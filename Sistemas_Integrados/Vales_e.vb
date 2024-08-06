Imports C1.Win.C1FlexGrid

Public Class Vales_e
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim usuario_sistema As String
    Dim lineas As Integer
    Dim dt As New DataTable()
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nvale As System.Windows.Forms.ComboBox
    Friend WithEvents corte As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents autorizada As System.Windows.Forms.ComboBox
    Friend WithEvents recibe As System.Windows.Forms.Label
    Friend WithEvents fvale As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents tallas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Vales_e))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.G1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.motivo = New System.Windows.Forms.ComboBox()
        Me.nvale = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.corte = New System.Windows.Forms.Label()
        Me.recibe = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fvale = New System.Windows.Forms.Label()
        Me.autorizada = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.tallas = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(168, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(312, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fecha A."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Bitmap)
        Me.G1.Location = New System.Drawing.Point(912, 24)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 51
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Actualiza la BAse de Datos.")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(456, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 24)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Vale Emitido a "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "7,1,0,0,0,95,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:138;Caption:""CORTE"";AllowEditing:False;DataType:System.String;TextAlign:C" & _
        "enterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:335;Caption:""MOTIVO DEL VALE"";" & _
        "AllowEditing:False;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:162;" & _
        "Caption:""T.PRENDA"";AllowEditing:False;DataType:System.String;TextAlign:LeftCente" & _
        "r;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Caption:""TALLA"";AllowEditing:False;DataType:Syst" & _
        "em.String;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Caption:""PRENDA" & _
        "S"";AllowEditing:False;DataType:System.Int32;Format:""###0"";TextAlign:RightCenter;" & _
        "TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Caption:""ANULAR"";DataType:System.Decimal;Format:""" & _
        "##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 160)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(944, 488)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackCol" & _
        "or:167, 232, 245;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,Co" & _
        "ntrolDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Se" & _
        "arch{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewR" & _
        "ow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Grand" & _
        "Total{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;Fore" & _
        "Color:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{Ba" & _
        "ckColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;Fo" & _
        "reColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{" & _
        "BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 24)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Motivo Anulación"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'motivo
        '
        Me.motivo.Items.AddRange(New Object() {"Recuperación de Prendas", "Error ingreso de Datos"})
        Me.motivo.Location = New System.Drawing.Point(16, 120)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(288, 24)
        Me.motivo.TabIndex = 3
        '
        'nvale
        '
        Me.nvale.Items.AddRange(New Object() {"Si", "No"})
        Me.nvale.Location = New System.Drawing.Point(16, 40)
        Me.nvale.Name = "nvale"
        Me.nvale.Size = New System.Drawing.Size(136, 24)
        Me.nvale.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Vale"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.corte.ForeColor = System.Drawing.Color.Black
        Me.corte.Location = New System.Drawing.Point(168, 40)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(136, 24)
        Me.corte.TabIndex = 71
        Me.corte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'recibe
        '
        Me.recibe.BackColor = System.Drawing.Color.White
        Me.recibe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recibe.ForeColor = System.Drawing.Color.Black
        Me.recibe.Location = New System.Drawing.Point(456, 40)
        Me.recibe.Name = "recibe"
        Me.recibe.Size = New System.Drawing.Size(392, 24)
        Me.recibe.TabIndex = 72
        Me.recibe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(312, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Fecha E."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fvale
        '
        Me.fvale.BackColor = System.Drawing.Color.White
        Me.fvale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fvale.ForeColor = System.Drawing.Color.Black
        Me.fvale.Location = New System.Drawing.Point(312, 40)
        Me.fvale.Name = "fvale"
        Me.fvale.Size = New System.Drawing.Size(136, 24)
        Me.fvale.TabIndex = 74
        Me.fvale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'autorizada
        '
        Me.autorizada.Items.AddRange(New Object() {"Contabilidad", "Tony Lopez Ibañez", "Juan Sanchez B.", "Juan Sanchez J."})
        Me.autorizada.Location = New System.Drawing.Point(456, 120)
        Me.autorizada.Name = "autorizada"
        Me.autorizada.Size = New System.Drawing.Size(392, 24)
        Me.autorizada.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(225, Byte), CType(250, Byte))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(456, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 24)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Anulación Autorizada por"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fecha.ForeColor = System.Drawing.Color.Black
        Me.fecha.Location = New System.Drawing.Point(312, 120)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(136, 24)
        Me.fecha.TabIndex = 77
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tallas
        '
        Me.tallas.Items.AddRange(New Object() {"Primera", "Segunda"})
        Me.tallas.Location = New System.Drawing.Point(864, 120)
        Me.tallas.Name = "tallas"
        Me.tallas.Size = New System.Drawing.Size(72, 24)
        Me.tallas.TabIndex = 78
        Me.tallas.Visible = False
        '
        'Vales_e
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tallas, Me.fecha, Me.autorizada, Me.Label2, Me.fvale, Me.Label5, Me.recibe, Me.corte, Me.nvale, Me.Label8, Me.motivo, Me.Label4, Me.fg, Me.Label3, Me.G1, Me.Label19, Me.Label1, Me.Label9})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vales_e"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anulación de Vales"
        Me.ToolTip1.SetToolTip(Me, "Anulación de Vales")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler nvale.KeyPress, AddressOf keypressed1
        AddHandler motivo.KeyPress, AddressOf keypressed2
        AddHandler autorizada.KeyPress, AddressOf keypressed3
        llena_combos(tallas, "SELECT * FROM TALLAS ORDER BY ORDEN", "TALLA")
        Dim obj As empresas
        obj = New empresas()
        usuario_sistema = obj.usuario
        limpia_variables()
        nvale.Focus()
    End Sub

    Private Sub limpia_variables()
        llena_combos(nvale, "SELECT DISTINCT VALE FROM VALES WHERE (PRENDAS - UNIDADES) > 0 ORDER BY VALE ", "VALE")
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub


    Private Sub llena_vales()
        setea_grid()
        Dim l As Integer = 1
        dt = New DataTable()
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM VALES WHERE (PRENDAS - UNIDADES) > 0 AND VALE = '" & nvale.Text & "' ORDER BY VALE"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            corte.Text = dr("CORTE")
            fvale.Text = Format(dr("FECHA"), "dd/MM/yyyy")
            recibe.Text = dr("RECIBE")
            fg(l, 1) = dr("CORTE")
            fg(l, 2) = dr("MOTIVO")
            fg(l, 3) = dr("TIPO")
            fg(l, 4) = dr("TALLA")
            fg(l, 5) = dr("PRENDAS") - dr("UNIDADES")
            fg(l, 6) = fg(l, 5)
            l = l + 1
        Next
    End Sub

    Private Sub chequea_lineas(ByRef ok As Boolean)
        ok = True
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 6) > fg(i, 5) Then
                MsgBox("En la línea " & CStr(i) & " las prendas anuladas son mayores que las prendas del Vale", MsgBoxStyle.Critical, "Revisar Prendas")
                ok = False
            End If
        Next
    End Sub


    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim si As Boolean = True
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Esta completamente seguro de Grabar los Registros Ingresados?", MsgBoxStyle.YesNo, "Grabacion de Registros")
        If seguro = MsgBoxResult.No Then
            Exit Sub
        End If
        chequea_lineas(si)
        If si Then
            graba_registros()
            limpia_variables()
        End If
    End Sub

    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            motivo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            autorizada.Focus()
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            G1.Focus()
        End If
    End Sub 'keypressed

    Private Sub motivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles motivo.KeyPress
        AutoCompletar(motivo, e)
    End Sub
    Private Sub autorizada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles autorizada.KeyPress
        AutoCompletar(autorizada, e)
    End Sub
    Private Sub nvale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nvale.KeyPress
        AutoCompletar(nvale, e)
    End Sub

    '===================================================================
    '==           ACTUALIZA BASE DE DATOS
    '===================================================================
    Private Sub graba_registros()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim ti As String
        Dim ta As String
        Dim p(9) As Integer
        Dim s(9) As Integer
        Dim fechac As String = Format(Now, "yyyy-MM-dd")
        Dim tallas(10) As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                llena_tallas(tallas, fg(i, 1))
                ' ================ ENCABEZADOS ====================
                strsql = "INSERT INTO VALES_A (VALE,CORTE,TIPO,TALLA,FECHA,PRENDAS,MOTIVO,AUTORIZADO,INGRESADO) " & _
                                         "VALUES ( '" & nvale.Text & "','" & _
                                                    fg(i, 1) & "','" & _
                                                    fg(i, 3) & "','" & _
                                                    fg(i, 4) & "','" & _
                                                    fechac & "','" & _
                                                    fg(i, 6) & "','" & _
                                                    motivo.Text & "','" & _
                                                    autorizada.Text & "','" & _
                                                    usuario_sistema & "')"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                ' ================ ACTUALIZA CORTES_V  ====================
                ti = Mid(fg(i, 3), 1, 1)
                ta = Array.IndexOf(tallas, fg(i, 4))
                strsql = "UPDATE CORTES_V SET " & ti + ta & " = " & ti + ta & " - " & fg(i, 6) & " WHERE CORTE = '" & fg(i, 1) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                ' ================ ACTUALIZA CORTES_V  ====================
                strsql = "UPDATE VALES SET UNIDADES = UNIDADES + " & fg(i, 6) & " WHERE VALE = '" & nvale.Text & "' AND CORTE = '" & fg(i, 1) & "' AND TIPO = '" & fg(i, 3) & "' AND TALLA = '" & fg(i, 4) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next
            transaccion.Commit()
            MsgBox("DATOS ACTUALIZADOS", MsgBoxStyle.Information, "VALE ANULADO")

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
    Private Sub llena_tallas(ByRef tallas() As String, ByVal corte As String)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim i As Integer
        Dim strsql As String = "SELECT T1,T2,T3,T4,T5,T6,T7,T8,T9,T0 FROM E_TALLAS  WHERE ESCALA = (SELECT ESCALA FROM CPO_D LEFT JOIN CORTES ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR WHERE CORTE = '" & corte & "')"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            For i = 0 To 9
                tallas(i) = dr(i)
            Next
        Next
    End Sub
    Private Sub nvale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nvale.SelectedIndexChanged
        motivo.SelectedIndex = 0
        autorizada.SelectedIndex = 0
        fecha.Text = Format(Now, "dd/MM/yyyy")
        llena_vales()
    End Sub
End Class
