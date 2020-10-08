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
            // ExFor:Document
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to create a document with a text.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Page page = new Page(doc);
            
            // Initialize Outline class object
            Outline outline = new Outline(doc);
            
            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement(doc);

            // Initialize TextStyle class object and set formatting properties
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            
            // Initialize RichText class object and apply text style
            RichText text = new RichText(doc) { Text = "Hello OneNote text!", ParagraphStyle = textStyle };

            // Add RichText node
            outlineElem.AppendChildLast(text);
            
            // Add OutlineElement node
            outline.AppendChildLast(outlineElem);
            
            // Add Outline node
            page.AppendChildLast(outline);
            
            // Add Page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "CreateDocWithSimpleRichText_out.one";
            doc.Save(dataDir);
            
            // ExEnd:CreateDocWithSimpleRichText

            Console.WriteLine("\nOneNote document created successfully with simple rich text.\nFile saved at " + dataDir);
        }
    }
}
