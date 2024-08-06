<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cambia_fecha_fpo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cambia_fecha_fpo))
        Me.graba = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fpo = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(558, 13)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 7
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 26)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "FPO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 26)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Nueva Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'fpo
        '
        Me.fpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fpo.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fpo.Location = New System.Drawing.Point(190, 27)
        Me.fpo.Name = "fpo"
        Me.fpo.Size = New System.Drawing.Size(344, 26)
        Me.fpo.TabIndex = 113
        Me.fpo.Text = " "
        Me.fpo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fecha.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fecha.Location = New System.Drawing.Point(190, 57)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(344, 26)
        Me.fecha.TabIndex = 114
        Me.fecha.Text = " "
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cambia_fecha_fpo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 109)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.fpo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.graba)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cambia_fecha_fpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia fecha a FPO's"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fpo As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.Label
End Class
