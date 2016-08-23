using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Pages
{
    public class ModifyPageHistory
    {
        public static void Run()
        {
            // ExStart:ModifyPageHistory
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document and get first child           
            Document document = new Document(dataDir + "Aspose.one");
            Page page = document.FirstChild;

            var pageHistory = document.GetPageHistory(page);

            pageHistory.RemoveRange(0, 1);

            pageHistory[0] = new Page(document);
            if (pageHistory.Count > 1)
            {
                pageHistory[1].Title.TitleText.Text = "New Title";

                pageHistory.Add(new Page(document));

                pageHistory.Insert(1, new Page(document));

                document.Save(dataDir + "ModifyPageHistory_out_.one");
            }
            // ExEnd:ModifyPageHistory
        }
    }
}