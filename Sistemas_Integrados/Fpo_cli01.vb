Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class Fpo_cli01
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cat As New DataTable()
    Dim dr As DataRow
    Dim strSQl As String
    Dim cato As String
    Dim categoria As String
    Dim busca As String
    Dim t(18) As Integer
    Dim clientes As String
    Dim finicio As Date
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents regresa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Fpo_cli01))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sigue = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.AutoResize = False
        Me.fg.ColumnInfo = "20,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:83;Name:""CATEGORIA"";Caption:""CLIENTE"";AllowMerging:True;AllowEditing:Fal" & _
        "se;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:74;Name:""FPO"";Caption:""" & _
        "FPO"";AllowEditing:False;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:35" & _
        "1;Caption:""TIPO DE TELA"";AllowEditing:False;DataType:System.String;TextAlign:Lef" & _
        "tCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:200;Name:""COLOR"";Caption:""COLOR"";AllowEditing:False;DataType:S" & _
        "ystem.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:80;Caption:""SEMANA 0"";AllowEditing:F" & _
        "alse;DataType:System.Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixe" & _
        "d:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:80;Caption:""SEMANA 1"";AllowEditing:False;DataType:System" & _
        ".Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Wi" & _
        "dth:80;Caption:""SEMANA 2"";AllowEditing:False;DataType:System.Decimal;Format:""##," & _
        "##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:80;Caption:""SEMA" & _
        "NA 3"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0"";TextAlign:Right" & _
        "Center;TextAlignFixed:RightCenter;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:80;Caption:""" & _
        "SEMANA 4"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0"";TextAlign:R" & _
        "ightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:80;Caption:""SEMANA 5"";AllowEdit" & _
        "ing:False;DataType:System.Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlig" & _
        "nFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:80;Caption:""SEMANA 6"";AllowEditing:False;DataType:" & _
        "System.Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:80;Caption:""SEMANA 7"";AllowEditing:False;DataType:System.Decimal;Form" & _
        "at:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:80;Capti" & _
        "on:""SEMANA 8"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0"";TextAli" & _
        "gn:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:80;Caption:""SEMANA 9"";Allow" & _
        "Editing:False;DataType:System.Decimal;Format:""##,##0"";TextAlign:RightCenter;Text" & _
        "AlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:80;Caption:""SEMANA 10"";AllowEditing:False;Data" & _
        "Type:System.Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "16{Width:80;Caption:""SEMANA 11"";AllowEditing:False;DataType:System.Decima" & _
        "l;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "17{Width:80" & _
        ";Caption:""SEMANA 12"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0"";" & _
        "TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "18{Width:100;Caption:""> 12 SE" & _
        "MANAS"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0"";TextAlign:Righ" & _
        "tCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "19{Width:62;Name:""OFECHA"";Caption:""OFRECIDA" & _
        """;Visible:False;DataType:System.DateTime;Format:""dd-MM-yyyy"";TextAlign:LeftCente" & _
        "r;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 40)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1008, 640)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 9.75pt;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor" & _
        ":238, 163, 117;ForeColor:ControlText;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:242, 111, 170;ForeCol" & _
        "or:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat," & _
        "1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{" & _
        "Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlD" & _
        "arkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:Contro" & _
        "lDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "TOTALES{Font:Tahoma, 11.25pt, style=Bold;BackColor:Gold;}" & Microsoft.VisualBasic.ChrW(9) & "azul{BackColor:142, " & _
        "215, 227;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(960, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 78
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(920, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 77
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Visible = False
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(104, 8)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(240, 26)
        Me.cliente.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Bitmap)
        Me.sigue.Location = New System.Drawing.Point(880, 0)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 82
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Bitmap)
        Me.regresa.Location = New System.Drawing.Point(880, 0)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 83
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Fpo_cli01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1018, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.sigue, Me.Label1, Me.cliente, Me.Button3, Me.Button2, Me.fg, Me.regresa})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fpo_cli01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan de Entregas de Tela por Cliente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Serigra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM FPO WHERE STATUS = 'ABIERTO' AND RECIBIDAS = 0 ORDER BY CLIENTE", "CLIENTE")
        llena_tablas(cat, "SELECT * FROM TELA_CATEGORIA ORDER BY CATEGORIA", cnn)
        setea_fg()
    End Sub

    Private Sub setea_fg()
        Dim i As Integer
        Dim hoy As Date = Today
        Dim d As Integer
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Rows(0).Height = 40
        d = hoy.DayOfWeek
        d = (d * -1)
        hoy = hoy.AddDays(d)
        fg(0, 5) = Format(hoy, "dd-MMM-yyyy")
        finicio = hoy
        For i = 6 To 18
            hoy = hoy.AddDays(7)
            fg(0, i) = Format(hoy, "dd-MMM-yyyy")
            If i = 18 Then
                fg(0, 18) = fg(0, 18) + " < "
            End If
        Next
        ReDim t(18)
    End Sub

    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim fpo As String = ""
        Dim colo As String = ""
        Dim dom As Date
        Dim d As Integer
        Dim i As Integer
        Dim ofecha As Date
        Dim libras As Integer
        Dim res As Decimal
        Dim descripcion As String
        Dim strSQL As String = "SELECT FPO,DESCRIPCION,COLOR,CLIENTE,OFECHA,SUM(LIBRAS) AS LIBRAS  FROM FPO LEFT JOIN CODIGO_TELA ON FPO.CODIGO = CODIGO_TELA.CODIGO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO' AND TIPO = 'TELA' AND CLIENTE = '" & cliente.Text & "' GROUP BY FPO,DESCRIPCION,COLOR,CLIENTE,OFECHA ORDER BY CLIENTE,FPO,DESCRIPCION,COLOR,OFECHA"
        llena_tablas(dt, strSQL, cnn)
        dom = finicio
        For Each Me.dr In dt.Rows
            clientes = dr("CLIENTE")
            fpo = dr("FPO")
            colo = dr("COLOR")
            descripcion = dr("DESCRIPCION")
            busca = fpo + descripcion + colo
            l = fg.FindRow(busca, 1, 0, False)
            If l = -1 Then
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                fg(l, 0) = busca
                fg(l, 1) = clientes
                fg(l, 2) = fpo
                fg(l, 3) = descripcion
                fg(l, 4) = colo
            End If
            ofecha = dr("OFECHA")
            libras = dr("LIBRAS")
            d = DateDiff(DateInterval.Day, dom, ofecha)
            res = (d / 7)
            If d > 0 Then
                d = Fix(d / 7)
                res = res - d
                If res > 0 Then
                    d = d + 1
                End If
            Else
                d = 0
            End If
            If d > 12 Then
                d = 13
            End If
            fg(l, d + 5) = fg(l, d + 5) + libras
            t(d + 5) = t(d + 5) + libras
        Next
        l = fg.Rows.Count
        fg.Rows.Count = l + 1
        fg.Rows(l).Style = fg.Styles("TOTALES")
        fg.Rows(l).Height = 30
        fg(l, 4) = "TELA OFRECIDA"
        For i = 5 To 18
            fg(l, i) = t(i)
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyyy")
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
        fg.PrintGrid("inventario", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Plan de Entregas Cliente: " + cliente.Text + " al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub datos_excel(ByRef si As Boolean)
        Dim path As String = "c:\reportes\Entregas_cliente.xls"
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/  bajo el nombre de Entregas_categoria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        llena_fg()
        regresa.Visible = True
        sigue.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        cliente.Enabled = False
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        regresa.Visible = False
        sigue.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        cliente.Enabled = True
        setea_fg()
    End Sub
End Class




