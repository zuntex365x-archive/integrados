Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Embarques_costura
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim strsql As String
    Dim pd As Date
    Dim fec As Date
    Dim fei As Date
    Dim hoy As Date = Today
    Dim dis As Integer = hoy.DayOfWeek

    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tsd As New DataTable()
    Dim obj As New empresas()
    Dim path As String = "c:\reportes\balance.xls"
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Embarques_costura))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(112, 8)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(256, 28)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Lista de Clientes")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(400, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 53
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(400, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(448, 8)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(35, 35)
        Me.Impri.TabIndex = 58
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Impri.UseVisualStyleBackColor = False
        Me.Impri.Visible = False
        '
        'Ex
        '
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Ex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.Image = CType(resources.GetObject("Ex.Image"), System.Drawing.Image)
        Me.Ex.Location = New System.Drawing.Point(496, 8)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(35, 35)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.UseVisualStyleBackColor = False
        Me.Ex.Visible = False
        '
        'Te
        '
        Me.Te.AllowEditing = False
        Me.Te.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Te.BackColor = System.Drawing.Color.White
        Me.Te.ColumnInfo = resources.GetString("Te.ColumnInfo")
        Me.Te.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Te.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.Te.ForeColor = System.Drawing.Color.Black
        Me.Te.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Te.Location = New System.Drawing.Point(9, 48)
        Me.Te.Name = "Te"
        Me.Te.Rows.DefaultSize = 19
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.Te.Size = New System.Drawing.Size(1424, 552)
        Me.Te.StyleInfo = resources.GetString("Te.StyleInfo")
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Te, "Celdas en Rojo muestran Faltante en tela.")
        '
        'Embarques_costura
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.Te)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Embarques_costura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Semanal de Tela según Fecha de Producción."
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        Te.Width = l - 60
        Te.Height = a - 110
        setea_grids()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM PLAN_COSTURA_T ORDER BY CLIENTE", "CLIENTE")
    End Sub

    Private Sub setea_grids()
        Dim i As Integer
        Dim pd As Date
        Dim su(0, 7, 6, 5, 4, 3, 2, 1) As Integer
        Te.Rows.Count = 1
        Te.Rows.Count = 18
        Te.Cols.Count = 19
        Te.Rows(0).Height = 30
        Te.Cols(0).Width = 100
        pd = hoy.AddDays(-dis)
        fei = pd.AddDays(7)
        pd = fei
        Te(0, 1) = UCase(Format(pd, "dd-MMM-yyyy"))
        Te(1, 0) = UCase(Format(pd, "dd-MMM-yyyy"))
        For i = 2 To 15
            pd = pd.AddDays(7)
            Te(0, i) = UCase(Format(pd, "dd-MMM-yyyy"))
            Te(i, 0) = UCase(Format(pd, "dd-MMM-yyyy"))
        Next
        pd = pd.AddDays(1)
        Te(0, 16) = UCase(Format(pd, "dd-MMM-yyyy")) & " < "
        Te(16, 0) = UCase(Format(pd, "dd-MMM-yyyy")) & " <  "
        Te(17, 0) = "COSTURA"
        Te.Rows(17).Style = Te.Styles("amarillo")
        Te.Cols(17).Style = Te.Styles("amarillo")
    End Sub

    Private Sub proceso_principal()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT  PLAN_COSTURA_T.*, F_PROMETIDA ,(SELECT TOP 1 EXP_REV FROM WIP0 WHERE WIP0.CPO = PLAN_COSTURA_T.CPO AND WIP0.ESTILO = PLAN_COSTURA_T.ESTILO AND WIP0.COLOR = PLAN_COSTURA_T.COLOR) AS F_REV FROM PLAN_COSTURA_T LEFT JOIN CPO_D ON PLAN_COSTURA_T.CPO = CPO_D.CPO AND PLAN_COSTURA_T.ESTILO = CPO_D.ESTILO AND PLAN_COSTURA_T.COLOR = CPO_D.COLOR WHERE SECCION <> 'SALDOS' AND CLIENTE = '" & Cliente.Text & "'"
        Dim f As Integer
        Dim c As Integer
        Dim plan As Date
        Dim exp As Date
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            plan = dr("F_PROD")
            Try
                exp = dr("F_REV")
            Catch ex As Exception
                exp = CDate("1900-01-01")
            End Try
            If exp = CDate("1900-01-01") Then
                exp = dr("F_PROMETIDA")
            End If
            determina_columna_tela(fei, exp, 1, 16, c)
            determina_columna_tela(fei, plan, 1, 16, f)
            If plan > CDate("2015-02-01") Then
                Dim JAPA As String = "SS"
            End If
            Te(f, c) = Te(f, c) + dr("PRENDAS")
        Next
        totales()
    End Sub
    Private Sub totales()
        Dim i As Integer
        Dim j As Integer
        For i = 1 To 16
            For j = 1 To 16
                Te(i, 17) = Te(i, 17) + Te(i, j)
                Te(17, j) = Te(17, j) + Te(i, j)
                Te(17, 17) = Te(17, 17) + Te(i, j)
            Next
        Next
    End Sub
    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
        Impri.Visible = True
        Ex.Visible = True
        Cliente.Enabled = False
        Te.Visible = True
        proceso_principal()
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        setea_grids()
    End Sub

    Private Sub limpia_flex()
        Te.Visible = True
    End Sub


    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_te()
    End Sub

    Private Sub Print_te()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String = ""
        fecha = Format(Today, "dd/MM/yyy")
        pd = Te.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        Te.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        Te.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        Te.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, Trim(Cliente.Text) + "    Balance de tela Al : " + fecha + "    " + mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ex.Click
        a_excel(Te, path, ok)
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        End If
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

End Class
