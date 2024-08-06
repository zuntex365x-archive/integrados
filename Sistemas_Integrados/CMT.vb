Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class CMT
    Dim fe As Date
    Dim fo As Date
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim ex As New DataTable
        dt = New DataTable
        Dim dr As DataRow
        Dim fechae As Date
        Dim m As Integer
        Dim cliente As String
        Dim f As Integer
        Dim strsql As String
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim px As Decimal
        Dim tot As Decimal
        Dim vt As Decimal
        Cursor = Cursors.WaitCursor
        strsql = "SELECT CPO.CLIENTE,CPO_D.*, 0 as TEXP , (CORTE + COSTURA + HILO + EMPAQUE + OTROS) AS VALOR ,(SELECT TOP 1  EXP_REV FROM WIP0 WHERE CPO_D.CPO = WIP0.CPO AND CPO_D.ESTILO = WIP0.ESTILO AND CPO_D.COLOR = WIP0.COLOR) AS F_REV , CPO_D.F_ENTREGA AS F_EXP FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN ESTILOS ON CPO.CLIENTE = ESTILOS.CLIENTE AND CPO_D.ESTILO = ESTILOS.ESTILO WHERE ESTADO = 'A'"
        llena_tablas(dt, strsql, cnn)
        strsql = "SELECT  CPO,ESTILO,COLOR, SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) AS EXP FROM PACKING_D WHERE CPO + ESTILO + COLOR IN (SELECT CPO +ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A') AND TIPO = 'Pri'  GROUP BY CPO,ESTILO,COLOR"
        llena_tablas(ex, strsql, cnn)
        For Each dr In dt.Rows
            If IsDBNull(dr("F_REV")) = False Then
                If dr("F_REV") > CDate("1900-01-01") Then
                    dr("F_EXP") = dr("F_REV")
                End If
            End If
            fechae = dr("F_EXP")
            If fecha.Value.Year = fechae.Year Then
                cliente = dr("CLIENTE")
                f = fg.FindRow(cliente, 1, 1, False)
                If f > 0 Then
                    m = fechae.Month
                    px = 0
                    dd = ex.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
                    If dd.Length > 0 Then
                        dj = dd(0)
                        px = dj("EXP")
                        dr("TEXP") = px
                    End If
                    tot = dr("TOTAL") - px
                    If tot > 0 Then
                        vt = tot * (dr("VALOR") / 12)
                        fg(f, m + 1) = fg(f, m + 1) + vt
                        fg(f, 14) = fg(f, 14) + vt
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub llena_clientes()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            l = l + 1
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button3.Visible = True
        regresa.Visible = True
        llena_clientes()
        llena_grid()
        subtotales()
        fecha.Enabled = False
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        With fg
            For i = 2 To 14
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
            Next i
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_grid()
        fecha.Enabled = True
        Button1.Visible = True
        Button3.Visible = False
        regresa.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\CMT_proyectado.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        If c > 1 And f > 0 And f < fg.Rows.Count - 1 Then
            detalle_ventas(f, c)
        End If
    End Sub

    Private Sub detalle_ventas(ByVal f As Integer, ByVal c As Integer)
        Dim ft As Date
        Dim fp As String
        Dim forma As New CMT_d
        forma.dt = dt
        Try
            forma.cliente.Text = fg(f, 1)
            ft = CDate("2015-" + Format(c - 1, "00") + "-01")
            fp = UCase(Format(ft, "MMMMM") + " / " + fecha.Text)
            forma.fecha.Text = fp
            forma.fec = DateSerial(Year(ft), Month(ft) + 1, 0)
            forma.ShowDialog()
        Catch
        End Try
    End Sub

End Class