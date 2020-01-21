<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APropos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lab_version = New System.Windows.Forms.Label()
        Me.lab_dev = New System.Windows.Forms.Label()
        Me.lab_annee = New System.Windows.Forms.Label()
        Me.pbox_logo = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FoxGameOfLife"
        '
        'lab_version
        '
        Me.lab_version.AutoSize = True
        Me.lab_version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_version.Location = New System.Drawing.Point(151, 22)
        Me.lab_version.Name = "lab_version"
        Me.lab_version.Size = New System.Drawing.Size(71, 13)
        Me.lab_version.TabIndex = 1
        Me.lab_version.Text = "Version 0.1"
        '
        'lab_dev
        '
        Me.lab_dev.AutoSize = True
        Me.lab_dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_dev.Location = New System.Drawing.Point(21, 60)
        Me.lab_dev.Name = "lab_dev"
        Me.lab_dev.Size = New System.Drawing.Size(336, 13)
        Me.lab_dev.TabIndex = 2
        Me.lab_dev.Text = "Développé par Ludovic Charmillot @Immortal Fox @Zyldar"
        '
        'lab_annee
        '
        Me.lab_annee.AutoSize = True
        Me.lab_annee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_annee.Location = New System.Drawing.Point(166, 35)
        Me.lab_annee.Name = "lab_annee"
        Me.lab_annee.Size = New System.Drawing.Size(35, 13)
        Me.lab_annee.TabIndex = 3
        Me.lab_annee.Text = "2018"
        '
        'pbox_logo
        '
        Me.pbox_logo.Image = Global.FoxGameOfLife.My.Resources.Resources.Logo_Application
        Me.pbox_logo.Location = New System.Drawing.Point(-2, 51)
        Me.pbox_logo.Name = "pbox_logo"
        Me.pbox_logo.Size = New System.Drawing.Size(371, 362)
        Me.pbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_logo.TabIndex = 4
        Me.pbox_logo.TabStop = False
        '
        'APropos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(369, 385)
        Me.Controls.Add(Me.lab_annee)
        Me.Controls.Add(Me.lab_dev)
        Me.Controls.Add(Me.lab_version)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbox_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "APropos"
        Me.Text = "A propos de..."
        CType(Me.pbox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lab_version As Label
    Friend WithEvents lab_dev As Label
    Friend WithEvents lab_annee As Label
    Friend WithEvents pbox_logo As PictureBox
End Class
