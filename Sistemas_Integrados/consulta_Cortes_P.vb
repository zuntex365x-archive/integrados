Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class consulta_cortes_P
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim cliente As String
    Dim path As String = "c:\reportes\cortes_pendientes.xls"
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Sala As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_cortes_P))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Sala = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(984, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 23
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Sala
        '
        Me.Sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sala.Location = New System.Drawing.Point(152, 16)
        Me.Sala.MaxLength = 20
        Me.Sala.Name = "Sala"
        Me.Sala.Size = New System.Drawing.Size(232, 24)
        Me.Sala.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Sala, "Salas de Corte")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 32)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Sala de Corte:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(448, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 2
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar todos los Cortes del Cliente Seleccionado")
        Me.si.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(491, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 54
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(533, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 55
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(448, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 57
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para regresar a Seleccionar Documentos.")
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'consulta_cortes_P
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 668)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Sala)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consulta_cortes_P"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cortes Pendientes"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
        llena_salas(Sala, cnn, "S")
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Clear(ClearFlags.Style)
            fg.Rows.Count = 1
            fg.Cols.Count = 20
            fg.Cols(0).Width = 5
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Name = "CORTE"
            fg.Cols(2).Name = "CPO"
            fg.Cols(3).Name = "FPO"
            fg.Cols(4).Name = "ESTILO"
            fg.Cols(5).Name = "COLOR"
            fg.Cols(6).Name = "XS"
            fg.Cols(7).Name = "S"
            fg.Cols(8).Name = "M"
            fg.Cols(9).Name = "L"
            fg.Cols(10).Name = "XL"
            fg.Cols(11).Name = "2XL"
            fg.Cols(12).Name = "3XL"
            fg.Cols(13).Name = "4XL"
            fg.Cols(14).Name = "5XL"
            fg.Cols(15).Name = "6XL"
            fg.Cols(16).Name = "TOTAL"
            fg.Cols(17).Name = "ESCALA"
            fg.Cols(18).Name = "F.CORTE"
            fg.Cols(19).Name = "SALA DE CORTE"
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 70
                fg(0, index) = fg.Cols(index).Name
                If index > 5 And index < 17 Then
                    fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                    fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                    fg.Cols(index).DataType = GetType(Integer)
                    fg.Cols(index).Format = "######"
                    fg.Cols(index).Width = 45
                End If
            Next
            fg.Cols(5).Width = 100
            fg.Cols(16).Width = 55
            fg.Cols(18).Width = 150
            Dim s As C1.Win.C1FlexGrid.CellStyle
            s = fg.Styles.Add("rojo")
            s.ForeColor = Color.Blue
            s.Font = New Font(fg.Styles.Normal.Font, FontStyle.Bold)

            fg.Cols(2).Width = 150
            fg.Cols(3).Width = 120
            fg.Cols(4).Width = 150
            fg.Cols(5).Width = 150
        Catch
        End Try
    End Sub

    Private Sub llena_grid(ByVal Salas As String)
        Dim dt As New DataTable
        ok = False
        Dim strSQL As String
        If Salas = "TODAS" Then
            strSQL = "SELECT CORTES_S.*,NOMBRE FROM CORTES_S LEFT JOIN CPO_D ON CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTES_S.ESTADO = 'A'"
        Else
            strSQL = "SELECT CORTES_S.*,NOMBRE FROM CORTES_S LEFT JOIN CPO_D ON CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE WHERE SELECT CORTES_S.*,NOMBRE FROM CORTES_S LEFT JOIN CPO_D ON CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTES_S.ESTADO = 'A' AND SALA = '" & Salas & "'"
        End If
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CORTE")
            fg(lineas, 2) = dr("CPO")
            fg(lineas, 3) = dr("FPO")
            fg(lineas, 4) = dr("ESTILO")
            fg(lineas, 5) = dr("COLOR")
            fg(lineas, 6) = dr("XS")
            fg(lineas, 7) = dr("S")
            fg(lineas, 8) = dr("M")
            fg(lineas, 9) = dr("L")
            fg(lineas, 10) = dr("XL")
            fg(lineas, 11) = dr("XL2")
            fg(lineas, 12) = dr("XL3")
            fg(lineas, 13) = dr("XL4")
            fg(lineas, 14) = dr("XL5")
            fg(lineas, 15) = dr("XL6")
            fg(lineas, 16) = dr("TOTAL")
            fg(lineas, 17) = dr("NOMBRE")
            fg(lineas, 18) = CDate(dr("F_ICORTE"))
            fg(lineas, 19) = dr("SALA")
            lineas = lineas + 1
        Next
        fg.Sort(SortFlags.Descending, 1)
        fg.Sort(SortFlags.Descending, 17)
    End Sub


    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        setea_grid()
        llena_grid(Sala.Text)
        Sala.Enabled = False
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        si.Visible = False
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
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
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog, "Listado de Cortes Pedientes: " + Trim(cliente) + "  al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, path, ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        si.Visible = True
        Sala.Enabled = True
        setea_grid()
    End Sub
    Private Sub sala_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Sala.KeyPress
        AutoCompletar(Sala, e)
    End Sub

End Class
