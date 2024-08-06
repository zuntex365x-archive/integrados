Imports C1.Win.C1FlexGrid
Imports System.Net.Mail

Public Class BOM_M
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
    Friend WithEvents ec As C1.Win.C1FlexGrid.C1FlexGrid
    Dim lineas As Integer
    Dim empre As New empresas
    Dim clave As String
    Dim cliente As String
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clientes As System.Windows.Forms.ComboBox
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOM_M))
        Me.bueno = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ec = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clientes = New System.Windows.Forms.ComboBox()
        CType(Me.ec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bueno
        '
        Me.bueno.BackColor = System.Drawing.Color.White
        Me.bueno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bueno.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bueno.ForeColor = System.Drawing.Color.Black
        Me.bueno.Image = CType(resources.GetObject("bueno.Image"), System.Drawing.Image)
        Me.bueno.Location = New System.Drawing.Point(883, 9)
        Me.bueno.Name = "bueno"
        Me.bueno.Size = New System.Drawing.Size(80, 61)
        Me.bueno.TabIndex = 21
        Me.bueno.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.bueno, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.bueno.UseVisualStyleBackColor = False
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
        Me.ec.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ec.ColumnInfo = resources.GetString("ec.ColumnInfo")
        Me.ec.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ec.Location = New System.Drawing.Point(8, 76)
        Me.ec.Name = "ec"
        Me.ec.Rows.DefaultSize = 19
        Me.ec.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ec.Size = New System.Drawing.Size(955, 580)
        Me.ec.StyleInfo = resources.GetString("ec.StyleInfo")
        Me.ec.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.ec, "Area de Datos.")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 38)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.Color.White
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.FormattingEnabled = True
        Me.clientes.Location = New System.Drawing.Point(92, 29)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(317, 28)
        Me.clientes.TabIndex = 46
        '
        'BOM_M
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 696)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.bueno)
        Me.Controls.Add(Me.ec)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BOM_M"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Bill of Materials"
        CType(Me.ec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dd As DataRow()
        clave = empre.clave
        revisa_acceso_usuario(clave, ac)
        dd = ac.Select("MODIFICACION_BOM = 'S'")
        If ac.Rows.Count = 0 Or dd.Length = 0 Then
            MsgBox("Usted no tiene los Derechos Suficientes para Accesar este Programa", MsgBoxStyle.Critical, "ACCESO DENEGADO")
            Close()
        End If
        llena_clientes()
    End Sub
    Private Sub setea_ec()
        ec.Rows.Count = 1
        ec.Rows(0).Height = 30
        ec.Cols(0).Width = 5
        llena_grid()
    End Sub
    Private Sub llena_clientes()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = ""
        Dim todos As Boolean = False
        Dim l As Integer = 1
        Dim client As String = ""
        For Each dr In ac.Rows
            If dr("MODIFICACION_BOM") = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    If client.IndexOf(dr("CLIENTE")) < 0 Then
                        client = client + "'" & dr("CLIENTE") & "',"
                    End If
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT DISTINCT CLIENTE FROM CLI_EST_COL WHERE ESTADO = 'A' ORDER BY CLIENTE"
            llena_combos(clientes, strsql, "CLIENTE")
        Else
            If client.Length > 0 Then
                client = Mid(client, 1, client.Length - 1)
                strsql = "SELECT DISTINCT CLIENTE FROM CLI_EST_COL WHERE ESTADO = 'A' AND CLIENTE IN (" & client & ") ORDER BY CLIENTE"
                llena_combos(clientes, strsql, "CLIENTE")
            End If
        End If
        Try
            clientes.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CLI_EST_COL WHERE CLIENTE = '" & clientes.Text & "' AND ESTADO = 'A' ORDER BY ESTILO,COLOR"
        llena_tablas(dt, strsql, cnn)
        ec.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            ec(l, 1) = dr("CLIENTE")
            ec(l, 2) = dr("ESTILO")
            ec(l, 3) = dr("COLOR")
            ec(l, 4) = False
            l = l + 1
        Next
    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub bueno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bueno.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de querer Modificar los BOM?  ", MsgBoxStyle.YesNo, "Actualizar el Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_registros("S")
            setea_ec()
            Close()
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
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim tipo As String = "M"
        Dim obj As New empresas()
        Dim i As Integer
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
            For i = 1 To ec.Rows.Count - 1
                If ec(i, 4) = True Then
                    '============== actualiza  =======================
                    dd = mt.Select("ESTILO = '" & ec(i, 2) & "' AND COLOR = '" & ec(i, 3) & "'")
                    For Each dr In dd
                        strsql = "INSERT INTO MAT_EST_COL_V (ESTILO,COLOR,CODIGO,FECHA,USUARIO,UNIDAD,TM) VALUES ('" & ec(i, 2) & "','" & ec(i, 3) & "','" & dr("CODIGO") & "',GETDATE(),'" & obj.usuario & "','" & dr("UNIDAD") & "','" & tipo & "')"
                        comando.CommandText = strsql
                        vitacora = comando.ExecuteNonQuery()
                    Next

                    If aprobado = "S" Then
                        strsql = "UPDATE CLI_EST_COL SET ESTADO = 'C' WHERE CLIENTE = '" & clientes.Text & "' AND ESTILO = '" & ec(i, 2) & "' AND COLOR = '" & ec(i, 3) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
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

    Private Sub llena_detalle()
        mt = New DataTable
        Dim strsql As String = "SELECT * FROM MAT_EST_COL WHERE ESTILO+ COLOR IN(SELECT ESTILO + COLOR FROM CLI_EST_COL WHERE CLIENTE = '" & clientes.Text & "')"
        llena_tablas(mt, strsql, cnn)
    End Sub

    Private Sub clientes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles clientes.SelectedIndexChanged
        setea_ec()
        llena_detalle()
    End Sub
    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientes.KeyPress
        AutoCompletar(clientes, e)
    End Sub
End Class
