Module Filtres

    ''' <summary>
    ''' Inverse toutes les valeurs du tableau du jeu de la vie
    ''' </summary>
    Public Sub Filtre_Inverser()
        For x As Integer = 1 To Main.Engine.TaillePlateau.Width
            For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                If Main.Engine.GetCellValue(x, y) = 1 Then
                    Main.Engine.GetCellValue(x, y) = 0
                ElseIf Main.Engine.GetCellValue(x, y) = 0 Then
                    Main.Engine.GetCellValue(x, y) = 1
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Ajoute une épaisseur aux cellules déjà présent sur le tableau
    ''' </summary>
    ''' <param name="_valeur">Type d'élément</param>
    ''' <param name="_epaisseur">Nombre d'épaisseur</param>
    Public Sub Filtre_Epaissir(ByVal _valeur As Byte, ByVal _epaisseur As Integer)
        'Nombre d'épaisseur
        For i As Integer = 1 To _epaisseur
            'Table de retenu temporaire
            Dim _table_tmp(Main.Engine.TaillePlateau.Width + 1, Main.Engine.TaillePlateau.Height + 1) As Byte

            'Parcours le plateau et ajoute les bordures potentielles dans la table temporaire
            For x As Integer = 1 To Main.Engine.TaillePlateau.Width
                For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                    'Test toutes les cases sur les côtés
                    If Main.Engine.TableEdition(x, y) <> 0 Then
                        For x2 As Integer = x - 1 To x + 1
                            For y2 As Integer = y - 1 To y + 1
                                If x2 > 0 And x2 <= Main.Engine.TaillePlateau.Width + 1 And y2 > 0 And y2 <= Main.Engine.TaillePlateau.Height + 1 Then
                                    _table_tmp(x2, y2) = _valeur
                                End If
                            Next
                        Next
                    End If
                Next
            Next

            'Application des bordures sur le plateau
            For x As Integer = 1 To Main.Engine.TaillePlateau.Width
                For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                    If Not IsNothing(_table_tmp(x, y)) And Main.Engine.GetCellValue(x, y) = 0 Then
                        Main.Engine.GetCellValue(x, y) = _table_tmp(x, y)
                    End If
                Next
            Next
        Next
    End Sub


    Public Sub Filtre_Melanger(ByVal _nombre As Integer)

        Dim index As Integer = 0
        Randomize()

        Do
            Dim randx As Integer = Main.Engine.TaillePlateau.Width * Rnd()
            Dim randy As Integer = Main.Engine.TaillePlateau.Height * Rnd()
            Dim randx2 As Integer = Main.Engine.TaillePlateau.Width * Rnd()
            Dim randy2 As Integer = Main.Engine.TaillePlateau.Height * Rnd()
            Dim temp As Byte
            temp = Main.Engine.GetCellValue(randx, randy)
            Main.Engine.GetCellValue(randx, randy) = Main.Engine.GetCellValue(randx2, randy2)
            Main.Engine.GetCellValue(randx2, randy2) = temp

            index = index + 1
        Loop While (index < _nombre)

    End Sub




End Module
