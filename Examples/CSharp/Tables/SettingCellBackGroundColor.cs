using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class SettingCellBackGroundColor
    {
        public static void Run()
        {
            // ExStart:SettingCellBackGroundColor
            // ExFor:Table
            // ExFor:Table.Columns
            // ExFor:Table.IsBordersVisible
            // ExFor:TableColumn
            // ExFor:TableColumn.Width
            // ExFor:TableRow
            // ExFor:TableCell
            // ExFor:TableCell.BackgroundColor
            // ExSummary:Shows how to set a background color for a cell.

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize TableCell class object and set text content
            TableCell cell11 = new TableCell(doc);
            cell11.AppendChildLast(InsertTable.GetOutlineElementWithText(doc, "Small text"));
            cell11.BackgroundColor = Color.Coral;

            // Initialize TableRow class object
            TableRow row = new TableRow(doc);
            row.AppendChildLast(cell11);

            Table table = new Table(doc)
                          {
                              IsBordersVisible = true,
                              Columns = { new TableColumn() { Width = 200 } }
                          };
            table.AppendChildLast(row);

            OutlineElement oe = new OutlineElement(doc);
            oe.AppendChildLast(table);

            Outline o = new Outline(doc);
            o.AppendChildLast(oe);

            // Initialize Page class object
            Page page = new Page(doc);
            page.AppendChildLast(o);

            doc.AppendChildLast(page);

            doc.Save(Path.Combine(RunExamples.GetDataDir_Tables(), "SettingCellBackGroundColor.pdf"));

            // ExEnd:SettingCellBackGroundColor
        }
    }
}