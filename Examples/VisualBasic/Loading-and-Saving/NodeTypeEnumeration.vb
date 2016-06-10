Imports System.IO
Imports Aspose.Note

Namespace Loading_Saving
    Public Class NodeTypeEnumeration
        Public Shared Sub Run()
            ' ExStart:NodeTypeEnumeration
            ' The path to the documents directory.
            Dim doc As New Document()

            ' Returns NodeType.Document
            Dim type As NodeType = doc.NodeType
            ' ExEnd:NodeTypeEnumeration
        End Sub
    End Class
End Namespace