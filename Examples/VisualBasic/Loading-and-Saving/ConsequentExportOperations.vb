Imports System.IO
Imports  Aspose.Note
Imports System.Drawing
Imports System.Globalization
Namespace Loading_Saving
    Public Class ConsequentExportOperations
        Public Shared Sub Run()
            ' ExStart:ConsequentExportOperations
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Initialize the new Document
            Dim doc As New Document() With {.AutomaticLayoutChangesDetectionEnabled = False}
            ' Initialize the new Page
            Dim page As New Page(doc)
            ' Default style for all text in the document.
            Dim textStyle As New TextStyle() With {.FontColor = System.Drawing.Color.Black, .FontName = "Arial", .FontSize = 10}
            page.Title = New Title(doc) With
            {
                .TitleText = New RichText(doc) With {.Text = "Title text.", .DefaultStyle = textStyle},
                .TitleDate = New RichText(doc) With {.Text = New DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), .DefaultStyle = textStyle},
                .TitleTime = New RichText(doc) With {.Text = "12:34", .DefaultStyle = textStyle}
            }
            ' Append page node
            doc.AppendChild(page)
            ' Save OneNote document in different formats, set text font size and detect layout changes manually.
            doc.Save(dataDir & "ConsequentExportOperations_out_.html")
            doc.Save(dataDir & "ConsequentExportOperations_out_.pdf")
            doc.Save(dataDir & "ConsequentExportOperations_out_.jpg")
            textStyle.FontSize = 11
            doc.DetectLayoutChanges()
            doc.Save(dataDir & "ConsequentExportOperations_out_.bmp")
            ' ExEnd:ConsequentExportOperations
            Console.WriteLine(vbLf & "Consequent export operations performed successfully.")
        End Sub
    End Class
End Namespace