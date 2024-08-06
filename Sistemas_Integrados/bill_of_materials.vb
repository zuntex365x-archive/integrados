Imports System.IO
Imports C1.Win.C1FlexGrid
Module Module2
    Dim de As New DataTable()
    Dim esp As New DataTable()
    Dim cnn As SqlClient.SqlConnection
    Dim cod As String
    Public Sub boms(ByVal cliente As String, ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByVal t() As Integer, ByVal ad As Decimal, ByRef dt As DataTable)
        Dim row As DataRow
        Dim strsql As String
        Dim cnn As New SqlClient.SqlConnection()
        Dim codigo As String
        Dim unidad As Decimal
        Dim total As Integer
        Dim i As Integer

        Dim ta As New DataTable()
        ' ====== total de prendas
        For i = 1 To 10
            total = total + t(i)
        Next
        crea_tabla(dt)

        strsql = "SELECT MAT_EST_COL.*, DESCRIPCION, ('" & cpo & "') AS CPO, ('" & cliente & "') as CLIENTE , COSTO FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'"
        llena_tablas(ta, strsql, cnn)

        strsql = "SELECT CODIGO,DESCRIPCION,COSTO FROM MATERIALES WHERE LEFT(CODIGO,8) IN (SELECT LEFT(CODIGO,8) FROM MAT_EST_COL WHERE ESTILO = '" & estilo & "' AND COLOR = '" & colo & "')"
        llena_tablas(de, strsql, cnn)

        crea_codigos_especiales(esp)

        For Each row In ta.Rows
            codigo = row("CODIGO")
            unidad = row("UNIDAD")
            If Mid(codigo, 9, 2) = "00" Then
                simple(codigo, unidad, row("COSTO"), total, ad, row, dt, row("DESCRIPCION"))
            Else
                otros(codigo, unidad, row("COSTO"), t, ad, row, dt, row("ESTILO"))
            End If
        Next
    End Sub

    Private Sub crea_tabla(ByRef dt As DataTable)
        dt = New DataTable()
        Dim column As DataColumn
        ' ====== CODIGO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "CODIGO"
        dt.Columns.Add(column)

        ' ========= DESCRIPCION 
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "DESCRIPCION"
        dt.Columns.Add(column)

        ' ========= CONSUMO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "CONSUMO"
        dt.Columns.Add(column)

        ' ========= UNIDADES
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "UNIDADES"
        dt.Columns.Add(column)

        ' ========= COSTO
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Decimal")
        column.ColumnName = "COSTO"
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

        ' ========= CLIENTE
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "CLIENTE"
        dt.Columns.Add(column)
    End Sub

    Private Sub simple(ByVal codigo As String, ByVal unidad As Decimal, ByVal costo As Decimal, ByVal total As Integer, ByVal ad As Decimal, ByVal dr As DataRow, ByRef dt As DataTable, ByVal descripcion As String)
        Dim pres As Decimal
        pres = unidad * total * ad
        pres = Format(pres, "#######0")
        nueva_fila(dt, codigo, pres, total, costo, dr, descripcion)
    End Sub

    Private Sub otros(ByVal codigo As String, ByVal unidad As Decimal, ByVal costo As Decimal, ByVal t() As Integer, ByVal ad As Decimal, ByVal dr As DataRow, ByRef dt As DataTable, ByVal estilo As String)
        Dim i As Integer
        Dim pres As Decimal
        Dim descripcion As String = ""
        Dim ok As Boolean
        Dim pre As Decimal
        Dim cod As String = codigo
        If Mid(codigo, 9, 2) < "11" Then
            For i = 1 To 10
                If t(i) > 0 Then
                    pres = unidad * t(i) * ad
                    pre = pres
                    pres = Format(pres, "#######0")
                    codigo = Mid(codigo, 1, 8) + Format(i, "00")
                    busca_descripcion(codigo, descripcion, costo, de)
                    ok = True
                    '============ codigos especiales
                    If Mid(codigo, 1, 2) = "99" Then
                        codigo = cod
                        busca_codigos_especiales(esp, estilo, codigo, i, ok)
                        codigo = "9900" + Mid(codigo, 5)
                        If ok Then
                            If (pre - pres) > 0 Then
                                pres = pres + 1
                            End If
                            agrega_bolsa(codigo, pres, dt, t(i), dr)
                            nueva_fila(dt, codigo, pres, costo, t(i), dr, descripcion)
                        End If
                    Else
                        '======== codigos normales
                        nueva_fila(dt, codigo, pres, costo, t(i), dr, descripcion)
                    End If
                End If
            Next i
        End If
    End Sub

    Private Sub nueva_fila(ByRef dt As DataTable, ByVal codigo As String, ByVal consumo As Decimal, ByVal unidades As Decimal, ByVal costo As Decimal, ByVal dj As DataRow, ByVal descripcion As String)
        Dim dr As DataRow
        If consumo < 1 Then
            consumo = 1
        End If
        dr = dt.NewRow()
        dr("CODIGO") = codigo
        dr("DESCRIPCION") = descripcion
        dr("CONSUMO") = consumo
        dr("UNIDADES") = unidades
        dr("COSTO") = costo
        dr("CPO") = dj("CPO")
        dr("ESTILO") = dj("ESTILO")
        dr("COLOR") = dj("COLOR")
        dr("CLIENTE") = dj("CLIENTE")
        dt.Rows.Add(dr)
    End Sub

    Private Sub agrega_bolsa(ByVal codigo As String, ByVal pres As Decimal, ByRef dt As DataTable, ByVal unidades As Decimal, ByVal dr As DataRow)
        Dim descripcion As String = ""
        Dim costo As Decimal
        codigo = Mid(codigo, 1, 8) & "99"
        busca_descripcion(codigo, descripcion, costo, de)
        nueva_fila(dt, codigo, pres, unidades, costo, dr, descripcion)
    End Sub

    Private Sub busca_descripcion(ByVal codigo As String, ByRef descripcion As String, ByRef costo As Decimal, ByVal dt As DataTable)
        Dim dr As DataRow
        Dim dd As DataRow()
        dd = dt.Select("CODIGO ='" & codigo & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            descripcion = dr("DESCRIPCION")
            costo = dr("COSTO")
        Else
            descripcion = ""
        End If
    End Sub


    '==========================================================================
    '                      BOM GLOBAL
    '==========================================================================

    Public Sub bom_global(ByRef cr As C1FlexGrid, ByRef dg As DataTable, ByVal cliente As String)
        Dim dt As New DataTable()
        Dim mt As New DataTable()
        Dim dd As DataRow()
        dt = New DataTable()
        Dim cnn As New SqlClient.SqlConnection()
        Dim strSQL As String
        llena_codigos(cod, cliente)
        If Trim(cliente) <> "" Then
            strSQL = "SELECT  CPO_D.*, CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND ESTILO + COLOR IN (SELECT ESTILO + COLOR FROM MAT_EST_COL WHERE CODIGO IN " & cod & ") ORDER BY CPO_D.CPO,ESTILO,COLOR"
        Else
            strSQL = "SELECT  CPO_D.*, CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CPO_D.CPO,ESTILO,COLOR"
        End If
        Dim l As Integer = 1
        llena_tablas(dt, strSQL, cnn)
        strSQL = "SELECT CODIGO,DESCRIPCION FROM MATERIALES WHERE LEFT(CODIGO,8) IN (SELECT LEFT(CODIGO,8) FROM MAT_EST_COL WHERE ESTILO + COLOR IN (SELECT DISTINCT ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A'))"
        llena_tablas(de, strSQL, cnn)
        strSQL = "SELECT MAT_EST_COL.*,DESCRIPCION  FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO + COLOR IN (SELECT DISTINCT ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(mt, strSQL, cnn)
        Dim dr As DataRow
        cr.Rows.Count = dt.Rows.Count + 1
        crea_tabla(dg)
        crea_codigos_especiales(esp)
        For Each dr In dt.Rows
            cr(l, 1) = dr("CPO")
            cr(l, 2) = dr("ESTILO")
            cr(l, 3) = dr("COLOR")
            cr(l, 4) = dr("XS")
            cr(l, 5) = dr("S")
            cr(l, 6) = dr("M")
            cr(l, 7) = dr("L")
            cr(l, 8) = dr("XL")
            cr(l, 9) = dr("XL2")
            cr(l, 10) = dr("XL3")
            cr(l, 11) = dr("XL4")
            cr(l, 12) = dr("XL5")
            cr(l, 13) = dr("XL6")
            cr(l, 14) = dr("TOTAL")
            cr(l, 15) = dr("CLIENTE")
            dd = mt.Select("ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            Crea_detalle_bom(dr, dg, dd)
            l = l + 1
        Next
    End Sub

    Private Sub llena_codigos(ByRef cod As String, ByVal cliente As String)
        Dim strsql As String
        If Trim(cliente) <> "" Then
            strsql = "SELECT DISTINCT CODIGO FROM MAT_EST_COL WHERE ESTILO+COLOR IN (SELECT ESTILO + COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND CLIENTE = '" & cliente & "')"
        Else
            strsql = "SELECT DISTINCT CODIGO FROM MAT_EST_COL WHERE ESTILO+COLOR IN (SELECT ESTILO + COLOR FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A')"
        End If
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strsql, cnn)
        cod = "("
        For Each dr In dt.Rows
            cod = cod + "'" + dr("CODIGO") + "',"
        Next
        Try
            cod = Mid(cod, 1, cod.Length - 1) + ")"
        Catch
        End Try
    End Sub

    Private Sub Crea_detalle_bom(ByVal dr As DataRow, ByRef dg As DataTable, ByVal dd As DataRow())
        Dim dt As New DataTable()
        Dim cnn As New SqlClient.SqlConnection()
        Dim dj As DataRow
        Dim t(10) As Integer
        Dim codigo As String
        Dim con As New DataTable()
        Dim total As Integer
        Dim unidad As Decimal
        Dim costo As Decimal
        t(1) = dr("XS")
        t(2) = dr("S")
        t(3) = dr("M")
        t(4) = dr("L")
        t(5) = dr("XL")
        t(6) = dr("XL2")
        t(7) = dr("XL3")
        t(8) = dr("XL4")
        t(9) = dr("XL5")
        t(10) = dr("XL6")
        total = t(1) + t(2) + t(3) + t(4) + t(5) + t(6) + t(7) + t(8) + t(9) + t(10)
        For Each dj In dd
            codigo = dj("CODIGO")
            unidad = dj("UNIDAD")
            If InStr(1, cod, codigo, CompareMethod.Text) > 0 Then
                If Mid(codigo, 9, 2) = "00" Then
                    simple(codigo, unidad, costo, total, 1.05, dr, dg, dj("DESCRIPCION"))
                Else
                    otros(codigo, unidad, costo, t, 1.05, dr, dg, dj("ESTILO"))
                End If
            End If
        Next
    End Sub

    '==========================================================================
    '                      BOM GLOBAL
    '==========================================================================

    Public Sub bom_cpo(ByRef cr As C1FlexGrid, ByRef dg As DataTable, ByVal cpo As String, ByVal codigos As String)
        Dim dt As New DataTable()
        Dim mt As New DataTable()
        Dim dd As DataRow()
        dt = New DataTable()
        Dim cnn As New SqlClient.SqlConnection()
        Dim strSQL As String
        cod = codigos
        strSQL = "SELECT  CPO_D.*, CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND ESTILO + COLOR IN (SELECT ESTILO + COLOR FROM MAT_EST_COL WHERE CODIGO IN " & cod & ") ORDER BY CPO_D.CPO,ESTILO,COLOR"
        Dim l As Integer = 1
        llena_tablas(dt, strSQL, cnn)
        strSQL = "SELECT CODIGO,DESCRIPCION FROM MATERIALES WHERE LEFT(CODIGO,8) IN (SELECT LEFT(CODIGO,8) FROM MAT_EST_COL WHERE ESTILO + COLOR IN (SELECT DISTINCT ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A'))"
        llena_tablas(de, strSQL, cnn)
        strSQL = "SELECT MAT_EST_COL.*,DESCRIPCION  FROM MAT_EST_COL LEFT JOIN MATERIALES ON MAT_EST_COL.CODIGO = MATERIALES.CODIGO WHERE ESTILO + COLOR IN (SELECT DISTINCT ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(mt, strSQL, cnn)
        Dim dr As DataRow
        cr.Rows.Count = dt.Rows.Count + 1
        crea_tabla(dg)
        crea_codigos_especiales(esp)
        For Each dr In dt.Rows
            cr(l, 1) = dr("CPO")
            cr(l, 2) = dr("ESTILO")
            cr(l, 3) = dr("COLOR")
            cr(l, 4) = dr("XS")
            cr(l, 5) = dr("S")
            cr(l, 6) = dr("M")
            cr(l, 7) = dr("L")
            cr(l, 8) = dr("XL")
            cr(l, 9) = dr("XL2")
            cr(l, 10) = dr("XL3")
            cr(l, 11) = dr("XL4")
            cr(l, 12) = dr("XL5")
            cr(l, 13) = dr("XL6")
            cr(l, 14) = dr("TOTAL")
            cr(l, 15) = dr("CLIENTE")
            dd = mt.Select("ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            Crea_detalle_bom(dr, dg, dd)
            l = l + 1
        Next
    End Sub

    Public Sub crea_codigos_especiales(ByRef dt As DataTable)
        Dim cnn As New SqlClient.SqlConnection()
        Dim strsql = "SELECT * FROM MAT_EST_COL_ES "
        llena_tablas(dt, strsql, cnn)
    End Sub

    Public Sub busca_codigos_especiales(ByVal dt As DataTable, ByVal estilo As String, ByRef codigo As String, ByVal talla As Integer, ByRef ok As Boolean)
        Dim dd As DataRow()
        Dim dr As DataRow
        ok = False
        'codigo = Mid(codigo, 1, 8) + "01"
        dd = dt.Select("CODIGO = '" & codigo & "' AND ESTILO = '" & estilo & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            If dr(talla + 1) Then
                ok = True
            End If
        End If
    End Sub
End Module

