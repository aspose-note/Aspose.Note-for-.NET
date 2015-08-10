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
Imports Aspose.Note.Saving

Namespace Aspose.Note.Examples.LoadSaveConvert
    Public Class SaveRangeOfPagesAsPDF
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Load the document into Aspose.Note.
            Dim oneFile As New Document(dataDir & "Aspose.one")

            ' Initialize PdfSaveOptions object
            Dim opts As New PdfSaveOptions()

            ' Set page index
            opts.PageIndex = 0

            ' Set page count
            opts.PageCount = 1

            ' Save the document as PDF
            oneFile.Save(dataDir & "output.pdf", opts)
        End Sub
    End Class
End Namespace