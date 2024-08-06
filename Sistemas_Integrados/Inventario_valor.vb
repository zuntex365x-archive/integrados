Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Inventario_valor
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TI As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_valor))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TI = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(624, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(672, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 48
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(360, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 56
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario de Telas. ")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(576, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 59
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(984, 616)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Listar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TI
        '
        Me.TI.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.TI.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.TI.ColumnInfo = resources.GetString("TI.ColumnInfo")
        Me.TI.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.TI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TI.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.TI.Location = New System.Drawing.Point(112, 8)
        Me.TI.Name = "TI"
        Me.TI.Rows.DefaultSize = 19
        Me.TI.Size = New System.Drawing.Size(176, 128)
        Me.TI.StyleInfo = resources.GetString("TI.StyleInfo")
        Me.TI.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.TI.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(112, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 24)
        Me.Label2.TabIndex = 58
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Inventario_valor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 684)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TI)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_valor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Tela (Resumido)"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim strSQL As String
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cns As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim path As String = "c:\reportes\inv_telas.xls"
    Dim E(9) As String
    Dim obj As empresas
    Dim tx As New DataTable()
    Dim dc As New DataTable()
    Dim rollos As Integer
    Dim yardas As Integer
    Dim libras As Integer
    Dim yd As Integer

    Private Sub Inventario_tela_r_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_textileras()
        llena_codigos()
        asigna_estado()
        setea_ti()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Cols.Fixed = 0
            fg.Cols(0).Width = 0
            fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
            fg.ScrollBars = ScrollBars.None
            fg.Rows.Count = 1
            fg.Cols.Count = 20
            fg.Rows(0).Height = 40
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Name = "BATCH"
            fg.Cols(2).Name = "CLIENTE"
            fg.Cols(3).Name = "FPO"
            fg.Cols(4).Name = "KNIT"
            fg.Cols(5).Name = "COLOR"
            fg.Cols(6).Name = "CPO"
            fg.Cols(7).Name = "ANCHO"
            fg.Cols(8).Name = "ROLLOS"
            fg.Cols(9).Name = "LIBRAS"
            fg.Cols(10).Name = "YARDAS"
            fg.Cols(11).Name = "COSTO $"
            fg.Cols(12).Name = "COSTO TOT."
            fg.Cols(13).Name = "RECIBIDO"
            fg.Cols(14).Name = "FIBRA"
            fg.Cols(15).Name = "ESTADO"
            fg.Cols(16).Name = "TEXTILERA"
            fg.Cols(17).Name = "CODIGO"
            fg.Cols(18).Name = "DESCRIPCION"
            fg.Cols(19).Name = "UBICACION"
            fg.Cols(8).DataType = GetType(Decimal)
            fg.Cols(8).Format = g
            fg.Cols(8).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(13).DataType = GetType(Date)
            fg.Cols(13).Format = "dd/MM/yyyy"
            fg.Cols(13).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(13).TextAlignFixed = TextAlignEnum.CenterCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 80
                fg(0, index) = fg.Cols(index).Name
                If index > 8 And index < 13 Then
                    fg.Cols(index).DataType = GetType(Decimal)
                    fg.Cols(index).Format = h
                    fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                    fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                End If
            Next
            fg.Cols(4).Width = 150
            fg.Cols(5).Width = 150
            fg.Cols(2).Width = 60
            fg.Cols(6).Width = 90
            fg.Cols(8).Width = 60
            fg.Cols(16).Width = 150
            fg.Cols(18).Width = 300
            fg.Cols(19).Width = 60
        Catch
        End Try
    End Sub

    Private Sub busca_tela()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim COSTO As Decimal
        Dim FECHA As String
        Dim es As String
        Dim i As Integer
        Dim dw As DataRow()

        llena_tablas(dt, strSQL, cns)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("CLIENTE")
            fg(lineas, 3) = dr("FPO")
            fg(lineas, 4) = dr("KNIT")
            fg(lineas, 5) = dr("COLOR")
            fg(lineas, 6) = dr("CPO")
            fg(lineas, 7) = dr("ANCHO")
            fg(lineas, 8) = dr("ROLLO")
            fg(lineas, 9) = dr("LIBRAS")
            fg(lineas, 10) = dr("YARDA")
            fg(lineas, 17) = dr("CODIGO")
            fg(lineas, 19) = dr("UBICACION")
            '  fg(lineas, 18) = dr("DESCRIPCION")

            COSTO = dr("COSTO")
            fg(lineas, 11) = COSTO
            fg(lineas, 12) = COSTO * fg(lineas, 9)
            FECHA = dr("FECHA")
            fg(lineas, 13) = FECHA
            fg(lineas, 14) = dr("YFIBER")
            es = CStr(dr("ACTIVO"))
            If IsNumeric(es) = False Then
                es = "0"
            End If
            fg(lineas, 15) = E(es)
            lineas = lineas + 1
        Next
        For i = 1 To fg.Rows.Count - 1
            dw = dc.Select("CODIGO = '" & fg(i, 17) & "'")
            For Each dr In dw
                fg(i, 18) = dr("DESCRIPCION")
                ok = True
            Next
            dw = tx.Select("FPO = '" & fg(i, 3) & "' AND KNIT = '" & fg(i, 4) & "' AND COLOR = '" & fg(i, 5) & "'")
            For Each dr In dw
                fg(i, 16) = dr("TEXTILERA")
                ok = True
            Next
        Next
        rollos = fg.Cols("ROLLOS").Index
        yardas = fg.Cols("COSTO TOT.").Index
        libras = fg.Cols("LIBRAS").Index
        yd = fg.Cols("YARDAS").Index
        subtotales()
        fg.ScrollBars = ScrollBars.Both
    End Sub


    Private Sub subtotales()
        With fg
            fg.Subtotal(AggregateEnum.Sum, 0, 0, rollos, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, yardas, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, libras, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, yd, "Gran Total -->")

            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
        End With
    End Sub

    Private Sub asigna_estado()
        E(0) = "Buen Estado"
        E(1) = "Barrado"
        E(2) = "Manchas"
        E(3) = "Tonalidad"
        E(4) = "Agujeros"
        E(5) = "Remanente"
        E(6) = "Textilera"
        E(7) = "Segundas"
        E(8) = "Obsoleto"
        E(9) = "Cuarentena"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setea_grid()
        busca_tela()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim MAL As String = ""
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Inventario de Tela al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Try
            Dim ch As Char = Microsoft.VisualBasic.Chr(9)
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TI.Visible = False
        crea_string(strSQL)
        If strSQL <> "" Then
            hace_Visible()
            If TI(1, 1) = True Then
                Label2.Text = "Todos"
            Else
                Label2.Text = "Seleccion"
            End If
            setea_grid()
            busca_tela()
            Button4.Focus()
        Else
            MsgBox("Por favor seleccione uno o mas tipos a listar", MsgBoxStyle.Critical, "Error en Seleccion")
        End If
    End Sub

    Private Sub setea_ti()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        TI.Cols.Count = 2
        TI.Rows.Count = 2
        TI.Rows.Fixed = 1
        TI.Cols.Fixed = 0
        TI.Rows(0).Height = 20
        TI(0, 0) = "Tipo de Tela"
        TI(0, 1) = "Listar ?"
        Dim c As Column = TI.Cols(0)
        c.Width = 100
        c.Name = "Tipo de Tela"
        c = TI.Cols(1)
        c.Name = "Boolean"
        c.DataType = GetType(Boolean)
        c.ImageAlign = ImageAlignEnum.CenterCenter
        c.Width = 50
        TI(1, 0) = "Todos"
        Dim strSQL As String = "SELECT * FROM ESTADOS_TELA"
        llena_tablas(dt, strSQL, cns)
        TI.Rows.Count = dt.Rows.Count + 2
        i = 2
        For Each dr In dt.Rows
            TI(i, 0) = dr("ESTADO_TELA")
            i = i + 1
        Next
        TI.Cols(0).AllowEditing = False
    End Sub


    Private Sub ti_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles TI.ValidateEdit
        Dim i As Integer
        If e.Col = 1 And e.Row = 1 Then
            For i = 2 To TI.Rows.Count - 1
                TI(i, 1) = False
            Next
        End If
        If e.Col = 1 And e.Row <> 1 Then
            TI(1, 1) = False
        End If
    End Sub

    Private Sub crea_string(ByRef StrSql As String)
        StrSql = ""
        Dim activo As String = ""
        Dim i As Integer
        If TI(1, 1) = True Then
            StrSql = "SELECT count(ROLLOS.ROLLO) AS ROLLO, SUM(YARDAS_I) AS INI, SUM(ROLLOS.YARDAS) AS YARDA,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS,ROLLOS.CLIENTE, ROLLOS.BATCH, KNIT, COLOR, ROLLOS.FPO ,YFIBER, ACTIVO,ANCHO, ROLLOS.CPO AS CPO , COSTO ,FECHA,ACTIVO , ROLLOS.CODIGO AS CODIGO , VIEJO AS UBICACION FROM ROLLOS, DMOVTO WHERE ROLLOS.ROLLO = DMOVTO.ROLLO  AND ROLLOS.BATCH = DMOVTO.BATCH  AND ROLLOS.FPO = DMOVTO.FPO  AND DMOVTO.TMOVTO = '1'  AND ROLLOS.YARDAS >0  AND TIPO = 'TELA'   GROUP BY ROLLOS.BATCH, FECHA, ROLLOS.CLIENTE, ROLLOS.FPO, ROLLOS.KNIT, ROLLOS.COLOR ,YFIBER, ACTIVO, ROLLOS.CPO, ANCHO, COSTO, ACTIVO,ROLLOS.CODIGO,VIEJO ORDER BY ROLLOS.BATCH"
            Exit Sub
        End If
        If TI(2, 1) = True Then
            activo = " ( ACTIVO = '0' OR ACTIVO = 'S' "
        End If
        For i = 3 To TI.Rows.Count - 1
            If TI(i, 1) = True Then
                If activo = "" Then
                    activo = " ( ACTIVO = '" + CStr(i - 2) + "' "
                Else
                    activo = activo + " OR ACTIVO = '" + CStr(i - 2) + "' "
                End If
            End If
        Next i
        If activo <> "" Then
            activo = activo + " ) "
            StrSql = "SELECT count(ROLLOS.ROLLO) AS ROLLO, SUM(YARDAS_I) AS INI, SUM(ROLLOS.YARDAS) AS YARDA, (SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS, ROLLOS.CLIENTE, ROLLOS.BATCH, KNIT, COLOR, ROLLOS.FPO , YFIBER, ACTIVO, ANCHO, ROLLOS.CPO AS CPO , COSTO ,FECHA, ACTIVO ,ROLLOS.CODIGO AS CODIGO, VIEJO AS UBICACION FROM ROLLOS, DMOVTO  WHERE " & activo & " AND ROLLOS.ROLLO = DMOVTO.ROLLO AND ROLLOS.BATCH = DMOVTO.BATCH AND ROLLOS.FPO = DMOVTO.FPO AND DMOVTO.TMOVTO = '1' AND ROLLOS.YARDAS >0 AND TIPO = 'TELA' GROUP BY ROLLOS.BATCH, FECHA, ROLLOS.CLIENTE, ROLLOS.FPO, ROLLOS.KNIT, ROLLOS.COLOR ,YFIBER, ACTIVO, ROLLOS.CPO, ANCHO, COSTO, ACTIVO , ROLLOS.CODIGO,VIEJO ORDER BY ROLLOS.BATCH"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        setea_grid()
        TI.Visible = True
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Label2.Visible = False
        Button1.Focus()
    End Sub

    Private Sub hace_Visible()
        TI.Visible = False
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub llena_codigos()
        Dim strsql As String = "SELECT * FROM CODIGO_TELA WHERE CODIGO IN (SELECT DISTINCT CODIGO FROM ROLLOS WHERE YARDAS > 0 ) ORDER BY CODIGO"
        llena_tablas(dc, strsql, cns)
    End Sub

    Private Sub llena_textileras()
        Dim strsql As String = "SELECT FPO,KNIT,COLOR,TEXTILERA FROM FPO WHERE FPO+KNIT+COLOR IN (SELECT DISTINCT FPO+KNIT+COLOR FROM ROLLOS WHERE YARDAS > 0 )"
        llena_tablas(tx, strsql, cns)
    End Sub

    Private Sub fg_afterfilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click

    End Sub
End Class
