Public Class Mae_tex_c
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim cd As New DataTable
    Dim tname As String
    Dim llave(2) As String
    Dim campo(2) As String
    Dim w2 As New TextBox

    Private Sub Mae_tel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llena_tablas(cd, "SELECT * FROM MAESTRO_TELA", cnn)
        db.SelectedIndex = 0
        tname = "TEX_GREIGE"
        llave(0) = "TELA"
        campo(0) = "GREIGE"
        limpia_variables0()
    End Sub

    Private Sub db_Click(sender As System.Object, e As System.EventArgs) Handles db.Click
        Select Case db.SelectedIndex
            Case 0
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
        setea_flex(fg)
        llena_flex(fg, tname, llave(0), campo(0), "")
    End Sub

    '=========================================================
    '=     CAPACIDADES
    '=========================================================
    Private Sub limpia_variables1()
        setea_flex(wf)
        llena_flex(wf, tname, llave(1), campo(1), "")
    End Sub
    '=========================================================
    '=     CAPACIDAD MAQUINAS
    '=========================================================
    Private Sub limpia_variables2()
        setea_flex(nf)
        llena_flex(nf, tname, llave(2), campo(2), "")
    End Sub
    Private Sub setea_flex(gu As C1.Win.C1FlexGrid.C1FlexGrid)
        gu.Rows.Count = 1
    End Sub
    Private Sub llena_flex(ByRef fl As C1.Win.C1FlexGrid.C1FlexGrid, ByVal tname As String, ByVal codigo As String, ByVal descripcion As String, ByVal desc As String)
        Dim l As Integer
        Dim dr As DataRow
        Dim descri As String = ""
        Dim tela As String = ""
        llena_tablas(dt, "SELECT * FROM " & tname, cnn)
        l = 1
        fl.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fl(l, 1) = dr(codigo)
            If tname <> "TEX_MAQ" Then
                tela = dr("TELA")
                busca_descripciones1(cd, "ORDEN", "FABRIC", dr("TELA"), descri)
                fl(l, 2) = descri
                fl(l, 3) = dr(descripcion)
            End If
            l = l + 1
        Next
    End Sub

End Class