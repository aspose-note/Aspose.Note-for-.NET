using System;
using System.Globalization;
using System.IO;
using Aspose.Note;
using System.Drawing;
using System.Collections.Generic;

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
            Aspose.Note.Document doc = new Aspose.Note.Document();

            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            // Initialize Outline class object
            Outline outline = new Outline(doc);

            // Initialize TextStyle class object and set formatting properties
            ParagraphStyle defaultStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Initialize OutlineElement class objects and apply bullets
            OutlineElement outlineElem1 = new OutlineElement(doc) { NumberList = new NumberList("*", "Arial", 10) };

            // Initialize RichText class object and apply text style
            RichText text1 = new RichText(doc) { Text = "First", ParagraphStyle = defaultStyle };
            outlineElem1.AppendChildLast(text1);

            OutlineElement outlineElem2 = new OutlineElement(doc) { NumberList = new NumberList("*", "Arial", 10) };
            RichText text2 = new RichText(doc) { Text = "Second", ParagraphStyle = defaultStyle };
            outlineElem2.AppendChildLast(text2);

            OutlineElement outlineElem3 = new OutlineElement(doc) { NumberList = new NumberList("*", "Arial", 10) };
            RichText text3 = new RichText(doc) { Text = "Third", ParagraphStyle = defaultStyle };
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
