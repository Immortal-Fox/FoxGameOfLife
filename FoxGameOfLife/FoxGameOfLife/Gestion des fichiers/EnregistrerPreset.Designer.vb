<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnregistrerPreset
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
        Me.lab_nom = New System.Windows.Forms.Label()
        Me.txtb_nom = New System.Windows.Forms.TextBox()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.cbox_enregistrerRegles = New System.Windows.Forms.CheckBox()
        Me.cbox_enregistrerFormat = New System.Windows.Forms.CheckBox()
        Me.cbox_enregistrerRaccourcis = New System.Windows.Forms.CheckBox()
        Me.cbox_enregistrerTexte = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lab_nom
        '
        Me.lab_nom.AutoSize = True
        Me.lab_nom.Location = New System.Drawing.Point(11, 14)
        Me.lab_nom.Name = "lab_nom"
        Me.lab_nom.Size = New System.Drawing.Size(113, 17)
        Me.lab_nom.TabIndex = 0
        Me.lab_nom.Text = "Nom du preset : "
        '
        'txtb_nom
        '
        Me.txtb_nom.Location = New System.Drawing.Point(121, 12)
        Me.txtb_nom.Name = "txtb_nom"
        Me.txtb_nom.Size = New System.Drawing.Size(276, 22)
        Me.txtb_nom.TabIndex = 1
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Coral
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(121, 171)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(145, 32)
        Me.bt_annuler.TabIndex = 68
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.LightGreen
        Me.bt_enregistrer.FlatAppearance.BorderSize = 0
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Location = New System.Drawing.Point(274, 171)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(145, 32)
        Me.bt_enregistrer.TabIndex = 67
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'cbox_enregistrerRegles
        '
        Me.cbox_enregistrerRegles.AutoSize = True
        Me.cbox_enregistrerRegles.Location = New System.Drawing.Point(121, 48)
        Me.cbox_enregistrerRegles.Name = "cbox_enregistrerRegles"
        Me.cbox_enregistrerRegles.Size = New System.Drawing.Size(165, 21)
        Me.cbox_enregistrerRegles.TabIndex = 69
        Me.cbox_enregistrerRegles.Text = "Enregistrer les règles"
        Me.cbox_enregistrerRegles.UseVisualStyleBackColor = True
        '
        'cbox_enregistrerFormat
        '
        Me.cbox_enregistrerFormat.AutoSize = True
        Me.cbox_enregistrerFormat.Location = New System.Drawing.Point(121, 75)
        Me.cbox_enregistrerFormat.Name = "cbox_enregistrerFormat"
        Me.cbox_enregistrerFormat.Size = New System.Drawing.Size(229, 21)
        Me.cbox_enregistrerFormat.TabIndex = 70
        Me.cbox_enregistrerFormat.Text = "Enregistrer les mises en formes"
        Me.cbox_enregistrerFormat.UseVisualStyleBackColor = True
        '
        'cbox_enregistrerRaccourcis
        '
        Me.cbox_enregistrerRaccourcis.AutoSize = True
        Me.cbox_enregistrerRaccourcis.Location = New System.Drawing.Point(121, 129)
        Me.cbox_enregistrerRaccourcis.Name = "cbox_enregistrerRaccourcis"
        Me.cbox_enregistrerRaccourcis.Size = New System.Drawing.Size(191, 21)
        Me.cbox_enregistrerRaccourcis.TabIndex = 71
        Me.cbox_enregistrerRaccourcis.Text = "Enregistrer les raccourcis"
        Me.cbox_enregistrerRaccourcis.UseVisualStyleBackColor = True
        '
        'cbox_enregistrerTexte
        '
        Me.cbox_enregistrerTexte.AutoSize = True
        Me.cbox_enregistrerTexte.Location = New System.Drawing.Point(121, 102)
        Me.cbox_enregistrerTexte.Name = "cbox_enregistrerTexte"
        Me.cbox_enregistrerTexte.Size = New System.Drawing.Size(149, 21)
        Me.cbox_enregistrerTexte.TabIndex = 72
        Me.cbox_enregistrerTexte.Text = "Enregistrer le texte"
        Me.cbox_enregistrerTexte.UseVisualStyleBackColor = True
        '
        'EnregistrerPreset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 219)
        Me.Controls.Add(Me.cbox_enregistrerTexte)
        Me.Controls.Add(Me.cbox_enregistrerRaccourcis)
        Me.Controls.Add(Me.cbox_enregistrerFormat)
        Me.Controls.Add(Me.cbox_enregistrerRegles)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.txtb_nom)
        Me.Controls.Add(Me.lab_nom)
        Me.Name = "EnregistrerPreset"
        Me.Text = "EnregistrerPreset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_nom As Label
    Friend WithEvents txtb_nom As TextBox
    Friend WithEvents bt_annuler As Button
    Friend WithEvents bt_enregistrer As Button
    Friend WithEvents cbox_enregistrerRegles As CheckBox
    Friend WithEvents cbox_enregistrerFormat As CheckBox
    Friend WithEvents cbox_enregistrerRaccourcis As CheckBox
    Friend WithEvents cbox_enregistrerTexte As CheckBox
End Class
