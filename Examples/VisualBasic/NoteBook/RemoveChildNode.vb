Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports AsposeNote = Aspose.Note

Namespace NoteBook
    Public Class RemoveChildNode
        Public Shared Sub Run()
            ' ExStart:RemoveChildNode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_NoteBook()

            ' Load a OneNote Notebook
            Dim notebook = New AsposeNote.Notebook(dataDir & Convert.ToString("test.onetoc2"))

            ' Traverse through its child nodes for searching the desired child item
            For Each child In New List(Of INotebookChildNode)(notebook)
                If child.DisplayName = "Remove Me" Then
                    ' Remove the Child Item from the Notebook
                    notebook.RemoveChild(child)
                End If
            Next

            dataDir = dataDir & Convert.ToString("RemoveChildNode_out_.onetoc2")

            ' Save the Notebook
            notebook.Save(dataDir)
            ' ExEnd:RemoveChildNode

            Console.WriteLine(Convert.ToString(vbLf & "Child node removed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace