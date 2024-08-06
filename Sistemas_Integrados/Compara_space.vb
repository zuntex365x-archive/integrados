Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Compara_space
    Inherits System.Windows.Forms.Form
    Dim pf As New DataTable
    Dim sf As New DataTable
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Dim cnn As New SqlClient.SqlConnection
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
    Friend WithEvents fecha_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cancela As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compara_space))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.S1 = New System.Windows.Forms.Button()
        Me.fecha_f = New System.Windows.Forms.DateTimePicker()
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        Me.Cancela = New System.Windows.Forms.Button()
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
        'fecha_f
        '
        Me.fecha_f.CustomFormat = "dd/MM/yyyy"
        Me.fecha_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_f.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_f.Location = New System.Drawing.Point(132, 36)
        Me.fecha_f.Name = "fecha_f"
        Me.fecha_f.Size = New System.Drawing.Size(136, 26)
        Me.fecha_f.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Fecha de la Produccion")
        '
        'fecha_i
        '
        Me.fecha_i.CustomFormat = "dd/MM/yyyy"
        Me.fecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_i.Location = New System.Drawing.Point(132, 4)
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(136, 26)
        Me.fecha_i.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Fecha de la Produccion")
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
        'Compara_space
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fecha_f)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha_i)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.S1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compara_space"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compara Spaces"
        Me.ToolTip1.SetToolTip(Me, "Control de Cortes")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Compara_spaces(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_fg()
        Dim dr As DataRow
        Dim l As Integer = 1
        fg.Rows.Count = pf.Rows.Count + 1
        For Each dr In pf.Rows
            fg(l, 1) = dr("EMPRESA")
            fg(l, 2) = dr("FPO")
            fg(l, 3) = dr("BATCH")
            fg(l, 4) = dr("FABRIC")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = dr("LIBRAS")
            fg(l, 7) = dr("N_LIBRAS")
            fg(l, 8) = dr("SEMANA")
            fg(l, 9) = dr("N_SEMANA")
            fg(l, 10) = False
            fg(l, 11) = False
            If fg(l, 6) <> fg(l, 7) Then
                fg(l, 10) = True
            End If
            If fg(l, 8) <> fg(l, 9) Then
                fg(l, 11) = True
            End If
            l = l + 1
        Next
        subtotales()
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
            proceso()
            setea_fg()
            llena_fg()
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            S1.Enabled = False
            Button3.Visible = True
            Cursor = Cursors.Default
        End If
    End Sub
    Private Sub compara_fechas(ByRef ok As Boolean)
        ok = False
        If fecha_i.Text = fecha_f.Text Then
            MsgBox("No se pueden comparar fechas iguales !!!!", MsgBoxStyle.Critical, "Por favor revise !!!!")
            Exit Sub
        End If
        If fecha_i.Value > fecha_f.Value Then
            MsgBox("Fecha 2 No puede ser menor o igual que Fecha 1", MsgBoxStyle.Critical, "Por favor revise !!!!")
            Exit Sub
        End If
        revisa_datos(fecha_i.Value, pf)
        If pf.Rows.Count = 0 Then
            MsgBox("la fecha " & fecha_i.Text & " no tiene datos !!!", MsgBoxStyle.Critical, "Por favor revise !!!")
            Exit Sub
        End If
        revisa_datos(fecha_f.Value, sf)
        If sf.Rows.Count = 0 Then
            MsgBox("la fecha " & fecha_f.Text & " no tiene datos !!!", MsgBoxStyle.Critical, "Por favor revise !!!")
            Exit Sub
        End If
        ok = True
    End Sub
    Private Sub revisa_datos(ByVal fec As Date, ByRef dt As DataTable)
        Dim fe As String = Format(fec, "yyyy-MM-dd")
        Dim strsql As String = "Select SPACE.*, 0 AS N_SEMANA, 0 AS N_LIBRAS FROM SPACE WHERE FECHA = '" & fe & "'"
        llena_tablas(dt, strsql, cnn)
    End Sub
    Private Sub proceso()
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim fpo As String
        Dim batch As String
        Dim fabric As String
        For Each dr In sf.Rows
            fpo = dr("FPO")
            batch = dr("BATCH")
            fabric = dr("FABRIC")
            dd = pf.Select("FPO = '" & fpo & "' AND BATCH = '" & batch & "' AND FABRIC = '" & fabric & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                dj("N_SEMANA") = dr("SEMANA")
                dj("N_LIBRAS") = dr("LIBRAS")
            Else
                dj = pf.NewRow()
                dj("FECHA") = dr("FECHA")
                dj("EMPRESA") = dr("EMPRESA")
                dj("FPO") = fpo
                dj("BATCH") = batch
                dj("FABRIC") = fabric
                dj("COLOR") = dr("COLOR")
                dj("N_LIBRAS") = dr("LIBRAS")
                dj("N_SEMANA") = dr("SEMANA")
                pf.Rows.Add(dj)
            End If
        Next
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
        a_excel(fg, "c:\reportes\Compara_spaces_" + Format(fecha_i.Value, "yyyy-MM-dd") + "_" + Format(fecha_f.Value, "yyyy-MM-dd") + ".xls", ok)
        If ok Then
            Close()
        End If
    End Sub

End Class



