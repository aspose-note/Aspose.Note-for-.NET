using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Drawing;
using System.Globalization;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class LoadFromStream
    {
        public static void Run()
        {
            // ExStart:LoadFromStream
            // ExFor:Notebook
            // ExFor:Notebook.LoadChildDocument(System.String)
            // ExFor:Notebook.LoadChildDocument(System.IO.Stream)
            // ExSummary:Shows how to load notebook from a stream.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();
            
            FileStream stream = new FileStream(dataDir + "Notizbuch öffnen.onetoc2", FileMode.Open);

            var notebook = new Notebook(stream);

            using (FileStream childStream = new FileStream(dataDir + "Aspose.one", FileMode.Open))
            {
                notebook.LoadChildDocument(childStream);
            }

            notebook.LoadChildDocument(dataDir + "Sample1.one");
            
            // ExEnd:LoadFromStream       
        }
    }
}
