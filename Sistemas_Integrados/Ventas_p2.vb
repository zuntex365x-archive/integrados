Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class Ventas_p2
    Dim fe As Date
    Dim fo As Date
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 2
        fg.Rows(0).Height = 30
    End Sub
    Private Sub crea_columnas()
        Dim i As Integer
        Dim f As Date = fecha.Value
        Dim d As Integer = f.DayOfWeek - 1
        Dim c As Column = fg.Cols(1)
        Dim fec As String
        fe = f.AddDays(d * -1)
        fo = fe
        fg.Cols.Count = 29
        For i = 2 To 27
            fg.Cols(i).DataType = GetType(Decimal)
            fg.Cols(i).Format = "N2" ' "$###,##0.00"
            fg.Cols(i).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(i).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(i).Width = 100
            fec = Format(fe, "dd-MM-yyyy")
            fg.Cols(i).Caption = fec
            fg.Cols(i).Name = fec
            fe = fe.AddDays(7)
        Next
        fg(0, 28) = "TOTAL"
        fg.Cols(28).DataType = GetType(Integer)
        fg.Cols(28).Format = "N2" '$##,###,##0.00"
        fg.Cols(28).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(28).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(28).Width = 100
    End Sub

    Private Sub llena_grid()
        dt = New DataTable
        Dim dr As DataRow
        Dim ft As Date
        Dim fp As Date
        Dim dd As DataRow()
        Dim cliente As String
        Dim i As Integer
        Dim f As Integer
        Dim strsql As String
        Cursor = Cursors.WaitCursor
        strsql = "SELECT CLIENTE,CPO_D.*,CPO_COSTO.* ,0.00 AS E0, 0.00 AS E1,0.00 AS E2,0.00 AS E3,0.00 AS E4,0.00 AS E5,0.00 AS E6,0.00 AS E7,0.00 AS E8,0.00 AS E9, CPO_D.F_ENTREGA AS F_EXP, 0.00 AS TOT FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN CPO_COSTO ON CPO_D.CPO = CPO_COSTO.CPO AND CPO_D.ESTILO = CPO_COSTO.ESTILO AND CPO_D.COLOR = CPO_COSTO.COLOR WHERE ESTADO = 'A' "
        llena_tablas(dt, strsql, cnn)
        fecha_entrega(dt)
            For i = 2 To 27
            ft = CDate(fg(0, i))
            fp = ft.AddDays(6)
            dd = dt.Select("F_EXP > '" & Format(ft.AddDays(-1), "yyyy-MM-dd") & "' AND F_EXP < '" & Format(fp.AddDays(1), "yyyy-MM-dd") & "'")
            If dd.Length > 0 Then
                For Each dr In dd
                    If dr("TOT") > 0 Then
                        cliente = dr("CLIENTE")
                        f = fg.FindRow(cliente, 1, 1, False)
                        fg(f, i) = fg(f, i) + dr("TOT")
                        fg(f, 28) = fg(f, 28) + dr("TOT")
                    End If
                Next
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
    Private Sub fecha_entrega(ByRef dt As DataTable)
        Dim cnn As New SqlClient.SqlConnection
        Dim dg As New DataTable
        Dim je As New DataTable
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim tota As Decimal
        Dim i As Integer
        Dim strsql As String = "SELECT DISTINCT CPO+ESTILO+COLOR,CPO,ESTILO,COLOR,EXP_REV FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND EXP_REV > '1900-01-01' ORDER BY CPO,ESTILO,COLOR,EXP_REV DESC"
        llena_tablas(dg, strsql, cnn)
        strsql = "SELECT CPO,ESTILO,COLOR,SUM(XS) AS XS,SUM(S) AS S,SUM(M) AS M,SUM(L) AS L,SUM(XL) AS XL,SUM(XL2) AS XL2,SUM(XL3) AS XL3,SUM(XL4) AS XL4,SUM(XL5) AS XL5,SUM(XL6) AS XL6 FROM PACKING_D WHERE TIPO = 'Pri' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A' ) GROUP BY CPO,ESTILO,COLOR"
        llena_tablas(je, strsql, cnn)
        For Each dr In dt.Rows
            dd = dg.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                If dj("EXP_REV") > CDate("1900-01-01") Then
                    dr("F_EXP") = dj("EXP_REV")
                End If
            End If
            If dr("F_EXP") < CDate(fo) Then
                dr("F_EXP") = CDate(fo)
            End If
            dd = je.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                For i = 0 To 9
                    dr(i + 4) = dr(i + 4) - dj(i + 3)
                    If dr(i + 4) < 0 Then
                        dr(i + 4) = 0
                    End If
                Next
            End If
            For i = 0 To 9
                Try
                    tota = dr(i + 4) * dr(i + 26)
                Catch ex As Exception
                    tota = 0
                End Try
                dr(i + 36) = tota
                dr("TOT") = dr("TOT") + tota
            Next
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button3.Visible = True
        regresa.Visible = True
        crea_columnas()
        llena_clientes()
        llena_grid()
        subtotales()
        fecha.Enabled = False
    End Sub

    Private Sub subtotales()
        Dim i As Integer

        With fg
            For i = 2 To fg.Cols.Count - 1
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
        a_excel(fg, "c:\reportes\ventas_proyectadas_u.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        If c > 1 And f > 0 And f < fg.Rows.Count - 2 Then
            detalle_ventas(f, c)
        End If
    End Sub

    Private Sub detalle_ventas(ByVal f As Integer, ByVal c As Integer)
        Dim ft As Date
        Dim fp As Date
        Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 50
        Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
        Dim forma As New Ventas02_d()
        forma.Size = New Size(l, a - 20)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 160
        forma.dt = dt
        forma.cliente.Text = fg(f, 1)
        Try
            ft = CDate(fg(0, c))
            fp = ft.AddDays(6)
            forma.fecha.Text = "Del " & Format(ft, "dd/MMM/yyyy") & " al " & Format(fp, "dd/MMM/yyyy")
            forma.strsql = "F_EXP > '" & Format(ft.AddDays(-1), "yyyy-MM-dd") & "' AND F_EXP < '" & Format(fp.AddDays(1), "yyyy-MM-dd") & "' AND CLIENTE = '" & fg(f, 1) & "'"
            forma.ShowDialog()
        Catch
        End Try
    End Sub


End Class