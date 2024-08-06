Module cajas_01
    Dim obj As New empresas
    Dim cnn As New SqlClient.SqlConnection

    Public Function imprime_cajas(ByRef inicial As String, ByVal final As String) As Boolean
        Dim ok As Boolean = True
        Dim ipAddress As String = "192.9.200.28"
        Dim port As Integer = 9100
        Dim dt As New DataTable
        Dim ze As New DataTable
        Dim dr As DataRow
        Dim fj As DataRow
        Dim dd As DataRow()
        Dim logo As String = ""
        Dim caja As String
        Dim ZPLString As String
        Dim l As Integer
        Dim ti As String = ""
        Dim enca As String
        Dim cliente As String = ""
        Dim cpo As String
        Dim estilo As String
        Dim colo As String
        Dim primero As Boolean = False
        '       Try
        Dim client As New System.Net.Sockets.TcpClient()
        client.Connect(ipAddress, port)

        ' Write ZPL String to connection
        Dim writer As New System.IO.StreamWriter(client.GetStream())

        If obj.numero = "1" Then
            logo = "^FO0,0^GFA,1221,1221,11,,::M07F,L01FF8,L03FFE,L07FFE,L07IF,L0JF,L0JF8,:::L0JF,L07IF,L07FFE,L03FFE,L01FF8,M07F,,::K01SFC,::::::::::::::::Q01JF8,:Q01JF8CFC,:Q01JF8IC,K01JF81JF8C0C,:K01JF81JF8E1C,K01JF81JF87F8,K01JF81JF83F,K01JF81JF8,:K01JF81JF8FFC,K01JF007IF8FFC,K01IF8001IF803C,K01IFJ0IF80F,K01FFCJ03FF83C,K01FF803801FF87,K01FF80FE01FF8FFC,K01FF01CF00FF8FFC,K01FE01C7007F8,K01FE0387007F8,K01FE01C7007F8FFC,K01FC01CE003F8FFC,K01FC01FC003F8528,K01FC00F8303F8,K01FC03F8703F81E,K01FC07BC703F87F,K01FC071C703F87F8,K01FC0F0EE03F8E1C,K01FC0F0FE03F8C0C,K01FE0F07C07F8C0C,K01FE0787C07F8C0C,K01FF07FFE0FF8FFC,K01FF03FEF0FF8FFC,K01FF807001FF8,K01FFCJ03FF8,K01FFEJ07FF800C,K01IFJ0IF807C,K01IFC003IF83F8,K01JF81JF8FA,K01JF81JF8C2,K01JF81JF8FE,K03JF81JF83FC,K03JF81JF803C,K07JF81JF8004,K0KF01JF8,J03KF01JF8,I03LF01JF871C,007MF01JF8FFC,007LFE01JF8CF,007LFE01JF8CC,:007LFC01JF8FFC,:007LF801JF8,007LF001JF8,007LF001JF8C,007KFE001JF8C,007KFC001JF8C,007KF8001JF8FFC,007JFEI01JF8FFC,007JFCI01JF8C,007JFJ01JF8C,007IF8J01JF84,007FF8K01JF8,,:::::^FS"
        ElseIf obj.numero = "3" Then
            logo = "^FO10,10^GFA,2400,2400,24,,:::::R07FFC,Q01JF,P03KF,I0FFEJ07KF,007IFE001IFE,00KFC03FFE,03PFE,03QF,K07NF,K01NFC,K01OF,K03OF,J01LFE03F8,J0MFE001C,I03NF8,I07NFC,001LF3IF,003LF1IF,00FFDJF8IFC,00FF8JF8F3FE0FFC,03FE1JF8F8FF0IFC,03FC1JF8787F0IFEI03F,07FC3FCFF83C1F800FFC1JF,0F887FCFF83C0FC00FFE3JF,0F007F8FF00E0FC03LF7F,1E00FF0FF00F03E0LFC,1C00FF0FF00F01E1LF8,1001FE0FF00F00F3LFC,I03FC0FF007807003KFC,I03F00FE003CJ03KFE,I03E00FE003CJ07LF8,I03C00FE003EJ0MFC,I07C00FE001FI03FFDIF7F,I0F800FEI0FI03F71IF3F,I0F800FEI0FI07CF1IF1FC,I0F8007CI0FI0F8F1FDF0FC,I0FI07CI07800F0E1F8FC1E,I0EI07CI03C01E0C1F8FC0E,I0CI07EI03C01C3C1F87C,001CI07EI03C0083C0F83E,0018I03EI03EI0700F81E,001J03EI01FI0700FC0F,M03EI01FI0F00FC0F,M03EJ0FI0F00F807,M03CJ0F001E0078038,M01EJ0F003C007803C,M01EJ0F803C007003C,N0EJ0F803C00F001C,S07C03800F,S07C07800F,S07C0FI0F,:S07C0FI0E,S03E0E,S03E1E,S03E3C,::::S03F7C,S03FFC,S03FF8L0IFCN01IF,S03FF8K01IFCN03IF,S03FF8K03IF8N07FFE,S03FFL03IFO03FFC,S03FFL0107CP07F,S07FFN07C008M03EI0C,S07FFN0F003CI0CI07C007E3C0F,S07FFM01F007C001CI0FC00FF3C0F,S07FFM07C00FC303C301F803FF3F3E,S07FFM0FC01F8387C781F007FE1FFC,S07FFL01F003F0F0FCF83F00F3C1FF,S0IFL03F003F1F0IF07F00F3C0FF,S0IFL0FC007C3F3IF0FE03E380FC,S0IFK01FC00FC7E3IF0FC03C700FC,S0IFK03F030IFC3IF0FC07CE01FC,S0IFK07F070IFC7FFE1F80FCE03FC,S0IFJ01JF1IFCFC7C3F00FFE1FFE,S0IFJ03IFE3FCFCFC7C3F00FFE3IF,Q030IFJ03IFC3F0FCF87C7E00FFC7IF,Q030IFJ03IF83F0F8F07CFC00FF87C7F,Q021IFK0FF0030070C0307I0780703C,Q023IFR02U08,Q027IFE8,Q07KFC,Q0LFE,Q0MF,P01MF8,P01FDE3DFF,,:::^FS"
        End If
        llena_tablas(ze, "SELECT DISTINCT CAJA FROM CAJAS01 WHERE CAJA BETWEEN '" & inicial & "' AND '" & final & "' ORDER BY CAJA", cnn)
        llena_tablas(dt, "SELECT * FROM CAJAS01 LEFT JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE WHERE CAJA BETWEEN '" & inicial & "' AND '" & final & "' ORDER BY CAJA", cnn)

        enca = "^XA" + logo + "^FO20,120^A0,30,20^FDCORTE^FS" + "^FO100,120^A0,30,20^FDCPO^FS" + "^FO250,120^A0,30,20^FDESTILO^FS" + "^FO420,120^A0,30,20^FDCOLOR^FS" + "^FO610,120^A0,30,20^FDTALLA^FS" + "^FO690,120^A0,30,20^FDUNIDAD.^FS" + "^FO770,120^A0,30,20^FDT^FS" + "^FO15,110^GB790,40,3^FS"

        For Each dr In ze.Rows
            caja = dr("CAJA")
            ZPLString = enca
            dd = dt.Select("CAJA = '" & caja & "'")
            l = 160
            ti = ""
            primero = True
            For Each fj In dd
                cliente = fj("CLIENTE")
                If fj("UNIDADES") > 0 Then
                    cpo = recorta(fj("CPO"), 20)
                    estilo = recorta(fj("ESTILO"), 16)
                    colo = recorta(fj("COLOR"), 15)
                    If primero Then
                        ti = ti + "^FO20," + CStr(l) + "^A0,50,50^FD" + fj("CORTE") + "^FS"
                        l = l + 50
                        primero = False
                    End If

                    ti = ti + "^FO100," + CStr(l) + "^A0,30,20^FD" + cpo + "^FS"
                    ti = ti + "^FO250," + CStr(l) + "^A0,30,20^FD" + estilo + "^FS"
                    ti = ti + "^FO420," + CStr(l) + "^A0,30,20^FD" + colo + "^FS"
                    ti = ti + "^FO620," + CStr(l) + "^A0,30,20^FD" + fj("TALLA") + "^FS"
                    ti = ti + "^FO700," + CStr(l) + "^A0,30,20^FD" + Format(fj("UNIDADES"), "######") + "^FS"
                    ti = ti + "^FO770," + CStr(l) + "^A0,30,20^FD" + fj("TIPO") + "^FS"
                    l = l + 30
                End If
            Next
            ZPLString = ZPLString + ti + "^FO650,85^A0,30,20^FD" + cliente + "^FS" + "^FX" + "^BY5,2,120" + "^FO75,410^BC^FD" + caja & "^FS" + "^XZ"
            writer.Write(ZPLString)
            writer.Flush()

        Next

        writer.Close()
        client.Close()
        ' Catch
        '    ok = False
        ' End Try
        Return ok
    End Function
    Public Function imprime_cajas_l(ByRef inicial As String) As Boolean
        Dim ok As Boolean = True
        Dim ipAddress As String = "192.9.200.28"
        Dim port As Integer = 9100
        Dim dt As New DataTable
        Dim ze As New DataTable
        Dim dr As DataRow
        Dim fj As DataRow
        Dim dd As DataRow()
        Dim logo As String = ""
        Dim caja As String
        Dim ZPLString As String
        Dim l As Integer
        Dim ti As String = ""
        Dim enca As String
        Dim cliente As String = ""
        Dim cpo As String
        Dim estilo As String
        Dim colo As String
        Dim primero As Boolean = False
        '       Try
        Dim client As New System.Net.Sockets.TcpClient()
        client.Connect(ipAddress, port)

        ' Write ZPL String to connection
        Dim writer As New System.IO.StreamWriter(client.GetStream())

        If obj.numero = "1" Then
            logo = "^FO0,0^GFA,1221,1221,11,,::M07F,L01FF8,L03FFE,L07FFE,L07IF,L0JF,L0JF8,:::L0JF,L07IF,L07FFE,L03FFE,L01FF8,M07F,,::K01SFC,::::::::::::::::Q01JF8,:Q01JF8CFC,:Q01JF8IC,K01JF81JF8C0C,:K01JF81JF8E1C,K01JF81JF87F8,K01JF81JF83F,K01JF81JF8,:K01JF81JF8FFC,K01JF007IF8FFC,K01IF8001IF803C,K01IFJ0IF80F,K01FFCJ03FF83C,K01FF803801FF87,K01FF80FE01FF8FFC,K01FF01CF00FF8FFC,K01FE01C7007F8,K01FE0387007F8,K01FE01C7007F8FFC,K01FC01CE003F8FFC,K01FC01FC003F8528,K01FC00F8303F8,K01FC03F8703F81E,K01FC07BC703F87F,K01FC071C703F87F8,K01FC0F0EE03F8E1C,K01FC0F0FE03F8C0C,K01FE0F07C07F8C0C,K01FE0787C07F8C0C,K01FF07FFE0FF8FFC,K01FF03FEF0FF8FFC,K01FF807001FF8,K01FFCJ03FF8,K01FFEJ07FF800C,K01IFJ0IF807C,K01IFC003IF83F8,K01JF81JF8FA,K01JF81JF8C2,K01JF81JF8FE,K03JF81JF83FC,K03JF81JF803C,K07JF81JF8004,K0KF01JF8,J03KF01JF8,I03LF01JF871C,007MF01JF8FFC,007LFE01JF8CF,007LFE01JF8CC,:007LFC01JF8FFC,:007LF801JF8,007LF001JF8,007LF001JF8C,007KFE001JF8C,007KFC001JF8C,007KF8001JF8FFC,007JFEI01JF8FFC,007JFCI01JF8C,007JFJ01JF8C,007IF8J01JF84,007FF8K01JF8,,:::::^FS"
        ElseIf obj.numero = "3" Then
            logo = "^FO10,10^GFA,2400,2400,24,,:::::R07FFC,Q01JF,P03KF,I0FFEJ07KF,007IFE001IFE,00KFC03FFE,03PFE,03QF,K07NF,K01NFC,K01OF,K03OF,J01LFE03F8,J0MFE001C,I03NF8,I07NFC,001LF3IF,003LF1IF,00FFDJF8IFC,00FF8JF8F3FE0FFC,03FE1JF8F8FF0IFC,03FC1JF8787F0IFEI03F,07FC3FCFF83C1F800FFC1JF,0F887FCFF83C0FC00FFE3JF,0F007F8FF00E0FC03LF7F,1E00FF0FF00F03E0LFC,1C00FF0FF00F01E1LF8,1001FE0FF00F00F3LFC,I03FC0FF007807003KFC,I03F00FE003CJ03KFE,I03E00FE003CJ07LF8,I03C00FE003EJ0MFC,I07C00FE001FI03FFDIF7F,I0F800FEI0FI03F71IF3F,I0F800FEI0FI07CF1IF1FC,I0F8007CI0FI0F8F1FDF0FC,I0FI07CI07800F0E1F8FC1E,I0EI07CI03C01E0C1F8FC0E,I0CI07EI03C01C3C1F87C,001CI07EI03C0083C0F83E,0018I03EI03EI0700F81E,001J03EI01FI0700FC0F,M03EI01FI0F00FC0F,M03EJ0FI0F00F807,M03CJ0F001E0078038,M01EJ0F003C007803C,M01EJ0F803C007003C,N0EJ0F803C00F001C,S07C03800F,S07C07800F,S07C0FI0F,:S07C0FI0E,S03E0E,S03E1E,S03E3C,::::S03F7C,S03FFC,S03FF8L0IFCN01IF,S03FF8K01IFCN03IF,S03FF8K03IF8N07FFE,S03FFL03IFO03FFC,S03FFL0107CP07F,S07FFN07C008M03EI0C,S07FFN0F003CI0CI07C007E3C0F,S07FFM01F007C001CI0FC00FF3C0F,S07FFM07C00FC303C301F803FF3F3E,S07FFM0FC01F8387C781F007FE1FFC,S07FFL01F003F0F0FCF83F00F3C1FF,S0IFL03F003F1F0IF07F00F3C0FF,S0IFL0FC007C3F3IF0FE03E380FC,S0IFK01FC00FC7E3IF0FC03C700FC,S0IFK03F030IFC3IF0FC07CE01FC,S0IFK07F070IFC7FFE1F80FCE03FC,S0IFJ01JF1IFCFC7C3F00FFE1FFE,S0IFJ03IFE3FCFCFC7C3F00FFE3IF,Q030IFJ03IFC3F0FCF87C7E00FFC7IF,Q030IFJ03IF83F0F8F07CFC00FF87C7F,Q021IFK0FF0030070C0307I0780703C,Q023IFR02U08,Q027IFE8,Q07KFC,Q0LFE,Q0MF,P01MF8,P01FDE3DFF,,:::^FS"
        End If
        llena_tablas(ze, "SELECT DISTINCT CAJA FROM CAJAG01 WHERE CAJA = '" & inicial & "' ORDER BY CAJA", cnn)
        llena_tablas(dt, "SELECT * FROM CAJAG01 LEFT JOIN CORTES ON CAJAG01.CORTE = CORTES.CORTE WHERE CAJA = '" & inicial & "' ORDER BY CAJA", cnn)

        enca = "^XA" + logo + "^FO20,120^A0,30,20^FDCORTE^FS" + "^FO100,120^A0,30,20^FDCPO^FS" + "^FO250,120^A0,30,20^FDESTILO^FS" + "^FO420,120^A0,30,20^FDCOLOR^FS" + "^FO610,120^A0,30,20^FDTALLA^FS" + "^FO690,120^A0,30,20^FDUNIDAD.^FS" + "^FO770,120^A0,30,20^FDT^FS" + "^FO15,110^GB790,40,3^FS"

        For Each dr In ze.Rows
            caja = dr("CAJA")
            ZPLString = enca
            dd = dt.Select("CAJA = '" & caja & "'")
            l = 160
            ti = ""
            primero = True
            For Each fj In dd
                cliente = fj("CLIENTE")
                If fj("UNIDADES") > 0 Then
                    cpo = recorta(fj("CPO"), 20)
                    estilo = recorta(fj("ESTILO"), 16)
                    colo = recorta(fj("COLOR"), 15)
                    If primero Then
                        ti = ti + "^FO20," + CStr(l) + "^A0,50,50^FD" + fj("CORTE") + "^FS"
                        l = l + 50
                        primero = False
                    End If

                    ti = ti + "^FO100," + CStr(l) + "^A0,30,20^FD" + cpo + "^FS"
                    ti = ti + "^FO250," + CStr(l) + "^A0,30,20^FD" + estilo + "^FS"
                    ti = ti + "^FO420," + CStr(l) + "^A0,30,20^FD" + colo + "^FS"
                    ti = ti + "^FO620," + CStr(l) + "^A0,30,20^FD" + fj("TALLA") + "^FS"
                    ti = ti + "^FO700," + CStr(l) + "^A0,30,20^FD" + Format(fj("UNIDADES"), "######") + "^FS"
                    ti = ti + "^FO770," + CStr(l) + "^A0,30,20^FD" + fj("TIPO") + "^FS"
                    l = l + 30
                End If
            Next
            ZPLString = ZPLString + ti + "^FO650,85^A0,30,20^FD" + cliente + "^FS" + "^FX" + "^BY5,2,120" + "^FO75,410^BC^FD" + caja & "^FS" + "^XZ"
            writer.Write(ZPLString)
            writer.Flush()

        Next

        writer.Close()
        client.Close()
        ' Catch
        '    ok = False
        ' End Try
        Return ok
    End Function

    Public Function imprime_cajas_t(ByRef inicial As String, ByVal final As String) As Boolean
        Dim ok As Boolean = True
        Dim ipAddress As String = "192.9.200.28"
        Dim port As Integer = 9100
        Dim dt As New DataTable
        Dim ze As New DataTable
        Dim dr As DataRow
        Dim fj As DataRow
        Dim dd As DataRow()
        Dim logo As String = ""
        Dim caja As String
        Dim ZPLString As String
        Dim l As Integer
        Dim ti As String = ""
        Dim enca As String
        Dim cliente As String = ""
        Dim cpo As String
        Dim estilo As String
        Dim colo As String
        '       Try
        Dim client As New System.Net.Sockets.TcpClient()
        client.Connect(ipAddress, port)

        ' Write ZPL String to connection
        Dim writer As New System.IO.StreamWriter(client.GetStream())

        If obj.numero = "1" Then
            logo = "^FO0,0^GFA,1221,1221,11,,::M07F,L01FF8,L03FFE,L07FFE,L07IF,L0JF,L0JF8,:::L0JF,L07IF,L07FFE,L03FFE,L01FF8,M07F,,::K01SFC,::::::::::::::::Q01JF8,:Q01JF8CFC,:Q01JF8IC,K01JF81JF8C0C,:K01JF81JF8E1C,K01JF81JF87F8,K01JF81JF83F,K01JF81JF8,:K01JF81JF8FFC,K01JF007IF8FFC,K01IF8001IF803C,K01IFJ0IF80F,K01FFCJ03FF83C,K01FF803801FF87,K01FF80FE01FF8FFC,K01FF01CF00FF8FFC,K01FE01C7007F8,K01FE0387007F8,K01FE01C7007F8FFC,K01FC01CE003F8FFC,K01FC01FC003F8528,K01FC00F8303F8,K01FC03F8703F81E,K01FC07BC703F87F,K01FC071C703F87F8,K01FC0F0EE03F8E1C,K01FC0F0FE03F8C0C,K01FE0F07C07F8C0C,K01FE0787C07F8C0C,K01FF07FFE0FF8FFC,K01FF03FEF0FF8FFC,K01FF807001FF8,K01FFCJ03FF8,K01FFEJ07FF800C,K01IFJ0IF807C,K01IFC003IF83F8,K01JF81JF8FA,K01JF81JF8C2,K01JF81JF8FE,K03JF81JF83FC,K03JF81JF803C,K07JF81JF8004,K0KF01JF8,J03KF01JF8,I03LF01JF871C,007MF01JF8FFC,007LFE01JF8CF,007LFE01JF8CC,:007LFC01JF8FFC,:007LF801JF8,007LF001JF8,007LF001JF8C,007KFE001JF8C,007KFC001JF8C,007KF8001JF8FFC,007JFEI01JF8FFC,007JFCI01JF8C,007JFJ01JF8C,007IF8J01JF84,007FF8K01JF8,,:::::^FS"
        ElseIf obj.numero = "3" Then
            logo = "^FO10,10^GFA,2400,2400,24,,:::::R07FFC,Q01JF,P03KF,I0FFEJ07KF,007IFE001IFE,00KFC03FFE,03PFE,03QF,K07NF,K01NFC,K01OF,K03OF,J01LFE03F8,J0MFE001C,I03NF8,I07NFC,001LF3IF,003LF1IF,00FFDJF8IFC,00FF8JF8F3FE0FFC,03FE1JF8F8FF0IFC,03FC1JF8787F0IFEI03F,07FC3FCFF83C1F800FFC1JF,0F887FCFF83C0FC00FFE3JF,0F007F8FF00E0FC03LF7F,1E00FF0FF00F03E0LFC,1C00FF0FF00F01E1LF8,1001FE0FF00F00F3LFC,I03FC0FF007807003KFC,I03F00FE003CJ03KFE,I03E00FE003CJ07LF8,I03C00FE003EJ0MFC,I07C00FE001FI03FFDIF7F,I0F800FEI0FI03F71IF3F,I0F800FEI0FI07CF1IF1FC,I0F8007CI0FI0F8F1FDF0FC,I0FI07CI07800F0E1F8FC1E,I0EI07CI03C01E0C1F8FC0E,I0CI07EI03C01C3C1F87C,001CI07EI03C0083C0F83E,0018I03EI03EI0700F81E,001J03EI01FI0700FC0F,M03EI01FI0F00FC0F,M03EJ0FI0F00F807,M03CJ0F001E0078038,M01EJ0F003C007803C,M01EJ0F803C007003C,N0EJ0F803C00F001C,S07C03800F,S07C07800F,S07C0FI0F,:S07C0FI0E,S03E0E,S03E1E,S03E3C,::::S03F7C,S03FFC,S03FF8L0IFCN01IF,S03FF8K01IFCN03IF,S03FF8K03IF8N07FFE,S03FFL03IFO03FFC,S03FFL0107CP07F,S07FFN07C008M03EI0C,S07FFN0F003CI0CI07C007E3C0F,S07FFM01F007C001CI0FC00FF3C0F,S07FFM07C00FC303C301F803FF3F3E,S07FFM0FC01F8387C781F007FE1FFC,S07FFL01F003F0F0FCF83F00F3C1FF,S0IFL03F003F1F0IF07F00F3C0FF,S0IFL0FC007C3F3IF0FE03E380FC,S0IFK01FC00FC7E3IF0FC03C700FC,S0IFK03F030IFC3IF0FC07CE01FC,S0IFK07F070IFC7FFE1F80FCE03FC,S0IFJ01JF1IFCFC7C3F00FFE1FFE,S0IFJ03IFE3FCFCFC7C3F00FFE3IF,Q030IFJ03IFC3F0FCF87C7E00FFC7IF,Q030IFJ03IF83F0F8F07CFC00FF87C7F,Q021IFK0FF0030070C0307I0780703C,Q023IFR02U08,Q027IFE8,Q07KFC,Q0LFE,Q0MF,P01MF8,P01FDE3DFF,,:::^FS"
        End If
        llena_tablas(ze, "SELECT DISTINCT CAJA FROM PROD_TER01 WHERE CAJA BETWEEN '" & inicial & "' AND '" & final & "' AND UNIDADES > 0 ORDER BY CAJA", cnn)
        llena_tablas(dt, "SELECT * FROM PROD_TER01 LEFT JOIN CORTES ON PROD_TER01.CORTE = CORTES.CORTE WHERE CAJA BETWEEN '" & inicial & "' AND '" & final & "' AND UNIDADES > 0 ORDER BY CAJA", cnn)

        enca = "^XA" + logo + "^FO20,120^A0,30,20^FDCORTE^FS" + "^FO100,120^A0,30,20^FDCPO^FS" + "^FO250,120^A0,30,20^FDESTILO^FS" + "^FO420,120^A0,30,20^FDCOLOR^FS" + "^FO610,120^A0,30,20^FDTALLA^FS" + "^FO690,120^A0,30,20^FDUNIDAD.^FS" + "^FO770,120^A0,30,20^FDT^FS" + "^FO15,110^GB790,40,3^FS"

        For Each dr In ze.Rows
            caja = dr("CAJA")
            ZPLString = enca
            dd = dt.Select("CAJA = '" & caja & "'")
            l = 160
            ti = ""
            For Each fj In dd
                cliente = fj("CLIENTE")
                If fj("UNIDADES") > 0 Then
                    cpo = recorta(fj("CPO"), 20)
                    estilo = recorta(fj("ESTILO"), 15)
                    colo = recorta(fj("COLOR"), 15)
                    ti = ti + "^FO20," + CStr(l) + "^A0,30,20^FD" + fj("CORTE") + "^FS"
                    ti = ti + "^FO100," + CStr(l) + "^A0,30,20^FD" + cpo + "^FS"
                    ti = ti + "^FO250," + CStr(l) + "^A0,30,20^FD" + estilo + "^FS"
                    ti = ti + "^FO420," + CStr(l) + "^A0,30,20^FD" + colo + "^FS"
                    ti = ti + "^FO620," + CStr(l) + "^A0,30,20^FD" + fj("TALLA") + "^FS"
                    ti = ti + "^FO700," + CStr(l) + "^A0,30,20^FD" + Format(fj("UNIDADES"), "######") + "^FS"
                    ti = ti + "^FO770," + CStr(l) + "^A0,30,20^FD" + fj("TIPO") + "^FS"
                    l = l + 30
                End If
            Next
            ZPLString = ZPLString + ti + "^FO650,85^A0,30,20^FD" + cliente + "^FS" + "^FX" + "^BY5,2,120" + "^FO75,410^BC^FD" + caja & "^FS" + "^XZ"
            writer.Write(ZPLString)
            writer.Flush()

        Next

        writer.Close()
        client.Close()
        ' Catch
        '    ok = False
        ' End Try
        Return ok
    End Function
    Private Function recorta(ByVal texto As String, ByVal t As Integer) As String
        Dim tx As String
        tx = Mid(texto, 1, t)
        Return tx
    End Function


    Public Function modifica_caja(ByRef co As DataTable, ByVal caja As String, ByVal tipo As String, ByVal talla As String, ByVal uni As Integer, ByRef orden As Integer, ByRef unidad As Integer) As Boolean
        Dim dd As DataRow()
        Dim dr As DataRow = Nothing
        Dim ok As Boolean = False
        dd = co.Select("CAJA = '" & caja & "' AND TIPO = '" & tipo & "' AND TALLA = '" & talla & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            dr("UNIDADES") = dr("UNIDADES") - uni
            unidad = dr("UNIDADES")
            orden = dr("ORDEN")
        End If
        Return ok
    End Function

    Public Function saldo_caja(ByRef co As DataTable, ByVal caja As String, ByVal tipo As String, ByVal talla As String, ByRef orden As String) As Integer
        Dim dd As DataRow()
        Dim dr As DataRow = Nothing
        Dim unidades As Integer = 0
        dd = co.Select("CAJA ='" & caja & "' AND TIPO = '" & tipo & "' AND TALLA = '" & talla & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            unidades = dr("UNIDADES")
            orden = dr("ORDEN")
        End If
        Return unidades
    End Function

End Module
