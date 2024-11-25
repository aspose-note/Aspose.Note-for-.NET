using System;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class InsertChineseNumberList
    {
        public static void Run()
        {
            // ExStart:InsertChineseNumberList
            // ExFor:NumberList
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
            // ExSummary:Shows how to insert new list with chinese numbering.

            string dataDir = RunExamples.GetDataDir_Text();

            // Initialize OneNote document
            Document doc = new Document();

            // Initialize OneNote page
            Page page = new Page();
            Outline outline = new Outline();

            // Apply text style settings
            ParagraphStyle defaultStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Numbers in the same outline are automatically incremented.
            OutlineElement outlineElem1 = new OutlineElement() { NumberList = new NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10) };
            RichText text1 = new RichText() { Text = "First", ParagraphStyle = defaultStyle };
            outlineElem1.AppendChildLast(text1);
            
            //------------------------
            OutlineElement outlineElem2 = new OutlineElement() { NumberList = new NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10) };
            RichText text2 = new RichText() { Text = "Second", ParagraphStyle = defaultStyle };
            outlineElem2.AppendChildLast(text2);
            
            //------------------------
            OutlineElement outlineElem3 = new OutlineElement() { NumberList = new NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10) };
            RichText text3 = new RichText() { Text = "Third", ParagraphStyle = defaultStyle };
            outlineElem3.AppendChildLast(text3);

            //------------------------
            outline.AppendChildLast(outlineElem1);
            outline.AppendChildLast(outlineElem2);
            outline.AppendChildLast(outlineElem3);
            page.AppendChildLast(outline);
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "InsertChineseNumberList_out.one"; 
            doc.Save(dataDir);
            
            // ExEnd:InsertChineseNumberList

            Console.WriteLine("\nChinese number list inserted successfully.\nFile saved at " + dataDir);
        }
    }
}
