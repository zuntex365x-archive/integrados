Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Imports System.Transactions
Imports System.Data.SqlClient

Public Class Prod_T07
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim estados As New ComboBox()
    Friend WithEvents embarque As System.Windows.Forms.TextBox
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Friend WithEvents graba As System.Windows.Forms.Button
    Public tsd As New DataTable()

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prod_T07))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.sigue = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.embarque = New System.Windows.Forms.TextBox()
        Me.graba = New System.Windows.Forms.Button()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.cliente.Location = New System.Drawing.Point(155, 4)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(364, 28)
        Me.cliente.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.cliente, "No. Embarque")
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(1148, 15)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 105
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Chequeo de Datos")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(1216, 15)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 107
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'Co
        '
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Co.ColumnInfo = resources.GetString("Co.ColumnInfo")
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(8, 338)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1288, 430)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 46
        '
        'fg
        '
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 67)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1288, 253)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Cliente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Embarque:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'embarque
        '
        Me.embarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.embarque.Location = New System.Drawing.Point(155, 35)
        Me.embarque.MaxLength = 15
        Me.embarque.Name = "embarque"
        Me.embarque.Size = New System.Drawing.Size(364, 26)
        Me.embarque.TabIndex = 103
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(1148, 15)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 106
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Prod_T07
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 792)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.embarque)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Co)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_T07"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Listas de Empaque ( Segundas )"
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cliente.KeyPress, AddressOf keypressed1
        AddHandler embarque.KeyPress, AddressOf keypressed2
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM PROD_TER01 WHERE TIPO = 'S' AND ESTADO = 'A' ORDER BY CLIENTE ", "CLIENTE")
        setea_fg()
        setea_co()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub setea_co()
        Co.Rows.Count = 1
        Co.Rows(0).Height = 30
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                embarque.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(embarque.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub

    Private Sub sigue_Click(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        If Trim(embarque.Text) = "" Then
            MsgBox("El nombre del embarque no puede ir en blanco", MsgBoxStyle.Critical, "Por favor revise !!!")
            Exit Sub
        End If
        cliente.Enabled = False
        embarque.Enabled = False
        graba.Visible = True
        sigue.Visible = False
        llena_fg()
        fg.Focus()
    End Sub


    Private Sub llena_fg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT CPO,ESTILO,COLOR,PROD_TER01.CORTE AS CORTE , SUM(UNIDADES) FROM PROD_TER01 LEFT JOIN CORTES ON PROD_TER01.CORTE = CORTES.CORTE WHERE TIPO = 'S' AND ESTADO = 'A' GROUP BY CPO,ESTILO,COLOR,PROD_TER01.CORTE ORDER BY CPO,ESTILO,COLOR,PROD_TER01.CORTE"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CPO")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("CORTE")
            fg(l, 5) = 0
            fg(l, 6) = False
            l = l + 1
        Next
    End Sub

    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit
        If e.Col = 6 Then
            If fg(e.Row, e.Col) = True Then
                quita(e.Row)
                fg(e.Row, 6) = False
            Else
                crea(e.Row)
                fg(e.Row, 6) = True
            End If
        End If
    End Sub

    Private Sub crea(ByVal fila As Integer)
        Dim corte As String = fg(fila, 4)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = Co.Rows.Count
        Dim strsql As String = "SELECT * FROM PROD_TER01 LEFT JOIN CORTES ON PROD_TER01.CORTE = CORTES.CORTE WHERE PROD_TER01.CORTE = '" & corte & "' AND TIPO = 'S' AND ESTADO = 'A' AND CAJA NOT IN (SELECT CAJA FROM PROD_TER01 WHERE CORTE = '" & corte & "' AND TIPO = 'P') ORDER BY CAJA"
        llena_tablas(dt, strsql, cnn)
        Co.Rows.Count = Co.Rows.Count + dt.Rows.Count
        For Each dr In dt.Rows
            Co(l, 1) = dr("CPO")
            Co(l, 2) = dr("ESTILO")
            Co(l, 3) = dr("COLOR")
            Co(l, 4) = dr("CORTE")
            Co(l, 5) = dr("CAJA")
            Co(l, 6) = dr("TALLA")
            Co(l, 7) = dr("UNIDADES")
            Co(l, 8) = True
            fg(fila, 5) = fg(fila, 5) + dr("UNIDADES")
            l = l + 1
        Next
    End Sub

    Private Sub quita(ByVal fila As Integer)
        Dim existe As Boolean = True
        Dim corte As String = fg(fila, 4)
        Dim f As Integer
        While existe
            f = Co.FindRow(corte, 1, 4, False)
            If f > 0 Then
                Co.Rows.Remove(f)
            Else
                existe = False
            End If
        End While
        fg(fila, 5) = 0
    End Sub

    Private Sub co_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles Co.ValidateEdit
        If e.Col = 8 Then
            Dim corte As String = Co(e.Row, 4)
            Dim f As Integer = fg.FindRow(corte, 1, 4, False)
            If f > 0 Then
                If Co(e.Row, e.Col) = True Then
                    fg(f, 5) = fg(f, 5) - Co(e.Row, 7)
                    Co(e.Row, 8) = False
                Else
                    fg(f, 5) = fg(f, 5) + Co(e.Row, 7)
                    Co(e.Row, 8) = True
                End If
            End If
        End If
    End Sub

    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        setea_fg()
        setea_co()
        sigue.Visible = True
        cliente.Enabled = True
        embarque.Enabled = True
        embarque.Text = ""
        cliente.Focus()
    End Sub

    Private Sub graba_Click(sender As System.Object, e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            If Co.Rows.Count > 1 Then
                graba_datos()
                Close()
            End If
        Else
            MsgBox("Aún no ha ingresado unidades a la nueva Caja", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If

    End Sub
    Private Sub cliente_key(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub
    '============================= Actualiza la Base de Datos =============================
    Private Sub graba_datos()
        Dim strsql As String = ""
        Dim afectados As Integer
        Dim emp As New empresas

        Dim cnn1 As String = ""
        Dim cnn2 As String = ""
        cnn1 = emp.constr + ";Enlist=False"
        cnn2 = lector_dc() + ";Enlist=False"

        Try
            Using scope As New TransactionScope()
                Using connection1 As New SqlConnection(cnn1)

                    connection1.Open()

                    Dim command1 As SqlCommand = New SqlCommand(strsql, connection1)

                    For i = 1 To Co.Rows.Count - 1
                        If Co(i, 8) = True Then
                            strsql = "INSERT INTO PROD_TER04 (EMBARQUE,CAJA,TALLA,CLIENTE,FECHA,UNIDADES,ESTADO) VALUES ('" & _
                                                           embarque.Text & "','" & _
                                                           Co(i, 5) & "','" & _
                                                           Co(i, 6) & "','" & _
                                                           cliente.Text & "',GETDATE(),'" & _
                                                           Co(i, 7) & "','A')"

                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()


                            strsql = "UPDATE PROD_TER01 SET ESTADO = 'P' WHERE CAJA = '" & Co(i, 5) & "'"
                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()
                        End If
                    Next

                    Using connection2 As New SqlConnection(cnn2)
                        connection2.Open()

                        Dim command2 As SqlCommand = New SqlCommand(strsql, connection2)

                        For i = 1 To Co.Rows.Count - 1
                            If Co(i, 8) = True Then
                                Try
                                    strsql = "INSERT INTO EMB01 (EMPRESA,EMBARQUE,CAJA,LEIDA) VALUES ('" & _
                                                             emp.numero & "','" & _
                                                             embarque.Text & "','" & _
                                                             Co(i, 5) & "','N')"
                                    command2.CommandText = strsql
                                    afectados = command2.ExecuteNonQuery()
                                Catch
                                End Try
                            End If
                        Next

                    End Using
                End Using

                ' The Complete method commits the transaction. If an exception has been thrown,
                ' Complete is called and the transaction is rolled back.
                scope.Complete()
            End Using
        Catch ex As TransactionAbortedException
            MsgBox("TransactionAbortedException Message: {0}" & ex.Message, MsgBoxStyle.Critical, "")
        Catch ex As ApplicationException
            MsgBox("ApplicationException Message: {0}" & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub


End Class



