using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
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
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            // Initialize Outline class object and set offset properties
            Outline outline = new Outline(doc);

            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement(doc);
            
            // Load an image by the file path.
            Aspose.Note.Image image = new Aspose.Note.Image(doc, dataDir + "image.jpg")
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