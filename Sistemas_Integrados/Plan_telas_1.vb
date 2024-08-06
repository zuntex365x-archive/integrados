Imports C1.Win.C1FlexGrid
Public Class Plan_telas_1
    Public cpo As New DataTable
    Dim fpo As New DataTable
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 50
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 3
    Dim strsql As String
    Dim dt As New DataTable
    Dim cnn As New SqlClient.SqlConnection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tm.SelectedIndex = 0
        setea_jg()
        consumo()
    End Sub

    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.SelectedIndexChanged
        Select Case tm.SelectedIndex
            Case 0
                setea_jg()
                consumo()
            Case 1
                setea_fg()
                fpos()
        End Select
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
    End Sub
    Private Sub consumo()
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim j As Integer = 1
        Dim busca As String = "CODIGO = '" & cod.Text & "' AND COLOR_TELA = '" & col.Text & "'"
        setea_jg()
        dd = cpo.Select(busca)
        jg.Rows.Count = dd.Length + 1
        For Each dr In dd
            ' ============================ LLENA jg ======================
            jg(j, 1) = dr("CPO")
            jg(j, 2) = dr("ESTILO")
            jg(j, 3) = dr("COLOR")
            jg(j, 4) = dr("PEDIDO")
            jg(j, 5) = dr("CORTADAS")
            jg(j, 6) = dr("UNIDADES")
            jg(j, 7) = dr("FCOR")
            jg(j, 8) = dr("FCOS")
            jg(j, 9) = dr("C_UNIT")
            jg(j, 10) = dr("C_TOT")
            j = j + 1
        Next
        jg.Sort(SortFlags.Ascending, 1)
        jg.Sort(SortFlags.Ascending, 8)

    End Sub
    Private Sub fpos()
        Dim ig = New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT *   FROM FPO WHERE CLIENTE = '" & cli.Text & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND RECIBIDAS = 0  AND CODIGO = '" & cod.Text & "' AND COLOR = '" & col.Text & "' ORDER BY OFECHA "
        Dim l As Integer = 1
        Dim st As String = ""
        llena_tablas(ig, strsql, cnn)
        fg.Rows.Count = ig.Rows.Count + 1
        For Each dr In ig.Rows
            fg(l, 1) = dr("OFECHA")
            fg(l, 2) = dr("FPO")
            fg(l, 3) = dr("TEXTILERA")
            fg(l, 4) = dr("KNIT")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = dr("CPO")
            fg(l, 7) = dr("LIBRAS")
            l = l + 1
        Next
    End Sub

End Class
