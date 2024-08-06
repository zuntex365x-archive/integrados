Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Plan_costura_con
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
    Dim edi As New DataTable
    Dim dr As DataRow
    Dim strsql As String
    Dim secc As String = ""
    Dim cnn As New SqlClient.SqlConnection
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim filtro As New ConditionFilter '.Win.C1FlexGrid.ConditionFilter
    Dim con() As String
    Dim si_puedo As Boolean
    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As Point
        si_puedo = puedo_planificar()
        Dim emp As New empresas
        If emp.numero <> 1 Then
            Close()
        End If
        If si_puedo = False Then
            Close()
        Else
            planificando("G")
        End If
        fg.Width = Me.Width - 25
        fg.Height = Me.Height - 85
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
        crea_nuevos_cortes()
        proyecciones()
        busca_procesos_adicionales()
        materiales()
        busca_materiales()
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
            ' filtro.Condition1.Operator = ConditionOperator.Contains
            ' fg.Cols("COR").Filter = filtro
            'fg.ApplyFilters()
        Catch
        End Try
    End Sub
    Private Sub cpos_abiertos()
        strsql = "SELECT CPO_D.*,CPO.CLIENTE,TOTAL AS PEDIDAS,0 AS CORTADAS, 0 AS PRODUCIDAS , PRIORIDAD, PLAN_COSTURA_CP.SECCION AS SECC, DIFICULTAD, CATEGORIA, SUB_CATEGORIA FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN PLAN_COSTURA_CP ON PLAN_COSTURA_CP.CPO = CPO_D.CPO AND PLAN_COSTURA_CP.ESTILO = CPO_D.ESTILO AND PLAN_COSTURA_CP.COLOR = CPO_D.COLOR LEFT JOIN PLAN_COSTURA_E ON CPO.CLIENTE = PLAN_COSTURA_E.CLIENTE AND CPO_D.ESTILO = PLAN_COSTURA_E.ESTILO WHERE ESTADO = 'A' and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(cp, con, strsql)
        Dim dr As DataRow
        dr = cp.Rows(0)
    End Sub
    Private Sub cortes_cpo()
        strsql = "SELECT CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR,CORTES_S.CORTE, CORTES_S.TOTAL AS PRESUP, CORTES.TOTAL  AS CORTADAS ,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND TIPO = '0') AS PRODUCIDAS, CORTES.*,PRIORIDAD,PLAN_COSTURA_C.PRODUCIDAS AS PROD_P,STATUS ,COMENTARIOS, O2, O3 FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN PLAN_COSTURA_C ON CORTES_S.CORTE = PLAN_COSTURA_C.CORTE LEFT JOIN ESTILOS ON CORTES_S.CLIENTE = ESTILOS.CLIENTE AND CORTES_S.ESTILO = ESTILOS.ESTILO WHERE CORTES_S.CPO + CORTES_S.ESTILO + CORTES_S.COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A'and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE())) AND CORTES_S.TOTAL > 0 and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE()) ORDER BY CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR"
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
    Private Sub secciones()
        secc = ""
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
    Private Sub materiales()
        strsql = "SELECT CORTES.CORTE,PREPARADA,DESPACHADA FROM CORTES LEFT JOIN REQUI ON CORTES.CORTE = REQUI.CORTE WHERE EXPORTADO <> 'S' AND (SELECT COUNT(FECHA) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) = 0 and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(mat, con, strsql)
    End Sub
    Private Sub dias_corte()
        strsql = "SELECT ESTILO,DIAS_CORTE FROM ESTILOS_CORTE WHERE ESTILO IN (SELECT DISTINCT ESTILO FROM CPO_D WHERE ESTADO = 'A' and CPO_D.F_INGRESO > DATEADD(DAY, -365, GETDATE()))"
        llena_tablas_con(edi, con, strsql)
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
        Dim sec_cos As String = ""
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
                sincretiza_seccion(dr("SECCION"), l, sec_cos)
                fg(l, "SEC") = sec_cos
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
        Dim dj As DataRow()
        Dim sec_cos As String = ""
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
                    sincretiza_seccion(dg("SECCION"), l, sec_cos)
                    fg(l, "SEC") = sec_cos
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
        Dim sec_cos As String = ""
        llena_tablas_con(pro, con, "SELECT * FROM PLAN_COSTURA_P")
        For Each dr In pro.Rows
            agrega_linea(l)
            cortes = "PROY" + Format(cuenta, "00000")
            sincretiza_seccion(dr("SECCION"), l, sec_cos)
            fg(l, "SEC") = sec_cos
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
            fg(l, "EMP") = "1"
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

        dd = se.Select("SECCION = '" & sec & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            meta = dr("META")
        Else
            meta = 2000
        End If
    End Sub

    Private Sub fin_de_semana(ByVal fecha As Date, ByRef weekend As Date)
        Dim d As Integer
        d = fecha.DayOfWeek
        weekend = fecha.AddDays(7 - d)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles re_calcula.Click
        calcula_fecha_produccion()
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            reordena()
            fg.Subtotal(AggregateEnum.Clear)
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
        Try
            For J = 1 To 3
                cnn = New SqlClient.SqlConnection
                cnn.ConnectionString = con(J)
                cnn.Open()

                ' Comienza la transacción
                transaccion = cnn.BeginTransaction()

                ' Crea el comando para la transacción
                comando = cnn.CreateCommand()
                comando.Transaction = transaccion

                strsql = "DELETE PLAN_COSTURA_T"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                If J = 1 Then
                    strsql = "DELETE PLANIF_COSTURA"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If


                For i = 1 To fg.Rows.Count - 1
                    If (i Mod 200) = 0 Then
                        Label1.Text = "Actualizando " & Format(i, "###,##0") & " de " & Format(fg.Rows.Count - 1, "###,##0")
                        Label1.Refresh()
                    End If
                    If fg(i, "EMP") = J Then
                        f_prod = Format(fg(i, "FCS"), "yyyy-MM-dd")
                        If fg(i, 0) = "S" Then
                            Mid(fg(i, "SEC"), 1, 6) = "TEXFOR"
                        End If
                        Try
                            comentarios = Trim(fg(i, "COM"))
                        Catch
                            comentarios = ""
                        End Try
                        fg(i, 0) = fg(i, "CPO") + fg(i, "EST") + fg(i, "COL")
                        If comentarios.Length > 80 Then
                            comentarios = Mid(comentarios, 1, 80)
                            fg(i, "COM") = comentarios
                        End If
                        If fg(i, "TIP") = "C" Then
                            strsql = "UPDATE PLAN_COSTURA_C SET  PRIORIDAD = '" & fg(i, "PRI") & "', F_COSTURA = '" & f_prod & "' , PRODUCIDAS = '" & fg(i, "PRO") & "' , STATUS = '" & fg(i, "STA") & "' , COMENTARIOS = '" & fg(i, "COM") & "' WHERE CORTE = '" & fg(i, "COR") & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            If afectados = 0 Then
                                strsql = "INSERT INTO PLAN_COSTURA_C (CORTE,PRIORIDAD,F_COSTURA,PRODUCIDAS,STATUS,COMENTARIOS) " &
                                       "VALUES ( '" & fg(i, "COR") & "','" &
                                           fg(i, "PRI") & "','" &
                                           f_prod & "','" &
                                           fg(i, "PRO") & "','" &
                                           fg(i, "STA") & "','" &
                                           fg(i, "COM") & " ')"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If
                            strsql = "UPDATE CORTES SET SECCION = '" & fg(i, "SEC") & "' WHERE CORTE = '" & fg(i, "COR") & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If

                        If fg(i, "TIP") = "F" Then
                            strsql = "UPDATE PLAN_COSTURA_CP SET  PRIORIDAD = '" & fg(i, "PRI") & "' , SECCION = '" & fg(i, "SEC") & "' , COMENTARIOS = '" & fg(i, "COM") & "' WHERE CPO = '" & fg(i, "CPO") & "' AND ESTILO = '" & fg(i, "EST") & "' AND COLOR = '" & fg(i, "COL") & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            If afectados = 0 Then
                                strsql = "INSERT INTO PLAN_COSTURA_CP (CPO,ESTILO,COLOR,PRIORIDAD,SECCION,COMENTARIOS) " &
                                       "VALUES ( '" & fg(i, "CPO") & "','" &
                                           fg(i, "EST") & "','" &
                                           fg(i, "COL") & "','" &
                                           fg(i, "PRI") & "','" &
                                           fg(i, "SEC") & "','" &
                                           fg(i, "COM") & "')"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If
                        End If
                        If fg(i, "TIP") = "P" Then
                            strsql = "UPDATE PLAN_COSTURA_P SET  PRIORIDAD = '" & fg(i, "PRI") & "' , COMENTARIOS = '" & fg(i, "COM") & "' WHERE SECCION = '" & fg(i, "SEC") & "' AND CLIENTE = '" & fg(i, "CLI") & "' AND CPO = '" & fg(i, "CPO") & "' AND ESTILO = '" & fg(i, "EST") & "' AND COLOR = '" & fg(i, "COL") & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If

                        f_prod = Format(fg(i, "FCS"), "yyyy-MM-dd")
                        strsql = "UPDATE WIP0 SET SEW_PLAN = '" & f_prod & "' WHERE CPO = '" & fg(i, "CPO") & "' AND ESTILO = '" & fg(i, "EST") & "' AND COLOR = '" & fg(i, "COL") & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                        If afectados = 0 Then
                            strsql = "INSERT INTO WIP0 (CPO,ESTILO,COLOR,TALLA,FAB_PLAN,FAB_ACTUAL,CUT_PLAN,CUT_ACTUAL,SEW_PLAN,SEW_ACTUAL,EXP_PLAN,EXP_REV,EXP_ACTUAL,COMENTARIOS,EX_CHAR,SER_PLAN,BOR_PLAN)" &
                                                            "VALUES ( '" & fg(i, "CPO") & "','" &
                                                                           fg(i, "EST") & "','" &
                                                                           fg(i, "COL") & "','" &
                                                                           "S" & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           f_prod & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           " " & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "','" &
                                                                           f_min & "')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If
                        strsql = "INSERT INTO PLAN_COSTURA_T(CORTE,CPO,ESTILO,COLOR,CLIENTE,F_PROD,PRENDAS,SECCION) VALUES ('" &
                                                                          fg(i, "COR") & "','" &
                                                                          fg(i, "CPO") & "','" &
                                                                          fg(i, "EST") & "','" &
                                                                          fg(i, "COL") & "','" &
                                                                          fg(i, "CLI") & "','" &
                                                                          f_prod & "','" &
                                                                          fg(i, "PRE") & "','" &
                                                                          fg(i, "SEC") & "') "
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()


                    End If
                Next i
                strsql = "UPDATE PLAN_COSTURA_A SET FECHA = getdate() , USUARIO = '" & obj.usuario & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                transaccion.Commit()
                cnn.Close()

            Next J
        Catch e As Exception
            MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor Avise a Jesús Acosta !!!!")
            cnn.Close()
        End Try
        graba_todo()
        Cursor = Cursors.Default
    End Sub
    Private Sub graba_todo()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim transaccion As SqlClient.SqlTransaction
        Dim comando As SqlClient.SqlCommand
        cnn = New SqlClient.SqlConnection
        cnn.ConnectionString = con(1)

        Try
            cnn.Open()

            ' Comienza la transacción
            transaccion = cnn.BeginTransaction()

            ' Crea el comando para la transacción
            comando = cnn.CreateCommand()
            comando.Transaction = transaccion

            For i = 1 To fg.Rows.Count - 1

                '======================== PLANIF. COSTURA
                strsql = "INSERT INTO PLANIF_COSTURA (LINEA,PLANTA,CLIENTE,CATEGO,SUB_CAT,PRIORIDAD,CPO,CORTE,PRENDAS,PRODUCIDAS,ESTILO,COLOR,DIFIC,PLAN_C,WEEKEND,SHIP_DATE,SHIP_WEEK,ORIG_SHIP,PLAN_CORTE,STATUS,W_DELAY,FABRICS,TRIMS,ARTE,ARTE_1,EMBELLIS,DESTINO,COMENTARIOS,EMPRESA)" &
                                                          "VALUES ( '" & i & "','" &
                                                                      fg(i, 1) & "','" &
                                                                      fg(i, 2) & "','" &
                                                                      fg(i, 3) & "','" &
                                                                      fg(i, 4) & "','" &
                                                                      fg(i, 5) & "','" &
                                                                      fg(i, 6) & "','" &
                                                                      fg(i, 7) & "','" &
                                                                      fg(i, 8) & "','" &
                                                                      fg(i, 9) & "','" &
                                                                      fg(i, 10) & "','" &
                                                                      fg(i, 11) & "','" &
                                                                      fg(i, 12) & "','" &
                                                                      Format(fg(i, 13), "yyyy-MM-dd") & "','" &
                                                                      Format(fg(i, 14), "yyyy-MM-dd") & "','" &
                                                                      Format(fg(i, 15), "yyyy-MM-dd") & "','" &
                                                                      Format(fg(i, 16), "yyyy-MM-dd") & "','" &
                                                                      Format(fg(i, 17), "yyyy-MM-dd") & "','" &
                                                                      Format(fg(i, 18), "yyyy-MM-dd") & "','" &
                                                                      fg(i, 19) & "','" &
                                                                      fg(i, 20) & "','" &
                                                                      fg(i, 21) & "','" &
                                                                      fg(i, 22) & "','" &
                                                                      fg(i, 23) & "','','" &
                                                                      fg(i, 27) & "','" &
                                                                      fg(i, 24) & "','" &
                                                                      fg(i, 25) & "','" &
                                                                      fg(i, 26) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()

        Catch e As Exception
            MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor Avise a Jesús Acosta !!!!")
        End Try
        cnn.Close()
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
    Private Sub fg_BeforeEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.BeforeEdit
        'Dim corte As String = fg(e.Row, "COR")
        'Dim seccion As String = fg(e.Row, "SEC")
        'Dim busca As String = "SALDOS NO ASI"
        'Dim res As Integer
        'Dim x As Integer = seccion.IndexOf(" ")
        'Dim sec As String = seccion
        'If e.Col = 1 Then
        '    If x > 0 Then
        '        seccion = Mid(seccion, 1, x)
        '    End If
        '    'secciones_e(seccion)
        '    If Mid(corte, 1, 1) <> "P" Then
        '        sec = seccion + "      "
        '        sec = Mid(sec, 1, 6)
        '        res = InStr(1, busca, sec)
        '        If res = 0 Then
        '            secciones_e(seccion)
        '        Else
        '            secciones_e("TODAS")
        '            ' e.Cancel = True
        '        End If
        '    Else
        '        secciones_e("TODAS")
        '    End If

        'End If

    End Sub
    Private Sub fg_AfterEdit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.AfterEdit
        Dim l As Integer = fg.RowSel
        sincretiza_seccion(fg(l, "SEC"), l, fg(l, "SEC"))
    End Sub

    Private Sub secciones_e(ByVal sec As String)
        Dim dr As DataRow
        secc = ""
        strsql = "SELECT * FROM SECCIONES WHERE SECCION LIKE '" & sec & "%' AND ACTIVA = 'S' ORDER BY SECCION"
        If Mid(sec, 1, 3) = "TEX" Then
            strsql = "SELECT * FROM SECCIONES WHERE SECCION LIKE '" & Mid(sec, 1, 3) & "%' AND ACTIVA = 'S' ORDER BY SECCION"
        End If
        If sec = "TODAS" Then
            strsql = "SELECT * FROM SECCIONES WHERE ACTIVA = 'S' ORDER BY SECCION"
        End If
        llena_tablas(se, strsql, cnn)
        For Each dr In se.Rows
            secc = secc + dr("SECCION") + "|"
        Next
        fg.Cols("SEC").ComboList = secc
    End Sub

    Private Sub sincretiza_seccion(ByVal sec As String, ByVal linea As Integer, ByRef seccion As String)
        Dim planta As String
        planta = Mid(sec, 1, 6)
        seccion = sec
        fg(linea, 0) = ""
    End Sub


    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If si_puedo Then
            planificando("E")
        End If

    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click
        Dim c As Integer = fg.ColSel
        Dim f As Integer = fg.RowSel
        Dim corte As String = fg(f, "COR")
        Dim seccion As String = fg(f, "SEC")
        Dim busca As String = "SALDOS NO ASI"
        Dim res As Integer
        Dim x As Integer = seccion.IndexOf(" ")
        Dim sec As String = seccion
        If c = 1 Then
            If x > 0 Then
                seccion = Mid(seccion, 1, x)
            End If
            'secciones_e(seccion)
            If Mid(corte, 1, 1) <> "P" Then
                sec = seccion + "      "
                sec = Mid(sec, 1, 6)
                res = InStr(1, busca, sec)
                If res = 0 Then
                    secciones_e(seccion)
                Else
                    secciones_e("TODAS")
                    ' e.Cancel = True
                End If
            Else
                secciones_e("TODAS")
            End If

        End If
    End Sub
End Class

