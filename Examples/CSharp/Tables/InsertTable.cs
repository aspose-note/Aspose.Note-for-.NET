using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class InsertTable
    {
        public static void Run()
        {
            // ExStart:InsertTable
            // ExFor:Table
            // ExFor:Table.Columns
            // ExFor:Table.IsBordersVisible
            // ExFor:TableColumn
            // ExFor:TableColumn.Width
            // ExFor:TableRow
            // ExFor:TableCell
            // ExSummary:Shows how to create a new table.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tables();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            // Initialize TableRow class object
            TableRow row1 = new TableRow(doc);
            
            // Initialize TableCell class objects
            TableCell cell11 = new TableCell(doc);
            TableCell cell12 = new TableCell(doc);
            TableCell cell13 = new TableCell(doc);

            // Append outline elements in the table cell
            cell11.AppendChildLast(GetOutlineElementWithText(doc, "cell_1.1"));
            cell12.AppendChildLast(GetOutlineElementWithText(doc, "cell_1.2"));
            cell13.AppendChildLast(GetOutlineElementWithText(doc, "cell_1.3"));
            
            // Table cells to rows
            row1.AppendChildLast(cell11);
            row1.AppendChildLast(cell12);
            row1.AppendChildLast(cell13);

            // Initialize TableRow class object
            TableRow row2 = new TableRow(doc);
            
            // initialize TableCell class objects
            TableCell cell21 = new TableCell(doc);
            TableCell cell22 = new TableCell(doc);
            TableCell cell23 = new TableCell(doc);

            // Append outline elements in the table cell
            cell21.AppendChildLast(GetOutlineElementWithText(doc, "cell_2.1"));
            cell22.AppendChildLast(GetOutlineElementWithText(doc, "cell_2.2"));
            cell23.AppendChildLast(GetOutlineElementWithText(doc, "cell_2.3"));

            // Append table cells to rows
            row2.AppendChildLast(cell21);
            row2.AppendChildLast(cell22);
            row2.AppendChildLast(cell23);

            // Initialize Table class object and set column widths
            Table table = new Table(doc)
                          {
                              IsBordersVisible = true,
                              Columns = { new TableColumn { Width = 200 }, new TableColumn { Width = 200 }, new TableColumn { Width = 200 } }
                          };
            
            // Append table rows to table
            table.AppendChildLast(row1);
            table.AppendChildLast(row2);

            // Initialize Outline object
            Outline outline = new Outline(doc);
            
            // Initialize OutlineElement object
            OutlineElement outlineElem = new OutlineElement(doc);
            
            // Add table to outline element node
            outlineElem.AppendChildLast(table);
            
            // Add outline element to outline
            outline.AppendChildLast(outlineElem);
            
            // Add outline to page node
            page.AppendChildLast(outline);
            
            // Add page to document node
            doc.AppendChildLast(page);
            dataDir = dataDir + "InsertTable_out.one";
            doc.Save(dataDir);
            
            // ExEnd:InsertTable

            Console.WriteLine("\nTable inserted successfully.\nFile saved at " + dataDir);
        }

        public static OutlineElement GetOutlineElementWithText(Document doc, string text)
        {
            OutlineElement outlineElem = new OutlineElement(doc);
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            outlineElem.AppendChildLast(new RichText(doc) { Text = text, ParagraphStyle = textStyle });
            return outlineElem;
        }
    }
}