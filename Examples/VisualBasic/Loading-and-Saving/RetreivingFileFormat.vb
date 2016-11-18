Imports System.IO
Imports  Aspose.Note
Imports Aspose.Note.Saving

Namespace CSharp.Loading_Saving
    Public Class RetreivingFileFormat
        Public Shared Sub Run()
            ' ExStart:RetreivingFileFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            Dim document = New Document(dataDir & Convert.ToString("Aspose.one"))
            Select Case document.FileFormat
                Case FileFormat.OneNote2010
                    ' process OneNote 2010
                    Exit Select
                Case FileFormat.OneNoteOnline
                    ' process OneNote Online
                    Exit Select
            End Select
            ' ExEnd:RetreivingFileFormat           
        End Sub
    End Class
End Namespace