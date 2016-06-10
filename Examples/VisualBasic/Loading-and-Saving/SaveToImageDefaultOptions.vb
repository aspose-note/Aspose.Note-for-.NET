Imports System.IO
Imports Aspose.Note

Namespace Loading_Saving
    Public Class SaveToImageDefaultOptions
        Public Shared Sub Run()
            ' ExStart:SaveToImageDefaultOptions
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            dataDir = dataDir & Convert.ToString("SaveToImageDefaultOptions_out_.gif")

            ' Save the document as gif.
            oneFile.Save(dataDir, SaveFormat.Gif)
            ' ExEnd:SaveToImageDefaultOptions
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document converted successfully to image using default options." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace