Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Asigna_rollos_Stock
    Inherits System.Windows.Forms.Form
    Dim lineas As Integer
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim estados As New ComboBox()
    Dim nec As Integer
    Dim StrSQL As String = "SELECT BATCH, ROLLO, FPO, KNIT, COLOR, FPO, CPO,ESTADO_TELA AS ESTADO,ANCHO, PESO AS LIBRAS, ROLLOS.CODIGO, DESCRIPCION FROM ROLLOS LEFT JOIN ESTADOS_TELA ON ACTIVO = ESTADOS_TELA.CODIGO LEFT JOIN CODIGO_TELA ON ROLLOS.CODIGO = CODIGO_TELA.CODIGO WHERE YARDAS >0 "

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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Stock As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents si As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Asigna_rollos_Stock))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Stock = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1174, 632)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(920, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 75
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Salir sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Stock
        '
        Me.Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Stock.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock.ForeColor = System.Drawing.Color.Black
        Me.Stock.Image = CType(resources.GetObject("Stock.Image"), System.Drawing.Image)
        Me.Stock.Location = New System.Drawing.Point(880, 8)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(35, 35)
        Me.Stock.TabIndex = 80
        Me.Stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Stock, "Presione este Boton para Grabar todos los Rollos escogidos en el Stock ")
        Me.Stock.UseVisualStyleBackColor = False
        Me.Stock.Visible = False
        '
        'C4
        '
        Me.C4.BackColor = System.Drawing.Color.White
        Me.C4.ForeColor = System.Drawing.Color.Black
        Me.C4.Location = New System.Drawing.Point(88, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(248, 24)
        Me.C4.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
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
        Me.si.TabIndex = 2
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Cliente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Asigna_rollos_Stock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1194, 696)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Asigna_rollos_Stock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asigna Rollos al Stock "
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlstr As String = "SELECT DISTINCT CLIENTE FROM ROLLOS WHERE YARDAS >0 ORDER BY CLIENTE "
        AddHandler C4.KeyPress, AddressOf keypressed1
        llena_combos(C4, sqlstr, "CLIENTE")
        If C4.Items.Count > 0 Then
            C4.SelectedIndex = 0
        End If
        setea_fg()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 13
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "KNIT"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "FPO"
        fg.Cols(6).Name = "CPO"
        fg.Cols(7).Name = "ESTADO"
        fg.Cols(8).Name = "ANCHO"
        fg.Cols(9).Name = "LIBRAS"
        fg.Cols(10).Name = "STOCK"
        fg.Cols(11).Name = "CODIGO"
        fg.Cols(12).Name = "DESCRIPCION"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 85
            fg(0, index) = fg.Cols(index).Name
            fg.Cols(index).AllowEditing = False
            If index = 9 Then
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = "######0.00"
                fg.Cols(index).Width = 80
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(2).Width = 50
        fg.Cols(3).Width = 130
        fg.Cols(4).Width = 170
        fg.Cols(5).Width = 60
        fg.Cols(6).Width = 105
        fg.Cols(2).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(2).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(10).Name = "RESERVAR"
        fg.Cols(10).DataType = GetType(Boolean)
        fg.Cols(10).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(10).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(10).AllowEditing = True
        fg.Cols(10).Width = 80
        fg.Cols(11).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(11).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(11).Width = 70
        fg.Cols(12).Width = 300
    End Sub

    '=============================================== Inventario ================================================

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        setea_fg()
        C4.Enabled = True
        Stock.Visible = False
        R1.Visible = False
        si.Visible = True
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(C4.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de colocar estos rollos en el Stock?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_stock()
        End If
        Close()
    End Sub

    Private Sub graba_stock()
        Dim strsql As String
        Dim afectados As Integer
        Dim i As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                If fg(i, 10) = True Then
                    strsql = "UPDATE ROLLOS SET CPO = " & "'Stock'" & _
                             "WHERE BATCH = '" & fg(i, 1) & "' AND ROLLO = '" & fg(i, 2) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

            transaccion.Commit()

        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try

    End Sub


    Private Sub llena_grid()
        Dim DATO As String
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, StrSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            DATO = dr("BATCH")
            fg(lineas, 2) = dr("ROLLO")
            fg(lineas, 3) = dr("KNIT")
            fg(lineas, 4) = dr("COLOR")
            fg(lineas, 5) = dr("FPO")
            fg(lineas, 6) = dr("CPO")
            fg(lineas, 7) = dr("ESTADO")
            fg(lineas, 8) = dr("ANCHO")
            fg(lineas, 9) = dr("LIBRAS")
            fg(lineas, 11) = dr("CODIGO")
            fg(lineas, 12) = dr("DESCRIPCION")
            lineas = lineas + 1
        Next
    End Sub



    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        StrSQL = "SELECT BATCH, ROLLO, FPO, KNIT, COLOR, FPO, CPO,ESTADO_TELA AS ESTADO,ANCHO, PESO AS LIBRAS, ROLLOS.CODIGO, DESCRIPCION FROM ROLLOS LEFT JOIN ESTADOS_TELA ON ACTIVO = ESTADOS_TELA.CODIGO LEFT JOIN CODIGO_TELA ON ROLLOS.CODIGO = CODIGO_TELA.CODIGO WHERE YARDAS >0 AND CLIENTE = '" & C4.Text & "'"
        setea_fg()
        llena_grid()
        C4.Enabled = False
        si.Visible = False
        R1.Visible = True
        Stock.Visible = True
    End Sub


    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub
End Class



