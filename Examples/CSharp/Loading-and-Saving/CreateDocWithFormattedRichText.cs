using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Drawing;
namespace CSharp.Loading_Saving
{
    public class CreateDocWithFormattedRichText
    {
        public static void Run()
        {
            // ExStart:CreateDocWithFormattedRichText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Initialize Title class object
            Title title = new Title(doc);
            // Initialize TextStyle class object and set formatting properties
            TextStyle defaultTextStyle = new TextStyle
            {
                FontColor = Color.Black,
                FontName = "Arial",
                FontSize = 10
            };

            RichText titleText = new RichText(doc)
            {
                Text = "Title!",
                DefaultStyle = defaultTextStyle
            };
            Outline outline = new Outline(doc)
            {
                VerticalOffset = 100,
                HorizontalOffset = 100
            };
            OutlineElement outlineElem = new OutlineElement(doc);
            // RunIndex = 5 means the style will be applied only to 0-4 characters. ("Hello")
            TextStyle textStyleForHelloWord = new TextStyle
            {
                FontColor = Color.Red,
                FontName = "Arial",
                FontSize = 10,
                RunIndex = 5,
            };
            // RunIndex = 13 means the style will be applied only to 5-12 characters. (" OneNote")
            TextStyle textStyleForOneNoteWord = new TextStyle
            {
                FontColor = Color.Green,
                FontName = "Calibri",
                FontSize = 10,
                IsItalic = true,
                RunIndex = 13,
            };
            // RunIndex = 18 means the style will be applied only to 13-17 characters. (" text").
            // Other characters ("!") will have the default style.
            TextStyle textStyleForTextWord = new TextStyle
            {
                FontColor = Color.Blue,
                FontName = "Arial",
                FontSize = 15,
                IsBold = true,
                IsItalic = true,
                RunIndex = 18,
            };
            RichText text = new RichText(doc)
            {
                Text = "Hello OneNote text!",
                DefaultStyle = defaultTextStyle,
                Styles = { textStyleForHelloWord, textStyleForOneNoteWord, textStyleForTextWord }
            };

            title.TitleText = titleText;
            // Set page title
            page.Title = title;
            // Add RichText node
            outlineElem.AppendChild(text);
            // Add OutlineElement node
            outline.AppendChild(outlineElem);
            // Add Outline node
            page.AppendChild(outline);
            // Add Page node
            doc.AppendChild(page);

            dataDir = dataDir + "CreateDocWithFormattedRichText_out_.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:CreateDocWithFormattedRichText
            Console.WriteLine("\nOneNote document created successfully with formatted rich text.\nFile saved at " + dataDir);

        }
    }
}
