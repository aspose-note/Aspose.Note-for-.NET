
using System.IO;
using Aspose.Note;
using System;
using Aspose.Note.Saving;
namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");
           
            var pdfSaveOptions = new PdfSaveOptions();

            // ExStart:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-1
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm(100);
            // ExEnd:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-1
            // Or
            // ExStart:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-2
            pdfSaveOptions.PageSplittingAlgorithm = new KeepPartAndCloneSolidObjectToNextPageAlgorithm(400);
            // ExEnd:PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.-2

            dataDir = dataDir + "PageSplittUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm_out_.pdf";
            doc.Save(dataDir);
            Console.WriteLine("\nPage splitt successfully using keep part and clone solid object to next page algorithm.");
        }
    }
}