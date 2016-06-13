Imports System.IO
Imports Aspose.Note

Namespace Pages
    Public Class GetNumberOfPages
        Public Shared Sub Run()
            ' ExStart:GetNumberOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Get number of pages
            Dim count As Integer = oneFile.GetChildNodes(Of Page)().Count

            ' Print count on the output screen
            Console.WriteLine(count)
            ' ExEnd:GetNumberOfPages
        End Sub
    End Class
End Namespace
