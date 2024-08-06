Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class prod_sem
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents li As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(prod_sem))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imprime = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.plan = New System.Windows.Forms.ComboBox()
        Me.excel = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.li = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Planilla:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Bitmap)
        Me.imprime.Location = New System.Drawing.Point(848, 8)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(35, 35)
        Me.imprime.TabIndex = 45
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(800, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar la Consulta.")
        '
        'plan
        '
        Me.plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.plan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plan.Location = New System.Drawing.Point(88, 12)
        Me.plan.Name = "plan"
        Me.plan.Size = New System.Drawing.Size(136, 28)
        Me.plan.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.plan, "Elija el Cliente a consultar.")
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Bitmap)
        Me.excel.Location = New System.Drawing.Point(896, 8)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(35, 35)
        Me.excel.TabIndex = 49
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Bitmap)
        Me.CANCELA.Location = New System.Drawing.Point(800, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Otro Pedido")
        Me.CANCELA.Visible = False
        '
        'li
        '
        Me.li.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.li.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li.Location = New System.Drawing.Point(88, 48)
        Me.li.Name = "li"
        Me.li.Size = New System.Drawing.Size(136, 28)
        Me.li.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.li, "Elija el Cliente a consultar.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(248, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 61
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "7,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:178;Name:""A"";Caption:""ESTILO"";DataType:System.String;Format:"" "";TextAlign" & _
        ":LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:269;Name:""B"";Caption:""CLIENTE"";D" & _
        "ataType:System.String;Format:"" "";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "3{Name:"" "";Caption:""CORTE"";DataType:System.String;Format:"" "";TextAlign:CenterC" & _
        "enter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:102;Name:""D"";Caption:""CANTIDAD"";Data" & _
        "Type:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:Center" & _
        "Center;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:150;Caption:""PRECIO U."";DataType:System.String;Format:"" "";TextA" & _
        "lign:LeftCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:177;Caption:""PRECIO TOT."";" & _
        "DataType:System.Decimal;Format:""$###,##0.00"";TextAlign:RightCenter;TextAlignFixe" & _
        "d:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 88)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 23
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 592)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 11.25pt;Border:Flat,1,Black,Vertical;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{Back" & _
        "Color:255, 167, 79;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Ba" & _
        "ckColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Hi" & _
        "ghlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{Ba" & _
        "ckColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:B" & _
        "lack;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Sub" & _
        "total1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDa" & _
        "rkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "S" & _
        "ubtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Control" & _
        "DarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 12pt, style=Bold;BackColor:Gold;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(568, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 32)
        Me.Label3.TabIndex = 63
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 32)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Linea:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prod_sem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.li, Me.Label4, Me.Label3, Me.fg, Me.Label1, Me.excel, Me.plan, Me.Button1, Me.imprime, Me.Label2, Me.CANCELA})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "prod_sem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Producción por Semana"
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
    Dim pr As New DataTable()
    Dim l As Integer = 1

    Private Sub Contribucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_tablas(pla, "SELECT * FROM PLANILLAS ORDER BY ANO+PLANILLA DESC", cnn)
        llena_combos_1()
        fg.Rows.Count = 1
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim rg As New CellRange()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 40
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
        fg.PrintGrid("Contribucion", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, li.Text + "   Control de Producción x Semana  Planilla  " & plan.Text + "     " + Label1.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\contribucion.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub llena_combos_1()
        plan.Items.Clear()
        For Each Me.dr In pla.Rows
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
            dw = pla.Select("ANO = '" & Mid(plan.Text, 1, 4) & "' AND PLANILLA = '" & Mid(plan.Text, 6, 2) & "'")
            dr = dw(0)
            fechai = Format(dr("FECHA_INICIAL"), "yyyy-MM-dd")
            fechaf = Format(dr("FECHA_FINAL"), "yyyy-MM-dd")
            Label1.Text = Format(dr("FECHA_INICIAL"), "dd/MMM/yyyy") + " AL " + Format(dr("FECHA_FINAL"), "dd/MMM/yyyy")
            t_cambio = dr("TIPO_CAMBIO")
            ano = dr("ANO")
            planilla = dr("PLANILLA")
            Label3.Text = "T.C. =  Q" + Format(t_cambio, "#0.00") + " x  $1.00"
            llena_combos(li, "SELECT DISTINCT SECCION  FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE FECHA BETWEEN '" & fechai & "' AND '" & fechaf & "' AND SECCION LIKE 'TEXSUN%' ORDER BY SECCION", "SECCION")
        Catch
        End Try
    End Sub

    '================================== PRENDAS PRODUCIDAS ==========================
    Private Sub prendas_producidas()
        Dim dt As New DataTable()
        Dim dd As DataRow()
        Dim ds As DataRow
        Dim strsql As String
        Dim tot As Decimal
        Dim precio As Decimal
        strsql = "SELECT CORTES.ESTILO,CORTES.CLIENTE,PROD_DIARIA.CORTE,SECCION,SUM(PRENDAS) AS CANTIDAD FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE FECHA BETWEEN '" & fechai & "' AND '" & fechaf & "' AND SECCION = '" & li.Text & "' GROUP BY CORTES.ESTILO,CORTES.CLIENTE,PROD_DIARIA.CORTE,SECCION ORDER BY PROD_DIARIA.CORTE"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 5
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = dr("CLIENTE")
            fg(l, 3) = dr("CORTE")
            fg(l, 4) = dr("CANTIDAD")
            dd = pr.Select("ESTILO = '" & dr("ESTILO") & "'")
            If dd.Length > 0 Then
                ds = dd(0)
                precio = ds("COSTURA") / 12
            Else
                precio = 0
            End If
            fg(l, 5) = "           " + Format(precio, "$###,##0.0000")
            fg(l, 6) = precio * fg(l, 4)
            tot = tot + fg(l, 6)
            l = l + 1
        Next
        fg(l, 5) = "SUB-TOTAL"
        fg(l, 6) = tot
    End Sub


    '================================== SUELDOS ==========================
    Private Sub salarios()
        Dim rg As CellRange
        Dim dt As New DataTable()
        Dim strsql As String
        Dim sec As String = Mid(li.Text, 8, 1)
        Dim plani As Decimal
        Dim pasivo As Decimal
        Dim pres As Decimal
        strsql = "SELECT * FROM SUELDOS WHERE ANO = '" & ano & "' AND PLANILLA = '" & planilla & "' AND SECCION = '" & sec & "'"
        llena_tablas(dt, strsql, cnn)
        fg(l + 1, 5) = "PLANILLA"
        For Each Me.dr In dt.Rows
            plani = dr("SUELDOS") + dr("HORAS_EXTRAS") + dr("BONIFICA") + dr("BONO_PROD")
            plani = (plani / t_cambio)
            fg(l + 1, 6) = plani
        Next
        fg(l + 2, 5) = "PASIVO"
        pres = (dr("SUELDOS") + dr("HORAS_EXTRAS"))
        pasivo = (pres / t_cambio) * 0.42
        fg(l + 2, 6) = pasivo

        fg(l + 3, 5) = "APORTE"
        fg(l + 3, 6) = fg(l, 6) - plani - pasivo
        rg = fg.GetCellRange(l, 5, l + 3, 6)
        rg.Style = fg.Styles("ctotal")
    End Sub

    Private Sub llena_precios()
        pr = New DataTable()
        llena_tablas(pr, "SELECT DISTINCT ESTILOS.ESTILO,COSTURA FROM ESTILOS WHERE ESTILO + CLIENTE IN (SELECT ESTILO+CLIENTE FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE FECHA BETWEEN '" & fechai & "' AND '" & fechaf & "' AND SECCION = '" & li.Text & "')", cnn)
    End Sub

    Private Sub procesa()
        l = 1
        Button1.Visible = False
        plan.Enabled = False
        llena_precios()
        prendas_producidas()
        salarios()
        CANCELA.Visible = True
        imprime.Visible = True
        excel.Visible = True
        li.Enabled = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        procesa()
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        visibles()
        setea_grid()
        CANCELA.Visible = False
        imprime.Visible = False
        excel.Visible = False
        Button1.Visible = True
        plan.Enabled = True
        li.Enabled = True
    End Sub

    Private Sub visibles()
        Dim i As Integer
        For i = 1 To fg.Cols.Count - 1
            fg.Cols(i).Visible = True
        Next
    End Sub
End Class
