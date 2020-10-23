using System.IO;
using Aspose.Note;
using System;
using Aspose.Note.Saving;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class PageSplitUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm
    {
        public static void Run()
        {
            // ExStart:PageSplitUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm
            // ExFor:Document
            // ExFor:PdfSaveOptions
            // ExFor:PdfSaveOptions.PageSplittingAlgorithm
            // ExFor:KeepPartAndCloneSolidObjectToNextPageAlgorithm
            // ExSummary:When long OneNote pages are saved in pdf format they are split across pages. The sample shows how to configure the splitting logic of objects located on page's breaks.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");
           
            var pdfSaveOptions = new PdfSaveOptions();

            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm(100);
            // or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm(400);

            dataDir = dataDir + "PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm_out.pdf";
            doc.Save(dataDir);

            // ExEnd:PageSplitUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm

            Console.WriteLine("\nPage split successfully using keep part and clone solid object to next page algorithm.");
        }
    }
}