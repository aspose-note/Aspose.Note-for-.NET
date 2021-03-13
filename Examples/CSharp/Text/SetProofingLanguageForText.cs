// -----------------------------------------------------------------------
//  <copyright file="SetProofingLanguageForText.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.Globalization;
    using System.IO;

    class SetProofingLanguageForText
    {
        public static void Run()
        {
            // ExStart:SetProofingLanguageForText
            // ExFor:TextStyle
            // ExFor:TextStyle.Language
            // ExFor:TextStyle.RunIndex
            // ExFor:RichText
            // ExFor:RichText.Styles
            // ExSummary:Set proofing language for a text.

            var document = new Document();
            var page = new Page(document);
            var outline = new Outline(document);
            var outlineElem = new OutlineElement(document);

            var text = new RichText(document) { Text = "United States Germany China", ParagraphStyle = ParagraphStyle.Default };
            text.Styles.Add(new TextStyle()
                                {
                                    Language = CultureInfo.GetCultureInfo("en-US"),
                                    RunIndex = 13
                                });
            text.Styles.Add(new TextStyle()
                                {
                                    Language = CultureInfo.GetCultureInfo("de-DE"),
                                    RunIndex = 21
                                });
            text.Styles.Add(new TextStyle()
                                {
                                    Language = CultureInfo.GetCultureInfo("zh-CN"),
                                    RunIndex = text.Text.Length
                                });


            outlineElem.AppendChildLast(text);
            outline.AppendChildLast(outlineElem);
            page.AppendChildLast(outline);
            document.AppendChildLast(page);

            document.Save(Path.Combine(RunExamples.GetDataDir_Text(), "SetProofingLanguageForText.one"));

            // ExEnd:SetProofingLanguageForText
        }
    }
}