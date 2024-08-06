Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Producido_cob2
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents to_excel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producido_cob2))
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.sigue = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.to_excel = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(248, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(60, 40)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(96, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(120, 26)
        Me.fecha.TabIndex = 1
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(248, 16)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 3
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(314, 16)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(60, 40)
        Me.imprime.TabIndex = 94
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'fecha1
        '
        Me.fecha1.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha1.CustomFormat = "dd/MM/yyyy"
        Me.fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha1.Location = New System.Drawing.Point(96, 48)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(120, 26)
        Me.fecha1.TabIndex = 2
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 80)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 100
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(1000, 616)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 26)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Desde:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Hasta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'to_excel
        '
        Me.to_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.to_excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_excel.ForeColor = System.Drawing.Color.Black
        Me.to_excel.Image = CType(resources.GetObject("to_excel.Image"), System.Drawing.Image)
        Me.to_excel.Location = New System.Drawing.Point(380, 16)
        Me.to_excel.Name = "to_excel"
        Me.to_excel.Size = New System.Drawing.Size(60, 40)
        Me.to_excel.TabIndex = 108
        Me.to_excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.to_excel.UseVisualStyleBackColor = False
        Me.to_excel.Visible = False
        '
        'Producido_cob2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 707)
        Me.Controls.Add(Me.to_excel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha1)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producido_cob2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cortes Pendientes de Facturar"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim est As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cob As New DataTable()
    Dim dr As DataRow
    Dim fechas As String
    Dim rango As String
    Private Sub detalle_facturas_r(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fecha.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 100
        fg.Height = Me.Height - 100
        fecha.Value = Today
        deshabilita()
    End Sub

    Private Sub deshabilita()
        setea_grid()
        fecha.Enabled = True
        CANCELA.Visible = False
        sigue.Visible = True
        fecha.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub


    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        Dim ok As Boolean
        revisa_fechas(ok)
        If ok Then
            sigue.Visible = False
            CANCELA.Visible = True
            imprime.Visible = True
            to_excel.Visible = True
            fecha.Enabled = False
            fecha1.Enabled = False
            Cursor = Cursors.WaitCursor
            llena_fg()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub revisa_fechas(ByRef ok As Boolean)
        rango = ""
        If fecha1.Value < fecha.Value Then
            MsgBox("La fecha final es menor que la inicial", MsgBoxStyle.Critical, "Por favor revise !!!!")
            ok = False
        Else
            ok = True
            rango = " FPROD BETWEEN '" & Format(fecha.Value, "yyyy-MM-dd") & "' AND '" & Format(fecha1.Value, "yyyy-MM-dd") & "' "
        End If
    End Sub

    Private Sub llena_fg()
        Dim f As Integer
        Dim i As Integer
        Dim dt As New DataTable()
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim ds As DataRow
        Dim corte As String
        Dim cpo As String
        Dim colo As String
        Dim prendas As Integer
        Dim tipo As String
        Dim estilo As String
        Dim busca As String = ""
        Dim precio As Decimal
        Dim cortado As Integer
        Dim l As Integer = 1
        Dim strsql As String = "SELECT PROD_DIARIA.CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,TIPO,ESTILOS.CORTE AS VCORTE,COSTURA,HILO,EMPAQUE,OTROS,CORTES.TOTAL,SUM(PRENDAS) AS PRENDAS,CORTES.SECCION,CPO_D.ESTADO FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE LEFT JOIN ESTILOS ON CORTES.ESTILO = ESTILOS.ESTILO AND CORTES.CLIENTE = ESTILOS.CLIENTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE   " & rango & "   GROUP BY PROD_DIARIA.CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,TIPO,ESTILOS.CORTE,COSTURA,HILO,EMPAQUE,OTROS,CORTES.TOTAL,SECCION,CPO_D.ESTADO  ORDER BY PROD_DIARIA.CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR  "
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            corte = dr("CORTE")
            cpo = dr("CPO")
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            tipo = dr("TIPO")
            prendas = dr("PRENDAS")
            cortado = dr("TOTAL")
            f = fg.FindRow(corte, 1, 1, False)
            If f = -1 Then
                f = l
                l = l + 1
                fg(f, 1) = corte
                fg(f, 2) = cpo
                fg(f, 3) = estilo
                fg(f, 4) = colo
                fg(f, 5) = cortado
                fg(f, 15) = dr("SECCION")
                fg(f, 16) = dr("ESTADO")
                Try
                    fg(f, 10) = dr("VCORTE") + dr("COSTURA") + dr("HILO") + dr("EMPAQUE") + dr("OTROS")
                Catch
                End Try
            End If
            If tipo = "0" Then
                fg(f, 6) = fg(f, 6) + prendas
            Else
                If (tipo = "3" Or tipo = "8") Then
                    fg(f, 8) = fg(f, 8) + prendas
                Else
                    fg(f, 7) = fg(f, 7) + prendas
                End If
            End If
            If busca.IndexOf("'" & corte & "'") < 1 Then
                busca = busca + "'" & corte & "','ST-" & corte & "',"
            End If
        Next
        fg.Rows.Count = l
        i = busca.Length
        If i > 0 Then
            busca = Mid(busca, 1, i - 1)
        End If
        llena_tablas(cob, "SELECT * FROM PACKING_D LEFT JOIN FACTURA_MO ON PACKING_D.EMBARQUE = FACTURA_MO.EMBARQUE AND PACKING_D.CPO = FACTURA_MO.CPO AND PACKING_D.ESTILO = FACTURA_MO.ESTILO AND PACKING_D.COLOR = FACTURA_MO.COLOR WHERE CORTE IN (" & busca & ")", cnn)
        For i = 1 To fg.Rows.Count - 1
            fg(i, 9) = fg(i, 6) + fg(i, 7)
            fg(i, 10) = Format((fg(i, 10) / 12) * (fg(i, 5)), "#######0.00")
            dd = cob.Select("CORTE = '" & fg(i, 1) & "' OR CORTE = 'ST-" & fg(i, 1) & "'")
            If dd.Length > 0 Then
                For Each ds In dd
                    prendas = ds("XS") + ds("S") + ds("M") + ds("L") + ds("XL") + ds("XL2") + ds("XL3") + ds("XL4") + ds("XL5") + ds("XL6")
                    fg(i, 11) = fg(i, 11) + prendas
                    Try
                        precio = ds("PRECIO") / 12
                    Catch ex As Exception
                        precio = 0
                    End Try
                    If precio > 0 Then
                        fg(i, 12) = precio * fg(i, 11)
                    End If
                Next
            End If
            fg(i, 13) = fg(i, 5) - fg(i, 11) - fg(i, 8)
            fg(i, 14) = fg(i, 10) - fg(i, 12)
            If fg(i, 14) < 0.5 Then
                fg(i, 14) = 0
            End If
            If fg(i, 13) < 1 Then
                fg(i, 0) = "E"
            End If
            precio = fg(i, 13)
        Next i
        fg.Sort(SortFlags.Ascending, 13)
        i = fg.FindRow("E", 1, 0, False)
        While i > 0
            fg.Rows.Remove(i)
            i = fg.FindRow("E", 1, 0, False)
        End While

    End Sub
    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        fechas = Format(fecha.Value, "yyyy-MM-dd")
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        sigue.Visible = True
        CANCELA.Visible = False
        imprime.Visible = False
        fecha.Enabled = True
        fecha1.Enabled = True
        fg.Rows.Count = 1
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fechad As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        fechad = Format(fecha.Value, "dd/MM/yyyy")
        mal = "Prendas Producidas Pendientes de Facturar  " + fechad & "  al " & Format(fecha1.Value, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("facturacion", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub sub_totales()
        Dim i As Integer
        Try
            For i = 5 To 14
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i)
            Next i

            Try
                fg.Rows(1).Height = 25
            Catch
            End Try
        Catch
        End Try

    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.AfterFilter
        sub_totales()
    End Sub

    Private Sub to_excel_Click(sender As System.Object, e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Pendientes_facturar " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        a_excel(fg, hora, ok)
        Close()
    End Sub
End Class
