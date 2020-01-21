<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditeurDeTexte
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
        Me.panel_outils = New System.Windows.Forms.Panel()
        Me.bt_insererThread = New System.Windows.Forms.Button()
        Me.bt_insererCellSize = New System.Windows.Forms.Button()
        Me.bt_insererHeightPx = New System.Windows.Forms.Button()
        Me.bt_insererWidthPx = New System.Windows.Forms.Button()
        Me.bt_insererHeight = New System.Windows.Forms.Button()
        Me.bt_insererWidth = New System.Windows.Forms.Button()
        Me.bt_insererUsername = New System.Windows.Forms.Button()
        Me.bt_insererFPS = New System.Windows.Forms.Button()
        Me.bt_insererRules = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.lab_options = New System.Windows.Forms.Label()
        Me.lab_variables = New System.Windows.Forms.Label()
        Me.bt_insererTime = New System.Windows.Forms.Button()
        Me.bt_insererPopulation = New System.Windows.Forms.Button()
        Me.bt_insererFrame = New System.Windows.Forms.Button()
        Me.lab_tailleTexte = New System.Windows.Forms.Label()
        Me.num_tailleTexte = New System.Windows.Forms.NumericUpDown()
        Me.bt_couleurTexte = New System.Windows.Forms.Button()
        Me.lab_couleurTexte = New System.Windows.Forms.Label()
        Me.lab_policeTexte = New System.Windows.Forms.Label()
        Me.cbox_police = New System.Windows.Forms.ComboBox()
        Me.txtb_contenu = New System.Windows.Forms.TextBox()
        Me.bt_couleurFond = New System.Windows.Forms.Button()
        Me.lab_couleurFond = New System.Windows.Forms.Label()
        Me.cbox_afficherFond = New System.Windows.Forms.CheckBox()
        Me.bt_insererNomProgramme = New System.Windows.Forms.Button()
        Me.bt_insererDev = New System.Windows.Forms.Button()
        Me.bt_insererVersion = New System.Windows.Forms.Button()
        Me.panel_outils.SuspendLayout()
        CType(Me.num_tailleTexte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_outils
        '
        Me.panel_outils.Controls.Add(Me.bt_insererVersion)
        Me.panel_outils.Controls.Add(Me.bt_insererDev)
        Me.panel_outils.Controls.Add(Me.bt_insererNomProgramme)
        Me.panel_outils.Controls.Add(Me.cbox_afficherFond)
        Me.panel_outils.Controls.Add(Me.bt_couleurFond)
        Me.panel_outils.Controls.Add(Me.lab_couleurFond)
        Me.panel_outils.Controls.Add(Me.bt_insererThread)
        Me.panel_outils.Controls.Add(Me.bt_insererCellSize)
        Me.panel_outils.Controls.Add(Me.bt_insererHeightPx)
        Me.panel_outils.Controls.Add(Me.bt_insererWidthPx)
        Me.panel_outils.Controls.Add(Me.bt_insererHeight)
        Me.panel_outils.Controls.Add(Me.bt_insererWidth)
        Me.panel_outils.Controls.Add(Me.bt_insererUsername)
        Me.panel_outils.Controls.Add(Me.bt_insererFPS)
        Me.panel_outils.Controls.Add(Me.bt_insererRules)
        Me.panel_outils.Controls.Add(Me.bt_annuler)
        Me.panel_outils.Controls.Add(Me.bt_enregistrer)
        Me.panel_outils.Controls.Add(Me.lab_options)
        Me.panel_outils.Controls.Add(Me.lab_variables)
        Me.panel_outils.Controls.Add(Me.bt_insererTime)
        Me.panel_outils.Controls.Add(Me.bt_insererPopulation)
        Me.panel_outils.Controls.Add(Me.bt_insererFrame)
        Me.panel_outils.Controls.Add(Me.lab_tailleTexte)
        Me.panel_outils.Controls.Add(Me.num_tailleTexte)
        Me.panel_outils.Controls.Add(Me.bt_couleurTexte)
        Me.panel_outils.Controls.Add(Me.lab_couleurTexte)
        Me.panel_outils.Controls.Add(Me.lab_policeTexte)
        Me.panel_outils.Controls.Add(Me.cbox_police)
        Me.panel_outils.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_outils.Location = New System.Drawing.Point(446, 0)
        Me.panel_outils.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panel_outils.Name = "panel_outils"
        Me.panel_outils.Size = New System.Drawing.Size(252, 481)
        Me.panel_outils.TabIndex = 0
        '
        'bt_insererThread
        '
        Me.bt_insererThread.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererThread.FlatAppearance.BorderSize = 0
        Me.bt_insererThread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererThread.Location = New System.Drawing.Point(132, 282)
        Me.bt_insererThread.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererThread.Name = "bt_insererThread"
        Me.bt_insererThread.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererThread.TabIndex = 73
        Me.bt_insererThread.Text = "Insérer {thread}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererThread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererThread.UseVisualStyleBackColor = False
        '
        'bt_insererCellSize
        '
        Me.bt_insererCellSize.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererCellSize.FlatAppearance.BorderSize = 0
        Me.bt_insererCellSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererCellSize.Location = New System.Drawing.Point(132, 251)
        Me.bt_insererCellSize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererCellSize.Name = "bt_insererCellSize"
        Me.bt_insererCellSize.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererCellSize.TabIndex = 72
        Me.bt_insererCellSize.Text = "Insérer {cellsize}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererCellSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererCellSize.UseVisualStyleBackColor = False
        '
        'bt_insererHeightPx
        '
        Me.bt_insererHeightPx.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererHeightPx.FlatAppearance.BorderSize = 0
        Me.bt_insererHeightPx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererHeightPx.Location = New System.Drawing.Point(132, 220)
        Me.bt_insererHeightPx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererHeightPx.Name = "bt_insererHeightPx"
        Me.bt_insererHeightPx.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererHeightPx.TabIndex = 71
        Me.bt_insererHeightPx.Text = "Insérer {heightpx}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererHeightPx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererHeightPx.UseVisualStyleBackColor = False
        '
        'bt_insererWidthPx
        '
        Me.bt_insererWidthPx.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererWidthPx.FlatAppearance.BorderSize = 0
        Me.bt_insererWidthPx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererWidthPx.Location = New System.Drawing.Point(132, 189)
        Me.bt_insererWidthPx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererWidthPx.Name = "bt_insererWidthPx"
        Me.bt_insererWidthPx.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererWidthPx.TabIndex = 70
        Me.bt_insererWidthPx.Text = "Insérer {widthpx}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererWidthPx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererWidthPx.UseVisualStyleBackColor = False
        '
        'bt_insererHeight
        '
        Me.bt_insererHeight.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererHeight.FlatAppearance.BorderSize = 0
        Me.bt_insererHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererHeight.Location = New System.Drawing.Point(18, 405)
        Me.bt_insererHeight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererHeight.Name = "bt_insererHeight"
        Me.bt_insererHeight.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererHeight.TabIndex = 69
        Me.bt_insererHeight.Text = "Insérer {height}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererHeight.UseVisualStyleBackColor = False
        '
        'bt_insererWidth
        '
        Me.bt_insererWidth.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererWidth.FlatAppearance.BorderSize = 0
        Me.bt_insererWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererWidth.Location = New System.Drawing.Point(18, 374)
        Me.bt_insererWidth.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererWidth.Name = "bt_insererWidth"
        Me.bt_insererWidth.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererWidth.TabIndex = 68
        Me.bt_insererWidth.Text = "Insérer {width}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererWidth.UseVisualStyleBackColor = False
        '
        'bt_insererUsername
        '
        Me.bt_insererUsername.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererUsername.FlatAppearance.BorderSize = 0
        Me.bt_insererUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererUsername.Location = New System.Drawing.Point(18, 343)
        Me.bt_insererUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererUsername.Name = "bt_insererUsername"
        Me.bt_insererUsername.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererUsername.TabIndex = 67
        Me.bt_insererUsername.Text = "Insérer {username}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererUsername.UseVisualStyleBackColor = False
        '
        'bt_insererFPS
        '
        Me.bt_insererFPS.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererFPS.FlatAppearance.BorderSize = 0
        Me.bt_insererFPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererFPS.Location = New System.Drawing.Point(18, 282)
        Me.bt_insererFPS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererFPS.Name = "bt_insererFPS"
        Me.bt_insererFPS.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererFPS.TabIndex = 66
        Me.bt_insererFPS.Text = "Insérer {fps}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererFPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererFPS.UseVisualStyleBackColor = False
        '
        'bt_insererRules
        '
        Me.bt_insererRules.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererRules.FlatAppearance.BorderSize = 0
        Me.bt_insererRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererRules.Location = New System.Drawing.Point(18, 313)
        Me.bt_insererRules.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererRules.Name = "bt_insererRules"
        Me.bt_insererRules.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererRules.TabIndex = 65
        Me.bt_insererRules.Text = "Insérer {rules}" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererRules.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Coral
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(18, 447)
        Me.bt_annuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(109, 26)
        Me.bt_annuler.TabIndex = 64
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.LightGreen
        Me.bt_enregistrer.FlatAppearance.BorderSize = 0
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Location = New System.Drawing.Point(132, 447)
        Me.bt_enregistrer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(109, 26)
        Me.bt_enregistrer.TabIndex = 63
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'lab_options
        '
        Me.lab_options.AutoSize = True
        Me.lab_options.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_options.Location = New System.Drawing.Point(9, 7)
        Me.lab_options.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_options.Name = "lab_options"
        Me.lab_options.Size = New System.Drawing.Size(50, 13)
        Me.lab_options.TabIndex = 62
        Me.lab_options.Text = "Options"
        '
        'lab_variables
        '
        Me.lab_variables.AutoSize = True
        Me.lab_variables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_variables.Location = New System.Drawing.Point(11, 167)
        Me.lab_variables.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_variables.Name = "lab_variables"
        Me.lab_variables.Size = New System.Drawing.Size(59, 13)
        Me.lab_variables.TabIndex = 61
        Me.lab_variables.Text = "Variables"
        '
        'bt_insererTime
        '
        Me.bt_insererTime.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererTime.FlatAppearance.BorderSize = 0
        Me.bt_insererTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererTime.Location = New System.Drawing.Point(19, 251)
        Me.bt_insererTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererTime.Name = "bt_insererTime"
        Me.bt_insererTime.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererTime.TabIndex = 60
        Me.bt_insererTime.Text = "Insérer {time}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererTime.UseVisualStyleBackColor = False
        '
        'bt_insererPopulation
        '
        Me.bt_insererPopulation.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererPopulation.FlatAppearance.BorderSize = 0
        Me.bt_insererPopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererPopulation.Location = New System.Drawing.Point(18, 220)
        Me.bt_insererPopulation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererPopulation.Name = "bt_insererPopulation"
        Me.bt_insererPopulation.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererPopulation.TabIndex = 59
        Me.bt_insererPopulation.Text = "Insérer {population}"
        Me.bt_insererPopulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererPopulation.UseVisualStyleBackColor = False
        '
        'bt_insererFrame
        '
        Me.bt_insererFrame.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererFrame.FlatAppearance.BorderSize = 0
        Me.bt_insererFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererFrame.Location = New System.Drawing.Point(18, 189)
        Me.bt_insererFrame.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_insererFrame.Name = "bt_insererFrame"
        Me.bt_insererFrame.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererFrame.TabIndex = 58
        Me.bt_insererFrame.Text = "Insérer {frame}"
        Me.bt_insererFrame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererFrame.UseVisualStyleBackColor = False
        '
        'lab_tailleTexte
        '
        Me.lab_tailleTexte.AutoSize = True
        Me.lab_tailleTexte.Location = New System.Drawing.Point(15, 75)
        Me.lab_tailleTexte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_tailleTexte.Name = "lab_tailleTexte"
        Me.lab_tailleTexte.Size = New System.Drawing.Size(73, 13)
        Me.lab_tailleTexte.TabIndex = 57
        Me.lab_tailleTexte.Text = "Taille du texte"
        '
        'num_tailleTexte
        '
        Me.num_tailleTexte.Location = New System.Drawing.Point(104, 72)
        Me.num_tailleTexte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.num_tailleTexte.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_tailleTexte.Name = "num_tailleTexte"
        Me.num_tailleTexte.Size = New System.Drawing.Size(71, 20)
        Me.num_tailleTexte.TabIndex = 56
        Me.num_tailleTexte.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'bt_couleurTexte
        '
        Me.bt_couleurTexte.BackColor = System.Drawing.Color.White
        Me.bt_couleurTexte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurTexte.Location = New System.Drawing.Point(104, 50)
        Me.bt_couleurTexte.Name = "bt_couleurTexte"
        Me.bt_couleurTexte.Size = New System.Drawing.Size(34, 18)
        Me.bt_couleurTexte.TabIndex = 55
        Me.bt_couleurTexte.UseVisualStyleBackColor = False
        '
        'lab_couleurTexte
        '
        Me.lab_couleurTexte.AutoSize = True
        Me.lab_couleurTexte.Location = New System.Drawing.Point(15, 51)
        Me.lab_couleurTexte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_couleurTexte.Name = "lab_couleurTexte"
        Me.lab_couleurTexte.Size = New System.Drawing.Size(84, 13)
        Me.lab_couleurTexte.TabIndex = 54
        Me.lab_couleurTexte.Text = "Couleur du texte"
        '
        'lab_policeTexte
        '
        Me.lab_policeTexte.AutoSize = True
        Me.lab_policeTexte.Location = New System.Drawing.Point(16, 26)
        Me.lab_policeTexte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_policeTexte.Name = "lab_policeTexte"
        Me.lab_policeTexte.Size = New System.Drawing.Size(36, 13)
        Me.lab_policeTexte.TabIndex = 53
        Me.lab_policeTexte.Text = "Police"
        '
        'cbox_police
        '
        Me.cbox_police.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_police.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbox_police.FormattingEnabled = True
        Me.cbox_police.Location = New System.Drawing.Point(55, 24)
        Me.cbox_police.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbox_police.Name = "cbox_police"
        Me.cbox_police.Size = New System.Drawing.Size(189, 21)
        Me.cbox_police.TabIndex = 52
        '
        'txtb_contenu
        '
        Me.txtb_contenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtb_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtb_contenu.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtb_contenu.Location = New System.Drawing.Point(0, 0)
        Me.txtb_contenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtb_contenu.Multiline = True
        Me.txtb_contenu.Name = "txtb_contenu"
        Me.txtb_contenu.Size = New System.Drawing.Size(446, 481)
        Me.txtb_contenu.TabIndex = 1
        '
        'bt_couleurFond
        '
        Me.bt_couleurFond.BackColor = System.Drawing.Color.White
        Me.bt_couleurFond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_couleurFond.Location = New System.Drawing.Point(104, 134)
        Me.bt_couleurFond.Name = "bt_couleurFond"
        Me.bt_couleurFond.Size = New System.Drawing.Size(34, 18)
        Me.bt_couleurFond.TabIndex = 75
        Me.bt_couleurFond.UseVisualStyleBackColor = False
        '
        'lab_couleurFond
        '
        Me.lab_couleurFond.AutoSize = True
        Me.lab_couleurFond.Location = New System.Drawing.Point(15, 136)
        Me.lab_couleurFond.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_couleurFond.Name = "lab_couleurFond"
        Me.lab_couleurFond.Size = New System.Drawing.Size(84, 13)
        Me.lab_couleurFond.TabIndex = 74
        Me.lab_couleurFond.Text = "Couleur du texte"
        '
        'cbox_afficherFond
        '
        Me.cbox_afficherFond.AutoSize = True
        Me.cbox_afficherFond.Location = New System.Drawing.Point(17, 110)
        Me.cbox_afficherFond.Name = "cbox_afficherFond"
        Me.cbox_afficherFond.Size = New System.Drawing.Size(191, 17)
        Me.cbox_afficherFond.TabIndex = 76
        Me.cbox_afficherFond.Text = "Afficher la couleur de fond du texte"
        Me.cbox_afficherFond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbox_afficherFond.UseVisualStyleBackColor = True
        '
        'bt_insererNomProgramme
        '
        Me.bt_insererNomProgramme.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererNomProgramme.FlatAppearance.BorderSize = 0
        Me.bt_insererNomProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererNomProgramme.Location = New System.Drawing.Point(131, 343)
        Me.bt_insererNomProgramme.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_insererNomProgramme.Name = "bt_insererNomProgramme"
        Me.bt_insererNomProgramme.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererNomProgramme.TabIndex = 77
        Me.bt_insererNomProgramme.Text = "Insérer {program}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererNomProgramme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererNomProgramme.UseVisualStyleBackColor = False
        '
        'bt_insererDev
        '
        Me.bt_insererDev.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererDev.FlatAppearance.BorderSize = 0
        Me.bt_insererDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererDev.Location = New System.Drawing.Point(131, 374)
        Me.bt_insererDev.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_insererDev.Name = "bt_insererDev"
        Me.bt_insererDev.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererDev.TabIndex = 78
        Me.bt_insererDev.Text = "Insérer {dev}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererDev.UseVisualStyleBackColor = False
        '
        'bt_insererVersion
        '
        Me.bt_insererVersion.BackColor = System.Drawing.Color.LightGray
        Me.bt_insererVersion.FlatAppearance.BorderSize = 0
        Me.bt_insererVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_insererVersion.Location = New System.Drawing.Point(131, 405)
        Me.bt_insererVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_insererVersion.Name = "bt_insererVersion"
        Me.bt_insererVersion.Size = New System.Drawing.Size(109, 26)
        Me.bt_insererVersion.TabIndex = 79
        Me.bt_insererVersion.Text = "Insérer {version}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.bt_insererVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_insererVersion.UseVisualStyleBackColor = False
        '
        'EditeurDeTexte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 481)
        Me.Controls.Add(Me.txtb_contenu)
        Me.Controls.Add(Me.panel_outils)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "EditeurDeTexte"
        Me.Text = "Texte"
        Me.panel_outils.ResumeLayout(False)
        Me.panel_outils.PerformLayout()
        CType(Me.num_tailleTexte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_outils As Panel
    Friend WithEvents txtb_contenu As TextBox
    Friend WithEvents lab_tailleTexte As Label
    Friend WithEvents num_tailleTexte As NumericUpDown
    Friend WithEvents bt_couleurTexte As Button
    Friend WithEvents lab_couleurTexte As Label
    Friend WithEvents lab_policeTexte As Label
    Friend WithEvents cbox_police As ComboBox
    Friend WithEvents bt_insererPopulation As Button
    Friend WithEvents bt_insererFrame As Button
    Friend WithEvents bt_insererTime As Button
    Friend WithEvents lab_options As Label
    Friend WithEvents lab_variables As Label
    Friend WithEvents bt_annuler As Button
    Friend WithEvents bt_enregistrer As Button
    Friend WithEvents bt_insererFPS As Button
    Friend WithEvents bt_insererRules As Button
    Friend WithEvents bt_insererUsername As Button
    Friend WithEvents bt_insererHeight As Button
    Friend WithEvents bt_insererWidth As Button
    Friend WithEvents bt_insererHeightPx As Button
    Friend WithEvents bt_insererWidthPx As Button
    Friend WithEvents bt_insererCellSize As Button
    Friend WithEvents bt_insererThread As Button
    Friend WithEvents cbox_afficherFond As CheckBox
    Friend WithEvents bt_couleurFond As Button
    Friend WithEvents lab_couleurFond As Label
    Friend WithEvents bt_insererNomProgramme As Button
    Friend WithEvents bt_insererDev As Button
    Friend WithEvents bt_insererVersion As Button
End Class
