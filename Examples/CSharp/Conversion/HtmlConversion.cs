using Aspose.Note.Importing;
using System;
using System.IO;

namespace Aspose.Note.Examples.CSharp.Conversion
{
    public class HtmlConversion
    {
        public static void Run()
        {
            ConvertOneToHtml();
            ConvertHtmlToOne();
        }

        public static void ConvertOneToHtml()
        {
            // ExStart:ConvertOneToHtml
            // ExFor:Document.Save(System.IO.Stream, SaveFormat)
            // ExSummary:Shows how to convert a OneNote document to HTML format.
            var dataDir = RunExamples.GetDataDir_Conversion_Html();

            var oneFilePath = Path.Combine(dataDir, "sample.one");
            var htmlFilePath = Path.Combine(dataDir, "output.html");

            // Convert OneNote to HTML
            var doc = new Document(oneFilePath);
            doc.Save(htmlFilePath, SaveFormat.Html);

            // ExEnd:ConvertOneToHtml

            Console.WriteLine("\nOneNote document converted to HTML successfully.");
        }

        public static void ConvertHtmlToOne()
        {
            // ExStart:ConvertHtmlToOne
            // ExFor:Document.Import(System.String, HtmlImportOptions)
            // ExSummary:Shows how to import an HTML file into a OneNote document.
            var dataDir = RunExamples.GetDataDir_Conversion_Html();

            var htmlFilePath = Path.Combine(dataDir, "sample.html");
            var oneFilePath = Path.Combine(dataDir, "output.one");

            // Import HTML into OneNote
            var doc = new Document();
            doc.Import(htmlFilePath, new HtmlImportOptions());
            doc.Save(oneFilePath);

            // ExEnd:ConvertHtmlToOne

            Console.WriteLine("\nHTML document imported into OneNote successfully.");
        }
    }
}
