Imports C1.Win.C1FlexGrid

Public Class Ingreso_codt
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim cnn1 As New System.Data.SqlClient.SqlConnection()
    Dim da As System.Data.SqlClient.SqlDataAdapter
    Dim ct As New DataTable()
    Dim cx As New DataTable()
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Elimi As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Descrip As System.Windows.Forms.TextBox
    Friend WithEvents Codte As System.Windows.Forms.TextBox
    Friend WithEvents Cod_tela As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Desc_tela As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_codt))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Descrip = New System.Windows.Forms.TextBox()
        Me.Elimi = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Codte = New System.Windows.Forms.TextBox()
        Me.Cod_tela = New System.Windows.Forms.TextBox()
        Me.Desc_tela = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 160)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 496)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(656, 13)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(418, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Codigo Texpasa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(424, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Descripción Texpasa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'Descrip
        '
        Me.Descrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrip.Location = New System.Drawing.Point(8, 120)
        Me.Descrip.MaxLength = 60
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Size = New System.Drawing.Size(424, 21)
        Me.Descrip.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Descrip, "Descripcion de la tela de Texpasa")
        '
        'Elimi
        '
        Me.Elimi.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimi.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimi.ForeColor = System.Drawing.Color.Black
        Me.Elimi.Image = CType(resources.GetObject("Elimi.Image"), System.Drawing.Image)
        Me.Elimi.Location = New System.Drawing.Point(788, 14)
        Me.Elimi.Name = "Elimi"
        Me.Elimi.Size = New System.Drawing.Size(60, 40)
        Me.Elimi.TabIndex = 51
        Me.Elimi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimi, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Elimi.UseVisualStyleBackColor = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(722, 13)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(60, 40)
        Me.Graba.TabIndex = 50
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'Codte
        '
        Me.Codte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codte.Location = New System.Drawing.Point(6, 32)
        Me.Codte.MaxLength = 60
        Me.Codte.Name = "Codte"
        Me.Codte.Size = New System.Drawing.Size(418, 21)
        Me.Codte.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Codte, "Codigo de la Tela")
        '
        'Cod_tela
        '
        Me.Cod_tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_tela.Location = New System.Drawing.Point(440, 120)
        Me.Cod_tela.MaxLength = 8
        Me.Cod_tela.Name = "Cod_tela"
        Me.Cod_tela.Size = New System.Drawing.Size(88, 21)
        Me.Cod_tela.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.Cod_tela, "Codigo de la Tela JT")
        '
        'Desc_tela
        '
        Me.Desc_tela.BackColor = System.Drawing.Color.White
        Me.Desc_tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc_tela.ForeColor = System.Drawing.Color.Black
        Me.Desc_tela.Location = New System.Drawing.Point(536, 120)
        Me.Desc_tela.MaxLength = 50
        Me.Desc_tela.Name = "Desc_tela"
        Me.Desc_tela.ReadOnly = True
        Me.Desc_tela.Size = New System.Drawing.Size(464, 21)
        Me.Desc_tela.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.Desc_tela, "Descripción de la Tela JT")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Codte)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.Graba)
        Me.GroupBox2.Controls.Add(Me.Elimi)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(992, 80)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(440, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Codigo Tela"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ingreso_codt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Desc_tela)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cod_tela)
        Me.Controls.Add(Me.Descrip)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_codt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de  Catálogo de Tela"
        Me.ToolTip1.SetToolTip(Me, "Ingreso de  Catálogo de Tela")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Codte.KeyPress, AddressOf keypressed1
        AddHandler Descrip.KeyPress, AddressOf keypressed2
        AddHandler Cod_tela.KeyPress, AddressOf keypressed3
        limpia_variables()
        setea_grid()
        llena_grid()
    End Sub

    Private Sub limpia_variables()
        Codte.Enabled = True
        Descrip.Enabled = False
        Cod_tela.Enabled = False
        Graba.Visible = False
        Elimi.Visible = False
        Codte.Text = ""
        Descrip.Text = ""
        Cod_tela.Text = ""
        Desc_tela.Text = ""
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 5
        fg.Cols(0).Width = 5
        fg.Cols(1).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CODIGO TEXPASA"
        fg.Cols(2).Name = "DESCRIPCION TEXPASA"
        fg.Cols(3).Name = "CODIGO TELA"
        fg.Cols(4).Name = "DESCRIPCION DE LA TELA"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 275
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(2).Width = 300
        fg.Cols(3).Width = 70
        fg.Cols(4).Width = 300
    End Sub

    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim s As Integer
        Dim strSQL As String = "SELECT CATALOGO.*,CODIGO_TELA.DESCRIPCION AS DESCR FROM CATALOGO LEFT JOIN CODIGO_TELA ON CATALOGO.CODIGO_T = CODIGO_TELA.CODIGO ORDER BY CODIGO_TELA"
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn1)
        s = dt.Rows.Count
        fg.Rows.Count = fg.Rows.Count + s
        For Each dr In dt.Rows
            fg(l, 1) = dr("CODIGO_TELA")
            fg(l, 2) = dr("DESCRIPCION")
            fg(l, 3) = dr("CODIGO_T")
            Try
                fg(l, 4) = dr("DESCR")
            Catch
                fg(l, 4) = " "
            End Try
            l = l + 1
        Next
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            Codte.Text = fg(fil, 1)
            Descrip.Text = fg(fil, 2)
            Try
                Cod_tela.Text = fg(fil, 3)
                Desc_tela.Text = fg(fil, 4)
            Catch
            End Try
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    Private Sub busca_codigo()
        Dim l As Integer = 1
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM CATALOGO WHERE CODIGO_TELA = '" & Codte.Text & "'"
        llena_tablas(dt, strSQL, cnn1)
        For Each dr In dt.Rows
            Codte.Text = dr("CODIGO_TELA")
            Descrip.Text = dr("DESCRIPCION")
        Next dr
        habilita()
        Descrip.Focus()
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Codte.Text) <> "" Then
                busca_codigo()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Descrip.Text) <> "" Then
                Cod_tela.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cod_tela.Text) <> "" Then
                busca_tela(ok)
                If ok Then
                    Graba.Focus()
                Else
                    Cod_tela.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub busca_tela(ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String
        ok = False
        strsql = "SELECT * FROM CODIGO_TELA WHERE CODIGO = '" & Cod_tela.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            Desc_tela.Text = dr("DESCRIPCION")
            ok = True
        Else
            Desc_tela.Text = ""
            MsgBox("Codigo Inexistente !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If

    End Sub
    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        busca_tela(ok)
        If ok Then
            graba_registro()
            limpia_variables()
        Else
            MsgBox("Error en los Datos", MsgBoxStyle.Critical, "Por favor verifique !!!")
        End If
    End Sub

    Private Sub agrega_linea()
        Dim lin As Integer = fg.Rows.Count
        fg.Rows.Count = lin + 1
        llena_lineas(lin)
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub elimina_linea()
        Dim lin As Integer
        Dim busca As String = Trim(Codte.Text)
        lin = fg.FindRow(busca, 1, 1, True)
        If lin > 0 Then
            fg.Rows.Remove(lin)
        End If
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer
        Dim busca As String = Trim(Codte.Text)
        lin = fg.FindRow(busca, 1, 1, True)
        llena_lineas(lin)
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 1) = Codte.Text
            fg(lineas, 2) = Descrip.Text
            fg(lineas, 3) = Cod_tela.Text
            fg(lineas, 4) = Desc_tela.Text
        Catch
        End Try
    End Sub

    Private Sub Elimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimi.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
            limpia_variables()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        habilita()
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
        Codte.Focus()
    End Sub

    Private Sub habilita()
        Codte.Enabled = False
        Descrip.Enabled = True
        Cod_tela.Enabled = True
        Graba.Visible = True
        Elimi.Visible = True
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Codte.Text = ""
        Codte.Focus()
    End Sub

    Private Sub codigos()
        llena_tablas(ct, "SELECT * FROM CODIGO_TELA ORDER BY CODIGO", cnn1)
    End Sub

   

    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE CATALOGO SET DESCRIPCION = " & "'" & Descrip.Text & "'," & _
                             " CODIGO_T  = '" & Cod_tela.Text & "'" & _
                             " WHERE CODIGO_TELA = '" & Codte.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CATALOGO (CODIGO_TELA,DESCRIPCION,CODIGO_T) " & _
                      "VALUES ( '" & Codte.Text & "','" & Descrip.Text & "','" & Cod_tela.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

            MsgBox("Grabación Exitosa !!!!", MsgBoxStyle.Information, "Actualización de Datos")

            setea_grid()
            llena_grid()
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

    Private Sub elimina()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CATALOGO WHERE CODIGO_TELA = '" & Codte.Text & "' "
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            elimina_linea()

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

End Class
