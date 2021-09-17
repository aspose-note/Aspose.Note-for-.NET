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
            // ExFor:Document
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:PdfSaveOptions
            // ExFor:SaveOptions.PageIndex
            // ExFor:SaveOptions.PageCount
            // ExSummary:Shows how to save a document in pdf format.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Initialize PdfSaveOptions object
            PdfSaveOptions opts = new PdfSaveOptions
                                      {
                                          // Set page index of first page to be saved
                                          PageIndex = 0,

                                          // Set page count
                                          PageCount = 1,
                                      };

            // Save the document as PDF
            dataDir = dataDir + "SaveRangeOfPagesAsPDF_out.pdf";
            oneFile.Save(dataDir, opts);

            // ExEnd:SaveRangeOfPagesAsPDF

            Console.WriteLine("\nOneNote specified page range converted successfully to PDF.\nFile saved at " + dataDir);
        }
    }
}
