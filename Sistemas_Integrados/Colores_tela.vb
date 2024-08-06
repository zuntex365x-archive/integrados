Imports C1.Win.C1FlexGrid

Public Class Colores_tela
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Friend WithEvents activo As System.Windows.Forms.CheckBox
    Dim nuevo As Boolean
    Dim usuario As String
    Friend WithEvents lapdip As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.ComboBox
    Friend WithEvents clase As System.Windows.Forms.ComboBox
    Friend WithEvents elimina As System.Windows.Forms.Button
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Colores_tela))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clase = New System.Windows.Forms.ComboBox()
        Me.activo = New System.Windows.Forms.CheckBox()
        Me.lapdip = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.colo = New System.Windows.Forms.ComboBox()
        Me.elimina = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(136, 24)
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
        Me.Label12.Size = New System.Drawing.Size(136, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Color:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 189)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1016, 483)
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
        Me.graba.Location = New System.Drawing.Point(879, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
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
        Me.Button3.Location = New System.Drawing.Point(920, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpia variables")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Clasificacion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Activo?"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.clase)
        Me.GroupBox1.Controls.Add(Me.activo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 85)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'clase
        '
        Me.clase.BackColor = System.Drawing.Color.White
        Me.clase.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.clase.Items.AddRange(New Object() {"WHITE", "LIGHT", "MEDIUM", "DARK", "SPECIAL"})
        Me.clase.Location = New System.Drawing.Point(159, 42)
        Me.clase.MaxDropDownItems = 15
        Me.clase.Name = "clase"
        Me.clase.Size = New System.Drawing.Size(163, 24)
        Me.clase.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.clase, "Clasificación según claridad del Color,")
        '
        'activo
        '
        Me.activo.AutoSize = True
        Me.activo.Location = New System.Drawing.Point(201, 22)
        Me.activo.Name = "activo"
        Me.activo.Size = New System.Drawing.Size(15, 14)
        Me.activo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.activo, "Activo?")
        Me.activo.UseVisualStyleBackColor = True
        '
        'lapdip
        '
        Me.lapdip.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lapdip.IntegralHeight = False
        Me.lapdip.Location = New System.Drawing.Point(167, 70)
        Me.lapdip.MaxLength = 10
        Me.lapdip.Name = "lapdip"
        Me.lapdip.Size = New System.Drawing.Size(163, 24)
        Me.lapdip.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.lapdip, "No. de Lapdip.")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Lapdip:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(168, 10)
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
        'colo
        '
        Me.colo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colo.IntegralHeight = False
        Me.colo.Location = New System.Drawing.Point(168, 40)
        Me.colo.MaxLength = 25
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(318, 24)
        Me.colo.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.colo, "Color.")
        '
        'elimina
        '
        Me.elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimina.ForeColor = System.Drawing.Color.Black
        Me.elimina.Image = CType(resources.GetObject("elimina.Image"), System.Drawing.Image)
        Me.elimina.Location = New System.Drawing.Point(838, 8)
        Me.elimina.Name = "elimina"
        Me.elimina.Size = New System.Drawing.Size(35, 35)
        Me.elimina.TabIndex = 45
        Me.elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.elimina, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.elimina.UseVisualStyleBackColor = False
        '
        'Colores_tela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.elimina)
        Me.Controls.Add(Me.colo)
        Me.Controls.Add(Me.lapdip)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Name = "Colores_tela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Colores de Tela"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Colores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler colo.KeyPress, AddressOf keypressed2
        AddHandler activo.KeyPress, AddressOf keypressed4
        AddHandler clase.KeyPress, AddressOf keypressed6
        AddHandler lapdip.KeyPress, AddressOf keypressed3
        llena_combos(cliente, "SELECT CLIENTE FROM CLIENTES WHERE ACTIVO = 'S'", "CLIENTE")
        set_variables()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim l As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM COLORES_TELA WHERE CLIENTE = '" & cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        l = dt.Rows.Count
        fg.Rows.Count = l + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("COLOR")
            If dr("ACTIVO") = "S" Then
                fg(l, 2) = True
            Else
                fg(l, 2) = False
            End If
            fg(l, 3) = dr("CLASIFICACION")
            fg(l, 4) = dr("LAPDIP")
            l = l + 1
        Next
        llena_combos(lapdip, "SELECT LAPDIP FROM LAPDIP", "LAPDIP")
    End Sub
    Private Sub set_variables()
        clase.SelectedIndex = 0
        activo.Checked = True
        clase.Enabled = False
        cliente.Enabled = True
        colo.Enabled = True
        lapdip.Enabled = True
        activo.Enabled = False
        graba.Visible = False
        elimina.Visible = False
        colo.Focus()
    End Sub
    Private Sub habilita()
        cliente.Enabled = False
        colo.Enabled = False
        lapdip.Enabled = False
        clase.Enabled = True
        activo.Enabled = True
        graba.Visible = True
        activo.Focus()
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim dt As New DataTable()
            If Trim(cliente.Text) <> "" Then
                colo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colo.Text) <> "" Then
                lapdip.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            revisa_datos(ok)
            If ok Then
                busca_color()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(activo.Text) <> "" Then
                clase.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(clase.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var)
    End Sub

    Private Sub busca_color()
        Dim dt As New DataTable()
        Dim dr As DataRow

        Dim strSQL As String = "SELECT * FROM COLORES_TELA WHERE CLIENTE = '" & cliente.Text & "' AND COLOR = '" & colo.Text & "' AND LAPDIP = '" & lapdip.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
        Else
            For Each dr In dt.Rows
                llena_Variables(dr)
                elimina.Visible = True
            Next
        End If
        habilita()
    End Sub

    Private Sub llena_Variables(ByVal dr As DataRow)
        Try
            clase.SelectedIndex = clase.Items.IndexOf(dr("CLASIFICACION"))
        Catch
        End Try
        If dr("ACTIVO") = "S" Then
            activo.Checked = True
        Else
            activo.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean = False
        revisa_datos(ok)
        If ok Then
            graba_registros()
            setea_grid()
            set_variables()
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim valor As Decimal = 0
        If Trim(colo.Text) = "" Then
            mensaje("Debe de ingresar la Descripción del Color")
            Exit Sub
        End If
        If Trim(lapdip.Text) = "" Then
            mensaje("Debe de ingresar el número de Lapdip")
            Exit Sub
        End If
        ok = True
    End Sub
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim acti As String = "N"
        If activo.Checked Then
            acti = "S"
        End If

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== Graba Color
            strSQL = "UPDATE COLORES_TELA SET ACTIVO = '" & acti & "' ,CLASIFICACION = '" & clase.Text & "' " & _
                                         "WHERE CLIENTE = '" & cliente.Text & "' AND COLOR = '" & colo.Text & "' AND LAPDIP = '" & lapdip.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()


            If afectados = 0 Then
                strSQL = "INSERT INTO COLORES_TELA (CLIENTE,COLOR,LAPDIP,ACTIVO,CLASIFICACION) VALUES ( '" & cliente.Text & "','" & _
                                                                      colo.Text & "','" & _
                                                                      lapdip.Text & "','" & _
                                                                      acti & "','" & _
                                                                      clase.Text & "')"
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

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim fila As Integer
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            colo.Text = fg(fil, 1)
            lapdip.Text = fg(fil, 4)
            busca_color()
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
        fg(lineas, 1) = cliente.Text
        fg(lineas, 2) = activo.Checked
        fg(lineas, 3) = clase.Text
        fg(lineas, 4) = lapdip.Text
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub


    Private Sub clase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clase.KeyPress
        AutoCompletar(clase, e)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        llena_grid()
        colo.Enabled = True
    End Sub

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        setea_grid()
        llena_grid()
        set_variables()
        llena_combos(colo, "SELECT COLOR FROM COLORES_TELA ORDER BY COLOR ", "COLOR")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        set_variables()
        cliente.Focus()
    End Sub

  
End Class
