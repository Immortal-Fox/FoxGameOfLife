Public Class ParametresAnimation
    Private Sub ParametresAnimation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_appliquer_Click(sender As Object, e As EventArgs) Handles bt_appliquer.Click

        ' Applique les paramètres d'animation

        Main.formatImage = cbox_formatImage.SelectedIndex
        Main.creerChaqueImage = cbox_enregistrerchaqueframe.Checked

        Main.creerGifAnime = cbox_creerGif.Checked
        Main.delaiGif = num_delai.Value

    End Sub
End Class