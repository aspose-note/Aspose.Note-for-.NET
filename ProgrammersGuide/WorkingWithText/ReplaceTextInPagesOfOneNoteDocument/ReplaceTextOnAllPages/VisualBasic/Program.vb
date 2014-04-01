'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Note. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Note
Imports System.Collections.Generic

Namespace ReplaceTextOnAllPages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim replacements As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			replacements.Add("Some task here", "New Text Here")

			' Load the document into Aspose.Note.
			Dim oneFile As New Document(dataDir & "Aspose.one")

			Dim compositeNode As CompositeNode = CType(oneFile, CompositeNode)
			' Get all RichText nodes
			Dim textNodes As IList(Of Node) = compositeNode.GetChildNodes(NodeType.RichText)

			For Each node As Node In textNodes
				For Each kvp As KeyValuePair(Of String, String) In replacements
					Dim richText As RichText = CType(node, RichText)
					If richText IsNot Nothing AndAlso richText.Text.Contains(kvp.Key) Then
						' Replace text of a shape
						richText.Text = richText.Text.Replace(kvp.Key, kvp.Value)
					End If
				Next kvp
			Next node

			' Save to any supported file format
			oneFile.Save(dataDir & "Output.pdf", SaveFormat.Pdf)

		End Sub
	End Class
End Namespace