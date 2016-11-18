Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Text
    Public Class ReplaceTextOnParticularPage
        Public Shared Sub Run()
            ' ExStart:ReplaceTextOnParticularPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            Dim replacements As New Dictionary(Of String, String)()
            replacements.Add("voice over", "voice over new text")

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            Dim pageNodes As IList(Of Page) = oneFile.GetChildNodes(Of Page)()


            ' Get all RichText nodes
            Dim textNodes As IList(Of RichText) = pageNodes(0).GetChildNodes(Of RichText)()

            For Each richText As RichText In textNodes
                For Each kvp As KeyValuePair(Of String, String) In replacements
                    If richText IsNot Nothing AndAlso richText.Text.Contains(kvp.Key) Then
                        ' Replace text of a shape
                        richText.Text = richText.Text.Replace(kvp.Key, kvp.Value)
                    End If
                Next
            Next
            dataDir = dataDir & Convert.ToString("ReplaceTextOnParticularPage_out.pdf")
            ' Save to any supported file format
            oneFile.Save(dataDir, SaveFormat.Pdf)
            ' ExEnd:ReplaceTextOnParticularPage
            Console.WriteLine(Convert.ToString(vbLf & "Text replaced successfully on a particular page." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace