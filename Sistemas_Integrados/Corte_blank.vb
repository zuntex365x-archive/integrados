Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Corte_blank
    Inherits System.Windows.Forms.Form
    Dim tip As String
    Dim reporte As String
    Dim strSQL As String
    Dim strSQL1 As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim Requi As String
    Dim t(10) As Integer
    Dim Empresan As String
    Dim empresa As String
    Dim cpo As String
    Dim cliente As String
    Dim constr As String
    Dim esp As New DataTable()
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents pd1 As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents S1 As Button
    Dim req As New DataTable()
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
    Friend WithEvents Corte As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Est As System.Windows.Forms.Label
    Friend WithEvents Col As System.Windows.Forms.Label
    Friend WithEvents Pren As System.Windows.Forms.Label
    Friend WithEvents impri As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corte_blank))
        Me.impri = New System.Windows.Forms.Button()
        Me.Corte = New System.Windows.Forms.ComboBox()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Est = New System.Windows.Forms.Label()
        Me.Col = New System.Windows.Forms.Label()
        Me.Pren = New System.Windows.Forms.Label()
        Me.c1r = New C1.C1Report.C1Report()
        Me.pd1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        Me.S1 = New System.Windows.Forms.Button()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pd1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pd1.SuspendLayout()
        Me.SuspendLayout()
        '
        'impri
        '
        Me.impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.impri.ForeColor = System.Drawing.Color.Black
        Me.impri.Image = CType(resources.GetObject("impri.Image"), System.Drawing.Image)
        Me.impri.Location = New System.Drawing.Point(366, 3)
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
        Me.regresa.Location = New System.Drawing.Point(432, 3)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 59
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Estilo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(787, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Prendas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Col.Size = New System.Drawing.Size(344, 24)
        Me.Col.TabIndex = 57
        Me.Col.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pren
        '
        Me.Pren.BackColor = System.Drawing.Color.White
        Me.Pren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pren.ForeColor = System.Drawing.Color.Black
        Me.Pren.Location = New System.Drawing.Point(872, 80)
        Me.Pren.Name = "Pren"
        Me.Pren.Size = New System.Drawing.Size(96, 24)
        Me.Pren.TabIndex = 58
        Me.Pren.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'pd1
        '
        Me.pd1.Location = New System.Drawing.Point(17, 114)
        Me.pd1.Name = "pd1"
        '
        'pd1.PreviewPane
        '
        Me.pd1.PreviewPane.Document = Me.c1r
        Me.pd1.PreviewPane.IntegrateExternalTools = True
        Me.pd1.PreviewPane.TabIndex = 0
        Me.pd1.Size = New System.Drawing.Size(960, 591)
        Me.pd1.TabIndex = 82
        Me.pd1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.pd1.ToolBars.File.Open.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.pd1.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.pd1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.pd1.ToolBars.File.Open.ToolTipText = "Open File"
        '
        '
        '
        Me.pd1.ToolBars.File.PageSetup.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.pd1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.pd1.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        '
        '
        '
        Me.pd1.ToolBars.File.Parameters.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Parameters.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.Parameters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.Parameters.Name = "btnParameters"
        Me.pd1.ToolBars.File.Parameters.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.Parameters.Tag = "C1PreviewActionEnum.Parameters"
        Me.pd1.ToolBars.File.Parameters.ToolTipText = "Report Parameters"
        '
        '
        '
        Me.pd1.ToolBars.File.Print.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.Print.Name = "btnPrint"
        Me.pd1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.pd1.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.pd1.ToolBars.File.PrintLayout.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.PrintLayout.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.PrintLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.PrintLayout.Name = "btnPrintLayout"
        Me.pd1.ToolBars.File.PrintLayout.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.PrintLayout.Tag = "C1PreviewActionEnum.PrintLayout"
        Me.pd1.ToolBars.File.PrintLayout.ToolTipText = "Print Layout"
        '
        '
        '
        Me.pd1.ToolBars.File.Reflow.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.pd1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.pd1.ToolBars.File.Reflow.ToolTipText = "Reflow"
        '
        '
        '
        Me.pd1.ToolBars.File.Save.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.Save.Name = "btnFileSave"
        Me.pd1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.pd1.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.pd1.ToolBars.File.Stop.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.File.Stop.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.File.Stop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.File.Stop.Name = "btnStop"
        Me.pd1.ToolBars.File.Stop.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.File.Stop.Tag = "C1PreviewActionEnum.Stop"
        Me.pd1.ToolBars.File.Stop.ToolTipText = "Stop"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.pd1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.pd1.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.pd1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.pd1.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.pd1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.pd1.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.pd1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.pd1.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.pd1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.pd1.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.pd1.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.pd1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.pd1.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.pd1.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.LblOfPages.Name = "lblOfPages"
        Me.pd1.ToolBars.Navigation.LblOfPages.Size = New System.Drawing.Size(27, 22)
        Me.pd1.ToolBars.Navigation.LblOfPages.Tag = "C1PreviewActionEnum.GoPageCount"
        Me.pd1.ToolBars.Navigation.LblOfPages.Text = "of 0"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.LblPage.Name = "lblPage"
        Me.pd1.ToolBars.Navigation.LblPage.Size = New System.Drawing.Size(33, 22)
        Me.pd1.ToolBars.Navigation.LblPage.Tag = "C1PreviewActionEnum.GoPageLabel"
        Me.pd1.ToolBars.Navigation.LblPage.Text = "Page"
        '
        '
        '
        Me.pd1.ToolBars.Navigation.NavigationPane.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Navigation.NavigationPane.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Navigation.NavigationPane.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Navigation.NavigationPane.Name = "btnNavigationPane"
        Me.pd1.ToolBars.Navigation.NavigationPane.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Navigation.NavigationPane.Tag = "C1PreviewActionEnum.NavigationPane"
        Me.pd1.ToolBars.Navigation.NavigationPane.ToolTipText = "Navigation Pane"
        Me.pd1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.pd1.ToolBars.Page.Continuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.pd1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.pd1.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.pd1.ToolBars.Page.Facing.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.pd1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.pd1.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.pd1.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.pd1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.pd1.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.pd1.ToolBars.Page.Single.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.pd1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.pd1.ToolBars.Page.Single.ToolTipText = "Single Page View"
        '
        '
        '
        Me.pd1.ToolBars.Search.MatchCase.Name = "btnMatchCase"
        Me.pd1.ToolBars.Search.MatchCase.Size = New System.Drawing.Size(73, 22)
        Me.pd1.ToolBars.Search.MatchCase.Tag = "C1PreviewActionEnum.MatchCase"
        Me.pd1.ToolBars.Search.MatchCase.Text = "Match Case"
        Me.pd1.ToolBars.Search.MatchCase.ToolTipText = "Search with case sensitivity"
        '
        '
        '
        Me.pd1.ToolBars.Search.SearchLabel.Name = "lblSearch"
        Me.pd1.ToolBars.Search.SearchLabel.Size = New System.Drawing.Size(33, 22)
        Me.pd1.ToolBars.Search.SearchLabel.Tag = "C1PreviewActionEnum.SearchLabel"
        Me.pd1.ToolBars.Search.SearchLabel.Text = "Find:"
        '
        '
        '
        Me.pd1.ToolBars.Search.SearchNext.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchNext.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Search.SearchNext.Name = "btnSearchNext"
        Me.pd1.ToolBars.Search.SearchNext.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Search.SearchNext.Tag = "C1PreviewActionEnum.SearchNext"
        Me.pd1.ToolBars.Search.SearchNext.ToolTipText = "Search Next"
        '
        '
        '
        Me.pd1.ToolBars.Search.SearchPrevious.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Search.SearchPrevious.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Search.SearchPrevious.Name = "btnSearchPrevious"
        Me.pd1.ToolBars.Search.SearchPrevious.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Search.SearchPrevious.Tag = "C1PreviewActionEnum.SearchPrevious"
        Me.pd1.ToolBars.Search.SearchPrevious.ToolTipText = "Search Previous"
        '
        '
        '
        Me.pd1.ToolBars.Text.Find.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Text.Find.Name = "btnFind"
        Me.pd1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        '
        '
        '
        Me.pd1.ToolBars.Text.Hand.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.pd1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.pd1.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        '
        '
        '
        Me.pd1.ToolBars.Text.SelectText.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.pd1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.pd1.ToolBars.Text.ToolTipFind = ""
        Me.pd1.ToolBars.Text.ToolTipToolTextSelect = ""
        '
        '
        '
        Me.pd1.ToolBars.Zoom.DropZoomFactor.Name = "dropZoomFactor"
        Me.pd1.ToolBars.Zoom.DropZoomFactor.Size = New System.Drawing.Size(13, 22)
        Me.pd1.ToolBars.Zoom.DropZoomFactor.Tag = "C1PreviewActionEnum.ZoomFactor"
        Me.pd1.ToolBars.Zoom.ToolTipToolZoomIn = Nothing
        Me.pd1.ToolBars.Zoom.ToolTipToolZoomOut = Nothing
        Me.pd1.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        '
        '
        '
        Me.pd1.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.pd1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.pd1.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.pd1.ToolBars.Zoom.ZoomInTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Zoom.ZoomInTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool"
        Me.pd1.ToolBars.Zoom.ZoomInTool.Size = New System.Drawing.Size(207, 22)
        Me.pd1.ToolBars.Zoom.ZoomInTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.pd1.ToolBars.Zoom.ZoomInTool.Text = "Herramienta para acercar"
        '
        '
        '
        Me.pd1.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.pd1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.pd1.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.pd1.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.pd1.ToolBars.Zoom.ZoomOutTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Zoom.ZoomOutTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool"
        Me.pd1.ToolBars.Zoom.ZoomOutTool.Size = New System.Drawing.Size(207, 22)
        Me.pd1.ToolBars.Zoom.ZoomOutTool.Tag = "C1PreviewActionEnum.ZoomOutTool"
        Me.pd1.ToolBars.Zoom.ZoomOutTool.Text = "Herramienta para alejar"
        '
        '
        '
        Me.pd1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pd1.ToolBars.Zoom.ZoomInTool, Me.pd1.ToolBars.Zoom.ZoomOutTool})
        Me.pd1.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
        Me.pd1.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pd1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.pd1.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(32, 22)
        Me.pd1.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.pd1.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool"
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(366, 3)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(60, 40)
        Me.S1.TabIndex = 83
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.S1.UseVisualStyleBackColor = False
        '
        'Corte_blank
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 716)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.pd1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.Pren)
        Me.Controls.Add(Me.Col)
        Me.Controls.Add(Me.Est)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Corte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.impri)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Corte_blank"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division Cortes por Blanks"
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pd1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pd1.ResumeLayout(False)
        Me.pd1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Corte_blank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Corte.KeyPress, AddressOf keypressed1
        Dim obj As empresas
        obj = New empresas()
        Empresan = obj.nombre
        constr = obj.constr
        llena_cortes()
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        Est.Text = ""
        Col.Text = ""
        Pren.Text = ""
        Corte.Enabled = True
        impri.Visible = False
        S1.Visible = True
        Try
            c1r.Clear()
        Catch
        End Try
    End Sub

    Private Sub llena_cortes()
        strSQL = "SELECT * FROM CORTES_B ORDER BY CORTE_NUEVO"
        llena_combos(Corte, strSQL, "CORTE_NUEVO")
    End Sub
    Private Sub imprime(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles impri.Click
        impresion_nuevo_corte()
    End Sub


    Private Sub busca_corte()
        Dim strSQL As String
        Dim dt As New DataTable()
        Dim cl As DataRow
        strSQL = "SELECT * FROM CORTES WHERE CORTE = '" & Corte.Text & "' "
        llena_tablas(dt, strSQL, cnn)
        For Each cl In dt.Rows
            Est.Text = cl("ESTILO")
            Col.Text = cl("COLOR")
            Pren.Text = cl("TOTAL")
            empresa = cl("CLIENTE")
            cliente = cl("CLIENTE")
        Next
        If dt.Rows.Count = 0 Then
            MsgBox("Corte no Existe en Base de Datos", MsgBoxStyle.Critical, "El corte Ingresado no existe !!!")
        End If
    End Sub
    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        llena_cortes()
        limpia_variables()
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            impri.Focus()
        End If
    End Sub 'keypressed

    '==============================================================================
    '            IMPRESION DE CORTE NUEVO
    '==============================================================================
    Private Sub impresion_nuevo_corte()
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT CORTES.*,CPO_D.ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0,CORTE_MADRE FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA LEFT JOIN CORTES_B ON CORTES.CORTE = CORTES_B.CORTE_NUEVO WHERE CORTE = '" & Corte.Text & "'"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report
            c1r.Load("C:\TELAS\rep.xml", "CORTE_B")
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strsql
            c1r.Fields("Empresa").Text = empresa
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
        End Try
        c1r.Render()
        c1r.Print()
    End Sub

    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Corte.KeyPress
        AutoCompletar(Corte, e)
    End Sub

    Private Sub S1_Click(sender As Object, e As EventArgs) Handles S1.Click
        busca_corte()
        S1.Visible = False
        impri.Visible = True
    End Sub
End Class
