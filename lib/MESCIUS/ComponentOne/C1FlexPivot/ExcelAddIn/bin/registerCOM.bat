pushd "%~dp0"
path = %path%;%windir%\Microsoft.NET\Framework\v4.0.30319
regasm C1.DataEngine.ExcelAddIn.dll /tlb:C1.DataEngine.ExcelAddIn.tlb /codebase
pause