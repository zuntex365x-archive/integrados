Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Estado_m
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim STRSQL As String
    Dim Estados As String
    Dim tot_estados As Integer
    Dim j() As String
    Dim es As New DataTable
    Dim fj As String = "('0','5','7','8','9','A','B','S')"
  
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents client As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estado_m))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.client = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CLIENTE:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(320, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione aqui para ver los Rollos del Batch")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(386, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(60, 40)
        Me.CANCELA.TabIndex = 46
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operaci�n y limpiar todos los datos sin" &
        " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(320, 16)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(60, 40)
        Me.GRABA.TabIndex = 47
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'client
        '
        Me.client.BackColor = System.Drawing.Color.White
        Me.client.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client.ForeColor = System.Drawing.Color.Black
        Me.client.Location = New System.Drawing.Point(8, 24)
        Me.client.MaxLength = 20
        Me.client.Name = "client"
        Me.client.Size = New System.Drawing.Size(248, 28)
        Me.client.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.client, "Batch de Tela")
        '
        'fg
        '
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 72)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(968, 592)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        '
        'Estado_m
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 668)
        Me.Controls.Add(Me.client)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GRABA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estado_m"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualiza el Estado de los rollos de Tela"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Estado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler client.KeyPress, AddressOf keypressed1
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        Estado_Tela()
        llena_clientes_cpo(client)
        limpia_variables()
    End Sub


    Private Sub limpia_variables()
        client.Enabled = True
        Button1.Visible = True
        CANCELA.Visible = False
        GRABA.Visible = False
        setea_grid()
        client.Focus()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear(ClearFlags.Style)
        fg.Rows.Count = 1
        fg.Cols.Count = 13
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "TIPO"
        fg.Cols(4).Name = "KNIT"
        fg.Cols(5).Name = "COLOR"
        fg.Cols(6).Name = "FPO"
        fg.Cols(7).Name = "CPO"
        fg.Cols(8).Name = "YARDAS"
        fg.Cols(9).Name = "ESTADO"
        fg.Cols(10).Name = "CODIGO"
        fg.Cols(11).Name = "DESCRIPCION"
        Dim c As Column = fg.Cols(9)
        c.ComboList = Estados
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 90
            fg(0, index) = fg.Cols(index).Name
            If index = 8 Then
                fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                fg.Cols(index).Format = h
            End If
            fg.Cols(index).AllowEditing = False
        Next
        fg.Cols(1).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(1).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(1).Width = 80
        fg.Cols(2).Width = 70
        fg.Cols(4).Width = 120
        fg.Cols(5).Width = 200
        fg.Cols(9).Width = 110
        fg.Cols(11).Width = 250
        j = Split(Estados, "|"c)
        fg.Cols(9).AllowEditing = True
        fg.Cols(12).Visible = False
    End Sub


    Private Sub llena_Grid(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        ok = True
        STRSQL = "SELECT * FROM ROLLOS LEFT JOIN ROLLOS_E ON ROLLOS.BATCH = ROLLOS_E.BATCH AND ROLLOS.ROLLO = ROLLOS_E.ROLLO LEFT JOIN ESTADOS_TELA ON ROLLOS_E.ESTADO = ESTADOS_TELA.CODIGO LEFT JOIN CODIGO_TELA ON ROLLOS.CODIGO = CODIGO_TELA.CODIGO WHERE YARDAS > 0 AND CLIENTE = '" & client.SelectedItem & "' ORDER BY ROLLOS.BATCH,ROLLOS.ROLLO"
        llena_tablas(dt, STRSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        i = 1
        For Each dr In dt.Rows
            fg(i, 1) = dr("BATCH")
            fg(i, 2) = dr("ROLLO")
            fg(i, 3) = dr("TIPO")
            fg(i, 4) = dr("KNIT")
            fg(i, 5) = dr("COLOR")
            fg(i, 6) = dr("FPO")
            fg(i, 7) = dr("CPO")
            fg(i, 8) = dr("YARDAS")
            If IsDBNull(dr("ESTADO_TELA")) Then
                fg(i, 9) = "Buen Estado"
                fg(i, 12) = "Buen Estado"
            Else
                fg(i, 9) = dr("ESTADO_TELA")
                fg(i, 12) = dr("ESTADO_TELA")
            End If
            fg(i, 10) = dr("CODIGO")
            fg(i, 11) = dr("DESCRIPCION")
            i = i + 1
        Next
        If dt.Rows.Count = 0 Then
            ok = False
        End If
    End Sub

    Private Sub batch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles client.KeyPress
        AutoCompletar(client, e)
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(client.Text) <> "" Then
                Button1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ok As Boolean
        setea_grid()
        llena_Grid(ok)
        If ok Then
            client.Enabled = False
            Button1.Visible = False
            CANCELA.Visible = True
            GRABA.Visible = True
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Cancelar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Cancela Cambios !!!")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            actualiza_batch()
        End If
    End Sub

    Private Sub Estado_Tela()
        es = New DataTable
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM ESTADOS_TELA ORDER BY CODIGO"
        llena_tablas(es, strSQL, cnn)
        For Each dr In es.Rows
            Estados = Estados + dr("ESTADO_TELA") + "|"
        Next
    End Sub

    Private Sub actualiza_batch()
        Dim estado As String
        Dim afectados As Integer
        Dim i As Integer
        Dim r As Integer = fg.Rows.Count - 1
        Dim obj As New empresas
        Dim tb As String = "05789AB"

        cnn.Open()
        ' Comienza la transacci�n
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacci�n
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To r
                estado = d_estado(es, fg(i, 9))
                If fg(i, 9) <> fg(i, 12) Then
                    STRSQL = "UPDATE ROLLOS_E SET ESTADO = " & "'" & estado & "'" &
                                         " WHERE BATCH = '" & fg(i, 1) & "' AND ROLLO = '" & fg(i, 2) & "' "
                    comando.CommandText = STRSQL
                    afectados = comando.ExecuteNonQuery()
                    If afectados = 0 Then
                        STRSQL = "INSERT INTO ROLLOS_E (BATCH,ROLLO,ESTADO) VALUES ('" & fg(i, 1) & "','" & fg(i, 2) & "','" & estado & "')"
                        comando.CommandText = STRSQL
                        afectados = comando.ExecuteNonQuery()
                    End If


                    STRSQL = "INSERT INTO ESTADOS_V (BATCH,ROLLO,USUARIO,FECHA,ESTADO_ACTUAL,NUEVO_ESTADO) VALUES ('" &
                             fg(i, 1) & "','" & fg(i, 2) & "','" & obj.usuario & "',GETDATE(),'" & fg(i, 12) & "','" & fg(i, 9) & "')"

                    comando.CommandText = STRSQL
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
                    MsgBox("Ocurri� un error de tipo " & ex.GetType().ToString() &
                                      " se gener� cuando se trato de eliminar la transacci�n.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
        limpia_variables()

    End Sub

    Private Sub client_SelectedIndexChanged(sender As Object, e As EventArgs) Handles client.SelectedIndexChanged

    End Sub
End Class
