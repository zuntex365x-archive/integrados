Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Toma_inventar1
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents res As System.Windows.Forms.ComboBox
    Friend WithEvents pd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toma_inventar1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.res = New System.Windows.Forms.ComboBox()
        Me.pd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 647)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(616, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'res
        '
        Me.res.BackColor = System.Drawing.Color.White
        Me.res.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.res.ForeColor = System.Drawing.Color.Black
        Me.res.Items.AddRange(New Object() {"Fisico", "Faltantes"})
        Me.res.Location = New System.Drawing.Point(116, 9)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(144, 21)
        Me.res.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.res, "Resultado")
        '
        'pd
        '
        Me.pd.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pd.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pd.ForeColor = System.Drawing.Color.Black
        Me.pd.Image = CType(resources.GetObject("pd.Image"), System.Drawing.Image)
        Me.pd.Location = New System.Drawing.Point(667, 8)
        Me.pd.Name = "pd"
        Me.pd.Size = New System.Drawing.Size(35, 35)
        Me.pd.TabIndex = 85
        Me.pd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.pd, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.pd.UseVisualStyleBackColor = False
        Me.pd.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Resultado:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Toma_inventar1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 700)
        Me.Controls.Add(Me.pd)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toma_inventar1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultado de la Toma de Inventario"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim cnn1 As New SqlClient.SqlConnection
    Dim obj As empresas
    Dim StrSQL As String
    Dim lec As New DataTable
    Dim dt As New DataTable
    Dim filtro As New ConditionFilter


    Private Sub Toma_inventar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        setea_grid()
        Cursor = Cursors.WaitCursor
        Button2.Visible = True
        pd.Visible = True
        setea_busqueda()
        setea_grid()
        llena_grid()
        res.SelectedIndex = 0
        Cursor = Cursors.Default
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim l As Integer
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("BATCH")
            fg(l, 3) = dr("ROLLO")
            fg(l, 4) = dr("FPO")
            fg(l, 5) = dr("CPO")
            fg(l, 6) = dr("KNIT")
            fg(l, 7) = dr("COLOR")
            fg(l, 8) = dr("YARDAS")
            fg(l, 9) = dr("PESO")
            fg(l, 10) = dr("COSTO")
            fg(l, 11) = dr("VIEJO")
            fg(l, 12) = dr("BARRA")
            fg(l, 13) = busca_rollos(fg(l, 12))
            l = l + 1
        Next
        fg.Sort(SortFlags.Ascending, 2, 3)
        fg.Sort(SortFlags.Ascending, 1, 2)
        '   Catch
        '   End Try
        subtotales()
    End Sub
    Private Function busca_rollos(rollo) As Boolean
        Dim dd As DataRow()
        Dim ok As Boolean = False
        dd = lec.Select("ROLLO = '" & rollo & "'")
        If dd.Length > 0 Then
            ok = True
        End If
        Return ok
    End Function
    Private Sub subtotales()
        fg.ScrollBars = ScrollBars.Both
        Try
            With fg
                .Redraw = False
                Dim totalya As Integer = fg.Cols("YARDAS").Index
                Dim totalib As Integer = fg.Cols("LIBRAS").Index
                Dim totalic As Integer = fg.Cols("COSTO").Index
                fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
                fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
                fg.Subtotal(AggregateEnum.Sum, 0, 0, totalic, "Gran Total -->")

                'change backcolor of subtotals
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
                .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
                .Redraw = True
            End With
        Catch
        End Try
    End Sub

    Private Sub setea_busqueda()
        StrSQL = "SELECT *,ROLLOS.* FROM INVENTARIO_TELAS LEFT JOIN ROLLOS ON INVENTARIO_TELAS.BATCH = ROLLOS.BATCH AND INVENTARIO_TELAS.ROLLO = ROLLOS.ROLLO "
        llena_tablas(dt, StrSQL, cnn)
        cnn1.ConnectionString = lector_dc()
        llena_tablas_e(lec, "SELECT * FROM INVENTARIO_TELAS WHERE ESTADO = 'S'", cnn1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Cursor = Cursors.WaitCursor
        Print_fg()
        otra_busqueda()
        Cursor = Cursors.Default
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim tipos As String = " (FISICO)"
        fecha = Format(Today, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        If res.SelectedIndex = 1 Then
            tipos = " (FALTANTE) "
        End If
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Resultado del Inventario de fecha : " + fecha + tipos + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        otra_busqueda()
    End Sub

    Private Sub otra_busqueda()
        Button2.Visible = False
        pd.Visible = False
        res.Enabled = True
        setea_grid()
    End Sub

    Private Sub fg_aftersort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles fg.AfterSort
        subtotales()
    End Sub

    Private Sub to_pdf()
        Dim archivo As String = "c:\reportes\Inventario_Fisico_" + Format(CDate(Today), "yyyy-MM-dd") + ".pdf"
        a_pdf(fg, archivo, "Reporte Inventario " + res.Text & " al  " + Format(CDate(Today), "dd-MM-yyyy"), "Fecha : " + Format(Now, "dd/MM/yyyy"))
        Close()
    End Sub
    Private Sub lee_rollos()
        Dim afectados As Integer
        Dim cnn1 As New SqlClient.SqlConnection
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim barra As String
        cnn.ConnectionString = lector_dc()
        llena_tablas_e(dt, "SELECT * FROM INVENTARIO_TELAS", cnn1)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            For Each dr In dt.Rows
                barra = dr("ROLLO")
                StrSQL = "UPDATE TOMA_INV SET BIEN = 'S' WHERE FECHA =  AND BARRA = '" & barra & "'"
                comando.CommandText = StrSQL
                afectados = comando.ExecuteNonQuery()
            Next
            transaccion.Commit()
        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub pd_Click(sender As System.Object, e As System.EventArgs) Handles pd.Click
        to_pdf()
    End Sub

    Private Sub res_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles res.SelectedIndexChanged
        filtro.Condition1.Operator = ConditionOperator.Contains
        If res.SelectedIndex = 0 Then

            filtro.Condition1.Parameter = True
        Else
            filtro.Condition1.Parameter = False
        End If
        fg.Cols(13).Filter = filtro
        fg.ApplyFilters()
    End Sub

    Private Sub fg_AfterFilter(sender As Object, e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

End Class
