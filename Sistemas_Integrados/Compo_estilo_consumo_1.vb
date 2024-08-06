Public Class Compo_estilo_consumo_1
    Dim dt As New DataTable
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection
    Dim strsql As String
    Public cliente As String
    Public ok As Boolean = False
    Private Sub Compo_estilo_consumo_1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler codigo.KeyPress, AddressOf keypressed1
        strsql = "SELECT COMBO_TELAS.*,DESCRIPCION FROM COMBO_TELAS LEFT JOIN CODIGO_TELA ON COMBO_TELAS.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE ='" & cliente & "' AND COLOR_TELA = '" & color_tela.Text & "' ORDER BY CODIGO"
        llena_tablas(dt, strsql, cnn)
        llena_combos_d(codigo, dt, "CODIGO")
        Try
            codigo.SelectedIndex = 0
            codigo.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub codigo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles codigo.SelectedIndexChanged
        Dim dd As DataRow()
        dd = dt.Select("CODIGO = '" & codigo.Text & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            descripcion.Text = dr("DESCRIPCION")
        End If
    End Sub
    Private Sub codigo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        AutoCompletar(codigo, e)
    End Sub

    Private Sub S1_Click(sender As System.Object, e As System.EventArgs) Handles S1.Click
        ok = True
        Close()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(codigo.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Consumo_TextChanged(sender As Object, e As EventArgs) Handles Consumo.TextChanged

    End Sub
End Class