using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class SaveRangeOfPagesAsPDF
    {
        public static void Run()
        {
            // ExStart:SaveRangeOfPagesAsPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // ExStart:LoadOneNote
            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");
            // ExEnd:LoadOneNote

            // Initialize PdfSaveOptions object
            PdfSaveOptions opts = new PdfSaveOptions();

            // Set page index
            opts.PageIndex = 0;

            // Set page count
            opts.PageCount = 1;

            dataDir = dataDir + "SaveRangeOfPagesAsPDF_out_.pdf";

            // Save the document as PDF
            oneFile.Save(dataDir, opts);
            // ExEnd:SaveRangeOfPagesAsPDF
            Console.WriteLine("\nOneNote specified page range converted successfully to PDF.\nFile saved at " + dataDir);
        }
    }
}