Public Class Mae_hil
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim tname As String
    Dim llave(2) As String
    Dim campo(2) As String

    Private Sub Mae_tel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler c0.KeyPress, AddressOf keypressed1
        AddHandler d0.KeyPress, AddressOf keypressed2
        AddHandler w1.KeyPress, AddressOf keypressed3
        AddHandler w2.KeyPress, AddressOf keypressed4
        AddHandler n1.KeyPress, AddressOf keypressed5
        AddHandler n2.KeyPress, AddressOf keypressed6
        db.SelectedIndex = 0
        tname = "TIPOS_HILO"
        llave(0) = "TIPO_HILO"
        campo(0) = "DESCRIPCION_TIPO"
        limpia_variables0()
    End Sub

    Private Sub db_Click(sender As System.Object, e As System.EventArgs)
        Select Case db.SelectedIndex
            Case 0
                tname = "TIPOS_HILO"
                llave(0) = "TIPO_HILO"
                campo(0) = "DESCRIPCION_TIPO"
                limpia_variables0()
            Case 1
                tname = "TITULOS_HILO"
                llave(1) = "TITULO_HILO"
                campo(1) = "DESCRIPCION_TITULO"
                limpia_variables1()
            Case 2
                tname = "ACABADO_HILO"
                llave(2) = "ACABADO_HILO"
                campo(2) = "DESCRIPCION_ACABADO"
                limpia_variables2()
        End Select
    End Sub
    '=========================================================
    '=     TIPOS
    '=========================================================
    Private Sub limpia_variables0()
        c0.Enabled = True
        c0.Refresh()
        e0.Visible = False
        d0.Text = ""
        setea_flex(fg, c0, d0)
        llena_flex(fg, tname, llave(0), campo(0))
        d0.Focus()
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c0.Text) <> "" Then
                busca_datos(c0, d0, e0, "TIPO_HILO", "DESCRIPCION_TIPO")
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
    Private Sub graba0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ok As Boolean
        revisa_datos(ok, c0, d0)
        If ok Then
            graba_datos(c0.Text, d0.Text, llave(0), campo(0))
            limpia_variables0()
        End If
    End Sub

    Private Sub regresa0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpia_variables0()
    End Sub

    Private Sub Elimina0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(llave(0), c0.Text)
        End If
        limpia_variables0()
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs)
        selecciona_registro(fg, c0, d0, e0, llave(0), campo(0))
    End Sub
    '=========================================================
    '=     TITULOS
    '=========================================================

    Private Sub limpia_variables1()
        w1.Enabled = True
        w1.Refresh()
        e1.Visible = False
        setea_flex(wf, w1, w2)
        llena_flex(wf, tname, llave(1), campo(1))
        w2.Focus()
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(w1.Text) <> "" Then
                busca_datos(w1, w2, e1, llave(1), campo(1))
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(w2.Text) <> "" Then
                g1.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub graba1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ok As Boolean
        revisa_datos(ok, w1, w2)
        If ok Then
            graba_datos(w1.Text, w2.Text, llave(1), campo(1))
            limpia_variables1()
        End If
    End Sub

    Private Sub regresa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpia_variables1()
    End Sub

    Private Sub Elimina1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(llave(1), w1.Text)
        End If
        limpia_variables1()
    End Sub
    Private Sub wf_Click(sender As System.Object, e As System.EventArgs)
        selecciona_registro(wf, w1, w2, e1, llave(1), campo(1))
    End Sub
    '=========================================================
    '=     ACABADO
    '=========================================================
    Private Sub limpia_variables2()
        n1.Enabled = True
        n1.Refresh()
        e2.Visible = False
        setea_flex(nf, n1, n2)
        llena_flex(nf, tname, llave(2), campo(2))
        n2.Focus()
    End Sub
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(n1.Text) <> "" Then
                busca_datos(n1, n2, e1, llave(2), campo(2))
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(n2.Text) <> "" Then
                g2.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub grabas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ok As Boolean
        revisa_datos(ok, n1, n2)
        If ok Then
            graba_datos(n1.Text, n2.Text, llave(2), campo(2))
            limpia_variables2()
        End If
    End Sub

    Private Sub regresas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpia_variables2()
    End Sub

    Private Sub Eliminas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(llave(2), n1.Text)
        End If
        limpia_variables2()
    End Sub
    Private Sub nf_Click(sender As System.Object, e As System.EventArgs)
        selecciona_registro(nf, n1, n2, e2, llave(2), campo(2))
    End Sub

    Private Sub setea_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, cg As Label, ByRef dg As TextBox)
        fl.Rows.Count = 1
        fl.Rows(0).Height = 30
        cg.text = ""
        dg.Text = ""
        e0.Visible = False
        dg.Focus()
    End Sub

    Private Sub llena_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByVal tname As String, ByVal codigo As String, ByVal descripcion As String)
        Dim l As Integer
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM " & tname, cnn)
        l = 1
        fl.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fl(l, 1) = dr(codigo)
            fl(l, 2) = dr(descripcion)
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
        cg.Enabled = False
        dg.Focus()
        llena_tablas(dt, "SELECT * FROM " & tname & " WHERE " & llave & " = '" & cg.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            dg.Text = dr(campo)
            bt.Visible = True
        End If
    End Sub



    Private Sub revisa_datos(ByRef ok As Boolean, ByRef cg As Label, ByRef dg As TextBox)
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
                strsql = "INSERT INTO " & tname & " ( " & campo & ") VALUES ('" & UCase(dg) & "')"
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


End Class