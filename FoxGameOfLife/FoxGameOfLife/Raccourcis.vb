Public Class Raccourcis

    Public raccourciPinceauSimple As Raccourci
    Public raccourciRemplisseur As Raccourci
    Public raccourciPinceauLigne As Raccourci
    Public raccourciPinceauColonne As Raccourci
    Public raccourciPinceauCroix As Raccourci
    Public raccourciPinceauDiagD As Raccourci
    Public raccourciPinceauDiagG As Raccourci
    Public raccourciPinceauDiagonales As Raccourci
    Public raccourciSelectionCellule As Raccourci
    Public raccourciSelectionVide As Raccourci
    Public raccourciSelectionMur As Raccourci
    Public raccourciSelectionCellulePermanente As Raccourci
    Public raccourciModeleRotationDroite As Raccourci
    Public raccourciModeleRotationGauche As Raccourci
    Public raccourciModeleSymetrieHorizontale As Raccourci
    Public raccourciModeleSymetrieVerticale As Raccourci

    Public raccourciSimulationDemarrer As Raccourci
    Public raccourciSimulationArreter As Raccourci
    Public raccourciSimulationPause As Raccourci
    Public raccourciSimulationFrameSuivante As Raccourci
    Public raccourciSimulationFramePrecedente As Raccourci


    Private Sub Raccourcis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        raccourciPinceauSimple = New Raccourci("Pinceau simple", My.Resources.crayon, Main.raccPinceauSimple)
        raccourciRemplisseur = New Raccourci("Remplisseur", My.Resources.remplisseur, Main.raccRemplisseur)
        raccourciPinceauLigne = New Raccourci("Pinceau ligne", My.Resources.pinceau_ligne, Main.raccPinceauLigne)
        raccourciPinceauColonne = New Raccourci("Pinceau colonne", My.Resources.pinceau_colonne, Main.raccPinceauColonne)
        raccourciPinceauCroix = New Raccourci("Pinceau croix", My.Resources.croix, Main.raccPinceauCroix)
        raccourciPinceauDiagD = New Raccourci("Pinceau diagonale droite", My.Resources.diagonale_droite, Main.raccPinceauDiagD)
        raccourciPinceauDiagG = New Raccourci("Pinceau diagonale gauche", My.Resources.diagonale_gauche, Main.raccPinceauDiagG)
        raccourciPinceauDiagonales = New Raccourci("Pinceau diagonales", My.Resources.croix2, Main.raccPinceauDiagonales)
        raccourciSelectionCellule = New Raccourci("Sélection cellule", My.Resources.editioncellule, Main.raccSelectionCellule)
        raccourciSelectionVide = New Raccourci("Sélection vide", My.Resources.editionvide, Main.raccSelectionVide)
        raccourciSelectionMur = New Raccourci("Sélection mur", My.Resources.pinceau_mur_perso, Main.raccSelectionMur)
        raccourciSelectionCellulePermanente = New Raccourci("Sélection cellule permanente", My.Resources.cellule_permanente, Main.raccSelectionCellulePermanente)
        raccourciModeleRotationDroite = New Raccourci("Rotation du modèle à droite", My.Resources.Inverserdiagonale, Main.raccModeleRotationDroite)
        raccourciModeleRotationGauche = New Raccourci("Rotation du modèle à gauche", My.Resources.Inverserdiagonale, Main.raccModeleRotationGauche)
        raccourciModeleSymetrieHorizontale = New Raccourci("Retourner le modèle horizontalement", My.Resources.miroircolonne, Main.raccModeleSymetrieHorizontale)
        raccourciModeleSymetrieVerticale = New Raccourci("Retourner le modèle verticalement", My.Resources.miroirligne, Main.raccModeleSymetrieVerticale)

        raccourciSimulationDemarrer = New Raccourci("Démarrer la simulation", My.Resources.play, Main.raccSimulationDemarrer)
        raccourciSimulationArreter = New Raccourci("Arrêter la simulation", My.Resources._stop, Main.raccSimulationArreter)
        raccourciSimulationPause = New Raccourci("Mettre la simulation en pause", My.Resources.pause, Main.raccSimulationPause)
        raccourciSimulationFrameSuivante = New Raccourci("Passer à la frame suivante", My.Resources.avancer, Main.raccSimulationFrameSuivante)
        raccourciSimulationFramePrecedente = New Raccourci("Passer à la frame précédente", My.Resources.reculer, Main.raccSimulationFramePrecedente)

        ' Ajout des contrôles au panel de contenu
        panel_contenu.Controls.Add(raccourciPinceauSimple)
        panel_contenu.Controls.Add(raccourciRemplisseur)
        panel_contenu.Controls.Add(raccourciPinceauLigne)
        panel_contenu.Controls.Add(raccourciPinceauColonne)
        panel_contenu.Controls.Add(raccourciPinceauCroix)
        panel_contenu.Controls.Add(raccourciPinceauDiagD)
        panel_contenu.Controls.Add(raccourciPinceauDiagG)
        panel_contenu.Controls.Add(raccourciPinceauDiagonales)
        panel_contenu.Controls.Add(raccourciSelectionCellule)
        panel_contenu.Controls.Add(raccourciSelectionVide)
        panel_contenu.Controls.Add(raccourciSelectionMur)
        panel_contenu.Controls.Add(raccourciSelectionCellulePermanente)
        panel_contenu.Controls.Add(raccourciModeleRotationDroite)
        panel_contenu.Controls.Add(raccourciModeleRotationGauche)
        panel_contenu.Controls.Add(raccourciModeleSymetrieHorizontale)
        panel_contenu.Controls.Add(raccourciModeleSymetrieVerticale)

        panel_contenu.Controls.Add(raccourciSimulationDemarrer)
        panel_contenu.Controls.Add(raccourciSimulationArreter)
        panel_contenu.Controls.Add(raccourciSimulationPause)
        panel_contenu.Controls.Add(raccourciSimulationFrameSuivante)
        panel_contenu.Controls.Add(raccourciSimulationFramePrecedente)

    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        Me.Close()
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Main.raccPinceauSimple = raccourciPinceauSimple.code
        Main.raccRemplisseur = raccourciRemplisseur.code
        Main.raccPinceauLigne = raccourciPinceauLigne.code
        Main.raccPinceauColonne = raccourciPinceauColonne.code
        Main.raccPinceauCroix = raccourciPinceauCroix.code
        Main.raccPinceauDiagD = raccourciPinceauDiagD.code
        Main.raccPinceauDiagG = raccourciPinceauDiagG.code
        Main.raccPinceauDiagonales = raccourciPinceauDiagonales.code
        Main.raccSelectionCellule = raccourciSelectionCellule.code
        Main.raccSelectionVide = raccourciSelectionVide.code
        Main.raccSelectionMur = raccourciSelectionMur.code
        Main.raccSelectionCellulePermanente = raccourciSelectionCellulePermanente.code
        Main.raccModeleRotationDroite = raccourciModeleRotationDroite.code
        Main.raccModeleRotationGauche = raccourciModeleRotationGauche.code
        Main.raccModeleSymetrieHorizontale = raccourciModeleSymetrieHorizontale.code
        Main.raccModeleSymetrieVerticale = raccourciModeleSymetrieVerticale.code

        Main.raccSimulationDemarrer = raccourciSimulationDemarrer.code
        Main.raccSimulationArreter = raccourciSimulationArreter.code
        Main.raccSimulationPause = raccourciSimulationPause.code
        Main.raccSimulationFrameSuivante = raccourciSimulationFrameSuivante.code
        Main.raccSimulationFramePrecedente = raccourciSimulationFramePrecedente.code

        panel_contenu.Controls.Clear()
        Me.Close()
    End Sub
