Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Collections.Generic

Namespace WorkingWithNoteBook
    Public Class ConvertToImageWithOptions
        Public Shared Sub Run()
            ' ExStart:ConvertToImageWithOptions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            ' Load a OneNote Notebook
            Dim notebook = New Notebook(dataDir & Convert.ToString("Notizbuch öffnen.onetoc2"))

            Dim notebookSaveOptions = New NotebookImageSaveOptions(SaveFormat.Png)

            Dim documentSaveOptions = notebookSaveOptions.DocumentSaveOptions

            documentSaveOptions.Resolution = 400

            dataDir = dataDir & Convert.ToString("ConvertToImageWithOptions_out.png")

            ' Save the Notebook
            notebook.Save(dataDir, notebookSaveOptions)

            ' ExEnd:ConvertToImageWithOptions
            Console.WriteLine(Convert.ToString(vbLf & "NoteBook document converted to image with options successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace