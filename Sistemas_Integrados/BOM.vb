Imports C1.Win.C1FlexGrid

Public Class BOM
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "0000000000"
    Dim ok As Boolean
    Dim CODIGO As String
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim dt As New DataTable()
    Dim mt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents ec As C1.Win.C1FlexGrid.C1FlexGrid
    Dim lineas As Integer
    Dim empre As New empresas
    Dim clave As String
    Dim cliente As String
    Friend WithEvents estil As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents Timer1 As Timer
    Friend WithEvents Actualizar As Button
    Friend WithEvents MateNombre As ComboBox
    Dim ac As New DataTable
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Unidad As System.Windows.Forms.TextBox
    Friend WithEvents busca As System.Windows.Forms.Button
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    Friend WithEvents mate As System.Windows.Forms.ComboBox
    'Friend WithEvents Descripcion As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOM))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.MateNombre = New System.Windows.Forms.ComboBox()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.mate = New System.Windows.Forms.ComboBox()
        Me.busca = New System.Windows.Forms.Button()
        Me.Unidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ec = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo.SuspendLayout()
        CType(Me.ec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 439)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1130, 386)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'grupo
        '
        Me.grupo.BackColor = System.Drawing.Color.White
        Me.grupo.Controls.Add(Me.MateNombre)
        Me.grupo.Controls.Add(Me.Actualizar)
        Me.grupo.Controls.Add(Me.estil)
        Me.grupo.Controls.Add(Me.colo)
        Me.grupo.Controls.Add(Me.mate)
        Me.grupo.Controls.Add(Me.busca)
        Me.grupo.Controls.Add(Me.Unidad)
        Me.grupo.Controls.Add(Me.Label5)
        Me.grupo.Controls.Add(Me.Label4)
        Me.grupo.Controls.Add(Me.Label2)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Controls.Add(Me.Button2)
        Me.grupo.Controls.Add(Me.Button3)
        Me.grupo.Controls.Add(Me.Button1)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Black
        Me.grupo.Location = New System.Drawing.Point(9, 244)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(1130, 186)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'MateNombre
        '
        Me.MateNombre.ItemHeight = 17
        Me.MateNombre.Location = New System.Drawing.Point(367, 103)
        Me.MateNombre.MaxLength = 25
        Me.MateNombre.Name = "MateNombre"
        Me.MateNombre.Size = New System.Drawing.Size(523, 25)
        Me.MateNombre.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.MateNombre, "Color")
        '
        'Actualizar
        '
        Me.Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Actualizar.BackgroundImage = Global.Sistemas_Integrados.My.Resources.Resources.actualizar
        Me.Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar.Location = New System.Drawing.Point(1006, 86)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(46, 41)
        Me.Actualizar.TabIndex = 55
        Me.Actualizar.UseVisualStyleBackColor = False
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.White
        Me.estil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estil.Location = New System.Drawing.Point(196, 20)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(271, 29)
        Me.estil.TabIndex = 54
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Location = New System.Drawing.Point(195, 55)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(273, 30)
        Me.colo.TabIndex = 53
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mate
        '
        Me.mate.Location = New System.Drawing.Point(196, 102)
        Me.mate.MaxLength = 25
        Me.mate.Name = "mate"
        Me.mate.Size = New System.Drawing.Size(140, 25)
        Me.mate.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.mate, "Color")
        '
        'busca
        '
        Me.busca.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.busca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.busca.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busca.ForeColor = System.Drawing.Color.Black
        Me.busca.Image = CType(resources.GetObject("busca.Image"), System.Drawing.Image)
        Me.busca.Location = New System.Drawing.Point(896, 89)
        Me.busca.Name = "busca"
        Me.busca.Size = New System.Drawing.Size(41, 43)
        Me.busca.TabIndex = 49
        Me.busca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.busca, "Presione este boton para buscar Materiales.")
        Me.busca.UseVisualStyleBackColor = False
        '
        'Unidad
        '
        Me.Unidad.BackColor = System.Drawing.Color.White
        Me.Unidad.Location = New System.Drawing.Point(196, 138)
        Me.Unidad.MaxLength = 10
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Size = New System.Drawing.Size(131, 23)
        Me.Unidad.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Unidad, "Codigo del Material")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(19, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 29)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Cantidad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 30)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Material:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 30)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1006, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 43)
        Me.Button2.TabIndex = 21
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1053, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 43)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1006, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(9, 828)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(626, 20)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'ec
        '
        Me.ec.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ec.AllowEditing = False
        Me.ec.AllowFiltering = True
        Me.ec.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ec.ColumnInfo = resources.GetString("ec.ColumnInfo")
        Me.ec.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ec.Location = New System.Drawing.Point(16, 15)
        Me.ec.Name = "ec"
        Me.ec.Rows.DefaultSize = 17
        Me.ec.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ec.Size = New System.Drawing.Size(1023, 224)
        Me.ec.StyleInfo = resources.GetString("ec.StyleInfo")
        Me.ec.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.ec, "Area de Datos.")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1056, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 64)
        Me.Button4.TabIndex = 55
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Despliega Specs del Estilo")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'BOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1154, 853)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ec)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BOM"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOM"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        Me.grupo.PerformLayout()
        CType(Me.ec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler mate.KeyPress, AddressOf keypressed1
        AddHandler MateNombre.KeyPress, AddressOf keypressed1
        AddHandler Unidad.KeyPress, AddressOf keypressed2
        Dim dd As DataRow()
        Dim d As Integer = 0
        clave = empre.clave
        revisa_acceso_usuario(clave, ac)
        Try
            dd = ac.Select("CREACION_BOM = 'S'")
            d = dd.Length
        Catch
        End Try
        If ac.Rows.Count = 0 Or d = 0 Then
            MsgBox("Usted no tiene los Derechos Suficientes para Accesar este Programa", MsgBoxStyle.Critical, "ACCESO DENEGADO")
            Close()
        Else
            llena_tablas(mt, "SELECT * FROM MATERIALES WHERE ACTIVO = 'S'", cnn)
            Try
                With mate
                    .DataSource = mt
                    .DisplayMember = "CODIGO"
                    .ValueMember = "CODIGO"
                    .SelectedIndex = 0
                End With
                With MateNombre
                    .DataSource = mt
                    .DisplayMember = "DESCRIPCION"
                    .ValueMember = "DESCRIPCION"
                    .SelectedIndex = 0
                End With
            Catch
            End Try
            Try
                mate.SelectedIndex = 0
                MateNombre.SelectedIndex = 0
            Catch
            End Try
            setea_ec()
            limpia_variables()
            Try
                selecciona_ec(1)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub setea_ec()
        ec.Rows.Count = 1
        ec.Rows(0).Height = 30
        ec.Cols(0).Width = 5
        llena_ec()
    End Sub
    Private Sub llena_ec()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim clientes As String = ""
        Dim todos As Boolean = False
        Dim l As Integer = 1
        For Each dr In ac.Rows
            If dr("CREACION_BOM") = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    clientes = clientes + "'" & dr("CLIENTE") & "',"
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'C' ORDER BY CLIENTE,ESTILO,COLOR"
        Else
            If clientes.Length > 0 Then
                clientes = Mid(clientes, 1, clientes.Length - 1)
                strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO =  'C' AND CLIENTE IN (" & clientes & ")"
            End If
        End If
        llena_tablas(dt, strsql, cnn)
        ec.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            ec(l, 1) = dr("CLIENTE")
            ec(l, 2) = dr("ESTILO")
            ec(l, 3) = dr("COLOR")
            l = l + 1
        Next
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 6
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        setea_grid()
        ok = False
        Dim strSQL As String = "SELECT * FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("CODIGO")
            fg(lineas, 4) = dr("DESCRIPCION")
            fg(lineas, 5) = dr("UNIDAD")
            lineas = lineas + 1
        Next
        seleccion(1)
    End Sub

    Private Sub limpia_variables()
        Unidad.Text = ""
        mate.Enabled = True
        MateNombre.Enabled = True
        habilita(False)
        busca.Visible = True
    End Sub

    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            busca_material()
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Unidad.Text) <> "" Then
                Try
                    If CDec(Unidad.Text) > 0 Then
                        Button1.Focus()
                    End If
                Catch
                End Try
            End If
        End If
    End Sub 'keypressed

    Private Sub chequea_encabezado(ByRef ok As Boolean)
        Dim codigo As String
        Dim largo As Integer
        ok = True
        If Trim(mate.Text) = "" Then
            ok = False
            Exit Sub
        End If
        Try
            If Len(mate.Text) > 2 Then
                largo = 10 - Len(mate.Text)
                codigo = Mid(Z, 1, largo) + Trim(mate.Text)
                mate.Text = codigo
            Else
                ok = False
            End If
        Catch
            ok = False
        End Try
        If Not ok Then
            MsgBox("El codigo es un Campo Numérico, no nulo", MsgBoxStyle.Critical, "Codigo Incorrecto")
            Exit Sub
        End If
        If Not ok Then
            Exit Sub
        End If

    End Sub
    Private Sub habilita(ok As Boolean)
        Button1.Visible = ok
        Button2.Visible = Not ok
        Unidad.Enabled = ok
        busca.Visible = ok
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        otro_registro()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub busca_material()
        Dim strSQL As String = "SELECT * FROM MAT_EST_COL WHERE ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "' AND CODIGO = '" & mate.Text & "'"
        Dim dr As DataRow
        mate.Enabled = False
        MateNombre.Enabled = False
        Unidad.ReadOnly = False
        dt = New DataTable()
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            Unidad.Text = dr("UNIDAD")
        Next
        If dt.Rows.Count > 0 Then
            habilita(False)
        Else
            habilita(True)
        End If
        mate.Enabled = False
        MateNombre.Enabled = False
        Unidad.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ok = True
        revisa_detalle(ok)
        If ok Then
            graba_registros()
            otro_registro()
        End If
    End Sub

    Private Sub revisa_detalle(ByRef ok As Boolean)
        ok = True
        Try
            Unidad.Text = CDec(Unidad.Text)
            If Unidad.Text = 0 Then
                mensaje("El dato de las unidades debe ser un número mayor que 0.")
                ok = False
            End If
        Catch
            ok = False
        End Try
    End Sub
    Private Sub otro_registro()
        setea_grid()
        llena_grid()
        limpia_variables()
        mate.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
        End If
        otro_registro()
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        Dim dato As String
        If fil > 0 And fil < fg.Rows.Count Then
            dato = fg(fil, 3)
            mate.SelectedIndex = mate.FindString(fg(fil, 3))
            busca_material()
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

    Private Sub busca_linea(ByRef linea As Integer)
        Dim i As Integer
        Dim buscar As String = Trim(estil.Text) + Trim(colo.Text) + Trim(mate.Text)
        linea = 0
        For i = 1 To fg.Rows.Count - 1
            If buscar = Trim(fg(i, 1)) + Trim(fg(i, 2)) + Trim(fg(i, 3)) Then
                linea = i
                Exit For
            End If
        Next
    End Sub

    Private Sub busca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles busca.Click
        Dim forma As New Consulta_materiales
        forma.cliente = cliente
        forma.ShowDialog()
        If forma.selec <> "" Then
            mate.Text = forma.selec
            busca_material()
        End If
    End Sub
    Private Sub mate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mate.KeyPress
        AutoCompletar(mate, e)
    End Sub
    Private Sub MateNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MateNombre.KeyPress
        AutoCompletar(MateNombre, e)
    End Sub
    Private Sub Colo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena_grid()
    End Sub

    Private Sub mate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mate.SelectedIndexChanged
        Dim dr As DataRow
        Try
            dr = mt.Rows(mate.SelectedIndex)
            'Descripcion.Text = dr("DESCRIPCION")
        Catch
        End Try
    End Sub

    REM =======================================================================================
    REM =                                                                                     =
    REM =                      GRABACIONES                                                    =
    REM =                                                                                     =
    REM =======================================================================================

    Private Sub graba_registros()
        Dim afectados As Integer
        Dim vitacora As Integer
        Dim strsql As String
        Dim tipo As String = "N"
        Dim obj As New empresas()
        Dim fechas As String = Format(Now, "yyyy-MM-dd hh:mm:ss") + ".000"
        Dim cliente As String = ec(ec.RowSel, 1)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '============== actualiza  =======================
            strsql = "UPDATE MAT_EST_COL SET UNIDAD = " & "'" & Unidad.Text & "'" &
                            " WHERE ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "' AND CODIGO = '" & mate.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados > 0 Then
                strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & estil.Text & "','" & colo.Text & "','" & mate.Text & "',GETDATE() ,'" & obj.usuario & "','" & Unidad.Text & "','M')"
                comando.CommandText = strsql
                vitacora = comando.ExecuteNonQuery()
            End If

            '=============== Graba nuevos ====================
            If afectados = 0 Then
                If Mid(mate.Text, 1, 2) = "99" Then
                    tipo = "E"
                Else
                    If Mid(mate.Text, 9, 2) > "00" Then
                        tipo = "T"
                    End If
                End If
                strsql = "INSERT INTO MAT_EST_COL (ESTILO,COLOR,CODIGO,UNIDAD,TIPO) " &
                                       "VALUES ( '" & estil.Text & "','" &
                                           colo.Text & "','" &
                                           mate.Text & "','" &
                                           Unidad.Text & "','" & tipo & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & estil.Text & "','" & colo.Text & "','" & mate.Text & "',GETDATE() ,'" & obj.usuario & "','" & Unidad.Text & "','A')"
                comando.CommandText = strsql
                vitacora = comando.ExecuteNonQuery()
            End If
            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    REM =======================================================================================
    REM =                                                                                     =
    REM =                     ELIMINA REGISTSRO                                               =
    REM =                                                                                     =
    REM =======================================================================================
    Private Sub elimina()
        Dim afectados As Integer
        Dim strsql As String
        Dim obj As New empresas()
        Dim fechas As String = Format(Now, "yyyy-MM-dd hh:mm:ss")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '============== ELIMINA  =======================
            strsql = "DELETE FROM MAT_EST_COL WHERE ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "' AND CODIGO = '" & mate.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & estil.Text & "','" & colo.Text & "','" & mate.Text & "',GETDATE(),'" & obj.usuario & "','" & Unidad.Text & "','E')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub ec_Click(sender As System.Object, e As System.EventArgs) Handles ec.Click
        Dim f As Integer = ec.RowSel
        selecciona_ec(f)
    End Sub

    Private Sub ec_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ec.KeyDown
        If e.KeyCode = Keys.Up Then
            selecciona_ec(ec.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            selecciona_ec(ec.Row + 1)
        End If
    End Sub

    Private Sub selecciona_ec(ByVal f As Integer)
        If f > 0 Then
            Try
                cliente = ec(f, 1)
                estil.Text = ec(f, 2)
                colo.Text = ec(f, 3)
                setea_grid()
                llena_grid()
            Catch
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            despliega_spec(ec(ec.RowSel, 1), ec(ec.RowSel, 2))
        Catch
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        llena_grid()
    End Sub

    Private Sub MateNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MateNombre.SelectedIndexChanged

    End Sub
End Class
