Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Embarque_corte
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim dt As New DataTable()
    Dim lineas As Integer
    Dim te(9) As String
    Dim fecha As String
    Dim fecha1 As String
    Dim path As String = "c:\reportes\embarcadas_corte.xls"
    Dim tallas_d(12) As String
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Embarque_corte))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        Me.fecha_f = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "21,1,0,0,0,85,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:116;Name:""EMBARQUE"";Caption:""EMBARQUE"";AllowMerging:True;TextAlign:LeftC" & _
        "enter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:113;Name:""CLIENTE"";Caption:""CLIENTE"";A" & _
        "llowMerging:True;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:140;Na" & _
        "me:""CPO"";Caption:""CPO"";AllowMerging:True;TextAlign:LeftCenter;TextAlignFixed:Lef" & _
        "tCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:143;Name:""ESTILO"";Caption:""ESTILO"";AllowMerging:True;TextAlign" & _
        ":LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:150;Name:""COLOR"";Caption:""COLOR""" & _
        ";AllowMerging:True;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Name:""CORT" & _
        "E"";Caption:""CORTE"";AllowMerging:True;TextAlign:LeftCenter;TextAlignFixed:LeftCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Name:""TIPO"";Caption:""TIPO"";TextAlign:LeftCenter;TextAlignFixed:LeftCente" & _
        "r;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:52;Name:""XS"";Caption:""XS"";DataType:System.Decimal;Format:""###,##0"";T" & _
        "extAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:52;Name:""S"";Caption:""" & _
        "S"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed" & _
        ":CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:52;Name:""M"";Caption:""M"";DataType:System.Decimal;Format:" & _
        """###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:52;Name:""" & _
        "L"";Caption:""L"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;Te" & _
        "xtAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:52;Name:""XL"";Caption:""XL"";DataType:System.D" & _
        "ecimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{W" & _
        "idth:52;Name:""2XL"";Caption:""2XL"";DataType:System.Decimal;Format:""###,##0"";TextAl" & _
        "ign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:52;Name:""3XL"";Caption:""3X" & _
        "L"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed" & _
        ":CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:52;Name:""4XL"";Caption:""4XL"";DataType:System.Decimal;For" & _
        "mat:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "16{Width:52;Na" & _
        "me:""5XL"";Caption:""5XL"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightC" & _
        "enter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "17{Width:52;Name:""6XL"";Caption:""6XL"";DataTyp" & _
        "e:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9) & "18{Width:60;Name:""TOTAL"";Caption:""TOTAL"";DataType:System.Decimal;Format:""#" & _
        "##,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "19{Width:70;Name:""FE" & _
        "CHA"";Caption:""FECHA"";AllowMerging:True;DataType:System.DateTime;Format:""dd/MMM/y" & _
        "yyy"";TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "20{Name:""BUSCA"";Caption:" & _
        """BUSCA"";Visible:False;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 72)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 608)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:255, 167, 79;ForeColo" & _
        "r:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Froze" & _
        "n{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,Cont" & _
        "rolDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:M" & _
        "icrosoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtot" & _
        "al1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186, 196, 228;ForeCo" & _
        "lor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:" & _
        "ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'fecha_i
        '
        Me.fecha_i.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.fecha_i.CustomFormat = "dd/MM/yyyy"
        Me.fecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha_i.Location = New System.Drawing.Point(144, 8)
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(136, 26)
        Me.fecha_i.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Fecha de la Produccion")
        '
        'fecha_f
        '
        Me.fecha_f.CustomFormat = "dd/MM/yyyy"
        Me.fecha_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_f.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha_f.Location = New System.Drawing.Point(144, 40)
        Me.fecha_f.Name = "fecha_f"
        Me.fecha_f.Size = New System.Drawing.Size(136, 26)
        Me.fecha_f.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Fecha de la Produccion")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(424, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 53
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(376, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 52
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Bitmap)
        Me.S1.Location = New System.Drawing.Point(328, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 58
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Bitmap)
        Me.CANCELA.Location = New System.Drawing.Point(328, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 59
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.CANCELA.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(328, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 60
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Embarque_corte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1002, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.S1, Me.Button3, Me.Button2, Me.fecha_f, Me.Label2, Me.Label1, Me.fecha_i, Me.fg, Me.CANCELA, Me.Button1})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Embarque_corte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cortes por Embarque"
        Me.ToolTip1.SetToolTip(Me, "Captacion de la Produccion diaria")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        ok = False
        Dim i As Integer
        Dim tipo As String
        Dim talla As String
        Dim prendas As Integer
        Dim cpo As String
        Dim estilo As String
        Dim colo As String
        Dim tallas As String = "XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6"
        Dim embarque As String
        Dim corte As String
        te = Split(tallas, ","c)
        Dim strSQL As String = "SELECT CLIENTE,CPO,ESTILO,COLOR,EMBARQUES.CORTE,TIPO,TALLA,EMBARQUE,FECHA,SUM(PRENDAS) AS PRENDA FROM EMBARQUES, CORTES WHERE  FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "' AND EMBARQUES.CORTE = CORTES.CORTE GROUP BY  CPO,ESTILO,COLOR,EMBARQUES.CORTE,TIPO,TALLA,CLIENTE,EMBARQUE,FECHA"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            cpo = dr("CPO")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            embarque = dr("EMBARQUE")
            corte = dr("CORTE")
            si = fg.FindRow(Trim(embarque) + Trim(corte), 1, 20, False)
            If si = -1 Then
                crea_otra_linea(corte)
            End If
            tipo = dr("TIPO")
            talla = dr("TALLA")
            prendas = dr("PRENDA")
            i = Array.IndexOf(te, talla)
            If tipo = 0 Then
                fg(si, i + 8) = fg(si, i + 8) + prendas
                fg(si, 18) = fg(si, 18) + prendas
            Else
                fg(si + 1, i + 8) = fg(si + 1, i + 8) + prendas
                fg(si + 1, 18) = fg(si + 1, 18) + prendas
            End If
        Next
        stock()
        subtotales()
    End Sub

    Private Sub crea_otra_linea(ByVal corte As String)
        Dim i As Integer
        fg.Rows.Count = fg.Rows.Count + 2
        lineas = fg.Rows.Count - 2
        For i = 0 To 1
            fg(lineas + i, 1) = dr("EMBARQUE")
            fg(lineas + i, 2) = dr("CLIENTE")
            fg(lineas + i, 3) = dr("CPO")
            fg(lineas + i, 4) = dr("ESTILO")
            fg(lineas + i, 5) = dr("COLOR")
            fg(lineas + i, 6) = corte
            fg(lineas + i, 19) = dr("FECHA")
            fg(lineas + i, 20) = Trim(dr("EMBARQUE")) + corte
        Next i
        fg(lineas, 7) = "Primeras"
        fg(lineas + 1, 7) = "Segundas"
        si = lineas
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        fg.Sort(SortFlags.Ascending, 1)
        With fg
            For i = 8 To 18
                fg.Subtotal(AggregateEnum.Sum, 1, 1, 2, i, "Subtotal")
                fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            Next i
        End With
    End Sub



    Private Sub chequea_fechas(ByRef ok As Boolean)
        ok = True
        fecha = Format(CDate(fecha_i.Text), "yyyy-MM-dd")
        fecha1 = Format(CDate(fecha_f.Text), "yyyy-MM-dd")
        If fecha1 < fecha Then
            fecha = fecha1
            ok = False
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Por favor verifique !!")
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        fecha = Format(Today, "dd/MM/yyy")
        mal = obj.nombre + "  Reporte de Prendas Embarcadas por Corte del " + Format(CDate(fecha_i.Text), "dd/MM/yyyy") + " al " + Format(CDate(fecha_f.Text), "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 30
            .Margins.Right = 30
            .Margins.Top = 50
            .Margins.Bottom = 30
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Empaque", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub datos_excel(ByRef si As Boolean)
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.Subtotal(AggregateEnum.Clear)
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            si = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        chequea_fechas(ok)
        If ok Then
            setea_grid()
            llena_grid()
            S1.Visible = False
            CANCELA.Visible = True
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            Button2.Visible = True
            Button3.Visible = True
        End If
    End Sub


    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        CANCELA.Visible = False
        S1.Visible = True
        fecha_i.Enabled = True
        fecha_f.Enabled = True
        Button2.Visible = False
        Button3.Visible = False
        setea_grid()
    End Sub

    Private Sub stock()
        Dim Cpo As String
        Dim Estilo As String
        Dim colo As String
        Dim tipo As String
        Dim talla As String
        Dim prendas As Integer
        Dim i As Integer
        Dim tallas As String = "XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL"
        Dim st As New DataTable()
        Dim dr As DataRow
        te = Split(tallas, ","c)
        Dim strSQL As String = "SELECT CLIENTE,CPO,ESTILO,COLOR,TIPO,TALLA,EMBARQUE,FECHA,SUM(PRENDAS) AS PRENDA FROM S_STOCK WHERE  FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "' GROUP BY  CPO,ESTILO,COLOR,TIPO,TALLA,CLIENTE,EMBARQUE,FECHA"
        llena_tablas(st, strSQL, cnn)
        For Each dr In st.Rows
            Cpo = dr("CPO")
            Estilo = dr("ESTILO")
            colo = dr("COLOR")
            si = fg.FindRow(Trim(dr("EMBARQUE")) + "STOCK", 1, 20, False)
            If si = -1 Then
                crea_otra_linea("STOCK")
            End If
            tipo = dr("TIPO")
            talla = dr("TALLA")
            prendas = dr("PRENDA")
            i = Array.IndexOf(te, talla)
            If tipo = 0 Then
                fg(si, i + 8) = fg(si, i + 8) + prendas
                fg(si, 18) = fg(si, 18) + prendas
            Else
                fg(si + 1, i + 8) = fg(si + 1, i + 8) + prendas
                fg(si + 1, 18) = fg(si + 1, 18) + prendas
            End If
        Next
    End Sub

End Class



