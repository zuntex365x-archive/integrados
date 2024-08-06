Imports C1.Win.C1FlexGrid

Public Class corte
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim lineas As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim dr As DataRow
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BAT As System.Windows.Forms.TextBox
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents SI As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents R1 As System.Windows.Forms.ComboBox
    Friend WithEvents R2 As System.Windows.Forms.ComboBox
    Friend WithEvents Cort As System.Windows.Forms.ComboBox
    Friend WithEvents client As System.Windows.Forms.Label
    Friend WithEvents Cpo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(corte))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.BAT = New System.Windows.Forms.TextBox()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SI = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.ComboBox()
        Me.R2 = New System.Windows.Forms.ComboBox()
        Me.Cort = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.client = New System.Windows.Forms.Label()
        Me.Cpo = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Corte:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
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
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(504, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 22)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "CPO:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label6.Text = "Rollo Inicial:"
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
        Me.Label7.Text = "Rollo Final:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(200, 32)
        Me.fecha.Name = "fecha"
        Me.fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecha.Size = New System.Drawing.Size(112, 22)
        Me.fecha.TabIndex = 2
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
        Me.Label3.Size = New System.Drawing.Size(136, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Cliente:"
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
        'R1
        '
        Me.R1.Location = New System.Drawing.Point(184, 104)
        Me.R1.Name = "R1"
        Me.R1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R1.Size = New System.Drawing.Size(136, 21)
        Me.R1.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.R1, "Rollo Inicial que se utilizo para el Corte.")
        '
        'R2
        '
        Me.R2.Location = New System.Drawing.Point(344, 104)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(136, 21)
        Me.R2.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.R2, "Rollo final que se utilizo para el Corte.")
        '
        'Cort
        '
        Me.Cort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cort.Location = New System.Drawing.Point(24, 32)
        Me.Cort.Name = "Cort"
        Me.Cort.Size = New System.Drawing.Size(136, 24)
        Me.Cort.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.Cort, "Cliente para el cual se efectuo el Corte.")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(12, 138)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(878, 462)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'client
        '
        Me.client.BackColor = System.Drawing.Color.White
        Me.client.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.client.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client.ForeColor = System.Drawing.Color.Black
        Me.client.Location = New System.Drawing.Point(344, 32)
        Me.client.Name = "client"
        Me.client.Size = New System.Drawing.Size(136, 24)
        Me.client.TabIndex = 49
        Me.client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cpo
        '
        Me.Cpo.BackColor = System.Drawing.Color.White
        Me.Cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpo.ForeColor = System.Drawing.Color.Black
        Me.Cpo.Location = New System.Drawing.Point(504, 32)
        Me.Cpo.Name = "Cpo"
        Me.Cpo.Size = New System.Drawing.Size(136, 24)
        Me.Cpo.TabIndex = 50
        Me.Cpo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'corte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(902, 612)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Cpo)
        Me.Controls.Add(Me.client)
        Me.Controls.Add(Me.Cort)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.SI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.GRABA)
        Me.Controls.Add(Me.BAT)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "corte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas por Corte"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub corte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cort.KeyPress, AddressOf keypressed1
        AddHandler fecha.KeyPress, AddressOf keypressed2
        AddHandler client.KeyPress, AddressOf keypressed3
        AddHandler Cpo.KeyPress, AddressOf keypressed4
        AddHandler BAT.KeyPress, AddressOf keypressed5
        AddHandler R1.KeyPress, AddressOf keypressed6
        AddHandler R2.KeyPress, AddressOf keypressed7
        llena_cortes()
        'busca_corte()
        limpia_variables()
        fecha.Enabled = False
    End Sub



    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 9
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "FPO"
        fg.Cols(4).Name = "KNIT"
        fg.Cols(5).Name = "COLOR"
        fg.Cols(6).Name = "LIBRAS"
        fg.Cols(7).Name = "PRECIO"
        fg.Cols(8).Name = "YARDAS"
        fg.Cols(2).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(2).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(6).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(6).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(6).DataType = GetType(Decimal)
        fg.Cols(6).Format = "######.00"
        fg.Cols(7).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(7).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(7).DataType = GetType(Decimal)
        fg.Cols(7).Format = "######.00"
        fg.Cols(8).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(8).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(8).DataType = GetType(Decimal)
        fg.Cols(8).Format = "######.00"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 105
            fg(0, index) = fg.Cols(index).Name
        Next
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        BAT.Text = ""
        R1.Items.Clear()
        R2.Items.Clear()
        GRABA.Visible = False
        Cort.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cort.Text) <> "" Then
                Cpo.Focus()
            Else
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                client.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(client.Text) <> "" Then
                Cpo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cpo.Text) <> "" Then
                BAT.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(BAT.Text) <> "" Then
                Dim si As Boolean
                revisa_rango(si)
                If si Then
                    R1.Focus()
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(R1.Text) <> "" Then
                If IsNumeric(R1.Text) = True And R1.Text > 0 Then
                    SI.Focus()
                Else
                    mensaje("Rollo Inicial Invalido !!!!!")
                End If
                R2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(R2.Text) <> "" Then
                If IsNumeric(R2.Text) = True And R2.Text > 0 Then
                    SI.Focus()
                Else
                    mensaje("Rollo Final Invalido !!!!!")
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
            revisa_batch(bien)
        End If
        If bien Then
            subtotales()
            otro_batch()
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
        If Trim(R1.Text) = "" Then
            mensaje("Número de Rollo INICIAL Invalido !!!")
            bien = False
            Exit Sub
        End If
        If Trim(R2.Text) = "" Then
            mensaje("Número de Rollo FINAL Invalido !!!")
            bien = False
            Exit Sub
        End If
        If CDec(R2.Text) < CDec(R1.Text) Then
            mensaje("Número de Rollo FINAL ES MENOR QUE EL ROLLO INICIAL!!!")
            bien = False
            Exit Sub
        End If
    End Sub

    Private Sub revisa_batch(ByRef bien As Boolean)
        Dim i As Integer
        Dim YARDAS As Decimal
        Dim ok As Boolean = True
        Dim despachado As String = ""
        bien = False
        For i = Int(R1.Text) To Int(R2.Text)
            Dim strSQL As String = "SELECT * FROM ROLLOS LEFT JOIN REQ_D ON ROLLOS.BATCH =REQ_D.BATCH AND ROLLOS.ROLLO = REQ_D.ROLLO WHERE ROLLOS.BATCH = '" & BAT.Text & "' AND ROLLOS.ROLLO = '" & CStr(i) & "'"
            llena_tablas(dt, strSQL, cnn)
            For Each Me.dr In dt.Rows
                YARDAS = dr("YARDAS")
                Try
                    despachado = dr("DESPACHADO")
                Catch ex As Exception
                    despachado = ""
                End Try
                busca_en_flex(ok, BAT.Text, Str(i))
                If Not ok Then
                    mensaje("Rollo " + Str(i) + " Ya existe en el Documento ")
                End If
                If despachado = "N" Then
                    mensaje("El rollo " + Str(i) + " Se encuentra Reservado para el CORTE " & dr("CORTE"))
                    ok = False
                Else
                    despachado = ""
                End If
                If ok Then
                    If YARDAS > 0 And despachado = "" Then
                        fg.Rows.Count = fg.Rows.Count + 1
                        lineas = fg.Rows.Count - 1
                        fg(lineas, 1) = BAT.Text
                        fg(lineas, 2) = dr("ROLLO")
                        fg(lineas, 3) = dr("FPO")
                        fg(lineas, 4) = dr("KNIT")
                        fg(lineas, 5) = dr("COLOR")
                        fg(lineas, 6) = dr("PESO")
                        fg(lineas, 7) = dr("COSTO")
                        fg(lineas, 8) = YARDAS
                        bien = True
                    Else
                        mensaje("El rollo " + Str(i) + " Ya no tiene existencia en Yardas ")
                    End If
                End If

            Next
            If dt.Rows.Count = 0 Then
                mensaje("Rollo " + CStr(i) + "No existe !!!!!")
            End If
        Next
    End Sub


    Private Sub busca_en_flex(ByRef ok As Boolean, ByVal batch As String, ByVal rollo As Integer)
        ok = True
        Dim j As Integer
        For j = 1 To fg.Rows.Count - 1
            If fg(j, 1) = batch And fg(j, 2) = rollo Then
                ok = False
                Exit For
            End If
        Next
        Exit Sub
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        limpia_variables()
    End Sub

    Private Sub revisa_rango(ByRef si As Boolean)
        Dim strSQL As String = "SELECT * FROM ROLLOS WHERE BATCH = '" & BAT.Text & "' ORDER BY ROLLO "
                    llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            Dim yardas As Decimal = dr("YARDAS")
            If yardas > 0 Then
                R1.Items.Add(dr("ROLLO"))
                R2.Items.Add(dr("ROLLO"))
                si = True
            End If
        Next
        If dt.Rows.Count = 0 Then
            mensaje("No existen Rollos para este Batch !!!!!")
            otro_batch()
            si = False
        Else
            R1.SelectedIndex = 0
            R2.SelectedIndex = 0
        End If
    End Sub

    Private Sub otro_batch()
        BAT.Text = ""
        R1.Items.Clear()
        R2.Items.Clear()
        BAT.Focus()
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        Dim si As Boolean = True
        revisa_encabezado(si)
        If si Then
            graba_documento()
            limpia_variables()
        End If
    End Sub

    Private Sub revisa_encabezado(ByRef bien As Boolean)
        If Trim(Cort.Text) = "" Or IsNumeric(Cort.Text) = False Then
            mensaje("Número de Corte Invalido !!!")
            bien = False
        End If
        If Trim(Cpo.Text) = "" Then
            mensaje("Número de CPO Invalida !!!")
            bien = False
        End If
    End Sub

    Private Sub graba_documento()
        Dim recordsEffected As Integer
        Dim strSQL As String
        Dim CORR As Integer
        Dim I As Integer
        Dim BATCH As String
        Dim ROLLO As Integer
        Dim PRECIO As Decimal
        Dim FPO As String
        Dim YARDAS As Decimal
        Dim LIBRAS As Decimal
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        strSQL = "SELECT SALIDAS FROM CORRELATIVO"
        fg.Subtotal(AggregateEnum.Clear)
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            CORR = dr("SALIDAS") + 1
        Next
        If dt.Rows.Count = 0 Then
            Close()
        End If
        strSQL = "UPDATE CORRELATIVO SET SALIDAS = '" & CORR & "'"
        grabar_sql(strSQL, cnn, recordsEffected)
        If CInt(recordsEffected) = 1 Then
            strSQL = "INSERT INTO EMOVTO (DOCTO, TMOVTO, FECHA, COMENTARIO) VALUES (" & _
                                  "'" & CORR & "','4','" & fechas & "','CORTE: " & Cort.Text & "')"
            grabar_sql(strSQL, cnn, recordsEffected)
            For I = 1 To fg.Rows.Count - 1
                BATCH = fg(I, 1)
                ROLLO = fg(I, 2)
                FPO = fg(I, 3)
                PRECIO = CDec(fg(I, 7))
                YARDAS = CDec(fg(I, 8))
                LIBRAS = CDec(fg(I, 6))
                strSQL = "INSERT INTO DMOVTO (DOCTO, TMOVTO, BATCH, ROLLO, FECHA, CLIENTE, FPO, CPO, CORTE, YARDAS, LIBRAS, PRECIO) VALUES ( " & _
                                      "'" & CORR & "','4','" & BATCH & "','" & ROLLO & "','" & fechas & "','" & _
                                      client.Text & "','" & FPO & "','" & Cpo.Text & "','" & Cort.Text & "','" & YARDAS & "','" & LIBRAS & "','" & PRECIO & "')"
                grabar_sql(strSQL, cnn, recordsEffected)
                strSQL = "UPDATE ROLLOS SET YARDAS = '0', ACTIVO = 'N' WHERE BATCH = '" & BATCH & "' AND ROLLO = '" & ROLLO & "'"
                grabar_sql(strSQL, cnn, recordsEffected)
                strSQL = "UPDATE REQ_D SET DESPACHADO = 'S' WHERE BATCH = '" & BATCH & "' AND ROLLO = '" & ROLLO & "'"
                grabar_sql(strSQL, cnn, recordsEffected)
            Next
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 1, 8, "Totales {0}")
    End Sub

    Private Sub llena_cortes()
        Dim strSQL As String = "SELECT * FROM CORTES WHERE EXPORTADO <> 'S'"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            Cort.Items.Add(dr("CORTE"))
        Next
        Cort.SelectedIndex = 0
    End Sub

    Private Sub busca_corte()
        Dim strSQL As String = "SELECT * FROM CORTES WHERE CORTE = '" & Cort.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            client.Text = dr("CLIENTE")
            Cpo.Text = dr("CPO")
        Next
    End Sub

    Private Sub Cort_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cort.SelectedIndexChanged
        busca_corte()
    End Sub
    Private Sub CORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cort.KeyPress
        AutoCompletar(Cort, e)
    End Sub
    Private Sub r1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles R1.KeyPress
        AutoCompletar(R1, e)
    End Sub
    Private Sub r2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles R2.KeyPress
        AutoCompletar(R2, e)
    End Sub
End Class
