Imports C1.Win.C1FlexGrid

Public Class Push03
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim dt As New DataTable()
    Dim mt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents es As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents estil As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fechap As System.Windows.Forms.Label
    Dim hoy As Date
    Dim cliente As String
    Dim fecha_p As Date
    Dim fecha As String
    Dim ta As New DataTable

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Push03))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.fechap = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.es = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo.SuspendLayout()
        CType(Me.es, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(6, 488)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1029, 196)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'grupo
        '
        Me.grupo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grupo.Controls.Add(Me.fechap)
        Me.grupo.Controls.Add(Me.cpo)
        Me.grupo.Controls.Add(Me.Label6)
        Me.grupo.Controls.Add(Me.estil)
        Me.grupo.Controls.Add(Me.colo)
        Me.grupo.Controls.Add(Me.Label4)
        Me.grupo.Controls.Add(Me.Label2)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Black
        Me.grupo.Location = New System.Drawing.Point(8, 364)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(1027, 120)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'fechap
        '
        Me.fechap.BackColor = System.Drawing.Color.White
        Me.fechap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fechap.Location = New System.Drawing.Point(741, 19)
        Me.fechap.Name = "fechap"
        Me.fechap.Size = New System.Drawing.Size(150, 24)
        Me.fechap.TabIndex = 70
        Me.fechap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'es
        '
        Me.es.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.es.AllowEditing = False
        Me.es.AllowFiltering = True
        Me.es.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.es.ColumnInfo = resources.GetString("es.ColumnInfo")
        Me.es.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.es.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.es.Location = New System.Drawing.Point(8, 12)
        Me.es.Name = "es"
        Me.es.Rows.DefaultSize = 19
        Me.es.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.es.Size = New System.Drawing.Size(1027, 323)
        Me.es.StyleInfo = resources.GetString("es.StyleInfo")
        Me.es.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.es, "Area de Datos.")
        '
        'Push03
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 696)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.es)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Push03"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Push - Out"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        CType(Me.es, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fecha As String = Format(Today, "yyyy-MM-dd")
        llena_tallas()
        setea_es()
    End Sub
    Private Sub llena_tallas()
        Dim strsql As String
        ta = New DataTable
        strsql = "SELECT * FROM E_TALLAS LEFT JOIN CPO_D ON E_TALLAS.ESCALA = CPO_D.ESCALA WHERE ESTADO = 'A'"
        llena_tablas(ta, strsql, cnn)
    End Sub
    Private Sub setea_es()
        es.Rows.Count = 1
        es.Rows(0).Height = 30
        es.Cols(0).Width = 0
        llena_ec()
    End Sub
    Private Sub setea_fg()
        Dim dd As DataRow()
        Dim dr As DataRow = Nothing
        Dim f As Integer = es.RowSel
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Cols(0).Width = 0

        dd = ta.Select("CPO = '" & es(f, 2) & "' AND ESTILO = '" & es(f, 3) & "' AND COLOR = '" & es(f, 4) & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            For f = 2 To 11
                fg(0, f) = dr(f)
            Next
        End If

    End Sub
    Private Sub llena_ec()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim clientes As String = ""
        Dim l As Integer = 1
        strsql = "SELECT CLIENTE,CPO,ESTILO,COLOR,FECHA_P,SUM(T0) AS T0 FROM PUSH01 WHERE CPO + ESTILO + COLOR IN (SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A')  GROUP BY CLIENTE,CPO,ESTILO,COLOR,FECHA_P ORDER BY CLIENTE,CPO,ESTILO,COLOR,FECHA_P"
        llena_tablas(dt, strsql, cnn)
        es.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            es(l, 1) = dr("CLIENTE")
            es(l, 2) = dr("CPO")
            es(l, 3) = dr("ESTILO")
            es(l, 4) = dr("COLOR")
            es(l, 5) = dr("FECHA_P")
            l = l + 1
        Next
        If dt.Rows.Count > 0 Then
            es.Focus()
            es.RowSel = 1
            selecciona_ec(1)

        End If
    End Sub

    Private Sub setea_grid()
        Dim dd As DataRow()
        Dim dr As DataRow = Nothing
        Dim f As Integer = es.RowSel
        fg.Rows.Count = 1
        fg.Cols.Count = 6
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        dd = ta.Select("CPO = '" & es(f, 2) & "' AND ESTILO = '" & es(f, 3) & "' AND COLOR = '" & es(f, 4) & "'")
        If dd.Length > 0 Then
            dr = dd(0)
        End If
        For f = 2 To 11
            fg(0, f) = dr(f)
        Next
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        Dim dato As String
        If fil > 0 And fil < fg.Rows.Count Then
            dato = fg(fil, 3)
        End If
    End Sub


    Private Sub ec_Click(sender As System.Object, e As System.EventArgs) Handles es.Click
        Dim f As Integer = es.RowSel
        selecciona_ec(f)
    End Sub

    Private Sub ec_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles es.KeyDown
        Dim f As Integer = es.RowSel
        If e.KeyCode = Keys.Up Then
            Try
                es.RowSel = es.Row - 1
                selecciona_ec(es.Row - 1)
            Catch
            End Try

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
                cliente = es(f, 1)
                cpo.Text = es(f, 2)
                estil.Text = es(f, 3)
                colo.Text = es(f, 4)
                fecha_p = es(f, 5)
                fechap.Text = Format(es(f, 5), "dd/MMM/yyyy")
                setea_fg()
                revisa_grabado()
            Catch
            End Try
        End If
    End Sub

    Private Sub revisa_grabado()
        Dim l As Integer = 1
        Dim j As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM PUSH01 WHERE CLIENTE = '" & cliente & "' AND CPO ='" & cpo.Text & "' AND ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "' AND FECHA_P = '" & Format(fecha_p, "yyyy-MM-dd") & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("FECHA_E")
            For j = 1 To 10
                fg(l, j + 1) = dr(j + 5)
            Next
            l = l + 1
        Next
    End Sub
End Class
