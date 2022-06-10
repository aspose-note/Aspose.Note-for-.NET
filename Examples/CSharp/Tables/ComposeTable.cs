// -----------------------------------------------------------------------
//  <copyright file="ComposeTable.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Tables
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    public class ComposeTable
    {
        public static void Run()
        {
            // ExStart:ComposeTable
            // ExFor:RichText.Styles
            // ExFor:Style.FontColor
            // ExFor:Style.Highlight
            // ExFor:Style.FontSize
            // ExSummary:Shows how to compose a table having text with various styles.
            string dataDir = RunExamples.GetDataDir_Text();

            var headerText = new RichText() { ParagraphStyle = new ParagraphStyle() { FontSize = 18, IsBold = true }, Alignment = HorizontalAlignment.Center }
                                .Append("Super contest for suppliers.");

            var page = new Page();
            var outline = page.AppendChildLast(new Outline() { HorizontalOffset = 50 });
            outline.AppendChildLast(new OutlineElement()).AppendChildLast(headerText);

            // Summary text before table
            var bodyTextHeader = outline.AppendChildLast(new OutlineElement()).AppendChildLast(new RichText() { ParagraphStyle = ParagraphStyle.Default });
            bodyTextHeader.Append("This is the final ranking of proposals got from our suppliers.");

            var ranking = outline.AppendChildLast(new OutlineElement()).AppendChildLast(new Table());
            var headerRow = ranking.AppendChildFirst(new TableRow());
            
            var headerStyle = ParagraphStyle.Default;
            headerStyle.IsBold = true;

            // Let's add a set of columns and a header row
            var backGroundColor = Color.LightGray;
            foreach (var header in new[] { "Supplier", "Contacts", "Score A", "Score B", "Score C", "Final score", "Attached materials", "Comments" })
            {
                ranking.Columns.Add(new TableColumn());
                headerRow.AppendChildLast(new TableCell() { BackgroundColor = backGroundColor })
                         .AppendChildLast(new OutlineElement())
                         .AppendChildLast(new RichText() { ParagraphStyle = headerStyle })
                            .Append(header);
            }

            // Let's 5 empty rows. Rows have interchanging background color
            for (int i = 0; i < 5; i++)
            {
                backGroundColor = backGroundColor.IsEmpty ? Color.LightGray : Color.Empty;

                var row = ranking.AppendChildLast(new TableRow());
                for (int j = 0; j < ranking.Columns.Count(); j++)
                {
                    row.AppendChildLast(new TableCell() { BackgroundColor = backGroundColor })
                       .AppendChildLast(new OutlineElement())
                       .AppendChildLast(new RichText() { ParagraphStyle = ParagraphStyle.Default });
                }
            }

            // Let's add some template for content in 'Contacts' column
            foreach (var row in ranking.Skip(1))
            {
                var contactsCell = row.ElementAt(1);
                contactsCell.AppendChildLast(new OutlineElement())
                            .AppendChildLast(new RichText() { ParagraphStyle = ParagraphStyle.Default })
                                .Append("Web: ").Append("link", new TextStyle() { HyperlinkAddress = "www.link.com", IsHyperlink = true });
                contactsCell.AppendChildLast(new OutlineElement())
                            .AppendChildLast(new RichText() { ParagraphStyle = ParagraphStyle.Default })
                                .Append("E-mail: ").Append("mail", new TextStyle() { HyperlinkAddress = "mailto:hi@link.com", IsHyperlink = true });
            }


            var d = new Document();
            d.AppendChildLast(page);
            d.Save(Path.Combine(dataDir, "ComposeTable_out.one"));

            // ExEnd:ComposeTable
            Console.WriteLine("\nThe document is composed successfully.");
        }
    }
}
