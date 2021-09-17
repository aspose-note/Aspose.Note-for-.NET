using System.Drawing;
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tags
{
    public class AddTextNodeWithTag
    {
        public static void Run()
        {
            // ExStart:AddTextNodeWithTag
            // ExFor:NoteTag
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExFor:RichText.ParagraphStyle
            // ExSummary:Shows how to add new paragraph with tag.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            // Initialize Outline class object
            Outline outline = new Outline(doc);

            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement(doc);
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            RichText text = new RichText(doc) { Text = "OneNote text.", ParagraphStyle = textStyle };
            text.Tags.Add(NoteTag.CreateYellowStar());

            // Add text node
            outlineElem.AppendChildLast(text);
            
            // Add outline element node
            outline.AppendChildLast(outlineElem);
            
            // Add outline node
            page.AppendChildLast(outline);
            
            // Add page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "AddTextNodeWithTag_out.one";
            doc.Save(dataDir);

            // ExEnd:AddTextNodeWithTag

            Console.WriteLine("\nText node with tag added successfully.\nFile saved at " + dataDir);
        }
    }
}