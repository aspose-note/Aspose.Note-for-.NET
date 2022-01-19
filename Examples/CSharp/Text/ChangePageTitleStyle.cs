using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Text
{
    using System.IO;

    public class ChangePageTitleStyle
    {
        public static void Run()
        {
            //ExStart
            //ExFor:TextStyle
            //ExFor:Style.FontSize
            //ExFor:Style.IsBold
            //ExFor:RichText
            //ExFor:RichText.Styles
            //ExFor:RichText.ParagraphStyle
            //ExFor:ParagraphStyle
            //ExSummary:Let's emphasize page's titles among other headers by increasing font's size.

            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document document = new Document(dataDir + "Aspose.one");

            // Iterate through page's titles.
            foreach (var title in document.Select(e => e.Title.TitleText))
            {
                title.ParagraphStyle.FontSize = 24;
                title.ParagraphStyle.IsBold = true;

                foreach (TextStyle style in title.Styles)
                {
                    style.FontSize = 24;
                    style.IsBold = true;
                }
            }

            document.Save(Path.Combine(dataDir, "ChangePageTitleStyle.pdf"));

            //ExEnd

            Console.WriteLine("\nTitle's styles are changed successfully.");
        }
    }
}
