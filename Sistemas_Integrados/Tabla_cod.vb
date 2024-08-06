Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Tabla_cod
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strSQl As String
    Dim lineas As Integer
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tabla_cod))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "8,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAli" & _
        "gn:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed:" & _
        "LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Left" & _
        "Center;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter;" & _
        "TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(24, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(976, 636)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{Font:Microsoft Sans Serif, 8.25" & _
        "pt, style=Bold;BackColor:85, 240, 186;ForeColor:Black;Border:Flat,1,ControlDark," & _
        "Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:218, 215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:218, " & _
        "215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{BackColor:218, 215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Sear" & _
        "ch{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow" & _
        "{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTo" & _
        "tal{Font:Microsoft Sans Serif, 9pt, style=Bold;BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 9pt, style=Bold;BackColor:Black;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 11.25pt, style=Bold;BackColor:186, " & _
        "196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDa" & _
        "rk;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subto" & _
        "tal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDark" & _
        "Dark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "c1{Font:Microsoft Sans Serif, 9.75pt;BackColor:129, 192, " & _
        "239;Border:None,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "amarillo{BackColor:248, 250, 177;Border:Inset,1,B" & _
        "lack,Both;}" & Microsoft.VisualBasic.ChrW(9) & "verde{BackColor:173, 233, 215;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:PaleGoldenrod;Border:" & _
        "Raised,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "c2{BackColor:129, 192, 239;Border:Inset,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "c3{" & _
        "BackColor:209, 223, 241;Border:None,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "c4{BackColor:209, 223, 241;Bo" & _
        "rder:Inset,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.fg, "Si desea eliminar presione la tecla (Del)  o  (Supr)")
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Bitmap)
        Me.Graba.Location = New System.Drawing.Point(944, 8)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 65
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(896, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 66
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Agregar otra línea")
        '
        'Tabla_cod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.fg, Me.Graba})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tabla_cod"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de Codigos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        def_sql(cnn)
        setea_fg()
        llena_fg()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 7
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Cols(1).Name = "COD."
        fg.Cols(2).Name = "FABRIC"
        fg.Cols(3).Name = "WEIGHT"
        fg.Cols(4).Name = "CONTENID"
        fg.Cols(5).Name = "FIBER"
        fg.Cols(6).Visible = False
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 220
            fg(0, index) = fg.Cols(index).Name
            fg.Cols(index).AllowEditing = True
        Next
        fg.Cols(1).AllowEditing = False
        fg.Cols(1).Width = 70
        fg.Cols(1).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub llena_fg()
        Dim dr As DataRow
        Dim i As Integer
        strSQl = "SELECT * FROM MAESTRO_TELA ORDER BY ORDEN"
        llena_tablas(dt, strSQl, cnn)
        i = dt.Rows.Count
        fg.Rows.Count = i + 1
        i = 1
        For Each dr In dt.Rows
            fg(i, 1) = dr("ORDEN")
            fg(i, 2) = dr("FABRIC")
            fg(i, 3) = dr("WEIGHT")
            fg(i, 4) = dr("CONTENID")
            fg(i, 5) = dr("FIBER")
            i = i + 1
        Next
    End Sub


    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        If e.KeyCode = Keys.Delete Then
            fg(f, c) = Nothing
            fg(f, 6) = "X"
        End If
    End Sub

    ' ============================== GRABACIONES ======================================
    Private Sub grabacion()
        Dim i As Integer
        Dim afectados As Integer
        Dim graba As New SqlClient.SqlCommand()
        Dim ok As Boolean
        i = fg.Rows.Count - 1
        If fg(i, 2) & fg(i, 3) & fg(i, 4) & fg(i, 5) = Nothing Then
            fg.Rows.Count = i - 1
        End If
        cnn.Open()
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 6) = "X" Then
                ok = False
                strSQl = "UPDATE MAESTRO_TELA SET FABRIC = '" & fg(i, 2) & "',WEIGHT = '" & fg(i, 3) & "',CONTENID = '" & fg(i, 4) & "',FIBER = '" & fg(i, 5) & "' WHERE ORDEN = '" & fg(i, 1) & "'"
                graba = New SqlCommand(strSQl, cnn)

                afectados = graba.ExecuteNonQuery()
                If afectados = 0 Then
                    strSQl = "INSERT INTO MAESTRO_TELA (ORDEN,FABRIC,WEIGHT,CONTENID,FIBER) " & _
                                                    "VALUES ( '" & fg(i, 1) & "','" & _
                                                                   fg(i, 2) & "','" & _
                                                                   fg(i, 3) & "','" & _
                                                                   fg(i, 4) & "','" & _
                                                                   fg(i, 5) & "')"
                    graba = New SqlCommand(strSQl, cnn)
                    afectados = graba.ExecuteNonQuery()
                End If
            End If
        Next
        cnn.Close()
    End Sub


    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Cursor = Cursors.WaitCursor
        revisa_grid()
        grabacion()
        cambia_descripciones()
        Cursor = Cursors.Default
        Close()
    End Sub

    Private Sub revisa_grid()
        Dim i As Integer
        Dim j As Integer
        Dim texto As String
        For i = 1 To fg.Rows.Count - 1
            For j = 2 To 5
                Try
                    texto = fg(i, j)
                    If texto.Length > 30 Then
                        texto = Mid(texto, 1, 30)
                    End If
                    fg(i, j) = texto.ToUpper
                Catch
                End Try
            Next
        Next
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        fg(r, 6) = "X"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim l As Integer = fg.Rows.Count - 1
        If Trim(fg(l, 2) & fg(l, 3) & fg(l, 4) & fg(l, 5)) <> "" Then
            agrega_linea()
        Else
            MsgBox("La última línea aun esta libre", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If
    End Sub

    Private Sub agrega_linea()
        Dim l As Integer = fg.Rows.Count
        fg.Rows.Count = l + 1
        fg(l, 1) = Format(l, "00")
    End Sub

    Private Sub cambia_descripciones()
        Dim dr As DataRow
        Dim de As New DataTable
        Dim codigo As String
        Dim desc As String
        Dim desc1 As String = ""
        Dim ok As Boolean
        llena_tablas(de, "SELECT * FROM CODIGO_TELA ORDER BY CODIGO", cnn)
        For Each dr In de.Rows
            desc = dr("DESCRIPCION")
            codigo = dr("CODIGO")
            crea_descripcion(codigo, desc1, ok)
            If ok And desc <> desc1 Then
                actualiza_codigo(codigo, desc1)
            End If
        Next
    End Sub

    Private Sub crea_descripcion(ByVal codigo As String, ByRef desc As String, ByRef ok As Boolean)
        Dim i As Integer
        Dim j As Integer
        Dim l As Integer
        desc = ""
        If codigo.Length = 8 Then
            Try
                For i = 1 To codigo.Length Step 2
                    l = (i + 1) / 2
                    j = Int(Mid(codigo, i, 2))
                    If j > 0 Then
                        desc = desc & Trim(fg(j, l + 1)) & " "
                    Else
                        If Int(Mid(codigo, 1, 2)) < 90 Then
                            ok = False
                            Exit Sub
                        End If
                    End If
                Next
                desc = Trim(desc)
                ok = True
            Catch
                ok = False
            End Try
        Else
            ok = False
        End If
    End Sub


    Private Sub actualiza_codigo(ByVal codigo As String, ByVal desc As String)
        Dim afectados As Integer
        Dim graba As New SqlClient.SqlCommand()
        strSQl = "UPDATE CODIGO_TELA SET DESCRIPCION = '" & desc & "' WHERE CODIGO = '" & codigo & "'"
        cnn.Open()
        graba = New SqlCommand(strSQl, cnn)
        afectados = graba.ExecuteNonQuery()
        cnn.Close()
    End Sub
End Class



