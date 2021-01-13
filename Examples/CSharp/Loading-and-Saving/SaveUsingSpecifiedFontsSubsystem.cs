// -----------------------------------------------------------------------
//  <copyright file="SaveUsingSpecifiedFontsSubsystem.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;
    using System.IO;

    using Aspose.Note.Fonts;
    using Aspose.Note.Saving;

    public class SaveUsingSpecifiedFontsSubsystem
    {
        public static void Run()
        {
            SaveUsingDocumentFontsSubsystemWithDefaultFontName();
            SaveUsingDocumentFontsSubsystemWithDefaultFontFromFile();
            SaveUsingDocumentFontsSubsystemWithDefaultFontFromStream();

            Console.WriteLine("\nDocument with unknown font is successfully saved at " + RunExamples.GetDataDir_LoadingAndSaving());
        }

        public static void SaveUsingDocumentFontsSubsystemWithDefaultFontName()
        {
            // ExStart:SaveUsingDocumentFontsSubsystemWithDefaultFontName
            // ExFor:Document.Save(System.IO.Stream, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveOptions.FontsSubsystem
            // ExFor:DocumentFontsSubsystem
            // ExFor:DocumentFontsSubsystem.UsingDefaultFont(System.String,System.Collections.Generic.Dictionary{System.String,System.String})
            // ExSummary:Shows how to save a document in pdf format using specified default font.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(Path.Combine(dataDir, "missing-font.one"));

            // Save the document as PDF
            dataDir = dataDir + "SaveUsingDocumentFontsSubsystemWithDefaultFontName_out.pdf";
            oneFile.Save(dataDir, new PdfSaveOptions() 
                                  {
                                      FontsSubsystem = DocumentFontsSubsystem.UsingDefaultFont("Times New Roman")
                                  });

            // ExEnd:SaveUsingDocumentFontsSubsystemWithDefaultFontName
        }

        public static void SaveUsingDocumentFontsSubsystemWithDefaultFontFromFile()
        {
            // ExStart:SaveUsingDocumentFontsSubsystemWithDefaultFontFromFile
            // ExFor:Document.Save(System.IO.Stream, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveOptions.FontsSubsystem
            // ExFor:DocumentFontsSubsystem
            // ExFor:DocumentFontsSubsystem.UsingDefaultFontFromFile(System.String,System.Collections.Generic.Dictionary{System.String,System.String})
            // ExSummary:Shows how to save a document in pdf format using default font from a file.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            string fontFile = Path.Combine(dataDir, "geo_1.ttf");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(Path.Combine(dataDir, "missing-font.one"));

            // Save the document as PDF
            dataDir = dataDir + "SaveUsingDocumentFontsSubsystemWithDefaultFontFromFile_out.pdf";
            oneFile.Save(dataDir, new PdfSaveOptions()
                                      {
                                          FontsSubsystem = DocumentFontsSubsystem.UsingDefaultFontFromFile(fontFile)
                                      });

            // ExEnd:SaveUsingDocumentFontsSubsystemWithDefaultFontFromFile
        }

        public static void SaveUsingDocumentFontsSubsystemWithDefaultFontFromStream()
        {
            // ExStart:SaveUsingDocumentFontsSubsystemWithDefaultFontFromStream
            // ExFor:Document.Save(System.IO.Stream, Aspose.Note.Saving.SaveOptions)
            // ExFor:SaveOptions.FontsSubsystem
            // ExFor:DocumentFontsSubsystem
            // ExFor:DocumentFontsSubsystem.UsingDefaultFontFromStream(System.IO.Stream,System.Collections.Generic.Dictionary{System.String,System.String})
            // ExSummary:Shows how to save a document in pdf format using default font from a stream.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            string fontFile = Path.Combine(dataDir, "geo_1.ttf");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(Path.Combine(dataDir, "missing-font.one"));

            // Save the document as PDF
            dataDir = dataDir + "SaveUsingDocumentFontsSubsystemWithDefaultFontFromStream_out.pdf";

            using (var stream = File.Open(fontFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                oneFile.Save(dataDir, new PdfSaveOptions()
                                          {
                                              FontsSubsystem = DocumentFontsSubsystem.UsingDefaultFontFromStream(stream)
                                          });
            }

            // ExEnd:SaveUsingDocumentFontsSubsystemWithDefaultFontFromStream
        }
    }
}
