Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Public Class Carga_open_c
    Dim dt As New DataTable
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection
    Dim obj As New empresas
    Dim jap As New Lib_SI.util

    Private Sub Plan_costura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 100
        fg.Width = Me.Width - 50
        cnn.ConnectionString = jap.con_string(0)
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub lee_fecha_actualización()
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas_e(dt, "SELECT * FROM OPEN_ORDER_1 WHERE CLAVE = 'ACTUALIZA'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            regs.Text = "Actualizado por: " & dr("USUARIO") & " en fecha:  " & Format(dr("FECHA"), "yyyy-MM-dd HH:mm:ss")
        End If
    End Sub
    Private Sub llena_fg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        llena_tablas_e(dt, "SELECT * FROM OPEN_ORDER", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            For j = 0 To 34
                fg(l, j + 1) = dr(j)
            Next
            l = l + 1
        Next

    End Sub
    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        Dim ok As Boolean = False
        lee_fecha_actualización()
        llena_fg()
        regs.Visible = True
        go.Visible = False
    End Sub

End Class

