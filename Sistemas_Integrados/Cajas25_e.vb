Imports C1.Win.C1FlexGrid

Public Class Cajas25_e
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable
    Dim co As New DataTable
    Dim pp As New DataTable
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Dim dr As DataRow
    Dim tp As New DataTable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents escala As System.Windows.Forms.Label
    Dim dj As DataRow
    Dim ta As String = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents upc As C1.Win.C1FlexGrid.C1FlexGrid
    Dim ts(10) As String
    Dim dato As String
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents colores As System.Windows.Forms.ComboBox
    Dim cl As New DataTable
    Friend WithEvents E1 As Button
    Dim obj As New empresas
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajas25_e))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.colores = New System.Windows.Forms.ComboBox()
        Me.graba = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.escala = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.upc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.E1 = New System.Windows.Forms.Button()
        CType(Me.upc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.cliente.Location = New System.Drawing.Point(201, 21)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(222, 28)
        Me.cliente.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cliente, "No. Embarque")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(909, 19)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 1
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Chequeo de Datos")
        Me.si.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(977, 19)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 104
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" &
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.estilo.Location = New System.Drawing.Point(201, 58)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(429, 28)
        Me.estilo.TabIndex = 131
        Me.ToolTip1.SetToolTip(Me.estilo, "No. Embarque")
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.colores.Location = New System.Drawing.Point(201, 96)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(429, 28)
        Me.colores.TabIndex = 132
        Me.ToolTip1.SetToolTip(Me.colores, "No. Embarque")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(909, 19)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 9
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 32)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 32)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Combinación:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 32)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Estilo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 32)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Color:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 32)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Escala:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'escala
        '
        Me.escala.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.escala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.escala.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.escala.Location = New System.Drawing.Point(202, 131)
        Me.escala.Name = "escala"
        Me.escala.Size = New System.Drawing.Size(92, 32)
        Me.escala.TabIndex = 111
        Me.escala.Text = " "
        Me.escala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'codigo
        '
        Me.codigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.codigo.Location = New System.Drawing.Point(201, 171)
        Me.codigo.MaxLength = 15
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(429, 26)
        Me.codigo.TabIndex = 129
        '
        'upc
        '
        Me.upc.AllowFiltering = True
        Me.upc.AutoClipboard = True
        Me.upc.ColumnInfo = resources.GetString("upc.ColumnInfo")
        Me.upc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.upc.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.upc.Location = New System.Drawing.Point(7, 231)
        Me.upc.Name = "upc"
        Me.upc.Rows.DefaultSize = 21
        Me.upc.Size = New System.Drawing.Size(1124, 92)
        Me.upc.StyleInfo = resources.GetString("upc.StyleInfo")
        Me.upc.TabIndex = 130
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.Black
        Me.E1.Image = CType(resources.GetObject("E1.Image"), System.Drawing.Image)
        Me.E1.Location = New System.Drawing.Point(1045, 19)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(60, 40)
        Me.E1.TabIndex = 133
        Me.E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E1, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.E1.UseVisualStyleBackColor = False
        '
        'Cajas25_e
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1139, 471)
        Me.Controls.Add(Me.E1)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.upc)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.escala)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cajas25_e"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresa UPC"
        CType(Me.upc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Cajas05_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        upc.DragMode = DragModeEnum.AutomaticCopy
        upc.DropMode = DropModeEnum.Automatic
        llena_clientes_cpo(cliente)
        ts = ta.Split("|")
        limpia_variables()
    End Sub
    Private Sub limpia_variables()
        setea_grid()
        cliente.Enabled = True
        estilo.Enabled = True
        colores.Enabled = True
        upc.Enabled = False
        E1.Visible = False
        escala.Text = ""
        codigo.Text = ""
        si.Visible = True
        graba.Visible = False
        codigo.Enabled = False
        cliente.Focus()
    End Sub
    Private Sub habilita()
        si.Visible = False
        graba.Visible = True
        cliente.Enabled = False
        estilo.Enabled = False
        colores.Enabled = False
        codigo.Enabled = True
        upc.Enabled = True
        E1.Visible = True
    End Sub
    Private Sub setea_grid()
        upc.Rows.Count = 1
        upc.Rows.Count = 2
        upc.Rows(0).Height = 30
        upc.Rows(1).Height = 30
    End Sub
    Private Sub si_Click(sender As System.Object, e As System.EventArgs) Handles si.Click
        If Trim(cliente.Text) <> "" And Trim(estilo.Text) <> "" And Trim(colores.Text) <> "" Then
            llena_corte()
        Else
            MsgBox("Datos Inconsistentes por favor revise !!!", MsgBoxStyle.Critical, "Revisar Datos.")
        End If

    End Sub

    Private Sub llena_corte()
        Dim i As Integer
        Dim strsql As String = "SELECT CPO.CLIENTE,E_TALLAS.*,UPC.* FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA LEFT JOIN UPC ON CPO_D.ESTILO = UPC.ESTILO AND CPO_D.COLOR = UPC.COLOR AND CPO.CLIENTE = UPC.CLIENTE WHERE CPO.CLIENTE = '" & cliente.Text & "' AND CPO_D.ESTILO = '" & estilo.Text & "' AND CPO_D.COLOR = '" & colores.Text & "'"
        llena_tablas(co, strsql, cnn)
        If co.Rows.Count > 0 Then
            dr = co.Rows(0)
            dj = dr
            escala.Text = dr("ESCALA")
            Try
                codigo.Text = dr("CODIGO")
            Catch
                codigo.Text = ""
            End Try

            For i = 1 To 10
                If escala.Text = "00" Then
                    dj(i + 1) = ts(i)
                End If
                upc(0, i) = ts(i)
                upc(1, i) = dj(i + 17)
            Next
        End If
        habilita()
    End Sub
    Private Sub revisa_cliente_usuario(ByVal cliente As String, ByRef ok As Boolean)
        Dim dd As DataRow()
        dd = cl.Select("CLIENTE = '" & cliente & "'")
        If dd.Length > 0 Then
            ok = True
        Else
            ok = False
        End If
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_datos()
            limpia_variables()
        End If
    End Sub


    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        limpia_variables()
        cliente.Focus()
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles upc.KeyDown
        Dim tarr() As String
        tarr = Clipboard.GetText().Split(Environment.NewLine)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.Insert, Keys.C
                    'copy
                    'System.Windows.Forms.Clipboard.SetDataObject(fg.Clip, True)
                    dato = upc(upc.RowSel, upc.ColSel)
                    Exit Select
                Case Keys.V 'paste
                    Dim rg As CellRange = upc.Selection
                    If dato <> "" Then
                        rg.Data = tarr
                    End If
            End Select
        End If
    End Sub
    '============================= Actualiza la Base de Datos =============================
    Private Sub graba_datos()
        Dim afectados As Integer
        Dim strsql As String
        Dim obj As New empresas()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            '============== actualiza  =======================
            strsql = "UPDATE UPC SET T1 ='" & upc(1, 1) & "', T2 = '" & upc(1, 2) & "', T3 ='" & upc(1, 3) & "', T4 ='" & upc(1, 4) & "', T5 ='" & upc(1, 5) & "', T6 = '" & upc(1, 6) & "', T7 ='" & upc(1, 7) & "', T8 ='" & upc(1, 8) & "', T9 ='" & upc(1, 9) & "', T0 = '" & upc(1, 10) & "', CODIGO = '" & codigo.Text & "' " &
                            " WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO UPC (CLIENTE,ESTILO,COLOR,CODIGO,ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0,USUARIO,FECHA) VALUES ('" &
                          cliente.Text & "','" &
                          estilo.Text & "','" &
                          colores.Text & "','" &
                          codigo.Text & "','" &
                          escala.Text & "','" &
                          upc(1, 1) & "','" &
                          upc(1, 2) & "','" &
                          upc(1, 3) & "','" &
                          upc(1, 4) & "','" &
                          upc(1, 5) & "','" &
                          upc(1, 6) & "','" &
                          upc(1, 7) & "','" &
                          upc(1, 8) & "','" &
                          upc(1, 9) & "','" &
                          upc(1, 10) & "','" &
                          obj.usuario & "',GETDATE() )"
                comando.CommandText = strsql
                comando.ExecuteNonQuery()
            End If
            transaccion.Commit()
            MsgBox("Actualización Exitosa.", MsgBoxStyle.Exclamation, "Datos Actualizados.")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub
    '============================= Elimina datos =====================================
    Private Sub elimina_upc()
        Dim afectados As Integer
        Dim strsql As String
        Dim obj As New empresas()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            '============== actualiza  =======================
            strsql = "DELETE UPC WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            MsgBox("Eliminacion Exitosa.", MsgBoxStyle.Exclamation, "Datos Actualizados.")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(estilo, "SELECT DISTINCT ESTILO FROM CLI_EST_COL WHERE CLIENTE = '" & cliente.Text & "' AND ESTADO = 'A'", "ESTILO")
    End Sub

    Private Sub estilo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles estilo.SelectedIndexChanged
        llena_combos(colores, "SELECT COLOR FROM CLI_EST_COL WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "' AND ESTADO = 'A' ORDER BY COLOR", "COLOR")
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub estilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estilo.KeyPress
        AutoCompletar(estilo, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colores.KeyPress
        AutoCompletar(colores, e)
    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean
        seguro = MsgBox("Esta COMPLETAMENTE SEGURO DE QUERER ELIMINAR EL UPC?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_upc()
            limpia_variables()
        End If
    End Sub
End Class

