Imports C1.Win.C1FlexGrid

Public Class Push01
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
    Friend WithEvents es As C1.Win.C1FlexGrid.C1FlexGrid
    Dim lineas As Integer
    Dim empre As New empresas
    Dim clave As String
    Friend WithEvents estil As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents tt As C1.Win.C1FlexGrid.C1FlexGrid
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Push01))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.cpo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sigue = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.es = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo.SuspendLayout()
        CType(Me.es, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(6, 447)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1029, 196)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(926, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(967, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'grupo
        '
        Me.grupo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grupo.Controls.Add(Me.cpo)
        Me.grupo.Controls.Add(Me.Label6)
        Me.grupo.Controls.Add(Me.Fecha)
        Me.grupo.Controls.Add(Me.estil)
        Me.grupo.Controls.Add(Me.colo)
        Me.grupo.Controls.Add(Me.Label4)
        Me.grupo.Controls.Add(Me.Label2)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Controls.Add(Me.Button3)
        Me.grupo.Controls.Add(Me.sigue)
        Me.grupo.Controls.Add(Me.Button1)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Black
        Me.grupo.Location = New System.Drawing.Point(8, 257)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(1027, 120)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cpo.Location = New System.Drawing.Point(168, 19)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(273, 24)
        Me.cpo.TabIndex = 68
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Cpo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy"
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha.Location = New System.Drawing.Point(742, 21)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(112, 22)
        Me.Fecha.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.Fecha, "Fecha desde donde comienza la búsqueda de Documentos.")
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.White
        Me.estil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estil.Location = New System.Drawing.Point(168, 49)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(273, 24)
        Me.estil.TabIndex = 54
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Location = New System.Drawing.Point(167, 79)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(275, 24)
        Me.colo.TabIndex = 53
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(591, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Fecha Push_Out:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(926, 16)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 69
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'es
        '
        Me.es.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.es.AllowEditing = False
        Me.es.AllowFiltering = True
        Me.es.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.es.ColumnInfo = resources.GetString("es.ColumnInfo")
        Me.es.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.es.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.es.Location = New System.Drawing.Point(8, 60)
        Me.es.Name = "es"
        Me.es.Rows.DefaultSize = 19
        Me.es.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.es.Size = New System.Drawing.Size(1027, 196)
        Me.es.StyleInfo = resources.GetString("es.StyleInfo")
        Me.es.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.es, "Area de Datos.")
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.cliente.Location = New System.Drawing.Point(189, 21)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(342, 28)
        Me.cliente.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.cliente, "No. Embarque")
        '
        'ta
        '
        Me.ta.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ta.AllowEditing = False
        Me.ta.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ta.ColumnInfo = resources.GetString("ta.ColumnInfo")
        Me.ta.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ta.ForeColor = System.Drawing.Color.Black
        Me.ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.ta.Location = New System.Drawing.Point(6, 383)
        Me.ta.Name = "ta"
        Me.ta.Rows.DefaultSize = 19
        Me.ta.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ta.Size = New System.Drawing.Size(1029, 58)
        Me.ta.StyleInfo = resources.GetString("ta.StyleInfo")
        Me.ta.TabIndex = 97
        Me.ToolTip1.SetToolTip(Me.ta, "Area de Datos.")
        '
        'tt
        '
        Me.tt.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.tt.AllowEditing = False
        Me.tt.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.tt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tt.ColumnInfo = resources.GetString("tt.ColumnInfo")
        Me.tt.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.tt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tt.ForeColor = System.Drawing.Color.Black
        Me.tt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.tt.Location = New System.Drawing.Point(99, 643)
        Me.tt.Name = "tt"
        Me.tt.Rows.Count = 1
        Me.tt.Rows.DefaultSize = 19
        Me.tt.Rows.Fixed = 0
        Me.tt.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.tt.Size = New System.Drawing.Size(917, 24)
        Me.tt.StyleInfo = resources.GetString("tt.StyleInfo")
        Me.tt.TabIndex = 98
        Me.ToolTip1.SetToolTip(Me.tt, "Area de Datos.")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 32)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Cliente:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Push01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 696)
        Me.Controls.Add(Me.tt)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.es)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Push01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Push - Out"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        CType(Me.es, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Fecha.KeyPress, AddressOf keypressed1
        Dim l As Integer
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        l = cliente.Items.IndexOf("THE NORTH FACE")
        If l > 0 Then
            cliente.SelectedIndex = l
        End If
        setea_es()
        setea_ta()
        setea_fg()
    End Sub
    Private Sub setea_es()
        es.Rows.Count = 1
        es.Rows(0).Height = 30
        es.Cols(0).Width = 0
        llena_ec()
    End Sub
    Private Sub setea_ta()
        ta.Rows.Count = 2
        ta.Rows(0).Height = 30
        ta.Cols(0).Width = 0
        llena_ta()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Cols(0).Width = 0
    End Sub
    Private Sub setea_tt()
        Dim i As Integer
        For i = 1 To 10
            tt(0, i) = 0
        Next
    End Sub
    Private Sub llena_ec()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim clientes As String = ""
        Dim todos As Boolean = False
        Dim l As Integer = 1
        strsql = "SELECT * FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & cliente.Text & "' AND ESTADO = 'A'"
        llena_tablas(dt, strsql, cnn)
        es.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            es(l, 1) = dr("CPO")
            es(l, 2) = dr("ESTILO")
            es(l, 3) = dr("COLOR")
            es(l, 4) = dr("ESCALA")
            l = l + 1
        Next
        setea_ta()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 6
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_ta()
        Dim l As Integer = es.RowSel
        Dim cpos As String = es(l, 1)
        Dim estilo As String = es(l, 2)
        Dim col As String = es(l, 3)
        Dim dr As DataRow
        estil.Text = estilo
        colo.Text = col
        cpo.Text = cpos
        Dim strSQL As String = "SELECT * FROM CPO_D LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR ='" & col & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            For l = 3 To 12
                ta(0, l - 1) = dr(21 + l)
                fg(0, l - 1) = dr(21 + l)
                ta(1, l - 1) = dr(l)
            Next
        End If
    End Sub
    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
        End If
    End Sub 'keypressed

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        setea_tt()
        setea_fg()
        sigue.Visible = True
        otro_registro()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
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
        Dim f As Integer
        Dim c As Integer
        Dim t As Integer
        Dim i As Integer = fg.Rows.Count - 1
        For f = 1 To i
            Try
                t = 0
                For c = 1 To 10
                    If fg(f, c + 1) = Nothing Then
                        fg(f, c + 1) = 0
                    End If
                    t = t + fg(f, c + 1)
                Next
                If t = 0 Or fg(f, 1) = Nothing Then
                    fg.Rows.Remove(f)
                    f = f - 1
                End If
            Catch
            End Try
        Next
        llena_tt()
        t = 0
        For i = 1 To 10
            t = t + tt(0, i) - ta(1, i + 1)
        Next
        If t <> 0 Then
            MsgBox("Error en unidades.  La suma de los Push Out no coinciden con el total de la PO", MsgBoxStyle.Critical, "Por favor revise !!!")
            Button1.Visible = True
            fg.Rows.Count = 12
            llena_tt()
            ok = False
        End If

    End Sub
    Private Sub llena_tt()
        Dim f As Integer
        Dim c As Integer
        setea_tt()
        For f = 1 To fg.Rows.Count - 1
            For c = 1 To 10
                tt(0, c) = tt(0, c) + fg(f, c + 1)
            Next
        Next

    End Sub
    Private Sub otro_registro()
        cliente.Enabled = True
        es.Enabled = True
        sigue.Visible = True
        Fecha.Enabled = True
        setea_ta()
        setea_tt()
        setea_fg()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
        End If
        otro_registro()
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub
    Private Sub fg_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.CellChanged
        llena_tt()
    End Sub
    Private Sub seleccion(ByVal fil As Integer)
        Dim dato As String
        If fil > 0 And fil < fg.Rows.Count Then
            dato = fg(fil, 3)
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
        Dim buscar As String = Trim(estil.Text) + Trim(colo.Text)
        linea = 0
        For i = 1 To fg.Rows.Count - 1
            If buscar = Trim(fg(i, 1)) + Trim(fg(i, 2)) + Trim(fg(i, 3)) Then
                linea = i
                Exit For
            End If
        Next
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub ec_Click(sender As System.Object, e As System.EventArgs) Handles es.Click
        Dim f As Integer = es.RowSel
        selecciona_ec(f)
    End Sub

    Private Sub ec_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles es.KeyDown
        Dim f As Integer = es.RowSel
        If e.KeyCode = Keys.Up Then
            es.RowSel = es.Row - 1
            selecciona_ec(es.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            Try
                es.RowSel = es.Row + 1
                selecciona_ec(es.Row + 1)
            Catch
            End Try

        End If
    End Sub

    Private Sub selecciona_ec(ByVal f As Integer)
        If f > 0 Then
            Try
                cpo.Text = es(f, 1)
                estil.Text = es(f, 2)
                colo.Text = es(f, 3)
                setea_ta()
            Catch
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Try
            despliega_spec(es(es.RowSel, 1), es(es.RowSel, 2))
        Catch
        End Try
    End Sub

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        setea_es()
    End Sub

    Private Sub sigue_Click(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        proceso()
        sigue.Visible = False
        Button1.Visible = True
        es.Enabled = False
        cliente.Enabled = False
        Fecha.Enabled = False
    End Sub
    Private Sub proceso()
        fg.Rows.Count = 1
        fg.Rows.Count = 12
        revisa_grabado()
        fg.Focus()
    End Sub
    Private Sub revisa_grabado()
        Dim l As Integer = 1
        Dim j As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM PUSH01 WHERE CLIENTE = '" & cliente.Text & "' AND CPO ='" & cpo.Text & "' AND ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "' AND FECHA_P = '" & Format(Fecha.Value, "yyyy-MM-dd") & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            fg(l, 1) = dr("FECHA_E")
            For j = 1 To 10
                fg(l, j + 1) = dr(j + 5)
            Next
            l = l + 1
        Next
    End Sub

    REM =======================================================================================
    REM =                                                                                     =
    REM =                      GRABACIONES                                                    =
    REM =                                                                                     =
    REM =======================================================================================

    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strsql As String
        Dim i As Integer
        Dim obj As New empresas()
        Dim fechas As String = Format(Fecha.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ''============== actualiza  =======================
            strsql = "DELETE PUSH01 WHERE CLIENTE = '" & cliente.Text & "' AND CPO = '" & cpo.Text & "' AND ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "' AND FECHA_P = '" & fechas & "'"

            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                strsql = "INSERT INTO PUSH01 (CLIENTE,CPO,ESTILO,COLOR,FECHA_P,FECHA_E,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0,USUARIO,FECHA_ACT) " & _
                                       "VALUES ( '" & cliente.Text & "','" & _
                                                      cpo.Text & "','" & _
                                                      estil.Text & "','" & _
                                                      colo.Text & "','" & fechas & "','" & _
                                                      Format(fg(i, 1), "yyyy-MM-dd") & "','" & _
                                                      fg(i, 2) & "','" & _
                                                      fg(i, 3) & "','" & _
                                                      fg(i, 4) & "','" & _
                                                      fg(i, 5) & "','" & _
                                                      fg(i, 6) & "','" & _
                                                      fg(i, 7) & "','" & _
                                                      fg(i, 8) & "','" & _
                                                      fg(i, 9) & "','" & _
                                                      fg(i, 10) & "','" & _
                                                      fg(i, 11) & "','" & _
                                                      obj.usuario & "',GETDATE() )"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

            Next
            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub Fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Fecha.ValueChanged
        chequea_fecha()
    End Sub

    Private Sub chequea_fecha()
        Dim dia As Date = Today
        Dim dias As Integer = Today.DayOfWeek
        Dim min As Date = dia.AddDays(-3)
        If FECHA.Value < min Then
            FECHA.Value = min
        End If
        If FECHA.Value > Today Then
            FECHA.Value = Today
        End If
    End Sub
End Class
