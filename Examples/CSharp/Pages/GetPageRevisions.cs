using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
namespace CSharp.Pages
{
    public class GetPageRevisions
    {
        public static void Run()
        {
            // ExStart:GetPageRevisions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document
            Document document = new Document(dataDir + "Aspose.one", new LoadOptions { LoadHistory = true });
            // Get first page
            Page firstPage = document.FirstChild;
            foreach (Page pageRevision in document.GetPageHistory(firstPage))
            {
                /*Use pageRevision like a regular page.*/
                Console.WriteLine("LastModifiedTime: {0}", pageRevision.LastModifiedTime);
                Console.WriteLine("CreationTime: {0}", pageRevision.CreationTime);
                Console.WriteLine("Title: {0}", pageRevision.Title);
                Console.WriteLine("Level: {0}", pageRevision.Level);
                Console.WriteLine("Author: {0}", pageRevision.Author);
                Console.WriteLine();
            }
            // ExEnd:GetPageRevisions
        }
    }
}