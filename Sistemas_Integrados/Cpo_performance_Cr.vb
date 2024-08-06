Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Imports C1.Win.C1Chart
Public Class Cpo_performance_Cr
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dx As New DataTable()
    Dim dr As DataRow
    Dim dd As DataRow()
    Dim lineas As Integer
    Friend WithEvents Fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1Chart1 As C1.Win.C1Chart.C1Chart
    Friend WithEvents tf As System.Windows.Forms.ComboBox
    Dim path As String = "c:\reportes\Cpo_performance_c.xls"
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cpo_performance_Cr))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tf = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1Chart1 = New C1.Win.C1Chart.C1Chart()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(625, 8)
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
        Me.S1.Location = New System.Drawing.Point(585, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(129, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(665, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 64
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Fecha_final
        '
        Me.Fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_final.Location = New System.Drawing.Point(131, 60)
        Me.Fecha_final.Name = "Fecha_final"
        Me.Fecha_final.Size = New System.Drawing.Size(112, 22)
        Me.Fecha_final.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.Fecha_final, "Fecha donde finaliza la búsqueda de Documentos.")
        '
        'Fecha_inicial
        '
        Me.Fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_inicial.Location = New System.Drawing.Point(131, 36)
        Me.Fecha_inicial.Name = "Fecha_inicial"
        Me.Fecha_inicial.Size = New System.Drawing.Size(112, 22)
        Me.Fecha_inicial.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.Fecha_inicial, "Fecha desde donde comienza la búsqueda de Documentos.")
        '
        'fj
        '
        Me.fj.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fj.AllowEditing = False
        Me.fj.BackColor = System.Drawing.Color.White
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.fj.ForeColor = System.Drawing.Color.Black
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fj.Location = New System.Drawing.Point(5, 107)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 20
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fj.Size = New System.Drawing.Size(455, 127)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.fj, "Area de Datos.")
        '
        'tf
        '
        Me.tf.AutoCompleteCustomSource.AddRange(New String() {"Fecha del CPO", "Fecha Acordada"})
        Me.tf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf.Items.AddRange(New Object() {"Fecha del CPO", "Fecha Acordada Cliente"})
        Me.tf.Location = New System.Drawing.Point(380, 8)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(175, 24)
        Me.tf.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.tf, "Fecha del CPO o Fecha Acordada")
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Fecha Incial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1Chart1
        '
        Me.C1Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.C1Chart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C1Chart1.ForeColor = System.Drawing.Color.Red
        Me.C1Chart1.Location = New System.Drawing.Point(466, 107)
        Me.C1Chart1.Name = "C1Chart1"
        Me.C1Chart1.PropBag = resources.GetString("C1Chart1.PropBag")
        Me.C1Chart1.Size = New System.Drawing.Size(720, 543)
        Me.C1Chart1.TabIndex = 70
        '
        'Cpo_performance_Cr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1198, 696)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.C1Chart1)
        Me.Controls.Add(Me.fj)
        Me.Controls.Add(Me.Fecha_final)
        Me.Controls.Add(Me.Fecha_inicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "Cpo_performance_Cr"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Performance por CPO"
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM CPO ORDER BY CLIENTE", "CLIENTE")
        setea_fj()
        C4.SelectedIndex = 0
        tf.SelectedIndex = 0
        C1Chart1.Visible = False
        C4.Focus()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        If CDate(Fecha_final.Value) < CDate(Fecha_inicial.Value) Then
            MsgBox("La fecha final es menor que la inicial. Revise !!!!", MsgBoxStyle.OkOnly, "ERROR EN LAS FECHAS")
            Exit Sub
        Else
            S1.Visible = False
            R1.Visible = True
            deshabilita()
            llena_fj()
            Cursor = Cursors.WaitCursor
            Cursor = Cursors.Default
            R1.Focus()
        End If

    End Sub

    Private Sub deshabilita()
        C1Chart1.Visible = True
        C4.Enabled = False
        Fecha_inicial.Enabled = False
        Fecha_final.Enabled = False
        Button2.Visible = True
        tf.Enabled = False
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        C1Chart1.Visible = False
        C4.Enabled = True
        S1.Visible = True
        R1.Visible = False
        Fecha_inicial.Enabled = True
        Fecha_final.Enabled = True
        Button2.Visible = False
        tf.Enabled = True
        setea_fj()
        C4.Focus()
    End Sub

    Private Sub setea_fj()
        fj.Rows.Count = 1
        fj.Rows(0).Height = 30
        fj.Rows.Count = 5
        fj(1, 1) = "A tiempo."
        fj(2, 1) = "Atrazado."
        fj(3, 1) = "Adelantado."
        fj(4, 1) = "TOTALES"
        fj.Rows(4).Height = 30
    End Sub

    Private Sub llena_fj()
        Dim l As Integer
        Dim cpos As String
        Dim estilo As String
        Dim colo As String
        Dim dias As Integer
        Dim dj As DataRow
        Dim req As Integer
        Dim exp As Integer
        Dim por As Integer
        Dim f_entrega As Date
        Dim f_expo As Date
        Dim total As Integer = 0
        Dim strsql As String = "SELECT CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR,CLIENTE,TOTAL,CPO_D.F_ENTREGA,EXP_REV,ESTADO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN WIP0 ON CPO_D.CPO = WIP0.CPO AND CPO_D.ESTILO = WIP0.ESTILO AND CPO_D.COLOR = WIP0.COLOR AND TALLA = 'TOTAL' WHERE CLIENTE = '" & C4.Text & "' AND ( CPO_D.F_ENTREGA BETWEEN '" & Format(Fecha_inicial.Value, "yyyy-MM-dd") & "' AND '" & Format(Fecha_final.Value, "yyyy-MM-dd") & "') ORDER BY CPO_D.CPO"
        llena_tablas(dt, strsql, cnn)
        For Each Me.dr In dt.Rows
            req = dr("TOTAL")
            exp = 0
            por = 0
            dias = 0
            f_expo = Today
            cpos = dr("CPO")
            colo = dr("COLOR")
            estilo = dr("ESTILO")
            Try
                If tf.SelectedIndex = 0 Then
                    f_entrega = dr("F_ENTREGA")
                Else
                    If IsDBNull(dr("EXP_REV")) = False Then
                        f_entrega = dr("EXP_REV")
                    Else
                        f_entrega = dr("F_ENTREGA")
                    End If
                End If
            Catch
            End Try
            dd = dx.Select("CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'", "FECHA ASC")
            If dd.Length > 0 Then
                For Each dj In dd
                    exp = exp + dj("EXPORTADO")
                    f_expo = dj("FECHA")
                Next
            Else
                f_expo = Today
            End If

            por = (exp * 100) / req
            If por < 94 Then
                f_expo = Today    ' Pedido no completado
            End If

            dias = DateDiff(DateInterval.Day, f_entrega, f_expo)

            If (dias < 8) And (dias > -8) Then
                fj(1, 2) = fj(1, 2) + exp
            ElseIf dias > 8 Then
                fj(2, 2) = fj(2, 2) + exp
            Else
                fj(3, 2) = fj(3, 2) + exp
            End If
            total = total + exp
        Next

        For l = 1 To 3
            Try
                fj(l, 3) = (fj(l, 2) * 100) / total
            Catch
            End Try

        Next
        fj(4, 2) = total
        dibuja_grafica()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Try
            Dim ch As Char = Microsoft.VisualBasic.Chr(9)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fj.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
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
        pd = fj.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fj.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fj.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fj.PrintGrid("Performance", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, C4.Text + "   Reporte de Performance de Cpos del " & Fecha_inicial.Text & "  al " + Fecha_final.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
        C1Chart1.PrintChart()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub C4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.SelectedIndexChanged
        llena_tablas(dx, "SELECT CPO,ESTILO,COLOR,CLIENTE,SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) AS EXPORTADO, FECHA  FROM PACKING_D WHERE CLIENTE = '" & C4.Text & "' AND TIPO = 'Pri' GROUP BY CPO,ESTILO,COLOR ,CLIENTE,FECHA ORDER BY CPO,ESTILO,COLOR,FECHA ", cnn)
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub

    Private Sub tf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tf.KeyPress
        AutoCompletar(tf, e)
    End Sub
    Private Sub dibuja_grafica()

        ' Set chart type
        C1Chart1.ChartArea.Inverted = True
        C1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie

        ' Clear previous data
        C1Chart1.ChartGroups(0).ChartData.SeriesList.Clear()

        ' Add Data
        Dim ProductNames As String() = {"Atrazado", "A tiempo", "Adelantado"}
        Dim PriceX As Integer() = {fj(2, 3), fj(1, 3), fj(3, 3)}

        'get series collection
        Dim dscoll As ChartDataSeriesCollection = C1Chart1.ChartGroups(0).ChartData.SeriesList
        For i As Integer = 0 To PriceX.Length - 1
            'populate the series
            Dim series As ChartDataSeries = dscoll.AddNewSeries()
            'Add one point to show one pie
            series.PointData.Length = 1
            'Assign the prices to the Y Data series
            series.Y(0) = PriceX(i)
            'format the product name and product price on the legend
            series.Label = ProductNames(i) & "   " & PriceX(i) & "%"
        Next
        ' show pie Legend
        C1Chart1.Legend.Visible = True
        'add a title to the chart legend
        C1Chart1.Legend.Text = C4.Text & vbLf & "Pedidos del " & Fecha_inicial.Text & " al " & Fecha_final.Text
        ' crea_grafica()

        C1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(45)
        C1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(45)
        C1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(45)

        'udDepth.Enabled = True
        'udElev.Enabled = True
    End Sub

End Class



