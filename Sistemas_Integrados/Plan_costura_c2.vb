Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Plan_costura_c2
    Dim dt As New DataTable
    Dim cp As New DataTable
    Dim cc As New DataTable
    Dim es As New DataTable
    Dim wp As New DataTable
    Dim se As New DataTable
    Dim fe As New DataTable
    Dim va As New DataTable
    Dim csc As New DataTable
    Dim met As New DataTable
    Dim pad As New DataTable
    Dim mat As New DataTable
    Dim dr As DataRow
    Dim strsql As String
    Dim secc As String = ""
    Dim cnn As New SqlClient.SqlConnection
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim filtro As New C1.Win.C1FlexGrid.ConditionFilter
    Dim con() As String
    Dim procesar As Boolean = True
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As Point
        fj.Width = Me.Width - 30
        fj.Height = Me.Height - 100
        C1SuperTooltip1.IsBalloon = True
        r.X = l - 165
        to_excel.Location = r
        r.X = l - 230
        imprime.Location = r
        r.X = Int(l / 2) - 343
        r.Y = Int(a / 2)
        conexiones(con)
        estilos()
        secciones()
        metas()
        vacaciones()
        setea_fg()
        setea_fj()
        crea_semanas()
    End Sub
    Private Sub crea_semanas()
        Dim hoy As Date = Today
        Dim d As Integer = hoy.DayOfWeek
        Dim i As Integer
        If d = 0 Then
            cierre.Items.Add(Format(Today, "dd/MM/yyyy"))
        Else
            hoy = hoy.AddDays(7 - d)
        End If
        For i = 1 To 5
            cierre.Items.Add(Format(hoy, "dd/MM/yyyy"))
            hoy = hoy.AddDays(7)
        Next i
        cierre.SelectedIndex = 0
    End Sub
    Private Sub setea_fj()
        fj.Rows.Count = 1
        fj.Rows(0).Height = 30
    End Sub
    Private Sub procesa()
        fg.ScrollBars = ScrollBars.None
        cpos_abiertos()
        cortes_cpo()
        wip()
        cpos_sc()
        en_proceso()
        materiales()
        crea_nuevos_cortes()
        proyecciones()
        procesos_adicionales()
        busca_procesos_adicionales()
        busca_materiales()
        imprime.Visible = True
        to_excel.Visible = True
        calcula_fecha_produccion()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub cpos_abiertos()
        strsql = "SELECT CPO_D.*,CPO.CLIENTE,TOTAL AS PEDIDAS,0 AS CORTADAS, 0 AS PRODUCIDAS , PRIORIDAD, PLAN_COSTURA_CP.SECCION AS SECC, DIFICULTAD, CATEGORIA, SUB_CATEGORIA FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN PLAN_COSTURA_CP ON PLAN_COSTURA_CP.CPO = CPO_D.CPO AND PLAN_COSTURA_CP.ESTILO = CPO_D.ESTILO AND PLAN_COSTURA_CP.COLOR = CPO_D.COLOR LEFT JOIN PLAN_COSTURA_E ON CPO.CLIENTE = PLAN_COSTURA_E.CLIENTE AND CPO_D.ESTILO = PLAN_COSTURA_E.ESTILO WHERE ESTADO = 'A' and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(cp, con, strsql)
        Dim dr As DataRow
        dr = cp.Rows(0)
    End Sub
    Private Sub cortes_cpo()
        strsql = "SELECT CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR,CORTES_S.CORTE, CORTES_S.TOTAL AS PRESUP, CORTES.TOTAL  AS CORTADAS ,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND TIPO = '0') AS PRODUCIDAS, CORTES.*,PRIORIDAD,PLAN_COSTURA_C.PRODUCIDAS AS PROD_P,STATUS ,COMENTARIOS, O2, O3 FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN PLAN_COSTURA_C ON CORTES_S.CORTE = PLAN_COSTURA_C.CORTE LEFT JOIN ESTILOS ON CORTES_S.CLIENTE = ESTILOS.CLIENTE AND CORTES_S.ESTILO = ESTILOS.ESTILO WHERE CORTES_S.CPO + CORTES_S.ESTILO + CORTES_S.COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR"
        llena_tablas_con(cc, con, strsql)
    End Sub
    Private Sub estilos()
        strsql = "SELECT * FROM ESTILOS WHERE ESTILO IN (SELECT ESTILO FROM CPO_D  WHERE ESTADO = 'A')"
        llena_tablas_con(es, con, strsql)
    End Sub
    Private Sub wip()
        strsql = "SELECT * FROM WIP0 WHERE CPO + ESTILO + COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A' and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE()))"
        llena_tablas_con(wp, con, strsql)
    End Sub
    Private Sub cpos_sc()
        strsql = "SELECT * FROM PLAN_COSTURA_CP WHERE CPO + ESTILO + COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A' and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE()))"
        llena_tablas_con(csc, con, strsql)
    End Sub
    Private Sub metas()
        strsql = "SELECT * FROM SECCIONES_META LEFT JOIN SECCIONES ON SECCIONES_META.SECCION = SECCIONES.SECCION WHERE ACTIVA = 'S' AND FECHA_FINAL > = '" & Format(Today, "yyyy-MM-dd") & "'"
        llena_tablas(met, strsql, cnn)
    End Sub
    Private Sub procesos_adicionales()
        strsql = "SELECT * FROM CORTES_PA LEFT JOIN CORTES ON CORTES_PA.CORTE = CORTES.CORTE LEFT JOIN CORTES_PAR ON CORTES_PA.CORTE = CORTES_PAR.CORTE AND CORTES_PA.PROCESO = CORTES_PAR.PROCESO AND CORTES_PAR.TIPO = 'Envio' WHERE EXPORTADO = 'N' and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(pad, con, strsql)
    End Sub

    Private Sub materiales()
        strsql = "SELECT CORTES.CORTE,PREPARADA,DESPACHADA FROM CORTES LEFT JOIN REQUI ON CORTES.CORTE = REQUI.CORTE WHERE EXPORTADO <> 'S' AND (SELECT COUNT(FECHA) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) = 0 and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(mat, con, strsql)
    End Sub

    Private Sub secciones()
        strsql = "SELECT * FROM SECCIONES WHERE ACTIVA = 'S' ORDER BY SECCION"
        llena_tablas(se, strsql, cnn)
        For Each Me.dr In se.Rows
            secc = secc + dr("SECCION") + "|"
        Next
        fg.Cols("SEC").ComboList = secc
    End Sub
    Private Sub vacaciones()
        strsql = "SELECT * FROM SECCIONES_DESCANSO WHERE FECHA > = '" & Format(Today, "yyyy-MM-dd") & "'"
        llena_tablas(va, strsql, cnn)
    End Sub

    Private Sub en_proceso()
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim dg As DataRow
        Dim prod As Integer
        Dim l As Integer
        Dim t As String = ""
        Dim cortadas As Integer
        Dim cpo As String
        Dim estilo As String
        Dim colo As String
        Dim suma As Integer
        Dim destino As String
        Dim fentrega As Date
        Dim prod_plan As Integer
        Dim prioridad As Decimal
        Dim status As String
        Dim totalr As Integer
        Dim sumar As Integer = 1
        totalr = cc.Rows.Count
        fg.Rows.Count = totalr + 1
        l = 1
        For Each dr In cc.Rows
            cpo = dr("CPO")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            Try
                If (dr("O2") = 0) And (dr("O3")) = 0 Then
                    fg(l, "ART") = "N/A"
                End If
            Catch ex As Exception
                fg(l, "ART") = "N/A"
            End Try
            Try
                prod = dr("PRODUCIDAS")
            Catch ex As Exception
                prod = 0
            End Try
            Try
                cortadas = dr("PRESUP")
            Catch
                cortadas = 0
            End Try
            Try
                If dr("CORTADAS") > 0 Then
                    cortadas = dr("CORTADAS")
                End If
            Catch ex As Exception
            End Try
            Try
                prod_plan = dr("PROD_P")
            Catch
                prod_plan = 0
            End Try
            Try
                prioridad = dr("PRIORIDAD")
            Catch ex As Exception
                prioridades(cpo, estilo, colo, prioridad)
            End Try
            suma = prod
            If suma = 0 Then
                suma = cortadas
            End If
            fg(l, "DIF") = 100
            fg(l, "EMP") = dr("EMPRESA")
            'If dr("EMPRESA") > "1" Then
            '    Dim JJ As String
            '    JJ = "JSSUS"
            'End If
            dd = cp.Select("CPO = '" & cpo & "' AND  ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
            If dd.Length > 0 Then
                dg = dd(0)
                destino = dg("DESTINO")
                fentrega = dg("F_ENTREGA")
                dg("CORTADAS") = dg("CORTADAS") + suma
                dg("PRODUCIDAS") = dg("PRODUCIDAS") + prod
                Try
                    fg(l, "CA1") = dg("CATEGORIA")
                    fg(l, "CA2") = dg("SUB_CATEGORIA")
                    fg(l, "DIF") = CInt(dg("DIFICULTAD"))
                Catch ex As Exception
                End Try
            Else
                destino = ""
            End If
            If prod_plan = cortadas Then
                prod = prod_plan
            End If
            Try
                status = dr("STATUS")
            Catch ex As Exception
                status = "A"
            End Try
            If prod = 0 And status = "A" Then
                fg(l, "SEC") = dr("SECCION")
                fg(l, "PRI") = prioridad
                fg(l, "CLI") = dr("CLIENTE")
                fg(l, "CPO") = cpo
                fg(l, "EST") = estilo
                fg(l, "COL") = colo
                fg(l, "DES") = destino
                fg(l, "COR") = dr("CORTE")
                fg(l, "FCO") = dr("FCORTE")
                fg(l, "PRE") = cortadas
                fg(l, "PRO") = prod_plan
                fg(l, "STA") = "A"
                fg(l, "TIP") = "C"
                fg(l, "COM") = dr("COMENTARIOS")
                Try
                    If dr("CORTADAS") = 0 Then
                        fg.SetCellStyle(l, fg.Cols.IndexOf("PRE"), "amarillo")
                    End If
                Catch ex As Exception

                End Try
                Try
                    fg(l, "SHO") = fentrega
                Catch ex As Exception
                End Try
                busca_wip(fg(l, "CPO"), fg(l, "EST"), fg(l, "COL"), fg(l, "SHD"), fg(l, "SHO"), fg(l, "SHW"))
                l = l + 1
            End If
            sumar = sumar + 1
        Next
        fg.Rows.Count = l - 1
    End Sub
    Private Sub crea_nuevos_cortes()
        Dim dr As DataRow
        Dim cortes As String
        Dim cuenta As Integer = 1
        Dim dif As Integer
        Dim pedidas As Integer
        Dim cortadas As Integer
        Dim fentrega As Date
        Dim destino As String
        Dim dd As DataRow()
        Dim dg As DataRow
        Dim l As Integer = fg.Rows.Count - 1
        For Each dr In cp.Rows
            pedidas = dr("PEDIDAS")
            cortadas = dr("CORTADAS")
            dif = pedidas - cortadas
            If dif > 0 Then
                agrega_linea(l)
                cortes = "P-" + Format(cuenta, "00000")
                fg(l, "SEC") = "NO ASIGNADA"
                fg(l, "PRI") = 999.99
                dd = csc.Select("CPO = '" & dr("CPO") & "' AND  ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
                If dd.Length > 0 Then
                    dg = dd(0)
                    fg(l, "SEC") = dg("SECCION")
                    fg(l, "PRI") = dg("PRIORIDAD")
                    fg(l, "COM") = dg("COMENTARIOS")
                End If
                fg(l, "CLI") = dr("CLIENTE")
                fg(l, "CPO") = dr("CPO")
                fg(l, "EST") = dr("ESTILO")
                fg(l, "COL") = dr("COLOR")
                fg(l, "DES") = dr("DESTINO")
                fg(l, "COR") = cortes
                fg(l, "FCO") = Today
                fg(l, "PRE") = dif
                fg(l, "PRO") = 0
                fg(l, "STA") = "A"
                fg(l, "TIP") = "F"
                fg(l, "EMP") = dr("EMPRESA")
                destino = dr("DESTINO")
                fentrega = dr("F_ENTREGA")
                Try
                    fg(l, "SHO") = fentrega
                Catch ex As Exception
                End Try
                Try
                    fg(l, "CA1") = dr("CATEGORIA")
                    fg(l, "CA2") = dr("SUB_CATEGORIA")
                    fg(l, "DIF") = CInt(dr("DIFICULTAD"))
                Catch ex As Exception
                    fg(l, "DIF") = 100
                End Try
                busca_wip(fg(l, "CPO"), fg(l, "EST"), fg(l, "COL"), fg(l, "SHD"), fg(l, "SHO"), fg(l, "SHW"))
                cuenta = cuenta + 1
            End If
        Next
    End Sub
    Private Sub proyecciones()
        Dim dr As DataRow
        Dim pro As New DataTable
        Dim cortes As String
        Dim cuenta As Integer = 1
        Dim l As Integer
        llena_tablas(pro, "SELECT * FROM PLAN_COSTURA_P", cnn)
        For Each dr In pro.Rows
            agrega_linea(l)
            cortes = "PROY" + Format(cuenta, "00000")
            fg(l, "SEC") = dr("SECCION")
            fg(l, "PRI") = dr("PRIORIDAD")
            fg(l, "CLI") = dr("CLIENTE")
            fg(l, "CPO") = dr("CPO")
            fg(l, "EST") = dr("ESTILO")
            fg(l, "COL") = dr("COLOR")
            fg(l, "DIF") = dr("DIFICULTAD")
            fg(l, "COR") = cortes
            fg(l, "FCO") = Today
            fg(l, "PRE") = dr("PRENDAS")
            fg(l, "PRO") = 0
            fg(l, "SHD") = dr("SHIP_DATE")
            fg(l, "STA") = "A"
            fg(l, "TIP") = "P"
            fg(l, "COM") = dr("COMENTARIOS")
            fin_de_semana(fg(l, "SHD"), fg(l, "SHW"))
            '  fg(l, "EMP") = dr("EMPRESA")
            cuenta = cuenta + 1
        Next
    End Sub
    Private Sub busca_wip(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByRef f_expor As Date, ByVal f_original As Date, ByRef weekend As Date)
        Dim dd As DataRow()
        Dim dg As DataRow
        dd = wp.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
        If dd.Length > 0 Then
            dg = dd(0)
            f_expor = dg("EXP_REV")
            If f_expor = CDate("1900-01-01") Then
                f_expor = f_original
            End If
        Else
            f_expor = f_original
        End If
        fin_de_semana(f_expor, weekend)
    End Sub
    Private Sub agrega_linea(ByRef l As Integer)
        l = fg.Rows.Count
        fg.Rows.Count = l + 1
    End Sub
    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit
        ' Validate amounts.
        If e.Col = 15 Then
            'Try
            Dim dec As Integer
            dec = Decimal.Parse(fg.Editor.Text())
            If dec > fg(e.Row, "PRE") Then
                MsgBox("Lo producido no puede ser mayor de lo Cortado !!!")
                e.Cancel = True
            End If
            'Catch
            '    MessageBox.Show("Este valor no es numérico")
            '    e.Cancel = True
            'End Try
        End If
        If e.Col = 17 Then
            If fg(e.Row, "STA") <> "P" Then
                e.Cancel = True
            End If
        End If
    End Sub

    'Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
    '    Dim colu As String = "01 05 23'"
    '    Dim co As String = Format(fg.Col, "00")
    '    If colu.IndexOf(co) < 0 Then
    '        Exit Sub
    '    End If
    '    If e.Control Then
    '        Select Case e.KeyCode
    '            Case Keys.Insert, Keys.C
    '                'copy
    '                System.Windows.Forms.Clipboard.SetDataObject(fg.Clip, True)
    '                Exit Select
    '            Case Keys.X
    '                'cut
    '                'System.Windows.Forms.Clipboard.SetDataObject(fg.Clip)
    '                'Dim rg As CellRange = fg.Selection
    '                'rg.Data = Nothing
    '                Exit Select
    '            Case Keys.V 'paste
    '                Dim data1 As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
    '                If data1.GetDataPresent(Type.GetType("System.String")) Then
    '                    fg.Select(fg.Row, fg.Col, fg.Rows.Count - 1, fg.Cols.Count - 1, False)
    '                    fg.Clip = CType(data1.GetData(Type.GetType("System.String")), String)
    '                    fg.Select(fg.Row, fg.Col, False)
    '                End If
    '        End Select
    '    End If
    'End Sub
    Private Sub calcula_fecha_produccion()
        Dim i As New Integer
        Dim sec As String = ""
        Dim hoy As Date = Today
        Dim prd As Date = Today
        Dim meta As Integer
        Dim metai As Integer
        Dim pr As New Integer
        Dim dif As New Decimal
        Dim dias As New Decimal
        Dim nmeta As Decimal = 0
        Dim d As Integer
        Dim s As Integer = fg.Cols.IndexOf("SEC")
        Dim p As Integer = fg.Cols.IndexOf("PRI")
        fg.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, p)
        fg.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, s)
        For i = 1 To fg.Rows.Count - 1
            If sec <> fg(i, "SEC") Then
                sec = fg(i, "SEC")
                busca_seccion(sec, metai)
                prd = Today
                ajusta_fecha_produccion(va, fg(i, "SEC"), Today, 0, prd)
            End If
            If fg(i, "PRO") < fg(i, "PRE") Then
                fg(i, "FCS") = prd
                pr = fg(i, "PRE") - fg(i, "PRO")
                fin_de_semana(fg(i, "FCS"), fg(i, "PWE"))
                If fg(i, "SHO") = Nothing Then
                    fg(i, "SHO") = fg(i, "PWE")     ' ============= PROYECCIONES 
                End If
                d = DateDiff(DateInterval.Day, fg(i, "SHO"), fg(i, "PWE"))
                fg(i, "WDE") = CInt(d / 7)
                meta = metai
                busca_meta(sec, prd, meta)
                nmeta = meta * (fg(i, "DIF") / 100)
                Try
                    dias = pr / nmeta
                Catch
                    dias = 0
                End Try

                ajusta_fecha_produccion(va, fg(i, "SEC"), fg(i, "FCS"), dias, prd)
                If fg(i, "FCS") > fg(i, "SHD") Then
                    fg.SetCellStyle(i, fg.Cols.IndexOf("FCS"), "amarillo")
                Else
                    fg.SetCellStyle(i, fg.Cols.IndexOf("FCS"), "blanco")
                End If
            End If
            ' calcula_fecha_corte(fg(i, "FCS"), fg(i, "FCO"))
        Next
    End Sub

    Private Sub busca_meta(ByVal sec As String, ByVal fprd As Date, ByRef meta As Integer)
        Dim dd As DataRow()
        Dim dg As DataRow
        dd = met.Select("SECCION = '" & sec & "'")
        If dd.Length > 0 Then
            For Each dg In dd
                If (fprd >= dg("FECHA_INICIAL")) And (fprd <= dg("FECHA_FINAL")) Then
                    meta = dg("META")
                End If
            Next
        End If
    End Sub
    Private Sub busca_seccion(ByVal sec As String, ByRef meta As Integer)
        Dim dr As DataRow
        Dim dd As DataRow()
        meta = 2000
        dd = se.Select("SECCION = '" & sec & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            meta = dr("META")
        End If
    End Sub
    Private Sub fin_de_semana(ByVal fecha As Date, ByRef weekend As Date)
        Dim d As Integer
        d = fecha.DayOfWeek
        d = 7 - d
        weekend = fecha.AddDays(d)
    End Sub
    Private Sub reordena()
        calcula_fecha_produccion()
    End Sub
    Private Sub a_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Plan_produccion " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        reordena()
        a_excel(fj, hora, ok)
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fj()
    End Sub
    Private Sub prioridades(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByRef prio As Decimal)
        Dim dd As DataRow()
        Dim dg As DataRow
        prio = 999.99
        dd = csc.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
        For Each dg In dd
            prio = dg("PRIORIDAD")
        Next
    End Sub
    Private Sub busca_procesos_adicionales()
        Dim dr As DataRow
        Dim i As Integer
        Dim c As Integer = fg.Cols.IndexOf("ART")
        Dim t As Integer = fg.Cols.IndexOf("COR")
        Dim p As Decimal
        For Each dr In pad.Rows
            i = fg.FindRow(dr("CORTE"), 1, t, False)
            If i > 0 Then
                Try
                    p = (dr("TOTAL_REC") * 100) / dr("TOTAL_ENV")
                Catch ex As Exception
                    p = 0
                End Try
                If p > 90 Then
                    fg(i, c) = "Completo"
                Else
                    fg(i, c) = dr("LUGAR")
                End If
            End If
        Next
    End Sub
    Private Sub busca_materiales()
        Dim dr As DataRow
        Dim i As Integer
        For Each dr In mat.Rows
            i = fg.FindRow(dr("CORTE"), 1, 7, False)
            If i > 0 Then
                If dr("DESPACHADA") Is DBNull.Value Then
                Else
                    If dr("DESPACHADA") = "S" Then
                        fg(i, 22) = "DESP."
                    Else
                        If dr("DESPACHADA") Is DBNull.Value Then
                        Else
                            If dr("PREPARADA") Is DBNull.Value Then
                            Else
                                If dr("PREPARADA") = "S" Then
                                    fg(i, 22) = "PREP."
                                End If
                            End If
                        End If

                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Print_fj()
        Dim pd As PrintDocument
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fj.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fj.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fj.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, "Plan de Produccion según exportacion " + cierre.Text + Chr(9) + Chr(9) + "Pagina {0}", Format(Now, "HH:mm"))
    End Sub
    Private Sub fg_AfterFilter(sender As Object, e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

    Private Sub subtotales()
        Dim c As Integer = fg.Cols.IndexOf("PRE")
        Try
            fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, c, "Gran TOTAL ---->")
        Catch
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        If procesar Then
            procesa()
            procesar = False
        End If
        acumula_datos()
        Cursor = Cursors.Default
        Button1.Visible = False
        cierre.Enabled = False
        R1.Visible = True
    End Sub

    Private Sub acumula_datos()
        Dim i As Integer
        Dim j As Integer = 1
        Dim d As String = cierre.Text
        Dim dia As Date = CDate(Mid(d, 7, 4) + "-" + Mid(d, 4, 2) + "-" + Mid(d, 1, 2))
        fj.Rows.Count = fg.Rows.Count
        For i = 1 To fg.Rows.Count - 1
            If fg(i, "SHD") <= d And Trim(fg(i, "SEC")) <> "SALDOS" Then
                fj(j, 1) = fg(i, "SEC")
                fj(j, 2) = fg(i, "CLI")
                fj(j, 3) = fg(i, "COR")
                fj(j, 4) = fg(i, "CPO")
                fj(j, 5) = fg(i, "EST")
                fj(j, 6) = fg(i, "COL")
                fj(j, 7) = fg(i, "PRE") - fg(i, "PRO")
                fj(j, 8) = fg(i, "SHD")
                fj(j, 9) = fg(i, "SHO")
                fj(j, 10) = fg(i, "FCS")
                j = j + 1
            End If
        Next
        fj.Rows.Count = j
    End Sub

    Private Sub R1_Click(sender As System.Object, e As System.EventArgs) Handles R1.Click
        R1.Visible = False
        Button1.Visible = True
        cierre.Enabled = True
        imprime.Visible = False
        to_excel.Visible = False
        setea_fj()
        cierre.Focus()
    End Sub
End Class

