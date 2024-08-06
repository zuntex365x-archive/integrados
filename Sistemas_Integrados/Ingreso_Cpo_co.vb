Imports C1.Win.C1FlexGrid
Public Class Ingreso_Cpo_co
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim strsql As String
    Dim ca As New DataTable()
    Dim ve As New DataTable()
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
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Ingreso_Cpo_co))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "4,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:850;AllowSorting:False;Name:""CPO"";Caption:""CPO"";AllowEditing:False;TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:120;AllowSorting:False;Captio" & _
        "n:""PROCESAR"";DataType:System.Boolean;TextAlign:CenterCenter;TextAlignFixed:Cente" & _
        "rCenter;ImageAlign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Name:""LOTE"";Cap" & _
        "tion:""LOTE"";Visible:False;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1008, 632)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 12pt;Border:Flat,1,LightGray,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackCol" & _
        "or:130, 223, 153;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Back" & _
        "Color:143, 158, 243;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highligh" & _
        "t;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColo" & _
        "r:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;F" & _
        "oreColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "S" & _
        "ubtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Control" & _
        "DarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackColor:G" & _
        "old;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Bitmap)
        Me.G1.Location = New System.Drawing.Point(968, 8)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 79
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.G1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(96, 8)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(240, 26)
        Me.cliente.TabIndex = 82
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.ColumnInfo = "6,1,0,0,0,95,Columns:0{Width:142;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "1{Width:174;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:262;}" & Microsoft.VisualBasic.ChrW(9) & "5{Name:""LOTE"";Caption:""LOTE"";Visible:False;DataType" & _
        ":System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.Location = New System.Drawing.Point(0, 400)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 25
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.jg.Size = New System.Drawing.Size(976, 272)
        Me.jg.StyleInfo = "Normal{Font:Tahoma, 12pt;Border:Flat,1,LightGray,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackCol" & _
        "or:130, 223, 153;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Back" & _
        "Color:143, 158, 243;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highligh" & _
        "t;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColo" & _
        "r:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;F" & _
        "oreColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "S" & _
        "ubtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Control" & _
        "DarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackColor:G" & _
        "old;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 84
        Me.jg.Visible = False
        '
        'Ingreso_Cpo_co
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg, Me.jg, Me.Label1, Me.cliente, Me.G1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Cpo_co"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparacion y Registro de CPOS"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Ingreso_Cpo_co_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_clientes_cpo(cliente)
        If cliente.Items.Count > 0 Then
            cliente.SelectedIndex = 0
            G1.Visible = True
        End If
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim l As Integer = 1
        'PARAMETRO CPO_FILTER SIRVE PARA ENCENDER EL SWITCH QUITARLO SI EXISTE ALGUN PROBLEMA TABLE T_PARAMETROS
        Dim strsql As String = "SELECT CPO_D1.*, CLIENTE, F_PEDIDO FROM CPO_D1 LEFT JOIN CPO_1 ON CPO_D1.CPO = CPO_1.CPO WHERE CLIENTE =  '" & cliente.Text & "' AND ( NOT EXISTS (SELECT 1 FROM T_PARAMETROS WHERE LLAVE = 'CPO_FILTER') OR NOT EXISTS (SELECT 1 FROM CPO_D WHERE CPO_D.CPO = CPO_D1.CPO AND CPO_D.ESTILO = CPO_D1.ESTILO AND CPO_D.COLOR = CPO_D1.COLOR))"
        llena_tablas(ca, strsql, cnn)
        For Each dr In ca.Rows
            l = fg.FindRow(dr("CPO"), 1, 1, False)
            If l < 1 Then
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                fg(l, 1) = dr("CPO")
            End If
        Next
        strsql = "SELECT CPO_D2.*, CLIENTE, F_PEDIDO FROM CPO_D2 LEFT JOIN CPO_2 ON CPO_D2.CPO = CPO_2.CPO WHERE CLIENTE = '" & cliente.Text & "'"
        llena_tablas(ve, strsql, cnn)
        For Each dr In ve.Rows
            l = fg.FindRow(dr("CPO"), 1, 1, False)
            If l < 1 Then
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                fg(l, 1) = dr("CPO")
            End If
        Next
    End Sub

    Private Sub clientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        seguro = MsgBox("Seguro de Actualizar los CPO's seleccionados?  ", MsgBoxStyle.YesNo, "Actualizando CPO's !!!")
        If seguro = MsgBoxResult.Yes Then
            actualizaciones()
        End If
    End Sub

    Private Sub actualizaciones()
        Dim i As Integer
        Dim t As Integer
        Dim cpo As String
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 2) = True Then
                cpo = fg(i, 1)
                procesa(cpo)
                t = t + 1
            End If
        Next
        If t = 0 Then
            MsgBox("Aún no ha elegido CPO's para Actualizar !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!!")
            Exit Sub
        End If
        Close()
    End Sub


    Private Sub procesa(ByVal cpo As String)
        Dim i As Integer
        Dim l As Integer
        Dim j As Integer
        Dim estilo As String
        Dim col As String
        Dim dr As DataRow
        Dim jr As DataRow
        Dim dd As DataRow()
        Dim estilol As String
        Dim ok As Boolean
        Dim ti As String = "CPO|ESTILO|COLOR|XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL|TOTAL|F_ENTREGA|F_PROMETIDA|DESTINO|COSTO XS|COSTO S|COSTO M|COSTO L|COSTO XL|COSTO 2XL|COSTO 3XL|COSTO 4XL|COSTO 5XL|COSTO 6XL|F_CAPTACION|USUARIO|VENDEDOR|COMISION|CLIENTE|F_PEDIDO|"
        Dim t As String()
        Dim c1 As String
        Dim c2 As String
        Dim u1 As String
        Dim u2 As String
        Dim malos As String = ""
        jg.Rows.Count = 1
        t = ti.Split("|")
        jg.Rows.Count = 1
        dd = ca.Select("CPO = '" & cpo & "'")
        If dd.Length > 0 Then
            For Each dr In dd
                l = jg.Rows.Count
                jg.Rows.Count = l + 1
                jg(l, 1) = dr("ESTILO")
                jg(l, 2) = dr("COLOR")
                estilol = dr("ESTILO") & dr("COLOR")
                jg(l, 0) = estilol
            Next
        End If
        dd = ve.Select("CPO = '" & cpo & "'")
        If dd.Length > 0 Then
            For Each dr In dd
                estilol = dr("ESTILO") & dr("COLOR")
                l = jg.FindRow(estilol, 1, 0, False)
                If l < 1 Then
                    l = jg.Rows.Count
                    jg.Rows.Count = l + 1
                    jg(l, 1) = dr("ESTILO")
                    jg(l, 2) = dr("COLOR")
                    jg(l, 0) = estilol
                End If
            Next
        End If
        jg.Sort(SortFlags.Ascending, 0)
        ok = True
        For i = 1 To jg.Rows.Count - 1
            estilo = jg(i, 1)
            col = jg(i, 2)
            dd = ca.Select("CPO + ESTILO + COLOR = '" & cpo + estilo + col & "'")
            If dd.Length > 0 Then
                dr = dd(0)
            Else
                dr = Nothing
            End If
            dd = ve.Select("CPO + ESTILO + COLOR = '" & cpo + estilo + col & "'")
            If dd.Length > 0 Then
                jr = dd(0)
            Else
                jr = Nothing
            End If
            For j = 1 To 30
                Try
                    c1 = dr(j)
                Catch
                    c1 = ""
                End Try
                Try
                    c2 = jr(j)
                Catch
                    c2 = ""
                End Try
                Try
                    u1 = dr("USUARIO")
                Catch
                    u1 = ""
                End Try
                Try
                    u2 = jr("USUARIO")
                Catch
                    u2 = ""
                End Try

                If c1 <> c2 Then
                    If (j < 27 Or j > 28) Then
                        malos = malos + t(j) + vbCr
                        ok = False
                    End If
                    graba_distinto(cpo, estilo, col, t(j), c1, c2, u1, u2)
                End If
            Next
        Next
        If ok Then
            graba_cpo(cpo)
        Else
            MsgBox("Existen Inconsistencias. Por favor Revisar !!!!" + vbCr + malos, MsgBoxStyle.Critical, "Cpo " & cpo & " No actualizada")
        End If
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_distinto(ByVal cpo As String, ByVal estilo As String, ByVal col As String, ByVal colu As String, ByVal c1 As String, ByVal c2 As String, ByVal u1 As String, ByVal u2 As String)
        Dim strsql As String
        Dim afectados As Integer
        Dim hoy As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '==================== DIARIO =========================================
            strsql = "INSERT INTO CPO_DIF(CLIENTE,CPO,ESTILO,COLOR,COLUMNA,INGRESO,VERIFICACION,FECHA,USUARIO1,USUARIO2) VALUES ('" & cliente.Text & "','" & cpo & "','" & estilo & "','" & col & "','" & colu & "','" & c1 & "','" & c2 & "','" & hoy & "','" & u1 & "','" & u2 & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub graba_cpo(ByVal cpo As String)
        Dim strsql As String
        Dim afectados As Integer
        Dim hoy As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim f_pedido As String
        Dim f_entrega As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            dd = ca.Select("CPO = '" & cpo & "'")
            If dd.Length > 0 Then
                dr = dd(0)
            Else
                dr = Nothing
            End If
            f_pedido = Format(dr("F_PEDIDO"), "yyyy-MM-dd")
            f_entrega = Format(dr("F_ENTREGA"), "yyyy-MM-dd")


            '==================== ENCABEZADO  =========================================
            strsql = "INSERT INTO CPO (CPO,CLIENTE,F_PEDIDO,F_ENTREGA,PEDIDO,BOM) " & _
                    "VALUES ( '" & cpo & "','" & _
                        dr("CLIENTE") & "','" & _
                        f_pedido & "','" & _
                        f_entrega & "',0,0)"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For Each dr In dd

                strsql = "INSERT INTO CPO_D (CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,ESTADO,F_ENTREGA,F_PROMETIDA,DESTINO,F_INGRESO,VENDEDOR,COMISION,ESCALA,MINIMO_P,MAXIMO_P) " & _
                            "VALUES ( '" & cpo & "','" & _
                                dr("ESTILO") & "','" & _
                                dr("COLOR") & "','" & _
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
                                dr("TOTAL") & "','A','" & _
                                f_entrega & "','" & _
                                f_entrega & "','" & _
                                dr("DESTINO") & "',getdate(),'" & _
                                dr("VENDEDOR") & "','" & _
                                dr("COMISION") & "','" & _
                                dr("ESCALA") & "','" & _
                                dr("MINIMO_P") & "','" & _
                                dr("MAXIMO_P") & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                strsql = "INSERT INTO CPO_COSTO (CPO,ESTILO,COLOR,C1,C2,C3,C4,C5,C6,C7,C8,C9,C0) " & _
                                         "VALUES ( '" & cpo & "','" & _
                                            dr("ESTILO") & "','" & _
                                            dr("COLOR") & "','" & _
                                            dr("C1") & "','" & _
                                            dr("C2") & "','" & _
                                            dr("C3") & "','" & _
                                            dr("C4") & "','" & _
                                            dr("C5") & "','" & _
                                            dr("C6") & "','" & _
                                            dr("C7") & "','" & _
                                            dr("C8") & "','" & _
                                            dr("C9") & "','" & _
                                            dr("C0") & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next


            strsql = "DELETE FROM CPO_1 WHERE CPO = '" & cpo & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE FROM CPO_2 WHERE CPO = '" & cpo & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE FROM CPO_D1 WHERE CPO = '" & cpo & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE FROM CPO_D2 WHERE CPO = '" & cpo & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()


        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.  CPO = " & cpo, MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente.SelectedIndexChanged
        setea_grid()
        llena_grid()
    End Sub
End Class
