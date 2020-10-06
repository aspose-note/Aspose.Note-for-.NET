using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class ExtractRowText
    {
        public static void Run()
        {
            // ExStart:ExtractRowText
            // ExFor:Table
            // ExFor:TableRow
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to get text from every table's row.

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
                    // Retrieve text
                    string text = string.Join(Environment.NewLine, row.GetChildNodes<RichText>().Select(e => e.Text)) + Environment.NewLine;
               
                    // Print text on the output screen
                    Console.WriteLine(text);
                }
            }

            // ExEnd:ExtractRowText
        }
    }
}