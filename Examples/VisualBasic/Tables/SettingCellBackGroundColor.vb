Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing

Namespace Tables
    Public Class SettingCellBackGroundColor
        Public Shared Sub Run()
            ' ExStart:SettingCellBackGroundColor
            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Aspose.Note.Page(doc)

            ' Initialize TableRow class object
            Dim row1 As New TableRow(doc)
            ' Initialize TableCell class object and set text content
            Dim cell11 As New TableCell(doc)
            cell11.AppendChild(InsertTable.GetOutlineElementWithText(doc, "Small text"))
            cell11.BackgroundColor = Color.Coral
            row1.AppendChild(cell11)
            ' ExEnd:SettingCellBackGroundColor
        End Sub
    End Class
End Namespace
