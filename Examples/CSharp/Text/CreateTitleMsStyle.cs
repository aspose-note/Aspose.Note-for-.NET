using System;
using System.Globalization;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class CreateTitleMsStyle
    {
        public static void Run()
        {
            // ExStart:CreateTitleMsStyle
            // ExFor:Page
            // ExFor:Page.Title
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:RichText.Text
            // ExFor:Title
            // ExFor:Title.TitleText
            // ExFor:Title.TitleDate
            // ExFor:Title.TitleTime
            // ExSummary:Shows how to set a title for a page.

            string dataDir = RunExamples.GetDataDir_Text();
            string outputPath = dataDir + "CreateTitleMsStyle_out.one";

            var doc = new Document();
            var page = new Page();

            page.Title = new Title()
            {
                TitleText = new RichText()
                {
                    Text = "Title text.",
                    ParagraphStyle = ParagraphStyle.Default
                },
                TitleDate = new RichText()
                {
                    Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture),
                    ParagraphStyle = ParagraphStyle.Default
                },
                TitleTime = new RichText()
                {
                    Text = "12:34",
                    ParagraphStyle = ParagraphStyle.Default
                }
            };

            doc.AppendChildLast(page);

            doc.Save(outputPath);

            // ExEnd:CreateTitleMsStyle

            Console.WriteLine("\nPage title setup successfully in microsoft OneNote style .\nFile saved at " + outputPath);
        }
    }
}
