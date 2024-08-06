Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Reimprime_etiqueta
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents clase As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reimprime_etiqueta))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.clase = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 632)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(721, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(639, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario de Telas. ")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.White
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(384, 19)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(228, 21)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(680, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 52
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'clase
        '
        Me.clase.BackColor = System.Drawing.Color.White
        Me.clase.ForeColor = System.Drawing.Color.Black
        Me.clase.Items.AddRange(New Object() {"Cliente", "Ubicación"})
        Me.clase.Location = New System.Drawing.Point(61, 19)
        Me.clase.Name = "clase"
        Me.clase.Size = New System.Drawing.Size(186, 21)
        Me.clase.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.clase, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Reimprime_etiqueta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 684)
        Me.Controls.Add(Me.clase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reimprime_etiqueta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Imprime Stickers"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim E(7) As String
    Dim obj As empresas
    Dim ok As Boolean
    Dim fe As New DataTable
    Dim StrSQL As String = "SELECT  DISTINCT  BATCH, FECHA FROM DMOVTO WHERE TMOVTO = '1' AND BATCH IN(SELECT BATCH FROM ROLLOS WHERE YARDAS > 0) ORDER BY FECHA "

    Private Sub Tela_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 130
        fg.Width = Me.Width - 30
        ok = puedo_imprimir()
        If Not ok Then
            Close()
        End If
        Try
            clase.SelectedIndex = 0
        Catch
        End Try
        setea_grid()
        Try
            C4.SelectedIndex = 0
        Catch
        End Try
        llena_tablas(fe, StrSQL, cnn)
    End Sub

    Private Sub setea_grid()
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.Rows.Count = 1
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim i As Integer
        llena_tablas(dt, StrSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            For i = 0 To 11
                fg(l, i + 1) = dr(i)
            Next
            fg(l, 13) = False
            l = l + 1
        Next

    End Sub

    Private Sub setea_busqueda()
        If clase.SelectedIndex = 0 Then
            StrSQL = "SELECT ROLLOS.BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,YFIBER,ROLLOS.ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS,  VIEJO, ROLLOS.BARRA FROM ROLLOS  WHERE CLIENTE = '" & C4.Text & "' AND YARDAS >0 AND TIPO = 'TELA'"
        Else
            StrSQL = "SELECT ROLLOS.BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,YFIBER,ROLLOS.ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS,  VIEJO, ROLLOS.BARRA FROM ROLLOS  WHERE VIEJO = '" & C4.Text & "' AND YARDAS >0 AND TIPO = 'TELA'"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        Button1.Visible = False
        Button2.Visible = True
        Button4.Visible = True
        C4.Enabled = False
        clase.Enabled = False
        Estado.Enabled = False
        setea_busqueda()
        setea_grid()
        llena_grid()
        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim obj As New empresas
        Dim pd As New PrintDocument()
        Dim pdlg As New Windows.Forms.PrintDialog()


        pd.PrinterSettings = New PrinterSettings()
        pd.PrinterSettings.PrinterName = pd.PrinterSettings.PrinterName

        pdlg.Document = pd
        If pdlg.ShowDialog() = DialogResult.OK Then
            pd.PrinterSettings.PrinterName = pdlg.PrinterSettings.PrinterName
            pd.Print()

        End If
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 13) = True Then
                imprime_etiquetas_tela(obj.numero, fg(i, 1), fg(i, 8), fg(i, 5), fg(i, 6), fg(i, 12), fg(i, 9), fg(i, 10), pd)
            End If
        Next
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button2.Visible = False
        Button4.Visible = False
        Button1.Visible = True
        C4.Enabled = True
        clase.Enabled = True
        setea_grid()
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles clase.SelectedIndexChanged
        If clase.SelectedIndex = 0 Then
            llena_combos(C4, "SELECT DISTINCT CLIENTE FROM ROLLOS WHERE YARDAS > 0 AND TIPO = 'TELA' ORDER BY CLIENTE", "CLIENTE")
        Else
            llena_combos(C4, "SELECT DISTINCT VIEJO FROM ROLLOS WHERE LEN(VIEJO) > 0 AND YARDAS > 0 AND TIPO = 'TELA' ORDER BY VIEJO", "VIEJO")
        End If
        Label2.Text = clase.SelectedItem
    End Sub
End Class
