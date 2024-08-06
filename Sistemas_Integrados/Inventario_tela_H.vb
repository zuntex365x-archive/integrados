Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Inventario_tela_H
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_tela_H))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Estado = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(579, 8)
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
        Me.Button1.Location = New System.Drawing.Point(536, 8)
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
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(120, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(112, 21)
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
        Me.Button3.Location = New System.Drawing.Point(621, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 48
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Estado
        '
        Me.Estado.BackColor = System.Drawing.Color.White
        Me.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado.ForeColor = System.Drawing.Color.Black
        Me.Estado.Location = New System.Drawing.Point(352, 16)
        Me.Estado.MaxDropDownItems = 10
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(144, 21)
        Me.Estado.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Estado, "Elija el Estado a Consultar")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(536, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 54
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(984, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Estado:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inventario_tela_H
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 684)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_tela_H"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Tela con fecha de Ingreso"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim StrSQL As String = "SELECT BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,YFIBER,ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ACTIVO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'NADA'"
    Dim lineas As Integer
    Dim e(7) As String
    Private Sub Inventario_tela_r_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Estado_Tela(cnn, Estado)
        llena_clientes(C4)
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
            fg.ScrollBars = ScrollBars.None
            'fg.Rows.Count = 1
            fg.Cols.Count = 16
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Name = "INGRESO"
            fg.Cols(2).Name = "CLIENTE"
            fg.Cols(3).Name = "FPO"
            fg.Cols(4).Name = "KNIT"
            fg.Cols(5).Name = "COLOR"
            fg.Cols(6).Name = "FIBRA"
            fg.Cols(7).Name = "CPO"
            fg.Cols(8).Name = "BATCH"
            fg.Cols(9).Name = "ROLLO"
            fg.Cols(10).Name = "YARDAS"
            fg.Cols(11).Name = "LIBRAS"
            fg.Cols(12).Name = "COSTO"
            fg.Cols(13).Name = "ESTADO"
            fg.Cols(14).Name = "CODIGO"
            fg.Cols(15).Name = "DESCRIPCION DE LA TELA"
            fg.Cols(1).DataType = GetType(Date)
            fg.Cols(1).Format = "dd/MMM/yyyy"
            fg.Cols(1).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(9).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(9).TextAlignFixed = TextAlignEnum.CenterCenter
            For index = 1 To fg.Cols.Count - 1
                If index > 9 And index < 13 Then
                    fg.Cols(index).DataType = GetType(Decimal)
                    fg.Cols(index).Format = h
                    fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                    fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                End If
                fg.Cols(index).Width = 70
                fg(0, index) = fg.Cols(index).Name
            Next
            fg.Cols(1).Width = 90
            fg.Cols(4).Width = 150
            fg.Cols(5).Width = 150
            fg.Cols(2).Width = 80
            fg.Cols(6).Width = 90
            fg.Cols(9).Width = 60
            fg.Cols(13).Width = 150
            fg.Cols(15).Width = 250
        Catch
        End Try
        llena_fg()
    End Sub

    Private Sub busca_tela()
        Dim estad As String
        estad = CStr(Estado.SelectedIndex)
        StrSQL = "SELECT FECHA, ROLLOS.CLIENTE, ROLLOS.FPO, KNIT, COLOR,YFIBER, ROLLOS.CPO, ROLLOS.BATCH, ROLLOS.ROLLO AS ROLLO, ROLLOS.YARDAS  AS YARDAS, (ROLLOS.PESO)/ (ROLLOS.YARDAS_I) *  (ROLLOS.YARDAS) AS LIBRAS, (COSTO * ((PESO/YARDAS_I)*ROLLOS.YARDAS)) AS COSTOS, ESTADO_TELA, ROLLOS.CODIGO, DESCRIPCION FROM ROLLOS LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO LEFT JOIN ESTADOS_TELA ON ESTADOS_TELA.CODIGO = ACTIVO LEFT JOIN  DMOVTO ON  DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' WHERE ROLLOS.YARDAS > 0 AND TIPO = 'TELA' "
        If Trim(C4.Text) <> "TODOS" Then
            StrSQL = StrSQL + " AND  ROLLOS.CLIENTE = '" & C4.Text & "' "
        End If
        If Estado.Text <> "TODOS" Then
            If estad = 0 Then
                StrSQL = StrSQL + " AND (ACTIVO = '0' OR ACTIVO = 'S') "
            Else
                StrSQL = StrSQL + " AND ACTIVO = '" & estad & "'"
            End If
        End If
        StrSQL = StrSQL + " ORDER BY FECHA"
    End Sub


    Private Sub subtotales()
        With fg
            Dim costos As Integer = fg.Cols("COSTO").Index
            Dim yardas As Integer = fg.Cols("YARDAS").Index
            Dim libras As Integer = fg.Cols("LIBRAS").Index

            fg.Subtotal(AggregateEnum.Sum, 0, 0, costos, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, yardas, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, libras, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
        End With
        fg.ScrollBars = ScrollBars.Both
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        busca_tela()
        setea_grid()
        subtotales()
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        C4.Enabled = False
        Estado.Enabled = False
        Cursor = Cursors.Default
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Inventario de Tela al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/Telas  bajo el nombre de Inventario_r ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Dim path As String = "c:\inventario_r.xls"
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
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button1.Visible = True
        C4.Enabled = True
        Estado.Enabled = True
        StrSQL = "SELECT BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,YFIBER,ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ACTIVO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'NADA'"
        setea_grid()
    End Sub


    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        llena_tablas(dt, StrSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        i = 1
        For Each dr In dt.Rows
            fg(i, 1) = dr("FECHA")
            fg(i, 2) = dr("CLIENTE")
            fg(i, 3) = dr("FPO")
            fg(i, 4) = dr("KNIT")
            fg(i, 5) = dr("COLOR")
            fg(i, 6) = dr("YFIBER")
            fg(i, 7) = dr("CPO")
            fg(i, 8) = dr("BATCH")
            fg(i, 9) = dr("ROLLO")
            fg(i, 10) = dr("YARDAS")
            fg(i, 11) = dr("LIBRAS")
            fg(i, 12) = dr("COSTOS")
            fg(i, 13) = dr("ESTADO_TELA")
            fg(i, 14) = dr("CODIGO")
            fg(i, 15) = dr("DESCRIPCION")
            i = i + 1
        Next

    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As SortColEventArgs) Handles fg.AfterSort
        subtotales()
    End Sub
End Class
