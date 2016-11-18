Imports System.IO
Imports Aspose.Note

Namespace Loading_Saving
    Public Class SaveWithDefaultSettings
        Public Shared Sub Run()
            ' ExStart:SaveWithDefaultSettings
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            dataDir = dataDir & Convert.ToString("SaveWithDefaultSettings_out.pdf")
            ' Save the document as PDF
            oneFile.Save(dataDir, SaveFormat.Pdf)
            ' ExEnd:SaveWithDefaultSettings
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document saved successfully with default settings." & vbLf & "File saved at ") & dataDir)
        End Sub

    End Class
End Namespace
