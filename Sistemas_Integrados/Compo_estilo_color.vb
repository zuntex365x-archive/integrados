Imports C1.Win.C1FlexGrid

Public Class Compo_estilo_color
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim nuevo As Boolean
    Dim usuario As String
    Friend WithEvents color_p As System.Windows.Forms.ComboBox
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents quita As System.Windows.Forms.Button
    Dim empre As New empresas
    Friend WithEvents s1 As System.Windows.Forms.Button
    Friend WithEvents autor As System.Windows.Forms.Label
    Dim estados As String
    Dim dms As String
    Dim dm As New DataTable
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
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_estilo_color))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.color_p = New System.Windows.Forms.ComboBox()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.quita = New System.Windows.Forms.Button()
        Me.s1 = New System.Windows.Forms.Button()
        Me.autor = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(123, 24)
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
        Me.Label12.Location = New System.Drawing.Point(16, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Estilo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 124)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1115, 548)
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
        Me.Label7.Location = New System.Drawing.Point(16, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Color Prenda:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'color_p
        '
        Me.color_p.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_p.IntegralHeight = False
        Me.color_p.Location = New System.Drawing.Point(157, 81)
        Me.color_p.MaxLength = 10
        Me.color_p.Name = "color_p"
        Me.color_p.Size = New System.Drawing.Size(318, 24)
        Me.color_p.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.color_p, "Cliente.")
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(157, 12)
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
        Me.Label19.Location = New System.Drawing.Point(8, 676)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'estilo
        '
        Me.estilo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.IntegralHeight = False
        Me.estilo.Location = New System.Drawing.Point(157, 45)
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
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(898, 25)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(60, 40)
        Me.s1.TabIndex = 108
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.s1.UseVisualStyleBackColor = False
        '
        'autor
        '
        Me.autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.autor.Location = New System.Drawing.Point(490, 76)
        Me.autor.Name = "autor"
        Me.autor.Size = New System.Drawing.Size(508, 33)
        Me.autor.TabIndex = 109
        Me.autor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Compo_estilo_color
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1136, 696)
        Me.Controls.Add(Me.autor)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.color_p)
        Me.Controls.Add(Me.quita)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "Compo_estilo_color"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Componentes por Estilo -  Color de la Prenda"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Colores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler estilo.KeyPress, AddressOf keypressed2
        AddHandler color_p.KeyPress, AddressOf keypressed3
        usuario = empre.clave
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM COMPONENTES ORDER BY CLIENTE ", "CLIENTE")
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
        color_p.Enabled = False
        s1.Visible = False
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub Colores_tela()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT DISTINCT COLOR FROM COLORES_TELA WHERE CLIENTE = '" & cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        estados = ""
        For Each dr In dt.Rows
            estados = estados + dr("COLOR") + "|"
        Next
    End Sub
   
    Private Sub set_variables()
        graba.Visible = False
        quita.Visible = False
        s1.Visible = True
        cliente.Enabled = True
        estilo.Enabled = True
        color_p.Enabled = True
        autor.Text = ""
        autor.Visible = False
        setea_grid()
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
                color_p.Focus()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean = False
        revisa_grid(ok)
        If ok Then
            graba_registros()
            set_variables()
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
        If Trim(color_p.Text) = "" Then
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
            ' =================== Graba Color

            For i = 1 To fg.Rows.Count - 1
                strSQL = "UPDATE COMBO_TELA_1 SET COLOR_TELA = '" & fg(i, 4) & "', INGRESADO_POR = '" & obj.usuario & "', FECHA_INGRESO = GETDATE() , DM = '" & fg(i, 5) & "', CODIGO = '" & fg(i, 6) & "' WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & fg(i, 1) & "' AND COLOR = '" & fg(i, 2) & "' AND COMPONENTE = '" & fg(i, 3) & "'"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
                If afectados = 0 Then
                    strSQL = "INSERT INTO COMBO_TELA_1 (CLIENTE,ESTILO,COLOR,COMPONENTE,COLOR_TELA,INGRESADO_POR,FECHA_INGRESO,DM,CODIGO) VALUES ( '" & cliente.Text & "','" & _
                                                                        fg(i, 1) & "','" & _
                                                                        fg(i, 2) & "','" & _
                                                                        fg(i, 3) & "','" & _
                                                                        fg(i, 4) & "','" & _
                                                                        obj.usuario & "',getdate(),'" & _
                                                                        fg(i, 5) & "','" & _
                                                                        fg(i, 6) & "')"

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
    Private Sub componente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles color_p.KeyPress
        AutoCompletar(color_p, e)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(estilo, "SELECT DISTINCT ESTILO FROM COMBO_TELA_0 WHERE CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", "ESTILO")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        set_variables()
    End Sub

    Private Sub estilo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles estilo.SelectedIndexChanged
        llena_combos(color_p, "SELECT DISTINCT COLOR FROM CLI_EST_COL WHERE CLIENTE = '" & cliente.Text & "' ORDER BY COLOR", "COLOR")
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
            strSQL = "DELETE COMBO_TELA_1 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & color_p.Text & "'"
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
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            procesa()
            deshabilita()
        End If
    End Sub

    Private Sub procesa()
        Dim ok As Boolean
        busca_datos(ok)
        If ok Then
            fg.Enabled = False
            If autor.Text = "" Then
                quita.Visible = True
            End If
        Else
            llena_componentes()
            graba.Visible = True
        End If
    End Sub

    Private Sub busca_datos(ByRef ok As Boolean)
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM COMBO_TELA_1 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & color_p.Text & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = dr("COLOR")
            fg(l, 3) = dr("COMPONENTE")
            fg(l, 4) = dr("COLOR_TELA")
            fg(l, 5) = dr("DM")
            fg(l, 6) = dr("CODIGO")
            If dr("VERIFICADO_POR") Is DBNull.Value Then
            Else
                autor.Text = "Verificado por: " + dr("VERIFICADO_POR")
                autor.Visible = True
            End If
            l = l + 1
        Next
        If dt.Rows.Count > 1 Then
            ok = True
        Else
            ok = False
        End If
    End Sub

    Private Sub llena_componentes()
        Dim l As Integer = 1
        Dim c As Column = fg.Cols(4)
        Dim dt As New DataTable
        Dim dr As DataRow
        Colores_tela()
        busca_dm(cliente.Text, dm, dms)
        c.ComboList = estados
        fg.Cols(4).AllowEditing = True
        c = fg.Cols(5)
        c.ComboList = dms
        fg.Cols(5).AllowEditing = True
        fg.Enabled = True
        llena_tablas(dt, "SELECT * FROM COMBO_TELA_0 WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = color_p.Text
            fg(l, 3) = dr("COMPONENTE")
            l = l + 1
        Next
    End Sub
    Private Sub revisa_grid(ByRef ok As Boolean)
        Dim i As Integer
        ok = True
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 4) = "" Then
                mensaje("Todos los Colores de Tela !!!")
                ok = False
                Exit For
            End If
            If fg(i, 5) = "" Then
                mensaje("Todos los DM de Tela !!!")
                ok = False
                Exit For
            End If
        Next
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim dml As String = fg(r, 5)
        If e.Col = 5 Then
            dd = dm.Select("DM = '" & dml & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                fg(e.Row, 6) = dr("CODIGO")
            Else
                fg(e.Row, 6) = ""
            End If

        End If
    End Sub
End Class
