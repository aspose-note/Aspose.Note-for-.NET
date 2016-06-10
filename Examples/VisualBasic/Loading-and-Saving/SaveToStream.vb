Imports System.IO
Imports Aspose.Note

Namespace Loading_Saving
    Public Class SaveToStream
        Public Shared Sub Run()
            ' ExStart:SaveToStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))

            Dim dstStream As New MemoryStream()
            doc.Save(dstStream, SaveFormat.Pdf)

            ' Rewind the stream position back to zero so it is ready for next reader.
            dstStream.Position = 0
            ' ExEnd:SaveToStream
            Console.WriteLine(vbLf & "OneNote document saved successfully to stream.")
        End Sub
    End Class
End Namespace
