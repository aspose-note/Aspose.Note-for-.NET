using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class CreateDocWithSimpleRichText
    {
        public static void Run()
        {
            // ExStart:CreateDocWithSimpleRichText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Initialize Outline class object
            Outline outline = new Outline(doc);
            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement(doc);

            // Initialize TextStyle class object and set formatting properties
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            // Initialize RichText class object and apply text style
            RichText text = new RichText(doc) { Text = "Hello OneNote text!", DefaultStyle = textStyle };

            // Add RichText node
            outlineElem.AppendChild(text);
            // Add OutlineElement node
            outline.AppendChild(outlineElem);
            // Add Outline node
            page.AppendChild(outline);
            // Add Page node
            doc.AppendChild(page);

            dataDir = dataDir + "CreateDocWithSimpleRichText_out.one";
            // Save OneNote document
            doc.Save(dataDir);
            // ExEnd:CreateDocWithSimpleRichText

            Console.WriteLine("\nOneNote document created successfully with simple rich text.\nFile saved at " + dataDir);

        }
    }
}
