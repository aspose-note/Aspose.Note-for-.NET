using System;
using System.Globalization;
using Aspose.Note;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class CreateTitleMsStyle
    {
        public static void Run()
        {
            // ExStart:CreateTitleMsStyle
            string dataDir = RunExamples.GetDataDir_Text();
            string outputPath = dataDir + "CreateTitleMsStyle_out.one";

            var doc = new Document();
            var page = new Page(doc);

            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc)
                {
                    Text = "Title text.",
                    DefaultStyle = TextStyle.DefaultMsOneNoteTitleTextStyle
                },
                TitleDate = new RichText(doc)
                {
                    Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture),
                    DefaultStyle = TextStyle.DefaultMsOneNoteTitleDateStyle
                },
                TitleTime = new RichText(doc)
                {
                    Text = "12:34",
                    DefaultStyle = TextStyle.DefaultMsOneNoteTitleTimeStyle
                }
            };

            doc.AppendChild(page);

            doc.Save(outputPath);
            // ExEnd:CreateTitleMsStyle
            Console.WriteLine("\nPage title setup successfully in microsoft OneNote style .\nFile saved at " + outputPath);
        }
    }
}
