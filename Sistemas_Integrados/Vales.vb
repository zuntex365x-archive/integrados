Imports C1.Win.C1FlexGrid

Public Class Vales
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim usuario_sistema As String
    Dim lineas As Integer
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents recibe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents motivo As System.Windows.Forms.ComboBox
    Friend WithEvents cortes As System.Windows.Forms.ComboBox
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents tallas As System.Windows.Forms.ComboBox
    Friend WithEvents cobrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prendas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nvale As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Vales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.R1 = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.recibe = New System.Windows.Forms.TextBox()
        Me.prendas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.motivo = New System.Windows.Forms.ComboBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.tallas = New System.Windows.Forms.ComboBox()
        Me.cobrar = New System.Windows.Forms.ComboBox()
        Me.cortes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nvale = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(168, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(312, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fecha"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy"
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha.Location = New System.Drawing.Point(312, 40)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(136, 26)
        Me.Fecha.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Fecha, "Fecha de la Produccion")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Bitmap)
        Me.R1.Location = New System.Drawing.Point(912, 72)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 50
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Bitmap)
        Me.G1.Location = New System.Drawing.Point(912, 24)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 51
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Actualiza la BAse de Datos.")
        Me.G1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Bitmap)
        Me.S1.Location = New System.Drawing.Point(872, 24)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 8
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Ingresa Datos")
        '
        'recibe
        '
        Me.recibe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recibe.Location = New System.Drawing.Point(456, 40)
        Me.recibe.MaxLength = 20
        Me.recibe.Name = "recibe"
        Me.recibe.Size = New System.Drawing.Size(392, 22)
        Me.recibe.TabIndex = 2
        Me.recibe.Text = ""
        Me.ToolTip1.SetToolTip(Me.recibe, "No. Embarque")
        '
        'prendas
        '
        Me.prendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prendas.Location = New System.Drawing.Point(584, 120)
        Me.prendas.MaxLength = 20
        Me.prendas.Name = "prendas"
        Me.prendas.Size = New System.Drawing.Size(120, 22)
        Me.prendas.TabIndex = 6
        Me.prendas.Text = "1"
        Me.ToolTip1.SetToolTip(Me.prendas, "No. Embarque")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(456, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 24)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Vale Emitido a "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "7,1,0,0,0,95,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:150;Caption:""CORTE"";DataType:System.String;TextAlign:CenterCenter;TextAli" & _
        "gnFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:335;Caption:""MOTIVO DEL VALE"";TextAlign:LeftCente" & _
        "r;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:162;Caption:""T.PRENDA"";DataType:System.Str" & _
        "ing;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Caption:""TALLA"";DataType:" & _
        "System.String;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Caption:""PR" & _
        "ENDAS"";DataType:System.Int32;Format:""###0"";TextAlign:RightCenter;TextAlignFixed:" & _
        "RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Caption:""Cobrar?"";DataType:System.String;TextAlign:CenterCenter;" & _
        "TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 160)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(944, 488)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackCol" & _
        "or:167, 232, 245;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,Co" & _
        "ntrolDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Se" & _
        "arch{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewR" & _
        "ow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Grand" & _
        "Total{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;Fore" & _
        "Color:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{Ba" & _
        "ckColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;Fo" & _
        "reColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{" & _
        "BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 24)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Motivo del Vale"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(312, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "T.prenda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(456, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Talla"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(712, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Cobrar?"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'motivo
        '
        Me.motivo.Items.AddRange(New Object() {"Perdida", "Muestras", "Atención Gerencia"})
        Me.motivo.Location = New System.Drawing.Point(16, 120)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(288, 24)
        Me.motivo.TabIndex = 3
        '
        'tipo
        '
        Me.tipo.Items.AddRange(New Object() {"Primera", "Segunda"})
        Me.tipo.Location = New System.Drawing.Point(312, 120)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(136, 24)
        Me.tipo.TabIndex = 4
        '
        'tallas
        '
        Me.tallas.Items.AddRange(New Object() {"Primera", "Segunda"})
        Me.tallas.Location = New System.Drawing.Point(456, 120)
        Me.tallas.Name = "tallas"
        Me.tallas.Size = New System.Drawing.Size(120, 24)
        Me.tallas.TabIndex = 5
        '
        'cobrar
        '
        Me.cobrar.Items.AddRange(New Object() {"Si", "No"})
        Me.cobrar.Location = New System.Drawing.Point(712, 120)
        Me.cobrar.MaxDropDownItems = 7
        Me.cobrar.Name = "cobrar"
        Me.cobrar.Size = New System.Drawing.Size(120, 24)
        Me.cobrar.TabIndex = 6
        '
        'cortes
        '
        Me.cortes.Items.AddRange(New Object() {"Si", "No"})
        Me.cortes.Location = New System.Drawing.Point(168, 40)
        Me.cortes.Name = "cortes"
        Me.cortes.Size = New System.Drawing.Size(136, 24)
        Me.cortes.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(584, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "No. Prendas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nvale
        '
        Me.nvale.Items.AddRange(New Object() {"Si", "No"})
        Me.nvale.Location = New System.Drawing.Point(16, 40)
        Me.nvale.Name = "nvale"
        Me.nvale.Size = New System.Drawing.Size(136, 24)
        Me.nvale.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Vale"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Vales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.nvale, Me.Label8, Me.prendas, Me.Label2, Me.S1, Me.cortes, Me.cobrar, Me.tallas, Me.tipo, Me.motivo, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.fg, Me.recibe, Me.Label3, Me.R1, Me.G1, Me.Fecha, Me.Label19, Me.Label1, Me.Label9})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captación de Vales"
        Me.ToolTip1.SetToolTip(Me, "Ingreso de Vales")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cortes.KeyPress, AddressOf keypressed1
        AddHandler Fecha.KeyPress, AddressOf keypressed2
        AddHandler recibe.KeyPress, AddressOf keypressed3
        AddHandler motivo.KeyPress, AddressOf keypressed4
        AddHandler tipo.KeyPress, AddressOf keypressed5
        AddHandler tallas.KeyPress, AddressOf keypressed6
        AddHandler prendas.KeyPress, AddressOf keypressed7
        AddHandler cobrar.KeyPress, AddressOf keypressed8
        Dim obj As empresas
        obj = New empresas()
        usuario_sistema = obj.usuario
        llena_combos(cortes, "SELECT CORTE FROM CORTES WHERE FCORTE > '2011-01-01' ORDER BY CORTE", "CORTE") 'EXPORTADO <> 'S' ORDER BY CORTE", "CORTE")
        llena_combos(tallas, "SELECT * FROM TALLAS ORDER BY ORDEN", "TALLA")
        limpia_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub limpia_variables()
        nvale.Enabled = False
        nvale.Text = ""
        cortes.Enabled = True
        Fecha.Enabled = True
        recibe.Enabled = True
        motivo.Enabled = True
        tipo.Enabled = True
        tallas.Enabled = True
        cobrar.Enabled = True
        Try
            cortes.SelectedIndex = 0
        Catch
        End Try
        motivo.SelectedIndex = 0
        tipo.SelectedIndex = 0
        tallas.SelectedIndex = 0
        cobrar.SelectedIndex = 0
        G1.Visible = True
        S1.Visible = True
        prendas.Text = "1"
        recibe.Text = ""
        setea_grid()
        cortes.Focus()
    End Sub

    Private Sub deshabilita()
        nvale.Enabled = True
        llena_vales()
        cortes.Enabled = False
        Fecha.Enabled = False
        recibe.Enabled = False
        motivo.Enabled = False
        tipo.Enabled = False
        tallas.Enabled = False
        cobrar.Enabled = False
        G1.Visible = False
        S1.Visible = False
        prendas.Text = "1"
        recibe.Text = ""
        setea_grid()
        nvale.Focus()
    End Sub

    Private Sub llena_vales()
        Dim strsql As String = "SELECT * FROM VALES WHERE FECHA > '" & Format(Today.AddDays(-7), "yyyy-MM-dd") & "' ORDER BY VALE"
        llena_combos(nvale, strsql, "VALE")
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        chequea_linea()
    End Sub

    Private Sub chequea_linea()
        Dim busca As String = cortes.Text + tipo.Text + tallas.Text
        Dim l As Integer
        Dim p As Decimal
        l = fg.FindRow(busca, 1, 0, False)
        If l > 0 Then
            llena_variables(l)
        Else
            Try
                p = CInt(prendas.Text)
            Catch
                p = 0
            End Try
            If p > 0 Then
                llena_linea()
            Else
                MsgBox("No. de Prendas debe ser numérico mayor que 0.", MsgBoxStyle.Critical, "Revisar Prendas")
            End If
        End If
    End Sub

    Private Sub llena_variables(ByVal l As Integer)
        cortes.SelectedIndex = cortes.Items.IndexOf(fg(l, 1))
        motivo.SelectedIndex = motivo.Items.IndexOf(fg(l, 2))
        tipo.SelectedIndex = tipo.Items.IndexOf(fg(l, 3))
        tallas.SelectedIndex = tallas.Items.IndexOf(fg(l, 4))
        prendas.Text = fg(l, 5)
        cobrar.SelectedIndex = cobrar.Items.IndexOf(fg(l, 6))
    End Sub

    Private Sub llena_linea()
        Dim l As Integer = fg.Rows.Count
        fg.Rows.Count = l + 1
        fg(l, 1) = cortes.Text
        fg(l, 2) = motivo.Text
        fg(l, 3) = tipo.Text
        fg(l, 4) = tallas.Text
        fg(l, 5) = prendas.Text
        fg(l, 6) = cobrar.Text
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Esta completamente seguro de Anular los cambios Efectuados?", MsgBoxStyle.YesNo, "Cancelar Cambios")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox(var, MsgBoxStyle.OKOnly, "Error en los Datos !!!")
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim si As Boolean = True
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Esta completamente seguro de Grabar los Registros Ingresados?", MsgBoxStyle.YesNo, "Grabacion de Registros")
        If seguro = MsgBoxResult.No Then
            Exit Sub
        End If
        revisa_registros(si)
        If si Then
            graba_registros()
            limpia_variables()
        End If
    End Sub

    Private Sub revisa_registros(ByRef si As Boolean)
        Dim i As Integer
        Dim ultima As Date
        Dim corte As String
        si = True
        ultima = Now.AddDays(-6)
        If (Fecha.Value < ultima) Or (Fecha.Value > Now) Then
            MsgBox("Error en fechas.", MsgBoxStyle.Critical, "Por favor revisar !!!")
            si = False
            Exit Sub
        End If
        If Trim(recibe.Text) = "" Then
            MsgBox("El campo Emitido está vacio.", MsgBoxStyle.Critical, "Por favor revisar !!!")
            si = False
            Exit Sub
        End If

        For i = 1 To fg.Rows.Count - 1
            corte = fg(i, 1)
            revisa_corte(corte, i, si)
        Next
    End Sub

    Private Sub revisa_corte(ByVal corte As String, ByVal l As Integer, ByRef si As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim t As Integer
        Dim p As Integer
        Dim e As Integer
        Dim v As Integer
        Dim pro As Integer
        Dim exp As Integer
        Dim val As Integer
        llena_tablas(dt, "SELECT CORTES.CORTE,CORTES_P.*,CORTES_E.*,CORTES_V.* FROM CORTES LEFT JOIN CORTES_P ON CORTES.CORTE = CORTES_P.CORTE LEFT JOIN CORTES_E ON CORTES.CORTE = CORTES_E.CORTE LEFT JOIN CORTES_V ON CORTES.CORTE = CORTES_V.CORTE WHERE CORTES.CORTE = '" & corte & "'", cnn)
        For Each dr In dt.Rows
            If Mid(fg(l, 3), 1, 1) = "P" Then
                p = 2
                e = 23
                v = 44
            Else
                p = 12
                e = 33
                v = 54
            End If
            t = tallas.Items.IndexOf(fg(l, 4))
            Try
                pro = dr(p + t)
            Catch
                pro = 0
            End Try
            Try
                exp = dr(e + t)
            Catch
                exp = 0
            End Try
            Try
                val = dr(v + t)
            Catch
                val = 0
            End Try
            If (exp + val + fg(l, 5)) > pro Then
                MsgBox("Corte: " & corte & "  Tipo: " & fg(l, 3) & "  Talla: " & fg(l, 4) & ".  No alcanzan Unidades.", MsgBoxStyle.Critical, "Por favor Revise !!!!")
                si = False
            End If
        Next
    End Sub


    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Fecha.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            recibe.Focus()
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(recibe.Text) <> "" Then
                motivo.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            tipo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            tallas.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            prendas.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            cobrar.Focus()
        End If
    End Sub 'keypressed


    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            S1.Focus()
        End If
    End Sub 'keypressed


    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Try
            Dim seguro As MsgBoxResult
            seguro = MsgBox("Atencion: Desea Eliminar Esta Linea?", MsgBoxStyle.YesNo, "Eliminacion de Lineas")
            If seguro = MsgBoxResult.Yes Then
                fg.Rows.Remove(fg.RowSel)
            End If
        Catch
        End Try
    End Sub

    Private Sub despliega_vale()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim l As Integer = 1
        llena_tablas(dt, "SELECT * FROM VALES WHERE VALE = '" & nvale.Text & "'", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CORTE")
            fg(l, 2) = dr("MOTIVO")
            fg(l, 3) = dr("TIPO")
            fg(l, 4) = dr("TALLA")
            fg(l, 5) = dr("PRENDAS")
            fg(l, 6) = dr("COBRAR")
            Fecha.Text = dr("FECHA")
            recibe.Text = dr("RECIBE")
        Next
    End Sub
    Private Sub cortes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cortes.KeyPress
        AutoCompletar(cortes, e)
    End Sub
    Private Sub motivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles motivo.KeyPress
        AutoCompletar(motivo, e)
    End Sub
    Private Sub tipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tipo.KeyPress
        AutoCompletar(tipo, e)
    End Sub
    Private Sub talla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tallas.KeyPress
        AutoCompletar(tallas, e)
    End Sub
    Private Sub cobrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cobrar.KeyPress
        AutoCompletar(cobrar, e)
    End Sub
    Private Sub nvale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nvale.KeyPress
        AutoCompletar(nvale, e)
    End Sub

    '===================================================================
    '==           ACTUALIZA BASE DE DATOS
    '===================================================================
    Private Sub graba_registros()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim fechac As String = Format(CDate(Fecha.Text), "yyyy-MM-dd")
        Dim vale As Integer
        Dim ti As String
        Dim ta As String
        Dim p(9) As Integer
        Dim s(9) As Integer
        llena_tablas(dt, "SELECT VALES FROM CORRELATIVO", cnn)
        For Each dr In dt.Rows
            vale = dr("VALES") + 1
        Next
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE CORRELATIVO SET VALES = '" & vale & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                ' ================ ENCABEZADOS ====================
                strsql = "INSERT INTO VALES (VALE,CORTE,TIPO,TALLA,FECHA,MOTIVO,RECIBE,PRENDAS,COBRAR,INGRESADO,AUTORIZADO,UNIDADES) " & _
                                         "VALUES ( '" & vale & "','" & _
                                                    fg(i, 1) & "','" & _
                                                    fg(i, 3) & "','" & _
                                                    fg(i, 4) & "','" & _
                                                    fechac & "','" & _
                                                    fg(i, 2) & "','" & _
                                                    recibe.Text & "','" & _
                                                    fg(i, 5) & "','" & _
                                                    fg(i, 6) & "','" & _
                                                    usuario_sistema & "','','0')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                ' ================ ACTUALIZA VALES  ====================
                ti = Mid(fg(i, 3), 1, 1)
                ta = tallas.Items.IndexOf(fg(i, 4))
                strsql = "UPDATE CORTES_V SET " & ti + ta & " = " & ti + ta & " + " & fg(i, 5) & " WHERE CORTE = '" & fg(i, 1) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                If afectados = 0 Then
                    ReDim p(9)
                    ReDim s(9)
                    If ti = "P" Then
                        p(ta) = fg(i, 5)
                    Else
                        s(ta) = fg(i, 5)
                    End If
                    strsql = "INSERT INTO CORTES_V (CORTE,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9) " & _
                                     "VALUES ( '" & cortes.Text & "','" & _
                                             p(0) & "','" & _
                                             p(1) & "','" & _
                                             p(2) & "','" & _
                                             p(3) & "','" & _
                                             p(4) & "','" & _
                                             p(5) & "','" & _
                                             p(6) & "','" & _
                                             p(7) & "','" & _
                                             p(8) & "','" & _
                                             p(9) & "','" & _
                                             s(0) & "','" & _
                                             s(1) & "','" & _
                                             s(2) & "','" & _
                                             s(3) & "','" & _
                                             s(4) & "','" & _
                                             s(5) & "','" & _
                                             s(6) & "','" & _
                                             s(7) & "','" & _
                                             s(8) & "','" & _
                                             s(9) & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next
            transaccion.Commit()
            MsgBox("EL VALE No. " & vale & " FUE INGRESADO SATISFACTORIAMENTE,", MsgBoxStyle.Information, "VALE GRABADO")

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

End Class
