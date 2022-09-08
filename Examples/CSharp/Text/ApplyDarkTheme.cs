// -----------------------------------------------------------------------
//  <copyright file="ApplyDarkTheme.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;
    using System.Drawing;
    using System.IO;

    class ApplyDarkTheme
    {
        public static void Run()
        {
            // ExStart:ApplyDarkTheme
            // ExFor:Document
            // ExFor:Document.Save(System.IO.Stream, Aspose.Note.SaveFormat)
            // ExFor:Page.BackgroundColor
            // ExFor:RichText.ParagraphStyle
            // ExFor:Style.FontColor
            // ExSummary:Shows how to apply Dark theme style to a Document.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document doc = new Document(Path.Combine(dataDir, "Aspose.one"));

            foreach (var page in doc)
            {
                page.BackgroundColor = Color.Black;
            }

            foreach (var node in doc.GetChildNodes<RichText>())
            {
                var c = node.ParagraphStyle.FontColor;
                if (c.IsEmpty || Math.Abs(c.R - Color.Black.R) + Math.Abs(c.G - Color.Black.G) + Math.Abs(c.B - Color.Black.B) <= 30)
                {
                    node.ParagraphStyle.FontColor = Color.White;
                }
            }

            doc.Save(Path.Combine(dataDir, "AsposeDarkTheme.pdf"));

            // ExEnd:ApplyDarkTheme

            Console.WriteLine("\nOneNote document saved successfully.");
        }
    }
}
