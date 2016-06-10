using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
using System;
namespace CSharp.Images
{
    public class ImageAlternativeText
    {
        public static void Run()
        {
            // ExStart:ImageAlternativeText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            var document = new Document();
            var page = new Page(document);
            var image = new Aspose.Note.Image(document, dataDir + "image.jpg");
            image.AlternativeText = "ImageAlternativeText";
            page.AppendChild(image);
            document.AppendChild(page);

            dataDir = dataDir + "ImageAlternativeText_out_.one";
            document.Save(dataDir);
            // ExEnd:ImageAlternativeText 
            Console.WriteLine("\nImage alternative text setup successfully.\nFile saved at " + dataDir); 
        }
    }
}