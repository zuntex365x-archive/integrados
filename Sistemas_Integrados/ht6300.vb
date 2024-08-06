Public Class ht6300
    Inherits System.Windows.Forms.Form
    Public modo As String
    Dim result
    Dim lSize
    'Dim sSize
    Dim Count
    Dim lee As New Object
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents puerto As System.Windows.Forms.ComboBox
    Dim mls As System.UInt32
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ht6300))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.puerto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(78, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Descargar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Presione Descargar   para que comience el proceso de descargar datos del  Lector " & _
            "Portatil."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Puerto:"
        '
        'puerto
        '
        Me.puerto.FormattingEnabled = True
        Me.puerto.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.puerto.Location = New System.Drawing.Point(135, 88)
        Me.puerto.Name = "puerto"
        Me.puerto.Size = New System.Drawing.Size(50, 21)
        Me.puerto.TabIndex = 4
        '
        'pt6300
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(272, 154)
        Me.Controls.Add(Me.puerto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pt6300"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pt6300"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim archivo As String = "INVTEL" + Format(Now, "yyyyMMddHHmm") + ".txt"
    'Private lee As New AxONLINECOMLib.AxCommObj

    Private Sub pt6300_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        puerto.SelectedIndex = 4
    End Sub

    Private Sub copia_datos()
        Dim retval As Object
        Dim jap As String = "c:\lector\Unitech\bconvert /input:" & Chr(34) & "C:\lector\MATE01.csv" & Chr(34) & " /output:" & Chr(34) & "c:\lector\MATE01.BLT" & Chr(34) & " /fieldno:1 /fieldsep:, /error:" & Chr(34) & "c:\lector\error"" "
        Try
            retval = Shell(jap, AppWinStyle.Hide)
        Catch
        End Try
        Try
            retval = Shell("c:\lector\Unitech\ptcomm /comport:" & puerto.Text & " /ptaddr:a /batch:c:\lector\Unitech\subir.txt /exit", AppWinStyle.Hide)
        Catch
        End Try
    End Sub
    Private Sub comienza_lectura()
        Dim retval As Object
        Try
            retval = Shell("c:\lector\Unitech\ptcomm /comport:" & puerto.Text & " /ptaddr:a /batch:c:\lector\Unitech\bajar.txt /exit", AppWinStyle.Hide)
        Catch
        End Try


        '    lee = CreateObject("UnitechAmericaInc.OnlineCom")
        '    Try
        '        result = lee.SetupEx(puerto.Text, 38400, 1, "N")
        '        result = lee.Connect()
        '        If result <> 1 Then
        '            MsgBox("El puerto Com" & puerto.Text & " no esta disponible !")
        '            lee = Nothing
        '            Try
        '                Call lee.Disconnect()
        '            Catch ex As Exception

        '            End Try
        '            Exit Sub
        '        End If
        '        ' Transfiere el archivo a windows
        '        ' 0 = timeout
        '        ' 3 = Numero de retry's
        '        result = lee.UpLoad("A", "c:\telas\INVSUN.TXT", "INVSUN.TXT", 0, 3)
        '        Count = 0
        '        If result > 0 Then
        '            Do
        '                mls = UInteger.Parse("400")
        '                Call lee.Sleep(mls)        '	Para que tenga mayor tiempo para bajar
        '                result = lee.StLoad(0)     '	Verifica el estado
        '                lSize = lee.StLoad_lSize
        '                If Count < 5 Then
        '                    Count = Count + 1
        '                    If (Count >= 5) And (lSize <= 0) Then
        '                        Exit Do        '	Algo salio mal
        '                    End If
        '                End If
        '            Loop Until result >= 2
        '        End If
        '        result = lee.StLoad(1)     '	force the transfer be stopped
        '        lSize = lee.StLoad_lSize
        '        If Int(lSize) > 0 Then
        '            MsgBox(lSize & " (Bytes) trasladados")
        '        Else
        '            MsgBox("No pude leer los datos. Por favor vuelva a tratar")
        '        End If
        '    Catch
        '    End Try
        '    Call lee.Disconnect()
        '    lee = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        If modo = "carga" Then
            copia_datos()
        ElseIf modo = "elimina" Then
            borra_datos()
        Else
            comienza_lectura()
        End If
        Cursor = Cursors.Default
        Close()
    End Sub

    Private Sub borra_datos()
        Dim retval
        Try
            retval = Shell("c:\lector\Unitech\ptcomm /comport:" & puerto.Text & " /ptaddr:a /batch:c:\lector\Unitech\ubica_d.txt /exit", AppWinStyle.Hide)
        Catch
        End Try
    End Sub
End Class
