Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Drawing
Namespace Loading_Saving
    Public Class CreateDocWithSimpleRichText
        Public Shared Sub Run()
            ' ExStart:CreateDocWithSimpleRichText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Create an object of the Document class
            Dim doc As New AsposeNote.Document()
            ' Initialize Page class object
            Dim page As New AsposeNote.Page(doc)
            ' Initialize Outline class object
            Dim outline As New Outline(doc)
            ' Initialize OutlineElement class object
            Dim outlineElem As New OutlineElement(doc)

            ' Initialize TextStyle class object and set formatting properties
            Dim textStyle As New TextStyle() With {.FontColor = Color.Black, .FontName = "Arial", .FontSize = 10}
            ' Initialize RichText class object and apply text style
            Dim text As New RichText(doc) With {.Text = "Hello OneNote text!", .DefaultStyle = textStyle}

            ' Add RichText node
            outlineElem.AppendChild(text)
            ' Add OutlineElement node
            outline.AppendChild(outlineElem)
            ' Add Outline node
            page.AppendChild(outline)
            ' Add Page node
            doc.AppendChild(page)

            dataDir = dataDir + "CreateDocWithSimpleRichText_out_.one"
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:CreateDocWithSimpleRichText
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document created successfully with simple rich text." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
