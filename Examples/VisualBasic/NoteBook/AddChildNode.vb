Imports System.Drawing
Imports System.IO
Imports System.Collections.Generic
Imports Aspose.Note

Namespace WorkingWithNoteBook
    Public Class AddChildNode
        Public Shared Sub Run()
            ' ExStart:AddChildNode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            ' Load a OneNote Notebook
            Dim notebook = New Notebook(dataDir & Convert.ToString("Notizbuch öffnen.onetoc2"))

            ' Append a new child to the Notebook
            notebook.AppendChild(New Document(dataDir & Convert.ToString("Neuer Abschnitt 1.one")))

            dataDir = dataDir & Convert.ToString("AddChildNode_out.onetoc2")

            ' Save the Notebook
            notebook.Save(dataDir)
            ' ExEnd:AddChildNode
            Console.WriteLine(Convert.ToString(vbLf & "Child node added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace

