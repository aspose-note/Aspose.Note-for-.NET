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
        public static void Run()
        {
            // ExStart:PrintDocumentWithPrintOptions
            // ExFor:Document
            // ExFor:Document.Print
            // ExFor:PrintOptions
            // ExFor:PrintOptions.PrinterSettings
            // ExFor:PrintOptions.Resolution
            // ExFor:PrintOptions.PageSplittingAlgorithm
            // ExFor:PrintOptions.DocumentName
            // ExFor:KeepSolidObjectsAlgorithm
            // ExSummary:Shows how to sent document to a printer using standard Windows dialog with specified options.

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

            // ExEnd:PrintDocumentWithPrintOptions
        }
    }
}
