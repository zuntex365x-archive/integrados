Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Batch_cpo
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents regresa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Batch_cpo))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Impri = New System.Windows.Forms.Button()
        Me.si = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(112, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(212, 24)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'cpo
        '
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(112, 32)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(212, 24)
        Me.cpo.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.cpo, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 62)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(947, 596)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(672, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 100
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "CPO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(738, 8)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(60, 40)
        Me.Impri.TabIndex = 99
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Impri.UseVisualStyleBackColor = False
        Me.Impri.Visible = False
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(672, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 98
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.si.UseVisualStyleBackColor = False
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(874, 73)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(40, 36)
        Me.AxAcroPDF1.TabIndex = 101
        Me.AxAcroPDF1.Visible = False
        '
        'Batch_cpo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 660)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Batch_cpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Rollos Asignados a una  CPO"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Private Sub Tela_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler C4.KeyPress, AddressOf keypressed1
        AddHandler cpo.KeyPress, AddressOf keypressed2
        fg.Width = Me.Width - 20
        fg.Height = Me.Height - 100
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO LEFT JOIN CPO_D ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        Try
            C4.SelectedIndex = 0
        Catch ex As Exception
        End Try
        setea_grid()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            C4.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub busca_tela()
        Dim strSQL As String
        If Trim(C4.Text) = "TODOS" Then
            strSQL = "SELECT * FROM ROLLOS WHERE CPO = '" & cpo.Text & "' "
        Else
            strSQL = "SELECT * FROM ROLLOS WHERE CLIENTE = '" & C4.Text & "' AND CPO = '" & cpo.Text & "' "
        End If
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("CLIENTE")
            fg(lineas, 3) = dr("FPO")
            fg(lineas, 4) = dr("KNIT")
            fg(lineas, 5) = dr("COLOR")
            fg(lineas, 6) = dr("ROLLO")
            fg(lineas, 7) = dr("YARDAS_I")
            fg(lineas, 8) = dr("PESO")
            If fg(lineas, 7) = 0 Then
                fg(lineas, 8) = 0
            End If
            lineas = lineas + 1
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        With fg
            .Redraw = False
            Dim totalya As Integer = fg.Cols("YARDAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 4, totalya, "Total Batch")
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 4, totalib, "Total Batch")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
            .Redraw = True
            'fg.Tree.Show(1)
        End With
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Consulta de Rollos de la CPO: " + Trim(cpo.Text) + "   al : " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setea_grid()
        busca_tela()
    End Sub

    Private Sub C4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.SelectedIndexChanged
        llena_combos(cpo, "SELECT DISTINCT CPO.CPO FROM CPO LEFT JOIN CPO_D ON CPO.CPO = CPO_D.CPO  WHERE CLIENTE = '" & C4.Text & "' AND ESTADO  = 'A' ORDER BY CPO.CPO", "CPO")
        Try
            cpo.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        C4.Enabled = False
        cpo.Enabled = False
        si.Visible = False
        regresa.Visible = True
        setea_grid()
        busca_tela()
    End Sub

    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_fg()
    End Sub
    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub
    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        C4.Enabled = True
        cpo.Enabled = True
        regresa.Visible = False
        si.Visible = True
        C4.Visible = True
        setea_grid()
    End Sub
End Class
