Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Embarque_resumen
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim dt As New DataTable()
    Dim lineas As Integer
    Dim te(9) As String
    Dim path As String = "c:\reportes\embarcadas_corte.xls"
    Dim tallas_d(12) As String
    Dim co As New DataTable()
    Dim oe As New DataTable()
    Dim va As New DataTable()
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Embarque As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents a_excel As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Embarque_resumen))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.a_excel = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Embarque = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 64)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 616)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'a_excel
        '
        Me.a_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.a_excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.a_excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_excel.ForeColor = System.Drawing.Color.Black
        Me.a_excel.Image = CType(resources.GetObject("a_excel.Image"), System.Drawing.Image)
        Me.a_excel.Location = New System.Drawing.Point(448, 8)
        Me.a_excel.Name = "a_excel"
        Me.a_excel.Size = New System.Drawing.Size(35, 35)
        Me.a_excel.TabIndex = 53
        Me.a_excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.a_excel, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.a_excel.UseVisualStyleBackColor = False
        Me.a_excel.Visible = False
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(408, 8)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(35, 35)
        Me.imprime.TabIndex = 52
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(360, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 2
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Presione para consultar datos.")
        Me.S1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(360, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 59
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Consultar otro embarque.")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(360, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 60
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Embarque
        '
        Me.Embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embarque.Location = New System.Drawing.Point(120, 16)
        Me.Embarque.Name = "Embarque"
        Me.Embarque.Size = New System.Drawing.Size(200, 28)
        Me.Embarque.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Embarque, "No. Embarque")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Embarque_resumen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 696)
        Me.Controls.Add(Me.Embarque)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.a_excel)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Embarque_resumen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Embarques"
        Me.ToolTip1.SetToolTip(Me, "Resumen por embarque")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Embarque.KeyPress, AddressOf ingreso_t
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        llena_embarque()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub


    Private Sub llena_embarque()
        llena_combos(Embarque, "SELECT DISTINCT EMBARQUE, FECHA FROM PACKING_E ORDER BY EMBARQUE", "EMBARQUE")
        Try
            Embarque.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub llena_grid()
        Dim dw As DataRow()
        Dim gr As DataRow
        Dim i As Integer
        Dim l As Integer
        Dim corte As String
        Dim seg As Decimal
        stock()
        otros_embarques()
        vales()
        Dim strSQL As String = "SELECT PACKING_D.*, BATCH,TOTAL,SECCION FROM PACKING_D LEFT JOIN CORTES ON PACKING_D.CORTE = CORTES.CORTE WHERE EMBARQUE = '" & Embarque.Text & "' ORDER BY PACKING_D.CORTE"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            corte = dr("CORTE")
            l = fg.FindRow(corte, 1, 3, False)
            If l < 0 Then
                crea_otra_linea(l)
                dw = co.Select("CORTE = '" & corte & "'")
                For Each gr In dw
                    If gr("TIPO") = "00" Then
                        fg(l, 21) = fg(l, 21) + gr("PRENDAS")
                    ElseIf gr("TIPO") = "01" Then
                        fg(l, 22) = fg(l, 22) + gr("PRENDAS")
                    Else
                        fg(l, 23) = fg(l, 23) + gr("PRENDAS")
                    End If
                Next
            End If
            For i = 0 To 9
                If dr("TIPO") = "Pri" Then
                    fg(l, i + 8) = fg(l, i + 8) + dr(i + 8)
                    fg(l, 18) = fg(l, 18) + dr(i + 8)
                Else
                    fg(l, 19) = fg(l, 19) + dr(i + 8)
                End If
            Next
        Next
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 3) <> "STOCK" Then
                seg = fg(i, 19) + fg(i, 22) + fg(i, 23)
                Try
                    fg(i, 20) = seg / fg(i, 7)
                Catch
                End Try
                fg(i, 26) = fg(i, 7) - (fg(i, 18) + fg(i, 19) + fg(i, 21) + fg(i, 22) + fg(i, 23) + fg(i, 24) + fg(i, 25))
            End If
        Next
        subtotales()
    End Sub

    Private Sub crea_otra_linea(ByRef l As Integer)
        Dim dw As DataRow()
        Dim dd As DataRow
        fg.Rows.Count = fg.Rows.Count + 1
        lineas = fg.Rows.Count - 1
        fg(lineas, 1) = dr("EMBARQUE")
        fg(lineas, 2) = dr("CLIENTE")
        fg(lineas, 3) = dr("CORTE")
        fg(lineas, 4) = dr("CPO")
        fg(lineas, 5) = dr("ESTILO")
        fg(lineas, 6) = dr("COLOR")
        fg(lineas, 7) = dr("TOTAL")
        fg(lineas, 27) = dr("FECHA")
        fg(lineas, 28) = dr("SECCION")
        dw = oe.Select("CORTE = '" & dr("CORTE") & "'")
        If dw.Length > 0 Then
            dd = dw(0)
            fg(lineas, 25) = dd("PRENDAS")
        End If
        dw = va.Select("CORTE = '" & dr("CORTE") & "'")
        If dw.Length > 0 Then
            dd = dw(0)
            fg(lineas, 24) = dd("PRENDAS")
        End If
        l = lineas
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        fg.Sort(SortFlags.Ascending, 1)
        For i = 7 To 19
            fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
        Next i
        For i = 21 To 26
            fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
        Next i
    End Sub


    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        fecha = Format(Today, "dd/MM/yyy")
        mal = obj.nombre + "  Resumen del Embarque " + Embarque.Text
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 20
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Empaque", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_excel.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub datos_excel(ByRef si As Boolean)
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


    Private Sub stock()
        co = New DataTable()
        Dim strSQL As String = "SELECT CORTE,TIPO,SUM(PRENDAS) AS PRENDAS FROM E_STOCK WHERE CORTE IN (SELECT CORTE FROM PACKING_D WHERE EMBARQUE = '" & Embarque.Text & "') GROUP BY CORTE,TIPO ORDER BY CORTE"
        llena_tablas(co, strSQL, cnn)
    End Sub

    Private Sub otros_embarques()
        oe = New DataTable()
        Dim strSQL As String = "SELECT CORTE,SUM(PRENDAS) AS PRENDAS FROM EMBARQUES WHERE EMBARQUE <> '" & Embarque.Text & "' AND CORTE IN (SELECT CORTE FROM PACKING_D WHERE EMBARQUE = '" & Embarque.Text & "') GROUP BY CORTE ORDER BY CORTE"
        llena_tablas(oe, strSQL, cnn)
    End Sub

    Private Sub vales()
        va = New DataTable()
        Dim strSQL As String = "SELECT CORTE,SUM(PRENDAS) AS PRENDAS FROM VALES WHERE CORTE IN (SELECT CORTE FROM PACKING_D WHERE EMBARQUE = '" & Embarque.Text & "') GROUP BY CORTE ORDER BY CORTE"
        llena_tablas(va, strSQL, cnn)
    End Sub



    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        If Embarque.Items.IndexOf(Embarque.Text) <> -1 Then
            llena_grid()
            CANCELA.Visible = True
            S1.Visible = False
            Embarque.Enabled = False
            imprime.Visible = True
            a_excel.Visible = True
        Else
            MsgBox("Embarque inexistente !!!!!", MsgBoxStyle.Critical, "Por favor Ingreselo de nuevo.")
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        setea_grid()
        CANCELA.Visible = False
        S1.Visible = True
        Embarque.Enabled = True
        imprime.Visible = False
        a_excel.Visible = False

    End Sub


    Private Sub embarque_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Embarque.KeyUp
        Dim index As Integer
        Dim actual As String
        Dim found As String

        ' Do nothing for some keys such as navigation keys.
        If ((e.KeyCode = Keys.Back) Or _
            (e.KeyCode = Keys.Left) Or _
            (e.KeyCode = Keys.Right) Or _
            (e.KeyCode = Keys.Up) Or _
            (e.KeyCode = Keys.Delete) Or _
            (e.KeyCode = Keys.Down) Or _
            (e.KeyCode = Keys.PageUp) Or _
            (e.KeyCode = Keys.PageDown) Or _
            (e.KeyCode = Keys.Home) Or _
            (e.KeyCode = Keys.End)) Then
            Return
        End If

        ' Store the actual text that has been typed.
        actual = Embarque.Text

        ' Find the first match for the typed value.
        index = Embarque.FindString(actual)

        ' Get the text of the first match.
        If (index > -1) Then
            found = Embarque.Items(index).ToString()

            ' Select this item from the list.
            Embarque.SelectedIndex = index

            ' Select the portion of the text that was automatically
            ' added so that additional typing will replace it.
            Embarque.SelectionStart = actual.Length
            Embarque.SelectionLength = found.Length
        End If
    End Sub

    Private Sub ingreso_t(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Embarque.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed

End Class



