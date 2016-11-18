Imports System.IO
Imports  Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing

Namespace Images
    Public Class InsertImage
        Public Shared Sub Run()
            ' ExStart:InsertImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images()

            ' Load document from the stream.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))
            ' Get the first page of the document.
            Dim page As Page = doc.FirstChild

            ' Load an image from the file.
            Dim image As New Image(doc, dataDir & Convert.ToString("image.jpg"))
            ' Change the image's size according to your needs (optional).
            image.Width = 100
            image.Height = 100
            ' Set the image's location in the page (optional).
            image.VerticalOffset = 400
            image.HorizontalOffset = 100
            ' Set image alignment
            image.Alignment = HorizontalAlignment.Right
            ' Add the image to the page.
            page.AppendChild(image)
            ' ExEnd:InsertImage 
            Console.WriteLine(vbLf & "Image inserted successfully to OneNote document.")
        End Sub
    End Class
End Namespace
