using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class ConvertToPDF
    {
        public static void Run()
        {
            // ExStart:ConvertToPDF
            // ExFor:Notebook
            // ExSummary:Shows how to save notebook in pdf format.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            dataDir = dataDir + "ConvertToPDF_out.pdf";

            // Save the Notebook
            notebook.Save(dataDir);

            // ExEnd:ConvertToPDF
            Console.WriteLine("\nNoteBook document converted to pdf successfully.\nFile saved at " + dataDir);
        }
    }
}