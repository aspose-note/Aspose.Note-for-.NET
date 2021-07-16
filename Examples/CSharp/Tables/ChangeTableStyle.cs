﻿namespace Aspose.Note.Examples.CSharp.Tables
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    public class ChangeTableStyle
    {
        private static void SetRowStyle(TableRow row, Color highlightColor, bool bold, bool italic)
        {
            foreach (var cell in row)
            {
                cell.BackgroundColor = highlightColor;

                foreach (var node in cell.GetChildNodes<RichText>())
                {
                    node.ParagraphStyle.IsBold = bold;
                    node.ParagraphStyle.IsItalic = italic;

                    foreach (var style in node.Styles)
                    {
                        style.IsBold = bold;
                        style.IsItalic = italic;
                    }
                }
            }
        }

        public static void Run()
        {
            // ExStart:ChangeTableStyle
            // ExFor:TextStyle
            // ExFor:TextStyle.IsBold
            // ExFor:TextStyle.IsItalic
            // ExFor:RichText
            // ExFor:RichText.Styles
            // ExFor:RichText.ParagraphStyle
            // ExFor:ParagraphStyle
            // ExFor:ParagraphStyle.IsBold
            // ExFor:ParagraphStyle.IsItalic
            // ExFor:TableCell
            // ExFor:TableCell.BackgroundColor
            // ExSummary:Let's format table for better perception. Make header row bold and italic, highlight every even row using LightGray color.
            string dataDir = RunExamples.GetDataDir_Tables();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "ChangeTableStyleIn.one");

            // Get a list of table nodes
            IList<Table> nodes = document.GetChildNodes<Table>();

            foreach (Table table in nodes)
            {
                SetRowStyle(table.First(), Color.DarkGray, true, true);

                // Highlight first row after head.
                var flag = false;
                foreach (var row in table.Skip(1))
                {
                    SetRowStyle(row, flag ? Color.LightGray : Color.Empty, false, false);

                    flag = !flag;
                }
            }

            document.Save(Path.Combine(dataDir, "ChangeTableStyleOut.one"));

            // ExEnd:ChangeTableStyle
            Console.WriteLine("\nTable's style is updated successfully.\nFile saved at " + dataDir);
        }
    }
}
