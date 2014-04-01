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
Imports System

Namespace ExtractingAllText
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load the document into Aspose.Note.
			Dim oneFile As New Document(dataDir & "Aspose.one")

			' Retrieve text
			Dim text As String = oneFile.GetText()

			' Print text on the output screen
			Console.WriteLine(text)

		End Sub
	End Class
End Namespace