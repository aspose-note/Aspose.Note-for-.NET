using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    class RetrieveDocumentsFromOneNoteNotebook
    {
        public static void Run()
        {
            // ExStart:RetrieveDocumentsFromOneNoteNotebook
            // ExFor:Notebook.RemoveChild
            // ExSummary:Shows how to access all sections from a notebook.

            string inputFile = "notebook.onetoc2";
            string dataDir = RunExamples.GetDataDir_NoteBook();
            
            Notebook rootNotebook = new Notebook(dataDir + inputFile);

            IList<Document> allDocuments = rootNotebook.GetChildNodes<Document>();
            foreach (Document document in allDocuments) 
            {
	            Console.WriteLine(document.DisplayName);
            }

            // ExEnd:RetrieveDocumentsFromOneNoteNotebook
        }
    }
}
