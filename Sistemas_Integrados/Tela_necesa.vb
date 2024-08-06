Imports C1.Win.C1FlexGrid

Public Class Tela_necesa
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cpo As System.Windows.Forms.Label
    Friend WithEvents Estilo As System.Windows.Forms.Label
    Friend WithEvents Colo As System.Windows.Forms.Label
    Friend WithEvents Cortar As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tela_necesa))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cpo = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.Label()
        Me.Colo = New System.Windows.Forms.Label()
        Me.Cortar = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(253, Byte), CType(249, Byte), CType(198, Byte))
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 112)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(912, 304)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:253, 249, 198;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:253, 249, 198;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 1" & _
        "56, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Bla" & _
        "ck;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:Highl" & _
        "ightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Bo" & _
        "rder:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186," & _
        " 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkD" & _
        "ark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Red;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 32)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Estilo::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "CPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Color:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(640, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 32)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Prendas x Cortar:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpo
        '
        Me.Cpo.BackColor = System.Drawing.Color.White
        Me.Cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Cpo.Location = New System.Drawing.Point(128, 8)
        Me.Cpo.Name = "Cpo"
        Me.Cpo.Size = New System.Drawing.Size(160, 24)
        Me.Cpo.TabIndex = 71
        Me.Cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Estilo.Location = New System.Drawing.Point(128, 40)
        Me.Estilo.Name = "Estilo"
        Me.Estilo.Size = New System.Drawing.Size(296, 24)
        Me.Estilo.TabIndex = 72
        Me.Estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Colo
        '
        Me.Colo.BackColor = System.Drawing.Color.White
        Me.Colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Colo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Colo.Location = New System.Drawing.Point(128, 72)
        Me.Colo.Name = "Colo"
        Me.Colo.Size = New System.Drawing.Size(296, 24)
        Me.Colo.TabIndex = 73
        Me.Colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cortar
        '
        Me.Cortar.BackColor = System.Drawing.Color.White
        Me.Cortar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cortar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cortar.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Cortar.Location = New System.Drawing.Point(808, 72)
        Me.Cortar.Name = "Cortar"
        Me.Cortar.Size = New System.Drawing.Size(104, 24)
        Me.Cortar.TabIndex = 74
        Me.Cortar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tela_necesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(926, 428)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Cortar, Me.Colo, Me.Estilo, Me.Cpo, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.fg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tela_necesa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Tela Necesaria por CPO - Estilo - Color"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tela_necesa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_fg()
        subtotales()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Cols.Count = 7
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "TELA"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "X CORTAR"
        fg.Cols(4).Name = "CONSUMO"
        fg.Cols(5).Name = "LBS.NEC."
        fg.Cols(6).Name = "ASIGNADA"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 150
            fg(0, index) = fg.Cols(index).Name
            If index > 2 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 90
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(4).DataType = GetType(Decimal)
        fg.Cols(4).Format = "####0.00"
        fg.Cols(3).AllowMerging = True
        fg.Cols(1).Width = 300
        fg.Cols(2).Width = 200
    End Sub

    Private Sub subtotales()
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 5, "Gran Total")
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 6, "Gran Total")
    End Sub
End Class
