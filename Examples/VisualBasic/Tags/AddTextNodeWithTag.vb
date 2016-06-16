Imports System.Drawing
Imports System.IO
Imports  Aspose.Note
Imports System.Collections.Generic

Namespace Tags
    Public Class AddTextNodeWithTag
        Public Shared Sub Run()
            ' ExStart:AddTextNodeWithTag
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tags()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Page(doc)
            ' Initialize Outline class object
            Dim outline As New Outline(doc)
            ' Initialize OutlineElement class object
            Dim outlineElem As New OutlineElement(doc)
            Dim textStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            Dim text As New RichText(doc) With {
                 .Text = "OneNote text.",
                 .DefaultStyle = textStyle
            }
            text.Tags.Add(New NoteTag() With {
                 .Icon = TagIcon.YellowStar
            })

            ' Add text node
            outlineElem.AppendChild(text)
            ' Add outline element node
            outline.AppendChild(outlineElem)
            ' Add outline node
            page.AppendChild(outline)
            ' Add page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("AddTextNodeWithTag_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:AddTextNodeWithTag
            Console.WriteLine(Convert.ToString(vbLf & "Text node with tag added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace