Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Imprime_etiqueta_m
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim constr(2) As String
    Dim lineas As Integer
    Dim abrear As New OpenFileDialog()
    Dim archivo As String
    Dim o As String = "0|2|3|8|5|12|6|7|4|11|9|10|0"
    Dim f(10) As String
    Dim e(2) As String
    Dim cd As New DataTable()
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Imp As System.Windows.Forms.Button
    Dim dm(3) As String
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
    Friend WithEvents Abre As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fp As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprime_etiqueta_m))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Abre = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Imp = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1183, 681)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.fg, "Detalle del Manifiesto")
        '
        'fp
        '
        Me.fp.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fp.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fp.BackColor = System.Drawing.Color.White
        Me.fp.ColumnInfo = resources.GetString("fp.ColumnInfo")
        Me.fp.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fp.ForeColor = System.Drawing.Color.Black
        Me.fp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fp.Location = New System.Drawing.Point(12, 185)
        Me.fp.Name = "fp"
        Me.fp.Rows.DefaultSize = 19
        Me.fp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fp.Size = New System.Drawing.Size(760, 448)
        Me.fp.StyleInfo = resources.GetString("fp.StyleInfo")
        Me.fp.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fp.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.fp, "Para Eliminar la fila  Presione  Doble-Click")
        Me.fp.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(163, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este boton para buscar el archivo a  actualizar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Abre
        '
        Me.Abre.Filter = "Text Files (.csv)|.csv"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Seleccione archivo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Imp
        '
        Me.Imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Imp.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imp.ForeColor = System.Drawing.Color.Black
        Me.Imp.Image = CType(resources.GetObject("Imp.Image"), System.Drawing.Image)
        Me.Imp.Location = New System.Drawing.Point(163, 8)
        Me.Imp.Name = "Imp"
        Me.Imp.Size = New System.Drawing.Size(60, 40)
        Me.Imp.TabIndex = 51
        Me.Imp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Imp.UseVisualStyleBackColor = False
        Me.Imp.Visible = False
        '
        'Imprime_etiqueta_m
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1203, 668)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Imp)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Imprime_etiqueta_m"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprime etiquetas del Manifiesto"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 130
        fg.Width = Me.Width - 30
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        abrear.InitialDirectory = "c:\texpasa"
        abrear.FileName = "Despacho*.*"
        ok = True
        If abrear.ShowDialog = DialogResult.OK Then
            Try
                Cursor = Cursors.WaitCursor
                archivo = abrear.FileName
                lee_texto()
                If ok Then
                    Imp.Visible = True
                    Button1.Visible = False
                Else
                    MessageBox.Show("Aun existen registros inconsistentes.", "Por favor revise !!!", MessageBoxButtons.OK)
                End If
            Catch
            End Try
            Cursor = Cursors.Default
        Else
            MessageBox.Show("Aun no se ha seleccionado el archivo a utilizar", "No se selecciono archivo", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub lee_texto()
        Dim sr As New StreamReader(archivo)
        Dim lineast As String
        Dim l As Integer
        Dim i As Integer
        Dim ln(12) As String
        Dim co(12) As String
        Dim sep As String = "|"
        Dim busca As String = ""
        co = Split(o, sep)
        fg.Rows.Count = 9001
        l = 0
        Try
            lineast = sr.ReadLine
            If lineast.IndexOf(sep) = -1 Then
                sep = vbTab
            End If
            Do
                lineast = sr.ReadLine()
                If lineast <> Nothing Then
                    If lineast.Length > 0 Then
                        lineast = lineast + sep
                        l = l + 1
                        ln = Split(lineast, sep)
                        For i = 1 To 12
                            If i < 9 Or i > 9 Then
                                fg(l, i) = ln(co(i))
                                If i = 12 Then
                                    If ln(0) = "0064" Then
                                        fg(l, i) = 1
                                    ElseIf ln(0) = "0340" Then
                                        fg(l, i) = 3
                                    Else
                                        fg(l, i) = 2
                                    End If
                                End If
                                If i = 9 Then
                                    fg(l, 9) = False
                                End If
                            End If
                        Next
                    End If
                End If
            Loop Until lineast Is Nothing
        Catch E As Exception
        End Try
        sr.Close()
        fg.Rows.Count = l + 1

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setea_grid()
    End Sub

    Private Sub determina_tipo(ByVal codigo As String, ByRef tipo As String)
        If UCase(Mid(codigo, 1, 4)) = "PUNO" Then
            tipo = "PUÑOS"
        ElseIf UCase(Mid(codigo, 1, 6)) = "CUELLO" Then
            tipo = "CUELLOS"
        Else
            tipo = "TELA"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Imp.Click
        imprime_etiquetas()
        Close()
    End Sub


    Private Sub imprime_etiquetas()
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 9) = True Then
                imprime_etiquetas_tela(fg(i, 12), fg(i, 3), fg(i, 4), fg(i, 6), fg(i, 7), fg(i, 8), fg(i, 11), fg(i, 10), Nothing)
            End If
        Next
    End Sub
End Class
