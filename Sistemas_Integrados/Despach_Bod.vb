Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Despach_Bod
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim STRSQL As String
    Dim DOCTO As String
    Dim CORTE As String
    Dim EMPRESA As String
    Dim lineas As Integer
    Dim dt As New DataTable()
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents b1 As System.Windows.Forms.ComboBox
    Dim dr As DataRow
    Dim bg As New DataTable
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cortes As System.Windows.Forms.ComboBox
    Friend WithEvents lector As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Despach_Bod))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Cortes = New System.Windows.Forms.ComboBox()
        Me.lector = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CORTE:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(464, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione aqui para ver los Rollos del Batch")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(504, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 46
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
                " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(464, 16)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(35, 35)
        Me.GRABA.TabIndex = 47
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        Me.GRABA.Visible = False
        '
        'Fecha
        '
        Me.Fecha.CalendarMonthBackground = System.Drawing.Color.White
        Me.Fecha.CalendarTitleForeColor = System.Drawing.Color.White
        Me.Fecha.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.Fecha.CustomFormat = "dd/MMM/yyyy"
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(128, 80)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(188, 22)
        Me.Fecha.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.Fecha, "Fecha del Movimiento")
        '
        'Cortes
        '
        Me.Cortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cortes.Location = New System.Drawing.Point(128, 48)
        Me.Cortes.Name = "Cortes"
        Me.Cortes.Size = New System.Drawing.Size(188, 24)
        Me.Cortes.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.Cortes, "Cliente para el cual se efectuo el Corte.")
        '
        'lector
        '
        Me.lector.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lector.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lector.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lector.ForeColor = System.Drawing.Color.Black
        Me.lector.Image = CType(resources.GetObject("lector.Image"), System.Drawing.Image)
        Me.lector.Location = New System.Drawing.Point(552, 16)
        Me.lector.Name = "lector"
        Me.lector.Size = New System.Drawing.Size(35, 35)
        Me.lector.TabIndex = 51
        Me.lector.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.lector, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.lector.UseVisualStyleBackColor = False
        Me.lector.Visible = False
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.White
        Me.b1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.Color.Black
        Me.b1.Location = New System.Drawing.Point(128, 10)
        Me.b1.MaxLength = 20
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(188, 28)
        Me.b1.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.b1, "Batch de Tela")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.fg.Location = New System.Drawing.Point(8, 124)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(968, 540)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "FECHA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(7, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "BODEGA:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Despach_Bod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 668)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lector)
        Me.Controls.Add(Me.Cortes)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GRABA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Despach_Bod"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas de Tela por Corte"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler b1.DrawItem, AddressOf comboBox_DrawItem1
        llena_tablas(bg, "SELECT * FROM BODEGAS WHERE CODIGO > '01'", cnn)
        Me.b1.DataSource = bg
        Me.b1.DisplayMember = "BODEGA"
        Me.b1.ValueMember = "CODIGO"
        Me.b1.DrawMode = DrawMode.OwnerDrawFixed
        AddHandler b1.SelectedIndexChanged, AddressOf b1_SelectedIndexChanged
        limpia_variables()
        Try
            b1.SelectedIndex = 0
        Catch ex As Exception

        End Try
        llena_cortes()
    End Sub

    Private Sub limpia_variables()
        Cortes.Enabled = True
        b1.Enabled = True
        Fecha.Enabled = False
        Button1.Visible = True
        CANCELA.Visible = False
        GRABA.Visible = False
        lector.Visible = False
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 13
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "KNIT"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "LIBRAS"
        fg.Cols(6).Name = "YARDAS"
        fg.Cols(7).Name = "REGIST."
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 220
            fg(0, index) = fg.Cols(index).Name
            If index > 4 And index < 7 Then
                fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                fg.Cols(index).Format = h
                fg.Cols(index).Width = 90
            End If
            fg.Cols(index).AllowEditing = False
        Next
        fg.Cols(2).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(2).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(7).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(7).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(2).Width = 90
        fg.Cols(3).Width = 220
        fg.Cols(7).Width = 100
        fg.Cols(1).Width = 120
        fg.Cols(7).DataType = GetType(Boolean)
        fg.Cols(8).Visible = False
        fg.Cols(9).Visible = False
        fg.Cols(10).Visible = False
        fg.Cols(11).Visible = False
        fg.Cols(12).Visible = False
        fg.Cols(7).AllowEditing = True
    End Sub

    Private Sub llena_Grid()
        Dim dr As DataRow
        Dim i As Integer
        Dim strSQL As String = "SELECT REQ_D.*, KNIT,COLOR,FPO,CPO,CLIENTE,BARRA,COSTO FROM REQ_D,ROLLOS WHERE REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO AND REQ_D.CORTE = '" & Cortes.Text & "' AND REQ_D.DESPACHADO = 'N' AND BODEGA = '" & b1.SelectedValue & "' ORDER BY REQ_D.BATCH, REQ_D.ROLLO"
        llena_tablas(dt, strSQL, cnn)
        i = dt.Rows.Count
        fg.Rows.Count = i + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("ROLLO")
            fg(lineas, 3) = dr("KNIT")
            fg(lineas, 4) = dr("COLOR")
            fg(lineas, 5) = dr("PESO")
            fg(lineas, 6) = dr("YARDAS")
            fg(lineas, 7) = True
            fg(lineas, 9) = dr("FPO")
            fg(lineas, 10) = dr("CPO")
            fg(lineas, 11) = dr("CLIENTE")
            fg(lineas, 12) = dr("COSTO")
            Try
                fg(lineas, 8) = dr("BARRA")
            Catch
            End Try
            lineas = lineas + 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ok As Boolean
        setea_grid()
        revisa_rollos(ok)
        If ok Then
            llena_Grid()
            'lector.Visible = True
            Button1.Visible = False
            CANCELA.Visible = True
            GRABA.Visible = True
            Cortes.Enabled = False
            b1.Enabled = False
        End If

    End Sub
    Private Sub revisa_rollos(ByRef ok As Boolean)
        Dim ro As New DataTable
        llena_tablas(ro, "SELECT * FROM REQ_D LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE CORTE = '" & Cortes.Text & "' AND BODEGA <> '" & b1.SelectedValue & "'", cnn)
        If ro.Rows.Count > 0 Then
            ok = False
            MsgBox("Por favor revisar.  Existen Rollos localizados en distintas bodegas a la que pertenece el Corte", MsgBoxStyle.Critical, "Por favor Revisar !!!")
            ok = False
        Else
            ok = True
        End If

    End Sub
    Private Sub lector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lector.Click
        Dim forma As New pt6300()
        forma.ShowDialog()
        procesa_descarga()
    End Sub

    Private Sub procesa_descarga()
        Try
            Dim archivo As String = "c:\texpasa\INVSUN.TXT"
            Dim sr As New StreamReader(archivo)
            Dim lineast As String
            Dim i As Integer
            Try
                Do
                    lineast = sr.ReadLine()
                    If lineast <> Nothing Then
                        If lineast.Length > 0 Then
                            lineast = lineast
                            i = fg.FindRow(lineast, 1, 8, True)
                            If i > 0 Then
                                fg(i, 7) = True
                            End If
                        End If
                    End If
                Loop Until lineast Is Nothing
            Catch E As Exception
            End Try
            sr.Close()
        Catch
        End Try
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Cancelar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Cancela Cambios !!!")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        revisa_antes_de_Grabar()
    End Sub

    Private Sub cortes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cortes.KeyPress
        AutoCompletar(Cortes, e)
    End Sub

    Private Sub revisa_antes_de_Grabar()
        Dim i As Integer
        Dim cuenta As Integer = 0
        Dim faltan As String = ""
        ok = True
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 7) = False Then
                faltan = "Aun faltan rollos por captar "
                ok = False
            Else
                cuenta = cuenta + 1
            End If
        Next
        If faltan <> "" Then
            MsgBox(faltan, MsgBoxStyle.Critical, "Por favor revise !!!")
        End If
        Dim seguro As MsgBoxResult
        If cuenta > 0 Then
            seguro = MsgBox("Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, "Actualizacion de Datos.  " + faltan)
            If seguro = MsgBoxResult.Yes Then
                grabaciones()
                limpia_variables()
            End If
        Else
            MsgBox("Aun no ha elegido ningun rollo a descargar !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If
    End Sub

    Private Sub grabaciones()
        graba_documento()
    End Sub

    '==================================== ACTUALIZA TABLAS ======================================= 
    Private Sub graba_documento()
        Dim dr As DataRow
        Dim strSQL As String
        Dim corr As Integer
        Dim i As Integer
        Dim BATCH As String
        Dim ROLLO As Integer
        Dim PRECIO As Decimal
        Dim YARDAS As Decimal
        Dim LIBRAS As Decimal
        Dim afectados As Integer
        Dim fechas As String = Format(Fecha.Value, "yyyy-MM-dd")
        strSQL = "SELECT SALIDAS FROM CORRELATIVO"
        fg.Subtotal(AggregateEnum.Clear)
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            corr = dr("SALIDAS") + 1
        Next

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strSQL = "UPDATE CORRELATIVO SET SALIDAS = '" & corr & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()


            If afectados = 1 Then
                strSQL = "INSERT INTO EMOVTO (DOCTO, TMOVTO, FECHA, COMENTARIO) VALUES (" & _
                                      "'" & corr & "','4','" & fechas & "','CORTE: " & Cortes.Text & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                For i = 1 To fg.Rows.Count - 1
                    If fg(i, 7) = True Then
                        BATCH = fg(i, 1)
                        ROLLO = fg(i, 2)
                        PRECIO = CDec(fg(i, 12))
                        YARDAS = CDec(fg(i, 6))
                        LIBRAS = CDec(fg(i, 5))
                        strSQL = "INSERT INTO DMOVTO (DOCTO, TMOVTO, BATCH, ROLLO, FECHA, CLIENTE, FPO, CPO, CORTE, YARDAS, LIBRAS, PRECIO) VALUES ( " & _
                                              "'" & corr & "','4','" & BATCH & "','" & ROLLO & "','" & fechas & "','" & _
                                              fg(i, 11) & "','" & fg(i, 9) & "','" & fg(i, 10) & "','" & Cortes.Text & "','" & YARDAS & "','" & LIBRAS & "','" & PRECIO & "')"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()

                        strSQL = "UPDATE ROLLOS SET YARDAS = '0', ACTIVO = 'N' , COSTO = '0' WHERE BATCH = '" & BATCH & "' AND ROLLO = '" & ROLLO & "'"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()

                        strSQL = "UPDATE REQ_D SET DESPACHADO = 'S' WHERE BATCH = '" & BATCH & "' AND ROLLO = '" & ROLLO & "'"
                        comando.CommandText = strSQL
                        afectados = comando.ExecuteNonQuery()
                    End If
                Next
            End If

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


    Public Sub comboBox_DrawItem1(ByVal sender As System.Object, _
                                   ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            ' Draw the default background
            e.DrawBackground()

            ' The ComboBox is bound to a DataTable,
            ' so the items are DataRowView objects.
            Dim drv As DataRowView = CType(b1.Items(e.Index), DataRowView)

            ' Retrieve the value of each column.
            Dim id As String = drv(0).ToString()
            Dim name As String = drv(1).ToString()

            ' Get the bounds for the first column
            Dim r1 As Rectangle = e.Bounds
            r1.Width = r1.Width / 2

            ' Draw the text on the first column
            Using sb As SolidBrush = New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(id, e.Font, sb, r1)
            End Using

            ' Draw a line to isolate the columns 
            Using p As Pen = New Pen(Color.Black)
                e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
            End Using

            ' Get the bounds for the second column
            Dim r2 As Rectangle = e.Bounds
            r2.X = e.Bounds.Width / 2
            r2.Width = r2.Width / 2

            ' Draw the text on the second column
            Using sb As SolidBrush = New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(name, e.Font, sb, r2)
            End Using
        Catch
        End Try

    End Sub

    Private Sub b1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena_cortes()
    End Sub

    Private Sub llena_cortes()
        Try
            Dim bodegon As String = b1.SelectedValue
            Dim strsql As String = "SELECT DISTINCT CORTE FROM REQ_D LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE DESPACHADO = 'N' AND BODEGA = '" & bodegon & "'"
            llena_combos(Cortes, strsql, "CORTE")
        Catch
        End Try
    End Sub

End Class
