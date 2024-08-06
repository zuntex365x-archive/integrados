Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cortes_split_1
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Dim tt(9) As String
    Dim dr As DataRow
    Dim tli As Decimal
    Dim tya As Decimal
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents motivo As System.Windows.Forms.ComboBox
    Dim cr As DataRow
    Dim obj As New Object

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
    Friend WithEvents corte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents seccion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sp As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents corte1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_split_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.corte = New System.Windows.Forms.TextBox()
        Me.sp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.motivo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.corte1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 242)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 4
        Me.fg.Rows.DefaultSize = 19
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(960, 120)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(288, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(32, 32)
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
        Me.S1.Location = New System.Drawing.Point(288, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(32, 32)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.Location = New System.Drawing.Point(120, 8)
        Me.corte.MaxLength = 15
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(136, 26)
        Me.corte.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.corte, "No. CPO")
        '
        'sp
        '
        Me.sp.AllowEditing = False
        Me.sp.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.sp.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.sp.ColumnInfo = resources.GetString("sp.ColumnInfo")
        Me.sp.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.sp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.sp.ForeColor = System.Drawing.Color.Black
        Me.sp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.sp.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.sp.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.sp.Location = New System.Drawing.Point(12, 414)
        Me.sp.Name = "sp"
        Me.sp.Rows.Count = 2
        Me.sp.Rows.DefaultSize = 19
        Me.sp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.sp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.sp.Size = New System.Drawing.Size(960, 278)
        Me.sp.StyleInfo = resources.GetString("sp.StyleInfo")
        Me.sp.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.sp.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.sp, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(920, 369)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
        Me.graba.TabIndex = 82
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Presione este Boton para Grabar o Actualizar los Datos del  Corte")
        Me.graba.UseVisualStyleBackColor = False
        '
        'descripcion
        '
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(131, 133)
        Me.descripcion.MaxLength = 160
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(778, 51)
        Me.descripcion.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.descripcion, "Descripcion del Estilo.")
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
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Estilo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        Me.cpo.Location = New System.Drawing.Point(131, 24)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(200, 20)
        Me.cpo.TabIndex = 64
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Location = New System.Drawing.Point(131, 48)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(200, 20)
        Me.cliente.TabIndex = 66
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(131, 72)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(200, 20)
        Me.estilo.TabIndex = 67
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(597, 24)
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
        Me.seccion.Location = New System.Drawing.Point(597, 48)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(312, 20)
        Me.seccion.TabIndex = 69
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.motivo)
        Me.GroupBox1.Controls.Add(Me.descripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cliente)
        Me.GroupBox1.Controls.Add(Me.colores)
        Me.GroupBox1.Controls.Add(Me.seccion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.estilo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cpo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 196)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'motivo
        '
        Me.motivo.BackColor = System.Drawing.Color.White
        Me.motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivo.ForeColor = System.Drawing.Color.Black
        Me.motivo.Location = New System.Drawing.Point(131, 105)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(353, 24)
        Me.motivo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Espedifique:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Motivo."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Corte"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'corte1
        '
        Me.corte1.BackColor = System.Drawing.Color.White
        Me.corte1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.corte1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte1.ForeColor = System.Drawing.Color.Black
        Me.corte1.Location = New System.Drawing.Point(120, 380)
        Me.corte1.Name = "corte1"
        Me.corte1.Size = New System.Drawing.Size(128, 24)
        Me.corte1.TabIndex = 75
        Me.corte1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cortes_split_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 704)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.corte1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.R1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_split_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division de Cortes"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler corte.KeyPress, AddressOf keypressed1
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        tt = Split("XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL", ","c)
        llena_combos(motivo, "SELECT MOTIVO FROM CORTES_SPLIT_1", "MOTIVO")
        motivo.SelectedIndex = 0
        obj = New empresas
        limpia_variables()
    End Sub
    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        deshabilita()
        If corte.Text <> "" Then
            ok = True
            cortado(ok)
            revisa_ya_dividido(ok)
            If ok Then
                producido()
                conteo(ok)
                If ok Then
                    graba.Visible = True
                    graba.Focus()
                End If
            Else
                MsgBox("No se puede efectuar división en este Corte.  Ya fue dividido anteriormente", MsgBoxStyle.Critical, "Por favor revise !!!!")
                limpia_variables()
            End If
        Else
            MsgBox("CORTE no Existe !!!!", MsgBoxStyle.Critical, "Por favor Verifique !!!")
            limpia_variables()
        End If
        graba.Visible = True
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub deshabilita()
        corte.ReadOnly = True
        S1.Visible = False
        R1.Visible = True
    End Sub

    Private Sub limpia_variables()
        corte.ReadOnly = False
        corte.Text = ""
        cpo.Text = ""
        corte1.Text = ""
        cliente.Text = ""
        estilo.Text = ""
        colores.Text = ""
        seccion.Text = ""
        descripcion.Text = ""
        S1.Visible = True
        R1.Visible = False
        graba.Visible = False
        setea_fg()
        corte.Focus()
    End Sub

    ''=============================================== CORTE ================================================
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows.Count = 5
        fg.Rows(0).Height = 30
        fg.Rows(4).Height = 30
        fg(1, 1) = "Cortado:"
        fg(2, 1) = "Producido:"
        fg(3, 1) = "Disponibles:"
        fg.Rows(4).Style = fg.Styles("verde")
        sp.Rows.Count = 1
        sp.Rows.Count = 2
        sp.Rows(0).Height = 30
        sp.AllowEditing = True
    End Sub

    Private Sub revisa_ya_dividido(ByRef ok As Boolean)
        Dim dn As New DataTable()
        Dim strSQL As String = "SELECT * FROM CORTES WHERE CORTE = '" & corte1.Text & "'"
        llena_tablas(dn, strSQL, cnn)
        If dn.Rows.Count > 0 Then
            ok = False
        Else
            ok = True
        End If

    End Sub
    Private Sub cortado(ByRef OK As Boolean)
        Dim dt As New DataTable()
        Dim i As Integer
        Dim dato As String
        Dim total As Integer
        Dim strSQL As String = "SELECT CORTES.*,F_ICORTE,SALA FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE CORTES.CORTE = '" & corte.Text & "'"
        OK = False
        llena_tablas(dt, strSQL, cnn)
        For Each Me.cr In dt.Rows
            OK = True
            total = 0
            cpo.Text = cr("CPO")
            cliente.Text = cr("CLIENTE")
            estilo.Text = cr("ESTILO")
            colores.Text = cr("COLOR")
            seccion.Text = cr("SECCION")
            For i = 6 To 16
                dato = cr(i)
                fg(1, i - 4) = fg(1, i - 4) + cr(i)
            Next
        Next
        If OK Then
            corte1.Text = "200-" + Trim(corte.Text)
        End If
    End Sub

    '=============================================== PRODUCCION  ================================================
    Private Sub producido()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim dato As String
        Dim strSQL As String = "SELECT * FROM CORTES_P WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        lineas = 2
        For Each dr In dt.Rows
            For i = 0 To 9
                dato = "P" + CStr(i)
                fg(lineas, i + 2) = fg(lineas, i + 2) + dr(dato)
                fg(lineas, 12) = fg(lineas, 12) + dr(dato)
                dato = "S" + CStr(i)
                fg(lineas, i + 2) = fg(lineas, i + 2) + dr(dato)
                fg(lineas, 12) = fg(lineas, 12) + dr(dato)
            Next
        Next
    End Sub

    Private Sub conteo(ByRef ok As Boolean)
        Dim i As Integer
        ok = True
        For i = 2 To 12
            fg(3, i) = fg(1, i) - fg(2, i)
            If fg(3, i) < 0 Then
                ok = False
            End If
            sp(1, i) = fg(3, i)
        Next
        If fg(3, 12) <= 0 Then
            ok = False
        End If
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub



    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        'If fg(3, 12) = sp(1, 12) Then
        '    MsgBox("No se puede dividir por el total de unidades del corte .", MsgBoxStyle.Critical, "Dividiendo Corte")
        '    Exit Sub
        'End If
        If Trim(descripcion.Text) <> "" Then
            If sp(1, 12) > 0 Then
                seguro = MsgBox("Seguro de Querer Dividir el Corte?  ", MsgBoxStyle.YesNo, "Dividiendo Corte !!!")
                If seguro = MsgBoxResult.Yes Then
                    graba_datos(ok)
                    ok = True
                    If ok Then
                        envia_correo()
                    End If
                    limpia_variables()
                End If
            Else
                MsgBox("Aún no ha ingresado las unidades a dividir", MsgBoxStyle.Critical, "Dividiendo Corte")
            End If

        Else
            MsgBox("Debe especificar el motivo de la división del Corte", MsgBoxStyle.Critical, "Dividiendo Corte")
        End If

    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos(ByVal ok As Boolean)
        Dim strsql As String
        Dim afectados As Integer
        Dim f_icorte As String = Format(cr("F_ICORTE"), "yyyy-MM-dd")
        Dim fcorte As String = Format(cr("FCORTE"), "yyyy-MM-dd")
        Dim fprod As String = Format(cr("FPROD"), "yyyy-MM-dd")
        Dim fecha As String = Format(Now, "yyyy-MM-dd hh:mm:ss")
        ok = False
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '==================== ACTUALIZA CORTE ANTIGUO  =========================================
            strsql = "UPDATE CORTES SET XS = " & "'" & fg(2, 2) & "'" & _
                          " , S = " & "'" & fg(2, 3) & "'" & _
                          " , M = " & "'" & fg(2, 4) & "'" & _
                          " , L = " & "'" & fg(2, 5) & "'" & _
                          " , XL = " & "'" & fg(2, 6) & "'" & _
                          " , XL2 = " & "'" & fg(2, 7) & "'" & _
                          " , XL3 = " & "'" & fg(2, 8) & "'" & _
                          " , XL4 = " & "'" & fg(2, 9) & " '" & _
                          " , XL5 = " & "'" & fg(2, 10) & "'" & _
                          " , XL6 = " & "'" & fg(2, 11) & "'" & _
                          " , TOTAL = " & "'" & fg(2, 12) & "'" & _
                          " WHERE CORTE = '" & corte.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '==================== CORTES   ======================================
            strsql = "INSERT INTO CORTES (CORTE,CLIENTE,CPO,FPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,FCORTE,FPROD,EXPORTADO,SECCION,BATCH) " & _
                     "VALUES ( '" & corte1.Text & "','" & _
                         cr("CLIENTE") & "','" & _
                         cr("CPO") & "','" & _
                         cr("FPO") & "','" & _
                         cr("ESTILO") & "','" & _
                         cr("COLOR") & "','" & _
                          fg(3, 2) & "','" & _
                         fg(3, 3) & "','" & _
                         fg(3, 4) & "','" & _
                         fg(3, 5) & "','" & _
                         fg(3, 6) & "','" & _
                         fg(3, 7) & "','" & _
                         fg(3, 8) & "','" & _
                         fg(3, 9) & "','" & _
                         fg(3, 10) & "','" & _
                         fg(3, 11) & "','" & _
                         fg(3, 12) & "','" & _
                         fcorte & "','" & _
                         fprod & "','N','" & _
                         cr("SECCION") & "','" & _
                         cr("BATCH") & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '==================== CORTES_S ======================================
            strsql = "INSERT INTO CORTES_S (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,F_ICORTE,ESTADO,BATCH,SALA) " & _
                     "VALUES ( '" & corte1.Text & "','" & _
                         cr("CLIENTE") & "','" & _
                         cr("FPO") & "','" & _
                         cr("CPO") & "','" & _
                         cr("ESTILO") & "','" & _
                         cr("COLOR") & "','" & _
                         fg(3, 2) & "','" & _
                         fg(3, 3) & "','" & _
                         fg(3, 4) & "','" & _
                         fg(3, 5) & "','" & _
                         fg(3, 6) & "','" & _
                         fg(3, 7) & "','" & _
                         fg(3, 8) & "','" & _
                         fg(3, 9) & "','" & _
                         fg(3, 10) & "','" & _
                         fg(3, 11) & "','" & _
                         fg(3, 12) & "','" & _
                         f_icorte & "','C','" & _
                         cr("BATCH") & "','" & cr("SALA") & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO CORTES_SPLIT (CORTE,FECHA,MOTIVO,DESCRIPCION,ORIGINAL,SPLIT,USUARIO)  VALUES ('" & corte.Text & "',GETDATE(),'" & motivo.Text & "','" & descripcion.Text & "','" & fg(1, 12) & "','" & fg(3, 12) & "','" & obj.usuario & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            ok = True
      
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

    Private Sub motivo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles motivo.KeyPress
        AutoCompletar(motivo, e)
    End Sub

    Private Sub envia_correo()
        Dim asunto As String
        Dim mensaje As String
        Dim ok As Boolean = False
        asunto = "División de Corte: " + corte.Text + ", Estilo: " + estilo.Text + ", Color:" & colores.Text
        mensaje = "División de Corte:  " + corte.Text + "     del Cliente:  " + cliente.Text + vbLf + vbLf
        mensaje = mensaje + "Motivo:   " + motivo.Text + vbLf + vbLf
        mensaje = mensaje + "Descripción:   " + descripcion.Text + vbLf + vbLf
        mensaje = mensaje + "Unidades originales:  " + CStr(fg(1, 12)) + vbLf
        mensaje = mensaje + "Unidades divididas:   " + CStr(fg(3, 12)) + vbLf

        mensaje = mensaje + vbLf + vbLf + vbLf + "Cambio realializado por: " + obj.usuario
        envia_corrreo_split(asunto, mensaje, ok)
    End Sub
End Class



