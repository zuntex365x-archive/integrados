Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Plan_costura_c3
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
    Dim fpo As New DataTable
    Dim edi As New DataTable
    Dim dr As DataRow
    Dim strsql As String
    Dim secc As String = ""
    Dim cnn As New SqlClient.SqlConnection
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim filtro1 As New ConditionFilter
    Dim filtro2 As New ConditionFilter
    Dim filtro3 As New ConditionFilter
    Dim filtro4 As New ConditionFilter
    Dim con() As String
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        Dim r As Point
        C1SuperTooltip1.IsBalloon = True
        r.X = l - 165
        to_excel.Location = r
        r.X = l - 230
        imprime.Location = r
        r.X = Int(l / 2) - 343
        r.Y = Int(a / 2)
        ProgressBar1.Location = r
        'fg.DragMode = DragModeEnum.Manual
        'fg.DropMode = DropModeEnum.Manual
        conexiones(con)
        estilos()
        secciones()
        metas()
        vacaciones()
        llena_fpos()
        dias_corte()
        setea_fg()
    End Sub
    Private Sub procesa()
        fg.ScrollBars = ScrollBars.None
        Label1.Visible = True
        go.Visible = False
        ProgressBar1.Visible = True
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
        fg.ScrollBars = ScrollBars.Both
        Label1.Visible = False
        imprime.Visible = True
        to_excel.Visible = True
        calcula_fecha_produccion()
        ProgressBar1.Visible = False
        actualizado()
        fpos()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.ClearFilter()
        filtro1.AndConditions = True
        filtro1.Condition1.Operator = ConditionOperator.Contains
        filtro2.Condition1.Operator = ConditionOperator.Contains
        filtro3.Condition1.Operator = ConditionOperator.Contains
        filtro4.Condition1.Operator = ConditionOperator.Contains
        Try
            fg.Cols("COR").Filter = filtro1
            fg.Cols("CLI").Filter = filtro2
            fg.Cols("EST").Filter = filtro3
            fg.Cols("COL").Filter = filtro4
            fg.ApplyFilters()
        Catch
        End Try
    End Sub
    Private Sub cpos_abiertos()
        strsql = "SELECT CPO_D.*,CPO.CLIENTE,TOTAL AS PEDIDAS,0 AS CORTADAS, 0 AS PRODUCIDAS , PRIORIDAD, PLAN_COSTURA_CP.SECCION AS SECC, DIFICULTAD, CATEGORIA, SUB_CATEGORIA , DIAS_CORTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN PLAN_COSTURA_CP ON PLAN_COSTURA_CP.CPO = CPO_D.CPO AND PLAN_COSTURA_CP.ESTILO = CPO_D.ESTILO AND PLAN_COSTURA_CP.COLOR = CPO_D.COLOR LEFT JOIN PLAN_COSTURA_E ON CPO.CLIENTE = PLAN_COSTURA_E.CLIENTE AND CPO_D.ESTILO = PLAN_COSTURA_E.ESTILO LEFT JOIN ESTILOS_CORTE ON CPO_D.ESTILO = ESTILOS_CORTE.ESTILO  WHERE ESTADO = 'A'"
        llena_tablas_con(cp, con, strsql)
        Dim dr As DataRow

        dr = cp.Rows(0)
    End Sub
    Private Sub cortes_cpo()
        strsql = "SELECT CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR,CORTES_S.CORTE, CORTES_S.TOTAL AS PRESUP, CORTES.TOTAL  AS CORTADAS ,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND TIPO = '0') AS PRODUCIDAS, CORTES.*,PRIORIDAD,PLAN_COSTURA_C.PRODUCIDAS AS PROD_P,STATUS ,COMENTARIOS, O2, O3 , SALA, F_ICORTE FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN PLAN_COSTURA_C ON CORTES_S.CORTE = PLAN_COSTURA_C.CORTE LEFT JOIN ESTILOS ON CORTES_S.CLIENTE = ESTILOS.CLIENTE AND CORTES_S.ESTILO = ESTILOS.ESTILO WHERE CORTES_S.CPO + CORTES_S.ESTILO + CORTES_S.COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A') AND CORTES_S.TOTAL > 0 ORDER BY CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR"
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
    Private Sub dias_corte()
        strsql = "SELECT ESTILO,DIAS_CORTE FROM ESTILOS_CORTE WHERE ESTILO IN (SELECT DISTINCT ESTILO FROM CPO_D WHERE ESTADO = 'A' and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE()))"
        llena_tablas_con(edi, con, strsql)
    End Sub

    'Private Sub asuetos()
    '    strsql = "SELECT * FROM ASUETOS ORDER BY FECHA"
    '    llena_tablas(fe, strsql, cnn)
    'End Sub

    Private Sub vacaciones()
        strsql = "SELECT * FROM SECCIONES_DESCANSO WHERE FECHA > = '" & Format(Today, "yyyy-MM-dd") & "'"
        llena_tablas(va, strsql, cnn)
    End Sub
    Private Sub llena_fpos()
        strsql = "SELECT DISTINCT FPO,CPO,COLOR_CPO AS COLOR FROM ROLLOS LEFT JOIN CONSUMO_TELA ON ROLLOS.CODIGO = CONSUMO_TELA.CODIGO AND ROLLOS.COLOR = CONSUMO_TELA.COLOR_TELA WHERE YARDAS > 0 AND UPPER(CPO)<> 'STOCK' AND CPO IN (SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,COLOR_CPO"
        llena_tablas_con1(fpo, con, strsql)
        strsql = "SELECT  DISTINCT FPO,CPO,COLOR_CPO AS COLOR FROM FPO_CPO LEFT JOIN CONSUMO_TELA ON FPO_CPO.COLOR = CONSUMO_TELA.COLOR_TELA WHERE CPO IN (SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,COLOR"
        llena_tablas_con1(fpo, con, strsql)
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
        Dim dj As DataRow()

        totalr = cc.Rows.Count
        fg.Rows.Count = totalr + 1
        l = 1
        For Each dr In cc.Rows
            cpo = dr("CPO")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            ProgressBar1.Value = +((sumar * 100 / totalr))
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
                fg(l, "SECO") = dr("SALA")
                fg(l, "FGE") = dr("F_ICORTE")
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
                dj = es.Select("CLIENTE = '" & dr("CLIENTE") & "' AND  ESTILO = '" & dr("ESTILO") & "'")
                fg(l, "EMB") = embelishment(dj)
                busca_wip(fg(l, "CPO"), fg(l, "EST"), fg(l, "COL"), fg(l, "SHD"), fg(l, "SHO"), fg(l, "SHW"))
                l = l + 1
            End If
            sumar = sumar + 1
        Next
        fg.Rows.Count = l
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
        Dim dj As DataRow()
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
                If Not IsDBNull(dr("DIAS_CORTE")) Then

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
                dj = es.Select("CLIENTE = '" & dr("CLIENTE") & "' AND  ESTILO = '" & dr("ESTILO") & "'")
                fg(l, "EMB") = embelishment(dj)
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
        llena_tablas_con(pro, con, "SELECT * FROM PLAN_COSTURA_P")
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
    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        setea_fg()
        go.Visible = False
        Cursor = Cursors.WaitCursor
        procesa()
        Cursor = Cursors.Default
        re_calcula.Visible = False
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
        secciones()
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
                Dim JJ As String = fg(i, "CPO")
                If fg(i, "FCS") > fg(i, "SHD") Then
                    fg.SetCellStyle(i, fg.Cols.IndexOf("FCS"), "amarillo")
                Else
                    fg.SetCellStyle(i, fg.Cols.IndexOf("FCS"), "blanco")
                End If
            End If
            calcula_fecha_corte(edi, fg(i, "EST"), fg(i, "FCS"), fg(i, "FCO"))
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
        weekend = fecha.AddDays(7 - d)
    End Sub

    Private Sub reordena()
        calcula_fecha_produccion()
    End Sub

    Private Sub a_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Plan_costura " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        reordena()
        a_excel(fg, hora, ok)
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fg()
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
                If dr("PROCESO") = "Bordado" Then
                    c = fg.Cols.IndexOf("ART")
                Else
                    c = fg.Cols.IndexOf("ART1")
                End If
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

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        reordena()
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

    Private Sub actualizado()
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM PLAN_COSTURA_A WHERE CLAVE = 'ACTUALIZA'", cnn)
        For Each dr In dt.Rows
            Label1.Text = "Actualizado por : " + Trim(dr("USUARIO")) & " al " & Format(dr("FECHA"), "dd-MMM-yyyy  hh:mm:ss")
        Next
        Label1.Visible = True
    End Sub

    Private Sub fpos()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim i As Integer
        Dim p As Integer
        Dim fp As String = ""
        For i = 1 To fg.Rows.Count - 1
            dd = fpo.Select("CPO = '" & fg(i, 6) & "' AND COLOR = '" & fg(i, 11) & "'")
            If dd.Length > 0 Then
                fp = ""
                For Each dr In dd
                    p = fp.IndexOf(dr("FPO"))
                    If p < 0 Then
                        fp = fp + dr("FPO") + " "
                    End If
                Next
                fg(i, "FPO") = fp
            End If
        Next
    End Sub


End Class

