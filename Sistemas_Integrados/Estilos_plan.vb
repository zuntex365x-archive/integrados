Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Estilos_plan
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dificultad As C1.Win.C1Input.C1TextBox
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents categoria As C1.Win.C1Input.C1TextBox
    Friend WithEvents subcategoria As C1.Win.C1Input.C1TextBox
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents excel As Button
    Dim dr As DataRow
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
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estilos_plan))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.regresa = New System.Windows.Forms.Button()
        Me.Elimina = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.sigue = New System.Windows.Forms.Button()
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dificultad = New C1.Win.C1Input.C1TextBox()
        Me.graba = New System.Windows.Forms.Button()
        Me.categoria = New C1.Win.C1Input.C1TextBox()
        Me.subcategoria = New C1.Win.C1Input.C1TextBox()
        Me.excel = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dificultad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(960, 10)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 67
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Elimina
        '
        Me.Elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina.ForeColor = System.Drawing.Color.Black
        Me.Elimina.Image = CType(resources.GetObject("Elimina.Image"), System.Drawing.Image)
        Me.Elimina.Location = New System.Drawing.Point(835, 10)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(60, 40)
        Me.Elimina.TabIndex = 68
        Me.Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina, "Elimina Registros")
        Me.Elimina.UseVisualStyleBackColor = False
        Me.Elimina.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 189)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 475)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'cliente
        '
        Me.cliente.Items.AddRange(New Object() {"1", "2"})
        Me.cliente.Location = New System.Drawing.Point(177, 10)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(231, 24)
        Me.cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cliente, "Nomina")
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(898, 67)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 3
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Chequeo de Datos")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'estilo
        '
        Me.estilo.Items.AddRange(New Object() {"1", "2"})
        Me.estilo.Location = New System.Drawing.Point(177, 40)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(231, 24)
        Me.estilo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.estilo, "Nomina")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 672)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Para Seleccionar un Registro  presione doble click en el Mouse."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 24)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Estilo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Categoría:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Dificultad:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 24)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Sub-Categoría:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dificultad
        '
        Me.dificultad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dificultad.CustomFormat = "##0"
        Me.dificultad.DataType = GetType(Integer)
        Me.dificultad.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.dificultad.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dificultad.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dificultad.Location = New System.Drawing.Point(177, 85)
        Me.dificultad.MaxLength = 3
        Me.dificultad.Name = "dificultad"
        Me.dificultad.PostValidation.ErrorMessage = "Por favor ingrese un número entre 1 y 900."
        Me.dificultad.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.dificultad.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(1, 900, True, True)})
        Me.dificultad.Size = New System.Drawing.Size(231, 22)
        Me.dificultad.TabIndex = 4
        Me.dificultad.Tag = Nothing
        Me.dificultad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dificultad.TrimStart = True
        Me.dificultad.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(898, 10)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 7
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        Me.graba.Visible = False
        '
        'categoria
        '
        Me.categoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.categoria.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoria.Location = New System.Drawing.Point(177, 112)
        Me.categoria.MaxLength = 20
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(393, 22)
        Me.categoria.TabIndex = 5
        Me.categoria.Tag = Nothing
        Me.categoria.TrimStart = True
        Me.categoria.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'subcategoria
        '
        Me.subcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.subcategoria.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subcategoria.Location = New System.Drawing.Point(177, 137)
        Me.subcategoria.MaxLength = 20
        Me.subcategoria.Name = "subcategoria"
        Me.subcategoria.Size = New System.Drawing.Size(393, 22)
        Me.subcategoria.TabIndex = 6
        Me.subcategoria.Tag = Nothing
        Me.subcategoria.TrimStart = True
        Me.subcategoria.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Image)
        Me.excel.Location = New System.Drawing.Point(783, 10)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(46, 40)
        Me.excel.TabIndex = 88
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.UseVisualStyleBackColor = False
        Me.excel.Visible = False
        '
        'Estilos_plan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1023, 696)
        Me.Controls.Add(Me.excel)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.subcategoria)
        Me.Controls.Add(Me.categoria)
        Me.Controls.Add(Me.dificultad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estilos_plan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecciones"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dificultad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tipos_cobro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler estilo.KeyPress, AddressOf keypressed2
        AddHandler dificultad.KeyPress, AddressOf keypressed3
        AddHandler categoria.KeyPress, AddressOf keypressed4
        AddHandler subcategoria.KeyPress, AddressOf keypressed5
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        limpia_variables()
        cliente.Focus()
    End Sub
    Private Sub limpia_variables()
        categoria.Value = ""
        subcategoria.Value = ""
        dificultad.Value = "100"
        cliente.Enabled = True
        estilo.Enabled = True
        dificultad.Enabled = False
        categoria.Enabled = False
        subcategoria.Enabled = False
        Elimina.Visible = False
        graba.Visible = False
        sigue.Visible = True
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_fg()
    End Sub
    Private Sub llena_fg()
        Dim l As Integer
        llena_tablas(dt, "SELECT * FROM PLAN_COSTURA_E WHERE CLIENTE = '" & cliente.Text & "'", cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("DIFICULTAD")
            fg(l, 4) = dr("CATEGORIA")
            fg(l, 5) = dr("SUB_CATEGORIA")
            l = l + 1
        Next
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    Private Sub estilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estilo.KeyPress
        AutoCompletar(estilo, e)
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub
    Private Sub selecciona_registro()
        Dim i As Integer = fg.RowSel
        cliente.SelectedIndex = cliente.Items.IndexOf(fg(i, 1))
        estilo.SelectedIndex = estilo.Items.IndexOf(fg(i, 2))
        dificultad.Value = fg(i, 3)
        categoria.Value = fg(i, 4)
        subcategoria.Value = fg(i, 5)
        busca_estilo()
        graba.Visible = True
        Elimina.Visible = True
    End Sub

    Private Sub busca_estilo()
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM PLAN_COSTURA_E WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            dificultad.Value = dr("DIFICULTAD")
            categoria.Value = dr("CATEGORIA")
            subcategoria.Value = dr("SUB_CATEGORIA")
            Elimina.Visible = True
        End If
        habilita()
    End Sub
    Private Sub habilita()
        cliente.Enabled = False
        estilo.Enabled = False
        dificultad.Enabled = True
        categoria.Enabled = True
        subcategoria.Enabled = True
        graba.Visible = True
        regresa.Visible = True
        sigue.Visible = False
        excel.Visible = True
        dificultad.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(estilo.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(9) Then
            e.Handled = True
            If Trim(dificultad.Text) <> "" Then
                categoria.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(9) Then
            e.Handled = True
            If Trim(categoria.Text) <> "" Then
                subcategoria.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Or e.KeyChar = Microsoft.VisualBasic.ChrW(9) Then
            e.Handled = True
            If Trim(subcategoria.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub revisa_datos(ByRef ok As Boolean)
        If categoria.Value = "" Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar todos los datos solicitados", MsgBoxStyle.Critical, "Por favor revise !!!!")
        Else
            ok = True
        End If
    End Sub
    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE PLAN_COSTURA_E SET DIFICULTAD = '" & dificultad.Value & "', " &
                                         "CATEGORIA = '" & categoria.Value & "', " &
                                         "SUB_CATEGORIA = '" & subcategoria.Value & "' " &
                                          "WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO PLAN_COSTURA_E (CLIENTE,ESTILO,DIFICULTAD,CATEGORIA,SUB_CATEGORIA) VALUES ('" &
                                                    cliente.Text & "','" &
                                                    estilo.Text & "','" &
                                                    dificultad.Value & "','" &
                                                    categoria.Value & "','" &
                                                    subcategoria.Value & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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
    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM PLAN_COSTURA_E WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. Posiblemente tiene movimiento. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        limpia_variables()
        estilo.Focus()
    End Sub

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        limpia_variables()
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            limpia_variables()
            estilo.Focus()
        End If
    End Sub

    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        busca_estilo()
    End Sub

    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(estilo, "SELECT DISTINCT ESTILO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", "ESTILO")
        Try
            estilo.SelectedIndex = 0
            setea_fg()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub excel_Click_1(sender As Object, e As EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\estilos_plan.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
End Class

