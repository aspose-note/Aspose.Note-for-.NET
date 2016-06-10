
using System.IO;
using Aspose.Note;
using System;

namespace CSharp.Loading_Saving
{
    public class SaveToStream
    {
        public static void Run()
        {
            // ExStart:SaveToStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            MemoryStream dstStream = new MemoryStream();
            doc.Save(dstStream, SaveFormat.Pdf);

            // Rewind the stream position back to zero so it is ready for next reader.
            dstStream.Position = 0;
            // ExEnd:SaveToStream
            Console.WriteLine("\nOneNote document saved successfully to stream.");
        }
    }
}