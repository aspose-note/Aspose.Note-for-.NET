using System;
using System.IO;
using Aspose.Note;

namespace CSharp.Loading_Saving
{
    public class SaveToImageDefaultOptions
    {
        public static void Run()
        {           
            // ExStart:SaveToImageDefaultOptions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SaveToImageDefaultOptions_out_.gif";

            // Save the document as gif.
            oneFile.Save(dataDir, SaveFormat.Gif);
            // ExEnd:SaveToImageDefaultOptions
            Console.WriteLine("\nOneNote document converted successfully to image using default options.\nFile saved at " + dataDir);
        }
    }
}