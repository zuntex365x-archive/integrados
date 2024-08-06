Imports C1.Win.C1FlexGrid

Public Class Ingreso_Cpo_N2_o
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnns As SqlClient.SqlConnection
    Dim cna As New SqlClient.SqlConnection()
    Dim TIPO As String
    Dim lineas As Integer
    Dim b As String = "0|0|0|0|0|0|0|0|0|0|0"
    Dim t As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim r As String()
    Dim g As String()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cp As New DataTable()
    Dim usuario As String
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents XS As System.Windows.Forms.TextBox
    Friend WithEvents S As System.Windows.Forms.TextBox
    Friend WithEvents M As System.Windows.Forms.TextBox
    Friend WithEvents L As System.Windows.Forms.TextBox
    Friend WithEvents XL As System.Windows.Forms.TextBox
    Friend WithEvents XL2 As System.Windows.Forms.TextBox
    Friend WithEvents XL3 As System.Windows.Forms.TextBox
    Friend WithEvents XL4 As System.Windows.Forms.TextBox
    Friend WithEvents XL5 As System.Windows.Forms.TextBox
    Friend WithEvents XL6 As System.Windows.Forms.TextBox
    Friend WithEvents TOTALES As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents F_PEDIDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents F_ENTREGA As System.Windows.Forms.DateTimePicker
    Friend WithEvents COLORES As System.Windows.Forms.ComboBox
    Friend WithEvents CPOS As System.Windows.Forms.TextBox
    Friend WithEvents CLIENTES As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents E2 As System.Windows.Forms.Button
    Friend WithEvents R2 As System.Windows.Forms.Button
    Friend WithEvents G2 As System.Windows.Forms.Button
    Friend WithEvents Estilos As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents destino As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tp As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Cpo_N2_o))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CPOS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TOTALES = New System.Windows.Forms.TextBox()
        Me.XL6 = New System.Windows.Forms.TextBox()
        Me.XL5 = New System.Windows.Forms.TextBox()
        Me.XL4 = New System.Windows.Forms.TextBox()
        Me.XL3 = New System.Windows.Forms.TextBox()
        Me.XL2 = New System.Windows.Forms.TextBox()
        Me.XL = New System.Windows.Forms.TextBox()
        Me.L = New System.Windows.Forms.TextBox()
        Me.M = New System.Windows.Forms.TextBox()
        Me.S = New System.Windows.Forms.TextBox()
        Me.XS = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CLIENTES = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.F_PEDIDO = New System.Windows.Forms.DateTimePicker()
        Me.F_ENTREGA = New System.Windows.Forms.DateTimePicker()
        Me.COLORES = New System.Windows.Forms.ComboBox()
        Me.E2 = New System.Windows.Forms.Button()
        Me.R2 = New System.Windows.Forms.Button()
        Me.G2 = New System.Windows.Forms.Button()
        Me.Estilos = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.destino = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tp = New System.Windows.Forms.Label()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ct
        '
        Me.ct.ColumnInfo = resources.GetString("ct.ColumnInfo")
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ct.Location = New System.Drawing.Point(8, 80)
        Me.ct.Name = "ct"
        Me.ct.Rows.Count = 1
        Me.ct.Rows.DefaultSize = 19
        Me.ct.Rows.Fixed = 0
        Me.ct.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ct.Size = New System.Drawing.Size(728, 32)
        Me.ct.StyleInfo = resources.GetString("ct.StyleInfo")
        Me.ct.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.ct, "Area de Datos.")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(840, 16)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 20
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.E1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.Black
        Me.E1.Image = CType(resources.GetObject("E1.Image"), System.Drawing.Image)
        Me.E1.Location = New System.Drawing.Point(936, 16)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(35, 35)
        Me.E1.TabIndex = 21
        Me.E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E1, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.E1.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(888, 16)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(384, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "F.Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CPOS
        '
        Me.CPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPOS.Location = New System.Drawing.Point(16, 32)
        Me.CPOS.MaxLength = 20
        Me.CPOS.Name = "CPOS"
        Me.CPOS.Size = New System.Drawing.Size(160, 24)
        Me.CPOS.TabIndex = 1
        Me.CPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.CPOS, "Numero de CPO")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(200, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Estilo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TOTALES)
        Me.GroupBox1.Controls.Add(Me.XL6)
        Me.GroupBox1.Controls.Add(Me.XL5)
        Me.GroupBox1.Controls.Add(Me.XL4)
        Me.GroupBox1.Controls.Add(Me.XL3)
        Me.GroupBox1.Controls.Add(Me.XL2)
        Me.GroupBox1.Controls.Add(Me.XL)
        Me.GroupBox1.Controls.Add(Me.L)
        Me.GroupBox1.Controls.Add(Me.M)
        Me.GroupBox1.Controls.Add(Me.S)
        Me.GroupBox1.Controls.Add(Me.XS)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ct)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 128)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 16)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Costo Unitario por Talla"
        '
        'TOTALES
        '
        Me.TOTALES.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.TOTALES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALES.ForeColor = System.Drawing.Color.Black
        Me.TOTALES.Location = New System.Drawing.Point(728, 32)
        Me.TOTALES.Name = "TOTALES"
        Me.TOTALES.ReadOnly = True
        Me.TOTALES.Size = New System.Drawing.Size(96, 21)
        Me.TOTALES.TabIndex = 41
        Me.TOTALES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TOTALES, "Total de Prendas Cortadas")
        '
        'XL6
        '
        Me.XL6.Location = New System.Drawing.Point(656, 32)
        Me.XL6.MaxLength = 6
        Me.XL6.Name = "XL6"
        Me.XL6.Size = New System.Drawing.Size(70, 20)
        Me.XL6.TabIndex = 18
        Me.XL6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XL6, "Talla 6XL")
        '
        'XL5
        '
        Me.XL5.Location = New System.Drawing.Point(584, 32)
        Me.XL5.MaxLength = 6
        Me.XL5.Name = "XL5"
        Me.XL5.Size = New System.Drawing.Size(70, 20)
        Me.XL5.TabIndex = 17
        Me.XL5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XL5, "Talla 5XL")
        '
        'XL4
        '
        Me.XL4.Location = New System.Drawing.Point(512, 32)
        Me.XL4.MaxLength = 6
        Me.XL4.Name = "XL4"
        Me.XL4.Size = New System.Drawing.Size(70, 20)
        Me.XL4.TabIndex = 16
        Me.XL4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XL4, "Talla 4Xl")
        '
        'XL3
        '
        Me.XL3.Location = New System.Drawing.Point(440, 32)
        Me.XL3.MaxLength = 6
        Me.XL3.Name = "XL3"
        Me.XL3.Size = New System.Drawing.Size(70, 20)
        Me.XL3.TabIndex = 15
        Me.XL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XL3, "Talla 3XL")
        '
        'XL2
        '
        Me.XL2.Location = New System.Drawing.Point(368, 32)
        Me.XL2.MaxLength = 6
        Me.XL2.Name = "XL2"
        Me.XL2.Size = New System.Drawing.Size(70, 20)
        Me.XL2.TabIndex = 14
        Me.XL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XL2, "Talla 2XL")
        '
        'XL
        '
        Me.XL.Location = New System.Drawing.Point(296, 32)
        Me.XL.MaxLength = 6
        Me.XL.Name = "XL"
        Me.XL.Size = New System.Drawing.Size(70, 20)
        Me.XL.TabIndex = 13
        Me.XL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XL, "Talla XL")
        '
        'L
        '
        Me.L.Location = New System.Drawing.Point(224, 32)
        Me.L.MaxLength = 6
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(70, 20)
        Me.L.TabIndex = 12
        Me.L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.L, "Talla L")
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(152, 32)
        Me.M.MaxLength = 6
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(70, 20)
        Me.M.TabIndex = 11
        Me.M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.M, "Talla M")
        '
        'S
        '
        Me.S.Location = New System.Drawing.Point(80, 32)
        Me.S.MaxLength = 6
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(70, 20)
        Me.S.TabIndex = 10
        Me.S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.S, "Talla S")
        '
        'XS
        '
        Me.XS.Location = New System.Drawing.Point(8, 32)
        Me.XS.MaxLength = 6
        Me.XS.Name = "XS"
        Me.XS.Size = New System.Drawing.Size(70, 20)
        Me.XS.TabIndex = 9
        Me.XS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.XS, "Talla XS")
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(728, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "TOTAL"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(656, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "6XL"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(584, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "5XL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SteelBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(512, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 16)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "4XL"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(664, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "4XL"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(440, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "3XL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SteelBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(368, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "2XL"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SteelBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(296, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "XL"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(224, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "L"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(152, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "M"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(80, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "S"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "XS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CLIENTES
        '
        Me.CLIENTES.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENTES.Location = New System.Drawing.Point(200, 24)
        Me.CLIENTES.MaxLength = 20
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(168, 26)
        Me.CLIENTES.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CLIENTES, "Cliente")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 680)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'F_PEDIDO
        '
        Me.F_PEDIDO.CustomFormat = "dd/MM/yyyy"
        Me.F_PEDIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_PEDIDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_PEDIDO.Location = New System.Drawing.Point(384, 24)
        Me.F_PEDIDO.Name = "F_PEDIDO"
        Me.F_PEDIDO.Size = New System.Drawing.Size(120, 24)
        Me.F_PEDIDO.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.F_PEDIDO, "Fecha de Pedido")
        '
        'F_ENTREGA
        '
        Me.F_ENTREGA.CustomFormat = "dd/MM/yyyy"
        Me.F_ENTREGA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_ENTREGA.Location = New System.Drawing.Point(376, 96)
        Me.F_ENTREGA.Name = "F_ENTREGA"
        Me.F_ENTREGA.Size = New System.Drawing.Size(96, 20)
        Me.F_ENTREGA.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.F_ENTREGA, "Fecha de Entrega")
        '
        'COLORES
        '
        Me.COLORES.Location = New System.Drawing.Point(160, 96)
        Me.COLORES.MaxLength = 20
        Me.COLORES.Name = "COLORES"
        Me.COLORES.Size = New System.Drawing.Size(208, 21)
        Me.COLORES.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.COLORES, "Cliente")
        '
        'E2
        '
        Me.E2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.E2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E2.ForeColor = System.Drawing.Color.Black
        Me.E2.Image = CType(resources.GetObject("E2.Image"), System.Drawing.Image)
        Me.E2.Location = New System.Drawing.Point(944, 80)
        Me.E2.Name = "E2"
        Me.E2.Size = New System.Drawing.Size(35, 35)
        Me.E2.TabIndex = 51
        Me.E2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.E2.UseVisualStyleBackColor = False
        '
        'R2
        '
        Me.R2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.ForeColor = System.Drawing.Color.Black
        Me.R2.Image = CType(resources.GetObject("R2.Image"), System.Drawing.Image)
        Me.R2.Location = New System.Drawing.Point(896, 80)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(35, 35)
        Me.R2.TabIndex = 49
        Me.R2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R2, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R2.UseVisualStyleBackColor = False
        Me.R2.Visible = False
        '
        'G2
        '
        Me.G2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G2.ForeColor = System.Drawing.Color.Black
        Me.G2.Image = CType(resources.GetObject("G2.Image"), System.Drawing.Image)
        Me.G2.Location = New System.Drawing.Point(848, 80)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(35, 35)
        Me.G2.TabIndex = 50
        Me.G2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G2, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G2.UseVisualStyleBackColor = False
        Me.G2.Visible = False
        '
        'Estilos
        '
        Me.Estilos.Location = New System.Drawing.Point(16, 96)
        Me.Estilos.MaxLength = 20
        Me.Estilos.Name = "Estilos"
        Me.Estilos.Size = New System.Drawing.Size(136, 21)
        Me.Estilos.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Estilos, "Cliente")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 256)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(983, 408)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'destino
        '
        Me.destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destino.Location = New System.Drawing.Point(480, 96)
        Me.destino.MaxLength = 30
        Me.destino.Name = "destino"
        Me.destino.Size = New System.Drawing.Size(352, 20)
        Me.destino.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.destino, "Numero de CPO")
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(376, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "F.Entrega"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(160, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.F_PEDIDO)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.E1)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.G1)
        Me.GroupBox2.Controls.Add(Me.CLIENTES)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 64)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(480, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(352, 16)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Lugar de Envio"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(728, 664)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 32)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Total Prendas:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tp
        '
        Me.tp.BackColor = System.Drawing.Color.White
        Me.tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp.ForeColor = System.Drawing.Color.Black
        Me.tp.Location = New System.Drawing.Point(856, 664)
        Me.tp.Name = "tp"
        Me.tp.Size = New System.Drawing.Size(104, 32)
        Me.tp.TabIndex = 56
        Me.tp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ingreso_Cpo_N2_o
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 703)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tp)
        Me.Controls.Add(Me.destino)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Estilos)
        Me.Controls.Add(Me.E2)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.G2)
        Me.Controls.Add(Me.COLORES)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CPOS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.F_ENTREGA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Cpo_N2_o"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificación  de  CPO'S"
        Me.ToolTip1.SetToolTip(Me, "Ingreso de CPO'S")
        CType(Me.ct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler CPOS.KeyPress, AddressOf keypressed1
        AddHandler CLIENTES.KeyPress, AddressOf keypressed2
        AddHandler F_PEDIDO.KeyPress, AddressOf keypressed3
        AddHandler F_ENTREGA.KeyPress, AddressOf keypressed4
        AddHandler Estilos.KeyPress, AddressOf keypressed6
        AddHandler COLORES.KeyPress, AddressOf keypressed7
        AddHandler XS.KeyPress, AddressOf keypressed8
        AddHandler S.KeyPress, AddressOf keypressed9
        AddHandler M.KeyPress, AddressOf keypressed10
        AddHandler L.KeyPress, AddressOf keypressed11
        AddHandler XL.KeyPress, AddressOf keypressed12
        AddHandler XL2.KeyPress, AddressOf keypressed13
        AddHandler XL3.KeyPress, AddressOf keypressed14
        AddHandler XL4.KeyPress, AddressOf keypressed15
        AddHandler XL5.KeyPress, AddressOf keypressed16
        AddHandler XL6.KeyPress, AddressOf keypressed17
        AddHandler destino.KeyPress, AddressOf keypressed18
        Dim obj As New empresas()
        usuario = obj.usuario
        llena_tablas(cp, "SELECT * FROM CPO", cna)
        llena_clientes_cpo(CLIENTES)
        setea_grid()
        limpia_variables()
    End Sub


    Private Sub limpia_variables()
        CPOS.Enabled = True
        CPOS.ReadOnly = False
        CLIENTES.Enabled = False
        F_PEDIDO.Enabled = False
        F_ENTREGA.Enabled = False
        Estilos.Enabled = False
        COLORES.Enabled = False
        destino.Enabled = False
        XS.Enabled = False
        S.Enabled = False
        M.Enabled = False
        L.Enabled = False
        XL.Enabled = False
        XL2.Enabled = False
        XL3.Enabled = False
        XL4.Enabled = False
        XL5.Enabled = False
        XL6.Enabled = False
        TOTALES.Enabled = False
        G1.Visible = False
        E1.Visible = False
        R1.Visible = True
        G2.Visible = False
        R2.Visible = False
        E2.Visible = False
        If CLIENTES.Items.Count > 0 Then
            CLIENTES.SelectedIndex = 0
        End If
        CLIENTES.Text = ""
        COLORES.Text = ""
        CPOS.Text = ""
        Estilos.Text = ""
        COLORES.Text = ""
        destino.Text = ""
        XS.Text = "0"
        S.Text = "0"
        M.Text = "0"
        L.Text = "0"
        XL.Text = "0"
        XL2.Text = "0"
        XL3.Text = "0"
        XL4.Text = "0"
        XL5.Text = "0"
        XL6.Text = "0"
        TOTALES.Text = "0"
        tp.Text = "0"
        r = Split(b, "|")
        setea_grid()
        setea_ct()
        ct.Enabled = False
        CPOS.Focus()
    End Sub

    Private Sub re_habilita()
        CPOS.Enabled = False
        CLIENTES.Enabled = True
        F_PEDIDO.Enabled = True
        E1.Visible = True
        G1.Visible = True
        R1.Visible = True
    End Sub

    Private Sub setea_ct()
        Dim i As Integer
        ct.Clear()
        ct.Rows(0).Height = 25
        ct.Cols.Count = 10
        For i = 0 To 9
            ct.Cols(i).Width = 72
            ct.Cols(i).DataType = GetType(Decimal)
            ct.Cols(i).Format = "####0.00"
            ct.Cols(i).TextAlign = TextAlignEnum.RightCenter
            ct(0, i) = 0
            ct.KeyActionEnter = KeyActionEnum.MoveAcross
            ct.KeyActionTab = KeyActionEnum.MoveAcross
        Next
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 18
        fg.Cols(0).Width = 5
        fg.Cols(1).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CPO"
        fg.Cols(2).Name = "ESTILO"
        fg.Cols(3).Name = "COLOR"
        fg.Cols(4).Name = "XS"
        fg.Cols(5).Name = "S"
        fg.Cols(6).Name = "M"
        fg.Cols(7).Name = "L"
        fg.Cols(8).Name = "XL"
        fg.Cols(9).Name = "2XL"
        fg.Cols(10).Name = "3XL"
        fg.Cols(11).Name = "4XL"
        fg.Cols(12).Name = "5XL"
        fg.Cols(13).Name = "6XL"
        fg.Cols(14).Name = "TOT."
        fg.Cols(15).Name = "ST"
        fg.Cols(16).Name = "F.ENTREGA"
        fg.Cols(17).Name = "LUGAR DE ENVIO"
        For index = 2 To fg.Cols.Count - 1
            fg.Cols(index).Width = 175
            fg(0, index) = fg.Cols(index).Name
            If index > 3 And index < 15 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 55
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(2).Width = 115
        fg.Cols(15).Width = 40
        fg.Cols(15).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(15).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT CPO_D2.*, CLIENTE FROM CPO_D2  LEFT JOIN CPO_2 ON CPO_D2.CPO = CPO_2.CPO WHERE CPO_D2.CPO ='" & CPOS.Text & "'"
        llena_tablas(dt, strSQL, cna)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            CLIENTES.SelectedIndex = CLIENTES.Items.IndexOf(dr("CLIENTE"))
            fg(lineas, 0) = Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            fg(lineas, 1) = dr("CPO")
            fg(lineas, 2) = dr("ESTILO")
            fg(lineas, 3) = dr("COLOR")
            fg(lineas, 4) = dr("XS")
            fg(lineas, 5) = dr("S")
            fg(lineas, 6) = dr("M")
            fg(lineas, 7) = dr("L")
            fg(lineas, 8) = dr("XL")
            fg(lineas, 9) = dr("XL2")
            fg(lineas, 10) = dr("XL3")
            fg(lineas, 11) = dr("XL4")
            fg(lineas, 12) = dr("XL5")
            fg(lineas, 13) = dr("XL6")
            fg(lineas, 14) = dr("TOTAL")
            fg(lineas, 16) = dr("F_ENTREGA")
            fg(lineas, 17) = dr("DESTINO")
            lineas = lineas + 1
        Next
        sub_total()
    End Sub


    Private Sub llena_clientes()
        Dim strSQL As String = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'A' ORDER BY CLIENTE"
        llena_combos(CLIENTES, strSQL, "CLIENTE")
        If CLIENTES.Items.Count > 0 Then
            CLIENTES.SelectedIndex = 0
        End If

    End Sub

    Private Sub llena_estilos()
        Estilos.Items.Clear()
        Dim strSQL As String = "SELECT DISTINCT ESTILO FROM CLI_EST_COL WHERE CLIENTE =  '" & CLIENTES.Text & "' AND ESTADO = 'A' ORDER BY ESTILO"
        llena_combos(Estilos, strSQL, "ESTILO")
        If Estilos.Items.Count > 0 Then
            Estilos.SelectedIndex = 0
        End If
    End Sub

    Private Sub llena_colores()
        COLORES.Items.Clear()
        Dim strSQL As String = "SELECT DISTINCT COLOR FROM CLI_EST_COL WHERE CLIENTE =  '" & CLIENTES.Text & "' AND ESTILO = '" & Estilos.Text & "' AND ESTADO = 'A' ORDER BY COLOR"
        llena_combos(COLORES, strSQL, "COLOR")
        If COLORES.Items.Count > 0 Then
            COLORES.SelectedIndex = 0
        End If
    End Sub

    Private Sub busca_cpos()
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_2 WHERE CPO =  '" & CPOS.Text & "'"
        llena_tablas(dt, strSQL, cna)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            CLIENTES.SelectedIndex = CLIENTES.Items.IndexOf(dr("CLIENTE"))
            F_PEDIDO.Text = dr("F_PEDIDO")
            llena_grid()
            E1.Visible = True
            habilita()
        Else
            re_habilita()
            CLIENTES.Focus()
        End If
    End Sub

    Private Sub busca_detalle()
        Dim dr As DataRow
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_D2 WHERE CPO =  '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"
        llena_tablas(dt, strSQL, cna)
        For Each dr In dt.Rows
            Estilos.Text = dr("ESTILO")
            XS.Text = dr("XS")
            S.Text = dr("S")
            M.Text = dr("M")
            L.Text = dr("L")
            XL.Text = dr("XL")
            XL2.Text = dr("XL2")
            XL3.Text = dr("XL3")
            XL4.Text = dr("XL4")
            XL5.Text = dr("XL5")
            XL6.Text = dr("XL6")
            TOTALES.Text = dr("TOTAL")
            F_ENTREGA.Text = dr("F_ENTREGA")
            destino.Text = dr("DESTINO")
            ct(0, 0) = dr("C1")
            ct(0, 1) = dr("C2")
            ct(0, 2) = dr("C3")
            ct(0, 3) = dr("C4")
            ct(0, 4) = dr("C5")
            ct(0, 5) = dr("C6")
            ct(0, 6) = dr("C7")
            ct(0, 7) = dr("C8")
            ct(0, 8) = dr("C9")
            ct(0, 9) = dr("C0")
            E2.Visible = True
        Next
        habilita1()
        F_ENTREGA.Focus()
    End Sub

    Private Sub habilita()
        CPOS.Enabled = False
        CLIENTES.Enabled = False
        F_PEDIDO.Enabled = False
        F_ENTREGA.Enabled = False
        Estilos.Enabled = True
        COLORES.Enabled = True
        destino.Enabled = False
        G2.Visible = False
        R2.Visible = True
        E2.Visible = False
        XS.Enabled = False
        S.Enabled = False
        M.Enabled = False
        L.Enabled = False
        XL.Enabled = False
        XL2.Enabled = False
        XL3.Enabled = False
        XL4.Enabled = False
        XL5.Enabled = False
        XL6.Enabled = False
        XS.Text = 0
        S.Text = 0
        M.Text = 0
        L.Text = 0
        XL.Text = 0
        XL2.Text = 0
        XL3.Text = 0
        XL4.Text = 0
        XL5.Text = 0
        XL6.Text = 0
        TOTALES.Text = 0
        setea_ct()
        Estilos.Focus()
    End Sub

    Private Sub habilita1()
        G2.Visible = True
        Estilos.Enabled = False
        COLORES.Enabled = False
        F_ENTREGA.Enabled = True
        destino.Enabled = True
        XS.Enabled = True
        S.Enabled = True
        M.Enabled = True
        L.Enabled = True
        XL.Enabled = True
        XL2.Enabled = True
        XL3.Enabled = True
        XL4.Enabled = True
        XL5.Enabled = True
        XL6.Enabled = True
        ct.Enabled = True
        r = Split(b, "|")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        revisa_cpo(ok)
        If ok Then
            revisa_encabezado(ok)
        End If
        If ok Then
            llena_colores()
            llena_estilos()
            llena_grid()
            habilita()
            G1.Visible = False
            E1.Visible = False
        End If
    End Sub

    Private Sub revisa_encabezado(ByVal ok As Boolean)
        If Trim(CLIENTES.Text) = "" Then
            ok = False
            mensaje("CLIENTE")
        End If
        If Trim(F_PEDIDO.Text) = "" Then
            ok = False
            mensaje("FECHA DEL PEDIDO")
        End If
        If Trim(F_ENTREGA.Text) = "" Then
            ok = False
            mensaje("FECHA DE ENTREGA")
        End If
    End Sub

    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        Dim ok As Boolean
        seguro = MsgBox("Seguro de Querer Eliminar TODA LA CPO?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_cpos(ok)
            If ok Then
                elimina_todo()
                limpia_variables()
            Else
                MsgBox("Este Cpo no se puede eliminar. Ya posee cortes", MsgBoxStyle.Critical, "Error en la eliminación")
            End If
        End If
    End Sub

    Private Sub revisa_cpos(ByRef ok As Boolean)
        Dim cor As New DataTable
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & CPOS.Text & "'"
        ok = True
        llena_tablas(cor, strsql, cnns)
        If cor.Rows.Count > 0 Then
            ok = False
        End If
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            Estilos.Text = fg(fil, 2)
            COLORES.SelectedIndex = COLORES.Items.IndexOf(Trim(fg(fil, 3)))
            busca_detalle()
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ct.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(CPOS.Text) <> "" Then
                busca_cpos()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(CLIENTES.Text) <> "" Then
                F_PEDIDO.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(F_PEDIDO.Text) <> "" Then
                G1.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            destino.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Estilos.Text) <> "" Then
                COLORES.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(COLORES.Text) <> "" And Trim(Estilos.Text) <> "" Then
                busca_detalle()
                F_ENTREGA.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XS.Text, ok)
            If ok Then
                S.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(S.Text, Ok)
            If Ok Then
                M.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed10(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(M.Text, Ok)
            If Ok Then
                L.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed11(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(L.Text, Ok)
            If Ok Then
                XL.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed12(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XL.Text, Ok)
            If Ok Then
                XL2.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed13(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XL2.Text, Ok)
            If Ok Then
                XL3.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed14(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XL3.Text, Ok)
            If Ok Then
                XL4.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed15(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XL4.Text, Ok)
            If Ok Then
                XL5.Focus()
            End If
        End If
    End Sub


    Private Sub keypressed16(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XL5.Text, Ok)
            If Ok Then
                XL6.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed17(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim Ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            VV(XL6.Text, Ok)
            If Ok Then
                'ESTADO.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed18(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            XS.Focus()
        End If
    End Sub


    Private Sub VV(ByVal dato As String, ByRef bien As Boolean)
        Dim NUMERO As Integer
        bien = False
        Try
            bien = True
            NUMERO = CInt(dato)
            TOTAL(bien)
        Catch
            bien = False
        End Try
    End Sub

    Private Sub co(ByVal dato As String, ByVal bien As Boolean)
        Dim num As Decimal
        bien = True
        Try
            num = CDec(dato)
            bien = True
        Catch
            bien = False
        End Try
    End Sub


    Private Sub TOTAL(ByRef SI As Boolean)
        Try
            TOTALES.Text = CInt(XS.Text) + CInt(S.Text) + CInt(M.Text) + CInt(L.Text) + CInt(XL.Text) + CInt(XL2.Text) + CInt(XL3.Text) + CInt(XL4.Text) + CInt(XL5.Text) + CInt(XL6.Text)
        Catch
            MsgBox("Por favor revise las tallas", MsgBoxStyle.OKOnly, "Existen valores no Validos !!!! ")
            SI = False
        End Try
    End Sub

    Private Sub XS_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XS.Leave
        TOTAL(ok)
    End Sub


    Private Sub S_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S.Leave
        TOTAL(ok)
    End Sub

    Private Sub M_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M.Leave
        TOTAL(ok)
    End Sub

    Private Sub L_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.Leave
        TOTAL(ok)
    End Sub

    Private Sub XL_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XL.Leave
        TOTAL(ok)
    End Sub

    Private Sub XL2_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XL2.Leave
        TOTAL(ok)
    End Sub

    Private Sub XL3_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XL3.Leave
        TOTAL(ok)
    End Sub

    Private Sub XL4_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XL4.Leave
        TOTAL(ok)
    End Sub

    Private Sub XL5_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XL5.Leave
        TOTAL(ok)
    End Sub

    Private Sub XL6_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XL6.Leave
        TOTAL(ok)
    End Sub


    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.Click
        revisa_Detalle(ok)
        If ok Then
            graba_registro()
            habilita()
            G1.Visible = False
            E1.Visible = False
        End If
    End Sub

    Private Sub revisa_Detalle(ByRef ok As Boolean)
        ok = True
        If Trim(Estilos.Text) = "" Then
            ok = False
            mensaje("ESTILO")
        End If
        If Trim(COLORES.Text) = "" Then
            ok = False
            mensaje("COLOR")
        End If
        If ok Then
            VV(XS.Text, ok)
            VV(S.Text, ok)
            VV(M.Text, ok)
            VV(L.Text, ok)
            VV(XL.Text, ok)
            VV(XL2.Text, ok)
            VV(XL3.Text, ok)
            VV(XL4.Text, ok)
            VV(XL5.Text, ok)
            VV(XL6.Text, ok)
        End If
        If CDec(TOTALES.Text) = 0 Then
            ok = False
            mensaje("Error en las Unidades")
        End If
        If ok Then
            revisa_fechas(ok)
        End If
        If ok Then
            revisa_costos(ok)
        End If
    End Sub

    Private Sub agrega_linea()
        Dim lin As Integer = fg.Rows.Count
        fg.Rows.Count = lin + 1
        llena_lineas(lin)
        fg.Sort(SortFlags.Ascending, 1)
        sub_total()
    End Sub

    Private Sub elimina_linea()
        Dim lin As Integer
        Dim busca As String = Trim(Estilos.Text) + Trim(COLORES.Text)
        lin = fg.FindRow(busca, 1, 0, True)
        fg.Rows.Remove(lin)
        sub_total()
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer
        Dim busca As String = Trim(Estilos.Text) + Trim(COLORES.Text)
        lin = fg.FindRow(busca, 1, 0, True)
        llena_lineas(lin)
        sub_total()
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 0) = Trim(Estilos.Text) + Trim(COLORES.Text)
            fg(lineas, 1) = CPOS.Text
            fg(lineas, 2) = Estilos.Text
            fg(lineas, 3) = COLORES.Text
            fg(lineas, 4) = XS.Text
            fg(lineas, 5) = S.Text
            fg(lineas, 6) = M.Text
            fg(lineas, 7) = L.Text
            fg(lineas, 8) = XL.Text
            fg(lineas, 9) = XL2.Text
            fg(lineas, 10) = XL3.Text
            fg(lineas, 11) = XL4.Text
            fg(lineas, 12) = XL5.Text
            fg(lineas, 13) = XL6.Text
            fg(lineas, 14) = TOTALES.Text
            fg(lineas, 16) = F_ENTREGA.Text
            fg(lineas, 17) = destino.Text
        Catch
        End Try
    End Sub


    Private Sub R2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R2.Click
        habilita()
    End Sub

    Private Sub E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        Dim ok As Boolean = True
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_cortes(ok)
            If ok Then
                elimina()
                habilita()
            Else
                MsgBox("Este Estilo-Color no se puede eliminar. Ya posee cortes", MsgBoxStyle.Critical, "Error en la eliminación")
            End If
        End If
    End Sub

    Private Sub revisa_cortes(ByRef ok As Boolean)
        Dim cor As New DataTable()
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"
        ok = True
        llena_tablas(cor, strsql, cnns)
        If cor.Rows.Count > 0 Then
            ok = False
        End If
    End Sub

    Private Sub revisa_fechas(ByRef si As Boolean)
        If CDate(F_PEDIDO.Text) > CDate(F_ENTREGA.Text) Then
            si = False
            mensaje("Error en las Fechas")
        Else
            si = True
        End If
    End Sub

    Private Sub ct_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles ct.ValidateEdit
        ' validate amounts
        If ct.Cols(e.Col).DataType Is GetType(Decimal) Then
            Try
                Dim dec As Decimal = Decimal.Parse(ct.Editor.Text())
            Catch
                MessageBox.Show("Por favor Ingrese un valor numerico!!!")
                e.Cancel = True
            End Try
        End If
    End Sub

    Private Sub ct_rowcolchange(ByVal sender As Object, ByVal e As RowColEventArgs) Handles ct.AfterEdit
        Dim tot As Decimal
        Dim cont As Integer
        Dim i As Integer
        For i = 0 To 9
            If ct(0, i) > 0 Then
                tot = ct(0, i)
                cont = cont + 1
            End If
        Next
        If cont = 1 Then
            copia_costo(tot)
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub copia_costo(ByVal costo As Decimal)
        Dim i As Integer
        Dim dat As String = XS.Text + "|" + S.Text + "|" + M.Text + "|" + L.Text + "|" + XL.Text + "|" + XL2.Text + "|" + XL3.Text + "|" + XL4.Text + "|" + XL5.Text + "|" + XL6.Text
        r = Split(dat, "|")
        For i = 0 To 9
            If r(i) > 0 Then
                ct(0, i) = costo
            End If
        Next
    End Sub

    Private Sub revisa_costos(ByRef ok As Boolean)
        Dim i As Integer
        Dim dat As String = XS.Text + "|" + S.Text + "|" + M.Text + "|" + L.Text + "|" + XL.Text + "|" + XL2.Text + "|" + XL3.Text + "|" + XL4.Text + "|" + XL5.Text + "|" + XL6.Text
        Dim ta As String()
        r = Split(dat, "|")
        ta = Split(t, "|")
        For i = 0 To 9
            If r(i) > 0 And ct(0, i) = 0 Then
                MsgBox("Aun no ha ingresado costo para la talla " + ta(i), MsgBoxStyle.Critical, "Por favor revise !!!!")
                ok = False
            End If
        Next
    End Sub

    Private Sub verifica_ordenes(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "' AND EXPORTADO = 'N'"
        llena_tablas(dt, strsql, cnns)
        If dt.Rows.Count > 0 Then
            ok = False
        Else
            ok = True
        End If
    End Sub

    Private Sub CLIENTES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTES.SelectedIndexChanged
        llena_estilos()
    End Sub

    Private Sub Estilos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estilos.SelectedIndexChanged
        llena_colores()
    End Sub

    ' =================================================================================
    ' =                            ACTUALIZA TABLAS
    ' =================================================================================

    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer
        Dim fecha1 As String
        Dim fecha2 As String
        Dim fechae As String = Format(CDate(F_ENTREGA.Text), "yyyy-MM-dd")
        Dim hoy As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' ================ ENCABEZADOS ====================
            fecha1 = Format(CDate(F_PEDIDO.Text), "yyyy-MM-dd")
            fecha2 = Format(CDate(F_ENTREGA.Text), "yyyy-MM-dd")
            strsql = "UPDATE CPO_2 SET CLIENTE = " & "'" & CLIENTES.Text & "'" & _
                                 " , F_PEDIDO = " & "'" & fecha1 & "'" & _
                                 " , F_ENTREGA = " & "'" & fecha2 & "'" & _
                                 " WHERE CPO = '" & CPOS.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CPO_2 (CPO,CLIENTE,F_PEDIDO,F_ENTREGA) " & _
                         "VALUES ( '" & CPOS.Text & "','" & _
                             CLIENTES.Text & "','" & _
                             fecha1 & "','" & _
                             fecha2 & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            ' ================ DETALLE ====================
            strsql = "UPDATE CPO_D2  SET ESTILO = " & "'" & Estilos.Text & "'" & _
             " , COLOR = " & "'" & COLORES.Text & "'" & _
             " , XS = " & "'" & XS.Text & "'" & _
             " , S = " & "'" & S.Text & "'" & _
             " , M = " & "'" & M.Text & "'" & _
             " , L = " & "'" & L.Text & "'" & _
             " , XL = " & "'" & XL.Text & "'" & _
             " , XL2 = " & "'" & XL2.Text & "'" & _
             " , XL3 = " & "'" & XL3.Text & "'" & _
             " , XL4 = " & "'" & XL4.Text & " '" & _
             " , XL5 = " & "'" & XL5.Text & "'" & _
             " , XL6 = " & "'" & XL6.Text & "'" & _
             " , TOTAL = " & "'" & TOTALES.Text & "'" & _
             " , F_ENTREGA = " & "'" & fechae & "'" & _
             " , F_PROMETIDA = " & "'" & fechae & "'" & _
             " , DESTINO = " & "'" & destino.Text & "'" & _
             " , C1 = " & "'" & ct(0, 0) & "'" & _
             " , C2 = " & "'" & ct(0, 1) & "'" & _
             " , C3 = " & "'" & ct(0, 2) & "'" & _
             " , C4 = " & "'" & ct(0, 3) & "'" & _
             " , C5 = " & "'" & ct(0, 4) & "'" & _
             " , C6 = " & "'" & ct(0, 5) & "'" & _
             " , C7 = " & "'" & ct(0, 6) & "'" & _
             " , C8 = " & "'" & ct(0, 7) & "'" & _
             " , C9 = " & "'" & ct(0, 8) & "'" & _
             " , C0 = " & "'" & ct(0, 9) & "' , USUARIO = '" & usuario & "' , FECHA = '" & hoy & "'  WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CPO_D2 (CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,F_ENTREGA,F_PROMETIDA,DESTINO,C1,C2,C3,C4,C5,C6,C7,C8,C9,C0,FECHA,USUARIO) " & _
                         "VALUES ( '" & CPOS.Text & "','" & _
                             Estilos.Text & "','" & _
                             COLORES.Text & "','" & _
                             XS.Text & "','" & _
                             S.Text & "','" & _
                             M.Text & "','" & _
                             L.Text & "','" & _
                             XL.Text & "','" & _
                             XL2.Text & "','" & _
                             XL3.Text & "','" & _
                             XL4.Text & "','" & _
                             XL5.Text & "','" & _
                             XL6.Text & "','" & _
                             TOTALES.Text & "','" & _
                             fechae & "','" & _
                             fechae & "','" & _
                             UCase(destino.Text) & "','" & _
                             ct(0, 0) & "','" & _
                             ct(0, 1) & "','" & _
                             ct(0, 2) & "','" & _
                             ct(0, 3) & "','" & _
                             ct(0, 4) & "','" & _
                             ct(0, 5) & "','" & _
                             ct(0, 6) & "','" & _
                             ct(0, 7) & "','" & _
                             ct(0, 8) & "','" & _
                             ct(0, 9) & "','" & hoy & "','" & usuario & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                agrega_linea()
            Else
                cambia_linea()
            End If

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
            cna.Close()
        End Try
    End Sub

    Private Sub elimina()
        Dim strsql As String
        Dim afectados As Integer

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CPO_D2 WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            elimina_linea()
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
            cna.Close()
        End Try
    End Sub

    Private Sub elimina_todo()
        Dim strsql As String
        Dim afectados As Integer

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CPO_D2 WHERE CPO = '" & CPOS.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE FROM CPO_2  WHERE CPO = '" & CPOS.Text & "'"
            comando.CommandText = strsql
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
            cna.Close()
        End Try
    End Sub


    Private Sub CPOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPOS.Leave
        Dim ok As Boolean
        revisa_cpo(ok)
        If Not ok Then
            CPOS.Focus()
        End If
    End Sub

    Private Sub revisa_cpo(ByRef ok As Boolean)
        Dim dd As DataRow()
        ok = True
        dd = cp.Select("CPO = '" & CPOS.Text & "'")
        If dd.Length > 0 Then
            MsgBox("Cpo ya existe !!!", MsgBoxStyle.Critical, "Por favor revise !!!")
            ok = False
        End If
    End Sub

    Private Sub sub_total()
        Dim i As Integer
        Dim t As Integer
        For i = 1 To fg.Rows.Count - 1
            t = t + fg(i, 14)
        Next
        tp.Text = Format(t, "##,###,##0")
        tp.Refresh()
    End Sub

    Private Sub clientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLIENTES.KeyPress
        AutoCompletar(CLIENTES, e)
    End Sub
    Private Sub estilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estilos.KeyPress
        AutoCompletar(Estilos, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COLORES.KeyPress
        AutoCompletar(COLORES, e)
    End Sub
End Class
