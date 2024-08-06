Imports C1.Win.C1FlexGrid

Public Class Ingreso_Cpo_47
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
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents serigrafia As System.Windows.Forms.TextBox
    Friend WithEvents ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cortes As System.Windows.Forms.TextBox
    Friend WithEvents cpos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents subc As System.Windows.Forms.TextBox
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents COLORES As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents E2 As System.Windows.Forms.Button
    Friend WithEvents R2 As System.Windows.Forms.Button
    Friend WithEvents G2 As System.Windows.Forms.Button
    Friend WithEvents Estilos As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents destino As System.Windows.Forms.TextBox
    Friend WithEvents tp As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Cpo_47))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.G1 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.COLORES = New System.Windows.Forms.ComboBox()
        Me.E2 = New System.Windows.Forms.Button()
        Me.R2 = New System.Windows.Forms.Button()
        Me.G2 = New System.Windows.Forms.Button()
        Me.Estilos = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.destino = New System.Windows.Forms.TextBox()
        Me.cpos = New System.Windows.Forms.ComboBox()
        Me.serigrafia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tp = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cortes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subc = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Estilo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 84)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
        '
        'ta
        '
        Me.ta.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ta.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.ta.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ta.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ta.BackColor = System.Drawing.Color.White
        Me.ta.ColumnInfo = resources.GetString("ta.ColumnInfo")
        Me.ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ta.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ta.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ta.Location = New System.Drawing.Point(6, 23)
        Me.ta.Name = "ta"
        Me.ta.Rows.Count = 2
        Me.ta.Rows.DefaultSize = 19
        Me.ta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ta.Size = New System.Drawing.Size(827, 46)
        Me.ta.StyleInfo = resources.GetString("ta.StyleInfo")
        Me.ta.TabIndex = 8
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
        'COLORES
        '
        Me.COLORES.Location = New System.Drawing.Point(263, 96)
        Me.COLORES.MaxLength = 20
        Me.COLORES.Name = "COLORES"
        Me.COLORES.Size = New System.Drawing.Size(237, 21)
        Me.COLORES.TabIndex = 3
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
        Me.Estilos.Size = New System.Drawing.Size(227, 21)
        Me.Estilos.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Estilos, "Cliente")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 254)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(983, 410)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'destino
        '
        Me.destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destino.Location = New System.Drawing.Point(507, 96)
        Me.destino.MaxLength = 30
        Me.destino.Name = "destino"
        Me.destino.Size = New System.Drawing.Size(325, 20)
        Me.destino.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.destino, "Numero de CPO")
        '
        'cpos
        '
        Me.cpos.Location = New System.Drawing.Point(8, 29)
        Me.cpos.MaxLength = 20
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(160, 21)
        Me.cpos.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cpos, "Cliente")
        '
        'serigrafia
        '
        Me.serigrafia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serigrafia.Location = New System.Drawing.Point(263, 140)
        Me.serigrafia.MaxLength = 20
        Me.serigrafia.Name = "serigrafia"
        Me.serigrafia.Size = New System.Drawing.Size(109, 24)
        Me.serigrafia.TabIndex = 6
        Me.serigrafia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(263, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cpos)
        Me.GroupBox2.Controls.Add(Me.E1)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.G1)
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
        Me.Label22.Location = New System.Drawing.Point(507, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(325, 16)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Destino"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tp
        '
        Me.tp.BackColor = System.Drawing.Color.White
        Me.tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp.ForeColor = System.Drawing.Color.Black
        Me.tp.Location = New System.Drawing.Point(856, 664)
        Me.tp.Name = "tp"
        Me.tp.Size = New System.Drawing.Size(104, 32)
        Me.tp.TabIndex = 54
        Me.tp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(728, 664)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 32)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Total Prendas:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.SteelBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(263, 124)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 16)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Serigrafía"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(404, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Corte"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cortes
        '
        Me.cortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cortes.Location = New System.Drawing.Point(404, 140)
        Me.cortes.MaxLength = 20
        Me.cortes.Name = "cortes"
        Me.cortes.Size = New System.Drawing.Size(96, 24)
        Me.cortes.TabIndex = 7
        Me.cortes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Sub-CPO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subc
        '
        Me.subc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subc.Location = New System.Drawing.Point(16, 140)
        Me.subc.MaxLength = 20
        Me.subc.Name = "subc"
        Me.subc.Size = New System.Drawing.Size(227, 24)
        Me.subc.TabIndex = 5
        Me.subc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ingreso_Cpo_47
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 703)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cortes)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.serigrafia)
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
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Cpo_47"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso CPO 47"
        Me.ToolTip1.SetToolTip(Me, "Ingreso CPO 47")
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler CPOS.KeyPress, AddressOf keypressed1
        AddHandler Estilos.KeyPress, AddressOf keypressed2
        AddHandler COLORES.KeyPress, AddressOf keypressed3
        AddHandler destino.KeyPress, AddressOf keypressed4
        AddHandler subc.KeyPress, AddressOf keypressed4a
        AddHandler serigrafia.KeyPress, AddressOf keypressed5
        AddHandler cortes.KeyPress, AddressOf keypressed6

        Dim obj As New empresas()
        usuario = obj.usuario
        llena_combos(cpos, "SELECT DISTINCT CPO_D.CPO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO=CPO.CPO WHERE CLIENTE LIKE '47%' AND ESTADO = 'A' AND YEAR(CPO_D.F_ENTREGA) = '2019'", "CPO")
        llena_tablas(cp, "SELECT * FROM CPO", cna)
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub limpia_ta()
        Dim i As Integer
        For i = 1 To 11
            ta(1, i) = 0
        Next
    End Sub
    Private Sub limpia_variables()
        limpia_ta()
        CPOS.Enabled = True
        Clientes.Enabled = False
        serigrafia.Enabled = False
        Estilos.Enabled = False
        COLORES.Enabled = False
        destino.Enabled = False
        subc.Enabled = False
        cortes.Enabled = False
        ta.Enabled = False
        G1.Visible = False
        E1.Visible = False
        R1.Visible = True
        G2.Visible = False
        R2.Visible = False
        E2.Visible = False
        destino.Text = ""
        serigrafia.Text = ""
        subc.Text = ""
        cortes.Text = ""
        tp.Text = "0"
        r = Split(b, "|")
        setea_grid()
        cpos.Focus()
    End Sub

    Private Sub re_habilita()
        CPOS.Enabled = False
        E1.Visible = True
        G1.Visible = True
        R1.Visible = True
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 19
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
        fg.Cols(16).Name = "SERIGRAFIA"
        fg.Cols(17).Name = "LUGAR DE ENVIO"
        fg.Cols(18).Name = "SUB CPO"
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
        Dim strSQL As String = "SELECT * FROM CPO_D_47 WHERE CPO ='" & cpos.Text & "'"
        llena_tablas(dt, strSQL, cna)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
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
            fg(lineas, 16) = dr("SERIGRAFIA")
            fg(lineas, 17) = dr("DESTINO")
            fg(lineas, 18) = dr("SUB_CPO")
            lineas = lineas + 1
        Next
        sub_total()
    End Sub
    Private Sub llena_estilos()
        llena_combos(Estilos, "SELECT DISTINCT CPO_D.ESTILO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO=CPO.CPO WHERE CLIENTE LIKE '47%' AND ESTADO = 'A' AND YEAR(CPO_D.F_ENTREGA) = '2019' AND CPO_D.CPO = '" & cpos.Text & "'", "ESTILO")
    End Sub

    Private Sub llena_colores()
        llena_combos(COLORES, "SELECT DISTINCT COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO=CPO.CPO WHERE CLIENTE LIKE '47%' AND ESTADO = 'A' AND YEAR(CPO_D.F_ENTREGA) = '2019' AND CPO_D.CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "'", "COLOR")
    End Sub

    Private Sub busca_cpos()
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_D_47 WHERE CPO =  '" & cpos.Text & "'"
        llena_tablas(dt, strSQL, cna)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            llena_grid()
            E1.Visible = True
        Else
            Estilos.Focus()
        End If
        habilita()
    End Sub

    Private Sub busca_detalle()
        limpia_ta()
        Dim dr As DataRow
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_D_47 WHERE CPO =  '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "' AND DESTINO = '" & destino.Text & "' AND SERIGRAFIA = '" & serigrafia.Text & "' AND SUB_CPO = '" & subc.Text & "'"
        llena_tablas(dt, strSQL, cna)
        For Each dr In dt.Rows
            ta(1, 1) = dr("XS")
            ta(1, 2) = dr("S")
            ta(1, 3) = dr("M")
            ta(1, 4) = dr("L")
            ta(1, 5) = dr("XL")
            ta(1, 6) = dr("XL2")
            ta(1, 7) = dr("XL3")
            ta(1, 8) = dr("XL4")
            ta(1, 9) = dr("XL5")
            ta(1, 10) = dr("XL6")
            ta(1, 11) = dr("TOTAL")
            destino.Text = dr("DESTINO")
            serigrafia.Text = dr("SERIGRAFIA")
            cortes.Text = dr("CORTE")
            E2.Visible = True
        Next
        habilita1()
        cortes.Focus()
    End Sub

    Private Sub habilita()
        CPOS.Enabled = False
        Estilos.Enabled = True
        COLORES.Enabled = True
        destino.Enabled = True
        serigrafia.Enabled = True
        subc.Enabled = True
        cortes.Enabled = False
        destino.Text = ""
        cortes.Text = ""
        serigrafia.Text = ""
        G2.Visible = False
        R2.Visible = True
        E2.Visible = False
        ta.Enabled = False
        Estilos.Focus()
        sub_total()
    End Sub

    Private Sub habilita1()
        G2.Visible = True
        Estilos.Enabled = False
        COLORES.Enabled = False
        destino.Enabled = False
        serigrafia.Enabled = False
        subc.Enabled = False
        cortes.Enabled = True
        ta.Enabled = True
        r = Split(b, "|")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        revisa_cpo(ok)
        If ok Then
            llena_colores()
            llena_estilos()
            llena_grid()
            habilita()
            G1.Visible = False
            E1.Visible = False
        End If
    End Sub


    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar TODA LA CPO?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_todo()
            limpia_variables()
        End If
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            Dim e As Integer = Estilos.Items.IndexOf(fg(fil, 2))
            Dim c As Integer = COLORES.Items.IndexOf(fg(fil, 3))
            Try
                Estilos.Text = Estilos.Items(e)
                COLORES.Text = COLORES.Items(c)
                destino.Text = fg(fil, 17)
                serigrafia.Text = fg(fil, 16)
                subc.Text = fg(fil, 18)
                busca_detalle()
            Catch
            End Try
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
            If Trim(Estilos.Text) <> "" Then
                COLORES.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(COLORES.Text) <> "" Then
                destino.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(destino.Text) <> "" Then
                subc.Focus()
            End If

        End If
    End Sub 'keypressed
    Private Sub keypressed4a(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(subc.Text) <> "" Then
                serigrafia.Focus()
            End If

        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(serigrafia.Text) <> "" Then
                busca_detalle()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cortes.Text) <> "" Then
                ta.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub TOTAL(ByRef SI As Boolean)
        Try
            ta(1, 11) = ta(1, 1) + ta(1, 2) + ta(1, 3) + ta(1, 4) + ta(1, 5) + ta(1, 6) + ta(1, 7) + ta(1, 8) + ta(1, 9) + ta(1, 10)
        Catch
            MsgBox("Por favor revise las tallas", MsgBoxStyle.OkOnly, "Existen valores no Validos !!!! ")
            SI = False
        End Try
    End Sub

    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.Click
        revisa_Detalle(ok)
        If ok Then
            graba_registro()
            habilita()
            limpia_ta()
            G1.Visible = False
            E1.Visible = False
            sub_total()
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
        If ta(1, 11) = 0 Then
            ok = False
            mensaje("Error en las Unidades")
        End If
    End Sub


    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 0) = Trim(Estilos.Text) + Trim(COLORES.Text)
            fg(lineas, 1) = CPOS.Text
            fg(lineas, 2) = Estilos.Text
            fg(lineas, 3) = COLORES.Text
            fg(lineas, 4) = ta(1, 1)
            fg(lineas, 5) = ta(1, 2)
            fg(lineas, 6) = ta(1, 3)
            fg(lineas, 7) = ta(1, 4)
            fg(lineas, 8) = ta(1, 5)
            fg(lineas, 9) = ta(1, 6)
            fg(lineas, 10) = ta(1, 7)
            fg(lineas, 11) = ta(1, 8)
            fg(lineas, 12) = ta(1, 9)
            fg(lineas, 13) = ta(1, 10)
            fg(lineas, 14) = ta(1, 11)
            fg(lineas, 16) = serigrafia.Text
            fg(lineas, 17) = destino.Text
        Catch
        End Try
    End Sub


    Private Sub R2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R2.Click
        habilita()
        limpia_ta()
    End Sub

    Private Sub E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        Dim ok As Boolean = True
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
            habilita()
            limpia_ta()
            sub_total()
        End If
    End Sub
    Private Sub ta_rowcolchange(ByVal sender As Object, ByVal e As RowColEventArgs) Handles ta.AfterEdit
        Dim ok As Boolean
        TOTAL(ok)
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub CLIENTES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' ================ ENCABEZADOS ====================
            strsql = "UPDATE CPO_D_47 SET CORTE = '" & cortes.Text & "'" & _
                                 " , XS = " & "'" & ta(1, 1) & "'" & _
                                 " , S = " & "'" & ta(1, 2) & "'" & _
                                 " , M = " & "'" & ta(1, 3) & "'" & _
                                 " , L = " & "'" & ta(1, 4) & "'" & _
                                 " , XL = " & "'" & ta(1, 5) & "'" & _
                                 " , XL2 = " & "'" & ta(1, 6) & "'" & _
                                 " , XL3 = " & "'" & ta(1, 7) & "'" & _
                                 " , XL4 = " & "'" & ta(1, 8) & " '" & _
                                 " , XL5 = " & "'" & ta(1, 9) & "'" & _
                                 " , XL6 = " & "'" & ta(1, 10) & "'" & _
                                 " , TOTAL = " & "'" & ta(1, 11) & "' WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "' AND DESTINO = '" & destino.Text & "' AND SERIGRAFIA = '" & serigrafia.Text & "' AND SUB_CPO = '" & subc.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CPO_D_47 (CPO,ESTILO,COLOR,DESTINO,SERIGRAFIA,SUB_CPO,CORTE,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL) " & _
                         "VALUES ( '" & cpos.Text & "','" & _
                             Estilos.Text & "','" & _
                             COLORES.Text & "','" & _
                             destino.Text & "','" & _
                             serigrafia.Text & "','" & _
                             subc.Text & "','" & _
                             cortes.Text & "','" & _
                             ta(1, 1) & "','" & _
                             ta(1, 2) & "','" & _
                             ta(1, 3) & "','" & _
                             ta(1, 4) & "','" & _
                             ta(1, 5) & "','" & _
                             ta(1, 6) & "','" & _
                             ta(1, 7) & "','" & _
                             ta(1, 8) & "','" & _
                             ta(1, 9) & "','" & _
                             ta(1, 10) & "','" & _
                             ta(1, 11) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()
            setea_grid()
            llena_grid()
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
            strsql = "DELETE FROM CPO_D_47 WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "' AND DESTINO = '" & destino.Text & "' AND SERIGRAFIA ='" & serigrafia.Text & "' AND SUB_CPO = '" & subc.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            setea_grid()
            llena_grid()
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
            strsql = "DELETE FROM CPO_D_47 WHERE CPO = '" & cpos.Text & "'"
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

    Private Sub CPOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub CPO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpos.KeyPress
        AutoCompletar(cpos, e)
    End Sub
    Private Sub estilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estilos.KeyPress
        AutoCompletar(Estilos, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COLORES.KeyPress
        AutoCompletar(COLORES, e)
    End Sub

    Private Sub cpos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cpos.SelectedIndexChanged
        llena_estilos()
    End Sub
End Class
