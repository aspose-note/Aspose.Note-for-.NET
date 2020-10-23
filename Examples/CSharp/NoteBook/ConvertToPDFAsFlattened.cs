using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class ConvertToPDFAsFlattened
    {
        public static void Run()
        {
            // ExStart:ConvertToPDFAsFlattened
            // ExFor:Notebook
            // ExFor:NotebookSaveOptions
            // ExFor:NotebookSaveOptions.Flatten
            // ExFor:NotebookImageSaveOptions

            // ExSummary:Shows how to save flattened notebook in pdf format.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            // Save the Notebook
            dataDir = dataDir + "ConvertToPDFAsFlattened_out.pdf";
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