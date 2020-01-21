Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Main
    Public Engine As JDLVEngine

    Private ReadOnly nomProgramme As String = "ZGameOfLife"
    Private ReadOnly versionProgramme As String = "1"

    Public mouseIsDown As Boolean = False

    'Public ArretAutomatiqueSimulation As Boolean = False
    'Public ArretAutomatiqueFrame As Integer = 1000

    'Liste de frame pour animation
    Public liste_frames As New List(Of Image)

    'Arborescence de dossier

    'Documents
    Public dir_documents As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "/FoxGameOfLife"
    'Documents/Animations
    Public dir_animations As String = dir_documents & "/Animations"
    'Documents/Fichiers
    Public dir_fichiers As String = dir_documents & "/Fichiers"
    'Documents/Modèles
    Public dir_modeles As String = dir_documents & "/Modèles"
    'Documents/Images
    Public dir_images As String = dir_documents & "/Images"
    'Appadata
    Public dir_appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "/FoxGameOfLife"
    'Documents/Fichier/Life
    Public dir_life As String = dir_fichiers & "/Life"

    'Animation et Paramètres d'enregistrement d'image
    Public nomAnimation As String
    Public numeroImage As Integer = 0

    Public creerChaqueImage As Boolean = True
    Public formatImage As Byte = 0 'Bitmap par défaut
    Public creerGifAnime As Boolean = False
    Public delaiGif As Integer = 100

    ' Liste pour le modèle
    Public liste_modele As List(Of Boolean)
    Public modeleLargeur As Integer = 0
    Public modeleHauteur As Integer = 0

    'Affichage du texte
    Public texte As String = ""

    ' Liste des raccourcis
    Public raccPinceauSimple As Keys
    Public raccRemplisseur As Keys
    Public raccPinceauLigne As Keys
    Public raccPinceauColonne As Keys
    Public raccPinceauCroix As Keys
    Public raccPinceauDiagD As Keys
    Public raccPinceauDiagG As Keys
    Public raccPinceauDiagonales As Keys
    Public raccSelectionCellule As Keys
    Public raccSelectionVide As Keys
    Public raccSelectionMur As Keys
    Public raccSelectionCellulePermanente As Keys
    ' Contrôle du modèle
    Public raccModeleRotationDroite As Keys
    Public raccModeleRotationGauche As Keys
    Public raccModeleSymetrieHorizontale As Keys
    Public raccModeleSymetrieVerticale As Keys
    ' Contrôle de la simulation
    Public raccSimulationDemarrer As Keys
    Public raccSimulationArreter As Keys
    Public raccSimulationPause As Keys
    Public raccSimulationFrameSuivante As Keys
    Public raccSimulationFramePrecedente As Keys

    ''' <summary>
    ''' Liste des pinceaux disponible
    ''' </summary>
    Enum Pinceaux
        Simple = 0
        Remplisseur = 1
        Ligne = 2
        Colonne = 3
        Croix = 4
        DiagonaleD = 5
        DiagonaleG = 6
        Diagonales = 7
        Mur = 8
        Modele = 20
    End Enum
    Enum TypeCellule
        Vide = 0
        Cellule = 1
        Mur = 2
        CellulePermanente = 3
    End Enum

    Public PinceauSelectionne As Pinceaux = Pinceaux.Simple
    Public ValeurEdition As Byte = 1

    ' Threading

    Public nombreThread As Integer = 1


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialisation du programme
        Me.Text = nomProgramme & " " & versionProgramme

        'Création des dossiers
        DossierExiste(dir_documents, True)
        DossierExiste(dir_animations, True)
        DossierExiste(dir_fichiers, True)
        DossierExiste(dir_modeles, True)
        DossierExiste(dir_images, True)
        DossierExiste(dir_appdata, True)
        DossierExiste(dir_life, True)

        'Création du moteur de jeu de la vie
        Engine = New JDLVEngine(New Size(100, 100), pbox_plateau)

        'Dimension et image
        pbox_plateau.Size = Engine.ImageCourante.Size
        pbox_plateau.Image = Engine.ImageCourante

        ' Vérification Coeurs processeurs pour thread
        If System.Environment.ProcessorCount < 2 Then
            tsm_2Thread.Enabled = False
            tsm_4Thread.Enabled = False
        ElseIf System.Environment.ProcessorCount < 4 Then
            tsm_4Thread.Enabled = False
        End If

        'Charger les paramètres
        ChargerParametres()

        'Charger les modèles 
        '  CreerModeles()              ' Modèles de base du programme
        '  ChargerFichiersModele()     ' Depuis un fichier
        ActualiserListeModele()
    End Sub

    Private Sub Pbox_plateau_MouseDown(sender As Object, e As MouseEventArgs) Handles pbox_plateau.MouseDown
        If tsm_stop.Enabled = False And e.Button = MouseButtons.Left Then
            mouseIsDown = True
            Dim x As Integer = Math.Floor(e.Location.X / Engine.TailleCases) + 1
            Dim y As Integer = Math.Floor(e.Location.Y / Engine.TailleCases) + 1

            ' Entrez dans le module pinceaux
            AppliquerPinceau(x, y)
            'Engine.GetCellValue(x, y) = Not Engine.GetCellValue(x, y)
            'Engine.GenererEditionImage()
            pbox_plateau.Image = Engine.ImageCourante
            If x <> tempX Or y <> tempY Then
                tempX = x
                tempY = y

                ' Création de la liste des points pour le dessin des rectangles du pinceau
                Engine.DessinerEmpreintePinceau(GetListeRectanglesPinceaux(PinceauSelectionne, x, y))
                pbox_plateau.Image = Engine.ImagePinceau


            End If
        End If

    End Sub



    Private Sub tsm_play_Click(sender As Object, e As EventArgs) Handles tsm_play.Click
        'Bloquer le mode édition
        If tsm_stop.Enabled = False Then
            Engine.SetMode() = False
        End If
        'Démarrer la simulation automatique
        temps_simulation.Interval = num_tempsSimulation.Value
        tsm_pause.Enabled = True
        tsm_stop.Enabled = True
        tsm_stopKeep.Enabled = True
        tsm_play.Enabled = False
        temps_simulation.Start()

    End Sub

    Private Sub temps_simulation_Tick(sender As Object, e As EventArgs) Handles temps_simulation.Tick

        'Génère la frame suivante
        Engine.GenererFrameSuivante()

        'Affiche l'image
        '   If Engine.afficherTexte Then
        '   pbox_plateau.Image = Engine.ImageTexte
        '   Else
        '   pbox_plateau.Image = Engine.ImageCourante
        '   End If


        'Met à jour l'affiche des frames

        lab_frame.Text = " Frame : " & Engine.numeroFrame

        ' Met à jour le compteur de population

        Me.lab_population.Text = "Population : " & Engine.population
        Me.lab_tempsGeneration.Text = " Temps de génération : " & Engine.tempsGeneration.Milliseconds & " ms"

        'Si la simulation doit s'arreter automatiquement

        If cbox_arreterSimulation.Checked Then
            If Engine.numeroFrame = num_arretframe.Value Then
                tsm_pause_Click(Nothing, Nothing)
            End If
        End If

        'Ajouter Animation
        AjouterAnimation()

    End Sub

    Private Sub tsm_pause_Click(sender As Object, e As EventArgs) Handles tsm_pause.Click
        temps_simulation.Stop()
        tsm_play.Enabled = True
        tsm_pause.Enabled = False
    End Sub

    Private Sub tsm_stop_Click(sender As Object, e As EventArgs) Handles tsm_stop.Click
        'Quitte le mode simulation
        Engine.SetMode = True
        'Mets fin à la simulation
        tsm_play.Enabled = True
        tsm_pause.Enabled = False
        tsm_framesuivante.Enabled = True
        tsm_stop.Enabled = False
        tsm_stopKeep.Enabled = False
        temps_simulation.Stop()
        Engine.ReinitialiserPlateau()
        pbox_plateau.Image = Engine.ImageCourante
        Engine.numeroFrame = 0
        lab_frame.Text = " Frame : " & Engine.numeroFrame
    End Sub

    Private Sub tsm_framesuivante_Click(sender As Object, e As EventArgs) Handles tsm_framesuivante.Click
        'Bloquer le mode édition
        If tsm_stop.Enabled = False Then
            Engine.SetMode() = False
            tsm_stop.Enabled = True
            tsm_stopKeep.Enabled = True
        End If
        'Génère la frame suivante
        Engine.GenererFrameSuivante()
        'Affiche l'image
        pbox_plateau.Image = Engine.ImageCourante
        'Met à jour l'affiche des frames
        lab_frame.Text = " Frame : " & Engine.numeroFrame
        ' Met à jour le compteur de population
        Me.lab_population.Text = "Population : " & Engine.population

        AjouterAnimation()
    End Sub

    Private Sub pbox_plateau_MouseUp(sender As Object, e As MouseEventArgs) Handles pbox_plateau.MouseUp
        mouseIsDown = False
    End Sub

    Public tempX As Integer = 0
    Public tempY As Integer = 0

    Private Sub pbox_plateau_MouseMove(sender As Object, e As MouseEventArgs) Handles pbox_plateau.MouseMove
        Dim x As Integer = Math.Floor(e.Location.X / Engine.TailleCases) + 1
        Dim y As Integer = Math.Floor(e.Location.Y / Engine.TailleCases) + 1
        ' Mets à jour l'information sur les coordonnées de la case
        tss_coord.Text = "x : " & x & " y : " & y

        If Engine.SetMode = True Then

            If x <> tempX Or y <> tempY Then
                tempX = x
                tempY = y

                ' Création de la liste des points pour le dessin des rectangles du pinceau
                Engine.DessinerEmpreintePinceau(GetListeRectanglesPinceaux(PinceauSelectionne, x, y))
                pbox_plateau.Image = Engine.ImagePinceau


            End If
        End If
        If mouseIsDown Then

            AppliquerPinceau(x, y)
            'Engine.GetCellValue(x, y) = True
            'Engine.GenererEditionImage()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub bt_touteffacer_Click(sender As Object, e As EventArgs) Handles tsm_effacer.Click
        If Engine.SetMode Then
            Engine.EffacerTableaux()
            Engine.ToutRedessiner()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Public Function DossierExiste(ByVal _path As String, Optional _creer As Boolean = False)
        If Directory.Exists(_path) Then
            Return True
        Else
            If _creer Then
                Directory.CreateDirectory(_path)
            End If
            Return False
        End If
    End Function

    Public Function FichierExiste(ByVal _path As String)
        If File.Exists(_path) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub tsm_enregistrerImage_Click(sender As Object, e As EventArgs) Handles tsm_enregistrerImage.Click
        If DossierExiste(dir_images, True) Then
            If Not IsNothing(pbox_plateau.Image) Then
                pbox_plateau.Image.Save(dir_images & "/" & DateAndTime.DateString & "_" & DateAndTime.Timer & ".bmp")
                MsgBox("Enregistré sous : " & dir_images & "/" & DateAndTime.DateString & "_" & DateAndTime.Timer & ".bmp")
            End If
        End If
    End Sub

    Private Sub NoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoteToolStripMenuItem.Click
        NotesVersion.Show()
    End Sub

    Private Sub num_tailleCases_ValueChanged(sender As Object, e As EventArgs) Handles num_tailleCases.ValueChanged
        'Modification de la taille des cases
        If num_tailleCases.Value <> 0 Then
            Engine.TailleCases = num_tailleCases.Value

            Engine.ToutRedimensionner()
            Engine.ToutRedessiner()

            pbox_plateau.Size = Engine.ImageCourante.Size
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub bt_couleurCasesVides_Click(sender As Object, e As EventArgs) Handles bt_couleurCasesVides.Click
        choixCouleur.Color = bt_couleurCasesVides.BackColor
        Dim resultat As DialogResult = choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurCasesVides.BackColor = choixCouleur.Color

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_couleurCellules.Click
        choixCouleur.Color = bt_couleurCellules.BackColor
        Dim resultat As DialogResult = choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurCellules.BackColor = choixCouleur.Color
        End If

    End Sub

    Private Sub Bt_couleurGrille_Click(sender As Object, e As EventArgs) Handles bt_couleurGrille.Click
        choixCouleur.Color = bt_couleurGrille.BackColor
        Dim resultat As DialogResult = choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurGrille.BackColor = choixCouleur.Color
        End If

    End Sub

    Private Sub num_tempsSimulation_ValueChanged(sender As Object, e As EventArgs) Handles num_tempsSimulation.ValueChanged
        temps_simulation.Interval = num_tempsSimulation.Value
    End Sub

    Public Sub AppliquerRegles()
        If Not IsNothing(Engine) Then
            'Efface les listes de règles existantes
            Engine.listeNombreCelluleCreation.Clear()
            Engine.listeNombreCelluleSurvie.Clear()

            'Applique les paramètres
            If cbox_survie0.Checked Then Engine.listeNombreCelluleSurvie.Add(0)
            If cbox_survie1.Checked Then Engine.listeNombreCelluleSurvie.Add(1)
            If cbox_survie2.Checked Then Engine.listeNombreCelluleSurvie.Add(2)
            If cbox_survie3.Checked Then Engine.listeNombreCelluleSurvie.Add(3)
            If cbox_survie4.Checked Then Engine.listeNombreCelluleSurvie.Add(4)
            If cbox_survie5.Checked Then Engine.listeNombreCelluleSurvie.Add(5)
            If cbox_survie6.Checked Then Engine.listeNombreCelluleSurvie.Add(6)
            If cbox_survie7.Checked Then Engine.listeNombreCelluleSurvie.Add(7)
            If cbox_survie8.Checked Then Engine.listeNombreCelluleSurvie.Add(8)

            If cbox_creation0.Checked Then Engine.listeNombreCelluleCreation.Add(0)
            If cbox_creation1.Checked Then Engine.listeNombreCelluleCreation.Add(1)
            If cbox_creation2.Checked Then Engine.listeNombreCelluleCreation.Add(2)
            If cbox_creation3.Checked Then Engine.listeNombreCelluleCreation.Add(3)
            If cbox_creation4.Checked Then Engine.listeNombreCelluleCreation.Add(4)
            If cbox_creation5.Checked Then Engine.listeNombreCelluleCreation.Add(5)
            If cbox_creation6.Checked Then Engine.listeNombreCelluleCreation.Add(6)
            If cbox_creation7.Checked Then Engine.listeNombreCelluleCreation.Add(7)
            If cbox_creation8.Checked Then Engine.listeNombreCelluleCreation.Add(8)
        End If
    End Sub

    Private Sub cbox_survie0_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_survie0.CheckedChanged,
                                                                                      cbox_survie1.CheckedChanged,
                                                                                      cbox_survie2.CheckedChanged,
                                                                                      cbox_survie3.CheckedChanged,
                                                                                      cbox_survie4.CheckedChanged,
                                                                                      cbox_survie5.CheckedChanged,
                                                                                      cbox_survie6.CheckedChanged,
                                                                                      cbox_survie7.CheckedChanged,
                                                                                      cbox_survie8.CheckedChanged,
                                                                                      cbox_creation0.CheckedChanged,
                                                                                      cbox_creation1.CheckedChanged,
                                                                                      cbox_creation2.CheckedChanged,
                                                                                      cbox_creation3.CheckedChanged,
                                                                                      cbox_creation4.CheckedChanged,
                                                                                      cbox_creation5.CheckedChanged,
                                                                                      cbox_creation6.CheckedChanged,
                                                                                      cbox_creation7.CheckedChanged,
                                                                                      cbox_creation8.CheckedChanged

        AppliquerRegles()
    End Sub

    Private Sub bt_reculer_Click(sender As Object, e As EventArgs) Handles tsm_framePrecedente.Click
        ' Met la simulstion en pause
        If tsm_play.Enabled = False Then
            tsm_play.Enabled = True
            tsm_pause.Enabled = False
            temps_simulation.Stop()
        End If
        Engine.AppliquerSnapshotPrecedent()
        pbox_plateau.Image = Engine.ImageCourante
        lab_frame.Text = " Frame : " & Engine.numeroFrame
        ' Met à jour le compteur de population
        Me.lab_population.Text = "Population : " & Engine.population

        AjouterAnimation()
    End Sub

    Private Sub bt_enregistrerAnimation_Click(sender As Object, e As EventArgs) Handles bt_enregistrerAnimation.Click

        If bt_enregistrerAnimation.Checked Then

            ' Définit le nom de l'animation
            nomAnimation = DateAndTime.DateString & "_" & DateAndTime.Timer

            'Créer les dossiers
            DossierExiste(dir_documents, True)
            DossierExiste(dir_animations, True)
            DossierExiste(dir_animations & "/" & nomAnimation, True)
            numeroImage = 0

        Else

            'Teste image gif
            Dim templiste As New List(Of String)

            Dim index As Integer = 0
            Do
                If File.Exists(dir_animations & "/" & nomAnimation & "/" & index & ".Jpeg") Then
                    templiste.Add(dir_animations & "/" & nomAnimation & "/" & index & ".Jpeg")
                    index = index + 1
                Else
                    Exit Do
                End If
            Loop
            'On reprend les images
            'For Each _img As String In Directory.GetFiles(dir_animations & "/" & nomAnimation)
            'templiste.Add(_img)
            'Next

            ' templiste = templiste.OrderByDescending(Function(x) x).ToList
            CreerGif(templiste, ".test.gif")
        End If

    End Sub

    Public Sub AjouterAnimation()

        'Si le bouton animation est checked

        If bt_enregistrerAnimation.Checked Then
            If DossierExiste(dir_documents) Then
                If DossierExiste(dir_animations) Then
                    If DossierExiste(dir_animations & "/" & nomAnimation) Then
                        pbox_plateau.Image.Save(dir_animations & "/" & nomAnimation & "/" & numeroImage & ".Jpeg", Imaging.ImageFormat.Png)
                        numeroImage = numeroImage + 1
                    End If
                End If
            End If
        End If

    End Sub

    ''' <summary>
    ''' Définit le bouton pinceaux actif
    ''' </summary>
    ''' <param name="bt">Bouton à activer</param>
    Public Sub BoutonPinceauxActif(ByRef bt As Button)
        For Each ctrl As Button In panel_pinceaux.Controls
            ctrl.BackColor = Color.Transparent
        Next
        bt.BackColor = Color.Silver
    End Sub

    Private Sub bt_pinceauSimple_Click(sender As Object, e As EventArgs) Handles bt_pinceauSimple.Click
        'Sélection du pinceau simple
        PinceauSelectionne = Pinceaux.Simple
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_remplisseur_Click(sender As Object, e As EventArgs) Handles bt_remplisseur.Click
        'Sélection du remplisseur
        PinceauSelectionne = Pinceaux.Remplisseur
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_pinceauLigne_Click(sender As Object, e As EventArgs) Handles bt_pinceauLigne.Click
        'Sélection du pinceau ligne
        PinceauSelectionne = Pinceaux.Ligne
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_pinceauColonne_Click(sender As Object, e As EventArgs) Handles bt_pinceauColonne.Click
        'Sélection du pinceau colonne
        PinceauSelectionne = Pinceaux.Colonne
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_pinceauCroix_Click(sender As Object, e As EventArgs) Handles bt_pinceauCroix.Click
        'Sélection du pinceau croix
        PinceauSelectionne = Pinceaux.Croix
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_pinceauDiagonaleD_Click(sender As Object, e As EventArgs) Handles bt_pinceauDiagonaleD.Click
        'Sélection du pinceau Diagonale droite
        PinceauSelectionne = Pinceaux.DiagonaleD
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_pinceauDiagonaleG_Click(sender As Object, e As EventArgs) Handles bt_pinceauDiagonaleG.Click
        'Sélection du pinceau Diagonale gauche
        PinceauSelectionne = Pinceaux.DiagonaleG
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub bt_pinceauDiagonales_Click(sender As Object, e As EventArgs) Handles bt_pinceauDiagonales.Click
        'Sélection du pinceau Diagonales (croix)
        PinceauSelectionne = Pinceaux.Diagonales
        BoutonPinceauxActif(sender)
    End Sub

    Private Sub tsm_generateurLabyrinthe_Click(sender As Object, e As EventArgs) Handles tsm_generateurLabyrinthe.Click
        GenerateurLabyrinthe.ShowDialog()
    End Sub

    ''' <summary>
    ''' Enregistre tous les paramètres
    ''' </summary>
    Public Sub EnregistrerParametres()

        'Enregistre les paramètres de l'application dans appdata/roaming

        Dim pFile As New ParameterFileReader

        ' Couleurs

        pFile.AddParameter("paramCouleurCases", ColorTranslator.ToHtml(bt_couleurCasesVides.BackColor))
        pFile.AddParameter("paramCouleurCellules", ColorTranslator.ToHtml(bt_couleurCellules.BackColor))
        pFile.AddParameter("paramCouleurGrille", ColorTranslator.ToHtml(bt_couleurGrille.BackColor))
        pFile.AddParameter("paramCouleurMur", ColorTranslator.ToHtml(bt_couleurMur.BackColor))
        pFile.AddParameter("paramCouleurCellulePermanente", ColorTranslator.ToHtml(bt_couleurCellulePermanente.BackColor))

        ' Taille des cases

        pFile.AddParameter("paramTailleCases", num_tailleCases.Value)

        ' Règles

        pFile.AddParameter("paramRegleSurvie0", cbox_survie0.Checked)
        pFile.AddParameter("paramRegleSurvie1", cbox_survie1.Checked)
        pFile.AddParameter("paramRegleSurvie2", cbox_survie2.Checked)
        pFile.AddParameter("paramRegleSurvie3", cbox_survie3.Checked)
        pFile.AddParameter("paramRegleSurvie4", cbox_survie4.Checked)
        pFile.AddParameter("paramRegleSurvie5", cbox_survie5.Checked)
        pFile.AddParameter("paramRegleSurvie6", cbox_survie6.Checked)
        pFile.AddParameter("paramRegleSurvie7", cbox_survie7.Checked)
        pFile.AddParameter("paramRegleSurvie8", cbox_survie8.Checked)
        pFile.AddParameter("paramRegleCreation0", cbox_creation0.Checked)
        pFile.AddParameter("paramRegleCreation1", cbox_creation1.Checked)
        pFile.AddParameter("paramRegleCreation2", cbox_creation2.Checked)
        pFile.AddParameter("paramRegleCreation3", cbox_creation3.Checked)
        pFile.AddParameter("paramRegleCreation4", cbox_creation4.Checked)
        pFile.AddParameter("paramRegleCreation5", cbox_creation5.Checked)
        pFile.AddParameter("paramRegleCreation6", cbox_creation6.Checked)
        pFile.AddParameter("paramRegleCreation7", cbox_creation7.Checked)
        pFile.AddParameter("paramRegleCreation8", cbox_creation8.Checked)

        ' Simulation

        pFile.AddParameter("paramTempsFrame", num_tempsSimulation.Value)
        pFile.AddParameter("paramArretAutomatique", cbox_arreterSimulation.Checked)
        pFile.AddParameter("paramArretFrame", num_arretframe.Value)

        ' Affichage

        pFile.AddParameter("paramAfficherReperes", tsm_utiliserReperes.Checked)
        pFile.AddParameter("paramAfficherPinceaux", tsm_afficherPinceaux.Checked)
        pFile.AddParameter("paramAfficherParametres", tsm_afficherParametres.Checked)
        pFile.AddParameter("paramAfficherStatus", tsm_afficherStatus.Checked)
        pFile.AddParameter("paramAfficherGrille", tsm_afficherGrille.Checked)
        pFile.AddParameter("paramAfficherTexte", tsm_afficherTexte.Checked)
        pFile.AddParameter("paramAfficherBord", tsm_afficherBord.Checked)

        ' Raccourcis

        pFile.AddParameter("paramRaccPinceauSimple", raccPinceauSimple)
        pFile.AddParameter("paramRaccRemplisseur", raccRemplisseur)
        pFile.AddParameter("paramRaccPinceauLigne", raccPinceauLigne)
        pFile.AddParameter("paramRaccPinceauColonne", raccPinceauColonne)
        pFile.AddParameter("paramRaccPinceauCroix", raccPinceauCroix)
        pFile.AddParameter("paramRaccPinceauDiagD", raccPinceauDiagD)
        pFile.AddParameter("paramRaccPinceauDiagG", raccPinceauDiagG)
        pFile.AddParameter("paramRaccPinceauDiagonales", raccPinceauDiagonales)
        pFile.AddParameter("paramRaccSelectionCellule", raccSelectionCellule)
        pFile.AddParameter("paramRaccSelectionVide", raccSelectionVide)
        pFile.AddParameter("paramRaccSelectionMur", raccSelectionMur)
        pFile.AddParameter("paramRaccSelectionCellulePermanente", raccSelectionCellulePermanente)
        pFile.AddParameter("paramRaccModeleRotationDroite", raccModeleRotationDroite)
        pFile.AddParameter("paramRaccModeleRotationGauche", raccModeleRotationGauche)
        pFile.AddParameter("paramRaccModeleSymetrieHorizontale", raccModeleSymetrieHorizontale)
        pFile.AddParameter("paramRaccModeleSymetrieVerticale", raccModeleSymetrieVerticale)
        pFile.AddParameter("paramRaccSimulationDemarrer", raccSimulationDemarrer)
        pFile.AddParameter("paramRaccSimulationArreter", raccSimulationArreter)
        pFile.AddParameter("paramRaccSimulationPause", raccSimulationPause)
        pFile.AddParameter("paramRaccSimulationFrameSuivante", raccSimulationFrameSuivante)
        pFile.AddParameter("paramRaccSimulationFramePrecedente", raccSimulationFramePrecedente)

        ' Texte

        pFile.AddParameter("paramTextePolice", Engine.policeTexte.Name)
        pFile.AddParameter("paramTexteCouleur", ColorTranslator.ToHtml(Engine.couleurTexte))
        pFile.AddParameter("paramTexteTaille", Engine.tailleTexte)
        pFile.AddParameter("paramTextePositionX", Engine.positionTexte.X)
        pFile.AddParameter("paramTextePositionY", Engine.positionTexte.Y)
        pFile.AddParameter("paramTexte", Engine.texte.Replace(vbCrLf, "//n"))
        pFile.AddParameter("paramAfficherFondTexte", Engine.afficherFondTexte)
        pFile.AddParameter("paramCouleurFondTexte", ColorTranslator.ToHtml(Engine.couleurFondTexte))

        ' Ecrire le fichier

        pFile.WriteFile(dir_appdata & "/Paramètres.txt")

    End Sub

    Public Sub ChargerParametres()

        'Teste si le dossier existe

        DossierExiste(dir_appdata)

        'Teste si le fichier existe

        If FichierExiste(dir_appdata & "/Paramètres.txt") Then

            Dim pFile As New ParameterFileReader()
            pFile.ReadFile(dir_appdata & "/Paramètres.txt")

            ' Paramètres des couleurs

            bt_couleurCasesVides.BackColor = ColorTranslator.FromHtml(pFile.GetParameter("paramCouleurCases"))
            bt_couleurCellules.BackColor = ColorTranslator.FromHtml(pFile.GetParameter("paramCouleurCellules"))
            bt_couleurGrille.BackColor = ColorTranslator.FromHtml(pFile.GetParameter("paramCouleurGrille"))
            bt_couleurMur.BackColor = ColorTranslator.FromHtml(pFile.GetParameter("paramCouleurMur"))
            bt_couleurCellulePermanente.BackColor = ColorTranslator.FromHtml(pFile.GetParameter("paramCouleurCellulePermanente"))

            ' Paramètres taille des cases

            num_tailleCases.Value = pFile.GetParameter("paramTailleCases")

            ' Paramètres des règles

            cbox_survie0.Checked = pFile.GetBoolParameter("paramRegleSurvie0")
            cbox_survie1.Checked = pFile.GetBoolParameter("paramRegleSurvie1")
            cbox_survie2.Checked = pFile.GetBoolParameter("paramRegleSurvie2", True)
            cbox_survie3.Checked = pFile.GetBoolParameter("paramRegleSurvie3", True)
            cbox_survie4.Checked = pFile.GetBoolParameter("paramRegleSurvie4")
            cbox_survie5.Checked = pFile.GetBoolParameter("paramRegleSurvie5")
            cbox_survie6.Checked = pFile.GetBoolParameter("paramRegleSurvie6")
            cbox_survie7.Checked = pFile.GetBoolParameter("paramRegleSurvie7")
            cbox_survie8.Checked = pFile.GetBoolParameter("paramRegleSurvie8")
            cbox_creation0.Checked = pFile.GetBoolParameter("paramRegleCreation0")
            cbox_creation1.Checked = pFile.GetBoolParameter("paramRegleCreation1")
            cbox_creation2.Checked = pFile.GetBoolParameter("paramRegleCreation2")
            cbox_creation3.Checked = pFile.GetBoolParameter("paramRegleCreation3", True)
            cbox_creation4.Checked = pFile.GetBoolParameter("paramRegleCreation4")
            cbox_creation5.Checked = pFile.GetBoolParameter("paramRegleCreation5")
            cbox_creation6.Checked = pFile.GetBoolParameter("paramRegleCreation6")
            cbox_creation7.Checked = pFile.GetBoolParameter("paramRegleCreation7")
            cbox_creation8.Checked = pFile.GetBoolParameter("paramRegleCreation8")

            ' Paramètres de simulation

            num_tempsSimulation.Value = pFile.GetIntParameter("paramTempsFrame", 30)
            cbox_arreterSimulation.Checked = pFile.GetBoolParameter("paramArretAutomatique", False)
            num_arretframe.Value = pFile.GetIntParameter("paramArretFrame", 1000)

            ' Paramètres d'affichage

            tsm_utiliserReperes.Checked = pFile.GetBoolParameter("paramAfficherReperes")
            tsm_afficherPinceaux.Checked = pFile.GetBoolParameter("paramAfficherPinceaux")
            tsm_afficherParametres.Checked = pFile.GetBoolParameter("paramAfficherParametres")
            tsm_afficherStatus.Checked = pFile.GetBoolParameter("paramAfficherStatus")
            tsm_afficherGrille.Checked = pFile.GetBoolParameter("paramAfficherGrille")
            tsm_afficherTexte.Checked = pFile.GetBoolParameter("paramAfficherTexte")
            tsm_afficherBord.Checked = pFile.GetBoolParameter("paramAfficherBord")

            ' Raccourcis

            raccPinceauSimple = pFile.GetIntParameter("paramRaccPinceauSimple")
            raccRemplisseur = pFile.GetIntParameter("paramRaccRemplisseur")
            raccPinceauLigne = pFile.GetIntParameter("paramRaccPinceauLigne")
            raccPinceauColonne = pFile.GetIntParameter("paramRaccPinceauColonne")
            raccPinceauCroix = pFile.GetIntParameter("paramRaccPinceauCroix")
            raccPinceauDiagD = pFile.GetIntParameter("paramRaccPinceauDiagD")
            raccPinceauDiagG = pFile.GetIntParameter("paramRaccPinceauDiagG")
            raccPinceauDiagonales = pFile.GetIntParameter("paramRaccPinceauDiagonales")
            raccSelectionCellule = pFile.GetIntParameter("paramRaccSelectionCellule")
            raccSelectionVide = pFile.GetIntParameter("paramRaccSelectionVide")
            raccSelectionMur = pFile.GetIntParameter("paramRaccSelectionMur")
            raccSelectionCellulePermanente = pFile.GetIntParameter("paramRaccSelectionCellulePermanente")
            raccModeleRotationDroite = pFile.GetIntParameter("paramRaccModeleRotationDroite")
            raccModeleRotationGauche = pFile.GetIntParameter("paramRaccModeleRotationGauche")
            raccModeleSymetrieHorizontale = pFile.GetIntParameter("paramRaccModeleSymetrieHorizontale")
            raccModeleSymetrieVerticale = pFile.GetIntParameter("paramRaccModeleSymetrieVerticale")
            raccSimulationDemarrer = pFile.GetIntParameter("paramRaccSimulationDemarrer")
            raccSimulationArreter = pFile.GetIntParameter("paramRaccSimulationArreter")
            raccSimulationPause = pFile.GetIntParameter("paramRaccSimulationPause")
            raccSimulationFrameSuivante = pFile.GetIntParameter("paramRaccSimulationFrameSuivante")
            raccSimulationFramePrecedente = pFile.GetIntParameter("paramRaccSimulationFramePrecedente")

            ' Texte
            Dim tailleTexte As Integer = pFile.GetIntParameter("paramTexteTaille")
            Dim couleurTexte As Color = ColorTranslator.FromHtml(pFile.GetParameter("paramTexteCouleur"))
            Dim policeTexte As String = pFile.GetParameter("paramTextePolice")
            Dim texteBrut As String = pFile.GetParameter("paramTexte") + ""
            Dim positionTexte As Point = New Point(pFile.GetIntParameter("paramTextePositionX"), pFile.GetIntParameter("paramTextePositionY"))
            Engine.ModifierTexte(couleurTexte, New Font(policeTexte, tailleTexte), texteBrut.Replace("//n", vbCrLf), positionTexte)

            Engine.afficherFondTexte = pFile.GetBoolParameter("paramAfficherFondTexte")
            Engine.couleurFondTexte = ColorTranslator.FromHtml(pFile.GetParameter("paramCouleurFondTexte"))

        End If

    End Sub


    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Engine.ArreterThread()
        ' Enregistre les paramètres à la fermeture du programme
        EnregistrerParametres()
    End Sub

    Private Sub bt_reglesParDefaut_Click(sender As Object, e As EventArgs) Handles bt_reglesParDefaut.Click
        ' Remet les paramètres des règles par défaut

        cbox_survie0.Checked = False
        cbox_survie1.Checked = False
        cbox_survie2.Checked = True
        cbox_survie3.Checked = True
        cbox_survie4.Checked = False
        cbox_survie5.Checked = False
        cbox_survie6.Checked = False
        cbox_survie7.Checked = False
        cbox_survie8.Checked = False

        cbox_creation0.Checked = False
        cbox_creation1.Checked = False
        cbox_creation2.Checked = False
        cbox_creation3.Checked = True
        cbox_creation4.Checked = False
        cbox_creation5.Checked = False
        cbox_creation6.Checked = False
        cbox_creation7.Checked = False
        cbox_creation8.Checked = False

    End Sub

    Private Sub Tsm_filtreInverser_Click(sender As Object, e As EventArgs) Handles tsm_filtreInverser.Click
        If Engine.SetMode Then
            Filtre_Inverser()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub Tsm_filtreEpaissir_Click(sender As Object, e As EventArgs) Handles tsm_filtreEpaissir.Click
        FiltreEpaisseur.ShowDialog()
        pbox_plateau.Image = Engine.ImageCourante
    End Sub

    Private Sub Tsm_apropos_Click(sender As Object, e As EventArgs) Handles tsm_apropos.Click
        APropos.Show()
    End Sub

    Public Sub CreerGif(ByVal _liste_image As List(Of String), ByVal _chemin As String)
        'https://www.rickvandenbosch.net/blog/howto-create-an-animated-gif-using-net-c/
        ' Dim StringCollection As Specialized.StringCollection
        Dim MemoryStream As MemoryStream
        Dim BinaryWriter As BinaryWriter
        Dim Img As Bitmap
        Dim buf1() As Byte
        Dim buf2(18) As Byte
        Dim buf3(7) As Byte

        MemoryStream = New MemoryStream()

        buf2(0) = 33
        buf2(1) = 255
        buf2(2) = 11
        buf2(3) = 78
        buf2(4) = 69
        buf2(5) = 84
        buf2(6) = 83
        buf2(7) = 67
        buf2(8) = 65
        buf2(9) = 80
        buf2(10) = 69
        buf2(11) = 50
        buf2(12) = 46
        buf2(13) = 48
        buf2(14) = 3
        buf2(15) = 1
        buf2(16) = 0
        buf2(17) = 0
        buf2(18) = 0


        buf3(0) = 33
        buf3(1) = 249
        buf3(2) = 4 ' Taille de block
        buf3(3) = 9
        buf3(4) = 0.2 ' Délai
        buf3(5) = 0.1 ' Délai
        buf3(6) = 255
        buf3(7) = 0

        'Flux de sortie
        Dim fs As Stream = New FileStream(_chemin, FileMode.Create)
        BinaryWriter = New BinaryWriter(fs)

        For compteurImage As Integer = 0 To _liste_image.Count - 1

            Img = New Bitmap(SafeImageFromFile(_liste_image(compteurImage)))

            Img.Save(MemoryStream, Imaging.ImageFormat.Gif)

            buf1 = MemoryStream.ToArray()

            Img.Dispose()


            'On écrit l'entête en premier et une seule fois
            If compteurImage = 0 Then
                BinaryWriter.Write(buf1, 0, 781)
                BinaryWriter.Write(buf2, 0, 18)
            End If

            BinaryWriter.Write(buf3, 0, 7)
            BinaryWriter.Write(buf1, 789, buf1.Length - 790)

            'On écrit le terminateur d'image à la fin
            If compteurImage = _liste_image.Count - 1 Then
                BinaryWriter.Write(";")
            End If

            MemoryStream.SetLength(0)

        Next
        BinaryWriter.Close()
        MemoryStream.Close()

    End Sub

    Private Sub tsm_parametresAnimation_Click(sender As Object, e As EventArgs) Handles tsm_parametresAnimation.Click

        'Défini les paramètres actuels
        ParametresAnimation.cbox_enregistrerchaqueframe.Checked = creerChaqueImage
        ParametresAnimation.cbox_formatImage.SelectedIndex = formatImage

        ParametresAnimation.cbox_creerGif.Checked = creerGifAnime
        ParametresAnimation.num_delai.Value = delaiGif

        ParametresAnimation.ShowDialog()

    End Sub

    Public Shared Function SafeImageFromFile(path As String) As Image
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function

    Public Sub CreerFichierBin(ByVal _liste_image As List(Of String), ByVal _chemin As String)
        'https://www.rickvandenbosch.net/blog/howto-create-an-animated-gif-using-net-c/
        ' Dim StringCollection As Specialized.StringCollection
        Dim MemoryStream As MemoryStream
        Dim BinaryWriter As BinaryWriter

        'Contenu du plateau de jeu
        Dim buf1() As Byte

        'Informations d'entête
        Dim buf2(8) As Byte

        MemoryStream = New MemoryStream()

        ' Entête de fichier

        'Extension
        buf2(0) = 90 ' Z
        buf2(1) = 74 ' J
        buf2(2) = 68 ' D
        buf2(3) = 76 ' L
        buf2(4) = 86 ' V

        buf2(5) = 0 ' Taille en largeur octet 1
        buf2(6) = 0 ' Taille en largeur octet 2
        buf2(7) = 0 ' Taille en hauteur octet 1
        buf2(8) = 0 ' Taille en hauteur octet 2

        'Taille du block pour contenu (largeur x hauteur ==> binaire sur 8 octets)
        buf2(9) = 0
        buf2(10) = 0
        buf2(11) = 0
        buf2(12) = 0
        buf2(13) = 0
        buf2(14) = 0
        buf2(15) = 0
        buf2(16) = 0

        ' Ajout du contenu dans une liste
        Dim temp_liste As New List(Of Boolean)
        For x As Integer = 1 To Engine.TaillePlateau.Width
            For y As Integer = 1 To Engine.TaillePlateau.Height
                temp_liste.Add(Engine.GetCellValue(x, y))
            Next
        Next

        'Flux de sortie
        Dim fs As Stream = New FileStream(_chemin, FileMode.Create)
        BinaryWriter = New BinaryWriter(fs)

        For compteurImage As Integer = 0 To _liste_image.Count - 1

            buf1 = MemoryStream.ToArray()





            ' Ecrit l'entete du fichier
            BinaryWriter.Write(buf2, 0, 18)



            BinaryWriter.Write(buf1, 789, buf1.Length - 790)

            'On écrit le terminateur d'image à la fin
            If compteurImage = _liste_image.Count - 1 Then
                BinaryWriter.Write(";")
            End If

            MemoryStream.SetLength(0)

        Next
        BinaryWriter.Close()
        MemoryStream.Close()
    End Sub

    Private Sub EditeurExceptionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ExceptionsEdition.ShowDialog()
    End Sub

    Private Sub bt_exceptions_Click(sender As Object, e As EventArgs) Handles bt_exceptions.Click
        Exceptions.Show()
    End Sub


    Private Sub bt_couleurMur_Click(sender As Object, e As EventArgs) Handles bt_couleurMur.Click
        choixCouleur.Color = bt_couleurMur.BackColor
        Dim resultat As DialogResult = choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurMur.BackColor = choixCouleur.Color
        End If
    End Sub

    'Private Sub bt_pinceauMur_Click(sender As Object, e As EventArgs) Handles bt_pinceauModele.Click
    '    'Sélection du pinceau Diagonales (croix)
    '    PinceauSelectionne = Pinceaux.Mur
    '    BoutonPinceauxActif(sender)
    'End Sub

    Private Sub tsm_cellule_Click(sender As Object, e As EventArgs) Handles tsm_cellule.Click
        ValeurEdition = 1
        tsm_objets.Image = My.Resources.editioncellule
    End Sub

    Private Sub tsm_vide_Click(sender As Object, e As EventArgs) Handles tsm_vide.Click
        ValeurEdition = 0
        tsm_objets.Image = My.Resources.editionvide
    End Sub

    Private Sub tsm_mur_Click(sender As Object, e As EventArgs) Handles tsm_mur.Click
        ValeurEdition = 2
        tsm_objets.Image = My.Resources.pinceau_mur_perso
    End Sub

    Private Sub tsm_filtreMelanger_Click(sender As Object, e As EventArgs) Handles tsm_filtreMelanger.Click
        FiltreMelanger.ShowDialog()
        pbox_plateau.Image = Engine.ImageCourante
    End Sub


    Private Sub tsm_enregistrerModele_Click(sender As Object, e As EventArgs) Handles tsm_enregistrerModele.Click
        EnregistrerModele.ShowDialog()
    End Sub

    Public Sub ActualiserListeModele()
        CreerModeles()
        ChargerFichiersModele()
        cbox_filtre.Items.Clear()
        cbox_filtre.Items.Add("Tout")
        For Each _modele As Modele In panel_modeles.Controls
            If Not IsNothing(_modele.liste_tags) Then
                For Each _tag As String In _modele.liste_tags
                    If Not cbox_filtre.Items.Contains(_tag) Then
                        cbox_filtre.Items.Add(_tag)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub cbox_filtre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_filtre.SelectedIndexChanged
        If cbox_filtre.SelectedItem = "Tout" Then
            For Each _modele As Modele In panel_modeles.Controls
                _modele.Visible = True
            Next
        Else
            For Each _modele As Modele In panel_modeles.Controls
                If Not IsNothing(_modele.liste_tags) Then
                    If _modele.liste_tags.Contains(cbox_filtre.SelectedItem) Then
                        _modele.Visible = True
                    Else
                        _modele.Visible = False
                    End If
                Else
                    _modele.Visible = False
                End If
            Next
        End If

    End Sub

    Private Sub tsm_utiliserReperes_Click(sender As Object, e As EventArgs) Handles tsm_utiliserReperes.CheckedChanged
        Engine.utiliserReperes = tsm_utiliserReperes.Checked
    End Sub

    Private Sub pbox_plateau_Click(sender As Object, e As EventArgs) Handles pbox_plateau.Click

    End Sub

    Private Sub tsm_cellulePermanente_Click(sender As Object, e As EventArgs) Handles tsm_cellulePermanente.Click
        ValeurEdition = 3
        tsm_objets.Image = My.Resources.cellule_permanente
    End Sub

    Private Sub tsm_afficherGrille_Click(sender As Object, e As EventArgs) Handles tsm_afficherGrille.CheckedChanged
        Engine.afficherGrille = tsm_afficherGrille.Checked
        Engine.ToutRedessiner()
        pbox_plateau.Image = Engine.ImageCourante
    End Sub

    Private Sub tsm_afficherPinceaux_Click(sender As Object, e As EventArgs) Handles tsm_afficherPinceaux.CheckedChanged
        panel_pinceaux.Visible = tsm_afficherPinceaux.Checked
    End Sub

    Private Sub tsm_afficherParametres_Click(sender As Object, e As EventArgs) Handles tsm_afficherParametres.CheckedChanged
        panel_outils.Visible = tsm_afficherParametres.Checked
    End Sub

    Private Sub tsm_afficherStatus_Click(sender As Object, e As EventArgs) Handles tsm_afficherStatus.CheckedChanged
        ss_info.Visible = tsm_afficherStatus.Checked
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Gestion des raccourcis clavier (hors raccourci avec touche F)

        Select Case e.KeyCode
            Case raccPinceauSimple      ' Touche 1 ==> Sélection pinceau simple
                bt_pinceauSimple.PerformClick()
            Case raccRemplisseur        ' Touche 2 ==> Sélection remplisseur
                bt_remplisseur.PerformClick()
            Case raccPinceauLigne       ' Touche 3 ==> Sélection pinceau ligne
                bt_pinceauLigne.PerformClick()
            Case raccPinceauColonne     ' Touche 4 ==> Sélection pinceau colonne
                bt_pinceauColonne.PerformClick()
            Case raccPinceauCroix       ' Touche 5 ==> Sélection pinceau croix
                bt_pinceauCroix.PerformClick()
            Case raccPinceauDiagD       ' Touche 6 ==> Sélection pinceau Diagonale D
                bt_pinceauDiagonaleD.PerformClick()
            Case raccPinceauDiagG       ' Touche 7 ==> Sélection pinceau Diagonale G
                bt_pinceauDiagonaleG.PerformClick()
            Case raccPinceauDiagonales
                bt_pinceauDiagonales.PerformClick()
            Case raccSelectionCellule
                tsm_cellule.PerformClick()
            Case raccSelectionVide
                tsm_vide.PerformClick()
            Case raccSelectionMur
                tsm_mur.PerformClick()
            Case raccSelectionCellulePermanente
                tsm_cellulePermanente.PerformClick()
            Case raccModeleRotationGauche
                tsm_rotationModeleGauche.PerformClick()
            Case raccModeleRotationDroite
            Case raccModeleSymetrieHorizontale
            Case raccModeleSymetrieVerticale

            Case raccSimulationDemarrer
                tsm_play.PerformClick()
            Case raccSimulationArreter
                tsm_stop.PerformClick()
            Case raccSimulationPause
                tsm_pause.PerformClick()
            Case raccSimulationFrameSuivante
                tsm_framesuivante.PerformClick()
            Case raccSimulationFramePrecedente
                tsm_framePrecedente.PerformClick()
        End Select

    End Sub

    Private Sub tsm_raccourcis_Click(sender As Object, e As EventArgs) Handles tsm_raccourcis.Click
        Raccourcis.Show()
    End Sub

    Private Sub tsm_themeSombre_Click(sender As Object, e As EventArgs) Handles tsm_themeSombre.Click
        ' Définition du thème sombre muhahahaha diabolique
        Dim bc1 As Color = Color.Black
        Dim fc1 As Color = Color.White

        ' ouai c'est compliqué enfaite....
        Menu.BackColor = bc1
        Menu.ForeColor = fc1
        For Each _menu As ToolStripMenuItem In Menu.Items
            For Each _sousMenu As ToolStripItem In _menu.DropDownItems
                _sousMenu.BackColor = bc1
                _sousMenu.ForeColor = fc1
            Next
        Next
    End Sub

    Private Sub tsm_quitter_Click(sender As Object, e As EventArgs) Handles tsm_quitter.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsm_modeleRotationDroite.Click
        ' Code rotation pour modèles
        ' Avec putain de liste de nom de dieu
        liste_modele = RotationDroiteModele(modeleLargeur, modeleHauteur, liste_modele)
        Dim temp As Integer
        temp = modeleHauteur
        modeleHauteur = modeleLargeur
        modeleLargeur = temp
        ' liste_modele.Reverse()
    End Sub

    ''' <summary>
    ''' Permet d'effectuer une rotation du modèle à 90° vers la droite
    ''' </summary>
    ''' <param name="_largeur">Largeur du modèle</param>
    ''' <param name="_hauteur">Hauteur du modèle</param>
    ''' <param name="_liste">Liste des boolean du modèle</param>
    ''' <returns></returns>
    Public Function RotationDroiteModele(ByVal _largeur As Integer, ByVal _hauteur As Integer, ByVal _liste As List(Of Boolean))
        Dim liste_symetrie As New List(Of Boolean)


        For y As Integer = _hauteur To 1 Step -1
            For x As Integer = 1 To _largeur Step +1

                If _liste(x * _hauteur - _hauteur + y - 1) = True Then
                    liste_symetrie.Add(True)
                Else
                    liste_symetrie.Add(False)
                End If

            Next
        Next
        Return liste_symetrie
    End Function

    ''' <summary>
    ''' Permet d'effectuer une rotation du modèle à 90° vers la droite
    ''' </summary>
    ''' <param name="_largeur">Largeur du modèle</param>
    ''' <param name="_hauteur">Hauteur du modèle</param>
    ''' <param name="_liste">Liste des boolean du modèle</param>
    ''' <returns></returns>
    Public Function RotationGaucheModele(ByVal _largeur As Integer, ByVal _hauteur As Integer, ByVal _liste As List(Of Boolean))
        Dim liste_symetrie As New List(Of Boolean)


        For y As Integer = _hauteur To 1 Step -1
            For x As Integer = 1 To _largeur Step +1

                If _liste(x * _hauteur - _hauteur + y - 1) = True Then
                    liste_symetrie.Add(True)
                Else
                    liste_symetrie.Add(False)
                End If

            Next
        Next
        Return liste_symetrie

    End Function

    Public Function SymetrieVerticaleModele(ByVal _largeur As Integer, ByVal _hauteur As Integer, ByVal _liste As List(Of Boolean))
        Dim liste_symetrie As New List(Of Boolean)

        For x As Integer = _largeur To 1 Step -1
            For y As Integer = 1 To _hauteur
                If _liste(y * _largeur - _largeur + x - 1) = True Then
                    liste_symetrie.Add(True)
                Else
                    liste_symetrie.Add(False)
                End If

            Next
        Next
        Return liste_symetrie
    End Function

    Private Sub tsm_nouveau_Click(sender As Object, e As EventArgs) Handles tsm_nouveau.Click
        'Applique les paramètres existants
        ParametresPlateau.num_largeur.Value = Engine.TaillePlateau.Width
        ParametresPlateau.num_hauteur.Value = Engine.TaillePlateau.Height
        ParametresPlateau.num_tailleCases.Value = Engine.TailleCases

        'Ouvre la fenêtre de paramètres
        ParametresPlateau.ShowDialog()

    End Sub

    Private Sub bt_modifierTexte_Click(sender As Object, e As EventArgs) Handles bt_modifierTexte.Click
        EditeurDeTexte.txtb_contenu.Text = Engine.texte
        EditeurDeTexte.cbox_police.SelectedItem = Engine.policeTexte.Name
        EditeurDeTexte.num_tailleTexte.Value = Engine.tailleTexte
        EditeurDeTexte.bt_couleurTexte.BackColor = Engine.couleurTexte
        EditeurDeTexte.cbox_afficherFond.Checked = Engine.afficherFondTexte
        EditeurDeTexte.bt_couleurFond.BackColor = Engine.couleurFondTexte
        EditeurDeTexte.ShowDialog()
    End Sub

    Private Sub tsm_afficherTexte_CheckedChanged(sender As Object, e As EventArgs) Handles tsm_afficherTexte.CheckedChanged
        Engine.afficherTexte = tsm_afficherTexte.Checked
    End Sub

    Private Sub num_textePositionX_ValueChanged(sender As Object, e As EventArgs) Handles num_textePositionX.ValueChanged
        Engine.positionTexte.X = num_textePositionX.Value
    End Sub

    Private Sub num_textePositionY_ValueChanged(sender As Object, e As EventArgs) Handles num_textePositionY.ValueChanged
        Engine.positionTexte.Y = num_textePositionY.Value
    End Sub

    Private Sub bt_couleurCasesVides_BackColorChanged(sender As Object, e As EventArgs) Handles bt_couleurCasesVides.BackColorChanged
        If Not IsNothing(Engine) Then
            Engine.couleurCaseVide = bt_couleurCasesVides.BackColor
            Engine.ToutRedessiner()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub bt_couleurCellules_BackColorChanged(sender As Object, e As EventArgs) Handles bt_couleurCellules.BackColorChanged
        If Not IsNothing(Engine) Then
            Engine.couleurCellule = bt_couleurCellules.BackColor
            Engine.ToutRedessiner()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub bt_couleurGrille_BackColorChanged(sender As Object, e As EventArgs) Handles bt_couleurGrille.BackColorChanged
        If Not IsNothing(Engine) Then
            Engine.couleurGrille = bt_couleurGrille.BackColor
            Engine.ToutRedessiner()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub bt_couleurMur_BackColorChanged(sender As Object, e As EventArgs) Handles bt_couleurMur.BackColorChanged
        If Not IsNothing(Engine) Then
            Engine.couleurMur = bt_couleurMur.BackColor
            Engine.ToutRedessiner()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub tsm_afficherBord_CheckedChanged(sender As Object, e As EventArgs) Handles tsm_afficherBord.CheckedChanged
        If tsm_afficherBord.Checked Then
            pbox_plateau.BorderStyle = BorderStyle.FixedSingle
        Else
            pbox_plateau.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub bt_couleurCellulePermanente_Click(sender As Object, e As EventArgs) Handles bt_couleurCellulePermanente.Click
        choixCouleur.Color = bt_couleurCellulePermanente.BackColor
        Dim resultat As DialogResult = choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurCellulePermanente.BackColor = choixCouleur.Color
        End If
    End Sub

    Private Sub bt_couleurCellulePermanente_BackColorChanged(sender As Object, e As EventArgs) Handles bt_couleurCellulePermanente.BackColorChanged
        If Not IsNothing(Engine) Then
            Engine.couleurCellulePermanente = bt_couleurCellulePermanente.BackColor
            Engine.ToutRedessiner()
            pbox_plateau.Image = Engine.ImageCourante
        End If
    End Sub

    Private Sub tsm_0Thread_Click(sender As Object, e As EventArgs) Handles tsm_0Thread.Click
        If Engine.SetMode Then
            tsm_0Thread.Checked = True
            tsm_1Thread.Checked = False
            tsm_2Thread.Checked = False
            tsm_4Thread.Checked = False
        End If
    End Sub

    Private Sub tsm_0Thread_CheckedChanged(sender As Object, e As EventArgs) Handles tsm_0Thread.CheckedChanged
        If tsm_0Thread.Checked Then
            Engine.nombreThread = JDLVEngine.NOMBRE_THREAD.AUCUN
        End If
    End Sub

    Private Sub tsm_1Thread_Click(sender As Object, e As EventArgs) Handles tsm_1Thread.Click
        If Engine.SetMode Then
            tsm_0Thread.Checked = False
            tsm_1Thread.Checked = True
            tsm_2Thread.Checked = False
            tsm_4Thread.Checked = False
        End If
    End Sub

    Private Sub tsm_1Thread_CheckedChanged(sender As Object, e As EventArgs) Handles tsm_1Thread.CheckedChanged
        If tsm_1Thread.Checked Then
            Engine.nombreThread = JDLVEngine.NOMBRE_THREAD.THREAD_1
        End If
    End Sub

    Private Sub tsm_2Thread_Click(sender As Object, e As EventArgs) Handles tsm_2Thread.Click
        If Engine.SetMode Then
            tsm_0Thread.Checked = False
            tsm_1Thread.Checked = False
            tsm_2Thread.Checked = True
            tsm_4Thread.Checked = False
        End If
    End Sub

    Private Sub tsm_2Thread_CheckedChanged(sender As Object, e As EventArgs) Handles tsm_2Thread.CheckedChanged
        If tsm_2Thread.Checked Then
            Engine.nombreThread = JDLVEngine.NOMBRE_THREAD.THREAD_2
        End If
    End Sub

    Private Sub tsm_4Thread_Click(sender As Object, e As EventArgs) Handles tsm_4Thread.Click
        If Engine.SetMode Then
            tsm_0Thread.Checked = False
            tsm_1Thread.Checked = False
            tsm_2Thread.Checked = False
            tsm_4Thread.Checked = True
        End If
    End Sub

    Private Sub tsm_4Thread_CheckedChanged(sender As Object, e As EventArgs) Handles tsm_4Thread.CheckedChanged
        If tsm_4Thread.Checked Then
            Engine.nombreThread = JDLVEngine.NOMBRE_THREAD.THREAD_4
        End If
    End Sub

    Private Sub bt_commande_Click(sender As Object, e As EventArgs) Handles bt_commande.Click
        ' Exécute la commande
        ExecuterCommande(txtb_commande.Text)
        txtb_commande.Clear()
        If Not cbox_commandeGarder.Checked Then
            panel_commandes.Visible = False
        End If

    End Sub

    Public Sub ExecuterCommande(ByVal _commande As String)
        If _commande <> "" Then
            Dim commande As String = GetCommandName(_commande)
            Select Case commande
                Case "Set"
                    Engine.GetCellValue(GetParameter(_commande, 1), GetParameter(_commande, 2)) = GetParameter(_commande, 3)
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Récupère un paramètre dans une commande
    ''' </summary>
    ''' <param name="command">Commande</param>
    ''' <param name="parameternumber">Numéro de paramètre</param>
    ''' <returns>Valeur du paramètre</returns>
    Function GetParameter(ByVal command As String, ByVal parameternumber As Integer) As String

        Dim ParametreFinal As String = ""
        Dim options As RegexOptions = RegexOptions.Multiline
        Dim _parameters As MatchCollection = Regex.Matches(command, "[^,()]+", options)
        If _parameters.Count > parameternumber Then
            ParametreFinal = _parameters.Item(parameternumber).Value
        End If

        ''Test
        'Select Case ParametreFinal
        '    Case "currentselection"
        '        ParametreFinal = Main.ValeurEditeur
        '    Case "var1"
        '        ParametreFinal = Main.macroVar1
        '    Case "var2"
        '        ParametreFinal = Main.macroVar2
        '    Case "var3"
        '        ParametreFinal = Main.macroVar3
        '    Case "var4"
        '        ParametreFinal = Main.macroVar4
        '    Case "var5"
        '        ParametreFinal = Main.macroVar5
        '    Case "var6"
        '        ParametreFinal = Main.macroVar6
        '    Case "var7"
        '        ParametreFinal = Main.macroVar7
        '    Case "var8"
        '        ParametreFinal = Main.macroVar8
        '    Case "var9"
        '        ParametreFinal = Main.macroVar9
        '    Case "var10"
        '        ParametreFinal = Main.macroVar10
        'End Select
        If ParametreFinal = "" Then
            ParametreFinal = 0
        End If
        If IsNothing(ParametreFinal) Then
            Return 0
        Else
            Return ParametreFinal
        End If

    End Function

    ''' <summary>
    ''' Récupère le nom d'une commande (sans ses parenthèses et ses paramètres)
    ''' </summary>
    ''' <param name="command">Commande</param>
    ''' <returns>Nom de la commande</returns>
    Function GetCommandName(ByVal command As String)
        Return command.Substring(0, command.IndexOf("("))
    End Function

    Private Sub tsm_commande_Click(sender As Object, e As EventArgs) Handles tsm_commande.Click
        panel_commandes.Visible = True
    End Sub

    Private Sub tsm_enregistrerLIF_Click(sender As Object, e As EventArgs) Handles tsm_enregistrerLIF.Click
        If Engine.TaillePlateau.Width <= 80 Then
            If Engine.TaillePlateau.Height <= 80 Then
                form_EnregistrerLife.ShowDialog()
            Else
                MsgBox("Vous ne pouvez pas enregistrer en format de fichier Life si la hauteur du plateau dépasse les 80 cases")

            End If
        Else
            MsgBox("Vous ne pouvez pas enregistrer en format de fichier Life si la largeur du plateau dépasse les 80 cases")

        End If


    End Sub

    Private Sub tsm_stopKeep_Click(sender As Object, e As EventArgs) Handles tsm_stopKeep.Click
        'Quitte le mode simulation en gardant la config plateau
        Engine.SetMode(True) = True
        'Mets fin à la simulation
        tsm_play.Enabled = True
        tsm_pause.Enabled = False
        tsm_framesuivante.Enabled = True
        tsm_stop.Enabled = False
        tsm_stopKeep.Enabled = False
        temps_simulation.Stop()
        'Engine.ReinitialiserPlateau()
        pbox_plateau.Image = Engine.ImageCourante
        Engine.numeroFrame = 0
        lab_frame.Text = " Frame : " & Engine.numeroFrame
    End Sub

    Private Sub tsm_conserver_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub tsm_ouvrirFichierLife_Click(sender As Object, e As EventArgs) Handles tsm_ouvrirFichierLife.Click
        ' Ouvrir un fichier Lif
        dialogOuvrirFichier.Title = "Ouvrir un fichier Life .LIF"
        Dim res As DialogResult = dialogOuvrirFichier.ShowDialog
        If res = DialogResult.OK Then

            Engine.OuvrirFichierLife(dialogOuvrirFichier.FileName)

        End If

    End Sub
End Class
