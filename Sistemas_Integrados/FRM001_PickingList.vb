Public Class FRM001_PickingList
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM001_PickingList))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1FlexGridClassic1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.C1FlexGrid3 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.C1FlexGrid4 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 32)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Corte"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(288, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'C1FlexGridClassic1
        '
        Me.C1FlexGridClassic1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.C1FlexGridClassic1.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.C1FlexGridClassic1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGridClassic1.Name = "C1FlexGridClassic1"
        Me.C1FlexGridClassic1.NodeClosedPicture = Nothing
        Me.C1FlexGridClassic1.NodeOpenPicture = Nothing
        Me.C1FlexGridClassic1.OutlineCol = -1
        Me.C1FlexGridClassic1.Size = New System.Drawing.Size(240, 150)
        Me.C1FlexGridClassic1.TabIndex = 0
        Me.C1FlexGridClassic1.TreeColor = System.Drawing.Color.DarkGray
        '
        'C1FlexGrid3
        '
        Me.C1FlexGrid3.AllowEditing = False
        Me.C1FlexGrid3.ColumnInfo = resources.GetString("C1FlexGrid3.ColumnInfo")
        Me.C1FlexGrid3.Location = New System.Drawing.Point(27, 79)
        Me.C1FlexGrid3.Name = "C1FlexGrid3"
        Me.C1FlexGrid3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.C1FlexGrid3.Size = New System.Drawing.Size(1500, 42)
        Me.C1FlexGrid3.TabIndex = 3
        Me.C1FlexGrid3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "¿Cuántas cajas desea?"
        Me.Label3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(288, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SandyBrown
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(476, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 41)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Revisar"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'C1FlexGrid4
        '
        Me.C1FlexGrid4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid4.ColumnInfo = resources.GetString("C1FlexGrid4.ColumnInfo")
        Me.C1FlexGrid4.Location = New System.Drawing.Point(29, 261)
        Me.C1FlexGrid4.Name = "C1FlexGrid4"
        Me.C1FlexGrid4.Rows.Count = 300
        Me.C1FlexGrid4.Size = New System.Drawing.Size(1136, 330)
        Me.C1FlexGrid4.TabIndex = 12
        Me.C1FlexGrid4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(749, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(234, 41)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Agregar Corte a Cajas"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SandyBrown
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(489, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 41)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Reiniciar Cajas"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(438, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 41)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Reiniciar Corte"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'FRM001_PickingList
        '
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1197, 615)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.C1FlexGrid4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.C1FlexGrid3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FRM001_PickingList"
        Me.Text = "FRM001_PickingList"
        CType(Me.C1FlexGridClassic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Dim cnx As New SqlClient.SqlConnection()

    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim strsql As String
    Dim n As Integer
    Dim t As Integer
    Dim corre As Integer
    Dim corteSelected As String = ""
    Dim inicial As String = ""
    Dim resulta As MsgBoxResult
    Dim cajas As Integer = 1
    Dim totCajas As Integer = 1

    Dim totalesN As Integer = 0
    Dim totalesT As Integer = 0
    Dim totales As Integer = 0
    Dim xsTotales As Integer = 0
    Dim sTotales As Integer = 0
    Dim mTotales As Integer = 0
    Dim lTotales As Integer = 0
    Dim xlTotales As Integer = 0
    Dim xl2Totales As Integer = 0
    Dim xl3Totales As Integer = 0
    Dim xl4Totales As Integer = 0
    Dim xl5Totales As Integer = 0
    Dim xl6Totales As Integer = 0

    Dim total As Integer = 0
    Dim xs As Integer = 0
    Dim s As Integer = 0
    Dim m As Integer = 0
    Dim l As Integer = 0
    Dim xl As Integer = 0
    Dim xl2 As Integer = 0
    Dim xl3 As Integer = 0
    Dim xl4 As Integer = 0
    Dim xl5 As Integer = 0
    Dim xl6 As Integer = 0

    Dim valid As Integer = 0
    Dim validCaja As Integer = 0
    Dim validMsg As String = "Debe Ingresar Cortes en las Cajas"

    Dim cliente As String
    Dim seccion As String
    Dim escala As String

    Dim consulta As Boolean = False

    'Constructor
    Public Sub New()
        MyBase.New

        InitializeComponent()

    End Sub

    Private Sub FRM001_PickingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim empresas As New empresas()
        cnx.ConnectionString = empresas.constr
        strsql = "SELECT X.CORTE FROM CORTES X WHERE X.EXPORTADO = 'N' AND NOT EXISTS (SELECT 1 FROM CAJAS01 WHERE CORTE = X.CORTE) ORDER BY X.CORTE"
        llena_combos(ComboBox1, strsql, "CORTE") ' LLENADO DEL COMBO BOX DE LOS CORTES


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dr As DataRow

        ' NUMERO DE CORTE SELECCIONADO

        strsql = "select CORTES.CORTE, CORTES.CLIENTE, CORTES.CPO, CORTES.COLOR, CORTES.FCORTE, CORTES.XS, CORTES.S, CORTES.M, CORTES.L, CORTES.XL, CORTES.XL2, CORTES.XL3, CORTES.XL4, CORTES.XL5, CORTES.XL6, CORTES.TOTAL, CORTES.SECCION, CPO_D.ESCALA from CORTES INNER JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.COLOR = CPO_D.COLOR where CORTES.CORTE = '" & ComboBox1.Text & "' and NOT EXISTS (SELECT 1 FROM CAJAS01 WHERE CORTE = CORTES.CORTE)"
        llena_tablas(dt, strsql, cnx)

        C1FlexGrid3(0, 1) = "CORTE"
        C1FlexGrid3(0, 2) = "CLIENTE"
        C1FlexGrid3(0, 3) = "CPO"
        C1FlexGrid3(0, 4) = "COLOR"
        C1FlexGrid3(0, 5) = "XS"
        C1FlexGrid3(0, 6) = "S"
        C1FlexGrid3(0, 7) = "M"
        C1FlexGrid3(0, 8) = "L"
        C1FlexGrid3(0, 9) = "XL"
        C1FlexGrid3(0, 10) = "XL2"
        C1FlexGrid3(0, 11) = "XL3"
        C1FlexGrid3(0, 12) = "XL4"
        C1FlexGrid3(0, 13) = "XL5"
        C1FlexGrid3(0, 14) = "XL6"
        C1FlexGrid3(0, 15) = "TOTAL"
        C1FlexGrid3(0, 16) = "FCORTE"
        C1FlexGrid3(0, 17) = "SECCION"

        'If dt.Rows.Count = 0 Then
        'consulta = True

        'strsql = "select CORTES.CORTE, CORTES.CLIENTE, CORTES.CPO, CORTES.COLOR, CORTES.FCORTE, CORTES.XS, CORTES.S, CORTES.M, CORTES.L, CORTES.XL, CORTES.XL2, CORTES.XL3, CORTES.XL4, CORTES.XL5, CORTES.XL6, CORTES.TOTAL, CORTES.SECCION, CPO_D.ESCALA from CORTES INNER JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.COLOR = CPO_D.COLOR where CORTES.CORTE = '" & ComboBox1.Text & "' and EXISTS (SELECT 1 FROM CAJAS01 WHERE CORTE = CORTES.CORTE)"
        'llena_tablas(dt, strsql, cnx)
        'End If

        C1FlexGrid3.Rows.Count = dt.Rows.Count + 1
        n = 1

        ' PROCESAMIENTO DE LA BUSQUEDA DEL CORTE
        For Each dr In dt.Rows
            C1FlexGrid3(n, 1) = dr("CORTE")
            C1FlexGrid3(n, 2) = dr("CLIENTE")
            C1FlexGrid3(n, 3) = dr("CPO")
            C1FlexGrid3(n, 4) = dr("COLOR")
            C1FlexGrid3(n, 5) = dr("XS")
            C1FlexGrid3(n, 6) = dr("S")
            C1FlexGrid3(n, 7) = dr("M")
            C1FlexGrid3(n, 8) = dr("L")
            C1FlexGrid3(n, 9) = dr("XL")
            C1FlexGrid3(n, 10) = dr("XL2")
            C1FlexGrid3(n, 11) = dr("XL3")
            C1FlexGrid3(n, 12) = dr("XL4")
            C1FlexGrid3(n, 13) = dr("XL5")
            C1FlexGrid3(n, 14) = dr("XL6")
            C1FlexGrid3(n, 15) = dr("TOTAL")
            C1FlexGrid3(n, 16) = dr("FCORTE")
            C1FlexGrid3(n, 17) = dr("SECCION")

            cliente = dr("CLIENTE")
            seccion = dr("SECCION")
            escala = dr("ESCALA")

            ' INSTANCIA DE TOTALES GLOBALES DE LA BUSQUEDA DEL CORTE
            xs = dr("XS")
            s = dr("S")
            m = dr("M")
            l = dr("L")
            xl = dr("XL")
            xl2 = dr("XL2")
            xl3 = dr("XL3")
            xl4 = dr("XL4")
            xl5 = dr("XL5")
            xl6 = dr("XL6")
            total = dr("TOTAL")
            n = n + 1
        Next dr

        C1FlexGrid3.Visible = True
        Label3.Visible = True
        TextBox2.Visible = True
        Button2.Visible = True
        Button5.Visible = True
        TextBox2.Select()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        resulta = MsgBox("ESTA SEGURO DE PROCESAR CAJAS", MsgBoxStyle.YesNo, "CAJAS")
        If resulta = MsgBoxResult.Yes Then

            ' PROCESAMIENTO DE CAJAS
            'MsgBox("CAJA PROCESADAS")
            'MsgBox("CAJAS: " & TextBox2.Text & vbCrLf & "FECHA: " & DateTimePicker1.Value & vbCrLf)
            Button2.Visible = False
            C1FlexGrid4.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            cajas = Integer.Parse(TextBox2.Text)
            totCajas = cajas + 1


            C1FlexGrid4(0, 1) = "CAJA"
            C1FlexGrid4(0, 2) = "XS"
            C1FlexGrid4(0, 3) = "S"
            C1FlexGrid4(0, 4) = "M"
            C1FlexGrid4(0, 5) = "L"
            C1FlexGrid4(0, 6) = "XL"
            C1FlexGrid4(0, 7) = "XL2"
            C1FlexGrid4(0, 8) = "XL3"
            C1FlexGrid4(0, 9) = "XL4"
            C1FlexGrid4(0, 10) = "XL5"
            C1FlexGrid4(0, 11) = "XL6"
            C1FlexGrid4(0, 12) = "TOTAL"

            ' INTEGRANDO EL NUMERO DE CAJAS SELECCIONADO
            For n = 1 To cajas

                C1FlexGrid4(n, 1) = n

                C1FlexGrid4(n, 12) = 0

            Next
            C1FlexGrid4(n, 1) = "TOTAL"
            C1FlexGrid4(n, 2) = 0
            C1FlexGrid4(n, 3) = 0
            C1FlexGrid4(n, 4) = 0
            C1FlexGrid4(n, 5) = 0
            C1FlexGrid4(n, 6) = 0
            C1FlexGrid4(n, 7) = 0
            C1FlexGrid4(n, 8) = 0
            C1FlexGrid4(n, 9) = 0
            C1FlexGrid4(n, 10) = 0
            C1FlexGrid4(n, 11) = 0
            C1FlexGrid4(n, 12) = 0
            C1FlexGrid4.Select()

        ElseIf resulta = DialogResult.No Then
            'Me.Close()
        End If

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' REINCIIO DEL PROCESAMIENTO DE LAS CAJAS
        Button2.Visible = True
        Button3.Visible = False
        Button4.Visible = False
        C1FlexGrid4.Visible = False
        Me.C1FlexGrid4.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)
        TextBox2.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' REINICIO DE BUSQUEDA DEL CORTE
        C1FlexGrid3.Visible = False
        Me.C1FlexGrid3.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)
        Label3.Visible = False
        TextBox2.Text = ""
        TextBox2.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        C1FlexGrid4.Visible = False
        Me.C1FlexGrid4.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Validacion_Totales()

        resulta = MsgBox("ESTA SEGURO DE PROCESAR DE CORTE A CAJAS", MsgBoxStyle.YesNo, "CORTE")
        If resulta = MsgBoxResult.Yes Then

            ' VALIDACION DE PROCESAMIENTO DEL CORTE, SI EL CORTE ESTA CORRECTO EN CAJAS
            If valid = 1 Then

                Dim obj As New empresas
                Dim pre As String = ""
                Dim h As String = "0000000"

                If obj.numero = "1" Then
                    pre = "JT"
                ElseIf obj.numero = "3" Then
                    pre = "ZU"
                End If

                cnx.Open()
                ' Comienza la transacción
                Dim transaccion As SqlClient.SqlTransaction = cnx.BeginTransaction()

                ' Crea el comando para la transacción
                Dim comando As SqlClient.SqlCommand = cnx.CreateCommand()
                comando.Transaction = transaccion
                Dim afectados As Int32
                Dim final As String

                Try
                    strsql = "SELECT CORRELATIVO FROM CAJAS02"
                    comando.CommandText = strsql
                    Dim k As Int32 = comando.ExecuteScalar()
                    corre = k.ToString
                    inicial = pre + Format(corre + 1, h)

                    For i = 1 To C1FlexGrid4.Rows.Count - 2
                        For j = 2 To 11
                            If CInt(C1FlexGrid4(i, j)) > 0 And C1FlexGrid4(i, 1) <> "TOTAL" Then

                                strsql = "INSERT INTO CAJAS01 (CAJA,CORTE,TALLA,TIPO,UNIDADES,CLIENTE,UBICACION,FECHA,ESTADO,ESCALA,ORDEN,IMPRESO,TIPO_SEG,SECCION) VALUES ('" &
                                               pre + Format(corre + i, h) & "','" & ComboBox1.Text & "','" &
                                               C1FlexGrid4(0, j) & "','P','" &
                                               C1FlexGrid4(i, j) & "','" & cliente & "','00',GETDATE(),'A','" &
                                               escala & "','" & (j - 2) & "','" & obj.usuario & "','0','" & seccion & "')"
                                comando.CommandText = strsql
                                afectados = comando.ExecuteNonQuery()
                            End If


                        Next


                        strsql = "UPDATE CAJAS02 SET CORRELATIVO = CORRELATIVO + 1"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        final = pre + Format(corre + i, h)
                    Next

                    transaccion.Commit()

                    MsgBox("CORTE " & corteSelected & " PROCESADO")

                    Me.Close()

                Catch ex As Exception
                    Try
                        MsgBox(ex.Message)
                        transaccion.Rollback()
                    Catch exc As SqlClient.SqlException
                        If Not transaccion.Connection Is Nothing Then
                            MsgBox("Ocurrió un error de tipo " & exc.GetType().ToString() &
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                        End If
                    End Try
                Finally
                    cnx.Close()
                End Try

            Else

                MsgBox("Error en CORTE: " & corteSelected & vbCrLf & " Detalle: " & validMsg)

            End If

        ElseIf resulta = DialogResult.No Then
            'Me.Close()
        End If
    End Sub

    Private Sub ValidarCantidades2(sender As Object, e As EventArgs) Handles C1FlexGrid4.LeaveCell

        C1FlexGrid4(totCajas, 2) = 0
        C1FlexGrid4(totCajas, 3) = 0
        C1FlexGrid4(totCajas, 4) = 0
        C1FlexGrid4(totCajas, 5) = 0
        C1FlexGrid4(totCajas, 6) = 0
        C1FlexGrid4(totCajas, 7) = 0
        C1FlexGrid4(totCajas, 8) = 0
        C1FlexGrid4(totCajas, 9) = 0
        C1FlexGrid4(totCajas, 10) = 0
        C1FlexGrid4(totCajas, 11) = 0
        C1FlexGrid4(totCajas, 12) = 0

        ' SUMATORIA DE TALLAS
        For n = 1 To cajas

            C1FlexGrid4(n, 12) = 0

            For t = 2 To 11

                C1FlexGrid4(n, 12) = C1FlexGrid4(n, t) + C1FlexGrid4(n, 12)
                C1FlexGrid4(totCajas, t) = C1FlexGrid4(n, t) + C1FlexGrid4(totCajas, t)

            Next

        Next

        Validacion_Totales()

    End Sub

    Private Sub Validacion_Totales()

        ' SUMA DE TOTALES POR TALLA
        totalesN = 0

        For n = 2 To 11

            totalesN = totalesN + C1FlexGrid4(totCajas, n)

        Next

        ' SUMA DE TOTALES POR CAJAS
        totalesT = 0

        For n = 1 To cajas

            If CInt(C1FlexGrid4(n, 12)) = 0 Or IsNothing(C1FlexGrid4(n, 12)) Then
                validCaja = 0
                Exit For
            Else
                validCaja = 1
            End If

            totalesT = totalesT + C1FlexGrid4(n, 12)

        Next

        ' VALIDANDO VARIABLES DE TALLAS
        xsTotales = C1FlexGrid4(totCajas, 2)
        sTotales = C1FlexGrid4(totCajas, 3)
        mTotales = C1FlexGrid4(totCajas, 4)
        lTotales = C1FlexGrid4(totCajas, 5)
        xlTotales = C1FlexGrid4(totCajas, 6)
        xl2Totales = C1FlexGrid4(totCajas, 7)
        xl3Totales = C1FlexGrid4(totCajas, 8)
        xl4Totales = C1FlexGrid4(totCajas, 9)
        xl5Totales = C1FlexGrid4(totCajas, 10)
        xl6Totales = C1FlexGrid4(totCajas, 11)


        ' VALIDACIONES PARA  PODER PROCESAR EL CORTE
        If validCaja = 1 Then
            If xsTotales = xs Then
                If sTotales = s Then
                    If mTotales = m Then
                        If lTotales = l Then
                            If xlTotales = xl Then
                                If xl2Totales = xl2 Then
                                    If xl3Totales = xl3 Then
                                        If xl4Totales = xl4 Then
                                            If xl5Totales = xl5 Then
                                                If xl6Totales = xl6 Then
                                                    If totalesN = totalesT Then
                                                        totales = totalesN
                                                        C1FlexGrid4(totCajas, 12) = totales
                                                        If totales = total Then
                                                            valid = 1
                                                        Else
                                                            totales = 0
                                                            valid = 0
                                                            validMsg = "Los totales no son Iguales - Corte vs Cajas"
                                                        End If
                                                    Else
                                                        totales = 0
                                                        valid = 0
                                                        validMsg = "Los totales no son Iguales - Cajas vs Tallas"
                                                    End If
                                                Else
                                                    valid = 0
                                                    validMsg = "Los totales de la Talla XL6 no son Iguales - Cajas vs Tallas"
                                                End If
                                            Else
                                                valid = 0
                                                validMsg = "Los totales de la Talla XL no son Iguales - Cajas vs Tallas"
                                            End If
                                        Else
                                            valid = 0
                                            validMsg = "Los totales de la Talla XL4 no son Iguales - Cajas vs Tallas"
                                        End If
                                    Else
                                        valid = 0
                                        validMsg = "Los totales de la Talla XL3 no son Iguales - Cajas vs Tallas"
                                    End If
                                Else
                                    valid = 0
                                    validMsg = "Los totales de la Talla XL2 no son Iguales - Cajas vs Tallas"
                                End If
                            Else
                                valid = 0
                                validMsg = "Los totales de la Talla XL no son Iguales - Cajas vs Tallas"
                            End If
                        Else
                            valid = 0
                            validMsg = "Los totales de la Talla L no son Iguales - Cajas vs Tallas"
                        End If
                    Else
                        valid = 0
                        validMsg = "Los totales de la Talla M no son Iguales - Cajas vs Tallas"
                    End If
                Else
                    valid = 0
                    validMsg = "Los totales de la Talla S no son Iguales - Cajas vs Tallas"
                End If
            Else
                valid = 0
                validMsg = "Los totales de la Talla XS no son Iguales - Cajas vs Tallas"
            End If
        Else
            valid = 0
            validMsg = "No puede queda una caja vacia"
        End If

    End Sub

    Private Sub handleEnter(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then

            Button1.Select()

        End If
    End Sub

    Private Sub handleCajasEnter(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Button2.Select()
        End If
    End Sub
End Class