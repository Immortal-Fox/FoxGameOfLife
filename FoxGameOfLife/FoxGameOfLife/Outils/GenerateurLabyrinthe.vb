Public Class GenerateurLabyrinthe
    Dim Curseur As MazeCursor

    Private Sub GenerateurLabyrinthe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Valeurs et valeurs par défaut des contrôles utilisateurs
        num_x.Maximum = Main.Engine.TaillePlateau.Width
        num_y.Maximum = Main.Engine.TaillePlateau.Height

        num_parcourscurseur.Value = 100
        num_tempsgen.Value = 100

        bt_stop.Enabled = False
        bt_reprendre.Enabled = False

        lab_noeuds.Text = 0
        lab_murs.Text = 0
        lab_passages.Text = 0

        num_seed.Maximum = Integer.MaxValue
        cbox_randomseed.Checked = True

    End Sub

    Private Sub bt_generer_Click(sender As Object, e As EventArgs) Handles bt_generer.Click
        'Génération du curseur
        lab_noeuds.Text = 0
        lab_murs.Text = 0
        lab_passages.Text = 0
        Curseur = New MazeCursor(num_parcourscurseur.Value, 1, 0, num_x.Value, num_y.Value, cbox_randomseed.Checked, num_seed.Value, cbox_casesvides.Checked)

        If cbox_generationpas.Checked Then
            ' On démarre la génération procédurale pas à pas
            TickGeneration.Interval = num_tempsgen.Value
            TickGeneration.Start()
            'on déverouille les boutons
            bt_stop.Enabled = True
            bt_reprendre.Enabled = False
        Else
            'On vérouille les boutons
            bt_stop.Enabled = False
            bt_reprendre.Enabled = False
            Do
                If Curseur.GetNoeudsRestants > 0 Then
                    Curseur.SelectRandomNode()
                    lab_noeuds.Text = Curseur.MazeListe.Count()
                Else
                    'Main.PlateauDeJeu.GestionRetourReprendre.AddImagePlateau("Génération de labyrinthe")
                    Exit Do
                End If
            Loop
        End If
        'Affiche l'image
        Main.pbox_plateau.Image = Main.Engine.ImageCourante
    End Sub

    Private Sub TickGeneration_Tick(sender As Object, e As EventArgs) Handles TickGeneration.Tick

        If Curseur.GetNoeudsRestants > 0 Then
            Curseur.SelectRandomNode()
            lab_noeuds.Text = Curseur.MazeListe.Count()
            'Me.Text = Curseur.MazeListe.Count()
        Else
            bt_stop.Enabled = False
            bt_reprendre.Enabled = False
            TickGeneration.Stop()
            'Main.PlateauDeJeu.GestionRetourReprendre.AddImagePlateau("Génération de labyrinthe")
        End If

        Main.pbox_plateau.Image = Main.Engine.ImageCourante

    End Sub

    Private Sub bt_stop_Click(sender As Object, e As EventArgs) Handles bt_stop.Click

        'Pause la génération
        TickGeneration.Stop()
        bt_reprendre.Enabled = True
        bt_stop.Enabled = False

    End Sub

    Private Sub bt_reprendre_Click(sender As Object, e As EventArgs) Handles bt_reprendre.Click

        'Reprend la génération
        TickGeneration.Start()
        bt_reprendre.Enabled = False
        bt_stop.Enabled = True

    End Sub
End Class

