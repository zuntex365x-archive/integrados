Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Inventario_tela
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Estado As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_tela))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Estado = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 632)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(721, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(639, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario de Telas. ")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.White
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(120, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(228, 21)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(763, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 49
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Estado
        '
        Me.Estado.BackColor = System.Drawing.Color.White
        Me.Estado.ForeColor = System.Drawing.Color.Black
        Me.Estado.Location = New System.Drawing.Point(455, 16)
        Me.Estado.MaxDropDownItems = 10
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(144, 21)
        Me.Estado.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.Estado, "Elija el Estado de la Tela a Consultar")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(680, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 52
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(367, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Estado:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inventario_tela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 684)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_tela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Tela (Detallado)"
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
    Dim obj As empresas
    Dim fe As New DataTable
    Dim StrSQL As String = "SELECT  DISTINCT  BATCH, FECHA FROM DMOVTO WHERE TMOVTO = '1' AND BATCH IN(SELECT BATCH FROM ROLLOS WHERE YARDAS > 0) ORDER BY FECHA "

    Private Sub Tela_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        Estado_Tela(cnn, Estado)
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM ROLLOS WHERE YARDAS > 0 AND TIPO = 'TELA' ORDER BY CLIENTE", "CLIENTE")
        C4.Items.Add("TODOS")
        setea_grid()
        Try
            C4.SelectedIndex = 0
            Estado.SelectedIndex = 0
        Catch
        End Try
        llena_tablas(fe, StrSQL, cnn)
    End Sub

    Private Sub setea_grid()
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.Rows.Count = 1
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim i As Integer
        Dim dd As DataRow()
        Dim dj As DataRow
        ' fg.Cols.Count = 21
        llena_tablas(dt, StrSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            For i = 0 To 18
                fg(l, i + 1) = dr(i)
                If i + 1 = 6 Then
                    fg(l, i + 1) = fg(l, i + 1) + vbLf
                End If
            Next
            dd = fe.Select("BATCH = '" & dr("BATCH") & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                fg(l, 19) = dj("FECHA")
            End If
            fg(l, 20) = dr("E_TELA")
            l = l + 1
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        fg.ScrollBars = ScrollBars.Both
        With fg
            Try

                .Redraw = True
                Dim totalya As Integer = fg.Cols("YARDAS").Index
                Dim totalro As Integer = fg.Cols("ROLLO").Index
                'fg.Subtotal(AggregateEnum.Sum, 1, 4, totalya, "Total Batch")
                Dim totalib As Integer = fg.Cols("LIBRAS").Index
                ' fg.Subtotal(AggregateEnum.Sum, 1, 4, totalib, "Total Batch")
                fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
                fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
                fg.Subtotal(AggregateEnum.Count, 0, 0, totalro, "Gran Total -->")
                'change backcolor of subtotals
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
                .Redraw = True
                'fg.Tree.Show(1)
            Catch
            End Try

        End With
    End Sub

    Private Sub setea_busqueda()
        Dim estad As String
        estad = CStr(Estado.SelectedIndex)
        If Trim(C4.Text) = "TODOS" Then
            StrSQL = "SELECT ROLLOS.BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,YFIBER,ROLLOS.ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ESTADOS_TELA.ESTADO_TELA, ANCHO, ROLLOS.TONALIDAD, ROLLOS.CODIGO, DESCRIPCION ,(SELECT TOP(1) TEXTILERA FROM FPO WHERE FPO = ROLLOS.FPO) AS TEXTILERA  , BODEGAS.BODEGA, VIEJO , ESTADOS_TELA.ESTADO_TELA AS E_TELA,ROLLOS.ACTIVO FROM ROLLOS  LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO LEFT JOIN BODEGAS ON ROLLOS.BODEGA = BODEGAS.CODIGO LEFT JOIN ROLLOS_E ON ROLLOS.BATCH = ROLLOS_E.BATCH AND ROLLOS.ROLLO = ROLLOS_E.ROLLO LEFT JOIN ESTADOS_TELA ON (CASE WHEN ROLLOS.ACTIVO = 'S' AND ROLLOS_E.ESTADO IS NULL THEN '0' ELSE ROLLOS_E.ESTADO END ) = ESTADOS_TELA.CODIGO WHERE YARDAS >0 AND TIPO = 'TELA'"
        Else
            StrSQL = "SELECT ROLLOS.BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,YFIBER,ROLLOS.ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ESTADOS_TELA.ESTADO_TELA, ANCHO, ROLLOS.TONALIDAD,ROLLOS.CODIGO, DESCRIPCION ,(SELECT TOP(1) TEXTILERA FROM FPO WHERE FPO = ROLLOS.FPO) AS TEXTILERA  , BODEGAS.BODEGA, VIEJO , ESTADOS_TELA.ESTADO_TELA AS E_TELA,ROLLOS.ACTIVO FROM ROLLOS  LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO LEFT JOIN BODEGAS ON ROLLOS.BODEGA = BODEGAS.CODIGO LEFT JOIN ROLLOS_E ON ROLLOS.BATCH = ROLLOS_E.BATCH AND ROLLOS.ROLLO = ROLLOS_E.ROLLO LEFT JOIN ESTADOS_TELA ON (CASE WHEN ROLLOS.ACTIVO = 'S' AND ROLLOS_E.ESTADO IS NULL THEN '0' ELSE ROLLOS_E.ESTADO END ) = ESTADOS_TELA.CODIGO WHERE CLIENTE = '" & C4.Text & "' AND YARDAS >0 AND TIPO = 'TELA'"
        End If
        If Estado.Text <> "TODOS" Then
            StrSQL = StrSQL + " AND ESTADOS_TELA.ESTADO_TELA = '" & Estado.Text & "'"
        Else
            StrSQL = StrSQL + " AND (ACTIVO = '0' OR ACTIVO = 'S') "
        End If
        StrSQL = StrSQL + " ORDER BY BATCH "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        C4.Enabled = False
        Estado.Enabled = False
        setea_busqueda()
        setea_grid()
        llena_grid()
        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String = ""
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        If Estado.SelectedIndex > 0 Then
            mal = "Tela con " + Estado.Text
        End If
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Inventario de Tela al : " + fecha + "    " + mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:\reportes  bajo el nombre de Inventario_d ", MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
            Close()
        Else
            subtotales()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Dim path As String = "c:\reportes\inventario_d.xls"
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            fg(i, 1) = fg(i, 1) + Chr(10)
        Next
        Try
            fg.Subtotal(AggregateEnum.Clear)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            ok = False
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button1.Visible = True
        C4.Enabled = True
        Estado.Enabled = True
        setea_grid()
    End Sub


    Private Sub fg_aftersort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles fg.AfterSort
        subtotales()
    End Sub

    Private Sub fg_filter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub

    Private Sub estado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estado.KeyPress
        AutoCompletar(Estado, e)
    End Sub
End Class
