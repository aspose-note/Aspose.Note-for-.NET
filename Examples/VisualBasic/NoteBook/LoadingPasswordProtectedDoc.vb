Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Imports System.Globalization

Namespace WorkingWithNoteBook
    Public Class LoadingPasswordProtectedDoc
        Public Shared Sub Run()
            ' ExStart:LoadingPasswordProtectedDoc
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()
            Dim notebook = New Notebook(dataDir & Convert.ToString("test.onetoc2"), New NotebookLoadOptions() With {
                 .DeferredLoading = True
            })

            notebook.LoadChildDocument(dataDir & Convert.ToString("Aspose.one"))
            notebook.LoadChildDocument(dataDir & Convert.ToString("Locked Pass1.one"), New LoadOptions() With {
                 .DocumentPassword = "pass"
            })
            notebook.LoadChildDocument(dataDir & Convert.ToString("Locked Pass2.one"), New LoadOptions() With {
                 .DocumentPassword = "pass2"
            })
            ' ExEnd:LoadingPasswordProtectedDoc       
        End Sub
    End Class
End Namespace

