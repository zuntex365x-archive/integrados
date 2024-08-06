Imports System.IO
Public Class Ingresa_spec
    Dim archivo As String
    Dim empre As New empresas
    Dim path As String = "\\192.9.200.254\programas\sistemas\plantillas\"
    Dim jt As String = path + "jt1.pdf"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llena_combos(cliente, "select DISTINCT CLIENTE FROM USUARIO_CLIENTE WHERE USUARIO = '" & empre.clave & "' ORDER BY CLIENTE", "CLIENTE")
        limpia()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles busca.Click
        Abrear.InitialDirectory = "c:\"
        Abrear.FileName = "*.pdf"
        archivo = ""
        If Abrear.ShowDialog = DialogResult.OK Then
            Try
                Cursor = Cursors.WaitCursor
                archivo = Abrear.FileName
                If File.Exists(archivo) = True Then
                    pdf0.src = archivo
                Else
                    MsgBox("Hubo un Error al abrir el archivo..", MsgBoxStyle.Critical, "Por favor revise !!!!")
                End If
            Catch
            End Try
            Cursor = Cursors.Default
        Else
            MessageBox.Show("Aun no se ha seleccionado el archivo a utilizar", "No se selecciono archivo", MessageBoxButtons.OK)
        End If
        If archivo.Length > 0 Then
            busca.Visible = False
            Graba.Visible = True
        End If
    End Sub

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        llena_combos(estilo, "SELECT DISTINCT ESTILO FROM CLI_EST_COL WHERE CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", "ESTILO")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        Dim nuevoar As String = path + "\" & cliente.Text + "\" + estilo.Text + ".pdf"
        Try
            pdf0.src = nuevoar
        Catch ex As Exception

        End Try
        sigue.Visible = False
        busca.Visible = True
        cliente.Enabled = False
        estilo.Enabled = False
    End Sub

    Private Sub Graba_Click(sender As System.Object, e As System.EventArgs) Handles Graba.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Grabar la Spec? ", MsgBoxStyle.YesNo, "Grabando Spec. !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_spec()
            limpia()
        End If
    End Sub
    Private Sub graba_spec()
        Dim seguro As MsgBoxResult
        Dim nuevodir As String
        Dim nuevoar As String
        nuevodir = path + cliente.Text
        nuevoar = nuevodir + "\" + estilo.Text + ".pdf"
        If IO.Directory.Exists(nuevodir) = False Then
            Directory.CreateDirectory(nuevodir)
        End If
        If IO.File.Exists(nuevoar) = True Then
            seguro = MsgBox("Ya existe una version de la Spec.  La desea actualizar? ", MsgBoxStyle.YesNo, "Spec ya Existe. !!!")
            If seguro = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Try
            Try
                File.Delete(nuevoar)
            Catch
            End Try

            File.Copy(archivo, nuevoar)
        Catch
            MsgBox("Hubo un Error copiar el Archivo.   Por favor intente de nuevo.", MsgBoxStyle.Critical, "Error !!!!")
        End Try
    End Sub

    Private Sub limpia()
        busca.Visible = False
        Graba.Visible = False
        sigue.Visible = True
        Try
           pdf0.src = jt
        Catch
        End Try
        cliente.Enabled = True
        estilo.Enabled = True
    End Sub

    Private Sub regresa_Click(sender As System.Object, e As System.EventArgs) Handles regresa.Click
        limpia()
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub estilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estilo.KeyPress
        AutoCompletar(estilo, e)
    End Sub

End Class
