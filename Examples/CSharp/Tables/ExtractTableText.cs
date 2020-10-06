using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class ExtractTableText
    {
        public static void Run()
        {
            // ExStart:ExtractTableText
            // ExFor:Table
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to get text from a table.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tables();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Sample1.one");

            // Get a list of table nodes
            IList<Table> nodes = document.GetChildNodes<Table>();

            // Set table count
            int tblCount = 0;

            foreach (Table table in nodes)
            {
                tblCount++;
                Console.WriteLine("table # " + tblCount);

                // Retrieve text
                string text = string.Join(Environment.NewLine, table.GetChildNodes<RichText>().Select(e => e.Text)) + Environment.NewLine;
               
                // Print text on the output screen
                Console.WriteLine(text);
            }

            // ExEnd:ExtractTableText
        }
    }
}