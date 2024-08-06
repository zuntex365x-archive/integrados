Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Traslado
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim STRSQL As String
    Dim bg As New DataTable
    Dim bg1 As New DataTable
    Friend WithEvents b1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tl As C1.Win.C1FlexGrid.C1FlexGrid
    Dim j(7) As String
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents batch As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traslado))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.batch = New System.Windows.Forms.ComboBox()
        Me.b1 = New System.Windows.Forms.ComboBox()
        Me.b2 = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tl = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(452, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BATCH:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(769, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione aqui para ver los Rollos del Batch")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(901, 12)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(60, 40)
        Me.CANCELA.TabIndex = 46
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
                " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(835, 12)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(60, 40)
        Me.GRABA.TabIndex = 47
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'batch
        '
        Me.batch.BackColor = System.Drawing.Color.White
        Me.batch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batch.ForeColor = System.Drawing.Color.Black
        Me.batch.Location = New System.Drawing.Point(452, 24)
        Me.batch.MaxLength = 20
        Me.batch.Name = "batch"
        Me.batch.Size = New System.Drawing.Size(248, 28)
        Me.batch.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.batch, "Batch de Tela")
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.White
        Me.b1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.Color.Black
        Me.b1.Location = New System.Drawing.Point(8, 24)
        Me.b1.MaxLength = 20
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(188, 28)
        Me.b1.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.b1, "Batch de Tela")
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.White
        Me.b2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ForeColor = System.Drawing.Color.Black
        Me.b2.Location = New System.Drawing.Point(225, 24)
        Me.b2.MaxLength = 20
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(188, 28)
        Me.b2.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.b2, "Batch de Tela")
        '
        'fg
        '
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.fg.Location = New System.Drawing.Point(8, 58)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(968, 305)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "De Bodega:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "A Bodega:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'tl
        '
        Me.tl.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.tl.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.tl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tl.ColumnInfo = resources.GetString("tl.ColumnInfo")
        Me.tl.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.tl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tl.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.tl.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.tl.Location = New System.Drawing.Point(4, 371)
        Me.tl.Name = "tl"
        Me.tl.Rows.DefaultSize = 19
        Me.tl.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.tl.Size = New System.Drawing.Size(968, 316)
        Me.tl.StyleInfo = resources.GetString("tl.StyleInfo")
        Me.tl.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.tl.TabIndex = 52
        '
        'Traslado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 699)
        Me.Controls.Add(Me.tl)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.batch)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.GRABA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Traslado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de Tela entre Bodegas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Ancho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler b1.KeyPress, AddressOf keypressed1
        AddHandler b2.KeyPress, AddressOf keypressed2
        AddHandler batch.KeyPress, AddressOf keypressed3
        AddHandler b1.DrawItem, AddressOf comboBox_DrawItem1
        AddHandler b2.DrawItem, AddressOf comboBox_DrawItem2
        llena_tablas(bg, "SELECT * FROM BODEGAS", cnn)
        llena_tablas(bg1, "SELECT * FROM BODEGAS", cnn)

        Me.b1.DataSource = bg
        Me.b1.DisplayMember = "BODEGA"
        Me.b1.ValueMember = "CODIGO"
        Me.b2.DataSource = bg1
        Me.b2.DisplayMember = "BODEGA"
        Me.b2.ValueMember = "CODIGO"
        Me.b1.DrawMode = DrawMode.OwnerDrawFixed
        Me.b2.DrawMode = DrawMode.OwnerDrawFixed
        Try
            b1.SelectedIndex = 0
        Catch ex As Exception

        End Try
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        b1.Enabled = True
        b2.Enabled = True
        batch.Enabled = False
        fg.Enabled = False
        Button1.Visible = False
        CANCELA.Visible = True
        GRABA.Visible = False
        setea_fg()
        setea_tl()
        b1.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub setea_tl()
        tl.Rows.Count = 1
        tl.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer = 1
        ok = True
        STRSQL = "SELECT * FROM ROLLOS WHERE BATCH = '" & batch.Text & "' AND ACTIVO <> 'N' AND YARDAS > 0"
        llena_tablas(dt, STRSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(i, 1) = dr("BATCH")
            fg(i, 2) = dr("ROLLO")
            fg(i, 3) = dr("KNIT")
            fg(i, 4) = dr("COLOR")
            fg(i, 5) = dr("PESO")
            fg(i, 6) = dr("YARDAS")
            fg(i, 7) = True
            i = i + 1
        Next
        If i = 1 Then
            ok = False
        End If
    End Sub

    Private Sub batch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles batch.KeyPress
        AutoCompletar(batch, e)
    End Sub

    Private Sub b1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b1.KeyPress
        AutoCompletar(b1, e)
    End Sub

    Private Sub b2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b2.KeyPress
        AutoCompletar(b2, e)
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(b1.Text) <> "" Then
                b2.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(b2.Text) <> "" Then
                revisa_datos(ok)
                If ok Then
                    batch.Focus()
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(batch.Text) <> "" Then
                Button1.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llena_datos()
    End Sub
    Private Sub llena_datos()
        Dim i As Integer
        Dim l As Integer
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 7) = True Then
                l = tl.FindRow(fg(i, 1) + CStr(fg(i, 2)), 1, 0, False)
                If l = -1 Then
                    l = tl.Rows.Count + 1
                    tl.Rows.Count = l
                    tl(l - 1, 1) = fg(i, 1)
                    tl(l - 1, 2) = fg(i, 2)
                    tl(l - 1, 3) = fg(i, 3)
                    tl(l - 1, 4) = fg(i, 4)
                    tl(l - 1, 5) = fg(i, 5)
                    tl(l - 1, 6) = fg(i, 6)
                    tl(l - 1, 0) = fg(i, 1) + CStr(fg(i, 2))
                End If
            End If
        Next
    End Sub
    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = False
        If b1.SelectedValue = b2.SelectedValue Then
            MsgBox("No puede efectuar traslados hacia la misma Bodega", MsgBoxStyle.Critical, "Revise Bodega que envía y Bodega que recibe.")
            Exit Sub
        End If
        b1.Enabled = False
        b2.Enabled = False
        batch.Enabled = True
        fg.Enabled = True
        Button1.Visible = True
        GRABA.Visible = True
        llena_combos(batch, "SELECT DISTINCT BATCH FROM ROLLOS WHERE ACTIVO <> 'N' AND YARDAS > 0 AND BODEGA = '" & b1.SelectedValue & "'", "BATCH")
        Try

            batch.SelectedIndex = 0
        Catch ex As Exception

        End Try
        ok = True
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Cancelar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Cancela Cambios !!!")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            If tl.Rows.Count > 1 Then
                actualiza_batch()
            Else
                MsgBox("Al menos ingrese un Rollo a Trasladar !!!!", MsgBoxStyle.Critical, "Verificar")
            End If
        End If
    End Sub

    Private Sub actualiza_batch()
        Dim afectados As Integer
        Dim hoy As Date = Now
        Dim i As Integer
        Dim obj As New empresas
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim traslado As Integer
        STRSQL = "SELECT TRASLADOS FROM CORRELATIVO"
        llena_tablas(dt, STRSQL, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            traslado = dr("TRASLADOS") + 1
        End If
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        STRSQL = "UPDATE CORRELATIVO SET TRASLADOS = TRASLADOS + 1"
        comando.CommandText = STRSQL
        afectados = comando.ExecuteNonQuery()

        Try
            For i = 1 To tl.Rows.Count - 1
                STRSQL = "UPDATE ROLLOS SET BODEGA = '" & b2.SelectedValue & "' " & _
                         " WHERE BATCH = '" & tl(i, 1) & "' AND ROLLO = '" & tl(i, 2) & "' "
                comando.CommandText = STRSQL
                afectados = comando.ExecuteNonQuery()

                STRSQL = "INSERT INTO TRASLADO_BODEGAS (TRASLADO,BATCH,ROLLO,DE_BODEGA,A_BODEGA,LIBRAS,YARDAS,USUARIO) VALUES " & _
                                                      "('" & CInt(traslado) & "','" & tl(i, 1) & "','" & tl(i, 2) & "','" & b1.SelectedValue & "','" & b2.SelectedValue & "','" & tl(i, 5) & "','" & tl(i, 6) & "','" & obj.usuario & "')"
                comando.CommandText = STRSQL
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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
        limpia_variables()

    End Sub

    Public Sub comboBox_DrawItem1(ByVal sender As System.Object, _
                                   ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            ' Draw the default background
            e.DrawBackground()

            ' The ComboBox is bound to a DataTable,
            ' so the items are DataRowView objects.
            Dim drv As DataRowView = CType(b1.Items(e.Index), DataRowView)

            ' Retrieve the value of each column.
            Dim id As String = drv(0).ToString()
            Dim name As String = drv(1).ToString()

            ' Get the bounds for the first column
            Dim r1 As Rectangle = e.Bounds
            r1.Width = r1.Width / 2

            ' Draw the text on the first column
            Using sb As SolidBrush = New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(id, e.Font, sb, r1)
            End Using

            ' Draw a line to isolate the columns 
            Using p As Pen = New Pen(Color.Black)
                e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
            End Using

            ' Get the bounds for the second column
            Dim r2 As Rectangle = e.Bounds
            r2.X = e.Bounds.Width / 2
            r2.Width = r2.Width / 2

            ' Draw the text on the second column
            Using sb As SolidBrush = New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(name, e.Font, sb, r2)
            End Using
        Catch
        End Try

    End Sub

    Private Sub comboBox_DrawItem2(ByVal sender As System.Object, _
                                  ByVal e As System.Windows.Forms.DrawItemEventArgs)

        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(b2.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv(0).ToString()
        Dim name As String = drv(1).ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 2

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
    End Sub

    Private Sub batch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batch.SelectedIndexChanged
        setea_fg()
        llena_fg()
    End Sub
End Class
