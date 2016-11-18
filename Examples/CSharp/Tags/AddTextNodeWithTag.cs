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
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            RichText text = new RichText(doc) { Text = "OneNote text.", DefaultStyle = textStyle };
            text.Tags.Add(new NoteTag
            {
                Icon = TagIcon.YellowStar,
            });

            // Add text node
            outlineElem.AppendChild(text);
            // Add outline element node
            outline.AppendChild(outlineElem);
            // Add outline node
            page.AppendChild(outline);
            // Add page node
            doc.AppendChild(page);

            dataDir = dataDir + "AddTextNodeWithTag_out.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:AddTextNodeWithTag
            Console.WriteLine("\nText node with tag added successfully.\nFile saved at " + dataDir);
        }
    }
}