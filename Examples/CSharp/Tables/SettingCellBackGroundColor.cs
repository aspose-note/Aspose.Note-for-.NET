using System.IO;
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
            TableCell cell11 = new TableCell();
            cell11.AppendChildLast(InsertTable.GetOutlineElementWithText("Small text"));
            cell11.BackgroundColor = Color.Coral;

            // Initialize TableRow class object
            TableRow row = new TableRow();
            row.AppendChildLast(cell11);

            Table table = new Table()
                          {
                              IsBordersVisible = true,
                              Columns = { new TableColumn() { Width = 200 } }
                          };
            table.AppendChildLast(row);

            OutlineElement oe = new OutlineElement();
            oe.AppendChildLast(table);

            Outline o = new Outline();
            o.AppendChildLast(oe);

            // Initialize Page class object
            Page page = new Page();
            page.AppendChildLast(o);

            doc.AppendChildLast(page);

            doc.Save(Path.Combine(RunExamples.GetDataDir_Tables(), "SettingCellBackGroundColor.pdf"));

            // ExEnd:SettingCellBackGroundColor
        }
    }
}