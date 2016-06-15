Imports System.IO
Imports AsposeNote = Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Namespace Loading_Saving
    Public Class CreateDocWithFormattedRichText
        Public Shared Sub Run()
            ' ExStart:CreateDocWithFormattedRichText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New AsposeNote.Page(doc)
            ' Initialize Title class object
            Dim title As New Title(doc)
            ' Initialize TextStyle class object and set formatting properties
            Dim defaultTextStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }

            Dim titleText As New RichText(doc) With {
                 .Text = "Title!",
                 .DefaultStyle = defaultTextStyle
            }
            Dim outline As New Outline(doc) With {
                 .VerticalOffset = 100,
                 .HorizontalOffset = 100
            }
            Dim outlineElem As New OutlineElement(doc)
            ' RunIndex = 5 means the style will be applied only to 0-4 characters. ("Hello")
            Dim textStyleForHelloWord As New TextStyle() With {
                 .FontColor = Color.Red,
                 .FontName = "Arial",
                 .FontSize = 10,
                 .RunIndex = 5
            }
            ' RunIndex = 13 means the style will be applied only to 5-12 characters. (" OneNote")
            Dim textStyleForOneNoteWord As New TextStyle() With {
                 .FontColor = Color.Green,
                 .FontName = "Calibri",
                 .FontSize = 10,
                 .IsItalic = True,
                 .RunIndex = 13
            }
            ' RunIndex = 18 means the style will be applied only to 13-17 characters. (" text").
            ' Other characters ("!") will have the default style.
            Dim textStyleForTextWord As New TextStyle() With {
                 .FontColor = Color.Blue,
                 .FontName = "Arial",
                 .FontSize = 15,
                 .IsBold = True,
                 .IsItalic = True,
                 .RunIndex = 18
            }
            Dim text As New RichText(doc) With {
                 .Text = "Hello OneNote text!",
                 .DefaultStyle = defaultTextStyle
            }

            title.TitleText = titleText
            ' Set page title
            page.Title = title
            ' Add RichText node
            outlineElem.AppendChild(Text)
            ' Add OutlineElement node
            Outline.AppendChild(outlineElem)
            ' Add Outline node
            page.AppendChild(Outline)
            ' Add Page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("CreateDocWithFormattedRichText_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:CreateDocWithFormattedRichText

            Console.WriteLine(Convert.ToString(vbLf & "OneNote document created successfully with formatted rich text." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace