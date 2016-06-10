Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Images
    Public Class ExtractImages
        Public Shared Sub Run()
            Try
                ' ExStart:ExtractImages
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_Images()

                ' Load the document into Aspose.Note.
                Dim oneFile As New Document(dataDir & Convert.ToString("Aspose.one"))

                ' Get all Image nodes
                Dim nodes As IList(Of Aspose.Note.Image) = oneFile.GetChildNodes(Of Aspose.Note.Image)()

                For Each image As Aspose.Note.Image In nodes
                    Using stream As New MemoryStream(image.Bytes)
                        Using bitMap As New Bitmap(stream)
                            ' Save image bytes to a file
                            bitMap.Save([String].Format(dataDir & Convert.ToString("{0}"), Path.GetFileName(image.FileName)))
                        End Using
                    End Using
                    ' ExEnd:ExtractImages 
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
        End Sub
    End Class
End Namespace
