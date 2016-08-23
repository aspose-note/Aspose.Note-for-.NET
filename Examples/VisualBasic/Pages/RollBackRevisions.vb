Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Pages
    Public Class RollBackRevisions
        Public Shared Sub Run()
            ' ExStart:RollBackRevisions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load OneNote document and get first child           
            Dim document As New Document(dataDir & Convert.ToString("Aspose.one"))
            Dim page As Page = document.FirstChild
            Dim lastPage As Page = Nothing
            For Each pageRevision As Page In document.GetPageHistory(page)
                lastPage = pageRevision
            Next
            document.RemoveChild(page)

            document.AppendChild(lastPage)

            document.Save(dataDir & "RollBackRevisions_out_.one")
            ' ExEnd:RollBackRevisions
        End Sub
    End Class
End Namespace
