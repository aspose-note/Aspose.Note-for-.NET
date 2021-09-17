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
            // ExFor:Image
            // ExFor:Image.Tags
            // ExFor:NoteTag
            // ExFor:Page
            // ExFor:Outline
            // ExFor:OutlineElement
            // ExSummary:Shows how to add new image with tag.

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
            outlineElem.AppendChildLast(image);
            image.Tags.Add(NoteTag.CreateYellowStar());

            // Add outline element node
            outline.AppendChildLast(outlineElem);

            // Add outline node
            page.AppendChildLast(outline);

            // Add page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "AddImageNodeWithTag_out.one";
            doc.Save(dataDir);

            // ExEnd:AddImageNodeWithTag

            Console.WriteLine("\nImage node with tag added successfully.\nFile saved at " + dataDir);
        }
    }
}