Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Empaque_estilo
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Dim strSQl As String
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empaque_estilo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.si = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(906, 9)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 65
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 636)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(108, 7)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(256, 28)
        Me.Cliente.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.Cliente, "Lista de Clientes")
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(906, 9)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 68
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(947, 9)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 69
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Empaque_estilo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Empaque_estilo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "No. prendas por Caja según Estilo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub empaque_estilo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_clientes_cpo(Cliente)
        setea_fg()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
    End Sub

    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim i As Integer
        Dim c(11) As Integer
        Dim ancho As Integer
        Dim dr As DataRow
        Dim strSQL As String = "SELECT DISTINCT ESTILOS.ESTILO,ESTILO_EMP.* FROM ESTILOS LEFT JOIN ESTILO_EMP ON ESTILOS.ESTILO = ESTILO_EMP.ESTILO WHERE  CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            For i = 1 To 10
                Try
                    c(i) = dr(i + 1)
                    fg(l, 15) = False
                Catch
                    c(i) = 20
                    fg(l, 15) = True
                End Try
            Next
            Try
                ancho = dr(12)
                fg(l, 12) = dr(12)
                fg(l, 13) = dr(13)
                fg(l, 14) = dr(14)
            Catch
                fg(l, 15) = True
                fg(l, 12) = 0
                fg(l, 13) = 0
                fg(l, 14) = 0
            End Try
            fg(l, 2) = c(1)
            fg(l, 3) = c(2)
            fg(l, 4) = c(3)
            fg(l, 5) = c(4)
            fg(l, 6) = c(5)
            fg(l, 7) = c(6)
            fg(l, 8) = c(7)
            fg(l, 9) = c(8)
            fg(l, 10) = c(9)
            fg(l, 11) = c(10)
            l = l + 1
        Next
    End Sub


    ' ============================== GRABACIONES ======================================
    Private Sub grabacion()
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
                If fg(i, 15) = True Then
                    strSQl = "UPDATE ESTILO_EMP SET XS = " & fg(i, 2) & ",S = " & fg(i, 3) & ",M = " & fg(i, 4) & ",L = " & fg(i, 5) & ",XL = " & fg(i, 6) & ",XL2 = " & fg(i, 7) & ",XL3 = " & fg(i, 8) & ",XL4 = " & fg(i, 9) & ",XL5 = '" & fg(i, 10) & "',XL6 = '" & fg(i, 11) & "',ANCHO = '" & fg(i, 12) & "',LARGO = '" & fg(i, 13) & "', ALTO = '" & fg(i, 14) & "' " & _
                                         " WHERE ESTILO = '" & fg(i, 1) & "'"
                    comando.CommandText = strSQl
                    afectados = comando.ExecuteNonQuery()
                    If afectados = 0 Then
                        strSQl = "INSERT INTO ESTILO_EMP (ESTILO,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,ANCHO,ALTO,LARGO)" & _
                                                        " VALUES ( '" & fg(i, 1) & "'," & _
                                                                       fg(i, 2) & "," & _
                                                                       fg(i, 3) & "," & _
                                                                       fg(i, 4) & "," & _
                                                                       fg(i, 5) & "," & _
                                                                       fg(i, 6) & "," & _
                                                                       fg(i, 7) & "," & _
                                                                       fg(i, 8) & "," & _
                                                                       fg(i, 9) & "," & _
                                                                       fg(i, 10) & "," & _
                                                                       fg(i, 11) & "," & _
                                                                       fg(i, 12) & "," & _
                                                                       fg(i, 13) & "," & _
                                                                       fg(i, 14) & ")"
                        comando.CommandText = strSQl
                        afectados = comando.ExecuteNonQuery()
                    End If
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


    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Cursor = Cursors.WaitCursor
        grabacion()
        Cursor = Cursors.Default
        habilita()
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        fg(r, 15) = True
    End Sub

    Private Sub si_Click(sender As System.Object, e As System.EventArgs) Handles si.Click
        setea_fg()
        llena_fg()
        Cliente.Enabled = False
        si.Visible = False
        Graba.Visible = True
    End Sub

    Private Sub R1_Click(sender As System.Object, e As System.EventArgs) Handles R1.Click
        habilita()
    End Sub
    Private Sub habilita()
        setea_fg()
        Cliente.Enabled = True
        si.Visible = True
        Graba.Visible = False
        Cliente.Focus()
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub
End Class



