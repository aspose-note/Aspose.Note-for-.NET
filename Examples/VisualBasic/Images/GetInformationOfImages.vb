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
Imports System.Collections.Generic
Imports System

Namespace Aspose.Note.Examples.Images
    Public Class GetInformationOfImages
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & "Aspose.one")
            ' Get all Image nodes
            Dim nodes As IList(Of Node) = oneFile.GetChildNodes(NodeType.Image)

            For Each image As Image In nodes
                Console.WriteLine("Width: {0}", image.Width)
                Console.WriteLine("Height: {0}", image.Height)
                Console.WriteLine("OriginalWidth: {0}", image.OriginalWidth)
                Console.WriteLine("OriginalHeight: {0}", image.OriginalHeight)
                Console.WriteLine("FileName: {0}", image.FileName)
                Console.WriteLine("Extension: {0}", image.Extension)
                Console.WriteLine("LastModifiedTime: {0}", image.LastModifiedTime)
                Console.WriteLine()
            Next image

        End Sub
    End Class
End Namespace