Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Balance_Tela_c2
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tsd As New DataTable()
    Dim path As String = "c:\reportes\balance_tot.xls"
    Dim obj As empresas
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim inv As DataTable
    Dim con As DataTable
    Dim cpo As DataTable
    Dim res As DataTable
    Dim fpo As DataTable
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
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance_Tela_c2))
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Impri = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Ex = New System.Windows.Forms.Button()
        Me.C1XLBook1 = New C1.C1Excel.C1XLBook()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(12, 3)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 53
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(12, 3)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(60, 40)
        Me.Impri.TabIndex = 58
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Impri.UseVisualStyleBackColor = False
        Me.Impri.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 20
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
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
        Me.Ex.Location = New System.Drawing.Point(78, 3)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(60, 40)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.UseVisualStyleBackColor = False
        Me.Ex.Visible = False
        '
        'Balance_Tela_c2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Impri)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balance_Tela_c2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Global de Tela en Buen Estado"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Rows(0).Visible = True
    End Sub
    Private Sub llena_dt()
        Dim strsql As String = "SELECT CPO_D.CPO,ESTILO,COLOR,CPO_D.TOTAL AS PEDIDAS ,(SELECT SUM(TOTAL) FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR) AS CORTADAS FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(cpo, strsql, cnn)
        strsql = "SELECT ROLLOS.CODIGO,DESCRIPCION,COLOR,CLIENTE,0 AS L_NEC,SUM((ROLLOS.PESO/YARDAS_I)*ROLLOS.YARDAS) AS INV,'0' AS RESERV,'0' AS PEDIDAS,'0' AS BALANCE FROM ROLLOS LEFT JOIN CODIGO_TELA ON ROLLOS.CODIGO = CODIGO_TELA.CODIGO WHERE  YARDAS > 0 AND TIPO = 'TELA' AND ACTIVO IN ('S','0','5') GROUP BY ROLLOS.CODIGO,DESCRIPCION,COLOR,CLIENTE"
        llena_tablas(inv, strsql, cnn)
        strsql = "SELECT REQ_D.CORTE,CODIGO,ROLLOS.COLOR,SUM(REQ_D.PESO)AS LIBRAS FROM REQ_D LEFT JOIN CORTES_S ON REQ_D.CORTE = CORTES_S.CORTE LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE DESPACHADO = 'N' GROUP BY REQ_D.CORTE,CODIGO,ROLLOS.COLOR"
        llena_tablas(res, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR,SUM(LIBRAS) AS LIBRAS FROM FPO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO 'GROUP BY CODIGO,COLOR"
        llena_tablas(fpo, strsql, cnn)
        strsql = "SELECT ESTILO_CPO,COLOR_CPO,CONSUMO_TELA.CODIGO,COLOR_TELA,LIBRAS,DESCRIPCION,CLIENTE FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CONSUMO_TELA.ESTILO_CPO + CONSUMO_TELA.COLOR_CPO IN (SELECT ESTILO + COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A')"
        llena_tablas(con, strsql, cnn)
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim lineas As Integer = 1
        fg.Rows.Count = inv.Rows.Count + 1
        lineas = 1
        For Each dr In inv.Rows
            fg(lineas, 0) = dr("CODIGO")
            fg(lineas, 1) = dr("DESCRIPCION")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("INV")
            fg(lineas, 4) = dr("L_NEC")
            fg(lineas, 5) = dr("PEDIDAS")
            fg(lineas, 6) = dr("RESERV")
            fg(lineas, 7) = fg(lineas, 3) - fg(lineas, 4) + fg(lineas, 5) - fg(lineas, 6)
            If fg(lineas, 7) < 0 Then
                fg.SetCellStyle(lineas, 7, "ROJO")
            End If
            fg(lineas, 8) = dr("CLIENTE")
            lineas = lineas + 1
        Next
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub proceso()
        Dim pedido As Decimal
        Dim cortadas As Decimal
        Dim cinco As Decimal
        Dim unidades As Decimal
        Dim dr As DataRow
        Dim dj As DataRow
        Dim dg As DataRow
        Dim dd As DataRow()
        Dim jj As DataRow()
        Dim row As DataRow
        For Each dr In cpo.Rows
            pedido = dr("PEDIDAS")
            cinco = pedido * 0.05
            Try
                cortadas = dr("CORTADAS")
            Catch ex As Exception
                cortadas = 0
            End Try
            unidades = pedido - cortadas

            If unidades > cinco Then
                '============= LLENA CONSUMOS =========================
                dd = busca("ESTILO_CPO", "COLOR_CPO", dr("ESTILO"), dr("COLOR"), con)
                If dd.Length > 0 Then
                    For Each dj In dd
                        jj = busca("CODIGO", "COLOR", dj("CODIGO"), dj("COLOR_TELA"), inv)
                        If jj.Length > 0 Then
                            dg = jj(0)
                            dg("L_NEC") = dg("L_NEC") + (unidades * dj("LIBRAS"))
                        Else
                            row = inv.NewRow()
                            row("CODIGO") = dj("CODIGO")
                            row("DESCRIPCION") = dj("DESCRIPCION")
                            row("COLOR") = dj("COLOR_TELA")
                            row("CLIENTE") = dj("CLIENTE")
                            row("L_NEC") = (unidades * dj("LIBRAS"))
                            row("INV") = 0
                            row("RESERV") = 0
                            row("PEDIDAS") = 0
                            row("BALANCE") = 0
                            inv.Rows.Add(row)
                        End If
                    Next
                End If
            End If
        Next
        ' ===================== LIBRAS RESERVADAS =================
        For Each dr In res.Rows
            dd = busca("CODIGO", "COLOR", dr("CODIGO"), dr("COLOR"), inv)
            If dd.Length > 0 Then
                dj = dd(0)
                dj("RESERV") = dj("RESERV") + dr("LIBRAS")
            End If
        Next
        ' ===================== FPOS  =================
        For Each dr In fpo.Rows
            dd = busca("CODIGO", "COLOR", dr("CODIGO"), dr("COLOR"), inv)
            If dd.Length > 0 Then
                dj = dd(0)
                dj("PEDIDAS") = dj("PEDIDAS") + dr("LIBRAS")
            End If
        Next
    End Sub

    Private Function busca(ByVal criterio1 As String, ByVal criterio2 As String, ByVal busca1 As String, ByVal busca2 As String, ByVal tabla As DataTable) As DataRow()
        Dim dd As DataRow()
        dd = tabla.Select(criterio1 & " = '" & busca1 & "' AND " & criterio2 & " = '" & busca2 & "'")
        Return dd
    End Function

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        Impri.Visible = True
        Ex.Visible = True
        revisa_consumo()
        llena_dt()
        proceso()
        setea_grid()
        llena_grid()
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        si.Visible = True
        Impri.Visible = False
        Ex.Visible = False
        setea_grid()
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim forma As New Bal_Tela_Det_c1()
        Dim l As Integer = fg.RowSel
        forma.codigo = fg(l, 0)
        forma.descripcion = fg(l, 1)
        forma.colores = fg(l, 2)
        forma.inventar = fg(l, 3)
        forma.necesario = fg(l, 4)
        forma.pedido = fg(l, 5)
        forma.reserva = fg(l, 6)
        forma.balance = fg(l, 7)
        forma.cliente = fg(l, 8)
        forma.tsd = tsd
        forma.ShowDialog()
    End Sub

    Private Sub revisa_consumo()
        Dim dt As New DataTable()
        Dim mala As String = "Los siguientes Estilos - Colores no tienen Consumo !!!" + vbLf
        Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND  CPO.CPO = CPO_D.CPO AND (ESTILO + COLOR NOT IN (SELECT DISTINCT ESTILO_CPO+COLOR_CPO FROM CONSUMO_TELA))"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            For Each dr In dt.Rows
                mala = mala + dr("ESTILO") + vbTab + vbTab + dr("COLOR") + vbLf
            Next
            MsgBox(mala, MsgBoxStyle.Critical, "Antes de Ejecutar la consulta Por Favor Ingrese los Consumos")
        End If
    End Sub

    Private Sub Ex_Click(sender As System.Object, e As System.EventArgs) Handles Ex.Click
        a_excel(fg, path, ok)
    End Sub
End Class
