Imports C1.Win.C1FlexGrid
Imports System.Net.Mail
Imports System.IO

Public Class BOM_Consulta
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOM_Consulta))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ec = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 342)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(974, 342)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'grupo
        '
        Me.grupo.BackColor = System.Drawing.Color.White
        Me.grupo.Controls.Add(Me.estil)
        Me.grupo.Controls.Add(Me.colo)
        Me.grupo.Controls.Add(Me.Label2)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Black
        Me.grupo.Location = New System.Drawing.Point(8, 233)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(968, 103)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.White
        Me.estil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estil.Location = New System.Drawing.Point(169, 27)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(232, 24)
        Me.estil.TabIndex = 54
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Location = New System.Drawing.Point(167, 56)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(234, 24)
        Me.colo.TabIndex = 53
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(14, 220)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
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
        Me.ec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ec.Location = New System.Drawing.Point(14, 12)
        Me.ec.Name = "ec"
        Me.ec.Rows.DefaultSize = 17
        Me.ec.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ec.Size = New System.Drawing.Size(877, 205)
        Me.ec.StyleInfo = resources.GetString("ec.StyleInfo")
        Me.ec.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ec, "Area de Datos.")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(902, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 56
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Despliega Specs del Estilo")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BOM_Consulta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 696)
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
        Me.Name = "BOM_Consulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de BOM"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        CType(Me.ec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_ec()
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
        strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'A' ORDER BY CLIENTE,ESTILO,COLOR"
        llena_tablas(dt, strsql, cnn)
        ec.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            ec(l, 1) = dr("CLIENTE")
            ec(l, 2) = dr("ESTILO")
            ec(l, 3) = dr("COLOR")
            l = l + 1
        Next
    selecciona_ec(1)
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CODIGO")
            fg(lineas, 2) = dr("DESCRIPCION")
            fg(lineas, 3) = dr("UNIDAD")
            lineas = lineas + 1
        Next

    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub ec_Click(sender As System.Object, e As System.EventArgs) Handles ec.Click
        Dim f As Integer = ec.RowSel
        selecciona_ec(f)
    End Sub

    Private Sub ec_filtra(sender As System.Object, e As System.EventArgs) Handles ec.SelChange
        Try
            setea_grid()
        Catch
        End Try
    End Sub

    Private Sub ec_filtro(sender As System.Object, e As System.EventArgs) Handles ec.AfterFilter
        Try
            ec.RowSel = 1
            ec.Focus()
        Catch ex As Exception

        End Try
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
End Class
