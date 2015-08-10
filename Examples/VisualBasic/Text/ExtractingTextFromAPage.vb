'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Note. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Note
Imports System
Imports System.Collections.Generic

Namespace Aspose.Note.Examples.Text
    Public Class ExtractingTextFromAPage
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & "Aspose.one")

            ' Get list of page nodes
            Dim nodes As IList(Of Node) = oneFile.GetChildNodes(NodeType.Page)

            If nodes.Count > 0 AndAlso nodes(0).NodeType = NodeType.Page Then
                Dim page As Page = CType(nodes(0), Page)
                ' Retrieve text
                Dim text As String = page.GetText()
                ' Print text on the output screen
                Console.WriteLine(text)
            End If

        End Sub
    End Class
End Namespace