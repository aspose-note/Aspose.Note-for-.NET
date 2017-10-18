using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    class LoadingNotebookInstantly
    {
        public static void Run()
        {
            // ExStart:LoadingNotebookInstantly
            // By default children loading is "lazy".
            // Therefore for instant loading has took place,
            // it is necessary to set the NotebookLoadOptions.InstantLoading flag.
            NotebookLoadOptions loadOptions = new NotebookLoadOptions();
            loadOptions.InstantLoading = true;
            String inputFile = "Notizbuch öffnen.onetoc2";
            String dataDir = RunExamples.GetDataDir_NoteBook();
            Notebook notebook = new Notebook(dataDir + inputFile, loadOptions);

            // All child documents are already loaded.
            foreach (INotebookChildNode notebookChildNode in notebook) {
	            if (notebookChildNode is Document) {
		            // Do something with child document
	            }
            }
            // ExEnd:LoadingNotebookInstantly
        }
    }
}
