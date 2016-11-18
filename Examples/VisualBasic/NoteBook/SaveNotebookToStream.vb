Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Imports System.Globalization

Namespace WorkingWithNoteBook
    Public Class SaveNotebookToStream
        Public Shared Sub Run()
            ' ExStart:SaveNotebookToStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()
            Dim notebook = New Notebook()

            Dim stream As New MemoryStream()
            notebook.Save(stream)
            If notebook.Count > 0 Then
                Dim childDocument0 = TryCast(notebook(0), Document)

                Dim childStream As New MemoryStream()
                childDocument0.Save(childStream)

                Dim childDocument1 = TryCast(notebook(1), Document)
                childDocument0.Save(dataDir & Convert.ToString("SaveNotebookToStream_out.one"))
            End If
            ' ExEnd:SaveNotebookToStream       
        End Sub
    End Class
End Namespace
