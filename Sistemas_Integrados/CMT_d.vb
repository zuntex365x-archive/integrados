Imports C1.Win.C1FlexGrid
Public Class CMT_d
    Public dt As New DataTable
    Public strsql As String
    Public fec As Date


    Private Sub Ventas01_d_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim tp As Decimal
        Dim l As Integer = 1
        Dim vex As Decimal
        dd = dt.Select("CLIENTE = '" & cliente.Text & "' AND F_EXP > = '" + Format(fec, "yyyy-MM") + "-01' AND F_EXP < = '" & Format(fec, "yyyy-MM-dd") & "'")
        fg.Rows.Count = dd.Length + 1
        For Each dr In dd
            tp = dr("TOTAL") - dr("TEXP")
            If tp > 0 Then
                fg(l, 1) = dr("CPO")
                fg(l, 2) = dr("ESTILO")
                fg(l, 3) = dr("COLOR")
                fg(l, 4) = dr("F_EXP")
                fg(l, 5) = tp
                fg(l, 6) = CDec(dr("VALOR")) / 12
                vex = tp * CDec(dr("VALOR")) / 12
                fg(l, 7) = vex
                l = l + 1
            End If
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        With fg
            fg.Subtotal(AggregateEnum.Sum, -1, -1, 5, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, -1, -1, 7, "Gran Total -->")
        End With
    End Sub
End Class