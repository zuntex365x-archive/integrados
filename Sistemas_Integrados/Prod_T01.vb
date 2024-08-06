Imports C1.Win.C1FlexGrid

Public Class Prod_T01
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim co As New DataTable
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents caja As System.Windows.Forms.ComboBox
    Friend WithEvents talla As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents unidades As System.Windows.Forms.TextBox
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Dim dr As DataRow
    Dim caja_nueva As String
    Dim cliente As String
    Dim escala As String
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim tallap As String
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prod_T01))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.caja = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.unidades = New System.Windows.Forms.TextBox()
        Me.talla = New System.Windows.Forms.ComboBox()
        Me.graba = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.Location = New System.Drawing.Point(199, 57)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(189, 28)
        Me.corte.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.corte, "No. Embarque")
        '
        'caja
        '
        Me.caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.caja.Location = New System.Drawing.Point(199, 21)
        Me.caja.Name = "caja"
        Me.caja.Size = New System.Drawing.Size(189, 28)
        Me.caja.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.caja, " ")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(879, 147)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 1
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Chequeo de Datos")
        Me.si.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(925, 19)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 104
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'unidades
        '
        Me.unidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.unidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.unidades.Location = New System.Drawing.Point(199, 164)
        Me.unidades.MaxLength = 20
        Me.unidades.Name = "unidades"
        Me.unidades.Size = New System.Drawing.Size(189, 26)
        Me.unidades.TabIndex = 6
        Me.unidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'talla
        '
        Me.talla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.talla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.talla.Location = New System.Drawing.Point(199, 128)
        Me.talla.Name = "talla"
        Me.talla.Size = New System.Drawing.Size(189, 28)
        Me.talla.TabIndex = 4
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(857, 19)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 9
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 32)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 28)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 28)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Talla:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 28)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Unidades:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.descripcion)
        Me.GroupBox1.Controls.Add(Me.tipo)
        Me.GroupBox1.Controls.Add(Me.si)
        Me.GroupBox1.Controls.Add(Me.unidades)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.talla)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.corte)
        Me.GroupBox1.Controls.Add(Me.caja)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(24, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(961, 235)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'descripcion
        '
        Me.descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.descripcion.Location = New System.Drawing.Point(199, 198)
        Me.descripcion.MaxLength = 50
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(740, 26)
        Me.descripcion.TabIndex = 102
        '
        'tipo
        '
        Me.tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.Location = New System.Drawing.Point(199, 92)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(189, 28)
        Me.tipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 28)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Tipo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 28)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Descripción:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 664)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(385, 18)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Double click elimina línea."
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(23, 306)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(962, 355)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
        '
        'Prod_T01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 696)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_T01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas de Inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cortes_status(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler caja.KeyPress, AddressOf keypressed1
        AddHandler corte.KeyPress, AddressOf keypressed2
        AddHandler tipo.KeyPress, AddressOf keypressed3
        AddHandler talla.KeyPress, AddressOf keypressed4
        AddHandler unidades.KeyPress, AddressOf keypressed5
        AddHandler descripcion.KeyPress, AddressOf keypressed6
        limpia_variables()
    End Sub
    Private Sub limpia_variables()
        setea_fg()
        corte.Enabled = True
        caja.Items.Clear()
        talla.Items.Clear()
        tipo.Items.Clear()
        unidades.Text = "0"
        si.Visible = True
        graba.Visible = True
        corte.Enabled = True
        caja.Enabled = True
        talla.Enabled = True
        tipo.Enabled = True
        unidades.Enabled = True
        llena_combos(caja, "SELECT DISTINCT CAJA FROM PROD_TER01 ", "CAJA")
        Try
            corte.SelectedIndex = 0
        Catch
        End Try
        corte.Focus()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Rows(0).Height = 30
        llena_combos(caja, "SELECT DISTINCT CAJA FROM PROD_TER01 WHERE ESTADO = 'A' ORDER BY CAJA", "CAJA")
    End Sub
    Private Sub si_Click(sender As System.Object, e As System.EventArgs) Handles si.Click
        Dim ok As Boolean
        verifica_unidades(ok)
        If ok Then
            agrega_fg(ok)
        End If
    End Sub
    Private Sub verifica_unidades(ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim unidad As Integer
        Dim strsql As String = "SELECT * FROM PROD_TER01 WHERE CAJA = '" & caja.Text & "' AND CORTE = '" & corte.Text & "' AND TIPO = '" & tipo.Text & "' AND TALLA = '" & talla.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            unidad = CInt(unidades.Text)
            cliente = dr("CLIENTE")
            If unidad = 0 Then
                MsgBox("No se puede efectuar la operación.  Debe ingresar el número de unidades a retirar.", MsgBoxStyle.Critical, "Por favor corrija")
                ok = False
                Exit Sub
            End If
            If dr("UNIDADES") < unidad Then
                MsgBox("No se puede efectuar la operación.  Solamente hay " & dr("UNIDADES") & " unidades.", MsgBoxStyle.Critical, "Por favor corrija")
                ok = False
                Exit Sub
            End If
        End If
        ok = True
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(caja.Text) <> "" Then
                corte.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                tipo.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(tipo.Text) <> "" Then
                talla.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If talla.Text <> "" Then
                unidades.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If unidades.Text <> "" Then
                descripcion.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descripcion.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub corte_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles corte.SelectedIndexChanged
        llena_combos(tipo, "SELECT DISTINCT TIPO FROM PROD_TER01 WHERE CAJA = '" & caja.Text & "' AND CORTE = '" & corte.Text & "' ORDER BY TIPO", "TIPO")
        Try
            tipo.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            If fg.Rows.Count > 1 Then
                graba_datos()
                imprime_etiquetas()
                Close()
            Else
                MsgBox("Aún no ha ingresado Ninguna Salida. ", MsgBoxStyle.Critical, "Por favor revise !!!")
            End If
      
        End If

    End Sub
    Private Sub imprime_etiquetas()
        Dim ok As Boolean
        Dim i As Integer
        Dim etique As String
        For i = 1 To fg.Rows.Count - 1
            etique = fg(i, 1)
            ok = imprime_cajas_t(etique, etique)
        Next

    End Sub

    Private Sub corteS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub
    Private Sub tipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tipo.KeyPress
        AutoCompletar(tipo, e)
    End Sub
    Private Sub talla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles talla.KeyPress
        AutoCompletar(talla, e)
    End Sub

    Private Sub cajad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles caja.SelectedIndexChanged
        llena_combos(corte, "SELECT DISTINCT CORTE FROM PROD_TER01 WHERE CAJA = '" & caja.Text & "'", "CORTE")
        Try
            corte.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub unidn_TextChanged(sender As System.Object, e As System.EventArgs) Handles unidades.TextChanged
        Dim selStart As Integer = unidades.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To unidades.Text.Length - 1

            If "0123456789".IndexOf(unidades.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & unidades.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        unidades.Text = newStr 'Place the new text into the textbox.
        unidades.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub

    Private Sub agrega_fg(ByRef ok As Boolean)
        Dim l As Integer
        ok = True
        Dim busca As String = caja.Text + corte.Text + tipo.Text + talla.Text
        l = fg.FindRow(busca, 1, 0, False)
        If l > -1 Then
            ok = False
            Exit Sub
        End If
        l = fg.Rows.Count
        fg.Rows.Count = l + 1
        fg(l, 0) = busca
        fg(l, 1) = caja.Text
        fg(l, 2) = corte.Text
        fg(l, 3) = tipo.Text
        fg(l, 4) = talla.Text
        fg(l, 5) = unidades.Text
        fg(l, 6) = descripcion.Text
    End Sub

    Private Sub tipod_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tipo.SelectedIndexChanged
        llena_combos(talla, "SELECT DISTINCT TALLA FROM PROD_TER01 WHERE CAJA = '" & caja.Text & "' AND CORTE = '" & corte.Text & "' AND TIPO = '" & tipo.Text & "' ORDER BY TALLA", "TALLA")
        Try
            talla.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        limpia_variables()
        corte.Focus()
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.DoubleClick
        elimina_linea()
    End Sub
    Private Sub elimina_linea()
        Dim l As Integer = fg.RowSel
        Try
            fg.Rows.Remove(l)
            caja.Focus()
        Catch
        End Try
    End Sub
    '============================= Actualiza la Base de Datos =============================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim pre As String = ""
        Dim obj As New empresas
        Dim h As String = "0000000"
        Dim g As New Object
        Dim corre As Decimal
        Dim docto As String
        Dim i As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "SELECT CORRELATIVO FROM PROD_TER03 WHERE TIPO = 'SALIDAS'"
            comando.CommandText = strsql
            g = comando.ExecuteScalar()
            corre = g.ToString + 1
            docto = Format(corre, h)

            strsql = "UPDATE PROD_TER03 SET CORRELATIVO = CORRELATIVO + 1 WHERE TIPO = 'SALIDAS'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()


            For i = 1 To fg.Rows.Count - 1
                strsql = "UPDATE PROD_TER01 SET UNIDADES = UNIDADES - " & fg(i, 5) & " WHERE CAJA ='" & fg(i, 1) & "' AND CORTE = '" & fg(i, 2) & "' AND TIPO = '" & fg(i, 3) & "' AND TALLA = '" & fg(i, 4) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                strsql = "INSERT INTO PROD_TER02 (TIPO_MOVTO,NO_DOCTO,CAJA,CORTE,TALLA,TIPO,DESCRIPCION,FECHA,UNIDADES,USUARIO) VALUES ('S','" & _
                                                docto & "','" & _
                                                fg(i, 1) & "','" & _
                                                fg(i, 2) & "','" & _
                                                fg(i, 4) & "','" & _
                                                fg(i, 3) & "','" & _
                                                fg(i, 6) & "',GETDATE(),'" & _
                                                fg(i, 5) & "','" & _
                                                obj.usuario & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
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

End Class

