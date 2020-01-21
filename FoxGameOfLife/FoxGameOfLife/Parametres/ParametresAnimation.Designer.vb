<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametresAnimation
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
        Me.cbox_enregistrerchaqueframe = New System.Windows.Forms.CheckBox()
        Me.cbox_creerGif = New System.Windows.Forms.CheckBox()
        Me.cbox_formatImage = New System.Windows.Forms.ComboBox()
        Me.lab_formatImage = New System.Windows.Forms.Label()
        Me.num_delai = New System.Windows.Forms.NumericUpDown()
        Me.lab_delai = New System.Windows.Forms.Label()
        Me.bt_appliquer = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        CType(Me.num_delai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbox_enregistrerchaqueframe
        '
        Me.cbox_enregistrerchaqueframe.AutoSize = True
        Me.cbox_enregistrerchaqueframe.Location = New System.Drawing.Point(11, 11)
        Me.cbox_enregistrerchaqueframe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbox_enregistrerchaqueframe.Name = "cbox_enregistrerchaqueframe"
        Me.cbox_enregistrerchaqueframe.Size = New System.Drawing.Size(144, 17)
        Me.cbox_enregistrerchaqueframe.TabIndex = 0
        Me.cbox_enregistrerchaqueframe.Text = "Enregistrer chaque frame"
        Me.cbox_enregistrerchaqueframe.UseVisualStyleBackColor = True
        '
        'cbox_creerGif
        '
        Me.cbox_creerGif.AutoSize = True
        Me.cbox_creerGif.Location = New System.Drawing.Point(12, 68)
        Me.cbox_creerGif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbox_creerGif.Name = "cbox_creerGif"
        Me.cbox_creerGif.Size = New System.Drawing.Size(119, 17)
        Me.cbox_creerGif.TabIndex = 1
        Me.cbox_creerGif.Text = "Créer une image Gif"
        Me.cbox_creerGif.UseVisualStyleBackColor = True
        '
        'cbox_formatImage
        '
        Me.cbox_formatImage.FormattingEnabled = True
        Me.cbox_formatImage.Items.AddRange(New Object() {"Bitmap", "Jpeg", "Png"})
        Me.cbox_formatImage.Location = New System.Drawing.Point(94, 28)
        Me.cbox_formatImage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbox_formatImage.Name = "cbox_formatImage"
        Me.cbox_formatImage.Size = New System.Drawing.Size(147, 21)
        Me.cbox_formatImage.TabIndex = 2
        Me.cbox_formatImage.Text = "Bitmap"
        '
        'lab_formatImage
        '
        Me.lab_formatImage.AutoSize = True
        Me.lab_formatImage.Location = New System.Drawing.Point(11, 30)
        Me.lab_formatImage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_formatImage.Name = "lab_formatImage"
        Me.lab_formatImage.Size = New System.Drawing.Size(78, 13)
        Me.lab_formatImage.TabIndex = 3
        Me.lab_formatImage.Text = "Format d'image"
        '
        'num_delai
        '
        Me.num_delai.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.num_delai.Location = New System.Drawing.Point(138, 91)
        Me.num_delai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.num_delai.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_delai.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.num_delai.Name = "num_delai"
        Me.num_delai.Size = New System.Drawing.Size(80, 20)
        Me.num_delai.TabIndex = 4
        Me.num_delai.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lab_delai
        '
        Me.lab_delai.AutoSize = True
        Me.lab_delai.Location = New System.Drawing.Point(9, 93)
        Me.lab_delai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_delai.Name = "lab_delai"
        Me.lab_delai.Size = New System.Drawing.Size(125, 13)
        Me.lab_delai.TabIndex = 5
        Me.lab_delai.Text = "Délai entre 2 images [ms]"
        '
        'bt_appliquer
        '
        Me.bt_appliquer.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.bt_appliquer.FlatAppearance.BorderSize = 0
        Me.bt_appliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_appliquer.Location = New System.Drawing.Point(156, 136)
        Me.bt_appliquer.Name = "bt_appliquer"
        Me.bt_appliquer.Size = New System.Drawing.Size(99, 27)
        Me.bt_appliquer.TabIndex = 9
        Me.bt_appliquer.Text = "Appliquer"
        Me.bt_appliquer.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Tomato
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(12, 136)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(99, 27)
        Me.bt_annuler.TabIndex = 8
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'ParametresAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 175)
        Me.Controls.Add(Me.bt_appliquer)
        Me.Controls.Add(Me.bt_annuler)
        Me.Controls.Add(Me.lab_delai)
        Me.Controls.Add(Me.num_delai)
        Me.Controls.Add(Me.lab_formatImage)
        Me.Controls.Add(Me.cbox_formatImage)
        Me.Controls.Add(Me.cbox_creerGif)
        Me.Controls.Add(Me.cbox_enregistrerchaqueframe)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ParametresAnimation"
        Me.Text = "Paramètres des animations"
        CType(Me.num_delai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbox_enregistrerchaqueframe As CheckBox
    Friend WithEvents cbox_creerGif As CheckBox
    Friend WithEvents cbox_formatImage As ComboBox
    Friend WithEvents lab_formatImage As Label
    Friend WithEvents num_delai As NumericUpDown
    Friend WithEvents lab_delai As Label
    Friend WithEvents bt_appliquer As Button
    Friend WithEvents bt_annuler As Button
End Class
