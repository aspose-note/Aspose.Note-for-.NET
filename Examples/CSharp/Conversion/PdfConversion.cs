using System;
using System.IO;

namespace Aspose.Note.Examples.CSharp.Conversion
{
    public class PdfConversion
    {
        public static void Run()
        {
            ConvertPdfToOne();
        }

        public static void ConvertPdfToOne()
        {
            // ExStart:ConvertPdfToOne
            // ExFor:Document.Import(System.String)
            // ExSummary:Shows how to import a PDF file into a OneNote document.
            var dataDir = RunExamples.GetDataDir_Conversion_Pdf();

            // Specify paths
            var pdfFilePath = Path.Combine(dataDir, "sample.pdf");
            var oneFilePath = Path.Combine(dataDir, "output.one");

            // Import PDF into OneNote
            var document = new Document();
            document.Import(pdfFilePath);
            document.Save(oneFilePath);

            // ExEnd:ConvertPdfToOne

            Console.WriteLine("\nPDF document imported into OneNote successfully.");
        }
    }
}
