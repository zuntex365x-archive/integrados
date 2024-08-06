Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Plan_telas
    Dim dt As New DataTable
    Dim ig As New DataTable
    Dim cp As New DataTable
    Dim cc As New DataTable
    Dim cn As New DataTable
    Dim qt As New DataTable
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection
    Dim inicio As Date
    Dim det As New DataTable
  
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        jg.Width = Me.Width - 30
        jg.Height = Me.Height - 100
        crea_dataTtable()
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM CPO LEFT JOIN CPO_D ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
    End Sub
    Private Sub procesa()
        Label1.Visible = True
        go.Visible = False
        cpos_abiertos()
        llena_consumos()
        crea_encabezados()
        ingresos()
        consumo()
        final()
        fg.ScrollBars = ScrollBars.Both
        to_excel.Visible = True
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub cpos_abiertos()
        strsql = "SELECT CPO_D.*,CPO.CLIENTE,TOTAL AS PEDIDAS,(SELECT SUM(TOTAL) FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR) AS CORTADAS, (SELECT TOP(1) SEW_PLAN FROM WIP0 WHERE WIP0.CPO = CPO_D.CPO AND WIP0.ESTILO = CPO_D.ESTILO AND WIP0.COLOR = CPO_D.COLOR) AS F_COSTURA FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND CPO.CLIENTE = '" & cliente.Text & "' ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(cp, strsql, cnn)
    End Sub
    Private Sub llena_consumos()
        strsql = "SELECT * ,DESCRIPCION FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO_CPO + COLOR_CPO IN (SELECT ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(cn, strsql, cnn)
    End Sub
    Private Sub consumo()
        Dim dr As DataRow
        Dim cinco As Decimal
        Dim pedido As Decimal
        Dim fcostura As Date
        Dim st As String
        Dim f As Integer
        Dim r As Integer
        Dim dd As DataRow()
        Dim dw As DataRow
        Dim unidades As Integer
        Dim cortadas As Integer
        Dim j As Integer = 0
        Dim fct As Date
        Dim row As DataRow
        jg.Rows.Count = cp.Rows.Count * 3
        jg.Rows(0).Height = 30
        jg.ClearFilter()
        For Each dr In cp.Rows
            pedido = dr("PEDIDAS")
            cinco = pedido * 0.05
            Try
                cortadas = dr("CORTADAS")
            Catch ex As Exception
                cortadas = 0
            End Try
            unidades = pedido - cortadas
            Try
                fcostura = dr("F_COSTURA")
                fcostura = fcostura.AddDays(-15)
                fct = dr("F_COSTURA")
            Catch
                fcostura = inicio
                fct = inicio
            End Try

            If unidades > cinco Then
                dd = cn.Select("ESTILO_CPO = '" & dr("ESTILO") & "' AND COLOR_CPO = '" & dr("COLOR") & "'")
                If dd.Length > 0 Then
                    For Each dw In dd
                        st = dw("CODIGO") + dw("COLOR_TELA")
                        f = fg.FindRow(st, 1, 0, False)
                        If f > 0 Then
                            If fcostura < CDate(fg(0, 5)) Then
                                fcostura = CDate(fg(0, 5))
                            End If
                            If fcostura > CDate(fg(0, 20)) Then
                                fcostura = CDate(fg(0, 20))
                            End If
                            r = DateDiff(DateInterval.Day, inicio, fcostura)
                            r = Fix(r / 7) + 5
                            fg(f + 1, r) = fg(f + 1, r) + (dw("LIBRAS") * unidades)
                            ' ============================ LLENA jg ======================
                            row = det.NewRow()
                            row("CODIGO") = dw("CODIGO")
                            row("DESCRIPCION") = dw("DESCRIPCION")
                            row("COLOR_TELA") = dw("COLOR_TELA")
                            row("CPO") = dr("CPO")
                            row("ESTILO") = dr("ESTILO")
                            row("COLOR") = dr("COLOR")
                            row("PEDIDO") = pedido
                            row("CORTADAS") = cortadas
                            row("UNIDADES") = pedido - cortadas
                            row("FCOR") = fct
                            row("FCOS") = fcostura
                            row("C_UNIT") = dw("LIBRAS")
                            row("C_TOT") = dw("LIBRAS") * unidades
                            det.Rows.Add(row)

                            j = j + 1
                            jg(j, 1) = dw("CODIGO")
                            jg(j, 2) = dw("DESCRIPCION")
                            jg(j, 3) = dw("COLOR_TELA")
                            jg(j, 4) = dr("CPO")
                            jg(j, 5) = dr("ESTILO")
                            jg(j, 6) = dr("COLOR")
                            jg(j, 7) = pedido
                            jg(j, 8) = cortadas
                            jg(j, 9) = pedido - cortadas
                            jg(j, 10) = fct
                            jg(j, 11) = fcostura
                            jg(j, 12) = dw("LIBRAS")
                            jg(j, 13) = dw("LIBRAS") * unidades
                        End If
                    Next
                End If
            End If
        Next
        jg.Rows.Count = j + 1
        jg.Sort(SortFlags.Ascending, 3)
        jg.Sort(SortFlags.Ascending, 1)
    End Sub
  
    Private Sub crea_encabezados()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim iv As New DataTable
        fg.Rows.Count = 1
        Dim l As Integer = 1
        Dim i As Integer
        Dim j As Integer
        Dim hoy As Date = Today
        Dim buscar As String
        Dim dw As DataRow = Nothing
        Dim libras As Decimal
        Dim quita As Decimal
        Dim strsql As String = "SELECT DISTINCT CONSUMO_TELA.CODIGO,COLOR_TELA, DESCRIPCION  FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE  ESTILO_CPO + COLOR_CPO IN (SELECT ESTILO + COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND CLIENTE = '" & cliente.Text & "') ORDER BY COLOR_TELA,CONSUMO_TELA.CODIGO"
        llena_tablas(dt, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR,SUM((PESO/YARDAS_I)*YARDAS) AS LIBRAS FROM ROLLOS  WHERE CLIENTE = '" & cliente.Text & "' AND YARDAS > 0 AND TIPO = 'TELA' GROUP BY CODIGO,COLOR ORDER BY CODIGO,COLOR"
        llena_tablas(iv, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR,SUM((ROLLOS.PESO/YARDAS_I)*ROLLOS.YARDAS) AS LIBRAS  FROM REQ_D LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE DESPACHADO = 'N' AND CLIENTE = '" & cliente.Text & "' GROUP BY CODIGO,COLOR ORDER BY COLOR,CODIGO"
        llena_tablas(qt, strsql, cnn)
        For Each dr In dt.Rows
            fg.Rows.Count = fg.Rows.Count + 5
            For i = l To l + 3
                fg(i, 0) = dr("CODIGO") + dr("COLOR_TELA")
                fg(i, 1) = dr("CODIGO")
                fg(i, 2) = dr("DESCRIPCION")
                fg(i, 3) = dr("COLOR_TELA")
            Next
            buscar = "CODIGO + COLOR = '" & dr("CODIGO") + dr("COLOR_TELA") & "'"
            busca(iv, buscar, dw)
            Try
                libras = dw("LIBRAS")
            Catch
                libras = 0
            End Try

            buscar = "CODIGO + COLOR = '" & dr("CODIGO") + dr("COLOR_TELA") & "'"
            busca(qt, buscar, dw)
            Try
                quita = dw("LIBRAS")
            Catch
                quita = 0
            End Try
            libras = libras - quita
            fg(l, 4) = "INV.INICIAL"
            fg(l, 5) = libras
            fg(l + 1, 4) = "CONSUMO"
            fg(l + 2, 4) = "INGRESOS"
            fg(l + 3, 4) = "INV.FINAL"
            For j = 5 To 20
                fg.SetCellStyle(l + 3, j, "amarillo")
            Next
            l = l + 5
        Next
        l = hoy.DayOfWeek()
        hoy = hoy.AddDays(-l + 1)
        inicio = hoy
        fg(0, 5) = hoy
        For i = 1 To 15
            hoy = hoy.AddDays(7)
            fg(0, i + 5) = hoy
        Next
    End Sub
    Private Sub ingresos()
        Dim ig = New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT CODIGO,COLOR,OFECHA,SUM(LIBRAS) AS LIBRAS  FROM FPO WHERE CLIENTE = '" & cliente.Text & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND RECIBIDAS = 0 GROUP BY CODIGO,COLOR,OFECHA ORDER BY CODIGO,COLOR,OFECHA"
        Dim f As Integer
        Dim st As String = ""
        Dim r As Integer
        Dim ofecha As Date
        llena_tablas(ig, strsql, cnn)
        For Each dr In ig.Rows
            st = dr("CODIGO") + dr("COLOR")
            f = fg.FindRow(st, 1, 0, False)
            If f > 0 Then
                ofecha = dr("OFECHA")
                If ofecha < CDate(fg(0, 5)) Then
                    ofecha = CDate(fg(0, 5))
                End If
                If ofecha > CDate(fg(0, 20)) Then
                    ofecha = CDate(fg(0, 20))
                End If
                r = DateDiff(DateInterval.Day, inicio, ofecha)
                r = (r / 7) + 5
                fg(f + 2, r) = fg(f + 2, r) + dr("LIBRAS")
            Else
                f = 11
            End If
        Next
    End Sub

    Private Sub final()
        Dim i As Integer
        Dim j As Integer
        For i = 1 To fg.Rows.Count - 1 Step 5
            fg(i + 3, 5) = fg(i, 5) - fg(i + 1, 5) + fg(i + 2, 5)
            If fg(i + 3, 5) < 0 Then
                fg.SetCellStyle(i + 3, 5, "rojo")
            End If
            For j = 6 To 20
                fg(i, j) = fg(i + 3, j - 1)
                fg(i + 3, j) = fg(i, j) - fg(i + 1, j) + fg(i + 2, j)
                If fg(i + 3, j) < 0 Then
                    fg.SetCellStyle(i + 3, j, "rojo")
                End If
            Next
        Next
    End Sub
    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        setea_fg()
        go.Visible = False
        buscador.Visible = True
        Cursor = Cursors.WaitCursor
        revisa_consumo()
        procesa()
        cliente.Enabled = False
        Cursor = Cursors.Default
    End Sub
  
    Private Sub a_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Plan_Tela " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        a_excel(fg, hora, ok)
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Print_fg()
    End Sub
    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String

        fecha = Format(Now, "dd/MMM/yyy HH:mm")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, "Plan de Costura al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", Format(Now, "HH:mm"))
    End Sub

    Private Sub busca(ByRef tabla As DataTable, ByRef buscar As String, ByRef en As DataRow)
        Dim dd As DataRow()
        en = Nothing
        dd = tabla.Select(buscar)
        If dd.Length > 0 Then
            en = dd(0)
        End If
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        to_excel.Visible = False
        to_excel1.Visible = False
        cliente.Enabled = True
        buscador.Visible = False
        setea_fg()
        go.Visible = True
        fg.Visible = True
        jg.Visible = False
        cliente.Focus()
    End Sub

  
    Private Sub buscador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscador.Click
        fg.Visible = False
        jg.Visible = True
        to_excel1.Visible = True
        to_excel.Visible = False

    End Sub

    Private Sub to_excel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel1.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Consumo_tela " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        a_excel(jg, hora, ok)
    End Sub
    Private Sub revisa_consumo()
        Dim dt As New DataTable()
        Dim mala As String = "Los siguientes Estilos - Colores no tienen Consumo !!!" + vbLf
        Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND CLIENTE = '" & cliente.Text & "' AND  CPO.CPO = CPO_D.CPO AND (ESTILO + COLOR NOT IN (SELECT DISTINCT ESTILO_CPO+COLOR_CPO FROM CONSUMO_TELA))"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            For Each dr In dt.Rows
                mala = mala + dr("ESTILO") + vbTab + vbTab + dr("COLOR") + vbLf
            Next
            MsgBox(mala, MsgBoxStyle.Critical, "Antes de Ejecutar la consulta Por Favor Ingrese los Consumos")
        End If
    End Sub

    Private Sub crea_dataTtable()
        det = New DataTable
        ' Crea_columnas
        det.Columns.Add("CODIGO", GetType(String))
        det.Columns.Add("DESCRIPCION", GetType(String))
        det.Columns.Add("COLOR_TELA", GetType(String))
        det.Columns.Add("CPO", GetType(String))
        det.Columns.Add("ESTILO", GetType(String))
        det.Columns.Add("COLOR", GetType(String))
        det.Columns.Add("PEDIDO", GetType(Decimal))
        det.Columns.Add("CORTADAS", GetType(Decimal))
        det.Columns.Add("UNIDADES", GetType(Decimal))
        det.Columns.Add("FCOR", GetType(DateTime))
        det.Columns.Add("FCOS", GetType(DateTime))
        det.Columns.Add("C_UNIT", GetType(Decimal))
        det.Columns.Add("C_TOT", GetType(Decimal))
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        If f > 0 Then
            If fg(f, 1) <> "" Then
                Dim form As New Plan_telas_1
                form.cod.Text = fg(f, 1)
                form.cli.Text = cliente.Text
                form.des.Text = fg(f, 2)
                form.col.Text = fg(f, 3)
                form.cpo = det
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub
End Class

