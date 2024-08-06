Imports C1.Win.C1FlexGrid

Public Class Corte_status_m
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prendas As System.Windows.Forms.TextBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cortado As System.Windows.Forms.Label
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corte_status_m))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prendas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cortado = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'corte
        '
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.corte.Location = New System.Drawing.Point(145, 19)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(189, 28)
        Me.corte.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.corte, "No. Embarque")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(948, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 97
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(882, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(60, 40)
        Me.S1.TabIndex = 2
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(882, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 91
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(11, 132)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(997, 552)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 32)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Producción:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prendas
        '
        Me.prendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.prendas.Location = New System.Drawing.Point(145, 90)
        Me.prendas.Name = "prendas"
        Me.prendas.Size = New System.Drawing.Size(117, 26)
        Me.prendas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Cortado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cortado
        '
        Me.cortado.BackColor = System.Drawing.Color.White
        Me.cortado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cortado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cortado.ForeColor = System.Drawing.Color.Black
        Me.cortado.Location = New System.Drawing.Point(145, 58)
        Me.cortado.Name = "cortado"
        Me.cortado.Size = New System.Drawing.Size(117, 26)
        Me.cortado.TabIndex = 100
        Me.cortado.Text = " "
        Me.cortado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Corte_status_m
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1023, 696)
        Me.Controls.Add(Me.cortado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.prendas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.corte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Corte_status_m"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia Producción a Cortes"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Cortes_status(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler corte.KeyPress, AddressOf keypressed1
        AddHandler prendas.KeyPress, AddressOf keypressed2
        llena_combos(corte, "SELECT  CORTES.CORTE FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CPO_D.ESTADO = 'A' AND (SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE CORTES.CORTE = PROD_DIARIA.CORTE) IS NULL ORDER BY CORTES.CORTE", "CORTE")
        setea_fg()
        limpia_variables()
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            graba.Focus()
        End If
    End Sub 'keypressed

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Rows(0).Height = 30
        llena_fg()
    End Sub
    Private Sub limpia_variables()
        graba.Visible = False
        S1.Visible = True
        cortado.Text = "0"
        prendas.Text = "0"
        corte.Enabled = True
        prendas.Enabled = False
        corte.Focus()
    End Sub
    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim dr As DataRow
        Dim strsql As String = "SELECT PLAN_COSTURA_C.* , SECCION FROM PLAN_COSTURA_C LEFT JOIN CORTES ON PLAN_COSTURA_C.CORTE = CORTES.CORTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CPO_D.ESTADO = 'A' AND (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE CORTE = PLAN_COSTURA_C.CORTE) = 0"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, "COR") = dr("CORTE")
            fg(l, "SEC") = dr("SECCION")
            fg(l, "PRE") = dr("PRODUCIDAS")
            fg(l, "FCO") = dr("F_COSTURA")
            fg(l, "COM") = dr("COMENTARIOS")
            fg(l, "STA") = dr("STATUS")
            fg(l, "GRA") = False
            l = l + 1
        Next
        fg.Sort(C1.Win.C1FlexGrid.SortFlags.Ascending, 1)
    End Sub
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim fec As String = Format(Today, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try

            strsql = "UPDATE PLAN_COSTURA_C SET PRODUCIDAS = '" & prendas.Text & "' WHERE CORTE  = '" & corte.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO PLAN_COSTURA_C (CORTE,PRIORIDAD,F_COSTURA,PRODUCIDAS,STATUS,COMENTARIOS) " & _
                           "VALUES ( '" & corte.Text & "','" & _
                               99 & "','" & _
                               fec & "','" & _
                               prendas.Text & "','A','')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

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
    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        If prendas.Text > cortado.Text Then
            MsgBox("Lo producido no puede ser mayor a lo cortado", MsgBoxStyle.Critical, "Error en el ingreso de Datos")
            Exit Sub
        End If
        seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_datos()
            corte.Focus()
        End If
        limpia_variables()
    End Sub
    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub

    Private Sub prendas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prendas.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub revisa_corte()
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, "SELECT PLAN_COSTURA_C.*, TOTAL FROM PLAN_COSTURA_C LEFT JOIN CORTES ON PLAN_COSTURA_C.CORTE = CORTES.CORTE WHERE PLAN_COSTURA_C.CORTE = '" & corte.Text & "'", cnn)
        prendas.Text = "0"
        For Each dr In dt.Rows
            prendas.Text = dr("PRODUCIDAS")
            cortado.Text = dr("TOTAL")
        Next
    End Sub

    Private Sub S1_Click(sender As System.Object, e As System.EventArgs) Handles S1.Click
        S1.Visible = False
        graba.Visible = True
        revisa_corte()
        corte.Enabled = False
        prendas.Enabled = True
        prendas.Focus()
    End Sub

    Private Sub R1_Click(sender As System.Object, e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim i As Integer = fg.RowSel
        Dim strsql As String = "SELECT * FROM PLAN_COSTURA_C WHERE CORTE = '" & fg(i, 1) & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            corte.Text = dr("CORTE")
            prendas.Text = dr("PRODUCIDAS")
        Next
        corte.Enabled = False
        prendas.Enabled = True
        prendas.Focus()
    End Sub
End Class

