using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Pages
{
    public class GetPageInformation
    {
        public static void Run()
        {
            // ExStart:GetPageInformation
            // ExFor:Document
            // ExFor:Page
            // ExFor:Page.LastModifiedTime
            // ExFor:Page.CreationTime
            // ExFor:Page.Title
            // ExFor:Page.Level
            // ExFor:Page.Author
            // ExSummary:Shows how to get meta information about a page.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            foreach (Page page in oneFile)
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