Public Class Transfer_re
    Inherits System.Windows.Forms.Form
    Dim strSQL As String
    Dim ano As String
    Dim mes As String
    Dim ok As Boolean
    Friend WithEvents traslado As System.Windows.Forms.ComboBox
    Friend WithEvents cpp1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Dim cnn As New SqlClient.SqlConnection()
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
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfer_re))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.si = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.traslado = New System.Windows.Forms.ComboBox()
        Me.cpp1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        Me.c1r = New C1.C1Report.C1Report()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.cpp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpp1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cpp1.SuspendLayout()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(1141, 6)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 51
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este Boton para Desplegar el  Reporte de Ingresos a Inventario. ")
        Me.si.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(1141, 6)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 59
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'traslado
        '
        Me.traslado.Items.AddRange(New Object() {"Cheque"})
        Me.traslado.Location = New System.Drawing.Point(154, 6)
        Me.traslado.Name = "traslado"
        Me.traslado.Size = New System.Drawing.Size(305, 28)
        Me.traslado.TabIndex = 0
        '
        'cpp1
        '
        Me.cpp1.Location = New System.Drawing.Point(12, 50)
        Me.cpp1.Name = "cpp1"
        '
        'cpp1.PreviewPane
        '
        Me.cpp1.PreviewPane.Document = Me.c1r
        Me.cpp1.PreviewPane.IntegrateExternalTools = True
        Me.cpp1.PreviewPane.MinZoomFactor = 1.0R
        Me.cpp1.PreviewPane.TabIndex = 0
        Me.cpp1.Size = New System.Drawing.Size(1164, 654)
        Me.cpp1.TabIndex = 78
        Me.cpp1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.cpp1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.cpp1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.cpp1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.cpp1.ToolBars.File.Open.ToolTipText = "Open File"
        '
        '
        '
        Me.cpp1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.cpp1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.cpp1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        '
        '
        '
        Me.cpp1.ToolBars.File.Parameters.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Parameters.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Parameters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Parameters.Name = "btnParameters"
        Me.cpp1.ToolBars.File.Parameters.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Parameters.Tag = "C1PreviewActionEnum.Parameters"
        Me.cpp1.ToolBars.File.Parameters.ToolTipText = "Report Parameters"
        '
        '
        '
        Me.cpp1.ToolBars.File.Print.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Print.Name = "btnPrint"
        Me.cpp1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.cpp1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.cpp1.ToolBars.File.PrintLayout.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PrintLayout.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.PrintLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.PrintLayout.Name = "btnPrintLayout"
        Me.cpp1.ToolBars.File.PrintLayout.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.PrintLayout.Tag = "C1PreviewActionEnum.PrintLayout"
        Me.cpp1.ToolBars.File.PrintLayout.ToolTipText = "Print Layout"
        '
        '
        '
        Me.cpp1.ToolBars.File.Reflow.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.cpp1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.cpp1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        '
        '
        '
        Me.cpp1.ToolBars.File.Save.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Save.Name = "btnFileSave"
        Me.cpp1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.cpp1.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.cpp1.ToolBars.File.Stop.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Stop.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Stop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Stop.Name = "btnStop"
        Me.cpp1.ToolBars.File.Stop.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Stop.Tag = "C1PreviewActionEnum.Stop"
        Me.cpp1.ToolBars.File.Stop.ToolTipText = "Stop"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.cpp1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.cpp1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.cpp1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.cpp1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.cpp1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.cpp1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.cpp1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.cpp1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.cpp1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.cpp1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.cpp1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.cpp1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.cpp1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.cpp1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.LblOfPages.Name = "lblOfPages"
        Me.cpp1.ToolBars.Navigation.LblOfPages.Size = New System.Drawing.Size(27, 22)
        Me.cpp1.ToolBars.Navigation.LblOfPages.Tag = "C1PreviewActionEnum.GoPageCount"
        Me.cpp1.ToolBars.Navigation.LblOfPages.Text = "of 0"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.LblPage.Name = "lblPage"
        Me.cpp1.ToolBars.Navigation.LblPage.Size = New System.Drawing.Size(33, 22)
        Me.cpp1.ToolBars.Navigation.LblPage.Tag = "C1PreviewActionEnum.GoPageLabel"
        Me.cpp1.ToolBars.Navigation.LblPage.Text = "Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.NavigationPane.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.NavigationPane.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.NavigationPane.Name = "btnNavigationPane"
        Me.cpp1.ToolBars.Navigation.NavigationPane.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.NavigationPane.Tag = "C1PreviewActionEnum.NavigationPane"
        Me.cpp1.ToolBars.Navigation.NavigationPane.ToolTipText = "Navigation Pane"
        Me.cpp1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.cpp1.ToolBars.Page.Continuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.cpp1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.cpp1.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.cpp1.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.cpp1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.cpp1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.cpp1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.cpp1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.cpp1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.cpp1.ToolBars.Page.Single.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.cpp1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.cpp1.ToolBars.Page.Single.ToolTipText = "Single Page View"
        '
        '
        '
        Me.cpp1.ToolBars.Search.MatchCase.Name = "btnMatchCase"
        Me.cpp1.ToolBars.Search.MatchCase.Size = New System.Drawing.Size(73, 22)
        Me.cpp1.ToolBars.Search.MatchCase.Tag = "C1PreviewActionEnum.MatchCase"
        Me.cpp1.ToolBars.Search.MatchCase.Text = "Match Case"
        Me.cpp1.ToolBars.Search.MatchCase.ToolTipText = "Search with case sensitivity"
        '
        '
        '
        Me.cpp1.ToolBars.Search.SearchLabel.Name = "lblSearch"
        Me.cpp1.ToolBars.Search.SearchLabel.Size = New System.Drawing.Size(33, 22)
        Me.cpp1.ToolBars.Search.SearchLabel.Tag = "C1PreviewActionEnum.SearchLabel"
        Me.cpp1.ToolBars.Search.SearchLabel.Text = "Find:"
        '
        '
        '
        Me.cpp1.ToolBars.Search.SearchNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Search.SearchNext.Name = "btnSearchNext"
        Me.cpp1.ToolBars.Search.SearchNext.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Search.SearchNext.Tag = "C1PreviewActionEnum.SearchNext"
        Me.cpp1.ToolBars.Search.SearchNext.ToolTipText = "Search Next"
        '
        '
        '
        Me.cpp1.ToolBars.Search.SearchPrevious.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Search.SearchPrevious.Name = "btnSearchPrevious"
        Me.cpp1.ToolBars.Search.SearchPrevious.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Search.SearchPrevious.Tag = "C1PreviewActionEnum.SearchPrevious"
        Me.cpp1.ToolBars.Search.SearchPrevious.ToolTipText = "Search Previous"
        '
        '
        '
        Me.cpp1.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Text.Find.Name = "btnFind"
        Me.cpp1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        '
        '
        '
        Me.cpp1.ToolBars.Text.Hand.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.cpp1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.cpp1.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        '
        '
        '
        Me.cpp1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.cpp1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.cpp1.ToolBars.Text.ToolTipFind = ""
        Me.cpp1.ToolBars.Text.ToolTipToolTextSelect = ""
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.DropZoomFactor.Name = "dropZoomFactor"
        Me.cpp1.ToolBars.Zoom.DropZoomFactor.Size = New System.Drawing.Size(13, 22)
        Me.cpp1.ToolBars.Zoom.DropZoomFactor.Tag = "C1PreviewActionEnum.ZoomFactor"
        Me.cpp1.ToolBars.Zoom.ToolTipToolZoomIn = Nothing
        Me.cpp1.ToolBars.Zoom.ToolTipToolZoomOut = Nothing
        Me.cpp1.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.cpp1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.cpp1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomInTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool"
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Size = New System.Drawing.Size(155, 22)
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Text = "Zoom In Tool"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.cpp1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.cpp1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool"
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Size = New System.Drawing.Size(155, 22)
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Tag = "C1PreviewActionEnum.ZoomOutTool"
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Text = "Zoom Out Tool"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cpp1.ToolBars.Zoom.ZoomInTool, Me.cpp1.ToolBars.Zoom.ZoomOutTool})
        Me.cpp1.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.cpp1.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(32, 22)
        Me.cpp1.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.cpp1.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool"
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Traslado:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Transfer_re
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 716)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cpp1)
        Me.Controls.Add(Me.traslado)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.si)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transfer_re"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RE-Impresion de Traslados"
        CType(Me.cpp1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cpp1.ResumeLayout(False)
        Me.cpp1.PerformLayout()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub voucher_re_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler traslado.KeyPress, AddressOf keypressed1
        cpp1.Width = Me.Width - 30
        cpp1.Height = Me.Height - 50
        llena_combos(traslado, "SELECT DISTINCT TRASLADO FROM TRASLADO_BODEGAS ORDER BY TRASLADO DESC", "TRASLADO")
        Try
            traslado.SelectedIndex = 0
            limpia_variables()
        Catch
        End Try
    End Sub

    Private Sub limpia_variables()
        regresa.Visible = False
        traslado.Enabled = True
        si.Visible = True
        cpp1.Document = Nothing
        traslado.Focus()
    End Sub
    Private Sub Carga(ByVal envia As Boolean)
        Dim reporte As String = "TRASLADO"
        Dim obj As New empresas
        Cursor = Cursors.WaitCursor

        strSQL = "SELECT TRASLADO_BODEGAS.*, (SELECT BODEGA FROM BODEGAS WHERE CODIGO = DE_BODEGA) AS DE ,(SELECT BODEGA FROM BODEGAS WHERE CODIGO = A_BODEGA) AS A, ROLLOS.* FROM TRASLADO_BODEGAS LEFT JOIN ROLLOS ON TRASLADO_BODEGAS.BATCH = ROLLOS.BATCH AND TRASLADO_BODEGAS.ROLLO = ROLLOS.ROLLO WHERE TRASLADO = '" & traslado.Text & "'"

        Try
            Cursor = Cursors.WaitCursor
            ' carga reporte
            c1r.Load("C:\TELAS\rep.xml", reporte)
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strSQL
            c1r.Fields("Empresa").Text = obj.nombre
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
        End Try
        Try
            cpp1.Document = c1r
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Carga(True)
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        traslado.Enabled = False
        Carga(False)
        si.Visible = False
        regresa.Visible = True
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        limpia_variables()
        c1r.Clear()
        cpp1.Document = Nothing
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            si.Focus()
        End If
    End Sub 'keypressed

    Private Sub cuenta_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles traslado.KeyPress
        AutoCompletar(traslado, e)
    End Sub

    Private Sub traslado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles traslado.SelectedIndexChanged

    End Sub
End Class
