Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing
Public Class Lista_empaque_A
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dp As New DataTable()
    Dim cp As New DataTable()
    Dim ex As New DataTable()
    Dim dr As DataRow
    Dim dw As DataRow
    Dim strSQl As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Embarque As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_A))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Embarque = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Embarque
        '
        Me.Embarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embarque.Location = New System.Drawing.Point(128, 8)
        Me.Embarque.Name = "Embarque"
        Me.Embarque.Size = New System.Drawing.Size(200, 28)
        Me.Embarque.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Embarque, "Embarque.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(888, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Desplegar la Consulta.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(888, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 83
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Otro Embarque")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.Location = New System.Drawing.Point(936, 8)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(35, 35)
        Me.Imprimir.TabIndex = 86
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.UseVisualStyleBackColor = False
        Me.Imprimir.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(1, 56)
        Me.jg.Name = "jg"
        Me.jg.Rows.Count = 1
        Me.jg.Rows.DefaultSize = 19
        Me.jg.Size = New System.Drawing.Size(1008, 632)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 80
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 15
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 616)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 85
        '
        'Lista_empaque_A
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.Embarque)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_A"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria de Cpo´s"
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Lista_empaque_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Embarque.KeyPress, AddressOf keypressed1
        setea_jg()
        llena_empaque()
    End Sub

    Private Sub llena_empaque()
        Embarque.Enabled = True
        llena_combos(Embarque, "SELECT DISTINCT EMBARQUE, FECHA FROM PACKING_E ORDER BY FECHA DESC", "EMBARQUE")
        Try
            Embarque.SelectedIndex = 0
        Catch
        End Try
        Button2.Visible = True
        regresa.Visible = False
        Imprimir.Visible = False
    End Sub

    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
    End Sub

    Private Sub llena_jg()
        Dim dt As New DataTable()
        Dim l As Integer = 1
        strSQl = "SELECT PACKING_E.*,(SELECT SUM(PRENDAS) FROM PACKING_C WHERE PACKING_E.EMBARQUE = PACKING_C.EMBARQUE AND PACKING_E.CPO = PACKING_C.CPO AND PACKING_E.ESTILO = PACKING_C.ESTILO AND PACKING_E.COLOR = PACKING_C.COLOR ) AS PRENDA FROM PACKING_E WHERE PACKING_E.EMBARQUE = '" & Embarque.Text & "'"
        llena_tablas(dt, strSQl, cnn)
        jg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            jg(l, 1) = dr("CPO")
            jg(l, 2) = dr("ESTILO")
            jg(l, 3) = dr("COLOR")
            jg(l, 4) = dr("DESTINO")
            jg(l, 5) = dr("PRENDA")
            jg(l, 6) = False
            l = l + 1
        Next
        If l > 1 Then
            jg(1, 6) = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Embarque.Enabled = False
        llena_jg()
        Button2.Visible = False
        regresa.Visible = True
        Imprimir.Visible = True
    End Sub


    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        llena_empaque()
        setea_jg()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Embarque.Text) <> "" Then
                Button2.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub jg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jg.Click
        Dim i As Integer
        For i = 1 To jg.Rows.Count - 1
            If i <> jg.RowSel Then
                jg(i, 6) = False
            Else
                jg(i, 6) = True
            End If
        Next
    End Sub

    Private Sub forma_lista()
        Dim dt As New DataTable()
        Dim dd As New DataTable()
        Dim cpo As String = jg(jg.RowSel, 1)
        Dim estilo As String = jg(jg.RowSel, 2)
        Dim colo As String = jg(jg.RowSel, 3)
        Dim l As Integer = 0
        Dim pri As Integer
        Dim i As Integer
        Dim j As Integer
        Dim talla As String = ""
        Dim c As Integer
        Dim prendas As Integer
        Dim t(11) As Integer
        Dim p(12) As Decimal
        Dim rgn As CellRange
        Dim da As DataRow()
        Dim dl As DataRow()
        Dim dc As DataRow = Nothing
        Dim ep As DataRow = Nothing
        strSQl = "SELECT PACKING_C.*, FECHA FROM PACKING_C LEFT JOIN PACKING_E ON PACKING_C.EMBARQUE = PACKING_E.EMBARQUE AND PACKING_C.CPO = PACKING_E.CPO AND PACKING_C.ESTILO = PACKING_E.ESTILO AND PACKING_C.COLOR = PACKING_E.COLOR WHERE PACKING_C.EMBARQUE = '" & Embarque.Text & "' AND PACKING_C.CPO = '" & cpo & "' AND PACKING_C.ESTILO = '" & estilo & "' AND PACKING_C.COLOR = '" & colo & "' ORDER BY CAJA"
        llena_tablas(dd, strSQl, cnn)
        If dd.Rows.Count > 0 Then
            dw = dd.Rows(0)
            encabezado()
            pri = fg.Rows.Count
            'crea_linea(talla, c, l)
        End If
        For Each Me.dw In dd.Rows
            If dw("TALLA") <> talla Or dw("PRENDAS") <> prendas Then
                crea_linea(talla, c, l)
            End If
            prendas = CInt(dw("PRENDAS"))
            fg(l, 2) = dw("CAJA")
            fg(l, c) = fg(l, c) + prendas
            fg(l, 18) = fg(l, 18) + prendas
        Next
        l = fg.Rows.Count
        fg.Rows.Count = l + 1
        rgn = fg.GetCellRange(pri, 1, l - 1, 18)
        rgn.Style = fg.Styles("si")
        For i = pri To l - 1
            fg(i, 17) = fg(i, 2) - fg(i, 1) + 1
            fg(i, 16) = fg(i, 18) / fg(i, 17)
            For j = 6 To 18
                If j <> 16 Then
                    fg(l, j) = fg(l, j) + fg(i, j)
                End If
            Next
        Next
        fg.Rows(l).Height = 25
        fg(l, 5) = "SUBTOTAL"
        rgn = fg.GetCellRange(l, 1, l, 18)
        rgn.Style = fg.Styles("sb")

        da = cp.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
        If da.Length > 0 Then
            dc = da(0)
            dl = ex.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
            If dl.Length > 0 Then
                ep = dl(0)
            End If
        End If

        fg.Rows.Count = fg.Rows.Count + 4
        rgn = fg.GetCellRange(l + 1, 1, l + 1, 18)
        rgn.Style = fg.Styles("pj")
        ReDim p(11)
        For i = 0 To 9
            t(i) = t(i) + fg(l, i + 6)
            Try
                p(i) = ep(i + 3) / dc(i + 3)
                fg(l + 1, i + 6) = p(i)
                p(10) = p(10) + dc(i + 3)
                p(11) = p(11) + ep(i + 3)
            Catch
                p(i) = 0
            End Try
        Next
        t(10) = t(10) + fg(l, 17)
        t(11) = t(11) + fg(l, 18)
        fg(l + 1, 18) = p(11) / p(10)

        'PORCENTAJE ====================

        rgn = fg.GetCellRange(l + 2, 1, l + 4, 18)
        rgn.Style = fg.Styles("nada")


        ' ============== GRAN TOTAL ===================
        l = fg.Rows.Count - 1
        For i = 0 To 9
            fg(l, i + 6) = t(i)
        Next
        fg(l, 17) = t(10)
        fg(l, 18) = t(11)


        fg.Rows(l).Height = 30
        fg(l, 5) = "GRAN TOTAL"
        rgn = fg.GetCellRange(l, 1, l, 18)
        rgn.Style = fg.Styles("gt")

    End Sub

    Private Sub crea_linea(ByRef talla As String, ByRef c As Integer, ByRef l As Integer)
        Dim caja As String = dw("CAJA")
        l = fg.Rows.Count
        talla = dw("TALLA")
        c = fg.Cols.IndexOf(talla)
        If caja = fg(l - 1, 2) Then
            l = l - 1
            Exit Sub
        End If
        fg.Rows.Count = fg.Rows.Count + 1
        fg(l, 1) = dw("CAJA")
        fg(l, 3) = dw("ESTILO")
        fg(l, 4) = dw("CPO")
        fg(l, 5) = dw("COLOR")
    End Sub

    Private Sub encabezado()
        Dim descripcion As String = ""
        Dim cliente As String = ""
        Dim rgn As CellRange
        Dim l As Integer = fg.Rows.Count
        Dim dn As DataRow
        Dim ds As DataRow()
        Dim estilo As String
        Dim cuenta As Integer = dp.Rows.Count
        Try
            estilo = dw("ESTILO")
            ds = dp.Select("ESTILO = '" & estilo & "'")
            If ds.Length > 0 Then
                dn = ds(0)
                descripcion = dn("DESCRIPCION")
            End If
        Catch
        End Try

        Try
            ds = cp.Select("ESTILO = '" & jg(jg.RowSel, 1) & "' AND COLOR = '" & jg(jg.RowSel, 2) & "'")
            If ds.Length > 0 Then
                dn = ds(0)
                cliente = dn("CLIENTE")
            End If
        Catch
        End Try

        fg.Rows.Count = fg.Rows.Count + 3
        fg.Rows(l).Height = 40
        fg.Rows(l + 1).Height = 30
        fg.Rows(l + 2).Height = 30

        fg.Rows(l).AllowMerging = True
        rgn = fg.GetCellRange(l, 0, l, 3)
        rgn.Data = cliente
        rgn.Style = fg.Styles("cliente")

        rgn = fg.GetCellRange(l, 4, l, 14)
        rgn.Data = descripcion
        rgn.Style = fg.Styles("sin")

        rgn = fg.GetCellRange(l, 11, l, 18)
        rgn.Data = " "
        rgn.Style = fg.Styles("abajo")

        fg.Rows(l + 1).AllowMerging = True
        rgn = fg.GetCellRange(l + 1, 1, l + 1, 2)
        rgn.Data = "CARTON #"
        rgn.Style = fg.Styles("si")

        rgn = fg.GetCellRange(l + 1, 14, l + 1, 18)
        rgn.Style = fg.Styles("si")

        fg(l + 1, 16) = "PER"
        fg(l + 1, 17) = "TTL"
        fg(l + 1, 18) = "TTL"


        rgn = fg.GetCellRange(l + 1, 3, l + 1, 14)
        rgn.Data = ""
        rgn.Style = fg.Styles("abajo")

        l = l + 2
        rgn = fg.GetCellRange(l, 1, l, 18)
        rgn.Style = fg.Styles("normal")
        fg(l, 1) = "FM"
        fg(l, 2) = "TO"
        fg(l, 3) = "STYLE"
        fg(l, 4) = "PO#"
        fg(l, 5) = "COLOR"
        fg(l, 6) = "XS"
        fg(l, 7) = "S"
        fg(l, 8) = "M"
        fg(l, 9) = "L"
        fg(l, 10) = "XL"
        fg(l, 11) = "2XL"
        fg(l, 12) = "3XL"
        fg(l, 13) = "4XL"
        fg(l, 14) = "5XL"
        fg(l, 15) = "6XL"
        fg(l, 16) = "CTNS"
        fg(l, 17) = "CTNS"
        fg(l, 18) = "PCS"
    End Sub

    Private Sub llena_descripcion()
        dp = New DataTable()
        llena_tablas(dp, "SELECT ESTILO,DESCRIPCION FROM ESTILOS WHERE ESTILO IN (SELECT DISTINCT ESTILO FROM PACKING_E WHERE EMBARQUE = '" & Embarque.Text & "')", cnn)
    End Sub

    Private Sub calcula_porcentaje()
        cp = New DataTable()
        llena_tablas(cp, "SELECT * ,CLIENTE FROM CPO_D JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CPO_D.CPO + ESTILO + COLOR IN (SELECT CPO+ESTILO+COLOR FROM PACKING_E WHERE EMBARQUE = '" & Embarque.Text & "')", cnn)
        ex = New DataTable()
        llena_tablas(ex, "SELECT CPO,ESTILO,COLOR, SUM(XS) AS P0, SUM(S) AS P1,SUM(M) AS P2,SUM(L) AS P3,SUM(XL) AS P4,SUM(XL2) AS P5,SUM(XL3) AS P6,SUM(XL4) AS P7,SUM(XL5) AS P8,SUM(XL6) AS P9  FROM PACKING_D WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM PACKING_D WHERE EMBARQUE = '" & Embarque.Text & "') GROUP BY CPO,ESTILO,COLOR ", cnn)
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        fg.Rows(0).Visible = False
        fg.Rows.Count = 1
        jg(jg.RowSel, 6) = True
        llena_descripcion()
        calcula_porcentaje()
        forma_lista()
        Print_fg()
    End Sub


    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String = Format(dw("FECHA"), "dd-MMM-yyyy")
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
        fg.PrintGrid("Listado para Auditoría", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Listado para Auditoría   Embarque: " + Embarque.Text + Chr(9) + Chr(9) + "Page {0}", "Fecha del Embarque: " + fecha)
    End Sub
End Class



