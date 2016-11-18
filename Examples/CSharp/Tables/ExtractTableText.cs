using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class ExtractTableText
    {
        public static void Run()
        {
            // ExStart:ExtractTableText
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
                string text = table.GetText();
                // Print text on the output screen
                Console.WriteLine(text);
            }
            // ExEnd:ExtractTableText
        }
    }
}