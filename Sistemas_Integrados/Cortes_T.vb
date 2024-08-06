Imports C1.Win.C1FlexGrid

Public Class Cortes_T
    Inherits System.Windows.Forms.Form
    Dim Bien As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim te As New DataTable()
    Dim mt As New DataTable()
    Dim coe As New DataTable
    Friend WithEvents pd1 As Printing.PrintDocument
    Friend WithEvents c1r As C1.C1Report.C1Report
    Dim drc As DataRow
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Corte_n As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents But_graba As System.Windows.Forms.Button
    Friend WithEvents seccion As System.Windows.Forms.ComboBox
    Friend WithEvents Corte_e As System.Windows.Forms.ComboBox
    Friend WithEvents sala As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_T))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Corte_n = New System.Windows.Forms.TextBox()
        Me.seccion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sala = New System.Windows.Forms.ComboBox()
        Me.But_graba = New System.Windows.Forms.Button()
        Me.Corte_e = New System.Windows.Forms.ComboBox()
        Me.pd1 = New System.Drawing.Printing.PrintDocument()
        Me.c1r = New C1.C1Report.C1Report()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte a Anular:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Corte Nuevo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sala Corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Corte_n
        '
        Me.Corte_n.BackColor = System.Drawing.Color.White
        Me.Corte_n.Location = New System.Drawing.Point(176, 32)
        Me.Corte_n.MaxLength = 80
        Me.Corte_n.Name = "Corte_n"
        Me.Corte_n.Size = New System.Drawing.Size(144, 20)
        Me.Corte_n.TabIndex = 4
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.White
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccion.Location = New System.Drawing.Point(176, 80)
        Me.seccion.MaxDropDownItems = 15
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(144, 24)
        Me.seccion.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sección / Planta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sala
        '
        Me.sala.BackColor = System.Drawing.Color.White
        Me.sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sala.Location = New System.Drawing.Point(176, 54)
        Me.sala.MaxDropDownItems = 15
        Me.sala.Name = "sala"
        Me.sala.Size = New System.Drawing.Size(144, 24)
        Me.sala.TabIndex = 27
        '
        'But_graba
        '
        Me.But_graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.But_graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.But_graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_graba.ForeColor = System.Drawing.Color.Black
        Me.But_graba.Image = CType(resources.GetObject("But_graba.Image"), System.Drawing.Image)
        Me.But_graba.Location = New System.Drawing.Point(856, 16)
        Me.But_graba.Name = "But_graba"
        Me.But_graba.Size = New System.Drawing.Size(35, 35)
        Me.But_graba.TabIndex = 24
        Me.But_graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_graba.UseVisualStyleBackColor = False
        '
        'Corte_e
        '
        Me.Corte_e.Items.AddRange(New Object() {"Devoluciónes", "Ajustes a Inventario"})
        Me.Corte_e.Location = New System.Drawing.Point(176, 8)
        Me.Corte_e.Name = "Corte_e"
        Me.Corte_e.Size = New System.Drawing.Size(144, 21)
        Me.Corte_e.TabIndex = 25
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'Cortes_T
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 197)
        Me.Controls.Add(Me.seccion)
        Me.Controls.Add(Me.Corte_e)
        Me.Controls.Add(Me.But_graba)
        Me.Controls.Add(Me.Corte_n)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sala)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_T"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado entre Cortes"
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Corte_e.KeyPress, AddressOf keypressed1
        AddHandler Corte_n.KeyPress, AddressOf keypressed2
        AddHandler sala.KeyPress, AddressOf keypressed3
        AddHandler seccion.KeyPress, AddressOf keypressed4
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        llena_corte_e()
        llena_combos(sala, "SELECT * FROM SALAS", "SALA")
        llena_combos(seccion, "SELECT * FROM SECCIONES", "SECCION")
        Corte_n.Text = ""
    End Sub

    Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Corte_n.Focus()
        End If
    End Sub 'keypressed
    Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            sala.Focus()
        End If
    End Sub 'keypressed
    Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            seccion.Focus()
        End If
    End Sub 'keypressed

    Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            But_graba.Focus()
        End If
    End Sub 'keypressed

    Private Sub But_Agrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        proceso()
    End Sub

    Private Sub corte_E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Corte_e.KeyPress
        AutoCompletar(Corte_e, e)
    End Sub

    Private Sub cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sala.KeyPress
        AutoCompletar(sala, e)
    End Sub
    Private Sub seccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles seccion.KeyPress
        AutoCompletar(seccion, e)
    End Sub
    Private Sub llena_corte_e()
        coe = New DataTable()
        llena_tablas(coe, "SELECT * FROM CORTES_DEV LEFT JOIN CORTES_S ON CORTES_DEV.CORTE = CORTES_S.CORTE WHERE CORTES_DEV.ESTADO = 'A'", cnn)
        Dim dr As DataRow
        Corte_e.Items.Clear()
        For Each dr In coe.Rows
            Corte_e.Items.Add(dr("CORTE"))
        Next
        Try
            Corte_e.SelectedIndex = 0
        Catch
        End Try
    End Sub
    Private Sub proceso()
        Dim ok As Boolean = True
        If Trim(Corte_e.Text) = "" Then
            MsgBox("Aún no ha seleccionado el corte a Anular !!", MsgBoxStyle.Critical, "Error de creación")
        End If
        ok = revisa_nuevo_corte()
        If ok Then
            ok = revisa_tela_mat()
            If ok Then
                graba_registros()
                impresion()
                impresion_requisicion()
                limpia_variables()
            End If
        End If

    End Sub
    Private Function revisa_nuevo_corte() As Boolean
        Dim bien As Boolean
        Dim dt As New DataTable
        Try
            Corte_n.Text = CInt(Corte_n.Text)
        Catch ex As Exception
            MsgBox("Error en el número de Corte Nuevo!!", MsgBoxStyle.Critical, "No puedo Crear el Corte Nuevo")
            Return False
        End Try
        If Corte_n.Text = "0" Then
            MsgBox("Error en el número de Corte Nuevo !!", MsgBoxStyle.Critical, "No puedo Crear el Corte Nuevo")
            Return False
        End If
        llena_tablas(dt, "SELECT * FROM CORTES WHERE CORTE ='" & Corte_n.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            MsgBox("El nuevo corte ya existe !!", MsgBoxStyle.Critical, "No puedo Crear el Corte Nuevo")
            bien = False
        Else
            bien = True
        End If
        Return bien
    End Function
    Private Function revisa_tela_mat() As Boolean
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim bien As Boolean = True
        Dim mat As Decimal
        Dim tel As Decimal
        Dim obj As Object
        llena_tablas(mt, "SELECT * FROM D_MATERIAL WHERE CORTE = '" & Corte_e.Text & "' AND T_MOVTO > '3'", cnn)
        llena_tablas(te, "SELECT * FROM DMOVTO WHERE CORTE = '" & Corte_e.Text & "' AND TMOVTO > '3'", cnn)
        dd = coe.Select("CORTE = '" & Corte_e.Text & "'")
        If dd.Length > 0 Then
            dr = dd(0)
        Else
            Return False
        End If
        Try
            obj = mt.Compute("SUM(UNIDADES)", String.Empty)
            mat = CDec(obj)
        Catch
            mat = 0
        End Try
        Try
            obj = te.Compute("SUM(YARDAS)", String.Empty)
            tel = CDec(obj)
        Catch
            tel = 0
        End Try
        If mat <> 0 And dr("MATERIALES") = 0 Then
            MsgBox("Aun no ha ingresado Materiales !!", MsgBoxStyle.Critical, "No puedo Crear el Corte Nuevo")
            bien = False
        End If
        If tel <> 0 And dr("telas") = 0 Then
            MsgBox("Aun no ha ingresado Telas !!", MsgBoxStyle.Critical, "No puedo Crear el Corte Nuevo")
            bien = False
        End If
        Return bien
    End Function
    ' ==================================== ACTUALIZA BASE DE DATOS =====================================
    Private Sub graba_registros()

        Dim afectados As Integer
        Dim strsql As String
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim fechas As String = Format(Today, "yyyy-MM-dd")
        dd = coe.Select("CORTE = '" & Corte_e.Text & "'")
        If dd.Length = 0 Then
            Exit Sub
        End If
        dr = dd(0)

        cnn.Open()

        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '============== NUEVO CORTE  =======================
            strsql = "UPDATE REQUI SET CORTE = '" & Corte_n.Text & "' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "UPDATE REQUI_D SET CORTE = '" & Corte_n.Text & "' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "UPDATE REQ_E SET CORTE = '" & Corte_n.Text & "' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "UPDATE REQ_E SET CORTE = '" & Corte_n.Text & "' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "UPDATE D_MATERIAL SET CORTE = '" & Corte_n.Text & "' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "UPDATE DMOVTO SET CORTE = '" & Corte_n.Text & "' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO CORTES (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,FCORTE,FPROD,EXPORTADO,SECCION,BATCH) " &
             "VALUES ( '" & Corte_n.Text & "','" &
                 dr("CLIENTE") & "','" &
                 dr("FPO") & "','" &
                 dr("CPO") & "','" &
                 dr("ESTILO") & "','" &
                 dr("COLOR") & "',0,0,0,0,0,0,0,0,0,0,0,'" &
                 fechas & "','" &
                 fechas & "','N','" & seccion.Text & "','" &
                 dr("BATCH") & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "INSERT INTO CORTES_S (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,F_ICORTE,ESTADO,BATCH,SALA) " &
                     "VALUES ('" & Corte_n.Text & "','" &
                         dr("CLIENTE") & "','" &
                         dr("FPO") & "','" &
                         dr("CPO") & "','" &
                         dr("ESTILO") & "','" &
                         dr("COLOR") & "','" &
                         dr("XS") & "','" &
                         dr("S") & "','" &
                         dr("M") & "','" &
                         dr("L") & "','" &
                         dr("XL") & "','" &
                         dr("XL2") & "','" &
                         dr("XL3") & "','" &
                         dr("XL4") & "','" &
                         dr("XL5") & "','" &
                         dr("XL6") & "','" &
                         dr("TOTAL") & "','" &
                         fechas & "','A','" &
                         dr("BATCH") & "','" & sala.Text & "')"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '============== ANULA CORTE ANTIGUO  =======================
            strsql = "UPDATE CORTES_S SET XS =0, S=0, M=0,L=0,XL=0,XL2=0,XL3=0,XL4=0,XL5=0,XL6=0,TOTAL=0 WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '======== Actualiza Maestro ===========
            strsql = "UPDATE CORTES SET XS=0, S=0, M=0,L=0,XL=0,XL2=0,XL3=0,XL4=0,XL5=0,XL6=0,TOTAL=0, EXPORTADO = 'S'  WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            '======== Actualiza Maestro ===========
            strsql = "UPDATE CORTES_DEV SET ESTADO ='D' WHERE CORTE = '" & Corte_e.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            MsgBox("Datos actualizados Correctamente.", MsgBoxStyle.Information, "Actualización Exitosa !!!!")
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos" + vbLf + e.Message + vbLf + "Avise a Jesús Acosta", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub But_graba_Click(sender As Object, e As EventArgs) Handles But_graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Antes de Actualizar Revise detenidamente TODOS los Datos." + vbLf + "Esta COMPLETAMENTE Seguro de Efectuar la Transacción?  ", MsgBoxStyle.YesNo, "Actualizando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            proceso()
        End If
    End Sub



    '========================== IMPRESION REQUISICION ======================
    Private Sub impresion()
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT REQ_D.* ,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,F_REQ,KNIT ,ROLLOS.COLOR AS COLORK, CORTES.CLIENTE , (SELECT SALA FROM CORTES_S WHERE CORTES_S.CORTE = REQ_D.CORTE) AS SALA, ANCHO,TONALIDAD FROM REQ_D LEFT JOIN REQ_E ON REQ_E.REQ = REQ_D.REQ LEFT JOIN CORTES ON REQ_D.CORTE =CORTES.CORTE LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE REQ_E.REQ = REQ_D.REQ AND REQ_D.CORTE =  '" & Corte_n.Text & "' ORDER BY KNIT,REQ_D.BATCH,REQ_D.ROLLO"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report
            c1r.Load("C:\TELAS\rep.xml", "REQUI")
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strsql
            c1r.Fields("Empresa").Text = empresa
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
        End Try
        pd1 = c1r.Document
        pd1.PrinterSettings.Copies = 2
        pd1.Print()
    End Sub
    '========================== IMPRESION REQUISICION ======================
    Private Sub impresion_requisicion()
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT CORTES_S.*,CPO_D.ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0 FROM CORTES_S LEFT JOIN CPO_D ON CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA  WHERE CORTE = '" & Corte_n.Text & "'"
        Dim obj As New empresas
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report
            c1r.Load("C:\TELAS\rep.xml", "CORTE_S")
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strsql
            c1r.Fields("Empresa").Text = empresa
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
        End Try
        pd1 = c1r.Document
        pd1.PrinterSettings.Copies = 1
        pd1.Print()
    End Sub
End Class

