using System;
using Aspose.Note.Examples.CSharp.Tables;

namespace Aspose.Note.Examples.CSharp.Tags
{
    public class AddTableNodeWithTag
    {
        public static void Run()
        {
            // ExStart:AddTableNodeWithTag
            // ExFor:Table
            // ExFor:Table.Columns
            // ExFor:Table.IsBordersVisible
            // ExFor:TableColumn
            // ExFor:TableColumn.Width
            // ExFor:TableRow
            // ExFor:TableCell
            // ExFor:NoteTag
            // ExSummary:Shows how to add new table with tag.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Page page = new Page();

            // Initialize TableRow class object
            TableRow row = new TableRow();

            // Initialize TableCell class object
            TableCell cell = new TableCell();

            // Insert cell content
            cell.AppendChildLast(InsertTable.GetOutlineElementWithText("Single cell."));

            // Add cell to row node
            row.AppendChildLast(cell);
            
            // Initialize table node
            Table table = new Table()
                          {
                              IsBordersVisible = true,
                              Columns = { new TableColumn { Width = 70 } }
                          };

            // Insert row node in table
            table.AppendChildLast(row);

            // Add tag to this table node
            table.Tags.Add(NoteTag.CreateQuestionMark());

            Outline outline = new Outline();
            OutlineElement outlineElem = new OutlineElement();
            
            // Add table node
            outlineElem.AppendChildLast(table);
            
            // Add outline elements
            outline.AppendChildLast(outlineElem);
            page.AppendChildLast(outline);
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "AddTableNodeWithTag_out.one";
            doc.Save(dataDir);

            // ExEnd:AddTableNodeWithTag

            Console.WriteLine("\nTable node with tag added successfully.\nFile saved at " + dataDir);
        }
    }
}