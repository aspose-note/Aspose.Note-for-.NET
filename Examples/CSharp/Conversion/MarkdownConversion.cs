using System.IO;
using System;
using Aspose.Html.Converters;
using Aspose.Note.Importing;
using Aspose.Html.Saving;

namespace Aspose.Note.Examples.CSharp.Conversion
{
    public class MarkdownConversion
    {
        public static void Run()
        {
            ConvertOneToMarkdown();
            ConvertMarkdownToOne();
        }

        public static void ConvertOneToMarkdown()
        {
            // ExStart:ConvertOneToMarkdown
            // ExFor:Document.Save(System.IO.Stream, SaveFormat)
            // ExSummary:Shows how to convert a OneNote document to Markdown format.
            var dataDir = RunExamples.GetDataDir_Conversion_Markdown();

            var oneFilePath = Path.Combine(dataDir, "sample.one");
            var mdFilePath = Path.Combine(dataDir, "output.md");
            var htmlFilePath = Path.Combine(dataDir, "temp.html");

            // Convert OneNote to HTML
            var document = new Document(oneFilePath);
            document.Save(htmlFilePath, SaveFormat.Html);

            // Convert HTML to Markdown
            Converter.ConvertHTML(htmlFilePath, new MarkdownSaveOptions(), mdFilePath);

            Console.WriteLine("\nOneNote document converted to Markdown successfully.");
            // ExEnd:ConvertOneToMarkdown
        }

        public static void ConvertMarkdownToOne()
        {
            // ExStart:ConvertMarkdownToOne
            // ExFor:Document.Import(System.String, HtmlImportOptions)
            // ExSummary:Shows how to import a Markdown file into a OneNote document.
            var dataDir = RunExamples.GetDataDir_Conversion_Markdown();

            var mdFilePath = Path.Combine(dataDir, "sample.md");
            var htmlFilePath = Path.Combine(dataDir, "temp.html");
            var oneFilePath = Path.Combine(dataDir, "output.one");

            // Convert Markdown to HTML
            Converter.ConvertMarkdown(mdFilePath, htmlFilePath);

            // Import HTML into OneNote
            var document = new Document();
            document.Import(htmlFilePath, new HtmlImportOptions());
            document.Save(oneFilePath);

            Console.WriteLine("\nMarkdown document imported into OneNote successfully.");
            // ExEnd:ConvertMarkdownToOne
        }
    }
}
