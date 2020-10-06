
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
            // ExFor:Page.GetChildNodes
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to get all text from the page.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get list of page nodes
            var page = oneFile.GetChildNodes<Page>().FirstOrDefault();

            if (page != null)
            {
                // Retrieve text
                string text = string.Join(Environment.NewLine, page.GetChildNodes<RichText>().Select(e => e.Text)) + Environment.NewLine;
                // Print text on the output screen
                Console.WriteLine(text);
            }

            // ExEnd:ExtractingTextFromAPage
        }
    }
}