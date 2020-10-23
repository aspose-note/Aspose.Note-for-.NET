using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Drawing;
using System.Globalization;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class CreateDocWithPageTitle
    {
        public static void Run()
        {
            // ExStart:CreateDocWithPageTitle
            // ExFor:Document
            // ExFor:Page
            // ExFor:Page.Title
            // ExFor:Title
            // ExFor:Title.TitleText
            // ExFor:Title.TitleDate
            // ExFor:Title.TitleTime
            // ExSummary:Shows how to create a document with titled page.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Create an object of the Document class
            Document doc = new Aspose.Note.Document();

            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            // Default style for all text in the document.
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };

            // Set page title properties
            page.Title = new Title(doc)
                         {
                             TitleText = new RichText(doc) { Text = "Title text.", ParagraphStyle = textStyle },
                             TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), ParagraphStyle = textStyle },
                             TitleTime = new RichText(doc) { Text = "12:34", ParagraphStyle = textStyle }
                         };

            // Append Page node in the document
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "CreateDocWithPageTitle_out.one";
            doc.Save(dataDir);

            // ExEnd:CreateDocWithPageTitle

            Console.WriteLine("\nOneNote document created successfully with page title.\nFile saved at " + dataDir);

        }
    }
}
