Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Wip0
    Inherits System.Windows.Forms.Form
    Dim h As String = "##,##0"
    Dim d As String = "dd/MM/yyyy"
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cpo As New DataTable()
    Dim con As New DataTable()
    Dim fpo As New DataTable()
    Dim fco As New DataTable()
    Dim es As New DataTable()
    Dim strSQl As String
    Dim lineas As Integer
    Dim f_rec As New DataTable()
    Dim te(9) As String
    Dim tp(9) As String
    Dim tv(9) As String
    Dim da(9) As Integer
    Dim st(3) As String
    Dim noe As String = "12,24,25,26,27,29"
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wip0))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(848, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(808, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(88, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(888, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 60
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Rows.Fixed = 2
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 636)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.fg, "Si desea eliminar presione la tecla (Del)  o  (Supr)")
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(928, 8)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 65
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(680, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 42)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Un Momento por favor.                                                            " & _
    "   Me encuentro Procesando"
        Me.Label1.Visible = False
        '
        'Wip0
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Graba)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wip0"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Production Tracking Report"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 40
        fg.Height = Me.Height - 100
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        tv = Split("XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL,TOTAL", ","c)
        st = Split("rojo,amarillo,verde", ","c)
        def_sql(cnn)
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO, CPO_D WHERE CPO.CPO = CPO_D.CPO AND ESTADO = 'A'", "CLIENTE")
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        Label1.Visible = True
        Label1.Refresh()
        Cursor = Cursors.WaitCursor
        S1.Visible = False
        R1.Visible = True
        Graba.Visible = True
        deshabilita()
        procesa()
        fg.ScrollBars = ScrollBars.Both
        Cursor = Cursors.Arrow
        Label1.Visible = False
        R1.Focus()
    End Sub

    Private Sub deshabilita()
        C4.Enabled = False
        Button3.Visible = True
    End Sub

    Private Sub otro_cliente()
        C4.Enabled = True
        S1.Visible = True
        R1.Visible = False
        Button3.Visible = False
        Graba.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        otro_cliente()
    End Sub

    Private Sub procesa()
        llena_consumos()
        llena_fpos_rec(C4.Text, fpo, f_rec)
        llena_fg()
        cortes()
        costura()
        fecha_costura()
        llena_exportacion_stock()
        exportacion()
        busca_datos()
        If C4.Text = "ANTIGUA" Then
            fg.Cols(29).Visible = True
        End If
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 2
        fg.Rows.Fixed = 2
        fg.Cols.Fixed = 7
        fg.Cols.Count = 32
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Rows(1).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "RCVD.PO"
        fg.Cols(2).Name = "PO"
        fg.Cols(3).Name = "STYLE"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "SIZE"
        fg.Cols(6).Name = "QTY"
        fg.Cols(7).Name = "PLAN"
        fg.Cols(8).Name = "ACTUAL"
        fg.Cols(9).Name = "LB"
        fg.Cols(10).Name = "BALAN."
        fg.Cols(11).Name = "FPO #"
        fg.Cols(12).Name = "PLAN"
        fg.Cols(13).Name = "ACTUAL"
        fg.Cols(14).Name = "ACT.PCS"
        fg.Cols(15).Name = "% AC-PL"
        fg.Cols(16).Name = "PLAN"
        fg.Cols(17).Name = "ACTUAL"
        fg.Cols(18).Name = "SEWING"
        fg.Cols(19).Name = "BALAN."
        fg.Cols(20).Name = "% AC-PL"
        fg.Cols(21).Name = "SHIP 1rst"
        fg.Cols(22).Name = "BALAN."
        fg.Cols(23).Name = "% AC-PL"
        fg.Cols(24).Name = "ORIGINAL"
        fg.Cols(25).Name = "REVISED"
        fg.Cols(26).Name = "ACTUAL"
        fg.Cols(29).Name = "X-CHARL."
        fg.Cols(30).Name = "CERRAR?"
        fg.Cols(28).Visible = False
        fg.Cols(31).Visible = False
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 120
            fg(1, index) = fg.Cols(index).Name
            If noe.IndexOf(Format(index, "00")) <> -1 Then
                fg.Cols(index).AllowEditing = True
            Else
                fg.Cols(index).AllowEditing = False
            End If
            If index < 6 Then
                fg.Cols(index).AllowMerging = True
            End If
        Next
        forma_fecha(1)
        forma_entero(6)
        forma_fecha(7)
        forma_fecha(8)
        forma_entero(9)
        forma_entero(10)
        forma_fecha(12)
        forma_fecha(13)
        forma_entero(14)
        forma_fecha(16)
        forma_fecha(17)
        forma_entero(18)
        forma_entero(19)
        forma_entero(21)
        forma_entero(22)
        forma_fecha(24)
        forma_fecha(25)
        forma_fecha(26)
        forma_fecha(29)
        fg.Cols(2).Width = 150
        fg.Cols(4).Width = 130
        fg.Cols(5).Width = 50
        fg.Cols(11).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(11).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(15).Width = 50
        fg.Cols(15).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(20).Width = 50
        fg.Cols(20).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(23).Width = 50
        fg.Cols(23).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(27).Width = 250
        fg.Cols(27).AllowMerging = True
        fg.Cols(30).DataType = GetType(Boolean)
        fg.Cols(30).Width = 70
        fg.Cols(30).AllowEditing = True
        fg.Cols(30).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(30).TextAlignFixed = TextAlignEnum.CenterCenter

        Dim rng1 = fg.GetCellRange(0, 1, 0, 6)
        rng1.Data = "PO INFORMATION"
        rng1.Style = fg.Styles("c1")
        fg.Rows(0).AllowMerging = True

        rng1 = fg.GetCellRange(1, 1, 1, 6)
        rng1.Style = fg.Styles("c2")

        rng1 = fg.GetCellRange(0, 7, 0, 11)
        rng1.Data = "FABRIC RECEIVED"
        rng1.Style = fg.Styles("c3")

        rng1 = fg.GetCellRange(1, 7, 1, 11)
        rng1.Style = fg.Styles("c4")

        rng1 = fg.GetCellRange(0, 12, 0, 15)
        rng1.Data = "START CUT"
        rng1.Style = fg.Styles("c1")
        fg.Rows(0).AllowMerging = True

        rng1 = fg.GetCellRange(1, 12, 1, 15)
        rng1.Style = fg.Styles("c2")

        rng1 = fg.GetCellRange(0, 16, 0, 20)
        rng1.Data = "START SEW"
        rng1.Style = fg.Styles("c3")

        rng1 = fg.GetCellRange(1, 16, 1, 20)
        rng1.Style = fg.Styles("c4")

        rng1 = fg.GetCellRange(0, 21, 0, 23)
        rng1.Data = "START SHIP        "
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(1, 21, 1, 23)
        rng1.Style = fg.Styles("c2")


        rng1 = fg.GetCellRange(0, 24, 0, 26)
        rng1.Data = "EX FACTORY DATE"
        rng1.Style = fg.Styles("c3")

        rng1 = fg.GetCellRange(1, 24, 1, 26)
        rng1.Style = fg.Styles("c4")

        rng1 = fg.GetCellRange(0, 27, 1, 27)
        rng1.Data = "  COMMENTS"
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(0, 29, 1, 29)
        rng1.Data = ""
        rng1.Style = fg.Styles("c3")

        rng1 = fg.GetCellRange(0, 30, 1, 30)
        rng1.Data = ""
        rng1.Style = fg.Styles("ci")

        fg(1, 29) = "X-CHAR."
        fg(1, 30) = "CERRAR?"
        fg.Cols(24).AllowEditing = False
        fg.Cols(26).AllowEditing = False
        fg.Cols(29).Visible = False

        For index = 7 To 11
            fg.Cols(index).Visible = False
        Next
    End Sub

    Private Sub forma_fecha(ByVal c As Integer)
        fg.Cols(c).DataType = GetType(Date)
        fg.Cols(c).Format = d
        fg.Cols(c).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(c).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(c).Width = 75
    End Sub

    Private Sub forma_entero(ByVal c As Integer)
        fg.Cols(c).DataType = GetType(Integer)
        fg.Cols(c).Format = "##,##0"
        fg.Cols(c).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(c).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(c).Width = 60
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\wip.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub busca_datos()
        Dim dr As DataRow
        Dim i As Integer
        Dim busca As String
        Dim f As String = "dd-MM-yyyy"
        strSQl = "SELECT * FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + Trim(dr("TALLA"))
            i = fg.FindRow(busca, 2, 0, True)
            If i > 1 Then
                'fechas(f, dr("FAB_PLAN"), fg(i, 7), ok)
                'fechas(f, dr("FAB_ACTUAL"), fg(i, 8), ok)
                fechas(f, dr("CUT_PLAN"), fg(i, 12), "R", ok)
                fechas(f, dr("SEW_PLAN"), fg(i, 16), "R", ok)
                'fechas(f, dr("EXP_PLAN"), fg(i, 24), ok)
                fechas(f, dr("EXP_REV"), fg(i, 25), "R", ok)
                fechas(f, dr("EXP_ACTUAL"), fg(i, 26), "R", ok)
                fg(i, 27) = dr("COMENTARIOS")
                Try
                    fechas(f, dr("EX_CHAR"), fg(i, 29), "R", ok)
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub llena_fg()
        Dim cpos As String = ""
        Dim estilo As String = ""
        Dim coloc As String = ""
        Dim dr As DataRow
        Dim i As Integer
        Dim l As Integer
        Dim c As Integer
        Dim talla As String
        Dim prendas As Integer
        Dim total As Object
        Dim consumo As Decimal
        Dim consume As Object
        Dim foundrows As DataRow()
        Dim dtr As DataRow
        Dim j As Integer
        Dim knit As String
        Dim colo As String
        Dim libras As Decimal
        Dim fecha As Date
        Dim fechar As Date
        Dim unidad As Integer
        Dim clinea As Integer
        Dim frec As Object
        strSQl = "SELECT CPO_D.* , CPO.CLIENTE, CPO.F_PEDIDO FROM CPO_D, CPO WHERE CPO_D.CPO = CPO.CPO AND CLIENTE = '" & C4.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.CPO,ESTILO,COLOR"
        llena_tablas(cpo, strSQl, cnn)
        l = cpo.Rows.Count
        l = l * 12
        fg.Rows.Count = l + 2
        l = 2
        c = 0
        For Each dr In cpo.Rows
            clinea = l
            For i = 0 To 10
                talla = te(i)
                prendas = dr("TOTAL")
                cpos = dr("CPO")
                estilo = dr("ESTILO")
                coloc = dr("COLOR")
                unidad = dr(talla)
                If unidad > 0 Then
                    fg(l, 1) = dr("F_PEDIDO")
                    fg(l, 2) = cpos
                    fg(l, 3) = estilo
                    fg(l, 4) = coloc
                    fg(l, 5) = tv(i)
                    fg(l, 6) = dr(talla)
                    fg(l, 14) = 0
                    fg(l, 15) = "   0%"
                    fg(l, 18) = 0
                    fg(l, 19) = 0
                    fg(l, 20) = "   0%"
                    fg(l, 21) = 0
                    fg(l, 22) = 0
                    fg(l, 23) = "   0%"
                    fg(l, 24) = dr("F_ENTREGA")
                    fg(l, 0) = Trim(fg(l, 2)) + Trim(fg(l, 3)) + Trim(fg(l, 4)) + Trim(fg(l, 5))
                    fg(l, 31) = Trim(cpos) + Trim(estilo) + Trim(coloc)
                    cambia_estilos(l, st(c))
                    l = l + 1
                End If
            Next
            libras = 0
            consumo = 0
            fecha = Date.MinValue
            fechar = Date.MinValue
            foundrows = con.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & coloc & "'")
            For j = 0 To foundrows.GetUpperBound(0)
                dtr = foundrows(j)
                knit = dtr("KNIT_TELA")
                colo = dtr("COLOR_TELA")
                consume = fpo.Compute("SUM(LIBRAS)", "KNIT = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                total = fpo.Compute("SUM(RECIBIDAS)", "KNIT = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                Try
                    libras = libras + CDec(total)
                Catch
                End Try
                Try
                    consumo = consumo + CDec(consume)
                Catch
                End Try
                total = fpo.Compute("MAX(RFECHA)", "KNIT = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                Try
                    If CDate(total) > fecha Then
                        fecha = CDate(total)
                    End If
                Catch
                End Try

                Try
                    frec = f_rec.Compute("MAX(FECHA)", "KNIT = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                    Try
                        If CDate(frec) > fechar Then
                            fechar = CDate(frec)
                        End If
                    Catch
                    End Try
                Catch
                End Try
            Next
            fg(clinea, 9) = libras
            fg(clinea, 10) = libras - consumo
            If fecha <> Date.MinValue Then
                fg(clinea, 7) = fecha
            End If
            If fechar <> Date.MinValue Then
                fg(clinea, 8) = fechar
            End If
            Try
                foundrows = fpo.Select("CPO = '" & cpos & "'")
                dtr = foundrows(0)
                fg(clinea, 11) = dtr("FPO")
            Catch
            End Try
            Try
                foundrows = f_rec.Select("CPO = '" & cpos & "'")
                dtr = foundrows(0)
                fg(clinea, 11) = dtr("FPO")
            Catch
            End Try

            cambia_estilos(l, st(c))
            fg.Rows(l).AllowEditing = False
            l = l + 1
            c = c + 1
            If c > 1 Then
                c = 0
            End If
        Next
        fg.Rows.Count = l
    End Sub

    Private Sub cambia_estilos(ByVal l As Integer, ByVal st As String)
        Dim i As Integer
        For i = 0 To 6
            fg.SetCellStyle(l, i, fg.Styles(st))
        Next
        fg.Rows(l).Style = fg.Styles(st)
    End Sub

    Private Sub cortes()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim ya As Boolean
        strSQl = "SELECT CPO,ESTILO,COLOR,FCORTE,SUM(XS) AS XS ,SUM(S) AS S,SUM(M) AS M ,SUM(L) AS L,SUM(XL) AS XL ,SUM(XL2) AS XL2 ,SUM(XL3) AS XL3 ,SUM(XL4) AS XL4 ,SUM(XL5) AS XL5 ,SUM(XL6) AS XL6,SUM(TOTAL) AS TOTAL  FROM CORTES WHERE CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR,FCORTE ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            ya = False
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + tv(i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    If Not ya Then
                        fg(f, 13) = dr("FCORTE")
                        ya = True
                    End If
                    fg(f, 14) = fg(f, 14) + dr(te(i))
                    If fg(f, 14) > 0 Then
                        Try
                            por = (fg(f, 14) * 100) / fg(f, 6)
                            fg(f, 15) = Format(por, "###0") + "%"
                        Catch
                            fg(f, 15) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub costura()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(TOTAL) AS TOTAL  FROM CORTES_P,CORTES WHERE CORTES_P.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + tv(i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, 18) = dr(te(i))
                    If fg(f, 18) > 0 Then
                        Try
                            If i < 10 Then
                                total = total + fg(f, 18)
                            Else
                                fg(f, 18) = total
                            End If
                            fg(f, 19) = fg(f, 18) - fg(f, 6)
                            por = (fg(f, 18) * 100) / fg(f, 6)
                            fg(f, 20) = Format(por, "###0") + "%"
                        Catch
                            fg(f, 20) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub exportacion()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        Dim pr As Integer
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(TOTAL) AS TOTAL  FROM CORTES_E,CORTES WHERE CORTES_E.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + tv(i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    exportacion_stock(dr("CPO"), dr("ESTILO"), dr("COLOR"), te(i), pr)
                    fg(f, 21) = dr(te(i)) + pr
                    If fg(f, 21) > 0 Then
                        Try
                            If i < 10 Then
                                total = total + fg(f, 21)
                            Else
                                fg(f, 21) = total
                            End If
                            por = (fg(f, 21) * 100) / fg(f, 6)
                            fg(f, 23) = Format(por, "###0") + "%"
                            fg(f, 22) = fg(f, 21) - fg(f, 6)
                        Catch
                            fg(f, 23) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub llena_exportacion_stock()
        strSQl = "SELECT CPO,ESTILO,COLOR,TALLA,SUM(PRENDAS)AS STOCK FROM S_STOCK WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE CLIENTE = '" & C4.Text & "' AND ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR,TALLA"
        llena_tablas(es, strSQl, cnn)
    End Sub

    Private Sub exportacion_stock(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByVal talla As String, ByRef prendas As Integer)
        Dim dw As DataRow()
        Dim dj As DataRow
        dw = es.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "' AND TALLA = '" & talla & "'")
        If dw.Length > 0 Then
            dj = dw(0)
            prendas = dj("STOCK")
        Else
            prendas = 0
        End If
    End Sub

    Private Sub llena_consumos()
        strSQl = "SELECT * FROM CPO_EST_COL WHERE ESTILO_CPO+COLOR_CPO IN (SELECT ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND CLIENTE = '" & C4.Text & "' ORDER BY ESTILO_CPO,COLOR_CPO"
        llena_tablas(con, strSQl, cnn)
    End Sub


    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        If noe.IndexOf(Format(c, "00")) <> -1 Then
            If e.KeyCode = Keys.Delete Then
                fg(f, c) = Nothing
                fg(f, 28) = "X"
            End If
        End If
    End Sub

    Private Sub verifica_ordenes(ByVal f As Integer, ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & fg(f, 2) & "' AND ESTILO = '" & fg(f, 3) & "' AND COLOR = '" & fg(f, 4) & "' AND EXPORTADO = 'N'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            ok = False
        Else
            ok = True
        End If
    End Sub

    Private Sub fechas(ByVal f As String, ByRef fecha As Date, ByRef res As String, ByVal tp As String, ByVal ok As Boolean)
        If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
            res = Format(fecha, f)
            ok = True
        Else
            res = "01-01-1900"
        End If

        If res = "01-01-1900" And tp <> "G" Then
            res = Nothing
        End If
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Label1.Visible = True
        Label1.Refresh()
        Cursor = Cursors.WaitCursor
        grabacion()
        Cursor = Cursors.Default
        otro_cliente()
        Label1.Visible = False
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        Dim c As Integer = e.Col
        If c = 25 Then
            actualiza_fecha_exp(fg(r, 2), fg(r, 3), fg(r, 4), fg(r, 25))

        End If
        If c = 30 Then
            verifica_ordenes(r, ok)
            If Not ok Then
                MsgBox("No puede Cerrar la Cpo.  Aun existen cortes sin exportación ", MsgBoxStyle.Critical, "Por favor Revise !!!!")
                fg(r, 30) = False
                Exit Sub
            End If
        End If
        fg(r, 28) = "X"
    End Sub

    Private Sub actualiza_fecha_exp(ByVal cpo As String, ByVal estilo As String, ByVal colores As String, ByVal fecha As Date)
        Dim i As Integer
        Dim f As Integer = 1
        Dim busca As String = cpo + estilo + colores
        i = fg.FindRow(busca, f, 31, False)
        While i > 0
            fg(i, 25) = fecha
            fg(i, 28) = "X"
            f = i + 1
            i = fg.FindRow(busca, f, 31, False)
        End While
    End Sub

    Private Sub fecha_costura()
        Dim dr As DataRow
        Dim i As Integer
        Dim f As Integer
        Dim busca As String
        strSQl = "SELECT DISTINCT (CPO+ESTILO+COLOR+PROD_DIARIA.CORTE),CPO,ESTILO,COLOR,PROD_DIARIA.CORTE,FECHA FROM PROD_DIARIA,CORTES WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(fco, strSQl, cnn)
        For Each dr In fco.Rows
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + tv(i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, 17) = dr("FECHA")
                    Exit For
                End If
            Next
        Next
    End Sub
    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub


    ' =================================================================================
    ' =                            ACTUALIZA TABLAS
    ' =================================================================================

    Private Sub grabacion()
        Dim strsql As String = ""
        Dim afectados As Integer
        Dim i As Integer
        Dim fab_plan As String = ""
        Dim fab_actual As String = ""
        Dim cut_plan As String = ""
        Dim cut_actual As String = ""
        Dim sew_plan As String = ""
        Dim sew_actual As String = ""
        Dim exp_plan As String = ""
        Dim exp_rev As String = ""
        Dim exp_actual As String = ""
        Dim ex_char As String = ""
        Dim ser_plan As String = ""
        Dim bor_plan As String = ""
        Dim comentarios As String
        Dim ok As Boolean
        Dim f As String = "yyyy-MM-dd"

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            For i = 2 To fg.Rows.Count - 1
                If fg(i, 28) = "X" Then
                    ok = False
                    fechas(f, fg(i, 7), fab_plan, "G", ok)
                    fechas(f, fg(i, 8), fab_actual, "G", ok)
                    fechas(f, fg(i, 12), cut_plan, "G", ok)
                    fechas(f, fg(i, 13), cut_actual, "G", ok)
                    fechas(f, fg(i, 16), sew_plan, "G", ok)
                    fechas(f, fg(i, 17), sew_actual, "G", ok)
                    fechas(f, fg(i, 24), exp_plan, "G", ok)
                    fechas(f, fg(i, 25), exp_rev, "G", ok)
                    fechas(f, fg(i, 26), exp_actual, "G", ok)
                    fechas(f, fg(i, 29), ex_char, "G", ok)
                    ser_plan = "01-01-1900"
                    bor_plan = "01-01-1900"
                    comentarios = fg(i, 27)
                    Try
                        If comentarios.Length > 50 Then
                            comentarios = Mid(comentarios, 1, 50)
                        Else
                            If comentarios <> "" Then
                                ok = True
                            End If
                        End If
                    Catch
                    End Try
                    Try
                        strsql = "INSERT INTO WIP0 (CPO,ESTILO,COLOR,TALLA,FAB_PLAN,FAB_ACTUAL,CUT_PLAN,CUT_ACTUAL,SEW_PLAN,SEW_ACTUAL,EXP_PLAN,EXP_REV,EXP_ACTUAL,COMENTARIOS,EX_CHAR,SER_PLAN,BOR_PLAN)" & _
                                      "VALUES ( '" & fg(i, 2) & "','" & _
                                               fg(i, 3) & "','" & _
                                               fg(i, 4) & "','" & _
                                               fg(i, 5) & "','" & _
                                               fab_plan & "','" & _
                                               fab_actual & "','" & _
                                               cut_plan & "','" & _
                                               cut_actual & "','" & _
                                               sew_plan & "','" & _
                                               sew_actual & "','" & _
                                               exp_plan & "','" & _
                                               exp_rev & "','" & _
                                               exp_actual & "','" & _
                                               comentarios & "','" & _
                                               ex_char & "','" & _
                                               ser_plan & "','" & _
                                               bor_plan & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    Catch ex As Exception
                        strsql = "UPDATE WIP0 SET CUT_PLAN = '" & cut_plan & "',CUT_ACTUAL = '" & cut_actual & "',EXP_PLAN = '" & exp_plan & "',EXP_REV = '" & exp_rev & "',EXP_ACTUAL = '" & exp_actual & "',COMENTARIOS = '" & comentarios & "' ,EX_CHAR = '" & ex_char & "' " & _
                                        "WHERE CPO = '" & fg(i, 2) & "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "'"  ' AND TALLA = '" & fg(i, 5) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End Try

                    If fg(i, 30) = True Then
                        strsql = "UPDATE CPO_D SET ESTADO = 'C' WHERE CPO = '" & fg(i, 2) & "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                End If
            Next
            strsql = "DELETE FROM WIP0 WHERE CPO+ESTILO+COLOR NOT IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Error en Grabación" + vbLf + strsql, MsgBoxStyle.Critical, "Por favor revise !!!!")
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

End Class



