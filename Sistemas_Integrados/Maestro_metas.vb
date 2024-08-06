Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Maestro_metas
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents meta As C1.Win.C1Input.C1TextBox
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents seccion As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maestro_metas))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.seccion = New System.Windows.Forms.ComboBox()
        Me.regresa = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        Me.Elimina = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.meta = New C1.Win.C1Input.C1TextBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AutoGenerateColumns = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 131)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 20
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 533)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'seccion
        '
        Me.seccion.ItemHeight = 16
        Me.seccion.Location = New System.Drawing.Point(176, 8)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(194, 24)
        Me.seccion.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.seccion, "Facturar por medio de Texsun?")
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(936, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 10
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(870, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 5
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Graba y Actualiza registros.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'Elimina
        '
        Me.Elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina.ForeColor = System.Drawing.Color.Black
        Me.Elimina.Image = CType(resources.GetObject("Elimina.Image"), System.Drawing.Image)
        Me.Elimina.Location = New System.Drawing.Point(804, 8)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(60, 40)
        Me.Elimina.TabIndex = 94
        Me.Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina, "Elimina Registros")
        Me.Elimina.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sección:"
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
        Me.Label3.Location = New System.Drawing.Point(16, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Fecha Inicial:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Meta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha_inicial
        '
        Me.fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_inicial.Location = New System.Drawing.Point(176, 38)
        Me.fecha_inicial.Name = "fecha_inicial"
        Me.fecha_inicial.Size = New System.Drawing.Size(171, 22)
        Me.fecha_inicial.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 24)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Fecha Final:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha_final
        '
        Me.fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_final.Location = New System.Drawing.Point(176, 65)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(171, 22)
        Me.fecha_final.TabIndex = 3
        '
        'meta
        '
        Me.meta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meta.CustomFormat = "##,##0"
        Me.meta.DataType = GetType(Decimal)
        Me.meta.DisplayFormat.CustomFormat = "####0"
        Me.meta.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.meta.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.meta.DisplayFormat.NullText = "0"
        Me.meta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meta.Location = New System.Drawing.Point(176, 91)
        Me.meta.MaxLength = 5
        Me.meta.Name = "meta"
        Me.meta.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.meta.ParseInfo.CustomFormat = "####0"
        Me.meta.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.meta.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
                    Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.meta.PostValidation.ErrorMessage = "Por favor ingrese un valor entre 100 y 99,999"
        Me.meta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.meta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {100, 0, 0, 0}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.meta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.meta.Size = New System.Drawing.Size(171, 24)
        Me.meta.TabIndex = 4
        Me.meta.Tag = Nothing
        Me.meta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.meta.TrimStart = True
        Me.meta.Value = New Decimal(New Integer() {800, 0, 0, 0})
        Me.meta.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Maestro_metas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.meta)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.fecha_final)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fecha_inicial)
        Me.Controls.Add(Me.seccion)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Maestro_metas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Metas x Seccion"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tipos_cobro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler seccion.KeyPress, AddressOf keypressed1
        AddHandler fecha_inicial.KeyPress, AddressOf keypressed2
        AddHandler fecha_final.KeyPress, AddressOf keypressed3
        AddHandler meta.KeyPress, AddressOf keypressed4
        llena_combos(seccion, "SELECT SECCION FROM SECCIONES WHERE ACTIVA = 'S'", "SECCION")
        Try
            seccion.SelectedIndex = 0
        Catch ex As Exception
        End Try
        setea_fg()
        seccion.SelectedIndex = 0
    End Sub
    Private Sub limpia_variables()
        meta.Enabled = True
        meta.Text = "1000"
        fecha_inicial.Value = Today
        fecha_final.Value = Today
        seccion.Enabled = True
        fecha_inicial.Enabled = True
        fecha_final.Enabled = False
        meta.Enabled = False
        Elimina.Visible = False
        graba.Visible = False
        seccion.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows(0).Height = 30
        limpia_variables()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        llena_tablas(dt, "SELECT * FROM SECCIONES_META WHERE SECCION = '" & seccion.Text & "'", cnn)
        fg.DataSource = dt
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub
    Private Sub fg_canbia_linea(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.KeyPress
        selecciona_registro()
    End Sub
    Private Sub selecciona_registro()
        Dim i As Integer = fg.RowSel
        Dim ok As Boolean
        If i > 0 Then
            seccion.Text = fg(i, 1)
            fecha_inicial.Value = fg(i, 2)
            busca_seccion(ok)
            habilita()
        End If
    End Sub

    Private Sub busca_seccion(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM SECCIONES_META WHERE SECCION = '" & seccion.Text & "' AND FECHA_INICIAL = '" & Format(fecha_inicial.Value, "yyyy-MM-dd") & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            fecha_final.Value = dr("FECHA_FINAL")
            meta.Enabled = True
            meta.Text = dr("META")
            ok = True
            Elimina.Visible = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita()
        seccion.Enabled = False
        fecha_inicial.Enabled = False
        fecha_final.Enabled = True
        meta.Enabled = True
        graba.Visible = True
        regresa.Visible = True
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion.Text) <> "" Then
                fecha_inicial.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha_inicial.Text) <> "" Then
                busca_seccion(ok)
                habilita()
                fecha_final.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha_final.Text) <> "" Then
                meta.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(meta.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = True
        Dim sal As Integer
        If Format(fecha_final.Value, "yyyy-MM-dd") < Format(fecha_inicial.Value, "yyyy-MM-dd") Then
            MsgBox("La Fecha Final no puede ser mayor a la Fecha Inicial válida.", MsgBoxStyle.Critical, "Error en Fechas !!!!")
            ok = False
            Exit Sub
        End If
        Try
            sal = CDec(meta.Text)
        Catch
            meta.Text = "0"
        End Try
        'If sal = 0 Then
        '    ok = False
        '    MsgBox("Antes de Grabar debe ingresar una meta válida.", MsgBoxStyle.Critical, "Por favor revise !!!!")
        'End If
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
        Dim finicial As String = Format(fecha_inicial.Value, "yyyy-MM-dd")
        Dim ffinal As String = Format(fecha_final.Value, "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SECCIONES_META SET FECHA_FINAL = '" & ffinal & "', " & _
                                                     "META = '" & meta.Text & "' " & _
                                           " WHERE SECCION = '" & seccion.Text & "' AND FECHA_INICIAL = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SECCIONES_META (SECCION,FECHA_INICIAL,FECHA_FINAL,META) VALUES ('" & _
                                                    seccion.Text & "','" & _
                                                    finicial & "','" & _
                                                    ffinal & "','" &
                                                    meta.Text & "')"
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
        seccion.Focus()
    End Sub

    Private Sub seccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles seccion.KeyPress
        AutoCompletar(seccion, e)
    End Sub

    Private Sub seccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seccion.SelectedIndexChanged
        llena_fg()
    End Sub

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        setea_fg()
    End Sub


    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha_inicial.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SECCIONES_META WHERE SECCION = '" & seccion.Text & "' AND FECHA_INICIAL = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
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
End Class

