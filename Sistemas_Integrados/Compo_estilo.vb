Imports C1.Win.C1FlexGrid

Public Class Compo_estilo
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim nuevo As Boolean
    Dim usuario As String
    Friend WithEvents componente As System.Windows.Forms.ComboBox
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents quita As System.Windows.Forms.Button
    Friend WithEvents s1 As System.Windows.Forms.Button
    Friend WithEvents sigue As System.Windows.Forms.Button
    Dim empre As New empresas
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_estilo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.s1 = New System.Windows.Forms.Button()
        Me.componente = New System.Windows.Forms.ComboBox()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.quita = New System.Windows.Forms.Button()
        Me.sigue = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Estilo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 172)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1016, 500)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(898, 24)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 18
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Actualiza Registro.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(964, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpia variables")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Componente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.s1)
        Me.GroupBox1.Controls.Add(Me.componente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 79)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(890, 19)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(60, 40)
        Me.s1.TabIndex = 109
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.s1.UseVisualStyleBackColor = False
        '
        'componente
        '
        Me.componente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.componente.IntegralHeight = False
        Me.componente.Location = New System.Drawing.Point(128, 28)
        Me.componente.MaxLength = 10
        Me.componente.Name = "componente"
        Me.componente.Size = New System.Drawing.Size(318, 24)
        Me.componente.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.componente, "Cliente.")
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(136, 10)
        Me.cliente.MaxLength = 10
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(318, 24)
        Me.cliente.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente.")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 672)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'estilo
        '
        Me.estilo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.IntegralHeight = False
        Me.estilo.Location = New System.Drawing.Point(136, 43)
        Me.estilo.MaxLength = 10
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(318, 24)
        Me.estilo.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.estilo, "Cliente.")
        '
        'quita
        '
        Me.quita.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.quita.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quita.ForeColor = System.Drawing.Color.Black
        Me.quita.Image = CType(resources.GetObject("quita.Image"), System.Drawing.Image)
        Me.quita.Location = New System.Drawing.Point(898, 24)
        Me.quita.Name = "quita"
        Me.quita.Size = New System.Drawing.Size(60, 40)
        Me.quita.TabIndex = 57
        Me.quita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.quita, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.quita.UseVisualStyleBackColor = False
        Me.quita.Visible = False
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(898, 24)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 110
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Compo_estilo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.quita)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compo_estilo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Componentes por Estilo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Colores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler estilo.KeyPress, AddressOf keypressed2
        AddHandler componente.KeyPress, AddressOf keypressed3
        usuario = empre.clave
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM COMPONENTES ORDER BY CLIENTE ", "CLIENTE")
        Try
            cliente.SelectedIndex = 0
        Catch ex As Exception
        End Try
        set_variables()
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM COMBO_TELA_0 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("COMPONENTE")
            l = l + 1
        Next
    End Sub
    Private Sub set_variables()
        sigue.Visible = True
        cliente.Enabled = True
        estilo.Enabled = True
        s1.Visible = False
        quita.Visible = False
        componente.Enabled = False
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim dt As New DataTable()
            If Trim(cliente.Text) <> "" Then
                estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(estilo.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            s1.Focus()
        End If
    End Sub 'keypressed
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var)
    End Sub

    Private Sub busca_estilo()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM COMBO_TELA_0 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COMPONENTE = '" & componente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
        Else
            quita.Visible = True
            dr = dt.Rows(0)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        If fg.Rows.Count > 1 Then
            seguro = MsgBox("Seguro de Querer Grabar?  Una vez grabado el Estilo no se le pueden agregar mas Componentes. ", MsgBoxStyle.YesNo, "Grabando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros()
                setea_grid()
                set_variables()
            End If
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = False
        If Trim(cliente.Text) = "" Then
            mensaje("Debe de ingresar el cliente")
            Exit Sub
        End If
        If Trim(estilo.Text) = "" Then
            mensaje("Debe de ingresar el Estilo")
            Exit Sub
        End If
        If Trim(componente.Text) = "" Then
            mensaje("Debe de ingresar el Componente")
            Exit Sub
        End If
        ok = True
    End Sub
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim obj As New empresas
        Dim i As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion


        Try
            ' =================== Graba Componentes
            For i = 1 To fg.Rows.Count - 1
                strSQL = "INSERT INTO COMBO_TELA_0 (CLIENTE,ESTILO,COMPONENTE,INGRESADO_POR,FECHA_INGRESO) VALUES ( '" & cliente.Text & "','" & _
                                                                          estilo.Text & "','" & _
                                                                          fg(i, 3) & "','" & _
                                                                          obj.usuario & "',getdate() )"
                comando.CommandText = strSQL
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
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim fila As Integer
        fila = fg.RowSel
        fg.Rows.Remove(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            componente.SelectedIndex = componente.Items.IndexOf(fg(fil, 3))
            busca_estilo()
        End If
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
        fg(lineas, 0) = cliente.Text + estilo.Text + componente.Text
        fg(lineas, 1) = cliente.Text
        fg(lineas, 2) = estilo.Text
        fg(lineas, 3) = componente.Text
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    Private Sub estilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estilo.KeyPress
        AutoCompletar(estilo, e)
    End Sub
    Private Sub componente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles componente.KeyPress
        AutoCompletar(componente, e)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena_grid()
    End Sub

    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(estilo, "SELECT DISTINCT ESTILO FROM ESTILOS WHERE CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", "ESTILO")
        llena_combos(componente, "SELECT COMPONENTE FROM COMPONENTES WHERE CLIENTE = '" & cliente.Text & "' ORDER BY COMPONENTE", "COMPONENTE")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        set_variables()
        setea_grid()
    End Sub

    Private Sub estilo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles estilo.SelectedIndexChanged
        setea_grid()
        set_variables()
    End Sub

    Private Sub quita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quita.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
        End If
        setea_grid()
        set_variables()
    End Sub

    Private Sub elimina()
        Dim afectados As Integer
        Dim strSQL As String
        Dim obj As New empresas
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== Graba Color
            strSQL = "DELETE COMBO_TELA_0 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
        Catch e As SqlClient.SqlException
            Dim myError As SqlClient.SqlError
            For Each myError In e.Errors
                If myError.Number = 3621 Then
                    MsgBox("No se pueden Eliminar estos Registros,  Ya existen otros que dependen de esta información !!!", MsgBoxStyle.Critical, "Por favor revise !!!!")
                End If
            Next
            Try
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

    Private Sub s1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        Dim ok As Boolean = False
        Dim lineas As Integer = fg.Rows.Count
        Dim busca As String = cliente.Text + estilo.Text + componente.Text
        Dim f As Integer
        revisa_datos(ok)
        If ok Then
            f = fg.FindRow(busca, 1, 0, False)
            If f < 1 Then
                fg.Rows.Count = lineas + 1
                llena_lineas(lineas)
                componente.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        procesa()
    End Sub

    Private Sub procesa()
        cliente.Enabled = False
        estilo.Enabled = False
        sigue.Visible = False
        setea_grid()
        llena_grid()
        If fg.Rows.Count > 1 Then
            fg.Enabled = False
            componente.Enabled = False
            quita.Visible = True
            graba.Visible = False
            s1.Visible = False
        Else
            fg.Enabled = True
            graba.Visible = True
            quita.Visible = True
            componente.Enabled = True
            s1.Visible = True
        End If
    End Sub
End Class
