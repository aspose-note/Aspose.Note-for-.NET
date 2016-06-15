Imports System.Globalization
Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Drawing
Imports System.Collections.Generic
Namespace Text
    Public Class ApplyNumberingOnText
        Public Shared Sub Run()
            ' ExStart:ApplyNumberingOnText
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Create an object of the Document class
            Dim doc As New Document()

            ' Initialize Page class object
            Dim page As New AsposeNote.Page(doc)

            ' Initialize Outline class object
            Dim outline As New Outline(doc)

            ' Initialize TextStyle class object and set formatting properties
            Dim defaultStyle As New TextStyle() With {
                .FontColor = Color.Black,
                .FontName = "Arial",
                .FontSize = 10
            }

            ' Initialize OutlineElement class objects and apply numbering
            ' Numbers in the same outline are automatically incremented.
            Dim outlineElem1 As New OutlineElement(doc) With {
                .NumberList = New NumberList("{0})", NumberFormat.DecimalNumbers, "Arial", 10)
            }
            Dim text1 As New RichText(doc) With {
                .Text = "First",
                .DefaultStyle = defaultStyle
            }
            outlineElem1.AppendChild(text1)

            Dim outlineElem2 As New OutlineElement(doc) With {
                .NumberList = New NumberList("{0})", NumberFormat.DecimalNumbers, "Arial", 10)
            }
            Dim text2 As New RichText(doc) With {
                .Text = "Second",
                .DefaultStyle = defaultStyle
            }
            outlineElem2.AppendChild(text2)

            Dim outlineElem3 As New OutlineElement(doc) With {
                .NumberList = New NumberList("{0})", NumberFormat.DecimalNumbers, "Arial", 10)
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

            dataDir = dataDir & Convert.ToString("ApplyNumberingOnText_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:ApplyNumberingOnText
            Console.WriteLine(Convert.ToString(vbLf & "Numbering applied successfully on a text." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
