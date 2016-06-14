using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
namespace Aspose.Note.Examples.CSharp.Tables
{
    public class ExtractCellText
    {
        public static void Run()
        {
            // ExStart:ExtractCellText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tables();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Sample1.one");

            // Get a list of table nodes
            IList<Table> nodes = document.GetChildNodes<Table>();        

            foreach (Table table in nodes)
            {
                // Iterate through table rows
                foreach (TableRow row in table)
                {
                    // Get list of TableCell nodes
                    IList<TableCell> cellNodes = row.GetChildNodes<TableCell>();
                    // Iterate through table cells
                    foreach (TableCell cell in cellNodes)
                    {
                        // Retrieve text
                        string text = cell.GetText();
                        // Print text on the output screen
                        Console.WriteLine(text);
                    }
                }
            }
            // ExEnd:ExtractCellText
        }
    }
}