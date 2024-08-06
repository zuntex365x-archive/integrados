Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Lista_empaque_q
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim dw As DataRow
    Dim strSQl As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Embarque As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nc As System.Windows.Forms.TextBox
    Friend WithEvents ec As System.Windows.Forms.TextBox
    Friend WithEvents prendas As System.Windows.Forms.Label
    Friend WithEvents talla As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents caja As System.Windows.Forms.Label
    Friend WithEvents graba As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_q))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Embarque = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nc = New System.Windows.Forms.TextBox()
        Me.ec = New System.Windows.Forms.TextBox()
        Me.prendas = New System.Windows.Forms.Label()
        Me.talla = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.caja = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Embarque
        '
        Me.Embarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embarque.Location = New System.Drawing.Point(112, 8)
        Me.Embarque.Name = "Embarque"
        Me.Embarque.Size = New System.Drawing.Size(200, 28)
        Me.Embarque.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Embarque, "Embarque.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(376, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Desplegar la Consulta.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(376, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 83
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Otro Embarque")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(928, 24)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
        Me.graba.TabIndex = 100
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Presione este Boton para Grabar o Actualizar los Datos del  Corte")
        Me.graba.UseVisualStyleBackColor = False
        Me.graba.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(1, 48)
        Me.jg.Name = "jg"
        Me.jg.Rows.Count = 1
        Me.jg.Rows.DefaultSize = 19
        Me.jg.Size = New System.Drawing.Size(1008, 304)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 26)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Caja No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.graba)
        Me.GroupBox1.Controls.Add(Me.nc)
        Me.GroupBox1.Controls.Add(Me.ec)
        Me.GroupBox1.Controls.Add(Me.prendas)
        Me.GroupBox1.Controls.Add(Me.talla)
        Me.GroupBox1.Controls.Add(Me.colo)
        Me.GroupBox1.Controls.Add(Me.estilo)
        Me.GroupBox1.Controls.Add(Me.cpo)
        Me.GroupBox1.Controls.Add(Me.caja)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 288)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'nc
        '
        Me.nc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nc.Location = New System.Drawing.Point(144, 226)
        Me.nc.MaxLength = 5
        Me.nc.Name = "nc"
        Me.nc.Size = New System.Drawing.Size(64, 24)
        Me.nc.TabIndex = 4
        Me.nc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ec
        '
        Me.ec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ec.Location = New System.Drawing.Point(144, 202)
        Me.ec.MaxLength = 5
        Me.ec.Name = "ec"
        Me.ec.Size = New System.Drawing.Size(64, 24)
        Me.ec.TabIndex = 3
        Me.ec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'prendas
        '
        Me.prendas.BackColor = System.Drawing.Color.White
        Me.prendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.prendas.ForeColor = System.Drawing.Color.Black
        Me.prendas.Location = New System.Drawing.Point(144, 160)
        Me.prendas.Name = "prendas"
        Me.prendas.Size = New System.Drawing.Size(64, 24)
        Me.prendas.TabIndex = 97
        Me.prendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'talla
        '
        Me.talla.BackColor = System.Drawing.Color.White
        Me.talla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.talla.ForeColor = System.Drawing.Color.Black
        Me.talla.Location = New System.Drawing.Point(144, 136)
        Me.talla.Name = "talla"
        Me.talla.Size = New System.Drawing.Size(64, 24)
        Me.talla.TabIndex = 96
        Me.talla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colo.ForeColor = System.Drawing.Color.Black
        Me.colo.Location = New System.Drawing.Point(144, 112)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(248, 24)
        Me.colo.TabIndex = 95
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(144, 88)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(248, 24)
        Me.estilo.TabIndex = 94
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.ForeColor = System.Drawing.Color.Black
        Me.cpo.Location = New System.Drawing.Point(144, 64)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(248, 24)
        Me.cpo.TabIndex = 93
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'caja
        '
        Me.caja.BackColor = System.Drawing.Color.White
        Me.caja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.caja.ForeColor = System.Drawing.Color.Black
        Me.caja.Location = New System.Drawing.Point(144, 32)
        Me.caja.Name = "caja"
        Me.caja.Size = New System.Drawing.Size(64, 24)
        Me.caja.TabIndex = 92
        Me.caja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 26)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Nueva Caja."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 26)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Esta Caja."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 26)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Prendas."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 26)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Talla."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 26)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Color."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 26)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Estilo."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 26)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Cpo."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lista_empaque_q
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.Embarque)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_q"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Divide Cajas"
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cpo_auditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Embarque.KeyPress, AddressOf keypressed1
        AddHandler ec.KeyPress, AddressOf keypressed2
        AddHandler nc.KeyPress, AddressOf keypressed3
        limpia_variables()
        llena_empaque()
    End Sub

    Private Sub limpia_variables()
        setea_jg()
        caja.Text = ""
        cpo.Text = ""
        estilo.Text = ""
        colo.Text = ""
        talla.Text = ""
        prendas.Text = "0"
        ec.Text = "0"
        nc.Text = "0"
        ec.ReadOnly = True
        nc.ReadOnly = True
        Button2.Visible = True
        regresa.Visible = False
        graba.Visible = False
        Embarque.Enabled = True
        Embarque.Focus()
    End Sub


    Private Sub llena_empaque()
        llena_combos(Embarque, "SELECT DISTINCT EMBARQUE, FECHA FROM PACKING_E WHERE FACTURADO = 'N' ORDER BY FECHA DESC", "EMBARQUE")
        Try
            Embarque.SelectedIndex = 0
        Catch
        End Try
        Button2.Visible = True
        regresa.Visible = False
    End Sub

    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
    End Sub

    Private Sub llena_jg()
        Dim dt As New DataTable()
        Dim l As Integer = 1
        strSQl = "SELECT * FROM PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "'"
        llena_tablas(dt, strSQl, cnn)
        jg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            jg(l, 1) = dr("CAJA")
            jg(l, 2) = dr("CPO")
            jg(l, 3) = dr("ESTILO")
            jg(l, 4) = dr("COLOR")
            jg(l, 5) = dr("TALLA")
            jg(l, 6) = dr("PRENDAS")
            jg(l, 7) = False
            l = l + 1
        Next
    End Sub


    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        limpia_variables()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Embarque.Text) <> "" Then
                Button2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            nc.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            graba.Focus()
        End If
    End Sub 'keypressed



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        llena_jg()
        Embarque.Enabled = False
        Button2.Visible = False
        regresa.Visible = True
    End Sub

    Private Sub busca_caja()
        Dim r As Integer = jg.RowSel
        strSQl = "SELECT * FROM PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "' AND CAJA = '" & jg(r, 1) & "'"
        llena_tablas(dt, strSQl, cnn)
        For Each Me.dw In dt.Rows
            caja.Text = dw("CAJA")
            cpo.Text = dw("CPO")
            estilo.Text = dw("ESTILO")
            colo.Text = dw("COLOR")
            talla.Text = dw("TALLA")
            prendas.Text = dw("PRENDAS")
            ec.Text = prendas.Text
            nc.Text = 0
        Next
    End Sub


    Private Sub jg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jg.Click
        Dim i As Integer
        Dim l As Integer = jg.RowSel
        For i = 1 To jg.Rows.Count - 1
            jg(i, 7) = False
        Next
        Try
            jg(l, 7) = True
            busca_caja()
            graba.Visible = True
            ec.ReadOnly = False
            nc.ReadOnly = False
        Catch
        End Try

    End Sub

    Private Sub ec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ec.Leave
        Dim l As Integer
        Try
            l = Int(ec.Text)
            If l >= Int(prendas.Text) And l > 0 Then
                MsgBox("El nuevo número de prendas de la caja original no puede ser mayor al total de prendas.", MsgBoxStyle.Critical, "Error en el ingreso")
                ec.Focus()
            End If
            l = Int(ec.Text) + Int(nc.Text)
            If l > Int(prendas.Text) And l > 0 Then
                mayor()
                ec.Focus()
            End If
        Catch
            MsgBox("El número de unidades debe ser un entero", MsgBoxStyle.Critical, "Error en el ingreso")
            ec.Focus()
        End Try
    End Sub

    Private Sub mayor()
        MsgBox("La suma de la caja original + nueva caja no puede ser mayor al total de prendas.", MsgBoxStyle.Critical, "Error en el ingreso")
    End Sub


    Private Sub nc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nc.Leave
        Dim l As Integer
        Try
            l = Int(nc.Text)
            If l >= Int(prendas.Text) And l > 0 Then
                MsgBox("El nuevo número de prendas de la nueva caja no puede ser mayor al total de prendas.", MsgBoxStyle.Critical, "Error en el ingreso")
                nc.Focus()
            End If
            l = Int(ec.Text) + Int(nc.Text)
            If l > Int(prendas.Text) And l > 0 Then
                mayor()
                nc.Focus()
            End If
        Catch
            MsgBox("El número de unidades debe ser un entero", MsgBoxStyle.Critical, "Error en el ingreso")
            nc.Focus()
        End Try
    End Sub

    Private Sub chequea_datos(ByRef ok As Boolean)
        Dim l As Integer
        ok = True
        Try
            l = Int(ec.Text) + Int(nc.Text)
            If l <> Int(prendas.Text) Then
                MsgBox("La suma de las prendas de la caja original + nueva caja no concuerdan.", MsgBoxStyle.Critical, "Error en el ingreso")
                ok = False
                Exit Sub
            End If
            If Int(ec.Text) = 0 Or Int(nc.Text) = 0 Then
                MsgBox("Ninguna de las dos cajas puede tener No. prendas igual a cero. ", MsgBoxStyle.Critical, "Error en el ingreso")
                ok = False
                Exit Sub
            End If
        Catch
            MsgBox("Datos inconsistentes.", MsgBoxStyle.Critical, "Error en el ingreso de datos.")
            ok = False
        End Try
    End Sub


    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean
        chequea_datos(ok)
        If ok Then
            Dim seguro As MsgBoxResult
            seguro = MsgBox("Seguro de efectuar el cambio?  ", MsgBoxStyle.YesNo, "Grabando cambios !!!")
            If seguro = MsgBoxResult.Yes Then
                actualiza_datos()
                limpia_variables()
            End If
        End If
    End Sub

    Private Sub ultima_caja(ByVal ultima As Integer)
        Dim da As New DataTable()
        Dim dd As DataRow
        ultima = 0
        strSQl = "SELECT TOP 1 * FROM PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "' ORDER BY CAJA DESC"
        llena_tablas(da, strSQl, cnn)
        For Each dd In da.Rows
            ultima = dr("CAJA") + 1
        Next
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub actualiza_datos()
        Dim c As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim da As New DataTable()
        Dim dd As DataRow
        Dim tipo As String = dw("TIPO")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "SELECT TOP 1 * FROM PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "' ORDER BY CAJA DESC"
            llena_tablas(da, strsql, cnn)
            For Each dd In da.Rows
                c = dr("CAJA") + 1
            Next


            strsql = "UPDATE PACKING_C SET PRENDAS = " & Int(ec.Text) & " WHERE EMBARQUE = '" & Embarque.Text & _
                                               "' AND CAJA = '" & caja.Text & "' AND CPO = '" & cpo.Text & _
                                               "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colo.Text & _
                                               "' AND TIPO = '" & tipo & "' AND TALLA = '" & talla.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO PACKING_C (EMBARQUE,CAJA,CPO,ESTILO,COLOR,TIPO,TALLA,PRENDAS) " & _
                                 "VALUES ('" & Embarque.Text & "','" & _
                                               c & "','" & _
                                               cpo.Text & "','" & _
                                               estilo.Text & "','" & _
                                               colo.Text & "','" & _
                                               tipo & "','" & _
                                               talla.Text & "','" & _
                                               nc.Text & "')"

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

End Class



