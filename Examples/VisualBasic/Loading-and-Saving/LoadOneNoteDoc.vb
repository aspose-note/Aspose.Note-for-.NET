Imports System.IO
Imports AsposeNote = Aspose.Note
Imports Aspose.Note.Saving

Namespace Loading_Saving
    Public Class LoadOneNoteDoc
        Public Shared Sub Run()
            ' ExStart:LoadOneNoteDoc
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()
            Dim fileName As String = ""
            If fileName <> "" Then
                Try
                    Dim notebook = New AsposeNote.Notebook(dataDir & fileName)
                    For Each notebookChildNode In notebook
                        Console.WriteLine(notebookChildNode.DisplayName)
                        ' Do something with child document
                        If TypeOf notebookChildNode Is Document Then
                            ' Do something with child notebook
                        ElseIf TypeOf notebookChildNode Is AsposeNote.Notebook Then
                        End If
                    Next
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            Else
                Console.WriteLine(vbLf & "Please enter valid file name.")
            End If
            ' ExEnd:LoadOneNoteDoc
        End Sub
    End Class
End Namespace