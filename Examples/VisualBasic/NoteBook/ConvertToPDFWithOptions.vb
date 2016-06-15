Imports System.IO
Imports AsposeNote = Aspose.Note
Imports Aspose.Note.Saving
Imports System.Collections.Generic

Namespace NoteBook
    Public Class ConvertToPDFWithOptions
        Public Shared Sub Run()
            ' ExStart:ConvertToPDFWithOptions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            ' Load a OneNote Notebook
            Dim notebook = New AsposeNote.Notebook(dataDir & Convert.ToString("Notizbuch öffnen.onetoc2"))

            Dim notebookSaveOptions = New NotebookPdfSaveOptions()

            Dim documentSaveOptions = notebookSaveOptions.DocumentSaveOptions

            documentSaveOptions.PageSplittingAlgorithm = New KeepSolidObjectsAlgorithm()

            dataDir = dataDir & Convert.ToString("ConvertToPDF_out_.pdf")

            ' Save the Notebook
            notebook.Save(dataDir, notebookSaveOptions)

            ' ExEnd:ConvertToPDFWithOptions
            Console.WriteLine(Convert.ToString(vbLf & "NoteBook document converted to pdf successfully with save options." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
