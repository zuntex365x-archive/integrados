Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class FPO_consul2
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim STRSQL As String
    Dim CSQL As String
    Dim CLIENTE As String
    Dim ESTADO As String
    Dim lineas As Integer
    Dim ROLLO As String


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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FPOS As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPO_consul2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FPOS = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(608, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Una vez Seleccionado el Cliente y el  FPO  presione aqui para ver los resultados." & _
                "")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(664, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 44
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'FPOS
        '
        Me.FPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPOS.Location = New System.Drawing.Point(16, 24)
        Me.FPOS.Name = "FPOS"
        Me.FPOS.Size = New System.Drawing.Size(240, 24)
        Me.FPOS.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FPOS, "Elija la Fabric PO  a Consultar .")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(720, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 51
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(608, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 52
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Limpiar los valores ingresados SIN  grabar NADA.")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(992, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "FPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FPO_consul2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1006, 668)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.FPOS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPO_consul2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Resumen de Tela por FPO"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_consul2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        busca_fpos()
        setea_grid()
        FPOS.Focus()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Clear(ClearFlags.Style)
            fg.ScrollBars = ScrollBars.None
            fg.Rows.Count = 1
            fg.Cols.Count = 13
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            fg.Cols(1).Name = "FPO"
            fg.Cols(2).Name = "COLOR"
            fg.Cols(3).Name = "KNIT"
            fg.Cols(4).Name = "ITEM"
            fg.Cols(5).Name = "LOTE"
            fg.Cols(6).Name = "LBS.PEDIDAS"
            fg.Cols(7).Name = "LBS.RECIBI."
            fg.Cols(8).Name = "DIFERENCIA"
            fg.Cols(9).Name = "YDS.RECIBI."
            fg.Cols(10).Name = "YDS.O.INGRE."
            fg.Cols(11).Name = "YDS. SALIDAS"
            fg.Cols(12).Name = "YDS INVENTA."
            fg.Cols(5).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(5).TextAlignFixed = TextAlignEnum.RightCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 110
                fg(0, index) = fg.Cols(index).Name
                If index > 4 Then
                    fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                    fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    fg.Cols(index).Format = h
                End If
            Next
            fg.Cols(5).Format = g
            fg.Cols(1).Width = 100
            fg.Cols(2).Width = 200
            fg.Cols(3).Width = 200
            fg.Cols(4).Width = 60
            fg.Cols(5).Width = 80
            Dim s As C1.Win.C1FlexGrid.CellStyle
            s = fg.Styles.Add("verde")
            s.ForeColor = Color.White
            s.BackColor = Color.Green
            s = fg.Styles.Add("amarillo")
            s.ForeColor = Color.Black
            s.BackColor = Color.Yellow
            s = fg.Styles.Add("rojo")
            s.ForeColor = Color.White
            s.BackColor = Color.Red
        Catch
        End Try
    End Sub

    Private Sub llena_grid()
        ok = False
        lineas = 0
        llena_fpo()
        llena_yardas()
        subtotales()
    End Sub

    Private Sub llena_yardas()
        Dim i As Integer
        Dim TIPO As String
        Dim KNIT As String
        Dim COL As String
        Dim YARDAS As Decimal
        Dim LIBRAS As Decimal
        Dim MOVTO As String
        Dim LOTE As String
        Dim dt As New DataTable()
        Dim dr As DataRow
        STRSQL = "SELECT DMOVTO.TMOVTO, ROLLOS.KNIT, ROLLOS.COLOR, ROLLOS.TIPO, ROLLOS.BATCH,SUM(DMOVTO.YARDAS) AS YARDA, SUM(DMOVTO.LIBRAS) AS LIBRA  FROM DMOVTO, ROLLOS WHERE DMOVTO.FPO = '" & FPOS.Text & "' AND  DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO GROUP BY DMOVTO.TMOVTO, ROLLOS.KNIT, ROLLOS.COLOR, ROLLOS.TIPO, ROLLOS.BATCH"
        llena_tablas(dt, STRSQL, cnn)
        For Each dr In dt.Rows
            KNIT = dr("KNIT")
            COL = dr("COLOR")
            TIPO = dr("TIPO")
            LOTE = dr("BATCH")
            lineas = fg.FindRow(COL + KNIT + TIPO + dr("BATCH"), 0, 0, True)
            YARDAS = dr("YARDA")
            LIBRAS = dr("LIBRA")
            MOVTO = dr("TMOVTO")
            If lineas > 0 Then
                If MOVTO = 1 Then
                    fg(lineas, 7) = fg(lineas, 7) + LIBRAS
                    fg(lineas, 9) = fg(lineas, 9) + YARDAS
                End If
                If MOVTO > 1 And MOVTO < 4 Then
                    fg(lineas, 10) = fg(lineas, 10) + YARDAS
                End If
                If MOVTO > 3 Then
                    fg(lineas, 11) = fg(lineas, 11) + YARDAS
                End If
                fg(lineas, 12) = fg(lineas, 9) + fg(lineas, 10) - fg(lineas, 11)
            End If
        Next
        For i = 1 To fg.Rows.Count - 1
            fg(i, 8) = fg(i, 7) - fg(i, 6)
            If CDec(fg(i, 8)) < 0 Then
                fg.SetCellStyle(i, 8, fg.Styles("rojo"))
            End If
            fg(i, 0) = ""
        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button1.Visible = False
        FPOS.Enabled = False
        setea_grid()
        llena_grid()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Print_fg()
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
        fg.PrintGrid("inventario2", PrintGridFlags.ShowPreviewDialog, "Resumen de Movtos.  FPO: " + Trim(FPOS.Text) + "  AL  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub subtotales()
        fg.ScrollBars = ScrollBars.Both
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.Cols(4).AllowMerging = True
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 6, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 7, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 8, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 12, "Gran TOTAL ---->")
        Cursor = Cursors.Default
    End Sub

    Private Sub busca_fpos()
        FPOS.Items.Clear()
        Dim strSQL As String = "SELECT DISTINCT FPO FROM FPO ORDER BY FPO "
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            FPOS.Items.Add(dr("FPO"))
        Next
        Try
            FPOS.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub llena_fpo()
        Dim TIPO As String
        Dim KNIT As String
        Dim COL As String
        Dim LOTE As Integer
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT KNIT, COLOR, TIPO, LOTE,  LIBRAS FROM FPO WHERE FPO  = '" & FPOS.Text & "'ORDER BY COLOR, KNIT, TIPO, LOTE "
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            lineas = lineas + 1
            fg.Rows.Count = lineas + 1
            KNIT = dr("KNIT")
            COL = dr("COLOR")
            TIPO = dr("TIPO")
            LOTE = dr("LOTE")
            fg(lineas, 0) = Trim(COL) + Trim(KNIT) + Trim(TIPO) + CStr(LOTE)
            fg(lineas, 1) = FPOS.Text
            fg(lineas, 2) = COL
            fg(lineas, 3) = KNIT
            fg(lineas, 4) = TIPO
            fg(lineas, 5) = LOTE
            fg(lineas, 6) = dr("LIBRAS")
            fg(lineas, 12) = 0
        Next
    End Sub

    Private Sub datos_excel(ByRef si As Boolean)
        Dim path As String = "c:\reportes\Fpos_tela.xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.Subtotal(AggregateEnum.Clear)
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            si = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:\reportes\  bajo el nombre de Diaria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        setea_grid()
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button1.Visible = True
        FPOS.Enabled = True
        FPOS.Focus()
    End Sub
    Private Sub fpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FPOS.KeyPress
        AutoCompletar(FPOS, e)
    End Sub


End Class
