Public Class Version

    Private Sub Version_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        obtiene_version()
    End Sub

    Private Sub obtiene_version()
        versiones.Text = My.Application.Info.Version.ToString
        marca.Text = "Jap Software  S.I. (Autor Jesús Acosta)"
        empresa.Text = "J&T Trading"
        nombre.Text = My.Application.Info.Description
        copyw.Text = My.Application.Info.Copyright
    End Sub
End Class