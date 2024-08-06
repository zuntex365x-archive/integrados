Public Class Consulta_materiales
    Dim dt As New DataTable()
    Public selec As String
    Public descr As String
    Public cliente As String
    Dim cnn As New SqlClient.SqlConnection

    Private Sub consulta_materieales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT CLIENTE,T_MATERIAL,DESCRIPCION,CODIGO FROM MATERIALES WHERE ACTIVO = 'S' AND  CLIENTE = '" & cliente & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        fg.Rows(0).Height = 30
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("T_MATERIAL")
            fg(l, 3) = dr("DESCRIPCION")
            fg(l, 4) = dr("CODIGO")
            l = l + 1
        Next
        selec = ""
    End Sub

    Private Sub fg_Click_1(sender As System.Object, e As System.EventArgs) Handles fg.DoubleClick
        Dim i As Integer
        i = fg.Row
        selec = fg(i, 4)
        descr = fg(i, 3)
        Close()
    End Sub
End Class