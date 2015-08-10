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
Imports System.Drawing
Imports System

Namespace Aspose.Note.Examples.Images
    Public Class ExtractImages
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & "Aspose.one")
            ' Get all Image nodes
            Dim nodes As IList(Of Node) = oneFile.GetChildNodes(NodeType.Image)

            For Each image As Global.Aspose.Note.Image In nodes
                Using stream As New MemoryStream(image.Bytes)
                    Using bitMap As New Bitmap(stream)
                        ' Save image bytes to a file
                        bitMap.Save(String.Format(dataDir & "{0}", Path.GetFileName(image.FileName)))
                    End Using
                End Using
            Next image

        End Sub
    End Class
End Namespace