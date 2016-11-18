using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Pages
{
    public class RollBackRevisions
    {
        public static void Run()
        {
            // ExStart:RollBackRevisions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document and get first child           
            Document document = new Document(dataDir + "Aspose.one");
            Page page = document.FirstChild;           
            Page lastPage = null;
            foreach (Page pageRevision in document.GetPageHistory(page))
            {
                lastPage = pageRevision;
            }
            document.RemoveChild(page);

            document.AppendChild(lastPage);

            document.Save(dataDir + "RollBackRevisions_out.one");          
            // ExEnd:RollBackRevisions
        }
    }
}