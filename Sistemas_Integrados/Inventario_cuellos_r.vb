Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Inventario_cuellos_r
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Inventario_cuellos_r))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Estado = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(592, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(536, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario .")
        '
        'C4
        '
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.Location = New System.Drawing.Point(120, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(112, 21)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(648, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 48
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario")
        Me.Button3.Visible = False
        '
        'Estado
        '
        Me.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado.Items.AddRange(New Object() {"CUELLOS Y PU�OS", "CUELLOS", "PU�OS"})
        Me.Estado.Location = New System.Drawing.Point(320, 16)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(144, 21)
        Me.Estado.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Estado, "Elija  el Tipo a Consultar")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(992, 616)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed" & _
        "{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlig" & _
        "ht{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackCol" & _
        "or:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTota" & _
        "l{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackCo" & _
        "lor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeCo" & _
        "lor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{Back" & _
        "Color:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Bitmap)
        Me.Button4.Location = New System.Drawing.Point(536, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 61
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.Visible = False
        '
        'Inventario_cuellos_r
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1006, 684)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Estado, Me.Label1, Me.fg, Me.Button3, Me.C4, Me.Button2, Me.Label2, Me.Button4})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_cuellos_r"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Cuellos y Pu�os  (Resumido)"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "##,###,##0.00"
    Dim g As String = "#,###,##0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Private Sub Inventario_tela_r_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_clientes(C4)
        C4.SelectedIndex = 0
        Estado.SelectedIndex = 0
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Clear()
            fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
            fg.Rows.Count = 1
            fg.Cols.Count = 13
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Name = "BATCH"
            fg.Cols(2).Name = "CLIENTE"
            fg.Cols(3).Name = "FPO"
            fg.Cols(4).Name = "TIPO"
            fg.Cols(5).Name = "MEDIDA"
            fg.Cols(6).Name = "COLOR"
            fg.Cols(7).Name = "ROLLOS"
            fg.Cols(8).Name = "UNIDADES"
            fg.Cols(9).Name = "COSTO U."
            fg.Cols(10).Name = "COSTO T."
            fg.Cols(11).Name = "CODIGO"
            fg.Cols(12).Name = "DESCRIPCION"
            fg.Cols(7).DataType = GetType(Decimal)
            fg.Cols(7).Format = g
            fg.Cols(7).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(7).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(8).DataType = GetType(Decimal)
            fg.Cols(8).Format = g
            fg.Cols(8).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.RightCenter

            fg.Cols(9).DataType = GetType(Decimal)
            fg.Cols(9).Format = h
            fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(9).TextAlignFixed = TextAlignEnum.RightCenter

            fg.Cols(10).DataType = GetType(Decimal)
            fg.Cols(10).Format = h
            fg.Cols(10).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(10).TextAlignFixed = TextAlignEnum.RightCenter

            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 90
                fg(0, index) = fg.Cols(index).Name
            Next
            fg.Cols(9).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(9).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(2).Width = 150
            fg.Cols(4).Width = 120
            fg.Cols(5).Width = 150
            fg.Cols(6).Width = 150
            fg.Cols(12).Width = 300
        Catch
        End Try
    End Sub

    Private Sub busca_tela()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String
        Dim estad As String
        Dim TIPO As String
        estad = CStr(Estado.SelectedIndex)
        If estad = "0" Then
            TIPO = " AND TIPO <> 'TELA' ORDER BY BATCH"
        Else
            TIPO = " AND TIPO = '" & Estado.SelectedItem & "'"
        End If
        If Trim(C4.Text) = "TODOS" Then
            strSQL = "SELECT count(ROLLO) AS ROLLO, SUM(YARDAS_I) AS INI, SUM(YARDAS) AS YARDA, SUM(PESO) AS LIBRAS, CLIENTE, BATCH, KNIT, COLOR, FPO , TIPO,ROLLOS.CODIGO,DESCRIPCION,COSTO FROM ROLLOS LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE YARDAS >0  " & TIPO & " GROUP BY BATCH, CLIENTE, FPO, TIPO, KNIT, COLOR,COSTO,ROLLOS.CODIGO,DESCRIPCION"
        Else
            strSQL = "SELECT count(ROLLO) AS ROLLO, SUM(YARDAS_I) AS INI ,SUM(YARDAS) AS YARDA, SUM(PESO) AS LIBRAS, CLIENTE, BATCH, KNIT, COLOR, FPO , TIPO, ROLLOS.CODIGO, DESCRIPCION,COSTO FROM ROLLOS LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE CLIENTE = '" & C4.Text & "' AND YARDAS >0 " & TIPO & " GROUP BY BATCH, CLIENTE, FPO, TIPO, KNIT, COLOR,COSTO,ROLLOS.CODIGO,DESCRIPCION "
        End If
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("CLIENTE")
            fg(lineas, 3) = dr("FPO")
            fg(lineas, 4) = dr("TIPO")
            fg(lineas, 5) = dr("KNIT")
            fg(lineas, 6) = dr("COLOR")
            fg(lineas, 7) = dr("ROLLO")
            fg(lineas, 8) = dr("YARDA")
            fg(lineas, 9) = dr("COSTO")
            fg(lineas, 10) = fg(lineas, 8) * fg(lineas, 9)
            fg(lineas, 11) = dr("CODIGO")
            fg(lineas, 12) = dr("DESCRIPCION")
            lineas = lineas + 1
        Next
        subtotales()
    End Sub


    Private Sub subtotales()
        With fg
            Dim rollos As Integer = fg.Cols("ROLLOS").Index
            Dim yardas As Integer = fg.Cols("UNIDADES").Index

            fg.Subtotal(AggregateEnum.Sum, 0, 0, rollos, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, yardas, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, 10, "Gran Total -->")

            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
        End With
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        setea_grid()
        busca_tela()
        Button1.Visible = False
        Button4.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        C4.Enabled = False
        Estado.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim MAL As String = ""
        If Estado.SelectedIndex > 0 Then
            MAL = "Tela con " + Estado.Text
        End If
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Inventario Cuellos y Pu�OS Al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/Telas  bajo el nombre de inventar_c_r.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Dim path As String = "c:\reportes\inventar_c_r.xls"
        Try
            fg.Subtotal(AggregateEnum.Clear)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)

            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            ok = False
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Visible = False
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        C4.Enabled = True
        Estado.Enabled = True
        setea_grid()
    End Sub
End Class
