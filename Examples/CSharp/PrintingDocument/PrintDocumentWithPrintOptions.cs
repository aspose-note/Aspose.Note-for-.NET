using Aspose.Note.Saving;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.PrintingDocument
{
    class PrintDocumentWithPrintOptions
    {
        // ExStart:PrintDocumentWithPrintOptions
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            var document = new Aspose.Note.Document(dataDir + "Aspose.one");

            var printerSettings = new PrinterSettings() { FromPage = 0, ToPage = 10 };
            printerSettings.DefaultPageSettings.Landscape = true;
            printerSettings.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 150, 50);

            document.Print(new PrintOptions()
            {
                PrinterSettings = printerSettings,
                Resolution = 1200,
                PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm(),
                DocumentName = "Test.one"
            });
        }
        // ExStart:PrintDocumentWithPrintOptions
    }
}
