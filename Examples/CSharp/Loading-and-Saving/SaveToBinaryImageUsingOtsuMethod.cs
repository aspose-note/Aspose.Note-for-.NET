// -----------------------------------------------------------------------
//  <copyright file="SaveToBinaryImageUsingOtsuMethod.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2020 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;

    using Aspose.Note.Saving;

    class SaveToBinaryImageUsingOtsuMethod
    {
        public static void Run()
        {
            // ExStart:SaveToBinaryImageUsingOtsuMethod
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveFormat
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.ColorMode
            // ExFor:ImageSaveOptions.BinarizationOptions
            // ExFor:ColorMode
            // ExFor:ImageBinarizationOptions
            // ExFor:ImageBinarizationOptions.BinarizationMethod
            // ExFor:BinarizationMethod
            // ExSummary:Shows how to save a document as binary image using Otsu's method.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SaveToBinaryImageUsingOtsuMethod_out.png";

            // Save the document as gif.
            oneFile.Save(dataDir, new ImageSaveOptions(SaveFormat.Png)
                                    {
                                        ColorMode = ColorMode.BlackAndWhite,
                                        BinarizationOptions = new ImageBinarizationOptions()
                                                              {
                                                                  BinarizationMethod = BinarizationMethod.Otsu,
                                                              }
                                    });

            // ExEnd:SaveToBinaryImageUsingOtsuMethod

            Console.WriteLine("\nOneNote document converted successfully to binary image using Otsu's method.\nFile saved at " + dataDir);
        }
    }
}
