Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class Push04
    Dim fe As Date
    Dim fo As Date
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim cp As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 130
        fg.Width = Me.Width - 30
        setea_grid()
        Try
            estado.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub crea_tablas()
        Dim strsql As String = "SELECT CLIENTE,CPO_D.*,CPO_COSTO.* FROM CPO_D LEFT JOIN CPO_COSTO ON CPO_D.CPO = CPO_COSTO.CPO AND CPO_D.ESTILO =  CPO_COSTO.ESTILO AND CPO_D.COLOR = CPO_COSTO.COLOR LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE + CPO_D.CPO + CPO_D.ESTILO + CPO_D.COLOR IN (SELECT  DISTINCT CLIENTE + CPO + ESTILO +  COLOR FROM PUSH01) AND ESTADO = '" & Mid(estado.Text, 1, 1) & "'"
        llena_tablas(cp, strsql, cnn)
        strsql = "SELECT * FROM PUSH01  ORDER BY CLIENTE,CPO,ESTILO,COLOR,FECHA_P DESC"
        llena_tablas(dt, strsql, cnn)
    End Sub
    Private Sub proceso()
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim f As Integer
        Dim cliente As String
        Dim fechap As Date
        Dim fechae As Date
        Dim valor As Decimal
        Dim i As Integer
        Dim dias As Integer
        Dim c As Integer
        fg.Rows.Count = cp.Rows.Count + 1
        f = 1
        For Each dr In cp.Rows
            cliente = dr("CLIENTE")
            fg(f, 1) = cliente
            fg(f, 2) = dr("CPO")
            fg(f, 3) = dr("ESTILO")
            fg(f, 4) = dr("COLOR")
            fechae = dr("F_ENTREGA")
            fg(f, 18) = fechae
            dd = dt.Select("CLIENTE = '" & dr("CLIENTE") & "' AND CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                fechap = dj("FECHA_P")
                For Each dj In dd
                    dias = DateDiff(DateInterval.Day, fechae, dj("FECHA_E"))
                    If dias > 0 Then
                        valor = 0
                        For i = 1 To 10
                            valor = valor + (dj(i + 5) * dr(i + 25))
                        Next

                        If dias < 1 Then
                            c = 5
                        ElseIf dias > 330 Then
                            c = 16
                        Else
                            c = Fix(dias / 30) + 5
                        End If
                        fg(f, c) = fg(f, c) + valor
                        fg(f, 17) = fg(f, 17) + valor
                    End If
                Next
            End If
            f = f + 1
        Next
    End Sub
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button3.Visible = True
        regresa.Visible = True
        crea_tablas()
        proceso()
        subtotales()
        estado.Enabled = False
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        With fg
            For i = 5 To 17
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
            Next i
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_grid()
        estado.Enabled = True
        Button1.Visible = True
        Button3.Visible = False
        regresa.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\resultado_push_out.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
End Class