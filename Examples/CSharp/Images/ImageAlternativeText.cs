using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Aspose.Note.Examples.CSharp.Images
{
    public class ImageAlternativeText
    {
        public static void Run()
        {
            // ExStart:ImageAlternativeText
            // ExFor:Document
            // ExFor:Image
            // ExFor:Image.AlternativeTextTitle
            // ExFor:Image.AlternativeTextDescription
            // ExSummary:Shows how to set text description for an image.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            var document = new Document();
            var page = new Page(document);
            var image = new Image(document, dataDir + "image.jpg")
                        {
                            AlternativeTextTitle = "This is an image's title!",
                            AlternativeTextDescription = "And this is an image's description!"
                        };
            page.AppendChildLast(image);
            document.AppendChildLast(page);

            dataDir = dataDir + "ImageAlternativeText_out.one";
            document.Save(dataDir);
            
            // ExEnd:ImageAlternativeText 
            
            Console.WriteLine("\nImage alternative text setup successfully.\nFile saved at " + dataDir); 
        }
    }
}