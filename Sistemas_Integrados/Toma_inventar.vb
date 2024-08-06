Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Toma_inventar
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Fechas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Toma_inventar))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Fechas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.fg.Location = New System.Drawing.Point(8, 72)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fg.Size = New System.Drawing.Size(1008, 624)
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
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(384, 8)
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
        Me.Button1.Location = New System.Drawing.Point(336, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario de Telas. ")
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.White
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(120, 40)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(144, 21)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Bitmap)
        Me.Button4.Location = New System.Drawing.Point(336, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 52
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.Visible = False
        '
        'Fechas
        '
        Me.Fechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechas.Location = New System.Drawing.Point(120, 8)
        Me.Fechas.Name = "Fechas"
        Me.Fechas.Size = New System.Drawing.Size(120, 24)
        Me.Fechas.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.Fechas, "Cliente para el cual se efectuo el Corte.")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Toma_inventar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1022, 700)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Fechas, Me.Label1, Me.C4, Me.Button2, Me.fg, Me.Label2, Me.Button1, Me.Button4})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toma_inventar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado para toma de Inventario"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim E(7) As String
    Dim obj As New empresas()
    Dim StrSQL As String = "SELECT BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ACTIVO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'NADA'"

    Private Sub Toma_inventar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        llena_fechas()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.DataSource = GetDataSource()
            fg.Cols.Count = 14
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Caption = "CLIENTE"
            fg.Cols(2).Caption = "BATCH"
            fg.Cols(3).Caption = "ROLLO"
            fg.Cols(4).Caption = "FPO"
            fg.Cols(5).Caption = "CPO"
            fg.Cols(6).Caption = "KNIT"
            fg.Cols(7).Caption = "COLOR"
            fg.Cols(8).Caption = "YARDAS"
            fg.Cols(9).Caption = "LIBRAS"
            fg.Cols(10).Caption = "ESTADO"
            fg.Cols(11).Caption = "ANCHO"
            fg.Cols(12).Caption = "CODIGO B."
            fg.Cols(13).Caption = "OK"
            fg.Cols(3).DataType = GetType(Integer)
            fg.Cols(3).Format = g
            fg.Cols(3).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(3).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(8).DataType = GetType(Decimal)
            fg.Cols(8).Format = h
            fg.Cols(8).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(9).DataType = GetType(Decimal)
            fg.Cols(9).Format = h
            fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(9).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(12).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(12).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(13).DataType = GetType(Boolean)
            fg.Cols(13).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(13).TextAlignFixed = TextAlignEnum.CenterCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 90
                fg(0, index) = fg.Cols(index).Caption
                If index > 7 Then
                    fg.Cols(index).Width = 70
                End If
            Next
            fg.Cols(1).Width = 90
            fg.Cols(2).Width = 80
            fg.Cols(3).Width = 50
            fg.Cols(6).Width = 150
            fg.Cols(7).Width = 150
            fg.Cols(13).Width = 50
            fg.Sort(SortFlags.Ascending, 2, 3)
            'fg.Sort(SortFlags.Ascending, 1, 2)
            subtotales()
        Catch
        End Try
    End Sub

    Private Sub subtotales()
        With fg
            .Redraw = False
            Dim totalya As Integer = fg.Cols("YARDAS").Index
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
            .Redraw = True
        End With
    End Sub

    Private Sub setea_busqueda()
        Dim fecha As String = Format(CDate(Fechas.Text), "MM-dd-yyyy")
        StrSQL = "SELECT TOMA_INV.CLIENTE,TOMA_INV.BATCH,TOMA_INV.ROLLO,FPO,CPO,KNIT,COLOR,TOMA_INV.YARDAS, LIBRAS, (SELECT ESTADO_TELA FROM ESTADOS_TELA WHERE ACTIVO = CODIGO) AS ACTIVO, ANCHO, TOMA_INV.BARRA FROM TOMA_INV LEFT JOIN ROLLOS ON TOMA_INV.BATCH = ROLLOS.BATCH AND TOMA_INV.ROLLO = ROLLOS.ROLLO WHERE FECHA = '" & fecha & "' "
        If Trim(C4.Text) <> "TODOS" Then
            StrSQL = StrSQL + " AND TOMA_INV.CLIENTE = '" & C4.Text & "' "
        End If
        StrSQL = StrSQL + " ORDER BY TOMA_INV.CLIENTE, TOMA_INV.BATCH, TOMA_INV.ROLLO "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        Button1.Visible = False
        Button2.Visible = True
        Button4.Visible = True
        Fechas.Enabled = False
        C4.Enabled = False
        setea_busqueda()
        setea_grid()
        Cursor = Cursors.Default
        fg.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Cursor = Cursors.WaitCursor
        Print_fg()
        otra_busqueda()
        Cursor = Cursors.Default
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim empre As String = obj.nombre
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "(" + empre + ") Listado para toma de Inventario al : " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Function GetDataSource() As DataTable
        Dim dt As New DataTable()
        llena_tablas(dt, StrSQL, cnn)
        def_sql(cnn)
        GetDataSource = dt
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        otra_busqueda()
    End Sub

    Private Sub otra_busqueda()
        Button2.Visible = False
        Button4.Visible = False
        Button1.Visible = True
        C4.Enabled = True
        Fechas.Enabled = True
        StrSQL = "SELECT CLIENTE,BATCH,ROLLO,FPO,CPO,KNIT,COLOR,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ACTIVO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'NADA'"
        setea_grid()
    End Sub

    Private Sub fg_aftersort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles fg.AfterSort
        subtotales()
    End Sub


    Private Sub llena_fechas()
        Dim strsql As String = "SELECT DISTINCT FECHA FROM TOMA_INV"
        Dim fecha As String
        Dim dt As New DataTable()
        Dim dr As DataRow
        Fechas.Items.Clear()
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            fecha = Format(dr("FECHA"), "dd/MM/yyyy")
            Fechas.Items.Add(fecha)
        Next
        If Fechas.Items.Count > 0 Then
            Fechas.SelectedIndex = 0
        End If
    End Sub

    Private Sub llena_clientes()
        Try
            Dim f As String = Fechas.Text
            Dim strsql As String = "SELECT DISTINCT CLIENTE FROM TOMA_INV WHERE FECHA = '" & Mid(f, 7, 4) & "-" & Mid(f, 4, 2) & "-" & Mid(f, 1, 2) & "' ORDER BY CLIENTE"
            Dim dt As New DataTable()
            Dim dr As DataRow
            C4.Items.Clear()
            C4.Items.Add("TODOS")
            llena_tablas(dt, strsql, cnn)
            For Each dr In dt.Rows
                C4.Items.Add(dr("CLIENTE"))
            Next
            If C4.Items.Count > 0 Then
                C4.SelectedIndex = 0
            End If
        Catch
        End Try
    End Sub

    Private Sub Fechas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechas.SelectedIndexChanged
        llena_clientes()
    End Sub
End Class
