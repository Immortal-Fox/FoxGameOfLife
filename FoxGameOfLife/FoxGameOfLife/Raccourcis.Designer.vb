<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Raccourcis
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
        Me.panel_contenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel_options = New System.Windows.Forms.Panel()
        Me.bt_enregistrer = New System.Windows.Forms.Button()
        Me.bt_annuler = New System.Windows.Forms.Button()
        Me.panel_options.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_contenu
        '
        Me.panel_contenu.AutoScroll = True
        Me.panel_contenu.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_contenu.Location = New System.Drawing.Point(0, 0)
        Me.panel_contenu.Name = "panel_contenu"
        Me.panel_contenu.Size = New System.Drawing.Size(436, 396)
        Me.panel_contenu.TabIndex = 0
        '
        'panel_options
        '
        Me.panel_options.Controls.Add(Me.bt_enregistrer)
        Me.panel_options.Controls.Add(Me.bt_annuler)
        Me.panel_options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_options.Location = New System.Drawing.Point(0, 396)
        Me.panel_options.Name = "panel_options"
        Me.panel_options.Size = New System.Drawing.Size(436, 54)
        Me.panel_options.TabIndex = 1
        '
        'bt_enregistrer
        '
        Me.bt_enregistrer.BackColor = System.Drawing.Color.LimeGreen
        Me.bt_enregistrer.FlatAppearance.BorderSize = 0
        Me.bt_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_enregistrer.Location = New System.Drawing.Point(327, 16)
        Me.bt_enregistrer.Name = "bt_enregistrer"
        Me.bt_enregistrer.Size = New System.Drawing.Size(97, 29)
        Me.bt_enregistrer.TabIndex = 1
        Me.bt_enregistrer.Text = "Appliquer"
        Me.bt_enregistrer.UseVisualStyleBackColor = False
        '
        'bt_annuler
        '
        Me.bt_annuler.BackColor = System.Drawing.Color.Coral
        Me.bt_annuler.FlatAppearance.BorderSize = 0
        Me.bt_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_annuler.Location = New System.Drawing.Point(8, 16)
        Me.bt_annuler.Name = "bt_annuler"
        Me.bt_annuler.Size = New System.Drawing.Size(97, 29)
        Me.bt_annuler.TabIndex = 0
        Me.bt_annuler.Text = "Annuler"
        Me.bt_annuler.UseVisualStyleBackColor = False
        '
        'Raccourcis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 450)
        Me.Controls.Add(Me.panel_contenu)
        Me.Controls.Add(Me.panel_options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Raccourcis"
        Me.Text = "Raccourcis"
        Me.panel_options.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_contenu As FlowLayoutPanel
    Friend WithEvents panel_options As Panel
    Friend WithEvents bt_enregistrer As Button
    Friend WithEvents bt_annuler As Button
End Class
