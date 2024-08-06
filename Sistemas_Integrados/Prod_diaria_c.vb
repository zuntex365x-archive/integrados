Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Prod_diaria_c
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents excel As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents mes As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Prod_diaria_c))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imprime = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.excel = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.mes = New System.Windows.Forms.DateTimePicker()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mes:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Bitmap)
        Me.imprime.Location = New System.Drawing.Point(264, 8)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(35, 35)
        Me.imprime.TabIndex = 45
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(216, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar la Consulta.")
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Bitmap)
        Me.excel.Location = New System.Drawing.Point(312, 8)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(35, 35)
        Me.excel.TabIndex = 49
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Bitmap)
        Me.CANCELA.Location = New System.Drawing.Point(216, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Otro Pedido")
        Me.CANCELA.Visible = False
        '
        'mes
        '
        Me.mes.CustomFormat = "MM/yyyy"
        Me.mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mes.Location = New System.Drawing.Point(80, 16)
        Me.mes.Name = "mes"
        Me.mes.ShowUpDown = True
        Me.mes.Size = New System.Drawing.Size(96, 26)
        Me.mes.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.mes, "Mes")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "19,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:158;Caption:""DIA"";}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:99;Name:""A"";Caption:""A"";DataType:System.Deci" & _
        "mal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;ImageAlig" & _
        "n:RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Name:""B"";Caption:""B"";DataType:Syst" & _
        "em.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "4{Name:""C"";Caption:""C"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightC" & _
        "enter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Name:""D"";Caption:""D"";DataType:System.Decim" & _
        "al;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Name:""" & _
        "E"";Caption:""E"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;Te" & _
        "xtAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Name:""F"";Caption:""F"";DataType:System.Decimal;Forma" & _
        "t:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Name:""G"";Capti" & _
        "on:""G"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Name:""H"";Caption:""H"";DataType:System.Decimal;Format:""###,#" & _
        "#0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Name:""I"";Caption:""I"";" & _
        "DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:Ce" & _
        "nterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Name:""J"";Caption:""J"";DataType:System.Decimal;Format:""###,##0"";Te" & _
        "xtAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Name:""K"";Caption:""K"";DataTy" & _
        "pe:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCe" & _
        "nter;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Name:""L"";Caption:""L"";DataType:System.Decimal;F" & _
        "ormat:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Name:""M"";" & _
        "Caption:""M"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextA" & _
        "lignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Name:""N"";Caption:""N"";DataType:System.Decimal;Format:" & _
        """###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "16{Name:""O"";Captio" & _
        "n:""O"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFi" & _
        "xed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "17{Name:""P"";Caption:""P"";DataType:System.Decimal;Format:""###,#" & _
        "#0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "18{Name:""TOTAL"";Caption:" & _
        """TOTAL"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlign" & _
        "Fixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 23
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 624)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 11.25pt;Border:Dotted,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackCo" & _
        "lor:255, 167, 79;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Back" & _
        "Color:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:High" & _
        "light;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{Back" & _
        "Color:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Bla" & _
        "ck;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Con" & _
        "trolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:C" & _
        "ontrolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackCol" & _
        "or:Gold;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 62
        '
        'Prod_diaria_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.mes, Me.fg, Me.excel, Me.Button1, Me.imprime, Me.Label2, Me.CANCELA})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_diaria_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción Diaria por Sección"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim pla As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Private Sub Prod_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 50
        mes.Text = CDate("01/" + mes.Text)
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim rg As New CellRange()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 40
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        print_fg()
    End Sub

    Private Sub print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("prendas_prod", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Prendas producidas del mes de   " & mes.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\prendas_prod.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
    '================================== llena mes  ==========================
    Private Sub llena_mes()
        Dim dt As New DataTable()
        Dim strsql As String
        Dim p As Integer
        Dim s As Integer
        Dim meses As String = Mid(mes.Text, 1, 2)
        Dim ano As String = Mid(mes.Text, 4, 4)
        Dim fecha As String
        Dim prendas As String
        Dim dr As DataRow
        strsql = "SELECT FECHA,SECCION,SUM(PRENDAS)AS PRODUCCION ,AVG(VALOR) AS PROMEDIO FROM PRODUCCION WHERE MONTH(FECHA) = '" & meses & "' AND YEAR(FECHA) = '" & ano & "' GROUP BY FECHA,SECCION"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            fecha = Format(dr("FECHA"), "dd - dddddd ")
            prendas = dr("PRODUCCION")
            s = fg.Cols(dr("SECCION")).Index
            p = fg.FindRow(fecha, 1, 1, True)
            If s > 0 Then
                If p > 0 Then
                    fg(p, s) = fg(p, s) + prendas
                    fg(p, 18) = fg(p, 18) + prendas
                Else
                    p = fg.Rows.Count
                    fg.Rows.Count = p + 1
                    fg(p, 1) = fecha
                    fg(p, s) = fg(p, s) + prendas
                    fg(p, 18) = fg(p, 18) + prendas
                End If
            End If
        Next

        For p = 2 To fg.Cols.Count - 1
            fg.Subtotal(AggregateEnum.Sum, 0, 0, p, "Gran Total -->")
            Try
                If fg(fg.Rows.Count - 1, p) = 0 Then
                    fg.Cols(p).Visible = False
                End If
                fg.Rows(fg.Rows.Count - 1).Height = 30
                fg(fg.Rows.Count - 1, 1) = "TOTALES ------>"
            Catch
            End Try
        Next
    End Sub

    Private Sub procesa()
        Button1.Visible = False
        mes.Enabled = False
        llena_mes()
        CANCELA.Visible = True
        imprime.Visible = True
        excel.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        procesa()
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        visibles()
        setea_grid()
        CANCELA.Visible = False
        imprime.Visible = False
        excel.Visible = False
        Button1.Visible = True
        mes.Enabled = True
    End Sub

    Private Sub visibles()
        Dim i As Integer
        For i = 1 To fg.Cols.Count - 1
            fg.Cols(i).Visible = True
        Next
    End Sub

    Private Sub mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
