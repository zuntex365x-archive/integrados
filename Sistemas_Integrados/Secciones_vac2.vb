Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Secciones_vac2
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Private WithEvents d1 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents d2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents d3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents seccion As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Dim sec As New DataTable
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents e1 As System.Windows.Forms.Button
    Friend WithEvents fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents seccion1 As System.Windows.Forms.ComboBox
    Friend WithEvents ja As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents r1 As System.Windows.Forms.Button
    Friend WithEvents g1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Dim dr As DataRow
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Secciones_vac2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Elimina = New System.Windows.Forms.Button()
        Me.seccion = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.regresa = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        Me.motivo = New System.Windows.Forms.ComboBox()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.e1 = New System.Windows.Forms.Button()
        Me.seccion1 = New System.Windows.Forms.ComboBox()
        Me.ja = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.r1 = New System.Windows.Forms.Button()
        Me.g1 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tm = New C1.Win.C1Command.C1DockingTab()
        Me.d1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.d2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.d3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tm.SuspendLayout()
        Me.d1.SuspendLayout()
        Me.d2.SuspendLayout()
        Me.d3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Elimina
        '
        Me.Elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina.ForeColor = System.Drawing.Color.Black
        Me.Elimina.Image = CType(resources.GetObject("Elimina.Image"), System.Drawing.Image)
        Me.Elimina.Location = New System.Drawing.Point(813, 14)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(60, 40)
        Me.Elimina.TabIndex = 105
        Me.Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina, "Elimina Registros")
        Me.Elimina.UseVisualStyleBackColor = False
        '
        'seccion
        '
        Me.seccion.ItemHeight = 20
        Me.seccion.Location = New System.Drawing.Point(141, 14)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(246, 28)
        Me.seccion.TabIndex = 97
        Me.ToolTip1.SetToolTip(Me.seccion, "Sección.")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(17, 108)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1047, 590)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(945, 14)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 101
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(879, 14)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 100
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Graba y Actualiza registros.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'motivo
        '
        Me.motivo.AutoCompleteCustomSource.AddRange(New String() {"ASUETO", "VACACIONES", "DESCANSOS"})
        Me.motivo.ItemHeight = 20
        Me.motivo.Items.AddRange(New Object() {"ASUETO", "VACACIONES", "DESCANSO"})
        Me.motivo.Location = New System.Drawing.Point(141, 74)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(246, 28)
        Me.motivo.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.motivo, "Motivo del Descanso")
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowFiltering = True
        Me.jg.BackColor = System.Drawing.Color.White
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.jg.ForeColor = System.Drawing.Color.Black
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(10, 13)
        Me.jg.Name = "jg"
        Me.jg.Rows.Count = 1
        Me.jg.Rows.DefaultSize = 25
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(999, 698)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.jg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1015, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 106
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Elimina Registros")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'e1
        '
        Me.e1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1.ForeColor = System.Drawing.Color.Black
        Me.e1.Image = CType(resources.GetObject("e1.Image"), System.Drawing.Image)
        Me.e1.Location = New System.Drawing.Point(816, 19)
        Me.e1.Name = "e1"
        Me.e1.Size = New System.Drawing.Size(60, 40)
        Me.e1.TabIndex = 115
        Me.e1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.e1, "Elimina Registros")
        Me.e1.UseVisualStyleBackColor = False
        '
        'seccion1
        '
        Me.seccion1.ItemHeight = 20
        Me.seccion1.Location = New System.Drawing.Point(144, 19)
        Me.seccion1.Name = "seccion1"
        Me.seccion1.Size = New System.Drawing.Size(246, 28)
        Me.seccion1.TabIndex = 109
        Me.ToolTip1.SetToolTip(Me.seccion1, "Seccion.")
        '
        'ja
        '
        Me.ja.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ja.AllowEditing = False
        Me.ja.AllowFiltering = True
        Me.ja.BackColor = System.Drawing.Color.White
        Me.ja.ColumnInfo = resources.GetString("ja.ColumnInfo")
        Me.ja.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ja.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.ja.ForeColor = System.Drawing.Color.Black
        Me.ja.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.ja.Location = New System.Drawing.Point(20, 97)
        Me.ja.Name = "ja"
        Me.ja.Rows.Count = 1
        Me.ja.Rows.DefaultSize = 25
        Me.ja.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ja.Size = New System.Drawing.Size(1047, 606)
        Me.ja.StyleInfo = resources.GetString("ja.StyleInfo")
        Me.ja.TabIndex = 114
        Me.ToolTip1.SetToolTip(Me.ja, "Area de Datos.")
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(948, 19)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(60, 40)
        Me.r1.TabIndex = 112
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r1, "Limpia datos sin Grabar ni Eliminar.")
        Me.r1.UseVisualStyleBackColor = False
        '
        'g1
        '
        Me.g1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g1.ForeColor = System.Drawing.Color.Black
        Me.g1.Image = CType(resources.GetObject("g1.Image"), System.Drawing.Image)
        Me.g1.Location = New System.Drawing.Point(882, 19)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(60, 40)
        Me.g1.TabIndex = 111
        Me.g1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.g1, "Graba y Actualiza registros.")
        Me.g1.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(141, 45)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(171, 26)
        Me.fecha.TabIndex = 98
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha del descanso")
        '
        'fecha1
        '
        Me.fecha1.CustomFormat = "dd/MM/yyyy"
        Me.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha1.Location = New System.Drawing.Point(144, 50)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(171, 26)
        Me.fecha1.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.fecha1, "Fecha de Sábado o Domingo que se trabajará.")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 672)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Para Seleccionar un Registro  presione doble click en el Mouse."
        '
        'tm
        '
        Me.tm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tm.CanCloseTabs = True
        Me.tm.CanMoveTabs = True
        Me.tm.Controls.Add(Me.d1)
        Me.tm.Controls.Add(Me.d2)
        Me.tm.Controls.Add(Me.d3)
        Me.tm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm.ItemSize = New System.Drawing.Size(0, 30)
        Me.tm.Location = New System.Drawing.Point(0, 12)
        Me.tm.Name = "tm"
        Me.tm.Size = New System.Drawing.Size(1089, 756)
        Me.tm.TabIndex = 70
        Me.tm.TabsSpacing = -1
        Me.tm.TabStyle = C1.Win.C1Command.TabStyleEnum.Rounded
        Me.tm.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        '
        'd1
        '
        Me.d1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.d1.Controls.Add(Me.motivo)
        Me.d1.Controls.Add(Me.Label4)
        Me.d1.Controls.Add(Me.Elimina)
        Me.d1.Controls.Add(Me.fecha)
        Me.d1.Controls.Add(Me.seccion)
        Me.d1.Controls.Add(Me.fg)
        Me.d1.Controls.Add(Me.Label3)
        Me.d1.Controls.Add(Me.regresa)
        Me.d1.Controls.Add(Me.graba)
        Me.d1.Controls.Add(Me.Label2)
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(1, 33)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(1087, 722)
        Me.d1.TabBackColor = System.Drawing.Color.Yellow
        Me.d1.TabBackColorSelected = System.Drawing.Color.White
        Me.d1.TabForeColor = System.Drawing.Color.Black
        Me.d1.TabForeColorSelected = System.Drawing.Color.Black
        Me.d1.TabIndex = 0
        Me.d1.Text = "Descansos"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 24)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Motivo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Sección:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd2
        '
        Me.d2.Controls.Add(Me.Button1)
        Me.d2.Controls.Add(Me.jg)
        Me.d2.Location = New System.Drawing.Point(1, 33)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(1087, 722)
        Me.d2.TabBackColor = System.Drawing.Color.DeepSkyBlue
        Me.d2.TabBackColorSelected = System.Drawing.Color.White
        Me.d2.TabIndex = 1
        Me.d2.Text = "Elimina Descansos"
        '
        'd3
        '
        Me.d3.Controls.Add(Me.e1)
        Me.d3.Controls.Add(Me.fecha1)
        Me.d3.Controls.Add(Me.seccion1)
        Me.d3.Controls.Add(Me.ja)
        Me.d3.Controls.Add(Me.Label6)
        Me.d3.Controls.Add(Me.r1)
        Me.d3.Controls.Add(Me.g1)
        Me.d3.Controls.Add(Me.Label7)
        Me.d3.Location = New System.Drawing.Point(1, 33)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(1087, 722)
        Me.d3.TabBackColor = System.Drawing.Color.SandyBrown
        Me.d3.TabBackColorSelected = System.Drawing.Color.White
        Me.d3.TabForeColor = System.Drawing.Color.Black
        Me.d3.TabForeColorSelected = System.Drawing.Color.Black
        Me.d3.TabIndex = 2
        Me.d3.Text = "Trabajo Fin de Semana"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 24)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Fecha:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(28, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Sección:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Secciones_vac2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1089, 768)
        Me.Controls.Add(Me.tm)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Secciones_vac2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descansos por Sección"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tm.ResumeLayout(False)
        Me.d1.ResumeLayout(False)
        Me.d2.ResumeLayout(False)
        Me.d3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tipos_cobro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler seccion.KeyPress, AddressOf keypressed1
        AddHandler fecha.KeyPress, AddressOf keypressed2
        AddHandler motivo.KeyPress, AddressOf keypressed3
        AddHandler seccion1.KeyPress, AddressOf keypressed4
        AddHandler fecha1.KeyPress, AddressOf keypressed5
        Dim dr As DataRow
        llena_tablas(sec, "SELECT SECCION FROM SECCIONES WHERE ACTIVA = 'S'", cnn)
        seccion.Items.Add("TODAS LAS SECCIONES")
        For Each dr In sec.Rows
            seccion.Items.Add(dr("SECCION"))
            seccion1.Items.Add(dr("SECCION"))
        Next
        Try
            seccion.SelectedIndex = 0
            seccion1.SelectedIndex = 0
        Catch ex As Exception
        End Try
        Try
            motivo.SelectedIndex = 0
        Catch ex As Exception
        End Try
        setea_fg()
    End Sub
    Private Sub limpia_variables()
        seccion.SelectedIndex = 0
        fecha.Value = Today
        seccion.Enabled = True
        fecha.Enabled = True
        motivo.Enabled = False
        Elimina.Visible = False
        graba.Visible = False
        seccion.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        limpia_variables()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        Dim l As Integer
        Dim hoy As String = Format(Today, "yyyy-MM-dd")
        llena_tablas(dt, "SELECT * FROM SECCIONES_DESCANSO WHERE TIPO = 'D' AND FECHA > = '" & hoy & "'", cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("SECCION")
            fg(l, 2) = dr("FECHA")
            fg(l, 3) = dr("MOTIVO")
            l = l + 1
        Next
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs)
        selecciona_registro()
    End Sub
    Private Sub selecciona_registro()
        Dim i As Integer = fg.RowSel
        Dim ok As Boolean
        seccion.Text = fg(i, 1)
        fecha.Value = fg(i, 2)
        busca_seccion(ok)
        habilita()
    End Sub

    Private Sub busca_seccion(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM SECCIONES_DESCANSO WHERE TIPO = 'D' AND  SECCION = '" & seccion.Text & "' AND FECHA = '" & Format(fecha.Value, "yyyy-MM-dd") & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            motivo.SelectedIndex = motivo.Items.IndexOf(dr("MOTIVO"))
            ok = True
            Elimina.Visible = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita()
        seccion.Enabled = False
        fecha.Enabled = False
        motivo.Enabled = True
        graba.Visible = True
        regresa.Visible = True
        motivo.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion.Text) <> "" Then
                fecha.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                busca_seccion(ok)
                habilita()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(motivo.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        graba_datos()
        setea_fg()
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha.Value, "yyyy-MM-dd")
        Dim secciones As String = ""
        Dim dr As DataRow

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            If seccion.SelectedIndex = 0 Then
                For Each dr In sec.Rows
                    secciones = dr("SECCION")
                    strsql = "UPDATE SECCIONES_DESCANSO SET MOTIVO = '" & motivo.Text & "' " & _
                                            " WHERE TIPO = 'D' AND  SECCION = '" & secciones & "' AND FECHA  = '" & finicial & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    If afectados = 0 Then
                        strsql = "INSERT INTO SECCIONES_DESCANSO (TIPO,SECCION,FECHA,MOTIVO) VALUES ('D','" & _
                                                            secciones & "','" & _
                                                            finicial & "','" & _
                                                            motivo.Text & "')"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                Next
            Else
                strsql = "UPDATE SECCIONES_DESCANSO SET MOTIVO = '" & motivo.Text & "' " & _
                                          " WHERE TIPO = 'D' AND  SECCION = '" & seccion.Text & "' AND FECHA  = '" & finicial & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                If afectados = 0 Then
                    strsql = "INSERT INTO SECCIONES_DESCANSO (TIPO,SECCION,FECHA,MOTIVO) VALUES ('D','" & _
                                                        seccion.Text & "','" & _
                                                        finicial & "','" & _
                                                        motivo.Text & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            End If
         
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_fg()
    End Sub

    Private Sub seccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles seccion.KeyPress
        AutoCompletar(seccion, e)
    End Sub
    Private Sub motivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles motivo.KeyPress
        AutoCompletar(motivo, e)
    End Sub

    Private Sub seccion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles seccion1.KeyPress
        AutoCompletar(seccion1, e)
    End Sub

    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SECCIONES_DESCANSO WHERE TIPO = 'D' AND SECCION = '" & seccion.Text & "' AND FECHA = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Elimina_Click(sender As System.Object, e As System.EventArgs) Handles Elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        setea_fg()
    End Sub

    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.SelectedIndexChanged
        Select Case tm.SelectedIndex
            Case 0
                descansos()
            Case 1
                elimina_grupo()
            Case 2
                fin_de_semana()
        End Select
    End Sub
    Private Sub descansos()
        limpia_variables()
    End Sub

    Private Sub elimina_grupo()
        setea_jg()
    End Sub

    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
        llena_jg()
    End Sub
    Private Sub llena_jg()
        Dim l As Integer
        Dim hoy As String = Format(Today, "yyyy-MM-dd")
        llena_tablas(dt, "SELECT * FROM SECCIONES_DESCANSO WHERE TIPO = 'D' AND FECHA > = '" & hoy & "'", cnn)
        l = 1
        jg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            jg(l, 1) = dr("SECCION")
            jg(l, 2) = dr("FECHA")
            jg(l, 3) = dr("MOTIVO")
            jg(l, 4) = False
            l = l + 1
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar todos los datos Seleccionados?  ", MsgBoxStyle.YesNo, "Eliminando Registros !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_grupos()
            setea_jg()
        End If
    End Sub


    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_grupos()
        Dim strsql As String
        Dim afectados As Integer
        Dim fechas As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To jg.Rows.Count - 1
                If jg(i, 4) = True Then
                    fechas = Format(jg(i, 2), "yyyy-MM-dd")
                    strsql = "DELETE SECCIONES_DESCANSO WHERE TIPO = 'D' AND SECCION = '" & jg(i, 1) & "' AND FECHA  = '" & fechas & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If

            Next
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub
    '=========================================================== FINES DE SEMANA =====================================================================
    Private Sub fin_de_semana()
        setea_ja()
        seccion1.Focus()
    End Sub

    Private Sub setea_ja()
        ja.Rows.Count = 1
        ja.Rows(0).Height = 30
        llena_ja()
    End Sub
    Private Sub llena_ja()
        Dim l As Integer
        Dim hoy As String = Format(Today, "yyyy-MM-dd")
        llena_tablas(dt, "SELECT * FROM SECCIONES_DESCANSO WHERE TIPO = 'F' AND FECHA > = '" & hoy & "'", cnn)
        l = 1
        ja.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            ja(l, 1) = dr("SECCION")
            ja(l, 2) = dr("FECHA")
            ja(l, 3) = dr("MOTIVO")
            l = l + 1
        Next
    End Sub

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion1.Text) <> "" Then
                fecha1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha1.Text) <> "" Then
                g1.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub es_fin_de_Semana(ByVal fechas As Date, ByRef ok As Boolean)
        Dim sabdom As String = "06"
        Dim d As Integer = fechas.DayOfWeek
        If sabdom.IndexOf(d) > -1 Then
            ok = True
        Else
            ok = False
            MsgBox("El día seleccionado no es Fin de Semana.", MsgBoxStyle.ApplicationModal, "Por favor revise !!!")
        End If
    End Sub

    Private Sub e1_Click(sender As System.Object, e As System.EventArgs) Handles e1.Click
        Dim ok As Boolean
        es_fin_de_Semana(fecha1.Value, ok)
        If ok Then
            elimina_fin()
        End If
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos_fin()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha1.Value, "yyyy-MM-dd")
        Dim secciones As String = ""


        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SECCIONES_DESCANSO SET MOTIVO = 'TRABAJO EXTRA' " & _
                                          " WHERE TIPO = 'F' AND  SECCION = '" & seccion1.Text & "' AND FECHA  = '" & finicial & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                If afectados = 0 Then
                strsql = "INSERT INTO SECCIONES_DESCANSO (TIPO,SECCION,FECHA,MOTIVO) VALUES ('F','" & _
                                                    seccion1.Text & "','" & _
                                                    finicial & "','TRABAJO EXTRA')"
                comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_fin()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha1.Value, "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try

            strsql = "DELETE SECCIONES_DESCANSO WHERE TIPO = 'F' AND SECCION = '" & seccion1.Text & "' AND FECHA = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ja_Click(sender As System.Object, e As System.EventArgs) Handles ja.KeyPress
        elige_ja()
    End Sub

    Private Sub g1_Click(sender As System.Object, e As System.EventArgs) Handles g1.Click
        Dim ok As Boolean
        es_fin_de_Semana(fecha1.Value, ok)
        If ok Then
            graba_datos_fin()
            setea_ja()
        End If
    End Sub

    Private Sub elige_ja()
        Dim f As Integer = ja.RowSel
        Try
            seccion1.SelectedIndex = seccion1.Items.IndexOf(ja(f, 1))
            fecha1.Value = CDate(ja(f, 2))
        Catch
        End Try
    End Sub

    Private Sub ja_Click_1(sender As System.Object, e As System.EventArgs) Handles ja.Click
        elige_ja()
    End Sub
End Class

