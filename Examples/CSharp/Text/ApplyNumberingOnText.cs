using System;
using System.Globalization;
using System.IO;
using Aspose.Note;
using System.Drawing;
using System.Collections.Generic;
namespace CSharp.Text
{
    public class ApplyNumberingOnText
    {
        public static void Run()
        {
            // ExStart:ApplyNumberingOnText
            string dataDir = RunExamples.GetDataDir_Text();
            
            // Create an object of the Document class
            Document doc = new Document();
            
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            
            // Initialize Outline class object
            Outline outline = new Outline(doc);
            
            // Initialize TextStyle class object and set formatting properties
            TextStyle defaultStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Initialize OutlineElement class objects and apply numbering
            // Numbers in the same outline are automatically incremented.
            OutlineElement outlineElem1 = new OutlineElement(doc) { NumberList = new NumberList("{0})", NumberFormat.DecimalNumbers, "Arial", 10) };
            RichText text1 = new RichText(doc) { Text = "First", DefaultStyle = defaultStyle };
            outlineElem1.AppendChild(text1);

            OutlineElement outlineElem2 = new OutlineElement(doc) { NumberList = new NumberList("{0})", NumberFormat.DecimalNumbers, "Arial", 10) };
            RichText text2 = new RichText(doc) { Text = "Second", DefaultStyle = defaultStyle };
            outlineElem2.AppendChild(text2);

            OutlineElement outlineElem3 = new OutlineElement(doc) { NumberList = new NumberList("{0})", NumberFormat.DecimalNumbers, "Arial", 10) };
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

            dataDir = dataDir + "ApplyNumberingOnText_out_.one"; 
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:ApplyNumberingOnText
            Console.WriteLine("\nNumbering applied successfully on a text.\nFile saved at " + dataDir);
        }
    }
}
