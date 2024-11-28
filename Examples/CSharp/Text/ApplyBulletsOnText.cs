using System;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class ApplyBulletsOnText
    {
        public static void Run()
        {
            // ExStart:ApplyBulletsOnText
            // ExFor:ParagraphStyle
            // ExFor:Style.FontColor
            // ExFor:Style.FontName
            // ExFor:Style.FontSize
            // ExFor:Page
            // ExFor:Outline
            // ExFor:OutlineElement
            // ExFor:OutlineElement.NumberList
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:RichText.Text
            // ExSummary:Shows how to insert new bulleted lis.

            string dataDir = RunExamples.GetDataDir_Text();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Page page = new Page();

            // Initialize Outline class object
            Outline outline = new Outline();

            // Initialize TextStyle class object and set formatting properties
            ParagraphStyle defaultStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Initialize OutlineElement class objects and apply bullets
            OutlineElement outlineElem1 = new OutlineElement() { NumberList = new NumberList("*", "Arial", 10) };

            // Initialize RichText class object and apply text style
            RichText text1 = new RichText() { Text = "First", ParagraphStyle = defaultStyle };
            outlineElem1.AppendChildLast(text1);

            OutlineElement outlineElem2 = new OutlineElement() { NumberList = new NumberList("*", "Arial", 10) };
            RichText text2 = new RichText(  ) { Text = "Second", ParagraphStyle = defaultStyle };
            outlineElem2.AppendChildLast(text2);

            OutlineElement outlineElem3 = new OutlineElement() { NumberList = new NumberList("*", "Arial", 10) };
            RichText text3 = new RichText() { Text = "Third", ParagraphStyle = defaultStyle };
            outlineElem3.AppendChildLast(text3);

            // Add outline elements
            outline.AppendChildLast(outlineElem1);
            outline.AppendChildLast(outlineElem2);
            outline.AppendChildLast(outlineElem3);

            // Add Outline node
            page.AppendChildLast(outline);
            // Add Page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "ApplyBulletsOnText_out.one"; 
            doc.Save(dataDir);

            // ExEnd:ApplyBulletsOnText
            Console.WriteLine("\nBullets applied successfully on a text.\nFile saved at " + dataDir);
        }
    }
}
