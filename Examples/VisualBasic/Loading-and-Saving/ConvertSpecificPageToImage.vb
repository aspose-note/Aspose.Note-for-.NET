Imports System.IO
Imports Aspose.Note
Imports Aspose.Note.Saving
Namespace Loading_Saving
    Public Class ConvertSpecificPageToImage
        Public Shared Sub Run()
            ' ExStart:ConvertSpecificPageToImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Initialize ImageSaveOptions object 
            Dim opts As New ImageSaveOptions(SaveFormat.Png)

            ' Set page index
            opts.PageIndex = 1

            dataDir = dataDir & Convert.ToString("ConvertSpecificPageToImage_out_.png")

            ' Save the document as PNG.
            oneFile.Save(dataDir, opts)
            ' ExEnd:ConvertSpecificPageToImage
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document converted successfully to image." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub SetOutputImageResolution()
            ' ExStart:SetOutputImageResolution
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            ' Load the document into Aspose.Note.
            Dim doc As New Document(dataDir & Convert.ToString("Aspose.one"))

            dataDir = dataDir & Convert.ToString("SetOutputImageResolution_out_.jpg")

            ' Save the document.
            doc.Save(dataDir, New ImageSaveOptions(SaveFormat.Jpeg) With {.Resolution = 220})
            ' ExEnd:SetOutputImageResolution
            Console.WriteLine(Convert.ToString(vbLf & "OneNote document output resolution setup successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace