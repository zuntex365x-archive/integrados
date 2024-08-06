Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Prod_diaria
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim dr As DataRow
    Dim cns As New SqlClient.SqlConnection()
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim talla As String
    Dim co As New DataTable()
    Friend WithEvents imprime As System.Windows.Forms.Button
    Dim TC As String = "XS -0,S  -1,M  -2,L  -3,XL -4,XL2-5,XL3-6,XL4-7,XL5-8,XL6-9"
    Dim ta As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim tf As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
    Dim t(9) As String
    Dim tr(9) As String
    Dim escalas As String = "00"
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Prendas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Estados As System.Windows.Forms.ComboBox
    Friend WithEvents FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Tallas As System.Windows.Forms.ComboBox
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents tj As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents secciones As System.Windows.Forms.Label
    Friend WithEvents cortes As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prod_diaria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Estados = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Prendas = New System.Windows.Forms.TextBox()
        Me.Tallas = New System.Windows.Forms.ComboBox()
        Me.S1 = New System.Windows.Forms.Button()
        Me.tj = New System.Windows.Forms.ComboBox()
        Me.cortes = New System.Windows.Forms.ComboBox()
        Me.imprime = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.secciones = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 152)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(944, 496)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(883, 24)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 20
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos del  Corte")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.Black
        Me.E1.Image = CType(resources.GetObject("E1.Image"), System.Drawing.Image)
        Me.E1.Location = New System.Drawing.Point(896, 24)
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
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(856, 24)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(16, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fecha"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(320, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estado de Prenda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Estados
        '
        Me.Estados.BackColor = System.Drawing.Color.White
        Me.Estados.Items.AddRange(New Object() {"Primeras", "Tela Fabricacion", "Tela Manchas", "Tela Agujeros", "Tela Tonalidad", "Cuellos/Puños", "Incompleta", "Prod. Costura", "Prod. Agujeros", "Prod. Tonalidad", "Bordado", "Muestras", "Terceras"})
        Me.Estados.Location = New System.Drawing.Point(320, 48)
        Me.Estados.MaxLength = 20
        Me.Estados.Name = "Estados"
        Me.Estados.Size = New System.Drawing.Size(168, 24)
        Me.Estados.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Estados, "Tipo  (Primeras,  Segundas)")
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
        'FECHA
        '
        Me.FECHA.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.FECHA.CustomFormat = "dd/MM/yyyy"
        Me.FECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FECHA.Location = New System.Drawing.Point(16, 32)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(136, 26)
        Me.FECHA.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FECHA, "Fecha de la Produccion")
        '
        'Prendas
        '
        Me.Prendas.BackColor = System.Drawing.Color.White
        Me.Prendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prendas.Location = New System.Drawing.Point(656, 48)
        Me.Prendas.MaxLength = 5
        Me.Prendas.Name = "Prendas"
        Me.Prendas.Size = New System.Drawing.Size(136, 22)
        Me.Prendas.TabIndex = 5
        Me.Prendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Prendas, "Numero de Prendas")
        '
        'Tallas
        '
        Me.Tallas.BackColor = System.Drawing.Color.White
        Me.Tallas.Items.AddRange(New Object() {"XS", "S", "M", "L", "XL", "2XL", "3XL", "4XL", "5XL", "6XL"})
        Me.Tallas.Location = New System.Drawing.Point(504, 48)
        Me.Tallas.MaxLength = 20
        Me.Tallas.Name = "Tallas"
        Me.Tallas.Size = New System.Drawing.Size(136, 24)
        Me.Tallas.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Tallas, "Talla")
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(816, 24)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 49
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'tj
        '
        Me.tj.BackColor = System.Drawing.Color.White
        Me.tj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tj.Items.AddRange(New Object() {"XS", "S", "M", "L", "XL", "XL2", "XL3", "XL4", "XL5", "XL6"})
        Me.tj.Location = New System.Drawing.Point(723, 12)
        Me.tj.MaxLength = 20
        Me.tj.Name = "tj"
        Me.tj.Size = New System.Drawing.Size(136, 24)
        Me.tj.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.tj, "Talla")
        Me.tj.Visible = False
        '
        'cortes
        '
        Me.cortes.BackColor = System.Drawing.Color.White
        Me.cortes.Items.AddRange(New Object() {"Primeras", "Tela Fabricacion", "Tela Manchas", "Tela Agujeros", "Tela Tonalidad", "Cuellos/Puños", "Incompleta", "Prod. Costura", "Prod. Agujeros", "Prod. Tonalidad", "Bordado", "Muestras"})
        Me.cortes.Location = New System.Drawing.Point(8, 48)
        Me.cortes.MaxLength = 20
        Me.cortes.Name = "cortes"
        Me.cortes.Size = New System.Drawing.Size(104, 24)
        Me.cortes.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.cortes, "Tipo  (Primeras,  Segundas)")
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(195, 18)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(60, 40)
        Me.imprime.TabIndex = 50
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(504, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Talla"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(656, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Prendas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tallas)
        Me.GroupBox1.Controls.Add(Me.R1)
        Me.GroupBox1.Controls.Add(Me.E1)
        Me.GroupBox1.Controls.Add(Me.Prendas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Estados)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.secciones)
        Me.GroupBox1.Controls.Add(Me.cortes)
        Me.GroupBox1.Controls.Add(Me.S1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 88)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(128, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 24)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Sección"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'secciones
        '
        Me.secciones.BackColor = System.Drawing.Color.White
        Me.secciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.secciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secciones.ForeColor = System.Drawing.Color.Black
        Me.secciones.Location = New System.Drawing.Point(128, 48)
        Me.secciones.Name = "secciones"
        Me.secciones.Size = New System.Drawing.Size(176, 24)
        Me.secciones.TabIndex = 50
        Me.secciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Prod_diaria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.tj)
        Me.Controls.Add(Me.FECHA)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.G1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_diaria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produccion Diaria"
        Me.ToolTip1.SetToolTip(Me, "Captacion de la Produccion diaria")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Prod_diria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler FECHA.KeyPress, AddressOf keypressed1
        AddHandler cortes.KeyPress, AddressOf keypressed2
        AddHandler Estados.KeyPress, AddressOf keypressed3
        AddHandler Tallas.KeyPress, AddressOf keypressed4
        AddHandler Prendas.KeyPress, AddressOf keypressed5
        llena_combos(cortes, "SELECT CORTE FROM CORTES WHERE EXPORTADO <> 'S' AND  CORTE NOT IN(SELECT DISTINCT CORTE FROM PACKING_D)  AND CORTE NOT IN (SELECT DISTINCT CORTE FROM CAJAS01) ORDER BY CORTE ", "CORTE")
        '        llena_combos(cortes, "SELECT CORTE FROM CORTES ORDER BY CORTE ", "CORTE")
        t = Split(ta, "|")
        tr = Split(tf, "|")
        setea_grid()
        limpia_variables()
        FECHA.Focus()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 9
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "FECHA"
        fg.Cols(2).Name = "CORTE"
        fg.Cols(3).Name = "ESTADO"
        fg.Cols(4).Name = "TALLA"
        fg.Cols(5).Name = "PRENDAS"
        fg.Cols(6).Name = "SECCION"
        fg.Cols(7).Visible = False
        fg.Cols(8).Visible = False
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 160
            fg(0, index) = fg.Cols(index).Name
            If index = 5 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 105
                fg.Cols(index).TextAlign = TextAlignEnum.CenterCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.CenterCenter
            End If
        Next
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim escala As String
        Dim fechas As String = Format(CDate(FECHA.Text), "yyyy-MM-dd")
        Dim strSQL As String = "SELECT PROD_DIARIA.*, SECCION,ESCALA FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE FECHA = '" & fechas & "'"
        llena_tablas(dt, strSQL, cns)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            fg(lineas, 1) = dr("FECHA")
            fg(lineas, 2) = dr("CORTE")
            fg(lineas, 3) = dr("TIPO")
            fg(lineas, 4) = dr("TALLA")
            fg(lineas, 5) = dr("PRENDAS")
            fg(lineas, 6) = dr("SECCION")
            fg(lineas, 3) = Estados.Items(fg(lineas, 3))
            Try
                escala = dr("ESCALA")
            Catch ex As Exception
                escala = "00"
            End Try
            If escala = "00" Then
                fg(lineas, 4) = tr(Array.IndexOf(t, dr("TALLA")))
            End If
            Dim texto As String
            texto = Trim(fg(lineas, 2)) + Trim(fg(lineas, 3)) + Trim(fg(lineas, 4))
            fg(lineas, 0) = texto
            fg(lineas, 7) = Array.IndexOf(t, dr("TALLA"))
            fg(lineas, 8) = dr("TIPO")
            lineas = lineas + 1
        Next
        fg.Sort(SortFlags.Ascending, 7)
        fg.Sort(SortFlags.Ascending, 8)
        fg.Sort(SortFlags.Ascending, 2)
    End Sub

    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(FECHA.Text) <> "" Then
                busca_fecha()
            End If
        End If
    End Sub 'keypressed

    Private Sub busca_fecha()
        setea_grid()
        limpia_variables()
        cortes.Focus()
    End Sub
    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cortes.Text) <> "" Then
                Estados.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Estados.Text) <> "" Then
                Tallas.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Tallas.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim prenda As Integer
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Prendas.Text) <> "" Then
                Try
                    prenda = Prendas.Text
                    If prenda > 0 Then
                        G1.Focus()
                    End If
                Catch
                End Try
            End If
        End If
    End Sub 'keypressed

    ' =========================== PRE-CHEQUEO ==================================

    Private Sub chequea_registro(ByRef OK As Boolean)
        Dim dt As New DataTable()
        Dim seccion As String
        Dim escala As String = "00"
        Dim fechas As String = Format(CDate(FECHA.Text), "yyyy-MM-dd")
        OK = False
        Dim strSQL As String = "SELECT PROD_DIARIA.*, SECCION,ESCALA FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE FECHA = '" & fechas & "' AND PROD_DIARIA.CORTE = '" & cortes.Text & "' AND TIPO = '" & Estados.SelectedIndex & "' AND TALLA = '" & t(Tallas.SelectedIndex) + "'"
        llena_tablas(dt, strSQL, cns)
        For Each Me.dr In dt.Rows
            OK = True
            Prendas.Text = dr("PRENDAS")
            seccion = dr("SECCION")
            secciones.Text = seccion
            'Try
            '    escala = dr("ESCALA")
            'Catch ex As Exception
            'End Try
            'If escala = "00" Then
            '    Tallas.SelectedIndex = Array.IndexOf(t, dr("TALLA"))
            'End If
            Prendas.Enabled = False
            Tallas.Enabled = False
            G1.Visible = False
            E1.Visible = True
            S1.Visible = False
        Next
    End Sub

    Private Sub busca_corte()
        Dim escala As String
        co = New DataTable()
        Dim dr As DataRow
        llena_tablas(co, "SELECT CORTES.*,ESCALA FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CORTE = '" & cortes.Text & "'", cnn)
        escala = "00"
        If co.Rows.Count > 0 Then
            dr = co.Rows(0)
            secciones.Text = dr("SECCION")
            Try
                escala = dr("ESCALA")
                escalas = escala
            Catch ex As Exception
            End Try
            crea_combo_tallas(escala)
        End If
    End Sub

    Private Sub crea_combo_tallas(ByRef escala As String)
        Dim dr As DataRow
        Dim tt As String
        dr = get_tallas(escala)
        Tallas.Items.Clear()
        For i = 0 To 9
            tt = dr(i + 2)
            If Trim(tt) <> "" Then
                Tallas.Items.Add(tt)
            End If
        Next
        Tallas.SelectedIndex = 0
    End Sub

    Private Sub existe_orden(ByRef ok As Boolean)
        Dim dt As New DataTable()
        ok = False
        Dim t(9) As Integer
        Dim TA As String = Tallas.Text
        Dim seccion As String
        resuelve_tallas(TA)
        Dim strSQL As String = "SELECT * FROM CORTES WHERE CORTE = '" & cortes.Text & "'"
        llena_tablas(dt, strSQL, cns)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            talla = dr(Tallas.SelectedIndex + 6)
            seccion = dr("SECCION")
            ok = True
            If talla = 0 Then
                mensaje("No se cortaron Prendas en esa Talla !!!!")
                ok = False
            End If
        Else
            mensaje("Corte Inexistente !!!!!")
        End If
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        Dim ok As Boolean
        chequea_registro(ok)
        If ok Then
            R1.Focus()
            Exit Sub
        End If
        existe_orden(ok)
        If ok Then
            Prendas.Text = ""
            G1.Visible = True
            E1.Visible = False
            deshabilita()
            Prendas.Focus()
        Else
        End If
    End Sub

    Private Sub deshabilita()
        FECHA.Enabled = False
        cortes.Enabled = False
        Estados.Enabled = False
        Tallas.Enabled = False
        secciones.Enabled = False
        Prendas.Enabled = True
        S1.Visible = False
        G1.Visible = True
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim ok As Boolean = True
        If IsNumeric(Prendas.Text) = False Then
            ok = False
            Exit Sub
        End If
        Prendas.Text = Int(Prendas.Text)
        If Prendas.Text = 0 Then
            Exit Sub
        End If
        revisa_detalle(ok)
        If ok Then
            graba_datos()
            cambia_Talla()
            limpia_variables()
        End If
    End Sub

    Private Sub revisa_detalle(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim TA As String = "P" + CStr(Tallas.SelectedIndex)
        Dim TAP As Integer = 0
        Dim TAP1 As Integer = 0
        Dim strSQL As String = "SELECT * FROM CORTES_P WHERE CORTE = '" & cortes.Text & "'"
        llena_tablas(dt, strSQL, cns)
        For Each Me.dr In dt.Rows
            TAP = dr(TA)
            TA = "S" + CStr(Tallas.SelectedIndex)
            TAP1 = dr(TA)
        Next
        TAP = TAP + TAP1 + Prendas.Text
        If TAP > talla Then
            mensaje("Esta ingresando mas produccion que lo Cortado !!!!")
            ok = False
        End If
    End Sub

    Private Sub cambia_Talla()
        Try
            Tallas.SelectedIndex = Tallas.SelectedIndex + 1
        Catch
            Tallas.SelectedIndex = 0
        End Try
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        FECHA.Enabled = True
        cortes.Enabled = True
        Estados.Enabled = True
        Tallas.Enabled = True
        Prendas.Enabled = False
        Estados.SelectedIndex = 0
        Prendas.Text = ""
        S1.Visible = True
        G1.Visible = False
        E1.Visible = False
        Try
            If Tallas.SelectedIndex < 0 Then
                Tallas.SelectedIndex = 1
            End If
        Catch
        End Try

        Estados.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
        cortes.Focus()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox(var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub


    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        Dim ok As Boolean
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            chequea_exportacion(ok)
            If ok Then
                elimina_datos()
            Else
                MsgBox("Este registro no se puede eliminar !!!!!", MsgBoxStyle.Critical, "Corte ya exportado !!!!!")
            End If
        End If
        limpia_variables()
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        Dim ok As Boolean
        If fil > 0 And fil < fg.Rows.Count Then
            chequea_corte(ok)
            If ok Then
                cortes.Text = fg(fil, 2)
                busca_corte()
                Estados.SelectedIndex = Estados.Items.IndexOf(fg(fil, 3))
                Tallas.SelectedIndex = Tallas.Items.IndexOf(fg(fil, 4))
                secciones.Text = fg(fil, 6)
                Prendas.Text = fg(fil, 5)
                chequea_registro(ok)
                If ok Then
                    deshabilita()
                    Prendas.Enabled = False
                    G1.Visible = False
                    E1.Visible = True
                    S1.Visible = False
                End If
            Else
                Exit Sub
            End If
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
        Try
            Dim texto As String
            fg(lineas, 1) = FECHA.Text
            fg(lineas, 2) = cortes.Text
            fg(lineas, 3) = Estados.Text
            fg(lineas, 4) = Tallas.Text
            fg(lineas, 5) = Prendas.Text
            fg(lineas, 6) = secciones.Text
            texto = Trim(fg(lineas, 2)) + Trim(fg(lineas, 3)) + Trim(fg(lineas, 4))
            fg(lineas, 0) = texto
        Catch
        End Try
    End Sub

    Private Sub FECHA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FECHA.ValueChanged
        chequea_fecha()
        busca_fecha()
    End Sub

    Private Sub resuelve_tallas(ByRef tallasf As String)
        Dim TA As Integer = Tallas.SelectedIndex
        If TA > 4 Then
            tallasf = Trim(tallasf)
            tallasf = Mid(tallasf, 2) + Mid(tallasf, 1, 1)
        Else
            tallasf = Tallas.Text
        End If
    End Sub

    Private Sub fg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub chequea_exportacion(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim total As Integer
        Dim strsql As String = "SELECT SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9+S0+S1+S2+S3+S4+S5+S6+S7+S8+S9) AS EXPORT FROM CORTES_E WHERE CORTE = '" & cortes.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            ok = True
            Try
                total = dr("EXPORT")
                If total > 0 Then
                    ok = False
                End If
            Catch
            End Try
        End If
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim fechas As String = Format(CDate(FECHA.Text), "yyyy-MM-dd")
        Dim P(9) As Integer
        Dim S(9) As Integer
        Dim i As Integer = Tallas.SelectedIndex
        Dim UP As String
        Dim talla As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            If escalas = "00" Then
                talla = t(i)
            Else
                talla = Tallas.Text
            End If
            '==================== DIARIO =========================================
            strsql = "INSERT INTO PROD_DIARIA (CORTE,FECHA,TIPO,TALLA,PRENDAS) " & _
                     "VALUES ( '" & cortes.Text & "','" & _
                        fechas & "','" & _
                        Estados.SelectedIndex & "','" & _
                        talla & "','" & _
                        Prendas.Text & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '==================== ACUMULADO ======================================
            If Estados.SelectedIndex = 0 Then
                P(i) = Prendas.Text
                UP = "P" + CStr(i)
            Else
                S(i) = Prendas.Text
                UP = "S" + CStr(i)
            End If
            strsql = "UPDATE CORTES_P SET " & UP & " = " & UP & " + " & Prendas.Text & " WHERE CORTE = '" & cortes.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CORTES_P (CORTE,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9) " & _
                         "VALUES ( '" & cortes.Text & "','" & _
                             P(0) & "','" & _
                             P(1) & "','" & _
                             P(2) & "','" & _
                             P(3) & "','" & _
                             P(4) & "','" & _
                             P(5) & "','" & _
                             P(6) & "','" & _
                             P(7) & "','" & _
                             P(8) & "','" & _
                             P(9) & "','" & _
                             S(0) & "','" & _
                             S(1) & "','" & _
                             S(2) & "','" & _
                             S(3) & "','" & _
                             S(4) & "','" & _
                             S(5) & "','" & _
                             S(6) & "','" & _
                             S(7) & "','" & _
                             S(8) & "','" & _
                             S(9) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            '==================== SECCION =======================================
            strsql = "UPDATE CORTES SET FPROD = '" & fechas & "' WHERE CORTE = '" & cortes.Text & "'"
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
            cnn.Close()
        End Try
    End Sub



    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim talla As String
        Dim fechas As String = Format(CDate(FECHA.Text), "yyyy-MM-dd")
        Dim P(9) As Integer
        Dim S(9) As Integer
        Dim i As Integer = Tallas.SelectedIndex
        Dim UP As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            If escalas = "00" Then
                talla = t(I)
            Else
                talla = Tallas.Text
            End If


            '==================== DIARIO =========================================
            strsql = "DELETE PROD_DIARIA WHERE FECHA = '" & fechas & "' AND CORTE = '" & cortes.Text & "' AND TIPO = '" & Estados.SelectedIndex & "' AND TALLA = '" & talla & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            '==================== ACUMULADO ======================================
            If Estados.SelectedIndex = 0 Then
                UP = "P" + CStr(I)
            Else
                UP = "S" + CStr(I)
            End If
            strsql = "UPDATE CORTES_P SET " & UP & " = " & UP & " - " & Prendas.Text & " WHERE CORTE = '" & cortes.Text & "'"
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
            cnn.Close()
        End Try
    End Sub

    Private Sub Cortes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ok As Boolean
        chequea_corte(ok)
    End Sub

    Private Sub chequea_corte(ByRef ok As Boolean)
        Dim pb As New DataTable
        ok = False
        Dim strsql As String = "SELECT * FROM PACKING_D WHERE CORTE = '" & cortes.Text & "'"
        llena_tablas(pb, strsql, cnn)
        If pb.Rows.Count > 0 Then
            MsgBox("No puede efectuar ninguna operación con este Corte. Ya tiene lista de empaque !!!!!!", MsgBoxStyle.Critical, "POR FAVOR REVISE !!!!")
            cortes.Text = ""
        Else
            ok = True
        End If
    End Sub

    Private Sub chequea_fecha()
        Dim dia As Date = Today
        Dim dias As Integer = Today.DayOfWeek
        Dim min As Date = dia.AddDays(-3)
        If FECHA.Value < min Then
            FECHA.Value = min
        End If
        If FECHA.Value > Today Then
            FECHA.Value = Today
        End If
    End Sub

    Private Sub corteS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cortes.KeyPress
        AutoCompletar(cortes, e)
    End Sub

    Private Sub cortes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cortes.Leave
        busca_corte()
    End Sub

    Private Sub estados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estados.KeyPress
        AutoCompletar(Estados, e)
    End Sub

    Private Sub tallas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tallas.KeyPress
        AutoCompletar(Tallas, e)
    End Sub

    Private Sub print_fg()
        Dim pd As PrintDocument
        Dim fechar As String
        fechar = Format(FECHA.Value, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("prendas_prod", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Reporte de Prendas Producidas del día " & fechar + Chr(9) + Chr(9) + "Pagina {0}", Format(Now, "dd/MMM/yyyy   HH:mm:ss") + Chr(9) + Chr(9) + "Revisado por: ________________")
    End Sub

    Private Sub imprime_Click(sender As System.Object, e As System.EventArgs) Handles imprime.Click
        print_fg()
    End Sub
End Class
