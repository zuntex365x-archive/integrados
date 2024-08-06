Imports System.IO

Public Class spec
    Public estilo As String
    Public cliente As String
    Dim path As String = "\\192.9.200.254\programas\sistemas\plantillas\"
    Dim jt As String = path + "jt1.pdf"
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        despliega_spec()
    End Sub

    Private Sub despliega_spec()
        Dim nuevoar As String = path + "\" & cliente + "\" + estilo + ".pdf"
        Try
            If File.Exists(nuevoar) Then
                pdf1.src = nuevoar
            Else
                pdf1.src = jt
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
