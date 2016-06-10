Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Namespace Pages
    Public Class GetPageInformation
        Public Shared Sub Run()
            ' ExStart:GetPageInformation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Get all Page nodes
            Dim pages As IList(Of Page) = oneFile.GetChildNodes(Of Page)()

            For Each page As Page In pages
                Console.WriteLine("LastModifiedTime: {0}", page.LastModifiedTime)
                Console.WriteLine("CreationTime: {0}", page.CreationTime)
                Console.WriteLine("Title: {0}", page.Title)
                Console.WriteLine("Level: {0}", page.Level)
                Console.WriteLine("Author: {0}", page.Author)
                Console.WriteLine()
            Next
            ' ExEnd:GetPageInformation
        End Sub
    End Class
End Namespace
