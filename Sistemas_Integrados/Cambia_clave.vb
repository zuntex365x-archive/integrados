Imports System.Transactions
Imports System.Data.SqlClient
Imports System.IO

Public Class Cambia_clave
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection
    Dim empresa As String
    Dim emprenom As String
    Dim obj As New Object
    Dim abrear As New OpenFileDialog()
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents puesto As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pac As System.Windows.Forms.TextBox
    Friend WithEvents pre As System.Windows.Forms.TextBox
    Friend WithEvents pnu As System.Windows.Forms.TextBox
    Dim archivo As String
    Dim clave As String
    Dim cs As New Lib_SI.util
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
    Friend WithEvents nombres As System.Windows.Forms.Label
    Friend WithEvents apellidos As System.Windows.Forms.Label
    Friend WithEvents g1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cambia_clave))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nombres = New System.Windows.Forms.Label()
        Me.apellidos = New System.Windows.Forms.Label()
        Me.g1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pac = New System.Windows.Forms.TextBox()
        Me.pre = New System.Windows.Forms.TextBox()
        Me.pnu = New System.Windows.Forms.TextBox()
        Me.puesto = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(725, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 432)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 184)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 40)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Puesto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nombres
        '
        Me.nombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombres.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombres.Location = New System.Drawing.Point(266, 106)
        Me.nombres.Name = "nombres"
        Me.nombres.Size = New System.Drawing.Size(424, 40)
        Me.nombres.TabIndex = 8
        Me.nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'apellidos
        '
        Me.apellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apellidos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidos.Location = New System.Drawing.Point(266, 154)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(424, 40)
        Me.apellidos.TabIndex = 12
        Me.apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'g1
        '
        Me.g1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g1.ForeColor = System.Drawing.Color.Black
        Me.g1.Image = CType(resources.GetObject("g1.Image"), System.Drawing.Image)
        Me.g1.Location = New System.Drawing.Point(854, 506)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(81, 58)
        Me.g1.TabIndex = 4
        Me.g1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.g1, "Graba fotografía.")
        Me.g1.UseVisualStyleBackColor = False
        '
        'pac
        '
        Me.pac.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.pac.ForeColor = System.Drawing.Color.Black
        Me.pac.Location = New System.Drawing.Point(266, 457)
        Me.pac.MaxLength = 10
        Me.pac.Name = "pac"
        Me.pac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pac.Size = New System.Drawing.Size(424, 32)
        Me.pac.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.pac, "Por favor ingrese la Contraseña Actual.")
        '
        'pre
        '
        Me.pre.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.pre.ForeColor = System.Drawing.Color.Black
        Me.pre.Location = New System.Drawing.Point(266, 551)
        Me.pre.MaxLength = 10
        Me.pre.Name = "pre"
        Me.pre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pre.Size = New System.Drawing.Size(424, 32)
        Me.pre.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.pre, "Por favor ingrese la palabra Clave que le asigno el Adminstrador del Sistema.   S" & _
                "in esa palabra no podrá accesar .")
        '
        'pnu
        '
        Me.pnu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnu.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.pnu.ForeColor = System.Drawing.Color.Black
        Me.pnu.Location = New System.Drawing.Point(266, 505)
        Me.pnu.MaxLength = 10
        Me.pnu.Name = "pnu"
        Me.pnu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pnu.Size = New System.Drawing.Size(424, 32)
        Me.pnu.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.pnu, "Por favor ingrese nueva contreseña. ")
        '
        'puesto
        '
        Me.puesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.puesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.puesto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puesto.Location = New System.Drawing.Point(266, 201)
        Me.puesto.Name = "puesto"
        Me.puesto.Size = New System.Drawing.Size(424, 40)
        Me.puesto.TabIndex = 82
        Me.puesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 426)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 175)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cambio de Contraseña."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Re-ingreso nueva."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 40)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Actual:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 40)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nueva:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cambia_clave
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1107, 621)
        Me.Controls.Add(Me.pnu)
        Me.Controls.Add(Me.pre)
        Me.Controls.Add(Me.pac)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.puesto)
        Me.Controls.Add(Me.g1)
        Me.Controls.Add(Me.apellidos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nombres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cambia_clave"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler pac.KeyPress, AddressOf keypressed1
        AddHandler pnu.KeyPress, AddressOf keypressed2
        AddHandler pre.KeyPress, AddressOf keypressed3
        obj = New empresas
        clave = obj.clave
        pnu.Enabled = False
        pre.Enabled = False
        g1.Visible = False
        busca_empleado()
    End Sub


    Private Sub busca_empleado()
        Dim dr As DataRow
        Dim dt As New DataTable
        obj = New empresas
        Dim strsql As String = "SELECT * FROM MEN_JAP_F WHERE PASSWORD = '" & clave & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
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
    Private Sub busca_datos(ByVal clave As String, ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim strsql As String = "SELECT * FROM MEN_JAP WHERE PASSWORD = '" & clave & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count = 0 Then
            ok = False
        Else
            ok = True
        End If

    End Sub
    Private Sub revisa_datos(ByRef ok As Boolean)
        If pac.Text <> obj.clave Then
            MsgBox("LA CONTRASEÑA INGRESADA NO COINCIDE CON LA DEL USUARIO. POR FAVOR REVISE !!!!")
            ok = False
        Else
            ok = True
        End If
    End Sub
    Private Sub habilita()
        pac.Enabled = False
        pnu.Enabled = True
        pre.Enabled = True
        g1.Visible = True
        pnu.Focus()
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim dt As New DataTable()
            If Trim(pac.Text) <> "" Then
                revisa_datos(ok)
                If ok Then
                    habilita()
                Else
                    pac.Focus()
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(pnu.Text) <> "" Then
                pre.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(pre.Text) <> "" Then
                g1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub g1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g1.Click
        Dim ok As Boolean
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Cambiar la Contraseña?  ", MsgBoxStyle.YesNo, "Cambiando Contraseña !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_nueva(ok)
            If ok Then
                graba_datos()
                End
            End If
        End If
    End Sub

    Private Sub revisa_nueva(ByRef ok As Boolean)
        ok = False
        If Len(pnu.Text) < 6 Then
            MsgBox("La contraseña debe tener al menos 6 caracteres", MsgBoxStyle.Critical, "Error en ingreso de Contraseñas")
            Exit Sub
        End If
        If pnu.Text <> pre.Text Then
            MsgBox("Contraseñas no son Iguales", MsgBoxStyle.Critical, "Error en ingreso de Contraseñas")
            Exit Sub
        End If
        busca_datos(pnu.Text, ok)
        If ok Then
            MsgBox("Otro usuario ya tiene esa contraseña !!!", MsgBoxStyle.Critical, "Error en ingreso de Contraseñas")
            ok = False
            Exit Sub
        End If
        ok = True
    End Sub
    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim fecha As String = Format(Now, "yyyy-MM-ddTHH:mm:ss")
        Dim strsql As String
        Dim afectados As Integer
        Dim con0 As New SqlClient.SqlConnection
        Dim con1 As New SqlClient.SqlConnection
        Dim con2 As New SqlClient.SqlConnection
        Dim comando As New SqlCommand

        con0.ConnectionString = cs.con_string("0")
        con1.ConnectionString = cs.con_string("1")
        con2.ConnectionString = cs.con_string("2")

        con0.ConnectionString = con0.ConnectionString + ";Enlist=False"
        con1.ConnectionString = con1.ConnectionString + ";Enlist=False"
        con2.ConnectionString = con2.ConnectionString + ";Enlist=False"

        Try

            Using scope As New TransactionScope()

                Using con0
                    con0.Open()
                    strsql = "UPDATE MEN_JAP SET PASSWORD = '" & pnu.Text & "' WHERE PASSWORD = '" & obj.CLAVE & "'"
                    comando = New SqlCommand(strsql, con0)
                    afectados = comando.ExecuteNonQuery()

                    strsql = "UPDATE MEN_JAP_F SET PASSWORD = '" & pnu.Text & "' WHERE PASSWORD = '" & obj.CLAVE & "'"
                    comando = New SqlCommand(strsql, con0)
                    afectados = comando.ExecuteNonQuery()

                    strsql = "INSERT INTO MEN_JAP_V (FECHA,USUARIO,ANTERIOR,NUEVA) VALUES ('" & fecha & "','" & obj.usuario & "','" & obj.clave & "','" & pnu.Text & "')"
                    comando = New SqlCommand(strsql, con0)
                    afectados = comando.ExecuteNonQuery()

                    strsql = "UPDATE USUARIO_CLIENTE SET USUARIO = '" & pnu.Text & "' WHERE USUARIO = '" & obj.CLAVE & "'"
                    comando = New SqlCommand(strsql, con0)
                    afectados = comando.ExecuteNonQuery()

                    Using con1
                        con1.Open()

                        strsql = "UPDATE USUARIO_CLIENTE SET USUARIO = '" & pnu.Text & "' WHERE USUARIO = '" & obj.CLAVE & "'"
                        comando = New SqlCommand(strsql, con1)
                        afectados = comando.ExecuteNonQuery()
                    End Using

                    Using con2
                        con2.Open()

                        strsql = "UPDATE USUARIO_CLIENTE SET USUARIO = '" & pnu.Text & "' WHERE USUARIO = '" & obj.CLAVE & "'"
                        comando = New SqlCommand(strsql, con2)
                        afectados = comando.ExecuteNonQuery()
                    End Using

                End Using

                scope.Complete()
                MsgBox("Contraseña Actualizada con Exito !!!", MsgBoxStyle.Information, "Transaccion Realizada !!!!")
            End Using

        Catch ex As TransactionAbortedException
            MsgBox("Error en la Grabacion" + ex.Message, MsgBoxStyle.Critical, "Por favor Revise !!!!")
        Finally
            con0.Close()
            con1.Close()
            con2.Close()
        End Try
    End Sub



    Private Const NERR_BASE As Long = 2100
    Private Const NERR_PasswordCantChange As Long = (NERR_BASE + 143)
    Private Const NERR_PasswordHistConflict As Long = (NERR_BASE + 144)
    Private Const NERR_PasswordTooShort As Long = (NERR_BASE + 145)
    Private Const NERR_PasswordTooRecent As Long = (NERR_BASE + 146)

    Private Declare Function NetUserChangePassword Lib "netapi32.dll" (ByVal sDomain As String, ByVal sUserName As String, ByVal sOldPassword As String, ByVal sNewPassword As String) As Long


    Public Function ValidateSysPassword(ByVal sPassword As String, Optional ByVal sUserName As String = "", Optional ByVal sDomain As String = "") As Boolean
        If Len(sUserName) = 0 Then
            sUserName = Environ$("USERNAME")
        End If
        If Len(sDomain) = 0 Then
            sDomain = Environ$("USERDOMAIN")
        End If

        'Select Case NetUserChangePassword(StrConv(sDomain, vbUnicode), StrConv(sUserName, vbUnicode), StrConv(sPassword, vbUnicode), StrConv(sPassword, vbUnicode))

        '    Case 0, NERR_PasswordCantChange, NERR_PasswordHistConflict, NERR_PasswordTooShort, NERR_PasswordTooRecent

        ValidateSysPassword = True
        Return True
        'End Select
    End Function

End Class
