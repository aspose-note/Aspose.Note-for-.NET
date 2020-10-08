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
            // ExFor:Document
            // ExFor:Document.Save(System.IO.Stream, Aspose.Note.SaveFormat)
            // ExFor:SaveFormat
            // ExSummary:Shows how to save a document in pdf format using default settings.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Save the document as PDF
            dataDir = dataDir + "SaveWithDefaultSettings_out.pdf";
            oneFile.Save(dataDir, SaveFormat.Pdf);
            
            // ExEnd:SaveWithDefaultSettings
            
            Console.WriteLine("\nOneNote document saved successfully with default settings.\nFile saved at " + dataDir); 
        }
    }
}