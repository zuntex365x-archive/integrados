Imports C1.Win.C1FlexGrid

Public Class Compo_consumo
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim nuevo As Boolean
    Dim usuario As String
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents quita As System.Windows.Forms.Button
    Dim empre As New empresas
    Friend WithEvents s1 As System.Windows.Forms.Button
    Dim estados As String
    Dim sep As Char = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    Friend WithEvents libras As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents componente As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Dim ct As New DataTable
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
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_consumo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.quita = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.ComboBox()
        Me.componente = New System.Windows.Forms.ComboBox()
        Me.s1 = New System.Windows.Forms.Button()
        Me.libras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
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
        Me.Label12.Location = New System.Drawing.Point(19, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 30)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Estilo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 204)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1186, 624)
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
        Me.graba.Location = New System.Drawing.Point(1048, 30)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(70, 49)
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
        Me.Button3.Location = New System.Drawing.Point(1125, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 49)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpia variables")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(183, 15)
        Me.cliente.MaxLength = 20
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(371, 24)
        Me.cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente.")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(9, 827)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(626, 20)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'estilo
        '
        Me.estilo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.IntegralHeight = False
        Me.estilo.Location = New System.Drawing.Point(183, 49)
        Me.estilo.MaxLength = 20
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(371, 24)
        Me.estilo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.estilo, "Cliente.")
        '
        'quita
        '
        Me.quita.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.quita.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quita.ForeColor = System.Drawing.Color.Black
        Me.quita.Image = CType(resources.GetObject("quita.Image"), System.Drawing.Image)
        Me.quita.Location = New System.Drawing.Point(1048, 30)
        Me.quita.Name = "quita"
        Me.quita.Size = New System.Drawing.Size(70, 49)
        Me.quita.TabIndex = 57
        Me.quita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.quita, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.quita.UseVisualStyleBackColor = False
        Me.quita.Visible = False
        '
        'codigo
        '
        Me.codigo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo.IntegralHeight = False
        Me.codigo.Location = New System.Drawing.Point(183, 118)
        Me.codigo.MaxLength = 10
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(371, 24)
        Me.codigo.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.codigo, "Cliente.")
        '
        'componente
        '
        Me.componente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.componente.IntegralHeight = False
        Me.componente.Location = New System.Drawing.Point(183, 84)
        Me.componente.MaxLength = 10
        Me.componente.Name = "componente"
        Me.componente.Size = New System.Drawing.Size(371, 24)
        Me.componente.TabIndex = 115
        Me.ToolTip1.SetToolTip(Me.componente, "Cliente.")
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(1048, 31)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(70, 49)
        Me.s1.TabIndex = 3
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.s1.UseVisualStyleBackColor = False
        '
        'libras
        '
        Me.libras.Location = New System.Drawing.Point(183, 158)
        Me.libras.Name = "libras"
        Me.libras.Size = New System.Drawing.Size(193, 20)
        Me.libras.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 29)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Libras:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 30)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Codigo Tela:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descripcion.Location = New System.Drawing.Point(573, 118)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(592, 30)
        Me.descripcion.TabIndex = 116
        Me.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 29)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Componente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Compo_consumo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.libras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.componente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.quita)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compo_consumo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comsumo por Estilo - Componente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Compo_consumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler estilo.KeyPress, AddressOf keypressed2
        AddHandler componente.KeyPress, AddressOf keypressed3
        AddHandler codigo.KeyPress, AddressOf keypressed4
        AddHandler libras.KeyPress, AddressOf keypressed5
        usuario = empre.clave
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM COMBO_TELA_1 ORDER BY CLIENTE", "CLIENTE")
        llena_tablas(ct, "SELECT * FROM CODIGO_TELA", cnn)
        llena_combos(codigo, "SELECT CODIGO FROM CODIGO_TELA ORDER BY CODIGO ", "CODIGO")
        Try
            cliente.SelectedIndex = 0
        Catch ex As Exception
        End Try
        set_variables()
        setea_grid()
    End Sub

    Private Sub deshabilita()
        cliente.Enabled = False
        estilo.Enabled = False
        componente.Enabled = True
        codigo.Enabled = True
        libras.Enabled = True
        s1.Visible = False
        componente.Focus()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub set_variables()
        graba.Visible = False
        quita.Visible = False
        s1.Visible = True
        cliente.Enabled = True
        estilo.Enabled = True
        componente.Enabled = False
        codigo.Enabled = False
        libras.Enabled = False
        setea_grid()
        cliente.Focus()
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
                s1.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(componente.Text) <> "" Then
                codigo.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(codigo.Text) <> "" Then
                libras.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If CDec(libras.Text) > 0 Then
                otro_registro()
            End If
        End If
    End Sub
    Private Sub otro_registro()
        Dim f As Integer
        f = fg.FindRow(componente.Text, 1, 2, False)
        If f > 0 Then
            fg(f, 3) = codigo.Text
            fg(f, 4) = libras.Text
            Try
                componente.SelectedIndex = componente.SelectedIndex + 1
            Catch ex As Exception
            End Try
            componente.Focus()
        End If
    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean = False
        revisa_grid(ok)
        If ok Then
            graba_registros()
            set_variables()
        Else
            mensaje("Aún faltan consumos por ingresar !!!!")
        End If
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
            ' =================== Graba Color
            For i = 1 To fg.Rows.Count - 1
                strSQL = "UPDATE COMBO_TELA_2 SET CODIGO ='" & fg(i, 3) & "', LIBRAS = '" & fg(i, 4) & "', INGRESADO_POR = '" & obj.usuario & "', FECHA_INGRESO = getdate() WHERE " & _
                                                             "CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COMPONENTE = '" & fg(i, 2) & "'"

                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                If afectados = 0 Then
                    strSQL = "INSERT INTO COMBO_TELA_2 (CLIENTE,ESTILO,COMPONENTE,CODIGO,LIBRAS,INGRESADO_POR,FECHA_INGRESO) VALUES ( '" & cliente.Text & "','" & _
                                                                        estilo.Text & "','" & _
                                                                        fg(i, 2) & "','" & _
                                                                        fg(i, 3) & "','" & _
                                                                        fg(i, 4) & "','" & _
                                                                        obj.usuario & "',getdate() )"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If
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

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    Private Sub estilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estilo.KeyPress
        AutoCompletar(estilo, e)
    End Sub
    Private Sub componente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles componente.KeyPress
        AutoCompletar(componente, e)
    End Sub
    Private Sub codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigo.KeyPress
        AutoCompletar(codigo, e)
    End Sub

    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(estilo, "SELECT DISTINCT ESTILO FROM COMBO_TELA_1 WHERE CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", "ESTILO")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        set_variables()
    End Sub
    Private Sub quita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quita.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
        End If
        set_variables()
    End Sub

    Private Sub elimina()
        Dim afectados As Integer
        '  Dim strSQL As String
        Dim obj As New empresas
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== Graba Color
            '   strSQL = "DELETE COMBO_TELA_1 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & componente.Text & "'"
            ' comando.CommandText = strSQL
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

    Private Sub s1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        procesa()
        deshabilita()
        Try
            componente.SelectedIndex = -1
            componente.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub procesa()
        Dim ok As Boolean
        busca_datos(ok)
        graba.Visible = True
    End Sub

    Private Sub busca_datos(ByRef ok As Boolean)
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT COMBO_TELA_0.*,CODIGO,LIBRAS FROM COMBO_TELA_0 LEFT JOIN COMBO_TELA_2 ON COMBO_TELA_0.CLIENTE = COMBO_TELA_2.CLIENTE AND COMBO_TELA_0.ESTILO = COMBO_TELA_2.ESTILO AND COMBO_TELA_0.COMPONENTE = COMBO_TELA_2.COMPONENTE  WHERE COMBO_TELA_0.CLIENTE = '" & cliente.Text & "' AND COMBO_TELA_0.ESTILO = '" & estilo.Text & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        ok = True
        For Each dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = dr("COMPONENTE")
            Try
                fg(l, 3) = dr("CODIGO")
            Catch ex As Exception

            End Try
            Try
                fg(l, 4) = dr("LIBRAS")
            Catch ex As Exception

            End Try
            l = l + 1
        Next
    End Sub

    Private Sub revisa_grid(ByRef ok As Boolean)
        Dim i As Integer
        ok = True
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 4) = 0 Then
                ok = False
            End If
        Next
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles libras.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub codigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigo.SelectedIndexChanged
        Dim ok As Boolean
        busca_descripciones(ct, codigo.Text, descripcion.Text, ok)
    End Sub

    Private Sub estilo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles estilo.SelectedIndexChanged
        llena_combos(componente, "SELECT COMPONENTE FROM COMBO_TELA_0 WHERE ESTILO = '" & estilo.Text & "'", "COMPONENTE")
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        llena_linea(f)
    End Sub

    Private Sub componente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles componente.SelectedIndexChanged
        Dim f As Integer
        Try
            f = componente.SelectedIndex + 1
            llena_linea(f)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub llena_linea(ByVal f As Integer)
        componente.SelectedIndex = componente.Items.IndexOf(fg(f, 2))
        codigo.SelectedIndex = codigo.Items.IndexOf(fg(f, 3))
        libras.Text = fg(f, 4)
    End Sub
    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        Dim f As Integer = fg.Row
        If e.KeyCode = Keys.Up Then
            f = f - 1
        End If

        If e.KeyCode = Keys.Down Then
            f = f + 1
        End If
        If f > fg.Rows.Count - 1 Or f < 1 Then
        Else
            llena_linea(f)
        End If

    End Sub

End Class
