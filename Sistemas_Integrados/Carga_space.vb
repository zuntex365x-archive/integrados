Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Carga_space
    Dim dt As New DataTable
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection
    Dim ar As New DataTable
    Dim es As New DataTable
    Dim au As New DataTable
    Dim obj As New empresas
    Dim area As String
    Dim archivo As String = ""
    Dim path As String = ""
    Dim fj As New C1.Win.C1FlexGrid.C1FlexGrid
    Dim fecha As Date
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        Dim ok As Boolean = False
        revisa_fecha(ok)
        If ok Then
            abre_archivo()
            lee_excel()
            go.Visible = False
            G1.Visible = True
        Else
            MsgBox("Esta fecha ya existe,", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
    End Sub
    Private Sub lee_excel()
        Dim i As Integer
        Dim se As String
        Dim j As Integer
        Dim l As Integer = 1
        Dim ano As Integer = CInt(Format(Today, "yyyy"))
        Dim fecha As Date
        busca_inicio(j)
        fg.Rows.Count = fj.Rows.Count - j + 1
        For i = j To fj.Rows.Count - 1
            fg(l, 1) = fj(i, 1)
            fg(l, 2) = fj(i, 2)
            fg(l, 3) = fj(i, 5)
            fg(l, 4) = fj(i, 6)
            fg(l, 5) = fj(i, 7)
            fg(l, 6) = fj(i, 9)
            se = CInt(fj(i, 13))
            semana_fecha(ano, se, fecha)
            fg(l, 7) = se
            fg(l, 8) = fecha
            l = l + 1
        Next
        regs.Visible = True
        regs.Text = "REGISTROS : " & CStr(fg.Rows.Count - 1)
    End Sub
    Private Sub busca_inicio(ByRef l As Integer)
        l = fg.Rows.Count - 1
        For l = 1 To fj.Rows.Count - 1
            If fj(l, 1) = "Customer" Then
                l = l + 1
                Exit Sub
            End If
        Next
    End Sub
    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        setea_fg()
        G1.Visible = False
        go.Visible = True
        fg.Visible = True
    End Sub
    Private Sub buscador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fg.Visible = False
    End Sub
    Private Sub abre_archivo()
        Dim ok As Boolean
        abrear.InitialDirectory = "C:\reportes"
        ok = True
        If abrear.ShowDialog = DialogResult.OK Then
            Try
                archivo = abrear.FileName
                fj.LoadExcel(archivo)
            Catch
            End Try
        Else
            MessageBox.Show("Aun no se ha seleccionado el archivo a utilizar", "No se selecciono archivo", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub G1_Click(sender As System.Object, e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_fecha(ok)
            If ok Then
                actualiza()
                Close()
            End If
        End If
    End Sub
    Private Sub revisa_fecha(ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim fec As String = Format(fechas.Value, "yyyy-MM-dd")
        ok = False
        llena_tablas(dt, "SELECT * FROM SPACE WHERE FECHA = '" & fec & "'", cnn)
        If dt.Rows.Count = 0 Then
            ok = True
        Else
            MsgBox("Ya existen datos grabados con esa fecha.", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If
    End Sub
    Private Sub revisa_datos(ByVal ok As Boolean)
        Dim dt As New DataTable
        Dim strsql As String = "SELECT * FROM SPACE WHERE FECHA = '" & Format(fechas.Value, "yyyy-MM-dd") & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count = 0 Then
            ok = True
        Else
            ok = False
        End If
    End Sub
    Private Sub actualiza()
        Dim afectados As Integer
        Dim i As Integer
        Dim strsql As String
        Dim fec As String = Format(fechas.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                strsql = "INSERT INTO SPACE (FECHA,EMPRESA,FPO,BATCH,FABRIC,COLOR,LIBRAS,ENTREGA,SEMANA) " & _
                             "VALUES ( '" & fec & "','" & _
                                          fg(i, 1) & "','" & _
                                          fg(i, 2) & "','" & _
                                          fg(i, 3) & "','" & _
                                          fg(i, 4) & "','" & _
                                          fg(i, 5) & "','" & _
                                          fg(i, 6) & "','" & _
                                          fg(i, 8) & "','" & _
                                          fg(i, 7) & " ')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

            Next

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

