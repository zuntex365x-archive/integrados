Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Imports System.Transactions
Imports System.Data.SqlClient

Public Class Prod_T06
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim estados As New ComboBox()
    Friend WithEvents embarque As System.Windows.Forms.ComboBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Public le As New DataTable()
    Friend WithEvents graba As System.Windows.Forms.Button
    Dim dt As New DataTable

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prod_T06))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.embarque = New System.Windows.Forms.ComboBox()
        Me.sigue = New System.Windows.Forms.Button()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.graba = New System.Windows.Forms.Button()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Co
        '
        Me.Co.AllowEditing = False
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Co.ColumnInfo = resources.GetString("Co.ColumnInfo")
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(8, 61)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1288, 707)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 46
        '
        'embarque
        '
        Me.embarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.embarque.Items.AddRange(New Object() {"JT", "TRECENTO", "ZUNTEX"})
        Me.embarque.Location = New System.Drawing.Point(155, 17)
        Me.embarque.Name = "embarque"
        Me.embarque.Size = New System.Drawing.Size(364, 28)
        Me.embarque.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.embarque, "No. Embarque")
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(1141, 15)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(60, 40)
        Me.sigue.TabIndex = 105
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Chequeo de Datos")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Image)
        Me.Cancela.Location = New System.Drawing.Point(1216, 15)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(60, 40)
        Me.Cancela.TabIndex = 107
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" & _
        " Grabar.")
        Me.Cancela.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 28)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Embarque:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(1141, 15)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 109
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Prod_T06
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 792)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.Cancela)
        Me.Controls.Add(Me.embarque)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_T06"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verifica Listas de Empaque"
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler embarque.KeyPress, AddressOf keypressed1
        llena_combos(embarque, "SELECT DISTINCT EMBARQUE FROM PROD_TER04 WHERE ESTADO = 'A' ORDER BY EMBARQUE", "EMBARQUE")
        setea_co()
    End Sub

    Private Sub setea_co()
        Co.Rows.Count = 1
        Co.Rows(0).Height = 30
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(embarque.Text) <> "" Then
                embarque.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub sigue_Click(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        If Trim(embarque.Text) = "" Then
            MsgBox("El nombre del embarque no puede ir en blanco", MsgBoxStyle.Critical, "Por favor revise !!!")
            Exit Sub
        End If
        embarque.Enabled = False
        graba.Visible = True
        sigue.Visible = False
        llena_Co()
    End Sub

    Private Sub llena_Co()
        Dim dr As DataRow
        Dim l As Integer = Co.Rows.Count
        dt = New DataTable
        Dim strsql As String = "SELECT PROD_TER04.*,CORTES.CORTE,TIPO,PROD_TER01.ESCALA,ORDEN,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,DESTINO FROM PROD_TER04 LEFT JOIN PROD_TER01 ON PROD_TER04.CAJA = PROD_TER01.CAJA AND PROD_TER04.TALLA = PROD_TER01.TALLA LEFT JOIN CORTES ON PROD_TER01.CORTE = CORTES.CORTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D. ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE EMBARQUE = '" & embarque.Text & "' AND PROD_TER04.ESTADO = 'A'"
        llena_tablas(dt, strsql, cnn)
        Co.Rows.Count = Co.Rows.Count + dt.Rows.Count
        For Each dr In dt.Rows
            Co(l, 1) = dr("CPO")
            Co(l, 2) = dr("ESTILO")
            Co(l, 3) = dr("COLOR")
            Co(l, 4) = dr("CORTE")
            Co(l, 5) = dr("CAJA")
            Co(l, 6) = dr("TALLA")
            Co(l, 7) = dr("UNIDADES")
            Co(l, 8) = False
            l = l + 1
        Next
        lee_lector()
    End Sub
    Private Sub lee_lector()
        Dim cnn1 As New SqlClient.SqlConnection
        Dim dr As DataRow
        Dim l As Integer
        Dim f As Integer
        le = New DataTable
        Dim strsql As String = "SELECT * FROM EMB01 WHERE EMBARQUE = '" & embarque.Text & "' AND LEIDA = 'S'"
        cnn1.ConnectionString = lector_dc()
        llena_tablas_e(le, strsql, cnn1)
        For Each dr In le.Rows
            f = 1
            l = 1
            While l > 0
                l = Co.FindRow(dr("CAJA"), f, 5, False)
                If l > 0 Then
                    Co(l, 8) = True
                    f = l + 1
                End If
            End While
        Next
    End Sub

    Private Sub Cancela_Click(sender As System.Object, e As System.EventArgs) Handles Cancela.Click
        setea_co()
        sigue.Visible = True
        embarque.Enabled = True
        embarque.Focus()
    End Sub
    Private Sub revisa_embarque(ByRef ok As Boolean)
        Dim i As Integer
        For i = 1 To Co.Rows.Count - 1
            If Co(i, 8) = False Then
                MsgBox("Para efectuar el Embarque se necesitan todas las cajas scaneadas.", MsgBoxStyle.Critical, "Por favor revise !!!")
                ok = False
                Exit Sub
            End If
        Next
        ok = True
    End Sub

    Private Sub graba_Click(sender As System.Object, e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Crear la Lista de Empaque?  ", MsgBoxStyle.YesNo, "Una vez creada la Lista de empaque NO puede ser Modificada ni Eliminada.")
        If seguro = MsgBoxResult.Yes Then
            revisa_embarque(ok)
            If ok Then
                graba_datos()
                Close()
            End If
        End If
    End Sub
    Private Sub embarque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles embarque.KeyPress
        AutoCompletar(embarque, e)
    End Sub

    '============================= Actualiza la Base de Datos =============================
    Private Sub graba_datos()
        Dim dr As DataRow
        Dim strsql As String = ""
        Dim afectados As Integer
        Dim emp As New empresas
        Dim ta As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6|"
        Dim t(10) As String
        Dim pr(10) As Integer
        Dim se(10) As Integer
        Dim unidades As Integer
        Dim tal As String
        Dim cnn1 As String = ""
        Dim cnn2 As String = ""
        cnn1 = emp.constr + ";Enlist=False"
        cnn2 = lector_dc() + ";Enlist=False"
        t = Split(ta, "|")

        Try
            Using scope As New TransactionScope()
                Using connection1 As New SqlConnection(cnn1)

                    connection1.Open()

                    Dim command1 As SqlCommand = New SqlCommand(strsql, connection1)

                    For Each dr In dt.Rows
                        unidades = dr("UNIDADES")


                        strsql = "UPDATE PACKING_C SET PRENDAS = PRENDAS + " & dr("UNIDADES") & " WHERE EMBARQUE = '" & embarque.Text & _
                                                      "' AND CAJA = '" & dr("CAJA") & "' AND CPO = '" & dr("CPO") & _
                                                      "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & _
                                                      "' AND TIPO = '" & dr("TIPO") & "' AND TALLA = '" & dr("TALLA") & "'"
                        command1.CommandText = strsql
                        afectados = command1.ExecuteNonQuery()

                        If afectados = 0 Then
                            strsql = "INSERT INTO PACKING_C (EMBARQUE,CAJA,CPO,ESTILO,COLOR,TIPO,TALLA,PRENDAS) " & _
                                                 "VALUES ('" & embarque.Text & "','" & _
                                                                dr("CAJA") & "','" & _
                                                                dr("CPO") & "','" & _
                                                                dr("ESTILO") & "','" & _
                                                                dr("COLOR") & "','" & dr("TIPO") & "','" & _
                                                                dr("TALLA") & "','" & _
                                                                dr("UNIDADES") & "')"
                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()
                        End If


                        strsql = "UPDATE PACKING_E SET CAJA_F = '" & dr("CAJA") & "' WHERE EMBARQUE = '" & dr("EMBARQUE") & "' AND CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'"
                        command1.CommandText = strsql
                        afectados = command1.ExecuteNonQuery()

                        If afectados = 0 Then
                            strsql = "INSERT INTO PACKING_E (EMBARQUE,CPO,ESTILO,COLOR,CAJA_I,CAJA_F,FECHA,DESTINO,FACTURA,CONTENEDOR,MATPRI,FACTURADO) " & _
                                                   "VALUES ('" & dr("EMBARQUE") & "','" & _
                                                                 dr("CPO") & "','" & _
                                                                 dr("ESTILO") & "','" & _
                                                                 dr("COLOR") & "','" & _
                                                                 dr("CAJA") & "','" & _
                                                                 dr("CAJA") & "',GETDATE(),'" & _
                                                                 dr("DESTINO") & "','','',0,'N')"

                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()
                        End If

                        strsql = "UPDATE PACKING_D SET " & t(dr("ORDEN")) & " = " & t(dr("ORDEN")) & " + " & dr("UNIDADES") & "WHERE EMBARQUE = '" & dr("EMBARQUE") & "' AND CORTE = '" & dr("CORTE") & "' AND TIPO = '" & dr("TIPO") & "' AND CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'"
                        command1.CommandText = strsql
                        afectados = command1.ExecuteNonQuery()
                        If afectados = 0 Then
                            ReDim pr(10)
                            pr(dr("ORDEN")) = unidades
                            strsql = "INSERT INTO PACKING_D (EMBARQUE,CORTE,TIPO,CPO,ESTILO,COLOR,FECHA,CLIENTE,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6)  " & _
                                        "VALUES ('" & embarque.Text & "','" & _
                                                      dr("CORTE") & "','" & _
                                                      dr("TIPO") & "','" & _
                                                      dr("CPO") & "','" & _
                                                      dr("ESTILO") & "','" & _
                                                      dr("COLOR") & "',GETDATE(),'" & _
                                                      dr("CLIENTE") & "','" & _
                                                      pr(0) & "','" & _
                                                      pr(1) & "','" & _
                                                      pr(2) & "','" & _
                                                      pr(3) & "','" & _
                                                      pr(4) & "','" & _
                                                      pr(5) & "','" & _
                                                      pr(6) & "','" & _
                                                      pr(7) & "','" & _
                                                      pr(8) & "','" & _
                                                      pr(9) & "')"
                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()
                        End If
                        ' =================================== ACTUALIZA EXPORTACION DEL CORTE ==============
                        strsql = "UPDATE CORTES SET EXPORTADO = 'S' WHERE CORTE = '" & dr("CORTE") & "'"
                        command1.CommandText = strsql
                        afectados = command1.ExecuteNonQuery()
                        ' =================================== EMBARQUES  ==================== ==============
                        strsql = "UPDATE EMBARQUES SET PRENDAS = PRENDAS  + " & unidades & _
                                                              " WHERE EMBARQUE = '" & dr("EMBARQUE") & "' AND CORTE = '" & dr("CORTE") & "' " & _
                                                              " AND TIPO = '" & dr("TIPO") & "' AND TALLA = '" & dr("TALLA") & "'"

                        command1.CommandText = strsql
                        afectados = command1.ExecuteNonQuery()
                        If afectados = 0 Then
                            strsql = "INSERT INTO EMBARQUES (EMBARQUE,CORTE,TIPO,TALLA,FECHA,PRENDAS) " & _
                                                                "VALUES ( '" & dr("EMBARQUE") & "','" & _
                                                                   dr("CORTE") & "','" & _
                                                                   dr("TIPO") & "','" & _
                                                                   dr("TALLA") & "',GETDATE(),'" & _
                                                                   unidades & "')"

                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()
                        End If
                        ' =================================== CORTES EXPORTADOS  ==================================
                        tal = dr("TIPO") & dr("ORDEN")
                        strsql = "UPDATE CORTES_E SET " & tal & " = " & tal & " + " & unidades & " WHERE CORTE = '" & dr("CORTE") & "'"
                        command1.CommandText = strsql
                        afectados = command1.ExecuteNonQuery()
                        If afectados = 0 Then
                            ReDim pr(10)
                            If dr("TIPO") = "P" Then
                                pr(dr("ORDEN")) = unidades
                            Else
                                se(dr("ORDEN")) = unidades
                            End If

                            strsql = "INSERT INTO CORTES_E (CORTE,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9) " & _
                                "VALUES ( '" & dr("CORTE") & "','" & _
                                 pr(0) & "','" & _
                                 pr(1) & "','" & _
                                 pr(2) & "','" & _
                                 pr(3) & "','" & _
                                 pr(4) & "','" & _
                                 pr(5) & "','" & _
                                 pr(6) & "','" & _
                                 pr(7) & "','" & _
                                 pr(8) & "','" & _
                                 pr(9) & "','" & _
                                 se(0) & "','" & _
                                 se(1) & "','" & _
                                 se(2) & "','" & _
                                 se(3) & "','" & _
                                 se(4) & "','" & _
                                 se(5) & "','" & _
                                 se(6) & "','" & _
                                 se(7) & "','" & _
                                 se(8) & "','" & _
                                 se(9) & "')"
                            command1.CommandText = strsql
                            afectados = command1.ExecuteNonQuery()
                        End If
                    Next

                    strsql = "UPDATE PROD_TER01 SET ESTADO = 'X' WHERE CAJA IN (SELECT CAJA FROM PROD_TER04 WHERE EMBARQUE = '" & embarque.Text & "')"
                    command1.CommandText = strsql
                    afectados = command1.ExecuteNonQuery()

                    strsql = "UPDATE PROD_TER04 SET ESTADO = 'X' WHERE EMBARQUE = '" & embarque.Text & "'"
                    command1.CommandText = strsql
                    afectados = command1.ExecuteNonQuery()

                    Using connection2 As New SqlConnection(cnn2)
                        connection2.Open()

                        Dim command2 As SqlCommand = New SqlCommand(strsql, connection2)

                        strsql = "DELETE EMB01 WHERE EMPRESA = '" & emp.numero & "' AND EMBARQUE = '" & embarque.Text & "'"
                        command2.CommandText = strsql

                    End Using
                End Using

                ' The Complete method commits the transaction. If an exception has been thrown,
                ' Complete is called and the transaction is rolled back.
                scope.Complete()
            End Using
        Catch ex As TransactionAbortedException
            MsgBox("TransactionAbortedException Message: {0}" & ex.Message, MsgBoxStyle.Critical, "")
        Catch ex As ApplicationException
            MsgBox("ApplicationException Message: {0}" & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub

End Class



