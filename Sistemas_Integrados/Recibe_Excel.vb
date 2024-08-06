Imports System.IO
Imports C1.C1Excel
Imports C1.Win.C1FlexGrid
Public Class Recibe_Excel
    Dim cp As New DataTable
    Dim co As New DataTable
    Dim cnn As New SqlClient.SqlConnection
    Private Sub Recibe_Excel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_fg()
    End Sub
    Private Sub setea_fg()
        jg.Rows.Count = 1
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub


    Private Sub obtiene_archivo(ByRef ok As Boolean)
        Dim i As Integer
        Dim l As Integer = 1
        Dim dd As DataRow()
        setea_fg()
        ' choose file
        Dim dlg As New OpenFileDialog()
        dlg.DefaultExt = "xls"
        dlg.FileName = "*.xls"
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' clear everything
        _book.Clear()
        Try
            ' load book
            _book.Load(dlg.FileName)

            ' create one grid per sheet and add them to listbox
            Dim sheet As XLSheet
            For Each sheet In _book.Sheets
                ' load sheet into new grid
                Carga_hoja(jg, sheet, ok)
                Exit For
            Next
        Catch
        End Try
        llena_consultas()
        fg.Rows.Count = jg.Rows.Count + 1
        For i = 1 To jg.Rows.Count - 1
            dd = cp.Select("CPO ='" & jg(i, 1) & "' AND ESTILO = '" & jg(i, 2) & "' AND COLOR ='" & jg(i, 3) & "'")
            If dd.Length > 0 Then
                fg(l, 1) = jg(i, 1)
                fg(l, 2) = jg(i, 2)
                fg(l, 3) = jg(i, 3)
                fg(l, 4) = jg(i, 4)
                fg(l, 5) = jg(i, 5)
                fg(l, 6) = jg(i, 6)
                l = l + 1
            End If
        Next
        fg.Rows.Count = l
    End Sub

    '==============================================

    Dim _styles As Hashtable

    ' load sheet into grid
    Private Sub Carga_hoja(ByVal flex As C1FlexGrid, ByVal sheet As XLSheet, ByRef ok As Boolean)

        ' account for fixed cells
        Dim frows As Integer = flex.Rows.Fixed
        Dim fcols As Integer = flex.Cols.Fixed
        Dim t As Integer = 0
        ' copy dimensions
        flex.Rows.Count = sheet.Rows.Count '+ frows
        flex.Cols.Count = sheet.Columns.Count + fcols
        ok = False
        ' initialize fixed cells
        Dim r As Integer, c As Integer

        If flex.Cols.Count <> 7 Then
            MsgBox("Hoja Incompatible !!!!!", MsgBoxStyle.Critical, "Por favor Revise !!!!")
            Exit Sub
        End If
        ' Lee las Celdas
        For r = 1 To sheet.Rows.Count - 1
            For c = 0 To sheet.Columns.Count - 1
                ' get cell
                Dim cell As XLCell = sheet.GetCell(r, c)
                If (cell Is Nothing) Then
                    Continue For
                End If

                ' apply content
                If c = 4 Then
                    flex(r, c + fcols) = UCase(cell.Value)
                Else
                    flex(r, c + fcols) = cell.Value
                End If
            Next
        Next
        ok = True
    End Sub

    Private Sub revisa_excel(ByRef ok As Boolean)
        Dim i As Integer
        Dim dt As New DataTable
        Dim dd As DataRow()
        Dim strsql As String = "SELECT * FROM SECCIONES"
        llena_tablas(dt, strsql, cnn)
        For i = 1 To fg.Rows.Count - 1
            dd = dt.Select("SECCION = '" & fg(i, 5) + "'")
            If dd.Length = 0 Then
                ok = False
                fg.Rows(i).Style = fg.Styles("rojo")
            End If
        Next
    End Sub

    Private Sub to_excel_Click(sender As System.Object, e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        obtiene_archivo(ok)
        If ok Then
            revisa_excel(ok)
            If ok Then
                Graba.Visible = True
                to_excel.Visible = False
            Else
                MsgBox("Exiten inconsistencias en el archivo !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!")
            End If
        End If
      
    End Sub

    Private Sub Graba_Click(sender As System.Object, e As System.EventArgs) Handles Graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar los Datos?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            Label1.Visible = True
            actualiza_plan()
            Close()
        End If
    End Sub

    Private Sub llena_consultas()
        Dim strsql As String
        strsql = "SELECT CPO,ESTILO,COLOR FROM CPO_D WHERE ESTADO = 'A'"
        llena_tablas(cp, strsql, cnn)
        strsql = "SELECT CORTE FROM CORTES WHERE (EXPORTADO = 'N') AND ((SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) IS NULL)"
        llena_tablas(co, strsql, cnn)
    End Sub
    Private Sub fechas(ByVal f As String, ByRef fecha As Date, ByRef res As String, ByVal tp As String, ByVal ok As Boolean)
        If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
            res = Format(fecha, f)
            ok = True
        Else
            res = "01-01-1900"
        End If

        If res = "01-01-1900" And tp <> "G" Then
            res = Nothing
        End If
    End Sub

    Private Sub actualiza_plan()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim f_prod As String
        Dim seccion As String = ""
        Dim dd As DataRow()
        Dim obj As New empresas
        Dim min As String = "1900-01-01"
        Dim comentarios As String = ""

        obj = New empresas
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                Label1.Text = "Actualizando " & Format(i, "###,##0") & " de " & Format(fg.Rows.Count - 1, "###,##0")
                Label1.Refresh()
                f_prod = Format(fg(i, 6), "yyyy-MM-dd")
                If fg(i, 6) >= Today Then
                    ' If dd.Length > 0 Then
                    strsql = "UPDATE WIP0 SET SEW_PLAN = '" & f_prod & "' WHERE CPO = '" & fg(i, 1) & "' AND ESTILO = '" & fg(i, 2) & "' AND COLOR = '" & fg(i, 3) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                    If afectados = 0 Then
                        strsql = "INSERT INTO WIP0 (CPO,ESTILO,COLOR,TALLA,FAB_PLAN,FAB_ACTUAL,CUT_PLAN,CUT_ACTUAL,SEW_PLAN,SEW_ACTUAL,EXP_PLAN,EXP_REV,EXP_ACTUAL,COMENTARIOS,EX_CHAR,SER_PLAN,BOR_PLAN)" & _
                                          "VALUES ( '" & fg(i, 1) & "','" & _
                                                   fg(i, 2) & "','" & _
                                                   fg(i, 3) & "','XS','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   f_prod & "','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   comentarios & "','" & _
                                                   min & "','" & _
                                                   min & "','" & _
                                                   min & "')"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                    ' End If
                End If

                dd = co.Select("CORTE = '" & fg(i, 4) & "'")
                If dd.Length > 0 Then
                    seccion = fg(i, 5)
                    If seccion.Length > 0 Then
                        strsql = "UPDATE CORTES SET SECCION = '" & fg(i, 5) & "' WHERE CORTE = '" & fg(i, 4) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                End If
                Try
                    strsql = "INSERT INTO PLAN_COSTURA_X (CPO,ESTILO,COLOR,CORTE,SECCION,FECHA) VALUES ('" & fg(i, 1) & "','" & fg(i, 2) & "','" & fg(i, 3) & "','" & fg(i, 4) & "','" & fg(i, 5) & "','" & f_prod & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                Catch
                End Try


            Next
            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

End Class