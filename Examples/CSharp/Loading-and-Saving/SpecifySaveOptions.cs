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
            // ExFor:Document
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:PdfSaveOptions
            // ExFor:PdfSaveOptions.PageIndex
            // ExFor:PdfSaveOptions.PageCount
            // ExFor:PdfSaveOptions.ImageCompression
            // ExFor:PdfSaveOptions.JpegQuality
            // ExSummary:Shows how to save a document in pdf format using specific settings.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            // Initialize PdfSaveOptions object
            PdfSaveOptions opts = new PdfSaveOptions
                                      {
                                          // Set page index
                                          PageIndex = 2,

                                          // Set page count
                                          PageCount = 3,

                                          // Specify image's compression if required
                                          ImageCompression = Saving.Pdf.PdfImageCompression.Jpeg,
                                          
                                          // Specify compressions quality for JPEG compression
                                          JpegQuality = 90
                                      };


            dataDir = dataDir + "Document.SaveWithOptions_out.pdf";
            doc.Save(dataDir, opts);
            
            // ExEnd:SpecifySaveOptions
            
            Console.WriteLine("\nOneNote document saved successfully.\nFile saved at " + dataDir);
        }
    }
}