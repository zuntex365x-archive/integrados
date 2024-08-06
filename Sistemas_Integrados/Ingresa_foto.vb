Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports c1.Win.C1FlexGrid

Public Class Ingresa_foto
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection
    Dim empresa As String
    Dim emprenom As String
    Dim obj As Object
    Dim abrear As New OpenFileDialog()
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nombres As System.Windows.Forms.TextBox
    Friend WithEvents apellidos As System.Windows.Forms.TextBox
    Friend WithEvents puesto As System.Windows.Forms.TextBox
    Dim archivo As String
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fg As c1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents textbox1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents foto As System.Windows.Forms.Button
    Friend WithEvents Abre As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresa_foto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textbox1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.foto = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Abre = New System.Windows.Forms.OpenFileDialog()
        Me.nombres = New System.Windows.Forms.TextBox()
        Me.apellidos = New System.Windows.Forms.TextBox()
        Me.puesto = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(743, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(369, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 232)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Laborales"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 40)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Puesto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(816, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(296, 72)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Texsun S.A."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(3, 0)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1118, 834)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 848)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(392, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Para Seleccionar un Empleado Presione Click."
        '
        'textbox1
        '
        Me.textbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textbox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox1.Location = New System.Drawing.Point(280, 88)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(144, 40)
        Me.textbox1.TabIndex = 25
        Me.textbox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.textbox1.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(848, 534)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(81, 58)
        Me.Button6.TabIndex = 79
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button6, "Graba fotografía.")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(1022, 534)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 58)
        Me.Button5.TabIndex = 80
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Otro empleado.")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'foto
        '
        Me.foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.foto.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foto.ForeColor = System.Drawing.Color.Black
        Me.foto.Image = CType(resources.GetObject("foto.Image"), System.Drawing.Image)
        Me.foto.Location = New System.Drawing.Point(935, 534)
        Me.foto.Name = "foto"
        Me.foto.Size = New System.Drawing.Size(81, 58)
        Me.foto.TabIndex = 81
        Me.foto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.foto, "Toma foto.")
        Me.foto.UseVisualStyleBackColor = False
        '
        'Abre
        '
        Me.Abre.Filter = "Text Files (.csv)|.csv"
        '
        'nombres
        '
        Me.nombres.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.nombres.Location = New System.Drawing.Point(280, 200)
        Me.nombres.Name = "nombres"
        Me.nombres.Size = New System.Drawing.Size(424, 32)
        Me.nombres.TabIndex = 83
        '
        'apellidos
        '
        Me.apellidos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.apellidos.Location = New System.Drawing.Point(280, 249)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(424, 32)
        Me.apellidos.TabIndex = 84
        '
        'puesto
        '
        Me.puesto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.puesto.Location = New System.Drawing.Point(280, 295)
        Me.puesto.Name = "puesto"
        Me.puesto.Size = New System.Drawing.Size(424, 32)
        Me.puesto.TabIndex = 85
        '
        'Ingresa_foto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1126, 867)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.puesto)
        Me.Controls.Add(Me.apellidos)
        Me.Controls.Add(Me.nombres)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.foto)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingresa_foto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados Pendientes de Fotografia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = New empresas()
        empresa = obj.NOMBRE
        Label14.Text = empresa
        setea_fg()
        llena_fg()
    End Sub

    Private Sub limpia_variables()
        nombres.Text = ""
        apellidos.Text = ""
        nombres.Text = ""
        apellidos.Text = ""
        puesto.Text = ""
        Label15.Visible = False
        PictureBox1.Image = Nothing
        PictureBox1.Refresh()
        Button5.Visible = True
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 35
    End Sub

    Private Sub llena_fg()
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strSQL As String = "SELECT * FROM MEN_JAP ORDER BY USUARIO "
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 0) = dr("PASSWORD")
            fg(l, 1) = dr("USUARIO")
            fg(l, 2) = dr("USUARIO")
            l = l + 1
        Next
    End Sub

    Private Sub busca_empleado()
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim strsql As String = "SELECT * FROM MEN_JAP_F WHERE PASSWORD = '" & textbox1.Text & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            textbox1.Text = dr("PASSWORD")
            nombres.Text = dr("NOMBRES")
            apellidos.Text = dr("APELLIDOS")
            puesto.Text = dr("PUESTO")
            Try
                Dim fotogra() As Byte = dr("FOTO")
                Dim stmBLOBData As New MemoryStream(fotogra)
                PictureBox1.Image = Image.FromStream(stmBLOBData)
            Catch
            End Try
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpia_variables()
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Try
            textbox1.Text = fg(fg.RowSel, 0)
            fg.Visible = False
            Label15.Visible = True
            limpia_variables()
            busca_empleado()
        Catch
        End Try

    End Sub

    Private Sub otro_empleado()
        limpia_variables()
        Button5.Visible = False
        Button6.Visible = False
        fg.Visible = True
        Label15.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        graba_datos()
        limpia_variables()
        llena_fg()
        otro_empleado()
    End Sub

    Private Sub foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foto.Click
        Dim ok As Boolean
        abrear.InitialDirectory = "\\TECNICO\Programas\Personal\"
        ' abrear.FileName = textbox1.Text + "*.*"
        ok = True
        If abrear.ShowDialog = DialogResult.OK Then
            Try
                archivo = abrear.FileName
                PictureBox1.Image = Image.FromFile(archivo)
                Button6.Visible = True
            Catch
            End Try
        Else
            MessageBox.Show("Aun no se ha seleccionado el archivo a utilizar", "No se selecciono archivo", MessageBoxButtons.OK)
            Button6.Visible = False
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        otro_empleado()
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

            strsql = "UPDATE MEN_JAP_F SET T_FOTO = 'S' WHERE PASSWORD = " & "'" & textbox1.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO MEN_JAP_F (PASSWORD,NOMBRES,APELLIDOS,PUESTO) VALUES ('" & textbox1.Text & "','" & nombres.Text & "','" & apellidos.Text & "','" & puesto.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            strsql = "UPDATE MEN_JAP_F SET FOTO = @foto WHERE PASSWORD = '" & textbox1.Text & "'"

            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlClient.SqlParameter("@foto", SqlDbType.Image)
            p.Value = data
            comando.Parameters.Add(p)
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            MessageBox.Show("Fotografía grabada correctamente", "Fotos", MessageBoxButtons.OK)

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

End Class
