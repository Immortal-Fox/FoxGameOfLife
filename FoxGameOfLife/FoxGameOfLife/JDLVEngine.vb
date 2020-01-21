Imports System.Threading
Imports System.IO

''' <summary>
''' Moteur de jeu de la vie
''' </summary>
Public Class JDLVEngine

    Protected WithEvents Parent As PictureBox
    'Image et modificateur graphique

    Public ImageCourante As Bitmap          ' Image générée par le moteur à chaque frame
    Public G As Graphics                    ' Modificateur graphique

    Public ImageTexte As Bitmap             ' Image générée par le motêur à chaque frame (avec le texte)
    Public GTexte As Graphics               ' Modificateur graphique pour la partie texte

    Public ImagePinceau As Bitmap           ' Image générée par le pinceau à chaque mouvement de case (uniquement en mode édition)
    Public GPinceau As Graphics             ' Modificateur graphique

    Public genererImage As Boolean = True

    'Propriétés du plateau

    Public TaillePlateau As Size            ' Taille du plateau (cases)
    Public TailleCases As Integer           ' Taille d'une case (pixels)
    Public TailleBordure As Integer = 1     ' Taille de bordure

    Public couleurCellule As Color          ' Couleur des cases contenant une cellule
    Public couleurCaseVide As Color         ' Couleur des cases vides

    Public afficherGrille As Boolean        ' Afficher ou non la grille
    Public couleurGrille As Color           ' Couleur de la grille

    Public couleurMur As Color = Color.Red  ' Couleur des murs
    Public couleurCellulePermanente As Color = Color.Blue
    ' Propriétés des empreintes

    Public couleurEmpreinte As Color        ' Couleur des empreintes (pinceaux)
    Public couleurReperes As Color          ' Couleur des repères (pinceaux)
    Public utiliserReperes As Boolean       ' Affiche les repères de dimension du pinceau

    ' Propriétés du texte (frame)
    Public afficherTexte As Boolean
    Public couleurTexte As Color
    Public tailleTexte As Integer = 12
    Public nomPoliceTexte As String
    Public positionTexte As Point
    Public policeTexte As Font
    Public texte As String

    Public afficherFondTexte As Boolean
    Public couleurFondTexte As Color

    'Règles du jeu

    Public listeNombreCelluleSurvie As List(Of Integer)
    Public listeNombreCelluleCreation As List(Of Integer)

    ' Exceptions

    Public listeExceptionsCreation As List(Of CellException)
    Public listeExceptionsDesctruction As List(Of CellException)
    Public listeExceptionsSurvie As List(Of CellException)

    'Tableaux de données

    Public TableEdition(10000, 10000) As Byte       ' Table pour l'édition
    Private ReadOnly TableSequence(10000, 10000) As Byte      ' Table séquence de référence pour effectuer les opérations du jeu de la vie
    Private ReadOnly TableIntermediaire(10000, 10000) As Byte    ' Table intermédiaire pour effectuer les opérations du jeu de la vie

    'Snapshot

    Private ReadOnly limiteSnapshot As Integer = 200
    Private Liste_Snaphots As New List(Of Snapshot)
    Private numeroSnapshot As Integer = -1

    ' Mode

    Private modeEdition As Boolean = True

    ' Gestion des frames

    Public numeroFrame As Integer = 0

    ' statistiques
    Public naissances As Integer = 0
    Public morts As Integer = 0

    Public population As Integer = 0
    Public fps As Integer = 0
    Public tempsGeneration As TimeSpan
    Public tempsTotal As TimeSpan
    Public tempsFPS1 As TimeSpan

    ' Threading 
    Public nombreThread As NOMBRE_THREAD = NOMBRE_THREAD.AUCUN

    Private thread1 As Thread       ' Thread N°1
    Private t1_job As Boolean       ' Variable de synchronisation
    Private t1_deX As Integer       ' Zone de calcul pour le thread 1 (de x à x et de y à y)
    Private t1_aX As Integer        ' //
    Private t1_deY As Integer       ' //
    Private t1_aY As Integer        ' //
    Private thread2 As Thread
    Private t2_job As Boolean
    Private t2_deX As Integer
    Private t2_aX As Integer
    Private t2_deY As Integer
    Private t2_aY As Integer
    Private thread3 As Thread
    Private t3_job As Boolean
    Private t3_deX As Integer
    Private t3_aX As Integer
    Private t3_deY As Integer
    Private t3_aY As Integer
    Private thread4 As Thread
    Private t4_job As Boolean
    Private t4_deX As Integer
    Private t4_aX As Integer
    Private t4_deY As Integer
    Private t4_aY As Integer

    'Public debug As Integer = 0

    Enum NOMBRE_THREAD
        AUCUN = 0      ' Aucun Thread
        THREAD_1 = 1   ' 1 Thread
        THREAD_2 = 2   ' 2 threads
        THREAD_4 = 4 ' 4 Threads
    End Enum


    ''' <summary>
    ''' Constructeur du moteur de jeu de la vie
    ''' </summary>
    ''' <param name="_taillePlateau"> Dimension du plateau de jeu de la vie </param>
    Sub New(ByVal _taillePlateau As Size, ByRef _parent As PictureBox)
        Parent = _parent

        TailleCases = 7
        TaillePlateau = _taillePlateau
        couleurCellule = Color.Black
        couleurCaseVide = Color.White
        couleurGrille = Color.Gray

        couleurEmpreinte = Color.Red
        couleurReperes = Color.Black
        utiliserReperes = False

        listeNombreCelluleSurvie = New List(Of Integer)
        listeNombreCelluleSurvie.Add(2)
        listeNombreCelluleSurvie.Add(3)
        listeNombreCelluleCreation = New List(Of Integer)
        listeNombreCelluleCreation.Add(3)

        ' Création des listes d'exceptions
        listeExceptionsCreation = New List(Of CellException)
        listeExceptionsDesctruction = New List(Of CellException)
        listeExceptionsSurvie = New List(Of CellException)

        Initialisation()
    End Sub

    Public Property NombreThreads As NOMBRE_THREAD
        Get
            Return nombreThread
        End Get
        Set(value As NOMBRE_THREAD)
            nombreThread = value
        End Set
    End Property

    Public Sub ArreterThread()

        ' Arrête les threads si besoin
        If Not IsNothing(thread1) Then
            If thread1.IsAlive Then
                thread1.Abort()
                thread1 = Nothing
            End If
        End If
        If Not IsNothing(thread2) Then
            If thread2.IsAlive Then
                thread2.Abort()
                thread2 = Nothing
            End If
        End If
        If Not IsNothing(thread3) Then
            If thread3.IsAlive Then
                thread3.Abort()
                thread3 = Nothing
            End If
        End If
        If Not IsNothing(thread4) Then
            If thread4.IsAlive Then
                thread4.Abort()
                thread4 = Nothing
            End If
        End If
    End Sub

    ''' <summary>
    ''' Fonction pour la synchronisation des threads
    ''' </summary>
    Public Sub SynchronisationThread()
        'Do
        ' Si il faut dessiner l'image
        Dim jobOk As Boolean = False
        'Pour un thread
        If nombreThread = NOMBRE_THREAD.THREAD_1 Then
            If Not t1_job Then
                '    t1_job = True
                jobOk = True
            End If
        ElseIf nombreThread = NOMBRE_THREAD.THREAD_2 Then
            If Not t1_job And Not t2_job Then
                '    t1_job = True
                '    t2_job = True
                jobOk = True
            End If
        ElseIf nombreThread = NOMBRE_THREAD.THREAD_4 Then
            If Not t1_job And Not t2_job And Not t3_job And Not t4_job Then
                '    t1_job = True
                '    t2_job = True
                '    t3_job = True
                '   t4_job = True
                jobOk = True
            End If
        End If

        Dim tempPopulation As Integer = 0
        If jobOk Then

            If genererImage Then
                For x As Integer = 1 To TaillePlateau.Width
                    For y As Integer = 1 To TaillePlateau.Height
                        If TableSequence(x, y) <> TableIntermediaire(x, y) Then
                            TableSequence(x, y) = TableIntermediaire(x, y)
                            DessinerCase(x, y, TableIntermediaire(x, y))
                            If TableIntermediaire(x, y) = 1 Or TableIntermediaire(x, y) = 3 Then
                                tempPopulation += 1
                            End If
                        End If
                    Next
                Next

                If afficherTexte Then
                    DessinerTexte()
                End If

                ' Calculs pour statistiques
                numeroFrame = numeroFrame + 1
                population = tempPopulation
                Main.Invoke(New DelExporterImage(AddressOf ExporterImage))
            End If
            AjouterSnapshot()
            t1_job = True
            t2_job = True
            t3_job = True
            t4_job = True
        End If
        ' Loop
    End Sub
    Delegate Sub DelExporterImage()
    ''' <summary>
    ''' Exportation de l'image
    ''' </summary>
    Private Sub ExporterImage()
        'Main.pbox_plateau.Image = ImageCourante
        If afficherTexte Then
            Parent.Image = ImageTexte
        Else
            Parent.Image = ImageCourante
        End If
    End Sub

    Public Sub ActualiserImage()
        Parent.Image = ImageCourante
    End Sub

    ''' <summary>
    ''' Démarre le threading 
    ''' </summary>
    Public Sub InitThreading()
        ArreterThread()
        t1_job = True
        t2_job = True
        t3_job = True
        t4_job = True

        ' Créer les threads selon le nombre de coeur souhaité
        If nombreThread = NOMBRE_THREAD.THREAD_1 Then
            thread1 = New Thread(AddressOf Thread1Job)
            t1_deX = 0
            t1_aX = TaillePlateau.Width
            t1_deY = 0
            t1_aY = TaillePlateau.Height
            thread1.Start()
        ElseIf nombreThread = NOMBRE_THREAD.THREAD_2 Then
            thread1 = New Thread(AddressOf Thread1Job)
            t1_deX = 0
            t1_aX = TaillePlateau.Width
            t1_deY = 0
            t1_aY = Math.Floor(TaillePlateau.Height / 2)
            thread2 = New Thread(AddressOf Thread2Job)
            t2_deX = 0
            t2_aX = TaillePlateau.Width
            t2_deY = Math.Floor(TaillePlateau.Height / 2)
            t2_aY = TaillePlateau.Height
            thread1.Start()
            thread2.Start()
        ElseIf nombreThread = NOMBRE_THREAD.THREAD_4 Then
            thread1 = New Thread(AddressOf Thread1Job)
            t1_deX = 0
            t1_aX = Math.Floor(TaillePlateau.Width / 2)
            t1_deY = 0
            t1_aY = Math.Floor(TaillePlateau.Height / 2)
            thread2 = New Thread(AddressOf Thread2Job)
            t2_deX = Math.Floor(TaillePlateau.Width / 2)
            t2_aX = TaillePlateau.Width
            t2_deY = 0
            t2_aY = Math.Floor(TaillePlateau.Height / 2)
            thread3 = New Thread(AddressOf Thread3Job)
            t3_deX = 0
            t3_aX = Math.Floor(TaillePlateau.Width / 2) - 1
            t3_deY = Math.Floor(TaillePlateau.Height / 2) - 1
            t3_aY = TaillePlateau.Height
            thread4 = New Thread(AddressOf Thread4Job)
            t4_deX = Math.Floor(TaillePlateau.Width / 2) - 1
            t4_aX = TaillePlateau.Width
            t4_deY = Math.Floor(TaillePlateau.Height / 2) - 1
            t4_aY = TaillePlateau.Height
            thread1.IsBackground = True
            thread2.IsBackground = True
            thread3.IsBackground = True
            thread4.IsBackground = True
            thread1.Start()
            thread2.Start()
            thread3.Start()
            thread4.Start()
        End If

        'ThreadSynchronisateur = New Thread(AddressOf SynchronisationThread)
        'T 'hreadSynchronisateur.Start()
    End Sub

    ''' <summary>
    ''' Fonction du thread 1
    ''' </summary>
    Protected Sub Thread1Job()
        Do
            If t1_job Then
                For x As Integer = t1_deX To t1_aX
                    For y As Integer = t1_deY To t1_aY
                        'Ensuite on modifie le tableau intermédiaire selon les résultats des règles

                        If Not Exceptions(x, y) Then
                            'Si la case contient une cellule
                            If TableSequence(x, y) = 1 Then
                                If Not listeNombreCelluleSurvie.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de survie
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 0 Then

                                If Not listeNombreCelluleCreation.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de création
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 2 Then
                                TableIntermediaire(x, y) = 2
                            ElseIf TableSequence(x, y) = 3 Then
                                TableIntermediaire(x, y) = 3
                            End If

                        End If

                    Next
                Next

                t1_job = False
            End If
            Threading.Thread.Sleep(1)
        Loop
    End Sub

    ''' <summary>
    ''' Fonction du thread 2
    ''' </summary>
    Protected Sub Thread2Job()
        Do
            If t2_job Then
                For x As Integer = t2_deX To t2_aX
                    For y As Integer = t2_deY To t2_aY
                        'Ensuite on modifie le tableau intermédiaire selon les résultats des règles

                        If Not Exceptions(x, y) Then
                            'Si la case contient une cellule
                            If TableSequence(x, y) = 1 Then
                                If Not listeNombreCelluleSurvie.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de survie
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 0 Then

                                If Not listeNombreCelluleCreation.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de création
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 2 Then
                                TableIntermediaire(x, y) = 2
                            ElseIf TableSequence(x, y) = 3 Then
                                TableIntermediaire(x, y) = 3
                            End If

                        End If

                    Next
                Next
                t2_job = False
            End If
        Loop
    End Sub

    ''' <summary>
    ''' Fonction du thread 3
    ''' </summary>
    Protected Sub Thread3Job()
        Do
            If t3_job Then
                For x As Integer = t3_deX To t3_aX
                    For y As Integer = t3_deY To t3_aY
                        'Ensuite on modifie le tableau intermédiaire selon les résultats des règles

                        If Not Exceptions(x, y) Then
                            'Si la case contient une cellule
                            If TableSequence(x, y) = 1 Then
                                If Not listeNombreCelluleSurvie.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de survie
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 0 Then

                                If Not listeNombreCelluleCreation.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de création
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 2 Then
                                TableIntermediaire(x, y) = 2
                            ElseIf TableSequence(x, y) = 3 Then
                                TableIntermediaire(x, y) = 3
                            End If

                        End If

                    Next
                Next
                t3_job = False
            End If
        Loop
    End Sub

    ''' <summary>
    ''' Fonction du thread 4
    ''' </summary>
    Protected Sub Thread4Job()
        Do
            If t4_job Then
                For x As Integer = t4_deX To t4_aX
                    For y As Integer = t4_deY To t4_aY
                        'Ensuite on modifie le tableau intermédiaire selon les résultats des règles

                        If Not Exceptions(x, y) Then
                            'Si la case contient une cellule
                            If TableSequence(x, y) = 1 Then
                                If Not listeNombreCelluleSurvie.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de survie
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 0 Then

                                If Not listeNombreCelluleCreation.Contains(NombreCellulesVoisines(x, y)) Then
                                    'Si la case ne répond pas aux règles de création
                                    TableIntermediaire(x, y) = 0
                                Else
                                    TableIntermediaire(x, y) = 1
                                End If

                            ElseIf TableSequence(x, y) = 2 Then
                                TableIntermediaire(x, y) = 2
                            ElseIf TableSequence(x, y) = 3 Then
                                TableIntermediaire(x, y) = 3
                            End If

                        End If

                    Next
                Next
                t4_job = False
            End If
        Loop
    End Sub
    ''' <summary>
    ''' Modifie les propriétés du texte
    ''' </summary>
    ''' <param name="_couleurTexte">Couleur du texte</param>
    ''' <param name="_policeTexte">Police du texte</param>
    ''' <param name="_texte">Texte</param>
    ''' <param name="_positionTexte">Position du texte</param>
    Public Sub ModifierTexte(ByVal _couleurTexte As Color, ByVal _policeTexte As Font, ByVal _texte As String, Optional _positionTexte As Point = Nothing)
        texte = _texte
        couleurTexte = _couleurTexte
        policeTexte = _policeTexte
        If Not IsNothing(_positionTexte) Then
            positionTexte = _positionTexte
        End If

    End Sub

    ''' <summary>
    ''' Permet de convertir les variables du texte
    ''' </summary>
    ''' <param name="_texte">Texte à convertir</param>
    ''' <returns>Texte converti</returns>
    Public Function TexteVariables(ByVal _texte As String) As String
        ' Décode les variables dans le texte
        _texte = _texte.Replace("{frame}", numeroFrame)
        _texte = _texte.Replace("{fps}", fps)
        _texte = _texte.Replace("{population}", population)
        _texte = _texte.Replace("{time}", tempsGeneration.Milliseconds)
        Dim str As String = ""
        For Each n As String In listeNombreCelluleSurvie
            str = str & n
        Next
        str = str & "/"
        For Each n As String In listeNombreCelluleCreation
            str = str & n
        Next
        _texte = _texte.Replace("{rules}", str)
        _texte = _texte.Replace("{username}", Environment.UserName)
        _texte = _texte.Replace("{width}", TaillePlateau.Width)
        _texte = _texte.Replace("{height}", TaillePlateau.Height)
        _texte = _texte.Replace("{widthpx}", ImageCourante.Width)
        _texte = _texte.Replace("{heightpx}", ImageCourante.Height)
        _texte = _texte.Replace("{cellsize}", TailleCases)
        _texte = _texte.Replace("{thread}", nombreThread)
        _texte = _texte.Replace("{dev}", "Charmillot Ludovic @Immortal Fox @Zyldar")
        _texte = _texte.Replace("{version}", Main.versionProgramme)
        _texte = _texte.Replace("{program}", Main.nomProgramme)
        Return _texte
    End Function

    ''' <summary>
    ''' Dessine le texte sur l'image
    ''' </summary>
    Public Sub DessinerTexte()

        GTexte.Clear(Color.Transparent)

        ' Dessine l'image courante
        GTexte.DrawImageUnscaledAndClipped(ImageCourante, New Rectangle(0, 0, ImageCourante.Width, ImageCourante.Height))

        ' Affiche la couleur d'arrière plan du texte si voulu
        If afficherFondTexte Then
            Dim tailleFond As SizeF = GTexte.MeasureString(TexteVariables(texte), policeTexte)
            GTexte.FillRectangle(New SolidBrush(couleurFondTexte), New Rectangle(positionTexte.X, positionTexte.Y, tailleFond.Width, tailleFond.Height))
        End If
        ' Dessine le texte
        GTexte.DrawString(TexteVariables(texte), policeTexte, New SolidBrush(couleurTexte), New PointF(positionTexte.X, positionTexte.Y))

    End Sub

    ''' <summary>
    ''' Dessine l'empreinte d'un pinceau selon une liste de points
    ''' </summary>
    ''' <param name="_liste_Points">Liste de points qui correspond à l'empreinte du pinceau</param>
    Public Sub DessinerEmpreintePinceau(ByVal _liste_Points As List(Of Point))
        GPinceau.Clear(Color.Transparent)
        GPinceau.DrawImage(ImageCourante, 0, 0)
        Dim xMin As Integer = TaillePlateau.Width
        Dim xMax As Integer = 0
        Dim yMin As Integer = TaillePlateau.Height
        Dim yMax As Integer = 0

        ' utilisation des repères
        If utiliserReperes Then

            For Each _point As Point In _liste_Points
                If _point.X < xMin Then xMin = _point.X
                If _point.X > xMax Then xMax = _point.X
                If _point.Y < yMin Then yMin = _point.Y
                If _point.Y > yMax Then yMax = _point.Y
            Next

            ' Dessin des barres horizontales et verticales
            GPinceau.DrawLine(New Pen(Color.Black, 1), xMax * TailleCases + TailleCases, 0, xMax * TailleCases + TailleCases, TaillePlateau.Height * TailleCases)
            GPinceau.DrawLine(New Pen(Color.Black, 1), xMin * TailleCases, 0, xMin * TailleCases, TaillePlateau.Height * TailleCases)
            GPinceau.DrawLine(New Pen(Color.Black, 1), 0, yMin * TailleCases, TaillePlateau.Width * TailleCases, yMin * TailleCases)
            GPinceau.DrawLine(New Pen(Color.Black, 1), 0, yMax * TailleCases + TailleCases, TaillePlateau.Width * TailleCases, yMax * TailleCases + TailleCases)
        End If

        ' Dessin de l'empreinte
        For Each _point As Point In _liste_Points
            GPinceau.DrawRectangle(New Pen(Color.Red, 1), New Rectangle(_point.X * TailleCases, _point.Y * TailleCases, TailleCases, TailleCases))
        Next

    End Sub



    ''' <summary>
    ''' Génère l'image suivante (Ne fonctionne pas en mode édition)
    ''' </summary>
    Public Sub GenererFrameSuivante()

        ' Si le programme est multithreader
        If nombreThread <> NOMBRE_THREAD.AUCUN Then
            ' Initialisation des threads
            If IsNothing(thread1) Then
                InitThreading()
            End If
            ' Synchronisation des threads
            SynchronisationThread()

        Else
            ' Si le programme n'est pas multithreader
            ' Variables pour statistiques
            Dim tempsTemporaire As Date = Date.Now
            Dim tempPopulation As Integer = 0
            ' On parcourt tout le tableau séquence pour créer les données suivantes
            For x As Integer = 1 To TaillePlateau.Width
                For y As Integer = 1 To TaillePlateau.Height
                    'Ensuite on modifie le tableau intermédiaire selon les résultats des règles

                    If Not Exceptions(x, y) Then
                        'Si la case contient une cellule
                        If TableSequence(x, y) = 1 Then
                            tempPopulation += 1
                            If Not listeNombreCelluleSurvie.Contains(NombreCellulesVoisines(x, y)) Then
                                'Si la case ne répond pas aux règles de survie
                                TableIntermediaire(x, y) = 0
                            Else
                                TableIntermediaire(x, y) = 1
                            End If

                        ElseIf TableSequence(x, y) = 0 Then

                            If Not listeNombreCelluleCreation.Contains(NombreCellulesVoisines(x, y)) Then
                                'Si la case ne répond pas aux règles de création
                                TableIntermediaire(x, y) = 0
                            Else
                                TableIntermediaire(x, y) = 1
                            End If

                        ElseIf TableSequence(x, y) = 2 Then
                            TableIntermediaire(x, y) = 2
                        ElseIf TableSequence(x, y) = 3 Then
                            TableIntermediaire(x, y) = 3
                            tempPopulation += 1
                        End If

                    End If

                Next
            Next
            population = tempPopulation

            ' On créer l'image et on inverse le tableau

            For x As Integer = 1 To TaillePlateau.Width
                For y As Integer = 1 To TaillePlateau.Height
                    If TableSequence(x, y) <> TableIntermediaire(x, y) Then
                        TableSequence(x, y) = TableIntermediaire(x, y)
                        DessinerCase(x, y, TableIntermediaire(x, y))
                    End If
                Next
            Next

            ' Calculs pour statistiques
            numeroFrame = numeroFrame + 1
            tempsGeneration = Date.Now - tempsTemporaire
            tempsTotal = tempsTotal + tempsGeneration

            Dim zzz As Date = Date.Now - tempsFPS1
            fps = 1000 / zzz.Ticks

            If genererImage Then
                If afficherTexte Then
                    DessinerTexte()
                End If
                ExporterImage()
            End If

            AjouterSnapshot()
        End If
    End Sub

    ''' <summary>
    ''' Teste la présence d'exceptions
    ''' </summary>
    ''' <param name="_x">Coordonnées X de la cellule</param>
    ''' <param name="_y">Coordonnées Y de la cellule</param>
    ''' <returns></returns>
    Public Function Exceptions(ByVal _x As Integer, ByVal _y As Integer) As Boolean
        Dim score As Byte = 0

        ' Exceptions de destruction de cellule

        If TableSequence(_x, _y) = 1 Then
            For Each _exe As CellException In listeExceptionsDesctruction
                score = 0
                For xx As Integer = -1 To 1
                    For yy As Integer = -1 To 1
                        If CelluleDansLimites(_x + xx, _y + yy) And Not (xx = 0 And yy = 0) Then
                            If TableSequence(_x + xx, _y + yy) = _exe.GetTableValue(xx + 2, yy + 2) Then
                                score = score + 1
                            End If
                        End If
                    Next
                Next
                If score = 8 Then
                    TableIntermediaire(_x, _y) = 0
                    Return True
                End If
            Next
        End If

        'Exceptions de création de cellule

        If TableSequence(_x, _y) = 0 Then
            For Each _exe As CellException In listeExceptionsCreation
                score = 0
                For xx As Integer = -1 To 1
                    For yy As Integer = -1 To 1
                        If CelluleDansLimites(_x + xx, _y + yy) And Not (xx = 0 And yy = 0) Then
                            If TableSequence(_x + xx, _y + yy) = _exe.GetTableValue(xx + 2, yy + 2) Then
                                score = score + 1
                            End If
                        End If
                    Next
                Next
                If score = 8 Then
                    TableIntermediaire(_x, _y) = 1
                    Return True
                End If
            Next
        End If


        Return False
    End Function

    ''' <summary>
    ''' Permet de récupérer le nombre de cellule voisine d'une case
    ''' </summary>
    ''' <param name="x">Coordonnée X de la case</param>
    ''' <param name="y">Coordonnée Y de la case</param>
    ''' <returns>Retourne le nombre de cellule voisine d'une case</returns>
    Public Function NombreCellulesVoisines(ByVal x As Integer, ByVal y As Integer)
        Dim nombreCellules As Integer = 0

        For i As SByte = -1 To 1 Step 1
            For u As SByte = -1 To 1 Step 1
                If CelluleDansLimites(x + i, y + u) And Not (i = 0 And u = 0) Then
                    If TableSequence(x + i, y + u) = 1 Or TableSequence(x + i, y + u) = 3 Then
                        nombreCellules += 1
                    End If
                End If
            Next
        Next

        Return nombreCellules
    End Function

    ''' <summary>
    ''' Teste si les coordonnées sont comprises dans les limites du plateau
    ''' </summary>
    ''' <param name="x">Coordonnée X</param>
    ''' <param name="y">Coordonnée Y</param>
    ''' <returns>Retourne vrai si les coordonnées sont dans les limites du plateau, sinon retourne faux</returns>
    Public Function CelluleDansLimites(ByVal x As Integer, ByVal y As Integer) As Boolean
        If x > 0 Then
            If y > 0 Then
                If x <= TaillePlateau.Width Then
                    If y <= TaillePlateau.Height Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function

    ''' <summary>
    ''' Redimensionne la taille du plateau en générant une nouvelle image
    ''' </summary>
    Public Sub ToutRedimensionner()

        'Supression de l'ancienne image
        If Not IsNothing(ImageCourante) Then
            ImageCourante.Dispose()
        End If

        'Création de l'image
        ImageCourante = New Bitmap(TaillePlateau.Width * TailleCases, TaillePlateau.Height * TailleCases)

        'Association au modificateur graphique
        G = Graphics.FromImage(ImageCourante)
        G.Clear(Color.White)

        ImagePinceau = New Bitmap(TaillePlateau.Width * TailleCases, TaillePlateau.Height * TailleCases)
        GPinceau = Graphics.FromImage(ImagePinceau)

        ImageTexte = New Bitmap(TaillePlateau.Width * TailleCases, TaillePlateau.Height * TailleCases)
        GTexte = Graphics.FromImage(ImageTexte)
    End Sub

    ''' <summary>
    ''' Efface toutes les données des tableaux
    ''' </summary>
    Public Sub EffacerTableaux()
        For x As Integer = 1 To TaillePlateau.Width
            For y As Integer = 1 To TaillePlateau.Width
                TableEdition(x, y) = 0
                TableSequence(x, y) = 0
                TableIntermediaire(x, y) = 0
            Next
        Next
    End Sub

    ''' <summary>
    ''' Redessine toute l'image
    ''' </summary>
    Public Sub ToutRedessiner()

        'Si on est en mode edition
        If modeEdition Then
            For x As Integer = 1 To TaillePlateau.Width
                For y As Integer = 1 To TaillePlateau.Height
                    DessinerCase(x, y, TableEdition(x, y))
                Next
            Next
        Else
            For x As Integer = 1 To TaillePlateau.Width
                For y As Integer = 1 To TaillePlateau.Height
                    DessinerCase(x, y, TableSequence(x, y))
                Next
            Next
        End If

        'Si on est en mode simulation
    End Sub

    ''' <summary>
    ''' Dessine une case
    ''' </summary>
    ''' <param name="_x">Coordonnée X de la case</param>
    ''' <param name="_y">Coordonnée Y de la case</param>
    ''' <param name="_valeur">Valeur du contenu de la case (vrai = cellule)</param>
    Public Sub DessinerCase(ByVal _x As Integer, ByVal _y As Integer, ByVal _valeur As Byte)
        If genererImage Then
            If _valeur = 1 Then
                G.FillRectangle(New SolidBrush(couleurCellule), New Rectangle(_x * TailleCases - TailleCases, _y * TailleCases - TailleCases, TailleCases, TailleCases))
            ElseIf _valeur = 0 Then
                G.FillRectangle(New SolidBrush(couleurCaseVide), New Rectangle(_x * TailleCases - TailleCases, _y * TailleCases - TailleCases, TailleCases, TailleCases))
            ElseIf _valeur = 2 Then
                G.FillRectangle(New SolidBrush(couleurMur), New Rectangle(_x * TailleCases - TailleCases, _y * TailleCases - TailleCases, TailleCases, TailleCases))
            ElseIf _valeur = 3 Then
                G.FillRectangle(New SolidBrush(couleurCellulePermanente), New Rectangle(_x * TailleCases - TailleCases, _y * TailleCases - TailleCases, TailleCases, TailleCases))
            End If
            'Ajoute la grille si besoin
            If afficherGrille Then
                G.DrawRectangle(New Pen(couleurGrille, 1), New Rectangle(_x * TailleCases - TailleCases, _y * TailleCases - TailleCases, TailleCases, TailleCases))
            End If
        End If
    End Sub

    ''' <summary>
    ''' Initialise le plateau
    ''' </summary>
    Private Sub Initialisation()

        'Création de l'image
        ImageCourante = New Bitmap(TaillePlateau.Width * TailleCases, TaillePlateau.Height * TailleCases)
        'Association au modificateur graphique
        G = Graphics.FromImage(ImageCourante)
        G.Clear(Color.White)

        'Création de l'image pour empreinte pinceau
        ImagePinceau = New Bitmap(TaillePlateau.Width * TailleCases, TaillePlateau.Height * TailleCases)
        GPinceau = Graphics.FromImage(ImagePinceau)

        ' Création du texte de base
        ImageTexte = New Bitmap(TaillePlateau.Width * TailleCases, TaillePlateau.Height * TailleCases)
        GTexte = Graphics.FromImage(ImageTexte)
        ModifierTexte(Color.Black, New Font("Arial", 12), "FoxGameOfLife by Immortal Fox" & vbCrLf & "Frame : {frame}", New Point(5, 5))
        ToutRedessiner()
    End Sub

    ''' <summary>
    ''' Permet de définir dans quel mode utiliser le moteur
    ''' </summary>
    ''' <returns>Si on est en mode édition ou pas</returns>
    Public Property SetMode(Optional _garderBoard As Boolean = False) As Boolean
        Get
            Return modeEdition
        End Get
        Set(value As Boolean)
            modeEdition = value

            'Si on quitte le mode édition
            If value = False Then

                'On set le tableau séquence selon le tableau edition

                For x As Integer = 1 To TaillePlateau.Width
                    For y As Integer = 1 To TaillePlateau.Width
                        TableSequence(x, y) = TableEdition(x, y)
                    Next
                Next

                AjouterSnapshot()
            Else
                'Arrête les threads si besoin
                ArreterThread()

                If _garderBoard = False Then
                    'Si on quitte le mode simulation
                    ReinitialiserPlateau()
                Else
                    GarderConfigurationPlateau()
                End If

                'Reset les snapshots
                EffacerSnapshots()
                End If
        End Set
    End Property

    ''' <summary>
    ''' Garde la configuration du JDLV après un Stop
    ''' </summary>
    Public Sub GarderConfigurationPlateau()
        For x As Integer = 1 To TaillePlateau.Width
            For y As Integer = 1 To TaillePlateau.Width
                If TableSequence(x, y) <> TableEdition(x, y) Then
                    DessinerCase(x, y, TableSequence(x, y))
                    TableEdition(x, y) = TableSequence(x, y)
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' Reviens en mode séquence
    ''' </summary>
    Public Sub ReinitialiserPlateau()
        For x As Integer = 1 To TaillePlateau.Width
            For y As Integer = 1 To TaillePlateau.Width
                If TableSequence(x, y) <> TableEdition(x, y) Then
                    DessinerCase(x, y, TableEdition(x, y))
                    TableSequence(x, y) = TableEdition(x, y)
                End If
            Next
        Next
        ' reset du temps total
        tempsTotal = Nothing
    End Sub

    ''' <summary>
    ''' Ouvre un fichier .Lif
    ''' </summary>
    ''' <param name="_path"></param>
    Public Sub OuvrirFichierLife(ByVal _path As String)
        Try
            ' Si le fichier n'existe pas on quitte la fonction
            If Not File.Exists(_path) Then
                MsgBox("Erreur lors de l'ouverture du fichier - Fichier inexistant")
                Exit Sub
            End If

            ' Variables pour définir la hauteur et la largeur du JDLV
            Dim largeur As Integer = 0
            Dim hauteur As Integer = 0
            ' Liste de cellules finale
            Dim listeCellules As New List(Of Byte)

            ' On ouvre le stream reader
            Using sr As New StreamReader(_path)
                ' Lit chaque ligne du fichier
                Do While (Not sr.EndOfStream)
                    ' Récupère la ligne du fichier texte
                    Dim line As String = sr.ReadLine()
                    largeur = 0
                    ' Si le premier caractère est #
                    If line.Substring(0, 1) = "#" Then

                    Else ' Sinon on récpère la ligne et on interprète chaque caractère
                        hauteur = hauteur + 1

                        For Each _car As Char In line
                            largeur = largeur + 1
                            ' Si le caractère représente une case vide
                            If _car = "." Then
                                listeCellules.Add(0)
                            Else
                                ' Sinon on ajoute une cellule pleine
                                listeCellules.Add(1)
                            End If
                        Next

                    End If
                Loop
                ' Fin de la lecture du fichier
            End Using

            If largeur = 0 Or hauteur = 0 Then
                MsgBox("Largeur ou hauteur de fichier incorrecte")
                Exit Sub
            End If
            ' On reset le plateau et on applique la liste de cellules
            ReinitialiserPlateau()

            ' On applique la largeur et la hauteur
            Me.TaillePlateau = New Size(largeur, hauteur)

            ToutRedimensionner()

            ' On applique les cellules et les zones vides
            For x As Integer = 1 To largeur
                For y As Integer = 1 To hauteur
                    TableEdition(x, y) = listeCellules.First
                    TableSequence(x, y) = listeCellules.First
                    listeCellules.RemoveAt(0)
                Next
            Next

            ToutRedessiner()

        Catch ex As Exception
            MsgBox("Erreur lors de la lecture du fichier" & vbCrLf & ex.ToString)
        End Try


    End Sub

    ''' <summary>
    ''' Efface les listes d'exceptions
    ''' </summary>
    Public Sub ReinitialiserExceptions()
        listeExceptionsDesctruction.Clear()
        listeExceptionsSurvie.Clear()
        listeExceptionsCreation.Clear()
    End Sub

    ''' <summary>
    ''' Efface tous les snapshots de la liste
    ''' </summary>
    Public Sub EffacerSnapshots()

        Liste_Snaphots.Clear()
        numeroSnapshot = -1
    End Sub

    ''' <summary>
    ''' Ajoute un snapshot
    ''' </summary>
    Private Sub AjouterSnapshot()

        'Si la limite de snapshots est atteinte on supprime le premier de la liste
        If Liste_Snaphots.Count > limiteSnapshot Then
            Liste_Snaphots.RemoveAt(0)
        End If

        'Si il y a des snapshots en trop après le point de retour on les supprime aussi
        If Liste_Snaphots.Count > numeroSnapshot + 1 Then
            Liste_Snaphots.RemoveRange(numeroSnapshot, Liste_Snaphots.Count - numeroSnapshot)
        End If

        'Converti le tableau en liste
        Dim liste_temp As New List(Of Byte)
        For x As Integer = 1 To TaillePlateau.Width
            For y As Integer = 1 To TaillePlateau.Height
                liste_temp.Add(TableSequence(x, y))
            Next
        Next

        'Ajoute le snapshot
        Liste_Snaphots.Add(New Snapshot(TaillePlateau.Width, TaillePlateau.Height, liste_temp, Me))

        'Met à jour le compteur de snapshot
        If numeroSnapshot < limiteSnapshot Then
            numeroSnapshot = numeroSnapshot + 1
        End If

    End Sub

    ''' <summary>
    ''' Revient à un état entérieur du plateau
    ''' </summary>
    Public Sub AppliquerSnapshotPrecedent()

        'Si il y a des snapshots dans la liste

        If numeroSnapshot > 0 Then

            'Récupérer le snapshot

            Dim temp_listeEtat As List(Of Byte) = Liste_Snaphots(numeroSnapshot - 1).liste_etatPlateau
            Dim index = 0

            'Appliquer état du plateau

            For x As Integer = 1 To TaillePlateau.Width
                For y As Integer = 1 To TaillePlateau.Height
                    TableSequence(x, y) = temp_listeEtat(index)
                    index = index + 1
                Next
            Next

            numeroSnapshot = numeroSnapshot - 1
            numeroFrame = numeroFrame - 1
            temp_listeEtat.Clear()
            ToutRedessiner()

        End If

    End Sub

    ''' <summary>
    ''' Retourne la valeur d'une cellule du tableau d'édition
    ''' </summary>
    ''' <param name="_x">Position X</param>
    ''' <param name="_y">Position Y</param>
    ''' <returns>Si la case contient une cellule</returns>
    Public Property GetCellValue(ByVal _x As Integer, ByVal _y As Integer) As Byte
        Get
            If CelluleDansLimites(_x, _y) Then
                Return TableEdition(_x, _y)
            Else
                Return False
            End If
        End Get
        Set(value As Byte)
            If modeEdition Then
                If CelluleDansLimites(_x, _y) Then
                    TableEdition(_x, _y) = value
                    DessinerCase(_x, _y, value)
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' Permet d'enregistrer l'état du plateau afin de pouvoir revenir en arrière
    ''' </summary>
    Protected Class Snapshot
        Private ReadOnly Parent As JDLVEngine
        Public largeur As Integer
        Public hauteur As Integer
        Public liste_etatPlateau As New List(Of Byte)

        Sub New(ByVal _largeur As Integer, ByVal _hauteur As Integer, ByVal _liste_etat As List(Of Byte), ByVal _parent As JDLVEngine)
            largeur = _largeur
            hauteur = _hauteur
            liste_etatPlateau = _liste_etat
        End Sub

    End Class

End Class


''' <summary>
''' Objet pour le mode exception
''' </summary>
Public Class CellException
    Private table(3, 3) As Byte ' Table indiquant les exceptions à suivre

    ''' <summary>
    ''' Permet de récupérer ou modifier l'état de l'exception
    ''' </summary>
    ''' <param name="x">Case x du tableau d'exception</param>
    ''' <param name="y">Case y du tableau d'exception</param>
    ''' <returns>Valeur de l'exception</returns>
    Public Property GetTableValue(ByVal x As Byte, ByVal y As Byte) As Byte
        Get
            Return table(x, y)
        End Get
        Set(value As Byte)
            table(x, y) = value
        End Set
    End Property
End Class