using System;
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
namespace CSharp.Loading_Saving
{
    public class ConvertSpecificPageToImage
    {
        public static void Run()
        {
            // ExStart:ConvertSpecificPageToImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Initialize ImageSaveOptions object 
            ImageSaveOptions opts = new ImageSaveOptions(SaveFormat.Png);
            
            // Set page index
            opts.PageIndex = 1;

            dataDir = dataDir + "ConvertSpecificPageToImage_out_.png";

            // Save the document as PNG.
            oneFile.Save(dataDir, opts);
            // ExEnd:ConvertSpecificPageToImage
            Console.WriteLine("\nOneNote document converted successfully to image.\nFile saved at " + dataDir);
        }    
        public static void SetOutputImageResolution()
        {
            // ExStart:SetOutputImageResolution
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SetOutputImageResolution_out_.jpg";

            // Save the document.
            doc.Save(dataDir, new ImageSaveOptions(SaveFormat.Jpeg) { Resolution = 220 });
            // ExEnd:SetOutputImageResolution
            Console.WriteLine("\nOneNote document output resolution setup successfully.\nFile saved at " + dataDir);
        }
    }
}