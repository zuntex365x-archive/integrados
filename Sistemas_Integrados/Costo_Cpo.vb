Imports System.Drawing.Printing
Imports C1.Win.C1FlexGrid
Public Class Costo_Cpo
    Dim cnn As New SqlClient.SqlConnection
    Dim te As New DataTable
    Dim ma As New DataTable
    Dim mo As New DataTable
    Dim ex As New DataTable
    Dim pr As New DataTable
    Dim pt As New DataTable
    Dim pm As New DataTable
    Dim cp As New DataTable
    Dim h As String = "########0.00"
    Dim t(10) As Integer
    Private Sub Costo_Cpo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 145
        rango.SelectedIndex = 0
        setea_fg()
    End Sub

    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        Dim busca As String = ""
        Dim strsql As String
        rangos(busca)
        strsql = " SELECT  CPO FROM CPO WHERE CLIENTE = '" & cliente.Text & "' AND DATEDIFF(MONTH,F_PEDIDO,GETDATE()) " & busca & " ORDER BY CPO"
        llena_combos(cpo, strsql, "CPO")
    End Sub
    Private Sub rangos(ByRef busca As String)
        busca = "< 7"
        Select Case rango.SelectedIndex
            Case 1
                busca = "< 13"
            Case 2
                busca = "> 0"
        End Select
    End Sub
    Private Sub setea_fg()
        Dim i As Integer
        fg.Rows.Count = 0
        fg.Cols.Count = 1
        fg.Rows.Count = 25
        fg.Rows(0).Height = 30
        fg.Rows(1).Height = 30
        fg.Rows(16).Height = 40
        fg(2, 0) = "Unidades Pedidas."
        fg(3, 0) = "Unidades Exportadas."
        fg(4, 0) = "DIFERENCIA"
        fg(6, 0) = "Fecha Exportacion CPO."
        fg(7, 0) = "Fecha Ultima Exportac."
        fg(8, 0) = "DIFERENCIA EN DIAS"
        fg.Cols(0).AllowMerging = True
        fg(10, 0) = "C O S T O S"
        fg(11, 0) = "Tela"
        fg(12, 0) = "Materiales"
        fg(13, 0) = "Mano de Obra"
        fg(14, 0) = "COSTOS TOTALES"
        fg(15, 0) = "Venta Total"
        fg(16, 0) = "APORTACION"
        fg(18, 0) = "COMPARATIVO"
        fg(19, 0) = "Tela Real"
        fg(20, 0) = "Tela Presup."
        fg(21, 0) = "DIFERENCIA"
        fg(22, 0) = "Materiales Real"
        fg(23, 0) = "Materiales Presup."
        fg(24, 0) = "DIFERENCIA"

        For i = 9 To 24
            If i < 16 Then
                fg.SetCellStyle(i, 0, fg.Styles("naranja"))
            Else
                fg.SetCellStyle(i, 0, fg.Styles("azul"))
            End If

        Next

        fg.SetCellStyle(16, 0, fg.Styles("oro"))
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        procesa_cpo()
        cliente.Enabled = False
        cpo.Enabled = False
        rango.Enabled = False
        S1.Visible = False
        R1.Visible = True
        to_excel.Visible = True
        impre.Visible = True
    End Sub

    Private Sub procesa_cpo()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim c As Integer
        Dim strsql As String = "SELECT * FROM CPO_D WHERE CPO = '" & cpo.Text & "'"
        llena_tablas(dt, strsql, cnn)
        ' llena_tablas(te, " SELECT ESTILO,COLOR,TMOVTO,SUM(LIBRAS*PRECIO) AS VALOR from DMOVTO LEFT JOIN CORTES ON DMOVTO.CORTE = CORTES.CORTE WHERE CORTES.CPO = '" & cpo.Text & "' GROUP BY ESTILO,COLOR,TMOVTO", cnn)

        llena_tablas(te, "SELECT DMOVTO.*,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,CODIGO FROM DMOVTO LEFT  JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO LEFT JOIN CORTES ON DMOVTO.CORTE = CORTES.CORTE WHERE DMOVTO.CORTE IN (SELECT CORTE FROM CORTES WHERE CPO = '" & cpo.Text & "' )", cnn)


        llena_tablas(ma, "SELECT ESTILO,COLOR,T_MOVTO,SUM(UNIDADES*COSTO) AS VALOR from D_MATERIAL LEFT JOIN CORTES ON D_MATERIAL.CORTE = CORTES.CORTE WHERE CORTES.CPO = '" & cpo.Text & "' GROUP BY ESTILO,COLOR,T_MOVTO", cnn)
        llena_tablas(mo, "SELECT * FROM ESTILOS WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO IN (SELECT DISTINCT ESTILO FROM CPO_D WHERE CPO ='" & cpo.Text & "')", cnn)
        llena_tablas(ex, "SELECT ESTILO,COLOR, SUM(XS) AS XS, SUM(S) AS S,SUM(M) AS M, SUM(L) AS L,SUM(XL) AS XL,SUM(XL2) AS XL2, SUM(XL3) AS XL3 , SUM(XL4) AS XL4 , SUM(XL5) AS XL5, SUM(XL6) AS XL6 FROM PACKING_D WHERE CPO = '" & cpo.Text & "' AND TIPO = 'Pri' GROUP BY ESTILO,COLOR", cnn)
        llena_tablas(pr, "SELECT * FROM CPO_COSTO WHERE CPO ='" & cpo.Text & "'", cnn)
        llena_tablas(pt, "SELECT * FROM CONSUMO_TELA WHERE ESTILO_CPO + COLOR_CPO IN (SELECT ESTILO + COLOR FROM CPO_D WHERE CPO ='" & cpo.Text & "')", cnn)
        llena_tablas(cp, "SELECT * FROM CPO_D WHERE CPO = '" & cpo.Text & "'", cnn)
        For Each dr In dt.Rows
            c = fg.Cols.Count
            fg.Cols.Count = c + 1
            fg(0, c) = Trim(dr("ESTILO"))
            fg(1, c) = Trim(dr("COLOR"))
            fg.Cols(c).Width = 250
            fg(2, c) = dr("TOTAL")
            fg(6, c) = dr("F_PROMETIDA")

            fg.SetCellStyle(0, c, fg.Styles("Fixed"))
            fg.SetCellStyle(1, c, fg.Styles("Fixed"))
            fg.SetCellStyle(4, c, fg.Styles("Fixed"))
            fg.SetCellStyle(8, c, fg.Styles("Fixed"))
            fg.SetCellStyle(9, c, fg.Styles("naranja"))
            fg.SetCellStyle(10, c, fg.Styles("naranja"))
            fg.SetCellStyle(14, c, fg.Styles("naranja"))
            fg.SetCellStyle(16, c, fg.Styles("oro"))
            fg.SetCellStyle(17, c, fg.Styles("azul"))
            fg.SetCellStyle(18, c, fg.Styles("azul"))
            fg.SetCellStyle(21, c, fg.Styles("azul"))
            fg.SetCellStyle(24, c, fg.Styles("azul"))
            fg.Cols(c).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        Next
        exportado()
    End Sub
    Private Sub exportado()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim c As Integer
        Dim estilo As String
        Dim colores As String
        Dim fec As Date
        Dim valor As Decimal
        Dim strsql As String = "SELECT ESTILO,COLOR,FECHA,SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) AS TOTAL FROM PACKING_D WHERE CPO = '" & cpo.Text & "' AND TIPO = 'Pri' GROUP BY ESTILO,COLOR,FECHA"
        llena_tablas(dt, strsql, cnn)
        For c = 1 To fg.Cols.Count - 1
            estilo = fg(0, c)
            colores = fg(1, c)
            fec = CDate("1900-01-01")
            dd = dt.Select("ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
            For Each dr In dd
                If dr("FECHA") > fec Then
                    fec = dr("FECHA")
                End If
                fg(3, c) = fg(3, c) + dr("TOTAL")
            Next
            fg(4, c) = fg(3, c) - fg(2, c)
            If fec > CDate("1900-01-01") Then
                fg(7, c) = fec
                fg(8, c) = DateDiff(DateInterval.Day, fec, fg(6, c))
            End If
            tela_mat_mo(estilo, colores, fg(11, c), fg(12, c), valor)
            valor = valor * fg(3, c)
            fg(13, c) = CDec(Format(valor, h))
            fg(14, c) = fg(11, c) + fg(12, c) + fg(13, c)
            precio(estilo, colores, fg(15, c))
            fg(16, c) = fg(15, c) - fg(14, c)
            presupuesto_tela(estilo, colores, valor)
            fg(20, c) = valor * fg(3, c)
            fg(20, c) = CDec(Format(fg(20, c), h))
            fg(19, c) = fg(11, c)
            fg(21, c) = fg(20, c) - fg(19, c)
            fg(22, c) = fg(12, c)
            fg(24, c) = fg(23, c) - fg(22, c)
            presupuesto_material(estilo, colores, valor)
        Next

    End Sub

    Private Sub rango_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rango.SelectedIndexChanged
        Dim busca As String = ""
        rangos(busca)
        Dim strsql As String = "SELECT DISTINCT CLIENTE FROM CPO WHERE DATEDIFF(MONTH,F_PEDIDO,GETDATE()) " & busca & " ORDER BY CLIENTE"
        llena_combos(cliente, strsql, "CLIENTE")
    End Sub

    Private Sub tela_mat_mo(ByVal estilo As String, ByVal colores As String, ByRef costo_tel As Decimal, ByRef costo_mat As Decimal, ByRef costo_mo As Decimal)
        Dim dt As New DataTable
        Dim dd As DataRow()
        Dim dr As DataRow
        costo_tel = 0
        costo_mat = 0
        costo_mo = 0
        Dim valor As Decimal = 0
        dd = te.Select("ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
        For Each dr In dd
            If dr("TMOVTO") > "3" Then
                costo_tel = costo_tel + (dr("LIBRAS") * dr("PRECIO"))
            Else
                costo_tel = costo_tel - (dr("LIBRAS") * dr("PRECIO"))
            End If
        Next

        dd = ma.Select("ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
        For Each dr In dd
            valor = dr("VALOR") * -1
            If dr("T_MOVTO") > 3 Then
                costo_mat = costo_mat + valor
            Else
                costo_mat = costo_mat - valor
            End If
        Next
        costo_tel = CDec(Format(costo_tel, h))
        costo_mat = CDec(Format(costo_mat, h))
        dd = mo.Select("CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo & "'")
        For Each dr In dd
            valor = dr("CORTE") + dr("COSTURA") + dr("HILO") + dr("EMPAQUE") + dr("OTROS")
            costo_mo = valor / 12
        Next
        costo_tel = CDec(Format(costo_tel, h))
        costo_mat = CDec(Format(costo_mat, h))
        costo_mo = CDec(Format(costo_mo, h))
    End Sub

    Private Sub precio(ByVal estilo As String, ByVal colores As String, ByRef precio As Decimal)
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim pc As DataRow
        Dim i As Integer
        precio = 0
        dd = ex.Select("ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            dd = pr.Select("ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
            If dd.Length > 0 Then
                pc = dd(0)
                For i = 0 To 9
                    If dr(i + 2) > 0 Then
                        precio = precio + (dr(i + 2) * pc(i + 3))
                    End If
                Next
            End If
        End If
        precio = CDec(Format(precio, h))
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        cpo.Enabled = True
        cliente.Enabled = True
        rango.Enabled = True
        S1.Visible = True
        R1.Visible = False
        to_excel.Visible = False
        impre.Visible = False
        setea_fg()
    End Sub
    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel.Click
        Dim path As String
        Dim ok As Boolean
        path = "c:\reportes\" + cpo.Text + Format(Today, "dd_MMM_yyyy") + ".xls"
        a_excel(fg, path, ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub impre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles impre.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 12, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 10, FontStyle.Italic)
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, "Costos CPO: " + cpo.Text + "  al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub presupuesto_tela(ByVal estilo As String, ByVal colores As String, ByRef prt As Decimal)
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim jj As DataRow()
        Dim jr As DataRow
        Dim codigo As String
        dd = pt.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & colores & "'")
        prt = 0
        For Each dr In dd
            codigo = dr("CODIGO")
            jj = te.Select("CODIGO = '" & codigo & "' AND PRECIO > 0", "PRECIO DESC")
            If jj.Length > 0 Then
                jr = jj(0)
                prt = jr("PRECIO") * dr("LIBRAS")
            End If
        Next
    End Sub

    Private Sub presupuesto_material(ByVal estilo As String, ByVal colores As String, ByRef prm As Decimal)
        Dim req As New DataTable
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim i As Integer
        Dim costo As Decimal
        ReDim t(10)

        dd = cp.Select("ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
        If dd.Length > 0 Then

            dr = dd(0)
            For i = 1 To 10
                t(i) = dr(i + 3)
            Next
        End If
        boms(cliente.Text, cpo.Text, estilo, colores, t, 1.02, req)
        For Each dr In req.Rows
            costo = dr("UNIDADES") * dr("COSTO")

        Next
    End Sub
End Class