Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Plan_serigra
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
    Dim dr As DataRow
    Dim strsql As String
    Dim secc As String = ""
    Dim cnn As New SqlClient.SqlConnection
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim filtro As New C1.Win.C1FlexGrid.ConditionFilter
    Dim con() As String
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As Point
        C1SuperTooltip1.IsBalloon = True
        r.X = l - 100
        r.Y = Graba.Location.Y
        Graba.Location = r
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
        asuetos()
        metas()
        vacaciones()
        procesos_adicionales()
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
        crea_nuevos_cortes()
        proyecciones()
        busca_procesos_adicionales()
        fg.ScrollBars = ScrollBars.Both
        Label1.Visible = False
        Graba.Visible = True
        imprime.Visible = True
        to_excel.Visible = True
        calcula_fecha_produccion()
        ProgressBar1.Visible = False
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        Try
            filtro.Condition2.Operator = ConditionOperator.Contains
            fg.Cols("COR").Filter = filtro
            fg.ApplyFilters()
        Catch
        End Try
    End Sub
    Private Sub cpos_abiertos()
        strsql = "SELECT CPO_D.*,CPO.CLIENTE,TOTAL AS PEDIDAS,0 AS CORTADAS, 0 AS PRODUCIDAS , PRIORIDAD, PLAN_SERIGRA_CP.SECCION AS SECC, DIFICULTAD, CATEGORIA, SUB_CATEGORIA FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN PLAN_SERIGRA_CP ON PLAN_SERIGRA_CP.CPO = CPO_D.CPO AND PLAN_SERIGRA_CP.ESTILO = CPO_D.ESTILO AND PLAN_SERIGRA_CP.COLOR = CPO_D.COLOR LEFT JOIN PLAN_SERIGRA_E ON CPO.CLIENTE = PLAN_SERIGRA_E.CLIENTE AND CPO_D.ESTILO = PLAN_SERIGRA_E.ESTILO WHERE ESTADO = 'A'"
        llena_tablas_con(cp, con, strsql)
        Dim dr As DataRow
        dr = cp.Rows(0)
    End Sub
    Private Sub cortes_cpo()
        strsql = "SELECT CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR,CORTES_S.CORTE, CORTES_S.TOTAL AS PRESUP, CORTES.TOTAL  AS CORTADAS ,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND TIPO = '0') AS PRODUCIDAS, CORTES.*,PRIORIDAD,PLAN_SERIGRA_C.PRODUCIDAS AS PROD_P,STATUS ,COMENTARIOS, O2, O3 FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN PLAN_SERIGRA_C ON CORTES_S.CORTE = PLAN_SERIGRA_C.CORTE LEFT JOIN ESTILOS ON CORTES_S.CLIENTE = ESTILOS.CLIENTE AND CORTES_S.ESTILO = ESTILOS.ESTILO WHERE CORTES_S.CPO + CORTES_S.ESTILO + CORTES_S.COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR"
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
        strsql = "SELECT * FROM PLAN_SERIGRA_CP WHERE CPO + ESTILO + COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas_con(csc, con, strsql)
    End Sub
    Private Sub metas()
        strsql = "SELECT * FROM SECCIONES_META LEFT JOIN SECCIONES ON SECCIONES_META.SECCION = SECCIONES.SECCION WHERE ACTIVA = 'S' AND FECHA_FINAL > = '" & Format(Today, "yyyy-MM-dd") & "'"
        llena_tablas(met, strsql, cnn)
    End Sub
    Private Sub procesos_adicionales()
        strsql = "SELECT * FROM CORTES_PA LEFT JOIN CORTES ON CORTES_PA.CORTE = CORTES.CORTE LEFT JOIN CORTES_PAR ON CORTES_PA.CORTE = CORTES_PAR.CORTE AND CORTES_PA.PROCESO = CORTES_PAR.PROCESO AND CORTES_PAR.TIPO = 'Envio' WHERE EXPORTADO = 'N' and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE())"
        llena_tablas(pad, strsql, cnn)
    End Sub
    Private Sub secciones()
        strsql = "SELECT * FROM SECCIONES WHERE ACTIVA = 'S' ORDER BY SECCION"
        llena_tablas(se, strsql, cnn)
        For Each Me.dr In se.Rows
            secc = secc + dr("SECCION") + "|"
        Next
        fg.Cols("SEC").ComboList = secc
    End Sub
    Private Sub asuetos()
        strsql = "SELECT * FROM ASUETOS ORDER BY FECHA"
        llena_tablas(fe, strsql, cnn)
    End Sub
    Private Sub vacaciones()
        strsql = "SELECT * FROM SECCIONES_DESCANSO WHERE FECHA > = '" & Format(Today, "yyyy-MM-dd") & "'"
        llena_tablas(va, strsql, cnn)
    End Sub

    ' ========================================= PRENDAS CON No. DE CORTE
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
            ProgressBar1.Value = +((sumar * 100 / totalr))
            Try
                fg(l, "ART") = "N/A"
                If (dr("O2") = False) And (dr("O3")) = False Then
                    fg(l, "ART") = "N/A"
                ElseIf dr("O2") = True Then
                    fg(l, "ART") = "BORDADO"
                ElseIf dr("O3") Then
                    fg(l, "ART") = "SERIGRAFIA"
                End If
                If dr("O2") And dr("O3") Then
                    fg(l, "ART") = "BORDADO/SERIGRA"
                End If
            Catch ex As Exception
                fg(l, "ART") = ""
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
    ' ================================= PRENDAS SIN CORTE AUN ======================
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
        llena_tablas(pro, "SELECT * FROM PLAN_SERIGRA_P", cnn)
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
        re_calcula.Visible = True
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

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        Dim colu As String = "01 05 23'"
        Dim co As String = Format(fg.Col, "00")
        If colu.IndexOf(co) < 0 Then
            Exit Sub
        End If
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.Insert, Keys.C
                    'copy
                    System.Windows.Forms.Clipboard.SetDataObject(fg.Clip, True)
                    Exit Select
                Case Keys.X
                    'cut
                    'System.Windows.Forms.Clipboard.SetDataObject(fg.Clip)
                    'Dim rg As CellRange = fg.Selection
                    'rg.Data = Nothing
                    Exit Select
                Case Keys.V 'paste
                    Dim data1 As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
                    If data1.GetDataPresent(Type.GetType("System.String")) Then
                        fg.Select(fg.Row, fg.Col, fg.Rows.Count - 1, fg.Cols.Count - 1, False)
                        fg.Clip = CType(data1.GetData(Type.GetType("System.String")), String)
                        fg.Select(fg.Row, fg.Col, False)
                    End If
            End Select
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
                    fg.SetCellStyle(i, fg.Cols.IndexOf("FCS"), fg.Styles("Normal"))
                End If
            End If
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

    'Private Sub ajusta_fecha_produccion(ByVal sec As String, ByVal fechai As Date, ByVal dias As Decimal, ByRef fechaf As Date)
    '    Dim d As Integer = 0
    '    Dim dr As DataRow
    '    Dim dd As DataRow()
    '    Dim fecha As New Date
    '    Dim sabdom As String = "06"
    '    Dim diasem As Integer
    '    Dim h As String = "yyyy-MM-dd"
    '    Dim fei As Date
    '    Dim fef As Date
    '    Dim japa As String
    '    fechaf = fechai.AddDays(dias)
    '    fei = Format(fechai, h)
    '    fef = Format(fechaf, h)
    '    ' ============== AGREGA FINES DE SEMANA ===================
    '    While fei <= fef
    '        diasem = fei.DayOfWeek
    '        If sabdom.IndexOf(diasem) > -1 Then
    '            fef = fef.AddDays(1)
    '            d = d + 1
    '        End If
    '        fei = fei.AddDays(1)
    '    End While
    '    If d > 0 Then
    '        dias = dias + d
    '        fechaf = fechai.AddDays(dias)
    '    End If
    '    ' ============ AGREGA ASUETOS =============================
    '    d = 0
    '    dd = fe.Select("FECHA >= '" & Format(fechai, "yyyy-MM-dd") & "' AND  FECHA <= '" & Format(fechaf, "yyyy-MM-dd") & "'")
    '    For Each dr In dd
    '        fecha = dr("FECHA")
    '        diasem = fecha.DayOfWeek
    '        If sabdom.IndexOf(diasem) = -1 Then
    '            d = d + 1
    '        End If
    '    Next
    '    If d > 0 Then
    '        dias = dias + d
    '        fechaf = fechai.AddDays(dias)
    '    End If

    '    ' ============ AGREGA VACACIONES  =============================
    '    d = 0
    '    If sec = "TEXSUN C" Then
    '        japa = "SECCION = '" & sec & "' AND FECHA_INICIAL < = '" & Format(fechaf, "yyyy-MM-dd") & "' AND  FECHA_FINAL > = '" & Format(fechaf, "yyyy-MM-dd") & "'"
    '    End If

    '    dd = va.Select("SECCION = '" & sec & "' AND FECHA_INICIAL < = '" & Format(fechaf, "yyyy-MM-dd") & "' AND  FECHA_FINAL > = '" & Format(fechaf, "yyyy-MM-dd") & "'")
    '    If dd.Length = 0 Then
    '        Exit Sub
    '    Else
    '        For Each dr In dd
    '            fecha = dr("FECHA_FINAL")
    '            d = DateDiff(DateInterval.Day, fechaf, fecha) + 2
    '        Next

    '        diasem = fecha.DayOfWeek
    '        If sabdom.IndexOf(diasem) = -1 Then
    '            d = d + 1
    '        End If

    '        If d > 0 Then
    '            dias = dias + d
    '            fechaf = fechai.AddDays(dias)
    '        End If
    '    End If
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles re_calcula.Click
        calcula_fecha_produccion()
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            reordena()
            actualiza_plan()
            Close()
        End If
    End Sub

    Private Sub reordena()
        calcula_fecha_produccion()
    End Sub

    Private Sub actualiza_plan()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim f_prod As String
        Dim comentarios As String = ""
        Dim s As Integer = fg.Cols.IndexOf("FCO")
        Dim f_min As String = "01-01-1900"
        Dim obj As New empresas
        obj = New empresas
        Dim transaccion As SqlClient.SqlTransaction
        Dim comando As SqlClient.SqlCommand
        Label1.BackColor = Color.Green
        Label1.Visible = True
        re_calcula.Visible = False
        Cursor = Cursors.WaitCursor
        ' Try
        For J = 1 To 3
            cnn = New SqlClient.SqlConnection
            cnn.ConnectionString = con(J)
            cnn.Open()

            ' Comienza la transacción
            transaccion = cnn.BeginTransaction()

            ' Crea el comando para la transacción
            comando = cnn.CreateCommand()
            comando.Transaction = transaccion

            For i = 1 To fg.Rows.Count - 1
                If (i Mod 200) = 0 Then
                    Label1.Text = "Actualizando " & Format(i, "###,##0") & " de " & Format(fg.Rows.Count - 1, "###,##0")
                    Label1.Refresh()
                End If
                If fg(i, "EMP") = J Then
                    f_prod = Format(fg(i, "FCS"), "yyyy-MM-dd")
                    comentarios = Trim(fg(i, "COM"))
                    fg(i, 0) = fg(i, "CPO") + fg(i, "EST") + fg(i, "COL")
                    If comentarios.Length > 80 Then
                        comentarios = Mid(comentarios, 1, 80)
                        fg(i, "COM") = comentarios
                    End If
                    If fg(i, "TIP") = "C" Then
                        strsql = "UPDATE PLAN_SERIGRA_C SET  PRIORIDAD = '" & fg(i, "PRI") & "', F_COSTURA = '" & f_prod & "' , PRODUCIDAS = '" & fg(i, "PRO") & "' , STATUS = '" & fg(i, "STA") & "' , COMENTARIOS = '" & fg(i, "COM") & "' WHERE CORTE = '" & fg(i, "COR") & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        If afectados = 0 Then
                            strsql = "INSERT INTO PLAN_SERIGRA_C (CORTE,PRIORIDAD,F_COSTURA,PRODUCIDAS,STATUS,COMENTARIOS) " & _
                                   "VALUES ( '" & fg(i, "COR") & "','" & _
                                       fg(i, "PRI") & "','" & _
                                       f_prod & "','" & _
                                       fg(i, "PRO") & "','" & _
                                       fg(i, "STA") & "','" & _
                                       fg(i, "COM") & " ')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If
                    End If

                    If fg(i, "TIP") = "F" Then
                        strsql = "UPDATE PLAN_SERIGRA_CP SET  PRIORIDAD = '" & fg(i, "PRI") & "' , SECCION = '" & fg(i, "SEC") & "' , COMENTARIOS = '" & fg(i, "COM") & "' WHERE CPO = '" & fg(i, "CPO") & "' AND ESTILO = '" & fg(i, "EST") & "' AND COLOR = '" & fg(i, "COL") & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        If afectados = 0 Then
                            strsql = "INSERT INTO PLAN_SERIGRA_CP (CPO,ESTILO,COLOR,PRIORIDAD,SECCION,COMENTARIOS) " & _
                                   "VALUES ( '" & fg(i, "CPO") & "','" & _
                                       fg(i, "EST") & "','" & _
                                       fg(i, "COL") & "','" & _
                                       fg(i, "PRI") & "','" & _
                                       fg(i, "SEC") & "','" & _
                                       fg(i, "COM") & "')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If
                    End If
                    If fg(i, "TIP") = "P" Then
                        strsql = "UPDATE PLAN_SERIGRA_P SET  PRIORIDAD = '" & fg(i, "PRI") & "' , COMENTARIOS = '" & fg(i, "COM") & "' WHERE SECCION = '" & fg(i, "SEC") & "' AND CLIENTE = '" & fg(i, "CLI") & "' AND CPO = '" & fg(i, "CPO") & "' AND ESTILO = '" & fg(i, "EST") & "' AND COLOR = '" & fg(i, "COL") & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If

                    'fg.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, s)
                    'fg.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 0)
                    'For i = 1 To fg.Rows.Count - 1
                    f_prod = Format(fg(i, "FCS"), "yyyy-MM-dd")
                    strsql = "UPDATE WIP0 SET SEW_PLAN = '" & f_prod & "' WHERE CPO = '" & fg(i, "CPO") & "' AND ESTILO = '" & fg(i, "EST") & "' AND COLOR = '" & fg(i, "COL") & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                    If afectados = 0 Then
                        strsql = "INSERT INTO WIP0 (CPO,ESTILO,COLOR,TALLA,FAB_PLAN,FAB_ACTUAL,CUT_PLAN,CUT_ACTUAL,SEW_PLAN,SEW_ACTUAL,EXP_PLAN,EXP_REV,EXP_ACTUAL,COMENTARIOS,EX_CHAR,SER_PLAN,BOR_PLAN)" & _
                                                        "VALUES ( '" & fg(i, "CPO") & "','" & _
                                                                       fg(i, "EST") & "','" & _
                                                                       fg(i, "COL") & "','" & _
                                                                       "S" & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       f_prod & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       " " & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "','" & _
                                                                       f_min & "')"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                End If
            Next i
            strsql = "UPDATE PLAN_SERIGRA_A SET FECHA = getdate() , USUARIO = '" & obj.usuario & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            cnn.Close()

        Next J
        Cursor = Cursors.Default
    End Sub

    Private Sub a_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\PLAN_SERIGRA " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
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

End Class

