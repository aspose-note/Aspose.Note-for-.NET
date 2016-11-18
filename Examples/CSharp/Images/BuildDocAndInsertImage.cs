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
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Initialize Outline class object and set offset properties
            Outline outline = new Outline(doc) { VerticalOffset = 0, HorizontalOffset = 0 };
            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement(doc);
            // Load an image by the file path.
            Aspose.Note.Image image = new Aspose.Note.Image(doc, dataDir + "image.jpg");
            // Set image alignment
            image.Alignment = HorizontalAlignment.Right;
            // Add image
            outlineElem.AppendChild(image);
            // Add outline elements
            outline.AppendChild(outlineElem);
            // Add Outline node
            page.AppendChild(outline);
            // Add Page node
            doc.AppendChild(page);

            dataDir = dataDir + "BuildDocAndInsertImage_out.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:BuildDocAndInsertImage 
            Console.WriteLine("\nDocument created and image inserted successfully.\nFile saved at " + dataDir); 
        }
    }
}