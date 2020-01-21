''' <summary>
''' Fenêtre d'édition d'exception du jeu de la vie
''' </summary>
Public Class ExceptionsEdition
    Public estNouveau As Boolean = True
    Public celluleCentrale As Boolean = False

    Private couleurCellule As Color = Color.Black
    Private couleurVide As Color = Color.White

    Public tableCellule(3, 3) As Byte

    Private Sub ExceptionsEdition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If estNouveau Then
            Reset()
        End If

        If celluleCentrale Then
            pbox_centre.BackColor = couleurCellule
        Else
            pbox_centre.BackColor = couleurVide
        End If

        Actualiser()

    End Sub

    Public Sub Reset()
        For x As Integer = 1 To 3
            For y As Integer = 1 To 3
                tableCellule(x, y) = False
            Next
        Next
        Actualiser()
    End Sub

    Public Sub Actualiser()

        If tableCellule(1, 1) Then
            pbox1_1.BackColor = couleurCellule
        Else
            pbox1_1.BackColor = couleurVide
        End If

        If tableCellule(1, 2) Then
            pbox1_2.BackColor = couleurCellule
        Else
            pbox1_2.BackColor = couleurVide
        End If

        If tableCellule(1, 3) Then
            pbox1_3.BackColor = couleurCellule
        Else
            pbox1_3.BackColor = couleurVide
        End If

        If tableCellule(2, 1) Then
            pbox2_1.BackColor = couleurCellule
        Else
            pbox2_1.BackColor = couleurVide
        End If

        If tableCellule(2, 3) Then
            pbox2_3.BackColor = couleurCellule
        Else
            pbox2_3.BackColor = couleurVide
        End If

        If tableCellule(3, 1) Then
            pbox3_1.BackColor = couleurCellule
        Else
            pbox3_1.BackColor = couleurVide
        End If

        If tableCellule(3, 2) Then
            pbox3_2.BackColor = couleurCellule
        Else
            pbox3_2.BackColor = couleurVide
        End If

        If tableCellule(3, 3) Then
            pbox3_3.BackColor = couleurCellule
        Else
            pbox3_3.BackColor = couleurVide
        End If


    End Sub

    Public Sub setCell(ByVal _x As Byte, ByVal _y As Byte)
        If tableCellule(_x, _y) = 0 Then
            tableCellule(_x, _y) = 1
        Else
            tableCellule(_x, _y) = 0
        End If
        Actualiser()
    End Sub

    Private Sub pbox1_1_Click(sender As Object, e As EventArgs) Handles pbox1_1.Click
        setCell(1, 1)
    End Sub

    Private Sub pbox2_1_Click(sender As Object, e As EventArgs) Handles pbox2_1.Click
        setCell(2, 1)
    End Sub

    Private Sub pbox3_1_Click(sender As Object, e As EventArgs) Handles pbox3_1.Click
        setCell(3, 1)
    End Sub

    Private Sub pbox1_2_Click(sender As Object, e As EventArgs) Handles pbox1_2.Click
        setCell(1, 2)
    End Sub

    Private Sub pbox3_2_Click(sender As Object, e As EventArgs) Handles pbox3_2.Click
        setCell(3, 2)
    End Sub

    Private Sub pbox1_3_Click(sender As Object, e As EventArgs) Handles pbox1_3.Click
        setCell(1, 3)
    End Sub

    Private Sub pbox2_3_Click(sender As Object, e As EventArgs) Handles pbox2_3.Click
        setCell(2, 3)
    End Sub

    Private Sub pbox3_3_Click(sender As Object, e As EventArgs) Handles pbox3_3.Click
        setCell(3, 3)
    End Sub

    Private Sub bt_annuler_Click(sender As Object, e As EventArgs) Handles bt_annuler.Click
        Me.Close()
    End Sub

    Private Sub bt_valider_Click(sender As Object, e As EventArgs) Handles bt_valider.Click
        'Modifie l'exception si elle existe
        If Not IsNothing(Exceptions.currentException) Then
            For x As Integer = 1 To 3
                For y As Integer = 1 To 3
                    Exceptions.currentException.tableCellule(x, y) = tableCellule(x, y)
                Next
            Next
        End If
        Me.Close()
    End Sub
End Class