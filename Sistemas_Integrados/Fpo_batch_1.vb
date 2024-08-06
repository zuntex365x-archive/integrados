Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Fpo_batch_1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim cnn1 As New SqlClient.SqlConnection
    Dim dt As New DataTable()
    Dim sp As New DataTable
    Dim dr As DataRow
    Dim strSQl As String
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    Dim dato As String
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
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpo_batch_1))
        Me.G1 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(74, 4)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(60, 40)
        Me.G1.TabIndex = 78
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 46)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(705, 634)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(8, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 81
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(140, 4)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 82
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.regresa.UseVisualStyleBackColor = False
        Me.regresa.Visible = False
        '
        'fj
        '
        Me.fj.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fj.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fj.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fj.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fj.AutoGenerateColumns = False
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fj.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fj.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fj.Location = New System.Drawing.Point(719, 46)
        Me.fj.Name = "fj"
        Me.fj.Rows.Count = 1
        Me.fj.Rows.DefaultSize = 22
        Me.fj.Size = New System.Drawing.Size(697, 531)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fj.TabIndex = 83
        '
        'Fpo_batch_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1425, 696)
        Me.Controls.Add(Me.fj)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.regresa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fpo_batch_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresa No. Batch"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Serigra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Clientes.KeyPress, AddressOf keypressed1
        fg.Height = Me.Height - 150
        fg.DragMode = DragModeEnum.AutomaticCopy
        fg.DropMode = DropModeEnum.Automatic
        llena_space()
        limpia_datos()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub limpia_datos()
        setea_fg()
        Button1.Visible = True
        regresa.Visible = False
        G1.Visible = False
        clientes.Enabled = True
    End Sub

    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim fpo As String = ""
        Dim estilo As String = "normal"
        Dim dr As DataRow
        Dim strSQL As String = "SELECT FPO,TIPO,KNIT,COLOR,LOTE,CLIENTE,CPO,TEXTILERA,LIBRAS,RECIBIDAS FROM FPO WHERE TIPO = 'TELA' AND STATUS = 'ABIERTO' AND RECIBIDAS = 0 AND LOTE < 100 ORDER BY FPO,COLOR,LOTE"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            If fpo <> dr("FPO") Then
                If estilo = "azul" Then
                    estilo = "normal"
                Else
                    estilo = "azul"
                End If
                fpo = dr("FPO")
            End If
            fg(l, 1) = dr("FPO")
            fg(l, 2) = dr("KNIT")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("LIBRAS")
            fg(l, 5) = dr("LOTE")
            fg(l, 6) = dr("LOTE")
            fg.Rows(l).Style = fg.Styles(estilo)
            l = l + 1
        Next
    End Sub
    Private Sub llena_space()
        Dim cs As New Lib_SI.util
        Dim cnst As String = ""
        Dim fec As Date
        Dim strsql As String
        Dim dr As DataRow
        cnn1.ConnectionString = cs.con_string("0")
        llena_tablas_e(sp, "SELECT TOP 1 FECHA FROM SPACE ORDER BY FECHA DESC", cnn1)
        If sp.Rows.Count > 0 Then
            dr = sp.Rows(0)
            fec = dr("FECHA")
        End If
        strsql = "SELECT * FROM SPACE WHERE FECHA = '" & Format(fec, "yyyy-MM-dd") & "' AND SUBSTRING(FABRIC,1,6) <> 'Cuello' ORDER BY FPO,FABRIC,COLOR"
        llena_tablas_e(sp, strsql, cnn1)
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim i As Integer
        Dim dt As New DataTable()
        ok = True
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 5) <> fg(i, 6) And fg(i, 5) > "100" Then
                llena_tablas(dt, "SELECT DISTINCT BATCH FROM ROLLOS WHERE BATCH = '" & fg(i, 5) & "' AND CLIENTE = '" & Clientes.Text & "'", cnn)
            End If
        Next
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            Close()
        End If
    End Sub

    Private Sub graba_datos()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim batch As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                If fg(i, 5) <> fg(i, 6) Then
                    batch = fg(i, 5)
                    If batch.Length > 15 Then
                        fg(i, 5) = Mid(batch, 1, 15)
                    End If
                    strsql = "UPDATE FPO SET LOTE = '" & fg(i, 5) & "' WHERE FPO = '" & fg(i, 1) & "' AND KNIT = '" & fg(i, 2) & "' AND COLOR = '" & fg(i, 3) & "' AND LOTE = '" & fg(i, 6) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next
            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Information, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        If fg.Col <> 8 Then
            Exit Sub
        End If
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.Insert, Keys.C
                    'copy
                    'System.Windows.Forms.Clipboard.SetDataObject(fg.Clip, True)
                    dato = fg(fg.RowSel, 8)
                    Exit Select
                Case Keys.V 'paste
                    Dim rg As CellRange = fg.Selection
                    If dato <> "" Then
                        rg.Data = dato
                    End If
            End Select
        End If
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(clientes.Text) <> "" Then
                Button1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llena_fg()
        Button1.Visible = False
        regresa.Visible = True
        clientes.Enabled = False
        G1.Visible = True
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        limpia_datos()
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.AfterRowColChange
        setea_fj()
        llena_fj()
    End Sub

    Private Sub setea_fj()
        fj.Rows.Count = 1
        fj.Rows(0).Height = 30
    End Sub
    Private Sub llena_fj()
        Dim f As Integer = fg.RowSel
        Dim l As Integer = 1
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim batch As String = ""
        dd = sp.Select("FPO = '" & fg(f, 1) & "'")
        If dd.Length > 0 Then
            fj.Rows.Count = dd.Length + 1
            For Each dr In dd
                fj(l, 1) = dr("FPO")
                fj(l, 2) = dr("FABRIC")
                fj(l, 3) = dr("COLOR")
                fj(l, 4) = dr("LIBRAS")
                fj(l, 5) = dr("BATCH")
                batch = batch + dr("BATCH") + "|"
                l = l + 1
            Next
        End If
        fj.Sort(SortFlags.Ascending, 3, 5)
        Dim c As Column = fg.Cols(5)
        c.ComboList = batch
    End Sub

  
End Class




