using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class ConvertToImageWithOptions
    {
        public static void Run()
        {
            // ExStart:ConvertToImageWithOptions
            // ExFor:Notebook
            // ExFor:NotebookImageSaveOptions
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.Resolution
            // ExSummary:Shows how to save notebook as image with specified options.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            var notebookSaveOptions = new NotebookImageSaveOptions(SaveFormat.Png);

            var documentSaveOptions = notebookSaveOptions.DocumentSaveOptions;

            documentSaveOptions.Resolution = 400;

            dataDir = dataDir + "ConvertToImageWithOptions_out.png";

            // Save the Notebook
            notebook.Save(dataDir, notebookSaveOptions);

            // ExEnd:ConvertToImageWithOptions
            Console.WriteLine("\nNoteBook document converted to image with options successfully.\nFile saved at " + dataDir);
        }
    }
}