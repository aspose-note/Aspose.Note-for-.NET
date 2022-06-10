// -----------------------------------------------------------------------
//  <copyright file="ChangeTableStyle.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Tables
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

                    foreach (var run in node.TextRuns)
                    {
                        run.Style.IsBold = bold;
                        run.Style.IsItalic = italic;
                    }
                }
            }
        }

        public static void Run()
        {
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

            Console.WriteLine("\nTable's style is updated successfully.\nFile saved at " + dataDir);
        }
    }
}
