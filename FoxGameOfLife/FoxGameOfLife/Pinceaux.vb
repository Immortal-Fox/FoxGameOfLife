Module GestionPinceaux

    'Informations pour l'utilisation des modèles
    Public table_modele(10000, 10000) As Boolean
    Public modele_largeur As Integer = 2    ' Largeur du modèle
    Public modele_hauteur As Integer = 2    ' Hauteur du modèle

    Public liste_remplisseur As New List(Of Point)

    Public Sub AppliquerPinceau(ByVal _x As Integer, ByVal _y As Integer)

        Select Case Main.PinceauSelectionne
            Case Main.Pinceaux.Simple
                Main.Engine.GetCellValue(_x, _y) = Main.ValeurEdition

            Case Main.Pinceaux.Remplisseur
                liste_remplisseur.Add(New Point(_x, _y))
                Main.Engine.GetCellValue(_x, _y) = Main.ValeurEdition
                Remplisseur()
                Main.Engine.ToutRedessiner()

            Case Main.Pinceaux.Ligne
                PinceauLigne(_y, Main.ValeurEdition)

            Case Main.Pinceaux.Colonne
                PinceauColonne(_x, Main.ValeurEdition)

            Case Main.Pinceaux.Croix
                PinceauLigne(_y, Main.ValeurEdition)
                PinceauColonne(_x, Main.ValeurEdition)

            Case Main.Pinceaux.DiagonaleD
                DiagonaleDroite(_x, _y, Main.ValeurEdition)

            Case Main.Pinceaux.DiagonaleG
                DiagonaleGauche(_x, _y, Main.ValeurEdition)

            Case Main.Pinceaux.Diagonales
                DiagonaleDroite(_x, _y, Main.ValeurEdition)
                DiagonaleGauche(_x, _y, Main.ValeurEdition)

            Case Main.Pinceaux.Mur
                Main.Engine.GetCellValue(_x, _y) = 2

            Case Main.Pinceaux.Modele
                PinceauModele(_x + 1, _y + 1, Main.ValeurEdition)
        End Select

    End Sub

    ''' <summary>
    ''' Fonction de remplissage
    ''' </summary>
    Public Sub Remplisseur()
        Do
            If liste_remplisseur.Count <> 0 Then
                'Liste temporaire pour les nouveaux points
                Dim temp_liste As New List(Of Point)

                'Parcours chaque point existant et les ajoutes dans la liste temporaire
                For Each _point As Point In liste_remplisseur
                    If Main.Engine.GetCellValue(_point.X + 1, _point.Y) <> Main.ValeurEdition And Main.Engine.CelluleDansLimites(_point.X + 1, _point.Y) Then
                        temp_liste.Add(New Point(_point.X + 1, _point.Y))
                        Main.Engine.TableEdition(_point.X + 1, _point.Y) = Main.ValeurEdition
                    End If
                    If Main.Engine.GetCellValue(_point.X - 1, _point.Y) <> Main.ValeurEdition And Main.Engine.CelluleDansLimites(_point.X - 1, _point.Y) Then
                        temp_liste.Add(New Point(_point.X - 1, _point.Y))
                        Main.Engine.TableEdition(_point.X - 1, _point.Y) = Main.ValeurEdition
                    End If
                    If Main.Engine.GetCellValue(_point.X, _point.Y + 1) <> Main.ValeurEdition And Main.Engine.CelluleDansLimites(_point.X, _point.Y + 1) Then
                        temp_liste.Add(New Point(_point.X, _point.Y + 1))
                        Main.Engine.TableEdition(_point.X, _point.Y + 1) = Main.ValeurEdition
                    End If
                    If Main.Engine.GetCellValue(_point.X, _point.Y - 1) <> Main.ValeurEdition And Main.Engine.CelluleDansLimites(_point.X, _point.Y - 1) Then
                        temp_liste.Add(New Point(_point.X, _point.Y - 1))
                        Main.Engine.TableEdition(_point.X, _point.Y - 1) = Main.ValeurEdition
                    End If
                Next

                'Inverse les listes
                liste_remplisseur.Clear()
                For Each _point As Point In temp_liste
                    liste_remplisseur.Add(_point)
                Next

                'Appel à nouveau la fonction jusqu'à ce que la liste soit vide
                Remplisseur()
            End If
        Loop Until (liste_remplisseur.Count = 0)

    End Sub

    ''' <summary>
    ''' Fonction de remplissage en ligne
    ''' </summary>
    ''' <param name="_y">Ligne</param>
    ''' <param name="_valeur">Valeur de remplissage</param>
    Public Sub PinceauLigne(ByVal _y As Integer, ByVal _valeur As Byte)
        For x As Integer = 1 To Main.Engine.TaillePlateau.Width
            For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                If y = _y Then
                    Main.Engine.GetCellValue(x, y) = _valeur
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Fonction de remplissage en colonne
    ''' </summary>
    ''' <param name="_x">Colonne</param>
    ''' <param name="_valeur">Valeur de remplissage</param>
    Public Sub PinceauColonne(ByVal _x As Integer, ByVal _valeur As Byte)
        For x As Integer = 1 To Main.Engine.TaillePlateau.Width
            For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                If x = _x Then
                    Main.Engine.GetCellValue(x, y) = _valeur
                End If
            Next
        Next
    End Sub

    Public Sub DiagonaleGauche(ByVal _x As Integer, ByVal _y As Integer, ByVal _valeur As Byte)
        For haut As Integer = 0 To _x
            Main.Engine.GetCellValue(_x - haut, _y - haut) = _valeur
        Next
        For haut As Integer = 0 To Main.Engine.TaillePlateau.Width - _x
            Main.Engine.GetCellValue(_x + haut, _y + haut) = _valeur
        Next
    End Sub

    Public Sub DiagonaleDroite(ByVal _x As Integer, ByVal _y As Integer, ByVal _valeur As Byte)
        For haut As Integer = 0 To Main.Engine.TaillePlateau.Width - _x
            Main.Engine.GetCellValue(_x + haut, _y - haut) = _valeur
        Next
        For haut As Integer = 0 To _x
            Main.Engine.GetCellValue(_x - haut, _y + haut) = _valeur
        Next
    End Sub

    Public Sub PinceauModele(ByVal _x As Integer, ByVal _y As Integer, ByVal _valeur As Byte)
        For Each _point As Point In GetListeRectanglesPinceaux(Main.Pinceaux.Modele, _x, _y)
            Main.Engine.GetCellValue(_point.X, _point.Y) = _valeur
        Next

    End Sub

    Public Function GetListeRectanglesPinceaux(ByVal _id As Main.Pinceaux, ByVal _x As Integer, ByVal _y As Integer) As List(Of Point)
        Dim liste_point As New List(Of Point)
        Select Case _id
            Case Main.Pinceaux.Modele
                Dim index = 0
                For x As Integer = 1 To Main.modeleLargeur
                    For y As Integer = 1 To Main.modeleHauteur
                        If Main.liste_modele(index) = True Then
                            liste_point.Add(New Point(_x + x - 2, _y + y - 2))
                        End If
                        index += 1
                    Next
                Next
            Case Main.Pinceaux.Simple
                liste_point.Add(New Point(_x - 1, _y - 1))
            Case Main.Pinceaux.Ligne
                For i As Integer = 1 To Main.Engine.TaillePlateau.Width
                    liste_point.Add(New Point(i - 1, _y - 1))
                Next
            Case Main.Pinceaux.Colonne
                For i As Integer = 1 To Main.Engine.TaillePlateau.Height
                    liste_point.Add(New Point(_x - 1, i - 1))
                Next
            Case Main.Pinceaux.Croix
                For i As Integer = 1 To Main.Engine.TaillePlateau.Width
                    liste_point.Add(New Point(i - 1, _y - 1))
                Next
                For i As Integer = 1 To Main.Engine.TaillePlateau.Height
                    liste_point.Add(New Point(_x - 1, i - 1))
                Next
            Case Main.Pinceaux.DiagonaleD
                For i As Integer = 0 To Main.Engine.TaillePlateau.Width - _x
                    liste_point.Add(New Point(_x + i, _y - i))
                Next
                For haut As Integer = 0 To _x
                    liste_point.Add(New Point(_x - haut, _y + haut))
                Next
            Case Main.Pinceaux.DiagonaleG
                For haut As Integer = 0 To _x
                    liste_point.Add(New Point(_x - haut, _y - haut))
                Next
                For haut As Integer = 0 To Main.Engine.TaillePlateau.Width - _x
                    liste_point.Add(New Point(_x + haut, _y + haut))
                Next
            Case Main.Pinceaux.Diagonales
                For i As Integer = 0 To Main.Engine.TaillePlateau.Width - _x
                    liste_point.Add(New Point(_x + i, _y - i))
                Next
                For haut As Integer = 0 To _x
                    liste_point.Add(New Point(_x - haut, _y + haut))
                Next
                For haut As Integer = 0 To _x
                    liste_point.Add(New Point(_x - haut, _y - haut))
                Next
                For haut As Integer = 0 To Main.Engine.TaillePlateau.Width - _x
                    liste_point.Add(New Point(_x + haut, _y + haut))
                Next
        End Select

        Return liste_point
    End Function

End Module
