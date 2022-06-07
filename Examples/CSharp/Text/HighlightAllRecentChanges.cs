// -----------------------------------------------------------------------
//  <copyright file="HighlightAllRecentChanges.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    public class HighlightAllRecentChanges
    {
        public static void Run()
        {
            // ExStart
            // ExFor:TextStyle
            // ExFor:Style.FontSize
            // ExFor:Style.IsBold
            // ExFor:RichText
            // ExFor:RichText.LastModifiedTime
            // ExFor:RichText.ParagraphStyle
            // ExFor:ParagraphStyle
            // ExSummary:Let's emphasize latest text's changes by highlighting.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");

            // Get RichText nodes modified last week.
            var richTextNodes = document.GetChildNodes<RichText>().Where(e => e.LastModifiedTime >= DateTime.Today.Subtract(TimeSpan.FromDays(7)));

            foreach (var node in richTextNodes)
            {
                // Set highlight color
                node.ParagraphStyle.Highlight = Color.DarkGreen;
                foreach (var run in node.TextRuns)
                {
                    // Set highlight color
                    run.Style.Highlight = Color.DarkSeaGreen;
                }
            }

            document.Save(Path.Combine(dataDir, "HighlightAllRecentChanges.pdf"));

            // ExEnd
            Console.WriteLine("\nText's recent changes are highlighted successfully.");
        }
    }
}
