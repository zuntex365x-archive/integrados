Imports C1.Win.C1FlexGrid

Public Class Tela_oc_1
    Inherits System.Windows.Forms.Form
    Public re As New C1.Win.C1FlexGrid.C1FlexGrid()
    Dim h As String = "######0.0000"
    Dim g As String = "######0.00"
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tela_oc_1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(248, Byte), CType(217, Byte), CType(197, Byte))
        Me.fg.ColumnInfo = "6,1,0,0,0,85,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:400;Caption:""Descripción de la Tela"";AllowEditing:False;TextAlign:LeftCen" & _
        "ter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:100;Caption:""Consumo Prom.E"";AllowEditin" & _
        "g:False;DataType:System.Decimal;Format:""###,##0.0000"";TextAlign:RightCenter;Text" & _
        "AlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:100;Caption:""Consumo Prom.R."";AllowEditing:Fals" & _
        "e;DataType:System.Decimal;Format:""###,##0.0000"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:100;Caption:""Diferencia"";AllowEditing:False;DataType:" & _
        "System.Decimal;Format:""###,##0.0000"";TextAlign:RightCenter;TextAlignFixed:RightC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:80;Caption:""%"";DataType:System.Decimal;Format:""###,##0.0000"";Tex" & _
        "tAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 6
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(808, 136)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:248, 217, 197;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:248, 217, 197;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:245, " & _
        "181, 158;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Bl" & _
        "ack;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:High" & _
        "lightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;B" & _
        "order:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Bla" & _
        "ck;ForeColor:White;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;For" & _
        "eColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{B" & _
        "ackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;F" & _
        "oreColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Red;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 54
        '
        'Tela_oc_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(806, 131)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tela_oc_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Tela por Tipo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Tela_oc_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_fg()
        llena_fg()
    End Sub

    Private Sub setea_fg()
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Rows.Count = 1
    End Sub

    Private Sub llena_fg()
        Dim i As Integer
        Dim j As Integer
        fg.Rows.Count = re.Rows.Count
        For i = 1 To re.Rows.Count - 1
            For j = 1 To 5
                fg(i, j) = re(i, j)
                Try
                    If CDec(re(i, j)) = 0 Then
                        fg(i, j) = 0
                    End If
                Catch
                End Try
            Next
            If fg(i, 5) > 100 Then
                fg.SetCellStyle(i, 5, fg.Styles("rojo"))
            End If
            If fg(i, 2) = 0 Then
                fg.SetCellStyle(i, 2, fg.Styles("rojo"))
                fg.SetCellStyle(i, 5, fg.Styles("rojo"))
            End If
        Next
    End Sub
End Class
