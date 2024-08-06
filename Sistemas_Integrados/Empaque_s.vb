Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Empaque_s
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Dim fecha As String
    Dim fecha1 As String
    Dim path As String = "c:\reportes\segundas.xls"

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empaque_s))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        Me.fecha_f = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 72)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(976, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'fecha_i
        '
        Me.fecha_i.CustomFormat = "dd/MM/yyyy"
        Me.fecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_i.Location = New System.Drawing.Point(144, 8)
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(136, 26)
        Me.fecha_i.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Fecha de la Produccion")
        '
        'fecha_f
        '
        Me.fecha_f.CustomFormat = "dd/MM/yyyy"
        Me.fecha_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_f.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_f.Location = New System.Drawing.Point(144, 40)
        Me.fecha_f.Name = "fecha_f"
        Me.fecha_f.Size = New System.Drawing.Size(136, 26)
        Me.fecha_f.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Fecha de la Produccion")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(880, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 53
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
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
        Me.Button2.Location = New System.Drawing.Point(824, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 52
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(328, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 58
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(328, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 60
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
                " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Empaque_s
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 696)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fecha_f)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha_i)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.CANCELA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Empaque_s"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Segundas"
        Me.ToolTip1.SetToolTip(Me, "Captacion de la Produccion diaria")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        Llena_tipos()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 21
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CORTE"
        fg.Cols(2).Name = "CLIENTE"
        fg.Cols(3).Name = "CPO"
        fg.Cols(4).Name = "ESTILO"
        fg.Cols(5).Name = "COLOR"
        fg.Cols(6).Name = "1ras."
        fg.Cols(7).Name = "XS"
        fg.Cols(8).Name = "S"
        fg.Cols(9).Name = "M"
        fg.Cols(10).Name = "L"
        fg.Cols(11).Name = "XL"
        fg.Cols(12).Name = "2XL"
        fg.Cols(13).Name = "3XL"
        fg.Cols(14).Name = "4XL"
        fg.Cols(15).Name = "5XL"
        fg.Cols(16).Name = "6XL"
        fg.Cols(17).Name = "TOT."
        fg.Cols(18).Name = "CORTE"
        fg.Cols(19).Name = "%"
        fg.Cols(20).Name = "SECCION"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 80
            fg(0, index) = fg.Cols(index).Name
            If index > 5 And index < 19 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 50
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(1).Width = 60
        fg.Cols(6).Width = 60
        fg.Cols(17).Width = 60
        fg.Cols(19).Width = 43
        fg.Cols(19).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(19).TextAlignFixed = TextAlignEnum.RightCenter
    End Sub

    Private Sub llena_grid()
        ok = False
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim orden As String
        Dim tipo As String
        Dim talla As String
        Dim prendas As Integer
        Dim dato As String
        Dim strSQL As String = "SELECT PROD_DIARIA.CORTE,CLIENTE,CPO,ESTILO,COLOR,TIPO,FECHA,TALLA,PRENDAS,TOTAL,SECCION FROM PROD_DIARIA, CORTES WHERE FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "' AND PROD_DIARIA.CORTE = CORTES.CORTE"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            orden = dr("CORTE")
            si = fg.FindRow(orden, 1, 1, True)
            If si = -1 Then
                crea_otra_linea(dr)
            End If
            tipo = dr("TIPO")
            talla = dr("TALLA")
            prendas = dr("PRENDAS")
            i = Array.IndexOf(te, talla)
            If tipo = 0 Then
                fg(si, 6) = fg(si, 6) + prendas
            Else
                fg(si, i + 7) = fg(si, i + 7) + prendas
                fg(si, 17) = fg(si, 17) + prendas
            End If
        Next
        For i = 1 To fg.Rows.Count - 1
            dato = Format((fg(i, 17) * 100) / (fg(i, 18)), h)
            fg(i, 19) = dato + "%"
            'If (fg(i, 6) + fg(i, 17)) <> fg(i, 18) Then
            '    fg.SetCellStyle(i, 18, fg.Styles("rojo"))
            'End If
        Next
        subtotales()
    End Sub

    Private Sub crea_otra_linea(ByVal dr As DataRow)
        Dim i As Integer
        fg.Rows.Count = fg.Rows.Count + 1
        lineas = fg.Rows.Count - 1
        fg(lineas + i, 1) = dr("CORTE")
        fg(lineas + i, 2) = dr("CLIENTE")
        fg(lineas + i, 3) = dr("CPO")
        fg(lineas + i, 4) = dr("ESTILO")
        fg(lineas + i, 5) = dr("COLOR")
        fg(lineas + i, 18) = dr("TOTAL")
        fg(lineas + i, 20) = dr("SECCION")
        si = lineas
    End Sub

    Private Sub Llena_tipos()
        Dim tallas As String = "XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6"
        te = Split(tallas, ","c)
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        With fg
            Try
                For i = 6 To 18
                    fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
                Next i
            Catch
            End Try
        End With
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        fecha = Format(Today, "dd/MM/yyy")
        mal = obj.nombre + "  Reporte de Segundas del: " + Format(CDate(fecha_i.Text), "dd/MM/yyyy") + " al " + Format(CDate(fecha_f.Text), "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Empaque", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        chequea_fechas(ok)
        If ok Then
            setea_grid()
            llena_grid()
            S1.Visible = False
            CANCELA.Visible = True
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            Button2.Visible = True
            Button3.Visible = True
        End If
    End Sub


    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        CANCELA.Visible = False
        S1.Visible = True
        fecha_i.Enabled = True
        fecha_f.Enabled = True
        Button2.Visible = False
        Button3.Visible = False
        setea_grid()
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub
End Class



