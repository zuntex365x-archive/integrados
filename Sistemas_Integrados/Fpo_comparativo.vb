Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Fpo_comparativo
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim fpos As String = ""
    Friend WithEvents fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Dim fr As New DataTable
    Dim t(7) As Decimal
    Dim p(7) As String
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
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpo_comparativo))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.si = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(112, 12)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(256, 28)
        Me.Cliente.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Cliente, "Lista de Clientes")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 85)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 20
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(984, 595)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Double Click sobre un Knit_Color para ver su Detalle")
        '
        'tipo
        '
        Me.tipo.AutoCompleteCustomSource.AddRange(New String() {"Fecha Confirmada", "Fecha Ofrecida"})
        Me.tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.Items.AddRange(New Object() {"Fecha Confiración", "Fecha Prometida"})
        Me.tipo.Location = New System.Drawing.Point(112, 41)
        Me.tipo.MaxLength = 20
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(256, 28)
        Me.tipo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tipo, "Lista de Clientes")
        '
        'Ex
        '
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Ex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.Image = CType(resources.GetObject("Ex.Image"), System.Drawing.Image)
        Me.Ex.Location = New System.Drawing.Point(805, 12)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(35, 35)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.UseVisualStyleBackColor = False
        Me.Ex.Visible = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(757, 12)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(35, 35)
        Me.Impri.TabIndex = 58
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Impri.UseVisualStyleBackColor = False
        Me.Impri.Visible = False
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(709, 12)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 4
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(709, 12)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'fecha_inicial
        '
        Me.fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.fecha_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_inicial.Location = New System.Drawing.Point(525, 14)
        Me.fecha_inicial.Name = "fecha_inicial"
        Me.fecha_inicial.Size = New System.Drawing.Size(112, 26)
        Me.fecha_inicial.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.fecha_inicial, "Fecha Inicial")
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
        Me.Te.Location = New System.Drawing.Point(8, 85)
        Me.Te.Name = "Te"
        Me.Te.Rows.Count = 1
        Me.Te.Rows.DefaultSize = 20
        Me.Te.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Te.Size = New System.Drawing.Size(984, 595)
        Me.Te.StyleInfo = resources.GetString("Te.StyleInfo")
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.Te, "Presione Double Click sobre un Knit_Color para ver su Detalle")
        '
        'fecha_final
        '
        Me.fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_final.Location = New System.Drawing.Point(525, 41)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(112, 26)
        Me.fecha_final.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.fecha_final, "Fecha Final")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(410, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Fecha Incio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 32)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Fecha Final:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fpo_comparativo
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.fecha_final)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fecha_inicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Impri)
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
        Me.Name = "Fpo_comparativo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparativo de Fechas de Entrega"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        fg.Width = l - 20
        fg.Height = a - 170
        setea_grid()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CLIENTES ", "CLIENTE")
        Cliente.Items.Add("TODOS")
        tipo.SelectedIndex = 0
    End Sub

    Private Sub setea_grid()
        fg.Rows(0).Height = 30
        fg.Rows.Count = 1
    End Sub
    'Private Sub agrega_negro()
    '    fg.Rows.Count = 3
    '    fg.Rows(1).Style = fg.Styles("negro")
    '    fg.Rows(2).Style = fg.Styles("negro")
    'End Sub
    Private Sub llena_recibido()
        Dim strsql As String
        strsql = "SELECT DISTINCT  FECHA, DMOVTO.FPO, TIPO, KNIT,COLOR, DMOVTO.BATCH FROM DMOVTO, ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' AND DMOVTO.FPO IN  " & fpos
        llena_tablas(fr, strsql, cnn)
    End Sub
    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim tip As String = "F_CONFIRMADA"
        If tipo.SelectedIndex = 1 Then
            tip = "OFECHA"
        End If
        fpos = "('"
        Dim fecha As Date
        Dim fechas1 As String = Format(fecha_inicial.Value, "yyyy-MM-dd")
        Dim fechas2 As String = Format(fecha_final.Value, "yyyy-MM-dd")
        Dim strSQL As String = "SELECT * FROM FPO LEFT JOIN FPO_CONFIRMADA ON FPO.FPO = FPO_CONFIRMADA.FPO AND FPO.TIPO = FPO_CONFIRMADA.TIPO AND FPO.KNIT = FPO_CONFIRMADA.KNIT AND FPO.COLOR = FPO_CONFIRMADA.COLOR AND FPO.LOTE = FPO_CONFIRMADA.LOTE WHERE FPO.TIPO = 'TELA' AND  " & tip & " BETWEEN '" & fechas1 & "' AND '" & fechas2 & "' "
        If Cliente.Text <> "TODOS" Then
            strSQL = strSQL + " AND CLIENTE = '" & Cliente.Text & "'"
        End If
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 0) = dr("LIBRAS")
            fg(l, 1) = dr("FPO")
            fg(l, 2) = dr("CLIENTE")
            fg(l, 3) = dr("KNIT")
            fg(l, 4) = dr("COLOR")
            fg(l, 5) = dr("LOTE")
            fecha = dr(tip)
            fg(l, 6) = fecha
            If fpos.IndexOf(dr("FPO")) - 1 Then
                fpos = fpos + "','" + dr("FPO")
            End If
            l = l + 1
        Next
        If fpos.Length > 0 Then
            fpos = Mid(fpos, 1, fpos.Length - 1) + "')"
        Else
            fpos = fpos + "')"
        End If
    End Sub
    Private Sub calcula_cumplimiento()
        Dim i As Integer
        Dim fec As Date
        Dim d As Integer = 0
        For i = 1 To fg.Rows.Count - 1
            fec = fecha_recepcion(fg(i, 1), fg(i, 3), fg(i, 4), fg(i, 5))
            fg(i, 7) = fec
            If fec = Nothing Then
                fg(i, 14) = fg(i, 14) + fg(i, 0)
                t(7) = t(7) + fg(i, 0)
            Else
                d = DateDiff(DateInterval.Weekday, fg(i, 6), fec)
                If d > 3 Then
                    d = 3
                Else
                    If d < -3 Then
                        d = -3
                    End If
                End If
                fg(i, 11 + d) = fg(i, 11 + d) + fg(i, 0)
                t(4 + d) = t(4 + d) + fg(i, 0)
            End If
        Next
    End Sub

    Private Function fecha_recepcion(ByVal fpo As String, ByVal knit As String, ByVal colo As String, ByVal batch As String) As Date
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim fecha
        fecha = Nothing
        Try
            dd = fr.Select("FPO = '" & fpo & "' AND KNIT = '" & knit & "' AND COLOR = '" & colo & "' AND BATCH = '" & batch & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                fecha = dr("FECHA")
            End If
        Catch
        End Try

        Return fecha
    End Function
    Private Sub subtotales()
        Dim i As Integer
        Dim tot As String
        For i = 8 To 14
            fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total")
        Next i

        l = fg.Rows.Count
        fg.Rows.Count = l + 1
        tot = t(1) + t(2) + t(3) + t(4) + t(5) + t(6) + t(7)
        For i = 1 To 7
            fg(l, i + 7) = (t(i) * 100) / tot
        Next
        fg.Rows(l).Style = fg.Styles("negro")
        fg.Rows(l).Height = 30
        fg(1, 4) = "Totales"
        fg(l, 4) = "Porcentajes"

    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        If fecha_final.Value < fecha_inicial.Value Then
            MsgBox("Error en las fechas !!!", MsgBoxStyle.Critical, "Por favor corregir.")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
        Impri.Visible = True
        Ex.Visible = True
        Cliente.Enabled = False
        tipo.Enabled = False
        fecha_inicial.Enabled = False
        fecha_final.Enabled = False
        '    agrega_negro()
        llena_grid()
        llena_recibido()
        calcula_cumplimiento()
        subtotales()
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        tipo.Enabled = True
        fecha_inicial.Enabled = True
        fecha_final.Enabled = True
        setea_grid()
    End Sub

    Private Sub limpia_flex()
        fg.Visible = True
    End Sub


    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_te()
    End Sub

    Private Sub Print_te()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String = ""
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, Trim(Cliente.Text) + "    Balance de tela Al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ex.Click
        a_excel(fg, path, ok)
    End Sub

    Private Sub tela_sin_despachar()
        Dim strsql As String = "SELECT CORTE,ESTILO,COLOR,CPO,TOTAL,(SELECT SUM(YARDAS) FROM DMOVTO WHERE DMOVTO.CORTE = CORTES_S.CORTE AND TMOVTO = '4') AS DESPACHO  FROM CORTES_S WHERE ESTADO = 'A'  AND CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO,COLOR,CPO"
        llena_tablas(tsd, strsql, cnn)
    End Sub

    Private Sub ordena_te()
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            fg(i, 9) = fg(i, 1)
            fg(i, 1) = fg(i, 8)
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

End Class
