<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_EnregistrerLife
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
        Me.lab_description = New System.Windows.Forms.Label()
        Me.txtb_description = New System.Windows.Forms.TextBox()
        Me.lab_nomFichier = New System.Windows.Forms.Label()
        Me.txtb_nomFichier = New System.Windows.Forms.TextBox()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lab_description
        '
        Me.lab_description.AutoSize = True
        Me.lab_description.Location = New System.Drawing.Point(12, 9)
        Me.lab_description.Name = "lab_description"
        Me.lab_description.Size = New System.Drawing.Size(141, 17)
        Me.lab_description.TabIndex = 0
        Me.lab_description.Text = "Description du fichier"
        '
        'txtb_description
        '
        Me.txtb_description.Location = New System.Drawing.Point(12, 36)
        Me.txtb_description.Multiline = True
        Me.txtb_description.Name = "txtb_description"
        Me.txtb_description.Size = New System.Drawing.Size(466, 162)
        Me.txtb_description.TabIndex = 1
        '
        'lab_nomFichier
        '
        Me.lab_nomFichier.AutoSize = True
        Me.lab_nomFichier.Location = New System.Drawing.Point(12, 205)
        Me.lab_nomFichier.Name = "lab_nomFichier"
        Me.lab_nomFichier.Size = New System.Drawing.Size(99, 17)
        Me.lab_nomFichier.TabIndex = 2
        Me.lab_nomFichier.Text = "Nom du fichier"
        '
        'txtb_nomFichier
        '
        Me.txtb_nomFichier.Location = New System.Drawing.Point(12, 229)
        Me.txtb_nomFichier.Name = "txtb_nomFichier"
        Me.txtb_nomFichier.Size = New System.Drawing.Size(466, 22)
        Me.txtb_nomFichier.TabIndex = 3
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Coral
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(12, 265)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(145, 32)
        Me.bt_annuler.TabIndex = 66
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.LightGreen
        Me.bt_enregistrer.FlatAppearance.BorderSize = 0
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Location = New System.Drawing.Point(333, 265)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(145, 32)
        Me.bt_enregistrer.TabIndex = 65
        Me.bt_enregistrer.Text = "Enregistrer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'form_EnregistrerLife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 305)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.bt_enregistrer)
        Me.Controls.Add(Me.txtb_nomFichier)
        Me.Controls.Add(Me.lab_nomFichier)
        Me.Controls.Add(Me.txtb_description)
        Me.Controls.Add(Me.lab_description)
        Me.Name = "form_EnregistrerLife"
        Me.Text = "Enregistrer au format fichier life"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_description As Label
    Friend WithEvents txtb_description As TextBox
    Friend WithEvents lab_nomFichier As Label
    Friend WithEvents txtb_nomFichier As TextBox
    Friend WithEvents bt_annuler As Button
    Friend WithEvents bt_enregistrer As Button
End Class
