using System;

namespace Aspose.Note.Examples.CSharp.Images
{
    public class BuildDocAndInsertImage
    {
        public static void Run()
        {
            // ExStart:BuildDocAndInsertImage
            // ExFor:Document
            // ExFor:Image
            // ExFor:Image.Alignment
            // ExSummary:Shows how to add an image from file to a document.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Page page = new Page();

            // Initialize Outline class object and set offset properties
            Outline outline = new Outline();

            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement();
            
            // Load an image by the file path.
            Image image = new Image(dataDir + "image.jpg")
                                      {
                                          // Set image alignment
                                          Alignment = HorizontalAlignment.Right
                                      };

            // Add image
            outlineElem.AppendChildLast(image);
            
            // Add outline elements
            outline.AppendChildLast(outlineElem);
            
            // Add Outline node
            page.AppendChildLast(outline);
            
            // Add Page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "BuildDocAndInsertImage_out.one";
            doc.Save(dataDir);
            
            // ExEnd:BuildDocAndInsertImage 
            
            Console.WriteLine("\nDocument created and image inserted successfully.\nFile saved at " + dataDir); 
        }
    }
}