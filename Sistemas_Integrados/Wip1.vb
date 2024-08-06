Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO
Imports C1.C1Excel
Public Class Wip1
    Inherits System.Windows.Forms.Form
    Dim h As String = "##,##0"
    Dim d As String = "dd MMM yy"
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cpo As New DataTable()
    Dim con As New DataTable()
    Dim fpo As New DataTable()
    Dim fco As New DataTable()
    Dim es As New DataTable()
    Dim f_rec As New DataTable()
    Dim tal As New DataTable
    Dim strSQl As String
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Dim tv(9) As String
    Dim da(9) As Integer
    Dim ru(8) As String
    Dim st(3) As String
    Dim cl(42) As String
    Dim td(10, 12) As String
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wip1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(824, 3)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(758, 3)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(60, 40)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(88, 8)
        Me.C4.MaxDropDownItems = 12
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(890, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 60
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Rows.Fixed = 2
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 636)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
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
        Me.Label1.Location = New System.Drawing.Point(678, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 42)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Un Momento por favor.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Me encuentro Procesando"
        Me.Label1.Visible = False
        '
        'Wip1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wip1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Production Tracking Report"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 20
        fg.Height = Me.Height - 100
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        tv = Split("XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL,TOTAL", ","c)
        st = Split("rojo,amarillo,verde", ","c)
        def_sql(cnn)
        llena_tallas()
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO, CPO_D WHERE CPO.CPO = CPO_D.CPO AND ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
        Try
            C4.SelectedIndex = 0
        Catch
        End Try
        C4.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        Label1.Visible = True
        Label1.Refresh()
        Cursor = Cursors.WaitCursor
        S1.Visible = False
        R1.Visible = True
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
        Button3.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        otro_cliente()
    End Sub

    Private Sub procesa()
        llena_ruta()
        llena_consumos()
        llena_exportacion_stock()
        llena_fpos_rec(C4.Text, fpo, f_rec)
        llena_fg()
        cortes()
        controla_procesos()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 2
        fg.Rows.Fixed = 2
        fg.Cols.Fixed = 7
        fg.Cols.Count = 43
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
        fg.Cols(9).Name = "ACTUAL"
        fg.Cols(10).Name = "ACT.PCS"
        fg.Cols(11).Name = "% AC-PL"
        fg.Cols(42).Name = "DESTINATION"
        fg.Cols(28).Visible = False
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 70
            fg(1, index) = fg.Cols(index).Name
            fg.Cols(index).AllowEditing = False
            If index < 6 Then
                fg.Cols(index).AllowMerging = True
            End If
            If index > 11 Then
                fg.Cols(index).Visible = False
            End If
        Next
        forma_fecha(1)
        forma_entero(6)
        forma_fecha(7)
        forma_entero(8)
        forma_fecha(9)
        forma_entero(10)
        fg.Cols(2).Width = 105
        fg.Cols(4).Width = 150
        fg.Cols(5).Width = 50
        fg.Cols(11).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(11).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(15).Width = 50
        fg.Cols(15).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(20).Width = 50
        fg.Cols(20).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(23).Width = 50
        fg.Cols(23).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(27).Width = 250
        fg.Cols(9).AllowMerging = True
        fg.Cols(27).AllowMerging = True
        fg.Cols(42).Visible = True
        fg.Cols(42).Width = 120

        Dim rng1 = fg.GetCellRange(0, 1, 0, 6)
        rng1.Data = "PO INFORMATION"
        rng1.Style = fg.Styles("c1")
        fg.Rows(0).AllowMerging = True

        rng1 = fg.GetCellRange(1, 1, 1, 6)
        rng1.Style = fg.Styles("c2")

        rng1 = fg.GetCellRange(0, 7, 0, 8)
        rng1.Data = "FABRIC RECEIVED"
        rng1.Style = fg.Styles("c3")

        rng1 = fg.GetCellRange(1, 7, 1, 8)
        rng1.Style = fg.Styles("c4")

        rng1 = fg.GetCellRange(0, 9, 0, 11)
        rng1.Data = "START CUT"
        rng1.Style = fg.Styles("c1")
        fg.Rows(0).AllowMerging = True

        rng1 = fg.GetCellRange(1, 9, 1, 11)
        rng1.Style = fg.Styles("c2")

        ru = Split("0,0,0,0,0,0,0,0,0", ","c)
    End Sub

    Private Sub forma_fecha(ByVal c As Integer)
        fg.Cols(c).DataType = GetType(Date)
        fg.Cols(c).Format = d
        fg.Cols(c).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(c).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(c).Width = 70
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
        Dim c As Integer
        Dim talla As String
        Dim prendas As Integer
        Dim total As Object = ""
        Dim consumo As Decimal
        Dim consume As Decimal
        Dim foundrows As DataRow()
        Dim dtr As DataRow
        Dim j As Integer
        Dim knit As String = ""
        Dim colo As String = ""
        Dim libras As Decimal
        Dim fecha As Date
        Dim unidad As Integer
        Dim clinea As Integer
        strSQl = "SELECT CPO_D.* , CPO.CLIENTE, CPO.F_PEDIDO , E_TALLAS.* FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CPO_D.CPO = CPO.CPO AND CLIENTE = '" & C4.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.F_ENTREGA,CPO_D.CPO,ESTILO,COLOR"
        'SELECT CPO_D.* , CPO.CLIENTE, CPO.F_PEDIDO FROM CPO_D, CPO WHERE CPO_D.CPO = CPO.CPO AND CLIENTE = '" & C4.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.F_ENTREGA,CPO_D.CPO,ESTILO,COLOR"
        llena_tablas(cpo, strSQl, cnn)
        l = cpo.Rows.Count
        l = l * 12
        fg.Rows.Count = l + 2
        l = 2
        c = 0
        For Each dr In cpo.Rows
            clinea = l
            For i = 0 To 10
                talla = te(i)
                prendas = dr("TOTAL")
                cpos = dr("CPO")
                estilo = dr("ESTILO")
                coloc = dr("COLOR")
                unidad = dr(talla)
                If unidad > 0 Then
                    fg(l, 1) = dr("F_PEDIDO")
                    fg(l, 2) = cpos
                    fg(l, 3) = estilo
                    fg(l, 4) = coloc
                    If i = 10 Then
                        fg(l, 5) = "TOTAL"
                    Else
                        fg(l, 5) = dr(i + 28)
                    End If

                    fg(l, 6) = unidad
                    fg(l, 42) = dr("DESTINO")
                    fg(l, 0) = Trim(fg(l, 2)) + Trim(fg(l, 3)) + Trim(fg(l, 4)) + Trim(fg(l, 5))
                    cambia_estilos(l, st(c))
                    l = l + 1
                End If
            Next
            libras = 0
            consumo = 0
            fecha = Date.MinValue
            foundrows = con.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & coloc & "'")

            For j = 0 To foundrows.GetUpperBound(0)
                dtr = foundrows(j)
                knit = dtr("CODIGO")
                colo = dtr("COLOR_TELA")
                Try
                    consume = fpo.Compute("SUM(LIBRAS)", "CODIGO = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                    total = fpo.Compute("SUM(RECIBIDAS)", "CODIGO = '" & knit & "' AND COLOR = '" & colo & "' AND CPO = '" & cpos & "'")
                Catch
                End Try
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
            l = l + 1
            c = c + 1
            If c > 1 Then
                c = 0
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

    Private Sub cortes()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim ya As Boolean
        strSQl = "SELECT CPO,ESTILO,COLOR,FCORTE,SUM(XS) AS XS ,SUM(S) AS S,SUM(M) AS M ,SUM(L) AS L,SUM(XL) AS XL ,SUM(XL2) AS XL2 ,SUM(XL3) AS XL3 ,SUM(XL4) AS XL4 ,SUM(XL5) AS XL5 ,SUM(XL6) AS XL6,SUM(TOTAL) AS TOTAL, (SELECT ESCALA FROM CPO_D WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS ESCALA FROM CORTES WHERE CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR,FCORTE ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            ya = False
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, 9) = dr("FCORTE")
                    fg(f, 10) = fg(f, 10) + dr(te(i))
                    If fg(f, 10) > 0 Then
                        Try
                            por = (fg(f, 10) * 100) / fg(f, 6)
                            fg(f, 11) = Format(por, "###0") + "%"
                        Catch
                            fg(f, 11) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub costura(ByVal c As Integer)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(TOTAL) AS TOTAL, (SELECT ESCALA FROM CPO_D WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS ESCALA  FROM CORTES_P,CORTES WHERE CORTES_P.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, c + 1) = dr(te(i))
                    If fg(f, c + 1) > 0 Then
                        Try
                            If i < 10 Then
                                total = total + fg(f, c + 1)
                            Else
                                fg(f, c + 1) = total
                            End If
                            fg(f, c + 2) = fg(f, c + 1) - fg(f, 6)
                            por = (fg(f, c + 1) * 100) / fg(f, 6)
                            fg(f, c + 3) = Format(por, "###0") + "%"
                        Catch
                            fg(f, c + 3) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub exportacion(ByVal c As Integer)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        Dim pr As Integer
        strSQl = "SELECT CPO,ESTILO,COLOR,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(TOTAL) AS TOTAL, (SELECT ESCALA FROM CPO_D WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS ESCALA FROM CORTES_E,CORTES WHERE CORTES_E.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, c + 1) = dr(te(i)) + pr
                    If fg(f, c + 1) > 0 Then
                        Try
                            If i < 10 Then
                                total = total + fg(f, c + 1)
                            Else
                                fg(f, c + 1) = total
                            End If
                            por = (fg(f, c + 1) * 100) / fg(f, 6)
                            fg(f, c + 3) = Format(por, "###0") + "%"
                            fg(f, c + 2) = fg(f, c + 1) - fg(f, 6)
                        Catch
                            fg(f, c + 3) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
        exportacion_stock(c)
    End Sub

    Private Sub llena_exportacion_stock()
        strSQl = "SELECT CPO,ESTILO,COLOR,TALLA,FECHA,SUM(PRENDAS)AS STOCK FROM S_STOCK WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE CLIENTE = '" & C4.Text & "' AND ESTADO = 'A') GROUP BY CPO,ESTILO,COLOR,TALLA,FECHA"
        llena_tablas(es, strSQl, cnn)
    End Sub


    Private Sub exportacion_stock(ByVal c As Integer)
        Dim dr As DataRow
        Dim busca As String = ""
        Dim f As Integer
        Dim por As Decimal
        Dim i As Integer
        Dim talla As String
        For Each dr In es.Rows
            talla = dr("TALLA")
            i = Array.IndexOf(tv, Trim(dr("TALLA")))
            If i > 0 Then
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + tv(i)
            End If
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
                    fg(f, c) = dr("FECHA")
                End If
            End If
            'TOTALES ====================
            busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + "TOTAL"
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
                    fg(f, c) = dr("FECHA")
                End If
            End If
        Next
    End Sub

    Private Sub llena_ruta()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim si As Boolean
        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE =  '" & C4.Text & "' ORDER BY ESTILO"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
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
        Dim c As Integer = 12
        Dim pr(8) As String
        Dim p(8) As String
        Dim est As Integer = 3
        pr = Split("CERO,CUT,EMBROIDERY,SCREEN PRINTING,SEWING,DYED,WASHED,PACKING,SHIP", ","c)
        p = Split("CERO,Corte,Bordado,Serigrafía,Costura,Teñido,Lavado,Empaque,Exportación", ","c)
        For i = 2 To 8
            If ru(i) > 0 Then
                define_columnas(c, est, pr(i), p(i))
                If i = 4 Then
                    costura(c)
                    fecha_costura(c)
                ElseIf i = 8 Then
                    exportacion(c)
                    fecha_export(c)
                    otras_fechas_export(c)
                    fecha_original(c)
                Else
                    proceso_ad(c, p(i))
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
        For i = c To c + 4
            cl(i) = proces
        Next

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
    End Sub

    Private Sub proceso_ad(ByVal c As Integer, ByVal proceso As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim f As Integer
        Dim i As Integer
        Dim busca As String
        Dim por As Decimal
        Dim total As Integer
        Dim pr(8) As String
        Dim fil As Integer
        strSQl = "SELECT CORTES_PAR.CPO,ESTILO,COLOR,FECHA,SUM(P0) AS XS ,SUM(P1) AS S,SUM(P2) AS M ,SUM(P3) AS L,SUM(P4) AS XL ,SUM(P5) AS XL2 ,SUM(P6) AS XL3 ,SUM(P7) AS XL4 ,SUM(P8) AS XL5 ,SUM(P9) AS XL6,SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9) AS TOTAL , (SELECT ESCALA FROM CPO_D WHERE CORTES_PAR.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS ESCALA FROM CORTES_PAR,CORTES WHERE CORTES_PAR.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND PROCESO = '" & proceso & "' AND  TIPO = 'Recepcion' AND CORTES_PAR.CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') GROUP BY CORTES_PAR.CPO,ESTILO,COLOR,FECHA ORDER BY CORTES_PAR.CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            total = 0
            fil = 0
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    If dr(te(i)) > 0 Then
                        If fil = 0 Then
                            fil = f
                        End If
                        fg(fil, c) = dr("FECHA")
                        fg(f, c + 1) = fg(f, c + 1) + dr(te(i))
                        Try
                            If i < 10 Then
                                total = total + fg(f, c + 1)
                            Else
                                fg(f, c + 1) = total
                            End If
                            fg(f, c + 2) = fg(f, c + 1) - fg(f, 6)
                            por = (fg(f, c + 1) * 100) / fg(f, 6)
                            fg(f, c + 3) = Format(por, "###0") + "%"
                        Catch
                            fg(f, c + 3) = "   0%"
                        End Try
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        fg(r, 28) = "X"
    End Sub

    Private Sub fecha_costura(ByVal c As Integer)
        Dim dr As DataRow
        Dim i As Integer
        Dim f As Integer
        Dim busca As String
        strSQl = "SELECT DISTINCT (CPO+ESTILO+COLOR+PROD_DIARIA.CORTE),CPO,ESTILO,COLOR,PROD_DIARIA.CORTE,FECHA , (SELECT ESCALA FROM CPO_D WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS ESCALA FROM PROD_DIARIA,CORTES WHERE PROD_DIARIA.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(fco, strSQl, cnn)
        For Each dr In fco.Rows
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, c) = dr("FECHA")
                End If
            Next
        Next
        fg.Cols(c).AllowMerging = True
    End Sub

    Private Sub fecha_export(ByVal c As Integer)
        Dim fco As New DataTable
        Dim dr As DataRow
        Dim i As Integer
        Dim f As Integer
        Dim busca As String
        strSQl = "SELECT DISTINCT (CPO+ESTILO+COLOR+EMBARQUES.CORTE),CPO,ESTILO,COLOR,EMBARQUES.CORTE,FECHA , (SELECT ESCALA FROM CPO_D WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR) AS ESCALA  FROM EMBARQUES,CORTES WHERE EMBARQUES.CORTE = CORTES.CORTE AND CLIENTE = '" & C4.Text & "' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(fco, strSQl, cnn)
        For Each dr In fco.Rows
            For i = 0 To 10
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), i)
                f = fg.FindRow(busca, 1, 0, True)
                If f > 0 Then
                    fg(f, c) = dr("FECHA")
                End If
            Next
        Next
        fg.Cols(c).AllowMerging = True
    End Sub


    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        Try
            If Trim(fg(f, 2)) <> "" Then
                If (c > 6 And c < 9) Then
                    detalle_fpo(f)
                ElseIf (c > 8 And c < 12) Then
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
            knit = dtr("KNIT_TELA")
            colo = dtr("COLOR_TELA")
            var = var + "'" + fg(f, 2) + knit + colo + fg(f, 3) + "',"
        Next
        j = var.Length
        var = Mid(var, 1, j - 1) + ")"
        forma.strsql = "Select * FROM FPO WHERE CPO+KNIT+COLOR+ESTILO IN " & var & " AND TIPO = 'TELA' ORDER BY FPO,COLOR,KNIT "
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

    Private Sub otras_fechas_export(ByVal c As Integer)
        Dim dr As DataRow
        Dim i As Integer
        Dim busca As String
        Dim f As String = "dd MMM yy"
        Dim fecha As Date
        Dim l As Integer
        strSQl = "SELECT * , (SELECT ESCALA FROM CPO_D WHERE WIP0.CPO = CPO_D.CPO AND WIP0.ESTILO = CPO_D.ESTILO AND WIP0.COLOR = CPO_D.COLOR) AS ESCALA FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(dt, strSQl, cnn)
        For Each dr In dt.Rows
            For l = 0 To 9
                busca = Trim(dr("CPO")) + Trim(dr("ESTILO")) + Trim(dr("COLOR")) + td(dr("ESCALA"), l)
                i = fg.FindRow(busca, 1, 0, True)
                If i > 1 Then
                    fecha = dr("EXP_REV")
                    If fecha <> Nothing And fecha <> CDate("01-01-1900") Then
                        If fecha > fg(i, c + 5) Then
                            fg(i, c + 5) = fecha
                        End If
                    End If
                End If
            Next l
        Next
    End Sub

    Private Sub fecha_original(ByVal c)
        Dim i As Integer
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim cpos As String
        Dim estilo As String
        Dim colo As String
        Dim t As Integer = cpo.Rows.Count
        For i = 1 To fg.Rows.Count - 1
            cpos = fg(i, 2)
            estilo = fg(i, 3)
            colo = fg(i, 4)
            dd = cpo.Select("CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                fg(i, c + 4) = dr("F_ENTREGA")
            End If
        Next
    End Sub

   
    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub

    Private Sub llena_tallas()
        Dim i As Integer
        Dim l As Integer
        tal = New DataTable
        Dim dr As DataRow
        llena_tablas(tal, "SELECT T1,T2,T3,T4,T5,T6,T7,T8,T9,T0 FROM E_TALLAS", cnn)
        l = tal.Rows.Count
        ReDim td(l, 12)
        l = 0
        For Each dr In tal.Rows
            For i = 0 To 9
                td(l, i) = dr(i)
            Next
            td(l, 10) = "TOTAL"
            l = l + 1
        Next
    End Sub

End Class



