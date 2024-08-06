Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Cortes_Diarios
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As empresas
    Dim strSql As String
    Dim Sqls As String = "SELECT CORTE,CPO,FPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,FCORTE,CLIENTE,BATCH FROM CORTES WHERE CORTE = ''"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents hoja As System.Windows.Forms.Button
    Friend WithEvents Regresa As System.Windows.Forms.Button
    Friend WithEvents fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_final As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_Diarios))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.hoja = New System.Windows.Forms.Button()
        Me.fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.si = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Regresa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 80)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 14
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 576)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 23
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.Location = New System.Drawing.Point(472, 8)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(35, 35)
        Me.Imprimir.TabIndex = 54
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.UseVisualStyleBackColor = False
        Me.Imprimir.Visible = False
        '
        'hoja
        '
        Me.hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoja.ForeColor = System.Drawing.Color.Black
        Me.hoja.Image = CType(resources.GetObject("hoja.Image"), System.Drawing.Image)
        Me.hoja.Location = New System.Drawing.Point(424, 8)
        Me.hoja.Name = "hoja"
        Me.hoja.Size = New System.Drawing.Size(35, 35)
        Me.hoja.TabIndex = 55
        Me.hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.hoja, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.hoja.UseVisualStyleBackColor = False
        Me.hoja.Visible = False
        '
        'fecha_inicial
        '
        Me.fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.fecha_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_inicial.Location = New System.Drawing.Point(152, 8)
        Me.fecha_inicial.Name = "fecha_inicial"
        Me.fecha_inicial.Size = New System.Drawing.Size(112, 26)
        Me.fecha_inicial.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.fecha_inicial, "Fecha de la cual se desea Consultar o Imprimir el Reporte de Tela Recibida.")
        '
        'Fecha_final
        '
        Me.Fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_final.Location = New System.Drawing.Point(152, 40)
        Me.Fecha_final.Name = "Fecha_final"
        Me.Fecha_final.Size = New System.Drawing.Size(112, 26)
        Me.Fecha_final.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Fecha_final, "Fecha de la cual se desea Consultar o Imprimir el Reporte de Tela Recibida.")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(376, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 60
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este Boton para Desplegar el  Reporte de Ingresos a Inventario. ")
        Me.si.UseVisualStyleBackColor = False
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Image)
        Me.Regresar.Location = New System.Drawing.Point(376, 8)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 61
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" & _
                "queda.")
        Me.Regresar.UseVisualStyleBackColor = False
        Me.Regresar.Visible = False
        '
        'Regresa
        '
        Me.Regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresa.ForeColor = System.Drawing.Color.Black
        Me.Regresa.Image = CType(resources.GetObject("Regresa.Image"), System.Drawing.Image)
        Me.Regresa.Location = New System.Drawing.Point(376, 8)
        Me.Regresa.Name = "Regresa"
        Me.Regresa.Size = New System.Drawing.Size(35, 35)
        Me.Regresa.TabIndex = 62
        Me.Regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresa, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" & _
                "queda.")
        Me.Regresa.UseVisualStyleBackColor = False
        Me.Regresa.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Fecha Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cortes_Diarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1006, 676)
        Me.Controls.Add(Me.Fecha_final)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha_inicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hoja)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Regresa)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_Diarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Diario de Cortes"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Clear(ClearFlags.All)
        Dim index As Integer
        fg.DataSource = GetDataSource()
        fg.Cols.Count = 22
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Caption = "CORTE"
        fg.Cols(2).Caption = "CPO"
        fg.Cols(3).Caption = "FPO"
        fg.Cols(4).Caption = "ESTILO"
        fg.Cols(5).Caption = "COLOR"
        fg.Cols(6).Caption = "XS"
        fg.Cols(7).Caption = "S"
        fg.Cols(8).Caption = "M"
        fg.Cols(9).Caption = "L"
        fg.Cols(10).Caption = "XL"
        fg.Cols(11).Caption = "2XL"
        fg.Cols(12).Caption = "3XL"
        fg.Cols(13).Caption = "4XL"
        fg.Cols(14).Caption = "5XL"
        fg.Cols(15).Caption = "6XL"
        fg.Cols(16).Caption = "TOTAL"
        fg.Cols(17).Caption = "ESCALA"
        fg.Cols(18).Caption = "F.CORTE"
        fg.Cols(19).Caption = "CLIENTE"
        fg.Cols(20).Caption = "BATCH"
        fg.Cols(21).Caption = "SALA CORTE"
        Dim s As C1.Win.C1FlexGrid.CellStyle
        s = fg.Styles.Add("rojo")
        s.ForeColor = Color.Blue
        s.Font = New Font(fg.Styles.Normal.Font, FontStyle.Bold)
        fg.Cols(16).Style = fg.Styles("rojo")
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 80
            fg(0, index) = fg.Cols(index).Caption
            If index > 5 And index < 17 Then
                fg.Cols(index).TextAlign = TextAlignEnum.RightBottom
                fg.Cols(index).TextAlignFixed = TextAlignEnum.CenterCenter
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######"
                fg.Cols(index).Width = 45
            End If
        Next
        fg.Cols(1).Width = 50
        fg.Cols(2).Width = 90
        fg.Cols(5).Width = 100
        fg.Cols(16).Width = 55
        fg.Cols(18).Width = 200
        fg.Cols(19).Width = 250
        fg.Cols(20).Width = 170
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
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog, "Reporte de Corte del dia:  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Print_fg()
    End Sub

    Private Sub datos_excel(ByRef si As Boolean)
        Dim path As String = "c:\Reportes\cortes_diarios.xls"
        Dim ok As Boolean
        a_excel(fg, path, ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Function GetDataSource() As DataTable
        Dim dt As New DataTable
        Try
            llena_tablas(dt, strSql, cnn)
            GetDataSource = dt
        Catch
        End Try
        Return dt
    End Function

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoja.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/  bajo el nombre de Diaria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        If CDate(Fecha_final.Text) < CDate(fecha_inicial.Text) Then
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Fecha final es menor que la Inicial")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Habilita()
        Dim FECHAI As String
        Dim FECHAF As String
        FECHAI = Format(CDate(fecha_inicial.Text), "yyyy-MM-dd")
        FECHAF = Format(CDate(Fecha_final.Text), "yyyy-MM-dd")
        strSql = "SELECT CORTE,CORTES.CPO,FPO,CORTES.ESTILO,CORTES.COLOR,CORTES.XS,CORTES.S,CORTES.M,CORTES.L,CORTES.XL,CORTES.XL2,CORTES.XL3,CORTES.XL4,CORTES.XL5,CORTES.XL6,CORTES.TOTAL,NOMBRE,FCORTE,CLIENTE,BATCH ,(SELECT SALA FROM CORTES_S WHERE CORTES_S.CORTE = CORTES.CORTE) AS SALA FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE FCORTE BETWEEN '" & FECHAI & "' AND '" & FECHAF & "' ORDER BY FCORTE,CORTE"
        setea_grid()
        Cursor = Cursors.Default
    End Sub

    Private Sub Habilita()
        si.Visible = False
        Imprimir.Visible = True
        Regresar.Visible = True
        hoja.Visible = True
        fecha_inicial.Enabled = False
        Fecha_final.Enabled = False
    End Sub

    Private Sub deshabilita()
        si.Visible = True
        Imprimir.Visible = False
        Regresar.Visible = False
        hoja.Visible = False
        fecha_inicial.Enabled = True
        Fecha_final.Enabled = True
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        deshabilita()
        strSql = Sqls
        setea_grid()
    End Sub
End Class
