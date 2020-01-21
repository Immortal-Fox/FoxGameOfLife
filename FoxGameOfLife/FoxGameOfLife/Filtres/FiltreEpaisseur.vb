Public Class FiltreEpaisseur
    Private Sub bt_appliquer_Click(sender As Object, e As EventArgs) Handles bt_appliquer.Click
        Filtre_Epaissir(1, num_epaisseur.Value)
        Me.Close()
    End Sub
End Class