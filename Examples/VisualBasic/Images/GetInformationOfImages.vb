Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Collections.Generic

Namespace Images
    Public Class GetInformationOfImages
        Public Shared Sub Run()
            ' ExStart:GetInformationOfImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

            ' Get all Image nodes
            Dim images As IList(Of AsposeNote.Image) = oneFile.GetChildNodes(Of AsposeNote.Image)()

            For Each image As AsposeNote.Image In images
                Console.WriteLine("Width: {0}", image.Width)
                Console.WriteLine("Height: {0}", image.Height)
                Console.WriteLine("OriginalWidth: {0}", image.OriginalWidth)
                Console.WriteLine("OriginalHeight: {0}", image.OriginalHeight)
                Console.WriteLine("FileName: {0}", image.FileName)
                Console.WriteLine("Extension: {0}", image.Extension)
                Console.WriteLine("LastModifiedTime: {0}", image.LastModifiedTime)
                Console.WriteLine()
            Next
            ' ExEnd:GetInformationOfImages
        End Sub
    End Class
End Namespace