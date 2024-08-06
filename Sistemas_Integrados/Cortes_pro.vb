Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Data.SqlClient

Public Class Cortes_pro
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow()
    Dim dd As DataRow
    Dim co(10) As Integer
    Dim estado As String
    Dim ds As New DataSet()
    Dim te(9) As String
    Dim ep(9) As String
    Dim es(9) As String
    Dim rp(9) As String
    Dim rs(9) As String
    Dim a(3, 10) As Integer
    Dim totalc As Integer
    Dim ep1 As String
    Dim es1 As String
    Dim rp1 As String
    Dim rs1 As String
    Dim proc As String
    Dim lugar As String
    Dim docto_envio As String
    Dim docto_rec As String
    Dim fecha_envio As String
    Dim fecha_rec As String
    Dim enviador As String
    Dim receptor As String
    Dim ceros As String = "0,0,0,0,0,0,0,0,0,0"
    Public t_opera As String
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Ex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents corte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents fpo As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents seccion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Fcorte As System.Windows.Forms.Label
    Friend WithEvents Fprod As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents proceso As System.Windows.Forms.ComboBox
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents prov As System.Windows.Forms.ComboBox
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents elimina As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Quien As System.Windows.Forms.TextBox
    Friend WithEvents docto As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_pro))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.corte = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.elimina = New System.Windows.Forms.Button()
        Me.Quien = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.fpo = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Fcorte = New System.Windows.Forms.Label()
        Me.Fprod = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.docto = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.prov = New System.Windows.Forms.ComboBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.proceso = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ex
        '
        Me.Ex.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Ex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Ex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Ex.BackColor = System.Drawing.Color.White
        Me.Ex.ColumnInfo = resources.GetString("Ex.ColumnInfo")
        Me.Ex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Ex.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.Ex.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.Ex.Location = New System.Drawing.Point(16, 376)
        Me.Ex.Name = "Ex"
        Me.Ex.Rows.DefaultSize = 17
        Me.Ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.Ex.Size = New System.Drawing.Size(936, 88)
        Me.Ex.StyleInfo = resources.GetString("Ex.StyleInfo")
        Me.Ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ex.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Ex, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(272, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(272, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.Location = New System.Drawing.Point(128, 16)
        Me.corte.MaxLength = 15
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(96, 26)
        Me.corte.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.corte, "No. Corte")
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(112, 128)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(104, 22)
        Me.fecha.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha del Proceso")
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(728, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 78
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" &
        " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(768, 16)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(35, 35)
        Me.GRABA.TabIndex = 79
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'elimina
        '
        Me.elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.elimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimina.ForeColor = System.Drawing.Color.Black
        Me.elimina.Image = CType(resources.GetObject("elimina.Image"), System.Drawing.Image)
        Me.elimina.Location = New System.Drawing.Point(768, 16)
        Me.elimina.Name = "elimina"
        Me.elimina.Size = New System.Drawing.Size(35, 35)
        Me.elimina.TabIndex = 80
        Me.elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.elimina, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.elimina.UseVisualStyleBackColor = False
        Me.elimina.Visible = False
        '
        'Quien
        '
        Me.Quien.BackColor = System.Drawing.Color.White
        Me.Quien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quien.Location = New System.Drawing.Point(112, 152)
        Me.Quien.MaxLength = 15
        Me.Quien.Name = "Quien"
        Me.Quien.Size = New System.Drawing.Size(400, 22)
        Me.Quien.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.Quien, "Persona quien envia o recibe.")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Corte"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cpo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Fpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Estilo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(504, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Color:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(504, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Sección:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.ForeColor = System.Drawing.Color.Black
        Me.cpo.Location = New System.Drawing.Point(112, 16)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(200, 24)
        Me.cpo.TabIndex = 64
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpo
        '
        Me.fpo.BackColor = System.Drawing.Color.White
        Me.fpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fpo.ForeColor = System.Drawing.Color.Black
        Me.fpo.Location = New System.Drawing.Point(112, 40)
        Me.fpo.Name = "fpo"
        Me.fpo.Size = New System.Drawing.Size(200, 24)
        Me.fpo.TabIndex = 65
        Me.fpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Location = New System.Drawing.Point(112, 64)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(200, 24)
        Me.cliente.TabIndex = 66
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(112, 88)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(200, 24)
        Me.estilo.TabIndex = 67
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(592, 16)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(312, 24)
        Me.colores.TabIndex = 68
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.White
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccion.ForeColor = System.Drawing.Color.Black
        Me.seccion.Location = New System.Drawing.Point(592, 40)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(312, 24)
        Me.seccion.TabIndex = 69
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Fcorte)
        Me.GroupBox1.Controls.Add(Me.Fprod)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cliente)
        Me.GroupBox1.Controls.Add(Me.fpo)
        Me.GroupBox1.Controls.Add(Me.colores)
        Me.GroupBox1.Controls.Add(Me.seccion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.estilo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cpo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 120)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'Fcorte
        '
        Me.Fcorte.BackColor = System.Drawing.Color.White
        Me.Fcorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fcorte.ForeColor = System.Drawing.Color.Black
        Me.Fcorte.Location = New System.Drawing.Point(592, 64)
        Me.Fcorte.Name = "Fcorte"
        Me.Fcorte.Size = New System.Drawing.Size(144, 24)
        Me.Fcorte.TabIndex = 72
        Me.Fcorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fprod
        '
        Me.Fprod.BackColor = System.Drawing.Color.White
        Me.Fprod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fprod.ForeColor = System.Drawing.Color.Black
        Me.Fprod.Location = New System.Drawing.Point(592, 88)
        Me.Fprod.Name = "Fprod"
        Me.Fprod.Size = New System.Drawing.Size(144, 24)
        Me.Fprod.TabIndex = 73
        Me.Fprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(504, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "F.Corte:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(504, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "F.Prod:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Proceso:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Tipo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Proveedor:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Documento:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.docto)
        Me.GroupBox2.Controls.Add(Me.Quien)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.prov)
        Me.GroupBox2.Controls.Add(Me.tipo)
        Me.GroupBox2.Controls.Add(Me.proceso)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.fecha)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CANCELA)
        Me.GroupBox2.Controls.Add(Me.elimina)
        Me.GroupBox2.Controls.Add(Me.GRABA)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 192)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        '
        'docto
        '
        Me.docto.BackColor = System.Drawing.Color.White
        Me.docto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.docto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.docto.ForeColor = System.Drawing.Color.Black
        Me.docto.Location = New System.Drawing.Point(112, 64)
        Me.docto.Name = "docto"
        Me.docto.Size = New System.Drawing.Size(164, 24)
        Me.docto.TabIndex = 83
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 24)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Recibe:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prov
        '
        Me.prov.BackColor = System.Drawing.Color.White
        Me.prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prov.ForeColor = System.Drawing.Color.Black
        Me.prov.Location = New System.Drawing.Point(112, 104)
        Me.prov.Name = "prov"
        Me.prov.Size = New System.Drawing.Size(272, 24)
        Me.prov.TabIndex = 12
        '
        'tipo
        '
        Me.tipo.BackColor = System.Drawing.Color.White
        Me.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.ForeColor = System.Drawing.Color.Black
        Me.tipo.Items.AddRange(New Object() {"Envio", "Recepcion"})
        Me.tipo.Location = New System.Drawing.Point(112, 40)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(164, 24)
        Me.tipo.TabIndex = 11
        '
        'proceso
        '
        Me.proceso.BackColor = System.Drawing.Color.White
        Me.proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceso.ForeColor = System.Drawing.Color.Black
        Me.proceso.Location = New System.Drawing.Point(112, 16)
        Me.proceso.Name = "proceso"
        Me.proceso.Size = New System.Drawing.Size(164, 24)
        Me.proceso.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Fecha:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cortes_pro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1194, 970)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.R1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_pro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de procesos Adiconales"
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Cortes_pro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler corte.KeyPress, AddressOf keypressed1
        AddHandler proceso.KeyPress, AddressOf keypressed2
        AddHandler tipo.KeyPress, AddressOf keypressed3
        AddHandler docto.KeyPress, AddressOf keypressed4
        AddHandler prov.KeyPress, AddressOf keypressed5
        AddHandler fecha.KeyPress, AddressOf keypressed6
        AddHandler Quien.KeyPress, AddressOf keypressed7
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        def_sql(cnn)
        llena_combos(prov, "SELECT PROV_SERV FROM PROV_SERV ORDER BY PROV_SERV", "PROV_SERV")
        setea_EX()
        limpia_variables()
        cpo.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        If corte.Text <> "" Then
            procesa_cortes()
        End If
    End Sub

    Private Sub procesa_cortes()
        ok = True
        busca_corte(ok)
        If Not ok Then
            limpia_variables()
            Exit Sub
        End If
        S1.Visible = False
        R1.Visible = True
        CANCELA.Visible = True
        llena_procesos()
        If proceso.Items.Count > 0 Then
            deshabilita()
        Else
            MsgBox("El estilo aun no tiene definidos Procesos Adicionales en la Ruta de Procesos", MsgBoxStyle.Critical, "Por favor Revise !!!")
            limpia_variables()
        End If
    End Sub

    Private Sub busca_doctos()
        Dim i As Integer = 0
        Dim j As Integer
        Dim tip As String
        Dim dr As DataRow
        ReDim a(3, 10)
        docto.Items.Clear()
        docto.Items.Add("NUEVO")
        llena_tablas(dt, "SELECT * FROM CORTES_PAR WHERE CORTE = '" & corte.Text & "' AND PROCESO = '" & proceso.Text & "' ORDER BY DOCTO", cnn)
        For Each dr In dt.Rows
            tip = dr("TIPO")
            For i = 0 To 9
                If tip = "Envio" Then
                    j = 0
                Else
                    j = 2
                End If
                a(j, i) = a(j, i) + dr(i + 8)
                a(j, 10) = a(j, 10) + dr(i + 8)
                a(j + 1, i) = a(j + 1, i) + dr(i + 18)
                a(j + 1, 10) = a(j + 1, 10) + dr(i + 18)
            Next
            If dr("TIPO") = tipo.Text Then
                docto.Items.Add(dr("DOCTO"))
            End If
        Next
        docto.SelectedIndex = 0
    End Sub

    Private Sub deshabilita()
        Quien.Text = ""
        setea_EX()
        corte.ReadOnly = True
        docto.Enabled = False
        proceso.Enabled = True
        tipo.Enabled = False
        prov.Enabled = False
        fecha.Enabled = False
        Quien.Enabled = False
        Ex.Enabled = False
        GRABA.Visible = False
        elimina.Visible = False
        proceso.Focus()
    End Sub

    Private Sub busca_corte(ByRef ok As Boolean)
        Dim i As Integer
        Dim dato As String
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CORTES WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            ok = True
            dr = dt.Rows(0)
            cpo.Text = dr("CPO")
            estilo.Text = dr("ESTILO")
            colores.Text = dr("COLOR")
            fpo.Text = dr("FPO")
            cliente.Text = dr("CLIENTE")
            totalc = dr("TOTAL")
            Fcorte.Text = Format(CDate(dr("FCORTE")), "dd/MMM/yyyy")
            Fprod.Text = Format(CDate(dr("FPROD")), "dd/MMM/yyyy")
            seccion.Text = dr("SECCION")
            For i = 0 To 9
                dato = te(i)
                co(i) = CInt(dr(dato))
            Next
            If dr("EXPORTADO") = "S" Then
                MsgBox("Este corte ya fue exportado !!!!!!", MsgBoxStyle.Critical, "Corte ya Exportado")
                ok = False
            End If
        Else
            MsgBox("CORTE no Existe !!!!", MsgBoxStyle.Critical, "Por favor Verifique !!!")
            ok = False
        End If
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            proceso.Enabled = False
            tipo.Enabled = True
            tipo.SelectedIndex = 0
            tipo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            busca_doctos()
            tipo.Enabled = False
            docto.Enabled = True
            docto.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If docto.SelectedIndex > 0 Then
                busca_documentos()
            Else
                habilita_detalle()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(docto.Text) <> "" Then
                fecha.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                Quien.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Quien.Text) <> "" Then
                Ex.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub habilita_detalle()
        docto.Enabled = False
        prov.Enabled = True
        fecha.Enabled = True
        Quien.Enabled = True
        Ex.Enabled = True
        GRABA.Visible = True
        Try
            prov.SelectedIndex = 0
        Catch
        End Try
        prov.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        corte.ReadOnly = False
        corte.Text = ""
        cpo.Text = ""
        fpo.Text = ""
        cliente.Text = ""
        estilo.Text = ""
        colores.Text = ""
        seccion.Text = ""
        Fcorte.Text = ""
        Fprod.Text = ""
        S1.Visible = True
        R1.Visible = False
        corte_invisible()
        docto.Text = ""
        Quien.Text = ""
        setea_EX()
        proceso.Enabled = False
        tipo.Enabled = False
        fecha.Enabled = False
        docto.Enabled = False
        Quien.Enabled = False
        prov.Enabled = False
        corte.Focus()
    End Sub

    '=============================================== PROCESOS  ================================================
    Private Sub setea_EX()
        Dim index As Integer
        Ex.Clear()
        Ex.Rows.Count = 3
        Ex.Cols.Count = 13
        Ex.Cols(0).Width = 5
        Ex.Rows(0).Height = 30
        Ex.Cols(1).Name = "TIPO"
        Ex.Cols(2).Name = "XS"
        Ex.Cols(3).Name = "S"
        Ex.Cols(4).Name = "M"
        Ex.Cols(5).Name = "L"
        Ex.Cols(6).Name = "XL"
        Ex.Cols(7).Name = "2XL"
        Ex.Cols(8).Name = "3XL"
        Ex.Cols(9).Name = "4XL"
        Ex.Cols(10).Name = "5XL"
        Ex.Cols(11).Name = "6XL"
        Ex.Cols(12).Name = "TOT."
        For index = 1 To Ex.Cols.Count - 1
            Ex.Cols(index).Width = 120
            Ex(0, index) = Ex.Cols(index).Name
            Ex.Cols(index).AllowEditing = False
            If index > 1 Then
                Ex.Cols(index).DataType = GetType(Integer)
                Ex.Cols(index).Format = "######0"
                Ex.Cols(index).Width = 70
                Ex.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Ex.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                If index < 12 Then
                    Ex.Cols(index).AllowEditing = True
                End If
            End If
        Next
        Ex(1, 1) = "PRIMERAS"
        Ex(2, 1) = "SEGUNDAS"
    End Sub

    Private Sub llena_ex()
        Dim i As Integer
        setea_EX()
        For i = 0 To 9
            Ex(1, i + 2) = dd(i + 8)
            Ex(2, i + 2) = dd(i + 18)
            Ex(1, 12) = Ex(1, 12) + dd(i + 8)
            Ex(2, 12) = Ex(2, 12) + dd(i + 18)
        Next
        subtotales()
    End Sub

    Private Sub corte_invisible()
        CANCELA.Visible = False
        GRABA.Visible = False
        elimina.Visible = False
    End Sub

    Private Sub corte_habilita()
        proceso.Enabled = True
        tipo.Enabled = True
        docto.Text = ""
        Quien.Text = ""
        prov.Enabled = False
        docto.Enabled = False
        fecha.Enabled = False
        Quien.Enabled = False
        GRABA.Visible = False
        elimina.Visible = False
        setea_EX()
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        For i = 2 To 12
            Ex.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
        Next
        Try
            Ex.Rows(3).AllowEditing = False
        Catch
        End Try
    End Sub

    Private Sub revisa_variables(ByRef ok As Boolean)
        ok = True
        If proceso.Text = "" Or tipo.Text = "" Or prov.Text = "" Or docto.Text = "" Or fecha.Text = "" Then
            MsgBox("Error en los Datos", MsgBoxStyle.Critical, "por favor revise !!!")
            ok = False
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        deshabilita()
        proceso.Focus()
    End Sub

    Private Sub ex_crea_total(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles Ex.AfterRowColChange
        Dim i As Integer
        Dim j As Integer
        Try
            Ex(1, 12) = 0
            Ex(2, 12) = 0
            For i = 1 To 2
                For j = 2 To 11
                    Ex(i, 12) = Ex(i, 12) + Ex(i, j)
                Next
            Next
            subtotales()
        Catch
        End Try
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        Dim suma As Integer = a(0, 10) + a(1, 10)
        ok = True
        If Trim(Quien.Text) = "" Then
            mensaje("Aun no ha ingresado quien Envia/Recibe.")
            ok = False
        End If
        If tipo.SelectedIndex > 0 And suma = 0 Then
            MsgBox("No puede hacer ingresos, todavia no ha enviado nada.", MsgBoxStyle.Critical, "Ingrese los envios Primero")
            tipo.Focus()
            ok = False
        End If
        If ok Then
            revisa_antes_grabar(ok)
        End If
        If ok Then
            graba_registro()
            deshabilita()
        End If
    End Sub

    Private Sub mensaje(ByVal mensaje As String)
        MsgBox(mensaje, MsgBoxStyle.Critical, "Por favor revise antes de grabar.")
    End Sub

    Private Sub revisa_antes_grabar(ByRef ok As Boolean)
        Dim i As Integer
        Dim total = Ex(1, 12) + Ex(2, 12)
        Dim suma As Integer
        subtotales()

        For i = 2 To 11
            If tipo.SelectedIndex = 0 Then
                suma = a(0, i - 2) + a(1, i - 2)
            Else
                suma = a(2, i - 2) + a(3, i - 2)
            End If
            Ex.Cols(i).Style = Ex.Styles("bueno")
            If (Ex(3, i) + suma) > co(i - 2) Then
                Ex.Cols(i).Style = Ex.Styles("rojo")
                mensaje("En esta talla solamente se cortaron " + CStr(co(i - 2)) + " prendas.  Sumando estas acumularia " + CStr(suma + Ex(3, i)))
                ok = False
                Exit Sub
            End If
        Next
        If total = 0 Then
            mensaje("Aun no ha ingresado el número de prendas procesadas")
            ok = False
        End If
    End Sub


    Private Sub elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elimina.Click
        Dim i As Integer
        Dim total As Integer = 0
        Dim dig As Integer
        If tipo.SelectedIndex = 0 Then
            For i = 0 To 9
                dig = a(0, i)
                dig = a(1, i)
                dig = a(2, i)
                dig = Ex(1, i + 2)
                dig = Ex(2, i + 2)
                total = total + (a(0, i) + a(1, i)) - (a(2, i) + a(3, i)) - (Ex(1, i + 2) + Ex(2, i + 2))
            Next
            If total < 0 Then
                MsgBox("No puede Eliminar este envio, ya posee recepción. Para eliminarlo primero elimine la recepción.", MsgBoxStyle.Critical, "Por favor Revise !!!")
                Exit Sub
            End If
        End If
        elimina_registro()
        deshabilita()
    End Sub

    Private Sub llena_procesos()
        Dim i As Integer
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim vl(8) As String
        Dim va As String = "148"
        vl = Split("Nada,Corte,Bordado,Serigrafia,Costura,Sublima/Teñido,Lavado,Empaque,Exportación", ","c)
        Dim str As String = "SELECT * FROM ESTILOS WHERE ESTILO = '" & estilo.Text & "' AND CLIENTE = '" & cliente.Text & "'"
        proceso.Items.Clear()
        llena_tablas(dt, str, cnn)
        For Each dr In dt.Rows
            For i = 1 To 7
                If va.IndexOf(CStr(i)) = -1 Then
                    If dr("O" + CStr(i)) = True Then
                        proceso.Items.Add(vl(i))
                    End If
                End If
            Next
        Next
        If proceso.Items.Count > 0 Then
            proceso.SelectedIndex = 0
        End If
    End Sub

    Private Sub docto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles docto.SelectedIndexChanged
        If docto.SelectedIndex > 0 Then
            busca_documentos()
        End If
    End Sub

    Private Sub busca_documentos()
        Dim dr As DataRow
        Dim dt As New DataTable
        llena_tablas(dt, "SELECT * FROM CORTES_PAR WHERE CORTE = '" & corte.Text & "' AND PROCESO = '" & proceso.Text & "' AND DOCTO = '" & docto.Text & "' AND TIPO = '" & tipo.Text & "'", cnn)
        deshabilita()
        docto.Enabled = False
        tipo.Enabled = False
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            prov.SelectedIndex = prov.Items.IndexOf(dr("LUGAR"))
            fecha.Text = dr("FECHA")
            Quien.Text = dr("RECIBIO")
            dd = dr
        End If
        llena_ex()
        proceso.Enabled = False
        Ex.Enabled = False
        elimina.Visible = True
    End Sub


    ' =================================================================================
    ' =                     RUTINA DE GRABACION
    ' =
    ' =================================================================================
    Private Sub graba_registro()
        Dim i As Integer
        Dim afectados As Integer
        Dim graba As New SqlCommand()
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim strSql As String
        Dim corre As String
        Dim tpp As String
        Dim tps As String
        Dim pr As String = ""
        Dim sg As String = ""
        Dim tpd As String
        Dim tota As Integer = 0
        Dim l1 As String = ""
        Dim l2 As String = ""
        Dim l3 As String = ""
        Dim l4 As String = ""
        Dim dr As DataRow
        Dim docu As String = ""
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            If tipo.SelectedIndex = 0 Then
                corre = "PROC_ENV"
            Else
                corre = "PROC_REC"
            End If

            llena_tablas(dt, "SELECT * FROM CORRELATIVO", cnn)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                docu = CInt(dr(corre)) + 1
            End If
            strSql = "UPDATE CORRELATIVO SET " & corre & " = " & corre & " + 1"
            comando.CommandText = strSql
            afectados = comando.ExecuteNonQuery()

            If afectados = 1 Then
                If tipo.SelectedIndex = 0 Then
                    tpp = "EP"
                    tps = "ES"
                    tpd = "TOTAL_ENV"
                Else
                    tpp = "RP"
                    tps = "RS"
                    tpd = "TOTAL_REC"
                End If

                For i = 0 To 9
                    pr = pr & tpp & CStr(i) & "= " & tpp & CStr(i) & " + " & CInt(ex(1, i + 2)) & ","
                    sg = sg & tps & CStr(i) & "= " & tps & CStr(i) & " + " & CInt(ex(2, i + 2)) & ","
                    tota = tota + ex(1, i + 2) + ex(2, i + 2)
                    l1 = l1 & "EP" & CStr(i) & ","
                    l2 = l2 & "ES" & CStr(i) & ","
                    l3 = l3 & "RP" & CStr(i) & ","
                    l4 = l4 & "RS" & CStr(i) & ","
                Next

                strSql = "UPDATE CORTES_PA SET " & pr & sg & tpd & " = " & tpd & " + " & tota & " WHERE CORTE = '" & corte.Text & "' AND PROCESO = '" & proceso.Text & "'"
                comando.CommandText = strSql
                afectados = comando.ExecuteNonQuery()
                pr = ""
                sg = ""
                If afectados = 0 Then
                    For i = 0 To 9
                        pr = pr & CInt(ex(1, i + 2)) & ","
                        sg = sg & CInt(ex(2, i + 2)) & ","
                    Next
                    sg = sg + "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
                    l4 = Mid(l4, 1, Len(l4) - 1)
                    strSql = "INSERT INTO CORTES_PA (CORTE,PROCESO,CPO,TOTAL_ENV,TOTAL_REC," & l1 & l2 & l3 & l4 & ") " & _
                                                    "VALUES ( '" & corte.Text & "','" & _
                                                                   proceso.Text & "','" & _
                                                                   cpo.Text & "','" & _
                                                                   tota & "','0'," & _
                                                                   pr & sg & ")"
                    comando.CommandText = strSql
                    afectados = comando.ExecuteNonQuery()
                End If
                l1 = ""
                l2 = ""
                pr = ""
                sg = ""
                For i = 0 To 9
                    l1 = l1 + "P" + CStr(i) + ","
                    l2 = l2 + "S" + CStr(i) + ","
                    pr = pr & CInt(ex(1, i + 2)) & ","
                    sg = sg & CInt(ex(2, i + 2)) & ","
                Next
                l2 = Mid(l2, 1, Len(l2) - 1)
                sg = Mid(sg, 1, Len(sg) - 1)
                strSql = "INSERT INTO CORTES_PAR (CORTE,PROCESO,TIPO,DOCTO,CPO,FECHA,LUGAR,RECIBIO," & l1 & l2 & ") " & _
                                                "VALUES ( '" & corte.Text & "','" & _
                                                               proceso.Text & "','" & _
                                                               tipo.Text & "','" & _
                                                               docu & "','" & _
                                                               cpo.Text & "','" & _
                                                               fechas & "','" & _
                                                               prov.Text & "','" & _
                                                               Quien.Text & "'," & _
                                                               pr & sg & ")"
                comando.CommandText = strSql
                afectados = comando.ExecuteNonQuery()
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
            cnn.Close()
        End Try
    End Sub

    ' =================================================================================
    ' =                     RUTINA DE ELIMINACION
    ' =
    ' =================================================================================
    Private Sub elimina_registro()
        Dim i As Integer
        Dim afectados As Integer
        Dim graba As New SqlCommand()
        Dim strSql As String
        Dim pr As String = ""
        Dim sg As String = ""
        Dim tpp As String
        Dim tps As String
        Dim tpd As String
        Dim tota As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            If tipo.SelectedIndex = 0 Then
                tpp = "EP"
                tps = "ES"
                tpd = "TOTAL_ENV"
            Else
                tpp = "RP"
                tps = "RS"
                tpd = "TOTAL_REC"
            End If

            For i = 0 To 9
                pr = pr & tpp & CStr(i) & "= " & tpp & CStr(i) & " - " & CInt(ex(1, i + 2)) & ","
                sg = sg & tps & CStr(i) & "= " & tps & CStr(i) & " - " & CInt(ex(2, i + 2)) & ","
                tota = tota + ex(1, i + 2) + ex(2, i + 2)
            Next

            strSql = "UPDATE CORTES_PA SET " & pr & sg & tpd & " = " & tpd & " - " & tota & " WHERE CORTE = '" & corte.Text & "' AND PROCESO = '" & proceso.Text & "'"
            comando.CommandText = strSql
            afectados = comando.ExecuteNonQuery()

            If afectados > 0 Then
                strSql = "DELETE CORTES_PAR WHERE CORTE = '" & corte.Text & "' AND PROCESO = '" & proceso.Text & "' AND TIPO = '" & tipo.Text & "' AND DOCTO = '" & docto.Text & "'"
                comando.CommandText = strSql
                afectados = comando.ExecuteNonQuery()
            End If

            If afectados > 0 Then
                transaccion.Commit()
            End If

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



