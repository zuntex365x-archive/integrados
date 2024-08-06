Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing

Public Class Listado_salidas
    Inherits System.Windows.Forms.Form
    Dim fecha_i As String
    Dim fecha_f As String
    Dim fechas As String
    Dim tip As Integer
    Dim str As String = "SELECT * FROM DMOVTO WHERE DOCTO = 'S'"
    Dim h As String = "#######.00"
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim ti(7) As String
    Dim path As String = "C:\reportes\reporte_ingresos.xls"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Uno As System.Windows.Forms.CheckBox
    Friend WithEvents c4 As System.Windows.Forms.ComboBox
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents Hoja As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Listado_salidas))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.c4 = New System.Windows.Forms.ComboBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Hoja = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Uno = New System.Windows.Forms.CheckBox()
        Me.Todos = New System.Windows.Forms.CheckBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tipo
        '
        Me.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo.Items.AddRange(New Object() {"TODOS", "PRODUCCION", "DEVOLUCIONES", "AJUSTES"})
        Me.tipo.Location = New System.Drawing.Point(168, 64)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(112, 21)
        Me.tipo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tipo, "Elija el tipo de Ingreso a Listar  O  seleccione TODOS para imprimir todos los in" & _
        "gresos no importando el tipo que tenga.")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Bitmap)
        Me.si.Location = New System.Drawing.Point(584, 16)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 6
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este Boton para Desplegar el  Reporte de Ingresos a Inventario. ")
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Bitmap)
        Me.Imprimir.Location = New System.Drawing.Point(624, 16)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(35, 35)
        Me.Imprimir.TabIndex = 50
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.Visible = False
        '
        'Fecha_inicial
        '
        Me.Fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha_inicial.Location = New System.Drawing.Point(168, 16)
        Me.Fecha_inicial.Name = "Fecha_inicial"
        Me.Fecha_inicial.Size = New System.Drawing.Size(112, 22)
        Me.Fecha_inicial.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Fecha_inicial, "Fecha desde donde comienza la búsqueda de Documentos.")
        '
        'Fecha_final
        '
        Me.Fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha_final.Location = New System.Drawing.Point(168, 40)
        Me.Fecha_final.Name = "Fecha_final"
        Me.Fecha_final.Size = New System.Drawing.Size(112, 22)
        Me.Fecha_final.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Fecha_final, "Fecha donde finaliza la búsqueda de Documentos.")
        '
        'c4
        '
        Me.c4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c4.Items.AddRange(New Object() {"TODOS", "COMPRA", "DEVOLUCIONES", "AJUSTES"})
        Me.c4.Location = New System.Drawing.Point(16, 48)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(200, 21)
        Me.c4.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.c4, "Elija el tipo de Ingreso a Listar  O  seleccione TODOS para imprimir todos los in" & _
        "gresos no importando el tipo que tenga.")
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Bitmap)
        Me.Regresar.Location = New System.Drawing.Point(584, 16)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 59
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" & _
        "queda.")
        Me.Regresar.Visible = False
        '
        'Hoja
        '
        Me.Hoja.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hoja.ForeColor = System.Drawing.Color.Black
        Me.Hoja.Image = CType(resources.GetObject("Hoja.Image"), System.Drawing.Bitmap)
        Me.Hoja.Location = New System.Drawing.Point(664, 16)
        Me.Hoja.Name = "Hoja"
        Me.Hoja.Size = New System.Drawing.Size(35, 35)
        Me.Hoja.TabIndex = 60
        Me.Hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Hoja, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario")
        Me.Hoja.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.c4, Me.Uno, Me.Todos})
        Me.GroupBox1.Location = New System.Drawing.Point(320, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 80)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Seleccion de Cliente")
        '
        'Uno
        '
        Me.Uno.Location = New System.Drawing.Point(16, 32)
        Me.Uno.Name = "Uno"
        Me.Uno.Size = New System.Drawing.Size(120, 16)
        Me.Uno.TabIndex = 5
        Me.Uno.Text = "Solo un Cliente"
        '
        'Todos
        '
        Me.Todos.Checked = True
        Me.Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Todos.Location = New System.Drawing.Point(16, 16)
        Me.Todos.Name = "Todos"
        Me.Todos.Size = New System.Drawing.Size(128, 16)
        Me.Todos.TabIndex = 4
        Me.Todos.Text = "Todos los Clientes"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "12,1,0,0,0,85,Columns:0{Width:0;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:90;Name:""FECHA"";Caption:""FECHA"";TextAlign:CenterCenter;TextAlignFixed:Ce" & _
        "nterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:90;Name:""CLIENTE"";Caption:""CLIENTE"";TextAlign:LeftCenter;Te" & _
        "xtAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:70;Name:""TMOVTO"";Caption:""T.MOVTO"";TextAlign:L" & _
        "eftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:80;Name:""DOCTO"";Caption:""DOCTO."";T" & _
        "extAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:90;Name:""BATCH"";Caption:" & _
        """BATCH"";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:70;Name:""ROLLO""" & _
        ";Caption:""ROLLO"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:11" & _
        "0;Name:""KNIT"";Caption:""KNIT"";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{" & _
        "Width:150;Name:""COLOR"";Caption:""COLOR"";TextAlign:LeftCenter;TextAlignFixed:LeftC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:90;Name:""CPO"";Caption:""CPO"";TextAlign:LeftCenter;TextAlignFixed:" & _
        "LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:70;Name:""YARDAS"";Caption:""YARDAS"";DataType:System.Decimal;" & _
        "Format:""######.00"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:7" & _
        "0;Name:""LIBRAS"";Caption:""LIBRAS"";DataType:System.Decimal;Format:""######.00"";Text" & _
        "Align:RightCenter;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAlignFi" & _
        "xed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 96)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(1008, 584)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed" & _
        "{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlig" & _
        "ht{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackCol" & _
        "or:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTota" & _
        "l{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:0, 192, 192;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:" & _
        "ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColo" & _
        "r:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Incial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de Salida:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Listado_salidas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1022, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Hoja, Me.fg, Me.GroupBox1, Me.Fecha_final, Me.Fecha_inicial, Me.Imprimir, Me.tipo, Me.Label3, Me.Label1, Me.Label2, Me.si, Me.Regresar})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listado_salidas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Salidas a Inventario"
        Me.ToolTip1.SetToolTip(Me, "Para salir del programa Presione la X en la esquina superior derecha.")
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Listado_ingresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Fecha_inicial.KeyPress, AddressOf keypressed1
        AddHandler Fecha_final.KeyPress, AddressOf keypressed2
        AddHandler tipo.KeyPress, AddressOf keypressed3
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        ti(4) = "PRODUCC."
        ti(5) = "DEVOLU."
        ti(6) = "AJUSTES"
        ti(7) = "MUESTRAS"
        tipo.SelectedIndex = 0
        llena_combos(c4, "SELECT * FROM CLIENTES ORDER BY CLIENTE", "CLIENTE")
        Try
            If c4.Items.Count > 0 Then
                c4.SelectedIndex = 0
            End If
        Catch
        End Try
        fg.Rows(0).Height = 30
        setea_grid(str)
    End Sub

    Private Sub setea_grid(ByVal strsql As String)
        'Try
        Dim index As Integer
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.DataSource = GetDataSource(strsql)
        fg.Cols.Count = 17
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Caption = "FECHA"
        fg.Cols(2).Caption = "CLIENTE"
        fg.Cols(3).Caption = "T.MOVTO"
        fg.Cols(4).Caption = "DOCTO"
        fg.Cols(5).Caption = "FPO"
        fg.Cols(6).Caption = "BATCH"
        fg.Cols(7).Caption = "ROLLO"
        fg.Cols(8).Caption = "KNIT"
        fg.Cols(9).Caption = "COLOR"
        fg.Cols(10).Caption = "CPO"
        fg.Cols(11).Caption = "YARDAS"
        fg.Cols(12).Caption = "LIBRAS"
        fg.Cols(13).Caption = "COSTO LB."
        fg.Cols(14).Caption = "COSTO T."
        fg.Cols(15).Caption = "TEXTILERA"
        fg.Cols(16).Caption = "CORTE"
        fg.Cols(7).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(7).TextAlignFixed = TextAlignEnum.CenterCenter
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 90
            fg(0, index) = fg.Cols(index).Caption
            If index > 9 Then
                fg.Cols(index).Width = 70
            End If
            If index > 10 And index < 15 Then
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = h
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(1).Width = 80
        fg.Cols(2).Width = 80
        fg.Cols(3).Width = 70
        fg.Cols(7).Width = 50
        fg.Cols(8).Width = 150
        fg.Cols(9).Width = 150
        fg.Cols(15).Width = 150
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.Cols(4).AllowMerging = True
        fg.Cols(5).AllowMerging = True
        fg.Cols(6).AllowMerging = True
        'Catch
        'End Try
    End Sub

    Private Sub deshabilita()
        tipo.Enabled = False
        Fecha_inicial.Enabled = False
        Fecha_final.Enabled = False
        Uno.Enabled = False
        Todos.Enabled = False
        c4.Enabled = False
        Imprimir.Visible = True
        Regresar.Visible = True
        Hoja.Visible = True
        si.Visible = False
    End Sub

    Private Sub habilita()
        Fecha_inicial.Enabled = True
        Fecha_final.Enabled = True
        tipo.Enabled = True
        Uno.Enabled = True
        Todos.Enabled = True
        c4.Enabled = False
        Todos.Checked = True
        tipo.SelectedIndex = 0
        Imprimir.Visible = False
        Regresar.Visible = False
        Hoja.Visible = False
        si.Visible = True
    End Sub

    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Fecha_inicial.Text) <> "" Then
                Fecha_final.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Fecha_final.Text) <> "" Then
                tipo.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(tipo.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        If CDate(Fecha_final.Text) < CDate(Fecha_inicial.Text) Then
            MsgBox("La fecha final es menor que la inicial. Revise !!!!", MsgBoxStyle.OKOnly, "ERROR EN LAS FECHAS")
            Exit Sub
        Else
            Cursor = Cursors.WaitCursor
            deshabilita()
            asigna_Valores()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub asigna_Valores()
        Dim strSQL As String
        Dim i As Integer
        fecha_i = Format(CDate(Fecha_inicial.Text), "yyyy-MM-dd")
        fecha_f = Format(CDate(Fecha_final.Text), "yyyy-MM-dd")
        'strSQL = "SELECT FECHA,CLIENTE,TMOVTO,DOCTO,FPO,BATCH,ROLLO,(SELECT KNIT FROM ROLLOS WHERE ROLLOS.BATCH = DMOVTO.BATCH AND ROLLOS.ROLLO = DMOVTO.ROLLO)AS KNIT ,(SELECT COLOR FROM ROLLOS WHERE ROLLOS.BATCH = DMOVTO.BATCH AND ROLLOS.ROLLO = DMOVTO.ROLLO)AS COLOR, CPO,YARDAS,LIBRAS, PRECIO, (PRECIO*LIBRAS) AS TOTAL,(SELECT DISTINCT TEXTILERA FROM FPO WHERE FPO.FPO = DMOVTO.FPO) AS  TEXTILERA,CORTE FROM DMOVTO WHERE TIPO = 'TELA' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "' AND TMOVTO > '3' "
        strSQL = "SELECT FECHA,DMOVTO.CLIENTE,TMOVTO,DOCTO,DMOVTO.FPO,DMOVTO.BATCH,DMOVTO.ROLLO,KNIT ,COLOR, DMOVTO.CPO,DMOVTO.YARDAS,LIBRAS, PRECIO, (PRECIO*LIBRAS) AS TOTAL,(SELECT DISTINCT TEXTILERA FROM FPO WHERE FPO.FPO = DMOVTO.FPO) AS  TEXTILERA,CORTE FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO WHERE ROLLOS.TIPO = 'TELA' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "' AND TMOVTO > '3' "

        tip = tipo.SelectedIndex
        If tip > 0 Then
            tip = tipo.SelectedIndex + 3
            strSQL = strSQL + " AND TMOVTO = '" & tip & "' "
        End If
        If Uno.Checked Then
            strSQL = strSQL + " AND DMOVTO.CLIENTE = '" & Trim(c4.Text) & "'"
        End If
        strSQL = strSQL + " ORDER BY FECHA,DMOVTO.CLIENTE,TMOVTO,DOCTO "
        setea_grid(strSQL)
        For i = 1 To fg.Rows.Count - 1
            fg(i, 3) = ti((fg(i, 3)))
        Next
        subtotales()
    End Sub

    Private Sub Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Todos.CheckedChanged
        If Todos.Checked = True Then
            Uno.Checked = False
            c4.Enabled = False
        Else
            Uno.Checked = True
            c4.Enabled = True
        End If
    End Sub

    Private Sub Uno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Uno.CheckedChanged
        If Uno.Checked = True Then
            Todos.Checked = False
            c4.Enabled = True
        Else
            Todos.Checked = True
            c4.Enabled = False
        End If
    End Sub

    Private Sub subtotales()
        With fg
            .Redraw = False
            Dim totalya As Integer = fg.Cols("YARDAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 4, totalya, "Total Batch")
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 4, totalya, "Total Batch")
            fg.Subtotal(AggregateEnum.Sum, 1, 4, totalib, "Total Batch")
            fg.Subtotal(AggregateEnum.Sum, 1, 4, 14, "Total Batch")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, 14, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGreen
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
            .Redraw = True
            'fg.Tree.Show(1)
        End With
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        habilita()
        setea_grid(str)
    End Sub

    Private Function GetDataSource(ByVal Strsql As String) As DataTable
        def_sql(cnn)
        Dim da As System.Data.SqlClient.SqlDataAdapter
        da = New System.Data.SqlClient.SqlDataAdapter(Strsql, cnn)
        Dim ds As DataSet
        ds = New DataSet()
        da.Fill(ds)
        GetDataSource = ds.Tables(0)
    End Function

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Reporte de Salidas de Bodega de Tela" + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hoja.Click
        Dim ok As Boolean
        fg.Subtotal(AggregateEnum.Clear)
        a_excel(fg, path, ok)
        If ok Then
            Close()
        Else
            subtotales()
        End If
    End Sub
End Class
