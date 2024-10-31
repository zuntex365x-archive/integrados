Imports C1.Win.C1FlexGrid

Public Class Estilos
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim dr As DataRow
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents empaque As System.Windows.Forms.CheckBox
    Friend WithEvents lavado As System.Windows.Forms.CheckBox
    Friend WithEvents tenido As System.Windows.Forms.CheckBox
    Friend WithEvents costura As System.Windows.Forms.CheckBox
    Friend WithEvents serigra As System.Windows.Forms.CheckBox
    Friend WithEvents bordado As System.Windows.Forms.CheckBox
    Friend WithEvents corte As System.Windows.Forms.CheckBox
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents programa As System.Windows.Forms.TextBox
    Friend WithEvents vcorte As C1.Win.C1Input.C1TextBox
    Dim nuevo As Boolean
    Dim usuario As String
    Friend WithEvents votros As C1.Win.C1Input.C1TextBox
    Friend WithEvents vempaque As C1.Win.C1Input.C1TextBox
    Friend WithEvents vhilo As C1.Win.C1Input.C1TextBox
    Friend WithEvents vcostura As C1.Win.C1Input.C1TextBox
    Dim empre As New empresas
    Dim obj As New empresas
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estilos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.votros = New C1.Win.C1Input.C1TextBox()
        Me.vempaque = New C1.Win.C1Input.C1TextBox()
        Me.vhilo = New C1.Win.C1Input.C1TextBox()
        Me.vcostura = New C1.Win.C1Input.C1TextBox()
        Me.vcorte = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.empaque = New System.Windows.Forms.CheckBox()
        Me.lavado = New System.Windows.Forms.CheckBox()
        Me.tenido = New System.Windows.Forms.CheckBox()
        Me.costura = New System.Windows.Forms.CheckBox()
        Me.serigra = New System.Windows.Forms.CheckBox()
        Me.bordado = New System.Windows.Forms.CheckBox()
        Me.corte = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.estilo = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.programa = New System.Windows.Forms.TextBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.votros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vempaque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vhilo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcostura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Programa:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Estilo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 350)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1016, 322)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(880, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
        Me.graba.TabIndex = 18
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Actualiza Registro.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(920, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpia variables")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 24)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Bordado:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Sublima/Teñido:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 24)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Empaque:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 24)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Costura:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Lavado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripcion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(587, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 24)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Corte:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(296, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Operaciones"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Corte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Serigrafía:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label8, "Necesita Serigrafía?")
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SteelBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(587, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 24)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Empaque:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(587, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 24)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Hilo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.votros)
        Me.GroupBox1.Controls.Add(Me.vempaque)
        Me.GroupBox1.Controls.Add(Me.vhilo)
        Me.GroupBox1.Controls.Add(Me.vcostura)
        Me.GroupBox1.Controls.Add(Me.vcorte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.empaque)
        Me.GroupBox1.Controls.Add(Me.lavado)
        Me.GroupBox1.Controls.Add(Me.tenido)
        Me.GroupBox1.Controls.Add(Me.costura)
        Me.GroupBox1.Controls.Add(Me.serigra)
        Me.GroupBox1.Controls.Add(Me.bordado)
        Me.GroupBox1.Controls.Add(Me.corte)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 216)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'votros
        '
        Me.votros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.votros.CustomFormat = "##,##0.00"
        Me.votros.DataType = GetType(Decimal)
        Me.votros.DisplayFormat.CustomFormat = "###,##0.00"
        Me.votros.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.votros.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.votros.DisplayFormat.NullText = "0"
        Me.votros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votros.Location = New System.Drawing.Point(776, 136)
        Me.votros.MaxLength = 6
        Me.votros.Name = "votros"
        Me.votros.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.votros.ParseInfo.CustomFormat = "####0"
        Me.votros.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.votros.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.votros.PostValidation.ErrorMessage = "Por favor un valor válido"
        Me.votros.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.votros.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 131072}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.votros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.votros.Size = New System.Drawing.Size(108, 22)
        Me.votros.TabIndex = 15
        Me.votros.Tag = Nothing
        Me.votros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.votros.TrimStart = True
        Me.votros.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.votros.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'vempaque
        '
        Me.vempaque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vempaque.CustomFormat = "##,##0.00"
        Me.vempaque.DataType = GetType(Decimal)
        Me.vempaque.DisplayFormat.CustomFormat = "###,##0.00"
        Me.vempaque.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.vempaque.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.vempaque.DisplayFormat.NullText = "0"
        Me.vempaque.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vempaque.Location = New System.Drawing.Point(776, 111)
        Me.vempaque.MaxLength = 6
        Me.vempaque.Name = "vempaque"
        Me.vempaque.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.vempaque.ParseInfo.CustomFormat = "####0"
        Me.vempaque.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.vempaque.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.vempaque.PostValidation.ErrorMessage = "Por favor un valor válido"
        Me.vempaque.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.vempaque.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 131072}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.vempaque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.vempaque.Size = New System.Drawing.Size(108, 22)
        Me.vempaque.TabIndex = 14
        Me.vempaque.Tag = Nothing
        Me.vempaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vempaque.TrimStart = True
        Me.vempaque.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.vempaque.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'vhilo
        '
        Me.vhilo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vhilo.CustomFormat = "##,##0.00"
        Me.vhilo.DataType = GetType(Decimal)
        Me.vhilo.DisplayFormat.CustomFormat = "###,##0.00"
        Me.vhilo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.vhilo.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.vhilo.DisplayFormat.NullText = "0"
        Me.vhilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhilo.Location = New System.Drawing.Point(776, 88)
        Me.vhilo.MaxLength = 6
        Me.vhilo.Name = "vhilo"
        Me.vhilo.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.vhilo.ParseInfo.CustomFormat = "####0"
        Me.vhilo.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.vhilo.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.vhilo.PostValidation.ErrorMessage = "Por favor un valor válido"
        Me.vhilo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.vhilo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 131072}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.vhilo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.vhilo.Size = New System.Drawing.Size(108, 22)
        Me.vhilo.TabIndex = 13
        Me.vhilo.Tag = Nothing
        Me.vhilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vhilo.TrimStart = True
        Me.vhilo.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.vhilo.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'vcostura
        '
        Me.vcostura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vcostura.CustomFormat = "##,##0.00"
        Me.vcostura.DataType = GetType(Decimal)
        Me.vcostura.DisplayFormat.CustomFormat = "###,##0.00"
        Me.vcostura.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.vcostura.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.vcostura.DisplayFormat.NullText = "0"
        Me.vcostura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcostura.Location = New System.Drawing.Point(776, 64)
        Me.vcostura.MaxLength = 6
        Me.vcostura.Name = "vcostura"
        Me.vcostura.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.vcostura.ParseInfo.CustomFormat = "####0"
        Me.vcostura.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.vcostura.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.vcostura.PostValidation.ErrorMessage = "Por favor un valor válido"
        Me.vcostura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.vcostura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 131072}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.vcostura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.vcostura.Size = New System.Drawing.Size(108, 22)
        Me.vcostura.TabIndex = 12
        Me.vcostura.Tag = Nothing
        Me.vcostura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vcostura.TrimStart = True
        Me.vcostura.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.vcostura.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'vcorte
        '
        Me.vcorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vcorte.CustomFormat = "##,##0.00"
        Me.vcorte.DataType = GetType(Decimal)
        Me.vcorte.DisplayFormat.CustomFormat = "###,##0.00"
        Me.vcorte.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.vcorte.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.vcorte.DisplayFormat.NullText = "0"
        Me.vcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcorte.Location = New System.Drawing.Point(776, 40)
        Me.vcorte.MaxLength = 6
        Me.vcorte.Name = "vcorte"
        Me.vcorte.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.vcorte.ParseInfo.CustomFormat = "####0"
        Me.vcorte.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.vcorte.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.vcorte.PostValidation.ErrorMessage = "Por favor un valor válido"
        Me.vcorte.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.vcorte.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 131072}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.vcorte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.vcorte.Size = New System.Drawing.Size(108, 22)
        Me.vcorte.TabIndex = 11
        Me.vcorte.Tag = Nothing
        Me.vcorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.vcorte.TrimStart = True
        Me.vcorte.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.vcorte.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(588, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 24)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Precio Manufactura"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'empaque
        '
        Me.empaque.AutoSize = True
        Me.empaque.Location = New System.Drawing.Point(238, 189)
        Me.empaque.Name = "empaque"
        Me.empaque.Size = New System.Drawing.Size(15, 14)
        Me.empaque.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.empaque, "Es necesario empacar las prendas?")
        Me.empaque.UseVisualStyleBackColor = True
        '
        'lavado
        '
        Me.lavado.AutoSize = True
        Me.lavado.Location = New System.Drawing.Point(238, 165)
        Me.lavado.Name = "lavado"
        Me.lavado.Size = New System.Drawing.Size(15, 14)
        Me.lavado.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lavado, "Se lavan antes de empacar?")
        Me.lavado.UseVisualStyleBackColor = True
        '
        'tenido
        '
        Me.tenido.AutoSize = True
        Me.tenido.Location = New System.Drawing.Point(238, 141)
        Me.tenido.Name = "tenido"
        Me.tenido.Size = New System.Drawing.Size(15, 14)
        Me.tenido.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.tenido, "Es necesario Teñido?")
        Me.tenido.UseVisualStyleBackColor = True
        '
        'costura
        '
        Me.costura.AutoSize = True
        Me.costura.Location = New System.Drawing.Point(238, 117)
        Me.costura.Name = "costura"
        Me.costura.Size = New System.Drawing.Size(15, 14)
        Me.costura.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.costura, "Se efectúa la Operación de Costura?")
        Me.costura.UseVisualStyleBackColor = True
        '
        'serigra
        '
        Me.serigra.AutoSize = True
        Me.serigra.Location = New System.Drawing.Point(238, 93)
        Me.serigra.Name = "serigra"
        Me.serigra.Size = New System.Drawing.Size(15, 14)
        Me.serigra.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.serigra, "Necesita Serigrafía?")
        Me.serigra.UseVisualStyleBackColor = True
        '
        'bordado
        '
        Me.bordado.AutoSize = True
        Me.bordado.Location = New System.Drawing.Point(238, 69)
        Me.bordado.Name = "bordado"
        Me.bordado.Size = New System.Drawing.Size(15, 14)
        Me.bordado.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.bordado, "Se Bordan las prendas?")
        Me.bordado.UseVisualStyleBackColor = True
        '
        'corte
        '
        Me.corte.AutoSize = True
        Me.corte.Location = New System.Drawing.Point(238, 45)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(15, 14)
        Me.corte.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.corte, "Se cortan las Prendas del Estilo?")
        Me.corte.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(587, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 24)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Costura:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(587, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 24)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Serigrafía:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(136, 8)
        Me.cliente.MaxLength = 10
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(232, 24)
        Me.cliente.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente.")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 672)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'estilo
        '
        Me.estilo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.Location = New System.Drawing.Point(136, 38)
        Me.estilo.MaxLength = 20
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(232, 22)
        Me.estilo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.estilo, "Estilo.")
        '
        'descripcion
        '
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(136, 64)
        Me.descripcion.MaxLength = 50
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(613, 22)
        Me.descripcion.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.descripcion, "Descripcion del Estilo.")
        '
        'programa
        '
        Me.programa.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programa.Location = New System.Drawing.Point(136, 90)
        Me.programa.MaxLength = 50
        Me.programa.Name = "programa"
        Me.programa.Size = New System.Drawing.Size(613, 22)
        Me.programa.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.programa, "Programa al que pertenece el Estilo.")
        '
        'Estilos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.programa)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estilos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Estilos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.votros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vempaque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vhilo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcostura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Estilos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler estilo.KeyPress, AddressOf keypressed2
        AddHandler descripcion.KeyPress, AddressOf keypressed3
        AddHandler programa.KeyPress, AddressOf keypressed4
        AddHandler corte.KeyPress, AddressOf keypressed5
        AddHandler bordado.KeyPress, AddressOf keypressed6
        AddHandler serigra.KeyPress, AddressOf keypressed7
        AddHandler costura.KeyPress, AddressOf keypressed8
        AddHandler tenido.KeyPress, AddressOf keypressed9
        AddHandler lavado.KeyPress, AddressOf keypressed9A
        AddHandler empaque.KeyPress, AddressOf keypressed10
        AddHandler vcorte.KeyPress, AddressOf keypressed11
        AddHandler vcostura.KeyPress, AddressOf keypressed12
        AddHandler vhilo.KeyPress, AddressOf keypressed13
        AddHandler vempaque.KeyPress, AddressOf keypressed14
        AddHandler votros.KeyPress, AddressOf keypressed15
        usuario = empre.clave
        llena_clientes_usuario(cliente, usuario, "ESTILO")
        If cliente.Items.Count = 0 Then
            MsgBox("Usted no tiene los Derechos Suficientes para Accesar este Programa", MsgBoxStyle.Critical, "ACCESO DENEGADO")
            Close()
        End If
        Try
            cliente.SelectedIndex = 0
        Catch ex As Exception
        End Try
        set_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE = '" & cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("O1")
            fg(lineas, 3) = dr("O2")
            fg(lineas, 4) = dr("O3")
            fg(lineas, 5) = dr("O4")
            fg(lineas, 6) = dr("O5")
            fg(lineas, 7) = dr("O6")
            fg(lineas, 8) = dr("O7")
            lineas = lineas + 1
        Next
    End Sub
    Private Sub set_variables()
        estilo.Text = ""
        descripcion.Text = ""
        programa.Text = ""
        corte.Checked = True
        bordado.Checked = False
        serigra.Checked = False
        costura.Checked = True
        tenido.Checked = False
        lavado.Checked = False
        empaque.Checked = False
        vcorte.Text = "0.00"
        vcostura.Text = "0.00"
        vhilo.Text = "0.00"
        vempaque.Text = "0.00"
        votros.Text = "0.00"
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim dt As New DataTable()
            If Trim(cliente.Text) <> "" Then
                estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(estilo.Text) <> "" Then
                busca_estilo()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descripcion.Text) <> "" Then
                programa.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            corte.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            bordado.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            serigra.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            costura.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            tenido.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            lavado.Focus()
        End If
    End Sub 'keypressed
    Private Sub keypressed9A(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            empaque.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed10(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            vcorte.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed11(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            vcostura.Focus()
        End If
    End Sub 'keypressed


    Private Sub keypressed12(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            vhilo.Focus()
        End If
    End Sub 'keypressed
    Private Sub keypressed13(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            vempaque.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed14(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            votros.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed15(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            graba.Focus()
        End If
    End Sub 'keypressed
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var)
    End Sub

    Private Sub busca_estilo()
        Dim dt As New DataTable()
        Dim dr As DataRow

        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            EXISTE = False
            nuevo = True
        Else
            For Each dr In dt.Rows
                EXISTE = True
                nuevo = False
                llena_Variables(dr)
                Button3.Visible = True
            Next
        End If
        descripcion.Focus()
    End Sub

    Private Sub llena_Variables(ByVal dr As DataRow)
        descripcion.Text = dr("DESCRIPCION")
        programa.Text = dr("PROGRAMA")
        corte.Checked = dr("O1")
        bordado.Checked = dr("O2")
        serigra.Checked = dr("O3")
        costura.Checked = dr("O4")
        tenido.Checked = dr("O5")
        lavado.Checked = dr("O6")
        empaque.Checked = dr("O7")
        vcorte.Text = dr("CORTE")
        vcostura.Text = dr("COSTURA")
        vempaque.Text = dr("EMPAQUE")
        votros.Text = dr("OTROS")
        vhilo.Text = dr("HILO")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean = False
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar los Datos?  ", MsgBoxStyle.YesNo, "Actualiza Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_datos(ok)
            If ok Then
                graba_registros()
                envia_correo()
                setea_grid()
                set_variables()
            End If
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim valor As Decimal = 0

        ' Mensaje para verificar los valores actuales de los campos antes de la validación
        MsgBox("Verificando los siguientes valores: " & vbCrLf &
           "Corte: " & vcorte.Text & vbCrLf &
           "Costura: " & vcostura.Text & vbCrLf &
           "Hilo: " & vhilo.Text & vbCrLf &
           "Empaque: " & vempaque.Text & vbCrLf &
           "Otros: " & votros.Text)

        If Trim(estilo.Text) = "" Then
            mensaje("Debe de ingresar la No de Estilo")
            Exit Sub
        End If

        If Trim(descripcion.Text) = "" Then
            mensaje("Debe de ingresar la Descripción del Estilo")
            Exit Sub
        End If

        ' Capturar posibles errores en la conversión de los valores numéricos
        Try
            valor = CDec(vcorte.Text) + CDec(vcostura.Text) + CDec(vhilo.Text) + CDec(vempaque.Text) + CDec(votros.Text)
        Catch ex As Exception
            mensaje("Error al convertir los valores numéricos: " & ex.Message)
            Exit Sub
        End Try

        If valor = 0 Then
            mensaje("Debe de ingresar el valor de Manufactura")
            Exit Sub
        End If

        ok = True
    End Sub

    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim v(10) As Integer

        If corte.Checked Then
            v(1) = 1
        End If
        If bordado.Checked Then
            v(2) = 1
        End If
        If serigra.Checked Then
            v(3) = 1
        End If
        If costura.Checked Then
            v(4) = 1
        End If
        If tenido.Checked Then
            v(5) = 1
        End If
        If lavado.Checked Then
            v(6) = 1
        End If
        If empaque.Checked Then
            v(7) = 1
        End If
        v(8) = 1
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== ACTUALIZA ESTILOS
            strSQL = "UPDATE ESTILOS SET O1 = " & v(1) & ",O2 = " & v(2) & ",O3 = " & v(3) & ",O4 = " & v(4) & ",O5 = " & v(5) & ",O6 = " & v(6) & ",O7 = " & v(7) & ",O8 = " & v(8) & ",PROGRAMA = '" & programa.Text & "',DESCRIPCION = '" & descripcion.Text & "', " & _
                                            "CORTE = " & vcorte.Text & ",COSTURA = " & vcostura.Text & ",HILO = " & vhilo.Text & ",EMPAQUE  = " & vempaque.Text & ",OTROS = " & votros.Text & _
                                            " WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO ESTILOS (CLIENTE,ESTILO,O1,O2,O3,O4,O5,O6,O7,O8,PROGRAMA,DESCRIPCION,CORTE,COSTURA,HILO,EMPAQUE,OTROS,DESCRIPCION1)" & _
                                                  " VALUES ( '" & cliente.Text & "','" & _
                                                                 estilo.Text & "'," & _
                                                                 v(1) & "," & _
                                                                 v(2) & "," & _
                                                                 v(3) & "," & _
                                                                 v(4) & "," & _
                                                                 v(5) & "," & _
                                                                 v(6) & "," & _
                                                                 v(7) & "," & _
                                                                 v(8) & ",'" & _
                                                                 programa.Text & "','" & _
                                                                 descripcion.Text & "','" & _
                                                                 vcorte.Text & "','" & _
                                                                 vcostura.Text & "','" & _
                                                                 vhilo.Text & "','" & _
                                                                 vempaque.Text & "','" & _
                                                                 votros.Text & "',' ')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
           
            End If

            strSQL = "INSERT INTO ESTILOS_LOG SELECT getdate() as FECHA, '" & obj.usuario & "' AS USUARIO,* FROM ESTILOS WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            estilo.Text = fg(fil, 1)
            busca_estilo()
        End If
    End Sub
    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        fg(lineas, 1) = cliente.Text
        fg(lineas, 2) = corte.Checked
        fg(lineas, 3) = bordado.Checked
        fg(lineas, 4) = serigra.Checked
        fg(lineas, 5) = costura.Checked
        fg(lineas, 6) = tenido.Checked
        fg(lineas, 7) = lavado.Checked
        fg(lineas, 8) = empaque.Checked
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        llena_grid()
        estilo.Enabled = True
    End Sub

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        setea_grid()
        llena_grid()
        set_variables()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        set_variables()
        estilo.Focus()
    End Sub


    Private Sub envia_correo()
        Dim asunto As String
        Dim mensaje As String
        Dim ok As Boolean = False
        asunto = "Actualizacion de Datos del Estilo: " + estilo.Text
        mensaje = " " + vbLf + vbLf
        mensaje = "  " + vbLf + vbLf
        mensaje = "Actualizacion de Datos del Estilo: " + estilo.Text

        mensaje = mensaje + vbLf + vbLf + vbLf + "Cambio realializado por: " + obj.usuario
        envia_corrreo_estilo(asunto, mensaje, ok)
    End Sub
End Class
