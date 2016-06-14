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
            cell11.AppendChild(GetOutlineElementWithText(doc, "cell_1.1"));
            cell12.AppendChild(GetOutlineElementWithText(doc, "cell_1.2"));
            cell13.AppendChild(GetOutlineElementWithText(doc, "cell_1.3"));
            // Table cells to rows
            row1.AppendChild(cell11);
            row1.AppendChild(cell12);
            row1.AppendChild(cell13);

            // Initialize TableRow class object
            TableRow row2 = new TableRow(doc);
            // initialize TableCell class objects
            TableCell cell21 = new TableCell(doc);
            TableCell cell22 = new TableCell(doc);
            TableCell cell23 = new TableCell(doc);

            // Append outline elements in the table cell
            cell21.AppendChild(GetOutlineElementWithText(doc, "cell_2.1"));
            cell22.AppendChild(GetOutlineElementWithText(doc, "cell_2.2"));
            cell23.AppendChild(GetOutlineElementWithText(doc, "cell_2.3"));

            // Append table cells to rows
            row2.AppendChild(cell21);
            row2.AppendChild(cell22);
            row2.AppendChild(cell23);

            // Initialize Table class object and set column widths
            Table table = new Table(doc)
            {
                IsBordersVisible = true,
                Columns = { new TableColumn { Width = 200 }, new TableColumn { Width = 200 }, new TableColumn { Width = 200 } }
            };
            // Append table rows to table
            table.AppendChild(row1);
            table.AppendChild(row2);

            // Initialize Outline object
            Outline outline = new Outline(doc);
            // Initialize OutlineElement object
            OutlineElement outlineElem = new OutlineElement(doc);
            // Add table to outline element node
            outlineElem.AppendChild(table);
            // Add outline element to outline
            outline.AppendChild(outlineElem);
            // Add outline to page node
            page.AppendChild(outline);
            // Add page to document node
            doc.AppendChild(page);
            dataDir = dataDir + "InsertTable_out_.one";
            doc.Save(dataDir);
            // ExEnd:InsertTable

            Console.WriteLine("\nTable inserted successfully.\nFile saved at " + dataDir);
        }
        // ExStart:GetOutlineElementWithText
        public static OutlineElement GetOutlineElementWithText(Document doc, string text)
        {
            OutlineElement outlineElem = new OutlineElement(doc);
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            outlineElem.AppendChild(new RichText(doc) { Text = text, DefaultStyle = textStyle });
            return outlineElem;
        }
        // ExEnd:GetOutlineElementWithText
    }
}