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
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();
            FileStream stream = new FileStream(dataDir + "notebook.onetoc2", FileMode.Open);
            var notebook = new Notebook(stream);

            FileStream childStream = new FileStream(dataDir + "Aspose.one", FileMode.Open);
            notebook.LoadChildDocument(childStream);
           
            notebook.LoadChildDocument(dataDir + "Sample1.one");
            // ExEnd:LoadFromStream       
        }
    }
}
