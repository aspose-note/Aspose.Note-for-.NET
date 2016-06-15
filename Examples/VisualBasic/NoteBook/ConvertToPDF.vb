Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Collections.Generic

Namespace NoteBook
    Public Class ConvertToPDF
        Public Shared Sub Run()
            ' ExStart:ConvertToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            ' Load a OneNote Notebook
            Dim notebook = New AsposeNote.Notebook(dataDir & Convert.ToString("Notizbuch öffnen.onetoc2"))

            dataDir = dataDir & Convert.ToString("ConvertToPDF_out_.pdf")

            ' Save the Notebook
            notebook.Save(dataDir)

            ' ExEnd:ConvertToImage
            Console.WriteLine(Convert.ToString(vbLf & "NoteBook document converted to pdf successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
