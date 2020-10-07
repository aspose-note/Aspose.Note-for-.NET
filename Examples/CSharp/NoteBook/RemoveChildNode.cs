using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class RemoveChildNode
    {
        public static void Run()
        {
            // ExStart:RemoveChildNode
            // ExFor:Notebook
            // ExFor:Notebook.DisplayName
            // ExFor:Notebook.RemoveChild
            // ExSummary:Shows how to remove a section from a notebook.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "test.onetoc2");

            // Traverse through its child nodes for searching the desired child item
            foreach (var child in new List<INotebookChildNode>(notebook))
            {
                if (child.DisplayName == "Remove Me")
                {
                    // Remove the Child Item from the Notebook
                    notebook.RemoveChild(child);
                }
            }

            dataDir = dataDir + "RemoveChildNode_out.onetoc2";

            // Save the Notebook
            notebook.Save(dataDir);

            // ExEnd:RemoveChildNode

            Console.WriteLine("\nChild node removed successfully.\nFile saved at " + dataDir);
        }
    }
}