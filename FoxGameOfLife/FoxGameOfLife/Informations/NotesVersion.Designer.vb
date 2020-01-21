<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotesVersion
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
        Me.bt_versionCourante = New System.Windows.Forms.Button()
        Me.txtb_versionCourante = New System.Windows.Forms.TextBox()
        Me.bt_anciennesVersions = New System.Windows.Forms.Button()
        Me.txtb_anciennesVersions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bt_versionCourante
        '
        Me.bt_versionCourante.BackColor = System.Drawing.Color.LightGray
        Me.bt_versionCourante.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt_versionCourante.FlatAppearance.BorderSize = 0
        Me.bt_versionCourante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_versionCourante.Location = New System.Drawing.Point(0, 0)
        Me.bt_versionCourante.Name = "bt_versionCourante"
        Me.bt_versionCourante.Size = New System.Drawing.Size(460, 23)
        Me.bt_versionCourante.TabIndex = 0
        Me.bt_versionCourante.Text = "Version courante 1.0"
        Me.bt_versionCourante.UseVisualStyleBackColor = False
        '
        'txtb_versionCourante
        '
        Me.txtb_versionCourante.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtb_versionCourante.Location = New System.Drawing.Point(0, 23)
        Me.txtb_versionCourante.Multiline = True
        Me.txtb_versionCourante.Name = "txtb_versionCourante"
        Me.txtb_versionCourante.ReadOnly = True
        Me.txtb_versionCourante.Size = New System.Drawing.Size(460, 167)
        Me.txtb_versionCourante.TabIndex = 1
        Me.txtb_versionCourante.Text = "Version 1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Moteur de jeu de la vie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'bt_anciennesVersions
        '
        Me.bt_anciennesVersions.BackColor = System.Drawing.Color.LightGray
        Me.bt_anciennesVersions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bt_anciennesVersions.FlatAppearance.BorderSize = 0
        Me.bt_anciennesVersions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_anciennesVersions.Location = New System.Drawing.Point(0, 423)
        Me.bt_anciennesVersions.Name = "bt_anciennesVersions"
        Me.bt_anciennesVersions.Size = New System.Drawing.Size(460, 23)
        Me.bt_anciennesVersions.TabIndex = 2
        Me.bt_anciennesVersions.Text = "Anciennes versions"
        Me.bt_anciennesVersions.UseVisualStyleBackColor = False
        '
        'txtb_anciennesVersions
        '
        Me.txtb_anciennesVersions.Location = New System.Drawing.Point(0, 213)
        Me.txtb_anciennesVersions.Multiline = True
        Me.txtb_anciennesVersions.Name = "txtb_anciennesVersions"
        Me.txtb_anciennesVersions.ReadOnly = True
        Me.txtb_anciennesVersions.Size = New System.Drawing.Size(460, 167)
        Me.txtb_anciennesVersions.TabIndex = 3
        '
        'NotesVersion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 446)
        Me.Controls.Add(Me.txtb_anciennesVersions)
        Me.Controls.Add(Me.bt_anciennesVersions)
        Me.Controls.Add(Me.txtb_versionCourante)
        Me.Controls.Add(Me.bt_versionCourante)
        Me.Name = "NotesVersion"
        Me.Text = "Notes de version"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_versionCourante As Button
    Friend WithEvents txtb_versionCourante As TextBox
    Friend WithEvents bt_anciennesVersions As Button
    Friend WithEvents txtb_anciennesVersions As TextBox
End Class
