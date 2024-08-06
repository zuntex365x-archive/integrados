Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Cortes_pendientes
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection
    Dim filtro1 As New C1.Win.C1FlexGrid.ConditionFilter
    Dim filtro2 As New C1.Win.C1FlexGrid.ConditionFilter
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_pendientes))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 50)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(976, 598)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 33)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cortes_pendientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 652)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_pendientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cortes producidos Pendentes de Exportacion"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Inventario_Mat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_fg()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        filtro1.Condition1.Operator = ConditionOperator.BeginsWith
        filtro2.Condition1.Operator = ConditionOperator.BeginsWith
        fg.Cols(2).Filter = filtro1
        fg.Cols(3).Filter = filtro2
        fg.ApplyFilters()

    End Sub

    Private Sub llena_fg()
        Dim prendas As Integer
        Dim exp As Integer
        Dim dt As New DataTable
        Dim strsql As String = "SELECT CORTES.*,  F_PROMETIDA,(SELECT  SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) AS PROD, (SELECT SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) FROM PACKING_D WHERE PACKING_D.CORTE = CORTES.CORTE) AS EXPOR, PRODUCIDAS FROM CORTES LEFT JOIN PLAN_COSTURA_C ON CORTES.CORTE = PLAN_COSTURA_C.CORTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE EXPORTADO <> 'S'"
        Dim l As Integer = 1
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            If Not DBNull.Value.Equals(dr("PRODUCIDAS")) Then
                prendas = dr("PRODUCIDAS")
            Else
                prendas = 0
            End If

            If prendas = 0 Then
                If Not DBNull.Value.Equals(dr("PROD")) Then
                    prendas = dr("PROD")
                Else
                    prendas = 0
                End If
            End If
            If Not DBNull.Value.Equals(dr("EXPOR")) Then
                exp = dr("EXPOR")
            Else
                exp = 0
            End If
            If prendas > 0 And exp = 0 Then
                fg(l, 1) = dr("CLIENTE")
                fg(l, 2) = dr("CPO")
                fg(l, 3) = dr("ESTILO")
                fg(l, 4) = dr("COLOR")
                fg(l, 5) = dr("CORTE")
                fg(l, 6) = dr("SECCION")
                fg(l, 7) = prendas
                fg(l, 8) = dr("F_PROMETIDA")
                l = l + 1
            End If
        Next
        fg.Rows.Count = l
        fg.Sort(SortFlags.Ascending, 1)
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        setea_fg()
        llena_fg()
        Button1.Enabled = False
    End Sub

    Private Sub fg_AfterFilter(sender As Object, e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

    Private Sub subtotales()
        Try
            fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 7, "Gran TOTAL ---->")
        Catch
        End Try
    End Sub

End Class
