Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace WorkingWithNoteBook
    Public Class CreateNoteBook
        Public Shared Sub Run()
            ' ExStart:CreateNoteBook
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            Dim notebook = New Notebook()

            dataDir = dataDir & Convert.ToString("test_out.onetoc2")

            ' Save the Notebook
            notebook.Save(dataDir)

            ' ExEnd:CreateNoteBook
            Console.WriteLine(Convert.ToString(vbLf & "NoteBook created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace