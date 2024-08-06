Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Ingreso_texpasa
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim EXISTE As Boolean
    Dim constr(2) As String
    Dim lineas As Integer
    Dim abrear As New OpenFileDialog()
    Dim archivo As String
    Dim o As String = "00,00,01,02,08,06,04,05,03,09,10"
    Dim fpos As String = ""
    Dim batches As String = ""
    Dim cols As String
    Dim envios As String = ""
    Dim f(10) As String
    Dim e(2) As String
    Dim fpo0 As New DataTable()
    Dim fpo1 As New DataTable()
    Dim fpo2 As New DataTable()
    Friend WithEvents despacho As System.Windows.Forms.ComboBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    ' Dim despacho As String = ""
    Dim cnnl As New SqlClient.SqlConnection
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
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fp As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Re As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_texpasa))
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.Button()
        Me.Re = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.sigue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.despacho = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Re, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(19, 163)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(112, 20)
        Me.fecha.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha de Recepcion de los Rollos de Tela.")
        Me.fecha.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 185)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1183, 564)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.fg, "Detalle del Manifiesto")
        '
        'fp
        '
        Me.fp.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fp.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fp.BackColor = System.Drawing.Color.White
        Me.fp.ColumnInfo = resources.GetString("fp.ColumnInfo")
        Me.fp.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fp.ForeColor = System.Drawing.Color.Black
        Me.fp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fp.Location = New System.Drawing.Point(12, 185)
        Me.fp.Name = "fp"
        Me.fp.Rows.DefaultSize = 19
        Me.fp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fp.Size = New System.Drawing.Size(760, 448)
        Me.fp.StyleInfo = resources.GetString("fp.StyleInfo")
        Me.fp.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fp.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.fp, "Para Eliminar la fila  Presione  Doble-Click")
        Me.fp.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(280, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 28
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(328, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 29
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'Re
        '
        Me.Re.AllowEditing = False
        Me.Re.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.Re.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Re.BackColor = System.Drawing.Color.White
        Me.Re.ColumnInfo = resources.GetString("Re.ColumnInfo")
        Me.Re.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.Re.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Re.ForeColor = System.Drawing.Color.Black
        Me.Re.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Re.Location = New System.Drawing.Point(369, 2)
        Me.Re.Name = "Re"
        Me.Re.Rows.DefaultSize = 19
        Me.Re.Size = New System.Drawing.Size(822, 160)
        Me.Re.StyleInfo = resources.GetString("Re.StyleInfo")
        Me.Re.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Re, "Resumen del Manifiesto")
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(280, 8)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 62
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Chequeo de Datos")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Manifiesto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 112)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Instrucciones:"
        '
        'despacho
        '
        Me.despacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.despacho.Location = New System.Drawing.Point(97, 15)
        Me.despacho.MaxLength = 20
        Me.despacho.Name = "despacho"
        Me.despacho.Size = New System.Drawing.Size(167, 26)
        Me.despacho.TabIndex = 33
        '
        'Ingreso_texpasa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1203, 761)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.despacho)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Re)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_texpasa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despachos de Texpasa"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Re, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = vbLf + "     Instrucciones:" + vbLf + vbLf + "1.- Descargue el archivo de Texpasa" + vbLf + "2.- Verifique que los Datos esten correctos" + vbLf + "3.- Descargue Datos del Lector Portatil" + vbLf + "4.- Revise que todos los Rollos esten captados" + vbLf + "5.- Proceda a Grabar los Datos"
        llena_conexiones()
        setea_grid()
        busca_manifiestos()
    End Sub
    Private Sub llena_conexiones()
        Dim i As Integer
        e(0) = "inventarios"
        e(1) = "TRECENTO"
        e(2) = "zuntex"
        For i = 0 To 2
            constr(i) = "Data Source=192.9.200.3\JT;initial catalog=" + e(i) + ";User id=user_e;Password=Ga2412_e"
        Next i
    End Sub
    Private Sub busca_manifiestos()
        Dim strsql As String = "SELECT DISTINCT DESPACHO FROM MANI ORDER BY DESPACHO"
        Dim dt As New DataTable()
        Dim dr As DataRow
        cnnl.ConnectionString = lector_dc()
        despacho.Items.Clear()
        llena_tablas_e(dt, strsql, cnnl)
        For Each dr In dt.Rows
            Try
                despacho.Items.Add(dr("DESPACHO"))
            Catch
            End Try
        Next
        If despacho.Items.Count > 0 Then
            despacho.SelectedIndex = 0
            sigue.Visible = True
        Else
            sigue.Visible = False
        End If
    End Sub
    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 15
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "ENVIO"
        fg.Cols(2).Name = "FPO"
        fg.Cols(3).Name = "BATCH"
        fg.Cols(4).Name = "TELA"
        fg.Cols(5).Name = "COLOR"
        fg.Cols(6).Name = "ROLLO"
        fg.Cols(7).Name = "LOTE"
        fg.Cols(8).Name = "BARRA"
        fg.Cols(9).Name = "LIBRAS"
        fg.Cols(10).Name = "YARDAS"
        fg.Cols(11).Name = "EMP."
        fg.Cols(12).Name = "KNIT"
        fg.Cols(13).Name = "REG."
        fg.Cols(14).Name = "CODIGO"
        fg.Cols(9).Format = r
        fg.Cols(8).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(8).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(9).DataType = GetType(Decimal)
        fg.Cols(9).Format = "######.0"
        fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(10).DataType = GetType(Decimal)
        fg.Cols(10).Format = "######.0"
        fg.Cols(10).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(13).DataType = GetType(Boolean)
        fg.Cols(13).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(13).TextAlignFixed = TextAlignEnum.CenterCenter
        For index = 1 To fg.Cols.Count - 1
            If index < 8 Or index > 10 Then
                fg.Cols(index).TextAlign = TextAlignEnum.LeftCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.LeftCenter
            End If
            fg.Cols(index).Width = 70
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(6).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(6).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(13).DataType = GetType(Boolean)
        fg.Cols(13).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(13).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(1).Width = 60
        fg.Cols(2).Width = 80
        fg.Cols(4).Width = 230
        fg.Cols(5).Width = 190
        fg.Cols(6).Width = 55
        fg.Cols(7).Width = 60
        fg.Cols(11).Width = 30
        fg.Cols(12).Width = 130
        fg.Cols(13).Width = 50
        Dim s As C1.Win.C1FlexGrid.CellStyle
        s = fg.Styles.Add("SELECTO")
        s.ForeColor = Color.Black
        s.BackColor = Color.White
        fg.Cols(7).Visible = False
        ' fg.Cols(11).Visible = False
        s = fg.Styles.Add("amarillo")
        s.ForeColor = Color.Black
        s.BackColor = Color.Yellow
        setea_re()
        G1.Visible = False
    End Sub

    Private Sub setea_re()
        Dim index As Integer
        Re.Rows.Count = 1
        Re.Cols.Count = 7
        Re.Cols(0).Width = 0
        Re.Rows(0).Height = 30
        Dim c As Column = Re.Cols(1)
        Re.Cols(1).Name = "ENVIO"
        Re.Cols(2).Name = "TELA"
        Re.Cols(3).Name = "COLOR"
        Re.Cols(4).Name = "MANIFIE."
        Re.Cols(5).Name = "REGISTR."
        Re.Cols(6).Name = "DIFEREN."
        For index = 1 To Re.Cols.Count - 1
            If index > 3 Then
                Re.Cols(index).DataType = GetType(Decimal)
                Re.Cols(index).Format = "######.0"
                Re.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Re.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            Else
                Re.Cols(index).TextAlign = TextAlignEnum.LeftCenter
                Re.Cols(index).TextAlignFixed = TextAlignEnum.LeftCenter
            End If
            Re.Cols(index).Width = 60
            Re(0, index) = Re.Cols(index).Name
        Next
        Re.Cols(1).Width = 60
        Re.Cols(2).Width = 250
        Re.Cols(3).Width = 300
    End Sub
    Private Sub sigue_Click(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        despacho.Enabled = False
        lee_texto()
        busca_fpos()
        busca_datos(ok)

        procesa_descarga()
        Re.Subtotal(AggregateEnum.Sum, -1, -1, 6, "Gran Total -->")
        If ok Then
            G1.Visible = True
        Else
            MessageBox.Show("Aun existen registros inconsistentes.", "Por favor revise !!!", MessageBoxButtons.OK)
        End If
        sigue.Visible = False
    End Sub

    Private Sub lee_texto()
        Dim strsql As String = "SELECT * FROM MANI WHERE DESPACHO = '" & despacho.Text & "' ORDER BY ENVIO"
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim l As Integer = 1
        fpos = ""
        batches = ""
        envios = ""
        cnnl.ConnectionString = lector_dc()
        despacho.Items.Clear()
        llena_tablas_e(dt, strsql, cnnl)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("ENVIO")
            fg(l, 2) = dr("FPO")
            fg(l, 3) = dr("BATCH")
            fg(l, 4) = dr("KNIT")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = dr("ROLLO")
            fg(l, 7) = dr("ROLLO")
            fg(l, 8) = dr("BARRA")
            fg(l, 9) = dr("LIBRAS")
            fg(l, 10) = dr("YARDAS")
            fg(l, 11) = dr("EMP")
            fg(l, 12) = dr("KNIT")
            fg(l, 13) = False
            fg(l, 14) = dr("CODIGO")
            If fpos.IndexOf("'" + dr("FPO") + "'") = -1 Then
                fpos = fpos + "'" + dr("FPO") + "',"
            End If
            If batches.IndexOf(fg(l, 3)) = -1 Then
                batches = batches + "'" + fg(l, 3) + "',"
            End If
            If envios.IndexOf(fg(l, 1)) = -1 Then
                envios = envios + "'" + fg(l, 1) + "',"
            End If
            l = l + 1
        Next
        If fpos.Length > 0 Then
            fpos = "(" + Mid(fpos, 1, fpos.Length - 1) + ")"
        End If

        If batches.Length > 0 Then
            batches = "(" + Mid(batches, 1, batches.Length - 1) + ")"
        End If
        If envios.Length > 0 Then
            envios = "(" + Mid(envios, 1, envios.Length - 1) + ")"
        End If
    End Sub

    Private Sub llena_resumen(ByVal envio, ByVal tela, ByVal colo, ByVal libras)
        Dim busca As String = Trim(envio) + Trim(tela) + Trim(colo)
        Dim f As Integer = Re.FindRow(busca, 1, 0, True)
        If f < 0 Then
            f = Re.Rows.Count
            Re.Rows.Count = f + 1
            Re(f, 0) = busca
            Re(f, 1) = envio
            Re(f, 2) = tela
            Re(f, 3) = colo
        End If
        Re(f, 4) = Re(f, 4) + libras
        Re(f, 5) = 0
        Re(f, 6) = Re(f, 4)
    End Sub

    Private Sub llena_variable(ByRef line As String, ByRef resul As String)
        Dim p As Integer = line.IndexOf(",")
        If p > -1 Then
            resul = Mid(line, 1, p)
            line = Mid(line, p + 2)
        Else
            resul = ""
        End If
    End Sub

    Private Sub busca_fpos()
        Dim i As Integer
        Dim s As Integer
        Dim fpo As String
        Dim tela As String
        Dim colo As String
        Dim busca As String
        Dim lote As String
        Dim con As New System.Data.SqlClient.SqlConnection()
        Dim da As New System.Data.SqlClient.SqlDataAdapter()
        Dim ds As New System.Data.DataSet()
        Dim dr As System.Data.DataRow
        Dim recibidas As Decimal
        Dim codte As String = ""
        'Dim strSQL As String = "SELECT * FROM FPO WHERE FPO IN " & fpos & " AND STATUS = 'ABIERTO' AND RECIBIDAS = 0 ORDER BY FPO, COLOR"
        Dim strSQL As String = "SELECT * FROM FPO WHERE FPO IN " & fpos & " AND STATUS = 'ABIERTO' ORDER BY FPO, COLOR"
        fp.Clear()
        fp.Rows.Count = 0
        Dim l As Integer = 0
        For i = 0 To 2
            con.ConnectionString = constr(i)
            da = New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            da.Fill(ds)
            If i = 0 Then
                fpo0 = ds.Tables(0)
            ElseIf i = 1 Then
                fpo1 = ds.Tables(0)
            Else
                fpo2 = ds.Tables(0)
            End If
            s = ds.Tables(0).Rows.Count
            fp.Rows.Count = fp.Rows.Count + s
            For Each dr In ds.Tables(0).Rows
                recibidas = dr("RECIBIDAS")
                fpo = dr("FPO")
                tela = dr("KNIT")
                colo = dr("COLOR")
                lote = dr("LOTE")
                Try
                    codte = dr("CODIGO_TELA")
                Catch
                End Try
                'cambio
                If Mid(codte, 1, 5) = "Cuell" Or Mid(codte, 1, 4) = "Puno" Then
                Else
                    codte = Mid(codte, 1, 5)
                End If

                busca = Trim(fpo) + Trim(dr("LOTE")) + Trim(tela)
                s = fp.FindRow(busca, 0, 0, False)
                'If s = -1 And recibidas = 0 Then
                If s = -1 Then
                    fp(l, 1) = fpo
                    fp(l, 2) = tela
                    fp(l, 3) = colo
                    fp(l, 4) = codte
                    fp(l, 11) = i
                    fp(l, 5) = lote
                    fp(l, 6) = dr("CODIGO")
                    fp(l, 0) = busca
                    l = l + 1
                End If
            Next dr
        Next i
    End Sub

    Private Sub busca_datos(ByRef ok As Boolean)
        Dim i As Integer
        Dim p As Integer
        Dim fps As String
        Dim lote As String
        Dim busca As String
        Dim codte As String
        ok = True
        fg.Sort(SortFlags.Ascending, 1, 5)
        ' fp.Cols(0).Width = 300
        For i = 1 To fg.Rows.Count - 1
            fps = fg(i, 2)
            lote = fg(i, 3)
            codte = fg(i, 4)
            If Mid(codte, 1, 5) = "Cuell" Or Mid(codte, 1, 4) = "Puno" Then
            Else
                '  codte = Mid(codte, 1, 5)
            End If
            busca = Trim(fps) + Trim(lote) + Trim(codte)
            p = fp.FindRow(busca, 0, 0, False)
            If p > -1 Then
                fg(i, 12) = fp(p, 2)
                fg(i, 5) = fp(p, 3)
                fg(i, 14) = fp(p, 6)
            Else
                fg.Rows(i).Style = fg.Styles("amarillo")
                ok = False
            End If
            llena_resumen(fg(i, 1), fg(i, 4), fg(i, 5), fg(i, 9))
        Next
        Re.Sort(SortFlags.Ascending, 1)
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        setea_grid()
        sigue.Visible = True
        busca_manifiestos()
        despacho.Enabled = True
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        ok = True
        hay_que_grabar(ok)
        If ok Then
            chequea_documentos(ok)
            revisa_rollos(ok)
            Cursor = Cursors.WaitCursor
            ordena_y_graba()
            Cursor = Cursors.Default
            setea_grid()
        End If
    End Sub

    Private Sub lector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub procesa_descarga()
        Dim dt As New DataTable
        Try
            dt = descarga_lector(0)
            Dim dr As DataRow
            Dim lineast As String
            Dim l As Integer
            Dim i As Integer
            Dim envio As String
            Dim tela As String
            Dim colo As String
            Dim libra As Decimal
            Dim busca As String
            For Each dr In dt.Rows
                lineast = dr("CODIGO")
                i = fg.FindRow(lineast, 1, 8, True)
                If i > 0 Then
                    If fg(i, 13) = False Then
                        envio = Trim(fg(i, 1))
                        tela = Trim(fg(i, 4))
                        colo = Trim(fg(i, 5))
                        libra = fg(i, 9)
                        busca = Trim(envio) + Trim(tela) + Trim(colo)
                        l = Re.FindRow(busca, 1, 0, True)
                        If l > 0 Then
                            Re(l, 5) = Re(l, 5) + libra
                            Re(l, 6) = Re(l, 4) - Re(l, 5)
                        End If
                        fg(i, 13) = True
                    End If
                End If
            Next
        Catch E As Exception
        End Try
        Re.Subtotal(AggregateEnum.Sum, -1, -1, 6, "Gran Total -->")
    End Sub
    Private Sub marca_leido()
        Dim envio As String
        Dim tela As String
        Dim colo As String
        Dim libra As String
        Dim busca As String
        Dim i As Integer
        Dim l As Integer
        For i = 1 To fg.Rows.Count - 1
            envio = Trim(fg(i, 1))
            tela = Trim(fg(i, 4))
            colo = Trim(fg(i, 5))
            libra = fg(i, 9)
            busca = Trim(envio) + Trim(tela) + Trim(colo)
            l = Re.FindRow(busca, 1, 0, True)
            If l > 0 Then
                Re(l, 5) = Re(l, 5) + libra
                Re(l, 6) = Re(l, 4) - Re(l, 5)
            End If
            fg(i, 13) = True
        Next
        Re.Subtotal(AggregateEnum.Sum, -1, -1, 6, "Gran Total -->")
    End Sub

    Private Sub hay_que_grabar(ByRef ok As Boolean)
        Dim i As Integer
        Dim total As Integer
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 13) = True Then
                total = total + 1
            End If
        Next
        If total = 0 Then
            MsgBox("Aun no existen registros para Grabar. ", MsgBoxStyle.OKOnly, "Por favor Revise  !!!")
            ok = False
        End If
    End Sub

    Private Sub revisa_rollos(ByRef ok As Boolean)
        Dim j As Integer
        Dim i As Integer
        Dim bt As New C1.Win.C1FlexGrid.C1FlexGrid()
        Dim con As New System.Data.SqlClient.SqlConnection()
        Dim da As New System.Data.SqlClient.SqlDataAdapter()
        Dim ds As New System.Data.DataSet()
        Dim rollos As New DataTable()
        Dim dd As DataRow()
        Dim batch As String
        Dim rollo As String
        Dim prob As String = ""
        Dim l As Integer = 0
        Dim strSQL As String = "SELECT * FROM ROLLOS WHERE BATCH IN " & batches & " AND YARDAS > 0 ORDER BY BATCH, ROLLO"
        For i = 0 To 1
            con.ConnectionString = constr(i)
            da = New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            da.Fill(ds)
            rollos = ds.Tables(0)
            For j = 1 To fg.Rows.Count - 1
                batch = fg(i, 3)
                rollo = fg(i, 6)
                dd = rollos.Select("BATCH = '" & batch & "' AND ROLLO = '" & rollo & "'")
                If dd.Length > 0 Then
                    prob = prob + batch + " " + rollo + "; "
                End If
            Next j
        Next i
        If prob <> "" Then
            MsgBox("Los siguientes batch rollo ya existen:" + vbLf + prob, MsgBoxStyle.OKOnly, "Por favor Revise")
            ok = False
        End If
    End Sub

    Private Sub chequea_documentos(ByRef ok As Boolean)
        Dim s As Integer
        Dim i As Integer
        Dim con As New System.Data.SqlClient.SqlConnection()
        Dim da As New System.Data.SqlClient.SqlDataAdapter()
        Dim ds As New System.Data.DataSet()
        Dim dr As System.Data.DataRow
        Dim tabla As String
        Dim prob As String = ""
        Dim strSQL As String = "SELECT * FROM EMOVTO WHERE DOCTO IN " & envios & " AND TMOVTO = '1' "
        For i = 0 To 1
            con.ConnectionString = constr(i)
            da = New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            tabla = "ENVIOS" + CStr(i)
            da.Fill(ds, tabla)
            s = ds.Tables(tabla).Rows.Count
            For Each dr In ds.Tables(tabla).Rows
                prob = prob + dr("DOCTO") + "; "
            Next dr
        Next
        If prob <> "" Then
            MsgBox("Los siguientes Documentos ya existen:" + vbLf + prob, MsgBoxStyle.OKOnly, "Por favor Revise")
            ok = False
        End If
    End Sub

    Private Sub ordena_y_graba()
        Dim i As Integer
        Dim p As Integer
        Dim ei(2) As Integer
        Dim ef(2) As Integer
        fg.Sort(SortFlags.Ascending, 11)
        For i = 1 To fg.Rows.Count - 1
            p = fg(i, 11)
            If ei(p) = 0 Then
                ei(p) = i
            End If
            ef(p) = i
        Next
        For i = 0 To 2
            If ei(i) > 0 Then
                graba_datos(i, ei(i), ef(i))
            End If
        Next
        elimina_datos_despacho()
    End Sub

    Private Sub determina_tipo(ByVal codigo As String, ByRef tipo As String)
        If UCase(Mid(codigo, 1, 4)) = "PUNO" Then
            tipo = "PUÑOS"
        ElseIf UCase(Mid(codigo, 1, 6)) = "CUELLO" Then
            tipo = "CUELLOS"
        Else
            tipo = "TELA"
        End If
    End Sub

    Private Sub despacho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles despacho.KeyPress
        AutoCompletar(despacho, e)
    End Sub
    '===============================================================================================
    '=
    '=                       ACTUALIZA BASE DE DATOS
    '=
    '===============================================================================================

    Private Sub graba_datos(ByVal em As Integer, ByVal ci As Integer, ByVal cf As Integer)
        Dim strSQL As String
        Dim fechas As String
        Dim afectados As Integer
        Dim l As Integer
        Dim p As Integer
        Dim docto As String
        Dim ancho As String = "00"
        Dim corte As String = "00000"
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim doctos As String = "|"
        fechas = Format(CDate(fecha.Value), "yyyy-MM-dd")
        cnn.ConnectionString = constr(em)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For l = ci To cf
                If fg(l, 13) = True Then
                    docto = fg(l, 1)
                    p = doctos.IndexOf(docto)
                    If p = -1 Then
                        doctos = doctos + docto + "|"
                        '=================================================
                        '               ENCABEZADO MOVTOS
                        '=================================================
                        Try
                            strSQL = "INSERT INTO EMOVTO (DOCTO, TMOVTO, FECHA, COMENTARIO ) " & _
                                     "VALUES ( '" & docto & "','1','" & _
                                         fechas & "','" & docto & "')"
                            comando.CommandText = strSQL
                            afectados = comando.ExecuteNonQuery()
                        Catch
                        End Try
                    End If
                    '=================================================
                    '               GRABA ROLLOS
                    '=================================================
                    If em = 0 Then
                        dd = fpo0.Select("FPO = '" & fg(l, 2) & "' AND KNIT = '" & fg(l, 12) & "' AND COLOR = '" & fg(l, 5) & "' AND LOTE = '" & fg(l, 3) & "' AND CODIGO = '" & fg(l, 14) & "'")
                    ElseIf em = 1 Then
                        dd = fpo1.Select("FPO = '" & fg(l, 2) & "' AND KNIT = '" & fg(l, 12) & "' AND COLOR = '" & fg(l, 5) & "' AND LOTE = '" & fg(l, 3) & "' AND CODIGO = '" & fg(l, 14) & "'")
                    Else
                        dd = fpo2.Select("FPO = '" & fg(l, 2) & "' AND KNIT = '" & fg(l, 12) & "' AND COLOR = '" & fg(l, 5) & "' AND LOTE = '" & fg(l, 3) & "' AND CODIGO = '" & fg(l, 14) & "'")
                    End If

                    If dd.Length > 0 Then
                        dr = dd(0)
                        strSQL = "INSERT INTO ROLLOS (BATCH, ROLLO, FPO, CPO, CLIENTE, TIPO, KNIT, COLOR, PESO, YARDAS_I, YARDAS, ANCHO, YFIBER, YFINISH, COSTO, LOTE, ACTIVO,CODIGO_TELA,BARRA,CODIGO ) " & _
                                                                                   "VALUES ( '" & fg(l, 3) & "','" & _
                                                                                       fg(l, 6) & "','" & _
                                                                                       fg(l, 2) & "','" & _
                                                                                       dr("CPO") & "','" & _
                                                                                       dr("CLIENTE") & "','" & _
                                                                                       dr("TIPO") & "','" & _
                                                                                       fg(l, 12) & "','" & _
                                                                                       fg(l, 5) & "','" & _
                                                                                       fg(l, 9) & "','" & _
                                                                                       fg(l, 10) & "','" & _
                                                                                       fg(l, 10) & "','" & _
                                                                                       ancho & "','" & _
                                                                                       dr("YFIBER") & "','" & _
                                                                                       dr("YFINISH") & "','" & _
                                                                                       dr("PRECIO") & "','" & _
                                                                                       fg(l, 2) & "','S','" & _
                                                                                       fg(l, 4) & "','" & _
                                                                                       fg(l, 8) & "','" & _
                                                                                       dr("CODIGO") & "')"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()

                        strSQL = "INSERT INTO DMOVTO (DOCTO, TMOVTO, BATCH, ROLLO, FECHA, CLIENTE, FPO, CPO, CORTE, YARDAS, LIBRAS, PRECIO) " & _
                                                 "VALUES ( '" & fg(l, 1) & "','1','" & _
                                                     fg(l, 3) & "','" & _
                                                     fg(l, 6) & "','" & _
                                                     fechas & "','" & _
                                                     dr("CLIENTE") & "','" & _
                                                     fg(l, 2) & "','" & _
                                                     dr("CPO") & "','" & _
                                                     corte & "','" & _
                                                     fg(l, 10) & "','" & _
                                                     fg(l, 9) & "','" & _
                                                     dr("PRECIO") & "')"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()
                        Try
                            strSQL = "INSERT INTO AP_TELA (BATCH, CODIGO , ESTADO, FECHA_ING, FECHA, REVISADO, COMENTARIOS, FACTURA) " & _
                                                                     "VALUES ( '" & fg(l, 3) & "','" & dr("CODIGO") & "','PENDIENTE','" & fechas & "','" & fechas & "','','','" & fg(l, 1) & "')"
                            comando.CommandText = strSQL
                            afectados = comando.ExecuteNonQuery()
                        Catch
                        End Try
                        strSQL = "UPDATE FPO SET RECIBIDAS = RECIBIDAS + " & fg(l, 9) & " WHERE FPO = '" & fg(l, 2) & "' AND TIPO = '" & dr("TIPO") & "' AND KNIT = '" & fg(l, 12) & "' AND COLOR = '" & fg(l, 5) & "' AND LOTE = '" & fg(l, 3) & "'"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()
                    End If
                End If
            Next l
            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Information, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub elimina_datos_despacho()
        Dim afectados As Integer
        Dim strsql As String
        cnn.ConnectionString = lector_dc()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE ROLLO WHERE MANI = '" & despacho.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE CODIGO WHERE MANI = '" & despacho.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE MANI WHERE DESPACHO = '" & despacho.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

  
End Class
