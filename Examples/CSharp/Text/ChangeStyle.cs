using System;
using System.Globalization;
using System.IO;
using Aspose.Note;
using System.Drawing;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Text
{
    using System.Linq;

    public class ChangeStyle
    {
        public static void Run()
        {
            // ExStart:ChangeStyle
            // ExFor:RichText.Styles
            // ExFor:TextStyle.FontColor
            // ExFor:TextStyle.Highlight
            // ExFor:TextStyle.FontSize
            // ExSummary:Shows how to change style for a text.

            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");

            // Get a particular RichText node
            RichText richText = document.GetChildNodes<RichText>().First();

            foreach (TextStyle style in richText.Styles)
            {
                // Set font color
                style.FontColor = Color.Yellow;

                // Set highlight color
                style.Highlight = Color.Blue;

                // Set font size
                style.FontSize = 20;
            }  
            
            // ExEnd:ChangeStyle

            Console.WriteLine("\nStyle changed successfully.");
        }
    }
}
