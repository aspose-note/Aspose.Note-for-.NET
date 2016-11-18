using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Pages
{
    public class WorkingWithPageRevisions
    {
        public static void Run()
        {
            // ExStart:WorkingWithPageRevisions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document and get first child           
            Document document = new Document(dataDir + "Aspose.one");
            Page page = document.FirstChild;

            // Reading Content Revision Summary for this page
            var pageRevisionInfo = page.PageContentRevisionSummary;

            Console.WriteLine(string.Format(
                "Author:\t{0}\nModified:\t{1}",
                pageRevisionInfo.AuthorMostRecent,
                pageRevisionInfo.LastModifiedTime.ToString("dd.MM.yyyy HH:mm:ss")));

            // Update Page Revision Summary for this page
            pageRevisionInfo.AuthorMostRecent = "New Author";
            pageRevisionInfo.LastModifiedTime = DateTime.Now;
            document.Save(dataDir + "WorkingWithPageRevisions_out.one");
            // ExEnd:WorkingWithPageRevisions
        }
    }
}