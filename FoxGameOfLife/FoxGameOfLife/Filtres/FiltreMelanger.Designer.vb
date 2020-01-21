<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltreMelanger
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
        Me.bt_appliquer = New System.Windows.Forms.Button()
        Me.num_melange = New System.Windows.Forms.NumericUpDown()
        Me.lab_epaisseur = New System.Windows.Forms.Label()
        CType(Me.num_melange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_appliquer
        '
        Me.bt_appliquer.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.bt_appliquer.FlatAppearance.BorderSize = 0
        Me.bt_appliquer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_appliquer.Location = New System.Drawing.Point(152, 33)
        Me.bt_appliquer.Name = "bt_appliquer"
        Me.bt_appliquer.Size = New System.Drawing.Size(73, 23)
        Me.bt_appliquer.TabIndex = 3
        Me.bt_appliquer.Text = "Appliquer"
        Me.bt_appliquer.UseVisualStyleBackColor = False
        '
        'num_melange
        '
        Me.num_melange.Location = New System.Drawing.Point(131, 7)
        Me.num_melange.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_melange.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_melange.Name = "num_melange"
        Me.num_melange.Size = New System.Drawing.Size(94, 20)
        Me.num_melange.TabIndex = 5
        Me.num_melange.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lab_epaisseur
        '
        Me.lab_epaisseur.AutoSize = True
        Me.lab_epaisseur.Location = New System.Drawing.Point(12, 9)
        Me.lab_epaisseur.Name = "lab_epaisseur"
        Me.lab_epaisseur.Size = New System.Drawing.Size(111, 13)
        Me.lab_epaisseur.TabIndex = 4
        Me.lab_epaisseur.Text = "Nombre de mélange : "
        '
        'FiltreMelanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 64)
        Me.Controls.Add(Me.num_melange)
        Me.Controls.Add(Me.lab_epaisseur)
        Me.Controls.Add(Me.bt_appliquer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FiltreMelanger"
        Me.Text = "Mélanger"
        CType(Me.num_melange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_appliquer As Button
    Friend WithEvents num_melange As NumericUpDown
    Friend WithEvents lab_epaisseur As Label
End Class
