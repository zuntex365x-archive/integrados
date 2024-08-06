Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cpo_performance_P
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dx As New DataTable()
    Dim dr As DataRow
    Dim dd As DataRow()
    Dim lineas As Integer
    Friend WithEvents Fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Dim path As String = "c:\reportes\Cpo_performance_p.xls"
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cpo_performance_P))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.R1.Location = New System.Drawing.Point(492, 8)
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
        Me.S1.Location = New System.Drawing.Point(452, 8)
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
        Me.C4.Location = New System.Drawing.Point(129, 8)
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
        Me.Button3.Location = New System.Drawing.Point(572, 8)
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
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 87)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 20
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 584)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(532, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 64
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Fecha_final
        '
        Me.Fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_final.Location = New System.Drawing.Point(131, 60)
        Me.Fecha_final.Name = "Fecha_final"
        Me.Fecha_final.Size = New System.Drawing.Size(112, 22)
        Me.Fecha_final.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.Fecha_final, "Fecha donde finaliza la búsqueda de Documentos.")
        '
        'Fecha_inicial
        '
        Me.Fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_inicial.Location = New System.Drawing.Point(131, 36)
        Me.Fecha_inicial.Name = "Fecha_inicial"
        Me.Fecha_inicial.Size = New System.Drawing.Size(112, 22)
        Me.Fecha_inicial.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.Fecha_inicial, "Fecha desde donde comienza la búsqueda de Documentos.")
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Fecha Incial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpo_performance_P
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Fecha_final)
        Me.Controls.Add(Me.Fecha_inicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "Cpo_performance_P"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Performance Pedido vrs Exportado"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
        C4.SelectedIndex = 0
        C4.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        If CDate(Fecha_final.Value) < CDate(Fecha_inicial.Value) Then
            MsgBox("La fecha final es menor que la inicial. Revise !!!!", MsgBoxStyle.OkOnly, "ERROR EN LAS FECHAS")
            Exit Sub
        Else
            S1.Visible = False
            R1.Visible = True
            deshabilita()
            Cursor = Cursors.WaitCursor
            llena_fg()
            fg.ScrollBars = ScrollBars.Both
            Cursor = Cursors.Default
            R1.Focus()
        End If

    End Sub

    Private Sub deshabilita()
        C4.Enabled = False
        Fecha_inicial.Enabled = False
        Fecha_final.Enabled = False
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        C4.Enabled = True
        S1.Visible = True
        R1.Visible = False
        Fecha_inicial.Enabled = True
        Fecha_final.Enabled = True
        Button2.Visible = False
        Button3.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim l As Integer
        Dim i As Integer
        Dim t As Integer
        Dim cpos As String
        Dim estilo As String
        Dim colo As String
        Dim dj As DataRow
        Dim strsql As String = "SELECT * FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CPO.CLIENTE = '" & C4.Text & "' AND  CPO.F_ENTREGA BETWEEN '" & Format(Fecha_inicial.Value, "yyyy-MM-dd") & "' AND '" & Format(Fecha_final.Value, "yyyy-MM-dd") & "' ORDER BY CPO_D.CPO"
        llena_tablas(dt, strsql, cnn)
        strsql = "SELECT PACKING_D.CPO,ESTILO,COLOR,SUM(XS) AS XS,SUM(S) AS S,SUM(M) AS M, SUM(L) AS L,SUM(XL) AS XL, SUM(XL2) AS XL2, SUM(XL3) AS XL3,SUM(XL4) AS XL4,SUM(XL5) AS XL5,SUM(XL6) AS XL6 FROM PACKING_D WHERE TIPO = 'Pri' AND CLIENTE = '" & C4.Text & "' AND PACKING_D.CPO + ESTILO + COLOR IN (SELECT CPO_D.CPO+ESTILO+COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO= CPO.CPO WHERE CPO.F_ENTREGA BETWEEN '" & Format(Fecha_inicial.Value, "yyyy-MM-dd") & "' AND '" & Format(Fecha_final.Value, "yyyy-MM-dd") & "' AND CLIENTE = '" & C4.Text & "') GROUP BY PACKING_D.CPO,ESTILO,COLOR"
        llena_tablas(dx, strsql, cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            cpos = dr("CPO")
            colo = dr("COLOR")
            estilo = dr("ESTILO")
            fg(l, 1) = cpos
            fg(l, 2) = estilo
            fg(l, 3) = colo
            fg(l, 4) = dr("CLIENTE")
            fg(l, 5) = dr("F_PEDIDO")
            For i = 3 To 13
                fg(l, i + 3) = dr(i)
                fg.SetCellStyle(l, i + 3, "azul")
            Next
            dd = dx.Select("CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                t = 0
                For i = 3 To 12
                    fg(l, i + 14) = dj(i)
                    fg.SetCellStyle(l, i + 14, "verde")
                    t = t + dj(i)
                Next i
                fg(l, 27) = t
                fg.SetCellStyle(l, 27, "verde")
            End If
            l = l + 1
        Next
        subtotales()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Try
            Dim ch As Char = Microsoft.VisualBasic.Chr(9)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            ok = False
        End Try
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog + PrintGridFlags.ShowPreviewDialog, empresa + "   Reporte de Cpos al : " + fecha + "    " + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub

    Private Sub subtotales()
        Dim i As Integer

        With fg
            For i = 6 To fg.Cols.Count - 1
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
            Next i
        End With
    End Sub

End Class



