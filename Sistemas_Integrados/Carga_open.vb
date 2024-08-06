Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Carga_open
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
    'Dim fj As New C1.Win.C1FlexGrid.C1FlexGrid
    Dim fecha As Date
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        fg.Rows.Count = 1
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
        Dim c As Integer
        Dim l As Integer = 1
        busca_inicio(j)
        fg.Rows.Count = fj.Rows.Count - j + 1
        fg.Cols.Count = fj.Cols.Count
        For i = j To fj.Rows.Count - 1
            For c = 1 To fj.Cols.Count - 1
                fg(l, c) = fj(i, c)

            Next
            l = l + 1
        Next
        regs.Visible = True
        regs.Text = "REGISTROS : " & CStr(fg.Rows.Count - 1)
    End Sub
    Private Sub busca_inicio(ByRef l As Integer)
        l = fg.Rows.Count - 1
        For l = 1 To fj.Rows.Count - 1
            If Trim(fj(l, 1)) = "Customer" Then
                'crea_columnas(l)
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
        Dim jap As New Lib_SI.util
        cnn.ConnectionString = jap.con_string(0)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE OPEN_ORDER "
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1

                strsql = "INSERT INTO OPEN_ORDER (C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,C31,C32,C33,C34,C35)  " &
                             "VALUES ( '" & fg(i, 1) & "','" &
                                          fg(i, 2) & "','" &
                                          fg(i, 3) & "','" &
                                          fg(i, 4) & "','" &
                                          fg(i, 5) & "','" &
                                          fg(i, 6) & "','" &
                                          fg(i, 7) & "','" &
                                          fg(i, 8) & "','" &
                                          fg(i, 9) & "','" &
                                          fg(i, 10) & "','" &
                                          fg(i, 11) & "','" &
                                          fg(i, 12) & "','" &
                                          fg(i, 13) & "','" &
                                          fg(i, 14) & "','" &
                                          fg(i, 15) & "','" &
                                          fg(i, 16) & "','" &
                                          fg(i, 17) & "','" &
                                          fg(i, 18) & "','" &
                                          fg(i, 19) & "','" &
                                          fg(i, 20) & "','" &
                                          fg(i, 21) & "','" &
                                          fg(i, 22) & "','" &
                                          fg(i, 23) & "','" &
                                          fg(i, 24) & "','" &
                                          fg(i, 25) & "','" &
                                          fg(i, 26) & "','" &
                                          fg(i, 27) & "','" &
                                          fg(i, 28) & "','" &
                                          fg(i, 29) & "','" &
                                          fg(i, 30) & "','" &
                                          fg(i, 31) & "','" &
                                          fg(i, 32) & "','" &
                                          fg(i, 33) & "','" &
                                          fg(i, 34) & "','" &
                                          fg(i, 35) & "')"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

            Next

            strsql = "UPDATE OPEN_ORDER_1 SET USUARIO = '" & obj.usuario & "', FECHA = GETDATE() WHERE CLAVE = 'ACTUALIZA'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()


            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub
End Class

