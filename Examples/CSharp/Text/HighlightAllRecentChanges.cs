using System;
using System.Linq;

namespace Aspose.Note.Examples.CSharp.Text
{
    using System.Drawing;
    using System.IO;

    public class HighlightAllRecentChanges
    {
        public static void Run()
        {
            //ExStart
            //ExFor:TextStyle
            //ExFor:TextStyle.FontSize
            //ExFor:TextStyle.IsBold
            //ExFor:RichText
            //ExFor:RichText.LastModifiedTime
            //ExFor:RichText.ParagraphStyle
            //ExFor:RichText.Styles
            //ExFor:ParagraphStyle
            //ExFor:ParagraphStyle.FontSize
            //ExFor:ParagraphStyle.IsBold
            //ExSummary:Let's emphasize latest text's changes by highlighting.

            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");

            // Get RichText nodes modified last week.
            var richTextNodes = document.GetChildNodes<RichText>().Where(e => e.LastModifiedTime >= DateTime.Today.Subtract(TimeSpan.FromDays(7)));

            //foreach (var node in richTextNodes)
            //{
            //    // Set highlight color
            //    node.ParagraphStyle.Highlight = Color.DarkGreen;
            //    foreach (TextStyle style in node.Styles)
            //    {
            //        // Set highlight color
            //        style.Highlight = Color.DarkSeaGreen;
            //    }
            //}

            document.Save(Path.Combine(dataDir, "HighlightAllRecentChanges.pdf"));

            //ExEnd

            Console.WriteLine("\nText's recent changes are highlighted successfully.");
        }
    }
}
