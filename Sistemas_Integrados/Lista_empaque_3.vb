Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Lista_empaque_3
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.Label
    Dim strSQl As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Embarque As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents G1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_3))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Embarque = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.Button()
        Me.motivo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Embarque
        '
        Me.Embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embarque.Location = New System.Drawing.Point(128, 8)
        Me.Embarque.Name = "Embarque"
        Me.Embarque.Size = New System.Drawing.Size(200, 28)
        Me.Embarque.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Embarque, "Embarque.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(888, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Desplegar la Consulta.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.E1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.Black
        Me.E1.Image = CType(resources.GetObject("E1.Image"), System.Drawing.Image)
        Me.E1.Location = New System.Drawing.Point(968, 8)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(35, 35)
        Me.E1.TabIndex = 82
        Me.E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E1, "Presione este Boton para Borrar los datos seleccionados.")
        Me.E1.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(888, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 83
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Otro Embarque")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(928, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 84
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Actualiza el destino del embarque")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'motivo
        '
        Me.motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivo.Items.AddRange(New Object() {"Error al ingreso de datos.", "Reprogramación de Embarque por el Cliente.", "Mala Programación.", "Ordenes de Operaciónes (sin motivo)"})
        Me.motivo.Location = New System.Drawing.Point(534, 8)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(339, 28)
        Me.motivo.TabIndex = 85
        Me.ToolTip1.SetToolTip(Me.motivo, "Motivo")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(1, 78)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(1008, 605)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(367, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 26)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Motivo Eliminación:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.Black
        Me.fecha.Location = New System.Drawing.Point(128, 41)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 28)
        Me.fecha.TabIndex = 88
        Me.fecha.Text = " "
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lista_empaque_3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.motivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.E1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Embarque)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Lista de empaque."
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Lista_empaque_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Embarque.KeyPress, AddressOf keypressed1
        setea_fg()
        llena_empaque()
        motivo.SelectedIndex = 0
    End Sub

    Private Sub llena_empaque()
        llena_combos(Embarque, "SELECT DISTINCT EMBARQUE, FECHA FROM PACKING_E WHERE (FACTURADO IS NULL) OR (FACTURADO = 'N') AND EMBARQUE <> CPO ORDER BY EMBARQUE", "EMBARQUE")
        Try
            Embarque.SelectedIndex = 0
        Catch
        End Try
        Button2.Visible = True
        regresa.Visible = False
        E1.Visible = False
        G1.Visible = False
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fecha.Text = ""
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim l As Integer = 1
        strSQl = "SELECT PACKING_E.*,(SELECT SUM(PRENDAS) FROM PACKING_C WHERE PACKING_E.EMBARQUE = PACKING_C.EMBARQUE AND PACKING_E.CPO = PACKING_C.CPO AND PACKING_E.ESTILO = PACKING_C.ESTILO AND PACKING_E.COLOR = PACKING_C.COLOR ) AS PRENDA FROM PACKING_E WHERE PACKING_E.EMBARQUE = '" & Embarque.Text & "'"
        llena_tablas(dt, strSQl, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("CPO")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("DESTINO")
            fg(l, 5) = dr("PRENDA")
            fecha.text = Format(dr("FECHA"), "dd/MM/yyyy")
            fg(l, 6) = False
            l = l + 1
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ok As Boolean
        busca_cerrado(ok)
        If ok Then
            llena_fg()
            Button2.Visible = False
            regresa.Visible = True
            E1.Visible = True
            G1.Visible = True
        End If

    End Sub
    Private Sub busca_cerrado(ByRef ok As Boolean)
        Dim strsql As String = "SELECT CPO,ESTILO,COLOR,ESTADO FROM CPO_D WHERE CPO+ESTILO+COLOR IN (SELECT DISTINCT CPO + ESTILO + COLOR FROM PACKING_E WHERE EMBARQUE = '" & Embarque.Text & "') AND ESTADO <> 'A'"
        Dim cr As New DataTable
        ok = True
        llena_tablas(cr, strsql, cnn)
        If cr.Rows.Count > 0 Then
            MsgBox("No se puede anular la Lista de Embarque, El CPO esta Cerrado", MsgBoxStyle.Critical, "Por favor Revise !!!")
            ok = False
        End If

    End Sub
    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        seguro = MsgBox("Esta completamente seguro de Eliminar las líneas Seleccionadas?  ", MsgBoxStyle.YesNo, "Eliminación de Lista de Empaque (Completa) !!!")
        If seguro = MsgBoxResult.Yes Then
            eliminacion()
            llena_empaque()
            setea_fg()
        End If
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        llena_empaque()
        setea_fg()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Embarque.Text) <> "" Then
                Button2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub eliminacion()
        Dim i As Integer
        Dim ok As Boolean
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 6) = True Then
                bitacora(fg(i, 1), fg(i, 2), fg(i, 3), ok)
                If ok Then
                    elimina_lineas(fg(i, 1), fg(i, 2), fg(i, 3))
                End If
            End If
        Next
    End Sub
    Private Sub bitacora(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String
        Dim afectados As Integer
        Dim obj As New empresas
        ok = False
        llena_tablas(dt, "SELECT * FROM PACKING_D WHERE CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'", cnn)

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            For Each dr In dt.Rows

                strsql = "INSERT INTO PACKING_R (EMBARQUE, CORTE, TIPO, CPO, ESTILO,COLOR, FECHA, CLIENTE,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,MOTIVO,USUARIO) VALUES ('" & _
                                                dr("EMBARQUE") & "','" & _
                                                dr("CORTE") & "','" & _
                                                dr("TIPO") & "','" & _
                                                dr("CPO") & "','" & _
                                                dr("ESTILO") & "','" & _
                                                dr("COLOR") & "','" & _
                                                Format(dr("FECHA"), "yyyy-MM-dd") & "','" & _
                                                dr("CLIENTE") & "','" & _
                                                dr("XS") & "','" & _
                                                dr("S") & "','" & _
                                                dr("M") & "','" & _
                                                dr("L") & "','" & _
                                                dr("XL") & "','" & _
                                                dr("XL2") & "','" & _
                                                dr("XL3") & "','" & _
                                                dr("XL4") & "','" & _
                                                dr("XL5") & "','" & _
                                                dr("XL6") & "','" & _
                                                motivo.Text & "','" & _
                                                obj.usuario & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next
            transaccion.Commit()
            ok = True
        Catch e As Exception
            Try
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
    '=================================================================================
    '                        Elimina Lista de empaque
    '=================================================================================
    Private Sub elimina_lineas(ByVal cpo As String, ByVal estilo As String, ByVal colores As String)
        Dim j As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim tip As String
        Dim tipo As String
        Dim destino As String = ""
        Dim talla As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
        Dim tallas As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
        Dim tl() As String = talla.Split("|")
        Dim ts() As String = tallas.Split("|")
        Dim pr(9) As Integer
        Dim se(9) As Integer
        Dim corte As String
        Dim dt As New DataTable()
        Dim stock As Boolean

        strsql = "SELECT * FROM PACKING_D WHERE EMBARQUE  = '" & Embarque.Text & "' AND CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR  = '" & colores & "'"
        llena_tablas(dt, strsql, cnn)

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "' AND CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR  = '" & colores & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE PACKING_E WHERE EMBARQUE = '" & Embarque.Text & "' AND CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR  = '" & colores & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For Each Me.dr In dt.Rows
                tipo = dr("TIPO")
                corte = dr("CORTE")
                If Mid(corte, 1, 3) = "ST-" Then
                    corte = Mid(corte, 4)
                    stock = True
                Else
                    stock = False
                End If
                strsql = "DELETE EMBARQUES WHERE EMBARQUE = '" & Embarque.Text & "' AND CORTE = '" & corte & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                ' ================ ACTUALIZA EMBARQUES ==============================
                If Mid(tipo, 1, 1) = "P" Then
                    strsql = "UPDATE CORTES_E SET P0 = P0 - " & dr(8) & ", P1 = P1 - " & dr(9) & ", P2 = P2 - " & dr(10) & ",P3 = P3 - " & dr(11) & _
                        ", P4 = P4 - " & dr(12) & ", P5 = P5 - " & dr(13) & ", P6 = P6 - " & dr(14) & ", P7 = P7 - " & dr(15) & _
                        ", P8 = P8 - " & dr(16) & ", P9 = P9 - " & dr(17) & " WHERE CORTE = '" & corte & "'"
                Else
                    strsql = "UPDATE CORTES_E SET S0 = S0 - " & dr(8) & ", S1 = S1 - " & dr(9) & ", S2 = S2 - " & dr(10) & ",S3 = S3 - " & dr(11) & _
                                                ", S4 = S4 - " & dr(12) & ", S5 = S5 - " & dr(13) & ", S6 = S6 - " & dr(14) & ", S7 = S7 - " & dr(15) & _
                                                ", S8 = S8 - " & dr(16) & ", S9 = S9 - " & dr(17) & " WHERE CORTE = '" & corte & "'"
                End If
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                ' =================================== ACTUALIZA EXPORTACION DEL CORTE ==============
                strsql = "UPDATE CORTES SET EXPORTADO = 'N' WHERE CORTE = '" & corte & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
                '======================================= ACTUALIZA STOCK =============================
                If stock Then
                    If Mid(tipo, 1, 1) = "P" Then
                        tip = "00"
                    Else
                        tip = "01"
                    End If
                    ' =============== SALIDAS STOCK
                    strsql = "DELETE S_STOCK WHERE EMBARQUE = '" & Embarque.Text & "' AND CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR  = '" & colores & "'  AND TIPO = '" & tip & "'"
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()

                    For j = 8 To 17
                        If dr(j) > 0 Then
                            ' =============== INVENTARIO STOCK
                            strsql = "UPDATE STOCK SET UNIDADES = UNIDADES + " & dr(j) & " WHERE ESTILO = '" & estilo & "' AND COLOR = '" & colores & "' AND TIPO = '" & tip & "' AND TALLA = '" & ts(j - 8) & "' AND CLIENTE = '" & dr("CLIENTE") & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()

                            ' =============== ENTRADAS STOCK
                            strsql = "UPDATE E_STOCK SET EXPORT = EXPORT - " & dr(j) & " WHERE CORTE = '" & corte & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colores & "' AND TIPO = '" & tip & "' AND TALLA = '" & ts(j - 8) & "'"
                            comando.CommandText = strsql
                            afectados = comando.ExecuteNonQuery()
                        End If
                    Next j
                End If
            Next

            strsql = "DELETE PACKING_D WHERE EMBARQUE = '" & Embarque.Text & "' AND CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR  = '" & colores & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
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


    '=================================================================================
    '                        Actualiza destino
    '=================================================================================
    Private Sub actualiza()
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
                strSQl = "UPDATE PACKING_E SET DESTINO = '" & fg(i, 4) & "' WHERE EMBARQUE = '" & Embarque.Text & "' AND CPO = '" & fg(i, 1) & "' AND ESTILO = '" & fg(i, 2) & "' AND COLOR  = '" & fg(i, 3) & "'"
                comando.CommandText = strSQl
                afectados = comando.ExecuteNonQuery()
            Next
            transaccion.Commit()

        Catch e As Exception
            Try
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


    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        actualiza()
        llena_empaque()
        setea_fg()
    End Sub


    Private Sub embarque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Embarque.KeyPress
        AutoCompletar(Embarque, e)
    End Sub

    Private Sub motivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles motivo.KeyPress
        AutoCompletar(motivo, e)
    End Sub

End Class



