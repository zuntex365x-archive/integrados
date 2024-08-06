Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.IO
Module cajas_s1
    Dim obj As New empresas
    Dim cnn As New SqlClient.SqlConnection
    Public Function imprime_etiquetas_tela(ByRef empresa As String, ByVal batch As String, ByVal rollo As String, ByVal knit As String, ByVal colort As String, ByVal barra As String, ByVal yardas As Decimal, ByVal libras As Decimal, ByVal pd As PrintDocument) As Boolean
        Dim ok As Boolean = True
        Dim logo As String = ""
        Dim ZPLString As String
        Dim ti As String = ""
        Dim enca As String
        Dim cliente As String = ""
        Dim h As String = "##0.00"
        Dim ya As String = Format(yardas, h)
        Dim li As String = Format(libras, h)
        'Dim prname As String '= "\\192.168.50.141\telas_t"  SE QUITO POR CAMBIAR LA PANTALLA DE JAQUELINE OCOS

        If pd Is Nothing Then

            pd = New PrintDocument()
            Dim pdlg As New Windows.Forms.PrintDialog()


            pd.PrinterSettings = New PrinterSettings()
            pd.PrinterSettings.PrinterName = pd.PrinterSettings.PrinterName

            pdlg.Document = pd
            If pdlg.ShowDialog() = DialogResult.OK Then
                pd.PrinterSettings.PrinterName = pdlg.PrinterSettings.PrinterName
                pd.Print()

            End If
        End If


        ya = Space(6 - Len(ya)) + ya
        li = Space(6 - Len(li)) + li

        If empresa = "1" Then
            logo = "^FO10,10^GFA,2205,2205,15,,:::O03FE,O07FF8,N01IFC,N03IFE,N07JF,N07JF8,:N0KFC,::::::N0KF8,N07JF8,N07JF,N03IFE,N01IFC,O0IF8,O03FE,,:::M01WFE,:::::::::::::::::::::U03KFC,U01KFC,U03KFC,U03KFC10FE,U03KFC38FE,:U03KFC30C6,M01KFE03KFC38C6,M01KFE03KFC3806,M01KFE03KFC380E,M01KFE03KFC1C1E,M01KFE03KFC1FFC,M01KFE03KFC0FFC,M01KFE03KFC07F,M01KFE03KFC,::M01KFE03KFC3FFE,M01KF800KFC3FFE,M01JFCI01JFC183E,M01JFK0JFC007C,M01IFEK03IFC01F,M01IFCK01IFC07C,M01IF8004I0IFC1F,M01IF003F8007FFC3E,M01FFE00FFE003FFC3FFE,M01FFC00F1E003FFC3FFE,M01FFC01E0E001FFC1FFE,M01FF801E0F001FFC,M01FF801E0FI0FFC,M01FF801E1EI0FFC3FFE,M01FF001F1EI0FFC3FFE,M01FFI0F3CI07FC3FFE,M01FFI0FF8I07FC,M01FFI07E03807FC,M01FF001FE07807FC01C,M01FF003FF07807FC07F,M01FF007CF87807FC0FFC,M01FF00787CF007FC1FFC,M01FF00F87CF007FC1C1E,M01FF00F03FE007FC380E,M01FF00F81FE00FFC3806,M01FF80F80FC00FFC3006,M01FF80FC0FC00FFC3006,M01FF807F3FE01FFC3FFE,M01FFC03JF01FFC3FFE,M01FFE01FFCF83FFC3FFE,M01FFE007E0787FFC,M01IFM07FFC,M01IF8L0IFC,M01IFCK01IFCI0E,M01JFK07IFC007E,M01JF8J0JFC03FE,M01KFI07JFC1FF,M01KFC01KFC3F3,M03KFC01KFC383,M03KFC03KFC3F3,M03KFC03KFC1FF8,M03KFC03KFC03FE,M07KFC03KFC007E,M0LFC03KFCI0E,M0LFC03KFC,L03LFC03KFC,L0MF803KFC,K07MF803KFC0E0E,I0PF803KFC1F3E,I0PF803KFC1FFE,I0PF003KFC39F8,I0PF003KFC30E,I0PF003KFC30C,I0OFE003KFC38C,I0OFE003KFC3FFE,I0OFC003KFC3FFE,I0OF8003KFC1FFE,I0OF8003KFC,I0OFI03KFC,I0OFI03KFC38,I0NFEI03KFC38,I0NFCI03KFC38,I0NF8I03KFC38,I0NFJ03KFC3FFE,I0MFEJ03KFC3FFE,I0MF8J03KFC3A6E,I0MFK03KFC38,I0LF8K03KFC38,I0KFEL03KFC38,I0KFM03KFC,I0IFEN03KFC,I0FQ01KF8,,::::::^FS"
        ElseIf empresa = "3" Then
            logo = "^FO15,45^GFA,1480,1480,20,,:::Q0F8,P0IFC,O07IFC,I07FE001FFD2,001JF03FF8,007MFC,I093LF8,K03LF,K01LFC,K0JFE67E,J03KF003,I01LFC,I03JF7FE,I07JF3FF,001KF9FF8,003F4IF9DFC3FC,007E1IF8E7E3FF8003,00FE3FBF8E0F01FF0IF,00F23FBF070F003KF,01C07F3F030383JF8,01007C3F03838KF,0100FC3F03819F3IF8,I01E03F01CI03JF,I01F03E01EI07F7FFC,I01C03F00E001FEIFE,I03C03E00F001ECFFDF,I03C03E007003CCFFCF8,I03801D00700718FBE5C,I03001C00380E1879E0C,I06001E00380C30F8F04,I06001F001C0830F87,I04001E001C00607838,L01E001E00E07838,L01CI0E00E07838,M0EI0E01C0380C,:M0AI0F01807004,M02I0703803,Q0783003,Q0787003,Q0787002,Q078E,:::Q079C,:Q07FCJ01FF8L03FC,Q07FCJ07FF8L0FFC,Q07F8J07FFL01FF8,Q07F8J0F3EL01FE,Q07F8K0380CK03E00C,Q07F8K0700E006003C03E706,Q07F8K0E03E00E00780FE79E,Q07F8J03C07C71C70F81CE3FC,Q07F8J07807CF3CF1F03DC3F8,Q0FF8J0F00F1E7FE1F03983F,Q0FF8I03E00F7E7FE3E0F383E,Q0FF8I07C19EFCFFE3C0F603E,Q0FF8I0FCF1FFCFBC7C1F40FE,Q0FF8001FFE3F79F3CF81F73FF,O018FF8803FFE3E79E3CF01FE7FF,P09FF8801FF07879838E01F871F,P09FF88,O02BFFC,O01JFC,O03JFE,O0LF8,,:^FS"
        End If

        enca = "^XA" + logo
        ZPLString = enca
        ti = "^FO290,60^A0,50,50^FDBATCH:^FS"
        ti = ti + "^FO460,60^A0,50,50^FD" + batch + "^FS"
        ti = ti + "^FO290,120^A0,50,50^FDROLLO:^FS"
        ti = ti + "^FO460,120^A0,50,50^FD" + rollo + "^FS"
        ti = ti + "^FO30,190^A0,45,45^FDKNIT:^FS"
        ti = ti + "^FO30,230^A0,35,35^FD" + knit + "^FS"
        ti = ti + "^FO30,290^A0,45,45^FDCOLOR:^FS"
        ti = ti + "^FO30,330^A0,35,35^FD" + colort + "^FS"
        ti = ti + "^FO640,290^AD,30,14^FDYds.:^FS"
        ti = ti + "^FO730,290^AD,30,14^FD" & ya & "^FS"
        ti = ti + "^FO640,330^AD,30,14^FDLbs.:^FS"
        ti = ti + "^FO730,330^AD,30,14^FD" & li & "^FS"

        ZPLString = ZPLString + ti + "^BY5,2,120" + "^FO75,410^BC^FD" + barra & "^FS" + "^XZ"

        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, ZPLString)
        Return ok
    End Function
    Public Function imprime_cajas_s(ByRef inicial As String, ByVal final As String) As Boolean
        Dim ok As Boolean = True
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
        Dim etiqueta As String = ""
        Dim obj As New empresas
        '       Try
        Dim pd As New PrintDialog()
        pd.PrinterSettings = New PrinterSettings()
        'pd.PrinterSettings.PrinterName = "ticket_p"
        'pd.PrinterSettings.PrinterName = "\\192.9.200.113\Ticket_p"
        Dim prname As String
        prname = pd.PrinterSettings.PrinterName
        pd.PrinterSettings.PrinterName = prname



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

                    ti = ti + "^FO100," + CStr(l) + "^A0,40,30^FD" + cpo + "^FS"
                    ti = ti + "^FO250," + CStr(l) + "^A0,40,30^FD" + estilo + "^FS"
                    ti = ti + "^FO420," + CStr(l) + "^A0,40,30^FD" + colo + "^FS"
                    ti = ti + "^FO620," + CStr(l) + "^A0,40,30^FD" + fj("TALLA") + "^FS"
                    ti = ti + "^FO700," + CStr(l) + "^A0,40,30^FD" + Format(fj("UNIDADES"), "######") + "^FS"
                    ti = ti + "^FO770," + CStr(l) + "^A0,40,30^FD" + fj("TIPO") + "^FS"
                    l = l + 30
                End If
            Next
            '   ZPLString = ZPLString + ti + "^FO650,85^A0,30,20^FD" + cliente + "^FS" + "^FX" + "^BY5,2,120" + "^FO75,410^BC^FD" + caja & "^FS" + "^XZ"
            ZPLString = ZPLString + ti + "^FO650,85^A0,30,20^FD" + cliente + "^FS" + "^FX" + "^BY4,2,120" + "^FO170,410^BC^FD" + caja & "^FS" + "^XZ"
            etiqueta = etiqueta + ZPLString
        Next
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, etiqueta)
        Return ok
    End Function

    Private Function recorta(ByVal texto As String, ByVal t As Integer) As String
        Dim tx As String
        tx = Mid(texto, 1, t)
        Return tx
    End Function
    Public Class RawPrinterHelper
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
        Public Class DOCINFOA
            <MarshalAs(UnmanagedType.LPStr)> _
            Public pDocName As String
            <MarshalAs(UnmanagedType.LPStr)> _
            Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPStr)> _
            Public pDataType As String
        End Class
        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(<MarshalAs(UnmanagedType.LPStr)> ByVal szPrinter As String, ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal di As DOCINFOA) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="WritePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Structure DOCINFOW
            <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
        End Structure

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
        End Function

        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim dwError As Int32 = 0, dwWritten As Int32 = 0
            Dim hPrinter As New IntPtr(0)
            Dim di As New DOCINFOA()
            Dim bSuccess As Boolean = False
            ' Assume failure unless you specifically succeed.
            di.pDocName = "My C#.NET RAW Document"
            di.pDataType = "RAW"

            ' Open the printer.
            If OpenPrinter(szPrinterName.Normalize(), hPrinter, IntPtr.Zero) Then
                ' Start a document.
                If StartDocPrinter(hPrinter, 1, di) Then
                    ' Start a page.
                    If StartPagePrinter(hPrinter) Then
                        ' Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If bSuccess = False Then
                dwError = Marshal.GetLastWin32Error()
            End If
            Return bSuccess
        End Function

        Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
            ' Open the file.
            Dim fs As New FileStream(szFileName, FileMode.Open)
            ' Create a BinaryReader on the file.
            Dim br As New BinaryReader(fs)
            ' Dim an array of bytes big enough to hold the file's contents.
            Dim bytes As [Byte]() = New [Byte](fs.Length - 1) {}
            Dim bSuccess As Boolean = False
            ' Your unmanaged pointer.
            Dim pUnmanagedBytes As New IntPtr(0)
            Dim nLength As Integer

            nLength = Convert.ToInt32(fs.Length)
            ' Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength)
            ' Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength)
            ' Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength)
            ' Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength)
            ' Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes)
            Return bSuccess
        End Function
        Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String) As Boolean
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            ' How many characters are in the string?
            dwCount = szString.Length
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
            Return True
        End Function
    End Class

End Module

