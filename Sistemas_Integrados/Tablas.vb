Imports C1.Win.C1FlexGrid

Public Class Tablas
    Inherits System.Windows.Forms.Form
    Dim fila As Integer
    Dim codigo As String
    Dim lineas As Integer
    Dim cns As New SqlClient.SqlConnection()
    Dim dr As DataRow
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
    Friend WithEvents tc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents c3 As System.Windows.Forms.Button
    Friend WithEvents g3 As System.Windows.Forms.Button
    Friend WithEvents knit As System.Windows.Forms.TextBox
    Friend WithEvents kn As System.Windows.Forms.Label
    Friend WithEvents kg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tablas))
        Me.tc = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.kg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.c3 = New System.Windows.Forms.Button()
        Me.g3 = New System.Windows.Forms.Button()
        Me.knit = New System.Windows.Forms.TextBox()
        Me.kn = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tc.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.kg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc
        '
        Me.tc.Controls.Add(Me.TabPage3)
        Me.tc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tc.Location = New System.Drawing.Point(0, 0)
        Me.tc.Name = "tc"
        Me.tc.SelectedIndex = 0
        Me.tc.ShowToolTips = True
        Me.tc.Size = New System.Drawing.Size(688, 560)
        Me.tc.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.kg)
        Me.TabPage3.Controls.Add(Me.c3)
        Me.TabPage3.Controls.Add(Me.g3)
        Me.TabPage3.Controls.Add(Me.knit)
        Me.TabPage3.Controls.Add(Me.kn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(680, 531)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Knits"
        '
        'kg
        '
        Me.kg.AllowEditing = False
        Me.kg.ColumnInfo = resources.GetString("kg.ColumnInfo")
        Me.kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.kg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.kg.Location = New System.Drawing.Point(0, 70)
        Me.kg.Name = "kg"
        Me.kg.Rows.DefaultSize = 19
        Me.kg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.kg.Size = New System.Drawing.Size(665, 458)
        Me.kg.StyleInfo = resources.GetString("kg.StyleInfo")
        Me.kg.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.kg, "Presione Doble click para eliminar la línea seleccionada.")
        '
        'c3
        '
        Me.c3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.c3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.ForeColor = System.Drawing.Color.Black
        Me.c3.Image = CType(resources.GetObject("c3.Image"), System.Drawing.Image)
        Me.c3.Location = New System.Drawing.Point(605, 16)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(60, 40)
        Me.c3.TabIndex = 23
        Me.c3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.c3, "Presione este Boton para Cancelar toda la operación. ")
        Me.c3.UseVisualStyleBackColor = False
        '
        'g3
        '
        Me.g3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g3.ForeColor = System.Drawing.Color.Black
        Me.g3.Image = CType(resources.GetObject("g3.Image"), System.Drawing.Image)
        Me.g3.Location = New System.Drawing.Point(539, 16)
        Me.g3.Name = "g3"
        Me.g3.Size = New System.Drawing.Size(60, 40)
        Me.g3.TabIndex = 22
        Me.g3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.g3, "Presione este Boton para Grabar / Actualizar el  Cliente.")
        Me.g3.UseVisualStyleBackColor = False
        '
        'knit
        '
        Me.knit.BackColor = System.Drawing.Color.White
        Me.knit.Location = New System.Drawing.Point(88, 16)
        Me.knit.MaxLength = 50
        Me.knit.Name = "knit"
        Me.knit.Size = New System.Drawing.Size(360, 22)
        Me.knit.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.knit, "Ingrese aquí el Código del Cliente")
        '
        'kn
        '
        Me.kn.Location = New System.Drawing.Point(16, 16)
        Me.kn.Name = "kn"
        Me.kn.Size = New System.Drawing.Size(72, 24)
        Me.kn.TabIndex = 20
        Me.kn.Text = "Knit:"
        '
        'Tablas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 572)
        Me.Controls.Add(Me.tc)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tablas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablas del Sistema"
        Me.tc.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.kg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tablas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler knit.KeyPress, AddressOf keypressed5
        limpia_variables2()
        setea_kg()
    End Sub

    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc.Click
        Select Case tc.SelectedIndex
            Case 0
                limpia_variables2()
        End Select
    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox(var, MsgBoxStyle.Exclamation, "REVISE LOS DATOS!!!! ")
    End Sub
    '===================================  KNITS  ======================================
    Private Sub setea_kg()
        Dim index As Integer
        kg.Clear()
        kg.Rows.Count = 1
        kg.Cols.Count = 2
        kg.Cols(0).Width = 5
        kg.Rows(0).Height = 30
        Dim c As Column = kg.Cols(1)
        kg.Cols(1).Name = "KNIT"
        For index = 1 To kg.Cols.Count - 1
            kg.Cols(index).Width = 600
            kg(0, index) = kg.Cols(index).Name
        Next
        llena_knits()
    End Sub

    Private Sub llena_knits()
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM KNITS "
        llena_tablas(dt, strSQL, cns)
        lineas = 1
        kg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            kg(lineas, 1) = dr("KNIT")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub busca_knits(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM KNITS WHERE KNIT = '" & knit.Text & "'"
        llena_tablas(dt, strSQL, cns)
        ok = False
        For Each Me.dr In dt.Rows
            ok = True
            knit.Text = dr("KNIT")
        Next
    End Sub

    Private Sub limpia_variables2()
        knit.Text = ""
        knit.ReadOnly = False
        g3.Visible = False
        knit.Focus()
    End Sub

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim si As Boolean
            If Trim(knit.Text) <> "" Then
                busca_knits(si)
                If si Then
                    knit.ReadOnly = True
                End If
                g3.Visible = True
                g3.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub G3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g3.Click
        If Trim(knit.Text) = "" Then
            mensaje("Por favor ingrese datos en la casilla de Knit !!!")
            Exit Sub
        End If
        graba_knits()
        setea_kg()
        limpia_variables2()
    End Sub

    Private Sub graba_knits()
        Dim afectados As Integer
        Dim strSQL As String
        strSQL = "UPDATE KNITS SET KNIT = " & "'" & knit.Text & "'" & _
                             " WHERE KNIT = '" & knit.Text & "'"
        grabar_sql(strSQL, cns, afectados)
        If afectados = 0 Then
            strSQL = "INSERT INTO KNITS (KNIT) " & _
                     "VALUES ( '" & knit.Text & "')"
            grabar_sql(strSQL, cns, afectados)
        End If
    End Sub

    Private Sub E3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina2()
            setea_kg()
            limpia_variables2()
        End If
    End Sub

    Private Sub elimina2()
        Dim afectados As Integer
        Dim strSQL As String
        strSQL = "DELETE FROM KNITS WHERE KNIT = '" & knit.Text & "'"
        grabar_sql(strSQL, cns, afectados)
    End Sub

    Private Sub kg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kg.Click
        fila = kg.RowSel
        seleccion2(fila)
    End Sub

    Private Sub seleccion2(ByVal fil As Integer)
        If fil > 0 And fil < kg.Rows.Count Then
            knit.Text = kg(fil, 1)
            knit.ReadOnly = True
            g3.Visible = True
            c3.Focus()
        End If
    End Sub

    Private Sub c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.Click
        limpia_variables2()
    End Sub


End Class
