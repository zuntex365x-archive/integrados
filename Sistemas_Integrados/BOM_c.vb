Imports C1.Win.C1FlexGrid

Public Class BOM_c
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "0000000000"
    Dim ok As Boolean
    Dim fila As Integer
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents ec As C1.Win.C1FlexGrid.C1FlexGrid
    Dim lineas As Integer
    Dim empre As New empresas
    Dim clave As String
    Dim cliente As String
    Friend WithEvents estil As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents a_estilo As System.Windows.Forms.Label
    Friend WithEvents a_color As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Dim ac As New DataTable
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOM_c))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.a_estilo = New System.Windows.Forms.Label()
        Me.a_color = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ec = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 335)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1047, 335)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(993, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'grupo
        '
        Me.grupo.BackColor = System.Drawing.Color.White
        Me.grupo.Controls.Add(Me.PictureBox1)
        Me.grupo.Controls.Add(Me.a_estilo)
        Me.grupo.Controls.Add(Me.a_color)
        Me.grupo.Controls.Add(Me.Label5)
        Me.grupo.Controls.Add(Me.Label6)
        Me.grupo.Controls.Add(Me.estil)
        Me.grupo.Controls.Add(Me.colo)
        Me.grupo.Controls.Add(Me.Label2)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Controls.Add(Me.Button1)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Black
        Me.grupo.Location = New System.Drawing.Point(8, 246)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(1050, 83)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(437, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'a_estilo
        '
        Me.a_estilo.BackColor = System.Drawing.Color.White
        Me.a_estilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a_estilo.Location = New System.Drawing.Point(689, 16)
        Me.a_estilo.Name = "a_estilo"
        Me.a_estilo.Size = New System.Drawing.Size(232, 24)
        Me.a_estilo.TabIndex = 58
        Me.a_estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'a_color
        '
        Me.a_color.BackColor = System.Drawing.Color.White
        Me.a_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.a_color.Location = New System.Drawing.Point(687, 45)
        Me.a_color.Name = "a_color"
        Me.a_color.Size = New System.Drawing.Size(234, 24)
        Me.a_color.TabIndex = 57
        Me.a_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Khaki
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(537, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Color:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Khaki
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(537, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Estilo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.White
        Me.estil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estil.Location = New System.Drawing.Point(158, 16)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(232, 24)
        Me.estil.TabIndex = 54
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Location = New System.Drawing.Point(156, 45)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(234, 24)
        Me.colo.TabIndex = 53
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 673)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'ec
        '
        Me.ec.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ec.AllowEditing = False
        Me.ec.AllowFiltering = True
        Me.ec.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ec.ColumnInfo = resources.GetString("ec.ColumnInfo")
        Me.ec.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ec.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ec.Location = New System.Drawing.Point(8, 12)
        Me.ec.Name = "ec"
        Me.ec.Rows.DefaultSize = 17
        Me.ec.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ec.Size = New System.Drawing.Size(522, 228)
        Me.ec.StyleInfo = resources.GetString("ec.StyleInfo")
        Me.ec.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.ec, "Area de Datos.")
        '
        'fj
        '
        Me.fj.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fj.AllowEditing = False
        Me.fj.AllowFiltering = True
        Me.fj.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.fj.Location = New System.Drawing.Point(536, 12)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 17
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fj.Size = New System.Drawing.Size(522, 228)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.fj, "Area de Datos.")
        '
        'BOM_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 696)
        Me.Controls.Add(Me.fj)
        Me.Controls.Add(Me.ec)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BOM_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOM"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dd As DataRow()
        clave = empre.clave
        revisa_acceso_usuario(clave, ac)
        dd = ac.Select("CREACION_BOM = 'S'")
        If ac.Rows.Count = 0 Or dd.Length = 0 Then
            MsgBox("Usted no tiene los Derechos Suficientes para Accesar este Programa", MsgBoxStyle.Critical, "ACCESO DENEGADO")
            Close()
        End If
        setea_ec()
        setea_fj()
        Try
            selecciona_ec(1)
        Catch ex As Exception

        End Try
        Try
            selecciona_fj(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub setea_ec()
        ec.Rows.Count = 1
        ec.Rows(0).Height = 30
        ec.Cols(0).Width = 0
        llena_ec()
    End Sub
    Private Sub setea_fj()
        fj.Rows.Count = 1
        fj.Rows(0).Height = 30
        fj.Cols(0).Width = 0
        llena_fj()
    End Sub
    Private Sub llena_ec()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim clientes As String = ""
        Dim todos As Boolean = False
        Dim l As Integer = 1
        For Each dr In ac.Rows
            If dr("CREACION_BOM") = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    clientes = clientes + "'" & dr("CLIENTE") & "',"
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO IN ( 'A','C') ORDER BY CLIENTE,ESTILO,COLOR"
        Else
            If clientes.Length > 0 Then
                clientes = Mid(clientes, 1, clientes.Length - 1)
                strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO IN ( 'A','C')  AND CLIENTE IN (" & clientes & ")"
            End If
        End If
        llena_tablas(dt, strsql, cnn)
        ec.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            ec(l, 1) = dr("CLIENTE")
            ec(l, 2) = dr("ESTILO")
            ec(l, 3) = dr("COLOR")
            l = l + 1
        Next
    End Sub
    Private Sub llena_fj()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim clientes As String = ""
        Dim todos As Boolean = False
        Dim l As Integer = 1
        For Each dr In ac.Rows
            If dr("CREACION_BOM") = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    clientes = clientes + "'" & dr("CLIENTE") & "',"
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO <> 'A' AND (SELECT COUNT (CODIGO) FROM MAT_EST_COL WHERE MAT_EST_COL.ESTILO = CLI_EST_COL.ESTILO  AND MAT_EST_COL.COLOR = CLI_EST_COL.COLOR) = 0 ORDER BY CLIENTE,ESTILO,COLOR"
        Else
            If clientes.Length > 0 Then
                clientes = Mid(clientes, 1, clientes.Length - 1)
                strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO <> 'A' AND (SELECT COUNT (CODIGO) FROM MAT_EST_COL WHERE MAT_EST_COL.ESTILO = CLI_EST_COL.ESTILO  AND MAT_EST_COL.COLOR = CLI_EST_COL.COLOR) = 0 AND CLIENTE IN (" & clientes & ")"
            End If
        End If
        llena_tablas(dt, strsql, cnn)
        fj.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fj(l, 1) = dr("CLIENTE")
            fj(l, 2) = dr("ESTILO")
            fj(l, 3) = dr("COLOR")
            l = l + 1
        Next
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("CODIGO")
            fg(lineas, 4) = dr("DESCRIPCION")
            fg(lineas, 5) = dr("UNIDAD")
            fg(lineas, 6) = True
            lineas = lineas + 1
        Next
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    REM =======================================================================================
    REM =                                                                                     =
    REM =                      GRABACIONES                                                    =
    REM =                                                                                     =
    REM =======================================================================================

    Private Sub graba_registros()
        Dim afectados As Integer
        Dim vitacora As Integer
        Dim strsql As String
        Dim tipo As String = "N"
        Dim obj As New empresas()
        Dim codigo As String
        Dim unidades As Decimal
        Dim i As Integer
        Dim fechas As String = Format(Now, "yyyy-MM-dd hh:mm:ss")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                If fg(i, 6) = True Then
                    codigo = fg(i, 3)
                    unidades = fg(i, 5)
                    '============== actualiza  =======================
                    strsql = "UPDATE MAT_EST_COL SET UNIDAD = " & "'" & unidades & "'" & _
                                    " WHERE ESTILO = '" & a_estilo.Text & "' AND COLOR = '" & a_color.Text & "' AND CODIGO = '" & codigo & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    If afectados > 0 Then
                        strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & a_estilo.Text & "','" & a_color.Text & "','" & codigo & "', GETDATE(),'" & obj.usuario & "','" & unidades & "','M')"
                        comando.CommandText = strsql
                        vitacora = comando.ExecuteNonQuery()
                    End If

                    '=============== Graba nuevos ====================
                    If afectados = 0 Then
                        If Mid(codigo, 1, 2) = "99" Then
                            tipo = "E"
                        Else
                            If Mid(codigo, 9, 2) > "00" Then
                                tipo = "T"
                            End If
                        End If
                        strsql = "INSERT INTO MAT_EST_COL (ESTILO,COLOR,CODIGO,UNIDAD,TIPO) " & _
                                               "VALUES ( '" & a_estilo.Text & "','" & _
                                                   a_color.Text & "','" & _
                                                   codigo & "','" & _
                                                   unidades & "','" & tipo & "')"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & a_estilo.Text & "','" & a_color.Text & "','" & codigo & "',GETDATE(),'" & obj.usuario & "','" & unidades & "','A')"
                        comando.CommandText = strsql
                        vitacora = comando.ExecuteNonQuery()
                    End If
                End If
            Next

            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ec_Click(sender As System.Object, e As System.EventArgs) Handles ec.Click
        Dim f As Integer = ec.RowSel
        selecciona_ec(f)
    End Sub

    Private Sub ec_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ec.KeyDown
        If e.KeyCode = Keys.Up Then
            selecciona_ec(ec.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            selecciona_ec(ec.Row + 1)
        End If
    End Sub
    Private Sub selecciona_ec(ByVal f As Integer)
        If f > 0 Then
            Try
                cliente = ec(f, 1)
                estil.Text = ec(f, 2)
                colo.Text = ec(f, 3)
                setea_grid()
            Catch
            End Try
        End If
    End Sub
    Private Sub selecciona_fj(ByVal f As Integer)
        If f > 0 Then
            Try
                cliente = fj(f, 1)
                a_estilo.Text = fj(f, 2)
                a_color.Text = fj(f, 3)
            Catch
            End Try
        End If
    End Sub
    Private Sub fj_Click(sender As System.Object, e As System.EventArgs) Handles fj.Click
        Dim f As Integer = fj.RowSel
        selecciona_fj(f)
    End Sub

    Private Sub fj_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fj.KeyDown
        If e.KeyCode = Keys.Up Then
            selecciona_fj(fj.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            selecciona_fj(fj.Row + 1)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            seguro = MsgBox("Seguro de Querer Copiar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros()
                nuevo_bom()
            End If
        End If
    End Sub
    Private Sub nuevo_bom()
        setea_fj()
        llena_fj()
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = False
        If Trim(a_estilo.Text) = "" Then
            mensaje("Estilo a Copiar Inválido")
            Exit Sub
        End If
        If Trim(a_color.Text) = "" Then
            mensaje("Color a Copiar Inválido")
            Exit Sub
        End If
        ok = True
    End Sub
End Class
