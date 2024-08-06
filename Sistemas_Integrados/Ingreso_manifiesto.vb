Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Ingreso_manifiesto
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim constr(2) As String
    Dim lineas As Integer
    Dim abrear As New OpenFileDialog()
    Dim archivo As String
    Dim o As String = "0|2|3|8|5|12|6|7|4|11|9|10|0"
    Dim f(10) As String
    Dim e(2) As String
    Dim cd As New DataTable()
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Dim dm(3) As String
    Dim despacho As String = ""
    Dim fpos As String = ""
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Abre As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fp As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents G1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_manifiesto))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Abre = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1183, 681)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.fg, "Detalle del Manifiesto")
        '
        'fp
        '
        Me.fp.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fp.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fp.BackColor = System.Drawing.Color.White
        Me.fp.ColumnInfo = resources.GetString("fp.ColumnInfo")
        Me.fp.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fp.ForeColor = System.Drawing.Color.Black
        Me.fp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fp.Location = New System.Drawing.Point(12, 185)
        Me.fp.Name = "fp"
        Me.fp.Rows.DefaultSize = 19
        Me.fp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fp.Size = New System.Drawing.Size(760, 448)
        Me.fp.StyleInfo = resources.GetString("fp.StyleInfo")
        Me.fp.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fp.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.fp, "Para Eliminar la fila  Presione  Doble-Click")
        Me.fp.Visible = False
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(178, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(60, 40)
        Me.G1.TabIndex = 29
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(178, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este boton para buscar el archivo a  actualizar")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Abre
        '
        Me.Abre.Filter = "Text Files (.csv)|.csv"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Seleccione archivo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ingreso_manifiesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1203, 668)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.G1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_manifiesto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Manifiesto"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 130
        fg.Width = Me.Width - 30
        llena_conexiones()
        setea_grid()
    End Sub
    Private Sub llena_conexiones()
        Dim i As Integer
        e(0) = "inventarios"
        e(1) = "TRECENTO"
        e(2) = "zuntex"
        For i = 0 To 2
            constr(i) = "Data Source=192.9.200.3\JT;initial catalog=" + e(i) + ";User id=user_e;Password=Ga2412_e"
        Next i
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        G1.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        abrear.InitialDirectory = "c:\texpasa"
        abrear.FileName = "Despacho*.*"
        ok = True
        If abrear.ShowDialog = DialogResult.OK Then
            '  Try
            Cursor = Cursors.WaitCursor
            archivo = abrear.FileName
            lee_texto()
            If ok Then
                G1.Visible = True
                Button1.Visible = False

            Else
                MessageBox.Show("Aun existen registros inconsistentes.", "Por favor revise !!!", MessageBoxButtons.OK)
            End If
            '   Catch
            ' End Try
            Cursor = Cursors.Default
        Else
            MessageBox.Show("Aun no se ha seleccionado el archivo a utilizar", "No se selecciono archivo", MessageBoxButtons.OK)
            Close()
        End If
        Try
            despacho = Mid(archivo, archivo.IndexOf("Despacho") + 10)
            despacho = Mid(despacho, 1, despacho.IndexOf(".txt"))
            busca_manifiesto()
        Catch
        End Try

    End Sub

    Private Sub lee_texto()
        Dim sr As New StreamReader(archivo)
        Dim lineast As String
        Dim l As Integer
        Dim i As Integer
        Dim ln(12) As String
        Dim co(12) As String
        Dim sep As String = "|"
        Dim busca As String = ""
        co = Split(o, sep)
        fg.Rows.Count = 9001
        fpos = ""
        l = 0
        Try
            lineast = sr.ReadLine
            If lineast.IndexOf(sep) = -1 Then
                sep = vbTab
            End If
            Do
                lineast = sr.ReadLine()
                If lineast <> Nothing Then
                    If lineast.Length > 0 Then
                        lineast = lineast + sep
                        l = l + 1
                        ln = Split(lineast, sep)
                        For i = 1 To 12
                            fg(l, i) = ln(co(i))
                            If i = 12 Then
                                If ln(0) = "0064" Then
                                    fg(l, i) = 0
                                ElseIf ln(0) = "0340" Then
                                    fg(l, i) = 2
                                Else
                                    fg(l, i) = 1
                                End If
                            End If
                        Next
                        If InStr(dm(fg(l, 12)), fg(l, 5)) = 0 Then
                            dm(fg(l, 12)) = dm(fg(l, 12)) + fg(l, 5) + "','"
                        End If
                        If fpos.IndexOf("'" + fg(l, 2) + "'") = -1 Then
                            fpos = fpos + "'" + fg(l, 2) + "',"
                        End If
                    End If
                End If
            Loop Until lineast Is Nothing
        Catch E As Exception
        End Try
        sr.Close()
        fg.Rows.Count = l + 1
        If fpos.Length > 0 Then
            fpos = "(" + Mid(fpos, 1, fpos.Length - 1) + ")"
        End If
        carga_fpos()

    End Sub
    Private Sub carga_fpos()
        Dim dt As New DataTable
        Dim cnn1 As New SqlClient.SqlConnection
        Dim strsql As String = ""
        Dim dr As DataRow = Nothing
        Dim dd As DataRow()
        cd = New DataTable
        For i = 0 To 2
            If fpos <> "" Then
                cnn1.ConnectionString = constr(i)
                strsql = "SELECT " & Str(i) & " AS  EMPRESA, FPO.* FROM FPO WHERE FPO IN " & fpos
                llena_tablas_e(dt, strsql, cnn1)
                cd.Merge(dt)
            End If
        Next
        For i = 1 To fg.Rows.Count - 1
            dd = cd.Select("FPO = '" & fg(i, 2) & "' AND LOTE = '" & fg(i, 3) & "'")

            If dd.Length > 0 Then
                dr = dd(0)
                fg(i, 7) = dr("COLOR")
            Else
                fg(i, 7) = "N/A"
            End If
        Next
    End Sub
    Private Sub busca_manifiesto()
        Dim cnn As New SqlClient.SqlConnection
        Dim dt As New DataTable
        Dim seguro As MsgBoxResult
        Dim strsql As String = "SELECT * FROM MANI WHERE DESPACHO = '" & despacho & "'"
        cnn.ConnectionString = lector_dc()
        llena_tablas_e(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            seguro = MsgBox("Manifiesto ya existe.  Desea Eliminarlo?  ", MsgBoxStyle.YesNo, "Eliminación de Datos !!!")
            If seguro = MsgBoxResult.Yes Then
                elimina_datos()
                Close()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setea_grid()
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        If fg.Rows.Count = 1 Then
            MsgBox("Antes de Grabar debe de elegir un Manifiesto", MsgBoxStyle.Critical, "Por favor revise !!!")
            Exit Sub
        End If
        seguro = MsgBox("Seguro de Grabar el Manifiesto?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_datos()
            Close()
        End If
    End Sub

    Private Sub determina_tipo(ByVal codigo As String, ByRef tipo As String)
        If UCase(Mid(codigo, 1, 4)) = "PUNO" Then
            tipo = "PUÑOS"
        ElseIf UCase(Mid(codigo, 1, 6)) = "CUELLO" Then
            tipo = "CUELLOS"
        Else
            tipo = "TELA"
        End If
    End Sub
   
    '===============================================================================================
    '=
    '=                       ACTUALIZA BASE DE DATOS
    '=
    '===============================================================================================

    Private Sub graba_datos()
        Dim strSQL As String
        Dim afectados As Integer
        Dim i As Integer

        cnn.ConnectionString = lector_dc()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            For i = 1 To fg.Rows.Count - 1

                strSQL = "INSERT INTO ROLLO (ROLLO,MANI) " & _
                         "VALUES ( '" & fg(i, 8) & "','" & despacho & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                strSQL = "INSERT INTO MANI (DESPACHO,ENVIO,BATCH,ROLLO,FPO,DM,KNIT,COLOR,BARRA,CODIGO,LIBRAS,YARDAS,EMP) " & _
                                   "VALUES ( '" & despacho & "','" & fg(i, 1) & "','" & fg(i, 3) & "','" & fg(i, 4) & "','" & fg(i, 2) & "','" & fg(i, 5) & "','" & fg(i, 6) & "','" & fg(i, 7) & "','" & fg(i, 8) & "','" & fg(i, 9) & "','" & fg(i, 10) & "','" & fg(i, 11) & "','" & fg(i, 12) & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            Next i
            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
        Catch e As SqlClient.SqlException
                Dim numero As String = e.Number
                If numero = "2627" Then
                    numero = "Documento ya existe. !!!!!!"
                Else
                    numero = "Error No." & numero
                End If
                MsgBox("Inconsistencia en Datos." & vbLf & numero, MsgBoxStyle.Critical, "Por favor revise !!!!")
            transaccion.Rollback()
        Finally
            cnn.Close()
        End Try
    End Sub

    '===============================================================================================
    '=
    '=                       ELIMINA MANIFIESTO
    '=
    '===============================================================================================

    Private Sub elimina_datos()
        Dim strSQL As String
        Dim afectados As Integer

        cnn.ConnectionString = lector_dc()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strSQL = "DELETE ROLLO WHERE MANI = '" & despacho & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()


            strSQL = "DELETE MANI WHERE DESPACHO = '" & despacho & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Information, "Por favor revise !!!!")
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


    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.DoubleClick
        Dim l As Integer = fg.RowSel
        Dim form As New Ingreso_manifiesto_1
        If l > 0 And l < fg.Rows.Count Then
            form.jg = fg
            form.fpo.Text = fg(l, 2)
            form.batch.Text = fg(l, 3)
            form.knit_t.Text = fg(l, 6)
            form.fp = cd
            form.ShowDialog()
            fg = form.jg
        End If

    End Sub
End Class
