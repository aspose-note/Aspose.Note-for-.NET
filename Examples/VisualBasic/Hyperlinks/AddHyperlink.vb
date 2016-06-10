Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Hyperlinks
    Public Class AddHyperlink
        Public Shared Sub Run()
            ' ExStart:AddHyperlink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tasks()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Aspose.Note.Page(doc)
            ' Initialize Title class object
            Dim title As New Title(doc)

            Dim defaultTextStyle As New TextStyle() With {
                 .FontName = "Arial",
                 .FontSize = 10,
                 .FontColor = SystemColors.WindowText
            }
            Dim titleText As New RichText(doc) With {
                 .Text = "Title!",
                 .DefaultStyle = defaultTextStyle
            }
            Dim outline As New Outline(doc) With {
                 .MaxWidth = 200,
                 .MaxHeight = 200,
                 .VerticalOffset = 100,
                 .HorizontalOffset = 100
            }
            Dim outlineElem As New OutlineElement(doc)
            'this style will be applied to 0-7 characters.
            Dim textStyleRed As New TextStyle() With {
                 .FontColor = Color.Red,
                 .FontName = "Arial",
                 .FontSize = 10,
                 .RunIndex = 8
            }
            'this style will be applied to 8-16 characters.
            Dim textStyleHyperlink As New TextStyle() With {
                 .RunIndex = 17,
                 .IsHyperlink = True,
                 .HyperlinkAddress = "www.google.com"
            }
            Dim text As New RichText(doc) With {
                 .Text = "This is hyperlink. This text is not a hyperlink.",
                 .DefaultStyle = defaultTextStyle
            }

            title.TitleText = titleText
            page.Title = title
            outlineElem.AppendChild(Text)
            ' Add outline elements
            Outline.AppendChild(outlineElem)
            ' Add Outline node
            page.AppendChild(Outline)
            ' Add Page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("AddHyperlink_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:AddHyperlink
            Console.WriteLine(Convert.ToString(vbLf & "Hyperlink added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace