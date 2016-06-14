using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
using System;
namespace Aspose.Note.Examples.CSharp.Images
{
    public class InsertImage
    {
        public static void Run()
        {            
            // ExStart:InsertImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Load document from the stream.
            Document doc = new Document(dataDir + "Aspose.one");
            // Get the first page of the document.
            Aspose.Note.Page page = doc.FirstChild;

            // Load an image from the file.
            Aspose.Note.Image image = new Aspose.Note.Image(doc, dataDir + "image.jpg");
            // Change the image's size according to your needs (optional).
            image.Width = 100;
            image.Height = 100;
            // Set the image's location in the page (optional).
            image.VerticalOffset = 400;
            image.HorizontalOffset = 100;
            // Set image alignment
            image.Alignment = HorizontalAlignment.Right;
            // Add the image to the page.
            page.AppendChild(image);            
            // ExEnd:InsertImage 
            Console.WriteLine("\nImage inserted successfully to OneNote document.");
        }
    }
}