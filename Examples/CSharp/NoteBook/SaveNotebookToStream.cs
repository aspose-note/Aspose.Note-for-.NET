using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Drawing;
using System.Globalization;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class SaveNotebookToStream
    {
        public static void Run()
        {
            // ExStart:SaveNotebookToStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();
            var notebook = new Notebook();

            MemoryStream stream = new MemoryStream();
            notebook.Save(stream);
            if (notebook.Count > 0)
            {
                var childDocument0 = notebook[0] as Document;

                MemoryStream childStream = new MemoryStream();
                childDocument0.Save(childStream);

                var childDocument1 = notebook[1] as Document;
                childDocument0.Save(dataDir + "SaveNotebookToStream_out.one");
            }
            // ExEnd:SaveNotebookToStream       
        }
    }
}
