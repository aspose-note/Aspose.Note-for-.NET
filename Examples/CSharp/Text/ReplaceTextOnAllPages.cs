// -----------------------------------------------------------------------
//  <copyright file="ReplaceTextOnAllPages.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.Collections.Generic;

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
                    // Replace text of a shape
                    richText.Replace(kvp.Key, kvp.Value);
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