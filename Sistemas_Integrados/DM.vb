Imports C1.Win.C1FlexGrid

Public Class DM
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
    Dim de As New DataTable
    Friend WithEvents dmc As System.Windows.Forms.TextBox
    Dim tip As New DataTable
    Dim tit As New DataTable
    Dim cod As New DataTable
    Friend WithEvents r0 As System.Windows.Forms.Button
    Friend WithEvents tela As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dl As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents S1 As System.Windows.Forms.Button
    Dim dt As New DataTable

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
    Friend WithEvents borra As System.Windows.Forms.Button
    Friend WithEvents But_graba As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.borra = New System.Windows.Forms.Button()
        Me.But_graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.dmc = New System.Windows.Forms.TextBox()
        Me.r0 = New System.Windows.Forms.Button()
        Me.tela = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dl = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.S1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DM:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'borra
        '
        Me.borra.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.borra.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borra.ForeColor = System.Drawing.Color.Black
        Me.borra.Image = CType(resources.GetObject("borra.Image"), System.Drawing.Image)
        Me.borra.Location = New System.Drawing.Point(723, 9)
        Me.borra.Name = "borra"
        Me.borra.Size = New System.Drawing.Size(60, 40)
        Me.borra.TabIndex = 23
        Me.borra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.borra.UseVisualStyleBackColor = False
        Me.borra.Visible = False
        '
        'But_graba
        '
        Me.But_graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_graba.ForeColor = System.Drawing.Color.Black
        Me.But_graba.Image = CType(resources.GetObject("But_graba.Image"), System.Drawing.Image)
        Me.But_graba.Location = New System.Drawing.Point(789, 8)
        Me.But_graba.Name = "But_graba"
        Me.But_graba.Size = New System.Drawing.Size(60, 40)
        Me.But_graba.TabIndex = 4
        Me.But_graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:1;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:704;Caption:""CLIENTE"";Style:""DataType:S" & _
    "ystem.String;TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 202)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(922, 394)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 89
        '
        'dmc
        '
        Me.dmc.Location = New System.Drawing.Point(176, 20)
        Me.dmc.MaxLength = 10
        Me.dmc.Name = "dmc"
        Me.dmc.Size = New System.Drawing.Size(177, 22)
        Me.dmc.TabIndex = 0
        '
        'r0
        '
        Me.r0.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r0.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r0.ForeColor = System.Drawing.Color.Black
        Me.r0.Image = CType(resources.GetObject("r0.Image"), System.Drawing.Image)
        Me.r0.Location = New System.Drawing.Point(855, 9)
        Me.r0.Name = "r0"
        Me.r0.Size = New System.Drawing.Size(60, 40)
        Me.r0.TabIndex = 5
        Me.r0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r0.UseVisualStyleBackColor = False
        '
        'tela
        '
        Me.tela.BackColor = System.Drawing.Color.White
        Me.tela.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.tela.Location = New System.Drawing.Point(176, 62)
        Me.tela.MaxDropDownItems = 15
        Me.tela.Name = "tela"
        Me.tela.Size = New System.Drawing.Size(177, 24)
        Me.tela.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Código de la Tela:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dl
        '
        Me.dl.BackColor = System.Drawing.Color.White
        Me.dl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dl.Location = New System.Drawing.Point(358, 62)
        Me.dl.Name = "dl"
        Me.dl.Size = New System.Drawing.Size(557, 24)
        Me.dl.TabIndex = 101
        Me.dl.Text = " "
        Me.dl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.cliente.Location = New System.Drawing.Point(168, 33)
        Me.cliente.MaxDropDownItems = 15
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(335, 24)
        Me.cliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.S1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cliente)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 86)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(843, 21)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(60, 40)
        Me.S1.TabIndex = 103
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.S1.UseVisualStyleBackColor = False
        '
        'DM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 608)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dl)
        Me.Controls.Add(Me.tela)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.r0)
        Me.Controls.Add(Me.dmc)
        Me.Controls.Add(Me.borra)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.But_graba)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DM"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de DM"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler dmc.KeyPress, AddressOf keypressed1
        AddHandler tela.KeyPress, AddressOf keypressed2
        AddHandler cliente.KeyPress, AddressOf keypressed5
        llena_combos(cliente, "SELECT CLIENTE FROM CLIENTES WHERE ACTIVO = 'S' ORDER BY CLIENTE", "CLIENTE")
        llena_datatables()
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub llena_datatables()
        llena_tablas(cod, "SELECT * FROM CODIGO_TELA ", cnn)
        llena_combos(tela, "SELECT * FROM CODIGO_TELA", "CODIGO")
        Try
            tela.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        dmc.Enabled = True
        borra.Visible = False
        But_graba.Visible = False
        cliente.Enabled = False
        tela.Enabled = False
        fg.Enabled = False
        dmc.Text = ""
        dmc.Focus()
    End Sub
    Private Sub habilita()
        But_graba.Visible = True
        tela.Enabled = True
        cliente.Enabled = True
        dmc.Enabled = False
        fg.Enabled = True
        tela.Focus()
    End Sub

    Private Sub busca_registro()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM DM WHERE DM = '" & dmc.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            tela.SelectedIndex = tela.Items.IndexOf(dr("CODIGO"))
            borra.Visible = True
        End If
        llena_clientes()
        habilita()
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(dmc.Text) <> "" Then
                busca_registro()
            End If
            cliente.Focus()
        End If
    End Sub 'keypressed

    Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(tela.Text) <> "" Then
                cliente.Focus()
            End If
        End If
    End Sub 'keypressed

    Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub agrega_cliente()
        Dim l As Integer
        l = fg.FindRow(cliente.Text, 1, 1, False)
        If l < 1 Then
            l = fg.Rows.Count
            fg.Rows.Count = l + 1
            fg(l, 1) = cliente.Text
        End If
        cliente.Focus()
    End Sub

    Private Sub But_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borra.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_registros()
            limpia_variables()
        End If
    End Sub
    Private Sub llena_clientes()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        setea_grid()
        llena_tablas(dt, "SELECT * FROM DM_CLIENTE WHERE DM = '" & dmc.Text & "'", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            l = l + 1
        Next
    End Sub

    '=====================================================================================
    '                                  DETALLE
    '=====================================================================================
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
    End Sub
    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        llena_tablas(dt, "SELECT * FROM DM ORDER BY DM", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("DM")
            fg(l, 2) = dr("CODIGO")
            fg(l, 3) = dr("CLIENTE")
            l = l + 1
        Next
    End Sub


    Private Sub But_graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_graba.Click
        If fg.Rows.Count > 0 Then
            graba_registros()
        Else
            MsgBox("Debe de ingresar al menos un cliente", MsgBoxStyle.Critical, "No ha ingresado Clientes")
        End If
    End Sub
    ' ==================================================================================================
    '                                      ACTUALIZA BASE DE DATOS                                    ==
    ' ==================================================================================================
    Private Sub graba_registros()
        Dim empre As New empresas
        cnn.ConnectionString = empre.constr
        Dim i As Integer

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
            '========== Actualiza Maestro ===========
            strSQL = "DELETE DM_CLIENTE WHERE DM = '" & dmc.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            strSQL = "UPDATE DM SET CODIGO = '" & tela.Text & "' , CREADO = '" & obj.usuario & "', FECHA = GETDATE()  WHERE DM = '" & dmc.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strSQL = "INSERT INTO DM (DM,CODIGO,CLIENTE,CREADO,FECHA) " & _
                            "VALUES ( '" & dmc.Text & "','" & tela.Text & "','" & fg(1, 1) & "','" & obj.usuario & "',GETDATE())"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            End If
            For i = 1 To fg.Rows.Count - 1
                strSQL = "INSERT INTO DM_CLIENTE (DM,CLIENTE) " & _
                            "VALUES ( '" & dmc.Text & "','" & fg(i, 1) & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()
            limpia_variables()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor revise a Jesús Acosta !!!!")
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
    '                                      BORRA DATOS                                                ==
    ' ==================================================================================================
    Private Sub elimina_registros()
        Dim empre As New empresas
        cnn.ConnectionString = empre.constr

        Dim afectados As Integer
        Dim strSQL As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '========== Actualiza Maestro ===========

            strSQL = "DELETE DM_CLIENTE WHERE DM = '" & dmc.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            strSQL = "DELETE DM WHERE DM = '" & dmc.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            limpia_variables()
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

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.DoubleClick
        Dim seguro As MsgBoxResult
        Dim l As Integer = fg.RowSel
        If l > 0 Then
            seguro = MsgBox("Seguro de Querer Eliminar el Cliente?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                fg.Rows.Remove(l)
            End If
        End If
    End Sub
    Private Sub tela_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tela.KeyPress
        AutoCompletar(tela, e)
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub r0_Click(sender As System.Object, e As System.EventArgs) Handles r0.Click
        limpia_variables()
    End Sub

    Private Sub tela_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tela.SelectedIndexChanged
        busca_descripciones1(cod, "CODIGO", "DESCRIPCION", tela.Text, dl.Text)
    End Sub

    Private Sub S1_Click(sender As System.Object, e As System.EventArgs) Handles S1.Click
        agrega_cliente()
    End Sub
End Class

