Imports System.IO
Imports  Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Images
    Public Class BuildDocAndInsertImage
        Public Shared Sub Run()
            ' ExStart:BuildDocAndInsertImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Page(doc)
            ' Initialize Outline class object and set offset properties
            Dim outline As New Outline(doc) With {
                 .VerticalOffset = 0,
                 .HorizontalOffset = 0
            }
            ' Initialize OutlineElement class object
            Dim outlineElem As New OutlineElement(doc)
            ' Load an image by the file path.
            Dim image As New Image(doc, dataDir & Convert.ToString("image.jpg"))
            ' Set image alignment
            image.Alignment = HorizontalAlignment.Right
            ' Add image
            outlineElem.AppendChild(image)
            ' Add outline elements
            Outline.AppendChild(outlineElem)
            ' Add Outline node
            page.AppendChild(Outline)
            ' Add Page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("BuildDocAndInsertImage_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:BuildDocAndInsertImage 
            Console.WriteLine(Convert.ToString(vbLf & "Document created and image inserted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace