Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel
Imports System.Threading


Public Class Inventario_fis1
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_fis1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lector = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.lector.Location = New System.Drawing.Point(16, 8)
        Me.lector.Name = "lector"
        Me.lector.Size = New System.Drawing.Size(35, 35)
        Me.lector.TabIndex = 52
        Me.lector.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.lector, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.lector.UseVisualStyleBackColor = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(64, 8)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 68
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Crea registro para toma de inventario.")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(112, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 70
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(16, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "C"
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.fg.Size = New System.Drawing.Size(976, 647)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Inventario_fis1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 700)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Graba)
        Me.Controls.Add(Me.lector)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_fis1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capta Inventario Físico"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "##,###,##0.00"
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As New empresas()
    Dim usuario As String = obj.usuario
    Dim path = "c:\reportes\toma_inventario.xls"
    Private Sub Inventario_fis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        setea_grid()
        llena_grid()
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
        strsql = "SELECT FISICO,UNIDADES,MATERIALES.* FROM MAT_INV LEFT JOIN MATERIALES ON MATERIALES.CODIGO = MAT_INV.CODIGO ORDER BY CLIENTE,MATERIALES.T_MATERIAL,MAT_INV.CODIGO"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("T_MATERIAL")
            fg(l, 3) = dr("CODIGO")
            fg(l, 4) = dr("DESCRIPCION")
            fg(l, 5) = dr("UNIDAD_MEDIDA")
            fg(l, 6) = dr("UNIDADES")
            fg(l, 7) = "0"
            Try
                fg(l, 7) = dr("FISICO")
            Catch
            End Try
            If fg(l, 6) > 0 Then
                fg.SetCellStyle(l, 6, fg.Styles("valor"))
            End If
            fg(l, 9) = fg(l, 6) - fg(l, 7)
            fg(l, 10) = dr("COSTO") * dr("UNIDADES")
            l = l + 1
        Next
        ' fg.Sort(SortFlags.Ascending, 3)
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        fg(r, 8) = "X"
    End Sub

    Private Sub graba_documento()
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
                If fg(i, 8) = "X" Then
                    strsql = "UPDATE MAT_INV SET FISICO = ' " & fg(i, 7) & "' WHERE CODIGO = '" & fg(i, 3) & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                    If afectados = 0 Then
                        strsql = "INSERT INTO MAT_INV (CODIGO,UNIDADES,FISICO) " & _
                                  "VALUES ( '" & fg(i, 3) & "','0','" & _
                                                 fg(i, 7) & "')"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                End If
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
        Dim forma As New pt6300()
        Try
            File.Delete("c:\lector\materiales\INVSUN.TXT")
        Catch
        End Try
        forma.ShowDialog()
        lector.Visible = False
        Button1.Visible = True
    End Sub


    Private Sub procesa_descarga()
        Thread.Sleep(3000)
        Dim l As Integer
        Dim i As Integer
        Dim dg As New OpenFileDialog
        Dim archivo As String = "c:\lector\materiales\INVSUN.TXT"
        '   archivo = "c:\inventario 2014\materiales\06.TXT"
        Dim sr As New StreamReader(archivo)
        Dim codigo As String
        Dim unidades As Decimal
        Dim lineast As String
        Cursor = Cursors.WaitCursor
        Do
            lineast = sr.ReadLine()
            If lineast <> Nothing Then
                If lineast.Length > 0 Then
                    l = l + 1
                    lineast = lineast
                    codigo = Mid(lineast, 1, 10)
                    Try
                        unidades = CDec(Mid(lineast, 12))
                    Catch
                        unidades = 0
                    End Try

                    i = fg.FindRow(codigo, 1, 3, False)
                    If i > 0 Then
                        fg(i, 7) = unidades
                        fg(i, 8) = "X"
                    End If
                End If
            End If
        Loop Until lineast Is Nothing
        sr.Close()
        For i = 1 To fg.Rows.Count - 1
            fg(i, 9) = fg(i, 6) - fg(i, 7)
        Next
        MsgBox(Format(l, "#####") & " lineas procesadas", MsgBoxStyle.Information, "Proceso de Inventario")
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        graba_documento()
        Close()
    End Sub

    Private Sub datos_excel(ByRef si As Boolean)
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.Subtotal(AggregateEnum.Clear)

            a_excel(fg, path, si)
            System.Diagnostics.Process.Start(path)
            si = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            procesa_descarga()
        Catch
        End Try
        Cursor = Cursors.Default
        Graba.Visible = True
    End Sub
End Class
