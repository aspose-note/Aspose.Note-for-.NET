
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    public class ConvertToImage
    {
        public static void Run()
        {
            // ExStart:ConvertToImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            dataDir = dataDir + "ConvertToImage_out_.png";

            // Save the Notebook
            notebook.Save(dataDir);

            // ExEnd:ConvertToImage
            Console.WriteLine("\nNoteBook document converted to image successfully.\nFile saved at " + dataDir);
        }
    }
}