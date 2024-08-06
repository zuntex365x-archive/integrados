Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Lista_empaque_51
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents embarque As System.Windows.Forms.TextBox
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mas As System.Windows.Forms.Button
    Friend WithEvents correcto As System.Windows.Forms.Button
    Friend WithEvents sigue As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_51))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.embarque = New System.Windows.Forms.TextBox()
        Me.gr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.mas = New System.Windows.Forms.Button()
        Me.correcto = New System.Windows.Forms.Button()
        Me.sigue = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(504, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Revierte todo lo ingresado.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(968, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 81
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Grabacion de la Lista de empaque.")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'fecha
        '
        Me.fecha.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Enabled = False
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(360, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(104, 22)
        Me.fecha.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha del Embarque")
        '
        'embarque
        '
        Me.embarque.BackColor = System.Drawing.Color.White
        Me.embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.embarque.Location = New System.Drawing.Point(88, 8)
        Me.embarque.MaxLength = 11
        Me.embarque.Name = "embarque"
        Me.embarque.Size = New System.Drawing.Size(192, 26)
        Me.embarque.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.embarque, "Embarque    JTS-XXXXX")
        '
        'gr
        '
        Me.gr.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gr.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.gr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.gr.ColumnInfo = resources.GetString("gr.ColumnInfo")
        Me.gr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gr.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gr.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.gr.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.gr.Location = New System.Drawing.Point(8, 400)
        Me.gr.Name = "gr"
        Me.gr.Rows.Count = 100
        Me.gr.Rows.DefaultSize = 22
        Me.gr.Size = New System.Drawing.Size(1000, 128)
        Me.gr.StyleInfo = resources.GetString("gr.StyleInfo")
        Me.gr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.gr.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.gr, "Doble click para escoger Estilo-Color.")
        Me.gr.Visible = False
        '
        'mas
        '
        Me.mas.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mas.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mas.ForeColor = System.Drawing.Color.Black
        Me.mas.Image = CType(resources.GetObject("mas.Image"), System.Drawing.Image)
        Me.mas.Location = New System.Drawing.Point(928, 8)
        Me.mas.Name = "mas"
        Me.mas.Size = New System.Drawing.Size(35, 35)
        Me.mas.TabIndex = 86
        Me.mas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.mas, "Agrega mas lineas.")
        Me.mas.UseVisualStyleBackColor = False
        '
        'correcto
        '
        Me.correcto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.correcto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.correcto.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correcto.ForeColor = System.Drawing.Color.Black
        Me.correcto.Image = CType(resources.GetObject("correcto.Image"), System.Drawing.Image)
        Me.correcto.Location = New System.Drawing.Point(888, 8)
        Me.correcto.Name = "correcto"
        Me.correcto.Size = New System.Drawing.Size(35, 35)
        Me.correcto.TabIndex = 87
        Me.correcto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.correcto, "Chequea que todos los datos esten correctos.")
        Me.correcto.UseVisualStyleBackColor = False
        Me.correcto.Visible = False
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(504, 8)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 88
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Presione este Boton para Desplegar la Consulta.")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 100
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(1000, 480)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'fj
        '
        Me.fj.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fj.AllowEditing = False
        Me.fj.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fj.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fj.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fj.Location = New System.Drawing.Point(8, 552)
        Me.fj.Name = "fj"
        Me.fj.Rows.Count = 1
        Me.fj.Rows.DefaultSize = 22
        Me.fj.Size = New System.Drawing.Size(1000, 152)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fj.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(304, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 26)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 536)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Inventario Segundas"
        '
        'Lista_empaque_51
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 707)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.correcto)
        Me.Controls.Add(Me.mas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.embarque)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.gr)
        Me.Controls.Add(Me.fj)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_51"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empaque Segundas JT"
        CType(Me.gr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim sto As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim estilos As String
    Dim fgr As Integer
    Dim tallas As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
    Dim ts() As String = tallas.Split("|")
    Dim co As New DataTable()
    Private Sub Lista_empaque_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler embarque.KeyPress, AddressOf keypressed1
        AddHandler fecha.KeyPress, AddressOf keypressed2
        deshabilita()
    End Sub

    Private Sub deshabilita()
        setea_grid()
        setea_fj()
        embarque.Enabled = True
        fecha.Enabled = False
        CANCELA.Visible = False
        G1.Visible = False
        mas.Visible = False
        sigue.Visible = True
        correcto.Visible = False
        embarque.Focus()
    End Sub

    Private Sub habilita()
        embarque.Enabled = False
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub setea_fj()
        fj.Rows.Count = 1
        fj.Rows(0).Height = 30
    End Sub

    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(embarque.Text) <> "" Then
                fg.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                fg.Focus()
            End If
        End If
    End Sub

    Private Sub llena_cortes()
        llena_tablas(co, "SELECT * FROM E_STOCK WHERE ((PRENDAS - EXPORT) > 0 OR EXPORT IS NULL) AND TIPO = '01'", cnn)
    End Sub

    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        Dim ok As Boolean = True
        revisa_embarque(ok)
        If ok Then
            sigue.Visible = False
            CANCELA.Visible = True
            correcto.Visible = True
            mas.Visible = True
            embarque.Enabled = False
            fecha.Enabled = False
            fg.Rows.Count = 150
            embarque.Text = "JTS-" & embarque.Text
            llena_fj()
        Else
            MsgBox("Este No. de Embarque ya existe !!!", MsgBoxStyle.Critical, "Por favor verifique !!!!")
        End If
    End Sub

    Private Sub revisa_embarque(ByRef ok As Boolean)
        Dim em As New DataTable()
        ok = True
        llena_tablas(em, "SELECT * FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "'", cnn)
        If em.Rows.Count > 0 Then
            ok = False
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles embarque.Leave
        If embarque.Text = "" Or embarque.Text = Nothing Then
            MsgBox("Por favor ingrese el número de embarque", MsgBoxStyle.Exclamation, "Embarque inválido !!!")
            embarque.Focus()
        End If
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            embarque.Text = ""
            deshabilita()
        Else
            MsgBox("No puedo grabar el embarque", MsgBoxStyle.Exclamation, "Aun existen errores !!!")
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = True
        elimina_blancos(ok)
        If fg.Rows.Count > 0 Then
            llena_fj()
            llena_gr()
            compara(ok)
        Else
            MsgBox("Aun no ha ingresado ninguna caja !!!", MsgBoxStyle.Critical, "Por favor verifique.")
        End If

    End Sub

    Private Sub elimina_blancos(ByRef ok As Boolean)
        Dim i As Integer
        Dim j As Integer
        Dim t As Decimal = 0
        Dim c As DataRow()
        Try
            For i = 1 To fg.Rows.Count - 1
                For j = 5 To 14
                    t = t + fg(i, j)
                Next
                If fg(i, 1) = 0 Or fg(i, 2) = "" Or t = 0 Then
                    fg.Rows.Remove(i)
                    i = i - 1
                Else
                    c = co.Select("CORTE = '" & fg(i, 2) + "'")
                    If c.Length > 0 Then
                        dr = c(0)
                        fg(i, 3) = dr("ESTILO")
                        fg(i, 4) = dr("COLOR")
                    End If
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub llena_gr()
        Dim i As Integer
        Dim f As Integer
        Dim j As Integer
        Dim busca As String
        gr.Rows.Count = 1
        For i = 1 To fg.Rows.Count - 1
            busca = fg(i, 2)
            f = gr.FindRow(busca, 1, 1, False)
            If f < 0 Then
                f = gr.Rows.Count
                gr.Rows.Count = f + 1
                gr(f, 1) = busca
                gr(f, 2) = fg(i, 3)
                gr(f, 3) = fg(i, 4)
                gr(f, 14) = fg(i, 1)
                gr(f, 15) = fg(i, 1)
            Else
                If fg(i, 1) < gr(f, 14) Then
                    gr(f, 14) = fg(i, 1)
                End If
                If fg(i, 1) > gr(f, 15) Then
                    gr(f, 15) = fg(i, 1)
                End If
            End If
            For j = 5 To 14
                gr(f, j - 1) = gr(f, j - 1) + fg(i, j)
            Next
        Next
    End Sub

    Private Sub llena_fj()
        Dim i As Integer
        Dim p As Integer
        Dim corte As String
        Dim dr As DataRow
        Dim talla As String
        Dim prendas As Decimal
        Dim export As Decimal
        llena_cortes()
        fj.Rows.Count = 1
        For Each dr In co.Rows
            corte = dr("CORTE")
            i = fj.FindRow(corte, 1, 1, False)
            If i < 0 Then
                i = fj.Rows.Count
                fj.Rows.Count = i + 1
                fj(i, 1) = dr("CORTE")
                fj(i, 2) = dr("ESTILO")
                fj(i, 3) = dr("COLOR")
            End If
            talla = dr("TALLA")
            Try
                prendas = dr("PRENDAS")
            Catch
                prendas = 0
            End Try
            Try
                export = dr("EXPORT")
            Catch
                export = 0
            End Try
            p = Array.IndexOf(ts, talla) + 4
            If p > 0 Then
                fj(i, p) = fj(i, p) + (prendas - export)
            End If
        Next
    End Sub

    Private Sub compara(ByRef ok As Boolean)
        Dim i As Integer
        Dim j As Integer
        Dim p As Integer
        Dim corte As String
        For i = 1 To gr.Rows.Count - 1
            corte = gr(i, 1)
            p = fj.FindRow(corte, 1, 1, False)
            If p < 0 Then
                ok = False
                Exit Sub
            End If
            For j = 0 To 9
                If gr(i, j + 4) > fj(p, j + 4) Then
                    ok = False
                    pone_rojo(gr(i, 1), j + 5, "rojo")
                Else
                    pone_rojo(gr(i, 1), j + 5, "blanco")
                End If
            Next
        Next

    End Sub

    Private Sub pone_rojo(ByVal corte As String, ByVal t As Integer, ByVal estilo As String)
        Dim p As Integer
        Dim l As Integer = 1
        p = fg.FindRow(corte, l, 2, False)
        While p > 0
            fg.SetCellStyle(p, t, fg.Styles(estilo))
            l = l + 1
            p = fg.FindRow(corte, l, 2, False)
        End While
    End Sub

    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit
        Dim ds As DataRow()
        ' validate amounts
        If e.Col = 2 Then
            Dim corte As String = fg.Editor.Text()
            Try
                ds = co.Select("CORTE = '" & corte & "'")
                If (ds.Length = 0 And corte <> Nothing) Then
                    MessageBox.Show("Corte no existe en segundas !!!")
                    e.Cancel = True
                End If
            Catch
                MessageBox.Show("Valor incorrecto")
                e.Cancel = True
            End Try
        End If
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim i As Integer
        Dim j As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim tal As String
        Dim destino As String = ""
        Dim tt As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
        Dim tr As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
        Dim ta() As String = tt.Split("|")
        Dim t() As String = tr.Split("|")
        Dim talla As String
        Dim prendas As Decimal
        Dim pr(9) As Decimal
        Dim se(9) As Decimal
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                For j = 5 To 14
                    prendas = fg(i, j)
                    If prendas > 0 Then
                        talla = ta(j - 5)
                        strsql = "UPDATE PACKING_C SET PRENDAS = PRENDAS + " & prendas & " WHERE EMBARQUE = '" & embarque.Text & _
                                                           "' AND CAJA = '" & fg(i, 1) & "' AND CPO = '" & embarque.Text & _
                                                           "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & _
                                                           "' AND TIPO = 'Seg' AND TALLA = '" & talla & "'"

                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                        If afectados = 0 Then
                            strsql = "INSERT INTO PACKING_C (EMBARQUE,CAJA,CPO,ESTILO,COLOR,TIPO,TALLA,PRENDAS) " & _
                                                 "VALUES ('" & embarque.Text & "','" & _
                                                           fg(i, 1) & "','" & _
                                                           embarque.Text & "','" & _
                                                           fg(i, 3) & "','" & _
                                                           fg(i, 4) & "','" & _
                                                           "Seg" & "','" & _
                                                           talla & "','" & _
                                                           prendas & "')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If
                        tallas = t(j - 5)
                        strsql = "UPDATE EMBARQUES SET PRENDAS = PRENDAS  + " & prendas & _
                                                      " WHERE EMBARQUE = '" & embarque.Text & "' AND CORTE = '" & fg(i, 2) & "' " & _
                                                      " AND TIPO = '01' AND TALLA = '" & tallas & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        If afectados = 0 Then
                            strsql = "INSERT INTO EMBARQUES (EMBARQUE,CORTE,TIPO,TALLA,FECHA,PRENDAS) " & _
                                                                "VALUES ( '" & embarque.Text & "','" & fg(i, 2) & "','01','" & _
                                                                   tallas & "','" & _
                                                                   fechas & "','" & _
                                                                   prendas & "')"

                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If

                        '================================ STOCK ===========================
                        strsql = "UPDATE STOCK SET UNIDADES = UNIDADES - " & prendas & " WHERE ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "' AND TIPO = '01' AND TALLA = '" & talla & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        strsql = "UPDATE E_STOCK SET EXPORT = EXPORT + " & prendas & " WHERE CORTE = '" & fg(i, 2) & "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "' AND TIPO = '01' AND TALLA = '" & talla & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        strsql = "UPDATE S_STOCK SET PRENDAS = PRENDAS + " & prendas & " WHERE EMBARQUE = '" & embarque.Text & "' AND ESTILO = '" & fg(i, 3) & "' AND COLOR = '" & fg(i, 4) & "' AND TIPO = '01' AND TALLA = '" & talla & "' AND CLIENTE = 'JT' AND CPO = '" & embarque.Text & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        If afectados = 0 Then
                            strsql = "INSERT INTO S_STOCK (EMBARQUE,ESTILO,COLOR,TIPO,TALLA,CLIENTE,CPO,FECHA,PRENDAS)  " & _
                                                      "VALUES ('" & embarque.Text & "','" & _
                                                                    fg(i, 3) & "','" & _
                                                                    fg(i, 4) & "','01','" & _
                                                                    talla & "','JT','" & _
                                                                    embarque.Text & "','" & _
                                                                    fechas & "','" & _
                                                                    prendas & "')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If

                        '=================================== CORTES =========================
                        tal = "S" + CStr(j - 5)
                        ReDim pr(9)
                        ReDim se(9)
                        strsql = "UPDATE CORTES_E SET " & tal & " = " & tal & " + " & prendas & " WHERE CORTE = '" & fg(i, 2) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        If afectados = 0 Then
                            se(j - 5) = prendas
                            strsql = "INSERT INTO CORTES_E (CORTE,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9) " & _
                                     "VALUES ( '" & fg(i, 2) & "','" & _
                                                pr(0) & "','" & _
                                                pr(1) & "','" & _
                                                pr(2) & "','" & _
                                                pr(3) & "','" & _
                                                pr(4) & "','" & _
                                                pr(5) & "','" & _
                                                pr(6) & "','" & _
                                                pr(7) & "','" & _
                                                pr(8) & "','" & _
                                                pr(9) & "','" & _
                                                se(0) & "','" & _
                                                se(1) & "','" & _
                                                se(2) & "','" & _
                                                se(3) & "','" & _
                                                se(4) & "','" & _
                                                se(5) & "','" & _
                                                se(6) & "','" & _
                                                se(7) & "','" & _
                                                se(8) & "','" & _
                                                se(9) & "')"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If
                    End If
                Next j
            Next i
            For i = 1 To gr.Rows.Count - 1
                strsql = "UPDATE PACKING_E SET CAJA_F = '" & gr(i, 15) & "' WHERE EMBARQUE = '" & embarque.Text & _
                                                   "' AND CPO = '" & embarque.Text & "' AND ESTILO = '" & gr(i, 2) & _
                                                   "' AND COLOR = '" & gr(i, 3) & "'"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                If afectados = 0 Then
                    strsql = "INSERT INTO PACKING_E (EMBARQUE,CPO,ESTILO,COLOR,CAJA_I,CAJA_F,FECHA,DESTINO,FACTURA,CONTENEDOR,MATPRI,FACTURADO) " & _
                                                    "VALUES ('" & embarque.Text & "','" & _
                                                                  embarque.Text & "','" & _
                                                                  gr(i, 2) & "','" & _
                                                                  gr(i, 3) & "','" & _
                                                                  gr(i, 14) & "','" & _
                                                                  gr(i, 15) & "','" & _
                                                                  fechas & "','JT.TRADING'," & _
                                                                  "'','',0,'N')"

                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
                strsql = "INSERT INTO PACKING_D (EMBARQUE,CORTE,TIPO,CPO,ESTILO,COLOR,FECHA,CLIENTE,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6)  " & _
                "VALUES ('" & embarque.Text & "','" & gr(i, 1) & "','Seg','" & _
                              embarque.Text & "','" & _
                              gr(i, 2) & "','" & _
                              gr(i, 3) & "','" & _
                              fechas & "','JT','" & _
                              gr(i, 4) & "','" & _
                              gr(i, 5) & "','" & _
                              gr(i, 6) & "','" & _
                              gr(i, 7) & "','" & _
                              gr(i, 8) & "','" & _
                              gr(i, 9) & "','" & _
                              gr(i, 10) & "','" & _
                              gr(i, 11) & "','" & _
                              gr(i, 12) & "','" & _
                              gr(i, 13) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next i
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

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        seguro = MsgBox("Seguro de anular la lista de empaque?  ", MsgBoxStyle.YesNo, "Anulando movimiento !!!")
        If seguro = MsgBoxResult.Yes Then
            llena_fj()
            deshabilita()
        End If
    End Sub

    Private Sub mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas.Click
        fg.Rows.Count = 150
    End Sub

    Private Sub correcto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles correcto.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If Not ok Then
            If fg.Rows.Count > 1 Then
                MsgBox("Aun existen datos incorrectos !!!", MsgBoxStyle.Critical, "Por favor verifique.")
            End If
        Else
            G1.Visible = True
        End If
    End Sub


End Class
