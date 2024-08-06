Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Contribucion_c
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents excel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents plan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contribucion_c))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imprime = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.plan = New System.Windows.Forms.ComboBox()
        Me.excel = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Planilla:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(1131, 10)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(46, 44)
        Me.imprime.TabIndex = 45
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1067, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 44)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar la Consulta.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'plan
        '
        Me.plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.plan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plan.Location = New System.Drawing.Point(117, 15)
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(182, 33)
        Me.plan.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.plan, "Elija el Cliente a consultar.")
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Image)
        Me.excel.Location = New System.Drawing.Point(1195, 10)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(46, 44)
        Me.excel.TabIndex = 49
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.UseVisualStyleBackColor = False
        Me.excel.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(1067, 10)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(46, 44)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Otro Pedido")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(331, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 41)
        Me.Label1.TabIndex = 61
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(11, 71)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 23
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1333, 790)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(757, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 41)
        Me.Label3.TabIndex = 63
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Contribucion_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1279, 692)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.excel)
        Me.Controls.Add(Me.plan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CANCELA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contribucion_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contribución por Planilla  (CORTE)"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.0000"
    Dim pla As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim t_cambio As Decimal
    Dim fechai As String
    Dim fechaf As String
    Dim ano As String
    Dim planilla As String
    Dim suma As Decimal = 0
    Dim prendas As Decimal = 0
    Private Sub Contribucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 50
        llena_tablas(pla, "SELECT * FROM PLANILLAS ORDER BY ANO DESC , PLANILLA DESC ", cnn)
        llena_combos()
        fg.Rows.Count = 1
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim rg As New CellRange()
        Dim i As Integer
        fg.Rows.Count = 1
        fg.Rows.Count = 23
        fg.Rows(0).Height = 40
        fg(1, 1) = "PRODUCCIÓN"
        fg(1, 2) = "DIAS = 5"
        fg(2, 1) = "Prendas Producidas"
        fg(3, 1) = "Promedio diario"
        fg(4, 1) = "Número de Operarios"
        fg(5, 1) = "Prendas * Operario"
        fg(6, 1) = "Facturacion * Operario $"
        fg(7, 1) = "Costo * Operario $"
        fg(8, 1) = "COSTO"
        fg(9, 1) = "Sueldos Q."
        fg(10, 1) = "Horas Extras Q."
        fg(11, 1) = "Bonificación Ley Q."
        fg(12, 1) = "Bono por Producción Q"
        fg(13, 1) = "Total Q."
        fg(14, 1) = "Costo Unitario"
        fg(15, 1) = "Costo Q"
        fg(16, 1) = "Costo $"
        fg(17, 1) = "CONTRIBUCIÓN"
        fg(18, 1) = "Precio Unitario $"
        fg(19, 1) = "Costo/Precio"
        fg(20, 1) = "Aportación Unitaria"
        fg(21, 1) = "Aportación Total $"

        Dim s As CellStyle = fg.Styles.Add("entero")
        s.Format = "###,##0"

        s = fg.Styles.Add("porcentaje")
        s.Format = "###,##0%"

        For i = 1 To 21
            fg.Rows(i).Height = 25
            Try
                If i < 5 Then
                    rg = fg.GetCellRange(i, 2, i, 18)
                    rg.Style = fg.Styles("entero")
                End If
            Catch
            End Try
        Next
        fg.Rows(22).Visible = False
        s = fg.Styles.Add("grande")
        s.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        fg.SetCellStyle(1, 1, fg.Styles("grande"))
        fg.SetCellStyle(8, 1, fg.Styles("grande"))
        fg.SetCellStyle(14, 1, fg.Styles("grande"))
        fg.SetCellStyle(17, 1, fg.Styles("grande"))
        rg = fg.GetCellRange(21, 2, 21, 2)
        rg.Style = fg.Styles("ctotal")

        rg = fg.GetCellRange(7, 1, 7, 2)
        rg.Style = fg.Styles("abajo")


        rg = fg.GetCellRange(16, 1, 16, 2)
        rg.Style = fg.Styles("abajo")

        rg = fg.GetCellRange(19, 2, 19, 2)
        rg.Style = fg.Styles("porcentaje")
    End Sub


    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        print_fg()
    End Sub

    Private Sub print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
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
        fg.PrintGrid("Contribucion", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Resumen de Costos Planilla  " & plan.Text + "     " + Label1.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\contribucion.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub llena_combos()
        plan.Items.Clear()
        Dim dr As DataRow
        For Each dr In pla.Rows
            plan.Items.Add(dr("ANO") + "/" + dr("PLANILLA"))
        Next
        Try
            plan.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub plan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plan.SelectedIndexChanged
        Dim dw As DataRow()
        Try
            dw = pla.Select("ANO = '" & Mid(plan.Text, 1, 4) & "' AND PLANILLA = '" & Mid(plan.Text, 6) & "'")
            dr = dw(0)
            fechai = Format(dr("FECHA_INICIAL"), "yyyy-MM-dd")
            fechaf = Format(dr("FECHA_FINAL"), "yyyy-MM-dd")
            Label1.Text = Format(dr("FECHA_INICIAL"), "dd/MMM/yyyy") + " AL " + Format(dr("FECHA_FINAL"), "dd/MMM/yyyy")
            t_cambio = dr("TIPO_CAMBIO")
            ano = dr("ANO")
            planilla = dr("PLANILLA")
            Label3.Text = "T.C. =  Q" + Format(t_cambio, "#0.00") + " x  $1.00"
        Catch
        End Try
    End Sub

    '================================== PRENDAS PRODUCIDAS ==========================
    Private Sub prendas_producidas()
        Dim dt As New DataTable()
        Dim strsql As String
        Dim dr As DataRow
        strsql = "SELECT SALA,SUM((ESTILOS.CORTE)*CORTES.TOTAL) AS SUMA ,SUM(CORTES.TOTAL) AS PRENDAS FROM CORTES LEFT JOIN ESTILOS ON CORTES.CLIENTE = ESTILOS.CLIENTE AND ESTILOS.ESTILO = CORTES.ESTILO LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE (FCORTE BETWEEN '" & fechai & "' AND '" & fechaf & "') AND CORTES.TOTAL > 0 AND SALA LIKE 'TEX%' GROUP BY SALA"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            Try
                prendas = dr("PRENDAS")
                suma = dr("SUMA") / 12
                fg(2, 2) = prendas
                fg(18, 2) = Format(suma / prendas, h$)
            Catch
            End Try

        Next
    End Sub

    '================================== SUELDOS ==========================
    Private Sub salarios()
        Dim dt As New DataTable()
        Dim strsql As String
        Dim i As Integer
        Dim dr As DataRow
        strsql = "SELECT * FROM SUELDOS WHERE ANO = '" & ano & "' AND PLANILLA = '" & planilla & "' AND SECCION = 'V'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            Try
                i = 2
                If i > 0 Then
                    fg(9, i) = dr("SUELDOS")
                    fg(10, i) = fg(10, i) + dr("HORAS_EXTRAS")
                    fg(11, i) = fg(11, i) + dr("BONIFICA")
                    fg(12, i) = fg(12, i) + dr("BONO_PROD")
                    fg(13, i) = fg(9, i) + fg(10, i) + fg(11, i) + fg(12, i)
                    fg(4, i) = fg(4, i) + dr("OPERARIOS")
                End If
            Catch
            End Try
        Next
    End Sub

    '================================== PRECIO PROMEDIO  ==========================
    Private Sub precio_unitario()
        Try
            fg(18, 2) = Format((suma / fg(2, 2)), h$)
        Catch
        End Try
    End Sub


    Private Sub sumatoria()
        Dim i As Integer
        Dim pres As Decimal
        Dim cos As Decimal
        Dim pren As Decimal
        Dim ag_bon As Decimal
        Dim vac As Decimal
        Dim ind As Decimal
        Dim igp As Decimal
        For i = 2 To 2
            ' ============= costo total
            Try
                If fg(13, i) > 0 Then
                    ag_bon = fg(9, i) * 0.1666
                    vac = (fg(9, i) + fg(10, i) + fg(11, i) + fg(12, i)) * 0.05
                    ind = (fg(9, i) + fg(10, i)) * 0.0972
                    igp = (fg(9, i) + fg(10, i)) * 0.1267
                    pres = ag_bon + vac + ind + igp
                    fg(22, i) = fg(13, i) + pres
                End If
            Catch
            End Try
            ' ============= costo en Q y en $
            Try
                If fg(13, i) > 0 Then
                    fg(15, i) = Format(fg(22, i) / fg(2, i), h$)
                    fg(16, i) = Format(fg(15, i) / t_cambio, h$)
                End If
            Catch
            End Try

            ' ============= promedio diario
            Try
                If fg(2, i) > 0 Then
                    fg(3, i) = fg(2, i) / 5
                End If
            Catch
            End Try
            ' ============= prendas por operario
            Try
                If fg(2, i) > 0 Then
                    fg(5, i) = (fg(2, i) / fg(4, i)) / 5
                End If
            Catch
            End Try
            ' ============= costo / precio
            Try
                If fg(2, i) > 0 Then
                    fg(19, i) = fg(16, i) / fg(18, i)
                End If
            Catch
            End Try
            ' ============= facturacion por operario
            Try
                If fg(4, i) > 0 Then
                    fg(6, i) = (fg(18, i) * fg(2, i)) / fg(4, i)
                End If
            Catch
            End Try
            ' ============= costo por operario
            Try
                If fg(4, i) > 0 Then
                    fg(7, i) = (fg(16, i) * fg(2, i)) / fg(4, i)
                End If
            Catch
            End Try
            ' ============= aportacion unitaria
            Try
                fg(20, i) = Format(fg(18, i) - fg(16, i), "#######0.00")
            Catch
            End Try
            ' ============= aportacion total
            Try
                fg(21, i) = fg(20, i) * fg(2, i)
            Catch
            End Try

            ' ============= despliega solo secciones con datos
            Try
                cos = fg(13, i)
            Catch
                cos = 0
            End Try
            Try
                pren = fg(13, i)
            Catch
                pren = 0
            End Try
            If cos = 0 And pren = 0 Then
                fg.Cols(i).Visible = False
            End If
        Next
    End Sub

    Private Sub procesa()
        Button1.Visible = False
        plan.Enabled = False
        prendas_producidas()
        salarios()
        precio_unitario()
        sumatoria()
        CANCELA.Visible = True
        imprime.Visible = True
        excel.Visible = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ok As Boolean
        revisa_precios(ok)
        If ok Then
            procesa()
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        visibles()
        setea_grid()
        CANCELA.Visible = False
        imprime.Visible = False
        excel.Visible = False
        Button1.Visible = True
        plan.Enabled = True
    End Sub

    Private Sub visibles()
        Dim i As Integer
        For i = 1 To fg.Cols.Count - 1
            fg.Cols(i).Visible = True
        Next
    End Sub

    Private Sub revisa_precios(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim estilos As String = " "
        Dim estilo As String
        Dim dr As DataRow
        Dim strsql As String = "SELECT SALA,CORTES.CORTE,CORTES.ESTILO,ESTILOS.CORTE,CORTES.TOTAL FROM CORTES LEFT JOIN ESTILOS ON ESTILOS.ESTILO = CORTES.ESTILO AND ESTILOS.CLIENTE = CORTES.CLIENTE LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE (FCORTE BETWEEN '" & fechai & "' AND '" & fechaf & "') AND CORTES.TOTAL >0 AND (ESTILOS.CORTE = 0 OR ESTILOS.CORTE IS NULL) AND SALA = 'TEXSUN' ORDER BY SALA"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count = 0 Then
            ok = True
            Exit Sub
        End If
        For Each dr In dt.Rows
            estilo = dr("ESTILO")
            If dr("SALA") = "TEXSUN" Then
                If estilos.IndexOf(estilo) = -1 Then
                    estilos = estilos + Microsoft.VisualBasic.ChrW(13) + estilo
                End If
            End If
        Next
        MsgBox("Por favor ingresar el precio de los estilos: " + estilos, MsgBoxStyle.Critical, "Faltan precios")
        ok = False
    End Sub

End Class
