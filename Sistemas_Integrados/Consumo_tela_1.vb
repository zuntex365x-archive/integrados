Imports C1.Win.C1FlexGrid

Public Class Consumo_tela_1
    Inherits System.Windows.Forms.Form
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Sigue As System.Windows.Forms.Button
    Friend WithEvents Colo As System.Windows.Forms.ComboBox
    Friend WithEvents Estilo As System.Windows.Forms.ComboBox
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Graba As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Consumo_tela_1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.ComboBox()
        Me.Colo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sigue = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.co = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = "4,1,0,0,0,85,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:408;Name:""ESTILO"";Caption:""ESTILO"";AllowEditing:False;TextAlign:LeftCente" & _
        "r;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:459;Caption:""COLOR"";AllowEditing:False;For" & _
        "mat:""COLOR"";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:105;Caption" & _
        ":""ACTUALIZAR ?"";DataType:System.Boolean;TextAlign:CenterCenter;TextAlignFixed:Ce" & _
        "nterCenter;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 264)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 432)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;Border:Flat,1,Silve" & _
        "r,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:179, 236, 193;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:130, 223, 153;ForeC" & _
        "olor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search" & _
        "{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTota" & _
        "l{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackCo" & _
        "lor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeCo" & _
        "lor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{Back" & _
        "Color:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(912, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Graba, Me.Cliente, Me.Label1, Me.Estilo, Me.Colo, Me.Label2, Me.Label3, Me.Button3, Me.Sigue})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 96)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Bitmap)
        Me.Graba.Location = New System.Drawing.Point(952, 16)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 66
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        '
        'Cliente
        '
        Me.Cliente.BackColor = System.Drawing.Color.White
        Me.Cliente.ForeColor = System.Drawing.Color.Black
        Me.Cliente.Location = New System.Drawing.Point(168, 8)
        Me.Cliente.MaxLength = 25
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(232, 21)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Color")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.Black
        Me.Estilo.Location = New System.Drawing.Point(168, 32)
        Me.Estilo.MaxLength = 25
        Me.Estilo.Name = "Estilo"
        Me.Estilo.Size = New System.Drawing.Size(232, 21)
        Me.Estilo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Estilo, "Color")
        '
        'Colo
        '
        Me.Colo.BackColor = System.Drawing.Color.White
        Me.Colo.ForeColor = System.Drawing.Color.Black
        Me.Colo.Location = New System.Drawing.Point(168, 56)
        Me.Colo.MaxLength = 25
        Me.Colo.Name = "Colo"
        Me.Colo.Size = New System.Drawing.Size(232, 21)
        Me.Colo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Colo, "Color")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sigue
        '
        Me.Sigue.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sigue.ForeColor = System.Drawing.Color.Black
        Me.Sigue.Image = CType(resources.GetObject("Sigue.Image"), System.Drawing.Bitmap)
        Me.Sigue.Location = New System.Drawing.Point(872, 16)
        Me.Sigue.Name = "Sigue"
        Me.Sigue.Size = New System.Drawing.Size(35, 35)
        Me.Sigue.TabIndex = 3
        Me.Sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Sigue, "Presione este Boton para Buscar el Registro Seleccionado.")
        '
        'co
        '
        Me.co.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.co.AllowEditing = False
        Me.co.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.co.ColumnInfo = "6,1,0,0,0,85,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:80;Name:""CODIGO"";Caption:""CODIGO"";TextAlign:CenterCenter;TextAlignFixed:C" & _
        "enterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:400;Name:""DESCRIPCION"";Caption:""DESCRIPCION"";TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:190;Name:""COLOR"";Caption:""COLOR CPO""" & _
        ";DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width" & _
        ":190;Caption:""COLOR TELA"";DataType:System.String;TextAlign:LeftCenter;TextAlignF" & _
        "ixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Name:""CONSUMO"";Caption:""CONSUMO"";DataType:System.Decimal;For" & _
        "mat:""##,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.co.Location = New System.Drawing.Point(9, 104)
        Me.co.Name = "co"
        Me.co.Rows.DefaultSize = 17
        Me.co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.co.Size = New System.Drawing.Size(1000, 144)
        Me.co.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;Border:Flat,1,Silve" & _
        "r,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:240, 226, 191;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:255, 167, 79;ForeCo" & _
        "lor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{" & _
        "BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & _
        "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal" & _
        "{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackC" & _
        "olor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.co.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.co, "Area de Datos.")
        '
        'Consumo_tela_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1018, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.co, Me.GroupBox1, Me.fg})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consumo_tela_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copia consumo de telas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub consumo_tela_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        AddHandler Estilo.KeyPress, AddressOf keypressed2
        AddHandler Colo.KeyPress, AddressOf keypressed3
        llena_clientes(Cliente)
        Cliente.Items.Remove("TODOS")
        Try
            Cliente.SelectedIndex = 0
        Catch
        End Try
        setea_grid()
        limpia_variables()
    End Sub


    Private Sub setea_grid()
        co.Rows.Count = 1
        fg.Rows.Count = 1
        co.Rows(0).Height = 30
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT *,DESCRIPCION FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' AND COLOR_CPO = '" & Colo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        co.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            co(lineas, 1) = dr("CODIGO")
            co(lineas, 2) = dr("DESCRIPCION")
            co(lineas, 3) = dr("COLOR_CPO")
            co(lineas, 4) = dr("COLOR_TELA")
            co(lineas, 5) = dr("LIBRAS")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub llena_estilos()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT DISTINCT (ESTILO+COLOR),ESTILO,COLOR FROM CPO_D JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO = '" & Estilo.Text & "' ORDER BY ESTILO,COLOR"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            If Trim(dr("COLOR")) <> Trim(Colo.Text) Then
                lineas = fg.Rows.Count
                fg.Rows.Count = fg.Rows.Count + 1
                fg(lineas, 1) = dr("ESTILO")
                fg(lineas, 2) = dr("COLOR")
                fg(lineas, 3) = True
            End If
        Next
    End Sub

    Private Sub limpia_variables()
        Cliente.Enabled = True
        Estilo.Enabled = True
        Colo.Enabled = True
        Graba.Visible = False
        Sigue.Visible = True
        setea_grid()
        Estilo.Focus()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                Estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Estilo.Text) <> "" Then
                Colo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Colo.Text) <> "" Then
                Sigue.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sigue.Click
        llena_grid()
        llena_estilos()
        Graba.Visible = True
        Sigue.Visible = False
        Cliente.Enabled = False
        Estilo.Enabled = False
        Colo.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpia_variables()
    End Sub

    Private Sub busca_estilo()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim sp As String = "                         "
        Estilo.Items.Clear()
        Colo.Items.Clear()
        Dim estilos As String
        Dim i As Integer
        Dim strSQL As String = "SELECT DISTINCT ESTILO, COLOR  FROM CPO_D,CPO WHERE CPO.CPO = CPO_D.CPO AND CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            estilos = dr("ESTILO")
            i = Estilo.Items.IndexOf(estilos)
            If i < 0 Then
                Estilo.Items.Add(estilos)
            End If
        Next
        If Estilo.Items.Count > 0 Then
            Estilo.SelectedIndex = 0
        End If
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.SelectedIndexChanged
        busca_estilo()
    End Sub

    Private Sub llena_colores()
        Dim indice As Integer
        Dim strSQL As String = "SELECT DISTINCT COLOR FROM CPO_D WHERE ESTILO = '" & Estilo.Text & "' ORDER BY COLOR"
        llena_combos(Colo, strSQL, "COLOR")
        If Colo.Items.Count > 0 Then
            indice = Colo.Items.IndexOf(Colo.Text)
            If indice > 0 Then
                Colo.SelectedIndex = indice
            Else
                Colo.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Estilo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estilo.SelectedIndexChanged
        llena_colores()
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim seguro As MsgBoxResult
        If co.Rows.Count = 1 Then
            MsgBox("No puedo actualizar debido a que el Estilo-Color Maestro no tiene datos", MsgBoxStyle.Critical, "Por favor Revise !!!")
            Exit Sub
        End If
        seguro = MsgBox("Esta completamente Seguro de Querer Actualizar los Datos?  ", MsgBoxStyle.YesNo, "Actualizando Registros !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_datos()
            limpia_variables()
        End If
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim i As Integer
        Dim j As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim colort As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                If fg(i, 3) = True Then
                    strsql = "DELETE CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & fg(i, 1) & "' AND COLOR_CPO = '" & fg(i, 2) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    For j = 1 To co.Rows.Count - 1
                        colort = co(j, 4)
                        If co(j, 3) = co(j, 4) Then
                            colort = fg(i, 2)
                        Else
                            colort = co(j, 4)
                        End If
                        Try
                            strsql = "INSERT INTO CONSUMO_TELA (CLIENTE,ESTILO_CPO,COLOR_CPO,CODIGO,COLOR_TELA,LIBRAS) " & _
                                     "VALUES ('" & Cliente.Text & "','" & _
                                                   fg(i, 1) & "','" & _
                                                   fg(i, 2) & "','" & _
                                                   co(j, 1) & "','" & _
                                                   colort & "','" & _
                                                   co(j, 5) & "')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        Catch
                        End Try
                    Next j
                End If
            Next i

            transaccion.Commit()
        Catch e As Exception
            Try
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


    Private Sub cliente_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub


    Private Sub estilo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estilo.KeyPress
        AutoCompletar(Estilo, e)
    End Sub


    Private Sub colo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Colo.KeyPress
        AutoCompletar(Colo, e)
    End Sub

End Class
