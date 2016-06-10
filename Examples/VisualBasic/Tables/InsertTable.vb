Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Tables
    Public Class InsertTable
        Public Shared Sub Run()
            ' ExStart:InsertTable
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tables()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Aspose.Note.Page(doc)

            ' Initialize TableRow class object
            Dim row1 As New TableRow(doc)
            ' Initialize TableCell class objects
            Dim cell11 As New TableCell(doc)
            Dim cell12 As New TableCell(doc)
            Dim cell13 As New TableCell(doc)

            ' Append outline elements in the table cell
            cell11.AppendChild(GetOutlineElementWithText(doc, "cell_1.1"))
            cell12.AppendChild(GetOutlineElementWithText(doc, "cell_1.2"))
            cell13.AppendChild(GetOutlineElementWithText(doc, "cell_1.3"))
            ' Table cells to rows
            row1.AppendChild(cell11)
            row1.AppendChild(cell12)
            row1.AppendChild(cell13)

            ' Initialize TableRow class object
            Dim row2 As New TableRow(doc)
            ' initialize TableCell class objects
            Dim cell21 As New TableCell(doc)
            Dim cell22 As New TableCell(doc)
            Dim cell23 As New TableCell(doc)

            ' Append outline elements in the table cell
            cell21.AppendChild(GetOutlineElementWithText(doc, "cell_2.1"))
            cell22.AppendChild(GetOutlineElementWithText(doc, "cell_2.2"))
            cell23.AppendChild(GetOutlineElementWithText(doc, "cell_2.3"))

            ' Append table cells to rows
            row2.AppendChild(cell21)
            row2.AppendChild(cell22)
            row2.AppendChild(cell23)

            ' Initialize Table class object and set column widths
            Dim table As New Aspose.Note.Table(doc) With {
      .IsBordersVisible = True}
            ' Append table rows to table
            table.AppendChild(row1)
            table.AppendChild(row2)

            ' Initialize Outline object
            Dim outline As New Outline(doc)
            ' Initialize OutlineElement object
            Dim outlineElem As New OutlineElement(doc)
            ' Add table to outline element node
            outlineElem.AppendChild(table)
            ' Add outline element to outline
            outline.AppendChild(outlineElem)
            ' Add outline to page node
            page.AppendChild(outline)
            ' Add page to document node
            doc.AppendChild(page)
            dataDir = dataDir & Convert.ToString("InsertTable_out_.one")
            'doc.Save(dataDir)
            ' ExEnd:InsertTable

            Console.WriteLine(Convert.ToString(vbLf & "Table inserted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        ' ExStart:GetOutlineElementWithText
        Public Shared Function GetOutlineElementWithText(doc As Document, text As String) As OutlineElement
            Dim outlineElem As New OutlineElement(doc)
            Dim textStyle As New TextStyle() With {
                 .FontColor = Color.Black,
                 .FontName = "Arial",
                 .FontSize = 10
            }
            outlineElem.AppendChild(New RichText(doc) With {
                 .Text = text,
                 .DefaultStyle = textStyle
            })
            Return outlineElem
        End Function
        ' ExEnd:GetOutlineElementWithText
    End Class
End Namespace