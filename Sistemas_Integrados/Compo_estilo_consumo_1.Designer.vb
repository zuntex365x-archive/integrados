<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compo_estilo_consumo_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_estilo_consumo_1))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.color_tela = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.S1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Consumo = New C1.Win.C1Input.C1TextBox()
        CType(Me.Consumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 41)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Color Tela:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'color_tela
        '
        Me.color_tela.BackColor = System.Drawing.Color.White
        Me.color_tela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.color_tela.Location = New System.Drawing.Point(204, 46)
        Me.color_tela.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.color_tela.Name = "color_tela"
        Me.color_tela.Size = New System.Drawing.Size(677, 40)
        Me.color_tela.TabIndex = 111
        Me.color_tela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'codigo
        '
        Me.codigo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo.IntegralHeight = False
        Me.codigo.Location = New System.Drawing.Point(204, 122)
        Me.codigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.codigo.MaxLength = 10
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(195, 26)
        Me.codigo.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 41)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Codigo Tela:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.White
        Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descripcion.Location = New System.Drawing.Point(204, 174)
        Me.descripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(677, 40)
        Me.descripcion.TabIndex = 113
        Me.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(785, 254)
        Me.S1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(80, 49)
        Me.S1.TabIndex = 114
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.S1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 254)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 41)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Consumo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Consumo
        '
        Me.Consumo.DataType = GetType(Decimal)
        Me.Consumo.Location = New System.Drawing.Point(204, 261)
        Me.Consumo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Consumo.Name = "Consumo"
        Me.Consumo.Size = New System.Drawing.Size(196, 20)
        Me.Consumo.TabIndex = 116
        Me.Consumo.Tag = Nothing
        Me.Consumo.TextDetached = True
        '
        'Compo_estilo_consumo_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 332)
        Me.Controls.Add(Me.Consumo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.color_tela)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Compo_estilo_consumo_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia Codigo de Tela"
        CType(Me.Consumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents color_tela As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Consumo As C1.Win.C1Input.C1TextBox
End Class
