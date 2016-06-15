Imports System.Drawing
Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Collections.Generic

Namespace Tags
    Public Class AddImageNodeWithTag
        Public Shared Sub Run()
            ' ExStart:AddImageNodeWithTag
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tags()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New AsposeNote.Page(doc)
            ' Initialize Outline class object
            Dim outline As New Outline(doc)
            ' Initialize OutlineElement class object
            Dim outlineElem As New OutlineElement(doc)
            ' Load an image
            Dim image As New AsposeNote.Image(doc, dataDir & Convert.ToString("icon.jpg"))
            ' Insert image in the document node
            outlineElem.AppendChild(image)
            image.Tags.Add(New NoteTag() With {
                 .Icon = TagIcon.YellowStar
            })
            ' Add outline element node
            outline.AppendChild(outlineElem)
            ' Add outline node
            page.AppendChild(outline)
            ' Add page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("AddImageNodeWithTag_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:AddImageNodeWithTag
            Console.WriteLine(Convert.ToString(vbLf & "Image node with tag added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace