Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Inv_PT_1
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim csq As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Dim da(9) As Integer
    Dim tpr As New DataTable
    Dim cnn As New SqlClient.SqlConnection
    Dim cor As New DataTable
    Dim ta As String = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim ts(10) As String
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sala As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Batch As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Fcorte As System.Windows.Forms.Label
    Friend WithEvents Fprod As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents fpo As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents seccion As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents corte As System.Windows.Forms.Label
    Friend WithEvents pr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ex As C1.Win.C1FlexGrid.C1FlexGrid
    Dim pp As New DataTable

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inv_PT_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sala = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Batch = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Fcorte = New System.Windows.Forms.Label()
        Me.Fprod = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.fpo = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.corte = New System.Windows.Forms.Label()
        Me.pr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Corte"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 398)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Exportado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Sala)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Batch)
        Me.GroupBox1.Controls.Add(Me.Label11)
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 152)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'Sala
        '
        Me.Sala.BackColor = System.Drawing.Color.White
        Me.Sala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sala.ForeColor = System.Drawing.Color.Black
        Me.Sala.Location = New System.Drawing.Point(584, 120)
        Me.Sala.Name = "Sala"
        Me.Sala.Size = New System.Drawing.Size(312, 20)
        Me.Sala.TabIndex = 77
        Me.Sala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(496, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Sala:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Batch
        '
        Me.Batch.BackColor = System.Drawing.Color.White
        Me.Batch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Batch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch.ForeColor = System.Drawing.Color.Black
        Me.Batch.Location = New System.Drawing.Point(112, 120)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(368, 20)
        Me.Batch.TabIndex = 75
        Me.Batch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Batch:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Fcorte
        '
        Me.Fcorte.BackColor = System.Drawing.Color.White
        Me.Fcorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fcorte.ForeColor = System.Drawing.Color.Black
        Me.Fcorte.Location = New System.Drawing.Point(584, 72)
        Me.Fcorte.Name = "Fcorte"
        Me.Fcorte.Size = New System.Drawing.Size(144, 20)
        Me.Fcorte.TabIndex = 72
        Me.Fcorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fprod
        '
        Me.Fprod.BackColor = System.Drawing.Color.White
        Me.Fprod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fprod.ForeColor = System.Drawing.Color.Black
        Me.Fprod.Location = New System.Drawing.Point(584, 96)
        Me.Fprod.Name = "Fprod"
        Me.Fprod.Size = New System.Drawing.Size(144, 20)
        Me.Fprod.TabIndex = 73
        Me.Fprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(496, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "F.Corte:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(496, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "F.Prod:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Estilo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Location = New System.Drawing.Point(112, 72)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(200, 20)
        Me.cliente.TabIndex = 66
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpo
        '
        Me.fpo.BackColor = System.Drawing.Color.White
        Me.fpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fpo.ForeColor = System.Drawing.Color.Black
        Me.fpo.Location = New System.Drawing.Point(112, 48)
        Me.fpo.Name = "fpo"
        Me.fpo.Size = New System.Drawing.Size(200, 20)
        Me.fpo.TabIndex = 65
        Me.fpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(584, 24)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(312, 20)
        Me.colores.TabIndex = 68
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.White
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccion.ForeColor = System.Drawing.Color.Black
        Me.seccion.Location = New System.Drawing.Point(584, 48)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(312, 20)
        Me.seccion.TabIndex = 69
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(496, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Color:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(112, 96)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(200, 20)
        Me.estilo.TabIndex = 67
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Fpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(496, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Sección:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.ForeColor = System.Drawing.Color.Black
        Me.cpo.Location = New System.Drawing.Point(112, 24)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(200, 20)
        Me.cpo.TabIndex = 64
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cpo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Producido"
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
        Me.Co.Location = New System.Drawing.Point(21, 219)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1017, 56)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 94
        Me.Co.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Cortado"
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.ForeColor = System.Drawing.Color.Black
        Me.corte.Location = New System.Drawing.Point(126, 11)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(115, 20)
        Me.corte.TabIndex = 101
        Me.corte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pr
        '
        Me.pr.AllowEditing = False
        Me.pr.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.pr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.pr.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pr.ColumnInfo = resources.GetString("pr.ColumnInfo")
        Me.pr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pr.ForeColor = System.Drawing.Color.Black
        Me.pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.pr.Location = New System.Drawing.Point(20, 302)
        Me.pr.Name = "pr"
        Me.pr.Rows.DefaultSize = 19
        Me.pr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pr.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.pr.Size = New System.Drawing.Size(1018, 91)
        Me.pr.StyleInfo = resources.GetString("pr.StyleInfo")
        Me.pr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.pr.TabIndex = 102
        Me.pr.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'ex
        '
        Me.ex.AllowEditing = False
        Me.ex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ex.ColumnInfo = resources.GetString("ex.ColumnInfo")
        Me.ex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ex.ForeColor = System.Drawing.Color.Black
        Me.ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ex.Location = New System.Drawing.Point(20, 417)
        Me.ex.Name = "ex"
        Me.ex.Rows.DefaultSize = 19
        Me.ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ex.Size = New System.Drawing.Size(1018, 262)
        Me.ex.StyleInfo = resources.GetString("ex.StyleInfo")
        Me.ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ex.TabIndex = 103
        Me.ex.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Inv_PT_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 690)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inv_PT_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del Corte"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grids()
        procesa()
    End Sub

    Private Sub procesa()
        llena_co()
        llena_pr()
        llena_EX()
        subtotales()
    End Sub
    Private Sub setea_grids()
        Co.Rows.Count = 2
        pr.Rows.Count = 3
        ex.Rows.Count = 1
        Co.Rows(0).Height = 30
        pr.Rows(0).Height = 30
        pr.Rows(0).Height = 30
    End Sub
    Private Sub llena_co()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim total As Integer
        Dim strSQL As String = "SELECT CORTES.*, SALA FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE CORTES.CORTE = '" & corte.Text & "' ORDER BY FCORTE"
        OK = False
        llena_tablas(dt, strSQL, csq)
        For Each dr In dt.Rows
            OK = True
            total = 0
            cpo.Text = dr("CPO")
            fpo.Text = dr("FPO")
            cliente.Text = dr("CLIENTE")
            estilo.Text = dr("ESTILO")
            colores.Text = dr("COLOR")
            seccion.Text = dr("SECCION")
            Try
                Batch.Text = dr("BATCH")
            Catch
            End Try
            Co(1, 1) = dr("FCORTE")
            For i = 2 To 11
                Co(1, i) = dr(i + 4)
                total = total + Co(1, i)
            Next
            Co(1, 12) = total
            Fcorte.Text = Format(dr("FCORTE"), "dd/MMM/yyyy")
            Fprod.Text = Format(dr("FPROD"), "dd/MMM/yyyy")
            Try
                Sala.Text = dr("SALA")
            Catch
                Sala.Text = ""
            End Try
        Next
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, Co, 0, 2)
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, pr, 0, 2)
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, ex, 0, 4)
    End Sub

    Private Sub llena_pr()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim dato As String
        Dim strSQL As String = "SELECT * FROM CORTES_P WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strSQL, csq)
        For Each dr In dt.Rows
            pr(1, 1) = "PRIMERAS"
            Pr(2, 1) = "SEGUNDAS"
            For i = 0 To 9
                dato = "P" + CStr(i)
                pr(1, i + 2) = pr(1, i + 2) + dr(dato)
                pr(1, 12) = pr(1, 12) + pr(1, i + 2)
                dato = "S" + CStr(i)
                pr(2, i + 2) = pr(2, i + 2) + dr(dato)
                pr(2, 12) = pr(2, 12) + pr(2, i + 2)
            Next
        Next
        If dt.Rows.Count = 0 Then
            Fprod.Text = ""
        End If
    End Sub
    '=============================================== EXPORTACION  ================================================

    Private Sub llena_EX()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim l As Integer = 1
        Dim strSQL As String = "SELECT * FROM PACKING_D WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strSQL, csq)
        ex.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            ex(l, 1) = dr("FECHA")
            ex(l, 2) = dr("EMBARQUE")
            ex(l, 3) = dr("TIPO")
            For i = 8 To 17
                ex(l, i - 4) = dr(i)
                ex(l, 14) = ex(l, 14) + dr(i)
            Next
            l = l + 1
        Next
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        For i = 2 To 12
            Pr.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            ex.Subtotal(AggregateEnum.Sum, 0, 0, i + 2, "Gran Total -->")
        Next
    End Sub


End Class