End Class

Public Class Raccourci
    Inherits Panel
    Private pbox_image As New PictureBox
    Private lab_Texte As New Label
    Private WithEvents bt_raccourci As New Button
    Public code As Keys
    Sub New(ByVal _texte As String, ByVal _image As Image, Optional _raccourci As Keys = Keys.None)
        Me.Width = 300
        Me.Height = 24
        Me.BackColor = Color.Gainsboro
        pbox_image.Size = New Size(Me.Height, Me.Height)
        pbox_image.SizeMode = PictureBoxSizeMode.CenterImage
        pbox_image.Image = _image
        Me.Controls.Add(pbox_image)

        lab_Texte.Text = _texte
        lab_Texte.Location = New Point(pbox_image.Width + 2, 4)
        lab_Texte.AutoSize = True
        Me.Controls.Add(lab_Texte)

        bt_raccourci.Size = New Size(80, Me.Height)
        bt_raccourci.Location = New Point(Me.Width - bt_raccourci.Width, 0)
        bt_raccourci.FlatStyle = FlatStyle.Flat
        bt_raccourci.FlatAppearance.BorderSize = 0
        code = _raccourci
        bt_raccourci.Text = code.ToString
        Me.Controls.Add(bt_raccourci)

    End Sub

    Sub AssignerTouche() Handles bt_raccourci.Click
        RecupererTouche.ShowDialog()
        code = RecupererTouche.codeTouche
        bt_raccourci.Text = code.ToString
    End Sub
End Class