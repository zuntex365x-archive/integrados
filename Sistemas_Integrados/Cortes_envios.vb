Public Class Cortes_envios
    Inherits System.Windows.Forms.Form
    Dim strSQL As String
    Dim Requi As String
    Dim Empresan As String
    Dim empresa As String
    Dim CPO As String
    Dim constr As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Dim docto As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Corte As System.Windows.Forms.ComboBox
    Friend WithEvents impri As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_envios))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.si = New System.Windows.Forms.Button()
        Me.impri = New System.Windows.Forms.Button()
        Me.Corte = New System.Windows.Forms.ComboBox()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1r = New C1.C1Report.C1Report()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(336, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 51
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este Boton para Desplegar el  Reporte de Ingresos a Inventario. ")
        Me.si.UseVisualStyleBackColor = False
        '
        'impri
        '
        Me.impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.impri.ForeColor = System.Drawing.Color.Black
        Me.impri.Image = CType(resources.GetObject("impri.Image"), System.Drawing.Image)
        Me.impri.Location = New System.Drawing.Point(384, 8)
        Me.impri.Name = "impri"
        Me.impri.Size = New System.Drawing.Size(35, 35)
        Me.impri.TabIndex = 50
        Me.impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.impri.UseVisualStyleBackColor = False
        Me.impri.Visible = False
        '
        'Corte
        '
        Me.Corte.BackColor = System.Drawing.Color.White
        Me.Corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte.Location = New System.Drawing.Point(136, 8)
        Me.Corte.MaxDropDownItems = 10
        Me.Corte.MaxLength = 10
        Me.Corte.Name = "Corte"
        Me.Corte.Size = New System.Drawing.Size(160, 24)
        Me.Corte.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Corte, "Elija el Corte.")
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(336, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 59
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        Me.c1r.ReportName = "C1Report1"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 80)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Doble Click sobre el documento a imprimir."
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(8, 147)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.c1r
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(974, 557)
        Me.C1PrintPreviewControl1.TabIndex = 84
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Parameters.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Name = "btnParameters"
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.Tag = "C1PreviewActionEnum.Parameters"
        Me.C1PrintPreviewControl1.ToolBars.File.Parameters.ToolTipText = "Report Parameters"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PrintLayout.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Name = "btnPrintLayout"
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.Tag = "C1PreviewActionEnum.PrintLayout"
        Me.C1PrintPreviewControl1.ToolBars.File.PrintLayout.ToolTipText = "Print Layout"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Name = "btnFileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Stop.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Name = "btnStop"
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.Tag = "C1PreviewActionEnum.Stop"
        Me.C1PrintPreviewControl1.ToolBars.File.Stop.ToolTipText = "Stop"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Name = "lblOfPages"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Size = New System.Drawing.Size(27, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Tag = "C1PreviewActionEnum.GoPageCount"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Text = "of 0"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Name = "lblPage"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Size = New System.Drawing.Size(33, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Tag = "C1PreviewActionEnum.GoPageLabel"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Text = "Page"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Name = "btnNavigationPane"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Tag = "C1PreviewActionEnum.NavigationPane"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.ToolTipText = "Navigation Pane"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.ToolTipText = "Single Page View"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Name = "btnMatchCase"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Size = New System.Drawing.Size(73, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Tag = "C1PreviewActionEnum.MatchCase"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.Text = "Match Case"
        Me.C1PrintPreviewControl1.ToolBars.Search.MatchCase.ToolTipText = "Search with case sensitivity"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Name = "lblSearch"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Size = New System.Drawing.Size(33, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Tag = "C1PreviewActionEnum.SearchLabel"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchLabel.Text = "Find:"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Name = "btnSearchNext"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.Tag = "C1PreviewActionEnum.SearchNext"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchNext.ToolTipText = "Search Next"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Name = "btnSearchPrevious"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Tag = "C1PreviewActionEnum.SearchPrevious"
        Me.C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.ToolTipText = "Search Previous"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.ToolTipFind = ""
        Me.C1PrintPreviewControl1.ToolBars.Text.ToolTipToolTextSelect = ""
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Name = "dropZoomFactor"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Size = New System.Drawing.Size(13, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.DropZoomFactor.Tag = "C1PreviewActionEnum.ZoomFactor"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipToolZoomIn = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipToolZoomOut = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Size = New System.Drawing.Size(156, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Text = "Zoom In Tool"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Size = New System.Drawing.Size(156, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Tag = "C1PreviewActionEnum.ZoomOutTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Text = "Zoom Out Tool"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool, Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool})
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(32, 22)
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool"
        '
        'Cortes_envios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 716)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Corte)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.impri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.regresa)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_envios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Envios de Cortes"
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub REQ_MAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Corte.KeyPress, AddressOf keypressed1
        C1PrintPreviewControl1.Width = Me.Width - 30
        C1PrintPreviewControl1.Height = Me.Height - 100
        llena_cortes()
    End Sub

    Private Sub limpia_variables()
        impri.Visible = False
        impri.Enabled = True
        si.Visible = True
    End Sub

    Private Sub llena_grid()
        dt = New DataTable()
        Dim dr As DataRow
        Dim prendas As Integer
        Dim saldo As Integer = 0
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM CORTES_PAR LEFT JOIN CORTES ON CORTES_PAR.CORTE = CORTES.CORTE WHERE CORTES_PAR.CORTE = '" & Corte.Text & "' AND TIPO = 'Envio' ORDER BY FECHA,PROCESO,TIPO,DOCTO"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("FECHA")
            fg(l, 2) = dr("DOCTO")
            fg(l, 3) = dr("PROCESO")
            fg(l, 4) = dr("ESTILO")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = dr("LUGAR")
            prendas = (dr("P0") + dr("P1") + dr("P2") + dr("P3") + dr("P4") + dr("P5") + dr("P6") + dr("P7") + dr("P8") + dr("P9") + dr("S0") + dr("S1") + dr("S2") + dr("S3") + dr("S4") + dr("S5") + dr("S6") + dr("S7") + dr("S8") + dr("S9"))
            fg(l, 7) = prendas
            l = l + 1
        Next
    End Sub


    Private Sub Carga(ByVal envia As Boolean)
        Cursor = Cursors.WaitCursor
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT CORTES_PAR.*,CORTES.ESTILO,CORTES.COLOR, DETALLE,COMENTARIOS,CPO_D.ESCALA ,E_TALLAS.* FROM CORTES_PAR LEFT JOIN CORTES ON CORTES_PAR.CORTE = CORTES.CORTE LEFT JOIN CLI_EST_COL_P ON CORTES.CLIENTE = CLI_EST_COL_P.CLIENTE AND CORTES.ESTILO = CLI_EST_COL_P.ESTILO AND CORTES.COLOR = CLI_EST_COL_P.COLOR AND CLI_EST_COL_P.PROCESO = UPPER(CORTES_PAR.PROCESO) LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE DOCTO = '" & docto & " '"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.conole
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report


            c1r.Load("\\192.9.200.10\Programas\Programas\vb2010\rep.xml", "Envios")
            c1r.DataSource.ConnectionString = constr
            c1r.DataSource.RecordSource = strsql
            '
            c1r.Render()
            c1r.Print()

        Catch
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub llena_cortes()
        Dim strSQL As String
        strSQL = "SELECT DISTINCT CORTES_PAR.CORTE FROM CORTES_PAR LEFT JOIN CORTES ON CORTES_PAR.CORTE = CORTES.CORTE WHERE EXPORTADO <> 'S' ORDER BY CORTES_PAR.CORTE"
        llena_combos(Corte, strSQL, "CORTE")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles impri.Click
        Carga(True)
    End Sub


    Private Sub CORTE_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Corte.KeyUp
        Dim index As Integer
        Dim actual As String
        Dim found As String

        ' Do nothing for some keys such as navigation keys.
        If ((e.KeyCode = Keys.Back) Or _
            (e.KeyCode = Keys.Left) Or _
            (e.KeyCode = Keys.Right) Or _
            (e.KeyCode = Keys.Up) Or _
            (e.KeyCode = Keys.Delete) Or _
            (e.KeyCode = Keys.Down) Or _
            (e.KeyCode = Keys.PageUp) Or _
            (e.KeyCode = Keys.PageDown) Or _
            (e.KeyCode = Keys.Home) Or _
            (e.KeyCode = Keys.End)) Then
            Return
        End If

        ' Store the actual text that has been typed.
        actual = Corte.Text

        ' Find the first match for the typed value.
        index = Corte.FindString(actual)

        ' Get the text of the first match.
        If (index > -1) Then
            found = Corte.Items(index).ToString()

            ' Select this item from the list.
            Corte.SelectedIndex = index

            ' Select the portion of the text that was automatically
            ' added so that additional typing will replace it.
            Corte.SelectionStart = actual.Length
            Corte.SelectionLength = found.Length
        End If
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        llena_grid()
        Corte.Enabled = False
        regresa.Visible = True
        si.Visible = False
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        limpia_variables()
        impri.Visible = False
        c1r.Clear()
        fg.Enabled = True
        Corte.Enabled = True
        fg.Rows.Count = 1
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            si.Focus()
        End If
    End Sub 'keypressed

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim f As Integer = fg.RowSel
        If f > 0 Then
            fg.Enabled = False
            docto = fg(f, 2)
            Carga(False)
            si.Visible = False
            regresa.Visible = True
            impri.Visible = True
            impri.Focus()
        Else
            limpia_variables()
        End If
    End Sub
End Class
