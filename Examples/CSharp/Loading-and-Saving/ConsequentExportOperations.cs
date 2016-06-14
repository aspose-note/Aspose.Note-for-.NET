
using System.IO;
using Aspose.Note;
using System;
using System.Drawing;
using System.Globalization;
namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class ConsequentExportOperations
    {
        public static void Run()
        {
            // ExStart:ConsequentExportOperations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize the new Document
            Document doc = new Document() { AutomaticLayoutChangesDetectionEnabled = false };
            // Initialize the new Page
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Default style for all text in the document.
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc) { Text = "Title text.", DefaultStyle = textStyle },
                TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), DefaultStyle = textStyle },
                TitleTime = new RichText(doc) { Text = "12:34", DefaultStyle = textStyle }
            };
            // Append page node
            doc.AppendChild(page);
            // Save OneNote document in the HTML format
            doc.Save("ConsequentExportOperations_out_.html");
            // Save OneNote document in the PDF format
            doc.Save("ConsequentExportOperations_out_.pdf");
            // Save OneNote document in the JPG format
            doc.Save("ConsequentExportOperations_out_.jpg");
            // Set text font size
            textStyle.FontSize = 11;
            // Detect layout changes manually
            doc.DetectLayoutChanges();
            // Save OneNote document in the BMP format
            doc.Save("ConsequentExportOperations_out_.bmp");
            // ExEnd:ConsequentExportOperations
            Console.WriteLine("\nConsequent export operations performed successfully.");
        }
    }
}