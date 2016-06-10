Imports System.Globalization
Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Namespace Text
    Public Class RetrieveBulletOrNumberList
        Public Shared Sub Run()
            ' ExStart:RetrieveBulletOrNumberList
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & Convert.ToString("ApplyNumberingOnText.one"))

            ' Retrieve a collection nodes of the outline element
            Dim nodes As IList(Of OutlineElement) = oneFile.GetChildNodes(Of OutlineElement)()

            ' Iterate through each node
            For Each node As OutlineElement In nodes
                If node.NumberList IsNot Nothing Then
                    Dim list As NumberList = node.NumberList
                    ' Retrieve font name
                    Console.WriteLine("Font Name: " + list.Font)
                    ' Retrieve font length
                    Console.WriteLine("Font Length: " + list.Font.Length.ToString())
                    ' Retrieve font size
                    Console.WriteLine("Font Size: " + list.FontSize.ToString())
                    ' Retrieve font color
                    Console.WriteLine("Font Color: " + list.FontColor.ToString())
                    ' Retrieve format
                    Console.WriteLine("Font format: " + list.Format)
                    ' Check bold
                    Console.WriteLine("Is bold: " + list.IsBold.ToString())
                    ' Check italic
                    Console.WriteLine("Is italic: " + list.IsItalic.ToString())
                    Console.WriteLine()
                End If
            Next
            ' ExEnd:RetrieveBulletOrNumberList           
        End Sub
    End Class
End Namespace