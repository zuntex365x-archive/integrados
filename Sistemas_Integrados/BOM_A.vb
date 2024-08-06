Imports C1.Win.C1FlexGrid
Imports System.Net.Mail
Imports System.IO

Public Class BOM_A
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "0000000000"
    Dim ok As Boolean
    Dim CODIGO As String
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim indice As Integer = 1
    Dim dt As New DataTable()
    Dim mt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents ec As C1.Win.C1FlexGrid.C1FlexGrid
    Dim lineas As Integer
    Dim empre As New empresas
    Dim clave As String
    Dim cliente As String
    Friend WithEvents estil As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOM_A))
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
        Me.ec = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo.SuspendLayout()
        CType(Me.ec, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fg.Location = New System.Drawing.Point(9, 421)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1130, 404)
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
        Me.bueno.Location = New System.Drawing.Point(899, 33)
        Me.bueno.Name = "bueno"
        Me.bueno.Size = New System.Drawing.Size(94, 85)
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
        Me.malo.Location = New System.Drawing.Point(1000, 33)
        Me.malo.Name = "malo"
        Me.malo.Size = New System.Drawing.Size(93, 85)
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
        Me.grupo.Location = New System.Drawing.Point(9, 287)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(1130, 127)
        Me.grupo.TabIndex = 1
        Me.grupo.TabStop = False
        '
        'estil
        '
        Me.estil.BackColor = System.Drawing.Color.White
        Me.estil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estil.Location = New System.Drawing.Point(197, 33)
        Me.estil.Name = "estil"
        Me.estil.Size = New System.Drawing.Size(271, 30)
        Me.estil.TabIndex = 54
        Me.estil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colo.Location = New System.Drawing.Point(195, 69)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(273, 29)
        Me.colo.TabIndex = 53
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 29)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Khaki
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 30)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(9, 828)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(626, 20)
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
        Me.ec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ec.Location = New System.Drawing.Point(16, 15)
        Me.ec.Name = "ec"
        Me.ec.Rows.DefaultSize = 17
        Me.ec.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ec.Size = New System.Drawing.Size(1023, 252)
        Me.ec.StyleInfo = resources.GetString("ec.StyleInfo")
        Me.ec.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.ec, "Area de Datos.")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1052, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 85)
        Me.Button4.TabIndex = 57
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Despliega Specs del Estilo")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BOM_A
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1165, 696)
        Me.Controls.Add(Me.Button4)
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
        Me.Name = "BOM_A"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobación de Bill of Materials"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo.ResumeLayout(False)
        CType(Me.ec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dd As DataRow()
        clave = empre.clave
        revisa_acceso_usuario(clave, ac)
        dd = ac.Select("APROBAR_BOM = 'S'")
        If ac.Rows.Count = 0 Or dd.Length = 0 Then
            MsgBox("Usted no tiene los Derechos Suficientes para Accesar este Programa", MsgBoxStyle.Critical, "ACCESO DENEGADO")
            Close()
        End If
        llena_tablas(mt, "SELECT * FROM MATERIALES WHERE ACTIVO = 'S'", cnn)
        setea_ec()
        Try
            selecciona_ec(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub setea_ec()
        ec.Rows.Count = 1
        ec.Rows(0).Height = 30
        ec.Cols(0).Width = 5
        llena_ec()
        ec.Focus()
        Try
            ec.Row = indice
            selecciona_ec(indice)
        Catch ex As Exception
        End Try

    End Sub
    Private Sub llena_ec()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim clientes As String = ""
        Dim todos As Boolean = False
        Dim l As Integer = 1
        For Each dr In ac.Rows
            If dr("APROBAR_BOM") = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    clientes = clientes + "'" & dr("CLIENTE") & "',"
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'R' ORDER BY CLIENTE,ESTILO,COLOR"
        Else
            If clientes.Length > 0 Then
                clientes = Mid(clientes, 1, clientes.Length - 1)
                strsql = "SELECT * FROM CLI_EST_COL WHERE ESTADO = 'R' AND CLIENTE IN (" & clientes & ")"
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
        Try
            cliente = ec(1, 1)
            estil.Text = ec(1, 2)
            colo.Text = ec(1, 3)
        Catch ex As Exception
            cliente = ""
            estil.Text = ""
            colo.Text = ""
        End Try
        llena_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 6
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        setea_grid()
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
            lineas = lineas + 1
        Next
        seleccion(1)
    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub bueno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bueno.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        If Trim(Estilos.Text) <> "" And Trim(colo.Text) <> "" Then
            seguro = MsgBox("Seguro de quere Aprobar el BOM?  ", MsgBoxStyle.YesNo, "Aprobación de BOM !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros("S")
                envia_correo()
                indice = ec.RowSel
                setea_ec()
            End If
        End If

    End Sub

    Private Sub malo_Click(sender As System.Object, e As System.EventArgs) Handles malo.Click
        Dim seguro As MsgBoxResult
        If Trim(Estilos.Text) <> "" And Trim(colo.Text) <> "" Then
            seguro = MsgBox("Seguro de Reprobar el BOM?  ", MsgBoxStyle.YesNo, "Reprobar el BOM !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros("N")
                setea_ec()
            End If
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

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
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
        Dim tipo As String = "U"
        Dim obj As New empresas()
        Dim fechas As String = Format(Now, "yyyy-MM-dd hh:mm:ss")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        If aprobado = "N" Then
            tipo = "X"
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
                strsql = "UPDATE CLI_EST_COL SET ESTADO = 'A' WHERE CLIENTE = '" & cliente & "' AND ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Else
                strsql = "UPDATE CLI_EST_COL SET ESTADO = 'C' WHERE CLIENTE = '" & cliente & "' AND ESTILO = '" & estil.Text & "' AND COLOR = '" & colo.Text & "'"
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
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() &
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
                llena_grid()
            Catch
            End Try
        End If
    End Sub

    Private Sub envia_correo()
        Dim cliente As String = ec(ec.RowSel, 1)
        Dim asunto As String
        Dim mensaje As String
        Dim path As String = "c:\reportes\" & Format(Now, "yyyyMMddHHmmss") & ".pdf"
        Dim dd As String = Space(50)
        asunto = "Aprobación Cliente: " & cliente & ", Estilo: " & estil.Text & ", Color: " & colo.Text
        mensaje = "Aprobación:" + vbLf + vbLf
        For i = 1 To fg.Rows.Count - 1
            fg(i, 4) = fg(i, 4) + dd
            fg(i, 4) = Mid(fg(i, 4), 1, 50)
            mensaje = mensaje + fg(i, 3) + vbTab + fg(i, 4) + vbTab + Format(fg(i, 5), "###,##0.0000") + vbLf
        Next
        mensaje = mensaje + vbLf + vbLf + vbLf + "Aprobado por: " + empre.usuario
        a_pdf(fg, path, asunto, "")
        envia_corrreo_bom(cliente, asunto, mensaje, path)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            despliega_spec(ec(ec.RowSel, 1), ec(ec.RowSel, 2))
        Catch
        End Try
    End Sub

    Private Sub Estil_Click(sender As Object, e As EventArgs) Handles estil.Click

    End Sub
End Class
