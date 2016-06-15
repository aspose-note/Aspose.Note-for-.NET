Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Images
    Public Class ImageAlternativeText
        Public Shared Sub Run()
            ' ExStart:ImageAlternativeText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images()

            Dim document = New Document()
            Dim page = New Page(document)
            Dim image = New AsposeNote.Image(document, dataDir & Convert.ToString("image.jpg"))
            image.AlternativeText = "ImageAlternativeText"
            page.AppendChild(image)
            document.AppendChild(page)

            dataDir = dataDir & Convert.ToString("ImageAlternativeText_out_.one")
            document.Save(dataDir)
            ' ExEnd:ImageAlternativeText 
            Console.WriteLine(Convert.ToString(vbLf & "Image alternative text setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace