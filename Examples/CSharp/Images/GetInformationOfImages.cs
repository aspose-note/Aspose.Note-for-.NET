using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System;

namespace Aspose.Note.Examples.CSharp.Images
{
    public class GetInformationOfImages
    {
        public static void Run()
        {
            // ExStart:GetInformationOfImages
            // ExFor:Document
            // ExFor:CompositeNode`1.GetChildNodes
            // ExFor:Image
            // ExFor:Image.Width
            // ExFor:Image.Height
            // ExFor:Image.OriginalWidth
            // ExFor:Image.OriginalHeight
            // ExFor:Image.FileName
            // ExFor:Image.LastModifiedTime
            // ExSummary:Shows how to get image's meta information.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Images();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get all Image nodes
            IList<Aspose.Note.Image> images = oneFile.GetChildNodes<Aspose.Note.Image>();

            foreach (Aspose.Note.Image image in images)
            {
                Console.WriteLine("Width: {0}", image.Width);
                Console.WriteLine("Height: {0}", image.Height);
                Console.WriteLine("OriginalWidth: {0}", image.OriginalWidth);
                Console.WriteLine("OriginalHeight: {0}", image.OriginalHeight);
                Console.WriteLine("FileName: {0}", image.FileName);
                Console.WriteLine("LastModifiedTime: {0}", image.LastModifiedTime);
                Console.WriteLine();
            }

            // ExEnd:GetInformationOfImages
        }
    }
}