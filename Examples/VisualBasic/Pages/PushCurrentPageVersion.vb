Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Pages
    Public Class PushCurrentPageVersion
        Public Shared Sub Run()
            ' ExStart:PushCurrentPageVersion
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load OneNote document and get first child           
            Dim document As New Document(dataDir & Convert.ToString("Aspose.one"))
            Dim page As Page = document.FirstChild

            Dim pageHistory = document.GetPageHistory(page)

            pageHistory.Add(page.Clone())

            document.Save(dataDir & "PushCurrentPageVersion_out.one")
            ' ExEnd:PushCurrentPageVersion
        End Sub
    End Class
End Namespace
