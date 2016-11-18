Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic

Namespace Tables
    Public Class ExtractCellText
        Public Shared Sub Run()
            ' ExStart:ExtractCellText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tables()

            ' Load the document into Aspose.Note.
            Dim document As New Document(dataDir & Convert.ToString("Sample1.one"))

            ' Get a list of table nodes
            Dim nodes As IList(Of Table) = document.GetChildNodes(Of Table)()

            ' Set cell count
            Dim cellCount As Integer = 0

            For Each table As Table In nodes
                ' Iterate through table rows
                For Each row As TableRow In table
                    ' Get list of TableCell nodes
                    Dim cellNodes As IList(Of TableCell) = row.GetChildNodes(Of TableCell)()
                    ' Iterate through table cells
                    For Each cell As TableCell In cellNodes
                        ' Retrieve text
                        Dim text As String = cell.GetText()
                        ' Print text on the output screen
                        Console.WriteLine(text)
                    Next
                Next
            Next
            ' ExEnd:ExtractCellText
        End Sub
    End Class
End Namespace
