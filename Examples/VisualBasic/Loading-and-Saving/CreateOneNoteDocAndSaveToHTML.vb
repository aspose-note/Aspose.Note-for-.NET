Imports System.IO
Imports Aspose.Note
Imports System.Drawing
Imports System.Globalization
Imports Aspose.Note.Saving
Namespace Loading_Saving
    Public Class CreateOneNoteDocAndSaveToHTML
        Public Shared Sub Run()
            ' ExStart:CreateOneNoteDocAndSaveToHTML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Initialize OneNote document
            Dim doc As New Document()
            Dim page As New Aspose.Note.Page(doc)

            ' Default style for all text in the document.
            Dim textStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            page.Title = New Title(doc) With {
                 .TitleText = New RichText(doc) With {
                     .Text = "Title text.",
                     .DefaultStyle = textStyle
                },
                 .TitleDate = New RichText(doc) With {
                     .Text = New DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture),
                     .DefaultStyle = textStyle
                },
                 .TitleTime = New RichText(doc) With {
                     .Text = "12:34",
                     .DefaultStyle = textStyle
                }
            }
            doc.AppendChild(page)
            dataDir = dataDir & Convert.ToString("CreateOneNoteDocAndSaveToHTML_out_.html")
            ' Save as HTML format
            doc.Save(dataDir)
            ' ExEnd:CreateOneNoteDocAndSaveToHTML
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub CreateAndSavePageRange()
            ' ExStart:CreateAndSavePageRange
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Initialize OneNote document
            Dim doc As New Document()

            Dim page As New Aspose.Note.Page(doc)
            ' Default style for all text in the document.
            Dim textStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            page.Title = New Title(doc) With {
                 .TitleText = New RichText(doc) With {
                     .Text = "Title text.",
                     .DefaultStyle = textStyle
                },
                 .TitleDate = New RichText(doc) With {
                     .Text = New DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture),
                     .DefaultStyle = textStyle
                },
                 .TitleTime = New RichText(doc) With {
                     .Text = "12:34",
                     .DefaultStyle = textStyle
                }
            }
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("CreateAndSavePageRange_out_.html")
            ' Save as HTML format
            doc.Save(dataDir, New HtmlSaveOptions() With {
                 .PageCount = 1,
                 .PageIndex = 0
            })
            ' ExEnd:CreateAndSavePageRange
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document created successfully and saved as page range." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
