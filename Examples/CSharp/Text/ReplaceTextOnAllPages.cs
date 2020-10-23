using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class ReplaceTextOnAllPages
    {
        public static void Run()
        {
            // ExStart:ReplaceTextOnAllPages
            // ExFor:Page
            // ExFor:Page.GetChildNodes
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to pass through all pages and make a replacement in the text.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            Dictionary<string, string> replacements = new Dictionary<string, string>();
            replacements.Add("Some task here", "New Text Here");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get all RichText nodes
            IList<RichText> textNodes = oneFile.GetChildNodes<RichText>();

            foreach (RichText richText in textNodes)
            {
                foreach (KeyValuePair<string, string> kvp in replacements)
                {
                    if (richText != null)
                    {
                        // Replace text of a shape
                        richText.Text = richText.Text.Replace(kvp.Key, kvp.Value);
                    }
                }
            }

            dataDir = dataDir + "ReplaceTextOnAllPages_out.pdf";

            // Save to any supported file format
            oneFile.Save(dataDir, SaveFormat.Pdf);

            // ExEnd:ReplaceTextOnAllPages

            Console.WriteLine("\nText replaced successfully on all pages.\nFile saved at " + dataDir); 
        }
    }
}