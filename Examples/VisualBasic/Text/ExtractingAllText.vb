Imports System.IO
Imports Aspose.Note

Namespace Text
    Public Class ExtractingAllText
        Public Shared Sub Run()
            ' ExStart:ExtractingAllText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Retrieve text
            Dim text As String = oneFile.GetText()

            ' Print text on the output screen
            Console.WriteLine(text)
            ' ExEnd:ExtractingAllText
        End Sub
    End Class
End Namespace