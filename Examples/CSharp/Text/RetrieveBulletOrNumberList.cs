using System;
using System.Globalization;
using System.IO;
using Aspose.Note;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Text
{
    public class RetrieveBulletOrNumberList
    {
        public static void Run()
        {
            // ExStart:RetrieveBulletOrNumberList
            // ExFor:OutlineElement
            // ExFor:OutlineElement.NumberList
            // ExFor:NumberList
            // ExFor:NumberList.Font
            // ExFor:NumberList.FontSize
            // ExFor:NumberList.FontColor
            // ExFor:NumberList.Format
            // ExFor:NumberList.IsBold
            // ExFor:NumberList.IsItalic
            // ExSummary:Shows how to retrieve information about list's formatting.

            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "ApplyNumberingOnText.one");

            // Retrieve a collection nodes of the outline element
            IList<OutlineElement> nodes = oneFile.GetChildNodes<OutlineElement>();

            // Iterate through each node
            foreach (OutlineElement node in nodes)
            {
                if (node.NumberList != null)
                {
                    NumberList list = node.NumberList;
                    
                    // Retrieve font name
                    Console.WriteLine("Font Name: " + list.Font);
                    
                    // Retrieve font length
                    Console.WriteLine("Font Length: " + list.Font.Length);
                    
                    // Retrieve font size
                    Console.WriteLine("Font Size: " + list.FontSize);
                    
                    // Retrieve font color
                    Console.WriteLine("Font Color: " + list.FontColor);
                    
                    // Retrieve format
                    Console.WriteLine("Font format: " + list.Format);
                    
                    // Check bold
                    Console.WriteLine("Is bold: " + list.IsBold);
                    
                    // Check italic
                    Console.WriteLine("Is italic: " + list.IsItalic);
                    Console.WriteLine();
                }
            }

            // ExEnd:RetrieveBulletOrNumberList           
        }
    }
}
