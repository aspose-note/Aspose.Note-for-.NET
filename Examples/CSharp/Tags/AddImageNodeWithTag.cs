using System;

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
            Page page = new Page();

            // Initialize Outline class object
            Outline outline = new Outline();

            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement();

            // Load an image
            Image image = new Image(dataDir + "icon.jpg");

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