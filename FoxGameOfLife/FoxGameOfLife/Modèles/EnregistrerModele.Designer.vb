<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnregistrerModele
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
        Me.txtb_nom = New System.Windows.Forms.TextBox()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lab_tags = New System.Windows.Forms.Label()
        Me.txtb_tag = New System.Windows.Forms.TextBox()
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.liste_tags = New System.Windows.Forms.ListBox()
        Me.bt_retirer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtb_nom
        '
        Me.txtb_nom.Location = New System.Drawing.Point(12, 226)
        Me.txtb_nom.Name = "txtb_nom"
        Me.txtb_nom.Size = New System.Drawing.Size(320, 22)
        Me.txtb_nom.TabIndex = 0
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.YellowGreen
        Me.bt_enregistrer.FlatAppearance.BorderSize = 0
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Location = New System.Drawing.Point(217, 254)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(115, 30)
        Me.bt_enregistrer.TabIndex = 1
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Coral
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(12, 254)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(115, 30)
        Me.bt_annuler.TabIndex = 2
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom du modèle"
        '
        'lab_tags
        '
        Me.lab_tags.AutoSize = True
        Me.lab_tags.Location = New System.Drawing.Point(12, 9)
        Me.lab_tags.Name = "lab_tags"
        Me.lab_tags.Size = New System.Drawing.Size(184, 17)
        Me.lab_tags.TabIndex = 4
        Me.lab_tags.Text = "Tag(s) pour filtre du modèle"
        '
        'txtb_tag
        '
        Me.txtb_tag.Location = New System.Drawing.Point(13, 29)
        Me.txtb_tag.Name = "txtb_tag"
        Me.txtb_tag.Size = New System.Drawing.Size(320, 22)
        Me.txtb_tag.TabIndex = 5
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.YellowGreen
        Me.bt_ajouter.FlatAppearance.BorderSize = 0
        Me.bt_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_ajouter.Location = New System.Drawing.Point(217, 57)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(115, 30)
        Me.bt_ajouter.TabIndex = 6
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'liste_tags
        '
        Me.liste_tags.FormattingEnabled = True
        Me.liste_tags.ItemHeight = 16
        Me.liste_tags.Location = New System.Drawing.Point(12, 97)
        Me.liste_tags.Name = "liste_tags"
        Me.liste_tags.Size = New System.Drawing.Size(320, 100)
        Me.liste_tags.TabIndex = 7
        '
        'bt_retirer
        '
        Me.bt_retirer.BackColor = System.Drawing.Color.Coral
        Me.bt_retirer.FlatAppearance.BorderSize = 0
        Me.bt_retirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_retirer.Location = New System.Drawing.Point(15, 57)
        Me.bt_retirer.Name = "bt_retirer"
        Me.bt_retirer.Size = New System.Drawing.Size(115, 30)
        Me.bt_retirer.TabIndex = 8
        Me.bt_retirer.Text = "Retirer"
        Me.bt_retirer.UseVisualStyleBackColor = False
        '
        'EnregistrerModele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 299)
        Me.Controls.Add(Me.bt_retirer)
        Me.Controls.Add(Me.liste_tags)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.txtb_tag)
        Me.Controls.Add(Me.lab_tags)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.txtb_nom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EnregistrerModele"
        Me.Text = "Enregistrer le modèle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtb_nom As TextBox
    Friend WithEvents bt_enregistrer As Button
    Friend WithEvents bt_annuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lab_tags As Label
    Friend WithEvents txtb_tag As TextBox
    Friend WithEvents bt_ajouter As Button
    Friend WithEvents liste_tags As ListBox
    Friend WithEvents bt_retirer As Button
End Class
