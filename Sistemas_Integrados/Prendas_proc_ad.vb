Imports C1.Win.C1FlexGrid

Public Class Prendas_proc_ad
    Inherits System.Windows.Forms.Form

    Dim cnn1 As SqlClient.SqlConnection
    Dim lineas As Integer
    Dim emb As DataTable
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cpo As System.Windows.Forms.Label
    Friend WithEvents Estilo As System.Windows.Forms.Label
    Friend WithEvents Colo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Proceso As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prendas_proc_ad))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cpo = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.Label()
        Me.Colo = New System.Windows.Forms.Label()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Proceso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 136)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(960, 248)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 54
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Estilo::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "CPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Color:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpo
        '
        Me.Cpo.BackColor = System.Drawing.Color.White
        Me.Cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cpo.Location = New System.Drawing.Point(128, 8)
        Me.Cpo.Name = "Cpo"
        Me.Cpo.Size = New System.Drawing.Size(160, 24)
        Me.Cpo.TabIndex = 71
        Me.Cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Estilo.Location = New System.Drawing.Point(128, 32)
        Me.Estilo.Name = "Estilo"
        Me.Estilo.Size = New System.Drawing.Size(296, 24)
        Me.Estilo.TabIndex = 72
        Me.Estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Colo
        '
        Me.Colo.BackColor = System.Drawing.Color.White
        Me.Colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Colo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Colo.Location = New System.Drawing.Point(128, 56)
        Me.Colo.Name = "Colo"
        Me.Colo.Size = New System.Drawing.Size(296, 24)
        Me.Colo.TabIndex = 73
        Me.Colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'jg
        '
        Me.jg.AllowEditing = False
        Me.jg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.BackColor = System.Drawing.Color.White
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jg.ForeColor = System.Drawing.Color.Black
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.jg.Location = New System.Drawing.Point(8, 408)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 17
        Me.jg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(960, 256)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 74
        Me.jg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Proceso:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Proceso
        '
        Me.Proceso.BackColor = System.Drawing.Color.White
        Me.Proceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Proceso.Location = New System.Drawing.Point(128, 80)
        Me.Proceso.Name = "Proceso"
        Me.Proceso.Size = New System.Drawing.Size(296, 24)
        Me.Proceso.TabIndex = 76
        Me.Proceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Terminado:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "En Proceso:"
        '
        'Prendas_proc_ad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 668)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Proceso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.Colo)
        Me.Controls.Add(Me.Estilo)
        Me.Controls.Add(Me.Cpo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Prendas_proc_ad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Prendas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Bal_Tela_Det1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        def_sql(cnn1)
        setea_fg()
        setea_jg()
        llena_pedido()
        completas()
        llena_totales()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 16
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "FECHA"
        fg.Cols(2).Name = "CORTE"
        fg.Cols(3).Name = "XS"
        fg.Cols(4).Name = "S"
        fg.Cols(5).Name = "M"
        fg.Cols(6).Name = "L"
        fg.Cols(7).Name = "XL"
        fg.Cols(8).Name = "2XL"
        fg.Cols(9).Name = "3XL"
        fg.Cols(10).Name = "4XL"
        fg.Cols(11).Name = "5XL"
        fg.Cols(12).Name = "6XL"
        fg.Cols(13).Name = "TOTAL"
        fg.Cols(14).Name = "EMPRESA"
        fg.Cols(15).Name = "RECIBIDAS"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 120
            fg(0, index) = fg.Cols(index).Name
            If index > 2 And index < 14 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 50
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(1).Width = 70
        fg.Cols(15).Width = 70
        fg.Cols(1).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub setea_jg()
        Dim index As Integer
        jg.Clear()
        jg.Rows.Count = 1
        jg.Cols.Count = 15
        jg.Cols(0).Width = 5
        jg.Rows(0).Height = 30
        Dim c As Column = jg.Cols(1)
        jg.Cols(1).Name = "ENVIADO"
        jg.Cols(2).Name = "CORTE"
        jg.Cols(3).Name = "XS"
        jg.Cols(4).Name = "S"
        jg.Cols(5).Name = "M"
        jg.Cols(6).Name = "L"
        jg.Cols(7).Name = "XL"
        jg.Cols(8).Name = "2XL"
        jg.Cols(9).Name = "3XL"
        jg.Cols(10).Name = "4XL"
        jg.Cols(11).Name = "5XL"
        jg.Cols(12).Name = "6XL"
        jg.Cols(13).Name = "TOTAL"
        jg.Cols(14).Name = "EMPRESA"
        For index = 1 To jg.Cols.Count - 1
            jg.Cols(index).Width = 120
            jg(0, index) = jg.Cols(index).Name
            If index > 2 And index < 14 Then
                jg.Cols(index).DataType = GetType(Integer)
                jg.Cols(index).Format = "######0"
                jg.Cols(index).Width = 50
                jg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                jg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        jg.Cols(1).Width = 70
        jg.Cols(1).TextAlign = TextAlignEnum.CenterCenter
        jg.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub



    Private Sub llena_pedido()
        Dim strSQL As String = "SELECT CPO_D.* , (SELECT F_PEDIDO FROM CPO WHERE CPO.CPO = CPO_D.CPO) AS FPEDIDO FROM CPO_D WHERE CPO = '" & Cpo.Text & "' AND ESTILO = '" & Estilo.Text & "' AND COLOR = '" & Colo.Text & "' AND ESTADO = 'A'"
        Dim da As System.Data.SqlClient.SqlDataAdapter
        da = New System.Data.SqlClient.SqlDataAdapter(strSQL, cnn1)
        Dim ds As DataSet
        Dim dr As DataRow
        ds = New DataSet()
        da.Fill(ds, "PRENDAS")
        For Each dr In ds.Tables("PRENDAS").Rows
            lineas = fg.Rows.Count
            fg.Rows.Count = lineas + 1
            fg.Rows(1).Style = fg.Styles("pedido")
            fg(lineas, 1) = dr("FPEDIDO")
            fg(lineas, 2) = "Unidades Pedidas"
            fg(lineas, 3) = dr("XS")
            fg(lineas, 4) = dr("S")
            fg(lineas, 5) = dr("M")
            fg(lineas, 6) = dr("L")
            fg(lineas, 7) = dr("XL")
            fg(lineas, 8) = dr("XL2")
            fg(lineas, 9) = dr("XL3")
            fg(lineas, 10) = dr("XL4")
            fg(lineas, 11) = dr("XL5")
            fg(lineas, 12) = dr("XL6")
            fg(lineas, 13) = dr("TOTAL")
        Next
    End Sub

    Private Sub completas()
        Dim strSQL As String = "SELECT CORTES.CPO,ESTILO,COLOR,CORTES_PA.* FROM CORTES_PA,CORTES WHERE CORTES_PA.CORTE = CORTES.CORTE AND CORTES.CPO = '" & Cpo.Text & "' AND ESTILO = '" & Estilo.Text & "' AND COLOR = '" & Colo.Text & "' AND PROCESO = '" & Proceso.Text & "'"
        Dim da As System.Data.SqlClient.SqlDataAdapter
        da = New System.Data.SqlClient.SqlDataAdapter(strSQL, cnn1)
        Dim ds As DataSet
        Dim dr As DataRow
        ds = New DataSet()
        da.Fill(ds, "PRENDAS")
        For Each dr In ds.Tables("PRENDAS").Rows
            If dr("TOTAL_REC") > 0 Then
                lineas = fg.Rows.Count
                fg.Rows.Count = lineas + 1
                fg.Rows(lineas).Style = fg.Styles("export")
                fg(lineas, 1) = dr("FECHA_ENVIO")
                fg(lineas, 2) = "Corte: " & Trim(dr("CORTE"))
                fg(lineas, 3) = dr("RP0")
                fg(lineas, 4) = dr("RP1")
                fg(lineas, 5) = dr("RP2")
                fg(lineas, 6) = dr("RP3")
                fg(lineas, 7) = dr("RP4")
                fg(lineas, 8) = dr("RP5")
                fg(lineas, 9) = dr("RP6")
                fg(lineas, 10) = dr("RP7")
                fg(lineas, 11) = dr("RP8")
                fg(lineas, 12) = dr("RP9")
                fg(lineas, 13) = fg(lineas, 3) + fg(lineas, 4) + fg(lineas, 5) + fg(lineas, 6) + fg(lineas, 7) + fg(lineas, 8) + fg(lineas, 9) + fg(lineas, 10) + fg(lineas, 11) + fg(lineas, 12)
                fg(lineas, 14) = dr("LUGAR")
                fg(lineas, 15) = dr("FECHA_REC")
            Else
                pendientes(dr)
            End If
        Next
    End Sub

    Private Sub pendientes(ByVal dr As DataRow)
        Dim lineas As Integer
        lineas = jg.Rows.Count
        jg.Rows.Count = lineas + 1
        jg.Rows(lineas).Style = jg.Styles("export")
        jg(lineas, 1) = dr("FECHA_ENVIO")
        jg(lineas, 2) = "Corte: " & Trim(dr("CORTE"))
        jg(lineas, 3) = dr("EP0")
        jg(lineas, 4) = dr("EP1")
        jg(lineas, 5) = dr("EP2")
        jg(lineas, 6) = dr("EP3")
        jg(lineas, 7) = dr("EP4")
        jg(lineas, 8) = dr("EP5")
        jg(lineas, 9) = dr("EP6")
        jg(lineas, 10) = dr("EP7")
        jg(lineas, 11) = dr("EP8")
        jg(lineas, 12) = dr("EP9")
        jg(lineas, 13) = jg(lineas, 3) + jg(lineas, 4) + jg(lineas, 5) + jg(lineas, 6) + jg(lineas, 7) + jg(lineas, 8) + jg(lineas, 9) + jg(lineas, 10) + jg(lineas, 11) + jg(lineas, 12)
        jg(lineas, 14) = dr("LUGAR")
    End Sub


    Private Sub llena_totales()
        Dim i As Integer
        Dim j As Integer
        Dim f As Integer
        lineas = fg.Rows.Count
        fg.Rows.Count = lineas + 1
        fg.Rows(lineas).Style = fg.Styles("total")
        fg(lineas, 2) = "TOTALES .... "
        For i = 1 To lineas - 1
            If i = 1 Then
                f = 1
            Else
                f = -1
            End If
            For j = 3 To 13
                fg(lineas, j) = fg(lineas, j) + (fg(i, j) * f)
            Next
        Next
    End Sub


End Class
