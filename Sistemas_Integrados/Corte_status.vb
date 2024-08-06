Imports C1.Win.C1FlexGrid

Public Class Corte_status
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents empresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Dim dr As DataRow
    Dim cs As New Lib_SI.util
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corte_status))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.empresa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(948, 3)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 91
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.fg.Location = New System.Drawing.Point(11, 60)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(997, 624)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
        '
        'empresa
        '
        Me.empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empresa.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.empresa.Location = New System.Drawing.Point(128, 19)
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(303, 28)
        Me.empresa.TabIndex = 93
        Me.ToolTip1.SetToolTip(Me.empresa, "No. Embarque")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Empresa:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Corte_status
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1023, 696)
        Me.Controls.Add(Me.empresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Corte_status"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia status a Cortes"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cortes_status(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.DragMode = DragModeEnum.AutomaticCopy
        fg.DropMode = DropModeEnum.Automatic
        empresa.SelectedIndex = 0
        setea_fg()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Rows(0).Height = 30
        llena_fg()
    End Sub
    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim dr As DataRow
        Dim strsql As String = "SELECT PLAN_COSTURA_C.* , SECCION,TOTAL FROM PLAN_COSTURA_C LEFT JOIN CORTES ON PLAN_COSTURA_C.CORTE = CORTES.CORTE  WHERE (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE CORTE = PLAN_COSTURA_C.CORTE) = 0"
        llena_tablas_e(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, "COR") = dr("CORTE")
            fg(l, "SEC") = dr("SECCION")
            fg(l, "PRE") = dr("TOTAL")
            fg(l, "FCO") = dr("F_COSTURA")
            fg(l, "COM") = dr("COMENTARIOS")
            fg(l, "STA") = dr("STATUS")
            fg(l, "GRA") = False
            l = l + 1
        Next
    End Sub
    Private Sub graba_datos()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            For i = 1 To fg.Rows.Count - 1
                If fg(i, "GRA") = True Then
                    strsql = "UPDATE PLAN_COSTURA_C SET STATUS = '" & fg(i, "STA") & "' WHERE CORTE  = '" & fg(i, "COR") & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next
            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
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
    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        If fg.Col < fg.Cols.IndexOf("STA") Then
            Exit Sub
        End If
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.Insert, Keys.C
                    'copy
                    System.Windows.Forms.Clipboard.SetDataObject(fg.Clip, True)
                    Exit Select
                Case Keys.X
                    'cut
                    System.Windows.Forms.Clipboard.SetDataObject(fg.Clip)
                    Dim rg As CellRange = fg.Selection
                    rg.Data = Nothing
                    Exit Select
                Case Keys.V 'paste
                    Dim data1 As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
                    If data1.GetDataPresent(Type.GetType("System.String")) Then
                        fg.Select(fg.Row, fg.Col, fg.Rows.Count - 1, fg.Cols.Count - 1, False)
                        fg.Clip = CType(data1.GetData(Type.GetType("System.String")), String)

                        fg.Select(fg.Row, fg.Col, False)
                    End If
            End Select
        End If
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_datos()
            Close()
        End If
    End Sub
    Private Sub fg_grabar(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim l As Integer = e.Row
        fg(l, "GRA") = True
    End Sub

    Private Sub empresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        AutoCompletar(empresa, e)
    End Sub

    Private Sub empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empresa.SelectedIndexChanged
        cnn.ConnectionString = cs.con_string(empresa.SelectedIndex)
        setea_fg()
    End Sub
End Class

