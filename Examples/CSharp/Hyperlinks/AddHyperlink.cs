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
            // ExFor:Document
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:RichText.Styles
            // ExFor:RichText.Text
            // ExFor:TextStyle
            // ExFor:TextStyle.FontColor
            // ExFor:TextStyle.FontName
            // ExFor:TextStyle.FontSize
            // ExFor:TextStyle.RunIndex
            // ExFor:TextStyle.IsHyperlink
            // ExFor:TextStyle.HyperlinkAddress
            // ExSummary:Shows how to bind a hyperlink to a text.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tasks();

            // Create an object of the Document class
            Document doc = new Document();


            RichText titleText = new RichText(doc)
                                 {
                                     Text = "Title!",
                                     ParagraphStyle = ParagraphStyle.Default
                                 };

            Outline outline = new Outline(doc)
                              {
                                  MaxWidth = 200,
                                  MaxHeight = 200,
                                  VerticalOffset = 100,
                                  HorizontalOffset = 100
                              };

            TextStyle textStyleRed = new TextStyle
                                     {
                                         FontColor = Color.Red,
                                         FontName = "Arial",
                                         FontSize = 10,

                                         // This style will be applied to 0-7 characters.
                                         RunIndex = 8 
                                     };

            TextStyle textStyleHyperlink = new TextStyle
                                          {
                                              // This style will be applied to 8-16 characters.
                                              RunIndex = 17,
                                              IsHyperlink = true,
                                              HyperlinkAddress = "www.google.com"
                                          };

            RichText text = new RichText(doc)
                            {
                                Text = "This is hyperlink. This text is not a hyperlink.",
                                ParagraphStyle = ParagraphStyle.Default,
                                Styles = { textStyleRed, textStyleHyperlink }
                            };

            OutlineElement outlineElem = new OutlineElement(doc);
            outlineElem.AppendChildLast(text);
            
            // Add outline elements
            outline.AppendChildLast(outlineElem);

            // Initialize Title class object
            Title title = new Title(doc) { TitleText = titleText };

            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc) { Title = title };

            // Add Outline node
            page.AppendChildLast(outline);

            // Add Page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "AddHyperlink_out.one";
            doc.Save(dataDir);
            
            // ExEnd:AddHyperlink
            
            Console.WriteLine("\nHyperlink added successfully.\nFile saved at " + dataDir);
        }
    }
}