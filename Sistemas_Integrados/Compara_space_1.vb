Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Compara_space_1
    Inherits System.Windows.Forms.Form
    Dim sp As New DataTable
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fecha_i As System.Windows.Forms.ComboBox
    Friend WithEvents fecha_f As System.Windows.Forms.ComboBox
    Dim cnn As New SqlClient.SqlConnection
    Dim fc As New DataTable
    Dim cs As New Lib_SI.util
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
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cancela As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compara_space_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.S1 = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.fecha_i = New System.Windows.Forms.ComboBox()
        Me.fecha_f = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(318, 12)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(60, 40)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(384, 12)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 66
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'fecha_i
        '
        Me.fecha_i.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.IntegralHeight = False
        Me.fecha_i.Location = New System.Drawing.Point(90, 9)
        Me.fecha_i.MaxLength = 10
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(165, 24)
        Me.fecha_i.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Cliente.")
        '
        'fecha_f
        '
        Me.fecha_f.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_f.IntegralHeight = False
        Me.fecha_f.Location = New System.Drawing.Point(90, 41)
        Me.fecha_f.MaxLength = 10
        Me.fecha_f.Name = "fecha_f"
        Me.fecha_f.Size = New System.Drawing.Size(165, 24)
        Me.fecha_f.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Cliente.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Hasta:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Desde:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(12, 71)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(986, 606)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 67
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(451, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 68
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Compara_space_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.fecha_f)
        Me.Controls.Add(Me.fecha_i)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.S1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compara_space_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compara Spaces"
        Me.ToolTip1.SetToolTip(Me, "Control de Cortes")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Compara_spaces(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constr As String = ""
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        cnn.ConnectionString = cs.con_string("0")
        llena_combos_e(fecha_i, "0", "SELECT DISTINCT CONVERT(VARCHAR(10), FECHA, 23) AS FECHA FROM SPACE ORDER BY FECHA", "FECHA")
        llena_combos_e(fecha_f, "0", "SELECT DISTINCT CONVERT(VARCHAR(10), FECHA, 23) AS FECHA FROM SPACE ORDER BY FECHA", "FECHA")
        llena_tablas_e(fc, "SELECT DISTINCT CONVERT(VARCHAR(10), FECHA, 23) AS FECHA FROM SPACE ORDER BY FECHA", cnn)
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Cols.Count = 7
    End Sub
    Private Sub crea_columnas()
        Dim dr As DataRow
        Dim fec As String
        For Each dr In fc.Rows
            fec = dr("FECHA")
            If fec >= fecha_i.Text And fec <= fecha_f.Text Then
                agrega_columna(fec)
            End If
        Next
    End Sub
    Private Sub agrega_columna(ByVal dato As String)
        Dim c As Integer = fg.Cols.Count
        fg.Cols.Count = c + 1
        fg.Cols(c).Name = dato
        fg.Cols(c).Caption = dato
    End Sub
    Private Sub llena_fg()
        Dim strsql As String = "SELECT * FROM SPACE WHERE FECHA BETWEEN '" & fecha_i.Text & "' AND '" & fecha_f.Text & "' ORDER BY EMPRESA,FPO,BATCH,FABRIC"
        Dim dr As DataRow
        Dim f As Integer
        Dim c As Integer
        Dim busca As String
        Dim fecha
        llena_tablas(sp, strsql, cnn)
        For Each dr In sp.Rows
            busca = dr("EMPRESA") + dr("FPO") + dr("BATCH") + dr("FABRIC")
            f = fg.FindRow(busca, 0, 0, False)
            If f < 1 Then
                f = fg.Rows.Count
                fg.Rows.Count = f + 1
                fg(f, 1) = dr("EMPRESA")
                fg(f, 2) = dr("FPO")
                fg(f, 3) = dr("BATCH")
                fg(f, 4) = dr("FABRIC")
                fg(f, 5) = dr("COLOR")
                fg(f, 0) = busca
            End If
            fecha = Format(dr("FECHA"), "yyyy-MM-dd")
            busca_col(c, fecha)
            fg(f, c) = dr("ENTREGA")
        Next
    End Sub
    Private Sub filtro() Handles fg.AfterFilter
        subtotales()
    End Sub
    Private Sub subtotales()
        Dim c As Integer = fg.Cols.IndexOf("PRE")
        Try
            fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 6, "Gran TOTAL ---->")
            fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 7, "Gran TOTAL ---->")
        Catch
        End Try
    End Sub
    Private Sub S1_Click(sender As System.Object, e As System.EventArgs) Handles S1.Click
        Dim ok As Boolean = False
        compara_fechas(ok)
        If ok Then
            Cursor = Cursors.WaitCursor
            fg.ScrollBars = ScrollBars.None
            setea_fg()
            crea_columnas()
            llena_fg()
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            S1.Enabled = False
            Button3.Visible = True
            Cursor = Cursors.Default
            fg.ScrollBars = ScrollBars.Both
        End If
    End Sub
    Private Sub compara_fechas(ByRef ok As Boolean)
        ok = False
        If fecha_i.Text = fecha_f.Text Then
            MsgBox("No se pueden comparar fechas iguales !!!!", MsgBoxStyle.Critical, "Por favor revise !!!!")
            Exit Sub
        End If
        If fecha_i.Text > fecha_f.Text Then
            MsgBox("Fecha 2 No puede ser menor o igual que Fecha 1", MsgBoxStyle.Critical, "Por favor revise !!!!")
            Exit Sub
        End If
        ok = True
    End Sub
    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        setea_fg()
        fecha_i.Enabled = True
        fecha_f.Enabled = True
        Button3.Visible = False
        S1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\Compara_spaces_" + fecha_i.Text + "_" + fecha_f.Text + ".xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub busca_col(ByRef col As Integer, ByVal fec As String)
        Dim i As Integer
        col = -1
        For i = 3 To fg.Cols.Count - 1
            If fec = fg(0, i) Then
                col = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub fecha_i_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fecha_i.KeyPress
        AutoCompletar(fecha_i, e)
    End Sub

    Private Sub fecha_f_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fecha_f.KeyPress
        AutoCompletar(fecha_f, e)
    End Sub
End Class



