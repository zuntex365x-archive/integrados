Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports C1.C1Excel
Imports System
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Net.Mail
Imports System.Net
Module Module1
    Public _styles As Hashtable

    Public Sub def_sql(ByRef cnn As System.Data.SqlClient.SqlConnection)
        Dim obj As New empresas()
        cnn = New System.Data.SqlClient.SqlConnection()
        cnn.ConnectionString = obj.constr
    End Sub

    Public Sub Estado_Tela(ByVal con As Object, ByVal C4 As System.Windows.Forms.ComboBox)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        Dim strSQL As String = "SELECT * FROM ESTADOS_TELA WHERE CODIGO != 'S'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            C4.Items.Add(dr("ESTADO_TELA"))
        Next
        C4.Items.Add("TODOS")
    End Sub

    Public Sub a_excel(ByVal fg As C1FlexGrid, ByVal path As String, ByRef ok As Boolean)
        Try
            Dim ch As Char = Microsoft.VisualBasic.Chr(9)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells + FileFlags.VisibleOnly)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            ok = False
        End Try
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
        End If
    End Sub

    Public Sub llena_clientes(ByRef C4 As System.Windows.Forms.ComboBox)
        Dim cnn As New System.Data.SqlClient.SqlConnection()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strsql As String = "SELECT CLIENTE FROM CLIENTES ORDER BY CLIENTE"
        C4.Items.Add("TODOS")
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            C4.Items.Add(Trim(dr("CLIENTE")))
        Next
    End Sub
    Public Function get_codigo_color(ByVal cliente As String, ByVal color As String) As String
        Dim cnn As New SqlClient.SqlConnection
        Dim dt As New DataTable
        Dim dr As DataRow = Nothing
        Dim codigo As String = ""
        llena_tablas(dt, "SELECT * FROM COLORES WHERE CLIENTE = '" & cliente & "' AND COLOR = '" & color & "'", cnn)
        For Each dr In dt.Rows
            Try
                codigo = dr("CODIGO_C")
            Catch ex As Exception
            End Try
        Next
        Return codigo
    End Function
    Public Sub tallas_cortes(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByRef fg As C1.Win.C1FlexGrid.C1FlexGrid, ByVal fil As Integer, ByVal col As Integer)
        Dim i As Integer
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection
        Dim escala As String
        Try
            llena_tablas(dt, "SELECT * FROM CPO_D WHERE CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'", cnn)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                escala = dr("ESCALA")
                llena_tablas(dt, "SELECT * FROM E_TALLAS WHERE ESCALA = '" & escala & "'", cnn)
                If dt.Rows.Count > 0 Then
                    dr = dt.Rows(0)
                    For i = 1 To 10
                        fg(fil, col) = dr(i + 1)
                        col = col + 1
                    Next
                End If

            End If
        Catch
        End Try
    End Sub

    Public Sub get_escalas(ByRef ge As String)
        Dim cnn As New SqlClient.SqlConnection
        Dim dt As New DataTable
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM E_TALLAS ", cnn)
        For Each dr In dt.Rows
            ge = ge + dr("NOMBRE") + "|"
        Next
    End Sub
    Public Function lector_dc() As String
        Dim dc As String = "Data Source=192.9.200.3\JT;Initial Catalog=lector;Persist Security Info=True;User ID=user_l;Password=Lector_01"
        Return dc
    End Function
    Public Function get_tallas(ByVal escala As String) As DataRow
        Dim cnn As New SqlClient.SqlConnection
        Dim dt As New DataTable
        Dim dr As DataRow = Nothing
        llena_tablas(dt, "SELECT * FROM E_TALLAS WHERE ESCALA = '" & Format(CInt(escala), "00") & "'", cnn)
        For Each dr In dt.Rows
            get_tallas = dr
        Next
        Return dr
    End Function
    Public Sub talla_Grid(ByRef fg As C1.Win.C1FlexGrid.C1FlexGrid, ByVal col As Integer, ByVal adulto As Boolean)
        Dim t As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
        Dim co As String()
        Dim tit As String
        Dim i As Integer
        co = Split(t, "|")
        For i = col To col + 9
            If adulto Then
                tit = co(i - col)
            Else
                tit = "T" + Format(i - col + 1, "00")
            End If
            fg(0, i) = tit
            fg.Cols(i).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(i).TextAlignFixed = TextAlignEnum.CenterCenter
        Next
    End Sub
    Public Sub talla_setea(ByVal ta As C1.Win.C1FlexGrid.C1FlexGrid, ByVal escala As Integer)
        Dim t As String = Format(escala, "00")
        Dim dr As DataRow
        Dim i As Integer
        dr = get_tallas(t)
        For i = 1 To 10
            t = dr(i + 1)
            ta(0, i) = t
            ta(1, i) = 0
            If Trim(t) = "" Then
                ta.Cols(i).AllowEditing = False
            Else
                ta.Cols(i).AllowEditing = True
            End If
        Next
        ta(0, 11) = "TOTALES"
        ta(1, 11) = 0
        ta.SetCellStyle(1, 11, ta.Styles("amarillo"))
        ta.Enabled = False
    End Sub

    Public Sub llena_tipos_stock(ByRef C4 As System.Windows.Forms.ComboBox, ByRef tips As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim tps As New C1.Win.C1FlexGrid.C1FlexGrid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New System.Data.SqlClient.SqlConnection()
        Dim strsql As String = "SELECT * FROM TIPO_STOCK ORDER BY TIPO"
        Dim l As Integer
        llena_tablas(dt, strsql, cnn)
        tps.Clear()
        tps.Rows.Count = 0
        tps.Cols.Count = 2
        For Each dr In dt.Rows
            tps.Rows.Count = tps.Rows.Count + 1
            l = tps.Rows.Count - 1
            C4.Items.Add(dr("DESCRIPCION"))
            tps(l, 0) = dr("TIPO")
            tps(l, 1) = dr("DESCRIPCION")
        Next
        tips = tps
    End Sub

    Public Sub llena_salas(ByVal sala As System.Windows.Forms.ComboBox, ByVal cnn As SqlClient.SqlConnection, ByVal todas As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        sala.Items.Clear()
        If todas = "S" Then
            sala.Items.Add("TODAS")
        End If
        Dim strSQL As String = "SELECT * FROM SALAS"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            sala.Items.Add(dr("SALA"))
        Next
        If sala.Items.Count > 0 Then
            sala.SelectedIndex = 0
        End If
    End Sub

    Public Sub flex_a_dt(ByRef fg As C1.Win.C1FlexGrid.C1FlexGrid, ByRef dt As DataTable)
        Dim dr As DataRow
        Dim dc As DataColumn
        Dim i As Integer
        Dim j As Integer
        Dim colnom As String
        dt = New DataTable()
        For j = 1 To fg.Cols.Count - 1
            colnom = fg(0, j)
            dt.Columns.Add(colnom)
            dc = New DataColumn(colnom)
            dc.DataType = fg.Cols(j).GetType      'System.Type.GetType("System.String")
        Next
        For i = 1 To fg.Rows.Count - 1
            dr = dt.NewRow
            For j = 1 To fg.Cols.Count - 1
                dr.Item(j - 1) = fg(i, j)
            Next
            dt.Rows.Add(dr)
        Next
    End Sub

    Public Sub llena_combos(ByVal combo As System.Windows.Forms.ComboBox, ByVal strsql As String, ByVal campo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        llena_tablas(dt, strsql, cnn)
        combo.Items.Clear()
        combo.Text = ""
        Try
            For Each dr In dt.Rows
                combo.Items.Add(dr(campo))
            Next
            If combo.Items.Count > 0 Then
                combo.SelectedIndex = 0
            End If
        Catch
        End Try
    End Sub

    Public Sub llena_combos_e(ByVal combo As System.Windows.Forms.ComboBox, ByVal e As String, ByVal strsql As String, ByVal campo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        Dim constr As String = ""
        Dim cs As New Lib_SI.util
        cnn.ConnectionString = cs.con_string(e)
        llena_tablas_e(dt, strsql, cnn)
        combo.Items.Clear()
        combo.Text = ""
        Try
            For Each dr In dt.Rows
                combo.Items.Add(dr(campo))
            Next
            If combo.Items.Count > 0 Then
                combo.SelectedIndex = 0
            End If
        Catch
        End Try
    End Sub
    Public Sub llena_combos_d(ByVal combo As System.Windows.Forms.ComboBox, ByVal dt As DataTable, ByVal campo As String)
        Dim dr As DataRow
        combo.Items.Clear()
        combo.Text = ""
        Try
            For Each dr In dt.Rows
                combo.Items.Add(dr(campo))
            Next
            If combo.Items.Count > 0 Then
                combo.SelectedIndex = 0
            End If
        Catch
        End Try
    End Sub

    Public Sub llena_tablas(ByRef dt As DataTable, ByVal strSql As String, ByRef cnn As SqlClient.SqlConnection)
        Dim obj As empresas
        Dim da As System.Data.SqlClient.SqlDataAdapter
        cnn = New System.Data.SqlClient.SqlConnection()
        obj = New empresas()
        cnn.ConnectionString = obj.constr
        Dim ds As New DataSet()
        da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
        Try
            da.Fill(ds)
            dt = ds.Tables(0)
        Catch
        End Try
    End Sub
    Public Sub llena_tablas_e(ByRef dt As DataTable, ByVal strSql As String, ByRef cnn As SqlClient.SqlConnection)
        Dim da As System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet()
        da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
        Try
            da.Fill(ds)
            dt = ds.Tables(0)
        Catch
        End Try
    End Sub
    Public Sub llena_tablas_con(ByRef dt As DataTable, ByVal con() As String, ByVal strSql As String)
        Dim cnn As New SqlClient.SqlConnection
        Dim da As System.Data.SqlClient.SqlDataAdapter
        Dim ta As New DataTable
        Dim i As Integer
        Dim Col As New DataColumn
        dt = New DataTable
        For i = 1 To con.Length - 2
            cnn.ConnectionString = con(i)
            Dim ds As New DataSet()
            da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
            Try
                da.Fill(ds)
                ta = New DataTable
                ta = ds.Tables(0)
                Col = New DataColumn
                With Col
                    .ColumnName = "EMPRESA"
                    .DataType = System.Type.GetType("System.String")
                    .DefaultValue = CStr(i)
                End With
                ta.Columns.Add(Col)


                'Col = ta.Columns.Add("EMPRESA", Type.GetType("System.String"))
                'Col.DefaultValue = CStr(i)

                dt.Merge(ta)
            Catch
            End Try
        Next
    End Sub
    Public Sub llena_tablas_con1(ByRef dt As DataTable, ByVal con() As String, ByVal strSql As String)
        Dim cnn As New SqlClient.SqlConnection
        Dim da As System.Data.SqlClient.SqlDataAdapter
        Dim ta As New DataTable
        Dim i As Integer
        Dim Col As New DataColumn
        For i = 1 To con.Length - 2
            cnn.ConnectionString = con(i)
            Dim ds As New DataSet()
            da = New System.Data.SqlClient.SqlDataAdapter(strSql, cnn)
            Try
                da.Fill(ds)
                ta = New DataTable
                ta = ds.Tables(0)
                Col = New DataColumn
                With Col
                    .ColumnName = "EMPRESA"
                    .DataType = System.Type.GetType("System.String")
                    .DefaultValue = CStr(i)
                End With
                ta.Columns.Add(Col)

                dt.Merge(ta)
            Catch
            End Try
        Next
    End Sub

    Public Sub lee_cortes_pad(ByVal strsql As String, ByRef dr As DataRow, ByRef ep As String, ByRef es As String, ByRef rp As String, ByRef rs As String, ByRef ok As Boolean)
        Dim te(40) As String
        Dim cnn As New System.Data.SqlClient.SqlConnection()
        Dim dt As New DataTable()
        Dim i As Integer
        Dim lin As String
        Dim val As Integer
        Dim tas As String = "EP0,EP1,EP2,EP3,EP4,EP5,EP6,EP7,EP8,EP9,ES0,ES1,ES2,ES3,ES4,ES5,ES6,ES7,ES8,ES9,RP0,RP1,RP2,RP3,RP4,RP5,RP6,RP7,RP8,RP9,RS0,RS1,RS2,RS3,RS4,RS5,RS6,RS7,RS8,RS9"
        ok = False
        ep = ""
        es = ""
        rp = ""
        rs = ""
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            te = Split(tas, ","c)
            For i = 0 To 39
                lin = te(i)
                val = dr(lin)
                If i < 10 Then
                    ep = ep + CStr(val) + ","
                ElseIf i < 20 Then
                    es = es + CStr(val) + ","
                ElseIf i < 30 Then
                    rp = rp + CStr(val) + ","
                Else
                    rs = rs + CStr(val) + ","
                End If
            Next
            ep = Mid(ep, 1, Len(ep) - 1)
            es = Mid(es, 1, Len(es) - 1)
            rp = Mid(rp, 1, Len(rp) - 1)
            rs = Mid(rs, 1, Len(rs) - 1)
            ok = True
        End If
    End Sub

    Public Sub codif_tela(ByVal codt As DataTable, ByVal cod As String, ByRef descr As String, ByRef ok As Boolean)
        Dim i As Integer
        Dim p As String
        Dim r As Integer
        Dim d As String
        Dim t(4) As String
        Dim dr As DataRow
        Dim res As DataRow()
        descr = ""
        t = Split("ORDEN,FABRIC,WEIGHT,CONTENID,FIBRA", ","c)
        ok = True
        If cod.Length <> 8 Then
            descr = "MAL CODIGO"
            ok = False
            Exit Sub
        End If
        For i = 1 To 8 Step 2
            r = (i - 1) / 2 + 1
            p = Mid(cod, i, 2)
            res = codt.Select("ORDEN = '" & p & "'")
            Try
                dr = res(0)
                d = Trim(dr(t(r)))
                If d <> Nothing Then
                    descr = descr & d & " "
                Else
                    ok = False
                End If
            Catch
                ok = False
            End Try
        Next
        If Not ok Then
            descr = "MAL CODIGO"
        End If
    End Sub

    Public Sub llena_clientes_cpo(ByRef C4 As System.Windows.Forms.ComboBox)
        Dim cnn As New System.Data.SqlClient.SqlConnection()
        Dim dt As New DataTable()
        Dim td As New DataTable()
        Dim dr As DataRow
        Dim tr As DataRow
        Dim obj As empresas
        Dim strsql As String
        obj = New empresas()
        C4.Items.Clear()
        strsql = "SELECT * FROM USUARIO_CLIENTE WHERE USUARIO = '" & obj.clave & "' ORDER BY CLIENTE"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            If dr("CLIENTE") = "TODOS" Then
                strsql = "SELECT CLIENTE FROM CLIENTES ORDER BY CLIENTE"
                llena_tablas(td, strsql, cnn)
                For Each tr In td.Rows
                    C4.Items.Add(tr("CLIENTE"))
                Next
                Try
                    C4.SelectedIndex = 0
                Catch
                End Try
                Exit Sub
            End If
            C4.Items.Add(dr("CLIENTE"))
        Next
        Try
            C4.SelectedIndex = 0
        Catch
        End Try
    End Sub
    Public Sub llena_clientes_usuario_t(ByRef cl As DataTable)
        Dim strsql As String
        Dim obj As New empresas
        Dim dt As New DataTable
        Dim cnn As New SqlClient.SqlConnection
        Dim dr As DataRow
        cl = New DataTable
        strsql = "SELECT CLIENTE FROM USUARIO_CLIENTE WHERE USUARIO = '" & obj.clave & "' ORDER BY CLIENTE"
        llena_tablas(cl, strsql, cnn)
        For Each dr In cl.Rows
            If dr("CLIENTE") = "TODOS" Then
                strsql = "SELECT CLIENTE FROM CLIENTES ORDER BY CLIENTE"
                llena_tablas(dt, strsql, cnn)
                cl = dt
            End If
        Next
    End Sub

    Public Sub grabar_sql(ByVal strsql As String, ByRef cnn As SqlClient.SqlConnection, ByRef afectados As Integer)
        Try
            afectados = 0
            Dim obj As New empresas()
            cnn.ConnectionString = obj.constr
            cnn.Open()

            Dim graba As New SqlClient.SqlCommand(strsql, cnn)
            afectados = graba.ExecuteNonQuery()
        Catch
        Finally
            cnn.Close()
        End Try
    End Sub

    Public Sub llena_fpos_rec(ByVal cliente As String, ByRef fpo As DataTable, ByRef f_rec As DataTable)
        Dim cnn As New SqlClient.SqlConnection()
        Dim fpol As String
        Dim fpoes As String
        Dim dr As DataRow
        Dim p As Integer
        Dim strSQl As String = "SELECT * FROM FPO WHERE CPO IN (SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A') AND CLIENTE = '" & cliente & "' AND TIPO = 'TELA' ORDER BY CPO,COLOR,CODIGO"
        llena_tablas(fpo, strSQl, cnn)
        fpol = "("
        For Each dr In fpo.Rows
            fpoes = "'" & dr("FPO") & "'"
            p = fpol.IndexOf(fpoes)
            If p = -1 Then
                fpol = fpol & fpoes & ","
            End If
        Next
        fpol = Mid(fpol, 1, Len(fpol) - 1) + ")"
        fecha_recepcion(f_rec, fpol)
    End Sub

    Public Sub quita_caracter(ByRef texto As String, ByVal caracter As String)
        Dim p As Integer = texto.IndexOf(caracter)
        While p > 0
            texto = Mid(texto, 1, p) + Mid(texto, p + 2)
            p = texto.IndexOf(caracter)
        End While
    End Sub

    Public Sub adios(ByRef nombre As String)
        quita_caracter(nombre, "/")
        quita_caracter(nombre, "\")
    End Sub

    Public Sub graba_t(ByVal cnn As SqlClient.SqlConnection, ByVal strsql As String)
        Dim afectados As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion
        Try
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos, no se pudo actualizar.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Public Sub fecha_recepcion(ByRef f_rec As DataTable, ByRef fpol As String)
        f_rec = New DataTable()
        Dim strsql As String
        Dim cnn As New SqlClient.SqlConnection
        strsql = "SELECT DISTINCT FECHA, DMOVTO.CPO,DMOVTO.FPO, TIPO, CODIGO,COLOR, LOTE FROM DMOVTO, ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' AND DMOVTO.FPO IN " & fpol
        llena_tablas(f_rec, strsql, cnn)
    End Sub
#Region "** Load an XLSheet into a C1FlexGrid"

    'Private _styles As Hashtable

    ' load sheet into grid 
    Public Sub LoadSheet(ByVal flex As C1FlexGrid, ByVal sheet As XLSheet, ByVal fixedCells As Boolean)
        ' account for fixed cells 
        Dim frows As Integer = flex.Rows.Fixed
        Dim fcols As Integer = flex.Cols.Fixed

        ' copy dimensions 
        flex.Rows.Count = sheet.Rows.Count + frows
        flex.Cols.Count = sheet.Columns.Count + fcols

        ' initialize fixed cells 
        Dim r As Integer
        Dim c As Integer
        If fixedCells AndAlso frows > 0 AndAlso fcols > 0 Then
            flex.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            For r = 1 To flex.Rows.Count - 1
                flex(r, 0) = r
            Next
            'For c = 1 To flex.Cols.Count - 1
            '    Dim hdr As String = String.Format("{0}", CChar(("A") + c - 1))
            '    flex(0, c) = hdr
            'Next
        End If

        ' set default properties 
        flex.Font = sheet.Book.DefaultFont
        flex.Rows.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultRowHeight)
        flex.Cols.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultColumnWidth)

        ' prepare to convert styles 
        _styles = New Hashtable()

        ' set row/column properties 
        For r = 0 To sheet.Rows.Count - 1
            ' size/visibility 
            Dim fr As Row = flex.Rows(r + frows)
            Dim xr As XLRow = sheet.Rows(r)
            If xr.Height >= 0 Then
                fr.Height = C1XLBook.TwipsToPixels(xr.Height)
            End If
            fr.Visible = xr.Visible

            ' style 
            Dim cs As CellStyle = StyleFromExcel(flex, xr.Style)
            If cs Is Nothing Then
            Else
                'cs.DefinedElements &= ~StyleElementFlags.TextAlign; // << need to fix the grid 
                fr.Style = cs
            End If
        Next
        For c = 0 To sheet.Columns.Count - 1
            ' size/visibility 
            Dim fc As Column = flex.Cols(c + fcols)
            Dim xc As XLColumn = sheet.Columns(c)
            If xc.Width >= 0 Then
                fc.Width = C1XLBook.TwipsToPixels(xc.Width)
            End If
            fc.Visible = xc.Visible

            ' style 
            Dim cs As CellStyle = StyleFromExcel(flex, xc.Style)
            If cs Is Nothing Then
            Else
                'cs.DefinedElements &= ~StyleElementFlags.TextAlign; // << need to fix the grid 
                fc.Style = cs
            End If
        Next


        ' load cells 
        For r = 0 To sheet.Rows.Count - 1
            For c = 0 To sheet.Columns.Count - 1
                ' get cell 
                Dim cell As XLCell = sheet.GetCell(r, c)
                If cell Is Nothing Then
                Else
                    ' apply content 
                    flex(r + frows, c + fcols) = cell.Value

                    ' apply style 
                    Dim cs As CellStyle = StyleFromExcel(flex, cell.Style)
                    If cs Is Nothing Then
                    Else

                        flex.SetCellStyle(r + frows, c + fcols, cs)
                    End If
                End If
            Next
        Next
    End Sub

    ' convert Excel style into FlexGrid style 
    Private Function StyleFromExcel(ByVal flex As C1FlexGrid, ByVal style As XLStyle) As CellStyle
        ' sanity 
        If style Is Nothing Then
            Return (Nothing)
        End If

        ' look it up on list 
        If _styles.Contains(style) Then
            Return _styles(style)
        End If

        ' create new flex style 
        Dim cs As CellStyle = flex.Styles.Add(_styles.Count.ToString())

        ' set up new style 
        If style.Font Is Nothing Then
        Else
            cs.Font = style.Font
        End If
        'If style.ForeColor = Color.Transparent Then
        'Else
        cs.ForeColor = style.ForeColor
        'End If
        'If style.BackColor <> Color.Transparent Then
        cs.BackColor = style.BackColor
        'End If
        If style.Rotation = 90 Then
            cs.TextDirection = TextDirectionEnum.Up
        End If
        If style.Rotation = 180 Then
            cs.TextDirection = TextDirectionEnum.Down
        End If
        If style.Format Is Nothing Then
        Else
            If style.Format.Length > 0 Then
                cs.Format = XLStyle.FormatXLToDotNet(style.Format)
            End If
        End If
        Select Case style.AlignHorz
            Case (XLAlignHorzEnum.Center)
                cs.WordWrap = style.WordWrap
                Select Case style.AlignVert
                    Case (XLAlignVertEnum.Top)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop
                        Exit Select
                    Case (XLAlignVertEnum.Center)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                        Exit Select
                    Case Else
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterBottom
                        Exit Select
                End Select
                Exit Select
            Case (XLAlignHorzEnum.Right)
                cs.WordWrap = style.WordWrap
                Select Case style.AlignVert
                    Case (XLAlignVertEnum.Top)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightTop
                        Exit Select
                    Case (XLAlignVertEnum.Center)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
                        Exit Select
                    Case Else
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom
                        Exit Select
                End Select
                Exit Select
            Case (XLAlignHorzEnum.Left)
                cs.WordWrap = style.WordWrap
                Select Case style.AlignVert
                    Case (XLAlignVertEnum.Top)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftTop
                        Exit Select
                    Case (XLAlignVertEnum.Center)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
                        Exit Select
                    Case Else
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
                        Exit Select
                End Select
                Exit Select
            Case Else
                cs.WordWrap = style.WordWrap
                Select Case style.AlignVert
                    Case (XLAlignVertEnum.Top)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.GeneralTop
                        Exit Select
                    Case (XLAlignVertEnum.Center)
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.GeneralCenter
                        Exit Select
                    Case Else
                        cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.GeneralBottom
                        Exit Select
                End Select
                Exit Select
        End Select

        ' save it 
        _styles.Add(style, cs)

        ' return it 
        Return (cs)
    End Function
#End Region

    'Public Class myPrinter
    '    Friend TextToBePrinted As String
    '    Public Sub prt(ByVal text As String)
    '        TextToBePrinted = text
    '        Dim prn As New Printing.PrintDocument()
    '        Try
    '            prn.PrinterSettings.PrinterName = "PrinterName"
    '            AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
    '            prn.Print()
    '            RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
    '        Catch
    '        End Try
    '    End Sub
    '    Private Sub PrintPageHandler(ByVal sender As Object, _
    '       ByVal args As Printing.PrintPageEventArgs)
    '        Dim myFont As New Font("Microsoft San Serif", 10)
    '        args.Graphics.DrawString(TextToBePrinted, _
    '           New Font(myFont, FontStyle.Regular), _
    '           Brushes.Black, 50, 50)
    '    End Sub
    'End Class

    Public Sub AutoCompletar(ByRef cb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim strFindStr As String
        Dim i As Integer = cb.SelectedIndex
        If e.KeyChar = Chr(8) Then  'Backspace
            If cb.SelectionStart <= 1 Then
                cb.SelectionStart = 1
                ' Exit Sub
            End If
            If cb.SelectionLength = 0 Then
                strFindStr = cb.Text.Substring(0, cb.Text.Length - 1)
            Else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1)
            End If
        Else
            If cb.SelectionLength = 0 Then
                strFindStr = cb.Text & e.KeyChar
            Else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart) & e.KeyChar
            End If
        End If

        Dim intIdx As Integer = -1

        ' Busca el string en el combobox 
        intIdx = cb.FindString(strFindStr)

        If intIdx <> -1 Then ' String encontrado
            cb.SelectedText = ""
            cb.SelectedIndex = intIdx
            cb.SelectionStart = strFindStr.Length
            cb.SelectionLength = cb.Text.Length
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub a_pdf(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid, ByVal archivo As String, ByVal encabezado As String, ByVal pie As String)
        Dim pd As New PrintDocument()
        Dim pdf As New C1.C1Pdf.C1PdfDocument()
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyyy")
        fg.PrintParameters.PrintGridFlags = PrintGridFlags.FitToPageWidth
        fg.PrintParameters.Header = encabezado
        fg.PrintParameters.Footer = pie
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)

        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 20
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With

        ' Guarda el controller original
        Dim savePrintController As PrintController = pd.PrintController

        ' Reemplaza el previewcontroler por el printcontroller
        Dim previewController As New PreviewPrintController()
        pd.PrintController = previewController

        ' Imprime el documento detro del preview controller 
        pd.Print()

        ' restore original PrintController
        pd.PrintController = savePrintController

        ' Setea los nuevos documentos pdf
        pdf.Clear()
        pdf.PaperKind = pd.DefaultPageSettings.PaperSize.Kind
        pdf.Landscape = pd.DefaultPageSettings.Landscape

        ' copia las paginas a pdf
        Dim pages() As PreviewPageInfo = previewController.GetPreviewPageInfo
        Dim i As Integer
        For i = 0 To pages.Length - 1
            If i > 0 Then pdf.NewPage()
            pdf.DrawImage(pages(i).Image, pdf.PageRectangle)
        Next

        ' graba ele archivo pdf
        Dim fileName = archivo
        Try
            File.Delete(fileName)
            pdf.Save(fileName)
            '   System.Diagnostics.Process.Start(fileName)
        Catch
            MsgBox("No pude crear el archivo pdf. Por favor cierre el acrobat y prueba de nuevo", MsgBoxStyle.Critical, "Error al Crear Archivo")
        End Try
    End Sub


#Region "** Save a C1FlexGrid into an XLSheet"
    Public Sub SaveSheet(ByVal _book As C1XLBook, ByVal flex As C1FlexGrid, ByVal sheet As XLSheet, ByVal fixedCells As Boolean)
        ' crea nuevo estilo
        Dim nestilo As New XLStyle(_book)
        nestilo.Font = New Font("Arial", 9, FontStyle.Regular)
        nestilo.ForeColor = Color.Black

        Dim cabeza As New XLStyle(_book)
        cabeza.Font = New Font("Arial", 9, FontStyle.Regular)
        cabeza.ForeColor = Color.Black
        cabeza.BackColor = Color.LimeGreen


        ' account for fixed cells 

        Dim frows As Integer = flex.Rows.Fixed
        Dim fcols As Integer = flex.Cols.Fixed
        If fixedCells Then
            frows = 0
            fcols = 0
        End If

        ' copy dimensions 
        Dim lastRow As Integer = flex.Rows.Count - frows - 1
        Dim lastCol As Integer = flex.Cols.Count - fcols - 1
        If lastRow < 0 OrElse lastCol < 0 Then
            Exit Sub
        End If
        Dim cell As XLCell = sheet(lastRow, lastCol)

        ' set default properties 
        sheet.Book.DefaultFont = New Font("Arial", 9, FontStyle.Regular) 'flex.Font
        sheet.DefaultRowHeight = C1XLBook.PixelsToTwips(flex.Rows.DefaultSize)
        sheet.DefaultColumnWidth = C1XLBook.PixelsToTwips(flex.Cols.DefaultSize)

        ' prepare to convert styles 
        _styles = New Hashtable()

        ' set row/column properties 
        Dim r As Integer
        For r = frows To flex.Rows.Count - 1
            ' size/visibility 
            Dim fr As Row = flex.Rows(r)
            Dim xr As XLRow = sheet.Rows(r - frows)
            If fr.Height >= 0 Then
                xr.Height = C1XLBook.PixelsToTwips(fr.Height)
            End If
            xr.Visible = fr.Visible
            Dim japa As Decimal = fr.Height
            '' style 
            Dim xs As XLStyle = StyleFromFlex(_book, fr.Style)
            If xs Is Nothing Then
            Else
                xr.Style = xs
            End If
        Next

        Dim c As Integer
        For c = fcols To flex.Cols.Count - 1
            ' size/visibility 
            Dim fc As Column = flex.Cols(c)
            Dim xc As XLColumn = sheet.Columns(c - fcols)
            If fc.Width >= 0 Then
                xc.Width = C1XLBook.PixelsToTwips(fc.Width)
            End If
            xc.Visible = fc.Visible

            'style
            Dim xs As XLStyle = StyleFromFlex(_book, fc.Style)
            If xs Is Nothing Then
                xc.Style = nestilo
            Else
                xc.Style = xs
            End If
        Next


        ' load cells 

        For r = frows To flex.Rows.Count - 1
            For c = fcols To flex.Cols.Count - 1
                ' get cell 
                cell = sheet(r - frows, c - fcols)

                ' apply content 
                cell.Value = flex(r, c)

                ' apply style 
                Dim xs As XLStyle = StyleFromFlex(_book, flex.GetCellStyle(r, c))
                If xs Is Nothing Then
                    If r = 0 Then
                        cell.Style = cabeza
                    End If
                Else
                    cell.Style = xs
                End If
            Next
        Next
    End Sub

    ' convert FlexGrid style into Excel style 
    Private Function StyleFromFlex(ByVal _book As C1XLBook, ByRef style As CellStyle) As XLStyle
        ' sanity 
        If style Is Nothing Then
            Return (Nothing)
        End If
        Try
            ' look it up on list 
            If _styles.Contains(style) Then
                Return _styles(style)
            End If
        Catch
        End Try

        ' create new Excel style 
        Dim xs As New XLStyle(_book)
        xs.Font = New Font("Arial", 9, FontStyle.Regular) 'style.Font()
        xs.BackColor = Color.White 'style.BackColor 'Color.White



        ' set up new style 
        If style.BackColor.ToArgb() <> SystemColors.Window.ToArgb() Then
            xs.BackColor = style.BackColor
        End If
        xs.WordWrap = style.WordWrap
        xs.Format = XLStyle.FormatDotNetToXL(style.Format)

        Select Case style.TextDirection
            Case (TextDirectionEnum.Up)
                xs.Rotation = 90
                Exit Select
            Case (TextDirectionEnum.Down)
                xs.Rotation = 180
                Exit Select
        End Select
        Select Case style.TextAlign
            Case (TextAlignEnum.CenterBottom)
                xs.AlignHorz = XLAlignHorzEnum.Center
                xs.AlignVert = XLAlignVertEnum.Bottom
                Exit Select
            Case (TextAlignEnum.CenterCenter)
                xs.AlignHorz = XLAlignHorzEnum.Center
                xs.AlignVert = XLAlignVertEnum.Center
                Exit Select
            Case (TextAlignEnum.CenterTop)
                xs.AlignHorz = XLAlignHorzEnum.Center
                xs.AlignVert = XLAlignVertEnum.Top
                Exit Select
            Case (TextAlignEnum.GeneralBottom)
                xs.AlignHorz = XLAlignHorzEnum.General
                xs.AlignVert = XLAlignVertEnum.Bottom
                Exit Select
            Case (TextAlignEnum.GeneralCenter)
                xs.AlignHorz = XLAlignHorzEnum.General
                xs.AlignVert = XLAlignVertEnum.Center
                Exit Select
            Case (TextAlignEnum.GeneralTop)
                xs.AlignHorz = XLAlignHorzEnum.General
                xs.AlignVert = XLAlignVertEnum.Top
                Exit Select
            Case (TextAlignEnum.LeftBottom)
                xs.AlignHorz = XLAlignHorzEnum.Left
                xs.AlignVert = XLAlignVertEnum.Bottom
                Exit Select
            Case (TextAlignEnum.LeftCenter)
                xs.AlignHorz = XLAlignHorzEnum.Left
                xs.AlignVert = XLAlignVertEnum.Center
                Exit Select
            Case (TextAlignEnum.LeftTop)
                xs.AlignHorz = XLAlignHorzEnum.Left
                xs.AlignVert = XLAlignVertEnum.Top
                Exit Select
            Case (TextAlignEnum.RightBottom)
                xs.AlignHorz = XLAlignHorzEnum.Right
                xs.AlignVert = XLAlignVertEnum.Bottom
                Exit Select
            Case (TextAlignEnum.RightCenter)
                xs.AlignHorz = XLAlignHorzEnum.Right
                xs.AlignVert = XLAlignVertEnum.Center
                Exit Select
            Case (TextAlignEnum.RightTop)
                xs.AlignHorz = XLAlignHorzEnum.Right
                xs.AlignVert = XLAlignVertEnum.Top
                Exit Select
            Case Else
                xs.AlignHorz = XLAlignHorzEnum.Left
                xs.AlignVert = XLAlignVertEnum.Center
                Exit Select
        End Select

        ' save it 
        _styles.Add(style, xs)


        ' return it 
        Return (xs)
    End Function

    Public Sub llena_clientes_usuario(ByRef c4 As ComboBox, ByVal usuario As String, ByVal tipo As String)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim todos As Boolean = False
        Dim strsql As String
        Dim clientes As String = "("
        revisa_acceso_usuario(usuario, dt)
        For Each dr In dt.Rows
            If dr(tipo) = "S" Then
                If dr("CLIENTE") = "TODOS" Then
                    todos = True
                Else
                    clientes = clientes & "'" & dr("CLIENTE") & "',"
                End If
            End If
        Next
        If todos Then
            strsql = "SELECT * FROM CLIENTES ORDER BY CLIENTE"
        Else
            If clientes.Length > 0 Then
                clientes = Mid(clientes, 1, clientes.Length - 1) + ")"
            End If
            strsql = "SELECT * FROM CLIENTES WHERE CLIENTE IN " & clientes & " ORDER BY CLIENTE"
        End If
        llena_combos(c4, strsql, "CLIENTE")
    End Sub
    Public Sub despliega_spec(ByVal cliente As String, ByVal estilo As String)
        Dim form As New spec
        form.Text = form.Text + "  Cliente: " + cliente + "   Estilo: " + estilo
        form.cliente = cliente
        form.estilo = estilo
        form.ShowDialog()
    End Sub
    Public Sub revisa_acceso_usuario(ByRef usuario As String, ByRef dt As DataTable)
        Dim cnn As New SqlClient.SqlConnection
        llena_tablas(dt, "SELECT * FROM USUARIO_CLIENTE WHERE USUARIO = '" & usuario & "'", cnn)
    End Sub
    Public Sub envia_corrreo_bom(ByVal cliente As String, ByVal asunto As String, ByVal mensaje As String, ByVal path As String)

        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection
        Dim strsql As String = "SELECT * FROM USUARIO_CLIENTE WHERE SEGUIMIENTO_BOM = 'S' AND (CLIENTE = '" & cliente & "' OR CLIENTE = 'TODOS') ORDER BY USUARIO"
        llena_tablas(dt, strsql, cnn)

        Try
            Dim attachFile As New Attachment(path)
            Dim SmtpServer As New System.Net.Mail.SmtpClient
            Dim mail As New System.Net.Mail.MailMessage
            Dim correo As String = ""
            SmtpServer.Credentials = New Net.NetworkCredential("ricoh@pcs.com.gt", "Djk2e39df")
            SmtpServer.Port = 25 ' == puerto smtp 587
            SmtpServer.Host = "pop.emailsrvr.com"
            'mtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("ricoh@pcs.com.gt", "Sistem as Integrados Server")
            mail.Attachments.Add(attachFile)

            For Each dr In dt.Rows
                Try
                    correo = dr("CORREO")
                    mail.To.Add(correo)
                Catch ex As Exception
                    MsgBox("Error al enviar a la dir'eccion " & correo, MsgBoxStyle.Critical, "Error en el envío del correo.")
                End Try
            Next
            mail.Subject = asunto
            mail.Body = mensaje  ' === "Cuerpo del Mensaje"
            SmtpServer.Send(mail)
        Catch ex As Exception
            MsgBox("No puede enviar el correo de Autorización", MsgBoxStyle.Critical, "Error en el envío del correo.")
        End Try
    End Sub
    Public Sub envia_corrreo_split(ByVal asunto As String, ByVal mensaje As String, ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection
        Dim strsql As String = "SELECT * FROM CORTE_SPLIT_C ORDER BY CORREO"
        llena_tablas(dt, strsql, cnn)
        ok = False
        Try
            Dim SmtpServer As New System.Net.Mail.SmtpClient
            Dim mail As New System.Net.Mail.MailMessage
            Dim correo As String = ""
            SmtpServer.Credentials = New Net.NetworkCredential("ricoh@pcs.com.gt", "Djk2e39df")
            SmtpServer.Port = 25 ' == puerto smtp 587
            SmtpServer.Host = "pop.emailsrvr.com"
            'mtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("ricoh@pcs.com.gt", "Sistemas Integrados Server")
            'mail.Attachments.Add(attachFile)

            For Each dr In dt.Rows
                Try
                    correo = dr("CORREO")
                    mail.To.Add(correo)
                Catch ex As Exception
                    MsgBox("Error al enviar a la direccion " & correo, MsgBoxStyle.Critical, "Error en el envío del correo.")
                End Try
            Next
            mail.Subject = asunto
            mail.Body = mensaje  ' === "Cuerpo del Mensaje"
            SmtpServer.Send(mail)
            ok = True
        Catch ex As Exception
            MsgBox("No puede enviar el correo de Autorización", MsgBoxStyle.Critical, "Error en el envío del correo.")
        End Try
    End Sub
    Public Sub envia_corrreo_estilo(ByVal asunto As String, ByVal mensaje As String, ByRef ok As Boolean)
        Dim dt As New DataTable
        Dim cnn As New SqlClient.SqlConnection
        Dim strsql As String = "SELECT * FROM CORTE_SPLIT_C ORDER BY CORREO"
        llena_tablas(dt, strsql, cnn)
        ok = False
        Try
            Dim SmtpServer As New System.Net.Mail.SmtpClient
            Dim mail As New System.Net.Mail.MailMessage
            Dim correo As String = ""
            SmtpServer.Credentials = New Net.NetworkCredential("ricoh@pcs.com.gt", "Djk2e39df")
            SmtpServer.Port = 25 ' == puerto smtp 587
            SmtpServer.Host = "pop.emailsrvr.com"
            'mtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("ricoh@pcs.com.gt", "Sistemas Integrados Server")
            'mail.Attachments.Add(attachFile)
            mail.To.Add("amata@pcs.com.gt")
            mail.To.Add("rbarillas@pcs.com.gt")
            mail.Subject = asunto
        mail.Body = mensaje  ' === "Cuerpo del Mensaje"
        SmtpServer.Send(mail)
        ok = True
        Catch ex As Exception
            MsgBox("No puede enviar el correo de Autorización", MsgBoxStyle.Critical, "Error en el envío del correo.")
        End Try
    End Sub

    Public Sub busca_descripciones(ByVal cu As DataTable, ByVal codigo As String, ByRef descripcion As String, ByRef ok As Boolean)
        Dim dw As DataRow()
        Dim dr As DataRow
        descripcion = ""
        ok = False
        Try
            dw = cu.Select("CODIGO = '" & codigo & "'")
            If dw.Length > 0 Then
                dr = dw(0)
                descripcion = dr("DESCRIPCION")
                ok = True
            End If
        Catch
        End Try
    End Sub
    Public Sub busca_descripciones1(ByVal cu As DataTable, ByVal llave As String, ByVal campo As String, ByVal codigo As String, ByRef descripcion As String)
        Dim dw As DataRow()
        Dim dr As DataRow
        Try
            dw = cu.Select(llave & " = '" & codigo & "'")
            If dw.Length > 0 Then
                dr = dw(0)
                descripcion = dr(campo)
            End If
        Catch
            descripcion = ""
        End Try
    End Sub

    Public Sub llena_tipos_Telas(ByRef cu As DataTable, ByRef codigo As ComboBox)
        Dim dr As DataRow
        codigo.Items.Clear()
        For Each dr In cu.Rows
            codigo.Items.Add(dr("CODIGO"))
        Next
        If cu.Rows.Count > 0 Then
            codigo.SelectedIndex = 0
        End If
    End Sub
#End Region

    Public Sub conexiones(ByRef con() As String)
        Dim cs As New Lib_SI.util
        Dim emp As String = "|inventarios|TRECENTO|zuntex"
        Dim em() As String = Split(emp, "|")
        Dim i As Integer
        ReDim con(em.Length)
        For i = 1 To 3
            con(i) = cs.con_string(i - 1)
        Next
    End Sub


    Public Sub calcula_fecha_corte(ByVal ec As DataTable, ByVal estilo As String, ByVal fcostura As Date, ByRef fcorte As Date)
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim d As Integer
        Dim dias As Integer = 15
        dd = ec.Select("ESTILO = '" & estilo & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            dias = dr("DIAS_CORTE")
        End If
        Try
            fcorte = fcostura.AddDays(-dias)
            d = fcorte.DayOfWeek
            If d = 0 Then
                fcorte = fcorte.AddDays(-2)
            ElseIf d = 6 Then
                fcorte = fcorte.AddDays(-2)
            End If
        Catch
            fcostura = Today
            fcorte = fcostura.AddDays(-dias)
        End Try

    End Sub


    Public Sub determina_columna_tela(ByVal fei As Date, ByVal fecha As Date, ByVal coli As Integer, ByVal colmax As Integer, ByRef col As Integer)
        Dim d As Integer
        Dim res As Decimal
        d = DateDiff(DateInterval.Day, fei, fecha)
        res = (d / 7)
        If d > 0 Then
            d = Fix(d / 7)
            res = res - d
            If res > 0 Then
                d = d + 1
            End If
        Else
            d = 0
        End If
        col = coli + d
        If col < coli Then
            col = coli
        End If
        If col > colmax Then
            col = colmax
        End If
    End Sub


    Public Sub ajusta_fecha_produccion(ByRef va As DataTable, ByVal sec As String, ByVal fechai As Date, ByVal dias As Decimal, ByRef fechaf As Date)
        Dim d As Integer = 0
        Dim dd As DataRow()
        Dim fecha As New Date

        Dim h As String = "yyyy-MM-dd"
        Dim fei As Date
        Dim fef As Date
        Dim ok As Boolean
        Dim sabdom As String = "06"
        Dim diasem As Integer

        fechaf = fechai.AddDays(dias)
        fei = Format(fechai, h)
        fef = Format(fechaf, h)
     
        ' ======================== VERIFICA ASUETOS-VACACIONES ==================
        ok = True
        Try
            Do While ok
                dd = va.Select("TIPO = 'D' AND FECHA = '" & Format(fechaf, "yyyy-MM-dd") & "' AND SECCION = '" & sec & "'")
                If dd.Length > 0 Then
                    fechaf = fechaf.AddDays(1)
                Else
                    ok = False
                    ' ====================== VERIFICA FIN DE SEMANA =========================
                    diasem = fechaf.DayOfWeek
                    If sabdom.IndexOf(diasem) > -1 Then
                        dd = va.Select("TIPO = 'F' AND SECCION = '" & sec & "' AND FECHA = '" & Format(fechaf, "yyyy-MM-dd") & "'")
                        If dd.Length = 0 Then
                            fechaf = fechaf.AddDays(1)
                            ok = True
                        End If
                    End If
                End If
            Loop
        Catch
        End Try

    End Sub
    Public Sub crea_sub_inventario(ByRef ruta As String)
        Dim obj As New empresas
        ruta = "c:\telas\inventarios"
        Try
            If Not Directory.Exists(ruta) Then
                Directory.CreateDirectory(ruta)
            End If
        Catch ex As Exception
        End Try
        ruta = ruta + "\" + obj.nombre
        Try
            If Not Directory.Exists(ruta) Then
                Directory.CreateDirectory(ruta)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function semana_fecha(ByVal ano As Integer, ByRef semana As Integer, ByRef fecha As Date)
        Dim inicio As Date = CDate(Format(ano, "0000") + "-01-01")
        Dim dia As Integer = inicio.DayOfWeek
        If semana = 0 Then
            semana = 99
            fecha = CDate("9999-12-31")
        Else
            dia = 7 - dia
            inicio = inicio.AddDays(dia)
            dia = (semana - 1) * 7
            fecha = inicio.AddDays(dia)
        End If
        Return fecha
    End Function

    Public Sub llena_combos_d(ByVal combo As System.Windows.Forms.ComboBox, ByVal strsql As String, ByRef dt As DataTable, ByVal dm As String, ByVal vm As String)
        'Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        llena_tablas(dt, strsql, cnn)
        Try
            combo.DataSource = dt
            combo.DisplayMember = dm
            combo.ValueMember = vm
        Catch ex As Exception
        End Try
        If combo.Items.Count > 0 Then
            combo.SelectedIndex = 0
        End If
    End Sub

    Public Function d_estado(ByVal dt As DataTable, ByVal des As String) As String
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim res As String
        dd = dt.Select("ESTADO_TELA = '" & des & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            res = dr("CODIGO")
        Else
            res = ""
        End If
        Return res
    End Function

    Public Sub busca_registro(ByRef dt As DataTable, ByVal campob As String, ByVal busca As String, ByVal campo As String, ByRef resultado As String)
        Dim dd As DataRow()
        Dim dr As DataRow
        resultado = ""
        dd = dt.Select(campob & " = '" & busca & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            resultado = dr(campo)
        End If
    End Sub

    Public Function embelishment(ByVal dd As DataRow()) As String
        Dim dr As DataRow
        Dim res As String = "N/A"

        If dd.Length > 0 Then
            dr = dd(0)
            If dr("O2") Then
                res = "BORDADO"
            Else
                If dr("O3") Then
                    res = "SERIGRAFIA"
                End If
            End If
            If dr("O2") And dr("O3") Then
                res = "BORDADO/SERIGRA"
            End If
            If dr("O5") Then
                res = "SUBLIMACION/TEÑIDO"
            End If
        End If
        Return res
    End Function

    Public Function fpo_ofecha(ByVal cliente) As Date
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim fecha As Date = Nothing
        Dim cnna As New SqlClient.SqlConnection
        Dim strsql As String = "SELECT TOP 1 FECHA FROM FPO_OFECHA ORDER BY FECHA DESC"
        llena_tablas(dt, strsql, cnna)
        For Each dr In dt.Rows
            fecha = dr("fecha")
        Next
        Return fecha
    End Function

    Public Function descarga_lector(ByVal c As Integer) As DataTable
        Dim cnn As New SqlClient.SqlConnection
        Dim dt As New DataTable
        Dim tipo(3) As String
        tipo(0) = "CODIGO"
        tipo(1) = "ROLLOS_UBICA"
        tipo(2) = "DESP_T2"
        cnn.ConnectionString = lector_dc()
        llena_tablas_e(dt, "SELECT * FROM " & tipo(c), cnn)
        Return dt
    End Function

    Public Function get_seccion(ByVal corte As String) As String
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim seccion As String = ""
        Dim cnn As New SqlClient.SqlConnection
        Dim strsql As String = "SELECT SECCION FROM CORTES WHERE CORTE =  '" & corte & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            seccion = dr("SECCION")
        End If
        Return seccion
    End Function

    Public Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Public Function Obtiene_IP() As String
        Dim ip As System.Net.IPHostEntry
        Dim i As Integer
        Dim dir As String = ""
        ip = Dns.GetHostEntry(My.Computer.Name)
        For i = 1 To ip.AddressList.Length
            dir = ip.AddressList(1).ToString
            If dir.StartsWith("192.9.200.") Then
                Exit For
            End If
        Next
        Return dir
    End Function

    Public Function select_distinct(ByVal dt As DataTable, ByVal campo As String) As DataTable
        Dim vista As New DataView
        Dim distintos As New DataTable
        vista = New DataView(dt)
        distintos = vista.ToTable(True, campo)
        Return distintos
    End Function
    Public Function GetIpV4() As String
        Dim myHost As String = Dns.GetHostName
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(myHost)
        Dim ip As String = ""

        For Each tmpIpAddress As IPAddress In ipEntry.AddressList
            If tmpIpAddress.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Dim ipAddress As String = tmpIpAddress.ToString
                ip = ipAddress
                Exit For
            End If
        Next

        If ip = "" Then
            Throw New Exception("No 10. IP found!")
        End If

        Return ip
    End Function

    Public Function puedo_imprimir() As Boolean
        Dim cnn1 As New SqlClient.SqlConnection
        Dim ok As Boolean = False
        Dim dt As New DataTable
        cnn1.ConnectionString = lector_dc()
        llena_tablas_e(dt, "SELECT * FROM ETI_IMP WHERE IMPRIMO = 'S'", cnn1)
        If dt.Rows.Count > 0 Then
            ok = True
        End If
        Return ok
    End Function
    Public Sub busca_dm(ByVal cliente As String, ByRef dm As DataTable, ByRef dms As String)
        Dim cnn As New SqlClient.SqlConnection
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT DISTINCT DM_CLIENTE.DM, DM.CODIGO, DESCRIPCION FROM DM_CLIENTE LEFT JOIN DM ON DM_CLIENTE.DM = DM.DM LEFT JOIN CODIGO_TELA ON DM.CODIGO = CODIGO_TELA.CODIGO WHERE DM_CLIENTE.CLIENTE = '" & cliente & "'"
        dms = ""
        llena_tablas(dm, strSQL, cnn)
        For Each dr In dm.Rows
            dms = dms + dr("DM") + "|"
        Next
    End Sub
    Public Function puedo_planificar() As Boolean
        Dim ok As Boolean = False
        Dim strsql As String = "SELECT * FROM PLANIF_SI"
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count = 0 Then
            ok = True
        Else
            dr = dt.Rows(0)
            MsgBox("No puede Planificar, el usuario " & dr("USUARIO") & " se encuentra planificando. ", MsgBoxStyle.Critical, "Otro usuario Planificando")
        End If
        Return ok
    End Function
    Public Sub planificando(ByVal tipo As String)
        Dim cnn As New SqlClient.SqlConnection
        Dim strsql As String
        Dim afectados As Integer
        Dim obj As New empresas
        Dim usuario As String = obj.usuario
        cnn.ConnectionString = obj.constr
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            If tipo = "G" Then
                strsql = "INSERT INTO PLANIF_SI (USUARIO) " &
                            "VALUES ( '" & usuario & "')"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                strsql = "INSERT INTO PLANIF_SI_V (FECHA,USUARIO) " &
                           "VALUES ( GETDATE(),'" & usuario & "')"

                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Else
                strsql = "DELETE PLANIF_SI "
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Error al momento de grabar. " + e.Message, MsgBoxStyle.Critical, "Por favor revise.")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                     " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try

    End Sub
End Module
