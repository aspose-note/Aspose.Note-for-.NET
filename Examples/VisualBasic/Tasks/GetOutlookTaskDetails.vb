Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Tasks
    Public Class GetOutlookTaskDetails
        Public Shared Sub Run()
            ' ExStart:GetOutlookTaskDetails
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tasks()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Get all RichText nodes
            Dim nodes As IList(Of RichText) = oneFile.GetChildNodes(Of RichText)()

            ' Iterate through each node
            For Each richText As RichText In nodes
                For Each tag In richText.Tags
                    If TypeOf tag Is NoteTask Then
                        Dim noteTask As NoteTask = DirectCast(tag, NoteTask)
                        ' Retrieve properties
                        Console.WriteLine("Completed Time: " + noteTask.CompletedTime.ToString())
                        Console.WriteLine("Create Time: " + noteTask.CreationTime.ToString())
                        Console.WriteLine("Due Date: " + noteTask.DueDate.ToString())
                        Console.WriteLine("Status: " + noteTask.Status.ToString())
                        Console.WriteLine("Task Type: " + noteTask.TaskType.ToString())
                        Console.WriteLine("Icon: " + noteTask.Icon.ToString())
                    End If
                Next
            Next
            ' ExEnd:GetOutlookTaskDetails
        End Sub
    End Class
End Namespace