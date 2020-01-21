<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateurLabyrinthe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbox_randomseed = New System.Windows.Forms.CheckBox()
        Me.num_seed = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.num_y = New System.Windows.Forms.NumericUpDown()
        Me.num_x = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.num_parcourscurseur = New System.Windows.Forms.NumericUpDown()
        Me.lab_passages = New System.Windows.Forms.Label()
        Me.lab_murs = New System.Windows.Forms.Label()
        Me.lab_noeuds = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_reprendre = New System.Windows.Forms.Button()
        Me.cbox_generationpas = New System.Windows.Forms.CheckBox()
        Me.bt_stop = New System.Windows.Forms.Button()
        Me.num_tempsgen = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_generer = New System.Windows.Forms.Button()
        Me.TickGeneration = New System.Windows.Forms.Timer(Me.components)
        Me.cbox_casesvides = New System.Windows.Forms.CheckBox()
        CType(Me.num_seed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_parcourscurseur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.num_tempsgen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbox_randomseed
        '
        Me.cbox_randomseed.AutoSize = True
        Me.cbox_randomseed.Location = New System.Drawing.Point(253, 16)
        Me.cbox_randomseed.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_randomseed.Name = "cbox_randomseed"
        Me.cbox_randomseed.Size = New System.Drawing.Size(95, 17)
        Me.cbox_randomseed.TabIndex = 29
        Me.cbox_randomseed.Text = "Seed Aléatoire"
        Me.cbox_randomseed.UseVisualStyleBackColor = True
        '
        'num_seed
        '
        Me.num_seed.Location = New System.Drawing.Point(54, 13)
        Me.num_seed.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_seed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_seed.Name = "num_seed"
        Me.num_seed.Size = New System.Drawing.Size(187, 20)
        Me.num_seed.TabIndex = 28
        Me.num_seed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 16)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Seed :"
        '
        'num_y
        '
        Me.num_y.Location = New System.Drawing.Point(59, 61)
        Me.num_y.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_y.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_y.Name = "num_y"
        Me.num_y.Size = New System.Drawing.Size(69, 20)
        Me.num_y.TabIndex = 33
        Me.num_y.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'num_x
        '
        Me.num_x.Location = New System.Drawing.Point(59, 40)
        Me.num_x.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_x.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_x.Name = "num_x"
        Me.num_x.Size = New System.Drawing.Size(69, 20)
        Me.num_x.TabIndex = 32
        Me.num_x.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 64)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Point y : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Point x : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Parcours du curseur :"
        '
        'num_parcourscurseur
        '
        Me.num_parcourscurseur.Location = New System.Drawing.Point(133, 90)
        Me.num_parcourscurseur.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_parcourscurseur.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_parcourscurseur.Name = "num_parcourscurseur"
        Me.num_parcourscurseur.Size = New System.Drawing.Size(95, 20)
        Me.num_parcourscurseur.TabIndex = 34
        Me.num_parcourscurseur.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lab_passages
        '
        Me.lab_passages.AutoSize = True
        Me.lab_passages.Location = New System.Drawing.Point(366, 162)
        Me.lab_passages.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_passages.Name = "lab_passages"
        Me.lab_passages.Size = New System.Drawing.Size(13, 13)
        Me.lab_passages.TabIndex = 43
        Me.lab_passages.Text = "0"
        '
        'lab_murs
        '
        Me.lab_murs.AutoSize = True
        Me.lab_murs.Location = New System.Drawing.Point(366, 148)
        Me.lab_murs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_murs.Name = "lab_murs"
        Me.lab_murs.Size = New System.Drawing.Size(13, 13)
        Me.lab_murs.TabIndex = 42
        Me.lab_murs.Text = "0"
        '
        'lab_noeuds
        '
        Me.lab_noeuds.AutoSize = True
        Me.lab_noeuds.Location = New System.Drawing.Point(366, 135)
        Me.lab_noeuds.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_noeuds.Name = "lab_noeuds"
        Me.lab_noeuds.Size = New System.Drawing.Size(13, 13)
        Me.lab_noeuds.TabIndex = 41
        Me.lab_noeuds.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 162)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Passage(s) actif(s) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(261, 148)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Mur(s) actif(s) :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(261, 135)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Noeud(s) actif(s) :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.bt_reprendre)
        Me.Panel1.Controls.Add(Me.cbox_generationpas)
        Me.Panel1.Controls.Add(Me.bt_stop)
        Me.Panel1.Controls.Add(Me.num_tempsgen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(11, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 116)
        Me.Panel1.TabIndex = 37
        '
        'bt_reprendre
        '
        Me.bt_reprendre.BackColor = System.Drawing.Color.Silver
        Me.bt_reprendre.Enabled = False
        Me.bt_reprendre.FlatAppearance.BorderSize = 0
        Me.bt_reprendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_reprendre.Image = Global.FoxGameOfLife.My.Resources.Resources.play
        Me.bt_reprendre.Location = New System.Drawing.Point(63, 64)
        Me.bt_reprendre.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_reprendre.Name = "bt_reprendre"
        Me.bt_reprendre.Size = New System.Drawing.Size(40, 39)
        Me.bt_reprendre.TabIndex = 16
        Me.bt_reprendre.UseVisualStyleBackColor = False
        '
        'cbox_generationpas
        '
        Me.cbox_generationpas.AutoSize = True
        Me.cbox_generationpas.Checked = True
        Me.cbox_generationpas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbox_generationpas.Location = New System.Drawing.Point(10, 16)
        Me.cbox_generationpas.Name = "cbox_generationpas"
        Me.cbox_generationpas.Size = New System.Drawing.Size(127, 17)
        Me.cbox_generationpas.TabIndex = 8
        Me.cbox_generationpas.Text = "Génération pas à pas"
        Me.cbox_generationpas.UseVisualStyleBackColor = True
        '
        'bt_stop
        '
        Me.bt_stop.BackColor = System.Drawing.Color.Silver
        Me.bt_stop.Enabled = False
        Me.bt_stop.FlatAppearance.BorderSize = 0
        Me.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_stop.Image = Global.FoxGameOfLife.My.Resources.Resources._stop
        Me.bt_stop.Location = New System.Drawing.Point(10, 64)
        Me.bt_stop.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_stop.Name = "bt_stop"
        Me.bt_stop.Size = New System.Drawing.Size(40, 39)
        Me.bt_stop.TabIndex = 15
        Me.bt_stop.UseVisualStyleBackColor = False
        '
        'num_tempsgen
        '
        Me.num_tempsgen.Location = New System.Drawing.Point(149, 35)
        Me.num_tempsgen.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_tempsgen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_tempsgen.Name = "num_tempsgen"
        Me.num_tempsgen.Size = New System.Drawing.Size(68, 20)
        Me.num_tempsgen.TabIndex = 9
        Me.num_tempsgen.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Temps en ms entre les pas :"
        '
        'bt_generer
        '
        Me.bt_generer.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.bt_generer.FlatAppearance.BorderSize = 0
        Me.bt_generer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_generer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_generer.Location = New System.Drawing.Point(253, 199)
        Me.bt_generer.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_generer.Name = "bt_generer"
        Me.bt_generer.Size = New System.Drawing.Size(135, 34)
        Me.bt_generer.TabIndex = 36
        Me.bt_generer.Text = "Générer"
        Me.bt_generer.UseVisualStyleBackColor = False
        '
        'TickGeneration
        '
        Me.TickGeneration.Interval = 10
        '
        'cbox_casesvides
        '
        Me.cbox_casesvides.AutoSize = True
        Me.cbox_casesvides.Location = New System.Drawing.Point(253, 37)
        Me.cbox_casesvides.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_casesvides.Name = "cbox_casesvides"
        Me.cbox_casesvides.Size = New System.Drawing.Size(134, 17)
        Me.cbox_casesvides.TabIndex = 44
        Me.cbox_casesvides.Text = "Cases vides seulement"
        Me.cbox_casesvides.UseVisualStyleBackColor = True
        '
        'GenerateurLabyrinthe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 252)
        Me.Controls.Add(Me.cbox_casesvides)
        Me.Controls.Add(Me.lab_passages)
        Me.Controls.Add(Me.lab_murs)
        Me.Controls.Add(Me.lab_noeuds)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bt_generer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.num_parcourscurseur)
        Me.Controls.Add(Me.num_y)
        Me.Controls.Add(Me.num_x)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbox_randomseed)
        Me.Controls.Add(Me.num_seed)
        Me.Controls.Add(Me.Label12)
        Me.Name = "GenerateurLabyrinthe"
        Me.Text = "Générateur de labyrinthe"
        CType(Me.num_seed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_parcourscurseur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.num_tempsgen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbox_randomseed As CheckBox
    Friend WithEvents num_seed As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents num_y As NumericUpDown
    Friend WithEvents num_x As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents num_parcourscurseur As NumericUpDown
    Friend WithEvents lab_passages As Label
    Friend WithEvents lab_murs As Label
    Friend WithEvents lab_noeuds As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bt_reprendre As Button
    Friend WithEvents cbox_generationpas As CheckBox
    Friend WithEvents bt_stop As Button
    Friend WithEvents num_tempsgen As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_generer As Button
    Friend WithEvents TickGeneration As Timer
    Friend WithEvents cbox_casesvides As CheckBox
End Class
