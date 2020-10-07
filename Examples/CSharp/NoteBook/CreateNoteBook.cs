using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class CreateNoteBook
    {
        public static void Run()
        {
            // ExStart:CreateNoteBook
            // ExFor:Notebook
            // ExSummary:Shows how to save notebook.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();
            
            var notebook = new Notebook();

            dataDir = dataDir + "test_out.onetoc2";

            // Save the Notebook
            notebook.Save(dataDir);

            // ExEnd:CreateNoteBook

            Console.WriteLine("\nNoteBook created successfully.\nFile saved at " + dataDir);
        }
    }
}