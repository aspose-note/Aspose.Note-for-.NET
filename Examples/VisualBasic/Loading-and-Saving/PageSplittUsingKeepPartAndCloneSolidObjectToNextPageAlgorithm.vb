Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving

Namespace Loading_Saving
    Public Class PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))

            Dim pdfSaveOptions = New PdfSaveOptions()

            ' ExStart:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-1
            pdfSaveOptions.PageSplittingAlgorithm = New KeepPartAndCloneSolidObjectToNextPageAlgorithm(100)
            ' ExEnd:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-1
            ' Or
            ' ExStart:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-2
            pdfSaveOptions.PageSplittingAlgorithm = New KeepPartAndCloneSolidObjectToNextPageAlgorithm(400)
            ' ExEnd:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-2

            dataDir = dataDir & Convert.ToString("PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm_out.pdf")
            doc.Save(dataDir)
            Console.WriteLine(vbLf & "Page splitt successfully using keep part and clone solid object to next page algorithm.")
        End Sub
    End Class
End Namespace