Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Crea_fpo_02
    Public fp As New DataTable
    Dim dt As New DataTable
    Dim gr As New DataTable
    Dim cp As New DataTable
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection
    Dim obj As New empresas
    Dim area As String
    Dim rgn As New CellRange
    Dim lb As Integer
    Dim tot_gre As Decimal = 0
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_datos()
        setea_fg()
        llena_fg()
        capacidades()
        setea_batches()
    End Sub
    Private Sub llena_datos()
        Dim strsql = "SELECT * FROM TEX_GREIGE LEFT JOIN TEX_LXB ON TEX_GREIGE.TELA = TEX_LXB.RELA"
        llena_tablas(gr, strsql, cnn)
        strsql = "SELECT * FROM TEX_MAQ"
        llena_tablas(cp, strsql, cnn)
    End Sub
    Private Sub setea_fg()
        Dim dr As DataRow
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        If fp.Rows.Count > 0 Then
            dr = fp.Rows(0)
            colores.Text = dr("COLOR")
        End If
    End Sub
  

    Private Sub llena_fg()
        Dim l As Integer
        Dim buscar As String
        Dim dr As DataRow
        Dim total As Decimal
        For Each dr In fp.Rows
            buscar = dr("CODIGO")
            l = fg.FindRow(buscar, 1, 1, False)
            If l = -1 Then
                l = fg.Rows.Count
                fg.Rows.Count = fg.Rows.Count + 1
                buscar = "TELA = '" & Mid(buscar, 1, 2) & "'"
                busca(gr, buscar, "GREIGE", fg(l, 8))
                If fg(l, 8) = 0 Then
                    fg(l, 8) = 11
                End If
                busca(gr, buscar, "LIBRAS_BATCH", fg(l, 9))
                If fg(l, 9) = 0 Then
                    fg(l, 9) = 25
                End If
            End If
            fg(l, 1) = dr("CODIGO")
            fg(l, 2) = dr("DESCRIPCION")
            fg(l, 3) = fg(l, 3) + dr("CONSUMO")
            fg(l, 4) = fg(l, 3) * (1 + (fg(l, 8) / 100))
            total = total + dr("CONSUMO")
        Next
        For l = 1 To fg.Rows.Count - 1
            fg(l, 5) = fg(l, 3) / total * 100
            fg(l, 6) = 0
            fg(l, 7) = 0
            tot_gre = tot_gre + fg(l, 4)
        Next
        subtotal()
    End Sub
    Private Sub subtotal()
        Dim i As Integer
        For i = 3 To 7
            If i <> 5 Then
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
            End If
            fg.Rows(fg.Rows.Count - 1).Height = 30
        Next
    End Sub
    Private Sub busca(ByVal tabla As DataTable, ByVal buscar As String, ByVal campo As String, ByRef en As String)
        Dim dd As DataRow()
        Dim dr As DataRow
        en = Nothing
        Try
            dd = tabla.Select(buscar)
            If dd.Length > 0 Then
                dr = dd(0)
                en = dr(campo)
            Else

            End If
        Catch
        End Try
    End Sub

    Private Sub capacidades()
        Dim l As Integer = 1
        Dim dr As DataRow
        Dim i As Integer
        fg.Rows(0).Height = 30
        For Each dr In cp.Rows
            mq.Cols(l).Visible = True
            mq(0, l) = dr("CAPACIDAD")
            l = l + 1
        Next
        For i = 1 To l - 1
            '  fg.Rows(i).Height = 30
            mq(1, i) = tot_gre / mq(0, i)
            mq(2, i) = 0
            mq(3, i) = 0
        Next
        For i = 0 To 3
            mq.Rows(i).Height = 30
        Next
        mq.Rows(1).AllowEditing = False
        mq.Rows(3).AllowEditing = False
    End Sub

    Private Sub setea_batches()
        Dim i As Integer
        Dim w As Integer
        Dim l As Integer = 2
        Dim de As String
        Dim rgn As CellRange
        Dim par As Boolean = False
        Dim col As String
        Dim x As String = "|GREIGE CALCULADO|GREIGE FPO|FINISH|"
        Dim st(3) As String
        Dim c As Integer = 1
        Dim fgc As Integer = fg.Rows.Count - 2
        st = Split(x, "|")
        bt.Rows.Count = 2
        bt.Cols(1).Visible = True
        bt(1, 1) = "BATCH"
        bt.Rows(0).AllowMerging = True
        bt.Rows(0).TextAlign = TextAlignEnum.CenterCenter
        bt.Rows(0).TextAlignFixed = TextAlignEnum.CenterCenter
        bt.AllowMerging = AllowMergingEnum.FixedOnly
        For i = 1 To 3
            If par Then
                col = "azul"
                par = False
            Else
                col = "naranja"
                par = True
            End If
            rgn = bt.GetCellRange(0, l, 0, l + fgc)
            rgn.Data = st(i)

            rgn = bt.GetCellRange(0, l, 1, l + fgc)
            rgn.Style = bt.Styles(col)

            For w = 1 To fgc
                bt.Cols(l).Visible = True
                de = Mid(fg(w, 2), 1, 10)
                bt(1, l) = de
                l = l + 1
            Next
        Next
        bt.Cols(l).Visible = True
        bt.Cols(l).DataType = GetType(Date)
        bt.Cols(l).TextAlign = TextAlignEnum.CenterCenter
        bt.Cols(l).TextAlignFixed = TextAlignEnum.CenterCenter
        bt.Cols(l).AllowEditing = True
        bt.Cols(l).Width = 120
        bt.Cols(l).Style = bt.Styles("blanco")
        bt(1, l) = "ENTREGA"
        lb = l
    End Sub
    Private Sub mq_afeteredit(ByVal sender As System.Object, ByVal e As RowColEventArgs) Handles mq.AfterEdit
        llena_batches()
        fg_cero()
    End Sub

    Private Sub llena_batches()
        Dim r As Integer = 2
        Dim r1 As Integer
        Dim i As Integer
        Dim j As Integer
        Dim n As Integer
        Dim c As Integer = 2
        Dim fgc As Integer = fg.Rows.Count - 2
        setea_batches()
        For i = 1 To mq.Cols.Count - 1
            mq(3, i) = mq(0, i) * mq(2, i)
            r1 = Int(mq(2, i))
            If r1 > 0 Then
                bt.Rows.Count = bt.Rows.Count + r1
                For j = 1 To r1
                    bt(r, 1) = r - 1
                    c = 2
                    rgn = bt.GetCellRange(r, fgc + 2, r, fgc + 1 + fgc)
                    rgn.Style = bt.Styles("celeste")
                    For n = 1 To fgc
                        bt(r, c) = mq(0, i) * (fg(n, 5) / 100)
                        bt(r, c + fgc + fgc) = 0
                        bt.Cols(c).AllowEditing = False
                        bt.Cols(c + fgc).AllowEditing = True
                        bt.Cols(c + fgc + fgc).AllowEditing = False
                        c = c + 1
                    Next
                    r = r + 1
                Next
            End If

        Next
    End Sub
    Private Sub bt_afeteredit(ByVal sender As System.Object, ByVal e As RowColEventArgs) Handles bt.AfterEdit
        llena_greige()
    End Sub

    Private Sub llena_greige()
        Dim c As Integer = fg.Rows.Count - 2
        Dim r As Integer = bt.RowSel
        Dim c1 As Integer = bt.ColSel
        Dim t As Integer = c1 - c - 1
        If c1 <> lb Then
            bt(r, c1 + c) = bt(r, c1) / (1 + (fg(t, 8) / 100))
            fg_cero()
        End If

    End Sub

    Private Sub fg_cero()
        Dim i As Integer
        Dim j As Integer
        Dim c As Integer = fg.Rows.Count - 2
        Dim p As Integer = (c * 2) + 1
        For i = 1 To fg.Rows.Count - 1
            fg(i, 6) = 0
            fg(i, 7) = 0
        Next i
        For i = 2 To bt.Rows.Count - 1
            For j = c + 2 To p
                fg(j - c - 1, 7) = fg(j - c - 1, 7) + bt(i, j)
                fg(j - c - 1, 6) = fg(j - c - 1, 6) + bt(i, j + c)
            Next j
        Next i
        subtotal()
    End Sub

End Class

