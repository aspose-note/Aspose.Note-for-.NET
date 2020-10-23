using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Drawing;
using System.Globalization;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    using System.Linq;

    public class WritingPasswordProtectedDoc
    {
        public static void Run()
        {
            // ExStart:WritingPasswordProtectedDoc
            // ExFor:Notebook.RemoveChild
            // ExSummary:Shows how to save a notebook.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            var notebook = new Notebook(dataDir + "test.onetoc2", new NotebookLoadOptions() { DeferredLoading = false });

            notebook.Save(dataDir + "notebook_out.onetoc2", new NotebookOneSaveOptions() { DeferredSaving = true});

            if (notebook.Any())
            {
                var childDocument0 = notebook[0] as Document;

                childDocument0.Save(dataDir + "Not Locked_out.one");

                var childDocument1 = notebook[1] as Document;

                childDocument1.Save(dataDir + "Locked Pass1_out.one", new OneSaveOptions() { DocumentPassword = "pass" });

                var childDocument2 = notebook[2] as Document;

                childDocument2.Save(dataDir + "Locked Pass2_out.one", new OneSaveOptions() { DocumentPassword = "pass2" });
            }

            // ExEnd:WritingPasswordProtectedDoc       
        }
    }
}
