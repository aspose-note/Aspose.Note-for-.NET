// -----------------------------------------------------------------------
//  <copyright file="ChangeStyle.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Text
{
    using System;
    using System.Drawing;
    using System.Linq;

    public class ChangeStyle
    {
        public static void Run()
        {
            // ExStart:ChangeStyle
            // ExFor:Style.FontColor
            // ExFor:Style.Highlight
            // ExFor:Style.FontSize
            // ExSummary:Shows how to change style for a text.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");

            // Get a particular RichText node
            RichText richText = document.GetChildNodes<RichText>().First();

            foreach (var run in richText.TextRuns)
            {
                // Set font color
                run.Style.FontColor = Color.Yellow;

                // Set highlight color
                run.Style.Highlight = Color.Blue;

                // Set font size
                run.Style.FontSize = 20;
            }  
            
            // ExEnd:ChangeStyle
            Console.WriteLine("\nStyle changed successfully.");
        }
    }
}
