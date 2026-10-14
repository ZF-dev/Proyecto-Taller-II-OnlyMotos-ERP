Imports System.IO
Imports PdfSharp.Fonts

Public Class FileFontResolver 'totalmente hecho con la IA ya estoy quemado y este tema no me parece importante aprenderlo a fondo

    Implements IFontResolver

    Public Function ResolveTypeface(familyName As String, isBold As Boolean, isItalic As Boolean) As FontResolverInfo Implements IFontResolver.ResolveTypeface

        Return New FontResolverInfo(familyName)

    End Function

    Public Function GetFont(faceName As String) As Byte() Implements IFontResolver.GetFont

        Dim fontFileName As String = "verdana.ttf"

        If faceName.ToLower().Contains("arial") Then
            fontFileName = "arial.ttf"
        End If

        Dim fontPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), fontFileName)

        If Not File.Exists(fontPath) Then
            fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "verdana.ttf")
        End If

        If File.Exists(fontPath) Then
            Return File.ReadAllBytes(fontPath)
        End If

        Throw New FileNotFoundException($"No se pudo encontrar el archivo de fuente para: {faceName}")

    End Function

End Class