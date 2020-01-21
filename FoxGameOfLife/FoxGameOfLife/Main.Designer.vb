<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel_contenu = New System.Windows.Forms.Panel()
        Me.pbox_plateau = New System.Windows.Forms.PictureBox()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.tsm_fichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_nouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_enregistrersous = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_enregistrerModele = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_enregistrerImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_enregistrerLIF = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_ouvrirFichierLife = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_enregistrerpreset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_repertoires = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_repertoireFichiers = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_repertoireAnimations = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_repertoireImages = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_quitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_filtres = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_filtreInverser = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_filtreMelanger = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_filtreSymetrie = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_filtreEpaissir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_presets = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_rechargerPresets = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_mesPresets = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_outils = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_generateurLabyrinthe = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_commande = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_affichage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_afficherPinceaux = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_afficherParametres = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_afficherStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_utiliserReperes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_afficherGrille = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_afficherTexte = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_afficherBord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_themeSombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_parametres = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_reinitialiserParametres = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_raccourcis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_nombreThread = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_0Thread = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_1Thread = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_2Thread = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_4Thread = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_plus = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_aide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.NoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_apropos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_outils = New System.Windows.Forms.ToolStrip()
        Me.tsm_objets = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsm_cellule = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_vide = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_mur = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_cellulePermanente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_play = New System.Windows.Forms.ToolStripButton()
        Me.tsm_framePrecedente = New System.Windows.Forms.ToolStripButton()
        Me.tsm_pause = New System.Windows.Forms.ToolStripButton()
        Me.tsm_framesuivante = New System.Windows.Forms.ToolStripButton()
        Me.tsm_stop = New System.Windows.Forms.ToolStripButton()
        Me.tsm_stopKeep = New System.Windows.Forms.ToolStripButton()
        Me.bt_enregistrerAnimation = New System.Windows.Forms.ToolStripButton()
        Me.sep_animation = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_parametresAnimation = New System.Windows.Forms.ToolStripButton()
        Me.tsm_effacer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsm_modeleRotationDroite = New System.Windows.Forms.ToolStripButton()
        Me.tsm_rotationModeleGauche = New System.Windows.Forms.ToolStripButton()
        Me.tsm_modeleSymetrieHorizontale = New System.Windows.Forms.ToolStripButton()
        Me.tsm_modèleSymetrieVerticale = New System.Windows.Forms.ToolStripButton()
        Me.temps_simulation = New System.Windows.Forms.Timer(Me.components)
        Me.panel_outils = New System.Windows.Forms.Panel()
        Me.tab_contenu = New System.Windows.Forms.TabControl()
        Me.tab_ = New System.Windows.Forms.TabPage()
        Me.bt_couleurCellulePermanente = New System.Windows.Forms.Button()
        Me.lab_couleurCellulePermanente = New System.Windows.Forms.Label()
        Me.lab_textePositionY = New System.Windows.Forms.Label()
        Me.num_textePositionY = New System.Windows.Forms.NumericUpDown()
        Me.lab_textePositionX = New System.Windows.Forms.Label()
        Me.num_textePositionX = New System.Windows.Forms.NumericUpDown()
        Me.bt_modifierTexte = New System.Windows.Forms.Button()
        Me.lab_texte = New System.Windows.Forms.Label()
        Me.bt_couleurMur = New System.Windows.Forms.Button()
        Me.lab_couleurMur = New System.Windows.Forms.Label()
        Me.bt_exceptions = New System.Windows.Forms.Button()
        Me.bt_reglesParDefaut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_arretframe = New System.Windows.Forms.NumericUpDown()
        Me.cbox_arreterSimulation = New System.Windows.Forms.CheckBox()
        Me.lab_tempsSimulation = New System.Windows.Forms.Label()
        Me.num_tempsSimulation = New System.Windows.Forms.NumericUpDown()
        Me.lab_simulation = New System.Windows.Forms.Label()
        Me.num_tailleCases = New System.Windows.Forms.NumericUpDown()
        Me.lab_tailleCase = New System.Windows.Forms.Label()
        Me.cbox_creation8 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation7 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation6 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation5 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation4 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation3 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation2 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation1 = New System.Windows.Forms.CheckBox()
        Me.cbox_creation0 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_survie8 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie7 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie6 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie5 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie4 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie3 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie2 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie1 = New System.Windows.Forms.CheckBox()
        Me.cbox_survie0 = New System.Windows.Forms.CheckBox()
        Me.lab_survie = New System.Windows.Forms.Label()
        Me.lab_regles = New System.Windows.Forms.Label()
        Me.bt_couleurGrille = New System.Windows.Forms.Button()
        Me.bt_couleurCellules = New System.Windows.Forms.Button()
        Me.bt_couleurCasesVides = New System.Windows.Forms.Button()
        Me.lab_affichage = New System.Windows.Forms.Label()
        Me.lab_couleurGrille = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lab_couleurCase = New System.Windows.Forms.Label()
        Me.tab_edition = New System.Windows.Forms.TabPage()
        Me.panel_modeles = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel_pince = New System.Windows.Forms.Panel()
        Me.lab_modeles_taille = New System.Windows.Forms.Label()
        Me.lab_filtre = New System.Windows.Forms.Label()
        Me.cbox_filtre = New System.Windows.Forms.ComboBox()
        Me.lab_modeles = New System.Windows.Forms.Label()
        Me.choixCouleur = New System.Windows.Forms.ColorDialog()
        Me.panel_pinceaux = New System.Windows.Forms.FlowLayoutPanel()
        Me.bt_pinceauSimple = New System.Windows.Forms.Button()
        Me.bt_remplisseur = New System.Windows.Forms.Button()
        Me.bt_pinceauLigne = New System.Windows.Forms.Button()
        Me.bt_pinceauColonne = New System.Windows.Forms.Button()
        Me.bt_pinceauCroix = New System.Windows.Forms.Button()
        Me.bt_pinceauDiagonaleD = New System.Windows.Forms.Button()
        Me.bt_pinceauDiagonaleG = New System.Windows.Forms.Button()
        Me.bt_pinceauDiagonales = New System.Windows.Forms.Button()
        Me.cmenu_Modeles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsm_supprimerModele = New System.Windows.Forms.ToolStripMenuItem()
        Me.ss_info = New System.Windows.Forms.StatusStrip()
        Me.tss_coord = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lab_population = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lab_tempsGeneration = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lab_frame = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panel_commandes = New System.Windows.Forms.Panel()
        Me.cbox_commandeGarder = New System.Windows.Forms.CheckBox()
        Me.bt_commande = New System.Windows.Forms.Button()
        Me.txtb_commande = New System.Windows.Forms.TextBox()
        Me.dialogOuvrirFichier = New System.Windows.Forms.OpenFileDialog()
        Me.panel_contenu.SuspendLayout()
        CType(Me.pbox_plateau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.menu_outils.SuspendLayout()
        Me.panel_outils.SuspendLayout()
        Me.tab_contenu.SuspendLayout()
        Me.tab_.SuspendLayout()
        CType(Me.num_textePositionY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_textePositionX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_arretframe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tempsSimulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tailleCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_edition.SuspendLayout()
        Me.panel_pince.SuspendLayout()
        Me.panel_pinceaux.SuspendLayout()
        Me.cmenu_Modeles.SuspendLayout()
        Me.ss_info.SuspendLayout()
        Me.panel_commandes.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_contenu
        '
        Me.panel_contenu.AutoScroll = True
        Me.panel_contenu.AutoScrollMargin = New System.Drawing.Size(200, 200)
        Me.panel_contenu.BackColor = System.Drawing.Color.Silver
        Me.panel_contenu.Controls.Add(Me.pbox_plateau)
        Me.panel_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_contenu.Location = New System.Drawing.Point(31, 55)
        Me.panel_contenu.Margin = New System.Windows.Forms.Padding(200)
        Me.panel_contenu.Name = "panel_contenu"
        Me.panel_contenu.Size = New System.Drawing.Size(653, 525)
        Me.panel_contenu.TabIndex = 1
        '
        'pbox_plateau
        '
        Me.pbox_plateau.BackColor = System.Drawing.Color.AliceBlue
        Me.pbox_plateau.Location = New System.Drawing.Point(12, 12)
        Me.pbox_plateau.Name = "pbox_plateau"
        Me.pbox_plateau.Size = New System.Drawing.Size(201, 218)
        Me.pbox_plateau.TabIndex = 0
        Me.pbox_plateau.TabStop = False
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.Silver
        Me.Menu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_fichier, Me.tsm_filtres, Me.tsm_presets, Me.tsm_outils, Me.tsm_affichage, Me.tsm_parametres, Me.tsm_plus})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu.Size = New System.Drawing.Size(976, 24)
        Me.Menu.TabIndex = 2
        Me.Menu.Text = "MenuStrip1"
        '
        'tsm_fichier
        '
        Me.tsm_fichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_nouveau, Me.ToolStripSeparator9, Me.tsm_enregistrersous, Me.tsm_enregistrerModele, Me.tsm_enregistrerImage, Me.tsm_enregistrerLIF, Me.tsm_ouvrirFichierLife, Me.ToolStripSeparator5, Me.tsm_enregistrerpreset, Me.ToolStripSeparator3, Me.tsm_repertoires, Me.ToolStripSeparator4, Me.tsm_quitter})
        Me.tsm_fichier.Name = "tsm_fichier"
        Me.tsm_fichier.Size = New System.Drawing.Size(54, 20)
        Me.tsm_fichier.Text = "Fichier"
        '
        'tsm_nouveau
        '
        Me.tsm_nouveau.Image = Global.FoxGameOfLife.My.Resources.Resources.nouveau
        Me.tsm_nouveau.Name = "tsm_nouveau"
        Me.tsm_nouveau.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsm_nouveau.Size = New System.Drawing.Size(239, 30)
        Me.tsm_nouveau.Text = "Nouveau"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(236, 6)
        '
        'tsm_enregistrersous
        '
        Me.tsm_enregistrersous.Enabled = False
        Me.tsm_enregistrersous.Image = Global.FoxGameOfLife.My.Resources.Resources.sauvegarder
        Me.tsm_enregistrersous.Name = "tsm_enregistrersous"
        Me.tsm_enregistrersous.Size = New System.Drawing.Size(239, 30)
        Me.tsm_enregistrersous.Text = "Enregistrer sous..."
        '
        'tsm_enregistrerModele
        '
        Me.tsm_enregistrerModele.Image = Global.FoxGameOfLife.My.Resources.Resources.sauvegardermodele
        Me.tsm_enregistrerModele.Name = "tsm_enregistrerModele"
        Me.tsm_enregistrerModele.Size = New System.Drawing.Size(239, 30)
        Me.tsm_enregistrerModele.Text = "Enregistrer comme modèle"
        '
        'tsm_enregistrerImage
        '
        Me.tsm_enregistrerImage.Image = Global.FoxGameOfLife.My.Resources.Resources.image
        Me.tsm_enregistrerImage.Name = "tsm_enregistrerImage"
        Me.tsm_enregistrerImage.Size = New System.Drawing.Size(239, 30)
        Me.tsm_enregistrerImage.Text = "Enregistrer comme image"
        '
        'tsm_enregistrerLIF
        '
        Me.tsm_enregistrerLIF.Name = "tsm_enregistrerLIF"
        Me.tsm_enregistrerLIF.Size = New System.Drawing.Size(239, 30)
        Me.tsm_enregistrerLIF.Text = "Enregistrer comme fichier .LIF"
        '
        'tsm_ouvrirFichierLife
        '
        Me.tsm_ouvrirFichierLife.Image = Global.FoxGameOfLife.My.Resources.Resources.dossier
        Me.tsm_ouvrirFichierLife.Name = "tsm_ouvrirFichierLife"
        Me.tsm_ouvrirFichierLife.Size = New System.Drawing.Size(239, 30)
        Me.tsm_ouvrirFichierLife.Text = "Ouvrir un fichier .LIF"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(236, 6)
        '
        'tsm_enregistrerpreset
        '
        Me.tsm_enregistrerpreset.Enabled = False
        Me.tsm_enregistrerpreset.Image = Global.FoxGameOfLife.My.Resources.Resources.fichiersysteme
        Me.tsm_enregistrerpreset.Name = "tsm_enregistrerpreset"
        Me.tsm_enregistrerpreset.Size = New System.Drawing.Size(239, 30)
        Me.tsm_enregistrerpreset.Text = "Enregistrer comme preset"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(236, 6)
        '
        'tsm_repertoires
        '
        Me.tsm_repertoires.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_repertoireFichiers, Me.tsm_repertoireAnimations, Me.tsm_repertoireImages})
        Me.tsm_repertoires.Enabled = False
        Me.tsm_repertoires.Image = Global.FoxGameOfLife.My.Resources.Resources.dossier
        Me.tsm_repertoires.Name = "tsm_repertoires"
        Me.tsm_repertoires.Size = New System.Drawing.Size(239, 30)
        Me.tsm_repertoires.Text = "Répertoires"
        '
        'tsm_repertoireFichiers
        '
        Me.tsm_repertoireFichiers.Image = Global.FoxGameOfLife.My.Resources.Resources.dossier
        Me.tsm_repertoireFichiers.Name = "tsm_repertoireFichiers"
        Me.tsm_repertoireFichiers.Size = New System.Drawing.Size(201, 22)
        Me.tsm_repertoireFichiers.Text = "Documents/Fichiers"
        '
        'tsm_repertoireAnimations
        '
        Me.tsm_repertoireAnimations.Image = Global.FoxGameOfLife.My.Resources.Resources.dossier
        Me.tsm_repertoireAnimations.Name = "tsm_repertoireAnimations"
        Me.tsm_repertoireAnimations.Size = New System.Drawing.Size(201, 22)
        Me.tsm_repertoireAnimations.Text = "Documents/Animations"
        '
        'tsm_repertoireImages
        '
        Me.tsm_repertoireImages.Image = Global.FoxGameOfLife.My.Resources.Resources.dossier
        Me.tsm_repertoireImages.Name = "tsm_repertoireImages"
        Me.tsm_repertoireImages.Size = New System.Drawing.Size(201, 22)
        Me.tsm_repertoireImages.Text = "Documents/Images"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(236, 6)
        '
        'tsm_quitter
        '
        Me.tsm_quitter.Name = "tsm_quitter"
        Me.tsm_quitter.Size = New System.Drawing.Size(239, 30)
        Me.tsm_quitter.Text = "Quitter"
        '
        'tsm_filtres
        '
        Me.tsm_filtres.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_filtreInverser, Me.tsm_filtreMelanger, Me.tsm_filtreSymetrie, Me.tsm_filtreEpaissir})
        Me.tsm_filtres.Name = "tsm_filtres"
        Me.tsm_filtres.Size = New System.Drawing.Size(50, 20)
        Me.tsm_filtres.Text = "Filtres"
        '
        'tsm_filtreInverser
        '
        Me.tsm_filtreInverser.Name = "tsm_filtreInverser"
        Me.tsm_filtreInverser.Size = New System.Drawing.Size(180, 22)
        Me.tsm_filtreInverser.Text = "Inverser"
        '
        'tsm_filtreMelanger
        '
        Me.tsm_filtreMelanger.Name = "tsm_filtreMelanger"
        Me.tsm_filtreMelanger.Size = New System.Drawing.Size(180, 22)
        Me.tsm_filtreMelanger.Text = "Mélanger"
        '
        'tsm_filtreSymetrie
        '
        Me.tsm_filtreSymetrie.Name = "tsm_filtreSymetrie"
        Me.tsm_filtreSymetrie.Size = New System.Drawing.Size(180, 22)
        Me.tsm_filtreSymetrie.Text = "Symétrie"
        Me.tsm_filtreSymetrie.Visible = False
        '
        'tsm_filtreEpaissir
        '
        Me.tsm_filtreEpaissir.Name = "tsm_filtreEpaissir"
        Me.tsm_filtreEpaissir.Size = New System.Drawing.Size(180, 22)
        Me.tsm_filtreEpaissir.Text = "Epaissir"
        '
        'tsm_presets
        '
        Me.tsm_presets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_rechargerPresets, Me.tsm_mesPresets, Me.ToolStripSeparator11})
        Me.tsm_presets.Name = "tsm_presets"
        Me.tsm_presets.Size = New System.Drawing.Size(56, 20)
        Me.tsm_presets.Text = "Presets"
        '
        'tsm_rechargerPresets
        '
        Me.tsm_rechargerPresets.Name = "tsm_rechargerPresets"
        Me.tsm_rechargerPresets.Size = New System.Drawing.Size(192, 30)
        Me.tsm_rechargerPresets.Text = "Recharger les presets"
        '
        'tsm_mesPresets
        '
        Me.tsm_mesPresets.Image = Global.FoxGameOfLife.My.Resources.Resources.fichiersysteme
        Me.tsm_mesPresets.Name = "tsm_mesPresets"
        Me.tsm_mesPresets.Size = New System.Drawing.Size(192, 30)
        Me.tsm_mesPresets.Text = "Mes presets"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(189, 6)
        '
        'tsm_outils
        '
        Me.tsm_outils.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_generateurLabyrinthe, Me.tsm_commande})
        Me.tsm_outils.Name = "tsm_outils"
        Me.tsm_outils.Size = New System.Drawing.Size(50, 20)
        Me.tsm_outils.Text = "Outils"
        '
        'tsm_generateurLabyrinthe
        '
        Me.tsm_generateurLabyrinthe.Image = Global.FoxGameOfLife.My.Resources.Resources.MazeGenerator
        Me.tsm_generateurLabyrinthe.Name = "tsm_generateurLabyrinthe"
        Me.tsm_generateurLabyrinthe.Size = New System.Drawing.Size(212, 30)
        Me.tsm_generateurLabyrinthe.Text = "Générateur de labyrinthe"
        '
        'tsm_commande
        '
        Me.tsm_commande.Image = Global.FoxGameOfLife.My.Resources.Resources.parametre
        Me.tsm_commande.Name = "tsm_commande"
        Me.tsm_commande.Size = New System.Drawing.Size(212, 30)
        Me.tsm_commande.Text = "Commande"
        '
        'tsm_affichage
        '
        Me.tsm_affichage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_afficherPinceaux, Me.tsm_afficherParametres, Me.tsm_afficherStatus, Me.ToolStripSeparator6, Me.tsm_utiliserReperes, Me.tsm_afficherGrille, Me.tsm_afficherTexte, Me.tsm_afficherBord, Me.ToolStripSeparator7, Me.tsm_themeSombre})
        Me.tsm_affichage.Name = "tsm_affichage"
        Me.tsm_affichage.Size = New System.Drawing.Size(70, 20)
        Me.tsm_affichage.Text = "Affichage"
        '
        'tsm_afficherPinceaux
        '
        Me.tsm_afficherPinceaux.CheckOnClick = True
        Me.tsm_afficherPinceaux.Name = "tsm_afficherPinceaux"
        Me.tsm_afficherPinceaux.Size = New System.Drawing.Size(206, 30)
        Me.tsm_afficherPinceaux.Text = "Barre de pinceaux"
        '
        'tsm_afficherParametres
        '
        Me.tsm_afficherParametres.CheckOnClick = True
        Me.tsm_afficherParametres.Name = "tsm_afficherParametres"
        Me.tsm_afficherParametres.Size = New System.Drawing.Size(206, 30)
        Me.tsm_afficherParametres.Text = "Panneau de paramètres"
        '
        'tsm_afficherStatus
        '
        Me.tsm_afficherStatus.CheckOnClick = True
        Me.tsm_afficherStatus.Name = "tsm_afficherStatus"
        Me.tsm_afficherStatus.Size = New System.Drawing.Size(206, 30)
        Me.tsm_afficherStatus.Text = "Barre de status"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(203, 6)
        '
        'tsm_utiliserReperes
        '
        Me.tsm_utiliserReperes.CheckOnClick = True
        Me.tsm_utiliserReperes.Image = Global.FoxGameOfLife.My.Resources.Resources.selectionbordureint
        Me.tsm_utiliserReperes.Name = "tsm_utiliserReperes"
        Me.tsm_utiliserReperes.Size = New System.Drawing.Size(206, 30)
        Me.tsm_utiliserReperes.Text = "Afficher les repères"
        '
        'tsm_afficherGrille
        '
        Me.tsm_afficherGrille.CheckOnClick = True
        Me.tsm_afficherGrille.Image = Global.FoxGameOfLife.My.Resources.Resources.grille
        Me.tsm_afficherGrille.Name = "tsm_afficherGrille"
        Me.tsm_afficherGrille.Size = New System.Drawing.Size(206, 30)
        Me.tsm_afficherGrille.Text = "Afficher la grille"
        '
        'tsm_afficherTexte
        '
        Me.tsm_afficherTexte.CheckOnClick = True
        Me.tsm_afficherTexte.Image = Global.FoxGameOfLife.My.Resources.Resources.titre
        Me.tsm_afficherTexte.Name = "tsm_afficherTexte"
        Me.tsm_afficherTexte.Size = New System.Drawing.Size(206, 30)
        Me.tsm_afficherTexte.Text = "Afficher le texte"
        '
        'tsm_afficherBord
        '
        Me.tsm_afficherBord.CheckOnClick = True
        Me.tsm_afficherBord.Image = Global.FoxGameOfLife.My.Resources.Resources.bordure
        Me.tsm_afficherBord.Name = "tsm_afficherBord"
        Me.tsm_afficherBord.Size = New System.Drawing.Size(206, 30)
        Me.tsm_afficherBord.Text = "Afficher le bord"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(203, 6)
        '
        'tsm_themeSombre
        '
        Me.tsm_themeSombre.Name = "tsm_themeSombre"
        Me.tsm_themeSombre.Size = New System.Drawing.Size(206, 30)
        Me.tsm_themeSombre.Text = "Thème sombre"
        '
        'tsm_parametres
        '
        Me.tsm_parametres.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_reinitialiserParametres, Me.tsm_raccourcis, Me.ToolStripSeparator2, Me.tsm_nombreThread})
        Me.tsm_parametres.Name = "tsm_parametres"
        Me.tsm_parametres.Size = New System.Drawing.Size(78, 20)
        Me.tsm_parametres.Text = "Paramètres"
        '
        'tsm_reinitialiserParametres
        '
        Me.tsm_reinitialiserParametres.Image = Global.FoxGameOfLife.My.Resources.Resources.parametre
        Me.tsm_reinitialiserParametres.Name = "tsm_reinitialiserParametres"
        Me.tsm_reinitialiserParametres.Size = New System.Drawing.Size(247, 30)
        Me.tsm_reinitialiserParametres.Text = "Réinitialiser tous les paramètres"
        '
        'tsm_raccourcis
        '
        Me.tsm_raccourcis.Image = Global.FoxGameOfLife.My.Resources.Resources.bt
        Me.tsm_raccourcis.Name = "tsm_raccourcis"
        Me.tsm_raccourcis.Size = New System.Drawing.Size(247, 30)
        Me.tsm_raccourcis.Text = "Raccourcis"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(244, 6)
        '
        'tsm_nombreThread
        '
        Me.tsm_nombreThread.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_0Thread, Me.tsm_1Thread, Me.tsm_2Thread, Me.tsm_4Thread})
        Me.tsm_nombreThread.Name = "tsm_nombreThread"
        Me.tsm_nombreThread.Size = New System.Drawing.Size(247, 30)
        Me.tsm_nombreThread.Text = "Threading"
        '
        'tsm_0Thread
        '
        Me.tsm_0Thread.Name = "tsm_0Thread"
        Me.tsm_0Thread.Size = New System.Drawing.Size(125, 22)
        Me.tsm_0Thread.Text = "Aucun"
        '
        'tsm_1Thread
        '
        Me.tsm_1Thread.Image = Global.FoxGameOfLife.My.Resources.Resources.thread1
        Me.tsm_1Thread.Name = "tsm_1Thread"
        Me.tsm_1Thread.Size = New System.Drawing.Size(125, 22)
        Me.tsm_1Thread.Text = "1 Thread"
        '
        'tsm_2Thread
        '
        Me.tsm_2Thread.Image = Global.FoxGameOfLife.My.Resources.Resources.thread2
        Me.tsm_2Thread.Name = "tsm_2Thread"
        Me.tsm_2Thread.Size = New System.Drawing.Size(125, 22)
        Me.tsm_2Thread.Text = "2 Threads"
        '
        'tsm_4Thread
        '
        Me.tsm_4Thread.Image = Global.FoxGameOfLife.My.Resources.Resources.thread4
        Me.tsm_4Thread.Name = "tsm_4Thread"
        Me.tsm_4Thread.Size = New System.Drawing.Size(125, 22)
        Me.tsm_4Thread.Text = "4 Threads"
        '
        'tsm_plus
        '
        Me.tsm_plus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_aide, Me.ToolStripSeparator10, Me.NoteToolStripMenuItem, Me.tsm_apropos})
        Me.tsm_plus.Name = "tsm_plus"
        Me.tsm_plus.Size = New System.Drawing.Size(24, 20)
        Me.tsm_plus.Text = "?"
        '
        'tsm_aide
        '
        Me.tsm_aide.Image = Global.FoxGameOfLife.My.Resources.Resources.aide
        Me.tsm_aide.Name = "tsm_aide"
        Me.tsm_aide.Size = New System.Drawing.Size(162, 22)
        Me.tsm_aide.Text = "Aide"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(159, 6)
        '
        'NoteToolStripMenuItem
        '
        Me.NoteToolStripMenuItem.Image = Global.FoxGameOfLife.My.Resources.Resources.script
        Me.NoteToolStripMenuItem.Name = "NoteToolStripMenuItem"
        Me.NoteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NoteToolStripMenuItem.Text = "Notes de version"
        '
        'tsm_apropos
        '
        Me.tsm_apropos.Image = Global.FoxGameOfLife.My.Resources.Resources.news
        Me.tsm_apropos.Name = "tsm_apropos"
        Me.tsm_apropos.Size = New System.Drawing.Size(162, 22)
        Me.tsm_apropos.Text = "A propos de"
        '
        'menu_outils
        '
        Me.menu_outils.BackColor = System.Drawing.Color.Silver
        Me.menu_outils.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menu_outils.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menu_outils.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_objets, Me.ToolStripSeparator1, Me.tsm_play, Me.tsm_framePrecedente, Me.tsm_pause, Me.tsm_framesuivante, Me.tsm_stop, Me.tsm_stopKeep, Me.bt_enregistrerAnimation, Me.sep_animation, Me.tsm_parametresAnimation, Me.tsm_effacer, Me.ToolStripSeparator8, Me.tsm_modeleRotationDroite, Me.tsm_rotationModeleGauche, Me.tsm_modeleSymetrieHorizontale, Me.tsm_modèleSymetrieVerticale})
        Me.menu_outils.Location = New System.Drawing.Point(0, 24)
        Me.menu_outils.Name = "menu_outils"
        Me.menu_outils.Size = New System.Drawing.Size(976, 31)
        Me.menu_outils.TabIndex = 3
        Me.menu_outils.Text = "ToolStrip1"
        '
        'tsm_objets
        '
        Me.tsm_objets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_objets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_cellule, Me.tsm_vide, Me.tsm_mur, Me.tsm_cellulePermanente})
        Me.tsm_objets.Image = Global.FoxGameOfLife.My.Resources.Resources.editioncellule
        Me.tsm_objets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_objets.Name = "tsm_objets"
        Me.tsm_objets.Size = New System.Drawing.Size(37, 28)
        Me.tsm_objets.Text = "Objets"
        '
        'tsm_cellule
        '
        Me.tsm_cellule.Image = Global.FoxGameOfLife.My.Resources.Resources.editioncellule
        Me.tsm_cellule.Name = "tsm_cellule"
        Me.tsm_cellule.Size = New System.Drawing.Size(177, 22)
        Me.tsm_cellule.Text = "Cellule"
        '
        'tsm_vide
        '
        Me.tsm_vide.Image = Global.FoxGameOfLife.My.Resources.Resources.editionvide
        Me.tsm_vide.Name = "tsm_vide"
        Me.tsm_vide.Size = New System.Drawing.Size(177, 22)
        Me.tsm_vide.Text = "Vide"
        '
        'tsm_mur
        '
        Me.tsm_mur.Image = Global.FoxGameOfLife.My.Resources.Resources.pinceau_mur_perso
        Me.tsm_mur.Name = "tsm_mur"
        Me.tsm_mur.Size = New System.Drawing.Size(177, 22)
        Me.tsm_mur.Text = "Mur"
        '
        'tsm_cellulePermanente
        '
        Me.tsm_cellulePermanente.Image = Global.FoxGameOfLife.My.Resources.Resources.cellule_permanente
        Me.tsm_cellulePermanente.Name = "tsm_cellulePermanente"
        Me.tsm_cellulePermanente.Size = New System.Drawing.Size(177, 22)
        Me.tsm_cellulePermanente.Text = "Cellule permanente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'tsm_play
        '
        Me.tsm_play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_play.Image = Global.FoxGameOfLife.My.Resources.Resources.play
        Me.tsm_play.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_play.Name = "tsm_play"
        Me.tsm_play.Size = New System.Drawing.Size(28, 28)
        Me.tsm_play.Text = "Démarrer la simulation"
        '
        'tsm_framePrecedente
        '
        Me.tsm_framePrecedente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_framePrecedente.Image = Global.FoxGameOfLife.My.Resources.Resources.reculer
        Me.tsm_framePrecedente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_framePrecedente.Name = "tsm_framePrecedente"
        Me.tsm_framePrecedente.Size = New System.Drawing.Size(28, 28)
        Me.tsm_framePrecedente.Text = "Revenir à la frame précédente"
        '
        'tsm_pause
        '
        Me.tsm_pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_pause.Enabled = False
        Me.tsm_pause.Image = Global.FoxGameOfLife.My.Resources.Resources.pause
        Me.tsm_pause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_pause.Name = "tsm_pause"
        Me.tsm_pause.Size = New System.Drawing.Size(28, 28)
        Me.tsm_pause.Text = "Mettre la simulation en pause"
        '
        'tsm_framesuivante
        '
        Me.tsm_framesuivante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_framesuivante.Image = Global.FoxGameOfLife.My.Resources.Resources.avancer
        Me.tsm_framesuivante.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_framesuivante.Name = "tsm_framesuivante"
        Me.tsm_framesuivante.Size = New System.Drawing.Size(28, 28)
        Me.tsm_framesuivante.Text = "Passer à la frame suivante"
        '
        'tsm_stop
        '
        Me.tsm_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_stop.Enabled = False
        Me.tsm_stop.Image = Global.FoxGameOfLife.My.Resources.Resources._stop
        Me.tsm_stop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_stop.Name = "tsm_stop"
        Me.tsm_stop.Size = New System.Drawing.Size(28, 28)
        Me.tsm_stop.Text = "Arrêter la simulation"
        '
        'tsm_stopKeep
        '
        Me.tsm_stopKeep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_stopKeep.Enabled = False
        Me.tsm_stopKeep.Image = Global.FoxGameOfLife.My.Resources.Resources.arriereplan
        Me.tsm_stopKeep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_stopKeep.Name = "tsm_stopKeep"
        Me.tsm_stopKeep.Size = New System.Drawing.Size(28, 28)
        Me.tsm_stopKeep.Text = "Arrêter la simulation et garde la configuration du JDLV"
        '
        'bt_enregistrerAnimation
        '
        Me.bt_enregistrerAnimation.CheckOnClick = True
        Me.bt_enregistrerAnimation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bt_enregistrerAnimation.Image = Global.FoxGameOfLife.My.Resources.Resources.record
        Me.bt_enregistrerAnimation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bt_enregistrerAnimation.Name = "bt_enregistrerAnimation"
        Me.bt_enregistrerAnimation.Size = New System.Drawing.Size(28, 28)
        Me.bt_enregistrerAnimation.Text = "Enregistrer l'animation"
        '
        'sep_animation
        '
        Me.sep_animation.Name = "sep_animation"
        Me.sep_animation.Size = New System.Drawing.Size(6, 31)
        '
        'tsm_parametresAnimation
        '
        Me.tsm_parametresAnimation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_parametresAnimation.Image = Global.FoxGameOfLife.My.Resources.Resources.Animation
        Me.tsm_parametresAnimation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_parametresAnimation.Name = "tsm_parametresAnimation"
        Me.tsm_parametresAnimation.Size = New System.Drawing.Size(28, 28)
        Me.tsm_parametresAnimation.Text = "Paramètres des enregistrements"
        '
        'tsm_effacer
        '
        Me.tsm_effacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_effacer.Image = Global.FoxGameOfLife.My.Resources.Resources.gomme
        Me.tsm_effacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_effacer.Name = "tsm_effacer"
        Me.tsm_effacer.Size = New System.Drawing.Size(28, 28)
        Me.tsm_effacer.Text = "Tout effacer"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'tsm_modeleRotationDroite
        '
        Me.tsm_modeleRotationDroite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_modeleRotationDroite.Image = Global.FoxGameOfLife.My.Resources.Resources.Inverserdiagonale
        Me.tsm_modeleRotationDroite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_modeleRotationDroite.Name = "tsm_modeleRotationDroite"
        Me.tsm_modeleRotationDroite.Size = New System.Drawing.Size(28, 28)
        Me.tsm_modeleRotationDroite.Text = "Rotation du modèle à droite"
        '
        'tsm_rotationModeleGauche
        '
        Me.tsm_rotationModeleGauche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_rotationModeleGauche.Image = Global.FoxGameOfLife.My.Resources.Resources.Inverserdiagonale
        Me.tsm_rotationModeleGauche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_rotationModeleGauche.Name = "tsm_rotationModeleGauche"
        Me.tsm_rotationModeleGauche.Size = New System.Drawing.Size(28, 28)
        Me.tsm_rotationModeleGauche.Text = "Rotation du modèle à gauche"
        '
        'tsm_modeleSymetrieHorizontale
        '
        Me.tsm_modeleSymetrieHorizontale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_modeleSymetrieHorizontale.Image = Global.FoxGameOfLife.My.Resources.Resources.miroirligne
        Me.tsm_modeleSymetrieHorizontale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_modeleSymetrieHorizontale.Name = "tsm_modeleSymetrieHorizontale"
        Me.tsm_modeleSymetrieHorizontale.Size = New System.Drawing.Size(28, 28)
        Me.tsm_modeleSymetrieHorizontale.Text = "Symétrie horizontale du modèle"
        '
        'tsm_modèleSymetrieVerticale
        '
        Me.tsm_modèleSymetrieVerticale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_modèleSymetrieVerticale.Image = Global.FoxGameOfLife.My.Resources.Resources.miroircolonne
        Me.tsm_modèleSymetrieVerticale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_modèleSymetrieVerticale.Name = "tsm_modèleSymetrieVerticale"
        Me.tsm_modèleSymetrieVerticale.Size = New System.Drawing.Size(28, 28)
        Me.tsm_modèleSymetrieVerticale.Text = "Symétrie verticale du modèle"
        '
        'temps_simulation
        '
        Me.temps_simulation.Interval = 5
        '
        'panel_outils
        '
        Me.panel_outils.Controls.Add(Me.tab_contenu)
        Me.panel_outils.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_outils.Location = New System.Drawing.Point(684, 55)
        Me.panel_outils.Name = "panel_outils"
        Me.panel_outils.Size = New System.Drawing.Size(292, 525)
        Me.panel_outils.TabIndex = 1
        '
        'tab_contenu
        '
        Me.tab_contenu.Controls.Add(Me.tab_)
        Me.tab_contenu.Controls.Add(Me.tab_edition)
        Me.tab_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_contenu.Location = New System.Drawing.Point(0, 0)
        Me.tab_contenu.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_contenu.Name = "tab_contenu"
        Me.tab_contenu.SelectedIndex = 0
        Me.tab_contenu.Size = New System.Drawing.Size(292, 525)
        Me.tab_contenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tab_contenu.TabIndex = 0
        '
        'tab_
        '
        Me.tab_.Controls.Add(Me.bt_couleurCellulePermanente)
        Me.tab_.Controls.Add(Me.lab_couleurCellulePermanente)
        Me.tab_.Controls.Add(Me.lab_textePositionY)
        Me.tab_.Controls.Add(Me.num_textePositionY)
        Me.tab_.Controls.Add(Me.lab_textePositionX)
        Me.tab_.Controls.Add(Me.num_textePositionX)
        Me.tab_.Controls.Add(Me.bt_modifierTexte)
        Me.tab_.Controls.Add(Me.lab_texte)
        Me.tab_.Controls.Add(Me.bt_couleurMur)
        Me.tab_.Controls.Add(Me.lab_couleurMur)
        Me.tab_.Controls.Add(Me.bt_exceptions)
        Me.tab_.Controls.Add(Me.bt_reglesParDefaut)
        Me.tab_.Controls.Add(Me.Label3)
        Me.tab_.Controls.Add(Me.num_arretframe)
        Me.tab_.Controls.Add(Me.cbox_arreterSimulation)
        Me.tab_.Controls.Add(Me.lab_tempsSimulation)
        Me.tab_.Controls.Add(Me.num_tempsSimulation)
        Me.tab_.Controls.Add(Me.lab_simulation)
        Me.tab_.Controls.Add(Me.num_tailleCases)
        Me.tab_.Controls.Add(Me.lab_tailleCase)
        Me.tab_.Controls.Add(Me.cbox_creation8)
        Me.tab_.Controls.Add(Me.cbox_creation7)
        Me.tab_.Controls.Add(Me.cbox_creation6)
        Me.tab_.Controls.Add(Me.cbox_creation5)
        Me.tab_.Controls.Add(Me.cbox_creation4)
        Me.tab_.Controls.Add(Me.cbox_creation3)
        Me.tab_.Controls.Add(Me.cbox_creation2)
        Me.tab_.Controls.Add(Me.cbox_creation1)
        Me.tab_.Controls.Add(Me.cbox_creation0)
        Me.tab_.Controls.Add(Me.Label2)
        Me.tab_.Controls.Add(Me.cbox_survie8)
        Me.tab_.Controls.Add(Me.cbox_survie7)
        Me.tab_.Controls.Add(Me.cbox_survie6)
        Me.tab_.Controls.Add(Me.cbox_survie5)
        Me.tab_.Controls.Add(Me.cbox_survie4)
        Me.tab_.Controls.Add(Me.cbox_survie3)
        Me.tab_.Controls.Add(Me.cbox_survie2)
        Me.tab_.Controls.Add(Me.cbox_survie1)
        Me.tab_.Controls.Add(Me.cbox_survie0)
        Me.tab_.Controls.Add(Me.lab_survie)
        Me.tab_.Controls.Add(Me.lab_regles)
        Me.tab_.Controls.Add(Me.bt_couleurGrille)
        Me.tab_.Controls.Add(Me.bt_couleurCellules)
        Me.tab_.Controls.Add(Me.bt_couleurCasesVides)
        Me.tab_.Controls.Add(Me.lab_affichage)
        Me.tab_.Controls.Add(Me.lab_couleurGrille)
        Me.tab_.Controls.Add(Me.Label1)
        Me.tab_.Controls.Add(Me.lab_couleurCase)
        Me.tab_.Location = New System.Drawing.Point(4, 22)
        Me.tab_.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_.Name = "tab_"
        Me.tab_.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_.Size = New System.Drawing.Size(284, 499)
        Me.tab_.TabIndex = 0
        Me.tab_.Text = "Paramètres"
        Me.tab_.UseVisualStyleBackColor = True
        '
        'bt_couleurCellulePermanente
        '
        Me.bt_couleurCellulePermanente.BackColor = System.Drawing.Color.Gray
        Me.bt_couleurCellulePermanente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurCellulePermanente.Location = New System.Drawing.Point(172, 102)
        Me.bt_couleurCellulePermanente.Name = "bt_couleurCellulePermanente"
        Me.bt_couleurCellulePermanente.Size = New System.Drawing.Size(32, 18)
        Me.bt_couleurCellulePermanente.TabIndex = 58
        Me.bt_couleurCellulePermanente.UseVisualStyleBackColor = False
        '
        'lab_couleurCellulePermanente
        '
        Me.lab_couleurCellulePermanente.AutoSize = True
        Me.lab_couleurCellulePermanente.Location = New System.Drawing.Point(2, 104)
        Me.lab_couleurCellulePermanente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_couleurCellulePermanente.Name = "lab_couleurCellulePermanente"
        Me.lab_couleurCellulePermanente.Size = New System.Drawing.Size(165, 13)
        Me.lab_couleurCellulePermanente.TabIndex = 57
        Me.lab_couleurCellulePermanente.Text = "Couleur des cellules permanentes"
        '
        'lab_textePositionY
        '
        Me.lab_textePositionY.AutoSize = True
        Me.lab_textePositionY.Location = New System.Drawing.Point(6, 236)
        Me.lab_textePositionY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_textePositionY.Name = "lab_textePositionY"
        Me.lab_textePositionY.Size = New System.Drawing.Size(96, 13)
        Me.lab_textePositionY.TabIndex = 56
        Me.lab_textePositionY.Text = "Position y du texte "
        '
        'num_textePositionY
        '
        Me.num_textePositionY.Location = New System.Drawing.Point(103, 235)
        Me.num_textePositionY.Margin = New System.Windows.Forms.Padding(2)
        Me.num_textePositionY.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.num_textePositionY.Name = "num_textePositionY"
        Me.num_textePositionY.Size = New System.Drawing.Size(80, 20)
        Me.num_textePositionY.TabIndex = 55
        '
        'lab_textePositionX
        '
        Me.lab_textePositionX.AutoSize = True
        Me.lab_textePositionX.Location = New System.Drawing.Point(6, 214)
        Me.lab_textePositionX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_textePositionX.Name = "lab_textePositionX"
        Me.lab_textePositionX.Size = New System.Drawing.Size(96, 13)
        Me.lab_textePositionX.TabIndex = 54
        Me.lab_textePositionX.Text = "Position x du texte "
        '
        'num_textePositionX
        '
        Me.num_textePositionX.Location = New System.Drawing.Point(103, 212)
        Me.num_textePositionX.Margin = New System.Windows.Forms.Padding(2)
        Me.num_textePositionX.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.num_textePositionX.Name = "num_textePositionX"
        Me.num_textePositionX.Size = New System.Drawing.Size(80, 20)
        Me.num_textePositionX.TabIndex = 53
        '
        'bt_modifierTexte
        '
        Me.bt_modifierTexte.BackColor = System.Drawing.Color.Silver
        Me.bt_modifierTexte.FlatAppearance.BorderSize = 0
        Me.bt_modifierTexte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_modifierTexte.Image = Global.FoxGameOfLife.My.Resources.Resources.titre
        Me.bt_modifierTexte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_modifierTexte.Location = New System.Drawing.Point(5, 175)
        Me.bt_modifierTexte.Name = "bt_modifierTexte"
        Me.bt_modifierTexte.Size = New System.Drawing.Size(108, 33)
        Me.bt_modifierTexte.TabIndex = 52
        Me.bt_modifierTexte.Text = "Modifier le texte"
        Me.bt_modifierTexte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_modifierTexte.UseVisualStyleBackColor = False
        '
        'lab_texte
        '
        Me.lab_texte.AutoSize = True
        Me.lab_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_texte.Location = New System.Drawing.Point(2, 156)
        Me.lab_texte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_texte.Name = "lab_texte"
        Me.lab_texte.Size = New System.Drawing.Size(39, 13)
        Me.lab_texte.TabIndex = 43
        Me.lab_texte.Text = "Texte"
        '
        'bt_couleurMur
        '
        Me.bt_couleurMur.BackColor = System.Drawing.Color.Gray
        Me.bt_couleurMur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurMur.Location = New System.Drawing.Point(172, 81)
        Me.bt_couleurMur.Name = "bt_couleurMur"
        Me.bt_couleurMur.Size = New System.Drawing.Size(32, 18)
        Me.bt_couleurMur.TabIndex = 42
        Me.bt_couleurMur.UseVisualStyleBackColor = False
        '
        'lab_couleurMur
        '
        Me.lab_couleurMur.AutoSize = True
        Me.lab_couleurMur.Location = New System.Drawing.Point(2, 83)
        Me.lab_couleurMur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_couleurMur.Name = "lab_couleurMur"
        Me.lab_couleurMur.Size = New System.Drawing.Size(88, 13)
        Me.lab_couleurMur.TabIndex = 41
        Me.lab_couleurMur.Text = "Couleur des murs"
        '
        'bt_exceptions
        '
        Me.bt_exceptions.BackColor = System.Drawing.Color.Silver
        Me.bt_exceptions.FlatAppearance.BorderSize = 0
        Me.bt_exceptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_exceptions.Image = Global.FoxGameOfLife.My.Resources.Resources._event
        Me.bt_exceptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_exceptions.Location = New System.Drawing.Point(148, 403)
        Me.bt_exceptions.Name = "bt_exceptions"
        Me.bt_exceptions.Size = New System.Drawing.Size(92, 33)
        Me.bt_exceptions.TabIndex = 40
        Me.bt_exceptions.Text = "Exceptions"
        Me.bt_exceptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_exceptions.UseVisualStyleBackColor = False
        '
        'bt_reglesParDefaut
        '
        Me.bt_reglesParDefaut.BackColor = System.Drawing.Color.Silver
        Me.bt_reglesParDefaut.FlatAppearance.BorderSize = 0
        Me.bt_reglesParDefaut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_reglesParDefaut.Location = New System.Drawing.Point(6, 403)
        Me.bt_reglesParDefaut.Name = "bt_reglesParDefaut"
        Me.bt_reglesParDefaut.Size = New System.Drawing.Size(136, 33)
        Me.bt_reglesParDefaut.TabIndex = 39
        Me.bt_reglesParDefaut.Text = "Règles par défaut"
        Me.bt_reglesParDefaut.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 512)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "à la frame : "
        '
        'num_arretframe
        '
        Me.num_arretframe.Location = New System.Drawing.Point(69, 511)
        Me.num_arretframe.Margin = New System.Windows.Forms.Padding(2)
        Me.num_arretframe.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.num_arretframe.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_arretframe.Name = "num_arretframe"
        Me.num_arretframe.Size = New System.Drawing.Size(80, 20)
        Me.num_arretframe.TabIndex = 37
        Me.num_arretframe.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'cbox_arreterSimulation
        '
        Me.cbox_arreterSimulation.AutoSize = True
        Me.cbox_arreterSimulation.Location = New System.Drawing.Point(9, 488)
        Me.cbox_arreterSimulation.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_arreterSimulation.Name = "cbox_arreterSimulation"
        Me.cbox_arreterSimulation.Size = New System.Drawing.Size(201, 17)
        Me.cbox_arreterSimulation.TabIndex = 36
        Me.cbox_arreterSimulation.Text = "Arrêter automatiquement la simulation"
        Me.cbox_arreterSimulation.UseVisualStyleBackColor = True
        '
        'lab_tempsSimulation
        '
        Me.lab_tempsSimulation.AutoSize = True
        Me.lab_tempsSimulation.Location = New System.Drawing.Point(6, 466)
        Me.lab_tempsSimulation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_tempsSimulation.Name = "lab_tempsSimulation"
        Me.lab_tempsSimulation.Size = New System.Drawing.Size(150, 13)
        Me.lab_tempsSimulation.TabIndex = 35
        Me.lab_tempsSimulation.Text = "Temps entre les frames [ms]  : "
        '
        'num_tempsSimulation
        '
        Me.num_tempsSimulation.Location = New System.Drawing.Point(159, 464)
        Me.num_tempsSimulation.Margin = New System.Windows.Forms.Padding(2)
        Me.num_tempsSimulation.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_tempsSimulation.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_tempsSimulation.Name = "num_tempsSimulation"
        Me.num_tempsSimulation.Size = New System.Drawing.Size(80, 20)
        Me.num_tempsSimulation.TabIndex = 34
        Me.num_tempsSimulation.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lab_simulation
        '
        Me.lab_simulation.AutoSize = True
        Me.lab_simulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_simulation.Location = New System.Drawing.Point(2, 450)
        Me.lab_simulation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_simulation.Name = "lab_simulation"
        Me.lab_simulation.Size = New System.Drawing.Size(65, 13)
        Me.lab_simulation.TabIndex = 33
        Me.lab_simulation.Text = "Simulation"
        '
        'num_tailleCases
        '
        Me.num_tailleCases.Location = New System.Drawing.Point(139, 131)
        Me.num_tailleCases.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.num_tailleCases.Name = "num_tailleCases"
        Me.num_tailleCases.Size = New System.Drawing.Size(70, 20)
        Me.num_tailleCases.TabIndex = 32
        '
        'lab_tailleCase
        '
        Me.lab_tailleCase.AutoSize = True
        Me.lab_tailleCase.Location = New System.Drawing.Point(1, 133)
        Me.lab_tailleCase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_tailleCase.Name = "lab_tailleCase"
        Me.lab_tailleCase.Size = New System.Drawing.Size(139, 13)
        Me.lab_tailleCase.TabIndex = 31
        Me.lab_tailleCase.Text = "Taille des cases (en pixels) :"
        '
        'cbox_creation8
        '
        Me.cbox_creation8.AutoSize = True
        Me.cbox_creation8.FlatAppearance.BorderSize = 0
        Me.cbox_creation8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation8.Location = New System.Drawing.Point(123, 378)
        Me.cbox_creation8.Name = "cbox_creation8"
        Me.cbox_creation8.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation8.TabIndex = 30
        Me.cbox_creation8.Text = "8"
        Me.cbox_creation8.UseVisualStyleBackColor = True
        '
        'cbox_creation7
        '
        Me.cbox_creation7.AutoSize = True
        Me.cbox_creation7.FlatAppearance.BorderSize = 0
        Me.cbox_creation7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation7.Location = New System.Drawing.Point(88, 378)
        Me.cbox_creation7.Name = "cbox_creation7"
        Me.cbox_creation7.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation7.TabIndex = 29
        Me.cbox_creation7.Text = "7"
        Me.cbox_creation7.UseVisualStyleBackColor = True
        '
        'cbox_creation6
        '
        Me.cbox_creation6.AutoSize = True
        Me.cbox_creation6.FlatAppearance.BorderSize = 0
        Me.cbox_creation6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation6.Location = New System.Drawing.Point(52, 378)
        Me.cbox_creation6.Name = "cbox_creation6"
        Me.cbox_creation6.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation6.TabIndex = 28
        Me.cbox_creation6.Text = "6"
        Me.cbox_creation6.UseVisualStyleBackColor = True
        '
        'cbox_creation5
        '
        Me.cbox_creation5.AutoSize = True
        Me.cbox_creation5.FlatAppearance.BorderSize = 0
        Me.cbox_creation5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation5.Location = New System.Drawing.Point(18, 378)
        Me.cbox_creation5.Name = "cbox_creation5"
        Me.cbox_creation5.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation5.TabIndex = 27
        Me.cbox_creation5.Text = "5"
        Me.cbox_creation5.UseVisualStyleBackColor = True
        '
        'cbox_creation4
        '
        Me.cbox_creation4.AutoSize = True
        Me.cbox_creation4.FlatAppearance.BorderSize = 0
        Me.cbox_creation4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation4.Location = New System.Drawing.Point(158, 355)
        Me.cbox_creation4.Name = "cbox_creation4"
        Me.cbox_creation4.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation4.TabIndex = 26
        Me.cbox_creation4.Text = "4"
        Me.cbox_creation4.UseVisualStyleBackColor = True
        '
        'cbox_creation3
        '
        Me.cbox_creation3.AutoSize = True
        Me.cbox_creation3.Checked = True
        Me.cbox_creation3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbox_creation3.FlatAppearance.BorderSize = 0
        Me.cbox_creation3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation3.Location = New System.Drawing.Point(123, 355)
        Me.cbox_creation3.Name = "cbox_creation3"
        Me.cbox_creation3.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation3.TabIndex = 25
        Me.cbox_creation3.Text = "3"
        Me.cbox_creation3.UseVisualStyleBackColor = True
        '
        'cbox_creation2
        '
        Me.cbox_creation2.AutoSize = True
        Me.cbox_creation2.FlatAppearance.BorderSize = 0
        Me.cbox_creation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation2.Location = New System.Drawing.Point(88, 355)
        Me.cbox_creation2.Name = "cbox_creation2"
        Me.cbox_creation2.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation2.TabIndex = 24
        Me.cbox_creation2.Text = "2"
        Me.cbox_creation2.UseVisualStyleBackColor = True
        '
        'cbox_creation1
        '
        Me.cbox_creation1.AutoSize = True
        Me.cbox_creation1.FlatAppearance.BorderSize = 0
        Me.cbox_creation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation1.Location = New System.Drawing.Point(52, 355)
        Me.cbox_creation1.Name = "cbox_creation1"
        Me.cbox_creation1.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation1.TabIndex = 23
        Me.cbox_creation1.Text = "1"
        Me.cbox_creation1.UseVisualStyleBackColor = True
        '
        'cbox_creation0
        '
        Me.cbox_creation0.AutoSize = True
        Me.cbox_creation0.FlatAppearance.BorderSize = 0
        Me.cbox_creation0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_creation0.Location = New System.Drawing.Point(18, 355)
        Me.cbox_creation0.Name = "cbox_creation0"
        Me.cbox_creation0.Size = New System.Drawing.Size(29, 17)
        Me.cbox_creation0.TabIndex = 22
        Me.cbox_creation0.Text = "0"
        Me.cbox_creation0.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Création d'une cellule si la case possède x cellules voisines"
        '
        'cbox_survie8
        '
        Me.cbox_survie8.AutoSize = True
        Me.cbox_survie8.FlatAppearance.BorderSize = 0
        Me.cbox_survie8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie8.Location = New System.Drawing.Point(123, 315)
        Me.cbox_survie8.Name = "cbox_survie8"
        Me.cbox_survie8.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie8.TabIndex = 20
        Me.cbox_survie8.Text = "8"
        Me.cbox_survie8.UseVisualStyleBackColor = True
        '
        'cbox_survie7
        '
        Me.cbox_survie7.AutoSize = True
        Me.cbox_survie7.FlatAppearance.BorderSize = 0
        Me.cbox_survie7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie7.Location = New System.Drawing.Point(88, 314)
        Me.cbox_survie7.Name = "cbox_survie7"
        Me.cbox_survie7.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie7.TabIndex = 19
        Me.cbox_survie7.Text = "7"
        Me.cbox_survie7.UseVisualStyleBackColor = True
        '
        'cbox_survie6
        '
        Me.cbox_survie6.AutoSize = True
        Me.cbox_survie6.FlatAppearance.BorderSize = 0
        Me.cbox_survie6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie6.Location = New System.Drawing.Point(52, 314)
        Me.cbox_survie6.Name = "cbox_survie6"
        Me.cbox_survie6.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie6.TabIndex = 18
        Me.cbox_survie6.Text = "6"
        Me.cbox_survie6.UseVisualStyleBackColor = True
        '
        'cbox_survie5
        '
        Me.cbox_survie5.AutoSize = True
        Me.cbox_survie5.FlatAppearance.BorderSize = 0
        Me.cbox_survie5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie5.Location = New System.Drawing.Point(18, 314)
        Me.cbox_survie5.Name = "cbox_survie5"
        Me.cbox_survie5.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie5.TabIndex = 17
        Me.cbox_survie5.Text = "5"
        Me.cbox_survie5.UseVisualStyleBackColor = True
        '
        'cbox_survie4
        '
        Me.cbox_survie4.AutoSize = True
        Me.cbox_survie4.FlatAppearance.BorderSize = 0
        Me.cbox_survie4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie4.Location = New System.Drawing.Point(158, 294)
        Me.cbox_survie4.Name = "cbox_survie4"
        Me.cbox_survie4.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie4.TabIndex = 16
        Me.cbox_survie4.Text = "4"
        Me.cbox_survie4.UseVisualStyleBackColor = True
        '
        'cbox_survie3
        '
        Me.cbox_survie3.AutoSize = True
        Me.cbox_survie3.Checked = True
        Me.cbox_survie3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbox_survie3.FlatAppearance.BorderSize = 0
        Me.cbox_survie3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie3.Location = New System.Drawing.Point(123, 294)
        Me.cbox_survie3.Name = "cbox_survie3"
        Me.cbox_survie3.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie3.TabIndex = 15
        Me.cbox_survie3.Text = "3"
        Me.cbox_survie3.UseVisualStyleBackColor = True
        '
        'cbox_survie2
        '
        Me.cbox_survie2.AutoSize = True
        Me.cbox_survie2.Checked = True
        Me.cbox_survie2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbox_survie2.FlatAppearance.BorderSize = 0
        Me.cbox_survie2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie2.Location = New System.Drawing.Point(88, 294)
        Me.cbox_survie2.Name = "cbox_survie2"
        Me.cbox_survie2.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie2.TabIndex = 14
        Me.cbox_survie2.Text = "2"
        Me.cbox_survie2.UseVisualStyleBackColor = True
        '
        'cbox_survie1
        '
        Me.cbox_survie1.AutoSize = True
        Me.cbox_survie1.FlatAppearance.BorderSize = 0
        Me.cbox_survie1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie1.Location = New System.Drawing.Point(52, 294)
        Me.cbox_survie1.Name = "cbox_survie1"
        Me.cbox_survie1.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie1.TabIndex = 13
        Me.cbox_survie1.Text = "1"
        Me.cbox_survie1.UseVisualStyleBackColor = True
        '
        'cbox_survie0
        '
        Me.cbox_survie0.AutoSize = True
        Me.cbox_survie0.FlatAppearance.BorderSize = 0
        Me.cbox_survie0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_survie0.Location = New System.Drawing.Point(18, 294)
        Me.cbox_survie0.Name = "cbox_survie0"
        Me.cbox_survie0.Size = New System.Drawing.Size(29, 17)
        Me.cbox_survie0.TabIndex = 12
        Me.cbox_survie0.Text = "0"
        Me.cbox_survie0.UseVisualStyleBackColor = True
        '
        'lab_survie
        '
        Me.lab_survie.AutoSize = True
        Me.lab_survie.Location = New System.Drawing.Point(2, 271)
        Me.lab_survie.Name = "lab_survie"
        Me.lab_survie.Size = New System.Drawing.Size(250, 13)
        Me.lab_survie.TabIndex = 11
        Me.lab_survie.Text = "Une cellule survie si elle possède x cellules voisines"
        '
        'lab_regles
        '
        Me.lab_regles.AutoSize = True
        Me.lab_regles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_regles.Location = New System.Drawing.Point(2, 258)
        Me.lab_regles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_regles.Name = "lab_regles"
        Me.lab_regles.Size = New System.Drawing.Size(46, 13)
        Me.lab_regles.TabIndex = 7
        Me.lab_regles.Text = "Règles"
        '
        'bt_couleurGrille
        '
        Me.bt_couleurGrille.BackColor = System.Drawing.Color.Gray
        Me.bt_couleurGrille.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurGrille.Location = New System.Drawing.Point(172, 60)
        Me.bt_couleurGrille.Name = "bt_couleurGrille"
        Me.bt_couleurGrille.Size = New System.Drawing.Size(32, 18)
        Me.bt_couleurGrille.TabIndex = 6
        Me.bt_couleurGrille.UseVisualStyleBackColor = False
        '
        'bt_couleurCellules
        '
        Me.bt_couleurCellules.BackColor = System.Drawing.Color.Black
        Me.bt_couleurCellules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurCellules.Location = New System.Drawing.Point(172, 39)
        Me.bt_couleurCellules.Name = "bt_couleurCellules"
        Me.bt_couleurCellules.Size = New System.Drawing.Size(32, 18)
        Me.bt_couleurCellules.TabIndex = 5
        Me.bt_couleurCellules.UseVisualStyleBackColor = False
        '
        'bt_couleurCasesVides
        '
        Me.bt_couleurCasesVides.BackColor = System.Drawing.Color.White
        Me.bt_couleurCasesVides.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurCasesVides.Location = New System.Drawing.Point(172, 18)
        Me.bt_couleurCasesVides.Name = "bt_couleurCasesVides"
        Me.bt_couleurCasesVides.Size = New System.Drawing.Size(32, 18)
        Me.bt_couleurCasesVides.TabIndex = 4
        Me.bt_couleurCasesVides.UseVisualStyleBackColor = False
        '
        'lab_affichage
        '
        Me.lab_affichage.AutoSize = True
        Me.lab_affichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_affichage.Location = New System.Drawing.Point(1, 2)
        Me.lab_affichage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_affichage.Name = "lab_affichage"
        Me.lab_affichage.Size = New System.Drawing.Size(61, 13)
        Me.lab_affichage.TabIndex = 3
        Me.lab_affichage.Text = "Affichage"
        '
        'lab_couleurGrille
        '
        Me.lab_couleurGrille.AutoSize = True
        Me.lab_couleurGrille.Location = New System.Drawing.Point(2, 62)
        Me.lab_couleurGrille.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_couleurGrille.Name = "lab_couleurGrille"
        Me.lab_couleurGrille.Size = New System.Drawing.Size(93, 13)
        Me.lab_couleurGrille.TabIndex = 2
        Me.lab_couleurGrille.Text = "Couleur de la grille"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Couleur des cellules"
        '
        'lab_couleurCase
        '
        Me.lab_couleurCase.AutoSize = True
        Me.lab_couleurCase.Location = New System.Drawing.Point(2, 20)
        Me.lab_couleurCase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_couleurCase.Name = "lab_couleurCase"
        Me.lab_couleurCase.Size = New System.Drawing.Size(122, 13)
        Me.lab_couleurCase.TabIndex = 0
        Me.lab_couleurCase.Text = "Couleur des cases vides"
        '
        'tab_edition
        '
        Me.tab_edition.Controls.Add(Me.panel_modeles)
        Me.tab_edition.Controls.Add(Me.panel_pince)
        Me.tab_edition.Location = New System.Drawing.Point(4, 22)
        Me.tab_edition.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_edition.Name = "tab_edition"
        Me.tab_edition.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_edition.Size = New System.Drawing.Size(284, 499)
        Me.tab_edition.TabIndex = 1
        Me.tab_edition.Text = "Modèles"
        Me.tab_edition.UseVisualStyleBackColor = True
        '
        'panel_modeles
        '
        Me.panel_modeles.AutoScroll = True
        Me.panel_modeles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_modeles.Location = New System.Drawing.Point(2, 46)
        Me.panel_modeles.Name = "panel_modeles"
        Me.panel_modeles.Size = New System.Drawing.Size(280, 451)
        Me.panel_modeles.TabIndex = 6
        '
        'panel_pince
        '
        Me.panel_pince.Controls.Add(Me.lab_modeles_taille)
        Me.panel_pince.Controls.Add(Me.lab_filtre)
        Me.panel_pince.Controls.Add(Me.cbox_filtre)
        Me.panel_pince.Controls.Add(Me.lab_modeles)
        Me.panel_pince.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_pince.Location = New System.Drawing.Point(2, 2)
        Me.panel_pince.Name = "panel_pince"
        Me.panel_pince.Size = New System.Drawing.Size(280, 44)
        Me.panel_pince.TabIndex = 5
        '
        'lab_modeles_taille
        '
        Me.lab_modeles_taille.AutoSize = True
        Me.lab_modeles_taille.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_modeles_taille.Location = New System.Drawing.Point(4, 22)
        Me.lab_modeles_taille.Name = "lab_modeles_taille"
        Me.lab_modeles_taille.Size = New System.Drawing.Size(54, 13)
        Me.lab_modeles_taille.TabIndex = 3
        Me.lab_modeles_taille.Text = "Modèles"
        '
        'lab_filtre
        '
        Me.lab_filtre.AutoSize = True
        Me.lab_filtre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_filtre.Location = New System.Drawing.Point(108, 21)
        Me.lab_filtre.Name = "lab_filtre"
        Me.lab_filtre.Size = New System.Drawing.Size(35, 13)
        Me.lab_filtre.TabIndex = 2
        Me.lab_filtre.Text = "Filtre"
        '
        'cbox_filtre
        '
        Me.cbox_filtre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_filtre.FormattingEnabled = True
        Me.cbox_filtre.Location = New System.Drawing.Point(146, 19)
        Me.cbox_filtre.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_filtre.Name = "cbox_filtre"
        Me.cbox_filtre.Size = New System.Drawing.Size(132, 21)
        Me.cbox_filtre.TabIndex = 1
        '
        'lab_modeles
        '
        Me.lab_modeles.AutoSize = True
        Me.lab_modeles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_modeles.Location = New System.Drawing.Point(4, 4)
        Me.lab_modeles.Name = "lab_modeles"
        Me.lab_modeles.Size = New System.Drawing.Size(54, 13)
        Me.lab_modeles.TabIndex = 0
        Me.lab_modeles.Text = "Modèles"
        '
        'choixCouleur
        '
        Me.choixCouleur.SolidColorOnly = True
        '
        'panel_pinceaux
        '
        Me.panel_pinceaux.BackColor = System.Drawing.Color.LightGray
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauSimple)
        Me.panel_pinceaux.Controls.Add(Me.bt_remplisseur)
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauLigne)
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauColonne)
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauCroix)
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauDiagonaleD)
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauDiagonaleG)
        Me.panel_pinceaux.Controls.Add(Me.bt_pinceauDiagonales)
        Me.panel_pinceaux.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_pinceaux.Location = New System.Drawing.Point(0, 55)
        Me.panel_pinceaux.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_pinceaux.Name = "panel_pinceaux"
        Me.panel_pinceaux.Size = New System.Drawing.Size(31, 525)
        Me.panel_pinceaux.TabIndex = 4
        '
        'bt_pinceauSimple
        '
        Me.bt_pinceauSimple.BackColor = System.Drawing.Color.DarkGray
        Me.bt_pinceauSimple.FlatAppearance.BorderSize = 0
        Me.bt_pinceauSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauSimple.Image = Global.FoxGameOfLife.My.Resources.Resources.crayon
        Me.bt_pinceauSimple.Location = New System.Drawing.Point(3, 3)
        Me.bt_pinceauSimple.Name = "bt_pinceauSimple"
        Me.bt_pinceauSimple.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauSimple.TabIndex = 1
        Me.bt_pinceauSimple.UseVisualStyleBackColor = False
        '
        'bt_remplisseur
        '
        Me.bt_remplisseur.BackColor = System.Drawing.Color.LightGray
        Me.bt_remplisseur.FlatAppearance.BorderSize = 0
        Me.bt_remplisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_remplisseur.Image = Global.FoxGameOfLife.My.Resources.Resources.remplisseur
        Me.bt_remplisseur.Location = New System.Drawing.Point(3, 34)
        Me.bt_remplisseur.Name = "bt_remplisseur"
        Me.bt_remplisseur.Size = New System.Drawing.Size(25, 25)
        Me.bt_remplisseur.TabIndex = 2
        Me.bt_remplisseur.UseVisualStyleBackColor = False
        '
        'bt_pinceauLigne
        '
        Me.bt_pinceauLigne.BackColor = System.Drawing.Color.LightGray
        Me.bt_pinceauLigne.FlatAppearance.BorderSize = 0
        Me.bt_pinceauLigne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauLigne.Image = Global.FoxGameOfLife.My.Resources.Resources.pinceau_ligne
        Me.bt_pinceauLigne.Location = New System.Drawing.Point(3, 65)
        Me.bt_pinceauLigne.Name = "bt_pinceauLigne"
        Me.bt_pinceauLigne.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauLigne.TabIndex = 3
        Me.bt_pinceauLigne.UseVisualStyleBackColor = False
        '
        'bt_pinceauColonne
        '
        Me.bt_pinceauColonne.BackColor = System.Drawing.Color.LightGray
        Me.bt_pinceauColonne.FlatAppearance.BorderSize = 0
        Me.bt_pinceauColonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauColonne.Image = Global.FoxGameOfLife.My.Resources.Resources.pinceau_colonne
        Me.bt_pinceauColonne.Location = New System.Drawing.Point(3, 96)
        Me.bt_pinceauColonne.Name = "bt_pinceauColonne"
        Me.bt_pinceauColonne.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauColonne.TabIndex = 4
        Me.bt_pinceauColonne.UseVisualStyleBackColor = False
        '
        'bt_pinceauCroix
        '
        Me.bt_pinceauCroix.BackColor = System.Drawing.Color.LightGray
        Me.bt_pinceauCroix.FlatAppearance.BorderSize = 0
        Me.bt_pinceauCroix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauCroix.Image = Global.FoxGameOfLife.My.Resources.Resources.croix2
        Me.bt_pinceauCroix.Location = New System.Drawing.Point(3, 127)
        Me.bt_pinceauCroix.Name = "bt_pinceauCroix"
        Me.bt_pinceauCroix.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauCroix.TabIndex = 5
        Me.bt_pinceauCroix.UseVisualStyleBackColor = False
        '
        'bt_pinceauDiagonaleD
        '
        Me.bt_pinceauDiagonaleD.BackColor = System.Drawing.Color.LightGray
        Me.bt_pinceauDiagonaleD.FlatAppearance.BorderSize = 0
        Me.bt_pinceauDiagonaleD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauDiagonaleD.Image = Global.FoxGameOfLife.My.Resources.Resources.diagonale_droite
        Me.bt_pinceauDiagonaleD.Location = New System.Drawing.Point(3, 158)
        Me.bt_pinceauDiagonaleD.Name = "bt_pinceauDiagonaleD"
        Me.bt_pinceauDiagonaleD.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauDiagonaleD.TabIndex = 6
        Me.bt_pinceauDiagonaleD.UseVisualStyleBackColor = False
        '
        'bt_pinceauDiagonaleG
        '
        Me.bt_pinceauDiagonaleG.BackColor = System.Drawing.Color.LightGray
        Me.bt_pinceauDiagonaleG.FlatAppearance.BorderSize = 0
        Me.bt_pinceauDiagonaleG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauDiagonaleG.Image = Global.FoxGameOfLife.My.Resources.Resources.diagonale_gauche
        Me.bt_pinceauDiagonaleG.Location = New System.Drawing.Point(3, 189)
        Me.bt_pinceauDiagonaleG.Name = "bt_pinceauDiagonaleG"
        Me.bt_pinceauDiagonaleG.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauDiagonaleG.TabIndex = 7
        Me.bt_pinceauDiagonaleG.UseVisualStyleBackColor = False
        '
        'bt_pinceauDiagonales
        '
        Me.bt_pinceauDiagonales.BackColor = System.Drawing.Color.LightGray
        Me.bt_pinceauDiagonales.FlatAppearance.BorderSize = 0
        Me.bt_pinceauDiagonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_pinceauDiagonales.Image = Global.FoxGameOfLife.My.Resources.Resources.croix
        Me.bt_pinceauDiagonales.Location = New System.Drawing.Point(3, 220)
        Me.bt_pinceauDiagonales.Name = "bt_pinceauDiagonales"
        Me.bt_pinceauDiagonales.Size = New System.Drawing.Size(25, 25)
        Me.bt_pinceauDiagonales.TabIndex = 8
        Me.bt_pinceauDiagonales.UseVisualStyleBackColor = False
        '
        'cmenu_Modeles
        '
        Me.cmenu_Modeles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmenu_Modeles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_supprimerModele})
        Me.cmenu_Modeles.Name = "cmenu_Modeles"
        Me.cmenu_Modeles.Size = New System.Drawing.Size(134, 30)
        '
        'tsm_supprimerModele
        '
        Me.tsm_supprimerModele.Image = Global.FoxGameOfLife.My.Resources.Resources.poubelle
        Me.tsm_supprimerModele.Name = "tsm_supprimerModele"
        Me.tsm_supprimerModele.Size = New System.Drawing.Size(133, 26)
        Me.tsm_supprimerModele.Text = "Supprimer"
        '
        'ss_info
        '
        Me.ss_info.BackColor = System.Drawing.Color.Gainsboro
        Me.ss_info.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ss_info.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_coord, Me.lab_population, Me.lab_tempsGeneration, Me.lab_frame})
        Me.ss_info.Location = New System.Drawing.Point(0, 614)
        Me.ss_info.Name = "ss_info"
        Me.ss_info.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.ss_info.Size = New System.Drawing.Size(976, 22)
        Me.ss_info.TabIndex = 5
        Me.ss_info.Text = "StatusStrip1"
        '
        'tss_coord
        '
        Me.tss_coord.Name = "tss_coord"
        Me.tss_coord.Size = New System.Drawing.Size(51, 17)
        Me.tss_coord.Text = "x : 0 y : 0"
        '
        'lab_population
        '
        Me.lab_population.Name = "lab_population"
        Me.lab_population.Size = New System.Drawing.Size(80, 17)
        Me.lab_population.Text = "Population : 0"
        '
        'lab_tempsGeneration
        '
        Me.lab_tempsGeneration.Name = "lab_tempsGeneration"
        Me.lab_tempsGeneration.Size = New System.Drawing.Size(152, 17)
        Me.lab_tempsGeneration.Text = "Temps de génération : 0 ms"
        '
        'lab_frame
        '
        Me.lab_frame.Name = "lab_frame"
        Me.lab_frame.Size = New System.Drawing.Size(55, 17)
        Me.lab_frame.Text = "Frame : 0"
        '
        'panel_commandes
        '
        Me.panel_commandes.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_commandes.Controls.Add(Me.cbox_commandeGarder)
        Me.panel_commandes.Controls.Add(Me.bt_commande)
        Me.panel_commandes.Controls.Add(Me.txtb_commande)
        Me.panel_commandes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_commandes.Location = New System.Drawing.Point(0, 580)
        Me.panel_commandes.Margin = New System.Windows.Forms.Padding(2)
        Me.panel_commandes.Name = "panel_commandes"
        Me.panel_commandes.Size = New System.Drawing.Size(976, 34)
        Me.panel_commandes.TabIndex = 6
        '
        'cbox_commandeGarder
        '
        Me.cbox_commandeGarder.AutoSize = True
        Me.cbox_commandeGarder.Location = New System.Drawing.Point(334, 9)
        Me.cbox_commandeGarder.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_commandeGarder.Name = "cbox_commandeGarder"
        Me.cbox_commandeGarder.Size = New System.Drawing.Size(146, 17)
        Me.cbox_commandeGarder.TabIndex = 2
        Me.cbox_commandeGarder.Text = "Garder le panneau visible"
        Me.cbox_commandeGarder.UseVisualStyleBackColor = True
        '
        'bt_commande
        '
        Me.bt_commande.BackColor = System.Drawing.Color.Silver
        Me.bt_commande.FlatAppearance.BorderSize = 0
        Me.bt_commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_commande.Location = New System.Drawing.Point(238, 4)
        Me.bt_commande.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_commande.Name = "bt_commande"
        Me.bt_commande.Size = New System.Drawing.Size(83, 25)
        Me.bt_commande.TabIndex = 1
        Me.bt_commande.Text = "Exécuter"
        Me.bt_commande.UseVisualStyleBackColor = False
        '
        'txtb_commande
        '
        Me.txtb_commande.Location = New System.Drawing.Point(5, 7)
        Me.txtb_commande.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_commande.Name = "txtb_commande"
        Me.txtb_commande.Size = New System.Drawing.Size(228, 20)
        Me.txtb_commande.TabIndex = 0
        '
        'dialogOuvrirFichier
        '
        Me.dialogOuvrirFichier.FileName = "fichier.lif"
        Me.dialogOuvrirFichier.Title = "Ouvrir un fichier Lif"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 636)
        Me.Controls.Add(Me.panel_contenu)
        Me.Controls.Add(Me.panel_pinceaux)
        Me.Controls.Add(Me.panel_outils)
        Me.Controls.Add(Me.menu_outils)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.panel_commandes)
        Me.Controls.Add(Me.ss_info)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZGameOfLife"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_contenu.ResumeLayout(False)
        CType(Me.pbox_plateau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.menu_outils.ResumeLayout(False)
        Me.menu_outils.PerformLayout()
        Me.panel_outils.ResumeLayout(False)
        Me.tab_contenu.ResumeLayout(False)
        Me.tab_.ResumeLayout(False)
        Me.tab_.PerformLayout()
        CType(Me.num_textePositionY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_textePositionX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_arretframe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tempsSimulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tailleCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_edition.ResumeLayout(False)
        Me.panel_pince.ResumeLayout(False)
        Me.panel_pince.PerformLayout()
        Me.panel_pinceaux.ResumeLayout(False)
        Me.cmenu_Modeles.ResumeLayout(False)
        Me.ss_info.ResumeLayout(False)
        Me.ss_info.PerformLayout()
        Me.panel_commandes.ResumeLayout(False)
        Me.panel_commandes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_contenu As Panel
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents tsm_fichier As ToolStripMenuItem
    Friend WithEvents menu_outils As ToolStrip
    Friend WithEvents tsm_play As ToolStripButton
    Friend WithEvents tsm_pause As ToolStripButton
    Friend WithEvents tsm_stop As ToolStripButton
    Friend WithEvents temps_simulation As Timer
    Friend WithEvents tsm_quitter As ToolStripMenuItem
    Friend WithEvents tsm_framesuivante As ToolStripButton
    Friend WithEvents tsm_effacer As ToolStripButton
    Friend WithEvents tsm_parametresAnimation As ToolStripButton
    Friend WithEvents tsm_plus As ToolStripMenuItem
    Friend WithEvents bt_enregistrerAnimation As ToolStripButton
    Friend WithEvents sep_animation As ToolStripSeparator
    Friend WithEvents tsm_enregistrersous As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents panel_outils As Panel
    Friend WithEvents tsm_enregistrerModele As ToolStripMenuItem
    Friend WithEvents tsm_enregistrerImage As ToolStripMenuItem
    Friend WithEvents tsm_apropos As ToolStripMenuItem
    Friend WithEvents NoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsm_repertoires As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tab_contenu As TabControl
    Friend WithEvents tab_ As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents lab_couleurCase As Label
    Friend WithEvents tab_edition As TabPage
    Friend WithEvents lab_couleurGrille As Label
    Friend WithEvents bt_couleurCasesVides As Button
    Friend WithEvents lab_affichage As Label
    Friend WithEvents lab_regles As Label
    Friend WithEvents bt_couleurGrille As Button
    Friend WithEvents bt_couleurCellules As Button
    Friend WithEvents cbox_survie8 As CheckBox
    Friend WithEvents cbox_survie7 As CheckBox
    Friend WithEvents cbox_survie6 As CheckBox
    Friend WithEvents cbox_survie5 As CheckBox
    Friend WithEvents cbox_survie4 As CheckBox
    Friend WithEvents cbox_survie3 As CheckBox
    Friend WithEvents cbox_survie2 As CheckBox
    Friend WithEvents cbox_survie1 As CheckBox
    Friend WithEvents cbox_survie0 As CheckBox
    Friend WithEvents lab_survie As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents num_tailleCases As NumericUpDown
    Friend WithEvents lab_tailleCase As Label
    Friend WithEvents cbox_creation8 As CheckBox
    Friend WithEvents cbox_creation7 As CheckBox
    Friend WithEvents cbox_creation6 As CheckBox
    Friend WithEvents cbox_creation5 As CheckBox
    Friend WithEvents cbox_creation4 As CheckBox
    Friend WithEvents cbox_creation3 As CheckBox
    Friend WithEvents cbox_creation2 As CheckBox
    Friend WithEvents cbox_creation1 As CheckBox
    Friend WithEvents cbox_creation0 As CheckBox
    Friend WithEvents lab_simulation As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents num_arretframe As NumericUpDown
    Friend WithEvents cbox_arreterSimulation As CheckBox
    Friend WithEvents lab_tempsSimulation As Label
    Friend WithEvents num_tempsSimulation As NumericUpDown
    Friend WithEvents choixCouleur As ColorDialog
    Friend WithEvents tsm_framePrecedente As ToolStripButton
    Friend WithEvents bt_reglesParDefaut As Button
    Friend WithEvents bt_pinceauSimple As Button
    Friend WithEvents lab_modeles As Label
    Friend WithEvents bt_remplisseur As Button
    Friend WithEvents bt_pinceauLigne As Button
    Friend WithEvents bt_pinceauColonne As Button
    Friend WithEvents panel_pince As Panel
    Friend WithEvents bt_pinceauCroix As Button
    Friend WithEvents bt_pinceauDiagonaleD As Button
    Friend WithEvents bt_pinceauDiagonaleG As Button
    Friend WithEvents bt_pinceauDiagonales As Button
    Friend WithEvents tsm_filtres As ToolStripMenuItem
    Friend WithEvents panel_modeles As FlowLayoutPanel
    Friend WithEvents panel_pinceaux As FlowLayoutPanel
    Friend WithEvents tsm_outils As ToolStripMenuItem
    Friend WithEvents tsm_generateurLabyrinthe As ToolStripMenuItem
    Friend WithEvents tsm_filtreInverser As ToolStripMenuItem
    Friend WithEvents tsm_filtreMelanger As ToolStripMenuItem
    Friend WithEvents tsm_filtreSymetrie As ToolStripMenuItem
    Friend WithEvents tsm_filtreEpaissir As ToolStripMenuItem
    Friend WithEvents tsm_parametres As ToolStripMenuItem
    Friend WithEvents tsm_reinitialiserParametres As ToolStripMenuItem
    Friend WithEvents tsm_repertoireFichiers As ToolStripMenuItem
    Friend WithEvents tsm_repertoireAnimations As ToolStripMenuItem
    Friend WithEvents tsm_repertoireImages As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents bt_exceptions As Button
    Friend WithEvents bt_couleurMur As Button
    Friend WithEvents lab_couleurMur As Label
    Friend WithEvents tsm_objets As ToolStripDropDownButton
    Friend WithEvents tsm_cellule As ToolStripMenuItem
    Friend WithEvents tsm_vide As ToolStripMenuItem
    Friend WithEvents tsm_mur As ToolStripMenuItem
    Friend WithEvents tsm_enregistrerpreset As ToolStripMenuItem
    Friend WithEvents tsm_presets As ToolStripMenuItem
    Friend WithEvents lab_filtre As Label
    Friend WithEvents cbox_filtre As ComboBox
    Friend WithEvents cmenu_Modeles As ContextMenuStrip
    Friend WithEvents tsm_supprimerModele As ToolStripMenuItem
    Friend WithEvents lab_modeles_taille As Label
    Friend WithEvents tsm_affichage As ToolStripMenuItem
    Friend WithEvents tsm_afficherPinceaux As ToolStripMenuItem
    Friend WithEvents tsm_afficherParametres As ToolStripMenuItem
    Friend WithEvents tsm_utiliserReperes As ToolStripMenuItem
    Friend WithEvents ss_info As StatusStrip
    Friend WithEvents tss_coord As ToolStripStatusLabel
    Friend WithEvents tsm_afficherStatus As ToolStripMenuItem
    Friend WithEvents tsm_cellulePermanente As ToolStripMenuItem
    Friend WithEvents tsm_enregistrerLIF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsm_afficherGrille As ToolStripMenuItem
    Friend WithEvents tsm_raccourcis As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsm_themeSombre As ToolStripMenuItem
    Friend WithEvents tsm_modeleRotationDroite As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsm_rotationModeleGauche As ToolStripButton
    Friend WithEvents tsm_modeleSymetrieHorizontale As ToolStripButton
    Friend WithEvents tsm_modèleSymetrieVerticale As ToolStripButton
    Friend WithEvents lab_population As ToolStripStatusLabel
    Friend WithEvents lab_tempsGeneration As ToolStripStatusLabel
    Friend WithEvents lab_frame As ToolStripStatusLabel
    Friend WithEvents tsm_nouveau As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents lab_texte As Label
    Friend WithEvents tsm_afficherTexte As ToolStripMenuItem
    Friend WithEvents bt_modifierTexte As Button
    Friend WithEvents lab_textePositionY As Label
    Friend WithEvents num_textePositionY As NumericUpDown
    Friend WithEvents lab_textePositionX As Label
    Friend WithEvents num_textePositionX As NumericUpDown
    Friend WithEvents tsm_afficherBord As ToolStripMenuItem
    Friend WithEvents bt_couleurCellulePermanente As Button
    Friend WithEvents lab_couleurCellulePermanente As Label
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsm_nombreThread As ToolStripMenuItem
    Friend WithEvents tsm_1Thread As ToolStripMenuItem
    Friend WithEvents tsm_2Thread As ToolStripMenuItem
    Friend WithEvents tsm_4Thread As ToolStripMenuItem
    Friend WithEvents tsm_0Thread As ToolStripMenuItem
    Friend WithEvents panel_commandes As Panel
    Friend WithEvents bt_commande As Button
    Friend WithEvents txtb_commande As TextBox
    Friend WithEvents tsm_commande As ToolStripMenuItem
    Friend WithEvents cbox_commandeGarder As CheckBox
    Friend WithEvents tsm_aide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsm_rechargerPresets As ToolStripMenuItem
    Friend WithEvents tsm_mesPresets As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents pbox_plateau As PictureBox
    Friend WithEvents tsm_stopKeep As ToolStripButton
    Friend WithEvents tsm_ouvrirFichierLife As ToolStripMenuItem
    Friend WithEvents dialogOuvrirFichier As OpenFileDialog
End Class
