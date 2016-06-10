Imports System.Globalization
Imports Aspose.Note

Namespace Text
    Public Class CreateTitleMsStyle
        Public Shared Sub Run()
            ' ExStart:CreateTitleMsStyle
            Dim dataDir As String = RunExamples.GetDataDir_Text()
            Dim outputPath As String = dataDir & Convert.ToString("CreateTitleMsStyle_out_.one")

            Dim doc = New Document()
            Dim page = New Page(doc)

            page.Title = New Title(doc) With {
                 .TitleText = New RichText(doc) With {
                     .Text = "Title text.",
                     .DefaultStyle = TextStyle.DefaultMsOneNoteTitleTextStyle
                },
                 .TitleDate = New RichText(doc) With {
                     .Text = New DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture),
                     .DefaultStyle = TextStyle.DefaultMsOneNoteTitleDateStyle
                },
                 .TitleTime = New RichText(doc) With {
                     .Text = "12:34",
                     .DefaultStyle = TextStyle.DefaultMsOneNoteTitleTimeStyle
                }
            }

            doc.AppendChild(page)

            doc.Save(outputPath)
            ' ExEnd:CreateTitleMsStyle
            Console.WriteLine(Convert.ToString(vbLf & "Page title setup successfully in microsoft OneNote style ." & vbLf & "File saved at ") & outputPath)
        End Sub
    End Class
End Namespace
