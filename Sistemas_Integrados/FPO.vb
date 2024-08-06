Imports C1.Win.C1FlexGrid

Public Class FPO
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim TIPO As String
    Dim KNIT As String
    Dim COLOR As String
    Dim LOTES As String
    Dim CLIENTE As String
    Dim IFECHA As Date
    Dim CPO As String
    Dim ESTILO As String
    Dim YSIZE As String
    Dim YFIBER As String
    Dim YFINISH As String
    Dim PESO As String
    Dim ANCHO As String
    Dim LIBRAS As Integer
    Dim CUELLOS As Integer
    Dim RFECHA As Date
    Dim STATUS As String
    Dim lineas As Integer
    Dim dr As DataRow
    Friend WithEvents cpo_v As System.Windows.Forms.Button
    Friend WithEvents f_confirmada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Dim nuevo As Boolean
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents c0 As System.Windows.Forms.ComboBox
    Friend WithEvents c2 As System.Windows.Forms.ComboBox
    Friend WithEvents C3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents C5 As System.Windows.Forms.ComboBox
    Friend WithEvents C6 As System.Windows.Forms.ComboBox
    Friend WithEvents C7 As System.Windows.Forms.ComboBox
    Friend WithEvents C8 As System.Windows.Forms.ComboBox
    Friend WithEvents C9 As System.Windows.Forms.ComboBox
    Friend WithEvents c10 As System.Windows.Forms.ComboBox
    Friend WithEvents c11 As System.Windows.Forms.ComboBox
    Friend WithEvents FPC As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents c12 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Ct As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Texti As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Cod_jt As System.Windows.Forms.Label
    Friend WithEvents Cod_tela As System.Windows.Forms.Label
    Friend WithEvents totlibras As System.Windows.Forms.Label
    Friend WithEvents tlibras As System.Windows.Forms.TextBox
    Friend WithEvents liblote As System.Windows.Forms.Label
    Friend WithEvents lplote As System.Windows.Forms.TextBox
    Friend WithEvents cat As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.c0 = New System.Windows.Forms.ComboBox()
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.C3 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.f_confirmada = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cpo_v = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cat = New System.Windows.Forms.ComboBox()
        Me.Cod_tela = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Texti = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Cod_jt = New System.Windows.Forms.Label()
        Me.Ct = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.C5 = New System.Windows.Forms.ComboBox()
        Me.C6 = New System.Windows.Forms.ComboBox()
        Me.C7 = New System.Windows.Forms.ComboBox()
        Me.C8 = New System.Windows.Forms.ComboBox()
        Me.C9 = New System.Windows.Forms.ComboBox()
        Me.c10 = New System.Windows.Forms.ComboBox()
        Me.c12 = New System.Windows.Forms.ComboBox()
        Me.c11 = New System.Windows.Forms.ComboBox()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.FPC = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lote = New System.Windows.Forms.TextBox()
        Me.tlibras = New System.Windows.Forms.TextBox()
        Me.lplote = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.totlibras = New System.Windows.Forms.Label()
        Me.liblote = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Text = "FPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Knit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Color"
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
        Me.Label12.Text = "Tipo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 384)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1016, 288)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(880, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 20
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.")
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(960, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'c0
        '
        Me.c0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c0.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c0.Items.AddRange(New Object() {"CUELLOS", "PUÑOS", "TELA"})
        Me.c0.Location = New System.Drawing.Point(136, 40)
        Me.c0.MaxLength = 15
        Me.c0.Name = "c0"
        Me.c0.Size = New System.Drawing.Size(112, 24)
        Me.c0.Sorted = True
        Me.c0.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.c0, "Tipo de Item  Telas, Cuellos, Puños Etc.")
        '
        'c2
        '
        Me.c2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(136, 64)
        Me.c2.MaxLength = 20
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(232, 24)
        Me.c2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.c2, "Fabric Knit")
        '
        'C3
        '
        Me.C3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3.Location = New System.Drawing.Point(136, 112)
        Me.C3.MaxLength = 20
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(232, 24)
        Me.C3.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.C3, "Color")
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 24)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Estilo"
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
        Me.Label9.Size = New System.Drawing.Size(112, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Yarn Fiber"
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
        Me.Label10.Size = New System.Drawing.Size(112, 24)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Ancho"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Issue Date.")
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(528, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker2.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.DateTimePicker2, "Fecha de Entrega")
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 24)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Peso"
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
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Yarn Finish"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(528, 16)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 22)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Libras Necesarias para la PO.")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(400, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 24)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Fecha Req."
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
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de FPO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SteelBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(400, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 24)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Libras"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CPO"
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
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Yarn Size"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SteelBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(400, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 24)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Estado"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(528, 88)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 22)
        Me.TextBox4.TabIndex = 17
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox4, "Precio de la Tela")
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(400, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 24)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Precio"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.f_confirmada)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cpo_v)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cat)
        Me.GroupBox1.Controls.Add(Me.Cod_tela)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Texti)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Cod_jt)
        Me.GroupBox1.Controls.Add(Me.Ct)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.C5)
        Me.GroupBox1.Controls.Add(Me.C6)
        Me.GroupBox1.Controls.Add(Me.C7)
        Me.GroupBox1.Controls.Add(Me.C8)
        Me.GroupBox1.Controls.Add(Me.C9)
        Me.GroupBox1.Controls.Add(Me.c10)
        Me.GroupBox1.Controls.Add(Me.c12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.c11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 216)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'f_confirmada
        '
        Me.f_confirmada.Checked = False
        Me.f_confirmada.CustomFormat = "dd/MM/yyyy"
        Me.f_confirmada.Enabled = False
        Me.f_confirmada.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_confirmada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.f_confirmada.Location = New System.Drawing.Point(896, 50)
        Me.f_confirmada.Name = "f_confirmada"
        Me.f_confirmada.Size = New System.Drawing.Size(112, 22)
        Me.f_confirmada.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.f_confirmada, "Fecha de Entrega")
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.SteelBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(759, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(118, 24)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "F.confirmada:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo_v
        '
        Me.cpo_v.BackColor = System.Drawing.Color.SteelBlue
        Me.cpo_v.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo_v.ForeColor = System.Drawing.Color.White
        Me.cpo_v.Location = New System.Drawing.Point(660, 46)
        Me.cpo_v.Name = "cpo_v"
        Me.cpo_v.Size = New System.Drawing.Size(32, 16)
        Me.cpo_v.TabIndex = 57
        Me.cpo_v.Text = "..."
        Me.cpo_v.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.SteelBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(759, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 24)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Categoría"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cat
        '
        Me.cat.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat.Location = New System.Drawing.Point(896, 24)
        Me.cat.MaxLength = 10
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(112, 24)
        Me.cat.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.cat, "Ancho de la Tela.")
        '
        'Cod_tela
        '
        Me.Cod_tela.BackColor = System.Drawing.Color.White
        Me.Cod_tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cod_tela.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_tela.Location = New System.Drawing.Point(528, 160)
        Me.Cod_tela.Name = "Cod_tela"
        Me.Cod_tela.Size = New System.Drawing.Size(472, 21)
        Me.Cod_tela.TabIndex = 54
        Me.Cod_tela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.SteelBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(400, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 24)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Cod. Texpasa"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Texti
        '
        Me.Texti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Texti.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texti.Location = New System.Drawing.Point(528, 184)
        Me.Texti.MaxLength = 20
        Me.Texti.Name = "Texti"
        Me.Texti.Size = New System.Drawing.Size(312, 24)
        Me.Texti.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Texti, "Color")
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(400, 184)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 24)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Textilera"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Checked = False
        Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(528, 64)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(112, 22)
        Me.DateTimePicker3.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.DateTimePicker3, "Fecha de Entrega")
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(400, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 24)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Fecha Ofrec."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cod_jt
        '
        Me.Cod_jt.BackColor = System.Drawing.Color.White
        Me.Cod_jt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cod_jt.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_jt.Location = New System.Drawing.Point(528, 136)
        Me.Cod_jt.Name = "Cod_jt"
        Me.Cod_jt.Size = New System.Drawing.Size(136, 21)
        Me.Cod_jt.TabIndex = 48
        Me.Cod_jt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ct
        '
        Me.Ct.BackColor = System.Drawing.Color.SteelBlue
        Me.Ct.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ct.ForeColor = System.Drawing.Color.White
        Me.Ct.Location = New System.Drawing.Point(696, 136)
        Me.Ct.Name = "Ct"
        Me.Ct.Size = New System.Drawing.Size(32, 16)
        Me.Ct.TabIndex = 47
        Me.Ct.Text = "..."
        Me.Ct.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(400, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 24)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Codigo Tela"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C5
        '
        Me.C5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5.Location = New System.Drawing.Point(128, 40)
        Me.C5.MaxLength = 15
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(176, 24)
        Me.C5.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.C5, "PO del Cliente")
        '
        'C6
        '
        Me.C6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C6.Location = New System.Drawing.Point(128, 64)
        Me.C6.MaxLength = 15
        Me.C6.Name = "C6"
        Me.C6.Size = New System.Drawing.Size(176, 24)
        Me.C6.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.C6, "Estilo de la PO")
        '
        'C7
        '
        Me.C7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C7.Location = New System.Drawing.Point(128, 88)
        Me.C7.MaxLength = 40
        Me.C7.Name = "C7"
        Me.C7.Size = New System.Drawing.Size(176, 24)
        Me.C7.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.C7, "Yarn Size")
        '
        'C8
        '
        Me.C8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C8.Location = New System.Drawing.Point(128, 112)
        Me.C8.MaxLength = 10
        Me.C8.Name = "C8"
        Me.C8.Size = New System.Drawing.Size(176, 24)
        Me.C8.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.C8, "Peso de Fabricacion.")
        '
        'C9
        '
        Me.C9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C9.Location = New System.Drawing.Point(128, 136)
        Me.C9.MaxLength = 20
        Me.C9.Name = "C9"
        Me.C9.Size = New System.Drawing.Size(176, 24)
        Me.C9.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.C9, "Yarn Fiber")
        '
        'c10
        '
        Me.c10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c10.Location = New System.Drawing.Point(128, 160)
        Me.c10.MaxLength = 30
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(176, 24)
        Me.c10.TabIndex = 12
        '
        'c12
        '
        Me.c12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c12.Items.AddRange(New Object() {"ABIERTO", "CANCELADO", "CERRADO", "RECHAZADO"})
        Me.c12.Location = New System.Drawing.Point(528, 112)
        Me.c12.MaxLength = 10
        Me.c12.Name = "c12"
        Me.c12.Size = New System.Drawing.Size(112, 24)
        Me.c12.Sorted = True
        Me.c12.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.c12, "Estado de la  FPO")
        '
        'c11
        '
        Me.c11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c11.Location = New System.Drawing.Point(128, 184)
        Me.c11.MaxLength = 10
        Me.c11.Name = "c11"
        Me.c11.Size = New System.Drawing.Size(112, 24)
        Me.c11.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.c11, "Ancho de la Tela.")
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(136, 88)
        Me.C4.MaxLength = 20
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(232, 24)
        Me.C4.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.C4, "Cliente")
        '
        'FPC
        '
        Me.FPC.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPC.IntegralHeight = False
        Me.FPC.Location = New System.Drawing.Point(136, 8)
        Me.FPC.MaxLength = 10
        Me.FPC.Name = "FPC"
        Me.FPC.Size = New System.Drawing.Size(112, 24)
        Me.FPC.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FPC, "Fabric Purchase Order.")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(880, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 42
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Buscar el Registro Seleccionado.")
        Me.Button4.UseVisualStyleBackColor = False
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
        'lote
        '
        Me.lote.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lote.Location = New System.Drawing.Point(136, 136)
        Me.lote.MaxLength = 10
        Me.lote.Name = "lote"
        Me.lote.Size = New System.Drawing.Size(112, 22)
        Me.lote.TabIndex = 44
        Me.lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.lote, "Libras Necesarias para la PO.")
        '
        'tlibras
        '
        Me.tlibras.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlibras.Location = New System.Drawing.Point(640, 80)
        Me.tlibras.MaxLength = 5
        Me.tlibras.Name = "tlibras"
        Me.tlibras.Size = New System.Drawing.Size(112, 22)
        Me.tlibras.TabIndex = 5
        Me.tlibras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tlibras, "Libras Necesarias para la PO.")
        '
        'lplote
        '
        Me.lplote.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lplote.Location = New System.Drawing.Point(640, 104)
        Me.lplote.MaxLength = 5
        Me.lplote.Name = "lplote"
        Me.lplote.Size = New System.Drawing.Size(112, 22)
        Me.lplote.TabIndex = 6
        Me.lplote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.lplote, "Libras Necesarias para la PO.")
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SteelBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 24)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Lote"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totlibras
        '
        Me.totlibras.BackColor = System.Drawing.Color.SteelBlue
        Me.totlibras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totlibras.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totlibras.ForeColor = System.Drawing.Color.White
        Me.totlibras.Location = New System.Drawing.Point(488, 80)
        Me.totlibras.Name = "totlibras"
        Me.totlibras.Size = New System.Drawing.Size(144, 24)
        Me.totlibras.TabIndex = 46
        Me.totlibras.Text = "Total de Libras."
        Me.totlibras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'liblote
        '
        Me.liblote.BackColor = System.Drawing.Color.SteelBlue
        Me.liblote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.liblote.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liblote.ForeColor = System.Drawing.Color.White
        Me.liblote.Location = New System.Drawing.Point(488, 104)
        Me.liblote.Name = "liblote"
        Me.liblote.Size = New System.Drawing.Size(144, 24)
        Me.liblote.TabIndex = 48
        Me.liblote.Text = "Libras x Lote"
        Me.liblote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FPO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.lplote)
        Me.Controls.Add(Me.liblote)
        Me.Controls.Add(Me.tlibras)
        Me.Controls.Add(Me.totlibras)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lote)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.FPC)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.c0)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de FPO's"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler FPC.KeyPress, AddressOf keypressed1
        AddHandler c0.KeyPress, AddressOf keypressed2
        AddHandler c2.KeyPress, AddressOf keypressed3
        AddHandler C3.KeyPress, AddressOf keypressed4
        AddHandler lote.KeyPress, AddressOf keypressed4A
        AddHandler DateTimePicker1.KeyPress, AddressOf keypressed5
        AddHandler C4.KeyPress, AddressOf keypressed6
        AddHandler C5.KeyPress, AddressOf keypressed7
        AddHandler C6.KeyPress, AddressOf keypressed8
        AddHandler C7.KeyPress, AddressOf keypressed9
        AddHandler C8.KeyPress, AddressOf keypressed10
        AddHandler C9.KeyPress, AddressOf keypressed11
        AddHandler c10.KeyPress, AddressOf keypressed12
        AddHandler c11.KeyPress, AddressOf keypressed13
        AddHandler TextBox2.KeyPress, AddressOf keypressed14
        AddHandler DateTimePicker2.KeyPress, AddressOf keypressed15
        AddHandler TextBox4.KeyPress, AddressOf keypressed17
        AddHandler c12.KeyPress, AddressOf keypressed18
        AddHandler Ct.KeyPress, AddressOf keypressed19
        AddHandler DateTimePicker3.KeyPress, AddressOf keypressed20
        AddHandler Texti.KeyPress, AddressOf keypressed21
        AddHandler tlibras.KeyPress, AddressOf keypressed22
        AddHandler lplote.KeyPress, AddressOf keypressed23
        AddHandler cat.KeyPress, AddressOf keypressed24
        llena_combos(cat, "SELECT * FROM TELA_CATEGORIA", "CATEGORIA")
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        llena_combos(c2, "SELECT RTRIM(KNIT) AS KNIT FROM KNITS ORDER BY KNIT", "KNIT")
        llena_textileras()
        set_variables()
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 21
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "FPO"
        fg.Cols(2).Name = "ITEM"
        fg.Cols(3).Name = "KNIT"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "LOTE"
        fg.Cols(5).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(5).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(6).Name = "CLIENTE"
        fg.Cols(7).Name = "CPO"
        fg.Cols(8).Name = "ESTILO"
        fg.Cols(9).Name = "YARN SIZE"
        fg.Cols(10).Name = "PESO"
        fg.Cols(11).Name = "YARN FIBER"
        fg.Cols(12).Name = "YARN FINISH"
        fg.Cols(13).Name = "ANCHO"
        fg.Cols(14).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(14).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(14).Name = "LIBRAS"
        fg.Cols(15).Name = "F.REQUERIDA"
        fg.Cols(15).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(15).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(16).Name = "PRECIO"
        fg.Cols(16).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(16).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(17).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(17).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(17).Name = "STATUS"
        fg.Cols(16).DataType = GetType(Decimal)
        fg.Cols(16).Format = "######.00"
        fg.Cols(18).Name = "F.OFRECIDA"
        fg.Cols(18).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(18).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(19).Name = "TEXTILERA"
        fg.Cols(20).Name = "CODIGO"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 100
            fg(0, index) = fg.Cols(index).Name
        Next
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM FPO WHERE FPO = '" & FPC.Text & "'"  'STATUS = 'ABIERTO'"
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("FPO")
            fg(lineas, 2) = dr("TIPO")
            fg(lineas, 3) = dr("KNIT")
            fg(lineas, 4) = dr("COLOR")
            fg(lineas, 5) = dr("LOTE")
            fg(lineas, 6) = dr("CLIENTE")
            fg(lineas, 7) = dr("CPO")
            fg(lineas, 8) = dr("ESTILO")
            fg(lineas, 9) = dr("YSIZE")
            fg(lineas, 10) = dr("PESO")
            fg(lineas, 11) = dr("YFIBER")
            fg(lineas, 12) = dr("YFINISH")
            fg(lineas, 13) = dr("ANCHO")
            fg(lineas, 14) = dr("LIBRAS")
            fg(lineas, 15) = dr("RFECHA")
            fg(lineas, 16) = dr("PRECIO")
            fg(lineas, 17) = dr("STATUS")
            fg(lineas, 18) = dr("OFECHA")
            Try
                fg(lineas, 19) = dr("TEXTILERA")
                fg(lineas, 20) = dr("CODIGO")
            Catch
            End Try
            llena_datos(lineas)
            lineas = lineas + 1
        Next
    End Sub

    Private Sub llena_datos(ByVal l As Integer)
        Dim i As Integer
        i = FPC.Items.IndexOf(fg(l, 1))
        If i = -1 Then
            FPC.Items.Add(fg(l, 1))
        End If
        i = C7.Items.IndexOf(fg(l, 9))
        If i = -1 Then
            C7.Items.Add(fg(l, 9))
        End If
        i = C8.Items.IndexOf(fg(l, 10))
        If i = -1 Then
            C8.Items.Add(fg(l, 10))
        End If
        i = C9.Items.IndexOf(fg(l, 11))
        If i = -1 Then
            C9.Items.Add(fg(l, 11))
        End If
        i = c10.Items.IndexOf(fg(l, 12))
        If i = -1 Then
            c10.Items.Add(fg(l, 12))
        End If
        i = c11.Items.IndexOf(fg(l, 13))
        If i = -1 Then
            c11.Items.Add(fg(l, 13))
        End If
    End Sub


    Private Sub llena_colores()
        llena_combos(C3, "SELECT DISTINCT COLOR FROM COLORES_TELA WHERE CLIENTE = '" & C4.Text & "' ORDER BY COLOR", "COLOR")
    End Sub

    Private Sub llena_textileras()
        llena_combos(Texti, "SELECT * FROM TEXTILERA ", "TEXTILERA")
    End Sub

    Private Sub limpia_variables()
        FPC.Enabled = True
        c0.Enabled = True
        c2.Enabled = True
        C3.Enabled = True
        lote.Enabled = True
        C4.Enabled = True
        C5.Enabled = False
        C6.Enabled = False
        C7.Enabled = False
        C8.Enabled = False
        C9.Enabled = False
        c10.Enabled = False
        c11.Enabled = False
        c12.Enabled = False
        cat.Enabled = False
        cpo_v.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker3.Enabled = False
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        Texti.Enabled = False
        Ct.Enabled = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = True
        Button4.Visible = True
        totlibras.Visible = False
        liblote.Visible = False
        tlibras.Visible = False
        lplote.Visible = False
        tlibras.Text = 0
        lplote.Text = 0
        c0.SelectedIndex = 2
        c12.SelectedIndex = 0
        FPC.Focus()
    End Sub

    Private Sub set_variables()
        FPC.Text = ""
        lote.Text = "1"
        C7.Text = ""
        C8.Text = ""
        C9.Text = ""
        c10.Text = ""
        c11.Text = ""
        c12.Text = ""
        CUELLOS = 0
        TextBox2.Text = ""
        TextBox4.Text = ""
        Cod_tela.Text = ""
    End Sub
    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim l As Integer = 1
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim dt As New DataTable()
            If Trim(FPC.Text) <> "" Then
                llena_grid()
                c0.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c0.Text) <> "" Then
                c2.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c2.Text) <> "" Then
                C4.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C3.Text) <> "" Then
                lote.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4A(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(lote.Text) <> "" Then
                Button4.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(DateTimePicker1.Text) <> "" Then
                C5.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C4.Text) <> "" Then
                llena_colores()
                C3.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C5.Text) <> "" Then
                C6.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C6.Text) <> "" Then
                C7.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C7.Text) <> "" Then
                C8.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed10(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C8.Text) <> "" Then
                C9.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed11(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C9.Text) <> "" Then
                c10.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed12(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c10.Text) <> "" Then
                c11.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed13(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c11.Text) <> "" Then
                TextBox2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed14(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(TextBox2.Text) <> "" Then
                DateTimePicker2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed15(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(DateTimePicker2.Text) <> "" Then
                DateTimePicker3.Text = DateTimePicker2.Text
                DateTimePicker3.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed17(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(TextBox4.Text) <> "" Then
                c12.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed18(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c12.Text) <> "" Then
                Ct.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed19(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cod_tela.Text) <> "" Then
                Texti.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed20(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(DateTimePicker3.Text) <> "" Then
                TextBox4.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed21(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Texti.Text) <> "" Then
                cat.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed22(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim tlib As Decimal
            Try
                tlib = Format(CDec(tlibras.Text), "#####0")
                If tlib > 0 Then
                    tlibras.Text = tlib
                    lplote.Focus()
                Else
                    MsgBox("Por favor ingrese un Número valido de Libras.", MsgBoxStyle.Critical, "Revise !!!")
                End If
            Catch
            End Try
        End If
    End Sub 'keypressed

    Private Sub keypressed23(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim tlot As Decimal
            Try
                tlot = Format(CDec(lplote.Text), "#####0")
                If tlot > 0 Then
                    lplote.Text = tlot
                    TextBox2.Text = lplote.Text
                    DateTimePicker1.Focus()
                Else
                    MsgBox("Por favor ingrese un Número valido de Libras por lote.", MsgBoxStyle.Critical, "Revise !!!")
                End If
            Catch
            End Try
        End If
    End Sub 'keypressed

    Private Sub keypressed24(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cat.Text) <> "" Then
                Button1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        chequea_encabezado()
    End Sub

    Private Sub habilita()
        FPC.Enabled = False
        c0.Enabled = False
        c2.Enabled = False
        C3.Enabled = False
        lote.Enabled = False
        C4.Enabled = False
        C5.Enabled = True
        C6.Enabled = True
        C7.Enabled = True
        C8.Enabled = True
        C9.Enabled = True
        c10.Enabled = True
        c11.Enabled = True
        c12.Enabled = True
        cpo_v.Enabled = True
        Ct.Enabled = True
        cat.Enabled = True
        Texti.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        DateTimePicker3.Enabled = True
        TextBox2.Enabled = True
        TextBox4.Enabled = True
        Button1.Visible = True
        Button3.Visible = True
        Button4.Visible = False
    End Sub

    Private Sub chequea_encabezado()
        ok = True
        Dim dt As New DataTable()
        If Trim(FPC.Text) = "" Then
            ok = False
            mensaje("FPO")
        End If
        If Trim(c2.Text) = "" Then
            ok = False
            mensaje("FABRIC KNIT")
        End If
        If Trim(C3.Text) = "" Then
            ok = False
            mensaje("COLOR")
        End If
        If Trim(C4.Text) = "" Then
            ok = False
            mensaje("CLIENTE")
        End If
        If ok Then
            lee_registro()
        End If
        If EXISTE Then
            Button3.Focus()
        Else
            llena_tablas(dt, "SELECT * FROM FPO WHERE FPO = '" & FPC.Text & "' AND TIPO = '" & c0.Text & "' AND KNIT = '" & c2.Text & "' AND COLOR = '" & C3.Text & "'", cnn)
            nuevo = True
            If nuevo Then
                totlibras.Visible = True
                lplote.Visible = True
                tlibras.Visible = True
                liblote.Visible = True
            End If
            tlibras.Focus()
        End If
    End Sub

    Private Sub llena_cpo()
        llena_combos(C5, "SELECT DISTINCT CPO_D.CPO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & C4.Text & "' ORDER BY CPO_D.CPO", "CPO")
        C5.Items.Add("STOCK")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub lee_registro()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT FPO.*,F_CONFIRMADA FROM FPO LEFT JOIN FPO_CONFIRMADA ON FPO.FPO = FPO_CONFIRMADA.FPO AND FPO.TIPO = FPO_CONFIRMADA.TIPO AND FPO.KNIT = FPO_CONFIRMADA.KNIT AND FPO.COLOR = FPO_CONFIRMADA.COLOR AND FPO.LOTE = FPO_CONFIRMADA.LOTE  WHERE FPO.FPO = '" & FPC.Text & "' AND FPO.TIPO = '" & c0.Text & "' AND " & _
                                    "FPO.KNIT = '" & c2.Text & "' AND FPO.COLOR = '" & C3.Text & "' AND FPO.LOTE = '" & LOTES & "'"
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
                Button2.Visible = True
            Next
        End If
        habilita()
    End Sub

    Private Sub llena_Variables(ByVal dr As DataRow)
        Dim cpo As String = dr("CPO")
        Dim ESTILO As String = dr("ESTILO")
        DateTimePicker1.Text = dr("IFECHA")
        C5.SelectedIndex = C5.Items.IndexOf(dr("CPO"))
        C6.SelectedIndex = C6.Items.IndexOf(dr("ESTILO"))
        C7.SelectedIndex = C7.Items.IndexOf(dr("YSIZE"))
        C8.Text = dr("PESO")
        C9.Text = dr("YFIBER")
        c10.Text = dr("YFINISH")
        c11.Text = dr("ANCHO")
        TextBox2.Text = dr("LIBRAS")
        DateTimePicker2.Text = dr("RFECHA")
        DateTimePicker3.Text = dr("OFECHA")
        TextBox4.Text = dr("PRECIO")
        c12.Text = dr("STATUS")
        Try
            Cod_tela.Text = dr("CODIGO_TELA")
        Catch
            Cod_tela.Text = " "
        End Try
        Try
            Texti.Text = dr("TEXTILERA")
        Catch
        End Try
        Try
            Cod_jt.Text = dr("CODIGO")
        Catch
            Cod_jt.Text = "00000000"
        End Try
        Try
            cat.Text = dr("CATEGORIA")
        Catch
            cat.Text = cat.Text
        End Try
        If C7.SelectedIndex = -1 Then
            C7.Text = "Stock"
        End If
        If IsDBNull(dr("F_CONFIRMADA")) = False Then
            f_confirmada.Value = dr("F_CONFIRMADA")
        Else
            f_confirmada.Value = Today
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        revisa_detalle()
        If ok Then
            graba_registros()
            setea_grid()
            limpia_variables()
        End If
    End Sub

    Private Sub revisa_detalle()
        ok = True
        Dim compara As Integer
        Dim precio As Decimal
        Dim dt As New DataTable()
        If Trim(DateTimePicker2.Text) = "" Then
            ok = False
            mensaje("Fecha del FPO")
        End If
        If Trim(C4.Text) = "" Then
            ok = False
            mensaje("CLIENTE")
        End If
        If Trim(C5.Text) = "" Then
            ok = False
            mensaje("CPO")
        End If
        If Trim(C6.Text) = "" Then
            ok = False
            mensaje("ESTILO")
        End If
        If Trim(C7.Text) = "" Then
            ok = False
            mensaje("YARN SIZE")
        End If
        If Trim(C8.Text) = "" Then
            ok = False
            mensaje("PESO")
        End If
        If Trim(C9.Text) = "" Then
            ok = False
            mensaje("YARN FIBER")
        End If
        If Trim(c10.Text) = "" Then
            ok = False
            mensaje("YARN FINISH")
        End If
        If Trim(c11.Text) = "" Then
            ok = False
            mensaje("ANCHO")
        End If
        Try
            LIBRAS = CDec(TextBox2.Text)
            If LIBRAS = 0 Then
                ok = False
                mensaje("DATO DE LIBRAS ")
            End If
        Catch
            ok = False
            mensaje("DATO DE LIBRAS ")
        End Try
        Try
            precio = CDec(TextBox4.Text)
            If precio = 0 Then
                'ok = False
                mensaje("OJO CON EL DATO DEL PRECIO ")
            End If
        Catch
            ok = False
            mensaje("DATO DEL PRECIO ")
        End Try
        If Trim(Cod_tela.Text) = "" Then
            ok = False
            mensaje("CODIGO TEXPASA")
        End If
        If Trim(Cod_jt.Text) = "" Then
            ok = False
            mensaje("CODIGO DE LA TELA")
        End If
        compara = Date.Compare(DateTimePicker2.Value, DateTimePicker1.Value)
        If Date.Compare(DateTimePicker2.Value, DateTimePicker1.Value) < 0 Then
            ok = False
            mensaje("LA FECHA DE REQUERIDA DE ENTREGA ES MENOR QUE LA FECHA DEL FPO")
        End If
        If Date.Compare(DateTimePicker3.Value, DateTimePicker1.Value) < 0 Then
            ok = False
            mensaje("LA FECHA OFRECIDA ES MENOR QUE LA FECHA DEL FPO")
        End If
        If nuevo Then
            Try
                tlibras.Text = Format(CDec(tlibras.Text), "####0")
            Catch
                ok = False
                mensaje("Error en total de Libras.")
            End Try
            Try
                lplote.Text = Format(CDec(lplote.Text), "####0")
            Catch
                ok = False
                mensaje("Error en Libras por lote.")
            End Try
            Try
                If CDec(tlibras.Text) < CDec(lplote.Text) Then
                    mensaje("El total de Libras no puede ser menor a las Libras por Lote")
                    ok = False
                End If
            Catch
                ok = False
            End Try
        End If
    End Sub

    ' ====================================================================================
    ' =                ACTUALIZA BASE DE DATOS                                           =
    ' ====================================================================================
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim fechai As String
        fechai = Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd")
        Dim fechar As String
        Dim fechao As String
        Dim rlibras As Decimal = tlibras.Text
        Dim rlote As Integer = 50
        Dim conf As String = Format(f_confirmada.Value, "yyyy-MM-dd")

        fechar = Format(CDate(DateTimePicker2.Text), "yyyy-MM-dd")
        fechao = Format(CDate(DateTimePicker3.Text), "yyyy-MM-dd")
        TextBox2.Text = CStr(Int(TextBox2.Text))

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== TEXTILERA
            strSQL = "UPDATE FPO SET TEXTILERA = '" & Texti.Text & "' WHERE FPO = '" & FPC.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If Not nuevo Then
                ' =================== FPOS
                strSQL = "UPDATE FPO_CONFIRMADA SET F_CONFIRMADA = '" & conf & "' WHERE FPO = '" & FPC.Text & "' AND TIPO = '" & c0.Text & "' AND " & _
                                          "KNIT = '" & c2.Text & "' AND COLOR = '" & C3.Text & "' AND LOTE = '" & lote.Text & "'"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                strSQL = "UPDATE FPO SET FPO = " & "'" & FPC.Text & "'" & _
                                     " , TIPO = " & "'" & c0.Text & "'" & _
                                     " , KNIT = " & "'" & c2.Text & "'" & _
                                     " , COLOR = " & "'" & C3.Text & "'" & _
                                     " , LOTE = " & "'" & lote.Text & "'" & _
                                     " , IFECHA = " & "'" & fechai & "'" & _
                                     " , CLIENTE = " & "'" & C4.Text & "'" & _
                                     " , CPO = " & "'" & C5.Text & "'" & _
                                     " , ESTILO = " & "'" & C6.Text & "'" & _
                                     " , YSIZE = " & "'" & C7.Text & "'" & _
                                     " , PESO = " & "'" & C8.Text & "'" & _
                                     " , YFIBER = " & "'" & C9.Text & "'" & _
                                     " , YFINISH = " & "'" & c10.Text & "'" & _
                                     " , ANCHO = " & "'" & c11.Text & " '" & _
                                     " , LIBRAS = " & "'" & TextBox2.Text & "'" & _
                                     " , RFECHA = " & "'" & fechar & "'" & _
                                     " , PRECIO = " & "'" & TextBox4.Text & "'" & _
                                     " , STATUS = " & "'" & c12.Text & "'" & _
                                     " , CODIGO_TELA = " & "'" & Cod_tela.Text & "'" & _
                                     " , OFECHA = " & "'" & fechao & "'" & _
                                     " , TEXTILERA = " & "'" & Texti.Text & "'" & _
                                     " , CODIGO = " & "'" & Cod_jt.Text & "'" & _
                                     " , CATEGORIA = " & "'" & cat.Text & "'" & _
                                     " WHERE FPO = '" & FPC.Text & "' AND TIPO = '" & c0.Text & "' AND " & _
                                          "KNIT = '" & c2.Text & "' AND COLOR = '" & C3.Text & "' AND LOTE = '" & lote.Text & "'"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                If afectados = 0 Then
                    strSQL = "INSERT INTO FPO (FPO,TIPO,KNIT,COLOR,LOTE,CLIENTE,IFECHA,CPO,ESTILO,YSIZE,YFIBER,YFINISH,PESO,ANCHO,LIBRAS,RFECHA,PRECIO,STATUS,RECIBIDAS,CODIGO_TELA,OFECHA,TEXTILERA,CODIGO,CATEGORIA) " & _
                             "VALUES ( '" & FPC.Text & "','" & _
                                 c0.Text & "','" & _
                                 c2.Text & "','" & _
                                 C3.Text & "','" & _
                                 lote.Text & "','" & _
                                 C4.Text & "','" & _
                                 fechai & "','" & _
                                 C5.Text & "','" & _
                                 C6.Text & "','" & _
                                 C7.Text & "','" & _
                                 C9.Text & "','" & _
                                 c10.Text & "','" & _
                                 C8.Text & "','" & _
                                 c11.Text & "','" & _
                                 TextBox2.Text & "','" & _
                                 fechar & "','" & _
                                 TextBox4.Text & "','" & _
                                 c12.Text & "','0','" & _
                                 Cod_tela.Text & "','" & _
                                 fechao & "','" & _
                                 Texti.Text & "','" & _
                                 Cod_jt.Text & "','" & _
                                 cat.Text & "')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If
            Else
                While rlibras > 0
                    If rlibras > lplote.Text Then
                        TextBox2.Text = lplote.Text
                        rlibras = rlibras - CDec(lplote.Text)
                    Else
                        TextBox2.Text = rlibras
                        rlibras = 0
                    End If
                    lote.Text = rlote
                    strSQL = "INSERT INTO FPO (FPO,TIPO,KNIT,COLOR,LOTE,CLIENTE,IFECHA,CPO,ESTILO,YSIZE,YFIBER,YFINISH,PESO,ANCHO,LIBRAS,RFECHA,PRECIO,STATUS,RECIBIDAS,CODIGO_TELA,OFECHA,TEXTILERA,CODIGO,CATEGORIA) " & _
                                              "VALUES ( '" & FPC.Text & "','" & _
                                                        c0.Text & "','" & _
                                                        c2.Text & "','" & _
                                                        C3.Text & "','" & _
                                                        lote.Text & "','" & _
                                                        C4.Text & "','" & _
                                                        fechai & "','" & _
                                                        C5.Text & "','" & _
                                                        C6.Text & "','" & _
                                                        C7.Text & "','" & _
                                                        C9.Text & "','" & _
                                                        c10.Text & "','" & _
                                                        C8.Text & "','" & _
                                                        c11.Text & "','" & _
                                                        TextBox2.Text & "','" & _
                                                        fechar & "','" & _
                                                        TextBox4.Text & "','" & _
                                                        c12.Text & "','0','" & _
                                                        Cod_tela.Text & "','" & _
                                                        fechao & "','" & _
                                                        Texti.Text & "','" & _
                                                        Cod_jt.Text & "','" & _
                                                        cat.Text & "')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                    rlote = rlote + 1
                End While
            End If
            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.Message.ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ok As Boolean
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        revisa_batch(ok)
        If ok Then
            seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                elimina()
            End If
            setea_grid()
            limpia_variables()
        End If
    End Sub

    Private Sub revisa_batch(ByRef ok As Boolean)
        Dim cl As New DataTable()
        Dim strsql As String = "SELECT * FROM ROLLOS WHERE FPO = '" & FPC.Text & "' AND TIPO = '" & c0.Text & "' AND " & _
                                  "KNIT = '" & c2.Text & "' AND COLOR = '" & C3.Text & "' AND LOTE = '" & lote.Text & "'"
        llena_tablas(cl, strsql, cnn)
        If cl.Rows.Count > 0 Then
            MsgBox("No puede eliminar este registro !!!!!", MsgBoxStyle.Critical, "Ya tiene batch ingresado !!!!!")
            ok = False
        Else
            ok = True
        End If
    End Sub

    Private Sub elimina()
        Dim afectados As Integer
        Dim strSQL As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== ELIMINA FPO
            strSQL = "DELETE FROM FPO WHERE FPO = '" & FPC.Text & "' AND TIPO = '" & c0.Text & "' AND " & _
                                      "KNIT = '" & c2.Text & "' AND COLOR = '" & C3.Text & "' AND LOTE = '" & lote.Text & "'"
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
        Dim knit As String = fg(fil, 3)
        Dim colo As String = fg(fil, 4)

        If fil > 0 And fil < fg.Rows.Count Then
            FPC.Text = fg(fil, 1)
            c0.SelectedIndex = c0.Items.IndexOf(fg(fil, 2))
            c2.SelectedIndex = c2.Items.IndexOf(knit)
            C4.SelectedIndex = C4.Items.IndexOf(Trim(fg(fil, 6)))
            C3.SelectedIndex = C3.Items.IndexOf(colo)
            lote.Text = fg(fil, 5)
            LOTES = lote.Text
            lee_registro()
            c12.SelectedIndex = c12.Items.IndexOf(Trim(fg(fil, 17)))
            Texti.SelectedIndex = Texti.Items.IndexOf(Trim(fg(fil, 19)))
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


    Private Sub C4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.SelectedIndexChanged
        If Trim(C4.Text) <> "" Then
            llena_cpo()
            llena_colores()
        End If
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        fg(lineas, 1) = FPC.Text
        fg(lineas, 2) = c0.Text
        fg(lineas, 3) = c2.Text
        fg(lineas, 4) = C3.Text
        fg(lineas, 5) = lote.Text
        fg(lineas, 6) = C4.Text
        fg(lineas, 7) = C5.Text
        fg(lineas, 8) = C6.Text
        fg(lineas, 9) = C7.Text
        fg(lineas, 10) = C8.Text
        fg(lineas, 11) = C9.Text
        fg(lineas, 12) = c10.Text
        fg(lineas, 13) = c11.Text
        fg(lineas, 14) = TextBox2.Text
        fg(lineas, 15) = DateTimePicker2.Text
        fg(lineas, 16) = TextBox4.Text
        fg(lineas, 17) = c12.Text
        fg(lineas, 18) = DateTimePicker3.Text
        fg(lineas, 19) = Texti.Text
        fg(lineas, 20) = Cod_jt.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ct.Click
        Dim forma As New Sel_Codigo_Tela()
        'forma.cliente = C4.Text
        forma.codigo_j = C3.Text
        forma.ShowDialog()
        Cod_tela.Text = forma.codigo_t
        Cod_jt.Text = forma.codigo_j
    End Sub

    Private Sub c2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c2.KeyPress
        AutoCompletar(c2, e)
    End Sub
    Private Sub c3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C3.KeyPress
        AutoCompletar(C3, e)
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub

    Private Sub c5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C5.KeyPress
        AutoCompletar(C5, e)
    End Sub

    Private Sub c6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C6.KeyPress
        AutoCompletar(C6, e)
    End Sub

    Private Sub C5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5.SelectedIndexChanged
        Dim strsql As String
        If C5.Text = "STOCK" Then
            strsql = "SELECT DISTINCT CPO_D.ESTILO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & C4.Text & "' ORDER BY CPO_D.ESTILO"
        Else
            strsql = "SELECT DISTINCT CPO_D.ESTILO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & C4.Text & "' AND CPO_D.CPO = '" & C5.Text & "' ORDER BY CPO_D.ESTILO"
        End If
        llena_combos(C6, strsql, "ESTILO")
        C6.Items.Add("STOCK")
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles cpo_v.Click
        Dim forma As New Cambia_fecha_fpo
        forma.fpo.Text = FPC.Text
        forma.fecha.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")
        forma.cnn = cnn
        forma.ShowDialog()
        setea_grid()
        limpia_variables()
    End Sub
End Class
