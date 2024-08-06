Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports System.Threading

Public Class Toma_invr
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim strsql As String
    Dim EMPRESA As String
    Dim lineas As Integer
    Dim cnn1 As SqlClient.SqlConnection
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Dim dr As DataRow
    Friend WithEvents ar As C1.Win.C1FlexGrid.C1FlexGrid
    Dim abrear As New OpenFileDialog
    Dim ruta As String
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Fechas As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toma_invr))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Fechas = New System.Windows.Forms.ComboBox()
        Me.Graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ar = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(250, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione aqui para ver los Rollos del Batch")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Fechas
        '
        Me.Fechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechas.Location = New System.Drawing.Point(88, 19)
        Me.Fechas.Name = "Fechas"
        Me.Fechas.Size = New System.Drawing.Size(142, 28)
        Me.Fechas.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.Fechas, "Cliente para el cual se efectuo el Corte.")
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(250, 8)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(60, 40)
        Me.Graba.TabIndex = 67
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Crea registro para toma de inventario.")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 60)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(984, 636)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(672, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 48)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Un Momento por favor.                                                            " & _
    "   Me encuentro Procesando"
        Me.Label1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "abre"
        '
        'ar
        '
        Me.ar.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ar.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ar.AutoGenerateColumns = False
        Me.ar.BackColor = System.Drawing.Color.White
        Me.ar.ColumnInfo = resources.GetString("ar.ColumnInfo")
        Me.ar.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ar.ForeColor = System.Drawing.Color.Black
        Me.ar.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ar.Location = New System.Drawing.Point(8, 60)
        Me.ar.Name = "ar"
        Me.ar.Rows.Count = 1
        Me.ar.Rows.DefaultSize = 21
        Me.ar.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.ar.Size = New System.Drawing.Size(978, 602)
        Me.ar.StyleInfo = resources.GetString("ar.StyleInfo")
        Me.ar.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ar.TabIndex = 72
        '
        'Toma_invr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 690)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Fechas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Graba)
        Me.Controls.Add(Me.ar)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toma_invr"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Inventario Físico"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        ar.Width = Me.Width - 50
        ar.Height = Me.Height - 100
        crea_sub_inventario(ruta)
        ar.Rows.Count = 1
        ar.Rows(0).Height = 30
        fg.Visible = False
        llena_fecha()
        llena_ar()
    End Sub

    Private Sub llena_ar()
        Dim l As Integer
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(ruta)
            l = ar.Rows.Count
            ar.Rows.Count = l + 1
            ar(l, 1) = foundFile
            ar(l, 2) = True
        Next
    End Sub

    Private Sub limpia_variables()
        ar.Visible = True
        fg.Visible = False
        Button1.Visible = True
        Graba.Visible = False
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_Grid()
        Dim dr As DataRow
        Dim fecha As String = Format(CDate(Fechas.Text), "yyyy-MM-dd")
        Dim strSQL As String = "SELECT TOMA_INV.*, KNIT,COLOR FROM TOMA_INV LEFT JOIN ROLLOS ON TOMA_INV.BATCH = ROLLOS.BATCH AND TOMA_INV.ROLLO = ROLLOS.ROLLO WHERE FECHA = '" & fecha & "' ORDER BY TOMA_INV.CLIENTE,TOMA_INV.BATCH,TOMA_INV.ROLLO"
        Dim dt As New DataTable()
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CLIENTE")
            fg(lineas, 2) = dr("BATCH")
            fg(lineas, 3) = dr("ROLLO")
            fg(lineas, 4) = dr("KNIT")
            fg(lineas, 5) = dr("COLOR")
            fg(lineas, 6) = dr("YARDAS")
            fg(lineas, 7) = dr("LIBRAS")
            Try
                fg(lineas, 8) = dr("BARRA")
            Catch
            End Try
            If dr("BIEN") = "S" Then
                fg(lineas, 9) = True
            Else
                fg(lineas, 9) = False
            End If
            lineas = lineas + 1
        Next
    End Sub

    Private Sub llena_fecha()
        Dim strsql As String = "SELECT DISTINCT FECHA FROM TOMA_INV ORDER BY FECHA DESC"
        Dim fecha As String
        Dim dt As New DataTable()
        Dim dr As DataRow
        Fechas.Items.Clear()
        ok = True
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            fecha = Format(dr("FECHA"), "dd/MM/yyyy")
            Fechas.Items.Add(fecha)
        End If
        If Fechas.Items.Count > 0 Then
            Fechas.SelectedIndex = 0
        Else
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fg.Visible = True
        ar.Visible = False
        Graba.Visible = True
        setea_grid()
        llena_Grid()
        procesa_descarga()
        Button1.Visible = False
    End Sub

    Private Sub procesa_descarga()
        Dim l As Integer
        Dim archivo As String
        Dim c As Integer
        Dim barra As String
        Dim i As Integer
        Dim lineast As String
        Dim li As Integer
        For l = 1 To ar.Rows.Count - 1
            archivo = ar(l, 1)
            Dim sr As New StreamReader(archivo)
            Try
                Do
                    lineast = sr.ReadLine()
                    If lineast <> Nothing Then
                        If lineast.Length > 0 Then
                            c = lineast.IndexOf(",")
                            If c > 0 Then
                                barra = Mid(lineast, 1, c)
                                i = fg.FindRow(barra, 1, 8, False)
                                If i > 0 Then
                                    fg(i, 9) = True
                                    fg(i, 10) = "X"
                                    li = li + 1
                                Else
                                End If
                            End If
                        End If
                    End If
                Loop Until lineast Is Nothing
            Catch E As Exception
            End Try
            sr.Close()
        Next l
        MsgBox(Format(li, "####0") & " limeas procesadas", MsgBoxStyle.Information, "Proceso de Información")
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Label1.Visible = True
        Cursor = Cursors.WaitCursor
        graba_registros()
        Cursor = Cursors.Default
        Close()
    End Sub

    Private Sub Edita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim r As Integer = e.Row
        fg(r, 10) = "X"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Try
            procesa_descarga()
        Catch
        End Try
        Cursor = Cursors.Default
        Graba.Visible = True
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_registros()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim v(9) As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                If fg(i, 10) = "X" Then
                    strsql = "UPDATE TOMA_INV SET BIEN = 'S' WHERE BATCH = '" & fg(i, 2) & "' AND ROLLO = '" & fg(i, 3) & "'"
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
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

End Class
