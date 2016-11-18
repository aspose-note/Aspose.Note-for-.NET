Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving

Namespace Loading_Saving
    Public Class SaveRangeOfPagesAsPDF
        Public Shared Sub Run()
            ' ExStart:SaveRangeOfPagesAsPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' ExStart:LoadOneNote
            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))
            ' ExEnd:LoadOneNote

            ' Initialize PdfSaveOptions object
            Dim opts As New PdfSaveOptions()

            ' Set page index
            opts.PageIndex = 0

            ' Set page count
            opts.PageCount = 1

            dataDir = dataDir & Convert.ToString("SaveRangeOfPagesAsPDF_out.pdf")

            ' Save the document as PDF
            oneFile.Save(dataDir, opts)
            ' ExEnd:SaveRangeOfPagesAsPDF
            Console.WriteLine(Convert.ToString(vbLf & "OneNote specified page range converted successfully to PDF." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace