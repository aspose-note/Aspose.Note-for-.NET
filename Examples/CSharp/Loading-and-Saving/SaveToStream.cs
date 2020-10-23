using System.IO;
using Aspose.Note;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class SaveToStream
    {
        public static void Run()
        {
            // ExStart:SaveToStream
            // ExFor:Document
            // ExFor:Document.Save(System.IO.Stream, Aspose.Note.SaveFormat)
            // ExSummary:Shows how to save a document to a stream.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            MemoryStream dstStream = new MemoryStream();
            doc.Save(dstStream, SaveFormat.Pdf);

            // Rewind the stream position back to zero so it is ready for next reader.
            dstStream.Seek(0, SeekOrigin.Begin);
            
            // ExEnd:SaveToStream

            Console.WriteLine("\nOneNote document saved successfully to stream.");
        }
    }
}