// -----------------------------------------------------------------------
//  <copyright file="AddHyperlink.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Hyperlinks
{
    using System;
    using System.Drawing;

    public class AddHyperlink
    {
        public static void Run()
        {
            // ExStart:AddHyperlink
            // ExFor:Document
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:RichText.Text
            // ExFor:RichText.Append(System.String)
            // ExFor:RichText.Append(System.String,TextStyle)
            // ExFor:TextStyle
            // ExFor:Style.FontColor
            // ExFor:Style.FontName
            // ExFor:Style.FontSize
            // ExFor:TextStyle.IsHyperlink
            // ExFor:TextStyle.HyperlinkAddress
            // ExSummary:Shows how to bind a hyperlink to a text.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tasks();

            // Create an object of the Document class
            Document doc = new Document();


            RichText titleText = new RichText() { ParagraphStyle = ParagraphStyle.Default }.Append("Title!");

            Outline outline = new Outline()
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
                                         };

            TextStyle textStyleHyperlink = new TextStyle
                                               {
                                                   IsHyperlink = true,
                                                   HyperlinkAddress = "www.google.com"
                                               };

            RichText text = new RichText() { ParagraphStyle = ParagraphStyle.Default }
                                .Append("This is ", textStyleRed)
                                .Append("hyperlink", textStyleHyperlink)
                                .Append(". This text is not a hyperlink.", TextStyle.Default);

            OutlineElement outlineElem = new OutlineElement();
            outlineElem.AppendChildLast(text);
            
            // Add outline elements
            outline.AppendChildLast(outlineElem);

            // Initialize Title class object
            Title title = new Title() { TitleText = titleText };

            // Initialize Page class object
            Page page = new Note.Page() { Title = title };

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