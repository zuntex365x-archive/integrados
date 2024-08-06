Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class Fpo_cat01
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cat As New DataTable()
    Dim dr As DataRow
    Dim strSQl As String
    Dim cato As String
    Dim categoria As String
    Dim busca As String
    Dim t(21) As Integer
    Dim hoy As Date = Today
    Dim finicio As Date
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpo_cat01))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 40)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(1008, 640)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(960, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 78
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(920, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 77
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(888, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 36)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Procesar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Fpo_cat01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 696)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fpo_cat01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan de Entregas de Tela por Categoría"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Serigra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dia As Date = Today
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        dia = dia.AddDays(-15)
        llena_tablas(cat, "SELECT * FROM TELA_CATEGORIA_S WHERE FECHA > '" & Format(dia, "yyyy-MM-dd") & "' ORDER BY CATEGORIA", cnn)
        setea_fg()
    End Sub

    Private Sub setea_fg()
        Dim i As Integer
        Dim d As Integer
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Rows(0).Height = 40
        d = hoy.DayOfWeek
        d = (d * -1)
        hoy = hoy.AddDays(d)
        fg(0, 4) = Format(hoy, "dd-MMM-yyyy")
        finicio = hoy
        For i = 5 To 21
            hoy = hoy.AddDays(7)
            fg(0, i) = Format(hoy, "dd MMM yyyy")
            If i = 21 Then
                fg(0, 21) = fg(0, 21) + " < "
            End If
        Next

    End Sub

    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim fpo As String = ""
        Dim colo As String = ""
        Dim dom As Date
        Dim d As Integer
        Dim ofecha As Date
        Dim libras As Integer
        Dim res As Decimal
        Dim strSQL As String = "SELECT CLIENTE,FPO,COLOR,CATEGORIA,OFECHA,SUM(LIBRAS) AS LIBRAS  FROM FPO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO' AND TIPO = 'TELA' GROUP BY CLIENTE,FPO,COLOR,CATEGORIA,OFECHA ORDER BY CATEGORIA,CLIENTE,FPO,COLOR,OFECHA"
        'SELECT FPO,COLOR,CATEGORIA,OFECHA,SUM(LIBRAS) AS LIBRAS  FROM FPO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO' AND TIPO = 'TELA' GROUP BY FPO,COLOR,CATEGORIA,OFECHA ORDER BY CATEGORIA,FPO,COLOR,OFECHA"
        llena_tablas(dt, strSQL, cnn)
        dom = finicio
        For Each Me.dr In dt.Rows
            Try
                categoria = dr("CATEGORIA")
            Catch
                categoria = ""
            End Try
            If cato <> categoria Then
                totales_cat()
                cato = categoria
                ReDim t(21)
            End If
            fpo = dr("FPO")
            colo = dr("COLOR")
            Try
                categoria = dr("CATEGORIA")
            Catch
                categoria = ""
            End Try
            busca = categoria + fpo + colo
            l = fg.FindRow(busca, 1, 0, False)
            If l = -1 Then
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                fg(l, 0) = busca
                fg(l, 1) = categoria
                fg(l, 2) = fpo
                fg(l, 3) = colo
                fg(l, 22) = dr("CLIENTE")
            End If
            ofecha = dr("OFECHA")
            libras = dr("LIBRAS")
            d = DateDiff(DateInterval.Day, dom, ofecha)
            res = (d / 7)
            If d > 0 Then
                d = Fix(d / 7)
                res = res - d
                If res > 0 Then
                    d = d + 1
                End If
            Else
                d = 0
            End If
            If d > 16 Then
                d = 16
            End If
            fg(l, d + 4) = fg(l, d + 4) + libras
            t(d + 4) = t(d + 4) + libras
        Next
        totales_cat()
    End Sub

    Private Sub totales_cat()
        Dim dd As DataRow()
        Dim dg As DataRow
        Dim fec As Date
        Dim i As Integer
        Dim l As Integer
        Dim cuota
        If cato = "" Then
            Exit Sub
        End If
        l = fg.Rows.Count
        fg.Rows.Count = l + 3
        fg.Rows(l).Style = fg.Styles("TOTALES")
        fg.Rows(l + 1).Style = fg.Styles("TOTALES")
        fg.Rows(l + 2).Style = fg.Styles("TOTALES")
        fg(l + 1, 1) = cato
        fg(l, 3) = "CUOTA SEMANAL"
        fg(l + 1, 3) = "TELA OFRECIDA"
        fg(l + 2, 3) = "DIFERENCIA"
        fec = finicio
        fec = fec.AddDays(-6)
        For i = 4 To 21
            fec = fec.AddDays(7)
            cuota = 0
            dd = cat.Select("CATEGORIA = '" & cato & "' AND FECHA = '" & Format(fec, "yyyy-MM-dd") & "'")
            If dd.Length > 0 Then
                dg = dd(0)
                cuota = dg("LIBRAS")
            End If
            fg(l, i) = cuota
            fg(l + 1, i) = t(i)
            fg(l + 2, i) = fg(l, i) - fg(l + 1, i)
        Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyyy")
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
        fg.PrintGrid("inventario", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Plan de Entregas por categoria al : " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub datos_excel(ByRef si As Boolean)
        Dim path As String = "c:\reportes\Entregas_categoria.xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.Subtotal(AggregateEnum.Clear)
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            si = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/  bajo el nombre de Entregas_categoria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fg.ScrollBars = ScrollBars.None
        llena_fg()
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        fg.ScrollBars = ScrollBars.Both
    End Sub
End Class




