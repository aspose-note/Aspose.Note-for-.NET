using System;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Pages
{
    public class CreateDocWithRootAndSubPages
    {
        public static void Run()
        {
            // ExStart:CreateDocWithRootAndSubPages
            // ExFor:Page
            // ExFor:Page.Level
            // ExSummary:Shows how to add a page with a subpage.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object and set its level
            Page page1 = new Page() { Level = 1 };

            // Initialize Page class object and set its level
            Page page2 = new Page() { Level = 2 };

            // Initialize Page class object and set its level
            Page page3 = new Page() { Level = 1 };

            /*---------- Adding nodes to first Page ----------*/
            Outline outline = new Outline();
            OutlineElement outlineElem = new OutlineElement();
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            RichText text = new RichText() { Text = "First page.", ParagraphStyle = textStyle };
            outlineElem.AppendChildLast(text);
            outline.AppendChildLast(outlineElem);
            page1.AppendChildLast(outline);

            /*---------- Adding nodes to second Page ----------*/
            var outline2 = new Outline();
            var outlineElem2 = new OutlineElement();
            var textStyle2 = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            var text2 = new RichText() { Text = "Second page.", ParagraphStyle = textStyle2 };
            outlineElem2.AppendChildLast(text2);
            outline2.AppendChildLast(outlineElem2);
            page2.AppendChildLast(outline2);

            /*---------- Adding nodes to third Page ----------*/
            var outline3 = new Outline();
            var outlineElem3 = new OutlineElement();
            var textStyle3 = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            var text3 = new RichText() { Text = "Third page.", ParagraphStyle = textStyle3 };
            outlineElem3.AppendChildLast(text3);
            outline3.AppendChildLast(outlineElem3);
            page3.AppendChildLast(outline3);

            /*---------- Add pages to the OneNote Document ----------*/
            doc.AppendChildLast(page1);
            doc.AppendChildLast(page2);
            doc.AppendChildLast(page3);

            // Save OneNote document
            dataDir = dataDir + "CreateDocWithRootAndSubPages_out.one";
            doc.Save(dataDir);
            
            // ExEnd:CreateDocWithRootAndSubPages

            Console.WriteLine("\nOneNote document created successfully with root and sub level pages.\nFile saved at " + dataDir);
        }
    }
}