Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Proyecciones
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ship As System.Windows.Forms.DateTimePicker
    Friend WithEvents cpo As C1.Win.C1Input.C1TextBox
    Friend WithEvents estilo As C1.Win.C1Input.C1TextBox
    Friend WithEvents colores As C1.Win.C1Input.C1TextBox
    Friend WithEvents prioridad As C1.Win.C1Input.C1TextBox
    Friend WithEvents dificultad As C1.Win.C1Input.C1TextBox
    Friend WithEvents prendas As C1.Win.C1Input.C1TextBox
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents sigue As System.Windows.Forms.Button
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents seccion As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proyecciones))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.regresa = New System.Windows.Forms.Button()
        Me.Elimina = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.seccion = New System.Windows.Forms.ComboBox()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.sigue = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ship = New System.Windows.Forms.DateTimePicker()
        Me.cpo = New C1.Win.C1Input.C1TextBox()
        Me.estilo = New C1.Win.C1Input.C1TextBox()
        Me.colores = New C1.Win.C1Input.C1TextBox()
        Me.prioridad = New C1.Win.C1Input.C1TextBox()
        Me.dificultad = New C1.Win.C1Input.C1TextBox()
        Me.prendas = New C1.Win.C1Input.C1TextBox()
        Me.graba = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estilo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dificultad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(960, 10)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 67
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Elimina
        '
        Me.Elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina.ForeColor = System.Drawing.Color.Black
        Me.Elimina.Image = CType(resources.GetObject("Elimina.Image"), System.Drawing.Image)
        Me.Elimina.Location = New System.Drawing.Point(835, 10)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(60, 40)
        Me.Elimina.TabIndex = 68
        Me.Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina, "Elimina Registros")
        Me.Elimina.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 189)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 475)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'seccion
        '
        Me.seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seccion.Items.AddRange(New Object() {"1", "2"})
        Me.seccion.Location = New System.Drawing.Point(133, 10)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(231, 24)
        Me.seccion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.seccion, "Nomina")
        '
        'cliente
        '
        Me.cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cliente.Items.AddRange(New Object() {"1", "2"})
        Me.cliente.Location = New System.Drawing.Point(652, 10)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(170, 24)
        Me.cliente.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cliente, "Nomina")
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(898, 10)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 92
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Chequeo de Datos")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Sección:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(545, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "CPO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Estilo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 24)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Color:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Prioridad:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Dificultad:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(545, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 24)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Prendas:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(545, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 24)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Ship Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ship
        '
        Me.ship.CustomFormat = "dd/MM/yyyy"
        Me.ship.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ship.Location = New System.Drawing.Point(679, 128)
        Me.ship.Name = "ship"
        Me.ship.Size = New System.Drawing.Size(171, 22)
        Me.ship.TabIndex = 90
        '
        'cpo
        '
        Me.cpo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cpo.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(133, 39)
        Me.cpo.MaxLength = 20
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(231, 22)
        Me.cpo.TabIndex = 3
        Me.cpo.Tag = Nothing
        Me.cpo.TrimStart = True
        Me.cpo.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'estilo
        '
        Me.estilo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.estilo.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.Location = New System.Drawing.Point(133, 64)
        Me.estilo.MaxLength = 20
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(231, 22)
        Me.estilo.TabIndex = 4
        Me.estilo.Tag = Nothing
        Me.estilo.TrimStart = True
        Me.estilo.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'colores
        '
        Me.colores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.colores.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.Location = New System.Drawing.Point(133, 88)
        Me.colores.MaxLength = 25
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(231, 22)
        Me.colores.TabIndex = 5
        Me.colores.Tag = Nothing
        Me.colores.TrimStart = True
        Me.colores.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'prioridad
        '
        Me.prioridad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prioridad.CustomFormat = "##.00"
        Me.prioridad.DataType = GetType(Decimal)
        Me.prioridad.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.prioridad.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.prioridad.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prioridad.Location = New System.Drawing.Point(133, 132)
        Me.prioridad.MaxLength = 5
        Me.prioridad.Name = "prioridad"
        Me.prioridad.PostValidation.ErrorMessage = "Por favor ingrese un valor entre 0.01 y 99.99"
        Me.prioridad.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.prioridad.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {1, 0, 0, 131072}), New Decimal(New Integer() {99999, 0, 0, 131072}), True, True)})
        Me.prioridad.Size = New System.Drawing.Size(231, 22)
        Me.prioridad.TabIndex = 6
        Me.prioridad.Tag = Nothing
        Me.prioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prioridad.TrimStart = True
        Me.prioridad.Value = New Decimal(New Integer() {9999, 0, 0, 131072})
        Me.prioridad.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'dificultad
        '
        Me.dificultad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dificultad.CustomFormat = "##0"
        Me.dificultad.DataType = GetType(Integer)
        Me.dificultad.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.dificultad.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dificultad.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dificultad.Location = New System.Drawing.Point(133, 157)
        Me.dificultad.MaxLength = 3
        Me.dificultad.Name = "dificultad"
        Me.dificultad.PostValidation.ErrorMessage = "Por favor ingrese un número entre 1 y 100."
        Me.dificultad.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.dificultad.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(1, 100, True, True)})
        Me.dificultad.Size = New System.Drawing.Size(231, 22)
        Me.dificultad.TabIndex = 7
        Me.dificultad.Tag = Nothing
        Me.dificultad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dificultad.TrimStart = True
        Me.dificultad.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'prendas
        '
        Me.prendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.prendas.CustomFormat = "####,##0"
        Me.prendas.DataType = GetType(Integer)
        Me.prendas.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.prendas.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.prendas.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prendas.Location = New System.Drawing.Point(678, 153)
        Me.prendas.MaxLength = 7
        Me.prendas.Name = "prendas"
        Me.prendas.PostValidation.ErrorMessage = "Por favor ingrese un número de prendas entre 1 y 999,999"
        Me.prendas.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.prendas.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(1, 9999999, True, True)})
        Me.prendas.Size = New System.Drawing.Size(174, 22)
        Me.prendas.TabIndex = 9
        Me.prendas.Tag = Nothing
        Me.prendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prendas.TrimStart = True
        Me.prendas.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(898, 10)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 91
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        Me.graba.Visible = False
        '
        'Proyecciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1023, 696)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.prendas)
        Me.Controls.Add(Me.dificultad)
        Me.Controls.Add(Me.prioridad)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.ship)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.seccion)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proyecciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecciones"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estilo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prioridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dificultad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tipos_cobro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler seccion.KeyPress, AddressOf keypressed1
        AddHandler cliente.KeyPress, AddressOf keypressed2
        AddHandler cpo.KeyPress, AddressOf keypressed3
        AddHandler estilo.KeyPress, AddressOf keypressed4
        AddHandler colores.KeyPress, AddressOf keypressed5
        AddHandler prioridad.KeyPress, AddressOf keypressed6
        AddHandler dificultad.KeyPress, AddressOf keypressed7
        AddHandler ship.KeyPress, AddressOf keypressed8
        AddHandler prendas.KeyPress, AddressOf keypressed9
        setea_fg()
        llena_combos(seccion, "SELECT SECCION FROM SECCIONES", "SECCION")
        llena_combos(cliente, "SELECT * FROM CLIENTES ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
    End Sub

    Private Sub limpia_variables()
        seccion.SelectedIndex = 0
        cliente.SelectedIndex = 0
        cpo.Value = ""
        estilo.Value = ""
        colores.Value = ""
        prioridad.Value = 99.9
        dificultad.Value = 100
        prendas.Value = 100
        seccion.Enabled = True
        cliente.Enabled = True
        cpo.Enabled = True
        estilo.Enabled = True
        colores.Enabled = True
        prioridad.Enabled = False
        dificultad.Enabled = False
        ship.Enabled = False
        prendas.Enabled = False
        Elimina.Visible = False
        graba.Visible = False
        sigue.Visible = True
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
        llena_tablas(dt, "SELECT * FROM PLAN_COSTURA_P", cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("SECCION")
            fg(l, 2) = dr("CLIENTE")
            fg(l, 3) = dr("CPO")
            fg(l, 4) = dr("ESTILO")
            fg(l, 5) = dr("COLOR")
            l = l + 1
        Next
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub

    Private Sub selecciona_registro()
        Dim i As Integer = fg.RowSel
        seccion.SelectedIndex = seccion.Items.IndexOf(fg(i, 1))
        cliente.SelectedIndex = cliente.Items.IndexOf(fg(i, 2))
        cpo.Value = fg(i, 3)
        estilo.Value = fg(i, 4)
        colores.Value = fg(i, 5)
        busca_proyeccion()
        graba.Visible = True
        Elimina.Visible = True
    End Sub

    Private Sub busca_proyeccion()
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM PLAN_COSTURA_P WHERE SECCION = '" & seccion.Text & "' AND CLIENTE = '" & cliente.Text & "' AND CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            prioridad.Value = dr("PRIORIDAD")
            dificultad.Value = dr("DIFICULTAD")
            ship.Value = dr("SHIP_DATE")
            prendas.Value = dr("PRENDAS")
            Elimina.Visible = True
        End If
        habilita()
    End Sub
    Private Sub habilita()
        seccion.Enabled = False
        cliente.Enabled = False
        cpo.Enabled = False
        estilo.Enabled = False
        colores.Enabled = False
        prioridad.Enabled = True
        dificultad.Enabled = True
        ship.Enabled = True
        prendas.Enabled = True
        graba.Visible = True
        regresa.Visible = True
        sigue.Visible = False
        prioridad.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion.Text) <> "" Then
                cliente.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion.Text) <> "" Then
                cpo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(9) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(9) Then
            e.Handled = True
            If Trim(estilo.Text) <> "" Then
                colores.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(9) Then
            e.Handled = True
            If Trim(colores.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(prioridad.Text) <> "" Then
                dificultad.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(dificultad.Text) <> "" Then
                ship.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(ship.Text) <> "" Then
                prendas.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(ship.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_datos(ByRef ok As Boolean)
        If (CDec(prioridad.Value) = 0) Or (CDec(dificultad.Value) = 0) Or (CDec(prendas.Value) = 0) Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar todos los datos solicitados", MsgBoxStyle.Critical, "Por favor revise !!!!")
        Else
            ok = True
        End If
    End Sub
    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim fecha As String = Format(ship.Value, "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE PLAN_COSTURA_P SET PRIORIDAD = '" & prioridad.Value & "', " & _
                                         "DIFICULTAD = '" & dificultad.Value & "', " & _
                                         "SHIP_DATE = '" & fecha & "', " & _
                                         "PRENDAS = '" & prendas.Value & "' " & _
                                         "WHERE SECCION = '" & seccion.Text & "' AND CLIENTE = '" & cliente.Text & "' AND CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO PLAN_COSTURA_P (SECCION,CLIENTE,CPO,ESTILO,COLOR,PRIORIDAD,DIFICULTAD,SHIP_DATE,PRENDAS,COMENTARIOS) VALUES ('" & _
                                                    seccion.Text & "','" & _
                                                    cliente.Text & "','" & _
                                                    cpo.Value & "','" & _
                                                    estilo.Value & "','" & _
                                                    colores.Value & "'," & _
                                                    prioridad.Value & "," & _
                                                    dificultad.Value & ",'" & _
                                                    fecha & "'," & _
                                                    prendas.Value & ",'')"
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
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM PLAN_COSTURA_P WHERE SECCION = '" & seccion.Text & "' AND CLIENTE = '" & cliente.Text & "' AND CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. Posiblemente tiene movimiento. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        setea_fg()
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            setea_fg()
        End If
    End Sub

    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        If (Trim(cpo.Value) <> "") And (Trim(estilo.Value) <> "") And (Trim(colores.Value) <> "") Then
            busca_proyeccion()
        End If
    End Sub
End Class

