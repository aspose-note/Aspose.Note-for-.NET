using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;
namespace CSharp.Pages
{
    public class CreateDocWithRootAndSubPages
    {
        public static void Run()
        {
            // ExStart:CreateDocWithRootAndSubPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object and set its level
            Aspose.Note.Page page1 = new Aspose.Note.Page(doc) { Level = 1 };
            // Initialize Page class object and set its level
            Aspose.Note.Page page2 = new Aspose.Note.Page(doc) { Level = 2 };
            // Initialize Page class object and set its level
            Aspose.Note.Page page3 = new Aspose.Note.Page(doc) { Level = 1 };

            /*---------- Adding nodes to first Page ----------*/
            Outline outline = new Outline(doc);
            OutlineElement outlineElem = new OutlineElement(doc);
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            RichText text = new RichText(doc) { Text = "First page.", DefaultStyle = textStyle };
            outlineElem.AppendChild(text);
            outline.AppendChild(outlineElem);
            page1.AppendChild(outline);

            /*---------- Adding nodes to second Page ----------*/
            var outline2 = new Outline(doc);
            var outlineElem2 = new OutlineElement(doc);
            var textStyle2 = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            var text2 = new RichText(doc) { Text = "Second page.", DefaultStyle = textStyle2 };
            outlineElem2.AppendChild(text2);
            outline2.AppendChild(outlineElem2);
            page2.AppendChild(outline2);

            /*---------- Adding nodes to third Page ----------*/
            var outline3 = new Outline(doc);
            var outlineElem3 = new OutlineElement(doc);
            var textStyle3 = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            var text3 = new RichText(doc) { Text = "Third page.", DefaultStyle = textStyle3 };
            outlineElem3.AppendChild(text3);
            outline3.AppendChild(outlineElem3);
            page3.AppendChild(outline3);

            /*---------- Add pages to the OneNote Document ----------*/
            doc.AppendChild(page1);
            doc.AppendChild(page2);
            doc.AppendChild(page3);

            dataDir = dataDir + "CreateDocWithRootAndSubPages_out_.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:CreateDocWithRootAndSubPages
            Console.WriteLine("\nOneNote document created successfully with root and sub level pages.\nFile saved at " + dataDir);
        }
    }
}