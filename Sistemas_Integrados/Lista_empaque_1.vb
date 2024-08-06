Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Lista_empaque_1
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ta As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents li As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cpo As System.Windows.Forms.ComboBox
    Friend WithEvents embarque As System.Windows.Forms.TextBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents po As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents se As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents seg As System.Windows.Forms.CheckBox
    Friend WithEvents Au As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents at As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents empres As System.Windows.Forms.ComboBox
    Friend WithEvents tallas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sigue = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.G1 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.embarque = New System.Windows.Forms.TextBox()
        Me.empres = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ta = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tallas = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.li = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.po = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.se = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.seg = New System.Windows.Forms.CheckBox()
        Me.Au = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.at = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ta.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.li, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Au.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.at, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(929, 8)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 6
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Presione este Boton para Desplegar la Consulta.")
        Me.sigue.UseVisualStyleBackColor = False
        Me.sigue.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(969, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Otro Pedido")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(464, 8)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(155, 24)
        Me.cliente.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente")
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(665, 8)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(169, 24)
        Me.cpo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cpo, "Cpo")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(1009, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 81
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos del  Corte")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'fecha
        '
        Me.fecha.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Enabled = False
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(296, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(104, 22)
        Me.fecha.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha del Embarque")
        '
        'embarque
        '
        Me.embarque.BackColor = System.Drawing.Color.White
        Me.embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.embarque.Location = New System.Drawing.Point(88, 8)
        Me.embarque.MaxLength = 15
        Me.embarque.Name = "embarque"
        Me.embarque.Size = New System.Drawing.Size(144, 26)
        Me.embarque.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.embarque, "Embarque.")
        '
        'empres
        '
        Me.empres.BackColor = System.Drawing.Color.White
        Me.empres.Enabled = False
        Me.empres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empres.Items.AddRange(New Object() {"TEXSUN", "TEXFOR"})
        Me.empres.Location = New System.Drawing.Point(840, 8)
        Me.empres.Name = "empres"
        Me.empres.Size = New System.Drawing.Size(83, 24)
        Me.empres.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.empres, "Cpo")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(0, 0)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(1017, 200)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(407, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(625, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 26)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Cpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'co
        '
        Me.co.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.co.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.co.ColumnInfo = resources.GetString("co.ColumnInfo")
        Me.co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.co.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.co.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.co.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.co.Location = New System.Drawing.Point(0, 0)
        Me.co.Name = "co"
        Me.co.Rows.Count = 1
        Me.co.Rows.DefaultSize = 21
        Me.co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.co.Size = New System.Drawing.Size(1015, 392)
        Me.co.StyleInfo = resources.GetString("co.StyleInfo")
        Me.co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.co.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 26)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ta
        '
        Me.Ta.Controls.Add(Me.TabPage1)
        Me.Ta.Controls.Add(Me.TabPage2)
        Me.Ta.Controls.Add(Me.TabPage3)
        Me.Ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ta.Location = New System.Drawing.Point(0, 272)
        Me.Ta.Name = "Ta"
        Me.Ta.SelectedIndex = 0
        Me.Ta.Size = New System.Drawing.Size(1045, 424)
        Me.Ta.TabIndex = 77
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.co)
        Me.TabPage1.Controls.Add(Me.tallas)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1037, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cortes       "
        '
        'tallas
        '
        Me.tallas.BackColor = System.Drawing.Color.White
        Me.tallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tallas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tallas.Items.AddRange(New Object() {"XS", "S", "M", "L", "XL", "2XL", "3XL", "4XL", "5XL", "6XL"})
        Me.tallas.Location = New System.Drawing.Point(840, 352)
        Me.tallas.Name = "tallas"
        Me.tallas.Size = New System.Drawing.Size(120, 24)
        Me.tallas.TabIndex = 76
        Me.tallas.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.li)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1037, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle Empaque"
        '
        'li
        '
        Me.li.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.li.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.li.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.li.ColumnInfo = resources.GetString("li.ColumnInfo")
        Me.li.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.li.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.li.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.li.Location = New System.Drawing.Point(2, 2)
        Me.li.Name = "li"
        Me.li.Rows.Count = 1
        Me.li.Rows.DefaultSize = 22
        Me.li.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.li.Size = New System.Drawing.Size(1008, 392)
        Me.li.StyleInfo = resources.GetString("li.StyleInfo")
        Me.li.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.li.TabIndex = 76
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.po)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1037, 393)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Porcentajes"
        '
        'po
        '
        Me.po.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.po.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.po.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.po.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.po.ColumnInfo = resources.GetString("po.ColumnInfo")
        Me.po.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.po.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.po.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.po.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.po.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.po.Location = New System.Drawing.Point(4, 4)
        Me.po.Name = "po"
        Me.po.Rows.Count = 1
        Me.po.Rows.DefaultSize = 22
        Me.po.Size = New System.Drawing.Size(1008, 392)
        Me.po.StyleInfo = resources.GetString("po.StyleInfo")
        Me.po.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.po.TabIndex = 76
        '
        'se
        '
        Me.se.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.se.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.se.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.se.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.se.ColumnInfo = resources.GetString("se.ColumnInfo")
        Me.se.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.se.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.se.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.se.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.se.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.se.Location = New System.Drawing.Point(-16, 104)
        Me.se.Name = "se"
        Me.se.Rows.Count = 1
        Me.se.Rows.DefaultSize = 22
        Me.se.Size = New System.Drawing.Size(1008, 392)
        Me.se.StyleInfo = resources.GetString("se.StyleInfo")
        Me.se.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.se.TabIndex = 78
        Me.se.Visible = False
        '
        'seg
        '
        Me.seg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seg.ForeColor = System.Drawing.Color.Black
        Me.seg.Location = New System.Drawing.Point(939, 30)
        Me.seg.Name = "seg"
        Me.seg.Size = New System.Drawing.Size(64, 24)
        Me.seg.TabIndex = 7
        Me.seg.Text = "2das?"
        '
        'Au
        '
        Me.Au.Controls.Add(Me.TabPage5)
        Me.Au.Controls.Add(Me.TabPage6)
        Me.Au.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Au.Location = New System.Drawing.Point(0, 48)
        Me.Au.Name = "Au"
        Me.Au.SelectedIndex = 0
        Me.Au.Size = New System.Drawing.Size(1049, 224)
        Me.Au.TabIndex = 80
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.fg)
        Me.TabPage5.Controls.Add(Me.se)
        Me.TabPage5.Controls.Add(Me.seg)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1041, 191)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Selección"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.at)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1041, 191)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Auditados"
        '
        'at
        '
        Me.at.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.at.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.at.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.at.ColumnInfo = resources.GetString("at.ColumnInfo")
        Me.at.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.at.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.at.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.at.Location = New System.Drawing.Point(0, 0)
        Me.at.Name = "at"
        Me.at.Rows.Count = 1
        Me.at.Rows.DefaultSize = 22
        Me.at.Size = New System.Drawing.Size(1000, 192)
        Me.at.StyleInfo = resources.GetString("at.StyleInfo")
        Me.at.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.at.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(242, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 26)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lista_empaque_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1413, 707)
        Me.Controls.Add(Me.empres)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.embarque)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.Au)
        Me.Controls.Add(Me.Ta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empaque"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ta.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.li, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.se, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Au.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.at, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim pla As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim pe As DataTable
    Dim pc(9) As String
    Dim o As New C1menus.men

    Private Sub Lista_empaque_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler embarque.KeyPress, AddressOf keypressed1
        AddHandler fecha.KeyPress, AddressOf keypressed2
        AddHandler cliente.KeyPress, AddressOf keypressed3
        AddHandler cpo.KeyPress, AddressOf keypressed4
        empres.SelectedIndex = 0
        llena_clientes()
        deshabilita()
    End Sub

    Private Sub deshabilita()
        setea_grid(True)
        embarque.Enabled = True
        cliente.Enabled = False
        fecha.Enabled = False
        cpo.Enabled = False
        seg.Enabled = False
        empres.Enabled = False
        Au.Enabled = False
        Ta.Enabled = False
        sigue.Visible = False
        G1.Visible = False
        embarque.Focus()
    End Sub

    Private Sub habilita()
        embarque.Enabled = False
        cliente.Enabled = True
        cpo.Enabled = True
        seg.Enabled = True
        empres.Enabled = True
        Au.Enabled = True
        Ta.Enabled = True
        sigue.Visible = True
    End Sub

    Private Sub setea_grid(ByVal si As Boolean)
        Dim i As Integer
        If si Then
            fg.Rows.Count = 1
            at.Rows.Count = 1
        End If
        co.Rows.Count = 1
        li.Rows.Count = 1
        po.Rows.Count = 1


        fg.Rows(0).Height = 40
        co.Rows(0).Height = 40
        li.Rows(0).Height = 40
        po.Rows(0).Height = 40
        at.Rows(0).Height = 40

        co.Cols(16).AllowEditing = False

        For i = 1 To 4
            co.Cols(i).AllowMerging = True
        Next
    End Sub

    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(embarque.Text) <> "" Then
                revisa_nombre(embarque.Text)
                llena_at()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_nombre(ByRef embar As String)
        Dim i As Integer
        Dim c As String
        For i = 1 To Len(embar)
            c = Mid(embar, i, 1)
            If c <> Microsoft.VisualBasic.ChrW(32) Then
                If c < Microsoft.VisualBasic.ChrW(65) Then
                    If (c < Microsoft.VisualBasic.ChrW(48)) Or (c > Microsoft.VisualBasic.ChrW(57)) Then
                        Mid(embar, i, 1) = "|"
                    End If
                End If
                If c > Microsoft.VisualBasic.ChrW(90) Then
                    Mid(embar, i, 1) = "|"
                End If
            End If
        Next
        quita_caracter(embar, "|")
    End Sub

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                cliente.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                cpo.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub llena_detalle_cpos()
        Dim dt As New DataTable()
        Dim f As Integer
        Dim cpos As String
        Dim estilo As String
        Dim colo As String
        Dim todo As String
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CPO_D WHERE CPO = '" & cpo.Text & "' AND ESTADO = 'A' AND (CPO + ESTILO + COLOR)  NOT IN (SELECT CPO+ESTILO+COLOR FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "') ORDER BY CPO,ESTILO,COLOR "
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            cpos = dr("CPO")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            todo = cliente.Text + cpos + estilo + colo
            If fg.FindRow(todo, 1, 0, True) < 0 Then
                f = fg.Rows.Count
                fg.Rows.Count = f + 1
                fg(f, 1) = cliente.Text
                fg(f, 2) = cpos
                fg(f, 3) = estilo
                fg(f, 4) = colo
                fg(f, 5) = dr("TOTAL")
                fg(f, 6) = False
                Try
                    fg(f, 7) = dr("DESTINO")
                Catch
                End Try
                fg(f, 0) = todo
                fg.Cols(6).AllowEditing = True
            End If
        Next
        fg.Sort(SortFlags.Ascending, 0)
    End Sub

    Private Sub llena_cortes(ByVal f As Integer)
        Dim dt As New DataTable()
        Dim cpos As String = fg(f, 2)
        Dim estilo As String = fg(f, 3)
        Dim col As String = fg(f, 4)
        Dim corte As String
        Dim l As Integer
        Dim i As Integer
        Dim pr As Integer
        Dim ex As Integer
        Dim va As Integer
        Dim fin As Integer
        Dim tot As Integer
        Dim dr As DataRow
        Dim strsql As String = ""
        strsql = "SELECT * FROM CORTES LEFT JOIN CORTES_P ON CORTES.CORTE = CORTES_P.CORTE LEFT JOIN CORTES_E ON CORTES.CORTE = CORTES_E.CORTE LEFT JOIN CORTES_V ON CORTES.CORTE = CORTES_V.CORTE WHERE CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & col & "' AND CLIENTE = '" & cliente.Text & "'"
        setea_grid(False)
        Ta.SelectedIndex = 0
        l = co.FindRow(cpos + estilo + col, 1, 0, True)
        If l < 0 Then
            llena_tablas(dt, strsql, cnn)
            For Each dr In dt.Rows
                corte = dr(0)
                l = co.Rows.Count
                co.Rows.Count = co.Rows.Count + 1
                co(l, 1) = cpos
                co(l, 2) = estilo
                co(l, 3) = col
                co(l, 4) = corte
                co(l, 5) = "Pri"
                fin = 0
                If seg.Checked Then
                    co.Rows.Count = co.Rows.Count + 1
                    co(l + 1, 1) = cpos
                    co(l + 1, 2) = estilo
                    co(l + 1, 3) = col
                    co(l + 1, 4) = corte
                    co(l + 1, 5) = "Seg"
                    fin = 1
                End If

                For i = 0 To 9
                    Try
                        pr = dr(i + 23)
                    Catch
                        pr = 0
                    End Try
                    Try
                        ex = dr(i + 44)
                    Catch
                        ex = 0
                    End Try
                    Try
                        va = dr(i + 65)
                    Catch
                        va = 0
                    End Try
                    tot = pr - ex ' - va
                    If tot < 0 Then
                        tot = 0
                    End If
                    co(l, i + 6) = tot
                    co(l, 16) = co(l, 16) + co(l, i + 6)
                    Try
                        pr = dr(i + 33)
                    Catch
                        pr = 0
                    End Try
                    Try
                        ex = dr(i + 54)
                    Catch
                        ex = 0
                    End Try
                    Try
                        va = dr(i + 75)
                    Catch
                        va = 0
                    End Try
                    co(l, 17) = False
                    co(l, 18) = dr("BATCH")

                    If seg.Checked Then
                        tot = pr - ex '- va
                        If tot < 0 Then
                            tot = 0
                        End If
                        co(l + 1, i + 6) = tot
                        co(l + 1, 16) = co(l + 1, 16) + co(l + 1, i + 6)
                        co(l + 1, 17) = False
                        co(l + 1, 18) = dr("BATCH")
                    End If
                Next i
                'quita_stock(corte, l)
            Next
            llena_stock(f)
            For i = 1 To co.Rows.Count - 1
                If co(i, 16) = 0 Then
                    co(i, 0) = "adios"
                Else
                    co(i, 0) = cpos + estilo + col
                End If
            Next

            ' ====== Quita líneas con total 0 =====
            i = 1
            While i > 0
                i = co.FindRow("adios", 1, 0, True)
                If i > 0 Then
                    Try
                        co.Rows.Remove(i)
                    Catch
                    End Try
                End If
            End While
        End If

    End Sub

    Private Sub quita_stock(ByVal corte As String, ByVal l As Integer)
        Dim dt As New DataTable()
        Dim p As Integer
        Dim prendas As Decimal
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM E_STOCK WHERE CORTE = '" & corte & "'", cnn)
        For Each dr In dt.Rows
            prendas = dr("PRENDAS")
            p = tallas.Items.IndexOf(dr("TALLA"))
            If p > -1 Then
                If dr("TIPO") = "00" Then
                    co(l, p + 6) = co(l, p + 6) - prendas
                    co(l, 16) = co(l, 16) - prendas

                ElseIf seg.Checked And dr("TIPO") > "00" Then
                    co(l + 1, p + 6) = co(l + 1, p + 6) - prendas
                    co(l + 1, 16) = co(l + 1, 16) - prendas
                End If
            End If
        Next
    End Sub

    Private Sub llena_stock(ByVal f As Integer)
        Dim l As Integer
        Dim p As Integer
        Dim corte As String
        Dim prenda As Integer
        Dim colo As String = fg(f, 4)
        Dim estilo As String = fg(f, 3)
        Dim dt As New DataTable()
        Dim cpos As String = fg(f, 2)
        Dim TALLASN As String
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM E_STOCK WHERE ESTILO = '" & estilo & "' AND COLOR = '" & colo & "' AND (PRENDAS -EXPORT) > 0 AND TIPO = '00'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            corte = "ST-" + dr("CORTE")
            l = co.FindRow(corte, 1, 4, False)
            If l < 0 Then
                l = co.Rows.Count
                co.Rows.Count = co.Rows.Count + 1
                co(l, 1) = cpos
                co(l, 2) = estilo
                co(l, 3) = colo
                co(l, 4) = corte
                co(l, 5) = "Pri"
                For p = 6 To 16
                    co(l, p) = 0
                Next
            End If
            TALLASN = dr("TALLA")
            p = tallas.Items.IndexOf(Trim(dr("TALLA")))
            prenda = dr("PRENDAS") - dr("EXPORT")
            If dr("TIPO") = "00" Then
                co(l, p + 6) = co(l, p + 6) + prenda
                co(l, 16) = co(l, 16) + prenda
            End If
        Next
    End Sub

    Private Sub quita_cortes(ByVal f As Integer)
        Dim cpos As String = fg(f, 2)
        Dim estilo As String = fg(f, 3)
        Dim col As String = fg(f, 4)
        Dim i As Integer = 1
        While i > 0
            i = co.FindRow(cpos + estilo + col, 1, 0, True)
            If i > 0 Then
                Try
                    co.Rows.Remove(i)
                Catch
                End Try
            End If
        End While
    End Sub

    Private Sub procesa()
        llena_detalle_cpos()
    End Sub

    Private Sub llena_clientes()
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT DISTINCT CLIENTE FROM CPO LEFT JOIN CPO_D ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE "
        cliente.Items.Clear()
        llena_tablas(dt, strsql, cnn)
        For Each Me.dr In dt.Rows
            cliente.Items.Add(dr("CLIENTE"))
        Next
        Try
            cliente.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub llena_cpos()
        Dim strsql As String = "SELECT DISTINCT CPO_D.CPO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & cliente.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.CPO"
        llena_combos(cpo, strsql, "CPO")
        Try
            cpo.SelectedIndex = 0
        Catch
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Usted seleccionó " & empres.Text & " como empresa a exportar. ¿Está seguro?", MsgBoxStyle.YesNo, "Confirmar")
        If seguro = MsgBoxResult.Yes Then
            procesa()
            cliente.Enabled = False
            cpo.Enabled = False
            empres.Enabled = False
            G1.Visible = True
        End If

    End Sub
    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        setea_grid(True)
        deshabilita()
        embarque.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles embarque.Leave
        If embarque.Text = "" Or embarque.Text = Nothing Then
            MsgBox("Por favor ingrese el número de embarque", MsgBoxStyle.Exclamation, "Embarque inválido !!!")
            embarque.Focus()
        End If
    End Sub
    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_cpos()
        If cliente.Text = "SCREENMATES" Then
            seg.Visible = True
        Else
            seg.Checked = False
            seg.Visible = False
        End If
        'empres.SelectedIndex = o.fac_empre(cliente.Text)
    End Sub

    Private Sub fg_quita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim i As Integer
        Dim l As Integer = e.Row
        For i = 1 To fg.Rows.Count - 1
            If fg(l, 6) = True Then
                If i <> l Then
                    fg(i, 6) = False
                    quita_cortes(i)
                Else
                    llena_cortes(i)
                    tallas_cortes(fg(i, 2), fg(i, 3), fg(i, 4), co, 0, 6)
                End If
            Else
                quita_cortes(i)
            End If
        Next

    End Sub

    Private Sub co_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles co.ValidateEdit
        If e.Col < 16 Then
            Try
                Dim dec As Decimal = Decimal.Parse(co.Editor.Text())
                If dec > co(e.Row, e.Col) Then
                    MessageBox.Show("No puede ingresar una exportación mayor a la existencia.")
                    e.Cancel = True
                End If
            Catch
                MessageBox.Show("Por favor ingrese valores numéricos")
                e.Cancel = True
            End Try
        End If
    End Sub

    Private Sub RowColEventHandler(ByVal sender As Object, ByVal e As RowColEventArgs) Handles co.AfterEdit
        Dim i As Integer
        Dim l As Integer = e.Row
        co(l, 16) = 0
        For i = 6 To 15
            co(l, 16) = co(l, 16) + co(l, i)
        Next
        crea_lista_empaque()
    End Sub

    Private Sub Ta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ta.SelectedIndexChanged
        If Ta.SelectedIndex = 2 Then
            porcentajes()
        End If
    End Sub

    Private Sub crea_lista_empaque()
        Dim i As Integer
        Dim j As Integer
        Dim r As Integer
        Dim e As Integer
        Dim w As Integer
        Dim c As Integer = 1
        Dim p As Integer
        Dim ca As Integer
        li.Rows.Count = 1
        llena_se()
        ultima_caja(ca)
        c = ca + 1
        For i = 1 To se.Rows.Count - 1
            prendas_caja(se(i, 2))
            For j = 4 To 13
                If se(i, j) > 0 Then
                    p = CInt(pc(j - 4))
                    If p = 0 Then
                        p = 20
                    End If
                    e = Fix(se(i, j) / p)
                    r = se(i, j) Mod p
                    For w = 1 To e
                        crea_caja(c, i, j - 4, p)
                    Next
                End If
            Next
            For j = 4 To 13
                If se(i, j) > 0 Then
                    p = CInt(pc(j - 4))
                    If p = 0 Then
                        p = 20
                    End If
                    e = Fix(se(i, j) / p)
                    r = se(i, j) Mod p
                    If r > 0 Then
                        crea_caja(c, i, j - 4, r)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub crea_caja(ByRef caja As Integer, ByVal l As Integer, ByVal a As Integer, ByVal p As Integer)
        Dim ta() As String
        Dim t As String = "XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL"
        Dim n As Integer = li.Rows.Count
        ta = t.Split(","c)
        li.Rows.Count = li.Rows.Count + 1
        li(n, 1) = caja
        li(n, 2) = se(l, 1)
        li(n, 3) = se(l, 2)
        li(n, 4) = se(l, 3)
        li(n, 5) = se(l, 15)
        li(n, 6) = ta(a)
        li(n, 7) = p
        caja = caja + 1
    End Sub

    '================================= PORCENTAJES =======================================
    Private Sub porcentajes()
        Dim i As Integer
        po.Rows.Count = 1
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 6) = True Then
                busca_pedido(i)
            End If
        Next
    End Sub

    Private Sub busca_pedido(ByVal i As Integer)
        Dim dt As New DataTable()
        Dim dw As New DataTable()
        Dim dr As DataRow
        Dim ds As DataRow
        Dim l As Integer
        Dim j As Integer
        Dim p As Integer
        Dim e As Integer
        Dim pr As Integer
        Dim rgn As CellRange
        Dim strsql As String = "SELECT * FROM CPO_D WHERE CPO = '" & fg(i, 2) & "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            l = po.Rows.Count
            pr = l
            po.Rows.Count = po.Rows.Count + 6
            For j = 0 To 5
                po(l + j, 1) = dr("CPO")
                po(l + j, 2) = dr("ESTILO")
                po(l + j, 3) = dr("COLOR")
            Next
            po(l, 4) = "PEDIDO"
            For j = 3 To 13
                po(l, j + 2) = dr(j)
                po(l + 1, j + 2) = 0
                po(l + 2, j + 2) = 0
                po(l + 3, j + 2) = 0
            Next
            l = l + 1
            po(l, 4) = "EXPORT."
            strsql = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS P0,SUM(P1) AS P1,SUM(P2) AS P2,SUM(P3) AS P3,SUM(P4) AS P4,SUM(P5) AS P5,SUM(P6) AS P6,SUM(P7) AS P7,SUM(P8) AS P8, SUM(P9) AS P9 FROM CORTES_E, CORTES WHERE CORTES.CORTE = CORTES_E.CORTE AND CPO = '" & fg(i, 2) & "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "' GROUP BY CPO,ESTILO,COLOR"
            llena_tablas(dw, strsql, cnn)
            For Each ds In dw.Rows
                For j = 5 To 14
                    po(l, j) = ds(j - 2)
                    po(l, 15) = po(l, 15) + ds(j - 2)
                Next
            Next
            l = l + 1
            po(l, 4) = "EMBAR."
            p = 1
            e = 1
            While p > 0
                p = co.FindRow(po(l, 1) + po(l, 2) + po(l, 3), e, 0, False)
                If p > 0 Then
                    If co(p, 17) = True And co(p, 5) = "Pri" Then
                        For j = 5 To 15
                            po(l, j) = po(l, j) + co(p, j + 1)
                        Next
                    End If
                End If
                e = e + 1
            End While
            l = l + 1
            po(l, 4) = "DIFER."
            po(l + 1, 4) = "% EXP"
            For j = 5 To 15
                po(l, j) = (po(l - 3, j) - po(l - 2, j) - po(l - 1, j))
                Try
                    po(l + 1, j) = (po(l - 2, j) + po(l - 1, j)) / po(pr, j)
                Catch
                    po(l + 1, j) = 0
                End Try
            Next
            rgn = po.GetCellRange(l + 1, 5, l + 1, 15)
            rgn.Style = po.Styles("ctotal")
            For j = 1 To 4
                po(l + 2, j) = " "
            Next
            rgn = po.GetCellRange(l + 2, 1, l + 2, 15)
            rgn.Style = po.Styles("abajo")
        Next
    End Sub

    '======================================== LISTAS DE EMPAQUE ================================
    Private Sub define_empaque()
        Dim i As Integer
        Dim j As Integer
        Dim r As Integer
        Dim e As Integer
        Dim w As Integer
        Dim c As Integer = 1
        Dim p As Integer
        li.Rows.Count = 1
        For i = 1 To co.Rows.Count - 1
            If co(i, 17) = True Then
                For j = 6 To 15
                    If co(i, j) > 0 Then
                        p = 15
                        e = Fix(co(i, j) / p)
                        r = co(i, j) Mod p
                        For w = 1 To e
                            crea_caja(c, i, j - 6, p)
                        Next
                        If r > 0 Then
                            crea_caja(c, i, j - 6, r)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub llena_se()
        Dim i As Integer
        Dim j As Integer
        Dim l As Integer
        Dim bu As String
        se.Rows.Count = 1
        For i = 1 To co.Rows.Count - 1
            If co(i, 17) = True Then
                bu = co(i, 1) + co(i, 2) + co(i, 3) + co(i, 5)
                l = se.FindRow(bu, 1, 0, False)
                If l < 1 Then
                    l = se.Rows.Count
                    se.Rows.Count = se.Rows.Count + 1
                    se(l, 1) = co(i, 1)
                    se(l, 2) = co(i, 2)
                    se(l, 3) = co(i, 3)
                    se(l, 15) = co(i, 5)
                    se(l, 0) = se(l, 1) + se(l, 2) + se(l, 3) + se(l, 15)
                End If
                For j = 4 To 13
                    se(l, j) = se(l, j) + co(i, j + 2)
                Next
            End If
        Next
    End Sub

    Private Sub llena_at()
        Dim dt As New DataTable()
        Dim l As Integer = 1
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "' ORDER BY CAJA_I"
        llena_tablas(dt, strsql, cnn)
        at.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            at(l, 1) = dr("CPO")
            at(l, 2) = dr("ESTILO")
            at(l, 3) = dr("COLOR")
            at(l, 4) = dr("DESTINO")
            at(l, 5) = dr("CAJA_I")
            at(l, 6) = dr("CAJA_F")
            at(l, 0) = at(l, 1) + at(l, 2) + at(l, 3)
            fecha.Text = dr("FECHA")
            l = l + 1
        Next
        habilita()
        If dt.Rows.Count > 0 Then
            fecha.Enabled = False
            'MsgBox("Este embarque ya fue creado en fecha " + UCase(Format(dr("FECHA"), "dd-MMM-yyyy")), MsgBoxStyle.Critical, "Embarque Existente")
            setea_grid(True)
            ' deshabilita()
            ' embarque.Text = ""
            cliente.Focus()
        Else
            fecha.Enabled = False
            cliente.Focus()
        End If
    End Sub

    Private Sub prendas_caja(ByVal estilo As String)
        Dim dt As New DataTable()
        Dim dw As DataRow
        Dim i As Integer
        Dim ceros As String = "0|0|0|0|0|0|0|0|0|0"
        pc = ceros.Split("|")
        Dim strsql As String = "SELECT * FROM ESTILO_EMP WHERE ESTILO = '" & estilo & "'"
        llena_tablas(dt, strsql, cnn)
        For Each Me.dr In dt.Rows
            dw = dr
            For i = 0 To 9
                pc(i) = dr(i + 1)
            Next
        Next
    End Sub

    Private Sub ultima_caja(ByRef caja As Integer)
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT * FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "' ORDER BY CAJA_F DESC"
        caja = 0
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            caja = CInt(dr("CAJA_F"))
        End If
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        seguro = MsgBox("Seguro de agregar a la lista de empaque?  ", MsgBoxStyle.YesNo, "Grabando Lista de Empaque !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_datos(ok)
            If ok Then
                graba_datos()
                If seg.Checked = False Then
                    graba_segundas()
                End If
                otro_estilo()
            End If
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        If li.Rows.Count = 1 Then
            MsgBox("No puede Grabar aún. No ha elegido ningún corte !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!")
            ok = False
        Else
            ok = True
        End If
    End Sub

    Private Sub otro_estilo()
        setea_grid(True)
        deshabilita()
        llena_at()
        cpo.Focus()
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim i As Integer
        Dim p As Integer
        Dim j As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim cf As Integer
        Dim ci As Integer
        Dim tp As Integer
        Dim tip As String
        Dim tipo As String
        Dim tal As String
        Dim corte As String
        Dim destino As String = ""
        Dim talla As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
        Dim tallas As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
        Dim tl() As String = talla.Split("|")
        Dim ts() As String = tallas.Split("|")
        Dim pr(9) As Integer
        Dim se(9) As Integer
        'ultima_caja(c)
        li.Sort(SortFlags.Ascending, 1)

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To li.Rows.Count - 1

                strsql = "UPDATE PACKING_C SET PRENDAS = PRENDAS + " & li(i, 7) & " WHERE EMBARQUE = '" & embarque.Text &
                                                   "' AND CAJA = '" & li(i, 1) & "' AND CPO = '" & li(i, 2) &
                                                   "' AND ESTILO = '" & li(i, 3) & "' AND COLOR = '" & li(i, 4) &
                                                   "' AND TIPO = '" & li(i, 5) & "' AND TALLA = '" & li(i, 6) & "'"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                If afectados = 0 Then
                    strsql = "INSERT INTO PACKING_C (EMBARQUE,CAJA,CPO,ESTILO,COLOR,TIPO,TALLA,PRENDAS) " &
                                         "VALUES ('" & embarque.Text & "','" &
                                                       li(i, 1) & "','" &
                                                       li(i, 2) & "','" &
                                                       li(i, 3) & "','" &
                                                       li(i, 4) & "','" &
                                                       li(i, 5) & "','" &
                                                       li(i, 6) & "','" &
                                                       li(i, 7) & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next
            p = li.Rows.Count - 1
            ci = li(1, 1)
            cf = li(p, 1)
            destino = fg(fg.RowSel, 7)
            strsql = "INSERT INTO PACKING_E (EMBARQUE,CPO,ESTILO,COLOR,CAJA_I,CAJA_F,FECHA,DESTINO,FACTURA,CONTENEDOR,MATPRI,FACTURADO,NFSHIP,FECHA_CREACION,FACTURA_CLIENTE,E_FACTURA) " &
                                            "VALUES ('" & embarque.Text & "','" &
                                                          li(1, 2) & "','" &
                                                          li(1, 3) & "','" &
                                                          li(1, 4) & "','" &
                                                          ci & "','" &
                                                          cf & "','" &
                                                          fechas & "','" &
                                                          destino & "','','',0,'N','',GETDATE(),'','" & empres.SelectedIndex & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To co.Rows.Count - 1
                If co(i, 17) = True Then
                    strsql = "INSERT INTO PACKING_D (EMBARQUE,CORTE,TIPO,CPO,ESTILO,COLOR,FECHA,CLIENTE,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6)  " &
                                "VALUES ('" & embarque.Text & "','" &
                                              co(i, 4) & "','" &
                                              co(i, 5) & "','" &
                                              co(i, 1) & "','" &
                                              co(i, 2) & "','" &
                                              co(i, 3) & "','" &
                                              fechas & "','" &
                                              cliente.Text & "','" &
                                              co(i, 6) & "','" &
                                              co(i, 7) & "','" &
                                              co(i, 8) & "','" &
                                              co(i, 9) & "','" &
                                              co(i, 10) & "','" &
                                              co(i, 11) & "','" &
                                              co(i, 12) & "','" &
                                              co(i, 13) & "','" &
                                              co(i, 14) & "','" &
                                              co(i, 15) & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                    If Mid(co(i, 4), 1, 3) = "ST-" Then
                        corte = Mid(co(i, 4), 4)
                    Else
                        corte = co(i, 4)
                    End If

                    ' =================================== ACTUALIZA EXPORTACION DEL CORTE ==============
                    strsql = "UPDATE CORTES SET EXPORTADO = 'S' WHERE CORTE = '" & co(i, 4) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                    ' ================ ACTUALIZA EMBARQUES ==============================
                    If Mid(co(i, 5), 1, 1) = "P" Then
                        tp = 0
                        tip = "P"
                    Else
                        tp = 1
                        tip = "S"
                    End If
                    For j = 0 To 9
                        If co(i, j + 6) > 0 Then

                            strsql = "UPDATE EMBARQUES SET PRENDAS = PRENDAS  + " & co(i, j + 6) &
                                                          " WHERE EMBARQUE = '" & embarque.Text & "' AND CORTE = '" & co(i, 4) & "' " &
                                                          " AND TIPO = '" & tp & "' AND TALLA = '" & tl(j) & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            If afectados = 0 Then
                                strsql = "INSERT INTO EMBARQUES (EMBARQUE,CORTE,TIPO,TALLA,FECHA,PRENDAS) " &
                                                                    "VALUES ( '" & embarque.Text & "','" &
                                                                       co(i, 4) & "','" &
                                                                       tp & "','" &
                                                                       tl(j) & "','" &
                                                                       fechas & "','" &
                                                                       co(i, j + 6) & "')"

                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If
                            ReDim pr(9)
                            ReDim se(9)
                            If tp = 0 Then
                                pr(j) = co(i, j + 6)
                                se(j) = 0
                            Else
                                se(j) = co(i, j + 6)
                                pr(j) = 0
                            End If
                            If Mid(co(i, 5), 1, 1) = "P" Then
                                tal = "P" & CStr(j)
                            Else
                                tal = "S" & CStr(j)
                            End If
                            strsql = "UPDATE CORTES_E SET " & tal & " = " & tal & " + " & co(i, j + 6) & " WHERE CORTE = '" & co(i, 4) & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            If afectados = 0 Then
                                strsql = "INSERT INTO CORTES_E (CORTE,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9) " &
                                         "VALUES ( '" & co(i, 4) & "','" &
                                                    pr(0) & "','" &
                                                    pr(1) & "','" &
                                                    pr(2) & "','" &
                                                    pr(3) & "','" &
                                                    pr(4) & "','" &
                                                    pr(5) & "','" &
                                                    pr(6) & "','" &
                                                    pr(7) & "','" &
                                                    pr(8) & "','" &
                                                    pr(9) & "','" &
                                                    se(0) & "','" &
                                                    se(1) & "','" &
                                                    se(2) & "','" &
                                                    se(3) & "','" &
                                                    se(4) & "','" &
                                                    se(5) & "','" &
                                                    se(6) & "','" &
                                                    se(7) & "','" &
                                                    se(8) & "','" &
                                                    se(9) & "')"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If

                            If Mid(co(i, 4), 1, 3) = "ST-" Then
                                '======================================= ACTUALIZA STOCK =============================
                                If Mid(co(i, 5), 1, 1) = "P" Then
                                    tipo = "00"
                                Else
                                    tipo = "01"
                                End If
                                ' =============== SALIDAS STOCK
                                strsql = "UPDATE S_STOCK SET PRENDAS = PRENDAS + " & co(i, j + 6) & " WHERE EMBARQUE = '" & embarque.Text & "' AND ESTILO = '" & co(i, 2) & "' AND COLOR = '" & co(i, 3) & "' AND TIPO = '" & tipo & "' AND TALLA = '" & ts(j) & "' AND CLIENTE = '" & cliente.Text & "' AND CPO = '" & co(i, 1) & "'"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()

                                If afectados = 0 Then
                                    strsql = "INSERT INTO S_STOCK (EMBARQUE,ESTILO,COLOR,TIPO,TALLA,CLIENTE,CPO,FECHA,PRENDAS) " &
                                                                                            "VALUES ( '" & embarque.Text & "','" &
                                                                                               co(i, 2) & "','" &
                                                                                               co(i, 3) & "','" &
                                                                                               tipo & "','" &
                                                                                               ts(j) & "','" &
                                                                                               cliente.Text & "','" &
                                                                                               co(i, 1) & "','" &
                                                                                               fechas & "','" &
                                                                                               co(i, j + 6) & "')"

                                    comando.CommandText = strsql
                                    afectados = comando.ExecuteNonQuery()
                                End If
                                ' =============== ENTRADAS STOCK
                                strsql = "UPDATE E_STOCK SET EXPORT = EXPORT + " & co(i, j + 6) & " WHERE CORTE = '" & corte & "' AND ESTILO = '" & co(i, 2) & "' AND COLOR = '" & co(i, 3) & "' AND TIPO = '" & tipo & "' AND TALLA = '" & ts(j) & "'"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()

                                ' =============== INVENTARIO STOCK
                                strsql = "UPDATE STOCK SET UNIDADES = UNIDADES - " & co(i, j + 6) & " WHERE ESTILO = '" & co(i, 2) & "' AND COLOR = '" & co(i, 3) & "' AND TIPO = '" & tipo & "' AND TALLA = '" & ts(j) & "' AND CLIENTE = '" & cliente.Text & "'"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If
                        End If
                    Next j
                End If
            Next i

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub graba_segundas()
        Dim talla As String
        Dim afectados As Integer
        Dim t(9) As String
        Dim g(9) As String
        Dim tt As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
        Dim t1 As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
        Dim dt As New DataTable()
        Dim dc As New DataTable()
        Dim es As New DataTable()
        Dim dr As DataRow
        Dim dw As DataRow
        Dim i As Integer
        Dim j As Integer
        Dim seg As Integer
        Dim corte As String
        Dim strsql As String
        Dim pren As Object
        t = tt.Split("|")
        g = t1.Split("|")
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            For i = 1 To co.Rows.Count - 1
                If co(i, 5) = "Pri" Then
                    corte = co(i, 4)
                    dt = New DataTable()
                    dc = New DataTable()
                    strsql = "SELECT (CORTES_P.S0-CORTES_E.S0) as S0 ,(CORTES_P.S1-CORTES_E.S1) as S1,(CORTES_P.S2-CORTES_E.S2) as S2,(CORTES_P.S3-CORTES_E.S3) as S3,(CORTES_P.S4-CORTES_E.S4) as S4,(CORTES_P.S5-CORTES_E.S5) as S5,(CORTES_P.S6-CORTES_E.S6) as S6,(CORTES_P.S7-CORTES_E.S7) as S7,(CORTES_P.S8-CORTES_E.S8) as S8,(CORTES_P.S9-CORTES_E.S9) as S9 FROM CORTES_P LEFT JOIN CORTES_E ON CORTES_P.CORTE = CORTES_E.CORTE WHERE CORTES_P.CORTE = '" & corte & "'"
                    llena_tablas(dt, strsql, cnn)
                    strsql = "SELECT CORTE,TALLA, SUM(PRENDAS) AS PRENDAS FROM PROD_DIARIA WHERE CORTE = '" & corte & "' AND (TIPO = 3 OR TIPO = 8) GROUP BY CORTE,TALLA"
                    llena_tablas(dc, strsql, cnn)
                    llena_tablas(es, "SELECT * FROM E_STOCK WHERE CORTE = '" & corte & "' AND TIPO > '00'", cnn)
                    If es.Rows.Count = 0 Then
                        For Each dr In dt.Rows
                            For j = 0 To 9
                                seg = dr(j)
                                pren = dc.Compute("Sum(PRENDAS)", "TALLA = '" & g(j) & "'")
                                Try
                                    seg = seg - Int(pren)
                                Catch
                                End Try
                                If seg > 0 Then
                                    strsql = "INSERT INTO E_STOCK (CORTE,TIPO,TALLA,FECHA,ESTILO,COLOR,CLIENTE,PRENDAS,EXPORT) " &
                                                                                            "VALUES ( '" & corte & "','01','" &
                                                                                               t(j) & "','" &
                                                                                               fechas & "','" &
                                                                                               co(i, 2) & "','" &
                                                                                               co(i, 3) & "','" &
                                                                                               cliente.Text & "','" &
                                                                                               seg & "',0)"

                                    comando.CommandText = strsql
                                    afectados = comando.ExecuteNonQuery()

                                    strsql = "UPDATE STOCK SET UNIDADES = UNIDADES + " & seg & " WHERE ESTILO = '" & co(i, 2) & "' AND COLOR = '" & co(i, 3) & "' AND TIPO = '01' AND TALLA = '" & t(j) & "' AND CLIENTE = '" & cliente.Text & "'"
                                    comando.CommandText = strsql
                                    afectados = comando.ExecuteNonQuery()
                                    If afectados = 0 Then
                                        strsql = "INSERT INTO STOCK (ESTILO,COLOR,TIPO,TALLA,CLIENTE,UNIDADES) " &
                                                                       "VALUES ( '" & co(i, 2) & "','" &
                                                                                      co(i, 3) & "','01','" &
                                                                                      t(j) & "','" &
                                                                                      cliente.Text & "','" &
                                                                                      seg & "')"

                                        comando.CommandText = strsql
                                        afectados = comando.ExecuteNonQuery()
                                    End If
                                End If
                            Next
                        Next

                        For Each dw In dc.Rows
                            seg = dw("PRENDAS")
                            talla = t(Array.IndexOf(g, dw("TALLA")))
                            strsql = "INSERT INTO E_STOCK (CORTE,TIPO,TALLA,FECHA,ESTILO,COLOR,CLIENTE,PRENDAS,EXPORT) " &
                                                            "VALUES ( '" & corte & "','02','" &
                                                               talla & "','" &
                                                               fechas & "','" &
                                                               co(i, 2) & "','" &
                                                               co(i, 3) & "','" &
                                                               cliente.Text & "','" &
                                                               seg & "',0)"

                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            strsql = "UPDATE STOCK SET UNIDADES = UNIDADES + " & seg & " WHERE ESTILO = '" & co(i, 2) & "' AND COLOR = '" & co(i, 3) & "' AND TIPO = '02' AND TALLA = '" & talla & "' AND CLIENTE = '" & cliente.Text & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            If afectados = 0 Then
                                strsql = "INSERT INTO STOCK (ESTILO,COLOR,TIPO,TALLA,CLIENTE,UNIDADES) " &
                                                            "VALUES ( '" & co(i, 2) & "','" & co(i, 3) & "','02','" &
                                                                    talla & "','" &
                                                                    cliente.Text & "','" &
                                                                    seg & "')"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If
                        Next
                    End If
                End If
            Next
            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en datos", MsgBoxStyle.Critical, "Por favor revise !!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        fecha.Value = Today
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub

End Class
