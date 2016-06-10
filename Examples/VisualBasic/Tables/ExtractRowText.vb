Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Namespace Tables
    Public Class ExtractRowText
        Public Shared Sub Run()
            ' ExStart:ExtractRowText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tables()

            ' Load the document into Aspose.Note.
            Dim document As New Document(dataDir & Convert.ToString("Sample1.one"))

            ' Get a list of table nodes
            Dim nodes As IList(Of Table) = document.GetChildNodes(Of Table)()

            ' Set row count
            Dim rowCount As Integer = 0

            For Each table As Table In nodes
                ' Iterate through table rows
                For Each row As TableRow In table
                    rowCount += 1
                    ' Retrieve text
                    Dim text As String = row.GetText()
                    ' Print text on the output screen
                    Console.WriteLine(text)
                Next
            Next
            ' ExEnd:ExtractRowText
        End Sub
    End Class
End Namespace