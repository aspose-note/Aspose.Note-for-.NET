// -----------------------------------------------------------------------
//  <copyright file="ChangePageTitleStyle.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.IO;
    using System.Linq;

    public class ChangePageTitleStyle
    {
        public static void Run()
        {
            // ExStart
            // ExFor:TextStyle
            // ExFor:Style.FontSize
            // ExFor:Style.IsBold
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:ParagraphStyle
            // ExSummary:Let's emphasize page's titles among other headers by increasing font's size.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");

            // Iterate through page's titles.
            foreach (var title in document.Select(e => e.Title.TitleText))
            {
                title.ParagraphStyle.FontSize = 24;
                title.ParagraphStyle.IsBold = true;

                foreach (var run in title.TextRuns)
                {
                    run.Style.FontSize = 24;
                    run.Style.IsBold = true;
                }
            }

            document.Save(Path.Combine(dataDir, "ChangePageTitleStyle.pdf"));

            // ExEnd
            Console.WriteLine("\nTitle's styles are changed successfully.");
        }
    }
}
