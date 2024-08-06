Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Cpo_ver1
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents cancela As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents cpo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cpo_ver1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.sigue = New System.Windows.Forms.Button()
        Me.cancela = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gr
        '
        Me.gr.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gr.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.gr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.gr.ColumnInfo = resources.GetString("gr.ColumnInfo")
        Me.gr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gr.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.gr.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.gr.Location = New System.Drawing.Point(8, 400)
        Me.gr.Name = "gr"
        Me.gr.Rows.Count = 100
        Me.gr.Rows.DefaultSize = 19
        Me.gr.Size = New System.Drawing.Size(1000, 128)
        Me.gr.StyleInfo = resources.GetString("gr.StyleInfo")
        Me.gr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.gr.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.gr, "Doble click para escoger Estilo-Color.")
        Me.gr.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 100
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 640)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "CPO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(88, 16)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(256, 26)
        Me.cpo.TabIndex = 95
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(388, 2)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 114
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'cancela
        '
        Me.cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancela.ForeColor = System.Drawing.Color.Black
        Me.cancela.Image = CType(resources.GetObject("cancela.Image"), System.Drawing.Image)
        Me.cancela.Location = New System.Drawing.Point(388, 2)
        Me.cancela.Name = "cancela"
        Me.cancela.Size = New System.Drawing.Size(60, 40)
        Me.cancela.TabIndex = 113
        Me.cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancela.UseVisualStyleBackColor = False
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(454, 2)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(60, 40)
        Me.imprime.TabIndex = 112
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'Cpo_ver1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 707)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.cancela)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.gr)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cpo_ver1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificación de CPO´s por CPO"
        CType(Me.gr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim pac As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim fechas As String
    Dim rango As String
    Dim dt As New DataTable()

    Private Sub detalle_facturas_r(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cpo.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(cpo, "SELECT DISTINCT CPO FROM CPO_DIF ORDER BY CPO", "CPO")
        deshabilita()
    End Sub

    Private Sub deshabilita()
        setea_grid()
        CANCELA.Visible = False
        sigue.Visible = True
        cpo.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub


    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        sigue.Visible = False
        cancela.Visible = True
        imprime.Visible = True
        cpo.Enabled = False
        llena_fg()
    End Sub

    Private Sub llena_fg()
        Dim l As Integer = 1
        llena_tablas(dt, "SELECT * FROM CPO_DIF WHERE CPO = '" & cpo.Text & "'", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("FECHA")
            fg(l, 2) = dr("CLIENTE")
            fg(l, 3) = dr("CPO")
            fg(l, 4) = dr("ESTILO")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = dr("COLUMNA")
            fg(l, 7) = dr("INGRESO")
            fg(l, 8) = dr("VERIFICACION")
            fg(l, 9) = dr("USUARIO1")
            fg(l, 10) = dr("USUARIO2")
            l = l + 1
        Next
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancela.Click
        sigue.Visible = True
        cancela.Visible = False
        imprime.Visible = False
        cpo.Enabled = True
        fg.Rows.Count = 1
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        mal = obj.nombre + "Verificación de Ingreso de CPO'S    CPO " + cpo.Text
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Verificación", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub
    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub
End Class
