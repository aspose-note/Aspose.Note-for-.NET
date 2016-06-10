Imports System.IO
Imports Aspose.Note

Namespace Loading_Saving
    Public Class PasswordProtectedDoc
        Public Shared Sub Run()
            ' ExStart:PasswordProtectedDoc
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_LoadingAndSaving()

            Dim loadOptions As New LoadOptions() With {
                 .DocumentPassword = "password"
            }
            Dim doc As New Document(dataDir & Convert.ToString("Sample1.one"), loadOptions)

            ' ExEnd:PasswordProtectedDoc
            Console.WriteLine(vbLf & "Password protected document loaded successfully.")
        End Sub
    End Class
End Namespace