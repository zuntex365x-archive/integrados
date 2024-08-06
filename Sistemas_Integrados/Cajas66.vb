Imports C1.Win.C1FlexGrid

Public Class Cajas66
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable
    Dim co As New DataTable
    Dim pp As New DataTable
    Friend WithEvents graba As System.Windows.Forms.Button
    Private WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Dim dr As DataRow
    Dim caja_nueva As String
    Dim cliente As String
    Dim escala As String
    Dim tp As New DataTable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents seccion As System.Windows.Forms.Label
    Dim dj As DataRow
    Dim ta As String = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fcorte As System.Windows.Forms.Label
    Friend WithEvents cj As C1FlexGrid
    Friend WithEvents nuevo As TextBox
    Friend WithEvents Label7 As Label
    Dim ts(10) As String
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajas66))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fcorte = New System.Windows.Forms.Label()
        Me.cj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.nuevo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cj, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolTip1.SetToolTip(Me.corte, "No. Embarque")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(910, 19)
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
        Me.Cancela.Location = New System.Drawing.Point(977, 19)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 104
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" &
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(909, 19)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 9
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 228)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 3
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(1048, 76)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
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
        Me.Label3.Text = "Corte Maestro:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 106)
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
        Me.Label2.Location = New System.Drawing.Point(12, 143)
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
        Me.Label4.Location = New System.Drawing.Point(12, 180)
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
        Me.Label5.Location = New System.Drawing.Point(633, 105)
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
        Me.cpo.Location = New System.Drawing.Point(201, 106)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(307, 32)
        Me.cpo.TabIndex = 111
        Me.cpo.Text = " "
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.estilo.Location = New System.Drawing.Point(202, 143)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(307, 32)
        Me.estilo.TabIndex = 112
        Me.estilo.Text = " "
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colo.Location = New System.Drawing.Point(202, 180)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(307, 32)
        Me.colo.TabIndex = 113
        Me.colo.Text = " "
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.seccion.Location = New System.Drawing.Point(826, 105)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(211, 32)
        Me.seccion.TabIndex = 114
        Me.seccion.Text = " "
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(633, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 32)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "F. Corte:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fcorte
        '
        Me.fcorte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fcorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.fcorte.Location = New System.Drawing.Point(826, 143)
        Me.fcorte.Name = "fcorte"
        Me.fcorte.Size = New System.Drawing.Size(211, 32)
        Me.fcorte.TabIndex = 118
        Me.fcorte.Text = " "
        Me.fcorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cj
        '
        Me.cj.AllowFiltering = True
        Me.cj.ColumnInfo = resources.GetString("cj.ColumnInfo")
        Me.cj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cj.Location = New System.Drawing.Point(12, 324)
        Me.cj.Name = "cj"
        Me.cj.Rows.Count = 1
        Me.cj.Rows.DefaultSize = 21
        Me.cj.Size = New System.Drawing.Size(1048, 468)
        Me.cj.StyleInfo = resources.GetString("cj.StyleInfo")
        Me.cj.TabIndex = 119
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.nuevo.Location = New System.Drawing.Point(202, 60)
        Me.nuevo.MaxLength = 10
        Me.nuevo.Multiline = True
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(188, 29)
        Me.nuevo.TabIndex = 1
        Me.nuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 32)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Nuevo Corte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cajas66
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1097, 804)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.cj)
        Me.Controls.Add(Me.fcorte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.seccion)
        Me.Controls.Add(Me.colo)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cajas66"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Cortes NUEVOS"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Cajas66_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler corte.KeyPress, AddressOf keypressed1
        AddHandler nuevo.KeyPress, AddressOf keypressed2
        llena_combos(corte, "SELECT DISTINCT CORTE FROM CORTES WHERE CORTE IN (SELECT DISTINCT CORTE FROM CORTES_M) AND TOTAL > 0  ORDER BY CORTE", "CORTE")
        llena_tablas(tp, "SELECT * FROM TIPOS_PRENDA", cnn)
        Try
            corte.SelectedIndex = 0
        Catch
        End Try
        ts = ta.Split("|")
    End Sub
    Private Sub limpia_variables()
        setea_grid()
        corte.Enabled = True
        nuevo.Enabled = True
        cpo.Text = ""
        estilo.Text = ""
        colo.Text = ""
        seccion.Text = ""
        fcorte.Text = ""
        si.Visible = True
        graba.Visible = False
        corte.Focus()
    End Sub
    Private Sub habilita()
        si.Visible = False
        graba.Visible = True
        corte.Enabled = False
        nuevo.Enabled = False
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 3
        fg.Rows.Fixed = 1
        fg.Rows(0).Height = 25
        fg.Rows(1).Height = 25
        cj.Rows.Count = 1
        cj.Rows(0).Height = 30
    End Sub
    Private Sub si_Click(sender As System.Object, e As System.EventArgs) Handles si.Click
        Dim nuev As String
        Dim ok As Boolean
        Try
            nuev = CInt(nuevo.Text)
        Catch ex As Exception
            nuev = 0
        End Try
        If nuev = 0 Then
            MsgBox("Antes de continuar debe Ingresar el Corte a Crear.", MsgBoxStyle.Critical, "Por favor Revise !!!")
        End If
        ok = chequea_corte()
        If ok Then
            llena_corte()
            nuevo.Text = nuev
        End If
    End Sub
    Private Function chequea_corte() As Boolean
        Dim ok As Boolean = True
        Dim dt As New DataTable
        llena_tablas(dt, "SELECT * FROM CORTES WHERE CORTE = '" & nuevo.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            MsgBox("Este corte YA EXISTE !!!!!", MsgBoxStyle.Critical, "Por favor Revise.")
            ok = False
        End If
        Return ok
    End Function
    Private Sub llena_corte()
        Dim l As Integer = 1
        Dim i As Integer = 0
        Dim escala As String = ""
        llena_tablas(co, "SELECT CORTES.*,CPO_D.ESCALA, E_TALLAS.* ,SALA FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTES.CORTE = '" & corte.Text & "'", cnn)
        If co.Rows.Count > 0 Then
            dr = co.Rows(0)
            dj = dr
            cpo.Text = dr("CPO")
            estilo.Text = dr("ESTILO")
            colo.Text = dr("COLOR")
            seccion.Text = dr("SECCION")
            fg(1, 12) = dr("TOTAL")
            cliente = dr("CLIENTE")
            escala = dr("ESCALA")
            fcorte.Text = Format(dr("FPROD"), "dd/MM/yyyy")
            fg(1, 1) = corte.Text
            fg(2, 1) = nuevo.Text
            For i = 1 To 10
                If escala = "00" Then
                    dj(i + 24) = ts(i)
                End If
                fg(0, i + 1) = dj(i + 24)
                fg(1, i + 1) = dj(i + 5)
            Next
        End If
        llena_tablas(dt, "SELECT CAJA,CPO,ESTILO,COLOR,TIPO,TALLA,ORDEN,SUM(UNIDADES) AS PRENDAS  FROM CAJAS01 LEFT JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE WHERE CORTES.CORTE = '" & corte.Text & "' AND TIPO = 'P' AND UNIDADES > 0 GROUP BY CAJA,CPO,ESTILO,COLOR,TIPO,TALLA,ORDEN ORDER BY CAJA,TALLA,TIPO", cnn)
        cj.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            cj(l, 1) = dr("CAJA")
            cj(l, 2) = dr("CPO")
            cj(l, 3) = dr("ESTILO")
            cj(l, 4) = dr("COLOR")
            cj(l, 5) = dr("TIPO")
            cj(l, 6) = dr("TALLA")
            cj(l, 7) = dr("PRENDAS")
            cj(l, 8) = False
            cj(l, 9) = dr("ORDEN")
            l = l + 1
        Next
        habilita()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                nuevo.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                If CInt(nuevo.Text) > 0 Then
                    si.Focus()
                End If
            Catch
            End Try
        End If
    End Sub 'keypressed
    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Ejecutar la División?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            If fg.Rows.Count > 1 Then
                graba_datos()
                Close()
            End If
        Else
        End If

    End Sub
    Private Sub corteS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub
    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        limpia_variables()
        corte.Focus()
    End Sub
    '============================= Actualiza la Base de Datos =============================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim i As Integer
        Dim uni As String = ""
        Dim fechas As String = Format(Today, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            uni = ""
            For i = 2 To 12
                uni = uni + CStr(fg(2, i)) & "','"
            Next

            '==================== CORTES =========================================
            strsql = "INSERT INTO CORTES (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,FCORTE,FPROD,EXPORTADO,SECCION,BATCH) " &
             "VALUES ( '" & nuevo.Text & "','" &
                 dj("CLIENTE") & "','" &
                 dj("FPO") & "','" &
                 dj("CPO") & "','" &
                 dj("ESTILO") & "','" &
                 dj("COLOR") & "','" &
                 uni &
                 fechas & "','" &
                 fechas & "','N','" &
                 dj("SECCION") & "','" &
                 dj("BATCH") & "')"

            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO CORTES_S (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,F_ICORTE,ESTADO,BATCH,SALA) " &
                 "VALUES ( '" & nuevo.Text & "','" &
                 dj("CLIENTE") & "','" &
                 dj("FPO") & "','" &
                 dj("CPO") & "','" &
                 dj("ESTILO") & "','" &
                 dj("COLOR") & "','" &
                 uni &
                 fechas & "','C','" &
                 dj("BATCH") & "','" &
                 dj("SALA") & "')"

            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO CORTES_B (CORTE_MADRE,CORTE_NUEVO) VALUES ('" & corte.Text & "','" & nuevo.Text & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '====================  CAJAS  =========================================
            For i = 1 To cj.Rows.Count - 1
                If cj(i, 8) = True Then
                    strsql = "UPDATE CAJAS01 SET CORTE = '" & nuevo.Text & "', TIPO = 'P' WHERE CAJA = '" & cj(i, 1) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    strsql = "UPDATE CAJAS04 SET CORTE = '" & nuevo.Text & "', TIPO = 'P' WHERE CAJA = '" & cj(i, 1) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

            '=================== ACUMULADO ======================================
            strsql = "UPDATE CORTES SET XS = '" & fg(1, 2) & "'," &
                                        "S = '" & fg(1, 3) & "'," &
                                        "M = '" & fg(1, 4) & "'," &
                                        "L = '" & fg(1, 5) & "'," &
                                        "XL = '" & fg(1, 6) & "'," &
                                        "XL2 = '" & fg(1, 7) & "'," &
                                        "XL3 = '" & fg(1, 8) & "'," &
                                        "XL4 = '" & fg(1, 9) & "'," &
                                        "XL5 = '" & fg(1, 10) & "'," &
                                        "XL6 = '" & fg(1, 11) & "'," &
                                        "TOTAL = '" & fg(1, 12) & "' WHERE CORTE = '" & corte.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub cj_Click(sender As Object, e As EventArgs) Handles cj.AfterEdit
        Dim f As Integer = cj.RowSel
        Dim c As Integer = cj.ColSel
        Dim o As Integer = cj(f, 9)
        If c = 8 Then
            If cj(f, 8) = True Then
                If fg(1, o + 2) > 0 Then
                    quita_unidades(f, o)
                End If
            Else
                If fg(2, o + 2) > 0 Then
                    suma_unidades(f, o)
                End If
            End If
        End If
    End Sub
    Private Sub quita_unidades(ByVal f As Integer, ByVal o As Integer)
        fg(1, o + 2) = fg(1, o + 2) - cj(f, 7)
        fg(2, o + 2) = fg(2, o + 2) + cj(f, 7)
        fg(1, 12) = fg(1, 12) - cj(f, 7)
        fg(2, 12) = fg(2, 12) + cj(f, 7)
    End Sub
    Private Sub suma_unidades(ByVal f As Integer, ByVal o As Integer)
        fg(1, o + 2) = fg(1, o + 2) + cj(f, 7)
        fg(2, o + 2) = fg(2, o + 2) - cj(f, 7)
        fg(1, 12) = fg(1, 12) + cj(f, 7)
        fg(2, 12) = fg(2, 12) - cj(f, 7)
    End Sub

    Private Sub Corte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles corte.SelectedIndexChanged

    End Sub
End Class

