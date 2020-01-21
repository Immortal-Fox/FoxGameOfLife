Public Class FiltreMelanger
    Private Sub bt_appliquer_Click(sender As Object, e As EventArgs) Handles bt_appliquer.Click
        Filtre_Melanger(num_melange.Value)
        Me.Close()
    End Sub
End Class