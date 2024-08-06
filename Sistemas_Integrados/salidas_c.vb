Imports C1.Win.C1FlexGrid

Public Class Salidas_c
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim lineas As Integer
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Dim cnn1 As New SqlClient.SqlConnection()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BAT As System.Windows.Forms.TextBox
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents SI As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Observa As System.Windows.Forms.TextBox
    Friend WithEvents Yard As System.Windows.Forms.TextBox
    Friend WithEvents Rol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salidas_c))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.BAT = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SI = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Observa = New System.Windows.Forms.TextBox()
        Me.Yard = New System.Windows.Forms.TextBox()
        Me.Rol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.corte = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "No. Batch:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 22)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "No. Rollo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "No. Yardas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(24, 32)
        Me.fecha.Name = "fecha"
        Me.fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecha.Size = New System.Drawing.Size(112, 22)
        Me.fecha.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha en que se efectuo el Corte.")
        '
        'BAT
        '
        Me.BAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAT.Location = New System.Drawing.Point(24, 104)
        Me.BAT.MaxLength = 15
        Me.BAT.Name = "BAT"
        Me.BAT.Size = New System.Drawing.Size(136, 22)
        Me.BAT.TabIndex = 5
        Me.BAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.BAT, "Batch de Tela que utilizaremos para el Corte.")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 136)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(896, 488)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.fg, "Presione Doble click para eliminar la línea seleccionada.")
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(816, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 9
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
                " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(776, 16)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(35, 35)
        Me.GRABA.TabIndex = 10
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Observaciones / Comentarios"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SI
        '
        Me.SI.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SI.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SI.ForeColor = System.Drawing.Color.Black
        Me.SI.Image = CType(resources.GetObject("SI.Image"), System.Drawing.Image)
        Me.SI.Location = New System.Drawing.Point(736, 16)
        Me.SI.Name = "SI"
        Me.SI.Size = New System.Drawing.Size(35, 35)
        Me.SI.TabIndex = 8
        Me.SI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.SI, "Presione este Boton para aceptar los Rollos Seleccionados.")
        Me.SI.UseVisualStyleBackColor = False
        '
        'Observa
        '
        Me.Observa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observa.Location = New System.Drawing.Point(344, 32)
        Me.Observa.MaxLength = 25
        Me.Observa.Name = "Observa"
        Me.Observa.Size = New System.Drawing.Size(296, 22)
        Me.Observa.TabIndex = 3
        Me.Observa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Observa, "Batch de Tela que utilizaremos para el Corte.")
        '
        'Yard
        '
        Me.Yard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yard.Location = New System.Drawing.Point(344, 104)
        Me.Yard.MaxLength = 15
        Me.Yard.Name = "Yard"
        Me.Yard.Size = New System.Drawing.Size(136, 22)
        Me.Yard.TabIndex = 7
        Me.Yard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Yard, "Batch de Tela que utilizaremos para el Corte.")
        '
        'Rol
        '
        Me.Rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rol.Location = New System.Drawing.Point(184, 104)
        Me.Rol.MaxLength = 15
        Me.Rol.Name = "Rol"
        Me.Rol.Size = New System.Drawing.Size(136, 22)
        Me.Rol.TabIndex = 6
        Me.Rol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Rol, "Batch de Tela que utilizaremos para el Corte.")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 22)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Corte"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'corte
        '
        Me.corte.Items.AddRange(New Object() {"Producción"})
        Me.corte.Location = New System.Drawing.Point(184, 32)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(136, 21)
        Me.corte.TabIndex = 53
        '
        'Salidas_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 644)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Rol)
        Me.Controls.Add(Me.Yard)
        Me.Controls.Add(Me.Observa)
        Me.Controls.Add(Me.SI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.GRABA)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.BAT)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Salidas_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas por Produccion de Cuellos y Puños"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub salidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fecha.KeyPress, AddressOf keypressed1
        AddHandler corte.KeyPress, AddressOf keypressed2
        AddHandler Observa.KeyPress, AddressOf keypressed3
        AddHandler BAT.KeyPress, AddressOf keypressed5
        AddHandler Rol.KeyPress, AddressOf keypressed6
        AddHandler Yard.KeyPress, AddressOf keypressed7
        llena_combos(corte, "SELECT CORTE FROM CORTES WHERE EXPORTADO <> 'S'", "CORTE")
        limpia_variables()
        fecha.Enabled = False
    End Sub


    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 13
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "FPO"
        fg.Cols(4).Name = "KNIT"
        fg.Cols(5).Name = "COLOR"
        fg.Cols(6).Name = "CLIENTE"
        fg.Cols(7).Name = "CPO"
        fg.Cols(8).Name = "COSTO"
        fg.Cols(9).Name = "LIBRAS"
        fg.Cols(10).Name = "YARDAS"
        fg.Cols(2).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(2).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(9).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(9).DataType = GetType(Decimal)
        fg.Cols(9).Format = "######.00"
        fg.Cols(10).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(10).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(10).DataType = GetType(Decimal)
        fg.Cols(10).Format = "######.00"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 100
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(1).Width = 75
        fg.Cols(2).Width = 70
        fg.Cols(8).Width = 70
        fg.Cols(9).Width = 70
        fg.Cols(10).Width = 70
        fg.Cols(11).Visible = False
        fg.Cols(12).Visible = False
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        Observa.Text = "S/O"
        corte.SelectedIndex = 0
        BAT.Text = ""
        Rol.Text = ""
        Yard.Text = ""
        GRABA.Visible = False
        fecha.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                corte.Focus()
            Else
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                Observa.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Observa.Text) <> "" Then
                BAT.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(BAT.Text) <> "" Then
                Rol.Focus()
            End If
        End If
    End Sub 'keypressed



    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Rol.Text) <> "" Then
                If IsNumeric(Rol.Text) = True And Rol.Text > 0 Then
                    Yard.Focus()
                Else
                    mensaje("Número de Rollo Invalido !!!!!")
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Yard.Text) <> "" Then
                If IsNumeric(Yard.Text) = True And Yard.Text > 0 Then
                    SI.Focus()
                Else
                    mensaje("Número de Yardas invalidas !!!!!")
                End If
            End If
        End If
    End Sub 'keypressed


    Private Sub mensaje(ByVal var As String)
        MsgBox(var, MsgBoxStyle.Exclamation, "REVISE LOS DATOS!!!! ")
    End Sub


    Private Sub SI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SI.Click
        Dim bien As Boolean = True
        revisa_datos(bien)
        If bien Then
            revisa_rollo(bien)
        End If
        If bien Then
            subtotales()
            otro_rollo()
            GRABA.Visible = True
        End If
    End Sub

    Private Sub revisa_datos(ByRef bien As Boolean)
        revisa_encabezado(bien)
        If Not bien Then
            Exit Sub
        End If
        If Trim(BAT.Text) = "" Then
            mensaje("Número de BATCH Invalido !!!")
            bien = False
            Exit Sub
        End If
        If Trim(Rol.Text) = "" Or IsNumeric(Rol.Text) = False Then
            mensaje("Número de Rollo Invalido !!!")
            bien = False
            Exit Sub
        End If
        If Trim(Yard.Text) = "" Or IsNumeric(Yard.Text) = False Then
            mensaje("Número de Yardas Invalidas !!!")
            bien = False
            Exit Sub
        End If
        If CDec(Yard.Text) = 0 Then
            mensaje("Número de Yardas Invalidas !!!")
            bien = False
            Exit Sub
        End If
    End Sub

    Private Sub revisa_encabezado(ByRef bien As Boolean)
        If Trim(Observa.Text) = "" Then
            mensaje("Por favor Ingrese observaciones !!!")
            bien = False
        End If
    End Sub

    Private Sub revisa_rollo(ByRef bien As Boolean)
        Dim dt As New DataTable()
        Dim YARDAS As Decimal
        Dim YARDAS1 As Decimal
        Dim LIBRAS As Decimal
        Dim ok As Boolean = True
        bien = False
        Dim strSQL As String = "SELECT * FROM ROLLOS WHERE BATCH = '" & BAT.Text & "' AND ROLLO = '" & Rol.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            mensaje("Rollo " + Rol.Text + " No existe !!!!!")
        Else
            dr = dt.Rows(0)
            YARDAS = dr("YARDAS_I")
            YARDAS1 = dr("YARDAS")
            LIBRAS = dr("PESO")
            LIBRAS = (Yard.Text * LIBRAS) / YARDAS
            If ok And CDec(Yard.Text) > YARDAS1 Then
                mensaje("Rollo " + Rol.Text + ". Solamente tiene existencia =  " + CStr(YARDAS1) + " !!!!!")
                bien = False
                ok = False
            End If
            If ok Then
                busca_en_flex(ok, Rol.Text)
            End If
            If ok Then
                fg.Rows.Count = fg.Rows.Count + 1
                lineas = fg.Rows.Count - 1
                fg(lineas, 1) = BAT.Text
                fg(lineas, 2) = dr("ROLLO")
                fg(lineas, 3) = dr("FPO")
                fg(lineas, 4) = dr("KNIT")
                fg(lineas, 5) = dr("COLOR")
                fg(lineas, 6) = dr("CLIENTE")
                fg(lineas, 7) = dr("CPO")
                fg(lineas, 8) = dr("COSTO")
                fg(lineas, 9) = LIBRAS
                fg(lineas, 10) = Yard.Text
                fg(lineas, 11) = dr("TIPO")
                fg(lineas, 12) = dr("LOTE")
                bien = True
            End If
        End If
    End Sub


    Private Sub busca_en_flex(ByRef ok As Boolean, ByVal rollo As Integer)
        ok = True
        Dim pos As Integer
        For pos = 1 To fg.Rows.Count - 1
            If fg(pos, 2) = Rol.Text Then
                If fg(pos, 1) = BAT.Text Then
                    ok = False
                    mensaje("Batch: " + BAT.Text + "  Rollo: " + Str(rollo) + " Ya existe en el Documento ")
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        limpia_variables()
    End Sub

    Private Sub otro_rollo()
        Rol.Text = ""
        Yard.Text = ""
        Rol.Focus()
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        Dim si As Boolean = True
        revisa_encabezado(si)
        If si Then
            graba_documento()
            limpia_variables()
        End If
    End Sub


    Private Sub graba_documento()
        Dim dt As New DataTable()
        Dim afectados As Integer
        Dim strSQL As String
        Dim corr As Integer
        Dim i As Integer
        Dim tmovto As String
        Dim batch As String
        Dim rollo As Integer
        Dim precio As Decimal
        Dim fpo As String
        Dim client As String
        Dim cpo As String
        Dim yardas As Decimal
        Dim libras As Decimal
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        strSQL = "SELECT SALIDAS FROM CORRELATIVO"
        fg.Subtotal(AggregateEnum.Clear)
        llena_tablas(dt, strSQL, cnn1)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            corr = dr("SALIDAS") + 1
        End If
        tmovto = 4

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== CORRELATIVO
            strSQL = "UPDATE CORRELATIVO SET SALIDAS = " & corr
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            ' =================== ENCABEZADO
            strSQL = "INSERT INTO EMOVTO (DOCTO, TMOVTO, FECHA, COMENTARIO) VALUES (" & _
                      "'" & corr & "','" & tmovto & "','" & fechas & "','" & Observa.Text & "')"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                batch = fg(i, 1)
                rollo = fg(i, 2)
                fpo = fg(i, 3)
                client = fg(i, 6)
                cpo = fg(i, 7)
                precio = CDec(fg(i, 8))
                libras = CDec(fg(i, 9))
                yardas = CDec(fg(i, 10))

                ' =================== DETALLE
                strSQL = "INSERT INTO DMOVTO (DOCTO, TMOVTO, BATCH, ROLLO, FECHA, CLIENTE, FPO, CPO, CORTE, YARDAS, LIBRAS, PRECIO) VALUES ( " & _
                "'" & corr & "','" & tmovto & "','" & batch & "','" & rollo & "','" & fechas & "','" & _
                client & "','" & fpo & "','" & cpo & "','" & corte.Text & "','" & yardas & "','" & yardas & "','" & precio & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                ' =================== ROLLOS
                strSQL = "UPDATE ROLLOS SET  YARDAS = YARDAS -  '" & yardas & "' WHERE BATCH = '" & batch & "' AND ROLLO = '" & rollo & "'"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

            Next
            transaccion.Commit()

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


    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If fg.RowSel > 0 Then
            fg(fg.RowSel, 0) = "*"
            Dim seguro As MsgBoxResult
            seguro = MsgBox("Atencion: Desea Eliminar Esta Linea?", MsgBoxStyle.YesNo, "Eliminacion de Lineas")
            If seguro = MsgBoxResult.Yes Then
                elimina_linea()
                subtotales()
            Else
            End If
        End If
    End Sub

    Private Sub elimina_linea()
        Dim linea As Integer = fg.RowSel
        Try
            fg.Rows.Remove(linea)
        Catch
        End Try
    End Sub

    Private Sub subtotales()
        fg.Subtotal(AggregateEnum.Clear)
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 1, 10, "Totales {0}")
    End Sub

    Private Sub CORTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub
End Class
