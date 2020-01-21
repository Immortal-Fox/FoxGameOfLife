<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametresPlateau
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
        Me.num_largeur = New System.Windows.Forms.NumericUpDown()
        Me.lab_largeur = New System.Windows.Forms.Label()
        Me.lab_hauteur = New System.Windows.Forms.Label()
        Me.num_hauteur = New System.Windows.Forms.NumericUpDown()
        Me.lab_taillecase = New System.Windows.Forms.Label()
        Me.num_tailleCases = New System.Windows.Forms.NumericUpDown()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.bt_appliquer = New System.Windows.Forms.Button()
        CType(Me.num_largeur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_hauteur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tailleCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'num_largeur
        '
        Me.num_largeur.Location = New System.Drawing.Point(164, 10)
        Me.num_largeur.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.num_largeur.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_largeur.Name = "num_largeur"
        Me.num_largeur.Size = New System.Drawing.Size(91, 20)
        Me.num_largeur.TabIndex = 0
        Me.num_largeur.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lab_largeur
        '
        Me.lab_largeur.AutoSize = True
        Me.lab_largeur.Location = New System.Drawing.Point(9, 12)
        Me.lab_largeur.Name = "lab_largeur"
        Me.lab_largeur.Size = New System.Drawing.Size(149, 13)
        Me.lab_largeur.TabIndex = 1
        Me.lab_largeur.Text = "Nombre de cases en largeur : "
        '
        'lab_hauteur
        '
        Me.lab_hauteur.AutoSize = True
        Me.lab_hauteur.Location = New System.Drawing.Point(9, 34)
        Me.lab_hauteur.Name = "lab_hauteur"
        Me.lab_hauteur.Size = New System.Drawing.Size(153, 13)
        Me.lab_hauteur.TabIndex = 3
        Me.lab_hauteur.Text = "Nombre de cases en hauteur : "
        '
        'num_hauteur
        '
        Me.num_hauteur.Location = New System.Drawing.Point(164, 32)
        Me.num_hauteur.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.num_hauteur.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_hauteur.Name = "num_hauteur"
        Me.num_hauteur.Size = New System.Drawing.Size(91, 20)
        Me.num_hauteur.TabIndex = 2
        Me.num_hauteur.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lab_taillecase
        '
        Me.lab_taillecase.AutoSize = True
        Me.lab_taillecase.Location = New System.Drawing.Point(9, 73)
        Me.lab_taillecase.Name = "lab_taillecase"
        Me.lab_taillecase.Size = New System.Drawing.Size(137, 13)
        Me.lab_taillecase.TabIndex = 4
        Me.lab_taillecase.Text = "Taille en pixels d'une case :"
        '
        'num_tailleCases
        '
        Me.num_tailleCases.Location = New System.Drawing.Point(164, 71)
        Me.num_tailleCases.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.num_tailleCases.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_tailleCases.Name = "num_tailleCases"
        Me.num_tailleCases.Size = New System.Drawing.Size(91, 20)
        Me.num_tailleCases.TabIndex = 5
        Me.num_tailleCases.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Tomato
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(12, 115)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(99, 27)
        Me.bt_annuler.TabIndex = 6
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'bt_appliquer
        '
        Me.bt_appliquer.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.bt_appliquer.FlatAppearance.BorderSize = 0
        Me.bt_appliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_appliquer.Location = New System.Drawing.Point(156, 115)
        Me.bt_appliquer.Name = "bt_appliquer"
        Me.bt_appliquer.Size = New System.Drawing.Size(99, 27)
        Me.bt_appliquer.TabIndex = 7
        Me.bt_appliquer.Text = "Appliquer"
        Me.bt_appliquer.UseVisualStyleBackColor = False
        '
        'ParametresPlateau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 154)
        Me.Controls.Add(Me.bt_appliquer)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.num_tailleCases)
        Me.Controls.Add(Me.lab_taillecase)
        Me.Controls.Add(Me.lab_hauteur)
        Me.Controls.Add(Me.num_hauteur)
        Me.Controls.Add(Me.lab_largeur)
        Me.Controls.Add(Me.num_largeur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ParametresPlateau"
        Me.Text = "Paramètres du plateau"
        CType(Me.num_largeur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_hauteur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tailleCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num_largeur As NumericUpDown
    Friend WithEvents lab_largeur As Label
    Friend WithEvents lab_hauteur As Label
    Friend WithEvents num_hauteur As NumericUpDown
    Friend WithEvents lab_taillecase As Label
    Friend WithEvents num_tailleCases As NumericUpDown
    Friend WithEvents bt_annuler As Button
    Friend WithEvents bt_appliquer As Button
End Class
