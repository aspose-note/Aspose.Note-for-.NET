Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Imports System.Globalization

Namespace WorkingWithNoteBook
    Public Class WritingPasswordProtectedDoc
        Public Shared Sub Run()
            ' ExStart:WritingPasswordProtectedDoc
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            Dim notebook = New Notebook(dataDir & Convert.ToString("notebook2.onetoc2"), New NotebookLoadOptions() With {
                 .DeferredLoading = False
            })

            notebook.Save(dataDir & Convert.ToString("notebook_out.onetoc2"), New NotebookOneSaveOptions() With {
                 .DeferredSaving = True
            })

            If Notebook.Count > 0 Then
                Dim childDocument0 = TryCast(Notebook(0), Document)

                childDocument0.Save(dataDir & Convert.ToString("Not Locked_out.one"))

                Dim childDocument1 = TryCast(Notebook(1), Document)

                childDocument1.Save(dataDir & Convert.ToString("Locked Pass1_out.one"), New OneSaveOptions() With {
                     .DocumentPassword = "pass"
                })

                Dim childDocument2 = TryCast(Notebook(2), Document)

                childDocument2.Save(dataDir & Convert.ToString("Locked Pass2_out.one"), New OneSaveOptions() With {
                     .DocumentPassword = "pass2"
                })
            End If
            ' ExEnd:WritingPasswordProtectedDoc       
        End Sub
    End Class
End Namespace
