Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Namespace Loading_Saving
    Public Class PageSplittUsingKeepSOlidObjectsAlgoirthm
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))
            ' ExStart:KeepSOlidObjectsAlgoirthm-1
            Dim pdfSaveOptions = New PdfSaveOptions()
            pdfSaveOptions.PageSplittingAlgorithm = New AlwaysSplitObjectsAlgorithm()
            ' Or
            pdfSaveOptions.PageSplittingAlgorithm = New KeepPartAndCloneSolidObjectToNextPageAlgorithm()
            ' Or
            pdfSaveOptions.PageSplittingAlgorithm = New KeepSolidObjectsAlgorithm()
            ' ExEnd:KeepSOlidObjectsAlgoirthm-1

            ' ExStart:KeepSOlidObjectsAlgoirthm-2
            Dim heightLimitOfClonedPart As Single = 500
            pdfSaveOptions.PageSplittingAlgorithm = New KeepPartAndCloneSolidObjectToNextPageAlgorithm(heightLimitOfClonedPart)
            ' Or
            pdfSaveOptions.PageSplittingAlgorithm = New KeepSolidObjectsAlgorithm(heightLimitOfClonedPart)
            ' ExEnd:KeepSOlidObjectsAlgoirthm-2

            ' ExStart:KeepSOlidObjectsAlgoirthm-3
            pdfSaveOptions.PageSplittingAlgorithm = New KeepSolidObjectsAlgorithm(100)
            ' ExEnd:KeepSOlidObjectsAlgoirthm-3
            ' Or
            ' ExStart:KeepSOlidObjectsAlgoirthm-4
            pdfSaveOptions.PageSplittingAlgorithm = New KeepSolidObjectsAlgorithm(400)
            ' ExEnd:KeepSOlidObjectsAlgoirthm-4

            dataDir = dataDir & Convert.ToString("UsingKeepSOlidObjectsAlgoirthm_out_.pdf")
            doc.Save(dataDir)
            Console.WriteLine(vbLf & "Page splitt successfully using keep solid objects algoirthm method.")
        End Sub
    End Class
End Namespace