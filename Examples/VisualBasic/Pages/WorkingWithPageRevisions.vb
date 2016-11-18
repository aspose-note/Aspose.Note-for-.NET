Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Pages
    Public Class WorkingWithPageRevisions
        Public Shared Sub Run()
            ' ExStart:WorkingWithPageRevisions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load OneNote document and get first child           
            Dim document As New Document(dataDir & Convert.ToString("Aspose.one"))
            Dim page As Page = document.FirstChild

            ' Reading Content Revision Summary for this page
            Dim pageRevisionInfo = page.PageContentRevisionSummary

            Console.WriteLine(String.Format("Author:" & vbTab & "{0}" & vbLf & "Modified:" & vbTab & "{1}", pageRevisionInfo.AuthorMostRecent, pageRevisionInfo.LastModifiedTime.ToString("dd.MM.yyyy HH:mm:ss")))

            ' Update Page Revision Summary for this page
            pageRevisionInfo.AuthorMostRecent = "New Author"
            pageRevisionInfo.LastModifiedTime = DateTime.Now
            document.Save(dataDir & "WorkingWithPageRevisions_out.one")
            ' ExEnd:WorkingWithPageRevisions
        End Sub
    End Class
End Namespace
