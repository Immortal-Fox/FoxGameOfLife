<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltreEpaisseur
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
        Me.lab_epaisseur = New System.Windows.Forms.Label()
        Me.num_epaisseur = New System.Windows.Forms.NumericUpDown()
        Me.bt_appliquer = New System.Windows.Forms.Button()
        CType(Me.num_epaisseur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lab_epaisseur
        '
        Me.lab_epaisseur.AutoSize = True
        Me.lab_epaisseur.Location = New System.Drawing.Point(9, 9)
        Me.lab_epaisseur.Name = "lab_epaisseur"
        Me.lab_epaisseur.Size = New System.Drawing.Size(105, 13)
        Me.lab_epaisseur.TabIndex = 0
        Me.lab_epaisseur.Text = "Taille de l'epaisseur :"
        '
        'num_epaisseur
        '
        Me.num_epaisseur.Location = New System.Drawing.Point(128, 7)
        Me.num_epaisseur.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_epaisseur.Name = "num_epaisseur"
        Me.num_epaisseur.Size = New System.Drawing.Size(94, 20)
        Me.num_epaisseur.TabIndex = 1
        Me.num_epaisseur.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'bt_appliquer
        '
        Me.bt_appliquer.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.bt_appliquer.FlatAppearance.BorderSize = 0
        Me.bt_appliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_appliquer.Location = New System.Drawing.Point(149, 35)
        Me.bt_appliquer.Name = "bt_appliquer"
        Me.bt_appliquer.Size = New System.Drawing.Size(73, 23)
        Me.bt_appliquer.TabIndex = 2
        Me.bt_appliquer.Text = "Appliquer"
        Me.bt_appliquer.UseVisualStyleBackColor = False
        '
        'FiltreEpaisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 67)
        Me.Controls.Add(Me.bt_appliquer)
        Me.Controls.Add(Me.num_epaisseur)
        Me.Controls.Add(Me.lab_epaisseur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FiltreEpaisseur"
        Me.Text = "Filtre epaisseur"
        CType(Me.num_epaisseur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_epaisseur As Label
    Friend WithEvents num_epaisseur As NumericUpDown
    Friend WithEvents bt_appliquer As Button
End Class
