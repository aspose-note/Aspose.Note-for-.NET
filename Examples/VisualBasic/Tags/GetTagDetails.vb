Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Tags
    Public Class GetTagDetails
        Public Shared Sub Run()
            ' ExStart:GetTagDetails
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tags()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("TagFile.one"))

            ' Get all RichText nodes
            Dim nodes As IList(Of RichText) = oneFile.GetChildNodes(Of RichText)()

            ' Iterate through each node
            For Each richText As RichText In nodes
                For Each tag In richText.Tags
                    If TypeOf tag Is NoteTag Then
                        Dim noteTag As NoteTag = DirectCast(tag, NoteTag)
                        ' Retrieve properties
                        Console.WriteLine("Completed Time: " + noteTag.CompletedTime.ToString())
                        Console.WriteLine("Create Time: " + noteTag.CreationTime.ToString())
                        Console.WriteLine("Font Color: " + noteTag.FontColor.ToString())
                        Console.WriteLine("Status: " + noteTag.Status.ToString())
                        Console.WriteLine("Label: " + noteTag.Label)
                        Console.WriteLine("Icon: " + noteTag.Icon.ToString())
                        Console.WriteLine("High Light: " + noteTag.Highlight.ToString())
                    End If
                Next
            Next

            ' ExEnd:GetTagDetails
        End Sub
    End Class
End Namespace
