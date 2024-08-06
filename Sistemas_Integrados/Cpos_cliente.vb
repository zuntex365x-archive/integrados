Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cpos_cliente
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim strSQl As String
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Dim da(9) As Integer
    Dim st(3) As String
    Dim path As String = "c:\reportes\Cpos_cliente.xls"
    Dim estados(3) As String
    Friend WithEvents s1 As System.Windows.Forms.Button
    Friend WithEvents r1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Dim cpoin As String
    Dim filter As New C1.Win.C1FlexGrid.ConditionFilter
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
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Estad As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cpos_cliente))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Estad = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.s1 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(88, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Estad
        '
        Me.Estad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estad.Items.AddRange(New Object() {"TODOS", "ABIERTOS", "CERRADOS", "CANCELADOS"})
        Me.Estad.Location = New System.Drawing.Point(464, 8)
        Me.Estad.Name = "Estad"
        Me.Estad.Size = New System.Drawing.Size(128, 24)
        Me.Estad.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.Estad, "Elija el Estado  a Consultar .")
        Me.Estad.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(17, 44)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 20
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(976, 636)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
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
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(476, 3)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(60, 40)
        Me.button2.TabIndex = 97
        Me.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button2.UseVisualStyleBackColor = False
        Me.button2.Visible = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.Black
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.Location = New System.Drawing.Point(542, 3)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(60, 40)
        Me.button3.TabIndex = 96
        Me.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button3.UseVisualStyleBackColor = False
        Me.button3.Visible = False
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(410, 3)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(60, 40)
        Me.s1.TabIndex = 95
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.s1.UseVisualStyleBackColor = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(410, 3)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(60, 40)
        Me.r1.TabIndex = 93
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r1.UseVisualStyleBackColor = False
        '
        'Cpos_cliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Estad)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.r1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cpos_cliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cpos por Cliente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler C4.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 20
        fg.Height = Me.Height - 85
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        estados = Split("NADA,ABIERTO,CERRADO,CANCELADO", ","c)
        st = Split("customstyle1,customstyle2,customstyle3", ","c)
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
        Estad.SelectedIndex = 0
        Try
            C4.SelectedIndex = 0
        Catch
        End Try

        C4.Focus()

    End Sub

    Private Sub deshabilita()
        C4.Enabled = False
        Estad.Enabled = False
        Button2.Visible = True
        Button3.Visible = True
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Cols.Fixed = 0
        fg.Rows(0).Height = 30
        filter.Reset()
        filter.Condition1.Operator = 7
        fg.Cols("CPO").Filter = filter
        fg.ApplyFilters()
    End Sub
    Private Sub llena_fg()
        Dim cpo As String
        Dim colo As String
        Dim estilo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim l As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        strSQl = "SELECT CPO_D.* , CPO.CLIENTE, CPO.F_PEDIDO , E_TALLAS.NOMBRE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CPO_D.CPO = CPO.CPO  AND CPO.CLIENTE = '" & C4.Text & "' AND ESTADO = 'A' "
        llena_tablas(dt, strSQl, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            cpo = dr("CPO")
            colo = dr("COLOR")
            estilo = dr("ESTILO")
            fg(lineas, 1) = cpo
            fg(lineas, 2) = estilo
            fg(lineas, 3) = colo
            dato = "SACX"
            l = dato.IndexOf(dr("ESTADO"))
            Try
                fg(lineas, 4) = estados(l)
            Catch
            End Try
            fg(lineas, 5) = dr("NOMBRE")
            total = 0
            For i = 0 To 9
                dato = te(i)
                fg(lineas, i + 6) = dr(dato)
                total = total + fg(lineas, i + 6)
            Next i
            fg(lineas, 16) = total
            fg(lineas, 17) = dr("F_PEDIDO")
            fg(lineas, 18) = dr("F_ENTREGA")
            fg(lineas, 19) = dr("MINIMO_P")
            fg(lineas, 20) = dr("MAXIMO_P")
            lineas = lineas + 1
        Next
        subtotales()
        fg.ApplyFilters()
    End Sub
    Private Sub subtotales()
        Dim i As Integer
        For i = 6 To 16
            Try
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran total")
            Catch
            End Try
        Next
    End Sub
    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim empresa As String
        Dim obj As empresas
        obj = New empresas()
        empresa = obj.nombre
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, empresa + "   Reporte de Cpos al : " + fecha + "    " + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub
    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub
    Private Sub estad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estad.KeyPress
        AutoCompletar(Estad, e)
    End Sub

    Private Sub fg_afterfilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

    Private Sub s1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        S1.Visible = False
        R1.Visible = True
        deshabilita()
        Cursor = Cursors.WaitCursor
        llena_fg()
        fg.ScrollBars = ScrollBars.Both
        Cursor = Cursors.Default
        R1.Focus()
    End Sub

    Private Sub r1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        C4.Enabled = True
        Estad.Enabled = True
        S1.Visible = True
        R1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Print_fg()
    End Sub

    Private Sub button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Cpos_Cliente " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        a_excel(fg, hora, ok)
        If ok Then
            Close()
        End If
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            s1.Focus()
        End If
    End Sub 'keypressed

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim form As New Detalle_cpo1
        Dim l As Integer = fg.RowSel
        form.cpo.Text = fg(l, 1)
        form.estilo.Text = fg(l, 2)
        form.colores.Text = fg(l, 3)
        form.cliente.Text = C4.Text
        form.ShowDialog()
    End Sub
End Class



