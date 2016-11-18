using System;
using System.Globalization;
using System.IO;
using Aspose.Note;
using System.Drawing;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class ChangeStyle
    {
        public static void Run()
        {
            // ExStart:ChangeStyle
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");
            // Get a particular RichText node
            IList<RichText> richTextNodes = document.GetChildNodes<RichText>();
            RichText richText = richTextNodes[0];

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
