Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Imports System.Globalization
Namespace Loading_Saving
    Public Class CreateDocWithPageTitle
        Public Shared Sub Run()
            ' ExStart:CreateDocWithPageTitle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Create an object of the Document class
            Dim doc As Document = New Aspose.Note.Document()
            ' Initialize Page class object
            Dim page As New Aspose.Note.Page(doc)

            ' Default style for all text in the document.
            Dim textStyle As Aspose.Note.TextStyle = New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            ' Set page title properties
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
            ' Append Page node in the document
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("CreateDocWithPageTitle_out_.one")
            ' Save OneNote document
            doc.Save(dataDir)
            ' ExEnd:CreateDocWithPageTitle

            Console.WriteLine(Convert.ToString(vbLf & "OneNote document created successfully with page title." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace