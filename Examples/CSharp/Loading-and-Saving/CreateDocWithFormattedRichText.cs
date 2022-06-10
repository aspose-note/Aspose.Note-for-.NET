// -----------------------------------------------------------------------
//  <copyright file="CreateDocWithFormattedRichText.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    using System;
    using System.Drawing;

    public class CreateDocWithFormattedRichText
    {
        public static void Run()
        {
            // ExStart:CreateDocWithFormattedRichText
            // ExFor:SaveOptions.PageIndex
            // ExFor:RichText.Append(System.String,TextStyle)
            // ExSummary:Shows how to create a document with formatted rich text.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Create an object of the Document class
            Document doc = new Document();

            // Initialize Page class object
            Page page = new Page();

            // Initialize Title class object
            Title title = new Title();

            // Initialize TextStyle class object and set formatting properties
            ParagraphStyle defaultTextStyle = new ParagraphStyle
                                                  {
                                                      FontColor = Color.Black,
                                                      FontName = "Arial",
                                                      FontSize = 10
                                                  };

            RichText titleText = new RichText() { ParagraphStyle = defaultTextStyle }.Append("Title!");
            Outline outline = new Outline()
                                  {
                                      VerticalOffset = 100,
                                      HorizontalOffset = 100
                                  };
            OutlineElement outlineElem = new OutlineElement();
        
            TextStyle textStyleForHelloWord = new TextStyle
                                                  {
                                                      FontColor = Color.Red,
                                                      FontName = "Arial",
                                                      FontSize = 10,
                                                  };
            
            TextStyle textStyleForOneNoteWord = new TextStyle
                                                    {
                                                        FontColor = Color.Green,
                                                        FontName = "Calibri",
                                                        FontSize = 10,
                                                        IsItalic = true,
                                                    };

            TextStyle textStyleForTextWord = new TextStyle
                                                 {
                                                     FontColor = Color.Blue,
                                                     FontName = "Arial",
                                                     FontSize = 15,
                                                     IsBold = true,
                                                     IsItalic = true,
                                                 };
        
            RichText text = new RichText() { ParagraphStyle = defaultTextStyle }
                                .Append("Hello", textStyleForHelloWord)
                                .Append(" OneNote", textStyleForOneNoteWord)
                                .Append(" text", textStyleForTextWord)
                                .Append("!", TextStyle.Default);

            title.TitleText = titleText;

            // Set page title
            page.Title = title;
            
            // Add RichText node
            outlineElem.AppendChildLast(text);
            
            // Add OutlineElement node
            outline.AppendChildLast(outlineElem);
            
            // Add Outline node
            page.AppendChildLast(outline);
            
            // Add Page node
            doc.AppendChildLast(page);

            // Save OneNote document
            dataDir = dataDir + "CreateDocWithFormattedRichText_out.one";
            doc.Save(dataDir);

            // ExEnd:CreateDocWithFormattedRichText
            
            Console.WriteLine("\nOneNote document created successfully with formatted rich text.\nFile saved at " + dataDir);
        }
    }
}
