Public Class Req_Mater
    Inherits System.Windows.Forms.Form
    Dim strSQL As String
    Dim Requi As String
    Dim Empresan As String
    Dim empresa As String
    Dim CPO As String
    Dim constr As String
    Friend WithEvents Cpp1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents C1r As C1.C1Report.C1Report
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Si As System.Windows.Forms.Button
    Friend WithEvents Corte As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Est As System.Windows.Forms.Label
    Friend WithEvents Col As System.Windows.Forms.Label
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Regresa As System.Windows.Forms.Button
    Friend WithEvents MnuZoom As System.Windows.Forms.ContextMenu
    Friend WithEvents Mz100 As System.Windows.Forms.MenuItem
    Friend WithEvents MzPage As System.Windows.Forms.MenuItem
    Friend WithEvents MzTwoPages As System.Windows.Forms.MenuItem
    Friend WithEvents MzThumbnails As System.Windows.Forms.MenuItem
    Friend WithEvents PG1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Pd1 As System.Drawing.Printing.PrintDocument
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Req_Mater))
        Me.si = New System.Windows.Forms.Button()
        Me.impri = New System.Windows.Forms.Button()
        Me.Corte = New System.Windows.Forms.ComboBox()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Est = New System.Windows.Forms.Label()
        Me.Col = New System.Windows.Forms.Label()
        Me.mnuZoom = New System.Windows.Forms.ContextMenu()
        Me.mz100 = New System.Windows.Forms.MenuItem()
        Me.mzPage = New System.Windows.Forms.MenuItem()
        Me.mzTwoPages = New System.Windows.Forms.MenuItem()
        Me.mzThumbnails = New System.Windows.Forms.MenuItem()
        Me.PG1 = New System.Windows.Forms.PrintDialog()
        Me.pd1 = New System.Drawing.Printing.PrintDocument()
        Me.cpp1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        Me.c1r = New C1.C1Report.C1Report()
        CType(Me.cpp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpp1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cpp1.SuspendLayout()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(384, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 51
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.si.UseVisualStyleBackColor = False
        '
        'impri
        '
        Me.impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.impri.ForeColor = System.Drawing.Color.Black
        Me.impri.Image = CType(resources.GetObject("impri.Image"), System.Drawing.Image)
        Me.impri.Location = New System.Drawing.Point(384, 8)
        Me.impri.Name = "impri"
        Me.impri.Size = New System.Drawing.Size(60, 40)
        Me.impri.TabIndex = 50
        Me.impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.impri.UseVisualStyleBackColor = False
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
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(450, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 59
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Estilo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Est
        '
        Me.Est.BackColor = System.Drawing.Color.White
        Me.Est.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Est.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Est.ForeColor = System.Drawing.Color.Black
        Me.Est.Location = New System.Drawing.Point(136, 56)
        Me.Est.Name = "Est"
        Me.Est.Size = New System.Drawing.Size(160, 24)
        Me.Est.TabIndex = 56
        Me.Est.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Col
        '
        Me.Col.BackColor = System.Drawing.Color.White
        Me.Col.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Col.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Col.ForeColor = System.Drawing.Color.Black
        Me.Col.Location = New System.Drawing.Point(136, 80)
        Me.Col.Name = "Col"
        Me.Col.Size = New System.Drawing.Size(424, 24)
        Me.Col.TabIndex = 57
        Me.Col.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuZoom
        '
        Me.mnuZoom.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mz100, Me.mzPage, Me.mzTwoPages, Me.mzThumbnails})
        '
        'mz100
        '
        Me.mz100.Index = 0
        Me.mz100.Text = "100%"
        '
        'mzPage
        '
        Me.mzPage.Index = 1
        Me.mzPage.Text = "Full Page"
        '
        'mzTwoPages
        '
        Me.mzTwoPages.Index = 2
        Me.mzTwoPages.Text = "Two Pages"
        '
        'mzThumbnails
        '
        Me.mzThumbnails.Index = 3
        Me.mzThumbnails.Text = "Thumbnails"
        '
        'cpp1
        '
        Me.cpp1.Location = New System.Drawing.Point(0, 117)
        Me.cpp1.Name = "cpp1"
        '
        'cpp1.OutlineView
        '
        Me.cpp1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cpp1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.cpp1.PreviewOutlineView.Name = "OutlineView"
        Me.cpp1.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.cpp1.PreviewOutlineView.TabIndex = 0
        '
        'cpp1.PreviewPane
        '
        Me.cpp1.PreviewPane.Document = Me.c1r
        Me.cpp1.PreviewPane.IntegrateExternalTools = True
        Me.cpp1.PreviewPane.TabIndex = 0
        Me.cpp1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize
        '
        'cpp1.PreviewTextSearchPanel
        '
        Me.cpp1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.cpp1.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        Me.cpp1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        Me.cpp1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.cpp1.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        Me.cpp1.PreviewTextSearchPanel.TabIndex = 0
        Me.cpp1.PreviewTextSearchPanel.Visible = False
        '
        'cpp1.ThumbnailView
        '
        Me.cpp1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cpp1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.cpp1.PreviewThumbnailView.Name = "ThumbnailView"
        Me.cpp1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 526)
        Me.cpp1.PreviewThumbnailView.TabIndex = 0
        Me.cpp1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.cpp1.Size = New System.Drawing.Size(984, 599)
        Me.cpp1.TabIndex = 84
        Me.cpp1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.cpp1.ToolBars.File.Open.Image = CType(resources.GetObject("cpp1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.cpp1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.cpp1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.cpp1.ToolBars.File.Open.ToolTipText = "Open File"
        '
        '
        '
        Me.cpp1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("cpp1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.cpp1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.cpp1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        '
        '
        '
        Me.cpp1.ToolBars.File.Print.Image = CType(resources.GetObject("cpp1.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Print.Name = "btnPrint"
        Me.cpp1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.cpp1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.cpp1.ToolBars.File.Reflow.Image = CType(resources.GetObject("cpp1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.cpp1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.cpp1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        '
        '
        '
        Me.cpp1.ToolBars.File.Save.Image = CType(resources.GetObject("cpp1.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.File.Save.Name = "btnFileSave"
        Me.cpp1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.cpp1.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("cpp1.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.cpp1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.cpp1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("cpp1.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.cpp1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.cpp1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("cpp1.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.cpp1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.cpp1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("cpp1.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.cpp1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.cpp1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("cpp1.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.cpp1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.cpp1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.cpp1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.cpp1.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("cpp1.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
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
        Me.cpp1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.cpp1.ToolBars.Page.Continuous.Checked = True
        Me.cpp1.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cpp1.ToolBars.Page.Continuous.Image = CType(resources.GetObject("cpp1.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.cpp1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.cpp1.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.cpp1.ToolBars.Page.Facing.Image = CType(resources.GetObject("cpp1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.cpp1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.cpp1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.cpp1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("cpp1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.cpp1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.cpp1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.cpp1.ToolBars.Page.Single.Image = CType(resources.GetObject("cpp1.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.cpp1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.cpp1.ToolBars.Page.Single.ToolTipText = "Single Page View"
        '
        '
        '
        Me.cpp1.ToolBars.Text.Find.Image = CType(resources.GetObject("cpp1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Text.Find.Name = "btnFind"
        Me.cpp1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        '
        '
        '
        Me.cpp1.ToolBars.Text.Hand.Checked = True
        Me.cpp1.ToolBars.Text.Hand.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cpp1.ToolBars.Text.Hand.Image = CType(resources.GetObject("cpp1.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.cpp1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.cpp1.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        '
        '
        '
        Me.cpp1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("cpp1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
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
        Me.cpp1.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("cpp1.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.cpp1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.cpp1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Image = CType(resources.GetObject("cpp1.ToolBars.Zoom.ZoomInTool.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomInTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool"
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Size = New System.Drawing.Size(156, 22)
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.cpp1.ToolBars.Zoom.ZoomInTool.Text = "Zoom In Tool"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("cpp1.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.cpp1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.cpp1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.cpp1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Image = CType(resources.GetObject("cpp1.ToolBars.Zoom.ZoomOutTool.Image"), System.Drawing.Image)
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool"
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Size = New System.Drawing.Size(156, 22)
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Tag = "C1PreviewActionEnum.ZoomOutTool"
        Me.cpp1.ToolBars.Zoom.ZoomOutTool.Text = "Zoom Out Tool"
        '
        '
        '
        Me.cpp1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cpp1.ToolBars.Zoom.ZoomInTool, Me.cpp1.ToolBars.Zoom.ZoomOutTool})
        Me.cpp1.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("cpp1.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
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
        'Req_Mater
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 716)
        Me.Controls.Add(Me.cpp1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.Col)
        Me.Controls.Add(Me.Est)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Corte)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.impri)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Req_Mater"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-impresion de Requisiciones"
        CType(Me.cpp1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cpp1.ResumeLayout(False)
        Me.cpp1.PerformLayout()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub REQ_MAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cpp1.Width = Me.Width - 20
        cpp1.Height = Me.Height - 150
        AddHandler Corte.KeyPress, AddressOf keypressed1
        Dim obj As empresas
        obj = New empresas()
        Empresan = obj.nombre
        constr = obj.constr
        llena_cortes()
    End Sub

    Private Sub Limpia_variables()
        Est.Text = ""
        Col.Text = ""
        Impri.Visible = False
        Impri.Enabled = True
        Si.Visible = True
    End Sub

    Private Sub Carga(ByVal envia As Boolean)
        Cursor = Cursors.WaitCursor
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT REQ_D.* ,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,F_REQ,KNIT ,ROLLOS.COLOR AS COLORK, CORTES.CLIENTE , (SELECT SALA FROM CORTES_S WHERE CORTES_S.CORTE = REQ_D.CORTE) AS SALA, ANCHO,TONALIDAD FROM REQ_D LEFT JOIN REQ_E ON REQ_E.REQ = REQ_D.REQ LEFT JOIN CORTES ON REQ_D.CORTE =CORTES.CORTE LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE REQ_E.REQ = REQ_D.REQ AND REQ_D.REQ =  '" & Requi & "' ORDER BY KNIT,REQ_D.BATCH,REQ_D.ROLLO"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
                ' load report
            c1r.Load("C:\TELAS\rep.xml", "REQUI")
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strsql
            c1r.Fields("Empresa").Text = empresa
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
            End Try
    End Sub

    Private Sub Llena_cortes()
        Dim strSQL As String
        strSQL = "SELECT DISTINCT CORTE FROM REQ_D WHERE DESPACHADO = 'N' ORDER BY CORTE DESC"
        llena_combos(Corte, strSQL, "CORTE")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles impri.Click
        Carga(True)
    End Sub

    Private Sub Si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Si.Click
        Dim ok As Boolean
        busca_corte(ok)
        If ok Then
            Carga(False)
            Si.Visible = False
            Impri.Visible = True
            Impri.Focus()
        Else
            Limpia_variables()
        End If
    End Sub

    Private Sub Busca_corte(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String
        ok = False
        strSQL = "SELECT * FROM REQ_E  WHERE CORTE = '" & Corte.Text & "' "
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            MsgBox("Corte no Existe en Base de Datos", MsgBoxStyle.Critical, "El corte Ingresado no existe !!!")
            Exit Sub
        End If
        For Each dr In dt.Rows
            ok = True
            Requi = dr("REQ")
            Est.Text = dr("ESTILO")
            Col.Text = dr("COLOR")
        Next
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresa.Click
        Limpia_variables()
        C1r.Clear()
    End Sub

    Sub Keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Si.Focus()
        End If
    End Sub 'keypressed
    Private Sub Corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Corte.KeyPress
        '  AutoCompletar(Corte, e)
    End Sub
End Class
