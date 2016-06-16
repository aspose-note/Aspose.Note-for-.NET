Imports System.Globalization
Imports System.IO
Imports  Aspose.Note
Imports System.Drawing
Imports System.Collections.Generic
Namespace Text
    Public Class ApplyBulletsOnText
        Public Shared Sub Run()
            ' ExStart:ApplyBulletsOnText
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Page(doc)
            ' Initialize Outline class object
            Dim outline As New Outline(doc)
            ' Initialize TextStyle class object and set formatting properties
            Dim defaultStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }

            ' Initialize OutlineElement class objects and apply bullets
            Dim outlineElem1 As New OutlineElement(doc) With {
                 .NumberList = New NumberList("*", "Arial", 10)
            }
            ' Initialize RichText class object and apply text style
            Dim text1 As New RichText(doc) With {
                 .Text = "First",
                 .DefaultStyle = defaultStyle
            }
            outlineElem1.AppendChild(text1)

            Dim outlineElem2 As New OutlineElement(doc) With {
                 .NumberList = New NumberList("*", "Arial", 10)
            }
            Dim text2 As New RichText(doc) With {
                 .Text = "Second",
                 .DefaultStyle = defaultStyle
            }
            outlineElem2.AppendChild(text2)

            Dim outlineElem3 As New OutlineElement(doc) With {
                 .NumberList = New NumberList("*", "Arial", 10)
            }
            Dim text3 As New RichText(doc) With {
                 .Text = "Third",
                 .DefaultStyle = defaultStyle
            }
            outlineElem3.AppendChild(text3)

            ' Add outline elements
            outline.AppendChild(outlineElem1)
            outline.AppendChild(outlineElem2)
            outline.AppendChild(outlineElem3)

            ' Add Outline node
            page.AppendChild(outline)
            ' Add Page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("ApplyBulletsOnText_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:ApplyBulletsOnText
            Console.WriteLine(Convert.ToString(vbLf & "Bullets applied successfully on a text." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
