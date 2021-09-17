﻿// -----------------------------------------------------------------------
//  <copyright file="GenerateTemplateForMeetingNotes.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Tags
{
    using System;
    using System.IO;

    public class GenerateTemplateForMeetingNotes
    {
        private static NumberList CreateListNumberingStyle(ParagraphStyle bodyStyle, bool restart)
        {
            return new NumberList("{0}.", NumberFormat.DecimalNumbers, bodyStyle.FontName, bodyStyle.FontSize) { Restart = restart ? 1 : 0 };
        }

        public static void Run()
        {
            // ExStart:GenerateTemplateForMeetingNotes
            // ExFor:NoteTag
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExFor:RichText.ParagraphStyle
            // ExSummary:Shows how to prepare a template for weekly meeting.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Create an object of the Document class
            var headerStyle = new ParagraphStyle() { FontName = "Calibri", FontSize = 16 };
            var bodyStyle = new ParagraphStyle() { FontName = "Calibri", FontSize = 12 };
            

            var d = new Document();
            bool restartFlag = true;
            var outline = d.AppendChildLast(new Page(null)
                                                {
                                                    Title = new Title(null) { TitleText = new RichText(null) { Text = $"Weekly meeting {DateTime.Today:d}", ParagraphStyle = ParagraphStyle.Default } }
                                                })
                           .AppendChildLast(new Outline(null) { VerticalOffset = 30, HorizontalOffset = 30 });

            outline.AppendChildLast(new OutlineElement(null))
                   .AppendChildLast(new RichText(null) { Text = "Important", ParagraphStyle = headerStyle });
            foreach (var e in new[] { "First", "Second", "Third" })
            {
                outline.AppendChildLast(new OutlineElement(null) { NumberList = CreateListNumberingStyle(bodyStyle, restartFlag) })
                       .AppendChildLast(new RichText(null) { Text = e, ParagraphStyle = bodyStyle });
                restartFlag = false;
            }


            outline.AppendChildLast(new OutlineElement(null))
                   .AppendChildLast(new RichText(null) { Text = "TO DO", ParagraphStyle = headerStyle, SpaceBefore = 15 });
            restartFlag = true;
            foreach (var e in new[] { "First", "Second", "Third" })
            {
                outline.AppendChildLast(new OutlineElement(null) { NumberList = CreateListNumberingStyle(bodyStyle, restartFlag) })
                       .AppendChildLast(new RichText(null) { Text = e, ParagraphStyle = bodyStyle, Tags = { NoteCheckBox.CreateBlueCheckBox() } });
                restartFlag = false;
            }

            d.Save(Path.Combine(dataDir, "meetingNotes.one"));

            // ExEnd:GenerateTemplateForMeetingNotes
        }
    }
}
