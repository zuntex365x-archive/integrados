Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel
Imports System.Threading

Public Class Re_ubica
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
    Friend WithEvents lector As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Re_ubica))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lector = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lector
        '
        Me.lector.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lector.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lector.ForeColor = System.Drawing.Color.Black
        Me.lector.Image = CType(resources.GetObject("lector.Image"), System.Drawing.Image)
        Me.lector.Location = New System.Drawing.Point(12, 8)
        Me.lector.Name = "lector"
        Me.lector.Size = New System.Drawing.Size(35, 35)
        Me.lector.TabIndex = 52
        Me.lector.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.lector, "Presione este Boton para descargar Datos del Lector.")
        Me.lector.UseVisualStyleBackColor = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(12, 8)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 68
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Actualiza Ubicaciones")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AutoGenerateColumns = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1061, 639)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Re_ubica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 700)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.lector)
        Me.Controls.Add(Me.Graba)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Re_ubica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Ubica Rollos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "##,###,##0.00"
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As New empresas()
    Dim usuario As String = obj.usuario
    Dim codigos As String = ""
    Dim tab As New DataTable
    Dim lec As New DataTable
    Dim cs As New Lib_SI.util
    Private Sub Inventario_fis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        Cursor = Cursors.WaitCursor
        setea_grid()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim ubica As String
        fg.Rows.Count = tab.Rows.Count + 1
        For Each dr In tab.Rows
            fg(l, 0) = dr("EMPRESA")
            ubica = busca_ubica(dr("BARRA"))
            fg(l, 1) = ubica
            fg(l, 2) = dr("BARRA")
            fg(l, 3) = dr("BATCH")
            fg(l, 4) = dr("ROLLO")
            fg(l, 5) = dr("KNIT")
            fg(l, 6) = dr("COLOR")
            fg(l, 7) = dr("YARDAS")
            dr("VIEJO") = ubica
            l = l + 1
        Next
    End Sub
    Private Sub lee_registros()
        Dim i As Integer
        Dim dt As New DataTable
        Dim cnn As New SqlClient.SqlConnection
        Dim strsql As String
        tab = New DataTable
        For i = 0 To 2
            cnn.ConnectionString = cs.con_string(i)
            strsql = "SELECT " & Str(i) & " AS EMPRESA, VIEJO, BARRA,BATCH,ROLLO,KNIT,COLOR,YARDAS FROM ROLLOS WHERE BARRA IN (" & codigos & ") ORDER BY BATCH,ROLLO"
            llena_tablas_e(dt, strsql, cnn)
            tab.Merge(dt)
        Next
    End Sub

    Private Function busca_ubica(ByVal barra As String) As String
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim ubicacion As String = ""
        dd = lec.Select("CODIGO = '" & barra & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            ubicacion = dr("UBICA")
        End If
        Return ubicacion
    End Function

    Private Sub graba_datos(emp As String)
        Dim cs As New Lib_SI.util
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim afectados As Integer
        cnn.ConnectionString = cs.con_string(emp)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            dd = tab.Select("EMPRESA = '" & emp & "'")
            For Each dr In dd
                strsql = "UPDATE ROLLOS SET VIEJO = ' " & dr("VIEJO") & "' WHERE BARRA = '" & dr("BARRA") & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()
        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub lector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lector.Click
        'Try
        procesa_descarga()
        lee_registros()
        llena_grid()
        'Catch
        'End Try
        Cursor = Cursors.Default
        lector.Visible = False
        Graba.Visible = True
    End Sub

    Private Sub procesa_descarga()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim codigo As String
        Dim ubica As String
        lec = descarga_lector(1)
        For Each dr In lec.Rows
            codigo = "'" + dr("CODIGO") + "',"
            ubica = dr("UBICA")
            If codigos.IndexOf(codigo) < 0 Then
                codigos = codigos + codigo
            End If
            l = l + 1
        Next
        If codigos.Length > 0 Then
            codigos = Mid(codigos, 1, codigos.Length - 1)
        End If
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim i As Integer
        Dim seguro As MsgBoxResult
        If tab.Rows.Count > 0 Then
            Cursor = Cursors.WaitCursor
            For i = 0 To 2
                graba_datos(i)
            Next
            seguro = MsgBox("Quiere Limpiar el Lector?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                elimina_datos_ubicacion()
            End If
            Cursor = Cursors.Default
            Close()
        Else
            MsgBox("Al menos debe haber un rollo para Actualizar", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
    End Sub

    Private Sub elimina_datos_ubicacion()
        Dim afectados As Integer
        cnn.ConnectionString = lector_dc()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()
        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            strsql = "DELETE ROLLOS_UBICA"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            MsgBox("Transaccion Completa.", MsgBoxStyle.Information, "Datos Actualizados")
            transaccion.Commit()
        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    Console.WriteLine("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub
End Class
