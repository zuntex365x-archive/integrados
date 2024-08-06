Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Cop_01
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tsd As New DataTable()
    Dim obj As New empresas()
    Dim path As String = "c:\reportes\balance.xls"
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim ge As New DataTable
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ex As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cop_01))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(100, 13)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(268, 28)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Lista de Clientes")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(441, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 53
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(441, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(12, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(984, 631)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Double Click sobre un Knit_Color para ver su Detalle")
        '
        'Ex
        '
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Ex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.Image = CType(resources.GetObject("Ex.Image"), System.Drawing.Image)
        Me.Ex.Location = New System.Drawing.Point(507, 8)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(60, 40)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.UseVisualStyleBackColor = False
        Me.Ex.Visible = False
        '
        'Te
        '
        Me.Te.AllowEditing = False
        Me.Te.BackColor = System.Drawing.Color.White
        Me.Te.ColumnInfo = resources.GetString("Te.ColumnInfo")
        Me.Te.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Te.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.Te.ForeColor = System.Drawing.Color.Black
        Me.Te.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Te.Location = New System.Drawing.Point(8, 48)
        Me.Te.Name = "Te"
        Me.Te.Rows.Count = 1
        Me.Te.Rows.DefaultSize = 19
        Me.Te.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Te.Size = New System.Drawing.Size(984, 632)
        Me.Te.StyleInfo = resources.GetString("Te.StyleInfo")
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.Te, "Presione Double Click sobre un Knit_Color para ver su Detalle")
        '
        'Cop_01
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cop_01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envía datos al COP"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        fg.Height = Me.Height - 130
        fg.Width = Me.Width - 30
        setea_grid()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim strSQL As String = "select CPO_D.CPO,CPO_D.CPO,'0000' AS ORDEN_CORTE,ESTILO,' ' AS MODELO,COLOR,CODIGO,COLOR_TELA, FABRIC,' ' AS COMPONENTE,' ' AS ANCHO_TELA,' ' AS ANCHO_MARKER,' ' AS GSM ,ESTADO,E_TALLAS.NOMBRE ,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,' ' AS PLAN_CORTE,F_PEDIDO,CPO_D.F_ENTREGA FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN CONSUMO_TELA ON CPO.CLIENTE =CONSUMO_TELA.CLIENTE AND CPO_D.ESTILO = ESTILO_CPO AND CPO_D.COLOR = COLOR_CPO LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA LEFT JOIN MAESTRO_TELA ON LEFT(CODIGO,2) = ORDEN  WHERE CPO_D.ESTADO = 'A' AND CPO.CLIENTE = '" & Cliente.Text & "' AND CODIGO IS NOT NULL ORDER BY CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR"
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim c As Integer
        Dim cpo As String
        Dim estilo As String
        Dim colo As String
        Dim j As Integer
        Dim tot As Integer
        Dim ve(10) As Integer
        Dim ta(10) As Integer
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            cpo = dr("CPO")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            tot = 0
            ReDim ve(10)
            ve = get_g(cpo, estilo, colo)
            For j = 1 To 10
                dr(j + 14) = dr(j + 14) - ve(j)
                tot = tot + dr(j + 14)
            Next
            dr(25) = tot
            If tot > 0 Then
                For c = 0 To 28
                    fg(lineas, c + 1) = dr(c)
                Next
                lineas = lineas + 1
            End If
        Next
        fg.Rows.Count = lineas
    End Sub
    Private Sub llena_generado()
        Dim strsql As String = "SELECT  CORTES_S.CPO,CORTES_S.ESTILO,CORTES_S.COLOR,CORTES_S.CORTE,CORTES_S.XS,CORTES_S.S,CORTES_S.M,CORTES_S.L,CORTES_S.XL,CORTES_S.XL2,CORTES_S.XL3,CORTES_S.XL4,CORTES_S.XL5,CORTES_S.XL6,CORTES_S.TOTAL AS TOT_S ,CORTES.XS,CORTES.S,CORTES.M,CORTES.L,CORTES.XL,CORTES.XL2,CORTES.XL3,CORTES.XL4,CORTES.XL5,CORTES.XL6,CORTES.TOTAL AS TOT_C FROM CORTES_S LEFT JOIN CORTES ON CORTES_S.CORTE = CORTES.CORTE WHERE CORTES_S.CPO + CORTES_S.ESTILO + CORTES_S.COLOR IN ( SELECT CPO + ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A' AND CORTES_S.CLIENTE = '" & Cliente.Text & "') "
        ge = New DataTable
        llena_tablas(ge, strsql, cnn)
    End Sub
    Private Function get_g(ByVal cpo As String, ByVal estilo As String, ByVal colo As String) As Integer()
        Dim dr As DataRow = Nothing
        Dim dd As DataRow()
        Dim ve(10) As Integer
        Dim i As Integer
        dd = ge.Select("CPO ='" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
        If dd.Length > 0 Then
            For Each dr In dd
                For i = 1 To 10
                    If dr("TOT_C") > 0 Then
                        ve(i) = ve(i) + dr(i + 14)
                    Else
                        ve(i) = ve(i) + dr(i + 3)
                    End If
                Next
            Next
        End If
        Return ve
    End Function

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
        Ex.Visible = True
        Cliente.Enabled = False
        setea_grid()
        llena_generado()
        llena_grid()
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        setea_grid()
        si.Visible = True
        R1.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
    End Sub

    Private Sub limpia_flex()
        fg.Visible = True
    End Sub


    Private Sub tela_inventario()
        Dim strsql As String
        Dim busca As String
        Dim linea As Integer
        Dim dt As New DataTable()
        strsql = "SELECT CODIGO,COLOR,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE ACTIVO IN ('S','0','5') AND CODIGO+COLOR IN (SELECT CODIGO +COLOR_TELA FROM CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "') AND YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR"
        Dim dr As DataRow
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("CODIGO")) + Trim(dr("COLOR"))
            linea = fg.FindRow(busca, 1, 0, True)
            If linea > 0 Then
                fg(linea, 4) = CDec(dr("LIBRAS"))
            End If
        Next
    End Sub
    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        End If
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Ex_Click(sender As System.Object, e As System.EventArgs) Handles Ex.Click
        Dim path As String = "c:\reportes\COP" + Format(Now, "yyyyMMddHHmmss") + ".xls"
        a_excel(fg, path, ok)
        Close()
    End Sub
End Class
