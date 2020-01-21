<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecupererTouche
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
        Me.lab_aide = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lab_aide
        '
        Me.lab_aide.AutoSize = True
        Me.lab_aide.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_aide.Location = New System.Drawing.Point(12, 15)
        Me.lab_aide.Name = "lab_aide"
        Me.lab_aide.Size = New System.Drawing.Size(346, 34)
        Me.lab_aide.TabIndex = 0
        Me.lab_aide.Text = "Appuyez sur l'une des touche de votre clavier " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pour affecter la touche à l'actio" &
    "n voulu"
        '
        'RecupererTouche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(375, 68)
        Me.Controls.Add(Me.lab_aide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "RecupererTouche"
        Me.Text = "Affecter un raccourci"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_aide As Label
End Class
