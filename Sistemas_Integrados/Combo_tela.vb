Imports C1.Win.C1FlexGrid

Public Class Combo_tela
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "0000000000"
    Dim ok As Boolean
    Dim CODIGO As String
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents codigos As System.Windows.Forms.ComboBox
    Dim lineas As Integer
    Dim te As New DataTable
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
    Friend WithEvents grabar As System.Windows.Forms.Button
    Friend WithEvents elimina As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colort As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ct As System.Windows.Forms.Button
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Combo_tela))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.grabar = New System.Windows.Forms.Button()
        Me.elimina = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.codigos = New System.Windows.Forms.ComboBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Ct = New System.Windows.Forms.Button()
        Me.colort = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 125)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 531)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'grabar
        '
        Me.grabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grabar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grabar.ForeColor = System.Drawing.Color.Black
        Me.grabar.Image = CType(resources.GetObject("grabar.Image"), System.Drawing.Image)
        Me.grabar.Location = New System.Drawing.Point(911, 15)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(60, 40)
        Me.grabar.TabIndex = 54
        Me.grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.grabar, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.")
        Me.grabar.UseVisualStyleBackColor = False
        '
        'elimina
        '
        Me.elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimina.ForeColor = System.Drawing.Color.Black
        Me.elimina.Image = CType(resources.GetObject("elimina.Image"), System.Drawing.Image)
        Me.elimina.Location = New System.Drawing.Point(913, 61)
        Me.elimina.Name = "elimina"
        Me.elimina.Size = New System.Drawing.Size(60, 40)
        Me.elimina.TabIndex = 21
        Me.elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.elimina, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.elimina.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.codigos)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Controls.Add(Me.Ct)
        Me.GroupBox1.Controls.Add(Me.colort)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.elimina)
        Me.GroupBox1.Controls.Add(Me.grabar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'codigos
        '
        Me.codigos.BackColor = System.Drawing.Color.White
        Me.codigos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigos.ForeColor = System.Drawing.Color.Black
        Me.codigos.Location = New System.Drawing.Point(130, 48)
        Me.codigos.MaxLength = 25
        Me.codigos.Name = "codigos"
        Me.codigos.Size = New System.Drawing.Size(100, 24)
        Me.codigos.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.codigos, "Color")
        '
        'Descripcion
        '
        Me.Descripcion.BackColor = System.Drawing.Color.SkyBlue
        Me.Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Descripcion.Enabled = False
        Me.Descripcion.ForeColor = System.Drawing.Color.Black
        Me.Descripcion.Location = New System.Drawing.Point(288, 47)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Size = New System.Drawing.Size(272, 48)
        Me.Descripcion.TabIndex = 61
        '
        'Ct
        '
        Me.Ct.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Ct.Location = New System.Drawing.Point(248, 49)
        Me.Ct.Name = "Ct"
        Me.Ct.Size = New System.Drawing.Size(32, 16)
        Me.Ct.TabIndex = 4
        Me.Ct.Text = "..."
        Me.Ct.UseVisualStyleBackColor = False
        '
        'colort
        '
        Me.colort.BackColor = System.Drawing.Color.White
        Me.colort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colort.ForeColor = System.Drawing.Color.Black
        Me.colort.Location = New System.Drawing.Point(619, 47)
        Me.colort.MaxLength = 25
        Me.colort.Name = "colort"
        Me.colort.Size = New System.Drawing.Size(263, 24)
        Me.colort.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.colort, "Color")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(568, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Color:"
        '
        'Cliente
        '
        Me.Cliente.BackColor = System.Drawing.Color.White
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.ForeColor = System.Drawing.Color.Black
        Me.Cliente.Location = New System.Drawing.Point(130, 15)
        Me.Cliente.MaxLength = 25
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(232, 24)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Color")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Codigo Tela:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'Combo_tela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 696)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Combo_tela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combos de Tela"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Expo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        AddHandler codigos.KeyPress, AddressOf keypressed2
        AddHandler colort.KeyPress, AddressOf keypressed3
        llena_tablas(te, "SELECT * FROM CODIGO_TELA ORDER BY CODIGO", cnn)
        llena_combos_d(codigos, te, "CODIGO")
        llena_clientes(Cliente)
        Cliente.Items.Remove("TODOS")
        Try
            Cliente.SelectedIndex = 0
        Catch
        End Try
        setea_grid()
    End Sub


    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        setea_grid()
        ok = False
        Dim strSQL As String = "SELECT *,DESCRIPCION FROM COMBO_TELAS LEFT JOIN CODIGO_TELA ON COMBO_TELAS.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CODIGO")
            fg(lineas, 2) = dr("DESCRIPCION")
            fg(lineas, 3) = dr("COLOR_TELA")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.SelectedIndexChanged
        setea_grid()
        llena_grid()
        llena_combos(colort, "SELECT DISTINCT COLOR FROM COLORES_TELA WHERE CLIENTE = '" & Cliente.Text & "'", "COLOR")
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                codigos.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Ct.Text) <> "" Then
                colort.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colort.Text) <> "" Then
                grabar.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub chequea_encabezado(ByRef ok As Boolean)
        ok = True
        If Trim(Codigos.Text) = "" Or Trim(colort.Text) = "" Then
            MsgBox("Aún no ha ingresado todos los datos necesarios !!!", MsgBoxStyle.Critical, "Datos no validos")
            ok = False
        End If
    End Sub
    Private Sub seleccion(ByVal fil As Integer)
        Dim jj As Boolean
        If fil > 0 And fil < fg.Rows.Count Then
            Codigos.Text = fg(fil, 1)
            Descripcion.Text = fg(fil, 2)
            colort.SelectedIndex = colort.Items.IndexOf(fg(fil, 3))
            busca_detalle(jj)
        End If
    End Sub
    Private Sub busca_detalle(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM COMBO_TELA LEFT JOIN CODIGO_TELA ON COMBO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "' AND COMBO_TELA.CODIGO = '" & Codigos.Text & "' AND COLOR_TELA = '" & colort.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            Codigos.Text = dr("CODIGO")
            Descripcion.Text = dr("DESCRIPCION")
            colort.SelectedIndex = colort.Items.IndexOf(dr("COLOR_TELA"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
        Dim seguro As MsgBoxResult
        ok = True
        chequea_encabezado(ok)
        If ok Then
            seguro = MsgBox("Seguro de querer Actualizar  ", MsgBoxStyle.YesNo, "Actualizando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros()
                setea_grid()
                llena_grid()
                codigos.Focus()
            End If
        End If
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        fg(lineas, 1) = Codigos.Text
        fg(lineas, 2) = Descripcion.Text
        fg(lineas, 3) = colort.Text
        fg(lineas, 0) = fg(lineas, 1) + fg(lineas, 2)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar todo el Cliente_Estilo_Color ?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
        End If
    End Sub
    Private Sub ct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ct.Click
        Dim forma As New Sel_Codigo_Tela()
        forma.codigo_j = codigos.Text
        forma.ShowDialog()
        codigos.SelectedIndex = codigos.Items.IndexOf(forma.codigo_j)
        colort.Focus()
    End Sub

    Private Sub cliente_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub colort_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colort.KeyPress
        AutoCompletar(colort, e)
    End Sub

    Private Sub codigos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigos.KeyPress
        AutoCompletar(codigos, e)
    End Sub

    Private Sub cliente_Lleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        End If
    End Sub
    ' =================================================================================
    ' =                     RUTINA DE GRABACION
    ' =
    ' =================================================================================
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strSQL = "UPDATE COMBO_TELAS SET CODIGO = " & "'" & Codigos.Text & "',  COLOR_TELA = '" & colort.Text & "' " & _
                                 " WHERE CLIENTE = '" & Cliente.Text & "' AND CODIGO = '" & Codigos.Text & "' AND COLOR_TELA = '" & colort.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO COMBO_TELAS (CLIENTE,CODIGO,COLOR_TELA) " & _
                         "VALUES ( '" & Cliente.Text & "','" & _
                             Codigos.Text & "','" & _
                             colort.Text & "')"
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

    ' =================================================================================
    ' =                     RUTINA DE ELIMINACION
    ' =
    ' =================================================================================
    Private Sub elimina_registros(ByVal strsql As String)
        Dim afectados As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            comando.CommandText = strsql
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

    Private Sub codigos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigos.SelectedIndexChanged
        Dim ok As Boolean
        busca_descripciones(te, codigos.Text, Descripcion.Text, ok)
    End Sub

End Class
