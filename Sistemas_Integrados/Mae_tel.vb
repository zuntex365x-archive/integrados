Public Class Mae_tel
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim tname As String

    Private Sub Mae_tel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler c0.KeyPress, AddressOf keypressed1
        AddHandler d0.KeyPress, AddressOf keypressed2
        AddHandler w1.KeyPress, AddressOf keypressed3
        AddHandler w2.KeyPress, AddressOf keypressed4
        AddHandler n1.KeyPress, AddressOf keypressed5
        AddHandler n2.KeyPress, AddressOf keypressed6
        AddHandler f1.KeyPress, AddressOf keypressed7
        AddHandler f2.KeyPress, AddressOf keypressed8
        db.SelectedIndex = 0
        tname = "MAE_TEL_FAB"
        limpia_variables0()
    End Sub

    Private Sub db_Click(sender As System.Object, e As System.EventArgs) Handles db.Click
        Select Case db.SelectedIndex
            Case 0
                tname = "MAE_TEL_FAB"
                limpia_variables0()
            Case 1
                tname = "MAE_TEL_WEI"
                limpia_variables1()
            Case 2
                tname = "MAE_TEL_CON"
                limpia_variables2()
            Case 3
                tname = "MAE_TEL_FIB"
                limpia_variables3()
        End Select
    End Sub
    '=========================================================
    '=     FABRIC
    '=========================================================
    Private Sub limpia_variables0()
        c0.Enabled = True
        c0.Refresh()
        e0.Visible = False
        d0.Text = ""
        setea_flex(fg, c0, d0)
        c0.Focus()
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(c0.Text) <> "" Then
                busca_datos(fg, c0, d0, e0)
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
            graba_datos(c0.Text, d0.Text)
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
            elimina_datos(c0.Text)
        End If
        limpia_variables0()
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.Click
        selecciona_registro(fg, c0, d0, e0)
    End Sub
    '=========================================================
    '=     WEIGHT
    '=========================================================

    Private Sub limpia_variables1()
        w1.Enabled = True
        w1.Refresh()
        e1.Visible = False
        setea_flex(wf, w1, w2)
        w1.Focus()
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(w1.Text) <> "" Then
                busca_datos(wf, w1, w2, e1)
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
    Private Sub graba1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g1.Click
        Dim ok As Boolean
        revisa_datos(ok, w1, w2)
        If ok Then
            graba_datos(w1.Text, w2.Text)
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
            elimina_datos(w1.Text)
        End If
        limpia_variables1()
    End Sub
    Private Sub wf_Click(sender As System.Object, e As System.EventArgs) Handles wf.Click
        selecciona_registro(wf, w1, w2, e1)
    End Sub
    '=========================================================
    '=     CONTENIDO
    '=========================================================
    Private Sub limpia_variables2()
        n1.Enabled = True
        n1.Refresh()
        e2.Visible = False
        setea_flex(nf, n1, n2)
        n1.Focus()
    End Sub
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(n1.Text) <> "" Then
                busca_datos(nf, n1, n2, e2)
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
    Private Sub grabas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g2.Click
        Dim ok As Boolean
        revisa_datos(ok, n1, n2)
        If ok Then
            graba_datos(n1.Text, n2.Text)
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
            elimina_datos(n1.Text)
        End If
        limpia_variables2()
    End Sub
    Private Sub nf_Click(sender As System.Object, e As System.EventArgs) Handles nf.Click
        selecciona_registro(nf, n1, n2, e2)
    End Sub

    '=========================================================
    '=     FIBRA
    '=========================================================
    Private Sub limpia_variables3()
        f1.Enabled = True
        f1.Refresh()
        e3.Visible = False
        setea_flex(bf, f1, f2)
        f1.Focus()
    End Sub
    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(f1.Text) <> "" Then
                busca_datos(bf, f1, f2, e3)
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(f2.Text) <> "" Then
                g3.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub graba3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g3.Click
        Dim ok As Boolean
        revisa_datos(ok, f1, f2)
        If ok Then
            graba_datos(f1.Text, f2.Text)
            limpia_variables3()
        End If
    End Sub

    Private Sub regresa3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r3.Click
        limpia_variables3()
    End Sub

    Private Sub Elimina3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e3.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos(f1.Text)
        End If
        limpia_variables3()
    End Sub
    Private Sub bf_Click(sender As System.Object, e As System.EventArgs) Handles bf.Click
        selecciona_registro(bf, f1, f2, e3)
    End Sub

    Private Sub setea_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByRef cg As C1.Win.C1Input.C1NumericEdit, ByRef dg As TextBox)
        fl.Rows.Count = 1
        fl.Rows(0).Height = 30
        cg.Enabled = True
        cg.Refresh()
        cg.Text = "001"
        dg.Text = ""
        e0.Visible = False
        llena_flex(fl, tname)
        cg.Focus()
    End Sub

    Private Sub llena_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByVal tname As String)
        Dim l As Integer
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM " & tname, cnn)
        l = 1
        fl.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fl(l, 1) = dr("CODIGO")
            fl(l, 2) = dr("DESCRIPCION")
            l = l + 1
        Next
    End Sub

    Private Sub selecciona_registro(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByRef cg As C1.Win.C1Input.C1NumericEdit, ByRef dg As TextBox, ByRef bt As Button)
        Dim i As Integer = fl.RowSel
        cg.Enabled = True
        cg.Text = fl(i, 1)
        cg.Enabled = False
        busca_datos(fl, cg, dg, bt)
        g0.Visible = True
        e0.Visible = True
    End Sub

    Private Sub busca_datos(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByRef cg As C1.Win.C1Input.C1NumericEdit, ByRef dg As TextBox, ByRef bt As Button)
        Dim dt As New DataTable()
        Dim dr As DataRow
        cg.Enabled = False
        dg.Focus()
        llena_tablas(dt, "SELECT * FROM " & tname & " WHERE CODIGO = '" & cg.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            dg.Text = dr("DESCRIPCION")
            bt.Visible = True
        End If
    End Sub

 

    Private Sub revisa_datos(ByRef ok As Boolean, ByRef cg As C1.Win.C1Input.C1NumericEdit, ByRef dg As TextBox)
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
    Private Sub graba_datos(cg As String, ByRef dg As String)
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE " & tname & " SET DESCRIPCION  = '" & UCase(dg) & "' " & _
                                             " WHERE CODIGO = '" & cg & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO " & tname & " ( CODIGO, DESCRIPCION) VALUES ('" & _
                                                    cg & "','" & _
                                                    UCase(dg) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

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

    '=================================================================================
    '                       ELIMINA DATOS 
    '=================================================================================
    Private Sub elimina_datos(cg As String)
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE " & tname & " WHERE CODIGO = '" & cg & "'"
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