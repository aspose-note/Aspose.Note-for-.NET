Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Imports System.Globalization

Namespace WorkingWithNoteBook
    Public Class CreatingPasswordProtectedDoc
        Public Shared Sub Run()
            ' ExStart:CreatingPasswordProtectedDoc
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            Dim document As New Document()
            document.Save(dataDir & Convert.ToString("CreatingPasswordProtectedDoc_out.one"), New OneSaveOptions() With {
                 .DocumentPassword = "pass"
            })
            ' ExEnd:CreatingPasswordProtectedDoc       
        End Sub
    End Class
End Namespace
