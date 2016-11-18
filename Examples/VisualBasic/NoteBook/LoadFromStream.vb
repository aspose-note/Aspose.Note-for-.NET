Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Imports System.Drawing
Imports System.Globalization

Namespace WorkingWithNoteBook
    Public Class LoadFromStream
        Public Shared Sub Run()
            ' ExStart:LoadFromStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()
            Dim stream As New FileStream(dataDir & Convert.ToString("notebook.onetoc2"), FileMode.Open)
            Dim notebook = New Notebook(stream)

            Dim childStream As New FileStream(dataDir & Convert.ToString("Aspose.one"), FileMode.Open)
            notebook.LoadChildDocument(childStream)

            notebook.LoadChildDocument(dataDir & Convert.ToString("Sample1.one"))
            ' ExEnd:LoadFromStream       
        End Sub
    End Class
End Namespace
