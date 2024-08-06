Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Public Class Cambia_fecha_fpo
    Public cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cl As DataTable
    Dim tp As DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        graba.Focus()
    End Sub

    Private Sub graba_Click(sender As System.Object, e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Esta completamente Seguro de querer Actualizar la fecha de TODDA la FPO?", MsgBoxStyle.YesNo, "Cambiando Fechas !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_datos()
            Close()
        End If
    End Sub
    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim clientes As String = ""
        Dim tipos As String = ""
        Dim fechas As String = fecha.text

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE FPO SET RFECHA = '" & fechas & "' WHERE FPO = '" & fpo.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

End Class