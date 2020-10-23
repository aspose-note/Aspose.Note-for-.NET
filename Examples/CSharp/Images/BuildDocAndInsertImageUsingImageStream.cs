using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Aspose.Note.Examples.CSharp.Images
{
    public class BuildDocAndInsertImageUsingImageStream
    {
        public static void Run()
        {
            // ExStart:BuildDocAndInsertImageUsingImageStream
            // ExFor:Document
            // ExFor:Image
            // ExFor:Image.Alignment
            // ExSummary:Shows how to add an image from stream to a document.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            Outline outline1 = new Outline(doc);
            OutlineElement outlineElem1 = new OutlineElement(doc);

            using (FileStream fs = File.OpenRead(dataDir + "image.jpg"))
            {

                // Load the second image using the image name, extension and stream.
                Aspose.Note.Image image1 = new Aspose.Note.Image(doc, "Penguins.jpg", fs)
                                               {
                                                   // Set image alignment
                                                   Alignment = HorizontalAlignment.Right
                                               };

                outlineElem1.AppendChildLast(image1);
            }

            outline1.AppendChildLast(outlineElem1);
            page.AppendChildLast(outline1);

            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "BuildDocAndInsertImageUsingImageStream_out.one";
            doc.Save(dataDir);

            // ExEnd:BuildDocAndInsertImageUsingImageStream 
            
            Console.WriteLine("\nDocument created and image using image stream inserted successfully.\nFile saved at " + dataDir); 
        }
    }
}