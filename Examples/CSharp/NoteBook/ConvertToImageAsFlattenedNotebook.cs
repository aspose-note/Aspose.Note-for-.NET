using Aspose.Note.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    class ConvertToImageAsFlattenedNotebook
    {
        public static void Run()
        {
            // ExStart:ConvertToImageAsFlattenedNotebook
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch öffnen.onetoc2");

            var notebookSaveOptions = new NotebookImageSaveOptions(SaveFormat.Png);

            var documentSaveOptions = notebookSaveOptions.DocumentSaveOptions;

            documentSaveOptions.Resolution = 400;
            notebookSaveOptions.Flatten = true;

            dataDir = dataDir + "ConvertToImageAsFlattenedNotebook_out.png";

            // Save the Notebook
            notebook.Save(dataDir, notebookSaveOptions);
            // ExEnd:ConvertToImageAsFlattenedNotebook
        }
    }
}