Public Class MazeCursor
    Public x As Integer = 1
    Public y As Integer = 1
    Public MazeTable(Main.Engine.TaillePlateau.Width, Main.Engine.TaillePlateau.Height) As MazeNode
    Public MazeListe As New List(Of MazeNode)
    Public RandomGen As Random
    Public CasesvidesSeulement As Boolean

    Public LongueurChemin As Integer
    Public idmur As Byte = 1
    Public idespace As Byte = 0

    Sub New(ByVal frequency As Integer, ByVal _idmur As Byte, ByVal _idespace As Byte, ByVal _x As Integer, ByVal _y As Integer, ByVal userandomseed As Boolean, ByVal randomseed As Integer, ByVal casesvides As Boolean)
        'Paramètre de génération
        LongueurChemin = frequency
        idmur = _idmur
        idespace = _idespace
        CasesvidesSeulement = casesvides
        x = _x
        y = _y
        If userandomseed Then
            RandomGen = New Random()
        Else
            RandomGen = New Random(randomseed)
        End If
        'Remplissage du tableau avec les noeuds


        If Not CasesvidesSeulement Then
            For i As Integer = 1 To Main.Engine.TaillePlateau.Width
                For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                    MazeTable(i, y) = New MazeNode(i, y, Me)
                    'MazeGenerator.lab_murs.Text = MazeGenerator.lab_murs.Text + 1
                    Main.Engine.GetCellValue(i, y) = idmur
                    'Main.PlateauDeJeu.ActualisePosition(i, y)
                Next
            Next
        Else
            RecursiveParse(x, y, 0)
        End If



        'On ajoute le premier noeud dans la liste
        MazeListe.Add(MazeTable(x, y))
    End Sub
    Public Sub RecursiveParse(ByVal x As Integer, ByVal y As Integer, ByVal ID As Byte)
        MazeTable(x, y) = New MazeNode(x, y, Me)
        'MazeGenerator.lab_murs.Text = MazeGenerator.lab_murs.Text + 1
        Main.Engine.GetCellValue(x, y) = idmur
        'Main.PlateauDeJeu.ActualisePosition(x, y)

        If Main.Engine.GetCellValue(x + 1, y) = ID And x + 1 > 0 And y > 0 And x + 1 < Main.Engine.TaillePlateau.Width + 1 And y < Main.Engine.TaillePlateau.Height + 1 Then
            'Main.PlateauDeJeu.ValeurCase(x + 1, y) = newID
            '  Main.PlateauDeJeu.ActualisePosition(x + 1, y)
            RecursiveParse(x + 1, y, ID)
        End If
        If Main.Engine.GetCellValue(x - 1, y) = ID And x - 1 > 0 And y > 0 And x - 1 < Main.Engine.TaillePlateau.Width + 1 And y < Main.Engine.TaillePlateau.Height + 1 Then
            'Main.PlateauDeJeu.ValeurCase(x - 1, y) = newID
            '  Main.PlateauDeJeu.ActualisePosition(x - 1, y)
            RecursiveParse(x - 1, y, ID)
        End If
        If Main.Engine.GetCellValue(x, y + 1) = ID And x > 0 And y + 1 > 0 And x < Main.Engine.TaillePlateau.Width + 1 And y + 1 < Main.Engine.TaillePlateau.Height + 1 Then
            'Main.PlateauDeJeu.ValeurCase(x, y + 1) = newID
            '   Main.PlateauDeJeu.ActualisePosition(x, y + 1)
            RecursiveParse(x, y + 1, ID)
        End If
        If Main.Engine.GetCellValue(x, y - 1) = ID And x > 0 And y - 1 > 0 And x < Main.Engine.TaillePlateau.Width + 1 And y - 1 < Main.Engine.TaillePlateau.Height + 1 Then
            'Main.PlateauDeJeu.ValeurCase(x, y - 1) = newID
            '   Main.PlateauDeJeu.ActualisePosition(x, y - 1)
            RecursiveParse(x, y - 1, ID)
        End If
    End Sub
    Public Sub SelectRandomNode()
        'Choisi un noeud aléatoire dans la liste   
        Dim pickedWall As MazeNode = MazeListe.Item(RandomGen.Next(0, MazeListe.Count))
        'Récupère les coord pour le curseur
        x = pickedWall.x
        y = pickedWall.y
        'Demande aqu curseur de tracer un chemin
        CursorFill()

    End Sub

    Public Sub CursorFill()
        'Nombre de tentative de recherche de chemin pour le curseur
        For i As Integer = 0 To LongueurChemin

            If x + 1 <= Main.Engine.TaillePlateau.Width Then
                If Not IsNothing(MazeTable(x + 1, y)) Then
                    If MazeTable(x + 1, y).visitee = False And MazeTable(x + 1, y).murFixe = False And MazeTable(x + 1, y).HasAnEmptyCell Then
                        If RandomGen.Next(0, 3) = 1 Then
                            MazeTable(x, y).AddCells()
                            x = x + 1
                        End If
                    End If
                End If
            End If

            If x - 1 > 0 Then
                If Not IsNothing(MazeTable(x - 1, y)) Then
                    If MazeTable(x - 1, y).visitee = False And MazeTable(x - 1, y).murFixe = False And MazeTable(x - 1, y).HasAnEmptyCell Then
                        If RandomGen.Next(0, 3) = 1 Then
                            MazeTable(x, y).AddCells()
                            x = x - 1
                        End If
                    End If
                End If
            End If

            If y + 1 <= Main.Engine.TaillePlateau.Width Then
                If Not IsNothing(MazeTable(x, y + 1)) Then
                    If MazeTable(x, y + 1).visitee = False And MazeTable(x, y + 1).murFixe = False And MazeTable(x, y + 1).HasAnEmptyCell Then
                        If RandomGen.Next(0, 3) = 1 Then
                            MazeTable(x, y).AddCells()
                            y = y + 1
                        End If
                    End If
                End If
            End If

            If y - 1 > 0 Then
                If Not IsNothing(MazeTable(x, y - 1)) Then
                    If MazeTable(x, y - 1).visitee = False And MazeTable(x, y - 1).murFixe = False And MazeTable(x, y - 1).HasAnEmptyCell Then
                        If RandomGen.Next(0, 3) = 1 Then
                            MazeTable(x, y).AddCells()
                            y = y - 1
                        End If
                    End If
                End If
            End If
            MazeListe.Remove(MazeTable(x, y))
        Next
    End Sub

    Public Function GetNoeudsRestants() As Integer
        Return MazeListe.Count()
    End Function
