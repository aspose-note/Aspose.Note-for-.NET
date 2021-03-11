// -----------------------------------------------------------------------
//  <copyright file="SaveToTiffImageUsingImageSaveOptions.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;
    using System.IO;

    using Aspose.Note.Saving;

    class SaveToTiffImageUsingImageSaveOptions
    {
        public static void Run()
        {
            SaveToTiffUsingJpegCompression();
            SaveToTiffUsingPackBitsCompression();
            SaveToTiffUsingCcitt3Compression();
        }

        public static void SaveToTiffUsingJpegCompression()
        {
            // ExStart:SaveToTiffUsingJpegCompression
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveFormat
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.TiffCompression
            // ExFor:ImageSaveOptions.Quality
            // ExFor:TiffCompression
            // ExSummary:Shows how to save a document as image in Tiff format using Jpeg compression.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(Path.Combine(dataDir, "Aspose.one"));

            var dst = Path.Combine(dataDir, "SaveToTiffUsingJpegCompression.tiff");

            // Save the document.
            oneFile.Save(dst, new ImageSaveOptions(SaveFormat.Tiff)
                                  {
                                      TiffCompression = TiffCompression.Jpeg,
                                      Quality = 93
                                  });

            // ExEnd:SaveToTiffUsingJpegCompression
            Console.WriteLine("\nOneNote document converted successfully to image in Tiff format using Jpeg compression.\nFile saved at " + dst);
        }

        public static void SaveToTiffUsingPackBitsCompression()
        {
            // ExStart:SaveToTiffUsingPackBitsCompression
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveFormat
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.TiffCompression
            // ExFor:TiffCompression
            // ExSummary:Shows how to save a document as image in Tiff format using PackBits compression.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(Path.Combine(dataDir, "Aspose.one"));

            var dst = Path.Combine(dataDir, "SaveToTiffUsingPackBitsCompression.tiff");

            // Save the document.
            oneFile.Save(dst, new ImageSaveOptions(SaveFormat.Tiff)
                                  {
                                      TiffCompression = TiffCompression.PackBits
                                  });

            // ExEnd:SaveToTiffUsingPackBitsCompression
            Console.WriteLine("\nOneNote document converted successfully to image in Tiff format using PackBits compression.\nFile saved at " + dst);
        }

        public static void SaveToTiffUsingCcitt3Compression()
        {
            // ExStart:SaveToTiffUsingCcitt3Compression
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveFormat
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.ColorMode
            // ExFor:ImageSaveOptions.TiffCompression
            // ExFor:ColorMode
            // ExFor:TiffCompression
            // ExSummary:Shows how to save a document as image in Tiff format using CCITT Group 3 fax compression.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(Path.Combine(dataDir, "Aspose.one"));

            var dst = Path.Combine(dataDir, "SaveToTiffUsingCcitt3Compression.tiff");

            // Save the document.
            oneFile.Save(dst, new ImageSaveOptions(SaveFormat.Tiff)
                                  {
                                      ColorMode = ColorMode.BlackAndWhite,
                                      TiffCompression = TiffCompression.Ccitt3
                                  });

            // ExEnd:SaveToTiffUsingCcitt3Compression
            Console.WriteLine("\nOneNote document converted successfully to image in Tiff format using CCITT Group 3 fax compression.\nFile saved at " + dst);
        }
    }
}