Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class Inv_PT
    Dim fe As Date
    Dim fo As Date
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        fecha.Value = CDate("2016-01-01")
        setea_grid()
        Dim strsql As String = "SELECT 'TODOS' AS CLIENTE UNION SELECT CLIENTE FROM CLIENTES WHERE ACTIVO = 'S'"
        llena_combos(clientecmb, strsql, "CLIENTE")
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim strsql As String
        Dim l As Integer = 1
        Dim i As Integer
        Dim val As Decimal
        Dim fec As String = Format(fecha.Value, "yyyy-MM-dd")
        Dim dif As Decimal
        Cursor = Cursors.WaitCursor
        Try

            strsql = "SELECT CORTES.CORTE,CLIENTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,FCORTE,FPROD,TOTAL,(SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE TIPO = '0' AND PROD_DIARIA.CORTE = CORTES.CORTE) AS P_PROD, (SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE TIPO <> '0' AND PROD_DIARIA.CORTE = CORTES.CORTE) AS S_PROD,(SELECT SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) FROM PACKING_D WHERE PACKING_D.CORTE = CORTES.CORTE AND TIPO ='Pri') AS P_EXP ,(SELECT SUM(XS+S+M+L+XL+XL2+XL3+XL4+XL5+XL6) FROM PACKING_D WHERE PACKING_D.CORTE = CORTES.CORTE AND TIPO IN('Seg','Ter')) AS S_EXP ,coalesce((CORTES_V.P0+ CORTES_V.P1 + CORTES_V.P2+  CORTES_V.P3+ CORTES_V.P4+CORTES_V.P5+CORTES_V.P6+CORTES_V.P7+ CORTES_V.P8+CORTES_V.P9),0) AS VALES ,C2,C3,C4,C5   FROM CORTES LEFT JOIN CORTES_P ON CORTES.CORTE = CORTES_P.CORTE LEFT JOIN CORTES_E ON CORTES.CORTE = CORTES_E.CORTE LEFT JOIN CORTES_V ON CORTES.CORTE = CORTES_V.CORTE left JOIN CPO_COSTO ON CORTES.CPO=CPO_COSTO.CPO AND CORTES.ESTILO = CPO_COSTO.ESTILO AND CORTES.COLOR = CPO_COSTO.COLOR WHERE FCORTE > '" & fec & "' AND CORTES.TOTAL > 0 AND (CORTES.CLIENTE = '" & clientecmb.Text & "' OR 'TODOS' = '" & clientecmb.Text & "') ORDER BY CORTES.CORTE"
            llena_tablas(dt, strsql, cnn)
            fg.Rows.Count = dt.Rows.Count + 1
            For Each dr In dt.Rows
                fg(l, 1) = dr("CORTE")
                fg(l, 2) = dr("CLIENTE")
                fg(l, 3) = dr("CPO")
                fg(l, 4) = dr("ESTILO")
                fg(l, 5) = dr("COLOR")
                fg(l, 6) = dr("FPROD")
                fg(l, 7) = dr("P_PROD")
                fg(l, 8) = dr("S_PROD")
                fg(l, 9) = dr("TOTAL")
                fg(l, 10) = dr("P_EXP")
                fg(l, 11) = dr("S_EXP")
                fg(l, 12) = dr("VALES")
                dif = fg(l, 9) - (fg(l, 7) + fg(l, 8))
                fg(l, 13) = fg(l, 7) - fg(l, 10)
                fg(l, 14) = fg(l, 8) - fg(l, 11)

                For i = 13 To 16
                    Try
                        If dr(i) > 0 Then
                            val = dr(i)
                            Exit For
                        End If
                    Catch
                    End Try

                Next
                fg(l, 15) = (fg(l, 13) + fg(l, 14)) * val
                If (fg(l, 7) + fg(l, 8)) > 0 Then
                    l = l + 1
                End If
            Next
            fg.Rows.Count = l + 1
            subtotales()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button3.Visible = True
        regresa.Visible = True
        llena_grid()
        fecha.Enabled = False
    End Sub
    Private Sub subtotales()
        Dim i As Integer
        With fg
            For i = 13 To 15
                Try
                    fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
                Catch
                End Try
            Next i
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_grid()
        fecha.Enabled = True
        Button1.Visible = True
        Button3.Visible = False
        regresa.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\CMT_proyectado.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim f As Integer = fg.RowSel
        If f > 0 And f < fg.Rows.Count - 1 Then
            detalle_corte(f)
        End If
    End Sub

    Private Sub detalle_corte(ByVal f As Integer)
        Dim forma As New Inv_PT_1
        Try
            forma.corte.Text = fg(f, 1)
            forma.ShowDialog()
        Catch
        End Try
    End Sub

    Private Sub fg_afterfilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub

End Class