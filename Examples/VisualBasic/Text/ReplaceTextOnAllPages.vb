Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Text
    Public Class ReplaceTextOnAllPages
        Public Shared Sub Run()
            ' ExStart:ReplaceTextOnAllPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            Dim replacements As New Dictionary(Of String, String)()
            replacements.Add("Some task here", "New Text Here")

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Get all RichText nodes
            Dim textNodes As IList(Of RichText) = oneFile.GetChildNodes(Of RichText)()

            For Each richText As RichText In textNodes
                For Each kvp As KeyValuePair(Of String, String) In replacements
                    If richText IsNot Nothing AndAlso richText.Text.Contains(kvp.Key) Then
                        ' Replace text of a shape
                        richText.Text = richText.Text.Replace(kvp.Key, kvp.Value)
                    End If
                Next
            Next

            dataDir = dataDir & Convert.ToString("ReplaceTextOnAllPages_out.pdf")

            ' Save to any supported file format
            oneFile.Save(dataDir, SaveFormat.Pdf)
            ' ExEnd:ReplaceTextOnAllPages
            Console.WriteLine(Convert.ToString(vbLf & "Text replaced successfully on all pages." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
