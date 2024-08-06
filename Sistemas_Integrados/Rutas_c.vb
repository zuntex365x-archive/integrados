Public Class Rutas_c
    Dim dt As New DataTable
    Dim cnn As New SqlClient.SqlConnection
    Private Sub Rutas_c_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler C4.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM ESTILOS ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
        C4.SelectedIndex = 0
        C4.Focus()
    End Sub

    Private Sub deshabilita()
        C4.Enabled = False
    End Sub
    Private Sub otro_cliente()
        C4.Enabled = True
        s1.Visible = True
        r1.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        otro_cliente()
    End Sub

    Private Sub procesa()
        llena_fg()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_fg()
        Dim l As Integer
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE =  '" & C4.Text & "' ORDER BY ESTILO"
        llena_tablas(dt, strSQL, cnn)
        l = dt.Rows.Count
        fg.Rows.Count = l + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = dr("DESCRIPCION")
            fg(l, 3) = True
            fg(l, 4) = dr("O2")
            fg(l, 5) = dr("O3")
            fg(l, 6) = dr("O4")
            fg(l, 7) = dr("O7")
            fg(l, 8) = dr("O8")
            fg(l, 9) = dr("PROGRAMA")
            l = l + 1
        Next
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            s1.Focus()
        End If
    End Sub 'keypressed

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub


    Private Sub s1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        Cursor = Cursors.WaitCursor
        S1.Visible = False
        r1.Visible = True
        xlsestilo.Visible = True
        deshabilita()
        procesa()
        fg.ScrollBars = ScrollBars.Both
        Cursor = Cursors.Default
        R1.Focus()
    End Sub

    Private Sub xlsestilo_Click(sender As Object, e As EventArgs) Handles xlsestilo.Click
        Dim ok As Boolean
        a_excel(fg, "C:\Reportes\ConsultaEstilos.xls", ok)
    End Sub
End Class