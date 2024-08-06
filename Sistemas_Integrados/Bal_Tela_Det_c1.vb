Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Public Class Bal_Tela_Det_c1
    Inherits System.Windows.Forms.Form
    Public codigo As String
    Public descripcion As String
    Public colores As String
    Public necesario As Decimal
    Public inventar As Decimal
    Public pedido As Decimal
    Public reserva As Decimal
    Public balance As Decimal
    Public cliente As String
    Public con As DataTable
    Dim h As String = "######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim estados As New ComboBox()
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents res As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Public tsd As New DataTable()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents inv As System.Windows.Forms.Label
    Friend WithEvents consu As System.Windows.Forms.Label
    Friend WithEvents ped As System.Windows.Forms.Label
    Friend WithEvents bal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colors As System.Windows.Forms.Label
    Friend WithEvents desc_tela As System.Windows.Forms.Label
    Friend WithEvents Codi As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bal_Tela_Det_c1))
        Me.Ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.inv = New System.Windows.Forms.Label()
        Me.consu = New System.Windows.Forms.Label()
        Me.ped = New System.Windows.Forms.Label()
        Me.bal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.res = New System.Windows.Forms.Label()
        Me.desc_tela = New System.Windows.Forms.Label()
        Me.colors = New System.Windows.Forms.Label()
        Me.Codi = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ta
        '
        Me.Ta.AllowEditing = False
        Me.Ta.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Ta.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Ta.ColumnInfo = resources.GetString("Ta.ColumnInfo")
        Me.Ta.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Ta.ForeColor = System.Drawing.Color.Black
        Me.Ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Ta.Location = New System.Drawing.Point(8, 272)
        Me.Ta.Name = "Ta"
        Me.Ta.Rows.DefaultSize = 19
        Me.Ta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ta.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Ta.Size = New System.Drawing.Size(1288, 280)
        Me.Ta.StyleInfo = resources.GetString("Ta.StyleInfo")
        Me.Ta.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ta.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Ta, "Celdas resaltadas indican que la Tela del inventario está asignada a CPO's  no Ac" &
        "tivos.")
        '
        'Co
        '
        Me.Co.AllowEditing = False
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Co.ColumnInfo = resources.GetString("Co.ColumnInfo")
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(8, 592)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1288, 188)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.Co, "Celdas resaltadas indican que la Tela fue pedida para CPO's no Acitvas.")
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Pe.ColumnInfo = resources.GetString("Pe.ColumnInfo")
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Pe.Location = New System.Drawing.Point(8, 88)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 19
        Me.Pe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1034, 160)
        Me.Pe.StyleInfo = resources.GetString("Pe.StyleInfo")
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Prendas por Cortar.  Solamente refleja  unidades que  aún no hayan iniciado el pr" &
        "oceso de  Corte.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Tela en Inventario"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Tela Pedida"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Tela:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Prendas por Cortar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Color:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Inventario:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 22)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Consumo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(8, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 22)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Pedidos:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(8, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 24)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Balance:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inv
        '
        Me.inv.BackColor = System.Drawing.Color.White
        Me.inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv.ForeColor = System.Drawing.Color.Black
        Me.inv.Location = New System.Drawing.Point(136, 24)
        Me.inv.Name = "inv"
        Me.inv.Size = New System.Drawing.Size(96, 22)
        Me.inv.TabIndex = 65
        Me.inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'consu
        '
        Me.consu.BackColor = System.Drawing.Color.White
        Me.consu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consu.ForeColor = System.Drawing.Color.Black
        Me.consu.Location = New System.Drawing.Point(136, 48)
        Me.consu.Name = "consu"
        Me.consu.Size = New System.Drawing.Size(96, 22)
        Me.consu.TabIndex = 66
        Me.consu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ped
        '
        Me.ped.BackColor = System.Drawing.Color.White
        Me.ped.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ped.ForeColor = System.Drawing.Color.Black
        Me.ped.Location = New System.Drawing.Point(136, 72)
        Me.ped.Name = "ped"
        Me.ped.Size = New System.Drawing.Size(96, 22)
        Me.ped.TabIndex = 67
        Me.ped.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bal
        '
        Me.bal.BackColor = System.Drawing.Color.White
        Me.bal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bal.ForeColor = System.Drawing.Color.Black
        Me.bal.Location = New System.Drawing.Point(136, 134)
        Me.bal.Name = "bal"
        Me.bal.Size = New System.Drawing.Size(96, 24)
        Me.bal.TabIndex = 68
        Me.bal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.res)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.inv)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.consu)
        Me.GroupBox1.Controls.Add(Me.ped)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.bal)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1048, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 172)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen Tela:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(8, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 22)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Reserva:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'res
        '
        Me.res.BackColor = System.Drawing.Color.White
        Me.res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res.ForeColor = System.Drawing.Color.Black
        Me.res.Location = New System.Drawing.Point(136, 96)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(96, 22)
        Me.res.TabIndex = 70
        Me.res.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'desc_tela
        '
        Me.desc_tela.BackColor = System.Drawing.Color.White
        Me.desc_tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desc_tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_tela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.desc_tela.Location = New System.Drawing.Point(176, 8)
        Me.desc_tela.Name = "desc_tela"
        Me.desc_tela.Size = New System.Drawing.Size(648, 24)
        Me.desc_tela.TabIndex = 70
        Me.desc_tela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colors
        '
        Me.colors.BackColor = System.Drawing.Color.White
        Me.colors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colors.Location = New System.Drawing.Point(72, 32)
        Me.colors.Name = "colors"
        Me.colors.Size = New System.Drawing.Size(752, 24)
        Me.colors.TabIndex = 71
        Me.colors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Codi
        '
        Me.Codi.BackColor = System.Drawing.Color.White
        Me.Codi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Codi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Codi.Location = New System.Drawing.Point(72, 8)
        Me.Codi.Name = "Codi"
        Me.Codi.Size = New System.Drawing.Size(96, 24)
        Me.Codi.TabIndex = 72
        Me.Codi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1261, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 73
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Bal_Tela_Det_c1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 792)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Codi)
        Me.Controls.Add(Me.colors)
        Me.Controls.Add(Me.desc_tela)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Pe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_Tela_Det_c1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bal_Tela_Det_c1 + Balance de Tela"
        CType(Me.Ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Estado_Tela(cnn, estados)
        Codi.Text = codigo
        desc_tela.Text = descripcion
        colors.Text = colores
        setea_pe()
        llena_pe()
        setea_ta()
        llena_ta()
        setea_co()
        llena_co()
        resumen()
        Cursor = Cursors.Default
    End Sub
    Private Sub resumen()
        inv.Text = Format(inventar, h$)
        consu.Text = Format(necesario, h$)
        ped.Text = Format(pedido, h$)
        res.Text = Format(reserva, h$)
        bal.Text = Format(balance, h$)
    End Sub
    Private Sub setea_pe()
        Pe.Rows.Count = 1
        Pe.Rows(0).Height = 30
    End Sub
    Private Sub llena_pe()
        Dim dt As New DataTable()
        Dim wp As New DataTable()
        Dim unidades As Integer
        Dim pedido As Integer
        Dim cortadas As Integer
        Dim cinco As Decimal
        Dim dd As DataRow()
        Dim dw As DataRow
        Dim fec As Date
        Dim strSQL As String = "SELECT CONSUMO_TELA.*,CPO,CPO_D.ESTILO,CPO_D.COLOR,TOTAL,(SELECT SUM(TOTAL) FROM CORTES_S WHERE CPO = CPO_D.CPO AND ESTILO = CPO_D.ESTILO AND COLOR = CPO_D.COLOR ) AS CORTADAS, CPO_D.F_ENTREGA FROM CONSUMO_TELA LEFT JOIN CPO_D ON ESTILO_CPO = CPO_D.ESTILO AND COLOR_CPO = COLOR WHERE ESTILO_CPO + COLOR_CPO IN(SELECT CPO_D.ESTILO + COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & cliente & "' AND ESTADO = 'A') AND CPO_D.ESTADO = 'A' AND CODIGO = '" & Codi.Text & "' AND COLOR_TELA = '" & colors.Text & "'"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        strSQL = "SELECT * FROM WIP0 WHERE ESTILO + COLOR IN (SELECT ESTILO_CPO + COLOR_CPO FROM CONSUMO_TELA WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colors.Text & "')"
        llena_tablas(wp, strSQL, cnn)
        For Each dr In dt.Rows
            pedido = dr("TOTAL")
            cinco = pedido * 0.05
            Try
                cortadas = dr("CORTADAS")
            Catch ex As Exception
                cortadas = 0
            End Try
            unidades = pedido - cortadas
            If unidades > cinco Then
                lineas = Pe.Rows.Count
                Pe.Rows.Count = lineas + 1
                Pe(lineas, 1) = Trim(dr("CPO"))
                Pe(lineas, 2) = dr("ESTILO")
                Pe(lineas, 3) = dr("COLOR")
                Pe(lineas, 4) = dr("LIBRAS")
                Pe(lineas, 5) = unidades
                Pe(lineas, 6) = unidades * Pe(lineas, 4)
                dd = wp.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
                If dd.Length > 0 Then
                    dw = dd(0)
                    fec = dw("EXP_REV")
                    If Year(fec) = "1900" Then
                        Pe(lineas, 7) = dr("F_ENTREGA")
                    Else
                        Pe(lineas, 7) = fec
                    End If
                Else
                    Pe(lineas, 7) = dr("F_ENTREGA")
                End If
                lineas = lineas + 1
            End If
        Next
    End Sub
    '=============================================== Inventario ================================================
    Private Sub setea_ta()
        Ta.Rows.Count = 1
        Ta.Rows(0).Height = 30
        Ta.Cols(1).AllowMerging = True
    End Sub
    Private Sub llena_ta()
        Dim dt As New DataTable()
        Dim libras As Decimal
        Dim strSQL As String = " SELECT ROLLOS.BATCH,ROLLOS.ROLLO,FPO,CPO,CLIENTE,ROLLOS.YARDAS,((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS, ACTIVO, (select REQ_D.CORTE FROM REQ_D WHERE ROLLOS.BATCH = REQ_D.BATCH AND ROLLOS.ROLLO = REQ_D.ROLLO AND DESPACHADO = 'N' AND not exists (select 1 from DMOVTO WHERE DMOVTO.CORTE = REQ_D.CORTE AND DMOVTO.BATCH = REQ_D.BATCH AND DMOVTO.ROLLO = REQ_D.ROLLO)) CORTE FROM ROLLOS WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND ACTIVO IN ('S','0','5','6','9') AND ROLLOS.YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & cliente & "'"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        Ta.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            libras = dr("LIBRAS")
            If libras > 0 Then
                Ta(lineas, 1) = dr("BATCH")
                Ta(lineas, 2) = dr("ROLLO")
                Ta(lineas, 3) = dr("FPO")
                Ta(lineas, 4) = Trim(dr("CPO"))
                Ta(lineas, 5) = dr("CORTE")
                Ta(lineas, 6) = dr("YARDAS")
                Ta(lineas, 7) = libras
                Ta(lineas, 8) = dr("ACTIVO")
                If Ta(lineas, 8) = "S" Then
                    Ta(lineas, 8) = 0 'BUEN ESTADO
                    Ta(lineas, 8) = estados.Items.Item(Ta(lineas, 8))
                ElseIf Ta(lineas, 8) = 0 Then
                    Ta(lineas, 8) = estados.Items.Item(Ta(lineas, 8))
                Else
                    Ta(lineas, 8) = estados.Items.Item(Ta(lineas, 8) - 1)
                End If
                lineas = lineas + 1
            End If
        Next
    End Sub
    '=============================================== TELA PEDIDA   ================================================
    Private Sub setea_co()
        Dim index As Integer
        Co.Clear()
        Co.Rows.Count = 1
        Co.Cols.Count = 8
        Co.Cols(0).Width = 5
        Co.Rows(0).Height = 30
        Dim c As Column = Co.Cols(1)
        Co.Cols(1).Name = "FPO"
        Co.Cols(2).Name = "LOTE"
        Co.Cols(3).Name = "CLIENTE"
        Co.Cols(4).Name = "CPO"
        Co.Cols(5).Name = "LIBRAS"
        Co.Cols(6).Name = "F.REQUERIDA"
        Co.Cols(7).Name = "F.OFRECIDA"
        For index = 1 To Co.Cols.Count - 1
            Co.Cols(index).Width = 150
            Co(0, index) = Co.Cols(index).Name
            If index = 5 Then
                Co.Cols(index).DataType = GetType(Integer)
                Co.Cols(index).Format = "######0"
                Co.Cols(index).Width = 80
                Co.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Co.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Co.Cols(6).TextAlign = TextAlignEnum.CenterCenter
        Co.Cols(6).TextAlignFixed = TextAlignEnum.CenterCenter
        Co.Cols(7).TextAlign = TextAlignEnum.CenterCenter
        Co.Cols(7).TextAlignFixed = TextAlignEnum.CenterCenter
        Co.Cols(1).AllowMerging = True
        Co.Cols(2).AllowMerging = True
    End Sub
    Private Sub llena_co()
        Dim dt As New DataTable()
        Dim pedidos As Decimal
        Dim strSQL As String = "SELECT FPO,LOTE,CLIENTE,CPO,LIBRAS,RFECHA,(LIBRAS - RECIBIDAS) AS PEDIDO, OFECHA FROM FPO WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND CLIENTE = '" & cliente & "' AND RECIBIDAS = 0"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        Co.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            pedidos = dr("PEDIDO")
            Co(lineas, 1) = dr("FPO")
            Co(lineas, 2) = dr("LOTE")
            Co(lineas, 3) = dr("CLIENTE")
            Co(lineas, 4) = Trim(dr("CPO"))
            Co(lineas, 5) = pedidos
            Co(lineas, 6) = dr("RFECHA")
            Co(lineas, 7) = dr("OFECHA")
            lineas = lineas + 1
        Next
    End Sub
    Private Sub subtotales()
        With Ta
            Dim libras As Integer = Ta.Cols("LIBRAS").Index
            Ta.Subtotal(AggregateEnum.Sum, 0, 0, libras, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
        End With
    End Sub
    Private Sub subtotales1()
        With Co
            Dim libras As Integer = Co.Cols("LIBRAS").Index
            Co.Subtotal(AggregateEnum.Sum, 0, 0, libras, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
        End With
    End Sub
    Private Sub Pe_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pe.Click
        Dim forma As New Prendas_x_cortar()
        Dim linea As Integer
        linea = Pe.RowSel
        Cursor = Cursors.WaitCursor
        forma.Cpo.Text = Pe(linea, 1)
        forma.Estilo.Text = Pe(linea, 2)
        forma.Colo.Text = Pe(linea, 3)
        forma.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim path As String = "c:\reportes\tela_en_inventario.xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            Ta.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            ok = False
        End Try
    End Sub
End Class



