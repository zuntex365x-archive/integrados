Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Fpo_cat_1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Regresa As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cat As System.Windows.Forms.ComboBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents libras As System.Windows.Forms.TextBox
    Friend WithEvents Elimina As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Fpo_cat_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Elimina = New System.Windows.Forms.Button()
        Me.Regresa = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.libras = New System.Windows.Forms.TextBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Bitmap)
        Me.CANCELA.Location = New System.Drawing.Point(448, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 60
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.CANCELA.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(840, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 52
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(880, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 53
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.Visible = False
        '
        'Elimina
        '
        Me.Elimina.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Elimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina.ForeColor = System.Drawing.Color.Black
        Me.Elimina.Image = CType(resources.GetObject("Elimina.Image"), System.Drawing.Bitmap)
        Me.Elimina.Location = New System.Drawing.Point(944, 16)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(35, 35)
        Me.Elimina.TabIndex = 86
        Me.Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina, "Presione este Boton para Borrar el Registro Seleccionado.")
        '
        'Regresa
        '
        Me.Regresa.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresa.ForeColor = System.Drawing.Color.Black
        Me.Regresa.Image = CType(resources.GetObject("Regresa.Image"), System.Drawing.Bitmap)
        Me.Regresa.Location = New System.Drawing.Point(864, 16)
        Me.Regresa.Name = "Regresa"
        Me.Regresa.Size = New System.Drawing.Size(35, 35)
        Me.Regresa.TabIndex = 84
        Me.Regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Regresa.Visible = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Bitmap)
        Me.Graba.Location = New System.Drawing.Point(904, 16)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 3
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.AutoResize = False
        Me.fg.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:421;Name:""CATEGORIA"";Caption:""CATEGORIA"";AllowMerging:True;AllowEditing:F" & _
        "alse;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:200;Name:""FECHA"";Capt" & _
        "ion:""FECHA"";AllowEditing:False;DataType:System.DateTime;Format:""dd/MMM/yyyy"";Tex" & _
        "tAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:150;Name:""LIBRAS"";Capt" & _
        "ion:""LIBRAS"";AllowEditing:False;DataType:System.Decimal;Format:""###,##0.00"";Text" & _
        "Align:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:62;Name:""OFECHA"";Caption:" & _
        """OFRECIDA"";Visible:False;DataType:System.DateTime;Format:""dd-MM-yyyy"";TextAlign:" & _
        "LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(16, 136)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(976, 544)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 9.75pt;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor" & _
        ":238, 163, 117;ForeColor:ControlText;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:242, 111, 170;ForeCol" & _
        "or:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat," & _
        "1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{" & _
        "Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlD" & _
        "arkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:Contro" & _
        "lDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "TOTALES{Font:Tahoma, 11.25pt, style=Bold;BackColor:Gold;}" & Microsoft.VisualBasic.ChrW(9) & "azul{BackColor:142, " & _
        "215, 227;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Categoría:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cat
        '
        Me.cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat.Location = New System.Drawing.Point(152, 16)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(264, 26)
        Me.cat.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Fecha Inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Libras:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha.Location = New System.Drawing.Point(152, 64)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(136, 26)
        Me.fecha.TabIndex = 1
        '
        'libras
        '
        Me.libras.BackColor = System.Drawing.Color.White
        Me.libras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libras.ForeColor = System.Drawing.Color.Black
        Me.libras.Location = New System.Drawing.Point(152, 96)
        Me.libras.Name = "libras"
        Me.libras.Size = New System.Drawing.Size(136, 22)
        Me.libras.TabIndex = 1
        Me.libras.Text = ""
        '
        'Fpo_cat_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.libras, Me.fecha, Me.Label3, Me.Label2, Me.Elimina, Me.Regresa, Me.Graba, Me.Label1, Me.cat, Me.fg})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fpo_cat_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entregas Texpasa por Semana"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Fpo_cat_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cat.KeyPress, AddressOf keypressed1
        AddHandler fecha.KeyPress, AddressOf keypressed2
        AddHandler libras.KeyPress, AddressOf keypressed3
        llena_combos(cat, "SELECT CATEGORIA FROM TELA_CATEGORIA ORDER BY CATEGORIA", "CATEGORIA")
        Try
            cat.SelectedIndex = 0
        Catch ex As Exception
        End Try
        setea_fg()
        cat.SelectedIndex = 0
    End Sub
    Private Sub limpia_variables()
        libras.Enabled = True
        libras.Text = "30000"
        cat.Enabled = True
        fecha.Enabled = True
        libras.Enabled = False
        Elimina.Visible = False
        graba.Visible = False
        cat.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows(0).Height = 30
        limpia_variables()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        llena_tablas(dt, "SELECT CATEGORIA, FECHA, LIBRAS FROM TELA_CATEGORIA_S WHERE CATEGORIA = '" & cat.Text & "'", cnn)
        fg.DataSource = dt
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub
    Private Sub fg_canbia_linea(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro()
    End Sub

    Private Sub selecciona_registro()
        Dim i As Integer = fg.RowSel
        Dim ok As Boolean
        If i > 0 Then
            cat.Text = fg(i, 1)
            fecha.Value = fg(i, 2)
            busca_categoria(ok)
            habilita()
        End If
    End Sub

    Private Sub busca_categoria(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM TELA_CATEGORIA_S WHERE CATEGORIA = '" & cat.Text & "' AND FECHA = '" & Format(fecha.Value, "yyyy-MM-dd") & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            libras.Enabled = True
            libras.Text = dr("LIBRAS")
            ok = True
            Elimina.Visible = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita()
        cat.Enabled = False
        fecha.Enabled = False
        libras.Enabled = True
        Graba.Visible = True
        Regresa.Visible = True
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cat.Text) <> "" Then
                fecha.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                busca_categoria(ok)
                habilita()
                libras.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(libras.Text) <> "" Then
                Graba.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = True
        Dim libr As Decimal
        Dim fec As Date = fecha.Value
        Dim dia As Integer = fec.DayOfWeek
        If dia <> 1 Then
            MsgBox("La Fecha ingresada no corresponde a un día Lunes", MsgBoxStyle.Critical, "Error en Fechas !!!!")
            ok = False
            Exit Sub
        End If
        Try
            libr = CDec(libras.Text)
        Catch
            libras.Text = "0"
        End Try
        If libr = 0 Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar un monto de libras Valido.", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
        Me.Refresh()
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            setea_fg()
        End If
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim ffecha As String = Format(fecha.Value, "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE TELA_CATEGORIA_S SET  LIBRAS = '" & libras.Text & "' " & _
                                           " WHERE CATEGORIA = '" & cat.Text & "' AND FECHA = '" & ffecha & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO TELA_CATEGORIA_S (CATEGORIA,FECHA,LIBRAS) VALUES ('" & _
                                                    cat.Text & "','" & _
                                                    ffecha & "','" & _
                                                    libras.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresa.Click
        setea_fg()
        cat.Focus()
    End Sub

    Private Sub CAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cat.KeyPress
        AutoCompletar(cat, e)
    End Sub

    Private Sub seccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cat.SelectedIndexChanged
        llena_fg()
    End Sub

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        setea_fg()
    End Sub


    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim ffecha As String = Format(fecha.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE TELA_CATEGORIA_S WHERE CATEGORIA = '" & cat.Text & "' AND FECHA = '" & ffecha & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
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



