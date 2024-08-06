Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class Wip2
    Inherits System.Windows.Forms.Form
    Public la As Integer
    Public an As Integer
    Dim h As String = "##,##0"
    Dim d As String = "dd MMM yy"
    Dim cts As Integer
    Dim cse As Integer
    Dim cbo As Integer
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cpo As New DataTable()
    Dim con As New DataTable()
    Dim fpo As New DataTable()
    Dim fco As New DataTable()
    Dim rut As New DataTable()
    Dim es As New DataTable()
    Dim f_rec As DataTable
    Dim c As Integer
    Dim antes As String
    Dim strSQl As String
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Dim tv(9) As String
    Dim da(9) As Integer
    Dim ru(8) As String
    Dim st(3) As String
    Friend WithEvents cpos As System.Windows.Forms.ComboBox
    Dim cl(42) As String
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tipos As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wip2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tipos = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cpos = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(776, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(736, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(88, 18)
        Me.C4.MaxDropDownItems = 12
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(168, 24)
        Me.C4.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(816, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 60
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'tipos
        '
        Me.tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipos.Items.AddRange(New Object() {"TODOS", "CPO"})
        Me.tipos.Location = New System.Drawing.Point(423, 18)
        Me.tipos.Name = "tipos"
        Me.tipos.Size = New System.Drawing.Size(80, 24)
        Me.tipos.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.tipos, "Uno o todos los Cpos.")
        Me.tipos.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(856, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 70
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'cpos
        '
        Me.cpos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cpos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cpos.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.cpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpos.Items.AddRange(New Object() {"TODOS", "CPO"})
        Me.cpos.Location = New System.Drawing.Point(542, 18)
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(229, 24)
        Me.cpos.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.cpos, "Uno o todos los Cpos.")
        Me.cpos.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Rows.Fixed = 2
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 648)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 63
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(680, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 42)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Un Momento por favor.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Me encuentro Procesando"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Selección:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Wip2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 704)
        Me.Controls.Add(Me.cpos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tipos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wip2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Production Tracking Report"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Wip2_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 20
        fg.Height = Me.Height - 110
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        tv = Split("XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL,TOTAL", ","c)
        st = Split("rojo,blanco,verde", ","c)
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO, CPO_D WHERE CPO.CPO = CPO_D.CPO AND ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
        C4.SelectedIndex = 0
        tipos.SelectedIndex = 0
        C4.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        Label1.Visible = True
        Label2.Visible = True
        Label1.Refresh()
        Cursor = Cursors.WaitCursor
        S1.Visible = False
        R1.Visible = True
        Button2.Visible = True
        tipos.Visible = True
        llena_cpos()
        deshabilita()
        procesa()
        fg.ScrollBars = ScrollBars.Both
        Cursor = Cursors.Arrow
        Label1.Visible = False
        R1.Focus()
    End Sub

    Private Sub deshabilita()
        C4.Enabled = False
        Button3.Visible = True
    End Sub

    Private Sub otro_cliente()
        C4.Enabled = True
        S1.Visible = True
        R1.Visible = False
        tipos.Visible = False
        Cpos.Visible = False
        Label2.Visible = False
        Button3.Visible = False
        Button2.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        otro_cliente()
    End Sub

    Private Sub procesa()
        llena_ruta()
        llena_consumos()
        llena_fpos_rec(C4.Text, fpo, f_rec)
        llena_fg()
        cortes()
        llena_exportacion_stock()
        controla_procesos()
        llena_programas()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 2
        fg.Rows.Fixed = 2
        fg.Cols.Count = 47
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Rows(1).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "RCVD.PO"
        fg.Cols(2).Name = "PO"
        fg.Cols(3).Name = "STYLE"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "SIZE"
        fg.Cols(6).Name = "QTY"
        fg.Cols(7).Name = "ACTUAL"
        fg.Cols(8).Name = "BALAN."
        fg.Cols(9).Name = "OFFER.D."
        fg.Cols(10).Name = "PLAN"
        fg.Cols(11).Name = "ACTUAL"
        fg.Cols(12).Name = "ACT.PCS"
        fg.Cols(13).Name = "% AC-PL"
        fg.Cols(28).Visible = False
        fg.Cols(44).Name = "  X-CHAR"
        fg.Cols(45).Name = "PROGRAM"
        fg.Cols(46).Name = "DESTINATION"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 50
            fg(1, index) = fg.Cols(index).Name
            fg.Cols(index).AllowEditing = False
            If index < 6 Then
                fg.Cols(index).AllowMerging = True
            End If
            If index > 13 Then
                fg.Cols(index).Visible = False
            End If
        Next
        fg.Cols(44).Visible = False
        fg.Cols(45).Visible = True
        fg.Cols(46).Visible = True
        fg.Cols(44).Width = 70
        fg.Cols(45).Width = 120
        fg.Cols(46).Width = 150
        fg.Cols(44).AllowMerging = True
        fg.Cols(45).AllowMerging = True
        forma_fecha(1)
        forma_entero(6)
        forma_fecha(7)
        forma_entero(8)
        forma_fecha(9)
        forma_fecha(10)
        forma_fecha(11)
        forma_entero(12)
        fg.Cols(13).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(13).TextAlignFixed = TextAlignEnum.RightCenter

        fg.Cols(2).Width = 105
        fg.Cols(3).Width = 80
        fg.Cols(4).Width = 150
        fg.Cols(5).Width = 50
        fg.Cols(12).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(12).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(15).Width = 50
        fg.Cols(15).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(20).Width = 50
        fg.Cols(20).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(23).Width = 50
        fg.Cols(23).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(27).Width = 250
        fg.Cols(27).AllowMerging = True
        fg.Cols(5).Visible = False

        Dim rng1 = fg.GetCellRange(0, 1, 0, 6)
        rng1.Data = "PO INFORMATION"
        rng1.Style = fg.Styles("c1")
        fg.Rows(0).AllowMerging = True

        rng1 = fg.GetCellRange(1, 1, 1, 6)
        rng1.Style = fg.Styles("c2")

        rng1 = fg.GetCellRange(0, 7, 0, 9)
        rng1.Data = "FABRIC RECEIVED"
        rng1.Style = fg.Styles("c3")

        rng1 = fg.GetCellRange(1, 7, 1, 9)
        rng1.Style = fg.Styles("c4")

        rng1 = fg.GetCellRange(0, 10, 0, 13)
        rng1.Data = "CUT"
        rng1.Style = fg.Styles("c1")
        fg.Rows(0).AllowMerging = True

        rng1 = fg.GetCellRange(1, 10, 1, 13)
        rng1.Style = fg.Styles("c2")

        ru = Split("0,0,0,0,0,0,0,0,0", ","c)
        fg.Cols.Fixed = 7

        rng1 = fg.GetCellRange(0, 44, 1, 44)
        rng1.Style = fg.Styles("c1")
        forma_fecha(44)
    End Sub

    Private Sub forma_fecha(ByVal c As Integer)
        fg.Cols(c).DataType = GetType(Date)
        fg.Cols(c).Format = d
        fg.Cols(c).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(c).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(c).Width = 60
    End Sub

    Private Sub forma_entero(ByVal c As Integer)
        fg.Cols(c).DataType = GetType(Integer)
        fg.Cols(c).Format = "##,##0"
        fg.Cols(c).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(c).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(c).Width = 60
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\wip.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub llena_fg()
        Dim cpos As String = ""
        Dim estilo As String = ""
        Dim coloc As String = ""
        Dim dr As DataRow
        Dim i As Integer
        Dim l As Integer
        Dim talla As String
        Dim prendas As Integer
        Dim total As Object
        Dim consumo As Decimal
        Dim consume As Object
        Dim foundrows As DataRow()
        Dim dtr As DataRow
        Dim j As Integer
        Dim knit As String = ""
        Dim colo As String = ""
        Dim libras As Decimal
        Dim fecha As Date
        Dim unidad As Integer
        Dim clinea As Integer
        Dim fdr As DataRow
        strSQl = "SELECT CPO_D.* , CPO.CLIENTE, CPO.F_PEDIDO FROM CPO_D, CPO WHERE CPO_D.CPO = CPO.CPO AND CLIENTE = '" & C4.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.F_ENTREGA,CPO_D.CPO,ESTILO,COLOR"
        llena_tablas(cpo, strSQl, cnn)
        l = cpo.Rows.Count
        l = l * 12
        fg.Rows.Count = l + 2
        l = 2
        c = 0
        For Each dr In cpo.Rows
            cpos = dr("CPO")
            estilos_linea(l, cpos)
            clinea = l
            talla = te(i)
            prendas = dr("TOTAL")
            estilo = dr("ESTILO")
            coloc = dr("COLOR")
            unidad = dr(talla)
            If prendas > 0 Then
                fg(l, 1) = dr("F_PEDIDO")
                fg(l, 2) = cpos
                fg(l, 3) = estilo
                fg(l, 4) = coloc
                fg(l, 5) = ""
                fg(l, 6) = prendas
                fg(l, 41) = dr("F_ENTREGA")
                fg(l, 46) = dr("DESTINO")
                fg(l, 0) = Trim(fg(l, 2)) + Trim(fg(l, 3)) + Trim(fg(l, 4))
                cambia_estilos(l, st(c))
                l = l + 1
            End If
            libras = 0
            consumo = 0
            fecha = Date.MinValue
            foundrows = con.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & coloc & "'")
            For j = 0 To foundrows.GetUpperBound(0)
                dtr = foundrows(j)
                knit = dtr("CODIGO")
                colo = dtr("COLOR_TELA")
                consume = fpo.Compute("SUM(LIBRAS)", "CODIGO = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                total = fpo.Compute("SUM(RECIBIDAS)", "CODIGO = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                Try
                    libras = libras + CDec(total)
                Catch
                End Try
                Try
                    consumo = consumo + CDec(consume)
                Catch
                End Try
                Try
                    total = f_rec.Compute("MAX(FECHA)", "CODIGO = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                    If CDate(total) > fecha Then
                        fecha = CDate(total)
                    End If
                Catch
                End Try
            Next

            fg(clinea, 8) = libras - consumo
            If fecha <> Date.MinValue Then
                fg(clinea, 7) = fecha
            End If
            cambia_estilos(l, st(c))
            foundrows = fpo.Select("CODIGO = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
            If foundrows.Length > 0 Then
                Try
                    fdr = foundrows(0)
                    fg(clinea, 9) = fdr("OFECHA")
                Catch
                End Try
            End If
        Next
        fg.Rows.Count = l
    End Sub

    Private Sub cambia_estilos(ByVal l As Integer, ByVal st As String)
        Dim i As Integer
        For i = 0 To 6
            fg.SetCellStyle(l, i, fg.Styles(st))
        Next
        fg.Rows(l).Style = fg.Styles(st)
    End Sub

    Private Sub estilos_linea(ByRef l As Integer, ByVal ahora As String)
        If l = 2 Then
            antes = ahora
            Exit Sub
        End If
        If antes <> ahora Then
            l = l + 1
            c = c + 1
            antes = ahora
            If c > 1 Then
                c = 0
            End If
        End If
    End Sub


    Private Sub cortes()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim busca As String
        Dim por As Decimal
        Dim ya As Boolean
        strSQl = "SELECT CPO,ESTILO,COLOR,FCORTE,SUM(XS) AS XS ,SUM(S) AS S,SUM(M) AS M ,SUM(L) AS L,SUM(XL) AS XL ,SUM(XL2) AS XL2 ,SUM(XL3) AS XL3 ,SUM(XL4) AS XL4 ,SUM(XL5) AS XL5 ,SUM(XL6) AS XL6,SUM(TOTAL) AS TOTAL  FROM CORTES WHERE CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR,FCORTE ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            ya = False
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            If f > 0 Then
                If Not ya Then
                    fg(f, 11) = dr("FCORTE")
                    ya = True
                End If
                fg(f, 12) = fg(f, 12) + dr("TOTAL")
                If fg(f, 12) > 0 Then
                    Try
                        por = (fg(f, 12) * 100) / fg(f, 6)
                        fg(f, 13) = Format(por, "###0") + "%"
                    Catch
                        fg(f, 13) = "   0%"
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub costura(ByVal c As Integer)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9) AS TOTAL  FROM CORTES_P,CORTES WHERE CORTES_P.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            If f > 0 Then
                total = dr("TOTAL")
                fg(f, c + 2) = total
                If fg(f, c + 2) > 0 Then
                    Try
                        fg(f, c + 3) = fg(f, c + 2) - fg(f, 6)
                        por = (fg(f, c + 2) * 100) / fg(f, 6)
                        fg(f, c + 4) = Format(por, "###0") + "%"
                    Catch
                        fg(f, c + 4) = "   0%"
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub exportacion(ByVal c As Integer)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim pr As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9) AS TOTAL  FROM CORTES_E,CORTES WHERE CORTES_E.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            If f > 0 Then
                fg(f, c + 1) = dr("TOTAL") + pr
                If fg(f, c + 1) > 0 Then
                    Try
                        por = (fg(f, c + 1) * 100) / fg(f, 6)
                        fg(f, c + 3) = Format(por, "###0") + "%"
                        fg(f, c + 2) = fg(f, c + 1) - fg(f, 6)
                    Catch
                        fg(f, c + 3) = "   0%"
                    End Try
                End If
            End If
        Next
        exportacion_stock(c)
    End Sub

    Private Sub llena_exportacion_stock()
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(PRENDAS)AS STOCK FROM S_STOCK WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE CLIENTE = '" & C4.Text & "' AND ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR"
        llena_tablas(es, strSQl, cnn)
    End Sub

    Private Sub exportacion_stock(ByVal c As Integer)
        Dim dr As DataRow
        Dim busca As String
        Dim f As Integer
        Dim por As Decimal
        For Each dr In es.Rows
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            If f > 0 Then
                fg(f, c + 1) = fg(f, c + 1) + dr("STOCK")
                If fg(f, c + 1) > 0 Then
                    Try
                        por = (fg(f, c + 1) * 100) / fg(f, 6)
                        fg(f, c + 3) = Format(por, "###0") + "%"
                        fg(f, c + 2) = fg(f, c + 1) - fg(f, 6)
                    Catch
                        fg(f, c + 3) = "   0%"
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub llena_ruta()
        Dim dr As DataRow
        Dim i As Integer
        Dim si As Boolean
        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE =  '" & C4.Text & "' ORDER BY ESTILO"
        llena_tablas(rut, strSQL, cnn)
        For Each dr In rut.Rows
            For i = 2 To 9
                si = dr(i)
                If si Then
                    ru(i - 1) = 1
                End If
            Next
        Next
        ru(1) = 1
        ru(4) = 1
        ru(8) = 1
    End Sub

    Private Sub llena_consumos()
        strSQl = "SELECT * FROM CONSUMO_TELA WHERE ESTILO_CPO+COLOR_CPO IN (SELECT ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND CLIENTE = '" & C4.Text & "' ORDER BY ESTILO_CPO,COLOR_CPO"
        llena_tablas(con, strSQl, cnn)
    End Sub

    Private Sub controla_procesos()
        Dim i As Integer
        Dim c As Integer = 14
        Dim pr(8) As String
        Dim p(8) As String
        Dim est As Integer = 3
        pr = Split("CERO,CUT,EMBROIDERY,SCREEN PRINTING,SEWING,DYED,WASHED,PACKING,SHIP", ","c)
        p = Split("CERO,Corte,Bordado,Serigrafía,Costura,Teñido,Lavado,Empaque,Exportación", ","c)
        For i = 2 To 8
            If ru(i) > 0 Then
                define_columnas(c, est, pr(i), p(i))

                If i = 4 Then
                    cts = c
                    costura(c)
                    fecha_costura(c + 1)
                    c = c + 1
                ElseIf i = 8 Then
                    fecha_entrega(c + 4)
                    exportacion(c)
                    fecha_export(c)
                    otras_fechas_export(c)
                Else
                    proceso_ad(c, p(i))
                    If i = 3 Then
                        cse = c
                        c = c + 1
                    Else
                        If i = 2 Then
                            cbo = c
                            c = c + 1
                        End If
                    End If
                End If
                c = c + 4
                If est = 3 Then
                    est = 1
                Else
                    est = 3
                End If
            End If
        Next
    End Sub

    Private Sub define_columnas(ByVal c As Integer, ByVal est As Integer, ByVal proceso As String, ByVal proces As String)
        Dim i As Integer
        fg.Cols(c).Visible = True
        fg.Cols(c + 1).Visible = True
        fg.Cols(c + 2).Visible = True
        fg.Cols(c + 3).Visible = True
        forma_fecha(c)
        forma_entero(c + 1)
        forma_entero(c + 2)
        fg.Cols(c + 3).Width = 70
        fg.Cols(c + 3).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(c + 3).TextAlignFixed = TextAlignEnum.RightCenter
        fg(1, c) = "ACTUAL"
        fg(1, c + 1) = "ACT.PCS"
        fg(1, c + 2) = "BALAN."
        fg(1, c + 3) = "% AC-PL"

        Dim rng1 = fg.GetCellRange(0, c, 0, c + 3)
        rng1.Data = proceso
        rng1.Style = fg.Styles("c" + CStr(est))

        rng1 = fg.GetCellRange(1, c, 1, c + 3)
        rng1.Style = fg.Styles("c" + CStr(est + 1))

        If proceso = "SEWING" Or proceso = "SCREEN PRINTING" Or proceso = "EMBROIDERY" Then
            For i = c To c + 4
                fg.Cols(i).Visible = True
            Next
            forma_fecha(c)
            forma_fecha(c + 1)
            forma_entero(c + 2)
            forma_entero(c + 3)
            fg.Cols(c + 4).Width = 70
            fg.Cols(c + 4).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(c + 4).TextAlignFixed = TextAlignEnum.RightCenter
            fg(1, c) = "PLAN"
            fg(1, c + 1) = "ACTUAL"
            fg(1, c + 2) = "ACT.PCS"
            fg(1, c + 3) = "BALAN."
            fg(1, c + 4) = "% AC-PL"

            rng1 = fg.GetCellRange(0, c, 0, c + 4)
            rng1.Data = proceso
            rng1.Style = fg.Styles("c" + CStr(est))

            rng1 = fg.GetCellRange(1, c, 1, c + 4)
            rng1.Style = fg.Styles("c" + CStr(est + 1))
        End If

        If proceso = "SHIP" Then
            fg.Cols(c + 4).Visible = True
            fg.Cols(c + 5).Visible = True
            forma_fecha(c + 4)
            forma_fecha(c + 5)
            fg(1, c + 4) = "ORIGINAL"
            fg(1, c + 5) = "REVISED"

            rng1 = fg.GetCellRange(0, c, 0, c + 5)
            rng1.Data = proceso
            rng1.Style = fg.Styles("c" + CStr(est))

            rng1 = fg.GetCellRange(1, c, 1, c + 5)
            rng1.Style = fg.Styles("c" + CStr(est + 1))
        End If

        For i = c To c + 4
            cl(i) = proces
        Next
    End Sub

    Private Sub proceso_ad(ByVal c As Integer, ByVal proceso As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        Dim pr(8) As String
        Dim fil As Integer
        strSQl = "SELECT CORTES_PAR.CPO,ESTILO,COLOR,FECHA,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9) AS TOTAL  FROM CORTES_PAR,CORTES WHERE CORTES_PAR.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND PROCESO = '" & proceso & "' AND  TIPO = 'Recepcion' AND CORTES_PAR.CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CORTES_PAR.CPO,ESTILO,COLOR,FECHA ORDER BY CORTES_PAR.CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            fil = 0
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            If f > 0 Then
                If dr("TOTAL") > 0 Then
                    If fil = 0 Then
                        fil = f
                    End If
                    fg(fil, c + 1) = dr("FECHA")
                    total = dr("TOTAL")
                    Try
                        fg(f, c + 2) = fg(f, c + 2) + total
                        fg(f, c + 3) = fg(f, c + 2) - fg(f, 6)
                        por = (fg(f, c + 2) * 100) / fg(f, 6)
                        fg(f, c + 4) = Format(por, "###0") + "%"
                    Catch
                        fg(f, c + 4) = "   0%"
                    End Try
                End If
            End If
        Next
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        fg(r, 28) = "X"
    End Sub

    Private Sub fecha_costura(ByVal c As Integer)
        Dim dr As DataRow
        Dim f As Integer
        Dim busca As String
        Dim fecha As Date
        strSQl = "SELECT DISTINCT (CPO+ESTILO+COLOR+PROD_DIARIA.CORTE),CPO,ESTILO,COLOR,PROD_DIARIA.CORTE,FECHA FROM PROD_DIARIA,CORTES WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,ESTILO,COLOR,FECHA DESC"
        llena_tablas(fco, strSQl, cnn)
        For Each dr In fco.Rows
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            fecha = dr("FECHA")
            If f > 0 Then
                If fecha > fg(f, c) Then
                    fg(f, c) = fecha
                End If
            End If
        Next
    End Sub

    Private Sub fecha_export(ByVal c As Integer)
        Dim fco As New DataTable
        Dim dr As DataRow
        Dim f As Integer
        Dim fecha As Date
        Dim busca As String
        strSQl = "SELECT DISTINCT (CPO+ESTILO+COLOR+EMBARQUES.CORTE),CPO,ESTILO,COLOR,EMBARQUES.CORTE,FECHA FROM EMBARQUES,CORTES WHERE EMBARQUES.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,ESTILO,COLOR,FECHA DESC"
        llena_tablas(fco, strSQl, cnn)
        For Each dr In fco.Rows
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            f = fg.FindRow(busca, 1, 0, True)
            fecha = dr("FECHA")
            If f > 0 Then
                If fecha > fg(f, c) Then
                    fg(f, c) = fecha
                End If
            End If
        Next
    End Sub
    Private Sub fecha_entrega(ByVal c)
        Dim i As Integer
        For i = 2 To fg.Rows.Count - 1
            If fg(i, 41) <> CDate("01-01-1900") Then
                fg(i, c) = fg(i, 41)
            End If
        Next
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        If c > 43 Then
            Exit Sub
        End If
        Try
            If Trim(fg(f, 2)) <> "" Then
                If (c > 6 And c < 10) Then
                    detalle_fpo(f)
                ElseIf (c > 9 And c < 14) Then
                    detalle_por_cortar(f)
                ElseIf cl(c) = "Costura" Then
                    detalle_costura(f)
                ElseIf cl(c) = "Exportación" Then
                    detalle_exportac(f)
                ElseIf c > 12 Then
                    detalle_procesos(f, c)
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub detalle_fpo(ByVal f As Integer)
        Dim forma As New Fpo_consul4()
        Dim consumo() As DataRow
        Dim dtr As DataRow
        Dim knit As String
        Dim colo As String
        Dim var As String = "("
        Dim j As Integer
        consumo = con.Select("ESTILO_CPO = '" & fg(f, 3) & "' AND COLOR_CPO = '" & fg(f, 4) & "'")
        For j = 0 To consumo.GetUpperBound(0)
            dtr = consumo(j)
            knit = dtr("CODIGO")
            colo = dtr("COLOR_TELA")
            var = var + "'" + fg(f, 2) + knit + colo + fg(f, 3) + "',"
        Next
        j = var.Length
        var = Mid(var, 1, j - 1) + ")"
        forma.strsql = "Select * FROM FPO WHERE CPO+CODIGO+COLOR+ESTILO IN " & var & " AND TIPO = 'TELA' ORDER BY FPO,COLOR,KNIT "
        forma.ShowDialog()
    End Sub

    Private Sub detalle_por_cortar(ByVal f As Integer)
        Dim forma As New Prendas_x_cortar()
        forma.Cpo.Text = fg(f, 2)
        forma.Estilo.Text = fg(f, 3)
        forma.Colo.Text = fg(f, 4)
        forma.ShowDialog()
    End Sub


    Private Sub detalle_costura(ByVal f As Integer)
        Dim forma As New Prendas_costura()
        forma.Cpo.Text = fg(f, 2)
        forma.Estilo.Text = fg(f, 3)
        forma.Colo.Text = fg(f, 4)
        forma.ShowDialog()
    End Sub

    Private Sub detalle_exportac(ByVal f As Integer)
        Dim forma As New Prendas_exportac()
        forma.Cpo.Text = fg(f, 2)
        forma.Estilo.Text = fg(f, 3)
        forma.Colo.Text = fg(f, 4)
        forma.ShowDialog()
    End Sub

    Private Sub detalle_procesos(ByVal f As Integer, ByVal c As Integer)
        Dim forma As New Prendas_proc_ad()
        forma.Text = "Prendas en proceso de " + cl(c)
        forma.Cpo.Text = fg(f, 2)
        forma.Estilo.Text = fg(f, 3)
        forma.Colo.Text = fg(f, 4)
        forma.Proceso.Text = cl(c)
        forma.ShowDialog()
    End Sub

    Private Sub llena_programas()
        Dim foundrows As DataRow()
        Dim dt As DataRow
        Dim i As Integer
        For i = 2 To fg.Rows.Count - 1
            foundrows = rut.Select("ESTILO = '" & fg(i, 3) & "'")
            Try
                dt = foundrows(0)
                fg(i, 45) = dt("PROGRAMA")
            Catch
            End Try
        Next
    End Sub

    Private Sub otras_fechas_export(ByVal c As Integer)
        Dim dr As DataRow
        Dim i As Integer
        Dim busca As String
        Dim f As String = "dd MMM yy"
        Dim fecha As Date
        strSQl = "SELECT * FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR"))
            i = fg.FindRow(busca, 2, 0, True)
            If i > 1 Then
                Try
                    fecha = dr("CUT_PLAN")
                    If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                        If fecha > fg(i, 10) Then
                            fg(i, 10) = fecha
                        End If
                    End If
                Catch
                End Try
                fecha = dr("EXP_REV")
                If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                    If fecha > fg(i, c + 5) Then
                        fg(i, c + 5) = fecha
                    End If
                End If
                Try
                    fecha = dr("EX_CHAR")
                    If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                        If fecha > fg(i, 44) Then
                            fg(i, 44) = fecha
                        End If
                    End If
                Catch
                End Try
                Try
                    fecha = dr("SEW_PLAN")
                    If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                        If fecha > fg(i, cts) Then
                            fg(i, cts) = fecha
                        End If
                    Else
                        If fg(i, cts + 1) <> Nothing And fg(i, cts + 1) <> CDate("01-01-1900") Then
                            fg(i, cts) = fg(i, cts + 1)
                        End If
                    End If
                Catch
                End Try
                Try
                    fecha = dr("SER_PLAN")
                    If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                        If fecha > fg(i, cse) Then
                            fg(i, cse) = fecha
                        End If
                    End If
                Catch
                End Try
                Try
                    fecha = dr("BOR_PLAN")
                    If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                        If fecha > fg(i, cbo) Then
                            fg(i, cbo) = fecha
                        End If
                    End If
                Catch
                End Try
            End If
        Next
    End Sub
    Private Sub tipos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tipos.SelectedIndexChanged
        Dim i As Integer
        If tipos.SelectedIndex = 0 Then
            cpos.Text = ""
            cpos.Enabled = False
            cpos.Visible = False
            fg.ScrollBars = ScrollBars.None
            For i = 2 To fg.Rows.Count - 1
                fg.Rows(i).Visible = True
            Next
            fg.ScrollBars = ScrollBars.Both
        Else
            nada()
            cpos.Visible = True
            cpos.Enabled = True
            cpos.Focus()
        End If
    End Sub

    Private Sub nada()
        Dim i As Integer
        fg.ScrollBars = ScrollBars.None
        For i = 2 To fg.Rows.Count - 1
            fg.Rows(i).Visible = False
        Next
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Wip", PrintGridFlags.ShowPreviewDialog, "Wip " + Trim(C4.Text) + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub
    Private Sub cpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpos.KeyPress
        AutoCompletar(cpos, e)
    End Sub

    Private Sub llena_cpos()
        llena_combos(cpos, "SELECT DISTINCT CPO.CPO FROM CPO LEFT JOIN CPO_D ON CPO.CPO = CPO_D.CPO WHERE CLIENTE = '" & C4.Text & "' AND ESTADO = 'A' ORDER BY CPO.CPO", "CPO")
        Try
            cpos.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub cpos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpos.SelectedIndexChanged
        Dim i As Integer
        Dim J As Integer
        i = fg.FindRow(cpos.Text, 2, 2, True)
        If i > 0 Then
            fg.ScrollBars = ScrollBars.None
            For J = 2 To fg.Rows.Count - 1
                If fg(J, 2) <> cpos.Text Then
                    fg.Rows(J).Visible = False
                Else
                    fg.Rows(J).Visible = True
                End If
            Next
            fg.ScrollBars = ScrollBars.Both
        End If
    End Sub
End Class

