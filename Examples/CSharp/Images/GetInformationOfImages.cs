
using System.IO;
using Aspose.Note;
using System.Collections.Generic;
using System;

namespace CSharp.Images
{
    public class GetInformationOfImages
    {
        public static void Run()
        {
            // ExStart:GetInformationOfImages
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
                Console.WriteLine("Extension: {0}", image.Extension);
                Console.WriteLine("LastModifiedTime: {0}", image.LastModifiedTime);
                Console.WriteLine();
            }
            // ExEnd:GetInformationOfImages
        }
    }
}