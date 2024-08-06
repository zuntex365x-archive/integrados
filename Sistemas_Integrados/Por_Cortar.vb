Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Por_Cortar
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Dim path As String = "c:\por_cortar.xls"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Por_Cortar))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(984, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(128, 16)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(232, 24)
        Me.Cliente.TabIndex = 1
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
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(392, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 53
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar todos los Cortes del Cliente Seleccionado")
        Me.si.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(392, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(440, 8)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(35, 35)
        Me.Impri.TabIndex = 56
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Impri.UseVisualStyleBackColor = False
        Me.Impri.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(488, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 57
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Por_Cortar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 668)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.R1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Por_Cortar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prendas por Cortar por Cliente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CPO LEFT JOIN CPO_D ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.Rows.Count = 1
        fg.Cols.Count = 10
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "ESTILO"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "CPO"
        fg.Cols(4).Name = "F.ENTREGA"
        fg.Cols(5).Name = "PEDIDAS"
        fg.Cols(6).Name = "CORTADAS"
        fg.Cols(7).Name = "PROCESO"
        fg.Cols(8).Name = "DIFERENCIA"
        fg.Cols(9).Name = "PORCENTAJE"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 110
            fg(0, index) = fg.Cols(index).Name
            If index > 4 Then
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = "##,###,##0"
                fg.Cols(index).Width = 95
            End If
        Next
        fg.Cols(9).Format = "###0%"
        fg.Cols(1).Width = 150
        fg.Cols(2).Width = 300
        fg.Cols(3).Width = 200
        fg.Cols(4).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(4).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim p As Decimal
        Dim lineas As Integer = 1
        Dim strSQL As String = "SELECT ESTILO, COLOR ,CPO_D.CPO, CPO_D.F_ENTREGA ,TOTAL,(SELECT SUM(CORTES.TOTAL) FROM CORTES WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS CORTADO ,(SELECT SUM(CORTES_S.TOTAL) FROM CORTES_S,CORTES WHERE CORTES.CORTE = CORTES_S.CORTE AND CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR AND CORTES.TOTAL = 0) AS P_CORTE FROM CPO_D, CPO  WHERE ESTADO = 'A' AND CPO.CPO = CPO_D.CPO AND CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("CPO")
            fg(lineas, 4) = dr("F_ENTREGA")
            fg(lineas, 5) = dr("TOTAL")
            Try
                fg(lineas, 6) = dr("CORTADO")
            Catch
                fg(lineas, 6) = 0
            End Try
            Try
                fg(lineas, 7) = dr("P_CORTE")
            Catch
                fg(lineas, 7) = 0
            End Try
            fg(lineas, 8) = fg(lineas, 5) - (fg(lineas, 6) + fg(lineas, 7))
            p = ((fg(lineas, 6) + fg(lineas, 7)) * 100) / fg(lineas, 5)

            If p > 105 Then
                fg.SetCellStyle(lineas, 9, fg.Styles("rojo"))
            End If
            fg(lineas, 9) = p / 100
            lineas = lineas + 1
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        fg.Subtotal(AggregateEnum.Clear)
        Try
            With fg
                Dim totalya As Integer = fg.Cols("PEDIDAS").Index
                fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, totalya, "TOTALON")
                Dim totalib As Integer = fg.Cols("CORTADAS").Index
                fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, totalib, "TOTALON")
                totalib = fg.Cols("PROCESO").Index
                fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, totalib, "TOTALON")
                totalib = fg.Cols("DIFERENCIA").Index
                fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, totalib, "TOTALON")
            End With
        Catch
        End Try
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        si.Visible = False
        R1.Visible = True
        Impri.Visible = True
        Button3.Visible = True
        Cliente.Enabled = False
        setea_grid()
        llena_grid()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Button3.Visible = False
        Cliente.Enabled = True
        setea_grid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Reporte de Prendas por Cortar al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
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
            fg.Subtotal(AggregateEnum.Clear)
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

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub
End Class
