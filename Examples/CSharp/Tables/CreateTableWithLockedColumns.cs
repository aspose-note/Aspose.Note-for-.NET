using System;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class CreateTableWithLockedColumns
    {
        public static void Run()
        {
            // ExStart:CreateTableWithLockedColumns
            // ExFor:Table
            // ExFor:Table.Columns
            // ExFor:Table.IsBordersVisible
            // ExFor:TableColumn
            // ExFor:TableColumn.Width
            // ExFor:TableColumn.LockedWidth
            // ExFor:TableRow
            // ExFor:TableCell
            // ExSummary:Shows how to create a table with a locked column.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tables();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Page page = new Page();

            // Initialize TableRow class object
            TableRow row1 = new TableRow();
            
            // Initialize TableCell class object and set text content
            TableCell cell11 = new TableCell();
            cell11.AppendChildLast(InsertTable.GetOutlineElementWithText("Small text"));
            row1.AppendChildLast(cell11);

            // Initialize TableRow class object
            TableRow row2 = new TableRow();
            
            // Initialize TableCell class object and set text content
            TableCell cell21 = new TableCell();
            cell21.AppendChildLast(InsertTable.GetOutlineElementWithText("Long   text    with    several   words and    spaces."));
            row2.AppendChildLast(cell21);

            // Initialize Table class object
            Table table = new Table()
                          {
                              IsBordersVisible = true,
                              Columns = { new TableColumn { Width = 70, LockedWidth = true } }
                          };
            
            // Add rows
            table.AppendChildLast(row1);
            table.AppendChildLast(row2);

            Outline outline = new Outline();
            OutlineElement outlineElem = new OutlineElement();

            // Add table node
            outlineElem.AppendChildLast(table);
            
            // Add outline element node
            outline.AppendChildLast(outlineElem);
            
            // Add outline node
            page.AppendChildLast(outline);
            
            // Add page node
            doc.AppendChildLast(page);
            dataDir = dataDir + "CreateTableWithLockedColumns_out.one";
            doc.Save(dataDir);
            
            // ExEnd:CreateTableWithLockedColumns

            Console.WriteLine("\nTable with locked columns created successfully.\nFile saved at " + dataDir);
        }
        
    }
}