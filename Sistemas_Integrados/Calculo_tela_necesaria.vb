
Imports System.IO
Module uno
    Dim dt As New DataTable
    'Dim tsd As New DataTable
    Dim con As New DataTable
    Dim wip As New DataTable
    Dim res As New DataTable
    Dim edi As New DataTable
    Dim cli As New DataTable
    Dim ppc As Integer = 0
    Dim strsql As String = ""
    Dim cnn As New SqlClient.SqlConnection
 
    Public Sub calcula_tela_codigo(ByVal cliente As String, ByRef res As DataTable)
        Dim cortar As Integer
        Dim dr As DataRow
        Dim dw As DataRow
        Dim dd As DataRow()
        Dim da As DataRow
        Dim fect As Date
        'Dim pproc As Object
        Dim nec As Decimal
        Dim co As Decimal
        Dim dias As Integer = 28
        Dim proceso As Integer
        Dim total As Integer
        Dim cortado As Integer
        Dim estilo As String
        Dim colores As String
        Dim ww As DataRow()
        Dim wj As DataRow
        Dim fec As Date
        Dim fco As Date
        crea_tabla(res)
        llena_todas_las_tablas(cliente)
        busca_registro(cli, "CLIENTE", cliente, "MAXIMO", ppc)
        ppc = 100 + ppc
        For Each dr In dt.Rows
            estilo = dr("ESTILO")
            colores = dr("COLOR")
            Try
                proceso = dr("PROCESO")
            Catch
                proceso = 0
            End Try
            Try
                total = dr("TOTAL")
                total = CInt((total * ppc) / 100)
            Catch
                total = 0
            End Try
            Try
                cortado = dr("CORTADO")
            Catch
                cortado = 0
            End Try
            'If proceso > 0 Then
            'Try
            'pproc = tsd.Compute("SUM(TOTAL)", "ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "' AND CPO = '" & dr("CPO") & "' AND DESPACHO IS NULL")
            'If pproc > 0 And proceso >= pproc Then
            'proceso = proceso - pproc
            'End If
            'Catch
            'End Try
            'End If
            cortar = total - cortado - proceso
            If cortar > 0 Then
                dd = con.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & colores & "'")
                dias = 7

                For Each dw In dd
                    co = dw("LIBRAS")
                    nec = co * cortar
                    ww = wip.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colores & "' AND SEW_PLAN > '1900-01-01'")
                    If dr("CPO") = "3673707" Then
                        Dim jj As String
                        jj = "japa"
                    End If
                    If ww.Length > 0 Then
                        wj = ww(0)
                        Try
                            fec = wj("SEW_PLAN")
                        Catch
                            fec = Today
                        End Try
                        calcula_fecha_corte(edi, estilo, fec, fco)
                        fect = fco.AddDays(-7)   '============ Dias de anticipacion Tela
                    Else
                        fec = CDate("1900-01-01")
                        fect = CDate("1900-01-01")
                        fco = CDate("1900-01-01")
                    End If

                    ' ====================== AGREGA REGISTRO =======================
                    da = res.NewRow()
                    da("CLIENTE") = cliente
                    da("CODIGO") = dw("CODIGO")
                    da("COLORT") = dw("COLOR_TELA")
                    da("DESCRIPCION") = dw("DESCRIPCION")
                    da("CPO") = dr("CPO")
                    da("ESTILO") = dr("ESTILO")
                    da("COLOR") = dr("COLOR")
                    da("PRENDAS") = cortar
                    da("CONSUMO") = dw("LIBRAS")
                    da("NECESARIO") = nec
                    da("F_PROD") = fec
                    da("F_NEC") = fect
                    da("F_COR") = fco
                    res.Rows.Add(da)
                Next
            End If
        Next
    End Sub

    Private Sub llena_todas_las_tablas(ByVal cliente As String)
        dt = New DataTable()
        con = New DataTable()
        strsql = "SELECT CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR,TOTAL,CPO_D.F_ENTREGA,(SELECT SUM(TOTAL) FROM CORTES WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS CORTADO, (SELECT SUM(TOTAL)FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS PROCESO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CPO.CLIENTE = '" & cliente & "' AND ESTADO = 'A' ORDER BY CPO_D.ESTILO ,CPO_D.COLOR"
        llena_tablas(dt, strsql, cnn)
        strsql = "SELECT CONSUMO_TELA.*,DESCRIPCION FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO WHERE ESTILO_CPO + COLOR_CPO IN (SELECT DISTINCT ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND CONSUMO_TELA.CLIENTE = '" & cliente & "'"
        llena_tablas(con, strsql, cnn)
        strsql = "SELECT * FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT DISTINCT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(wip, strsql, cnn)
        'strsql = "SELECT CORTE,ESTILO,COLOR,CPO,TOTAL,(SELECT SUM(YARDAS) FROM DMOVTO WHERE DMOVTO.CORTE = CORTES_S.CORTE AND TMOVTO = '4') AS DESPACHO  FROM CORTES_S WHERE ESTADO = 'A'  AND CLIENTE = '" & cliente & "' ORDER BY ESTILO,COLOR,CPO"
        'llena_tablas(tsd, strsql, cnn)
        strsql = "SELECT ESTILO,DIAS_CORTE FROM ESTILOS_CORTE WHERE ESTILO IN (SELECT DISTINCT ESTILO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO  WHERE ESTADO = 'A' AND CLIENTE = '" & cliente & "')"
        llena_tablas(edi, strsql, cnn)
        strsql = "SELECT * FROM CLIENTES WHERE CLIENTE = '" & cliente & "'"
        llena_tablas(cli, strsql, cnn)
    End Sub

    Private Sub crea_tabla(ByRef dt As DataTable)
        dt = New DataTable()
        Dim column As DataColumn

        ' ====== CLIENTE
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "CLIENTE"
        dt.Columns.Add(column)

        ' ====== CODIGO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "CODIGO"
        dt.Columns.Add(column)

        ' ====== COLOR TELA
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "COLORT"
        dt.Columns.Add(column)

        ' ========= DESCRIPCION 
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "DESCRIPCION"
        dt.Columns.Add(column)

        ' ========= CPO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "CPO"
        dt.Columns.Add(column)

        ' ========= ESTILO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "ESTILO"
        dt.Columns.Add(column)

        ' ========= COLOR
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "COLOR"
        dt.Columns.Add(column)

        ' ========= PRENDAS
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "PRENDAS"
        dt.Columns.Add(column)

        ' ========= CONSUMO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "CONSUMO"
        dt.Columns.Add(column)

        ' ========= NECESARIO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "NECESARIO"
        dt.Columns.Add(column)

        ' ========= FECHA PRODUCCION
        column = New DataColumn()

        column.DataType = System.Type.GetType("System.DateTime")
        column.ColumnName = "F_PROD"
        dt.Columns.Add(column)

        ' ========= FECHA RECEPCION TELA
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.DateTime")
        column.ColumnName = "F_NEC"
        dt.Columns.Add(column)

        ' ========= FECHA CORTE
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.DateTime")
        column.ColumnName = "F_COR"
        dt.Columns.Add(column)
    End Sub

End Module
