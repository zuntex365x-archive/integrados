Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cpo_performance
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dx As New DataTable()
    Dim dr As DataRow
    Dim dd As DataRow()
    Dim lineas As Integer
    Dim path As String = "c:\reportes\Cpo_performance.xls"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cpo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Cpo_performance))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Bitmap)
        Me.R1.Location = New System.Drawing.Point(408, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Bitmap)
        Me.S1.Location = New System.Drawing.Point(368, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        '
        'C4
        '
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(88, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(488, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 60
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Button3.Visible = False
        '
        'cpo
        '
        Me.cpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Items.AddRange(New Object() {"TODOS", "ABIERTOS", "CERRADOS", "CANCELADOS"})
        Me.cpo.Location = New System.Drawing.Point(88, 32)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(240, 24)
        Me.cpo.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.cpo, "Elija el Estado  a Consultar .")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:128;Name:""CPO"";Caption:""CPO"";AllowDragging:False;AllowEditing:False;Data" & _
        "Type:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:141;" & _
        "Name:""ESTILO"";Caption:""ESTILO"";AllowDragging:False;AllowEditing:False;DataType:S" & _
        "ystem.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:179;Name:""" & _
        "COLOR"";Caption:""COLOR"";AllowDragging:False;AllowEditing:False;DataType:System.St" & _
        "ring;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:101;Name:""CLIENTE""" & _
        ";Caption:""CLIENTE"";AllowDragging:False;AllowMerging:True;AllowEditing:False;Data" & _
        "Type:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:80;N" & _
        "ame:""P.REQ"";Caption:""P.REQ"";AllowDragging:False;AllowEditing:False;DataType:Syst" & _
        "em.Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{" & _
        "Width:80;Caption:""P.EXP"";AllowDragging:False;AllowEditing:False;DataType:System." & _
        "Decimal;Format:""##,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Wid" & _
        "th:100;Caption:""F.CPO"";AllowDragging:False;AllowEditing:False;DataType:System.Da" & _
        "teTime;Format:""dd-MMM-yyyy"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "8{Width:100;Caption:""F.EXPORT."";AllowDragging:False;AllowEditing:False;DataType" & _
        ":System.DateTime;Format:""dd-MMM-yyyy"";TextAlign:CenterCenter;TextAlignFixed:Cent" & _
        "erCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:60;Caption:""DIF.DIAS"";AllowDragging:False;AllowEditing:False;" & _
        "DataType:System.Decimal;Format:""###0"";TextAlign:CenterCenter;TextAlignFixed:Cent" & _
        "erCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 64)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 616)
        Me.fg.StyleInfo = "Normal{Font:Courier New, 9pt;BackColor:White;ForeColor:Black;TextAlign:LeftCenter" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:AntiqueWhite;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:231, 154, 84;ForeColor:Bla" & _
        "ck;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{Bac" & _
        "kColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDa" & _
        "rkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{Font:Microsoft Sans Serif, 9pt, style=Bold;BackColor:Bl" & _
        "ack;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 9pt, style=Bold;BackC" & _
        "olor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 11.25pt, style" & _
        "=Bold;BackColor:186, 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{Ba" & _
        "ckColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;Fo" & _
        "reColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{" & _
        "BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(448, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 64
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.Visible = False
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Cpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Cpo_performance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.fg, Me.cpo, Me.Label2, Me.Button3, Me.C4, Me.R1, Me.S1, Me.Label6})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cpo_performance"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Performance por CPO"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO ORDER BY CLIENTE", "CLIENTE")
        setea_fg()
        C4.SelectedIndex = 0
        C4.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        S1.Visible = False
        R1.Visible = True
        deshabilita()
        Cursor = Cursors.WaitCursor
        llena_fg()
        fg.ScrollBars = ScrollBars.Both
        Cursor = Cursors.Default
        R1.Focus()
    End Sub

    Private Sub deshabilita()
        C4.Enabled = False
        cpo.Enabled = False
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        C4.Enabled = True
        CPO.Enabled = True
        S1.Visible = True
        R1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        setea_fg()
        C4.Focus()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim l As Integer
        Dim cpos As String
        Dim estilo As String
        Dim colo As String
        Dim dias As Integer
        Dim dj As DataRow
        Dim fen As Date
        llena_tablas(dt, "SELECT CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR,CLIENTE,TOTAL,CPO_D.F_ENTREGA,EXP_REV FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN WIP0 ON CPO_D.CPO = WIP0.CPO AND CPO_D.ESTILO = WIP0.ESTILO AND CPO_D.COLOR = WIP0.COLOR AND TALLA = 'TOTAL' WHERE CLIENTE = '" & C4.Text & "' AND CPO_D.CPO = '" & cpo.Text & "' ORDER BY CPO_D.CPO", cnn)
        L = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            cpos = dr("CPO")
            colo = dr("COLOR")
            estilo = dr("ESTILO")
            fg(l, 1) = cpos
            fg(l, 2) = estilo
            fg(l, 3) = colo
            fg(l, 4) = dr("CLIENTE")
            fg(l, 6) = 0
            fg(l, 5) = dr("TOTAL")
            Try
                fg(l, 7) = dr("F_ENTREGA")
            Catch
            End Try
            dd = dx.Select("CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                fg(l, 6) = dj("EXPORTADO")
                fg(l, 8) = dj("FECHA")
            End If
            Try
                fen = fg(l, 8)
                If fen > CDate("2000-01-01") Then
                    dias = DateDiff(DateInterval.Day, fg(l, 7), fg(l, 8))
                    fg(l, 9) = dias
                Else
                    If fg(l, 7) < Today Then
                        dias = DateDiff(DateInterval.Day, fg(l, 7), Today)
                        fg(l, 9) = dias
                    End If
                End If
            Catch
            End Try
            l = l + 1
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Try
            Dim ch As Char = Microsoft.VisualBasic.Chr(9)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            ok = False
        End Try
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim empresa As String
        Dim obj As empresas
        obj = New empresas()
        empresa = obj.nombre
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog + PrintGridFlags.ShowPreviewDialog, empresa + "   Reporte de Cpos al : " + fecha + "    " + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub C4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.SelectedIndexChanged
        llena_cpos()
    End Sub

    Private Sub llena_cpos()
        llena_combos(cpo, "SELECT DISTINCT CPO FROM CPO WHERE CLIENTE = '" & C4.Text & "'", "CPO")
        llena_tablas(dx, "SELECT CPO,ESTILO,COLOR,CLIENTE,SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) AS EXPORTADO, FECHA  FROM PACKING_D WHERE CLIENTE = '" & C4.Text & "' AND TIPO = 'Pri' GROUP BY CPO,ESTILO,COLOR ,CLIENTE,FECHA ORDER BY CPO,ESTILO,COLOR,FECHA ", cnn)
    End Sub

End Class



