Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Collections.Generic

Namespace WorkingWithNoteBook
    Public Class ConvertToPDFAsFlattened
        Public Shared Sub Run()
            ' ExStart:ConvertToPDFAsFlattened
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            ' Load a OneNote Notebook
            Dim notebook = New Notebook(dataDir & Convert.ToString("Notizbuch öffnen.onetoc2"))

            dataDir = dataDir & Convert.ToString("ConvertToPDFAsFlattened_out_.pdf")
            ' Save the Notebook
            notebook.Save(dataDir, New NotebookPdfSaveOptions() With {
                 .Flatten = True
            })

            ' ExEnd:ConvertToPDFAsFlattened
            Console.WriteLine(Convert.ToString(vbLf & "NoteBook document converted to pdf as flattened successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace