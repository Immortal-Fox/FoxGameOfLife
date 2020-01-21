Imports System.IO

Module Modeles

    ''' <summary>
    ''' Création des modèles de bases
    ''' </summary>
    Public Sub CreerModeles()

        ' Modèle de test

        '   Main.panel_modeles.Controls.Add(New Modele(3, 3, "Planeur", New List(Of Boolean)(New Boolean() {0, 0, 1,
        '                                                                                                 1, 1, 0,
        '                                                                                                 0, 1, 1}), Nothing))

    End Sub

    Public Function EnregistrerFichierModele(ByVal _nom As String) As Boolean
        If File.Exists(Main.dir_modeles & "/" & _nom) Then
            Return False
        End If

        Dim sw As New StreamWriter(Main.dir_modeles & "/" & _nom)
        sw.WriteLine(Main.Engine.TaillePlateau.Width)
        sw.WriteLine(Main.Engine.TaillePlateau.Height)
        For x As Integer = 1 To Main.Engine.TaillePlateau.Width
            For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                If Main.Engine.GetCellValue(x, y) > 0 Then
                    sw.WriteLine(1)
                Else
                    sw.WriteLine(0)
                End If
            Next
        Next

        For Each _tag As String In EnregistrerModele.liste_tags.Items
            sw.WriteLine(_tag)
        Next

        sw.Close()

        Return True
    End Function

    Public Sub ChargerFichiersModele()

        If Directory.Exists(Main.dir_modeles) Then

            For Each _file As String In Directory.EnumerateFiles(Main.dir_modeles)
                Dim sr As New StreamReader(_file)
                Dim tempLargeur As Integer = sr.ReadLine()
                Dim tempHauteur As Integer = sr.ReadLine()
                Dim tempListe As New List(Of Boolean)
                Dim tempListeTags As New List(Of String)
                For i As Integer = 1 To tempLargeur * tempHauteur
                    If sr.ReadLine() > 0 Then
                        tempListe.Add(True)
                    Else
                        tempListe.Add(False)
                    End If
                Next
                Do Until (sr.EndOfStream)
                    tempListeTags.Add(sr.ReadLine())
                Loop
                Main.panel_modeles.Controls.Add(New Modele(tempLargeur, tempHauteur, System.IO.Path.GetFileName(_file), tempListe, tempListeTags))
                sr.Close()
            Next

        End If

    End Sub
End Module
