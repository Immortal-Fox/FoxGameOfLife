<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exceptions
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
        Me.panel_bas = New System.Windows.Forms.Panel()
        Me.panel_survie = New System.Windows.Forms.Panel()
        Me.panel_survie_contenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel_survie_entete = New System.Windows.Forms.Panel()
        Me.bt_survie_vider = New System.Windows.Forms.Button()
        Me.bt_survie_ajouter = New System.Windows.Forms.Button()
        Me.lab_survie = New System.Windows.Forms.Label()
        Me.panel_creation = New System.Windows.Forms.Panel()
        Me.panel_creation_contenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel_creation_entete = New System.Windows.Forms.Panel()
        Me.bt_creation_vider = New System.Windows.Forms.Button()
        Me.bt_creation_ajouter = New System.Windows.Forms.Button()
        Me.lab_creation = New System.Windows.Forms.Label()
        Me.panel_destruction = New System.Windows.Forms.Panel()
        Me.panel_destruction_contenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.panel_destruction_entete = New System.Windows.Forms.Panel()
        Me.bt_destruction_vider = New System.Windows.Forms.Button()
        Me.bt_destruction_ajouter = New System.Windows.Forms.Button()
        Me.lab_desctruction = New System.Windows.Forms.Label()
        Me.panel_haut = New System.Windows.Forms.Panel()
        Me.bt_exporter = New System.Windows.Forms.Button()
        Me.bt_importer = New System.Windows.Forms.Button()
        Me.Ctxt_exceptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsm_supprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_bas.SuspendLayout()
        Me.panel_survie.SuspendLayout()
        Me.panel_survie_entete.SuspendLayout()
        Me.panel_creation.SuspendLayout()
        Me.panel_creation_entete.SuspendLayout()
        Me.panel_destruction.SuspendLayout()
        Me.panel_destruction_entete.SuspendLayout()
        Me.panel_haut.SuspendLayout()
        Me.Ctxt_exceptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_bas
        '
        Me.panel_bas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_bas.Controls.Add(Me.panel_survie)
        Me.panel_bas.Controls.Add(Me.panel_creation)
        Me.panel_bas.Controls.Add(Me.panel_destruction)
        Me.panel_bas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_bas.Location = New System.Drawing.Point(0, 52)
        Me.panel_bas.Name = "panel_bas"
        Me.panel_bas.Size = New System.Drawing.Size(902, 616)
        Me.panel_bas.TabIndex = 0
        '
        'panel_survie
        '
        Me.panel_survie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_survie.Controls.Add(Me.panel_survie_contenu)
        Me.panel_survie.Controls.Add(Me.panel_survie_entete)
        Me.panel_survie.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_survie.Location = New System.Drawing.Point(600, 0)
        Me.panel_survie.Name = "panel_survie"
        Me.panel_survie.Size = New System.Drawing.Size(300, 614)
        Me.panel_survie.TabIndex = 2
        '
        'panel_survie_contenu
        '
        Me.panel_survie_contenu.AutoScroll = True
        Me.panel_survie_contenu.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_survie_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_survie_contenu.Location = New System.Drawing.Point(0, 92)
        Me.panel_survie_contenu.Name = "panel_survie_contenu"
        Me.panel_survie_contenu.Size = New System.Drawing.Size(298, 520)
        Me.panel_survie_contenu.TabIndex = 2
        '
        'panel_survie_entete
        '
        Me.panel_survie_entete.BackColor = System.Drawing.Color.LightGray
        Me.panel_survie_entete.Controls.Add(Me.bt_survie_vider)
        Me.panel_survie_entete.Controls.Add(Me.bt_survie_ajouter)
        Me.panel_survie_entete.Controls.Add(Me.lab_survie)
        Me.panel_survie_entete.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_survie_entete.Location = New System.Drawing.Point(0, 0)
        Me.panel_survie_entete.Name = "panel_survie_entete"
        Me.panel_survie_entete.Size = New System.Drawing.Size(298, 92)
        Me.panel_survie_entete.TabIndex = 1
        '
        'bt_survie_vider
        '
        Me.bt_survie_vider.BackColor = System.Drawing.Color.Silver
        Me.bt_survie_vider.FlatAppearance.BorderSize = 0
        Me.bt_survie_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_survie_vider.Image = Global.FoxGameOfLife.My.Resources.Resources.poubelle
        Me.bt_survie_vider.Location = New System.Drawing.Point(61, 39)
        Me.bt_survie_vider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_survie_vider.Name = "bt_survie_vider"
        Me.bt_survie_vider.Size = New System.Drawing.Size(45, 46)
        Me.bt_survie_vider.TabIndex = 4
        Me.bt_survie_vider.UseVisualStyleBackColor = False
        '
        'bt_survie_ajouter
        '
        Me.bt_survie_ajouter.BackColor = System.Drawing.Color.Silver
        Me.bt_survie_ajouter.FlatAppearance.BorderSize = 0
        Me.bt_survie_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_survie_ajouter.Image = Global.FoxGameOfLife.My.Resources.Resources.ajouter
        Me.bt_survie_ajouter.Location = New System.Drawing.Point(8, 39)
        Me.bt_survie_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_survie_ajouter.Name = "bt_survie_ajouter"
        Me.bt_survie_ajouter.Size = New System.Drawing.Size(45, 46)
        Me.bt_survie_ajouter.TabIndex = 3
        Me.bt_survie_ajouter.UseVisualStyleBackColor = False
        '
        'lab_survie
        '
        Me.lab_survie.AutoSize = True
        Me.lab_survie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_survie.Location = New System.Drawing.Point(68, 9)
        Me.lab_survie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_survie.Name = "lab_survie"
        Me.lab_survie.Size = New System.Drawing.Size(159, 22)
        Me.lab_survie.TabIndex = 2
        Me.lab_survie.Text = "Survie de cellule"
        '
        'panel_creation
        '
        Me.panel_creation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_creation.Controls.Add(Me.panel_creation_contenu)
        Me.panel_creation.Controls.Add(Me.panel_creation_entete)
        Me.panel_creation.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_creation.Location = New System.Drawing.Point(300, 0)
        Me.panel_creation.Name = "panel_creation"
        Me.panel_creation.Size = New System.Drawing.Size(300, 614)
        Me.panel_creation.TabIndex = 1
        '
        'panel_creation_contenu
        '
        Me.panel_creation_contenu.AutoScroll = True
        Me.panel_creation_contenu.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_creation_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_creation_contenu.Location = New System.Drawing.Point(0, 92)
        Me.panel_creation_contenu.Name = "panel_creation_contenu"
        Me.panel_creation_contenu.Size = New System.Drawing.Size(298, 520)
        Me.panel_creation_contenu.TabIndex = 2
        '
        'panel_creation_entete
        '
        Me.panel_creation_entete.BackColor = System.Drawing.Color.LightGray
        Me.panel_creation_entete.Controls.Add(Me.bt_creation_vider)
        Me.panel_creation_entete.Controls.Add(Me.bt_creation_ajouter)
        Me.panel_creation_entete.Controls.Add(Me.lab_creation)
        Me.panel_creation_entete.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_creation_entete.Location = New System.Drawing.Point(0, 0)
        Me.panel_creation_entete.Name = "panel_creation_entete"
        Me.panel_creation_entete.Size = New System.Drawing.Size(298, 92)
        Me.panel_creation_entete.TabIndex = 1
        '
        'bt_creation_vider
        '
        Me.bt_creation_vider.BackColor = System.Drawing.Color.Silver
        Me.bt_creation_vider.FlatAppearance.BorderSize = 0
        Me.bt_creation_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_creation_vider.Image = Global.FoxGameOfLife.My.Resources.Resources.poubelle
        Me.bt_creation_vider.Location = New System.Drawing.Point(60, 39)
        Me.bt_creation_vider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_creation_vider.Name = "bt_creation_vider"
        Me.bt_creation_vider.Size = New System.Drawing.Size(45, 46)
        Me.bt_creation_vider.TabIndex = 4
        Me.bt_creation_vider.UseVisualStyleBackColor = False
        '
        'bt_creation_ajouter
        '
        Me.bt_creation_ajouter.BackColor = System.Drawing.Color.Silver
        Me.bt_creation_ajouter.FlatAppearance.BorderSize = 0
        Me.bt_creation_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_creation_ajouter.Image = Global.FoxGameOfLife.My.Resources.Resources.ajouter
        Me.bt_creation_ajouter.Location = New System.Drawing.Point(7, 39)
        Me.bt_creation_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_creation_ajouter.Name = "bt_creation_ajouter"
        Me.bt_creation_ajouter.Size = New System.Drawing.Size(45, 46)
        Me.bt_creation_ajouter.TabIndex = 3
        Me.bt_creation_ajouter.UseVisualStyleBackColor = False
        '
        'lab_creation
        '
        Me.lab_creation.AutoSize = True
        Me.lab_creation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_creation.Location = New System.Drawing.Point(56, 9)
        Me.lab_creation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_creation.Name = "lab_creation"
        Me.lab_creation.Size = New System.Drawing.Size(178, 22)
        Me.lab_creation.TabIndex = 1
        Me.lab_creation.Text = "Création de cellule"
        '
        'panel_destruction
        '
        Me.panel_destruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_destruction.Controls.Add(Me.panel_destruction_contenu)
        Me.panel_destruction.Controls.Add(Me.panel_destruction_entete)
        Me.panel_destruction.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_destruction.Location = New System.Drawing.Point(0, 0)
        Me.panel_destruction.Name = "panel_destruction"
        Me.panel_destruction.Size = New System.Drawing.Size(300, 614)
        Me.panel_destruction.TabIndex = 0
        '
        'panel_destruction_contenu
        '
        Me.panel_destruction_contenu.AutoScroll = True
        Me.panel_destruction_contenu.BackColor = System.Drawing.Color.Gainsboro
        Me.panel_destruction_contenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_destruction_contenu.Location = New System.Drawing.Point(0, 92)
        Me.panel_destruction_contenu.Name = "panel_destruction_contenu"
        Me.panel_destruction_contenu.Size = New System.Drawing.Size(298, 520)
        Me.panel_destruction_contenu.TabIndex = 1
        '
        'panel_destruction_entete
        '
        Me.panel_destruction_entete.BackColor = System.Drawing.Color.LightGray
        Me.panel_destruction_entete.Controls.Add(Me.bt_destruction_vider)
        Me.panel_destruction_entete.Controls.Add(Me.bt_destruction_ajouter)
        Me.panel_destruction_entete.Controls.Add(Me.lab_desctruction)
        Me.panel_destruction_entete.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_destruction_entete.Location = New System.Drawing.Point(0, 0)
        Me.panel_destruction_entete.Name = "panel_destruction_entete"
        Me.panel_destruction_entete.Size = New System.Drawing.Size(298, 92)
        Me.panel_destruction_entete.TabIndex = 0
        '
        'bt_destruction_vider
        '
        Me.bt_destruction_vider.BackColor = System.Drawing.Color.Silver
        Me.bt_destruction_vider.FlatAppearance.BorderSize = 0
        Me.bt_destruction_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_destruction_vider.Image = Global.FoxGameOfLife.My.Resources.Resources.poubelle
        Me.bt_destruction_vider.Location = New System.Drawing.Point(59, 39)
        Me.bt_destruction_vider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_destruction_vider.Name = "bt_destruction_vider"
        Me.bt_destruction_vider.Size = New System.Drawing.Size(45, 46)
        Me.bt_destruction_vider.TabIndex = 2
        Me.bt_destruction_vider.UseVisualStyleBackColor = False
        '
        'bt_destruction_ajouter
        '
        Me.bt_destruction_ajouter.BackColor = System.Drawing.Color.Silver
        Me.bt_destruction_ajouter.FlatAppearance.BorderSize = 0
        Me.bt_destruction_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_destruction_ajouter.Image = Global.FoxGameOfLife.My.Resources.Resources.ajouter
        Me.bt_destruction_ajouter.Location = New System.Drawing.Point(6, 39)
        Me.bt_destruction_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_destruction_ajouter.Name = "bt_destruction_ajouter"
        Me.bt_destruction_ajouter.Size = New System.Drawing.Size(45, 46)
        Me.bt_destruction_ajouter.TabIndex = 1
        Me.bt_destruction_ajouter.UseVisualStyleBackColor = False
        '
        'lab_desctruction
        '
        Me.lab_desctruction.AutoSize = True
        Me.lab_desctruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_desctruction.Location = New System.Drawing.Point(46, 9)
        Me.lab_desctruction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_desctruction.Name = "lab_desctruction"
        Me.lab_desctruction.Size = New System.Drawing.Size(204, 22)
        Me.lab_desctruction.TabIndex = 0
        Me.lab_desctruction.Text = "Destruction de cellule"
        '
        'panel_haut
        '
        Me.panel_haut.BackColor = System.Drawing.Color.DarkGray
        Me.panel_haut.Controls.Add(Me.bt_exporter)
        Me.panel_haut.Controls.Add(Me.bt_importer)
        Me.panel_haut.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_haut.Location = New System.Drawing.Point(0, 0)
        Me.panel_haut.Name = "panel_haut"
        Me.panel_haut.Size = New System.Drawing.Size(902, 52)
        Me.panel_haut.TabIndex = 1
        Me.panel_haut.Visible = False
        '
        'bt_exporter
        '
        Me.bt_exporter.BackColor = System.Drawing.Color.Silver
        Me.bt_exporter.FlatAppearance.BorderSize = 0
        Me.bt_exporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_exporter.Image = Global.FoxGameOfLife.My.Resources.Resources.Exporter
        Me.bt_exporter.Location = New System.Drawing.Point(56, 3)
        Me.bt_exporter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_exporter.Name = "bt_exporter"
        Me.bt_exporter.Size = New System.Drawing.Size(45, 46)
        Me.bt_exporter.TabIndex = 4
        Me.bt_exporter.UseVisualStyleBackColor = False
        '
        'bt_importer
        '
        Me.bt_importer.BackColor = System.Drawing.Color.Silver
        Me.bt_importer.FlatAppearance.BorderSize = 0
        Me.bt_importer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_importer.Image = Global.FoxGameOfLife.My.Resources.Resources.Importer
        Me.bt_importer.Location = New System.Drawing.Point(5, 3)
        Me.bt_importer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_importer.Name = "bt_importer"
        Me.bt_importer.Size = New System.Drawing.Size(45, 46)
        Me.bt_importer.TabIndex = 3
        Me.bt_importer.UseVisualStyleBackColor = False
        '
        'Ctxt_exceptions
        '
        Me.Ctxt_exceptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Ctxt_exceptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_supprimer})
        Me.Ctxt_exceptions.Name = "Ctxt_exceptions"
        Me.Ctxt_exceptions.Size = New System.Drawing.Size(265, 34)
        '
        'tsm_supprimer
        '
        Me.tsm_supprimer.Image = Global.FoxGameOfLife.My.Resources.Resources.poubelle
        Me.tsm_supprimer.Name = "tsm_supprimer"
        Me.tsm_supprimer.Size = New System.Drawing.Size(264, 30)
        Me.tsm_supprimer.Text = "Supprimer l'exception"
        '
        'Exceptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 668)
        Me.Controls.Add(Me.panel_bas)
        Me.Controls.Add(Me.panel_haut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Exceptions"
        Me.Text = "Exceptions"
        Me.panel_bas.ResumeLayout(False)
        Me.panel_survie.ResumeLayout(False)
        Me.panel_survie_entete.ResumeLayout(False)
        Me.panel_survie_entete.PerformLayout()
        Me.panel_creation.ResumeLayout(False)
        Me.panel_creation_entete.ResumeLayout(False)
        Me.panel_creation_entete.PerformLayout()
        Me.panel_destruction.ResumeLayout(False)
        Me.panel_destruction_entete.ResumeLayout(False)
        Me.panel_destruction_entete.PerformLayout()
        Me.panel_haut.ResumeLayout(False)
        Me.Ctxt_exceptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_bas As Panel
    Friend WithEvents panel_haut As Panel
    Friend WithEvents panel_creation As Panel
    Friend WithEvents panel_creation_contenu As FlowLayoutPanel
    Friend WithEvents panel_creation_entete As Panel
    Friend WithEvents panel_destruction As Panel
    Friend WithEvents panel_destruction_contenu As FlowLayoutPanel
    Friend WithEvents panel_destruction_entete As Panel
    Friend WithEvents panel_survie As Panel
    Friend WithEvents panel_survie_contenu As FlowLayoutPanel
    Friend WithEvents panel_survie_entete As Panel
    Friend WithEvents lab_survie As Label
    Friend WithEvents lab_creation As Label
    Friend WithEvents lab_desctruction As Label
    Friend WithEvents bt_destruction_ajouter As Button
    Friend WithEvents bt_destruction_vider As Button
    Friend WithEvents bt_survie_vider As Button
    Friend WithEvents bt_survie_ajouter As Button
    Friend WithEvents bt_creation_vider As Button
    Friend WithEvents bt_creation_ajouter As Button
    Friend WithEvents bt_importer As Button
    Friend WithEvents bt_exporter As Button
    Friend WithEvents Ctxt_exceptions As ContextMenuStrip
    Friend WithEvents tsm_supprimer As ToolStripMenuItem
End Class
