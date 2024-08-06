Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Public Class Fpo_cpo
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fpo.KeyPress, AddressOf keypressed1
        AddHandler colo.KeyPress, AddressOf keypressed3
        AddHandler cpo.KeyPress, AddressOf keypressed4
        setea_fg()
        llena_combos(fpo, "SELECT DISTINCT FPO FROM FPO ORDER BY FPO", "FPO")
        habilita()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_fg()
        Dim l As Integer
        Dim strsql As String = "SELECT DISTINCT CPO FROM FPO_CPO WHERE FPO = '" & fpo.Text & "' AND TIPO = 'TELA' AND COLOR = '" & colo.Text & "'"
        llena_tablas(dt, strsql, cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("CPO")
            l = l + 1
        Next
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub

    Private Sub selecciona_registro()
        Dim seguro As MsgBoxResult
        Dim i As Integer = fg.RowSel
        Try
            cpo.SelectedIndex = cpo.Items.IndexOf(fg(i, 1))
            seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                elimina_datos()
                llena_fg()
                deshabilita()
            End If
        Catch
        End Try

    End Sub
    Private Sub deshabilita()
        fpo.Enabled = False
        colo.Enabled = False
        cpo.Enabled = True
        graba.Visible = True
    End Sub
    Private Sub habilita()
        fpo.Enabled = True
        colo.Enabled = True
        cpo.Enabled = False
        graba.Visible = False
        fpo.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fpo.Text) <> "" Then
                colo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colo.Text) <> "" Then
                setea_fg()
                llena_fg()
                deshabilita()
                cpo.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        graba_datos()
        llena_fg()
        cpo.Focus()
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim knit As String
        strsql = "SELECT * FROM FPO WHERE FPO = '" & fpo.Text & "' AND COLOR = '" & colo.Text & "' AND TIPO = 'TELA'"
        llena_tablas(dt, strsql, cnn)


        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For Each dr In dt.Rows
                Try
                    knit = dr("KNIT")
                    strsql = "INSERT INTO FPO_CPO (FPO,TIPO,KNIT,COLOR,CPO) VALUES ('" & _
                                                        fpo.Text & "','TELA','" & _
                                                        knit & "','" & _
                                                        colo.Text & "','" & _
                                                        cpo.Text & "')"
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

    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
     
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM FPO_CPO WHERE FPO = '" & fpo.Text & "' AND TIPO = 'TELA' AND COLOR = '" & colo.Text & "' AND CPO = '" & cpo.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

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

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_fg()
        habilita()
    End Sub
    Private Sub fpo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles fpo.SelectedIndexChanged
        llena_combos(colo, "SELECT DISTINCT COLOR FROM FPO WHERE FPO = '" & fpo.Text & "' AND TIPO = 'TELA' ORDER BY COLOR ", "COLOR")
    End Sub

    Private Sub colo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles colo.SelectedIndexChanged
        llena_combos(cpo, "SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A' ORDER BY CPO", "CPO")
    End Sub
    Private Sub fpo_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fpo.KeyPress
        AutoCompletar(fpo, e)
    End Sub
    Private Sub colo_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colo.KeyPress
        AutoCompletar(colo, e)
    End Sub
    Private Sub cpo_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub
End Class