Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports C1.C1Excel
Imports C1.Win.C1FlexGrid

Public Class Lista_empaque_4
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strSQl As String
    Dim dr As DataRow
    Dim dw As DataRow
    Dim dp As New DataTable()
    Dim cp As New DataTable()
    Dim ex As New DataTable()
    Dim batch As String
    Dim fpo As String
    Dim _styles As New Hashtable()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Hoja As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents pdf As C1.C1Pdf.C1PdfDocument
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    Friend WithEvents Embarque As System.Windows.Forms.TextBox
    Friend WithEvents su As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_4))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Hoja = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me._book = New C1.C1Excel.C1XLBook()
        Me.Embarque = New System.Windows.Forms.TextBox()
        Me.su = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.su, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Hoja
        '
        Me.Hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hoja.ForeColor = System.Drawing.Color.Black
        Me.Hoja.Image = CType(resources.GetObject("Hoja.Image"), System.Drawing.Image)
        Me.Hoja.Location = New System.Drawing.Point(968, 8)
        Me.Hoja.Name = "Hoja"
        Me.Hoja.Size = New System.Drawing.Size(35, 35)
        Me.Hoja.TabIndex = 82
        Me.Hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Hoja, "Convierte a Excel")
        Me.Hoja.UseVisualStyleBackColor = False
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Image)
        Me.Regresar.Location = New System.Drawing.Point(928, 8)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 84
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" &
        "queda.")
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 648)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 88
        '
        'Embarque
        '
        Me.Embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embarque.Location = New System.Drawing.Point(136, 8)
        Me.Embarque.Name = "Embarque"
        Me.Embarque.Size = New System.Drawing.Size(176, 26)
        Me.Embarque.TabIndex = 89
        Me.Embarque.Text = "TextBox1"
        '
        'su
        '
        Me.su.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.su.AllowEditing = False
        Me.su.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.su.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.su.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.su.AutoGenerateColumns = False
        Me.su.BackColor = System.Drawing.Color.White
        Me.su.ColumnInfo = resources.GetString("su.ColumnInfo")
        Me.su.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.su.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.su.ForeColor = System.Drawing.Color.Black
        Me.su.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.su.Location = New System.Drawing.Point(9, 64)
        Me.su.Name = "su"
        Me.su.Rows.Count = 1
        Me.su.Rows.DefaultSize = 19
        Me.su.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.su.Size = New System.Drawing.Size(992, 608)
        Me.su.StyleInfo = resources.GetString("su.StyleInfo")
        Me.su.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.su.TabIndex = 90
        '
        'Lista_empaque_4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 703)
        Me.Controls.Add(Me.Embarque)
        Me.Controls.Add(Me.Hoja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.su)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_4"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empaque a excel"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.su, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Lista_empaque_4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        forma_lista()
        llena_su()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub forma_lista()
        Dim dt As New DataTable()
        Dim dd As New DataTable()
        Dim l As Integer = 0
        Dim pri As Integer
        Dim i As Integer
        Dim j As Integer
        Dim talla As String = ""
        Dim c As Integer
        Dim prendas As Integer
        Dim t(11) As Integer
        Dim p(12) As Decimal
        Dim strsql As String = "SELECT PACKING_E.*,CLIENTE FROM PACKING_E LEFT JOIN CPO ON PACKING_E.CPO = CPO.CPO WHERE EMBARQUE = '" & Embarque.Text & "' ORDER BY CAJA_I "
        llena_tablas(dt, strsql, cnn)
        llena_cortes()
        setea_grid()
        Try
            For Each Me.dr In dt.Rows
                strsql = "SELECT * FROM PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "' AND CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "' ORDER BY CAJA"
                llena_tablas(dd, strsql, cnn)
                If dd.Rows.Count > 0 Then
                    dw = dd.Rows(0)
                    pri = fg.Rows.Count
                End If
                For Each Me.dw In dd.Rows
                    If dw("TALLA") <> talla Or dw("PRENDAS") <> prendas Then
                        crea_linea(talla, c, l)
                    End If
                    prendas = CInt(dw("PRENDAS"))
                    fg(l, 6) = dw("CAJA")
                    fg(l, c) = fg(l, c) + prendas
                    fg(l, 24) = fg(l, 24) + prendas
                Next
                l = fg.Rows.Count
                For i = pri To l - 1
                    fg(i, 23) = fg(i, 6) - fg(i, 5) + 1
                    fg(i, 22) = fg(i, 24) / fg(i, 23)
                Next
            Next

            j = fg.Rows.Count
            fg.Rows.Count = j + 1
            For i = 1 To j - 1
                fg(j, 23) = fg(j, 23) + fg(i, 23)
                fg(j, 24) = fg(j, 24) + fg(i, 24)
            Next
            fg(j, 11) = "GRAND TOTAL"
            fg.Rows(j).Height = 30
        Catch
        End Try


    End Sub

    Private Sub crea_linea(ByRef talla As String, ByRef c As Integer, ByRef l As Integer)
        Dim caja As String = dw("CAJA")
        Dim codigo As String = ""
        l = fg.Rows.Count
        talla = dw("TALLA")
        c = fg.Cols.IndexOf(talla)
        Try
            If caja = fg(l - 1, 4) Then
                l = l - 1
                Exit Sub
            End If
        Catch
        End Try
        fg.Rows.Count = fg.Rows.Count + 1
        fg(l, 1) = Embarque.Text
        fg(l, 2) = dr("FECHA")
        fg(l, 3) = dr("CLIENTE")
        fg(l, 4) = dr("DESTINO")
        fg(l, 5) = dw("CAJA")
        fg(l, 7) = dw("ESTILO")
        fg(l, 8) = dw("CPO")
        codigo = get_codigo_color(dr("CLIENTE"), dr("COLOR"))
        If Trim(codigo) <> "" Then
            codigo = codigo + "- "
        End If
        fg(l, 9) = Trim(codigo) + dw("COLOR")
        busca_batch(fg(l, 8), fg(l, 7), fg(l, 9), batch, fpo)
        fg(l, 10) = fpo
        fg(l, 11) = batch
    End Sub

    Private Sub busca_batch(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByRef batch As String, ByRef fpo As String)
        Dim dw As DataRow()
        Dim dr As DataRow
        Dim bt As String
        Dim fp As String
        batch = ""
        fpo = ""
        dw = cp.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
        For Each dr In dw
            bt = dr("BATCH")
            fp = dr("FPO")
            If batch.IndexOf(bt + " ") = -1 Then
                batch = batch + dr("BATCH") + " "
            End If
            If fpo.IndexOf(fp + " ") = -1 Then
                fpo = fpo + dr("FPO") + " "
            End If
        Next
    End Sub

    Private Sub Hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hoja.Click
        Dim nombre As String = Embarque.Text
        adios(nombre)
        Dim path As String = "c:\reportes\Shipment_" + nombre + ".xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
        Catch
        End Try

        Try
            _book.Clear()
            _book.Sheets.Clear()
            Dim sheet As XLSheet = _book.Sheets.Add("Packing")
            SaveSheet(_book, fg, sheet, True)
            _book.Sheets.SelectedIndex = 0
            sheet = _book.Sheets.Add("Summary")
            SaveSheet(_book, su, sheet, True)
            _book.Save(path)
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
        End Try
        Close()
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        Close()
    End Sub

    Private Sub llena_cortes()
        cp = New DataTable()
        llena_tablas(cp, "SELECT * FROM CORTES WHERE CPO + ESTILO + COLOR IN (SELECT CPO+ESTILO+COLOR FROM PACKING_E WHERE EMBARQUE = '" & Embarque.Text & "')", cnn)
    End Sub


    Private Sub llena_su()
        Dim sum As New DataTable
        Dim l As Integer = 1
        Dim i As Integer
        Dim r As Integer
        Dim strsql As String = "SELECT CPO,ESTILO,COLOR,FECHA,CLIENTE,SUM(XS) AS XS,SUM(S) AS S,SUM(M) AS M, SUM(L) AS L,SUM(XL) AS XL,SUM(XL2) AS XL2, SUM(XL3) AS XL3,SUM(XL4) AS XL4,SUM(XL5) AS XL5,SUM(XL6) AS XL6 FROM PACKING_D  WHERE EMBARQUE = '" & Embarque.Text & "' GROUP BY CPO,ESTILO,COLOR,FECHA,CLIENTE ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(sum, strsql, cnn)
        su.Rows(0).Height = 40
        su.Rows.Count = sum.Rows.Count + 2
        r = sum.Rows.Count + 1
        For Each Me.dr In sum.Rows
            su.Rows(l).Height = 22
            su(l, 1) = Embarque.Text
            su(l, 2) = dr("FECHA")
            su(l, 3) = dr("CLIENTE")
            su(l, 4) = dr("CPO")
            su(l, 5) = dr("ESTILO")
            su(l, 6) = dr("COLOR")
            busca_batch(su(l, 4), su(l, 5), su(l, 6), batch, fpo)
            su(l, 7) = batch
            For i = 0 To 9
                su(l, i + 8) = dr(i + 5)
                su(l, 18) = su(l, 18) + dr(i + 5)
                su(r, i + 8) = su(r, i + 8) + dr(i + 5)
                su(r, 18) = su(r, 18) + dr(i + 5)
            Next
            l = l + 1
        Next
        su.Rows(r).Height = 30
        su(r, 7) = "GRAND TOTAL ....."
    End Sub

   

End Class