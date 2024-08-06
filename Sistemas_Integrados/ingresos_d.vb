Imports C1.Win.C1FlexGrid

Public Class ingresos_d
    Inherits System.Windows.Forms.Form
    Dim lineas As Integer
    Dim actual As Integer
    Dim Bien As Boolean
    Dim H As String = "##,###,##0.00"
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim co As New DataTable()
    Dim mt As New DataTable()
    Dim unidadt As Decimal
    Dim mat As New DataTable
    Dim total_m As Decimal
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents But_elimina As System.Windows.Forms.Button
    Friend WithEvents But_Agrega As System.Windows.Forms.Button
    Friend WithEvents But_regresa As System.Windows.Forms.Button
    Friend WithEvents But_anula As System.Windows.Forms.Button
    Friend WithEvents But_graba As System.Windows.Forms.Button
    Friend WithEvents Corte As System.Windows.Forms.ComboBox
    Friend WithEvents cod As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresos_d))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.But_regresa = New System.Windows.Forms.Button()
        Me.But_Agrega = New System.Windows.Forms.Button()
        Me.But_elimina = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cod = New System.Windows.Forms.ComboBox()
        Me.Corte = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.But_graba = New System.Windows.Forms.Button()
        Me.But_anula = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha del Movimiento:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Motivo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(176, 31)
        Me.TextBox2.MaxLength = 80
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(539, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "ANULACION DEL CORTE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.But_regresa)
        Me.GroupBox1.Controls.Add(Me.But_Agrega)
        Me.GroupBox1.Controls.Add(Me.But_elimina)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cod)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 77)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'But_regresa
        '
        Me.But_regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_regresa.ForeColor = System.Drawing.Color.Black
        Me.But_regresa.Image = CType(resources.GetObject("But_regresa.Image"), System.Drawing.Image)
        Me.But_regresa.Location = New System.Drawing.Point(808, 24)
        Me.But_regresa.Name = "But_regresa"
        Me.But_regresa.Size = New System.Drawing.Size(35, 35)
        Me.But_regresa.TabIndex = 25
        Me.But_regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_regresa.UseVisualStyleBackColor = False
        '
        'But_Agrega
        '
        Me.But_Agrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_Agrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_Agrega.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Agrega.ForeColor = System.Drawing.Color.Black
        Me.But_Agrega.Image = CType(resources.GetObject("But_Agrega.Image"), System.Drawing.Image)
        Me.But_Agrega.Location = New System.Drawing.Point(848, 24)
        Me.But_Agrega.Name = "But_Agrega"
        Me.But_Agrega.Size = New System.Drawing.Size(35, 35)
        Me.But_Agrega.TabIndex = 24
        Me.But_Agrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_Agrega.UseVisualStyleBackColor = False
        '
        'But_elimina
        '
        Me.But_elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_elimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_elimina.ForeColor = System.Drawing.Color.Black
        Me.But_elimina.Image = CType(resources.GetObject("But_elimina.Image"), System.Drawing.Image)
        Me.But_elimina.Location = New System.Drawing.Point(768, 24)
        Me.But_elimina.Name = "But_elimina"
        Me.But_elimina.Size = New System.Drawing.Size(35, 35)
        Me.But_elimina.TabIndex = 23
        Me.But_elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_elimina.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(168, 46)
        Me.TextBox4.MaxLength = 12
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(104, 22)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(315, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(392, 21)
        Me.Label7.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Unidades:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Codigo del Material:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cod
        '
        Me.cod.BackColor = System.Drawing.Color.White
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.Location = New System.Drawing.Point(168, 16)
        Me.cod.MaxDropDownItems = 15
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(144, 24)
        Me.cod.TabIndex = 4
        '
        'Corte
        '
        Me.Corte.BackColor = System.Drawing.Color.White
        Me.Corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte.Location = New System.Drawing.Point(176, 56)
        Me.Corte.MaxDropDownItems = 15
        Me.Corte.Name = "Corte"
        Me.Corte.Size = New System.Drawing.Size(144, 24)
        Me.Corte.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Corte:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 171)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(928, 421)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 23
        '
        'But_graba
        '
        Me.But_graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_graba.ForeColor = System.Drawing.Color.Black
        Me.But_graba.Image = CType(resources.GetObject("But_graba.Image"), System.Drawing.Image)
        Me.But_graba.Location = New System.Drawing.Point(856, 16)
        Me.But_graba.Name = "But_graba"
        Me.But_graba.Size = New System.Drawing.Size(35, 35)
        Me.But_graba.TabIndex = 24
        Me.But_graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_graba.UseVisualStyleBackColor = False
        '
        'But_anula
        '
        Me.But_anula.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_anula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_anula.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_anula.ForeColor = System.Drawing.Color.Black
        Me.But_anula.Image = CType(resources.GetObject("But_anula.Image"), System.Drawing.Image)
        Me.But_anula.Location = New System.Drawing.Point(816, 16)
        Me.But_anula.Name = "But_anula"
        Me.But_anula.Size = New System.Drawing.Size(35, 35)
        Me.But_anula.TabIndex = 22
        Me.But_anula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_anula.UseVisualStyleBackColor = False
        '
        'ingresos_d
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 608)
        Me.Controls.Add(Me.Corte)
        Me.Controls.Add(Me.But_graba)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.But_anula)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingresos_d"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otros Ingresos al Inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler TextBox2.KeyPress, AddressOf keypressed1
        AddHandler Corte.KeyPress, AddressOf keypressed2
        AddHandler TextBox4.KeyPress, AddressOf keypressed4
        AddHandler cod.KeyPress, AddressOf keypressed3
        llena_combos(Corte, "SELECT* FROM CORTES WHERE EXPORTADO <> 'S' AND (SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) IS NULL", "CORTE")
        llena_materiales()
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        setea_grid()
        TextBox2.Text = "ANULACION DEL CORTE"
        DateTimePicker1.Enabled = True
        TextBox2.ReadOnly = False
        cod.Enabled = False
        TextBox4.ReadOnly = True
        Corte.Enabled = True
        Try
            Corte.SelectedIndex = 0
        Catch ex As Exception

        End Try
        cod.Focus()
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Corte.Focus()
        End If
    End Sub 'keypressed
    Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Corte.Text) <> "" Then
                llena_mat_corte()
                limpia_detalle()
            End If
        End If
    End Sub 'keypressed
    Private Sub limpia_detalle()
        TextBox4.Text = ""
        cod.Enabled = True
        TextBox4.ReadOnly = False
        Corte.Enabled = False
        TextBox2.Enabled = False
        But_elimina.Visible = False
        cod.Focus()
    End Sub
    Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cod.Text) <> "" Then
                Try
                    resuelve()
                Catch
                End Try
            End If
        End If
    End Sub 'keypressed
    Private Sub resuelve()
        habilita_Detalle()
        busca_detalle()
    End Sub
    Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(TextBox4.Text) <> "" Then
                If IsNumeric(TextBox4.Text) Then
                    But_Agrega.Focus()
                Else
                    MsgBox("Por favor Ingrese el numero de Unidades ", MsgBoxStyle.OkOnly, "Dato no valido !!!")
                End If
            End If
        End If
    End Sub 'keypressed
    Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            But_Agrega.Focus()
        End If
    End Sub 'keypressed

    Private Sub But_Agrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Agrega.Click
        revisa_Detalle()
    End Sub
    Private Sub llena_mat_corte()
        Dim strsql As String = "SELECT CODIGO,SUM(UNIDADES) * - 1 AS UNIDADES FROM D_MATERIAL WHERE CORTE = '" & Corte.Text & "' AND T_MOVTO > '3' GROUP BY CODIGO"
        llena_tablas(mat, strsql, cnn)
    End Sub
    '=====================================================================================
    '                                  DETALLE
    '=====================================================================================
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
    End Sub

    Private Sub _flex_RowColChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If fg.Row < 1 Then
            Exit Sub
        End If
        If Trim(fg(fg.Row, 1)) <> "" Then
            seleccion()
        End If
    End Sub

    Private Sub seleccion()
        fila = fg.RowSel
        If fila < 1 Then
            Exit Sub
        End If
        Try
            cod.SelectedIndex = cod.Items.IndexOf(fg(fila, 1))
        Catch
        End Try
        Label7.Text = fg(fila, 2)
        TextBox4.Text = fg(fila, 3)
        Corte.SelectedIndex = Corte.Items.IndexOf(fg(fila, 4))
        But_elimina.Visible = True
    End Sub


    Private Sub busca_detalle()
        fila = fg.FindRow(cod.Text, 1, 1, True)
        fg.RowSel = fila
        If fila > 0 Then
            seleccion()
            fg.Focus()
        End If
    End Sub

    Private Sub habilita_Detalle()
        cod.Enabled = False
        TextBox4.ReadOnly = False
        Corte.Enabled = True
        TextBox4.Focus()
    End Sub

    Private Sub revisa_Detalle()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim lin As Integer
        Dim pos As Integer
        If Trim(TextBox4.Text) = "" Or IsNumeric(TextBox4.Text) = False Then
            MsgBox("Por favor Ingrese el numero de Unidades  ", MsgBoxStyle.OkOnly, "Faltan Unidades !!!")
            Bien = False
            Exit Sub
        End If
        Try
            dd = mat.Select("CODIGO = '" & cod.Text & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                If dr("UNIDADES") <> CDec(TextBox4.Text) Then
                    MsgBox("El número total de unidades para el Código no es el Correcto", MsgBoxStyle.Critical, "Por favor Revise!!")
                    Exit Sub
                Else
                    pos = fg.FindRow(cod.Text, 1, 1, True)
                    If pos < 0 Then
                        lin = fg.Rows.Count
                        fg.Rows.Count = fg.Rows.Count + 1
                    Else
                        lin = pos
                    End If
                    fg(lin, 1) = cod.Text
                    fg(lin, 2) = Label7.Text
                    fg(lin, 3) = TextBox4.Text
                    limpia_detalle()
                End If
            Else
                MsgBox("El Código del Material no existe en las salidas para el Corte.", MsgBoxStyle.Critical, "Por favor Revise!!")

            End If
        Catch
        End Try
    End Sub


    Private Sub But_graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_graba.Click
        Dim ok As Boolean
        If fg.Rows.Count = 1 Then
            MsgBox("Aun no ha Ingresado Materiales", MsgBoxStyle.Critical, "No se puede actualizar")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = "S/D"
        End If
        ok = compara_totales()
        If ok Then
            actualiza_datos()
        End If
    End Sub
    Private Function compara_totales() As Boolean
        Dim ok As Boolean = False
        Dim totm As Object

        Dim i As Integer
        total_m = 0
        totm = mat.Compute("SUM(UNIDADES)", String.Empty)
        For i = 1 To fg.Rows.Count - 1
            total_m = total_m + fg(i, 3)
        Next
        If total_m = CDec(totm) Then
            ok = True
        Else
            MsgBox("El número total de unidades no coincide.", MsgBoxStyle.Critical, "Por favor Revise !!")
        End If
        Return ok
    End Function
    '=============================== ACTUALIZA BASE DE DATOS ===============================

    Private Sub actualiza_datos()
        graba_registros()
        limpia_variables()
    End Sub

    Private Sub But_elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Eliminar la Linea?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            fg.Rows.Remove(fg.RowSel)
            limpia_detalle()
        End If
    End Sub

    Private Sub But_regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_regresa.Click
        limpia_detalle()
    End Sub

    Private Sub But_anula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_anula.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Anular todo el Movimiento?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        seleccion()
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            Try
                fg.RowSel = (fg.Row - 1)
            Catch
            End Try
        End If

        If e.KeyCode = Keys.Down Then
            Try
                fg.RowSel = (fg.Row + 1)
            Catch
            End Try
        End If
        seleccion()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Text = Today
    End Sub

    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Corte.KeyPress
        AutoCompletar(Corte, e)
    End Sub

    Private Sub cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cod.KeyPress
        AutoCompletar(cod, e)
    End Sub

    Private Sub llena_materiales()
        mt = New DataTable()
        llena_tablas(mt, "SELECT CODIGO,DESCRIPCION FROM MATERIALES", cnn)
        Dim dr As DataRow
        cod.Items.Clear()
        For Each dr In mt.Rows
            cod.Items.Add(dr("CODIGO"))
        Next
        Try
            cod.SelectedIndex = 0
        Catch
        End Try
    End Sub

    ' ==================================== ACTUALIZA BASE DE DATOS =====================================
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try


            strSQL = "UPDATE CORTES_DEV SET MATERIALES = '" & total_m & "' WHERE CORTE = '" & Corte.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO CORTES_DEV (CORTE,TELAS,MATERIALES,ESTADO) VALUES (" &
                                      "'" & Corte.Text & "','0','" & total_m & "','A')"

                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub cod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cod.SelectedIndexChanged
        Dim dd As DataRow()
        Dim dr As DataRow
        dd = mt.Select("CODIGO = '" & cod.Text & "'")
        For Each dr In dd
            Label7.Text = dr("DESCRIPCION")
        Next
    End Sub
End Class

