Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Desopacho_l
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim cortes As String = ""
    Dim co As New DataTable
   
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desopacho_l))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.Abre = New System.Windows.Forms.OpenFileDialog()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
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
        Me.fg.Size = New System.Drawing.Size(1183, 630)
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
        Me.G1.Location = New System.Drawing.Point(12, 3)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(60, 40)
        Me.G1.TabIndex = 29
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'Abre
        '
        Me.Abre.Filter = "Text Files (.csv)|.csv"
        '
        'Desopacho_l
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1203, 691)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.G1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Desopacho_l"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despachos (Carga Lector)"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        llena_Grid()
        G1.Visible = True
    End Sub
   
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        G1.Visible = False
    End Sub

    Private Sub llena_Grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT DISTINCT REQ_D.REQ,REQ_D.CORTE,CPO,ESTILO,COLOR,TOTAL FROM REQ_D LEFT JOIN CORTES ON REQ_D.CORTE = CORTES.CORTE WHERE DESPACHADO = 'N' AND EXPORTADO <> 'S' AND TOTAL = 0"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CORTE")
            fg(l, 2) = dr("REQ")
            fg(l, 3) = dr("CPO")
            fg(l, 4) = dr("ESTILO")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = False
            l = l + 1
        Next
    End Sub
    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit
        If e.Col = 6 Then
            If fg(e.Row, e.Col) = True Then
                suma_cortes("1", fg(e.Row, 1))
                'fg(e.Row, 6) = False
            Else
                suma_cortes("2", fg(e.Row, 1))
                'fg(e.Row, 6) = True
            End If
        End If
    End Sub
    Private Sub suma_cortes(ByVal t As String, ByVal corte As String)
        Dim p As Integer
        Dim l As Integer
        Dim cor As String = "'" + corte + "',"
        If t = 2 Then
            cortes = cortes + cor
        Else
            l = cor.Length
            p = cortes.IndexOf(cor) + 1
            cortes = Mid(cortes, 1, p - 1) + Mid(cortes, p + l)
        End If
    End Sub
    Private Sub antes_de_grabar(ByRef ok As Boolean)
        Dim obj As New Object
        obj = New empresas
        Dim EMP As String = obj.NUMERO
        ok = False
        Dim strsql As String
        If cortes.Length > 0 Then
            cortes = Mid(cortes, 1, cortes.Length - 1)
            strsql = "SELECT REQ, REQ_D.BATCH, REQ_D.ROLLO, CORTE, BARRA ," & obj.NUMERO & " AS EMPRESA FROM REQ_D LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE CORTE IN (" & cortes & ")"
            llena_tablas(co, strsql, cnn)
            ok = True
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setea_grid()
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim ok As Boolean
        Dim seguro As MsgBoxResult
        antes_de_grabar(ok)
        If ok Then
            seguro = MsgBox("Seguro de Grabar el Despacho de Tela?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos !!!")
            If seguro = MsgBoxResult.Yes Then
                graba_datos()
                Close()
            End If
        Else
            MsgBox("Antes de actualizar debe escoger al menos un Corte.", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If
    End Sub

    '===============================================================================================
    '=
    '=                       ACTUALIZA BASE DE DATOS
    '=
    '===============================================================================================

    Private Sub graba_datos()
        Dim strSQL As String = ""
        Dim afectados As Integer
        Dim i As Integer
        Dim dd As DataRow()
        Dim dr As DataRow
        cnn.ConnectionString = lector_dc()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            For i = 1 To fg.Rows.Count - 1
                If fg(i, 6) = True Then
                    dd = co.Select("CORTE = '" & fg(i, 1) & "'")
                    If dd.Length > 0 Then
                        For Each dr In dd

                            strSQL = "INSERT INTO DESP_T1 (REQ,BATCH,ROLLO,CORTE,CODIGO,EMPRESA,DESPACHADO) VALUES ('" & _
                                                      dr("REQ") & "','" & _
                                                      dr("BATCH") & "','" & _
                                                      dr("ROLLO") & "','" & _
                                                      dr("CORTE") & "','" & _
                                                      dr("BARRA") & "','" & _
                                                      dr("EMPRESA") & "','N')"
                                comando.CommandText = strSQL
                                afectados = comando.ExecuteNonQuery()

                        Next
                    End If
                End If
            Next i
            transaccion.Commit()
            MsgBox("Grabacion Exitosa", MsgBoxStyle.Exclamation, "Grabaciones")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos " & e.Message, MsgBoxStyle.Information, "Por favor revise !!!!")
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
