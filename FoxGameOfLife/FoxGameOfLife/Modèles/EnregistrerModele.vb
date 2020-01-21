Public Class EnregistrerModele
    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        Me.Close()
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        If txtb_nom.Text <> "" Then
            If EnregistrerFichierModele(txtb_nom.Text) Then
                Me.Close()
            Else
                MsgBox("impossible d'enregistrer le modèle")
            End If
        Else
            MsgBox("Veuillez entrer un nom de modèle")
        End If
    End Sub

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        If txtb_tag.Text <> "" Then
            liste_tags.Items.Add(txtb_tag.Text)
        End If
    End Sub

    Private Sub bt_retirer_Click(sender As Object, e As EventArgs) Handles bt_retirer.Click
        liste_tags.Items.Remove(liste_tags.SelectedItem)
    End Sub
End Class