End Class

Public Class MazeNode
    'Parent
    Public ParentCursor As MazeCursor
    'Position du noeud
    Public x As Integer
    Public y As Integer

    'Mur fixe d'office (cases paires)
    Public murFixe As Boolean = False
    'Si la cellule est vérouillée
    Public visitee As Boolean = False


    Sub New(ByVal _x As Integer, ByVal _y As Integer, ByVal _parent As MazeCursor)
        x = _x
        y = _y
        ParentCursor = _parent
        If x Mod 2 = 0 And y Mod 2 = 0 Then
            murFixe = True
        End If

    End Sub

    Public Function HasAnEmptyCell() As Boolean
        'Retourne une valeur faux si la cellule est adjacente à plusieures cellules visitées
        If x Mod 2 = 1 And y Mod 2 = 1 Then
            Return True
        End If
        Dim compteur As Integer = 0
        Dim compteurmur As Integer = 0
        If x + 1 <= Main.Engine.TaillePlateau.Width Then
            If Not IsNothing(ParentCursor.MazeTable(x + 1, y)) Then
                If ParentCursor.MazeTable(x + 1, y).visitee = True Then
                    compteur = compteur + 1
                End If
            End If
        End If

        If x - 1 > 0 Then
            If Not IsNothing(ParentCursor.MazeTable(x - 1, y)) Then
                If ParentCursor.MazeTable(x - 1, y).visitee = True Then
                    compteur = compteur + 1
                End If
            End If
        End If

        If y + 1 <= Main.Engine.TaillePlateau.Height Then
            If Not IsNothing(ParentCursor.MazeTable(x, y + 1)) Then
                If ParentCursor.MazeTable(x, y + 1).visitee = True Then
                    compteur = compteur + 1
                End If
            End If
        End If

        If y - 1 > 0 Then
            If Not IsNothing(ParentCursor.MazeTable(x, y - 1)) Then
                If ParentCursor.MazeTable(x, y - 1).visitee = True Then
                    compteur = compteur + 1
                End If
            End If
        End If

        If compteur > 1 Then
            If visitee = False Then
                murFixe = True
            End If

            ParentCursor.MazeListe.Remove(Me)
            Return False
        Else
            Return True
        End If
    End Function

    'Ajoute les cellules adjacentes dans la liste
    Public Sub AddCells()
        visitee = True
        If x + 1 <= Main.Engine.TaillePlateau.Width Then
            If Not IsNothing(ParentCursor.MazeTable(x + 1, y)) Then
                If ParentCursor.MazeTable(x + 1, y).visitee = False And ParentCursor.MazeTable(x + 1, y).murFixe = False And ParentCursor.MazeTable(x + 1, y).HasAnEmptyCell Then
                    ParentCursor.MazeListe.Add(ParentCursor.MazeTable(x + 1, y))
                End If
            End If
        End If

        If x - 1 > 0 Then
            If Not IsNothing(ParentCursor.MazeTable(x - 1, y)) Then
                If ParentCursor.MazeTable(x - 1, y).visitee = False And ParentCursor.MazeTable(x - 1, y).murFixe = False And ParentCursor.MazeTable(x - 1, y).HasAnEmptyCell Then
                    ParentCursor.MazeListe.Add(ParentCursor.MazeTable(x - 1, y))
                End If
            End If
        End If

        If y + 1 <= Main.Engine.TaillePlateau.Height Then
            If Not IsNothing(ParentCursor.MazeTable(x, y + 1)) Then
                If ParentCursor.MazeTable(x, y + 1).visitee = False And ParentCursor.MazeTable(x, y + 1).murFixe = False And ParentCursor.MazeTable(x, y + 1).HasAnEmptyCell Then
                    ParentCursor.MazeListe.Add(ParentCursor.MazeTable(x, y + 1))
                End If
            End If
        End If

        If y - 1 > 0 Then
            If Not IsNothing(ParentCursor.MazeTable(x, y - 1)) Then
                If ParentCursor.MazeTable(x, y - 1).visitee = False And ParentCursor.MazeTable(x, y - 1).murFixe = False And ParentCursor.MazeTable(x, y - 1).HasAnEmptyCell Then
                    ParentCursor.MazeListe.Add(ParentCursor.MazeTable(x, y - 1))
                End If
            End If
        End If

        'Ajoute l'id de l'objet vide sur le plateau de jeu
        Main.Engine.GetCellValue(x, y) = ParentCursor.idespace
        'Main.PlateauDeJeu.ActualisePosition(x, y)
        'MazeGenerator.lab_murs.Text = MazeGenerator.lab_murs.Text - 1
        'MazeGenerator.lab_passages.Text = MazeGenerator.lab_passages.Text + 1
        ParentCursor.MazeListe.Remove(Me)
    End Sub

End Class