Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Consumo_Est_col_c
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim StrSQL As String

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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents hoja As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consumo_Est_col_c))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.hoja = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
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
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(128, 16)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(264, 24)
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
        'hoja
        '
        Me.hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoja.ForeColor = System.Drawing.Color.Black
        Me.hoja.Image = CType(resources.GetObject("hoja.Image"), System.Drawing.Image)
        Me.hoja.Location = New System.Drawing.Point(504, 8)
        Me.hoja.Name = "hoja"
        Me.hoja.Size = New System.Drawing.Size(35, 35)
        Me.hoja.TabIndex = 56
        Me.hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.hoja, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.hoja.UseVisualStyleBackColor = False
        '
        'Consumo_Est_col_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 668)
        Me.Controls.Add(Me.hoja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consumo_Est_col_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo por Estilo_Color"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
        llena_cliente()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer = 1
        StrSQL = "SELECT ESTILO_CPO,COLOR_CPO,CONSUMO_TELA.CODIGO,COLOR_TELA,LIBRAS,DESCRIPCION  FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(dt, StrSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(i, 1) = dr("ESTILO_CPO")
            fg(i, 2) = dr("COLOR_CPO")
            fg(i, 3) = dr("CODIGO")
            fg(i, 4) = dr("DESCRIPCION")
            fg(i, 5) = dr("COLOR_TELA")
            fg(i, 6) = dr("LIBRAS")
            fg(i, 0) = fg(i, 1) + fg(i, 2)
            i = i + 1
        Next
        subtotales()
    End Sub

    Private Sub subtotales()
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Subtotal(AggregateEnum.Clear)
        With fg
            fg.Subtotal(AggregateEnum.Sum, 1, 0, 6)
        End With
    End Sub


    Private Sub llena_cliente()
        Dim strSQL As String = "SELECT * FROM CLIENTES ORDER BY CLIENTE"
        llena_clientes(Cliente)
        Try
            Cliente.Items.Remove("TODOS")
        Catch
        End Try
        Try
            Cliente.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoja.Click
        Dim path As String = "C:\reportes\consumo_est_col.xls"
        Dim ok As Boolean
        fg.Subtotal(AggregateEnum.Clear)
        a_excel(fg, path, ok)
        If ok Then
            Close()
        Else
            subtotales()
        End If
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.SelectedIndexChanged
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        Else
            setea_grid()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

End Class
