using System;
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class ConvertSpecificPageToImage
    {
        public static void Run()
        {
            ConvertDocumentToImage();
            SetOutputImageResolution();
        }

        public static void ConvertDocumentToImage()
        {
            // ExStart:ConvertSpecificPageToImage
            // ExFor:Document
            // ExFor:ImageSaveOptions
            // ExFor:SaveOptions.PageIndex
            // ExSummary:Shows how to save a document in png format.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Initialize ImageSaveOptions object 
            ImageSaveOptions opts = new ImageSaveOptions(SaveFormat.Png)
                                        {
                                            // Set page index
                                            PageIndex = 1
                                        };

            dataDir = dataDir + "ConvertSpecificPageToImage_out.png";

            // Save the document as PNG.
            oneFile.Save(dataDir, opts);

            // ExEnd:ConvertSpecificPageToImage

            Console.WriteLine("\nOneNote document converted successfully to image.\nFile saved at " + dataDir);
        }

        public static void SetOutputImageResolution()
        {
            // ExStart:SetOutputImageResolution
            // ExFor:Document
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.Resolution
            // ExFor:SaveFormat
            // ExSummary:Shows how to set a image resolution when saving document as image.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SetOutputImageResolution_out.jpg";

            // Save the document.
            doc.Save(dataDir, new ImageSaveOptions(SaveFormat.Jpeg) { Resolution = 220 });

            // ExEnd:SetOutputImageResolution
            
            Console.WriteLine("\nOneNote document output resolution setup successfully.\nFile saved at " + dataDir);
        }

        public static void SetOutputImageQuality()
        {
            // ExStart:SetOutputImageQuality
            // ExFor:Document
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.Quality
            // ExFor:SaveFormat
            // ExSummary:Shows how to set a image quality when saving document as image in JPEG format.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document doc = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SetOutputImageResolution_out.jpg";

            // Save the document.
            doc.Save(dataDir, new ImageSaveOptions(SaveFormat.Jpeg) { Quality = 100 });
            
            // ExEnd:SetOutputImageQuality
            
            Console.WriteLine("\nOneNote document output quality setup successfully.\nFile saved at " + dataDir);
        }
    }
}