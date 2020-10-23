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
            // ExFor:Document
            // ExFor:Image
            // ExFor:Image.Width
            // ExFor:Image.Height
            // ExFor:Image.HorizontalOffset
            // ExFor:Image.VerticalOffset
            // ExFor:Image.Alignment
            // ExSummary:Shows how to add an image from file to a document with user defined properties.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Load document from the stream.
            Document doc = new Document(dataDir + "Aspose.one");
            
            // Get the first page of the document.
            Aspose.Note.Page page = doc.FirstChild;

            // Load an image from the file.
            Aspose.Note.Image image = new Aspose.Note.Image(doc, dataDir + "image.jpg")
                                      {
                                          // Change the image's size according to your needs (optional).
                                          Width = 100,
                                          Height = 100,

                                          // Set the image's location in the page (optional).
                                          HorizontalOffset = 100,
                                          VerticalOffset = 400,

                                          // Set image alignment
                                          Alignment = HorizontalAlignment.Right
                                      };

            // Add the image to the page.
            page.AppendChildLast(image);            
            
            // ExEnd:InsertImage 
            
            Console.WriteLine("\nImage inserted successfully to OneNote document.");
        }
    }
}