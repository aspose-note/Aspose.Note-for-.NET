
using System.IO;
using Aspose.Note;
using System;
using Aspose.Note.Saving;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class PageSplitUsingKeepSolidObjectsAlgorithm
    {
        public static void Run()
        {

            // ExStart:KeepSolidObjectsAlgorithm
            // ExFor:Document
            // ExFor:PdfSaveOptions
            // ExFor:PdfSaveOptions.PageSplittingAlgorithm
            // ExFor:AlwaysSplitObjectsAlgorithm
            // ExFor:KeepPartAndCloneSolidObjectToNextPageAlgorithm
            // ExFor:KeepSolidObjectsAlgorithm
            // ExSummary:When long OneNote pages are saved in pdf format they are split across pages. The example shows how to configure the splitting logic of objects located on page's breaks.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");
            var pdfSaveOptions = new PdfSaveOptions();
            pdfSaveOptions.PageSplittingAlgorithm = new AlwaysSplitObjectsAlgorithm();
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm();
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm();

            float heightLimitOfClonedPart = 500;
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm(heightLimitOfClonedPart);
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(heightLimitOfClonedPart);

            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(100);
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(400);

            dataDir = dataDir + "UsingKeepSOlidObjectsAlgorithm_out.pdf";
            doc.Save(dataDir);

            // ExEnd: KeepSolidObjectsAlgorithm

            Console.WriteLine("\nPage split successfully using keep solid objects algorithm method.");
        }
    }
}