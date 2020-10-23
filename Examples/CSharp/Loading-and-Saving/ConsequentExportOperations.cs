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
            // ExFor:Document
            // ExFor:Document.AutomaticLayoutChangesDetectionEnabled
            // ExFor:Document.DetectLayoutChanges
            // ExFor:Page
            // ExFor:Page.Title
            // ExFor:Title
            // ExFor:Title.TitleText
            // ExFor:Title.TitleDate
            // ExFor:Title.TitleTime
            // ExSummary:Shows how to save a document in different formats.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize the new Document
            Document doc = new Document() { AutomaticLayoutChangesDetectionEnabled = false };
            
            // Initialize the new Page
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            
            // Default style for all text in the document.
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title(doc)
                         {
                             TitleText = new RichText(doc) { Text = "Title text.", ParagraphStyle = textStyle },
                             TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), ParagraphStyle = textStyle },
                             TitleTime = new RichText(doc) { Text = "12:34", ParagraphStyle = textStyle }
                         };

            // Append page node
            doc.AppendChildLast(page);

            // Save OneNote document in different formats, set text font size and detect layout changes manually.
            doc.Save(dataDir + "ConsequentExportOperations_out.html");            
            doc.Save(dataDir + "ConsequentExportOperations_out.pdf");            
            doc.Save(dataDir + "ConsequentExportOperations_out.jpg");            
            textStyle.FontSize = 11;           
            doc.DetectLayoutChanges();            
            doc.Save(dataDir + "ConsequentExportOperations_out.bmp");

            // ExEnd:ConsequentExportOperations

            Console.WriteLine("\nConsequent export operations performed successfully.");
        }
    }
}