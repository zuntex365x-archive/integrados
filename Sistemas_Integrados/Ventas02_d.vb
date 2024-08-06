Imports C1.Win.C1FlexGrid
Public Class Ventas02_d
    Public dt As New DataTable
    Public strsql As String
    Public tipo As String

    Private Sub Ventas01_d_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
        If tipo = "U" Then
            For i = 4 To 14
                fg.Cols(i).DataType = GetType(Decimal)
                fg.Cols(i).Format = "N0" ' "$###,##0.00"
                fg.Cols(i).TextAlign = TextAlignEnum.CenterCenter
                fg.Cols(i).TextAlignFixed = TextAlignEnum.CenterCenter
            Next
        End If

    End Sub

    Private Sub llena_grid()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim l As Integer = 1
        dd = dt.Select(strsql)
        fg.Rows.Count = dd.Length + 1
        For Each dr In dd
            fg(l, 1) = dr("CPO")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("E0")
            fg(l, 5) = dr("E1")
            fg(l, 6) = dr("E2")
            fg(l, 7) = dr("E3")
            fg(l, 8) = dr("E4")
            fg(l, 9) = dr("E5")
            fg(l, 10) = dr("E6")
            fg(l, 11) = dr("E7")
            fg(l, 12) = dr("E8")
            fg(l, 13) = dr("E9")
            fg(l, 14) = dr("TOT")
            fg(l, 15) = dr("F_EXP")
            l = l + 1
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        With fg
            For i = 4 To 14
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
            Next i
        End With
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\ventas_proyectadas_d_u.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
End Class