Imports C1.Win.C1FlexGrid
Public Class CMT_g1
    Public dt As New DataTable
    Public strsql As String

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
        Dim valor As Decimal
        Dim l As Integer = 1
        dd = dt.Select(strsql)
        fg.Rows.Count = dd.Length + 1
        For Each dr In dd
            fg(l, 1) = dr("CPO")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("F_EXP")
            fg(l, 5) = dr("TOTAL")
            valor = (dr("CORTE") + dr("COSTURA") + dr("HILO") + dr("EMPAQUE") + dr("OTROS")) / 12
            valor = valor * dr("TOTAL")
            fg(l, 6) = valor

            l = l + 1
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        With fg
            For i = 5 To 6
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
            Next i
        End With
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\detalle_cmt.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
End Class