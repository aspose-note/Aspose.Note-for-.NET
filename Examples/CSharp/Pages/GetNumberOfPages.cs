using System.IO;
using Aspose.Note;
using System;

namespace Aspose.Note.Examples.CSharp.Pages
{
    using System.Linq;

    public class GetNumberOfPages
    {
        public static void Run()
        {
            // ExStart:GetNumberOfPages
            // ExFor:Document
            // ExSummary:Shows how to get page's count of a document.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get number of pages
            int count = oneFile.Count();

            // Print count on the output screen
            Console.WriteLine(count);
            
            // ExEnd:GetNumberOfPages
        }
    }
}