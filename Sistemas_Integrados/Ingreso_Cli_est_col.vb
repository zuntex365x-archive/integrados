Imports C1.Win.C1FlexGrid


Public Class Ingreso_cli_est_col
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents ESTILOS As System.Windows.Forms.ComboBox
    Dim lineas As Integer
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents COLORES As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENTES As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Elimi As System.Windows.Forms.Button
    Friend WithEvents Regresa As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_cli_est_col))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CLIENTES = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.COLORES = New System.Windows.Forms.ComboBox()
        Me.Elimi = New System.Windows.Forms.Button()
        Me.Regresa = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.ESTILOS = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 152)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(952, 496)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(832, 16)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Estilo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CLIENTES
        '
        Me.CLIENTES.Location = New System.Drawing.Point(16, 32)
        Me.CLIENTES.MaxLength = 20
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(264, 21)
        Me.CLIENTES.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CLIENTES, "Cliente")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'COLORES
        '
        Me.COLORES.Location = New System.Drawing.Point(218, 112)
        Me.COLORES.MaxLength = 20
        Me.COLORES.Name = "COLORES"
        Me.COLORES.Size = New System.Drawing.Size(240, 21)
        Me.COLORES.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.COLORES, "Cliente")
        '
        'Elimi
        '
        Me.Elimi.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Elimi.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimi.ForeColor = System.Drawing.Color.Black
        Me.Elimi.Image = CType(resources.GetObject("Elimi.Image"), System.Drawing.Image)
        Me.Elimi.Location = New System.Drawing.Point(888, 96)
        Me.Elimi.Name = "Elimi"
        Me.Elimi.Size = New System.Drawing.Size(35, 35)
        Me.Elimi.TabIndex = 51
        Me.Elimi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimi, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Elimi.UseVisualStyleBackColor = False
        '
        'Regresa
        '
        Me.Regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresa.ForeColor = System.Drawing.Color.Black
        Me.Regresa.Image = CType(resources.GetObject("Regresa.Image"), System.Drawing.Image)
        Me.Regresa.Location = New System.Drawing.Point(840, 96)
        Me.Regresa.Name = "Regresa"
        Me.Regresa.Size = New System.Drawing.Size(35, 35)
        Me.Regresa.TabIndex = 49
        Me.Regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Regresa.UseVisualStyleBackColor = False
        Me.Regresa.Visible = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(792, 96)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 50
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'ESTILOS
        '
        Me.ESTILOS.Location = New System.Drawing.Point(16, 112)
        Me.ESTILOS.MaxLength = 20
        Me.ESTILOS.Name = "ESTILOS"
        Me.ESTILOS.Size = New System.Drawing.Size(168, 21)
        Me.ESTILOS.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.ESTILOS, "Cliente")
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(218, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.CLIENTES)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(944, 64)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'Ingreso_cli_est_col
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.Add(Me.ESTILOS)
        Me.Controls.Add(Me.Elimi)
        Me.Controls.Add(Me.Regresa)
        Me.Controls.Add(Me.Graba)
        Me.Controls.Add(Me.COLORES)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_cli_est_col"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de  Estilos_Colores por Cliente"
        Me.ToolTip1.SetToolTip(Me, "Ingreso de  Estilos_Colores por Cliente")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler ESTILOS.KeyPress, AddressOf keypressed1
        AddHandler COLORES.KeyPress, AddressOf keypressed2
        llena_estilos()
        llena_clientes()
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        CLIENTES.Enabled = True
        ESTILOS.Enabled = False
        COLORES.Enabled = False
        Graba.Visible = False
        Regresa.Visible = False
        Elimi.Visible = False
        COLORES.Items.Clear()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 4
        fg.Cols(0).Width = 5
        fg.Cols(1).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CLIENTE"
        fg.Cols(2).Name = "ESTILO"
        fg.Cols(3).Name = "COLOR"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 275
            fg(0, index) = fg.Cols(index).Name
        Next
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM CLI_EST_COL WHERE CLIENTE = '" & CLIENTES.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            fg.Rows.Count = fg.Rows.Count + 1
            lineas = fg.Rows.Count - 1
            fg(lineas, 0) = Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            fg(lineas, 1) = dr("CLIENTE")
            fg(lineas, 2) = dr("ESTILO")
            fg(lineas, 3) = dr("COLOR")
        Next
    End Sub

    Private Sub llena_estilos()
        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE =  '" & CLIENTES.Text & "' ORDER BY ESTILO"
        llena_combos(ESTILOS, strSQL, "ESTILO")
    End Sub
    Private Sub llena_clientes()
        Dim strSQL As String = "SELECT * FROM CLIENTES ORDER BY CLIENTE"
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            CLIENTES.Items.Add(dr("CLIENTE"))
        Next
        If CLIENTES.Items.Count > 0 Then
            CLIENTES.SelectedIndex = 0
        End If
    End Sub

    Private Sub llena_colores()
        Dim strSQL As String = "SELECT * FROM COLORES WHERE CLIENTE =  '" & CLIENTES.Text & "' AND ACTIVO = 'S' ORDER BY COLOR"
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            COLORES.Items.Add(Trim(dr("COLOR")))
        Next
        If COLORES.Items.Count > 0 Then
            COLORES.SelectedIndex = 0
        End If
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            ESTILOS.SelectedIndex = ESTILOS.Items.IndexOf(Trim(fg(fil, 2)))
            COLORES.SelectedIndex = COLORES.Items.IndexOf(Trim(fg(fil, 3)))
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
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(ESTILOS.Text) <> "" Then
                COLORES.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(COLORES.Text) <> "" Then
                Graba.Focus()
            End If
        End If
    End Sub


    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        If Trim(ESTILOS.Text) <> "" And Trim(COLORES.Text) <> "" Then
            graba_registro()
        End If
    End Sub

    Private Sub agrega_linea()
        Dim lin As Integer = fg.Rows.Count
        fg.Rows.Count = lin + 1
        llena_lineas(lin)
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub elimina_linea()
        Dim lin As Integer
        Dim busca As String = Trim(ESTILOS.Text) + Trim(COLORES.Text)
        lin = fg.FindRow(busca, 1, 0, True)
        If lin > 0 Then
            fg.Rows.Remove(lin)
        End If
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer
        Dim busca As String = Trim(ESTILOS.Text) + Trim(COLORES.Text)
        lin = fg.FindRow(busca, 1, 0, True)
        llena_lineas(lin)
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 0) = Trim(ESTILOS.Text) + Trim(COLORES.Text)
            fg(lineas, 1) = CLIENTES.Text
            fg(lineas, 2) = ESTILOS.Text
            fg(lineas, 3) = COLORES.Text
        Catch
        End Try
    End Sub


    Private Sub Elimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimi.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
        End If
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub CLIENTES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTES.SelectedIndexChanged
        habilita()
        llena_estilos()
        llena_colores()
        setea_grid()
        llena_grid()
        ESTILOS.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
        CLIENTES.Focus()
    End Sub

    Private Sub habilita()
        CLIENTES.Enabled = False
        ESTILOS.Enabled = True
        COLORES.Enabled = True
        Graba.Visible = True
        Elimi.Visible = True
        Regresa.Visible = True
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresa.Click
        ESTILOS.Focus()
    End Sub


    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE CLI_EST_COL SET ESTILO = " & "'" & ESTILOS.Text & "'" & _
                          " , COLOR = " & "'" & COLORES.Text & "'" & _
                          " WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CLI_EST_COL (CLIENTE,ESTILO,COLOR,ESTADO) " & _
                  "VALUES ( '" & CLIENTES.Text & "','" & _
                      ESTILOS.Text & "','" & _
                      COLORES.Text & "','C')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

          

            transaccion.Commit()

            MsgBox("Grabación Exitosa !!!!", MsgBoxStyle.Information, "Actualización de Datos")

            setea_grid()
            llena_grid()
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

    Private Sub elimina()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CLI_EST_COL WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "' AND ESTADO <> 'A'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
         
            elimina_linea()


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


    Private Sub clientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLIENTES.KeyPress
        AutoCompletar(CLIENTES, e)
    End Sub
    Private Sub estilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ESTILOS.KeyPress
        AutoCompletar(Estilos, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COLORES.KeyPress
        AutoCompletar(COLORES, e)
    End Sub
End Class
