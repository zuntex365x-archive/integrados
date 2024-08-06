Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Public Class Lotes_cpo
    Dim cnn As New SqlClient.SqlConnection()
    Dim cliente As String = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cpo.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 40
        fg.Height = Me.Height - 330
        setea_jg()
        Try
            jg.RowSel = 1
            setea_datos(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub setea_jg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
        strsql = "SELECT * FROM FPO WHERE "
        llena_tablas(dt, "SELECT * FROM FPO WHERE TIPO = 'TELA' AND STATUS = 'ABIERTO'", cnn)
        jg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            jg(l, 1) = dr("FPO")
            jg(l, 2) = dr("KNIT")
            jg(l, 3) = dr("COLOR")
            jg(l, 4) = dr("LOTE")
            jg(l, 5) = dr("CLIENTE")
            l = l + 1
        Next
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_fg()
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer
        Dim strsql As String = "SELECT * FROM FPO_CPO WHERE FPO = '" & fpo.Text & "' AND KNIT = '" & knit.Text & "' AND COLOR = '" & colo.Text & "' AND LOTE = '" & lote.Text & "'"
        llena_tablas(dt, strsql, cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("FPO")
            fg(l, 2) = dr("KNIT")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("LOTE")
            fg(l, 5) = dr("CPO")
            l = l + 1
        Next
        cpo.Focus()
    End Sub


    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        If Trim(fpo.Text) = "" Or Trim(cpo.Text) = "" Then
            Exit Sub
        End If
        graba_datos()
        setea_fg()
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim clientes As String = ""
        Dim tipos As String = ""
        Dim obj As New empresas

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE FPO_CPO SET   USUARIO  = '" & obj.usuario & "', FECHA  = GETDATE() " & _
                                "WHERE FPO = '" & fpo.Text & "' AND KNIT = '" & knit.Text & "' AND COLOR = '" & colo.Text & "' AND LOTE = '" & lote.Text & "' AND CPO = '" & cpo.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()



            If afectados = 0 Then
                strsql = "INSERT INTO FPO_CPO (FPO,KNIT,COLOR,LOTE,CPO,CLIENTE,USUARIO,FECHA) VALUES ('" & _
                                                    fpo.Text & "','" & _
                                                    knit.Text & "','" & _
                                                    colo.Text & "','" & _
                                                    lote.Text & "','" & _
                                                    cpo.Text & "','" & _
                                                    cliente & "','" &
                                                    obj.usuario & "',GETDATE())"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

            End If

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
        Dim obj As New empresas
        Dim clientes As String = ""
      

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FPO_CPO WHERE FPO = '" & fpo.Text & "' AND KNIT = '" & knit.Text & "' AND COLOR = '" & colo.Text & "' AND LOTE = '" & lote.Text & "' AND CPO = '" & cpo.Text & "'"
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

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        setea_fg()
    End Sub
    Private Sub llena_cpos()
        Dim strsql As String = "SELECT DISTINCT CPO_D.CPO FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' AND CLIENTE = 'CP TEE' ORDER BY CPO_D.CPO "
        llena_combos(cpo, strsql, "CPO")
    End Sub
    ' ================================= AUTOCOMPLETAR ==============================

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub
    Private Sub setea_datos(ByVal l As Integer)
        cliente = jg(l, 5)
        fpo.Text = jg(l, 1)
        knit.Text = jg(l, 2)
        colo.Text = jg(l, 3)
        lote.Text = jg(l, 4)
        setea_fg()
        llena_fg()
        llena_cpos()
    End Sub
  
    Private Sub jg_Click(sender As System.Object, e As System.EventArgs) Handles jg.RowColChange
        Dim l As Integer = jg.RowSel
        If l < 1 Then
            Try
                l = 1
            Catch ex As Exception

            End Try
        End If
        setea_datos(l)
    End Sub
End Class