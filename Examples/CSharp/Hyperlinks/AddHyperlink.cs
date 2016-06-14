
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;
namespace Aspose.Note.Examples.CSharp.Hyperlinks
{
    public class AddHyperlink
    {
        public static void Run()
        {
            // ExStart:AddHyperlink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tasks();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Initialize Title class object
            Title title = new Title(doc);

            TextStyle defaultTextStyle = new TextStyle
            {
                FontName = "Arial",
                FontSize = 10,
                FontColor = SystemColors.WindowText
            };
            RichText titleText = new RichText(doc)
            {
                Text = "Title!",
                DefaultStyle = defaultTextStyle
            };
            Outline outline = new Outline(doc)
            {
                MaxWidth = 200,
                MaxHeight = 200,
                VerticalOffset = 100,
                HorizontalOffset = 100
            };
            OutlineElement outlineElem = new OutlineElement(doc);
            TextStyle textStyleRed = new TextStyle
            {
                FontColor = Color.Red,
                FontName = "Arial",
                FontSize = 10,
                RunIndex = 8//this style will be applied to 0-7 characters.
            };
            TextStyle textStyleHyperlink = new TextStyle
            {
                RunIndex = 17,//this style will be applied to 8-16 characters.
                IsHyperlink = true,
                HyperlinkAddress = "www.google.com"
            };
            RichText text = new RichText(doc)
            {
                Text = "This is hyperlink. This text is not a hyperlink.",
                DefaultStyle = defaultTextStyle,
                Styles = { textStyleRed, textStyleHyperlink }
            };

            title.TitleText = titleText;
            page.Title = title;
            outlineElem.AppendChild(text);
            // Add outline elements
            outline.AppendChild(outlineElem);
            // Add Outline node
            page.AppendChild(outline);
            // Add Page node
            doc.AppendChild(page);

            dataDir = dataDir + "AddHyperlink_out_.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:AddHyperlink
            Console.WriteLine("\nHyperlink added successfully.\nFile saved at " + dataDir);
        
        }
    }
}