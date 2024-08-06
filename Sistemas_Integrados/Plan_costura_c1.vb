Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Plan_costura_c1
    Dim dt As New DataTable
    Dim pad As New DataTable
    Dim cc As New DataTable
    Dim fpo As New DataTable
    Dim es As New DataTable
    Dim mat As New DataTable
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
    Dim filtro5 As New ConditionFilter
    Dim filtro6 As New ConditionFilter

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
        setea_fg()
    End Sub
    Private Sub procesa()
        fg.ScrollBars = ScrollBars.None
        Label1.Visible = True
        go.Visible = False
        ProgressBar1.Visible = True
        proceso()
        fg.ScrollBars = ScrollBars.Both
        Label1.Visible = False
        imprime.Visible = True
        to_excel.Visible = True
        ProgressBar1.Visible = False
        actualizado()
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
        filtro5.Condition1.Operator = ConditionOperator.Contains
        filtro6.Condition1.Operator = ConditionOperator.Contains

        Try
            fg.Cols("COR").Filter = filtro1
            fg.Cols("CLI").Filter = filtro2
            fg.Cols("EST").Filter = filtro3
            fg.Cols("COL").Filter = filtro4
            fg.Cols("SEC").Filter = filtro5
            fg.Cols("CLI").Filter = filtro6
            fg.ApplyFilters()
        Catch
        End Try
    End Sub
    Private Sub plan_costura()
        '      strsql = "SELECT * FROM PLANIF_COSTURA inner join CPO_D ON PLANIF_COSTURA.CPO = CPO_D.CPO AND PLANIF_COSTURA.ESTILO = CPO_D.ESTILO AND PLANIF_COSTURA.COLOR = CPO_D.COLOR WHERE ORIG_SHIP > DATEADD(DAY,-180,GETDATE()) 
        'UNION   
        'Select Case* FROM PLANIF_COSTURA inner join zuntex.dbo.CPO_D ON PLANIF_COSTURA.CPO = CPO_D.CPO AND PLANIF_COSTURA.ESTILO = CPO_D.ESTILO AND PLANIF_COSTURA.COLOR = CPO_D.COLOR WHERE ORIG_SHIP > DATEADD(DAY,-180,GETDATE()) AND NOT EXISTS (SELECT 1 FROM zuntex.dbo.CORTES_M WHERE PLANIF_COSTURA.CORTE = CORTES_M.CORTE) AND NOT EXISTS (SELECT 1 FROM zuntex.dbo.CORTES_B WHERE PLANIF_COSTURA.CORTE = CORTES_B.CORTE_NUEVO) and NOT EXISTS (SELECT 1 FROM CORTES inner join zuntex.dbo.CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE CORTES.CORTE = REPLACE(PLANIF_COSTURA.CORTE,'P-',''))
        '"
        strsql = "SELECT * FROM PLANIF_COSTURA"
        llena_tablas(dt, strsql, cnn)
    End Sub
    Private Sub cortes_cpo()
        strsql = "SELECT CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR,CORTES_S.CORTE, CORTES_S.TOTAL AS PRESUP, CORTES.TOTAL  AS CORTADAS ,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND TIPO = '0') AS PRODUCIDAS, CORTES.*,PRIORIDAD,PLAN_COSTURA_C.PRODUCIDAS AS PROD_P,STATUS ,COMENTARIOS, O2, O3 , SALA, F_ICORTE FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN PLAN_COSTURA_C ON CORTES_S.CORTE = PLAN_COSTURA_C.CORTE LEFT JOIN ESTILOS ON CORTES_S.CLIENTE = ESTILOS.CLIENTE AND CORTES_S.ESTILO = ESTILOS.ESTILO WHERE CORTES_S.CPO + CORTES_S.ESTILO + CORTES_S.COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A') AND CORTES_S.TOTAL > 0 ORDER BY CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR"
        llena_tablas_con(cc, con, strsql)
    End Sub
    Private Sub procesos_adicionales()
        strsql = "SELECT * FROM CORTES_PA LEFT JOIN CORTES ON CORTES_PA.CORTE = CORTES.CORTE LEFT JOIN CORTES_PAR ON CORTES_PA.CORTE = CORTES_PAR.CORTE AND CORTES_PA.PROCESO = CORTES_PAR.PROCESO AND CORTES_PAR.TIPO = 'Envio' WHERE EXPORTADO = 'N' and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(pad, con, strsql)
    End Sub

    Private Sub llena_fpos()
        strsql = "SELECT DISTINCT FPO,CPO,COLOR_CPO AS COLOR FROM ROLLOS LEFT JOIN CONSUMO_TELA ON ROLLOS.CODIGO = CONSUMO_TELA.CODIGO AND ROLLOS.COLOR = CONSUMO_TELA.COLOR_TELA WHERE YARDAS > 0 AND UPPER(CPO)<> 'STOCK' AND CPO IN (SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,COLOR_CPO"
        llena_tablas_con1(fpo, con, strsql)
        strsql = "SELECT  DISTINCT FPO,CPO,COLOR_CPO AS COLOR FROM FPO_CPO LEFT JOIN CONSUMO_TELA ON FPO_CPO.COLOR = CONSUMO_TELA.COLOR_TELA WHERE CPO IN (SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,COLOR"
        llena_tablas_con1(fpo, con, strsql)
    End Sub
    Private Sub materiales()
        strsql = "SELECT CORTES.CORTE,PREPARADA,DESPACHADA FROM CORTES LEFT JOIN REQUI ON CORTES.CORTE = REQUI.CORTE WHERE EXPORTADO <> 'S' AND (SELECT COUNT(FECHA) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) = 0 and CORTES.FCORTE > DATEADD(DAY, -365, GETDATE())"
        llena_tablas_con(mat, con, strsql)
    End Sub

    Private Sub proceso()
        Dim i As Integer
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim dd As DataRow()
        Dim dj As DataRow
        'INSTANCIA DE COLOR PARA FONDOS 
        Dim s As C1.Win.C1FlexGrid.CellStyle
        s = fg.Styles.Add("rojo")
        s.BackColor = Color.Red
        s.Font = New Font(fg.Styles.Normal.Font, FontStyle.Bold)
        fg.Cols(16).Style = fg.Styles("rojo")

        Dim kf As C1.Win.C1FlexGrid.CellStyle
        kf = fg.Styles.Add("blanco")
        kf.BackColor = Color.White
        kf.Font = New Font(fg.Styles.Normal.Font, FontStyle.Bold)
        fg.Cols(16).Style = fg.Styles("blanco")

        'FIN INSTANCIA COLOR PARA FONDOS
        Dim fp As String
        Dim p As Integer
        plan_costura()
        cortes_cpo()
        llena_fpos()
        procesos_adicionales()
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            For i = 1 To 28
                If i <> 23 And i <> 24 Then
                    fg(l, i) = dr(i)
                End If
            Next i
            dd = fpo.Select("CPO = '" & fg(l, 6) & "' AND COLOR = '" & fg(l, 11) & "'")
            If dd.Length > 0 Then
                fp = ""
                For Each dj In dd
                    p = fp.IndexOf(dj("FPO"))
                    If p < 0 Then
                        fp = fp + dj("FPO") + " "
                    End If
                Next
                fg(l, "FPO") = fp
            End If
            dd = cc.Select("CORTE = '" & fg(l, 7) & "'")
            If dd.Length > 0 Then
                For Each dj In dd
                    fg(l, 29) = dj("SALA")
                    fg(l, "FGE") = dj("F_ICORTE")
                    Try
                        If dj("CORTADAS") = 0 Then
                            fg.SetCellStyle(l, fg.Cols.IndexOf("PRE"), "amarillo")
                        End If
                    Catch ex As Exception

                    End Try
                Next
            End If
            ''''''''''If fg(l, "FCS") > fg(l, "SHD") Then
            ''''''''''    fg.SetCellStyle(l, fg.Cols.IndexOf("FCS"), "rojo")
            ''''''''''    fg.SetCellStyle(l, fg.Cols.IndexOf("SHW"), "blanco")
            ''''''''''ElseIf fg(l, "FCS") > fg(l, "SHO") Then
            ''''''''''    fg.SetCellStyle(l, fg.Cols.IndexOf("FCS"), "amarillo")
            ''''''''''End If
            ' Verifica la existencia de las columnas "FCS" y "SHD"
            If fg.Cols.Contains("FCS") AndAlso fg.Cols.Contains("SHD") Then
                ' Obtiene la fecha del SHD y verifica si la columna "FCS" contiene una fecha válida
                Dim fechaShd As DateTime
                Dim fechaFcs As DateTime

                If DateTime.TryParse(fg(l, "SHD").ToString(), fechaShd) AndAlso DateTime.TryParse(fg(l, "FCS").ToString(), fechaFcs) Then
                    ' Calcula las fechas límite (7 y 14 días antes)
                    Dim fechaLimite7 As DateTime = fechaShd.AddDays(-7)
                    Dim fechaLimite14 As DateTime = fechaShd.AddDays(-14)

                    ' Compara las fechas de "FCS" y "SHD"
                    If fechaFcs < fechaShd AndAlso fechaFcs >= fechaLimite7 Then
                        ' Si la fecha de "FCS" está dentro del rango de 7 días antes de la fecha del SHD, cambia el color a rojo
                        fg.SetCellStyle(l, fg.Cols.IndexOf("FCS"), "rojo")
                    ElseIf fechaFcs < fechaShd AndAlso fechaFcs >= fechaLimite14 Then
                        ' Si la fecha de "FCS" está dentro del rango de 14 días antes de la fecha del SHD, cambia el color a amarillo
                        fg.SetCellStyle(l, fg.Cols.IndexOf("FCS"), "amarillo")
                    ElseIf fechaFcs > fechaShd AndAlso fechaFcs > fg(l, "SHO") Then
                        ' Si la fecha de "FCS" no cumple las condiciones anteriores, aplica las demás condiciones
                        fg.SetCellStyle(l, fg.Cols.IndexOf("FCS"), "otro_color") ' Puedes ajustar el color según tus necesidades
                    End If
                Else
                    ' Manejar el caso en el que la conversión no fue exitosa (el valor en "SHD" o "FCS" no es una fecha válida)
                    ' Aquí puedes mostrar un mensaje de error o realizar alguna acción adecuada para tu aplicación
                    MsgBox("La fecha en 'SHD' o 'FCS' no es válida.")
                End If
            Else
                ' Al menos una de las columnas "FCS" o "SHD" no existe, maneja este caso según tus necesidades
                MsgBox("Al menos una de las columnas 'FCS' o 'SHD' no existe.")
            End If


            l = l + 1
        Next
        busca_procesos_adicionales()
        materiales()
    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        setea_fg()
        go.Visible = False
        Cursor = Cursors.WaitCursor
        procesa()
        Cursor = Cursors.Default
        re_calcula.Visible = False
    End Sub

    Private Sub a_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Plan_costura " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        a_excel(fg, hora, ok)
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fg()
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


End Class

