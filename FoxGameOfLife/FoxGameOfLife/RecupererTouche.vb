Public Class RecupererTouche
    Public codeTouche As Keys
    Private Sub RecupererTouche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codeTouche = Keys.None
    End Sub

    ''' <summary>
    ''' Récupère la touche enfoncé
    ''' </summary>
    ''' <param name="sender">Objet trigger</param>
    ''' <param name="e">Event clavier</param>
    Private Sub RecupererTouche_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        codeTouche = e.KeyCode
        Me.Close()
    End Sub
End Class