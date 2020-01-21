Imports System.ComponentModel
''' <summary>
''' Fenêtre de gestion des exceptions du jeu de la vie
''' </summary>
Public Class Exceptions
    Public currentException As ExceptionsControl
    ' Exceptions (supression de cellule)
    ' Exceptions (création de cellule)
    Private Sub Exceptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Charge les exceptions sous forme graphique
        ' Parcours les listes du moteur pour créer les éléments graphiques 
        ' Liste des exceptions de destruction
        For Each _exe As CellException In Main.Engine.listeExceptionsDesctruction
            Dim temp As ExceptionsControl = New ExceptionsControl
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    temp.tableCellule(x, y) = _exe.GetTableValue(x, y)
                Next
            Next
            panel_destruction_contenu.Controls.Add(temp)
            temp.GenererImage()
        Next

        ' Liste des exceptions de création
        For Each _exe As CellException In Main.Engine.listeExceptionsCreation
            Dim temp As ExceptionsControl = New ExceptionsControl
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    temp.tableCellule(x, y) = _exe.GetTableValue(x, y)
                Next
            Next
            temp.GenererImage()
            panel_creation_contenu.Controls.Add(temp)
        Next

        ' Liste des exceptions de survie
        For Each _exe As CellException In Main.Engine.listeExceptionsSurvie
            Dim temp As ExceptionsControl = New ExceptionsControl
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    temp.tableCellule(x, y) = _exe.GetTableValue(x, y)
                Next
            Next
            temp.GenererImage()
            panel_survie_contenu.Controls.Add(temp)
        Next


    End Sub

    Public Sub SauvegarderExceptions()

        Main.Engine.ReinitialiserExceptions()

        For Each _exe As ExceptionsControl In panel_destruction_contenu.Controls
            Dim temp As New CellException
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    temp.GetTableValue(x, y) = _exe.tableCellule(x, y)
                Next
            Next
            Main.Engine.listeExceptionsDesctruction.Add(temp)
        Next

        For Each _exe As ExceptionsControl In panel_creation_contenu.Controls
            Dim temp As New CellException
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    temp.GetTableValue(x, y) = _exe.tableCellule(x, y)
                Next
            Next
            Main.Engine.listeExceptionsCreation.Add(temp)
        Next

        For Each _exe As ExceptionsControl In panel_survie_contenu.Controls
            Dim temp As New CellException
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    temp.GetTableValue(x, y) = _exe.tableCellule(x, y)
                Next
            Next
            Main.Engine.listeExceptionsSurvie.Add(temp)
        Next

    End Sub

    Private Sub bt_destruction_ajouter_Click(sender As Object, e As EventArgs) Handles bt_destruction_ajouter.Click
        panel_destruction_contenu.Controls.Add(New ExceptionsControl)
    End Sub

    Private Sub bt_destruction_vider_Click(sender As Object, e As EventArgs) Handles bt_destruction_vider.Click
        panel_destruction_contenu.Controls.Clear()
    End Sub

    Private Sub Exceptions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Enregistre les exceptions à la sortie du programme
        SauvegarderExceptions()
    End Sub

    Private Sub bt_creation_ajouter_Click(sender As Object, e As EventArgs) Handles bt_creation_ajouter.Click
        panel_creation_contenu.Controls.Add(New ExceptionsControl)
    End Sub

    Private Sub bt_creation_vider_Click(sender As Object, e As EventArgs) Handles bt_creation_vider.Click
        panel_creation_contenu.Controls.Clear()
    End Sub

    Private Sub bt_survie_ajouter_Click(sender As Object, e As EventArgs) Handles bt_survie_ajouter.Click
        panel_survie_contenu.Controls.Add(New ExceptionsControl)
    End Sub

    Private Sub bt_survie_vider_Click(sender As Object, e As EventArgs) Handles bt_survie_vider.Click
        panel_survie_contenu.Controls.Clear()
    End Sub
End Class

''' <summary>
''' Affichage graphique des exceptions du jeu de la vie
''' </summary>
Public Class ExceptionsControl
    Inherits PictureBox
    Public tableCellule(3, 3) As Byte
    Public img As Bitmap
    Public g As Graphics

    Public tailleCase As New Size(20, 20)

    Sub New()
        MiseEnForme()
        GenererImage()
    End Sub

    Sub New(ByVal _cell1_1 As Byte, ByVal _cell2_1 As Byte, ByVal _cell3_1 As Byte, ByVal _cell1_2 As Byte, ByVal _cell3_2 As Byte, ByVal _cell1_3 As Byte, ByVal _cell2_3 As Byte, ByVal _cell3_3 As Byte)
        tableCellule(1, 1) = _cell1_1
        tableCellule(2, 1) = _cell2_1
        tableCellule(3, 1) = _cell3_1
        tableCellule(1, 2) = _cell1_2
        tableCellule(3, 2) = _cell3_2
        tableCellule(1, 3) = _cell1_3
        tableCellule(2, 3) = _cell2_3
        tableCellule(3, 3) = _cell3_3
        MiseEnForme()
        GenererImage()
    End Sub

    Public Sub MiseEnForme()
        ' Mets en forme le contrôle
        Me.Size = New Size(tailleCase.Width * 3, tailleCase.Height * 3)
        Me.SizeMode = PictureBoxSizeMode.Zoom
        Me.BackColor = Color.White
        Me.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Public Sub GenererImage()
        ' Supprime l'image existante
        SupprimerImage()
        img = New Bitmap(tailleCase.Width * 3, tailleCase.Height * 3)
        g = Graphics.FromImage(img)

        ' Dessine les cases
        For x As Integer = 1 To 3
            For y As Integer = 1 To 3
                If tableCellule(x, y) = 1 Then
                    g.FillRectangle(New SolidBrush(Color.Black), x * tailleCase.Width - tailleCase.Width, y * tailleCase.Height - tailleCase.Height, tailleCase.Width, tailleCase.Height)
                End If
            Next
        Next
        g.FillRectangle(New SolidBrush(Color.Red), 2 * tailleCase.Width - tailleCase.Width, 2 * tailleCase.Height - tailleCase.Height, tailleCase.Width, tailleCase.Height)

        Me.Image = img

    End Sub

    Public Sub SupprimerImage()
        If Not IsNothing(img) Then
            img.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Ouvre l'editeur d'exception
    ''' </summary>
    Sub OuvrirEditeurException() Handles Me.Click
        Exceptions.currentException = Me
        ExceptionsEdition.estNouveau = False

        ' Chargement sur la table de l'editeur
        For x As Integer = 1 To 3
            For y As Integer = 1 To 3
                ExceptionsEdition.tableCellule(x, y) = tableCellule(x, y)
            Next
        Next

        ExceptionsEdition.ShowDialog()

        GenererImage()
    End Sub
End Class