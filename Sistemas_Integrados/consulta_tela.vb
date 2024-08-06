Imports C1.Win.C1FlexGrid
Public Class consulta_tela
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_tela))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = "10,1,0,0,0,95,Columns:1{Width:137;Caption:""CLIENTE"";Style:""DataType:System.String" & _
            ";TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(12, 12)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(966, 654)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 0
        '
        'consulta_tela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 676)
        Me.Controls.Add(Me.fg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consulta_tela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Tela Filtrado"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cnn As New SqlClient.SqlConnection()
    Dim y As Integer
    Dim l As Integer
    Dim caption As String = "Total for {0}"
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim strsql As String = "SELECT  CLIENTE, BATCH, KNIT, COLOR, FPO, ANCHO, count(ROLLO) AS ROLLOS, SUM(YARDAS) AS YARDAS, (SUM(PESO) / SUM(YARDAS_I)) * SUM(YARDAS) AS LIBRAS, CPO, ROLLOS.CODIGO, DESCRIPCION,YFIBER,YFINISH, COSTO ,(SELECT ESTADO_TELA FROM ESTADOS_TELA TELA WHERE CODIGO = ACTIVO) AS ACTIVO FROM ROLLOS LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE YARDAS >0 AND TIPO = 'TELA' GROUP BY CLIENTE, BATCH, KNIT, COLOR, FPO, ANCHO, CPO, ROLLOS.CODIGO, DESCRIPCION,YFIBER,YFINISH,COSTO,ACTIVO"
    Private Sub consulta_tela_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        Dim dt As New DataTable
        fg.Rows(0).Height = 30
        fg.Cols(0).Width = 0
        llena_tablas(dt, strsql, cnn)
        fg.DataSource = dt
        formatea_columnas()
        totalon()
    End Sub
    Private Sub formatea_columnas()
        Try
            fg.Cols("CLIENTE").Width = 150
            fg.Cols("KNIT").Width = 150
            fg.Cols("COLOR").Width = 200
            fg.Cols("DESCRIPCION").Width = 150
            fg.Cols("ROLLOS").Width = 60
            fg.Cols("LIBRAS").Format = "###,##0.00"
            fg.Cols("YARDAS").Format = "###,##0.00"
            fg.Sort(SortFlags.Ascending, 1, 2)
            y = fg.Cols("YARDAS").SafeIndex
            l = fg.Cols("LIBRAS").SafeIndex
        Catch
        End Try
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        totalon()
    End Sub

    Private Sub totalon()
        fg.Subtotal(AggregateEnum.Sum, -1, -1, y, caption)
        fg.Subtotal(AggregateEnum.Sum, -1, -1, l, caption)
    End Sub
End Class
