Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Control_Corte
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As SqlClient.SqlConnection
    Dim dr As DataRow
    Dim te(9) As String
    Dim tp(9) As String
    Dim da(9) As Integer
    Dim st(3) As String
    Dim fecha As String
    Dim fecha1 As String
    Dim corte As String
    Dim colo As String
    Dim estilo As String
    Dim cpo As String
    Dim fechac As String
    Dim l As Integer = 1
    Dim path As String = "c:\estado_cliente.xls"
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
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fecha_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Friend WithEvents excel As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Control_Corte))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.S1 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fecha_f = New System.Windows.Forms.DateTimePicker()
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.excel = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Bitmap)
        Me.S1.Location = New System.Drawing.Point(680, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 64)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 624)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;Border:None,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{Displa" & _
        "y:Stack;BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highli" & _
        "ght{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highligh" & _
        "t;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColo" & _
        "r:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;F" & _
        "oreColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackCol" & _
        "or:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bo" & _
        "ld;BackColor:186, 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackC" & _
        "olor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeC" & _
        "olor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{Bac" & _
        "kColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "CustomStyle1{BackColor:253, 249, 198;}" & Microsoft.VisualBasic.ChrW(9) & _
        "CustomStyle2{BackColor:251, 210, 222;}" & Microsoft.VisualBasic.ChrW(9) & "CustomStyle3{BackColor:183, 244, 221;}" & Microsoft.VisualBasic.ChrW(9) & "Cu" & _
        "stomStyle4{Display:Overlay;Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackCol" & _
        "or:Gold;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'fecha_f
        '
        Me.fecha_f.CustomFormat = "dd/MM/yyyy"
        Me.fecha_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_f.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha_f.Location = New System.Drawing.Point(464, 32)
        Me.fecha_f.Name = "fecha_f"
        Me.fecha_f.Size = New System.Drawing.Size(136, 26)
        Me.fecha_f.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Fecha de la Produccion")
        '
        'fecha_i
        '
        Me.fecha_i.CustomFormat = "dd/MM/yyyy"
        Me.fecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha_i.Location = New System.Drawing.Point(464, 0)
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(136, 26)
        Me.fecha_i.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Fecha de la Produccion")
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Bitmap)
        Me.Cancela.Location = New System.Drawing.Point(720, 8)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(35, 35)
        Me.Cancela.TabIndex = 66
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Cancela.Visible = False
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Bitmap)
        Me.excel.Location = New System.Drawing.Point(760, 8)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(35, 35)
        Me.excel.TabIndex = 67
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.Visible = False
        '
        'C4
        '
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(88, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Hasta:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Desde:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Control_Corte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C4, Me.Label6, Me.excel, Me.fecha_f, Me.Label2, Me.Label1, Me.fecha_i, Me.Cancela, Me.fg, Me.S1})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Control_Corte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria de Cortes  (Cortado vrs Exportado)"
        Me.ToolTip1.SetToolTip(Me, "Control de Cortes")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        st = Split("customstyle1,customstyle2,customstyle3", ","c)
        llena_combos(C4, "SELECT CLIENTE FROM CLIENTES ORDER BY CLIENTE ", "CLIENTE")
        setea_fg()
        fecha_i.Focus()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Fixed = 0
        fg.Cols.Count = 18
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(0).Name = "CORTE"
        fg.Cols(1).Name = "ESTILO"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "PROCESO"
        fg.Cols(4).Name = "XS"
        fg.Cols(5).Name = "S"
        fg.Cols(6).Name = "M"
        fg.Cols(7).Name = "L"
        fg.Cols(8).Name = "XL"
        fg.Cols(9).Name = "2XL"
        fg.Cols(10).Name = "3XL"
        fg.Cols(11).Name = "4XL"
        fg.Cols(12).Name = "5XL"
        fg.Cols(13).Name = "6XL"
        fg.Cols(14).Name = "SEG"
        fg.Cols(15).Name = "TOT."
        fg.Cols(16).Name = "FECHA"
        fg.Cols(17).Name = "CLIENTE"
        For index = 0 To fg.Cols.Count - 1
            fg.Cols(index).Width = 105
            fg(0, index) = fg.Cols(index).Name
            If index > 3 And index < 16 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 50
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(0).AllowMerging = True
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(0).Width = 70
        fg.Cols(1).Width = 80
        fg.Cols(3).Width = 85
        fg.Cols(15).Width = 70
        fg.Cols(16).Width = 100
        fg.Cols(15).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(15).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(16).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(16).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(17).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(17).TextAlignFixed = TextAlignEnum.CenterCenter
        l = 1
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim i As Integer
        Dim contador As Integer
        Dim total As Integer = 0
        Dim strSQL As String = "SELECT * FROM CORTES LEFT JOIN CORTES_P ON CORTES.CORTE = CORTES_P.CORTE LEFT JOIN CORTES_E ON CORTES.CORTE = CORTES_E.CORTE WHERE FCORTE BETWEEN '" & fecha & "' AND '" & fecha1 & "' AND CLIENTE = '" & C4.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = (dt.Rows.Count * 5) + 1
        For Each Me.dr In dt.Rows
            corte = dr("CORTE")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            fechac = dr("FCORTE")
            fg(l + 2, 17) = dr("CLIENTE")
            fg(l, 3) = "CORTADO"
            fg(l, 16) = fechac
            total = 0
            For i = 6 To 15
                fg(l, i - 2) = dr(i)
                total = total + fg(l, i - 2)
            Next
            fg(l, 15) = total
            contador = contador + 1
            If contador > 2 Then
                contador = 0
            End If
            For i = l To l + 4
                fg.Rows(i).Style = fg.Styles(st(contador))
            Next
            llena_produccion()
            llena_exportacion()
            stock()
            diferencia()
            l = l + 5
        Next
    End Sub

    ''=============================================== PRODUCCION  ================================================
    Private Sub llena_produccion()
        Dim i As Integer
        Dim dato As Integer
        Dim seg As Integer
        Dim total As Integer = 0
        fg(l + 1, 3) = "PRODUCCION"
        For i = 23 To 32
            Try
                dato = dr(i)
            Catch
                dato = 0
            End Try
            Try
                seg = dr(i + 10)
            Catch
                seg = 0
            End Try
            total = dato + seg
            fg(l + 1, 14) = fg(l + 1, 14) + seg
            fg(l + 1, 15) = fg(l + 1, 15) + total
            fg(l + 1, i - 19) = dato
        Next
    End Sub

    ''=============================================== EXPORTACION  ================================================
    Private Sub llena_exportacion()
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim SEG As Integer
        fg(l + 2, 0) = corte
        fg(l + 2, 1) = estilo
        fg(l + 2, 2) = colo
        fg(l + 2, 3) = "EXPORTACION"
        For i = 44 To 53
            Try
                dato = dr(i)
            Catch
                dato = 0
            End Try
            Try
                SEG = SEG + dr(i + 10)
            Catch
                SEG = 0
            End Try
            total = dato + SEG
            fg(l + 2, 14) = fg(l + 2, 14) + SEG
            fg(l + 2, 15) = fg(l + 2, 15) + total
            fg(l + 2, i - 40) = dato
        Next
    End Sub

    Private Sub stock()
        Dim dt As New DataTable()
        Dim talla As String
        Dim tipo As String = ""
        Dim prendas As Integer
        Dim i As Integer
        Dim tt(9) As String
        Dim tallas As String = "XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL"
        tt = Split(tallas, ","c)
        fg(l + 3, 3) = "STOCK"
        Dim strSQL As String = "SELECT CORTE,TIPO,TALLA,SUM(PRENDAS) AS PRENDA FROM E_STOCK WHERE CORTE = '" & corte & "' GROUP BY CORTE,TALLA "
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            talla = dr("TALLA")
            prendas = dr("PRENDA")
            i = Array.IndexOf(tt, talla)
            If tipo = 0 Then
                fg(l + 3, i + 4) = fg(l + 3, i + 4) + prendas
            Else
                fg(l + 3, 14) = fg(l + 3, 14) + prendas
            End If
            fg(l + 3, 15) = fg(l + 3, 15) + prendas
        Next
    End Sub


    Private Sub diferencia()
        Dim i As Integer
        fg(l + 4, 3) = "DIFERENCIA"
        For i = 0 To 10
            fg(l + 4, i + 4) = fg(l, i + 4) - fg(l + 2, i + 4)
            fg.SetCellStyle(l + 4, i + 4, fg.Styles("customstyle4"))
        Next
        fg(l + 4, 15) = fg(l, 15) - fg(l + 2, 15)

        fg.SetCellStyle(l + 4, 15, fg.Styles("customstyle4"))
    End Sub


    Private Sub chequea_fechas(ByRef ok As Boolean)
        ok = True
        fecha = Format(CDate(fecha_i.Text), "yyyy-MM-dd")
        fecha1 = Format(CDate(fecha_f.Text), "yyyy-MM-dd")
        If fecha1 < fecha Then
            fecha = fecha1
            ok = False
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Por favor verifique !!")
        End If
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        chequea_fechas(ok)
        If ok Then
            Cursor = Cursors.WaitCursor
            llena_fg()
            S1.Visible = False
            Cancela.Visible = True
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            C4.Enabled = False
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancela.Click
        Cancela.Visible = False
        S1.Visible = True
        fecha_i.Enabled = True
        fecha_f.Enabled = True
        C4.Enabled = True
        setea_fg()
    End Sub

    Private Sub excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\auditoria_cortes.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

End Class



