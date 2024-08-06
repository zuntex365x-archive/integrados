<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(spec))
        Me.pdf1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pdf1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdf1
        '
        Me.pdf1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdf1.Enabled = True
        Me.pdf1.Location = New System.Drawing.Point(0, 0)
        Me.pdf1.Name = "pdf1"
        Me.pdf1.OcxState = CType(resources.GetObject("pdf1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pdf1.Size = New System.Drawing.Size(984, 686)
        Me.pdf1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(744, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'spec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 686)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pdf1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "spec"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specs"
        CType(Me.pdf1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pdf1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
