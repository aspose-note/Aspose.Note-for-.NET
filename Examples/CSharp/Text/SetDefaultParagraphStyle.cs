// -----------------------------------------------------------------------
//  <copyright file="SetDefaultParagraphStyle.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
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
            // ExFor:RichText
            // ExFor:RichText.ParagraphStyle
            // ExFor:RichText.Append(System.String)
            // ExFor:RichText.Append(System.String,TextStyle)
            // ExFor:TextStyle
            // ExFor:Style.FontName
            // ExFor:Style.FontSize
            // ExSummary:Manipulate by text format using paragraph style.
            var document = new Document();
            var page = new Page();
            var outline = new Outline();
            var outlineElem = new OutlineElement();

            var text = new RichText() { ParagraphStyle = new ParagraphStyle() { FontName = "Courier New", FontSize = 20 } }
                            .Append($"DefaultParagraphFontAndSize{Environment.NewLine}")
                            .Append($"OnlyDefaultParagraphFont{Environment.NewLine}", new TextStyle() { FontSize = 14 })
                            .Append("OnlyDefaultParagraphFontSize", new TextStyle() { FontName = "Verdana" });

            outlineElem.AppendChildLast(text);
            outline.AppendChildLast(outlineElem);
            page.AppendChildLast(outline);
            document.AppendChildLast(page);

            document.Save(Path.Combine(RunExamples.GetDataDir_Text(), "SetDefaultParagraphStyle.one"));

            // ExEnd:SetDefaultParagraphStyle
        }
    }
}