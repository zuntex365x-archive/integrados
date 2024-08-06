Imports C1.Win.C1FlexGrid

Public Class Compo_autoriza
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim nuevo As Boolean
    Dim usuario As String
    Dim empre As New empresas
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Dim estados As String
    Dim filtro As New ConditionFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_autoriza))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 343)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1016, 329)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(870, 12)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 18
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Actualiza Registro.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'jg
        '
        Me.jg.AllowFiltering = True
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.AutoGenerateColumns = False
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(8, 41)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 19
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(729, 296)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.jg, "Area de Datos.")
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.cliente.Location = New System.Drawing.Point(111, 13)
        Me.cliente.MaxLength = 20
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(268, 21)
        Me.cliente.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.cliente, "Lista de Clientes")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(870, 13)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(60, 40)
        Me.si.TabIndex = 63
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar todos los Cortes del Cliente Seleccionado")
        Me.si.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(936, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 64
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para regresar a Seleccionar Documentos.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Compo_autoriza
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compo_autoriza"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verifica Componentes por Estilo -  Color de la Prenda"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Compo_autoriza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM COMBO_TELA_1 WHERE ESTADO <> 'V' ORDER BY CLIENTE", "CLIENTE")
        setea_jg()
        setea_fg()
        Try
            filtro.Condition1.Operator = ConditionOperator.Contains
            jg.Cols(2).Filter = filtro
            jg.ApplyFilters()
        Catch
        End Try

    End Sub
    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
        Try
            filtro.Condition1.Operator = ConditionOperator.Contains
            jg.Cols(2).Filter = filtro
            jg.ApplyFilters()
        Catch
        End Try
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_jg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT DISTINCT CLIENTE+ESTILO+COLOR ,CLIENTE,ESTILO,COLOR FROM COMBO_TELA_1 WHERE ESTADO <> 'V' AND CLIENTE = '" & cliente.Text & "'"
        llena_tablas(dt, strsql, cnn)
        jg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            jg(l, 1) = dr("CLIENTE")
            jg(l, 2) = dr("ESTILO")
            jg(l, 3) = dr("COLOR")
            jg(l, 4) = False
            l = l + 1
        Next
    End Sub
    Private Sub llena_fg() Handles jg.RowColChange
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim f As Integer = jg.RowSel
        Try
            Dim strsql As String = "SELECT * FROM COMBO_TELA_1 WHERE CLIENTE = '" & jg(f, 1) & "' AND ESTILO = '" & jg(f, 2) & "' AND COLOR = '" & jg(f, 3) & "'"
            llena_tablas(dt, strsql, cnn)
            fg.Rows.Count = dt.Rows.Count + 1
            For Each dr In dt.Rows
                fg(l, 1) = dr("ESTILO")
                fg(l, 2) = dr("COLOR")
                fg(l, 3) = dr("COMPONENTE")
                fg(l, 4) = dr("COLOR_TELA")
                fg(l, 5) = dr("DM")
                fg(l, 6) = dr("CODIGO")
                l = l + 1
            Next
        Catch
        End Try

    End Sub

    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim obj As New empresas
        Dim i As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== Graba Color

            For i = 1 To jg.Rows.Count - 1
                If jg(i, 4) = True Then
                    strSQL = "UPDATE COMBO_TELA_1  SET ESTADO = 'V', VERIFICADO_POR = '" & obj.usuario & "' , FECHA_VERIF = getdate()  WHERE CLIENTE = '" & jg(i, 1) & "' AND ESTILO = '" & jg(i, 2) & "' AND COLOR = '" & jg(i, 3) & "'"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If

            Next

            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub graba_Click(sender As System.Object, e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        Dim segurolas As MsgBoxResult
        Try
            seguro = MsgBox("Esta Seguro de querer autorizar los Componentes?  " + vbLf + "Una vez autorizados no se podrán revertir!!!", MsgBoxStyle.YesNo, "Actualizando Datos !!")
            If seguro = MsgBoxResult.Yes Then
                segurolas = MsgBox("Está completamente Seguro de Autorizar los Componentes?", MsgBoxStyle.YesNo, "Actualizando Componentes !!")
                If segurolas = MsgBoxResult.Yes Then
                    graba_registros()
                    Close()
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub si_Click(sender As System.Object, e As System.EventArgs) Handles si.Click
        setea_jg()
        setea_fg()
        llena_jg()
        Try
            jg.RowSel = 1
            llena_fg()
        Catch
        End Try
        si.Visible = False
        cliente.Enabled = False
        jg.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        filtro.Condition1.Clear()
        jg.Cols(2).Filter = filtro
        jg.ApplyFilters()
        setea_jg()
        setea_fg()
        si.Visible = True
        cliente.Enabled = True
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
End Class
