<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresa_spec
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresa_spec))
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.ComboBox()
        Me.Abrear = New System.Windows.Forms.OpenFileDialog()
        Me.busca = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.pdf0 = New AxAcroPDFLib.AxAcroPDF()
        Me.sigue = New System.Windows.Forms.Button()
        CType(Me.pdf0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(117, 13)
        Me.cliente.MaxLength = 20
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(247, 26)
        Me.cliente.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Estilo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.Location = New System.Drawing.Point(117, 42)
        Me.estilo.MaxLength = 20
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(247, 26)
        Me.estilo.TabIndex = 1
        '
        'Abrear
        '
        Me.Abrear.FileName = "OpenFileDialog1"
        '
        'busca
        '
        Me.busca.BackColor = System.Drawing.Color.Black
        Me.busca.Image = CType(resources.GetObject("busca.Image"), System.Drawing.Image)
        Me.busca.Location = New System.Drawing.Point(877, 12)
        Me.busca.Name = "busca"
        Me.busca.Size = New System.Drawing.Size(35, 35)
        Me.busca.TabIndex = 49
        Me.busca.UseVisualStyleBackColor = False
        Me.busca.Visible = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(877, 12)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 51
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(918, 12)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 50
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.regresa.UseVisualStyleBackColor = False
        '
        'pdf0
        '
        Me.pdf0.Enabled = True
        Me.pdf0.Location = New System.Drawing.Point(12, 77)
        Me.pdf0.Name = "pdf0"
        Me.pdf0.OcxState = CType(resources.GetObject("pdf0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdf0.Size = New System.Drawing.Size(941, 537)
        Me.pdf0.TabIndex = 52
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(877, 12)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 2
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Ingresa_spec
        '
        Me.ClientSize = New System.Drawing.Size(965, 626)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.pdf0)
        Me.Controls.Add(Me.Graba)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.busca)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ingresa_spec"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Specs."
        CType(Me.pdf0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pdf1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.ComboBox
    Friend WithEvents Abrear As System.Windows.Forms.OpenFileDialog
    Friend WithEvents busca As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents pdf0 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents sigue As System.Windows.Forms.Button

End Class
