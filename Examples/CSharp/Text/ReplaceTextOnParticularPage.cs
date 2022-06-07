// -----------------------------------------------------------------------
//  <copyright file="ReplaceTextOnParticularPage.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.Collections.Generic;

    public class ReplaceTextOnParticularPage
    {
        public static void Run()
        {
            // ExStart:ReplaceTextOnParticularPage
            // ExFor:Page
            // ExFor:Page.GetChildNodes
            // ExFor:RichText
            // ExFor:RichText.Replace(System.String,System.String)
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
                    // Replace text of a shape
                    richText.Replace(kvp.Key, kvp.Value);
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