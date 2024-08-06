Imports C1.Win.C1FlexGrid

Public Class Cajas05_I
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable
    Dim co As New DataTable
    Dim pp As New DataTable
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Dim dr As DataRow
    Dim caja_nueva As String
    Dim cliente As String
    Dim escala As String
    Dim tp As New DataTable
    Dim esBlank As Boolean
    Friend WithEvents pr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents seccion As System.Windows.Forms.Label
    Friend WithEvents tcortado As System.Windows.Forms.Label
    Friend WithEvents tprod As System.Windows.Forms.Label
    Dim dj As DataRow
    Dim ta As String = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tt As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents fecha_d As System.Windows.Forms.Label
    Dim ts(10) As String
    Dim fecha As Date = Today
    Dim cor As New DataTable
    Dim cte As New DataTable
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajas05_I))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.Label()
        Me.tcortado = New System.Windows.Forms.Label()
        Me.tprod = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fecha_d = New System.Windows.Forms.Label()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.corte.Location = New System.Drawing.Point(201, 21)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(189, 28)
        Me.corte.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.corte, "No. Corte")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(911, 12)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 1
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Chequeo de Datos")
        Me.si.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(977, 12)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 104
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(911, 12)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(60, 40)
        Me.G1.TabIndex = 124
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Actualiza la BAse de Datos.")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 32)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pr
        '
        Me.pr.ColumnInfo = resources.GetString("pr.ColumnInfo")
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.pr.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.pr.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.pr.Location = New System.Drawing.Point(12, 305)
        Me.pr.Name = "pr"
        Me.pr.Rows.DefaultSize = 21
        Me.pr.Size = New System.Drawing.Size(1048, 334)
        Me.pr.StyleInfo = resources.GetString("pr.StyleInfo")
        Me.pr.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 32)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "CPO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 32)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Estilo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 32)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Color:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(633, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 32)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Seccion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cpo.Location = New System.Drawing.Point(201, 56)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(352, 32)
        Me.cpo.TabIndex = 111
        Me.cpo.Text = " "
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.estilo.Location = New System.Drawing.Point(202, 93)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(352, 32)
        Me.estilo.TabIndex = 112
        Me.estilo.Text = " "
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colo.Location = New System.Drawing.Point(202, 130)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(352, 32)
        Me.colo.TabIndex = 113
        Me.colo.Text = " "
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.seccion.Location = New System.Drawing.Point(826, 61)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(211, 32)
        Me.seccion.TabIndex = 114
        Me.seccion.Text = " "
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tcortado
        '
        Me.tcortado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tcortado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tcortado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tcortado.Location = New System.Drawing.Point(849, 246)
        Me.tcortado.Name = "tcortado"
        Me.tcortado.Size = New System.Drawing.Size(188, 45)
        Me.tcortado.TabIndex = 115
        Me.tcortado.Text = " "
        Me.tcortado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tprod
        '
        Me.tprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tprod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tprod.Location = New System.Drawing.Point(849, 668)
        Me.tprod.Name = "tprod"
        Me.tprod.Size = New System.Drawing.Size(188, 45)
        Me.tprod.TabIndex = 116
        Me.tprod.Text = " "
        Me.tprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(633, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 32)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "F. Producción:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 170)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(1048, 76)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
        '
        'tt
        '
        Me.tt.AllowEditing = False
        Me.tt.BackColor = System.Drawing.Color.SteelBlue
        Me.tt.ColumnInfo = resources.GetString("tt.ColumnInfo")
        Me.tt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tt.ForeColor = System.Drawing.Color.White
        Me.tt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.tt.Location = New System.Drawing.Point(12, 641)
        Me.tt.Name = "tt"
        Me.tt.Rows.Count = 1
        Me.tt.Rows.DefaultSize = 21
        Me.tt.Rows.Fixed = 0
        Me.tt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tt.Size = New System.Drawing.Size(1048, 24)
        Me.tt.StyleInfo = resources.GetString("tt.StyleInfo")
        Me.tt.TabIndex = 122
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(911, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "C"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'fecha_d
        '
        Me.fecha_d.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fecha_d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fecha_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fecha_d.Location = New System.Drawing.Point(826, 99)
        Me.fecha_d.Name = "fecha_d"
        Me.fecha_d.Size = New System.Drawing.Size(211, 32)
        Me.fecha_d.TabIndex = 125
        Me.fecha_d.Text = " "
        Me.fecha_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cajas05_I
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1097, 727)
        Me.Controls.Add(Me.fecha_d)
        Me.Controls.Add(Me.tt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tprod)
        Me.Controls.Add(Me.tcortado)
        Me.Controls.Add(Me.seccion)
        Me.Controls.Add(Me.colo)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.G1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cajas05_I"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Producción"
        CType(Me.pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cajas05_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AddHandler corte.KeyPress, AddressOf keypressed1
        fecha_d.Text = Format(fecha, "dd/MM/yyyy")
        ' Primer problema esta aqui, busca que el corte no tenga produccion diaria y como estos ya se fueron producidos
        llena_tablas(cor, "SELECT  DISTINCT CORTE FROM CORTES WHERE CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND EXPORTADO <> 'S' AND TOTAL > 0 ", cnn)
        Try
            llena_tablas(cte, "SELECT CORTE FROM CORTES_TF", cnn)
            cor.Merge(cte)
        Catch
        End Try
        llena_combos_d(corte, cor, "CORTE")
        llena_tablas(tp, "SELECT * FROM TIPOS_PRENDA", cnn)
        Try
            corte.SelectedIndex = 0
        Catch
        End Try
        ts = ta.Split("|")
        limpia_variables()
    End Sub
    Private Sub limpia_variables()
        setea_grid()
        corte.Enabled = True
        esBlank = False
        cpo.Text = ""
        estilo.Text = ""
        colo.Text = ""
        seccion.Text = ""
        tcortado.Text = "0"
        tprod.Text = "0"
        si.Visible = True
        borra_totales()
        corte.Focus()
    End Sub
    Private Sub habilita()
        si.Visible = False
        corte.Enabled = False
    End Sub
    Private Sub setea_grid()
        Dim I As Integer
        Dim dr As DataRow
        Dim l As Integer = 1
        fg.Rows.Count = 2
        fg.Rows.Fixed = 1
        fg.Rows(0).Height = 30
        fg.Rows(1).Height = 30
        pr.Rows.Count = 1
        pr.Rows(0).Height = 30
        pr.Rows.Count = tp.Rows.Count + 2
        For I = 0 To tp.Rows.Count - 1
            dr = tp.Rows(I)
            pr(I + 1, 0) = dr("CODIGO")
            pr(I + 1, 1) = dr("TIPO_PRENDA")
            l = l + 1
        Next
        pr(l, 1) = "Vales"
    End Sub
    Private Sub si_Click(sender As System.Object, e As System.EventArgs) Handles si.Click
        llena_corte()
    End Sub

    Private Sub llena_corte()
        Dim i As Integer
        Dim escala As String = ""
        llena_tablas(co, "SELECT CORTES.*,CPO_D.ESCALA, E_TALLAS.* FROM CORTES LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTE = '" & corte.Text & "'", cnn)
        If co.Rows.Count > 0 Then
            dr = co.Rows(0)
            dj = dr
            cpo.Text = dr("CPO")
            estilo.Text = dr("ESTILO")
            colo.Text = dr("COLOR")
            seccion.Text = dr("SECCION")
            tcortado.Text = dr("TOTAL")
            cliente = dr("CLIENTE")
            escala = dr("ESCALA")
            fg(1, 1) = "Cortado"
        End If
        For i = 1 To 10
            If escala = "00" Then
                dj(i + 24) = ts(i)
            End If
            fg(0, i + 1) = dj(i + 24)
            fg(1, i + 1) = dj(i + 5)
            pr(0, i + 1) = dj(i + 24)
        Next
        llena_vales()
        habilita()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub corteS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub

    Private Sub sigue_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    '============================= Caso especial de Blanks ================================
    Private Sub verificarBlanks()
        Dim sqlQuerry As String
        Dim da As System.Data.SqlClient.SqlDataAdapter
        sqlQuerry = "SELECT * FROM CORTES_B WHERE CORTE_NUEVO = '" & corte.Text & "'"
        cnn.Open()
        Dim ds As New DataSet()
        Try
            da = New System.Data.SqlClient.SqlDataAdapter(sqlQuerry, cnn)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                esBlank = True
            End If
        Catch ex As Exception
            ' Show this message for debug purpose.
            'MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Notificar a IT porfavor.")
        End Try
    End Sub
    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        limpia_variables()
        corte.Focus()
    End Sub
    '============================= Actualiza la Base de Datos =============================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim pre As String = ""
        Dim j As Integer
        Dim obj As New empresas
        Dim h As String = " "
        If obj.numero = "1" Then
            pre = "JT"
        ElseIf obj.numero = "3" Then
            pre = "ZU"
        End If
        Dim tipo As String
        Dim talla As String
        Dim fechas As String = Format(Today, "yyyy-MM-dd")
        Dim p(9) As Integer
        Dim s(9) As Integer
        Dim UP As String
        Dim tipos As String
        Dim no_mover As String = "Vales"
        Dim c As Boolean
        cnn.Close()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try

            For i = 1 To pr.Rows.Count - 2
                tipos = pr(i, 1)
                c = no_mover.Contains(tipos)
                If Not c Then
                    For j = 2 To 11
                        If pr(i, j) > 0 Then
                            talla = pr(0, j)
                            tipo = pr(i, 0)
                            '==================== DIARIO =========================================
                            strsql = "INSERT INTO PROD_DIARIA (CORTE,FECHA,TIPO,TALLA,PRENDAS) " & _
                                     "VALUES ( '" & corte.Text & "','" & _
                                        fechas & "','" & _
                                        tipo & "','" & _
                                        talla & "'," & _
                                        CInt(pr(i, j)) & ")"
                            ' Si es blank no debe de duplicar la produccion diaria.
                            If Not esBlank Then
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If

                            '=================== ACUMULADO ======================================
                            If tipo = 0 Then
                                p(j - 2) = pr(i, j)
                                UP = "P" + CStr(j - 2)
                            Else
                                s(j - 2) = pr(i, j)
                                UP = "S" + CStr(j - 2)
                            End If
                            strsql = "UPDATE CORTES_P SET " & UP & " = " & UP & " + " & pr(i, j) & " WHERE CORTE = '" & corte.Text & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                            If afectados = 0 Then
                                strsql = "INSERT INTO CORTES_P (CORTE,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9) " & _
                                         "VALUES ( '" & corte.Text & "','" & _
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
                            ' ==================== SECCION =======================================
                            strsql = "UPDATE CORTES SET FPROD = '" & fechas & "' WHERE CORTE = '" & corte.Text & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If

                    Next
                End If
            Next

            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean
        borra_totales()
        llena_vales()
        calcula_totales(ok)
        If ok Then
            If CInt(tcortado.Text) <> CInt(tprod.Text) Then
                seguro = MsgBox("Atencion: " + vbLf + "El número de Prendas Cortadas no coinciden con el número de Prendas Producidas?", MsgBoxStyle.YesNo, "Seguro de continuar?")
                If seguro = MsgBoxResult.Yes Then
                    seguro = MsgBox("Atencion:" + vbLf + " Está completamente seguro de Continuar?", MsgBoxStyle.YesNo, "Seguro de continuar?")
                    If seguro <> MsgBoxResult.Yes Then
                        limpia_variables()
                        Exit Sub
                    End If
                Else
                    limpia_variables()
                    Exit Sub
                End If
            Else
            End If
            pr.Enabled = False
            Button1.Visible = False
            G1.Visible = True
        End If
    End Sub

    Private Sub borra_totales()
        tt(0, 1) = "TOTALES"
        For i = 2 To 11
            tt(0, i) = 0
        Next
    End Sub
    Private Sub borra_vales()
        For i = 2 To 11
            pr(14, i) = ""
        Next
    End Sub
    Private Sub llena_vales()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim i As Integer
        borra_vales()
        llena_tablas(dt, "SELECT * FROM CORTES_V WHERE CORTE = '" & corte.Text & "'", cnn)
        For Each dr In dt.Rows
            For i = 1 To 10
                pr(14, i + 1) = pr(14, i + 1) + (dr(i) + dr(i + 10))
            Next
        Next
    End Sub
    Private Sub calcula_totales(ByRef ok As Boolean)
        Dim i As Integer
        Dim j As Integer
        ok = True
        tprod.Text = 0
        For i = 1 To 13
            For j = 2 To 11
                tt(0, j) = tt(0, j) + pr(i, j)
                tprod.Text = tprod.Text + pr(i, j)
            Next
        Next
        For i = 2 To 11
            If fg(1, i) < tt(0, i) Then
                MsgBox("Diferencia en la talla " + fg(0, i), MsgBoxStyle.Critical, "Revise y corrija.")
                ok = False
            End If
        Next

    End Sub

    Private Sub G1_Click(sender As System.Object, e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            If fg.Rows.Count > 1 Then
                ' En este punto verifico si el corte que esta seleccionado es parte de un hijo de blanks
                verificarBlanks()

                graba_datos()
                Close()
            End If
        End If
    End Sub
End Class

