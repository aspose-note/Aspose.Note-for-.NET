using System;
using System.Globalization;
using System.IO;
using Aspose.Note;
using System.Drawing;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class InsertChineseNumberList
    {
        public static void Run()
        {
            // ExStart:InsertChineseNumberList
            string dataDir = RunExamples.GetDataDir_Text();

            // Initialize OneNote document
            Aspose.Note.Document doc = new Aspose.Note.Document();
            // Initialize OneNote page
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            Outline outline = new Outline(doc);
            // Apply text style settings
            ParagraphStyle defaultStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Numbers in the same outline are automatically incremented.
            OutlineElement outlineElem1 = new OutlineElement(doc) { NumberList = new NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10) };
            RichText text1 = new RichText(doc) { Text = "First", ParagraphStyle = defaultStyle };
            outlineElem1.AppendChildLast(text1);
            //------------------------
            OutlineElement outlineElem2 = new OutlineElement(doc) { NumberList = new NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10) };
            RichText text2 = new RichText(doc) { Text = "Second", ParagraphStyle = defaultStyle };
            outlineElem2.AppendChildLast(text2);
            //------------------------
            OutlineElement outlineElem3 = new OutlineElement(doc) { NumberList = new NumberList("{0})", NumberFormat.ChineseCounting, "Arial", 10) };
            RichText text3 = new RichText(doc) { Text = "Third", ParagraphStyle = defaultStyle };
            outlineElem3.AppendChildLast(text3);
            //------------------------
            outline.AppendChildLast(outlineElem1);
            outline.AppendChildLast(outlineElem2);
            outline.AppendChildLast(outlineElem3);
            page.AppendChildLast(outline);
            doc.AppendChildLast(page);

            dataDir = dataDir + "InsertChineseNumberList_out.one"; 
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:InsertChineseNumberList
            Console.WriteLine("\nChinese number list inserted successfully.\nFile saved at " + dataDir);
        }
    }
}
