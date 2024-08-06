Imports C1.Win.C1FlexGrid
Imports System.Net.Mail
Imports System.IO

Public Class BOM_R
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "0000000000"
    Dim ok As Boolean
    Dim CODIGO As String
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim dt As New DataTable()
    Dim mt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim empre As New empresas
    Dim clave As String
    Dim cliente As String
    Dim indice As Integer = 1
    Friend WithEvents estil As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clientes As System.Windows.Forms.ComboBox
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents colores As System.Windows.Forms.ComboBox
    Dim ac As New DataTable
    Dim cl As New DataTable
    Dim indx As String = ""
    Dim indx1 As String = ""
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
    Friend WithEvents bueno As System.Windows.Forms.Button
    Friend WithEvents malo As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grupo As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOM_R))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bueno = New System.Windows.Forms.Button()
        Me.malo = New System.Windows.Forms.Button()
        Me.grupo = New System.Windows.Forms.GroupBox()
        Me.estil = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clientes = New System.Windows.Forms.ComboBox()
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.colores = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 244)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(968, 426)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'bueno
        '
        Me.bueno.BackColor = System.Drawing.Color.White
        Me.bueno.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bueno.ForeColor = System.Drawing.Color.Black
        Me.bueno.Image = CType(resources.GetObject("bueno.Image"), System.Drawing.Image)
        Me.bueno.Location = New System.Drawing.Point(771, 19)
        Me.bueno.Name = "bueno"
        Me.bueno.Size = New System.Drawing.Size(80, 69)
        Me.bueno.TabIndex = 21
        Me.bueno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.bueno, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.bueno.UseVisualStyleBackColor = False
        '
        'malo
        '
        Me.malo.BackColor = System.Drawing.Color.White
        Me.malo.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.malo.ForeColor = System.Drawing.Color.Black
        Me.malo.Image = CType(resources.GetObject("malo.Image"), System.Drawing.Image)
        Me.malo.Location = New System.Drawing.Point(857, 19)
        Me.malo.Name = "malo"
        Me.malo.Size = New System.Drawing.Size(80, 69)
        Me.malo.TabIndex = 19
        Me.malo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.malo, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.malo.UseVisualStyleBackColor = False
        '
        'grupo
        '
        Me.grupo.BackColor = System.Drawing.Color.White
        Me.grupo.Controls.Add(Me.estil)
        Me.grupo.Controls.Add(Me.colo)
        Me.grupo.Controls.Add(Me.Label2)
        Me.grupo.Controls.Add(Me.Label3)
        Me.grupo.Controls.Add(Me.bueno)
        Me.grupo.Controls.Add(Me.malo)
        Me.grupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.ForeColor = System.Drawing.Color.Black
        Me.grupo.Location = New System.Drawing.Point(8, 135)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(968, 103)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.White
        Me.estil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estil.Location = New System.Drawing.Point(169, 27)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(232, 24)
        Me.estil.TabIndex = 54
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Location = New System.Drawing.Point(167, 56)
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
        Me.Label2.Location = New System.Drawing.Point(17, 56)
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
        Me.Label3.Location = New System.Drawing.Point(17, 27)
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
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(902, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 56
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Despliega Specs del Estilo")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Estilo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 24)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Color:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.Color.White
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.FormattingEnabled = True
        Me.clientes.Location = New System.Drawing.Point(200, 19)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(317, 28)
        Me.clientes.TabIndex = 60
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.FormattingEnabled = True
        Me.estilo.Location = New System.Drawing.Point(200, 57)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(317, 28)
        Me.estilo.TabIndex = 61
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.FormattingEnabled = True
        Me.colores.Location = New System.Drawing.Point(200, 92)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(317, 28)
        Me.colores.TabIndex = 62
        '
        'BOM_R
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 696)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BOM_R"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revisión del BOM"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler clientes.KeyPress, AddressOf keypressed1
        AddHandler estilo.KeyPress, AddressOf keypressed2
        AddHandler colores.KeyPress, AddressOf keypressed3
        Dim dd As DataRow()
        clave = empre.clave
        revisa_acceso_usuario(clave, ac)
        dd = ac.Select("REVISION_BOM = 'S'")
        If ac.Rows.Count = 0 Or dd.Length = 0 Then
            MsgBox("Usted no tiene los Derechos Suficientes para Accesar este Programa", MsgBoxStyle.Critical, "ACCESO DENEGADO")
            Close()
        End If
        llena_tablas(mt, "SELECT * FROM MATERIALES WHERE ACTIVO = 'S'", cnn)
        llena_clientes()
    End Sub
    Private Sub llena_clientes()
        Dim dr As DataRow
        Dim strsql As String = ""
        Dim client As String = ""
        Dim todos As Boolean = False
        Dim cli As String
        Dim x As Integer
        For Each dr In ac.Rows
            If dr("REVISION_BOM") = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    client = client + "'" & dr("CLIENTE") & "',"
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'C' AND (SELECT COUNT(CODIGO) FROM MAT_EST_COL WHERE CLI_EST_COL.ESTILO = MAT_EST_COL.ESTILO AND COLOR = MAT_EST_COL.COLOR)> 0 ORDER BY CLIENTE,ESTILO,COLOR"
        Else
            If client.Length > 0 Then
                client = Mid(client, 1, client.Length - 1)
                strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'C' AND CLIENTE IN (" & client & ") AND (SELECT COUNT(CODIGO) FROM MAT_EST_COL WHERE CLI_EST_COL.ESTILO = MAT_EST_COL.ESTILO AND COLOR = MAT_EST_COL.COLOR)> 0"
            End If
        End If
        llena_tablas(cl, strsql, cnn)
        clientes.Items.Clear()
        For Each dr In cl.Rows
            cli = dr("CLIENTE")
            x = clientes.Items.IndexOf(cli)
            If x = -1 Then
                clientes.Items.Add(cli)
            End If
        Next
        If indx <> "" Then
            Try
                x = clientes.Items.IndexOf(indx)
                clientes.SelectedIndex = x
            Catch
                If clientes.Items.Count > 0 Then
                    clientes.SelectedIndex = 0
                End If
            End Try

        Else
            If clientes.Items.Count > 0 Then
                clientes.SelectedIndex = 0
            End If
        End If
        estilo.Focus()
    End Sub
    Private Sub llena_estilos()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim est As String
        Dim x As Integer
        dd = cl.Select("CLIENTE = '" & clientes.Text & "'")
        estilo.Items.Clear()
        For Each dr In dd
            est = dr("ESTILO")
            x = estilo.Items.IndexOf(est)
            If x = -1 Then
                estilo.Items.Add(est)
            End If
        Next
        If indx1 <> "" Then
            Try
                x = estilo.Items.IndexOf(indx1)
                estilo.SelectedIndex = x
            Catch
                If estilo.Items.Count > 0 Then
                    estilo.SelectedIndex = 0
                End If
            End Try
        Else
            If estilo.Items.Count > 0 Then
                estilo.SelectedIndex = 0
            End If
        End If
       
    End Sub
    Private Sub llena_colores()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim col As String
        Dim x As Integer
        dd = cl.Select("CLIENTE = '" & clientes.Text & "' AND ESTILO = '" & estilo.Text & "'")
        colores.Items.Clear()
        For Each dr In dd
            col = dr("COLOR")
            x = estilo.Items.IndexOf(col)
            If x = -1 Then
                colores.Items.Add(col)
            End If
        Next
        If colores.Items.Count > 0 Then
            colores.SelectedIndex = 0
        End If
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 6
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("CODIGO")
            fg(lineas, 4) = dr("DESCRIPCION")
            fg(lineas, 5) = dr("UNIDAD")
            lineas = lineas + 1
        Next
        seleccion(1)
        estil.Text = estilo.Text
        colo.Text = colores.Text
    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub bueno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bueno.Click
        Dim seguro As MsgBoxResult
        If Trim(Estilos.Text) <> "" And Trim(colo.Text) <> "" Then
            seguro = MsgBox("Seguro de haber revisado el BOM?  ", MsgBoxStyle.YesNo, "Actualizar el Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros("S")
                sigue()
                llena_clientes()
            End If
        End If
    End Sub

    Private Sub malo_Click(sender As System.Object, e As System.EventArgs) Handles malo.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Rechazar el BOM?  ", MsgBoxStyle.YesNo, "Actualizar el Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_registros("N")
            sigue()
            llena_clientes()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        Dim dato As String
        If fil > 0 And fil < fg.Rows.Count Then
            dato = fg(fil, 3)
        End If
    End Sub
    Private Sub sigue()
        indx = clientes.Text
        indx1 = estilo.Text
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
            If Trim(clientes.Text) <> "" Then
                estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(estilo.Text) <> "" Then
                colores.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colores.Text) <> "" Then
                bueno.Focus()
            End If
        End If
    End Sub

    REM =======================================================================================
    REM =                                                                                     =
    REM =                      GRABACIONES                                                    =
    REM =                                                                                     =
    REM =======================================================================================

    Private Sub graba_registros(ByVal aprobado As String)
        Dim afectados As Integer
        Dim vitacora As Integer
        Dim strsql As String
        Dim tipo As String = "R"
        Dim obj As New empresas()
        Dim fechas As String = Format(Now, "yyyy-MM-dd hh:mm:ss")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        If aprobado = "N" Then
            tipo = "S"
        End If

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '============== actualiza  =======================
            For i = 1 To fg.Rows.Count - 1
                strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & estil.Text & "','" & colo.Text & "','" & fg(i, 3) & "',GETDATE(),'" & obj.usuario & "','" & fg(i, 5) & "','" & tipo & "')"
                comando.CommandText = strsql
                vitacora = comando.ExecuteNonQuery()
            Next

            If aprobado = "S" Then
                strsql = "UPDATE CLI_EST_COL SET ESTADO = 'R' WHERE CLIENTE = '" & clientes.Text & "' AND ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

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


    Private Sub envia_correo()
        Dim cliente As String = clientes.Text
        Dim asunto As String
        Dim mensaje As String
        Dim path As String = "c:\reportes\" & Format(Today, "yyyMMddHHmmss")
        asunto = "Revisión Cliente: " & cliente & ", Estilo: " & estil.Text & ", Color:" & colo.Text
        mensaje = "Revision:" + vbLf + vbLf
        For i = 1 To fg.Rows.Count - 1
            mensaje = mensaje + fg(i, 3) + vbTab + fg(i, 4) + vbTab + Format(fg(i, 5), "###,##0.0000") + vbLf
        Next
        mensaje = mensaje + vbLf + vbLf + vbLf + "Revisado por: " + empre.usuario
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells + FileFlags.VisibleOnly)
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            ok = False
        End Try
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
        End If
        envia_corrreo_bom(cliente, asunto, mensaje, path)
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            despliega_spec(clientes.Text, estilo.Text)
        Catch
        End Try
    End Sub

    Private Sub clientes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles clientes.SelectedIndexChanged
        llena_estilos()
    End Sub

    Private Sub estilo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles estilo.SelectedIndexChanged
        llena_colores()
    End Sub

    Private Sub colores_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles colores.SelectedIndexChanged
        setea_grid()
    End Sub


    Private Sub clientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientes.KeyPress
        AutoCompletar(clientes, e)
    End Sub

    Private Sub estilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estilo.KeyPress
        AutoCompletar(estilo, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colores.KeyPress
        AutoCompletar(colores, e)
    End Sub
End Class
