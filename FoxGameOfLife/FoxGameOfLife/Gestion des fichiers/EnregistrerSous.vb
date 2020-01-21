Imports System.IO
Public Class EnregistrerSous
    Private Sub EnregistrerSous_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub EnregistrerSous(ByVal _path As String)
        ' Dim MemoryStream As MemoryStream
        ' Dim BinaryWriter As BinaryWriter
        Dim byteBuffer As New List(Of Byte)

        ' Entête du fichier ("ZLIF")
        byteBuffer.Add(22)
        byteBuffer.Add(22)
        byteBuffer.Add(22)
        byteBuffer.Add(22)
        ' Dimension du plateau
        ' Largeur
        byteBuffer.Add(IIf(Main.Engine.TaillePlateau.Width > 255, 255, Main.Engine.TaillePlateau.Width))
        byteBuffer.Add(IIf(Main.Engine.TaillePlateau.Width > 255, Main.Engine.TaillePlateau.Width - 255, 0))
        ' Hauteur
        byteBuffer.Add(IIf(Main.Engine.TaillePlateau.Height > 255, 255, Main.Engine.TaillePlateau.Height))
        byteBuffer.Add(IIf(Main.Engine.TaillePlateau.Height > 255, Main.Engine.TaillePlateau.Height - 255, 0))

        ' Les valeurs des cases du plateau
        For x As Integer = 1 To Main.Engine.TaillePlateau.Width
            For y As Integer = 1 To Main.Engine.TaillePlateau.Height
                byteBuffer.Add(Main.Engine.GetCellValue(x, y))
            Next
        Next
    End Sub

End Class