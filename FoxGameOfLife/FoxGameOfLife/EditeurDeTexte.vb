Public Class EditeurDeTexte
    Private Sub EditeurDeTexte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Chargement des polices
        cbox_police.Items.Clear()
        Dim fonts As New Text.InstalledFontCollection
        Dim font_f() As FontFamily = fonts.Families()
        For Each ft As FontFamily In font_f
            cbox_police.Items.Add(ft.Name)
        Next
        cbox_police.SelectedItem = Main.Engine.policeTexte.Name

    End Sub

    ''' <summary>
    ''' Insère le texte à l'endroit ou se situe le focus du contrôle
    ''' </summary>
    ''' <param name="_texteAInserer">Texte à insérer</param>
    Public Sub InsererTexte(ByVal _texteAInserer As String)
        Dim tempIndex As Integer = txtb_contenu.SelectionStart
        txtb_contenu.Text = txtb_contenu.Text.Insert(txtb_contenu.SelectionStart, _texteAInserer)
        txtb_contenu.SelectionStart = tempIndex + _texteAInserer.Length
        txtb_contenu.Focus()
    End Sub

    Public Sub ConstruirePolice()
        If Not IsNothing(cbox_police.SelectedItem) Then
            txtb_contenu.Font = New Font(cbox_police.SelectedItem.ToString, num_tailleTexte.Value)
            txtb_contenu.ForeColor = bt_couleurTexte.BackColor
        End If
    End Sub

    Private Sub bt_couleurTexte_Click(sender As Object, e As EventArgs) Handles bt_couleurTexte.Click
        Main.choixCouleur.Color = bt_couleurTexte.BackColor
        Dim resultat As DialogResult = Main.choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurTexte.BackColor = Main.choixCouleur.Color
            'main.Engine.ModifierTexte(bt_couleurTexte.BackColor, New Font(cbox_police.SelectedItem.ToString, 12), texte, New Point(num_textePositionX.Value, num_textePositionY.Value))
            'Engine.couleurCaseVide = bt_couleurCasesVides.BackColor
            'Engine.ToutRedessiner()
            'pbox_plateau.Image = Engine.ImageCourante
            ConstruirePolice()
        End If
    End Sub

    Private Sub cbox_police_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_police.SelectedIndexChanged
        ConstruirePolice()
    End Sub

    Private Sub num_textePositionX_ValueChanged(sender As Object, e As EventArgs) Handles num_tailleTexte.ValueChanged
        ConstruirePolice()
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        Main.Engine.ModifierTexte(bt_couleurTexte.BackColor, New Font(cbox_police.SelectedItem.ToString, num_tailleTexte.Value), txtb_contenu.Text)
        Main.Engine.couleurFondTexte = bt_couleurFond.BackColor
        Main.Engine.afficherFondTexte = cbox_afficherFond.Checked
        Me.Close()
    End Sub

    Private Sub bt_insererFrame_Click(sender As Object, e As EventArgs) Handles bt_insererFrame.Click
        InsererTexte("{frame}")
    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        Me.Close()
    End Sub

    Private Sub bt_insererPopulation_Click(sender As Object, e As EventArgs) Handles bt_insererPopulation.Click
        InsererTexte("{population}")
    End Sub

    Private Sub bt_insererTime_Click(sender As Object, e As EventArgs) Handles bt_insererTime.Click
        InsererTexte("{time}")
    End Sub

    Private Sub bt_insererFPS_Click(sender As Object, e As EventArgs) Handles bt_insererFPS.Click
        InsererTexte("{fps}")
    End Sub

    Private Sub bt_insererRules_Click(sender As Object, e As EventArgs) Handles bt_insererRules.Click
        InsererTexte("{rules}")
    End Sub

    Private Sub bt_insererUsername_Click(sender As Object, e As EventArgs) Handles bt_insererUsername.Click
        InsererTexte("{username}")
    End Sub

    Private Sub bt_insererWidth_Click(sender As Object, e As EventArgs) Handles bt_insererWidth.Click
        InsererTexte("{width}")
    End Sub

    Private Sub bt_insererHeight_Click(sender As Object, e As EventArgs) Handles bt_insererHeight.Click
        InsererTexte("{height}")
    End Sub

    Private Sub bt_insererWidthPx_Click(sender As Object, e As EventArgs) Handles bt_insererWidthPx.Click
        InsererTexte("{widthpx}")
    End Sub

    Private Sub bt_insererHeightPx_Click(sender As Object, e As EventArgs) Handles bt_insererHeightPx.Click
        InsererTexte("{heightpx}")
    End Sub

    Private Sub bt_insererCellSize_Click(sender As Object, e As EventArgs) Handles bt_insererCellSize.Click
        InsererTexte("{cellsize}")
    End Sub

    Private Sub bt_insererThread_Click(sender As Object, e As EventArgs) Handles bt_insererThread.Click
        InsererTexte("{thread}")
    End Sub

    Private Sub bt_couleurFond_Click(sender As Object, e As EventArgs) Handles bt_couleurFond.Click
        Main.choixCouleur.Color = bt_couleurFond.BackColor
        Dim resultat As DialogResult = Main.choixCouleur.ShowDialog
        If resultat = DialogResult.OK Then
            bt_couleurFond.BackColor = Main.choixCouleur.Color
        End If
    End Sub

    Private Sub bt_insererNomProgramme_Click(sender As Object, e As EventArgs) Handles bt_insererNomProgramme.Click
        InsererTexte("{program}")
    End Sub

    Private Sub bt_insererDev_Click(sender As Object, e As EventArgs) Handles bt_insererDev.Click
        InsererTexte("{dev}")
    End Sub

    Private Sub bt_insererVersion_Click(sender As Object, e As EventArgs) Handles bt_insererVersion.Click
        InsererTexte("{version}")
    End Sub
End Class