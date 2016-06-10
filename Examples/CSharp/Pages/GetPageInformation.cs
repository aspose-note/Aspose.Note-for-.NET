using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
namespace CSharp.Pages
{
    public class GetPageInformation
    {
        public static void Run()
        {
            // ExStart:GetPageInformation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get all Page nodes
            IList<Page> pages = oneFile.GetChildNodes<Page>();

            foreach (Page page in pages)
            {
                Console.WriteLine("LastModifiedTime: {0}", page.LastModifiedTime);
                Console.WriteLine("CreationTime: {0}", page.CreationTime);
                Console.WriteLine("Title: {0}", page.Title);
                Console.WriteLine("Level: {0}", page.Level);
                Console.WriteLine("Author: {0}", page.Author);
                Console.WriteLine();
            }
            // ExEnd:GetPageInformation
        }
    }
}