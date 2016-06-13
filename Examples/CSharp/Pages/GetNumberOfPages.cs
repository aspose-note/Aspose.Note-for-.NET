
using System.IO;
using Aspose.Note;
using System;

namespace CSharp.Pages
{
    public class GetNumberOfPages
    {
        public static void Run()
        {
            // ExStart:GetNumberOfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get number of pages
            int count = oneFile.GetChildNodes<Page>().Count;

            // Print count on the output screen
            Console.WriteLine(count);
            // ExEnd:GetNumberOfPages
        }
    }
}