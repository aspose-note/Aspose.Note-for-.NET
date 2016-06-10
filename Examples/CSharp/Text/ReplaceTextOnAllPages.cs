using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System;
namespace CSharp.Text
{
    public class ReplaceTextOnAllPages
    {
        public static void Run()
        {
            // ExStart:ReplaceTextOnAllPages
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
                    if (richText != null && richText.Text.Contains(kvp.Key))
                    {
                        // Replace text of a shape
                        richText.Text = richText.Text.Replace(kvp.Key, kvp.Value);
                    }
                }
            }

            dataDir = dataDir + "ReplaceTextOnAllPages_out_.pdf";

            // Save to any supported file format
            oneFile.Save(dataDir, SaveFormat.Pdf);
            // ExEnd:ReplaceTextOnAllPages
            Console.WriteLine("\nText replaced successfully on all pages.\nFile saved at " + dataDir); 
        }
    }
}