Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class CMT_g
    Dim fe As Date
    Dim fo As Date
    Dim cnn As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        setea_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
  
    Private Sub crea_tabla()
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim ta As New DataTable
        Dim jt As New DataTable
        dt = New DataTable
        Dim strsql As String
        Dim keyColumn(5) As DataColumn
        strsql = "SELECT CPO.CLIENTE,CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,ESTADO,CPO_D.F_ENTREGA,F_PROMETIDA,DESTINO,F_INGRESO,VENDEDOR,COMISION,ESCALA,ESTILOS.* ,CPO_D.F_ENTREGA AS F_EXP FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN ESTILOS ON CPO.CLIENTE = ESTILOS.CLIENTE  AND CPO_D.ESTILO = ESTILOS.ESTILO WHERE ESTADO = 'A'"
        llena_tablas(dt, strsql, cnn)
        fecha_entrega(dt)
        strsql = "SELECT * FROM PUSH01 WHERE CLIENTE + CPO +ESTILO + COLOR IN (SELECT CLIENTE + CPO_D.CPO + ESTILO + COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A') ORDER BY FECHA_P DESC ,CLIENTE,ESTILO,COLOR"
        llena_tablas(ta, strsql, cnn)
        jt.Merge(dt)
        dt.Clear()
        For Each dr In jt.Rows
            Try
                dd = ta.Select("CLIENTE = '" & dr("CLIENTE") & "' AND CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
                If dd.Length > 0 Then
                    crea_divisiones(dd, dr)
                Else
                    dt.ImportRow(dr)
                End If
            Catch
                dt.ImportRow(dr)
            End Try
        Next
    End Sub
    Private Sub crea_divisiones(ByRef dd As DataRow(), ByRef dj As DataRow)
        Dim dr As DataRow = dd(0)
        Dim dg As DataRow
        Dim fecha As Date = dr("FECHA_P")
        Dim i As Integer
        Dim t As Integer
        Dim tota As Decimal
        Dim primera As Boolean = True
        For Each dr In dd
            If dr("FECHA_E") >= fo Then
                If fecha = dr("FECHA_P") Then
                    dg = dj
                    dg("F_EXP") = dr("FECHA_E")
                    t = 0
                    For i = 1 To 10
                        dg(i + 3) = dr(i + 5)
                        t = t + dr(i + 5)
                        Try
                            tota = dg(i + 3)
                        Catch ex As Exception
                            tota = 0
                        End Try
                    Next
                    dg(14) = t
                    dt.ImportRow(dg)
                End If
            End If
        Next
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim cliente As String
        Dim i As Integer
        Dim f As Integer
        Dim f_ini As String = Format(fecha.Value, "yyyy") + "-03-28"
        Dim f_fin As String = Format(fecha.Value, "yyyy") + "-09-1"
        Dim f_exp As Date
        Dim valor As Decimal
        Cursor = Cursors.WaitCursor
        crea_tabla()
        dd = dt.Select("F_EXP >= '" & f_ini & "' AND F_EXP <= '" & f_fin & "'")
        If dd.Length > 0 Then
            For Each dr In dd
                If dr("TOTAL") > 0 Then
                    cliente = dr("CLIENTE")
                    ' Verifica si el cliente es "PRANA" o "PRANA " y omite el procesamiento
                    If cliente.Trim().ToUpper() = "PRANA" Then
                        Continue For ' Salta al siguiente registro si el cliente es "PRANA"
                    End If

                    ' Continúa con el procesamiento para otros clientes
                    f = fg.FindRow(cliente, 1, 1, False)
                    f_exp = dr("F_EXP")
                    i = f_exp.Month
                    valor = (dr("CORTE") + dr("COSTURA") + dr("HILO") + dr("EMPAQUE") + dr("OTROS")) / 12
                    valor = valor * dr("TOTAL")
                    fg(f, i + 1) = fg(f, i + 1) + valor
                    fg(f, 14) = fg(f, 14) + valor
                End If
            Next
        End If
    End Sub



    Private Sub llena_clientes()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            l = l + 1
        Next
    End Sub
    Private Sub fecha_entrega(ByRef dt As DataTable)
        Dim cnn As New SqlClient.SqlConnection
        Dim dg As New DataTable
        Dim je As New DataTable
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim strsql As String = "SELECT DISTINCT CPO+ESTILO+COLOR,CPO,ESTILO,COLOR,EXP_REV FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND EXP_REV > '1900-01-01' ORDER BY CPO,ESTILO,COLOR,EXP_REV DESC"
        llena_tablas(dg, strsql, cnn)
        strsql = "SELECT CPO,ESTILO,COLOR,SUM(XS) AS XS,SUM(S) AS S,SUM(M) AS M,SUM(L) AS L,SUM(XL) AS XL,SUM(XL2) AS XL2,SUM(XL3) AS XL3,SUM(XL4) AS XL4,SUM(XL5) AS XL5,SUM(XL6) AS XL6 FROM PACKING_D WHERE TIPO = 'Pri' AND CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A' ) GROUP BY CPO,ESTILO,COLOR"
        llena_tablas(je, strsql, cnn)
        For Each dr In dt.Rows
            dd = dg.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                If dj("EXP_REV") > CDate("1900-01-01") Then
                    dr("F_EXP") = dj("EXP_REV")
                End If
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button3.Visible = True
        regresa.Visible = True
        llena_clientes()
        llena_grid()
        subtotales()
        fecha.Enabled = False
    End Sub

    Private Sub subtotales()
        Dim i As Integer

        With fg
            For i = 2 To fg.Cols.Count - 1
                fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
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
        a_excel(fg, "c:\reportes\ventas_proyectadas_u.xls", ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub detalle_ventas(ByVal f As Integer, ByVal c As Integer)
        Dim ffi As String = Format(fecha.Value, "yyyy") + "-" + Format(c - 1, "00") + "-01"
        Dim fff As String
        Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 50
        Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
        Dim forma As New CMT_g1()
        forma.Size = New Size(l, a - 20)
        forma.fg.Width = l - 30
        forma.fg.Height = a - 190
        forma.dt = dt
        forma.cliente.Text = fg(f, 1)
        fff = Format(UltimoDiaDelMes(CDate(ffi)), "yyyy-MM-dd")
        Try
            forma.fecha.Text = "Del " & Format(CDate(ffi), "dd/MMM/yyyy") & " al " & Format(CDate(fff), "dd/MMM/yyyy")
            forma.strsql = "F_EXP > = '" & ffi & "' AND F_EXP < = '" & fff & "' AND CLIENTE = '" & fg(f, 1) & "'"
            forma.ShowDialog()
        Catch
        End Try
    End Sub

    Private Sub fg_Click_1(sender As System.Object, e As System.EventArgs) Handles fg.Click
        Dim f As Integer = fg.RowSel
        Dim c As Integer = fg.ColSel
        If c > 1 And f > 0 And f < fg.Rows.Count - 2 Then
            detalle_ventas(f, c)
        End If
    End Sub
End Class