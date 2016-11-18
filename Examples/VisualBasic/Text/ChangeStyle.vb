Imports System.Globalization
Imports System.IO
Imports Aspose.Note
Imports System.Drawing
Imports System.Collections.Generic

Namespace Text
    Public Class ChangeStyle
        Public Shared Sub Run()
            ' ExStart:ChangeStyle
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Load the document into Aspose.Note.
            Dim document As New Document(dataDir & Convert.ToString("Aspose.one"))
            ' Get a particular RichText node
            Dim richTextNodes As IList(Of RichText) = document.GetChildNodes(Of RichText)()
            Dim richText As RichText = richTextNodes(0)

            For Each style As TextStyle In richText.Styles
                ' Set font color
                style.FontColor = Color.Yellow
                ' Set highlight color
                style.Highlight = Color.Blue
                ' Set font size
                style.FontSize = 20
            Next
            ' ExEnd:ChangeStyle
            Console.WriteLine(vbLf & "Style changed successfully.")
        End Sub
    End Class
End Namespace