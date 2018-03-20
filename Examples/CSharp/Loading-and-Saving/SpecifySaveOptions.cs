using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class SpecifySaveOptions
    {
        public static void Run()
        {
            // ExStart:SpecifySaveOptions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            // Initialize PdfSaveOptions object
            PdfSaveOptions opts = new PdfSaveOptions();
            // Set page index
            opts.PageIndex = 2;
            // Set page count
            opts.PageCount = 3;

            //specify compression if required
            opts.ImageCompression = Saving.Pdf.PdfImageCompression.Jpeg;
            opts.JpegQuality = 90;

            dataDir = dataDir + "Document.SaveWithOptions_out.pdf";
            doc.Save(dataDir, opts);
            // ExEnd:SpecifySaveOptions
            Console.WriteLine("\nOneNote document saved successfully.\nFile saved at " + dataDir);
        }
    }
}