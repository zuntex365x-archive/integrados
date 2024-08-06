Imports C1.Win.C1FlexGrid

Public Class Entradas_d
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim lineas As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim sal As New DataTable
    Dim yardas As Decimal
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cort As System.Windows.Forms.TextBox
    Friend WithEvents BAT As System.Windows.Forms.TextBox
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents SI As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Observa As System.Windows.Forms.TextBox
    Friend WithEvents Yard As System.Windows.Forms.TextBox
    Friend WithEvents Rol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tipo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entradas_d))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cort = New System.Windows.Forms.TextBox()
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
        Me.Tipo = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(664, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Corte:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "No. Batch:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(184, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 22)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "No. Rollo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(344, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "No. Yardas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cort
        '
        Me.cort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cort.Location = New System.Drawing.Point(664, 32)
        Me.cort.MaxLength = 10
        Me.cort.Name = "cort"
        Me.cort.Size = New System.Drawing.Size(136, 22)
        Me.cort.TabIndex = 4
        Me.cort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.cort, "Número de Corte.")
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Enabled = False
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(40, 32)
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
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(767, 80)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(60, 40)
        Me.CANCELA.TabIndex = 9
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" &
        " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(702, 80)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(60, 40)
        Me.GRABA.TabIndex = 10
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
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
        Me.SI.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SI.ForeColor = System.Drawing.Color.Black
        Me.SI.Image = CType(resources.GetObject("SI.Image"), System.Drawing.Image)
        Me.SI.Location = New System.Drawing.Point(636, 80)
        Me.SI.Name = "SI"
        Me.SI.Size = New System.Drawing.Size(60, 40)
        Me.SI.TabIndex = 8
        Me.SI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.SI, "Presione este Boton para aceptar los Rollos Seleccionados.")
        Me.SI.UseVisualStyleBackColor = False
        '
        'Observa
        '
        Me.Observa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observa.Location = New System.Drawing.Point(344, 32)
        Me.Observa.MaxLength = 20
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
        Me.Yard.MaxLength = 10
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
        Me.Rol.MaxLength = 6
        Me.Rol.Name = "Rol"
        Me.Rol.Size = New System.Drawing.Size(136, 22)
        Me.Rol.TabIndex = 6
        Me.Rol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Rol, "Batch de Tela que utilizaremos para el Corte.")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(184, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 22)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Tipo de Entrada"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tipo
        '
        Me.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo.Enabled = False
        Me.Tipo.Items.AddRange(New Object() {"Devolución de Corte", "Separar Cuellos/Puños"})
        Me.Tipo.Location = New System.Drawing.Point(184, 32)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(136, 21)
        Me.Tipo.TabIndex = 2
        '
        'Entradas_d
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 644)
        Me.Controls.Add(Me.Tipo)
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
        Me.Controls.Add(Me.cort)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Entradas_d"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de Tela"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Entradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fecha.KeyPress, AddressOf keypressed1
        AddHandler Tipo.KeyPress, AddressOf keypressed2
        AddHandler Observa.KeyPress, AddressOf keypressed3
        AddHandler cort.KeyPress, AddressOf keypressed4
        AddHandler BAT.KeyPress, AddressOf keypressed5
        AddHandler Rol.KeyPress, AddressOf keypressed6
        AddHandler Yard.KeyPress, AddressOf keypressed7
        limpia_variables()
    End Sub

    Private Sub setea_grid()

        fg.Rows.Count = 1

    End Sub

    Private Sub limpia_variables()
        setea_grid()
        cort.Text = "00000"
        Observa.Text = "S/O"
        Tipo.SelectedIndex = 0
        BAT.Text = ""
        Rol.Text = ""
        Yard.Text = ""
        BAT.Enabled = False
        Rol.Enabled = False
        Yard.Enabled = False
        Observa.Enabled = True
        cort.Enabled = True
        GRABA.Visible = False
        fecha.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                Tipo.Focus()
            Else
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Tipo.Text) <> "" Then
                Observa.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Observa.Text) <> "" Then
                If Mid(Tipo.Text, 1, 5) = "Devol" Then
                    cort.Focus()
                Else
                    BAT.Focus()
                End If
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cort.Text) <> "" Then
                procesa_corte()
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
            Try
                If Trim(Yard.Text) <> "" Then
                    If IsNumeric(Yard.Text) = True And Yard.Text > 0 Then

                        SI.Focus()
                    Else
                        mensaje("Número de Yardas invalidas !!!!!")
                    End If
                End If
            Catch
                mensaje("Número de Yardas invalidas !!!!!")
            End Try
        End If
    End Sub 'keypressed
    Private Sub procesa_corte()
        Dim ok As Boolean
        Dim strsql As String = " SELECT BATCH,ROLLO,CPO,FPO,SUM(YARDAS) AS YARDAS FROM DMOVTO WHERE CORTE = '" & cort.Text & "' AND TMOVTO > '3' GROUP BY BATCH,ROLLO,CPO,FPO ORDER BY BATCH,ROLLO"
        revisa_corte(ok)
        If ok Then
            llena_tablas(sal, strsql, cnn)
            If sal.Rows.Count = 0 Then
                MsgBox("Corte no tiene rollos Despachados.", MsgBoxStyle.Critical, "Error en los datos.")
                limpia_variables()
            Else
                BAT.Enabled = True
                Rol.Enabled = True
                Yard.Enabled = True
            End If
        End If
    End Sub
    Private Sub revisa_corte(ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim prendas As Integer
        ok = False
        Dim strsql As String = "SELECT CORTES.*,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE CORTE = '" & cort.Text & "') AS PRENDAS FROM CORTES WHERE CORTE = '" & cort.Text & "'"
        llena_tablas(dt, strsql, cnn)

        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            Try
                prendas = dr("PRENDAS")
            Catch ex As Exception
                prendas = 0
            End Try
            If prendas > 0 Then
                MsgBox("Corte ya tiene producción.", vbCritical, "Con Producción")
            Else
                Observa.Enabled = False
                cort.Enabled = False
                BAT.Focus()
                ok = True
            End If
        Else
            MsgBox("CORTE NO EXISTE", vbCritical, "CORTE NO EXISTE")
        End If
    End Sub

    Private Sub busca_corte(ByRef bien As Boolean)
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM DMOVTO WHERE BATCH = '" & BAT.Text & "' AND ROLLO = '" & Rol.Text & "' AND CORTE =  '" & cort.Text + "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            bien = False
        Else
            bien = True
        End If
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox(var, MsgBoxStyle.Exclamation, "REVISE LOS DATOS!!!! ")
    End Sub

    Private Sub SI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SI.Click
        Dim bien As Boolean = True
        revisa_datos(bien)
        If bien Then
            subtotales()
            otro_rollo()
            GRABA.Visible = True
        End If
    End Sub

    Private Sub revisa_datos(ByRef bien As Boolean)
        Dim dd As DataRow()
        Dim dr As DataRow
        bien = False
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
        Try
            dd = sal.Select("BATCH = '" & BAT.Text & "' AND ROLLO = '" & Rol.Text & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                If dr("YARDAS") <> Yard.Text Then
                    MsgBox("El número de yardas no coinciden.", MsgBoxStyle.Critical, "Error en los Datos")
                    Exit Sub
                End If
                revisa_rollo(dr, bien)
            Else
                MsgBox("Este Rollo No Pertenece al Corte", MsgBoxStyle.Critical, "Error en los Datos")
            End If

        Catch
            MsgBox("Corte no tiene rollos por devolver", MsgBoxStyle.Critical, "Error en los Datos")
        End Try


    End Sub

    Private Sub revisa_rollo(ByVal dr As DataRow, ByRef bien As Boolean)
        Dim ok As Boolean
        bien = False
        busca_en_flex(ok, Rol.Text)
        If ok Then
            fg.Rows.Count = fg.Rows.Count + 1
            lineas = fg.Rows.Count - 1
            fg(lineas, 1) = BAT.Text
            fg(lineas, 2) = dr("ROLLO")
            fg(lineas, 3) = dr("FPO")
            fg(lineas, 4) = dr("CPO")
            fg(lineas, 5) = dr("YARDAS")
            bien = True
        End If
    End Sub

    Private Sub busca_en_flex(ByRef ok As Boolean, ByVal rollo As Integer)
        ok = True
        Dim pos As Integer
        pos = fg.FindRow(CStr(rollo), 1, 2, True)
        While pos <> -1
            If fg(pos, 1) = BAT.Text Then
                ok = False
                mensaje("Rollo " + Str(rollo) + " Ya existe en el Documento ")
                Exit Sub
            End If
            Try
                pos = fg.FindRow(CStr(rollo), pos + 1, 2, True)
            Catch
                pos = -1
            End Try
        End While
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
        revisa_yardas(si)
        If si Then
            graba_documento()
            limpia_variables()
        End If
    End Sub

    Private Sub revisa_yardas(ByRef ok As Boolean)
        Dim yd As Object
        Dim i As Integer
        yardas = 0
        fg.Subtotal(AggregateEnum.Clear)
        For i = 1 To fg.Rows.Count - 1
            yardas = yardas + fg(i, 5)
        Next
        yd = sal.Compute("SUM(YARDAS)", String.Empty)
        If CDec(yd) <> yardas Then
            MsgBox("No coincide el número Total de Yardas." + vbLf + "Yardas Ingresadas: " + CStr(yardas) + vbLf + "Yardas Corte: " + CStr(yd), MsgBoxStyle.Critical, "Error en los Datos")
            ok = False
        Else
            ok = True
        End If

    End Sub
    Private Sub graba_documento()
        Dim afectados As Integer
        Dim strSQL As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strSQL = "UPDATE CORTES_DEV SET TELAS = '" & yardas & "' WHERE CORTE = '" & cort.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO CORTES_DEV (CORTE,TELAS,MATERIALES,ESTADO) VALUES (" &
                                      "'" & cort.Text & "','" & yardas & "','0','A')"

                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()
            MsgBox("Grabacion Exitosa.", MsgBoxStyle.Information, "Datos Actualizados !!!!")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
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
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 1, 5, "Totales {0}")
    End Sub

End Class
