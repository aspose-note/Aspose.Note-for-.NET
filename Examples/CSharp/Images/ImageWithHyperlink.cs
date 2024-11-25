﻿namespace Aspose.Note.Examples.CSharp.Images
{
    class ImageWithHyperlink
    {
        public static void Run()
        {
            // ExStart: ImageWithHyperlink
            // ExFor:Document
            // ExFor:Image
            // ExFor:Image.HyperlinkUrl
            // ExSummary:Shows how to bind a hyperlink to an image.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images(); 
            
            var document = new Document();

            var page = new Page();

            var image = new Image(dataDir + "image.jpg") { HyperlinkUrl = "http://image.com" };

            page.AppendChildLast(image);
            
            document.AppendChildLast(page);
            
            document.Save(dataDir + "Image with Hyperlink_out.one");
            
            // ExEnd: ImageWithHyperlink
        }
    }
}
