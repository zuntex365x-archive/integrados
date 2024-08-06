Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Consumo_corte
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cpos As System.Windows.Forms.TextBox
    Friend WithEvents Prendas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Clientes As System.Windows.Forms.TextBox
    Friend WithEvents Estilos As System.Windows.Forms.TextBox
    Friend WithEvents Colores As System.Windows.Forms.TextBox
    Friend WithEvents FCORTES As System.Windows.Forms.TextBox
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Secciones As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consumo_corte))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Cpos = New System.Windows.Forms.TextBox()
        Me.Prendas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Secciones = New System.Windows.Forms.TextBox()
        Me.FCORTES = New System.Windows.Forms.TextBox()
        Me.Colores = New System.Windows.Forms.TextBox()
        Me.Estilos = New System.Windows.Forms.TextBox()
        Me.Clientes = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Corte:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(704, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cpos
        '
        Me.Cpos.BackColor = System.Drawing.Color.White
        Me.Cpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpos.ForeColor = System.Drawing.Color.Black
        Me.Cpos.Location = New System.Drawing.Point(152, 40)
        Me.Cpos.MaxLength = 10
        Me.Cpos.Name = "Cpos"
        Me.Cpos.ReadOnly = True
        Me.Cpos.Size = New System.Drawing.Size(120, 22)
        Me.Cpos.TabIndex = 47
        '
        'Prendas
        '
        Me.Prendas.BackColor = System.Drawing.Color.White
        Me.Prendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prendas.ForeColor = System.Drawing.Color.Black
        Me.Prendas.Location = New System.Drawing.Point(576, 40)
        Me.Prendas.MaxLength = 10
        Me.Prendas.Name = "Prendas"
        Me.Prendas.ReadOnly = True
        Me.Prendas.Size = New System.Drawing.Size(88, 22)
        Me.Prendas.TabIndex = 48
        Me.Prendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Secciones)
        Me.GroupBox1.Controls.Add(Me.FCORTES)
        Me.GroupBox1.Controls.Add(Me.Colores)
        Me.GroupBox1.Controls.Add(Me.Estilos)
        Me.GroupBox1.Controls.Add(Me.Clientes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cpos)
        Me.GroupBox1.Controls.Add(Me.Prendas)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 72)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'Secciones
        '
        Me.Secciones.BackColor = System.Drawing.Color.White
        Me.Secciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secciones.ForeColor = System.Drawing.Color.Black
        Me.Secciones.Location = New System.Drawing.Point(776, 40)
        Me.Secciones.MaxLength = 10
        Me.Secciones.Name = "Secciones"
        Me.Secciones.ReadOnly = True
        Me.Secciones.Size = New System.Drawing.Size(136, 22)
        Me.Secciones.TabIndex = 53
        '
        'FCORTES
        '
        Me.FCORTES.BackColor = System.Drawing.Color.White
        Me.FCORTES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FCORTES.ForeColor = System.Drawing.Color.Black
        Me.FCORTES.Location = New System.Drawing.Point(672, 40)
        Me.FCORTES.MaxLength = 10
        Me.FCORTES.Name = "FCORTES"
        Me.FCORTES.ReadOnly = True
        Me.FCORTES.Size = New System.Drawing.Size(96, 22)
        Me.FCORTES.TabIndex = 52
        Me.FCORTES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Colores
        '
        Me.Colores.BackColor = System.Drawing.Color.White
        Me.Colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores.ForeColor = System.Drawing.Color.Black
        Me.Colores.Location = New System.Drawing.Point(408, 40)
        Me.Colores.MaxLength = 10
        Me.Colores.Name = "Colores"
        Me.Colores.ReadOnly = True
        Me.Colores.Size = New System.Drawing.Size(160, 22)
        Me.Colores.TabIndex = 51
        '
        'Estilos
        '
        Me.Estilos.BackColor = System.Drawing.Color.White
        Me.Estilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilos.ForeColor = System.Drawing.Color.Black
        Me.Estilos.Location = New System.Drawing.Point(280, 40)
        Me.Estilos.MaxLength = 10
        Me.Estilos.Name = "Estilos"
        Me.Estilos.ReadOnly = True
        Me.Estilos.Size = New System.Drawing.Size(120, 22)
        Me.Estilos.TabIndex = 50
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.White
        Me.Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.ForeColor = System.Drawing.Color.Black
        Me.Clientes.Location = New System.Drawing.Point(16, 40)
        Me.Clientes.MaxLength = 10
        Me.Clientes.Name = "Clientes"
        Me.Clientes.ReadOnly = True
        Me.Clientes.Size = New System.Drawing.Size(128, 22)
        Me.Clientes.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(776, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 24)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Seccion:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(672, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "F.Corte"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(576, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "No. Prendas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(408, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Color"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(280, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Estilo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(152, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Cpo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.ForeColor = System.Drawing.Color.Black
        Me.corte.Location = New System.Drawing.Point(95, 8)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(144, 26)
        Me.corte.TabIndex = 51
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(11, 118)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(936, 530)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Consumo_corte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 660)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consumo_corte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch por Corte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Dim obj As empresas
    Private Sub Tela_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(corte, "SELECT CORTE FROM CORTES ORDER BY CORTE", "CORTE")
        setea_grid()
    End Sub
    Private Sub setea_grid()
        Try
            Dim i As Integer
            Dim index As Integer
            fg.DataSource = GetDataSource()
            fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
            fg.Cols.Count = 10
            fg.Cols(0).Width = 2
            fg.Cols(9).Width = 0
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Caption = "BATCH"
            fg.Cols(2).Caption = "KNIT"
            fg.Cols(3).Caption = "COLOR"
            fg.Cols(4).Caption = "ROLLO"
            fg.Cols(5).Caption = "FECHA"
            fg.Cols(6).Caption = "FPO"
            fg.Cols(7).Caption = "YARDAS"
            fg.Cols(8).Caption = "LIBRAS"
            fg.Cols(9).Caption = "TMOVTO"
            fg.Cols(4).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(4).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(5).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(5).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(6).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(6).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(7).DataType = GetType(Decimal)
            fg.Cols(7).Format = h
            fg.Cols(7).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(7).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(8).DataType = GetType(Decimal)
            fg.Cols(8).Format = h
            fg.Cols(8).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.RightCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 100
                fg(0, index) = fg.Cols(index).Caption
            Next
            fg.Cols(2).Width = 150
            fg.Cols(3).Width = 150
            For i = 1 To fg.Rows.Count - 1
                If fg(i, 9) < 4 Then
                    fg(i, 7) = fg(i, 7) * -1
                    fg(i, 8) = fg(i, 8) * -1
                    fg.SetCellStyle(i, 7, fg.Styles("customstyle1"))
                    fg.SetCellStyle(i, 8, fg.Styles("customstyle1"))
                End If
            Next
            fg.Cols(9).Visible = False
            subtotales()
            corte.Focus()
        Catch
        End Try
    End Sub


    Private Sub subtotales()
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        With fg
            .Redraw = False
            Dim totalya As Integer = fg.Cols("YARDAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 3, totalya, "Total Batch")
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 3, totalib, "Total Batch")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
            ''change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            '.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            '.Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
            .Redraw = True
            'fg.Tree.Show(1)
        End With
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Consumo de Tela del Corte: " + Trim(Corte.Text) + "   al : " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub limpia_variables()
        Cpos.Text = ""
        Prendas.Text = ""
        Clientes.Text = ""
        Estilos.Text = ""
        Colores.Text = ""
        FCORTES.Text = ""
        Secciones.Text = ""
    End Sub

    Private Function GetDataSource() As DataTable
        Dim strSQL = "SELECT DMOVTO.BATCH AS BATCH, ROLLOS.KNIT AS KNIT, ROLLOS.COLOR AS COLOR, DMOVTO.ROLLO AS ROLLO, FECHA, DMOVTO.FPO AS FPO, DMOVTO.YARDAS AS YARDAS,(ROLLOS.PESO / ROLLOS.YARDAS_I) * DMOVTO.YARDAS AS LIBRAS, DMOVTO.TMOVTO AS TMOVTO  FROM DMOVTO, ROLLOS WHERE CORTE = '" & corte.Text & "'  AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO ORDER BY DMOVTO.BATCH, ROLLOS.KNIT, ROLLOS.COLOR, FECHA, ROLLOS.ROLLO"
        llena_tablas(dt, strSQL, cnn)
        GetDataSource = dt
    End Function

    Private Sub llena_corte()
        Dim strSQL As String = "SELECT * FROM CORTES WHERE CORTE = '" & Corte.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            Clientes.Text = dr("CLIENTE")
            Cpos.Text = dr("CPO")
            Estilos.Text = dr("ESTILO")
            Colores.Text = dr("COLOR")
            FCORTES.Text = dr("FCORTE")
            Secciones.Text = dr("SECCION")
            Prendas.Text = dr("TOTAL")
        Next
    End Sub

    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub

    Private Sub corte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles corte.SelectedIndexChanged
        limpia_variables()
        setea_grid()
        llena_corte()
    End Sub
End Class
