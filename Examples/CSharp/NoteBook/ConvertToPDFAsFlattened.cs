
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    public class ConvertToPDFAsFlattened
    {
        public static void Run()
        {
            // ExStart:ConvertToPDFAsFlattened
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            dataDir = dataDir + "ConvertToPDFAsFlattened_out_.pdf";
            // Save the Notebook
            notebook.Save(
                dataDir,
                new NotebookPdfSaveOptions
                {
                    Flatten = true
                });         

            // ExEnd:ConvertToPDFAsFlattened
            Console.WriteLine("\nNoteBook document converted to pdf as flattened successfully.\nFile saved at " + dataDir);
        }
    }
}