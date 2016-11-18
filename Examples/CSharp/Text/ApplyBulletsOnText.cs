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
            string dataDir = RunExamples.GetDataDir_Text();

            // Create an object of the Document class
            Aspose.Note.Document doc = new Aspose.Note.Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Initialize Outline class object
            Outline outline = new Outline(doc);
            // Initialize TextStyle class object and set formatting properties
            TextStyle defaultStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Initialize OutlineElement class objects and apply bullets
            OutlineElement outlineElem1 = new OutlineElement(doc) { NumberList = new NumberList("*", "Arial", 10) };
            // Initialize RichText class object and apply text style
            RichText text1 = new RichText(doc) { Text = "First", DefaultStyle = defaultStyle };
            outlineElem1.AppendChild(text1);

            OutlineElement outlineElem2 = new OutlineElement(doc) { NumberList = new NumberList("*", "Arial", 10) };
            RichText text2 = new RichText(doc) { Text = "Second", DefaultStyle = defaultStyle };
            outlineElem2.AppendChild(text2);

            OutlineElement outlineElem3 = new OutlineElement(doc) { NumberList = new NumberList("*", "Arial", 10) };
            RichText text3 = new RichText(doc) { Text = "Third", DefaultStyle = defaultStyle };
            outlineElem3.AppendChild(text3);

            // Add outline elements
            outline.AppendChild(outlineElem1);
            outline.AppendChild(outlineElem2);
            outline.AppendChild(outlineElem3);

            // Add Outline node
            page.AppendChild(outline);
            // Add Page node
            doc.AppendChild(page);

            dataDir = dataDir + "ApplyBulletsOnText_out.one"; 
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:ApplyBulletsOnText
            Console.WriteLine("\nBullets applied successfully on a text.\nFile saved at " + dataDir);
        }
    }
}
