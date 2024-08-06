Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Carga_upc_tnf
    Dim dt As New DataTable
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection
    Dim ar As New DataTable
    Dim es As New DataTable
    Dim au As New DataTable
    Dim area As String
    Dim archivo As String = ""
    Dim path As String = ""
    Dim fj As New C1.Win.C1FlexGrid.C1FlexGrid
    Dim fecha As Date
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        abre_archivo()
            lee_excel()
            go.Visible = False
            G1.Visible = True
    End Sub
    Private Sub lee_excel()
        Dim i As Integer
        Dim j As Integer
        Dim l As Integer = 1
        fg.Rows.Count = fj.Rows.Count - j + 1
        For i = 2 To fj.Rows.Count - 1
            If fj(i, 1) <> "" Then
                fg(l, 1) = fj(i, 1)
                fg(l, 2) = fj(i, 2)
                fg(l, 3) = fj(i, 3)
                l = l + 1
            End If
        Next
        fg.Rows.Count = l
        regs.Visible = True
        regs.Text = "REGISTROS : " & CStr(fg.Rows.Count - 1)
    End Sub
    Private Sub busca_inicio(ByRef l As Integer)
        l = fg.Rows.Count - 1
        For l = 1 To fj.Rows.Count - 1
            If UCase(fj(l, 1)) = "MATERIAL" Then
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
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            actualiza()
            Close()
        End If
    End Sub
    Private Sub actualiza()
        Dim afectados As Integer
        Dim i As Integer
        Dim strsql As String
        Dim cliente As String = "THE NORTH FACE"
        Dim emp As New empresas

        cnn.ConnectionString = emp.constr
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                Try
                    strsql = "INSERT INTO UPC_C (CLIENTE,MATERIAL,TALLA,UPC) " & _
                                 "VALUES ( '" & cliente & "','" & _
                                              fg(i, 1) & "','" & _
                                              fg(i, 2) & "','" & _
                                              fg(i, 3) & " ')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                Catch
                End Try

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

