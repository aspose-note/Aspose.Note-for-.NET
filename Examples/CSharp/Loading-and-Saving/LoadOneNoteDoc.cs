using System;
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class LoadOneNoteDoc
    {
        public static void Run()
        {
            // ExStart:LoadOneNoteDoc
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string fileName = "";
            if (fileName != "")
            {
                try
                {
                    var notebook = new Notebook(dataDir + fileName);
                    foreach (var notebookChildNode in notebook)
                    {
                        Console.WriteLine(notebookChildNode.DisplayName);
                        if (notebookChildNode is Document)
                        {
                            // Do something with child document
                        }
                        else if (notebookChildNode is Notebook)
                        {
                            // Do something with child notebook
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter valid file name.");
            }
            // ExEnd:LoadOneNoteDoc
        }
    }
}