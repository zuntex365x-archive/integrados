Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Tela_c_oc
    Inherits System.Windows.Forms.Form
    Dim h As String = "####,##0.00"
    Dim g As String = "####,##0"
    Dim cnn As New SqlClient.SqlConnection()
    Dim co As New DataTable()
    Dim mv As New DataTable()
    Dim dr As DataRow
    Dim dw As DataRow
    Dim fechain As Date
    Dim fechafi As Date
    Dim ok As Boolean
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim st(2) As String
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Fechaf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents salas As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tela_c_oc))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Fechaf = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.salas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
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
        Me.Button1.Location = New System.Drawing.Point(840, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Una vez Seleccionado el Cliente y el Estilo  presione aqui para ver los resultado" & _
                "s.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy"
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(8, 24)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(104, 26)
        Me.Fecha.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Fecha, "Fecha incial")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(840, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 54
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton regresar a escoger Estilo ")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Fechaf
        '
        Me.Fechaf.CustomFormat = "dd/MM/yyyy"
        Me.Fechaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechaf.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fechaf.Location = New System.Drawing.Point(128, 24)
        Me.Fechaf.Name = "Fechaf"
        Me.Fechaf.Size = New System.Drawing.Size(104, 26)
        Me.Fechaf.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Fechaf, "Mes y año de los Documentos que deseamos desplegar.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(888, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 57
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(936, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 58
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'salas
        '
        Me.salas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salas.Location = New System.Drawing.Point(264, 24)
        Me.salas.Name = "salas"
        Me.salas.Size = New System.Drawing.Size(240, 24)
        Me.salas.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Sala de Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 57)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(936, 630)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Tela_c_oc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 699)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fechaf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.salas)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tela_c_oc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo de Tela por Orden de Corte"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Tela_oc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim z As New ZoomCell(fg)
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        st = Split("blanco,verde", ","c)
        llena_salas()
        setea_grid()
        Fecha.Text = "01" + Mid(Fechaf.Text, 3)
        Fecha.Focus()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Rows.Count = 1
            fg.ScrollBars = ScrollBars.None
            fg.Rows.Count = 1
            fg.Cols.Count = 19
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            fg.Cols(1).Name = "O/C"
            fg.Cols(2).Name = "Cliente"
            fg.Cols(3).Name = "Cpo"
            fg.Cols(4).Name = "Estilo"
            fg.Cols(5).Name = "Color Cpo"
            fg.Cols(6).Name = "Codigo"
            fg.Cols(7).Name = "Descripcion Tela"
            fg.Cols(8).Name = "Color Tela"
            fg.Cols(9).Name = "P.Solicit."
            fg.Cols(10).Name = "P.Cortadas"
            fg.Cols(11).Name = "Diferencia"
            fg.Cols(12).Name = "Tela Asig."
            fg.Cols(13).Name = "Tela Devu."
            fg.Cols(14).Name = "Consumo R."
            fg.Cols(15).Name = "Consumo E."
            fg.Cols(16).Name = "Diferencia"
            fg.Cols(17).Name = "Porcentaje"
            fg.Cols(18).Name = "Sala de Corte"
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 100
                fg(0, index) = fg.Cols(index).Name
                If index > 8 And index < 12 Then
                    fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                    fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                    fg.Cols(index).Format = g
                    fg.Cols(index).Width = 70
                End If
                If index > 11 And index < 18 Then
                    fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                    fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                    fg.Cols(index).Format = h
                    fg.Cols(index).Width = 70
                End If
            Next
            fg.Cols(1).Width = 50
            fg.Cols(2).Width = 120
            fg.Cols(3).Width = 120
            fg.Cols(4).Width = 120
            fg.Cols(5).Width = 120
            fg.Cols(6).Width = 80
            fg.Cols(7).Width = 300
            fg.Cols(8).Width = 180
            fg.Cols(18).Width = 150
        Catch
        End Try
    End Sub

    Private Sub llena_grid()
        Cursor = Cursors.WaitCursor
        setea_grid()
        procesar()
        subtotales()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        revisa_fechas(ok)
        If ok Then
            Fecha.Enabled = False
            Fechaf.Enabled = False
            salas.Enabled = False
            Button1.Visible = False
            Button4.Visible = True
            Button3.Visible = True
            Cursor = Cursors.WaitCursor
            recoge_datos()
            llena_grid()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        For i = 7 To 14
            fg.Subtotal(AggregateEnum.Sum, 0, -1, -1, i, "Gran TOTAL ---->")
        Next i
        fg.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub procesar()
        Dim l As Integer = 1
        Dim corte As String
        Dim codigo As String
        Dim dd As DataRow()
        Dim pri As Boolean = True
        Dim cel As String = "blanco"
        Dim busca As String
        Dim colo As String
        For Each Me.dr In mv.Rows
            corte = Trim(dr("CORTE"))
            codigo = dr("CODIGO")
            colo = dr("COLOR")
            busca = corte + codigo + colo
            l = fg.FindRow(busca, 1, 0, False)
            If l = -1 Then
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                fg(l, 0) = busca
                fg(l, 6) = codigo
                fg(l, 7) = dr("DESCRIPCION")
                fg(l, 8) = dr("COLOR")
                dd = co.Select("CORTE = '" & corte & "'")
                If dd.Length > 0 Then
                    llena_datos(dd(0), l)
                End If
                dd = co.Select("CORTE = '" & corte & "' AND CODIGO = '" & codigo & "' AND COLOR_TELA= '" & colo & "'")
                If dd.Length > 0 Then
                    dw = dd(0)
                    fg(l, 15) = dw("LIBRAS") * fg(l, 10)
                Else
                    fg(l, 15) = 0
                End If
            End If
            If dr("TMOVTO") = "4" Then
                fg(l, 12) = fg(l, 12) + dr("LIBRAS")
            Else
                fg(l, 13) = fg(l, 13) + dr("LIBRAS")
            End If
            fg(l, 14) = fg(l, 12) - fg(l, 13)
            fg(l, 16) = fg(l, 15) - fg(l, 14)
            Try
                fg(l, 17) = (fg(l, 14) * 100) / fg(l, 15)
            Catch
            End Try
            fg.Rows(l).Style = fg.Styles(cel)
            If (fg(l, 17) > 100) Or (fg(l, 17) = 0) Then
                fg.SetCellStyle(l, 17, "rojo")
            End If
        Next

    End Sub

    Private Sub llena_datos(ByVal dr As DataRow, ByVal l As Integer)
        fg(l, 1) = dr("CORTE")
        fg(l, 2) = dr("CLIENTE")
        fg(l, 3) = dr("CPO")
        fg(l, 4) = dr("ESTILO")
        fg(l, 5) = dr("COLOR")
        fg(l, 18) = dr("SALA")
        fg(l, 9) = dr("PRESUP")
        fg(l, 10) = dr("CORTADAS")
        fg(l, 11) = fg(l, 9) - fg(l, 10)
    End Sub

    Private Sub recoge_datos()
        Dim strsql As String
        Dim cortes As String = ""
        Dim fechas As String = "FCORTE BETWEEN '" & Format(CDate(Fecha.Text), "yyyy-MM-dd") & "' AND '" & Format(CDate(Fechaf.Text), "yyyy-MM-dd") & "'"
        If salas.SelectedIndex > 0 Then
            strsql = "SELECT CORTES.*, CORTES.TOTAL AS CORTADAS,CORTES_S.TOTAL AS PRESUP ,CONSUMO_TELA.CODIGO, LIBRAS, DESCRIPCION , COLOR_TELA , SALA FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN CONSUMO_TELA ON CORTES.ESTILO = CONSUMO_TELA.ESTILO_CPO AND CORTES.COLOR = CONSUMO_TELA.COLOR_CPO LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO WHERE SALA = '" & salas.Text & "' AND  " & fechas & " AND CORTES.TOTAL > 0 ORDER BY CORTES_S.CORTE"
        Else
            strsql = "SELECT CORTES.*, CORTES.TOTAL AS CORTADAS,CORTES_S.TOTAL AS PRESUP ,CONSUMO_TELA.CODIGO,LIBRAS, DESCRIPCION, COLOR_TELA, SALA FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE LEFT JOIN CONSUMO_TELA ON CORTES.ESTILO = CONSUMO_TELA.ESTILO_CPO AND CORTES.COLOR = CONSUMO_TELA.COLOR_CPO LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO WHERE " & fechas & " AND CORTES.TOTAL > 0 ORDER BY CORTES_S.CORTE"
        End If
        llena_tablas(co, strsql, cnn)
        lista_cortes(cortes)
        strsql = "SELECT DMOVTO.CORTE,ROLLOS.CODIGO,ROLLOS.COLOR,TMOVTO,SUM((ROLLOS.PESO/ROLLOS.YARDAS_I)*DMOVTO.YARDAS) AS LIBRAS, DESCRIPCION FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO  LEFT JOIN CORTES ON CORTES.CORTE = DMOVTO.CORTE  LEFT JOIN CODIGO_TELA ON ROLLOS.CODIGO = CODIGO_TELA.CODIGO WHERE  DMOVTO.CORTE IN " & cortes & " AND ROLLOS.TIPO = 'TELA' AND  (DMOVTO.TMOVTO = '4' OR DMOVTO.TMOVTO = '2') GROUP BY DMOVTO.CORTE,TMOVTO,ROLLOS.CODIGO,ROLLOS.COLOR,DESCRIPCION ORDER BY DMOVTO.CORTE,ROLLOS.CODIGO,TMOVTO"
        llena_tablas(mv, strsql, cnn)
    End Sub

    Private Sub lista_cortes(ByRef cortes As String)
        Dim dr As DataRow
        cortes = "('"
        For Each dr In co.Rows
            cortes = cortes + dr("CORTE") + "','"
        Next
        cortes = Mid(cortes, 1, Len(cortes) - 2) + ")"
    End Sub

    Private Sub revisa_fechas(ByRef ok As Boolean)
        ok = True
        fechain = CDate(Format(CDate(Fecha.Text), "yyyy-MM-dd"))
        fechafi = CDate(Format(CDate(Fechaf.Text), "yyyy-MM-dd"))
        If fechafi < fechain Then
            MsgBox("Error !!!   Fecha inicial es mayor que la Fecha final ", MsgBoxStyle.Critical, "Por favor Revise !!!!")
            ok = False
        End If
    End Sub

    Private Sub llena_salas()
        Dim dt As New DataTable()
        Dim dr As DataRow
        salas.Items.Clear()
        salas.Items.Add("TODAS")
        Dim strSQL As String = "SELECT SALA FROM SALAS ORDER BY SALA"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            salas.Items.Add(dr("SALA"))
        Next
        Try
            salas.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        setea_grid()
        Fecha.Enabled = True
        Fechaf.Enabled = True
        salas.Enabled = True
        Button1.Visible = True
        Button4.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Reporte de utilizacion de Tela : " + Fecha.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub sala_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salas.KeyPress
        AutoCompletar(salas, e)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        Dim path As String = "c:\reportes\consumo_corte.xls"
        datos_excel(si, Path)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " & Path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        Else
        End If
    End Sub


    Private Sub datos_excel(ByRef si As Boolean, ByVal path As String)
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

End Class
