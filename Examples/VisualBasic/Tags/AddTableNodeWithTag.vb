Imports System.Drawing
Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Collections.Generic
Imports Aspose.Note.Examples.VisualBasic.Tables
Namespace Tags
    Public Class AddTableNodeWithTag
        Public Shared Sub Run()
            ' ExStart:AddTableNodeWithTag
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Tags()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New AsposeNote.Page(doc)
            ' Initialize TableRow class object
            Dim row As New TableRow(doc)
            ' Initialize TableCell class object
            Dim cell As New TableCell(doc)
            ' Insert cell content
            cell.AppendChild(InsertTable.GetOutlineElementWithText(doc, "Single cell."))
            ' Add cell to row node
            row.AppendChild(cell)
            ' Initialize table node
            Dim table As New Table(doc) With {
                 .IsBordersVisible = True
            }
            ' Insert row node in table
            table.AppendChild(row)
            ' Add tag to this table node
            table.Tags.Add(New NoteTag() With {
                 .Icon = TagIcon.QuestionMark
            })

            Dim outline As New Outline(doc)
            Dim outlineElem As New OutlineElement(doc)
            ' Add table node
            outlineElem.AppendChild(table)
            ' Add outline elements
            outline.AppendChild(outlineElem)
            page.AppendChild(outline)
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("AddTableNodeWithTag_out_.one")
            ' Save OneNote document
            'doc.Save(dataDir)
            ' ExEnd:AddTableNodeWithTag
            Console.WriteLine(Convert.ToString(vbLf & "Table node with tag added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace