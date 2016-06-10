
using System.IO;
using Aspose.Note;
using System;

namespace CSharp.Text
{
    public class ExtractingAllText
    {
        public static void Run()
        {
            // ExStart:ExtractingAllText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Text();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Retrieve text
            string text = oneFile.GetText();
            
            // Print text on the output screen
            Console.WriteLine(text);
            // ExEnd:ExtractingAllText
        }
    }
}