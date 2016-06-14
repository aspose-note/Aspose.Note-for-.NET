using System.Drawing;
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tags
{
    public class AddImageNodeWithTag
    {
        public static void Run()
        {
            // ExStart:AddImageNodeWithTag
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
            // Load an image
            Aspose.Note.Image image = new Aspose.Note.Image(doc, dataDir + "icon.jpg");
            // Insert image in the document node
            outlineElem.AppendChild(image);
            image.Tags.Add(new NoteTag
            {
                Icon = TagIcon.YellowStar,
            });
            // Add outline element node
            outline.AppendChild(outlineElem);
            // Add outline node
            page.AppendChild(outline);
            // Add page node
            doc.AppendChild(page);

            dataDir = dataDir + "AddImageNodeWithTag_out_.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:AddImageNodeWithTag
            Console.WriteLine("\nImage node with tag added successfully.\nFile saved at " + dataDir);
        }
    }
}