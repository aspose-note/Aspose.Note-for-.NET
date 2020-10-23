using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class ReplaceTextOnParticularPage
    {
        public static void Run()
        {
            // ExStart:ReplaceTextOnParticularPage
            // ExFor:Page
            // ExFor:Page.GetChildNodes
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to pass through page's text and make a replacement.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            Dictionary<string, string> replacements = new Dictionary<string, string>();
            replacements.Add("voice over", "voice over new text");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            IList<Page> pageNodes = oneFile.GetChildNodes<Page>();


            // Get all RichText nodes
            IList<RichText> textNodes = pageNodes[0].GetChildNodes<RichText>();

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

            // Save to any supported file format
            dataDir = dataDir + "ReplaceTextOnParticularPage_out.pdf";
            oneFile.Save(dataDir, SaveFormat.Pdf);
            
            // ExEnd:ReplaceTextOnParticularPage

            Console.WriteLine("\nText replaced successfully on a particular page.\nFile saved at " + dataDir);
        }
    }
}