using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Pages
{
    using System.Linq;

    public class RollBackRevisions
    {
        public static void Run()
        {
            // ExStart:RollBackRevisions
            // ExFor:Document
            // ExFor:Document.GetPageHistory
            // ExSummary:Shows how to restore previous version of a page.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document and get first child           
            Document document = new Document(dataDir + "Aspose.one");
            Page page = document.FirstChild;           
            Page previousPageVersion = document.GetPageHistory(page).Last();

            document.RemoveChild(page);
            document.AppendChildLast(previousPageVersion);

            document.Save(dataDir + "RollBackRevisions_out.one");

            // ExEnd:RollBackRevisions
        }
    }
}