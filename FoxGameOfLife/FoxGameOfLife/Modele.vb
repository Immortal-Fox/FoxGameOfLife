''' <summary>
''' Modèle de structure pour le jeu de la vie
''' Sert de base pour les pinceaux
''' </summary>
Public Class Modele
    Inherits PictureBox

    'largeur du modèle
    Public Largeur As Integer
    'hauteur du modèle
    Public Hauteur As Integer
    'Liste des cellules du modèle
    Public Liste_cellules As New List(Of Boolean)
    Public liste_tags As New List(Of String)

    Public nom As String

    Public ImageModele As Bitmap
    Public G As Graphics

    Sub New(ByVal _largeur As Integer, ByVal _hauteur As Integer, ByVal _nom As String, ByVal _liste_cellules As List(Of Boolean), ByVal _liste_tags As List(Of String))
        Largeur = _largeur
        Hauteur = _hauteur
        nom = _nom

        'Définir le facteur de taille d'image
        Dim facteur As Integer = 40

        ' Créer l'aperçu du modèle
        ImageModele = New Bitmap(Largeur * facteur, Hauteur * facteur)
        G = Graphics.FromImage(ImageModele)

        Dim index As Integer = 0
        For x As Integer = 1 To Largeur
            For y As Integer = 1 To Hauteur
                If _liste_cellules(index) Then
                    G.FillRectangle(New SolidBrush(Color.Black), x * facteur - facteur, y * facteur - facteur, facteur, facteur)
                End If
                index = index + 1
            Next
        Next

        Liste_cellules = _liste_cellules
        liste_tags = _liste_tags

        Me.Image = ImageModele
        Me.SizeMode = PictureBoxSizeMode.Zoom
        Me.Size = New Size(80, 80)
        Me.BackColor = Color.Gainsboro
    End Sub

    Sub PassageSouris() Handles Me.MouseMove
        Main.lab_modeles.Text = nom
        Main.lab_modeles_taille.Text = Largeur & "x" & Hauteur
    End Sub


    Sub ClicSouris() Handles Me.Click
        Main.liste_modele = Me.Liste_cellules
        Main.PinceauSelectionne = Main.Pinceaux.Modele
        Main.modeleLargeur = Largeur
        Main.modeleHauteur = Hauteur
    End Sub
End Class
