Public Class pt6300
    Inherits System.Windows.Forms.Form
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(pt6300))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.Location = New System.Drawing.Point(80, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Descargar"
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
        'pt6300
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(272, 140)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Button1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pt6300"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pt6300"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim archivo As String = "INVTEL" + Format(Now, "yyyyMMddHHmm") + ".txt"
    ' Private lee As New AxONLINECOMLib.AxCommObj

    Private Sub pt6300_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub comienza_lectura()
        Dim result
        Dim lSize
        'Dim sSize
        Dim Count
        Dim lee
        Dim mls As System.UInt32

        lee = CreateObject("UnitechAmericaInc.OnlineCom")
        Try
            result = lee.SetupEx(1, 38400, 1, "N")
            result = lee.Connect()
            If result <> 1 Then
                MsgBox("El puerto Com1 no esta disponible !")
                lee = Nothing
                Try
                    Call lee.Disconnect()
                Catch ex As Exception

                End Try
                Exit Sub
            End If
            ' Transfiere el archivo a windows
            ' 0 = timeout
            ' 3 = Numero de retry's
            result = lee.UpLoad("A", "c:\TEXPASA\INVSUN.TXT", "INVSUN.TXT", 0, 3)
            Count = 0
            If result > 0 Then
                Do
                    mls = UInteger.Parse("400")
                    Call lee.Sleep(mls)        '	Para que tenga mayor tiempo para bajar
                    result = lee.StLoad(0)     '	Verifica el estado
                    lSize = lee.StLoad_lSize
                    If Count < 5 Then
                        Count = Count + 1
                        If (Count >= 5) And (lSize <= 0) Then
                            Exit Do        '	Algo salio mal
                        End If
                    End If
                Loop Until result >= 2
            End If
            result = lee.StLoad(1)     '	force the transfer be stopped
            lSize = lee.StLoad_lSize
            If Int(lSize) > 0 Then
                MsgBox(lSize & " (Bytes) trasladados")
            Else
                MsgBox("No pude leer los datos. Por favor vuelva a tratar")
            End If
        Catch
        End Try
        Call lee.Disconnect()
        lee = Nothing

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        'UpLoad()
        comienza_lectura()
        'UpLoad()
        Cursor = Cursors.Default
        Close()
    End Sub
End Class
