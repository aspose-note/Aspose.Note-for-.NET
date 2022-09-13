// -----------------------------------------------------------------------
//  <copyright file="SaveToPdfUsingPageSettings.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;
    using System.IO;

    using Aspose.Note.Saving;

    public class SaveToPdfUsingPageSettings
    {
        public static void Run()
        {
            SaveToPdfUsingLetterPageSettings();
            SaveToPdfUsingA4PageSettingsWithoutHeightLimit();
        }

        public static void SaveToPdfUsingLetterPageSettings()
        {
            // ExStart:SaveToPdfUsingLetterPageSettings
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:PdfSaveOptions
            // ExFor:PdfSaveOptions.PageSettings
            // ExFor:PageSettings
            // ExFor:PageSettings.Letter
            // ExSummary:Shows how to save a document in Pdf format with Letter page layout.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "OneNote.one");

            var dst = Path.Combine(dataDir, "SaveToPdfUsingLetterPageSettings.pdf");

            // Save the document.
            oneFile.Save(dst, new PdfSaveOptions() { PageSettings = PageSettings.Letter });

            // ExEnd:SaveToPdfUsingLetterPageSettings

            Console.WriteLine("\nOneNote document saved successfully.\nFile saved at " + dst);
        }

        public static void SaveToPdfUsingA4PageSettingsWithoutHeightLimit()
        {
            // ExStart:SaveToPdfUsingA4PageSettingsWithoutHeightLimit
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:PdfSaveOptions
            // ExFor:PdfSaveOptions.PageSettings
            // ExFor:PageSettings
            // ExFor:PageSettings.A4NoHeightLimit
            // ExSummary:Shows how to save a document in Pdf format with A4 page layout without height limit.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "OneNote.one");

            var dst = Path.Combine(dataDir, "SaveToPdfUsingA4PageSettingsWithoutHeightLimit.pdf");

            // Save the document.
            oneFile.Save(dst, new PdfSaveOptions() { PageSettings = PageSettings.A4NoHeightLimit });

            // ExEnd:SaveToPdfUsingA4PageSettingsWithoutHeightLimit

            Console.WriteLine("\nOneNote document saved successfully.\nFile saved at " + dst);
        }
    }
}
