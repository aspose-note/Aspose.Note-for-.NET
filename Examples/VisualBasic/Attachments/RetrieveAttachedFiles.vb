Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing

Namespace Attachments
    Public Class RetrieveAttachedFiles
        Public Shared Sub Run()
            ' ExStart:RetrieveAttachedFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Attachments()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("Sample1.one"))

            ' Get a list of attached file nodes
            Dim nodes As IList(Of AttachedFile) = oneFile.GetChildNodes(Of AttachedFile)()

            ' Iterate through all nodes
            For Each file As AttachedFile In nodes
                ' Load attached file to a stream object
                Using outputStream As Stream = New MemoryStream(file.Bytes)
                    ' Create a local file
                    Using fileStream As Stream = System.IO.File.OpenWrite([String].Format(dataDir + file.FileName))
                        ' Copy file stream
                        CopyStream(outputStream, fileStream)
                    End Using
                End Using
            Next

            ' ExEnd:RetrieveAttachedFiles            
        End Sub
        ' ExStart:CopyStream  
        Private Shared Sub CopyStream(input As Stream, output As Stream)
            Try
                Dim buffer As Byte() = New Byte(8 * 1024 - 1) {}
                Dim len As Integer
                While (InlineAssignHelper(len, input.Read(buffer, 0, buffer.Length))) > 0
                    output.Write(buffer, 0, len)
                End While
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
        ' ExEnd:CopyStream  
    End Class
End Namespace