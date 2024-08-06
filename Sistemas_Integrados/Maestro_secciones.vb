Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Maestro_secciones
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents activa As System.Windows.Forms.ComboBox
    Dim dr As DataRow
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents seccion As System.Windows.Forms.TextBox
    Friend WithEvents supervisor As System.Windows.Forms.TextBox
    Friend WithEvents meta As System.Windows.Forms.TextBox
    Friend WithEvents facturar As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maestro_secciones))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.seccion = New System.Windows.Forms.TextBox()
        Me.graba = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.supervisor = New System.Windows.Forms.TextBox()
        Me.meta = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.facturar = New System.Windows.Forms.ComboBox()
        Me.activa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'seccion
        '
        Me.seccion.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccion.Location = New System.Drawing.Point(152, 8)
        Me.seccion.MaxLength = 15
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(231, 24)
        Me.seccion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.seccion, "Sección")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(872, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 6
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Graba y Actualiza registros.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(938, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 67
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'supervisor
        '
        Me.supervisor.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supervisor.Location = New System.Drawing.Point(152, 32)
        Me.supervisor.MaxLength = 30
        Me.supervisor.Name = "supervisor"
        Me.supervisor.Size = New System.Drawing.Size(520, 24)
        Me.supervisor.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.supervisor, "Nombre del Supervisor")
        '
        'meta
        '
        Me.meta.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meta.Location = New System.Drawing.Point(152, 56)
        Me.meta.MaxLength = 10
        Me.meta.Name = "meta"
        Me.meta.Size = New System.Drawing.Size(152, 24)
        Me.meta.TabIndex = 3
        Me.meta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.meta, "Prendas por día.")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 131)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 533)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'facturar
        '
        Me.facturar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.facturar.ItemHeight = 16
        Me.facturar.Items.AddRange(New Object() {"S", "N"})
        Me.facturar.Location = New System.Drawing.Point(152, 80)
        Me.facturar.Name = "facturar"
        Me.facturar.Size = New System.Drawing.Size(48, 24)
        Me.facturar.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.facturar, "Facturar por medio de Texsun?")
        '
        'activa
        '
        Me.activa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.activa.ItemHeight = 16
        Me.activa.Items.AddRange(New Object() {"S", "N"})
        Me.activa.Location = New System.Drawing.Point(152, 104)
        Me.activa.Name = "activa"
        Me.activa.Size = New System.Drawing.Size(48, 24)
        Me.activa.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.activa, "El registro está activo?")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sección"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 672)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Para Seleccionar un Registro  presione doble click en el Mouse."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Supervisor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Meta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Facturar:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 24)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Activa:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Maestro_secciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.activa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.facturar)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.meta)
        Me.Controls.Add(Me.supervisor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.seccion)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Maestro_secciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Secciones"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Tipos_cobro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler seccion.KeyPress, AddressOf keypressed1
        AddHandler supervisor.KeyPress, AddressOf keypressed2
        AddHandler meta.KeyPress, AddressOf keypressed3
        AddHandler facturar.KeyPress, AddressOf keypressed4
        AddHandler activa.KeyPress, AddressOf keypressed5
        setea_fg()
    End Sub
    Private Sub limpia_variables()
        seccion.Text = ""
        supervisor.Text = ""
        meta.Text = "2000"
        facturar.SelectedIndex = 0
        activa.SelectedIndex = 0
        seccion.Enabled = True
        supervisor.Enabled = False
        meta.Enabled = False
        facturar.Enabled = False
        activa.Enabled = False
        graba.Visible = False
        seccion.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        limpia_variables()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        Dim l As Integer
        llena_tablas(dt, "SELECT * FROM SECCIONES ORDER BY SECCION", cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("SECCION")
            fg(l, 2) = dr("SUPERVISOR")
            fg(l, 3) = dr("META")
            fg(l, 4) = dr("FACTURAR")
            fg(l, 5) = dr("ACTIVA")
            l = l + 1
        Next
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub
    Private Sub selecciona_registro()
        Dim i As Integer = fg.RowSel
        Dim ok As Boolean
        seccion.Text = fg(i, 1)
        busca_seccion(ok)
        habilita()
    End Sub

    Private Sub busca_seccion(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM SECCIONES WHERE SECCION = '" & seccion.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            supervisor.Text = dr("SUPERVISOR")
            meta.Text = dr("META")
            facturar.SelectedItem = dr("FACTURAR")
            activa.SelectedItem = dr("ACTIVA")
            ok = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita()
        seccion.Enabled = False
        supervisor.Enabled = True
        meta.Enabled = True
        facturar.Enabled = True
        activa.Enabled = True
        graba.Visible = True
        regresa.Visible = True
        supervisor.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion.Text) <> "" Then
                busca_seccion(ok)
                habilita()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(supervisor.Text) <> "" Then
                meta.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(meta.Text) <> "" Then
                facturar.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(facturar.Text) <> "" Then
                activa.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(activa.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim sal As Decimal
        If (Trim(supervisor.Text) = "") Or (Trim(meta.Text) = "") Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar todos los datos solicitados", MsgBoxStyle.Critical, "Por favor revise !!!!")
        Else
            ok = True
        End If
        Try
            sal = CDec(meta.Text)
        Catch
        End Try
        If sal = 0 Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar una meta válida.", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
        seccion.Text = UCase(seccion.Text)
        supervisor.Text = UCase(supervisor.Text)
        Me.Refresh()
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            setea_fg()
        End If
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SECCIONES SET SUPERVISOR = '" & supervisor.Text & "', " & _
                                          "META = '" & meta.Text & "', " & _
                                          "FACTURAR = '" & facturar.Text & "', " & _
                                          "ACTIVA = '" & activa.Text & "' WHERE SECCION = '" & seccion.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SECCIONES (SECCION,FACTURAR,SUPERVISOR,META,ACTIVA) VALUES ('" & _
                                                    seccion.Text & "','" & _
                                                    facturar.Text & "','" & _
                                                    supervisor.Text & "','" &
                                                    meta.Text & "','" & _
                                                    facturar.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_fg()
    End Sub
End Class

