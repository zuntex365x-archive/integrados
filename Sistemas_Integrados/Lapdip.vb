Imports C1.Win.C1FlexGrid

Public Class LAPDIP
    Inherits System.Windows.Forms.Form
    Dim lineas As Integer
    Dim actual As Integer
    Dim tipo_movto As Integer = 1
    Dim Bien As Boolean
    Dim choice As String
    Dim H As String = "##,###,##0.00"
    Dim existe As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim co As New DataTable()
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim tp As New DataTable
    Friend WithEvents dm As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents colores As System.Windows.Forms.ComboBox
    Friend WithEvents lapdi As System.Windows.Forms.TextBox
    Friend WithEvents r0 As System.Windows.Forms.Button
    Dim h1 As String = "######0.0000"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents borra As System.Windows.Forms.Button
    Friend WithEvents But_graba As System.Windows.Forms.Button
    Friend WithEvents clasif As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LAPDIP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.borra = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clasif = New System.Windows.Forms.ComboBox()
        Me.But_graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.dm = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.colores = New System.Windows.Forms.ComboBox()
        Me.lapdi = New System.Windows.Forms.TextBox()
        Me.r0 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lap Dip"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DM:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Color:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'borra
        '
        Me.borra.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.borra.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borra.ForeColor = System.Drawing.Color.Black
        Me.borra.Image = CType(resources.GetObject("borra.Image"), System.Drawing.Image)
        Me.borra.Location = New System.Drawing.Point(738, 12)
        Me.borra.Name = "borra"
        Me.borra.Size = New System.Drawing.Size(60, 40)
        Me.borra.TabIndex = 23
        Me.borra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.borra.UseVisualStyleBackColor = False
        Me.borra.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Clasificacion Color:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clasif
        '
        Me.clasif.BackColor = System.Drawing.Color.White
        Me.clasif.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.clasif.Items.AddRange(New Object() {"White", "Light", "Medium", "Dark", "Special"})
        Me.clasif.Location = New System.Drawing.Point(176, 140)
        Me.clasif.MaxDropDownItems = 15
        Me.clasif.Name = "clasif"
        Me.clasif.Size = New System.Drawing.Size(144, 24)
        Me.clasif.TabIndex = 4
        '
        'But_graba
        '
        Me.But_graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_graba.ForeColor = System.Drawing.Color.Black
        Me.But_graba.Image = CType(resources.GetObject("But_graba.Image"), System.Drawing.Image)
        Me.But_graba.Location = New System.Drawing.Point(804, 12)
        Me.But_graba.Name = "But_graba"
        Me.But_graba.Size = New System.Drawing.Size(60, 40)
        Me.But_graba.TabIndex = 5
        Me.But_graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 181)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(922, 415)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 89
        '
        'dm
        '
        Me.dm.BackColor = System.Drawing.Color.White
        Me.dm.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.dm.Location = New System.Drawing.Point(176, 53)
        Me.dm.MaxDropDownItems = 15
        Me.dm.Name = "dm"
        Me.dm.Size = New System.Drawing.Size(177, 24)
        Me.dm.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cliente.Location = New System.Drawing.Point(176, 81)
        Me.cliente.MaxDropDownItems = 15
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(177, 24)
        Me.cliente.TabIndex = 2
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.colores.Location = New System.Drawing.Point(176, 110)
        Me.colores.MaxDropDownItems = 15
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(314, 24)
        Me.colores.TabIndex = 3
        '
        'lapdi
        '
        Me.lapdi.Location = New System.Drawing.Point(176, 9)
        Me.lapdi.MaxLength = 10
        Me.lapdi.Name = "lapdi"
        Me.lapdi.Size = New System.Drawing.Size(177, 22)
        Me.lapdi.TabIndex = 0
        '
        'r0
        '
        Me.r0.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r0.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r0.ForeColor = System.Drawing.Color.Black
        Me.r0.Image = CType(resources.GetObject("r0.Image"), System.Drawing.Image)
        Me.r0.Location = New System.Drawing.Point(870, 12)
        Me.r0.Name = "r0"
        Me.r0.Size = New System.Drawing.Size(60, 40)
        Me.r0.TabIndex = 93
        Me.r0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r0.UseVisualStyleBackColor = False
        '
        'LAPDIP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 608)
        Me.Controls.Add(Me.r0)
        Me.Controls.Add(Me.lapdi)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dm)
        Me.Controls.Add(Me.borra)
        Me.Controls.Add(Me.clasif)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.But_graba)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LAPDIP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maesro de Lap Dip"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler lapdi.KeyPress, AddressOf keypressed1
        AddHandler dm.KeyPress, AddressOf keypressed2
        AddHandler cliente.KeyPress, AddressOf keypressed3
        AddHandler colores.KeyPress, AddressOf keypressed4
        AddHandler clasif.KeyPress, AddressOf keypressed5
        llena_combos(dm, "SELECT DM FROM DM ORDER BY DM", "DM")
        llena_combos(cliente, "SELECT * FROM CLIENTES", "CLIENTE")
        clasif.SelectedIndex = 0
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        lapdi.Text = ""
        lapdi.Enabled = True
        dm.Enabled = False
        cliente.Enabled = False
        colores.Enabled = False
        clasif.Enabled = False
        borra.Visible = False
        But_graba.Visible = False
        lapdi.Focus()
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(lapdi.Text) <> "" Then
                busca_datos()
            End If
        End If
    End Sub 'keypressed


    Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(dm.Text) <> "" Then
                cliente.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                colores.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colores.Text) <> "" Then
                clasif.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(clasif.Text) <> "" Then
                But_graba.Focus()
            End If

        End If
    End Sub 'keypressed

    Private Sub busca_linea(ByVal busca As String, ByRef l As Integer)
        busca = Trim(clasif.Text)
        l = fg.FindRow(busca, 1, 1, True)
    End Sub
    Private Sub But_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borra.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_registros()
            setea_grid()
            limpia_variables()
        End If
    End Sub
    Private Sub selecciona_linea(ByVal l As Integer)
        l = fg.RowSel
        Try
            lapdi.Text = fg(l, 1)
            busca_datos()
            borra.Visible = True
        Catch
        End Try
    End Sub
    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            If fg.Row > 1 Then
                selecciona_linea(fg.Row - 1)
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If fg.Row < fg.Rows.Count Then
                selecciona_linea(fg.Row + 1)
            End If
        End If
    End Sub
    Private Sub habilita()
        lapdi.Enabled = False
        dm.Enabled = True
        cliente.Enabled = True
        colores.Enabled = True
        clasif.Enabled = True
        But_graba.Visible = True
        dm.Focus()
    End Sub
    Private Sub busca_datos()
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM LAPDIP WHERE LAPDIP = '" & lapdi.Text & "'", cnn)
        For Each dr In dt.Rows
            dm.SelectedIndex = dm.Items.IndexOf(dr("DM"))
            cliente.SelectedIndex = cliente.Items.IndexOf(dr("CLIENTE"))
            colores.SelectedIndex = colores.Items.IndexOf(dr("COLOR"))
            clasif.SelectedIndex = dr("CLASIFICACION")
            borra.Visible = True
        Next
        habilita()
    End Sub

    '=====================================================================================
    '                                  DETALLE
    '=====================================================================================
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
        llena_grid()
    End Sub
    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        llena_tablas(dt, "SELECT * FROM LAPDIP", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("LAPDIP")
            fg(l, 2) = dr("CLIENTE")
            fg(l, 3) = dr("COLOR")
            l = l + 1
        Next
    End Sub

    Private Sub But_graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_graba.Click
        graba_registros()
        limpia_variables()
        setea_grid()
    End Sub

    Private Sub dm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dm.KeyPress
        AutoCompletar(dm, e)
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colores.KeyPress
        AutoCompletar(colores, e)
    End Sub
    Private Sub cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clasif.KeyPress
        AutoCompletar(clasif, e)
    End Sub
    ' ==================================================================================================
    '                                      ACTUALIZA BASE DE DATOS                                    ==
    ' ==================================================================================================
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim hoy As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            '============== Correlativo  =======================
            strSQL = "UPDATE LAPDIP SET DM = '" & dm.Text & "' , CLIENTE = '" & cliente.Text & "' , COLOR = '" & colores.Text & "' , CLASIFICACION = '" & clasif.SelectedIndex & "' , ACTUALIZADO = '" & hoy & "' WHERE LAPDIP = '" & lapdi.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strSQL = "INSERT INTO LAPDIP (LAPDIP,DM,CLIENTE,COLOR,CLASIFICACION,ACTUALIZADO) " & _
                                    "VALUES ( '" & lapdi.Text & "','" & dm.Text & "','" & cliente.Text & "','" & colores.Text & "','" & clasif.SelectedIndex & "','" & hoy & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            End If

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
    End Sub
    ' ==================================================================================================
    '                                     ELIMINA REGISTROS                                           ==
    ' ==================================================================================================
    Private Sub elimina_registros()
        Dim afectados As Integer
        Dim strSQL As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strSQL = "DELETE LAPDIP WHERE LAPDIP = '" & lapdi.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

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
    End Sub
    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        Dim l As Integer = fg.RowSel
        If l > 0 Then
            selecciona_linea(l)
        End If
    End Sub
    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(colores, "SELECT COLOR FROM COLORES WHERE CLIENTE = '" & cliente.Text & "' AND ACTIVO = 'S' ORDER BY COLOR", "COLOR")
    End Sub

    Private Sub r0_Click(sender As System.Object, e As System.EventArgs) Handles r0.Click
        setea_grid()
        limpia_variables()
    End Sub
End Class

