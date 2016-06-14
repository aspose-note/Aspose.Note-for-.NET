using System.IO;
using Aspose.Note;
using System;
using System.Drawing;
using System.Globalization;
using Aspose.Note.Saving;
namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class CreateOneNoteDocAndSaveToHTML
    {
        public static void Run()
        {
            // ExStart:CreateOneNoteDocAndSaveToHTML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize OneNote document
            Document doc = new Document();
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            
            // Default style for all text in the document.
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc) { Text = "Title text.", DefaultStyle = textStyle },
                TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), DefaultStyle = textStyle },
                TitleTime = new RichText(doc) { Text = "12:34", DefaultStyle = textStyle }
            };
            doc.AppendChild(page);
            dataDir = dataDir + "CreateOneNoteDocAndSaveToHTML_out_.html";
            // Save as HTML format
            doc.Save(dataDir);
            // ExEnd:CreateOneNoteDocAndSaveToHTML
            Console.WriteLine("\nOneNote document created successfully.\nFile saved at " + dataDir);
        }
        public static void CreateAndSavePageRange()
        {
            // ExStart:CreateAndSavePageRange
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize OneNote document
            Document doc = new Document();

            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Default style for all text in the document.
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc) { Text = "Title text.", DefaultStyle = textStyle },
                TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), DefaultStyle = textStyle },
                TitleTime = new RichText(doc) { Text = "12:34", DefaultStyle = textStyle }
            };
            doc.AppendChild(page);

            dataDir = dataDir + "CreateAndSavePageRange_out_.html";
            // Save as HTML format
            doc.Save(dataDir, new HtmlSaveOptions
            {
                PageCount = 1,
                PageIndex = 0
            });
            // ExEnd:CreateAndSavePageRange
            Console.WriteLine("\nOneNote document created successfully and saved as page range.\nFile saved at " + dataDir);
        }
    }
}