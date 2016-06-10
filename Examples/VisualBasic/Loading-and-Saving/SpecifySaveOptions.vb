Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Namespace Loading_Saving
    Public Class SpecifySaveOptions
        Public Shared Sub Run()
            ' ExStart:SpecifySaveOptions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Initialize PdfSaveOptions object
            Dim opts As New PdfSaveOptions()
            ' Set page index
            opts.PageIndex = 2
            ' Set page count
            opts.PageCount = 3

            dataDir = dataDir & Convert.ToString("Document.SaveWithOptions_out_.pdf")
            doc.Save(dataDir, opts)
            ' ExEnd:SpecifySaveOptions
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document saved successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace