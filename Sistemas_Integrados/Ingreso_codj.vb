Imports C1.Win.C1FlexGrid


Public Class Ingreso_codj
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Dim ct As New DataTable()
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Elimi As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Cod_tela As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Descrip As System.Windows.Forms.Label
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_codj))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Elimi = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Cod_tela = New System.Windows.Forms.TextBox()
        Me.Descrip = New System.Windows.Forms.Label()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 96)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1005, 560)
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
        Me.R1.Location = New System.Drawing.Point(800, 16)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(120, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(664, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Descripción de la Tela"
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
        'Elimi
        '
        Me.Elimi.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimi.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimi.ForeColor = System.Drawing.Color.Black
        Me.Elimi.Image = CType(resources.GetObject("Elimi.Image"), System.Drawing.Image)
        Me.Elimi.Location = New System.Drawing.Point(931, 16)
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
        Me.Graba.Location = New System.Drawing.Point(866, 16)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(60, 40)
        Me.Graba.TabIndex = 50
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'Cod_tela
        '
        Me.Cod_tela.BackColor = System.Drawing.Color.White
        Me.Cod_tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_tela.Location = New System.Drawing.Point(24, 35)
        Me.Cod_tela.MaxLength = 8
        Me.Cod_tela.Name = "Cod_tela"
        Me.Cod_tela.Size = New System.Drawing.Size(88, 21)
        Me.Cod_tela.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.Cod_tela, "Codigo de la Tela JT")
        '
        'Descrip
        '
        Me.Descrip.BackColor = System.Drawing.Color.White
        Me.Descrip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Descrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrip.ForeColor = System.Drawing.Color.Black
        Me.Descrip.Location = New System.Drawing.Point(120, 35)
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Size = New System.Drawing.Size(664, 21)
        Me.Descrip.TabIndex = 52
        Me.Descrip.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Descrip, "Descripción de la Tela")
        '
        'fj
        '
        Me.fj.AllowEditing = False
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fj.Location = New System.Drawing.Point(9, 128)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 21
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fj.Size = New System.Drawing.Size(992, 496)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.fj, "Area de Datos.")
        Me.fj.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Descrip)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.Graba)
        Me.GroupBox2.Controls.Add(Me.Elimi)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Cod_tela)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1005, 80)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Codigo Tela"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ingreso_codj
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 696)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fj)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_codj"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Códigos de Tela"
        Me.ToolTip1.SetToolTip(Me, "Maestro de Códigos de Tela")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cod_tela.KeyPress, AddressOf keypressed1
        llena_maestro()
        limpia_variables()
        setea_grid()
        llena_grid()
    End Sub

    Private Sub limpia_variables()
        Descrip.Text = ""
        Cod_tela.Text = ""
        Cod_tela.Enabled = True
        Graba.Visible = False
        Elimi.Visible = False
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 3
        fg.Cols(0).Width = 5
        fg.Cols(1).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CODIGO"
        fg.Cols(2).Name = "DESCRIPCION DE LA TELA"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 625
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(1).TextAlign = ImageAlignEnum.CenterCenter
        fg.Cols(1).TextAlignFixed = ImageAlignEnum.CenterCenter
        fg.Cols(1).Width = 200
        fg.Cols(2).Width = 725
    End Sub

    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim s As Integer
        Dim strSQL As String = "SELECT * FROM CODIGO_TELA ORDER BY CODIGO "
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        s = dt.Rows.Count
        fg.Rows.Count = fg.Rows.Count + s
        For Each dr In dt.Rows
            fg(l, 1) = dr("CODIGO")
            fg(l, 2) = dr("DESCRIPCION")
            l = l + 1
        Next dr
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            Cod_tela.Text = fg(fil, 1)
            Descrip.Text = fg(fil, 2)
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
        Dim strSQL As String = "SELECT * FROM CODIGO_TELA WHERE CODIGO = '" & Cod_tela.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            crea_descripcion(Cod_tela.Text, Descrip.Text, ok)
            If Not ok Then
                MsgBox("CODIGO MAL DEFINIDO !!!!", MsgBoxStyle.Critical, "POR FAVOR REVISE !!!")
                Cod_tela.Focus()
                Exit Sub
            End If
        Else
            For Each dr In dt.Rows
                Cod_tela.Text = dr("CODIGO")
                Descrip.Text = dr("DESCRIPCION")
            Next dr
        End If
        habilita()
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cod_tela.Text) <> "" Then
                busca_codigo()
            End If
        End If
    End Sub


    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        If Trim(Descrip.Text) <> "" Then
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
        Dim busca As String = Trim(Cod_tela.Text)
        lin = fg.FindRow(busca, 1, 1, True)
        If lin > 0 Then
            fg.Rows.Remove(lin)
        End If
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer
        Dim busca As String = Trim(Cod_tela.Text)
        lin = fg.FindRow(busca, 1, 1, True)
        llena_lineas(lin)
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 1) = Cod_tela.Text
            fg(lineas, 2) = Descrip.Text
        Catch
        End Try
    End Sub

    Private Sub Elimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimi.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            '  pre_eliminacion()
        End If
    End Sub

    Private Sub pre_eliminacion()
        Dim ok As Boolean
        revisa_fpo(Cod_tela.Text, ok)
        If ok Then
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
        Cod_tela.Focus()
    End Sub

    Private Sub habilita()
        Cod_tela.Enabled = False
        Graba.Visible = True
        Elimi.Visible = True
        Graba.Focus()
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cod_tela.Text = ""
        Cod_tela.Focus()
    End Sub

    Private Sub llena_maestro()
        Dim dr As DataRow
        Dim i As Integer
        Dim dt As New DataTable()
        Dim strSQl As String = "SELECT * FROM MAESTRO_TELA ORDER BY ORDEN"
        llena_tablas(dt, strSQl, cnn)
        i = dt.Rows.Count
        fj.Rows.Count = i + 1
        i = 1
        For Each dr In dt.Rows
            fj(i, 1) = CStr(Format(i, "00"))
            fj(i, 2) = dr("FABRIC")
            fj(i, 3) = dr("WEIGHT")
            fj(i, 4) = dr("CONTENID")
            fj(i, 5) = dr("FIBER")
            i = i + 1
        Next
    End Sub

    Private Sub crea_descripcion(ByVal codigo As String, ByRef desc As String, ByRef ok As Boolean)
        Dim i As Integer
        Dim j As Integer
        Dim l As Integer
        desc = ""
        If codigo.Length = 8 Then
            Try
                For i = 1 To codigo.Length Step 2
                    l = (i + 1) / 2
                    j = Int(Mid(codigo, i, 2))
                    If j > 0 Then
                        desc = desc & Trim(fj(j, l + 1)) & " "
                    Else
                        If Int(Mid(codigo, 1, 2)) > 89 Then
                        Else
                            ok = False
                            Exit Sub
                        End If
                    End If
                Next
                desc = Trim(desc)
                ok = True
            Catch
                ok = False
            End Try
        Else
            ok = False
        End If
    End Sub

    Private Sub revisa_fpo(ByVal codigo As String, ByVal ok As Boolean)
        Dim fp As New DataTable
        Dim strsql As String = "SELECT * FROM FPO WHERE CODIGO = '" & codigo & "'"
        llena_tablas(fp, strsql, cnn)
        Try
            If fp.Rows.Count = 0 Then
                ok = True
            Else
                ok = False
            End If
        Catch
        End Try
        If Not ok Then
            MsgBox("No se puede eliminar el Codigo.  Tiene fpos que lo utilizan", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
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
              strSQL = "UPDATE CODIGO_TELA SET DESCRIPCION = " & "'" & Descrip.Text & "' " & _
                           " WHERE CODIGO  = '" & Cod_tela.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
              strSQL = "INSERT INTO CODIGO_TELA (CODIGO,DESCRIPCION) " & _
                       "VALUES ( '" & Cod_tela.Text & "','" & Descrip.Text & "')"
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
            strsql = "DELETE FROM CODIGO_TELA WHERE CODIGO  = '" & Cod_tela.Text & "' "
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
