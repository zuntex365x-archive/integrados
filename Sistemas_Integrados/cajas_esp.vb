Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class cajas_esp
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents mas As System.Windows.Forms.Button
    Friend WithEvents correcto As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cajas_esp))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.G1 = New System.Windows.Forms.Button()
        Me.gr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.mas = New System.Windows.Forms.Button()
        Me.correcto = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(848, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 81
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Grabacion de la Lista de empaque.")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'gr
        '
        Me.gr.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.gr.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.gr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.gr.ColumnInfo = resources.GetString("gr.ColumnInfo")
        Me.gr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.gr.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.gr.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.gr.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.gr.Location = New System.Drawing.Point(8, 400)
        Me.gr.Name = "gr"
        Me.gr.Rows.Count = 100
        Me.gr.Rows.DefaultSize = 22
        Me.gr.Size = New System.Drawing.Size(1000, 128)
        Me.gr.StyleInfo = resources.GetString("gr.StyleInfo")
        Me.gr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.gr.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.gr, "Doble click para escoger Estilo-Color.")
        Me.gr.Visible = False
        '
        'mas
        '
        Me.mas.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mas.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mas.ForeColor = System.Drawing.Color.Black
        Me.mas.Image = CType(resources.GetObject("mas.Image"), System.Drawing.Image)
        Me.mas.Location = New System.Drawing.Point(928, 8)
        Me.mas.Name = "mas"
        Me.mas.Size = New System.Drawing.Size(35, 35)
        Me.mas.TabIndex = 86
        Me.mas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.mas, "Agrega mas lineas.")
        Me.mas.UseVisualStyleBackColor = False
        '
        'correcto
        '
        Me.correcto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.correcto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.correcto.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correcto.ForeColor = System.Drawing.Color.Black
        Me.correcto.Image = CType(resources.GetObject("correcto.Image"), System.Drawing.Image)
        Me.correcto.Location = New System.Drawing.Point(888, 8)
        Me.correcto.Name = "correcto"
        Me.correcto.Size = New System.Drawing.Size(35, 35)
        Me.correcto.TabIndex = 87
        Me.correcto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.correcto, "Chequea que todos los datos esten correctos.")
        Me.correcto.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(968, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 88
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 100
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(1000, 648)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'cajas_esp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1078, 707)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.correcto)
        Me.Controls.Add(Me.mas)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.gr)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cajas_esp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilizaci�n de Cajas"
        CType(Me.gr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim mt As New DataTable()
    Dim dt As New DataTable()
    Dim strsql As String
    Private Sub cajas_esp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 50
        strsql = "SELECT DISTINCT ESTILO FROM ESTILOS ORDER BY ESTILO"
        llena_combos_fg(1, strsql, "ESTILO", dt)
        strsql = "SELECT * FROM MATERIALES WHERE CODIGO LIKE '99%' AND ACTIVO <> 'N' ORDER BY CODIGO"
        llena_combos_fg(2, strsql, "CODIGO", mt)
        setea_grid()
        llena_grid()
    End Sub

    Private Sub llena_combos_fg(ByVal c As Integer, ByVal strsql As String, ByVal variable As String, ByRef dt As DataTable)
        dt = New DataTable()
        Dim dr As DataRow
        Dim estilo As String = ""
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            estilo = estilo & dr(variable) & "|"
        Next
        fg.Cols(c).ComboList = estilo
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim i As Integer
        llena_tablas(dt, "SELECT * FROM MAT_EST_COL_ES ORDER BY ESTILO", cnn)
        fg.Rows.Count = dt.Rows.Count + 50
        For Each dr In dt.Rows
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = dr("CODIGO")
            busca_descripcion(fg(l, 2), fg(l, 3))
            For i = 4 To 13
                fg(l, i) = dr(i - 2)
            Next
            l = l + 1
        Next
    End Sub

    Private Sub busca_descripcion(ByVal codigo As String, ByRef descripcion As String)
        Dim dd As DataRow()
        Dim dr As DataRow
        dd = mt.Select("CODIGO = '" & codigo & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            descripcion = dr("DESCRIPCION")
        Else
            descripcion = ""
        End If
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
        Else
            MsgBox("No puedo grabar.", MsgBoxStyle.Exclamation, "Aun existen errores !!!")
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        ok = True
        fg.Sort(SortFlags.Ascending, 1, 2)
        elimina_blancos(ok)
        If fg.Rows.Count > 0 Then
        Else
            MsgBox("Aun no ha ingresado ningun dato!!!", MsgBoxStyle.Critical, "Por favor verifique.")
            ok = False
        End If

    End Sub

    Private Sub elimina_blancos(ByRef ok As Boolean)
        Dim i As Integer
        Dim j As Integer
        Dim t As Decimal = 0
        Dim v As Boolean
        Try
            For i = 1 To fg.Rows.Count - 1
                t = 0
                For j = 4 To 13
                    v = fg(i, j)
                    If v = True Then
                        t = t + 1
                    End If
                Next
                If fg(i, 1) = Nothing Or fg(i, 2) = Nothing Or t < 1 Then
                    fg.Rows.Remove(i)
                    i = i - 1
                End If
            Next
        Catch
        End Try
    End Sub


    Private Sub fg_rowcolchange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.AfterEdit 'AfterRowColChange
        Dim c As Integer = fg.RowSel
        ' validate amounts
        Try
            busca_descripcion(fg(e.Row, 2), fg(e.Row, 3))
        Catch
        End Try
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim i As Integer
        Dim j As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim v(9) As Integer
        cnn.Open()
        ' Comienza la transacci�n
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacci�n
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                For j = 0 To 9
                    If fg(i, j + 4) Then
                        v(j) = 1
                    Else
                        v(j) = 0
                    End If
                Next
                strsql = "UPDATE MAT_EST_COL_ES SET XS = '" & v(0) & "', S = '" & v(1) & "', M = '" & v(2) & "', L = '" & v(3) & "', XL = '" & v(4) & "', XL2 = '" & v(5) & _
                                     "', XL3 = '" & v(6) & "', XL4 = '" & v(7) & "', XL5 = '" & v(8) & "', XL6 = '" & v(9) & "' WHERE ESTILO = '" & fg(i, 1) & "' AND CODIGO = '" & fg(i, 2) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                If afectados = 0 Then
                    strsql = "INSERT INTO MAT_EST_COL_ES (ESTILO,CODIGO,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6) " & _
                                                 "VALUES ('" & fg(i, 1) & "','" & _
                                                               fg(i, 2) & "','" & _
                                                               v(0) & "','" & _
                                                               v(1) & "','" & _
                                                               v(2) & "','" & _
                                                               v(3) & "','" & _
                                                               v(4) & "','" & _
                                                               v(5) & "','" & _
                                                               v(6) & "','" & _
                                                               v(7) & "','" & _
                                                               v(8) & "','" & _
                                                               v(9) & "')"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next i
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurri� un error de tipo " & ex.GetType().ToString() & _
                                     " se gener� cuando se trato de eliminar la transacci�n.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim f As Integer = fg.RowSel
        Dim estilo As String = fg(f, 1)
        Dim codigo As String = fg(f, 2)

        cnn.Open()
        ' Comienza la transacci�n
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacci�n
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE MAT_EST_COL_ES WHERE ESTILO = '" & estilo & "' AND CODIGO = '" & codigo & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurri� un error de tipo " & ex.GetType().ToString() & _
                                     " se gener� cuando se trato de eliminar la transacci�n.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub


    Private Sub mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas.Click
        fg.Rows.Count = 150
    End Sub

    Private Sub correcto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles correcto.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If Not ok Then
            If fg.Rows.Count > 1 Then
                MsgBox("Aun existen datos incorrectos !!!", MsgBoxStyle.Critical, "Por favor verifique.")
            End If
        Else
            G1.Visible = True
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim seguro As MsgBoxResult
        Dim f As Integer = fg.RowSel
        seguro = MsgBox("Est� Seguro de Eliminar la L�nea?  ", MsgBoxStyle.YesNo, "Eliminaci�n de L�neas")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
            fg.RemoveItem(f)
        End If
    End Sub
End Class
