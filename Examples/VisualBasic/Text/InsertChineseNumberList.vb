Imports System.Globalization
Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Drawing
Imports System.Collections.Generic
Namespace Text
    Public Class InsertChineseNumberList
        Public Shared Sub Run()
            ' ExStart:InsertChineseNumberList
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Initialize OneNote document
            Dim doc As New AsposeNote.Document()
            ' Initialize OneNote page
            Dim page As New AsposeNote.Page(doc)
            Dim outline As New Outline(doc)
            ' Apply text style settings
            Dim defaultStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }

            ' Numbers in the same outline are automatically incremented.
            Dim outlineElem1 As New OutlineElement(doc) With {
                 .NumberList = New NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10)
            }
            Dim text1 As New RichText(doc) With {
                 .Text = "First",
                 .DefaultStyle = defaultStyle
            }
            outlineElem1.AppendChild(text1)
            '------------------------
            Dim outlineElem2 As New OutlineElement(doc) With {
                 .NumberList = New NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10)
            }
            Dim text2 As New RichText(doc) With {
                 .Text = "Second",
                 .DefaultStyle = defaultStyle
            }
            outlineElem2.AppendChild(text2)
            '------------------------
            Dim outlineElem3 As New OutlineElement(doc) With {
                 .NumberList = New NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10)
            }
            Dim text3 As New RichText(doc) With {
                 .Text = "Third",
                 .DefaultStyle = defaultStyle
            }
            outlineElem3.AppendChild(text3)
            '------------------------
            outline.AppendChild(outlineElem1)
            outline.AppendChild(outlineElem2)
            outline.AppendChild(outlineElem3)
            page.AppendChild(outline)
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("InsertChineseNumberList_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:InsertChineseNumberList
            Console.WriteLine(Convert.ToString(vbLf & "Chinese number list inserted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace