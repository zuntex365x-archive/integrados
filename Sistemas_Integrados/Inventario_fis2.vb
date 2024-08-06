Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Inventario_fis2
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents But_graba As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_fis2))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.But_graba = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(976, 648)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'But_graba
        '
        Me.But_graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_graba.ForeColor = System.Drawing.Color.Black
        Me.But_graba.Image = CType(resources.GetObject("But_graba.Image"), System.Drawing.Image)
        Me.But_graba.Location = New System.Drawing.Point(920, 8)
        Me.But_graba.Name = "But_graba"
        Me.But_graba.Size = New System.Drawing.Size(35, 35)
        Me.But_graba.TabIndex = 25
        Me.But_graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.But_graba, "Boton de Grabación del Documento")
        Me.But_graba.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(872, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 46
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Inventario_fis2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 700)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.But_graba)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_fis2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste al inventario Físico"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "##,###,##0.00"
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As New empresas()
    Dim usuario As String = obj.usuario
    Private Sub Inventario_fis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        Cursor = Cursors.WaitCursor
        setea_grid()
        llena_grid()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim fisico As Decimal
        Dim libros As Decimal
        strsql = "SELECT CLIENTE,T_MATERIAL,MATERIALES.CODIGO,DESCRIPCION,EXISTENCIA,FISICO,(EXISTENCIA-FISICO) AS DIF, COSTO FROM MATERIALES LEFT JOIN LEC_FIN ON MATERIALES.CODIGO = LEC_FIN.CODIGO WHERE T_MATERIAL <> 'OBSOLETO' AND ACTIVO <> 'N' AND T_MATERIAL <> 'THREAD' AND EXISTENCIA <> FISICO ORDER BY CLIENTE,T_MATERIAL,MATERIALES.CODIGO"

        '   -"SELECT CLIENTE,T_MATERIAL,MATERIALES.CODIGO,DESCRIPCION,UNIDAD_MEDIDA,EXISTENCIA,FISICO,COSTO FROM MATERIALES LEFT JOIN TOMA_MAT ON MATERIALES.CODIGO = TOMA_MAT.CODIGO WHERE T_MATERIAL <> 'OBSOLETO' AND T_MATERIAL <> 'THREAD' ORDER BY CLIENTE,T_MATERIAL,MATERIALES.CODIGO"
        'strsql = "SELECT CLIENTE,T_MATERIAL,MATERIALES.CODIGO,DESCRIPCION,UNIDAD_MEDIDA,(SELECT SUM(UNIDADES) FROM D_MATERIAL WHERE D_MATERIAL.CODIGO = MATERIALES.CODIGO AND FECHA < '2009-10-01') AS EXISTENCIA,FISICO,COSTO FROM MATERIALES LEFT JOIN TOMA_MAT ON MATERIALES.CODIGO = TOMA_MAT.CODIGO WHERE T_MATERIAL <> 'OBSOLETO' ORDER BY CLIENTE,T_MATERIAL,MATERIALES.CODIGO"

        Try
            llena_tablas(dt, strsql, cnn)
            fg.Rows.Count = dt.Rows.Count + 1
            For Each dr In dt.Rows
                Try
                    libros = dr("EXISTENCIA")
                Catch
                    libros = 0
                End Try
                Try
                    fisico = dr("FISICO")
                Catch
                    fisico = 0
                End Try
                fg(l, 1) = dr("CLIENTE")
                fg(l, 2) = dr("T_MATERIAL")
                fg(l, 3) = dr("CODIGO")
                fg(l, 4) = dr("DESCRIPCION")
                fg(l, 5) = libros
                fg(l, 6) = fisico
                fg(l, 7) = fisico - libros
                fg(l, 8) = dr("COSTO")
                l = l + 1
            Next
        Catch
        End Try
        fg.Sort(SortFlags.Ascending, 2, 3)
    End Sub

    Private Sub graba_movimiento()
        Dim afectados As Integer
        Dim fecha As String = Format(Today, "yyyy") + "-09-30" 'Format(Today, "yyyy-MM-dd")
        Dim docto As String = Format(Today, "yyyy") + "0930"   'Format(Today, "yyyyMMdd")
        Dim i As Integer
        Dim empresa As String = "JT"
        Dim corte As String = "00000"
        Dim pedido As String = ""
        Dim cpo As String = ""
        Dim tipo As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        strsql = "INSERT INTO E_MATERIAL (T_MOVTO,DOCTO,FECHA,DESCRIPCION) " & _
                                "VALUES ( '3' , '" & docto & "' " & " ,'" & fecha & "','AJUSTE POR INVENTARIO FISICO')"
        Try
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            strsql = "INSERT INTO E_MATERIAL (T_MOVTO,DOCTO,FECHA,DESCRIPCION) " & _
                                     "VALUES ( '6' , '" & docto & "' " & " ,'" & fecha & "','AJUSTE POR INVENTARIO FISICO')"

            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                tipo = "6"
                If fg(i, 7) > 0 Then
                    tipo = "3"
                End If

                strsql = "INSERT INTO D_MATERIAL (T_MOVTO,DOCTO,CODIGO,LINEA,FECHA,EMPRESA,CORTE,UNIDADES,COSTO,PEDIDO,CPO) " & _
                         "VALUES ( '" & tipo & "','" & _
                                  docto & "','" & _
                                  fg(i, 3) & "','" & _
                                  i & "','" & _
                                  fecha & "','" & _
                                  empresa & "','" & _
                                  corte & "','" & _
                                  fg(i, 7) & "','" & _
                                  fg(i, 8) & "','" & _
                                  pedido & "','" & _
                                  cpo & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                strsql = "UPDATE MATERIALES SET EXISTENCIA = EXISTENCIA + " & fg(i, 7) & " WHERE CODIGO = '" & fg(i, 3) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next i

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
        cnn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        mal = "(" + obj.nombre + ")  Correciones segun Inventario Físico"
        fecha = Format(Today, "dd/MM/yyyy")
        fecha = "30/09/" + Format(Today, "yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Materiales", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + " al  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub But_graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Actualizar las Correciones?  ", MsgBoxStyle.YesNo, "Correcciones Al Inventario Físico!!!")
        If seguro = MsgBoxResult.Yes Then
            graba_movimiento()
        End If
    End Sub
End Class
