// -----------------------------------------------------------------------
//  <copyright file="SetDefaultParagraphStyle.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.IO;

    class SetDefaultParagraphStyle
    {
        public static void Run()
        {
            // ExStart:SetDefaultParagraphStyle
            // ExFor:ParagraphStyle
            // ExFor:ParagraphStyle.FontName 
            // ExFor:ParagraphStyle.FontSize
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:RichText.Text
            // ExFor:TextStyle
            // ExFor:TextStyle.FontName
            // ExFor:TextStyle.FontSize
            // ExSummary:Manipulate by text format using paragraph style.

            var document = new Document();
            var page = new Page(document);
            var outline = new Outline(document);
            var outlineElem = new OutlineElement(document);

            var text = new RichText(document)
                        {
                            Text = $"DefaultParagraphFontAndSize{Environment.NewLine}OnlyDefaultParagraphFont{Environment.NewLine}OnlyDefaultParagraphFontSize",
                            ParagraphStyle = new ParagraphStyle()
                                                {
                                                    FontName = "Courier New",
                                                    FontSize = 20
                                                }
                        };

            // Font and font size are from text.ParagraphStyle
            text.Styles.Add(new TextStyle()
                                    {
                                        RunIndex = 27
                                    });

            // Only font is from text.ParagraphStyle
            text.Styles.Add(new TextStyle()
                                    {
                                        FontSize = 14,
                                        RunIndex = 53
                                    });

            // Only font size is from text.ParagraphStyle
            text.Styles.Add(new TextStyle()
                                    {
                                        FontName = "Verdana",
                                        RunIndex = text.Text.Length
                                    });


            outlineElem.AppendChildLast(text);
            outline.AppendChildLast(outlineElem);
            page.AppendChildLast(outline);
            document.AppendChildLast(page);

            document.Save(Path.Combine(RunExamples.GetDataDir_Text(), "SetDefaultParagraphStyle.one"));

            // ExEnd:SetDefaultParagraphStyle
        }
    }
}