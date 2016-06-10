using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
using System;
namespace CSharp.Images
{
    public class BuildDocAndInsertImageUsingImageStream
    {
        public static void Run()
        {
            // ExStart:BuildDocAndInsertImageUsingImageStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            Outline outline1 = new Outline(doc) { VerticalOffset = 600, HorizontalOffset = 0 };
            OutlineElement outlineElem1 = new OutlineElement(doc);
            FileStream fs = File.OpenRead(dataDir +  "image.jpg");
            // Load the second image using the image name, extension and stream.
            Aspose.Note.Image image1 = new Aspose.Note.Image(doc, "Penguins", "jpg", fs);
            // Set image alignment
            image1.Alignment = HorizontalAlignment.Right;

            outlineElem1.AppendChild(image1);
            outline1.AppendChild(outlineElem1);
            page.AppendChild(outline1);

            doc.AppendChild(page);

            dataDir = dataDir + "BuildDocAndInsertImageUsingImageStream_out_.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:BuildDocAndInsertImageUsingImageStream 
            Console.WriteLine("\nDocument created and image using image stream inserted successfully.\nFile saved at " + dataDir); 
        }
    }
}