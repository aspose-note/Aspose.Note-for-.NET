Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Namespace Tables
    Public Class ExtractTableText
        Public Shared Sub Run()
            ' ExStart:ExtractTableText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tables()

            ' Load the document into Aspose.Note.
            Dim document As New Document(dataDir & Convert.ToString("Sample1.one"))

            ' Get a list of table nodes
            Dim nodes As IList(Of Table) = document.GetChildNodes(Of Table)()

            ' Set table count
            Dim tblCount As Integer = 0

            For Each table As Table In nodes
                tblCount += 1
                Console.WriteLine("table # " + tblCount.ToString())

                ' Retrieve text
                Dim text As String = table.GetText()
                ' Print text on the output screen
                Console.WriteLine(text)
            Next
            ' ExEnd:ExtractTableText
        End Sub
    End Class
End Namespace