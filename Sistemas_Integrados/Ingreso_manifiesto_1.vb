Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Ingreso_manifiesto_1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dd As DataRow()
    Public fp As DataTable
    Public jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fpo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents knit_t As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents knit As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Dim dr As DataRow
    Dim OK As Boolean
    Friend WithEvents batch As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Dim grabado As Boolean = False

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_manifiesto_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.graba = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fpo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.knit_t = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.knit = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.batch = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(877, 7)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
        Me.graba.TabIndex = 5
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Graba y Actualiza registros.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 30)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "FPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpo
        '
        Me.fpo.BackColor = System.Drawing.Color.White
        Me.fpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fpo.ForeColor = System.Drawing.Color.Black
        Me.fpo.Location = New System.Drawing.Point(161, 7)
        Me.fpo.Name = "fpo"
        Me.fpo.Size = New System.Drawing.Size(263, 30)
        Me.fpo.TabIndex = 77
        Me.fpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 30)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "KNIT TEXPASA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'knit_t
        '
        Me.knit_t.BackColor = System.Drawing.Color.White
        Me.knit_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.knit_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knit_t.ForeColor = System.Drawing.Color.Black
        Me.knit_t.Location = New System.Drawing.Point(161, 70)
        Me.knit_t.Name = "knit_t"
        Me.knit_t.Size = New System.Drawing.Size(704, 30)
        Me.knit_t.TabIndex = 80
        Me.knit_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.knit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 104)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'knit
        '
        Me.knit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knit.FormattingEnabled = True
        Me.knit.Location = New System.Drawing.Point(153, 18)
        Me.knit.Name = "knit"
        Me.knit.Size = New System.Drawing.Size(704, 28)
        Me.knit.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 30)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "KNIT FPO:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'batch
        '
        Me.batch.BackColor = System.Drawing.Color.White
        Me.batch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.batch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batch.ForeColor = System.Drawing.Color.Black
        Me.batch.Location = New System.Drawing.Point(161, 39)
        Me.batch.Name = "batch"
        Me.batch.Size = New System.Drawing.Size(263, 30)
        Me.batch.TabIndex = 88
        Me.batch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 30)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "BATCH:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ingresa_manifiesto_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 224)
        Me.Controls.Add(Me.batch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.knit_t)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.fpo)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingresa_manifiesto_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia KNIT a Manifiesto"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Ingreso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler knit.KeyPress, AddressOf keypressed1
        dd = fp.Select("FPO = '" & fpo.Text & "' AND LOTE = '" & batch.Text & "'")
        llena_knit()
        knit.Focus()
    End Sub
    Private Sub llena_knit()
        Dim dr As DataRow
        Dim kn As String = ""
        knit.Items.Clear()
        For Each dr In dd
            If kn.Contains(dr("KNIT")) = False Then
                knit.Items.Add(dr("KNIT"))
                kn = kn + dr("KNIT") + " "
            End If
        Next
        If knit.Items.Count > 0 Then
            knit.SelectedIndex = 0
        End If
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(knit.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub graba_Click(sender As System.Object, e As System.EventArgs) Handles graba.Click
        cambia_datos()
        Close()
    End Sub

    Private Sub cambia_datos()
        Dim dr As DataRow
        Dim i As Integer
        dd = fp.Select("FPO = '" & fpo.Text & "' AND LOTE = '" & batch.Text & "' AND KNIT = '" & knit.Text & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            For i = 1 To jg.Rows.Count - 1
                If jg(i, 6) = knit_t.Text Then
                    jg(i, 6) = knit.Text
                    jg(i, 9) = dr("CODIGO")
                End If
            Next
        End If
    End Sub
End Class

