<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carga_de_cpos_masiva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Subtitulo = New System.Windows.Forms.Label()
        Me.PRECIO = New System.Windows.Forms.Label()
        Me.MAXIMO_P = New System.Windows.Forms.Label()
        Me.MINIMO_P = New System.Windows.Forms.Label()
        Me.ESCALA = New System.Windows.Forms.Label()
        Me.COMISION = New System.Windows.Forms.Label()
        Me.VENDEDOR = New System.Windows.Forms.Label()
        Me.DESTINO = New System.Windows.Forms.Label()
        Me.ESTADO = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.Label()
        Me.UNIDADES = New System.Windows.Forms.Label()
        Me.TALLA = New System.Windows.Forms.Label()
        Me.COLOR = New System.Windows.Forms.Label()
        Me.ESTILO = New System.Windows.Forms.Label()
        Me.CPO = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Boton_cargar = New System.Windows.Forms.Button()
        Me.ComboBox_ESCALA = New System.Windows.Forms.ComboBox()
        Me.ComboBox_MAXIMO_P = New System.Windows.Forms.ComboBox()
        Me.ComboBox_PRECIO = New System.Windows.Forms.ComboBox()
        Me.ComboBox_VENDEDOR = New System.Windows.Forms.ComboBox()
        Me.ComboBox_COMISION = New System.Windows.Forms.ComboBox()
        Me.ComboBox_MINIMO_P = New System.Windows.Forms.ComboBox()
        Me.ComboBox_UNIDADES = New System.Windows.Forms.ComboBox()
        Me.ComboBox_TOTAL = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ESTADO = New System.Windows.Forms.ComboBox()
        Me.ComboBox_DESTINO = New System.Windows.Forms.ComboBox()
        Me.ComboBox_COLOR = New System.Windows.Forms.ComboBox()
        Me.ComboBox_TALLA = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ESTILO = New System.Windows.Forms.ComboBox()
        Me.ComboBox_CPO = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Finalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Subtitulo
        '
        Me.Subtitulo.AutoSize = True
        Me.Subtitulo.Location = New System.Drawing.Point(228, 81)
        Me.Subtitulo.Name = "Subtitulo"
        Me.Subtitulo.Size = New System.Drawing.Size(454, 13)
        Me.Subtitulo.TabIndex = 52
        Me.Subtitulo.Text = "Revisa que tus columnas coicidan con el nombre de cada campo para hacer el ingres" &
    "o masivo"
        '
        'PRECIO
        '
        Me.PRECIO.AutoSize = True
        Me.PRECIO.Location = New System.Drawing.Point(209, 315)
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Size = New System.Drawing.Size(47, 13)
        Me.PRECIO.TabIndex = 51
        Me.PRECIO.Text = "PRECIO"
        '
        'MAXIMO_P
        '
        Me.MAXIMO_P.AutoSize = True
        Me.MAXIMO_P.Location = New System.Drawing.Point(63, 315)
        Me.MAXIMO_P.Name = "MAXIMO_P"
        Me.MAXIMO_P.Size = New System.Drawing.Size(63, 13)
        Me.MAXIMO_P.TabIndex = 50
        Me.MAXIMO_P.Text = "MAXIMO_P"
        '
        'MINIMO_P
        '
        Me.MINIMO_P.AutoSize = True
        Me.MINIMO_P.Location = New System.Drawing.Point(804, 235)
        Me.MINIMO_P.Name = "MINIMO_P"
        Me.MINIMO_P.Size = New System.Drawing.Size(60, 13)
        Me.MINIMO_P.TabIndex = 49
        Me.MINIMO_P.Text = "MINIMO_P"
        '
        'ESCALA
        '
        Me.ESCALA.AutoSize = True
        Me.ESCALA.Location = New System.Drawing.Point(672, 235)
        Me.ESCALA.Name = "ESCALA"
        Me.ESCALA.Size = New System.Drawing.Size(48, 13)
        Me.ESCALA.TabIndex = 48
        Me.ESCALA.Text = "ESCALA"
        '
        'COMISION
        '
        Me.COMISION.AutoSize = True
        Me.COMISION.Location = New System.Drawing.Point(507, 235)
        Me.COMISION.Name = "COMISION"
        Me.COMISION.Size = New System.Drawing.Size(60, 13)
        Me.COMISION.TabIndex = 47
        Me.COMISION.Text = "COMISION"
        '
        'VENDEDOR
        '
        Me.VENDEDOR.AutoSize = True
        Me.VENDEDOR.Location = New System.Drawing.Point(348, 235)
        Me.VENDEDOR.Name = "VENDEDOR"
        Me.VENDEDOR.Size = New System.Drawing.Size(68, 13)
        Me.VENDEDOR.TabIndex = 46
        Me.VENDEDOR.Text = "VENDEDOR"
        '
        'DESTINO
        '
        Me.DESTINO.AutoSize = True
        Me.DESTINO.Location = New System.Drawing.Point(209, 235)
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.Size = New System.Drawing.Size(55, 13)
        Me.DESTINO.TabIndex = 45
        Me.DESTINO.Text = "DESTINO"
        '
        'ESTADO
        '
        Me.ESTADO.AutoSize = True
        Me.ESTADO.Location = New System.Drawing.Point(63, 235)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(51, 13)
        Me.ESTADO.TabIndex = 44
        Me.ESTADO.Text = "ESTADO"
        '
        'TOTAL
        '
        Me.TOTAL.AutoSize = True
        Me.TOTAL.Location = New System.Drawing.Point(822, 159)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(42, 13)
        Me.TOTAL.TabIndex = 43
        Me.TOTAL.Text = "TOTAL"
        '
        'UNIDADES
        '
        Me.UNIDADES.AutoSize = True
        Me.UNIDADES.Location = New System.Drawing.Point(657, 159)
        Me.UNIDADES.Name = "UNIDADES"
        Me.UNIDADES.Size = New System.Drawing.Size(63, 13)
        Me.UNIDADES.TabIndex = 42
        Me.UNIDADES.Text = "UNIDADES"
        '
        'TALLA
        '
        Me.TALLA.AutoSize = True
        Me.TALLA.Location = New System.Drawing.Point(518, 159)
        Me.TALLA.Name = "TALLA"
        Me.TALLA.Size = New System.Drawing.Size(40, 13)
        Me.TALLA.TabIndex = 41
        Me.TALLA.Text = "TALLA"
        '
        'COLOR
        '
        Me.COLOR.AutoSize = True
        Me.COLOR.Location = New System.Drawing.Point(355, 159)
        Me.COLOR.Name = "COLOR"
        Me.COLOR.Size = New System.Drawing.Size(44, 13)
        Me.COLOR.TabIndex = 40
        Me.COLOR.Text = "COLOR"
        '
        'ESTILO
        '
        Me.ESTILO.AutoSize = True
        Me.ESTILO.Location = New System.Drawing.Point(205, 159)
        Me.ESTILO.Name = "ESTILO"
        Me.ESTILO.Size = New System.Drawing.Size(45, 13)
        Me.ESTILO.TabIndex = 39
        Me.ESTILO.Text = "ESTILO"
        '
        'CPO
        '
        Me.CPO.AutoSize = True
        Me.CPO.Location = New System.Drawing.Point(76, 159)
        Me.CPO.Name = "CPO"
        Me.CPO.Size = New System.Drawing.Size(29, 13)
        Me.CPO.TabIndex = 38
        Me.CPO.Text = "CPO"
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.BackColor = System.Drawing.SystemColors.MenuText
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Titulo.Location = New System.Drawing.Point(164, 45)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(598, 24)
        Me.Titulo.TabIndex = 37
        Me.Titulo.Text = "RECOPILADOR DE DATOS PARA TABLA TEMPORAL DE CPO"
        '
        'Boton_cargar
        '
        Me.Boton_cargar.Location = New System.Drawing.Point(720, 349)
        Me.Boton_cargar.Name = "Boton_cargar"
        Me.Boton_cargar.Size = New System.Drawing.Size(162, 48)
        Me.Boton_cargar.TabIndex = 36
        Me.Boton_cargar.Text = "Cargar"
        Me.Boton_cargar.UseVisualStyleBackColor = True
        '
        'ComboBox_ESCALA
        '
        Me.ComboBox_ESCALA.FormattingEnabled = True
        Me.ComboBox_ESCALA.Location = New System.Drawing.Point(627, 260)
        Me.ComboBox_ESCALA.Name = "ComboBox_ESCALA"
        Me.ComboBox_ESCALA.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ESCALA.TabIndex = 66
        '
        'ComboBox_MAXIMO_P
        '
        Me.ComboBox_MAXIMO_P.FormattingEnabled = True
        Me.ComboBox_MAXIMO_P.Location = New System.Drawing.Point(21, 350)
        Me.ComboBox_MAXIMO_P.Name = "ComboBox_MAXIMO_P"
        Me.ComboBox_MAXIMO_P.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_MAXIMO_P.TabIndex = 65
        '
        'ComboBox_PRECIO
        '
        Me.ComboBox_PRECIO.FormattingEnabled = True
        Me.ComboBox_PRECIO.Location = New System.Drawing.Point(163, 350)
        Me.ComboBox_PRECIO.Name = "ComboBox_PRECIO"
        Me.ComboBox_PRECIO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_PRECIO.TabIndex = 64
        '
        'ComboBox_VENDEDOR
        '
        Me.ComboBox_VENDEDOR.FormattingEnabled = True
        Me.ComboBox_VENDEDOR.Location = New System.Drawing.Point(313, 260)
        Me.ComboBox_VENDEDOR.Name = "ComboBox_VENDEDOR"
        Me.ComboBox_VENDEDOR.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_VENDEDOR.TabIndex = 63
        '
        'ComboBox_COMISION
        '
        Me.ComboBox_COMISION.FormattingEnabled = True
        Me.ComboBox_COMISION.Location = New System.Drawing.Point(475, 260)
        Me.ComboBox_COMISION.Name = "ComboBox_COMISION"
        Me.ComboBox_COMISION.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_COMISION.TabIndex = 62
        '
        'ComboBox_MINIMO_P
        '
        Me.ComboBox_MINIMO_P.FormattingEnabled = True
        Me.ComboBox_MINIMO_P.Location = New System.Drawing.Point(777, 260)
        Me.ComboBox_MINIMO_P.Name = "ComboBox_MINIMO_P"
        Me.ComboBox_MINIMO_P.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_MINIMO_P.TabIndex = 61
        '
        'ComboBox_UNIDADES
        '
        Me.ComboBox_UNIDADES.FormattingEnabled = True
        Me.ComboBox_UNIDADES.Location = New System.Drawing.Point(627, 186)
        Me.ComboBox_UNIDADES.Name = "ComboBox_UNIDADES"
        Me.ComboBox_UNIDADES.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_UNIDADES.TabIndex = 60
        '
        'ComboBox_TOTAL
        '
        Me.ComboBox_TOTAL.FormattingEnabled = True
        Me.ComboBox_TOTAL.Location = New System.Drawing.Point(777, 186)
        Me.ComboBox_TOTAL.Name = "ComboBox_TOTAL"
        Me.ComboBox_TOTAL.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_TOTAL.TabIndex = 59
        '
        'ComboBox_ESTADO
        '
        Me.ComboBox_ESTADO.FormattingEnabled = True
        Me.ComboBox_ESTADO.Location = New System.Drawing.Point(21, 260)
        Me.ComboBox_ESTADO.Name = "ComboBox_ESTADO"
        Me.ComboBox_ESTADO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ESTADO.TabIndex = 58
        '
        'ComboBox_DESTINO
        '
        Me.ComboBox_DESTINO.FormattingEnabled = True
        Me.ComboBox_DESTINO.Location = New System.Drawing.Point(163, 260)
        Me.ComboBox_DESTINO.Name = "ComboBox_DESTINO"
        Me.ComboBox_DESTINO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DESTINO.TabIndex = 57
        '
        'ComboBox_COLOR
        '
        Me.ComboBox_COLOR.FormattingEnabled = True
        Me.ComboBox_COLOR.Location = New System.Drawing.Point(313, 186)
        Me.ComboBox_COLOR.Name = "ComboBox_COLOR"
        Me.ComboBox_COLOR.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_COLOR.TabIndex = 56
        '
        'ComboBox_TALLA
        '
        Me.ComboBox_TALLA.FormattingEnabled = True
        Me.ComboBox_TALLA.Location = New System.Drawing.Point(475, 186)
        Me.ComboBox_TALLA.Name = "ComboBox_TALLA"
        Me.ComboBox_TALLA.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_TALLA.TabIndex = 55
        '
        'ComboBox_ESTILO
        '
        Me.ComboBox_ESTILO.FormattingEnabled = True
        Me.ComboBox_ESTILO.Location = New System.Drawing.Point(163, 186)
        Me.ComboBox_ESTILO.Name = "ComboBox_ESTILO"
        Me.ComboBox_ESTILO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ESTILO.TabIndex = 54
        '
        'ComboBox_CPO
        '
        Me.ComboBox_CPO.FormattingEnabled = True
        Me.ComboBox_CPO.Location = New System.Drawing.Point(21, 186)
        Me.ComboBox_CPO.Name = "ComboBox_CPO"
        Me.ComboBox_CPO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_CPO.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Finalizar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 701)
        Me.Panel1.TabIndex = 67
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(510, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Seleccione la fecha prometida"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(289, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 68
        '
        'Finalizar
        '
        Me.Finalizar.Location = New System.Drawing.Point(647, 61)
        Me.Finalizar.Name = "Finalizar"
        Me.Finalizar.Size = New System.Drawing.Size(124, 33)
        Me.Finalizar.TabIndex = 5
        Me.Finalizar.Text = "Finalizar"
        Me.Finalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SI TODO ESTA EN ORDEN PROCEDER A LA INSERCION, CASO CONTRARIO CERRAR LA PANTALLA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(21, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 311)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VISTA DE CPO DETALLADA"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(6, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(861, 255)
        Me.DataGridView1.TabIndex = 1
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'Carga_de_cpos_masiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 506)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox_ESCALA)
        Me.Controls.Add(Me.ComboBox_MAXIMO_P)
        Me.Controls.Add(Me.ComboBox_PRECIO)
        Me.Controls.Add(Me.ComboBox_VENDEDOR)
        Me.Controls.Add(Me.ComboBox_COMISION)
        Me.Controls.Add(Me.ComboBox_MINIMO_P)
        Me.Controls.Add(Me.ComboBox_UNIDADES)
        Me.Controls.Add(Me.ComboBox_TOTAL)
        Me.Controls.Add(Me.ComboBox_ESTADO)
        Me.Controls.Add(Me.ComboBox_DESTINO)
        Me.Controls.Add(Me.ComboBox_COLOR)
        Me.Controls.Add(Me.ComboBox_TALLA)
        Me.Controls.Add(Me.ComboBox_ESTILO)
        Me.Controls.Add(Me.ComboBox_CPO)
        Me.Controls.Add(Me.Subtitulo)
        Me.Controls.Add(Me.PRECIO)
        Me.Controls.Add(Me.MAXIMO_P)
        Me.Controls.Add(Me.MINIMO_P)
        Me.Controls.Add(Me.ESCALA)
        Me.Controls.Add(Me.COMISION)
        Me.Controls.Add(Me.VENDEDOR)
        Me.Controls.Add(Me.DESTINO)
        Me.Controls.Add(Me.ESTADO)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.UNIDADES)
        Me.Controls.Add(Me.TALLA)
        Me.Controls.Add(Me.COLOR)
        Me.Controls.Add(Me.ESTILO)
        Me.Controls.Add(Me.CPO)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Boton_cargar)
        Me.Name = "Carga_de_cpos_masiva"
        Me.Text = "Carga_de_cpos_masiva"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Subtitulo As Label
    Friend WithEvents PRECIO As Label
    Friend WithEvents MAXIMO_P As Label
    Friend WithEvents MINIMO_P As Label
    Friend WithEvents ESCALA As Label
    Friend WithEvents COMISION As Label
    Friend WithEvents VENDEDOR As Label
    Friend WithEvents DESTINO As Label
    Friend WithEvents ESTADO As Label
    Friend WithEvents TOTAL As Label
    Friend WithEvents UNIDADES As Label
    Friend WithEvents TALLA As Label
    Friend WithEvents COLOR As Label
    Friend WithEvents ESTILO As Label
    Friend WithEvents CPO As Label
    Friend WithEvents Titulo As Label
    Friend WithEvents Boton_cargar As Button
    Friend WithEvents ComboBox_ESCALA As ComboBox
    Friend WithEvents ComboBox_MAXIMO_P As ComboBox
    Friend WithEvents ComboBox_PRECIO As ComboBox
    Friend WithEvents ComboBox_VENDEDOR As ComboBox
    Friend WithEvents ComboBox_COMISION As ComboBox
    Friend WithEvents ComboBox_MINIMO_P As ComboBox
    Friend WithEvents ComboBox_UNIDADES As ComboBox
    Friend WithEvents ComboBox_TOTAL As ComboBox
    Friend WithEvents ComboBox_ESTADO As ComboBox
    Friend WithEvents ComboBox_DESTINO As ComboBox
    Friend WithEvents ComboBox_COLOR As ComboBox
    Friend WithEvents ComboBox_TALLA As ComboBox
    Friend WithEvents ComboBox_ESTILO As ComboBox
    Friend WithEvents ComboBox_CPO As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents Finalizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
