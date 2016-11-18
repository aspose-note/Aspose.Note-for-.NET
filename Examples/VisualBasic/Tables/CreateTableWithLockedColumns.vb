Imports System.IO
Imports  Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing

Namespace Tables
    Public Class CreateTableWithLockedColumns
        Public Shared Sub Run()
            ' ExStart:CreateTableWithLockedColumns
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tables()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Page(doc)

            ' Initialize TableRow class object
            Dim row1 As New TableRow(doc)
            ' Initialize TableCell class object and set text content
            Dim cell11 As New TableCell(doc)
            cell11.AppendChild(InsertTable.GetOutlineElementWithText(doc, "Small text"))
            row1.AppendChild(cell11)

            ' Initialize TableRow class object
            Dim row2 As New TableRow(doc)
            ' Initialize TableCell class object and set text content
            Dim cell21 As New TableCell(doc)
            cell21.AppendChild(InsertTable.GetOutlineElementWithText(doc, "Long   text    with    several   words and    spaces."))
            row2.AppendChild(cell21)

            ' Initialize Table class object
            Dim table As New Table(doc) With {.IsBordersVisible = True}
            ' Add rows
            Table.AppendChild(row1)
            Table.AppendChild(row2)

            Dim outline As New Outline(doc)
            Dim outlineElem As New OutlineElement(doc)
            ' Add table node
            outlineElem.AppendChild(Table)
            ' Add outline element node
            outline.AppendChild(outlineElem)
            ' Add outline node
            page.AppendChild(outline)
            ' Add page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("CreateTableWithLockedColumns_out.one")

            'doc.Save(dataDir)
            ' ExEnd:CreateTableWithLockedColumns

            Console.WriteLine(Convert.ToString(vbLf & "Table with locked columns created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub

    End Class
End Namespace