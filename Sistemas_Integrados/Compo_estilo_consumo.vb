Imports C1.Win.C1FlexGrid

Public Class Compo_estilo_consumo
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim nuevo As Boolean
    Dim usuario As String
    Dim empre As New empresas
    Dim estados As String
    Friend WithEvents es As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Dim sep As Char = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
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
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_estilo_consumo))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.es = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(7, 230)
        Me.fg.Margin = New System.Windows.Forms.Padding(2)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(950, 434)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(887, 26)
        Me.graba.Margin = New System.Windows.Forms.Padding(2)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(56, 39)
        Me.graba.TabIndex = 18
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Actualiza Registro.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'es
        '
        Me.es.AllowFiltering = True
        Me.es.ColumnInfo = resources.GetString("es.ColumnInfo")
        Me.es.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.es.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.es.Location = New System.Drawing.Point(7, 3)
        Me.es.Margin = New System.Windows.Forms.Padding(2)
        Me.es.Name = "es"
        Me.es.Rows.DefaultSize = 19
        Me.es.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.es.Size = New System.Drawing.Size(563, 211)
        Me.es.StyleInfo = resources.GetString("es.StyleInfo")
        Me.es.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.es, "Estilos")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 671)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Doble click sobre la fila deseada para cambiar Código de Tela"
        '
        'Compo_estilo_consumo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(979, 689)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.es)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compo_estilo_consumo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comsumo por Estilo - Componente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub compo_estilo_consumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nuevo_dato()
    End Sub
    Private Sub nuevo_dato()
        setea_es()
        llena_es()
        setea_fg()
        Try
            es.RowSel = 1
            llena_fg(es(1, 1), es(1, 2))
        Catch ex As Exception
        End Try
        es.Focus()
    End Sub
    Private Sub setea_es()
        es.Rows.Count = 1
        es.Rows(0).Height = 30
    End Sub
    Private Sub llena_es()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT DISTINCT CLIENTE,ESTILO FROM COMBO_TELA_1 WHERE ESTADO = 'V' ORDER BY CLIENTE,ESTILO"
        llena_tablas(dt, strsql, cnn)
        es.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            es(l, 1) = dr("CLIENTE")
            es(l, 2) = dr("ESTILO")
            l = l + 1
        Next
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_fg(ByVal cliente As String, ByVal estilo As String)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim busca As String
        Dim f As Integer
        Dim strsql As String = "SELECT COMBO_TELA_1.CLIENTE,COMBO_TELA_1.ESTILO,COMBO_TELA_1.COLOR AS COLOR_PRENDA,COMBO_TELA_1.COMPONENTE,COMBO_TELA_1.COLOR_TELA, COMBO_TELA_2.CODIGO,COMBO_TELA_2.LIBRAS FROM COMBO_TELA_1 LEFT JOIN COMBO_TELA_2 ON COMBO_TELA_1.CLIENTE = COMBO_TELA_2.CLIENTE AND COMBO_TELA_1.ESTILO = COMBO_TELA_2.ESTILO AND COMBO_TELA_1.COMPONENTE = COMBO_TELA_2.COMPONENTE WHERE COMBO_TELA_1.CLIENTE = '" & cliente & "' AND COMBO_TELA_1.ESTILO = '" & estilo & "' AND ESTADO = 'V' "
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            busca = dr("COLOR_PRENDA") + dr("COLOR_TELA") + dr("CODIGO")
            f = fg.FindRow(busca, 1, 0, False)
            If f > 0 Then
                Try
                    fg(f, 4) = fg(f, 4) + dr("LIBRAS")
                Catch
                End Try
            Else
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                fg(l, 1) = dr("COLOR_PRENDA")
                fg(l, 2) = dr("COLOR_TELA")
                fg(l, 3) = dr("CODIGO")
                fg(l, 4) = dr("LIBRAS")
                fg(l, 0) = busca
            End If
            l = l + 1
        Next
    End Sub
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        Try
            seguro = MsgBox("Seguro de Querer Grabar Estilo = " & es(es.RowSel, 2) & "?  ", MsgBoxStyle.YesNo, "Actualizando Datos !!")
            If seguro = MsgBoxResult.Yes Then
                graba_registros()
                nuevo_dato()
            End If
        Catch
        End Try
    End Sub
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim obj As New empresas
        Dim i As Integer = es.RowSel
        Dim cliente As String = es(i, 1)
        Dim estilo As String = es(i, 2)

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== CONSUMO_TELA

            For i = 1 To fg.Rows.Count - 1
                Try
                    strSQL = "INSERT INTO CONSUMO_TELA (CLIENTE,ESTILO_CPO,COLOR_CPO,CODIGO,COLOR_TELA,LIBRAS,ACTUALIZADO) VALUES ( '" & cliente & "','" &
                                                                      estilo & "','" &
                                                                      fg(i, 1) & "','" &
                                                                      fg(i, 3) & "','" &
                                                                      fg(i, 2) & "','" &
                                                                      fg(i, 4) & "', " &
                                                                      "getdate() )"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                Catch
                End Try

                strSQL = "UPDATE COMBO_TELA_1 SET ESTADO = 'C' WHERE CLIENTE = '" & cliente & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & fg(i, 1) & "' AND COLOR_TELA = '" & fg(i, 2) & "'"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

            Next

            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub es_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles es.KeyDown
        Dim f As Integer = es.Row

        If e.KeyCode = Keys.Up Then
            f = f - 1
        End If

        If e.KeyCode = Keys.Down Then
            f = f + 1
        End If
        If f > es.Rows.Count - 1 Or f < 1 Then
        Else
            setea_fg()
            llena_fg(es(f, 1), es(f, 2))
        End If

    End Sub

    Private Sub es_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles es.Click
        Dim f As Integer = es.RowSel
        If f > es.Rows.Count - 1 Or f < 1 Then
        Else
            setea_fg()
            llena_fg(es(f, 1), es(f, 2))
        End If
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.DoubleClick
        Dim l As Integer = fg.RowSel
        Dim c As Integer = es.RowSel
        Dim forma As New Compo_estilo_consumo_1
        forma.cliente = es(c, 1)
        forma.color_tela.Text = fg(l, 2)
        forma.Consumo.Text = fg(l, 4).ToString()
        forma.ShowDialog()
        If forma.ok Then

            fg(l, 3) = forma.codigo.Text
        End If
        If forma.Consumo.Text <> fg(1, 4).ToString() Then
            fg(l, 4) = forma.Consumo.Text
        End If
    End Sub

    Private Sub Fg_Click_1(sender As Object, e As EventArgs) Handles fg.Click

    End Sub
End Class
