Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Images
    Public Class BuildDocAndInsertImageUsingImageStream
        Public Shared Sub Run()
            ' ExStart:BuildDocAndInsertImageUsingImageStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Aspose.Note.Page(doc)

            Dim outline1 As New Outline(doc) With {
                 .VerticalOffset = 600,
                 .HorizontalOffset = 0
            }
            Dim outlineElem1 As New OutlineElement(doc)
            Dim fs As FileStream = File.OpenRead(dataDir & Convert.ToString("image.jpg"))
            ' Load the second image using the image name, extension and stream.
            Dim image1 As New Aspose.Note.Image(doc, "Penguins", "jpg", fs)
            ' Set image alignment
            image1.Alignment = HorizontalAlignment.Right

            outlineElem1.AppendChild(image1)
            outline1.AppendChild(outlineElem1)
            page.AppendChild(outline1)

            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("BuildDocAndInsertImageUsingImageStream_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:BuildDocAndInsertImageUsingImageStream 
            Console.WriteLine(Convert.ToString(vbLf & "Document created and image using image stream inserted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace