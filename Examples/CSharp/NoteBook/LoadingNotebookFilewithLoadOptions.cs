using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    class LoadingNotebookFilewithLoadOptions
    {
        public static void Run()
        {
            // ExStart:LoadingNotebookFilewithLoadOptions
            string inputFile = "Notizbuch öffnen.onetoc2";
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // By default children loading is "lazy".
            Notebook notebook = new Notebook(dataDir + inputFile);

            foreach (INotebookChildNode notebookChildNode in notebook) {
	            // Actual loading of the child document happens only here.
	            if (notebookChildNode is Document) {
		            // Do something with child document
	            }
            }
            // ExEnd:LoadingNotebookFilewithLoadOptions
        }
    }
}
