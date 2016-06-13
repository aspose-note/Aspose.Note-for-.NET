Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Text
    Public Class ExtractingTextFromAPage
        Public Shared Sub Run()
            ' ExStart:ExtractingTextFromAPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Get list of page nodes
            Dim nodes As IList(Of Node) = oneFile.GetChildNodes(Of Node)()

            If nodes.Count > 0 AndAlso nodes(0).NodeType = NodeType.Page Then
                Dim page As Page = DirectCast(nodes(0), Page)
                ' Retrieve text
                Dim text As String = page.GetText()
                ' Print text on the output screen
                Console.WriteLine(text)
            End If
            ' ExEnd:ExtractingTextFromAPage
        End Sub
    End Class
End Namespace
