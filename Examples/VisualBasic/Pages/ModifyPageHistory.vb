Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Pages
    Public Class ModifyPageHistory
        Public Shared Sub Run()
            ' ExStart:ModifyPageHistory
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Pages()

            ' Load OneNote document and get first child           
            Dim document As New Document(dataDir & "Aspose.one")
            Dim page As Page = document.FirstChild

            Dim pageHistory = document.GetPageHistory(page)

            pageHistory.RemoveRange(0, 1)

            pageHistory(0) = New Page(document)
            If pageHistory.Count > 1 Then
                pageHistory(1).Title.TitleText.Text = "New Title"

                pageHistory.Add(New Page(document))

                pageHistory.Insert(1, New Page(document))

                document.Save(dataDir & "ModifyPageHistory_out_.one")
            End If
            ' ExEnd:ModifyPageHistory
        End Sub
    End Class
End Namespace
