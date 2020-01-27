
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class ExtractingTextFromAPage
    {
        public static void Run()
        {
            // ExStart:ExtractingTextFromAPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get list of page nodes
            IList<Node> nodes = oneFile.GetChildNodes<Node>();

            if (nodes.Count > 0 && nodes[0].NodeType == NodeType.Page)
            {
                Page page = (Page)nodes[0];
                // Retrieve text
                string text = string.Join(Environment.NewLine, page.GetChildNodes<RichText>().Select(e => e.Text)) + Environment.NewLine;
                // Print text on the output screen
                Console.WriteLine(text);
            }
            // ExEnd:ExtractingTextFromAPage
        }
    }
}