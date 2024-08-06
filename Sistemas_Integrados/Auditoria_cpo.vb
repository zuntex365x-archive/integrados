Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Auditoria_cpo
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim cpos As String
    Dim te(9) As String
    Dim tp(9) As String
    Dim da(9) As Integer
    Dim st(3) As String
    Dim fecha As String
    Dim fecha1 As String
    Dim corte As String
    Dim exp As New DataTable
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
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
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CPO As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auditoria_cpo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.S1 = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.CPO = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(312, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Efectuar la consulta")
        Me.S1.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(352, 8)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(35, 35)
        Me.Cancela.TabIndex = 66
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Otro CPO.")
        Me.Cancela.UseVisualStyleBackColor = False
        Me.Cancela.Visible = False
        '
        'CPO
        '
        Me.CPO.BackColor = System.Drawing.Color.White
        Me.CPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPO.Location = New System.Drawing.Point(8, 24)
        Me.CPO.MaxDropDownItems = 15
        Me.CPO.Name = "CPO"
        Me.CPO.Size = New System.Drawing.Size(248, 24)
        Me.CPO.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.CPO, "Elija el Cpo  a Consultar .")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(392, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 69
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "CPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "1,1,0,0,0,85,Columns:0{Width:0;Style:""TextAlign:LeftCenter;"";StyleFixed:""TextAlig" &
    "n:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 64)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 20
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(981, 602)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 102
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        '
        'Auditoria_cpo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CPO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.S1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Auditoria_cpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria de Cortes por CPO"
        Me.ToolTip1.SetToolTip(Me, "Control de Cortes")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler CPO.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(CPO, "SELECT DISTINCT CPO FROM CPO  WHERE YEAR(F_PEDIDO) > '2009' ORDER BY CPO", "CPO")
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        st = Split("customstyle1,customstyle2,customstyle3", ","c)
        setea_fg()
        CPO.Focus()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Fixed = 0
        fg.Cols.Count = 19
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
        fg.Cols(14).Name = "TOT."
        fg.Cols(15).Name = "SEG."
        fg.Cols(16).Name = "FECHA C."
        fg.Cols(17).Name = "CLIENTE"
        fg.Cols(18).Name = "CPO"
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
        fg.Cols(0).Width = 85
        fg.Cols(1).Width = 90
        fg.Cols(2).Width = 150
        fg.Cols(3).Width = 85
        fg.Cols(16).Width = 80
        fg.Cols(17).Width = 150
        fg.Cols(16).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(17).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim colo As String
        Dim estilo As String
        Dim i As Integer
        Dim contador As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim fechac As String
        Dim strSQL As String = "SELECT * FROM CORTES LEFT JOIN CORTES_P ON CORTES.CORTE = CORTES_P.CORTE LEFT JOIN CORTES_E ON CORTES.CORTE = CORTES_E.CORTE WHERE CPO = '" & CPO.Text & "' ORDER BY CORTES.CORTE"
        llena_tablas(dt, strSQL, cnn)
        strSQL = "SELECT * FROM PACKING_D WHERE CPO = '" & CPO.Text & "' ORDER BY CORTE"
        llena_tablas(exp, strSQL, cnn)
        For Each dr In dt.Rows
            contador = contador + 1
            lineas = fg.Rows.Count
            fg.Rows.Count = fg.Rows.Count + 6
            corte = dr("CORTE")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            fechac = dr("FCORTE")
            cpos = dr("CPO")
            fg(lineas, 0) = corte
            fg(lineas, 1) = estilo
            fg(lineas, 2) = colo
            fg(lineas, 3) = "CORTADO"
            fg(lineas, 16) = fechac
            fg(lineas, 17) = dr("CLIENTE")
            fg(lineas, 18) = cpos
            total = 0
            For i = 0 To 9
                dato = te(i)
                fg(lineas, i + 4) = dr(dato)
                total = total + fg(lineas, i + 4)
            Next
            fg(lineas, 14) = total
            If contador > 2 Then
                contador = 0
            End If
            For i = lineas To lineas + 5
                fg.Rows(i).Style = fg.Styles(st(contador))
            Next
            llena_produccion(dr)
            llena_exportacion(dr)
            llena_vales(corte, estilo, colo, fechac)
            stock(corte, estilo, colo, fechac, dr)
            diferencia(corte, estilo, colo, fechac)
        Next
    End Sub


    ''=============================================== PRODUCCION  ================================================
    Private Sub llena_produccion(ByVal dr As DataRow)
        Dim i As Integer
        Dim dato As String
        Dim seg As String
        Dim total As Integer = 0
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM CORTES_P  WHERE CORTE = '" & corte & "'"
        fg(lineas + 1, 0) = dr("CORTE")
        fg(lineas + 1, 1) = dr("ESTILO")
        fg(lineas + 1, 2) = dr("COLOR")
        fg(lineas + 1, 3) = "PRODUCCION"
        For i = 0 To 9
            dato = "P" + Trim(Str(i))
            seg = "S" + Trim(Str(i))
            Try
                fg(lineas + 1, i + 4) = dr(dato) + dr(seg)
                total = total + fg(lineas + 1, i + 4)
                fg(lineas + 1, 15) = fg(lineas + 1, 15) + dr(seg)
            Catch
            End Try
        Next
        fg(lineas + 1, 14) = total
    End Sub
    ''=============================================== EXPORTACION  ================================================
    Private Sub llena_exportacion(ByVal dr As DataRow)
        Dim i As Integer
        Dim strsql = "CORTE IN ('" & dr("CORTE") & "','ST-" & dr("CORTE") & "')"
        Dim total As Integer = 0
        Dim dd As DataRow()
        Dim dj As DataRow
        fg(lineas + 2, 0) = dr("CORTE")
        fg(lineas + 2, 1) = dr("ESTILO")
        fg(lineas + 2, 2) = dr("COLOR")
        fg(lineas + 2, 3) = "EXPORTACION"
        dd = exp.Select(strsql)
        If dd.Length > 0 Then
            For Each dj In dd
                For i = 8 To 17
                    If dj(2) = "Seg" Then
                        fg(lineas + 2, 15) = fg(lineas + 2, 15) + dj(i)
                    End If
                    fg(lineas + 2, i - 4) = dj(i)
                    total = total + fg(lineas + 2, i - 4)
                Next
                fg(lineas + 2, 14) = total
            Next
        End If
    End Sub

    ''=============================================== VALES  ================================================
    Private Sub llena_vales(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByVal fechac As String)
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM CORTES_V WHERE CORTE = '" & corte & "'"
        fg(lineas + 3, 0) = corte
        fg(lineas + 3, 1) = estilo
        fg(lineas + 3, 2) = colo
        fg(lineas + 3, 3) = "VALES"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            For i = 0 To 9
                dato = tp(i)
                fg(lineas + 3, i + 4) = dr(dato) + dr(Trim("S" + CStr(i)))
                total = total + fg(lineas + 3, i + 4)
                fg(lineas + 3, 15) = fg(lineas + 3, 15) + dr("S" + CStr(i))

            Next
            fg(lineas + 3, 14) = total
        Next
    End Sub

    Private Sub stock(ByVal corte As String, ByVal estilo As String, ByVal colo As String, ByVal fechac As String, ByVal dl As DataRow)
        Dim talla As String
        Dim prendas As Integer
        Dim i As Integer
        Dim tt(9) As String
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim tallas As String = "XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL"
        tt = Split(tallas, ","c)
        fg(lineas + 4, 0) = dl("CORTE")
        fg(lineas + 4, 1) = dl("ESTILO")
        fg(lineas + 4, 2) = dl("COLOR")
        fg(lineas + 4, 3) = "STOCK"
        Dim strSQL As String = "SELECT CORTE,TALLA,SUM(PRENDAS - EXPORT) AS PRENDA,TIPO FROM E_STOCK WHERE CORTE = '" & corte & "' GROUP BY CORTE,TALLA,TIPO"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            talla = dr("TALLA")
            prendas = dr("PRENDA")
            i = Array.IndexOf(tt, talla)
            fg(lineas + 4, i + 4) = fg(lineas + 4, i + 4) + prendas
            fg(lineas + 4, 14) = fg(lineas + 4, 14) + prendas
            If dr("TIPO") = 1 Then
                fg(lineas + 4, 15) = fg(lineas + 4, 15) + prendas
            End If
        Next
    End Sub


    Private Sub diferencia(ByVal corte As String, ByVal estilo As String, ByVal colo As String, ByVal fechac As String)
        Dim i As Integer
        fg(lineas + 5, 3) = "DIFERENCIA"
        For i = 0 To 9
            fg(lineas + 5, i + 4) = fg(lineas, i + 4) - fg(lineas + 2, i + 4) - fg(lineas + 3, i + 4) - fg(lineas + 4, i + 4)
            fg(lineas + 5, 14) = fg(lineas + 5, 14) + fg(lineas + 5, i + 4)
            fg.SetCellStyle(lineas + 5, i + 4, fg.Styles("customstyle4"))
        Next
        fg.SetCellStyle(lineas + 5, 14, fg.Styles("customstyle4"))

    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        setea_fg()
            llena_fg()
            S1.Visible = False
            Cancela.Visible = True
            CPO.Enabled = False
            Button2.Visible = True
    End Sub


    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancela.Click
        Cancela.Visible = False
        S1.Visible = True
        CPO.Enabled = True
        Button2.Visible = False
        setea_fg()
    End Sub
    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CPO.KeyPress
        AutoCompletar(CPO, e)
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 10
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Auditoria", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Auditoria de Cortes del Cpo: " + Trim(CPO.Text) + "  al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(CPO.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed
End Class



