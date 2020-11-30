// -----------------------------------------------------------------------
//  <copyright file="SaveToBinaryImageUsingFixedThreshold.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2020 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;

    using Aspose.Note.Saving;

    class SaveToBinaryImageUsingFixedThreshold
    {
        public static void Run()
        {
            // ExStart:SaveToBinaryImageUsingFixedThreshold
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveFormat
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.ColorMode
            // ExFor:ImageSaveOptions.BinarizationOptions
            // ExFor:ColorMode
            // ExFor:ImageBinarizationOptions
            // ExFor:ImageBinarizationOptions.BinarizationMethod
            // ExFor:ImageBinarizationOptions.BinarizationThreshold
            // ExFor:BinarizationMethod
            // ExSummary:Shows how to save a document as binary image using fixed threshold.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SaveToBinaryImageUsingFixedThreshold_out.png";

            // Save the document as gif.
            oneFile.Save(dataDir, new ImageSaveOptions(SaveFormat.Png)
                                      {
                                          ColorMode = ColorMode.BlackAndWhite,
                                          BinarizationOptions = new ImageBinarizationOptions()
                                                                    {
                                                                        BinarizationMethod = BinarizationMethod.FixedThreshold,
                                                                        BinarizationThreshold = 123
                                                                    }
                                      });

            // ExEnd:SaveToBinaryImageUsingFixedThreshold

            Console.WriteLine("\nOneNote document converted successfully to binary image using fixed threshold.\nFile saved at " + dataDir);
        }
    }
}
