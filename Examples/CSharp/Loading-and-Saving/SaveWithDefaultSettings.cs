using System.IO;
using Aspose.Note;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class SaveWithDefaultSettings
    {
        public static void Run()
        {
            // ExStart:SaveWithDefaultSettings
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SaveWithDefaultSettings_out.pdf";
            // Save the document as PDF
            oneFile.Save(dataDir, SaveFormat.Pdf);
            // ExEnd:SaveWithDefaultSettings
            Console.WriteLine("\nOneNote document saved successfully with default settings.\nFile saved at " + dataDir); 
        }
       
    }
}