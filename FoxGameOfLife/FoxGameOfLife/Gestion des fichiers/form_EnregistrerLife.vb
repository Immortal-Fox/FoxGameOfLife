Imports System.IO
Public Class form_EnregistrerLife

    Public Const DEADCELL_CHAR As Char = "."
    Public Const ALIVECELL_CHAR As Char = "*"

    Public Version As String
    Public Description As String
    Public Regles As String
    Public Position As String
    Public ListeCellules As New List(Of String)
    Public ListeDescription As New List(Of String)

    Private Sub EnregistrerLife_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Préparation des champs

        ' Version du fichier
        Version = "#Life 1.05"
        ' Description
        Description = "A définir"
        ' Règles
        Regles = "#R " & Main.Engine.TexteVariables("{rules}")
        ' Position
        Position = "#P -1 -1"

        For x As Integer = 1 To Main.Engine.TaillePlateau.Width
            Dim line As String = ""
            For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                If Main.Engine.GetCellValue(x, y) = 0 Then
                    line = line & DEADCELL_CHAR
                Else
                    line = line & ALIVECELL_CHAR
                End If
            Next
            ListeCellules.Add(line)
        Next

        txtb_description.Clear()
        txtb_nomFichier.Clear()
    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        Me.Close()
    End Sub

    Private Sub bt_enregistrer_Click(sender As Object, e As EventArgs) Handles bt_enregistrer.Click
        ' Enregistrement de la description
        ListeDescription.Clear()

        For Each _ligne As String In txtb_description.Lines
            ListeDescription.Add("#D " & _ligne)
        Next

        If Main.DossierExiste(Main.dir_life, True) Then
            If Not File.Exists(Main.dir_life & "/" & txtb_nomFichier.Text & ".lif") Then
                EcrireFichierLife(Main.dir_life & "/" & txtb_nomFichier.Text & ".lif")
            End If
        End If

    End Sub

    Public Sub EcrireFichierLife(ByVal _path As String)
        Dim sw As New StreamWriter(_path, False)
        sw.WriteLine(Version)   ' Version de format de fichier
        For Each _ligne As String In ListeDescription
            sw.WriteLine(_ligne)    ' Description du fichier
        Next
        sw.WriteLine(Regles)
        sw.WriteLine(Position)
        For Each _ligneCells As String In ListeCellules
            sw.WriteLine(_ligneCells)
        Next
        sw.Close()
    End Sub
End Class