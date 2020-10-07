using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class AddChildNode
    {
        public static void Run()
        {
            // ExStart:AddChildNode
            // ExFor:Notebook
            // ExFor:Document
            // ExSummary:Shows how to add new section to a notebook.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            // Append a new child to the Notebook
            notebook.AppendChild(new Document(dataDir + "Neuer Abschnitt 1.one"));

            dataDir = dataDir + "AddChildNode_out.onetoc2";

            // Save the Notebook
            notebook.Save(dataDir);

            // ExEnd:AddChildNode

            Console.WriteLine("\nChild node added successfully.\nFile saved at " + dataDir);
        }
    }
}