Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports System.Transactions
Imports System.Data.SqlClient

Public Class Toma_inventar0
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Toma_inventar0))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(1008, 648)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed" & _
        "{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlig" & _
        "ht{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackCol" & _
        "or:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTota" & _
        "l{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackCo" & _
        "lor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeCo" & _
        "lor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{Back" & _
        "Color:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(336, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario de Telas. ")
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.White
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(104, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(168, 21)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Bitmap)
        Me.Button4.Location = New System.Drawing.Point(336, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 52
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.Visible = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Bitmap)
        Me.Graba.Location = New System.Drawing.Point(384, 8)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 66
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Crea registro para toma de inventario.")
        Me.Graba.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(696, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 42)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Un Momento por favor.                                                            " & _
        "   Me encuentro Procesando"
        Me.Label1.Visible = False
        '
        'Toma_inventar0
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1022, 700)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.Graba, Me.C4, Me.fg, Me.Label2, Me.Button1, Me.Button4})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toma_inventar0"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Registro para Toma de Inventario"
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
    Dim StrSQL As String = "SELECT BATCH,CLIENTE,FPO,CPO,KNIT,COLOR,ROLLO,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ACTIVO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'NADA'"

    Private Sub Toma_inventar0_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        llena_clientes(C4)
        Try
            C4.SelectedIndex = 0
        Catch
        End Try
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.DataSource = GetDataSource()
            fg.Cols.Count = 14
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Caption = "CLIENTE"
            fg.Cols(2).Caption = "BATCH"
            fg.Cols(3).Caption = "ROLLO"
            fg.Cols(4).Caption = "FPO"
            fg.Cols(5).Caption = "CPO"
            fg.Cols(6).Caption = "KNIT"
            fg.Cols(7).Caption = "COLOR"
            fg.Cols(8).Caption = "YARDAS"
            fg.Cols(9).Caption = "LIBRAS"
            fg.Cols(10).Caption = "ESTADO"
            fg.Cols(11).Caption = "ANCHO"
            fg.Cols(12).Caption = "CODIGO B."
            fg.Cols(13).Caption = "COSTO"
            fg.Cols(13).Visible = False
            fg.Cols(3).DataType = GetType(Integer)
            fg.Cols(3).Format = g
            fg.Cols(3).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(3).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(8).DataType = GetType(Decimal)
            fg.Cols(8).Format = h
            fg.Cols(8).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(9).DataType = GetType(Decimal)
            fg.Cols(9).Format = h
            fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(9).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(12).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(12).TextAlignFixed = TextAlignEnum.CenterCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 90
                fg(0, index) = fg.Cols(index).Caption
                If index > 7 Then
                    fg.Cols(index).Width = 70
                End If
            Next
            fg.Cols(1).Width = 90
            fg.Cols(2).Width = 80
            fg.Cols(3).Width = 50
            fg.Cols(6).Width = 150
            fg.Cols(7).Width = 150
            fg.Cols(13).Width = 50
            fg.Sort(SortFlags.Ascending, 2, 3)
            fg.Sort(SortFlags.Ascending, 1, 2)
            crea_costo()
            ' subtotales()
        Catch
        End Try
    End Sub

    Private Sub subtotales()
        fg.ScrollBars = ScrollBars.Both
        With fg
            .Redraw = False
            Dim totalya As Integer = fg.Cols("YARDAS").Index
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.LightGray
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
            .Redraw = True
        End With
    End Sub

    Private Sub setea_busqueda()
        If Trim(C4.Text) = "TODOS" Then
            StrSQL = "SELECT CLIENTE,BATCH,ROLLO,FPO,CPO,KNIT,COLOR,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, (SELECT ESTADO_TELA FROM ESTADOS_TELA WHERE ACTIVO = CODIGO) AS ACTIVO, ANCHO, BARRA, COSTO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'TELA'"
        Else
            StrSQL = "SELECT CLIENTE,BATCH,ROLLO,FPO,CPO,KNIT,COLOR,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS,(SELECT ESTADO_TELA FROM ESTADOS_TELA WHERE ACTIVO = CODIGO) AS ACTIVO, ANCHO, BARRA, COSTO FROM ROLLOS WHERE CLIENTE = '" & C4.Text & "' AND YARDAS >0 AND TIPO = 'TELA'"
        End If
        StrSQL = StrSQL + " ORDER BY BATCH "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        Button1.Visible = False
        Graba.Visible = True
        Button4.Visible = True
        C4.Enabled = False
        setea_busqueda()
        setea_grid()
        Cursor = Cursors.Default
    End Sub

    Private Sub crea_costo()
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            fg(i, 13) = fg(i, 13) * fg(i, 9)
        Next
    End Sub

    Private Sub graba_inventario()
        Dim strsql As String
        Dim afectados As Integer
        Dim con0 As New SqlClient.SqlConnection
        Dim con1 As New SqlClient.SqlConnection
        Dim obj As New empresas
        Dim comando As New SqlCommand

        con0.ConnectionString = obj.constr
        con1.ConnectionString = lector_dc()


        con0.ConnectionString = con0.ConnectionString + ";Enlist=False"
        con1.ConnectionString = con1.ConnectionString + ";Enlist=False"

        Try

            Using scope As New TransactionScope()

                Using con0
                    con0.Open()


                    strsql = "DELETE INVENTARIO_TELAS "
                    comando = New SqlCommand(strsql, con0)
                    afectados = comando.ExecuteNonQuery()

                    For i = 1 To fg.Rows.Count - 1
                        strsql = "INSERT INTO INVENTARIO_TELAS (BATCH,ROLLO,BARRA) " & _
                                 "VALUES ( '" & fg(i, 2) & "','" & _
                                                fg(i, 3) & "','" & _
                                                fg(i, 12) & "')"
                        comando = New SqlCommand(strsql, con0)
                        afectados = comando.ExecuteNonQuery()
                    Next

                    Using con1
                        con1.Open()

                        strsql = "DELETE INVENTARIO_TELAS "
                        comando = New SqlCommand(strsql, con1)
                        afectados = comando.ExecuteNonQuery()

                        For i = 1 To fg.Rows.Count - 1
                            strsql = "INSERT INTO INVENTARIO_TELAS (ROLLO,ESTADO) " & _
                                     "VALUES ( '" & fg(i, 12) & "','N')"
                            comando = New SqlCommand(strsql, con1)
                            afectados = comando.ExecuteNonQuery()
                        Next
                    End Using
                End Using

                scope.Complete()
                MsgBox("Actualización efectuada con Exito !!!", MsgBoxStyle.Information, "Transaccion Realizada !!!!")
            End Using

        Catch ex As TransactionAbortedException
            MsgBox("Error en la Grabacion" + ex.Message, MsgBoxStyle.Critical, "Por favor Revise !!!!")
        Finally
            con0.Close()
            con1.Close()
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Function GetDataSource() As DataTable
        Dim dt As New DataTable()
        llena_tablas(dt, StrSQL, cnn)
        def_sql(cnn)
        GetDataSource = dt
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        otra_busqueda()
    End Sub

    Private Sub otra_busqueda()
        Graba.Visible = False
        Button4.Visible = False
        Button1.Visible = True
        C4.Enabled = True
        StrSQL = "SELECT CLIENTE,BATCH,ROLLO,FPO,CPO,KNIT,COLOR,YARDAS,(PESO/YARDAS_I)*YARDAS AS LIBRAS, ACTIVO,COSTO FROM ROLLOS WHERE YARDAS >0 AND TIPO = 'NADA'"
        setea_grid()
    End Sub

    Private Sub fg_aftersort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles fg.AfterSort
        subtotales()
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim fecha As String = Format(Today, "MM-dd-yyyy")
        Cursor = Cursors.WaitCursor
        graba_inventario()
        Close()
    End Sub
End Class
