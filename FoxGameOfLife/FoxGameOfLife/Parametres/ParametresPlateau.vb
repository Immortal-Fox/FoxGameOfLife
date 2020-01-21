Public Class ParametresPlateau
    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        Me.Close()
    End Sub

    Private Sub bt_appliquer_Click(sender As Object, e As EventArgs) Handles bt_appliquer.Click

        'Efface les tableaux
        Main.Engine.EffacerTableaux()

        'Efface l'image affichée
        Main.pbox_plateau.Image = Nothing

        'Applique les paramètres sur le moteur
        Main.Engine.TaillePlateau = New Size(num_largeur.Value, num_hauteur.Value)
        Main.Engine.TailleCases = num_tailleCases.Value

        Main.Engine.ToutRedimensionner()
        Main.Engine.ToutRedessiner()

        Main.pbox_plateau.Size = Main.Engine.ImageCourante.Size
        Main.pbox_plateau.Image = Main.Engine.ImageCourante

        Me.Close()

    End Sub
End Class