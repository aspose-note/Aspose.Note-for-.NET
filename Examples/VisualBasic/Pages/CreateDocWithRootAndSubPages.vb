Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Pages
    Public Class CreateDocWithRootAndSubPages
        Public Shared Sub Run()
            ' ExStart:CreateDocWithRootAndSubPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object and set its level
            Dim page1 As New Aspose.Note.Page(doc) With {
                 .Level = 1
            }
            ' Initialize Page class object and set its level
            Dim page2 As New Aspose.Note.Page(doc) With {
                 .Level = 2
            }
            ' Initialize Page class object and set its level
            Dim page3 As New Aspose.Note.Page(doc) With {
                 .Level = 1
            }

            '---------- Adding nodes to first Page ----------

            Dim outline As New Outline(doc)
            Dim outlineElem As New OutlineElement(doc)
            Dim textStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            Dim text As New RichText(doc) With {
                 .Text = "First page.",
                 .DefaultStyle = textStyle
            }
            outlineElem.AppendChild(text)
            outline.AppendChild(outlineElem)
            page1.AppendChild(outline)

            '---------- Adding nodes to second Page ----------

            Dim outline2 = New Outline(doc)
            Dim outlineElem2 = New OutlineElement(doc)
            Dim textStyle2 = New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            Dim text2 = New RichText(doc) With {
                 .Text = "Second page.",
                 .DefaultStyle = textStyle2
            }
            outlineElem2.AppendChild(text2)
            outline2.AppendChild(outlineElem2)
            page2.AppendChild(outline2)

            '---------- Adding nodes to third Page ----------

            Dim outline3 = New Outline(doc)
            Dim outlineElem3 = New OutlineElement(doc)
            Dim textStyle3 = New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            Dim text3 = New RichText(doc) With {
                 .Text = "Third page.",
                 .DefaultStyle = textStyle3
            }
            outlineElem3.AppendChild(text3)
            outline3.AppendChild(outlineElem3)
            page3.AppendChild(outline3)

            '---------- Add pages to the OneNote Document ----------

            doc.AppendChild(page1)
            doc.AppendChild(page2)
            doc.AppendChild(page3)

            dataDir = dataDir & Convert.ToString("CreateDocWithRootAndSubPages_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:CreateDocWithRootAndSubPages
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document created successfully with root and sub level pages." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
