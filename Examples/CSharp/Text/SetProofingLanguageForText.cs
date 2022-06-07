// -----------------------------------------------------------------------
//  <copyright file="SetProofingLanguageForText.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System.Globalization;
    using System.IO;

    class SetProofingLanguageForText
    {
        public static void Run()
        {
            // ExStart:SetProofingLanguageForText
            // ExFor:TextStyle
            // ExFor:TextStyle.Language
            // ExFor:RichText
            // ExFor:RichText.Append(System.String,TextStyle)
            // ExSummary:Set proofing language for a text.
            var document = new Document();
            var page = new Page();
            var outline = new Outline();
            var outlineElem = new OutlineElement();

            var text = new RichText() { ParagraphStyle = ParagraphStyle.Default };
            text.Append("United States", new TextStyle() { Language = CultureInfo.GetCultureInfo("en-US") })
                .Append(" Germany", new TextStyle() { Language = CultureInfo.GetCultureInfo("de-DE") })
                .Append(" China", new TextStyle() { Language = CultureInfo.GetCultureInfo("zh-CN") });

            outlineElem.AppendChildLast(text);
            outline.AppendChildLast(outlineElem);
            page.AppendChildLast(outline);
            document.AppendChildLast(page);

            document.Save(Path.Combine(RunExamples.GetDataDir_Text(), "SetProofingLanguageForText.one"));

            // ExEnd:SetProofingLanguageForText
        }
    }
}