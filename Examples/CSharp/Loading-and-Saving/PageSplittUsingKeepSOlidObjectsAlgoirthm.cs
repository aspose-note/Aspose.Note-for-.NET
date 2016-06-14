
using System.IO;
using Aspose.Note;
using System;
using Aspose.Note.Saving;
namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class PageSplittUsingKeepSOlidObjectsAlgoirthm
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");
            // ExStart:KeepSOlidObjectsAlgoirthm-1
            var pdfSaveOptions = new PdfSaveOptions();
            pdfSaveOptions.PageSplittingAlgorithm = new AlwaysSplitObjectsAlgorithm();
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm();
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm();
            // ExEnd:KeepSOlidObjectsAlgoirthm-1

            // ExStart:KeepSOlidObjectsAlgoirthm-2
            float heightLimitOfClonedPart = 500;
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm(heightLimitOfClonedPart);
            // Or
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(heightLimitOfClonedPart);
            // ExEnd:KeepSOlidObjectsAlgoirthm-2

            // ExStart:KeepSOlidObjectsAlgoirthm-3
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(100);
            // ExEnd:KeepSOlidObjectsAlgoirthm-3
            // Or
            // ExStart:KeepSOlidObjectsAlgoirthm-4
            pdfSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(400);
            // ExEnd:KeepSOlidObjectsAlgoirthm-4

            dataDir = dataDir + "UsingKeepSOlidObjectsAlgoirthm_out_.pdf";
            doc.Save(dataDir);
            Console.WriteLine("\nPage splitt successfully using keep solid objects algoirthm method.");
        }
    }
}