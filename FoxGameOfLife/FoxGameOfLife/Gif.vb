Imports System.IO

Module Gif

    Public Sub CreerGif(ByVal _liste_image As List(Of String), ByVal _chemin As String, ByVal _largeurPX As Integer, ByVal _hauteurPx As Integer)
        'https://www.rickvandenbosch.net/blog/howto-create-an-animated-gif-using-net-c/
        ' Dim StringCollection As Specialized.StringCollection
        Dim MemoryStream As MemoryStream
        Dim BinaryWriter As BinaryWriter
        Dim Img As Bitmap
        Dim buf1() As Byte
        Dim buf2(18) As Byte
        Dim buf3(7) As Byte

        MemoryStream = New MemoryStream()
        'Nom de l'extension
        buf2(0) = 71 'G
        buf2(1) = 73 'I
        buf2(2) = 70 'F
        buf2(3) = 56 '8
        buf2(4) = 57 '9
        buf2(5) = 97 'a

        'Définiton de la largeur de l'image
        buf2(6) = IIf(_largeurPX > 255, 255, _largeurPX)
        buf2(7) = IIf(_largeurPX > 255, _largeurPX - 255, 0)

        'Définition de la hauteur de l'image
        buf2(8) = IIf(_hauteurPx > 255, 255, _hauteurPx)
        buf2(9) = IIf(_hauteurPx > 255, _hauteurPx - 255, 0)


        buf2(10) = 239 ' Paramètres
        buf2(11) = 0 'Couleur de fond (index)
        buf2(12) = 1 ' Ratio de l'aspect des pixels
        buf2(13) = 255 '
        buf2(14) = 255
        buf2(15) = 255
        buf2(16) = 59 ' Trailer

        'Image block
        buf3(0) = 44 ' Séparateur d'image
        buf3(1) = 0  ' Position gauche de l'image octet 1
        buf3(2) = 0  ' Position gauche de l'image octet 2
        buf3(3) = 0  ' Position hauteur de l'image octet 1
        buf3(4) = 0  ' Position hauteur de l'image octet 2
        buf3(5) = 0  ' Largeur de l'image octet 1
        buf3(6) = 0  ' Largeur de l'image octet 2
        buf3(7) = 0  ' Hauteur de l'image octet 1
        buf3(8) = 0  ' Hauteur de l'image octet 2
        buf3(9) = 1  ' Paramètres LCTF
        buf3(10) = 255
        buf3(11) = 255
        buf3(12) = 255
        buf3(13) = 1
        ' buf3()

        'Flux de sortie
        Dim fs As Stream = New FileStream(_chemin, FileMode.Create)
        BinaryWriter = New BinaryWriter(fs)

        For compteurImage As Integer = 0 To _liste_image.Count - 1

            Img = New Bitmap(Main.SafeImageFromFile(_liste_image(compteurImage)))

            Img.Save(MemoryStream, Imaging.ImageFormat.Gif)

            buf1 = MemoryStream.ToArray()

            Img.Dispose()


            'On écrit l'entête en premier et une seule fois
            If compteurImage = 0 Then
                BinaryWriter.Write(buf1, 0, 781)
                BinaryWriter.Write(buf2, 0, 18)
            End If

            BinaryWriter.Write(buf3, 0, 7)
            BinaryWriter.Write(buf1, 789, buf1.Length - 790)

            'On écrit le terminateur d'image à la fin
            If compteurImage = _liste_image.Count - 1 Then
                BinaryWriter.Write(";")
            End If

            MemoryStream.SetLength(0)

        Next
        BinaryWriter.Close()
        MemoryStream.Close()
    End Sub

    Public Function dec2bin(nombre As Long) As Long
        Dim i = 0 : dec2bin = 0
        Do While (nombre / 2 > 0)
            dec2bin = dec2bin + (nombre Mod 2) * (10 ^ i)
            nombre = Int(nombre / 2)
            i = i + 1
        Loop
    End Function

    Public Function bin2dec(nombre As Long) As Long
        Dim i = 0 : bin2dec = 0
        Do While (nombre >= 1)
            bin2dec = bin2dec + (nombre Mod 10) * (2 ^ i)
            nombre = Int(nombre / 10)
            i = i + 1
        Loop
    End Function

End Module
