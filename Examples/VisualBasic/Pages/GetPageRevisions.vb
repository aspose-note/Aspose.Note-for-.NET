Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Pages
    Public Class GetPageRevisions
        Public Shared Sub Run()
            ' ExStart:GetPageRevisions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load OneNote document
            Dim document As New Document(dataDir & Convert.ToString("Aspose.one"), New LoadOptions() With {
                 .LoadHistory = True
            })
            ' Get first page
            Dim firstPage As Page = Document.FirstChild
            For Each pageRevision As Page In Document.GetPageHistory(firstPage)
                'Use pageRevision like a regular page.

                Console.WriteLine("LastModifiedTime: {0}", pageRevision.LastModifiedTime)
                Console.WriteLine("CreationTime: {0}", pageRevision.CreationTime)
                Console.WriteLine("Title: {0}", pageRevision.Title)
                Console.WriteLine("Level: {0}", pageRevision.Level)
                Console.WriteLine("Author: {0}", pageRevision.Author)
                Console.WriteLine()
            Next
            ' ExEnd:GetPageRevisions
        End Sub
    End Class
End Namespace
