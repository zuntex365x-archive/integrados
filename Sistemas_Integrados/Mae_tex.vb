Public Class Mae_tex
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim cd As New DataTable
    Dim tname As String
    Dim llave(2) As String
    Dim campo(2) As String
    Dim w2 As New TextBox

    Private Sub Mae_tel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler tela.KeyPress, AddressOf keypressed1
        AddHandler d0.KeyPress, AddressOf keypressed2
        AddHandler w1.KeyPress, AddressOf keypressed3
        AddHandler t2.KeyPress, AddressOf keypressed5
        AddHandler d2.KeyPress, AddressOf keypressed6
        llena_tablas(cd, "SELECT * FROM MAESTRO_TELA", cnn)
        llena_combos(tela, "SELECT * FROM MAESTRO_TELA", "ORDEN")
        llena_combos(t2, "SELECT * FROM MAESTRO_TELA", "ORDEN")
        db.SelectedIndex = 0
        tname = "TEX_GREIGE"
        llave(0) = "TELA"
        campo(0) = "GREIGE"
        limpia_variables0()
        Try
            tela.SelectedIndex = 1
            tela.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub db_Click(sender As System.Object, e As System.EventArgs) Handles db.Click
        Select Case db.SelectedIndex
            Case 0
                Try
                    tela.SelectedIndex = 1
                    tela.SelectedIndex = 0
                Catch ex As Exception
                End Try
                tname = "TEX_GREIGE"
                llave(0) = "TELA"
                campo(0) = "GREIGE"
                limpia_variables0()
            Case 1
                tname = "TEX_MAQ"
                llave(1) = "CAPACIDAD"
                campo(1) = ""
                limpia_variables1()
            Case 2
                Try
                    t2.SelectedIndex = 1
                    t2.SelectedIndex = 0
                Catch ex As Exception
                End Try
                tname = "TEX_LXB"
                llave(2) = "TELA"
                campo(2) = "LIBRAS_BATCH"
                limpia_variables2()
        End Select
    End Sub
    '=========================================================
    '=     GREIGE
    '=========================================================
    Private Sub limpia_variables0()
        tela.Enabled = True
        e0.Visible = False
        d0.Text = ""
        setea_flex(fg, c0, d0)
        llena_flex(fg, tname, llave(0), campo(0), "")
        busca_descripciones1(cd, "ORDEN", "FABRIC", tela.Text, c0.Text)
        tela.Focus()
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim l0 As New Label
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c0.Text) <> "" Then
                l0.Text = tela.Text
                busca_datos(l0, d0, e0, "TELA", "GREIGE")
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(d0.Text) <> "" Then
                g0.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub graba0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g0.Click
        Dim ok As Boolean
        revisa_datos(ok, c0, d0)
        If ok Then
            graba_datos(tela.Text, d0.Text, llave(0), campo(0))
            limpia_variables0()
        End If
    End Sub

    Private Sub regresa0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r0.Click
        limpia_variables0()
    End Sub

    Private Sub Elimina0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e0.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(llave(0), c0.Text)
        End If
        limpia_variables0()
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        selecciona_registro(fg, c0, d0, e0, llave(0), campo(0))
        tela.SelectedIndex = tela.Items.IndexOf(c0.Text)
        busca_descripciones1(cd, "ORDEN", "FABRIC", tela.Text, c0.Text)
    End Sub
    '=========================================================
    '=     CAPACIDADES
    '=========================================================

    Private Sub limpia_variables1()
        Dim w0 As New Label
        w0.Text = w1.Text
        w1.Enabled = True
        e1.Visible = False
        setea_flex(wf, w0, w1)
        llena_flex(wf, tname, llave(1), campo(1), "")
        w2.Focus()
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim w0 As New Label
        w0.Text = w1.Text
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(w1.Text) <> "" Then
                busca_datos(w0, w2, e1, llave(1), llave(1))
                g1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub graba1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g1.Click
        Dim ok As Boolean
        Dim w0 As New Label
        w0.Text = w1.Text
        revisa_datos(ok, w0, w1)
        If ok Then
            graba_datos(w1.Text, w1.Text, llave(1), llave(1))
            limpia_variables1()
        End If
    End Sub

    Private Sub regresa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        limpia_variables1()
    End Sub

    Private Sub Elimina1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e1.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(llave(1), w1.Text)
        End If
        limpia_variables1()
    End Sub
    Private Sub wf_Click(sender As System.Object, e As System.EventArgs) Handles wf.Click
        Dim w0 As New Label
        w0.Text = w1.Text
        selecciona_registro(wf, w0, w2, e1, llave(1), llave(1))
        w1.Text = w0.Text
    End Sub
    '=========================================================
    '=     CAPACIDAD MAQUINAS
    '=========================================================
    Private Sub limpia_variables2()
        t2.Enabled = True
        e2.Visible = False
        setea_flex(nf, c2, d0)
        llena_flex(nf, tname, llave(2), campo(2), "")
        busca_descripciones1(cd, "ORDEN", "FABRIC", t2.Text, c2.Text)
        t2.Focus()
    End Sub
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim l0 As New Label
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(t2.Text) <> "" Then
                l0.Text = t2.Text
                busca_descripciones1(cd, "ORDEN", "FABRIC", t2.Text, c2.Text)
                busca_datos(l0, d2, e1, "TELA", "LIBRAS_BATCH")
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(d2.Text) <> "" Then
                g2.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub grabas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g2.Click
        Dim ok As Boolean
        revisa_datos(ok, c2, d2)
        If ok Then
            graba_datos(t2.Text, d2.Text, llave(2), campo(2))
            limpia_variables2()
        End If
    End Sub

    Private Sub regresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r2.Click
        limpia_variables2()
    End Sub

    Private Sub Eliminas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e2.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(llave(2), t2.Text)
        End If
        limpia_variables2()
    End Sub
    Private Sub nf_Click(sender As System.Object, e As System.EventArgs) Handles nf.Click
        selecciona_registro(nf, c2, d2, e2, llave(2), campo(2))
        t2.SelectedIndex = t2.Items.IndexOf(c2.Text)
        busca_descripciones1(cd, "ORDEN", "FABRIC", t2.Text, c2.Text)
    End Sub

    Private Sub setea_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, cg As Label, ByRef dg As TextBox)
        fl.Rows.Count = 1
        fl.Rows(0).Height = 30
        cg.text = ""
        dg.Text = ""
        e0.Visible = False
        dg.Focus()
    End Sub

    Private Sub llena_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByVal tname As String, ByVal codigo As String, ByVal descripcion As String, ByVal desc As String)
        Dim l As Integer
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM " & tname, cnn)
        l = 1
        fl.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fl(l, 1) = dr(codigo)
            If tname <> "TEX_MAQ" Then
                busca_descripciones1(cd, "ORDEN", "FABRIC", dr("TELA"), fl(l, 2))
                fl(l, 3) = dr(descripcion)
            End If
            l = l + 1
        Next
    End Sub
    Private Sub selecciona_registro(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByRef cg As Label, ByRef dg As TextBox, ByRef bt As Button, ByVal llave As String, ByVal campo As String)
        Dim i As Integer = fl.RowSel
        cg.Enabled = True
        cg.Text = fl(i, 1)
        cg.Enabled = False
        busca_datos(cg, dg, bt, llave, campo)
        g0.Visible = True
        e0.Visible = True
    End Sub

    Private Sub busca_datos(ByRef cg As Label, ByRef dg As TextBox, ByRef bt As Button, ByVal llave As String, ByVal campo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Try
            cg.Enabled = False
        Catch
        End Try
        llena_tablas(dt, "SELECT * FROM " & tname & " WHERE " & llave & " = '" & cg.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            dg.Text = dr(campo)
            bt.Visible = True
        End If
        dg.Focus()
    End Sub
    Private Sub revisa_datos(ByRef ok As Boolean, ByRef cg As Label, ByRef dg As TextBox)
        Dim val As Integer
        If tname = "TEX_GREIGE" Then
            Try
                val = CInt(dg.Text)
            Catch ex As Exception
                val = 0
            End Try
            If val = 0 Or val > 100 Then
                ok = False
                MsgBox("% No puede ser 0 o mayor que 100.", MsgBoxStyle.Critical, "Por favor revise !!!!")
                Exit Sub
            End If
        End If
        If (Trim(dg.Text) = "") Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar todos los datos solicitados", MsgBoxStyle.Critical, "Por favor revise !!!!")
        Else
            ok = True
        End If
    End Sub



    '=================================================================================
    '                        GRABA DATOS 
    '=================================================================================
    Private Sub graba_datos(cg As String, ByRef dg As String, ByVal llave As String, ByVal campo As String)
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE " & tname & " SET " & campo & " = '" & UCase(dg) & "' " & _
                                             " WHERE " & llave & "  = '" & cg & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                If tname <> "TEX_MAQ" Then
                    strsql = "INSERT INTO " & tname & " ( TELA, " & campo & ") VALUES ('" & cg & "','" & UCase(dg) & "')"
                Else
                    strsql = "INSERT INTO " & tname & " ( " & campo & ") VALUES ('" & UCase(dg) & "')"
                End If
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As SqlClient.SqlException
            Try
                Dim numero As String = e.Number
                If numero = "2601" Then
                    numero = "Ya existe el dato que desea Grabar.  No se puede duplicar !!!!!!"
                Else
                    numero = "Error No." & numero
                End If
                MsgBox("Inconsistencia en Datos." & vbLf & numero, MsgBoxStyle.Critical, "Por favor revise !!!!")
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
    '                       ELIMINA DATOS 
    '=================================================================================
    Private Sub elimina_datos(ByVal campo As String, ByVal valor As String)
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE " & tname & " WHERE " & campo & " = '" & valor & "'"
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


    Private Sub tela_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tela.SelectedIndexChanged
        busca_descripciones1(cd, "ORDEN", "FABRIC", tela.Text, c0.Text)
    End Sub

    Private Sub tela_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tela.KeyPress
        AutoCompletar(tela, e)
    End Sub

    Private Sub t2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles t2.SelectedIndexChanged
        busca_descripciones1(cd, "ORDEN", "FABRIC", t2.Text, c2.Text)
    End Sub
End Class