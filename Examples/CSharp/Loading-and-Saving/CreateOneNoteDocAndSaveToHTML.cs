// -----------------------------------------------------------------------
//  <copyright file="CreateOneNoteDocAndSaveToHTML.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.IO;

    using Aspose.Note.Saving;
    using Aspose.Note.Saving.Html;

    public class CreateOneNoteDocAndSaveToHTML
    {
        public static void Run()
        {
            CreateAndSaveToHTMLUsingDefaultOptions();
            CreateAndSavePageRange();
            SaveAsHTMLToFileWithResourcesInSeparateFiles();
            SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources();
            SaveAsHTMLToMemoryStreamWithEmbeddedResources();
        }

        public static void CreateAndSaveToHTMLUsingDefaultOptions()
        {
            // ExStart:CreateAndSaveToHTMLUsingDefaultOptions
            // ExFor:Document
            // ExFor:Page
            // ExFor:Page.Title
            // ExFor:Title
            // ExFor:Title.TitleText
            // ExFor:Title.TitleDate
            // ExFor:Title.TitleTime
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExSummary:Shows how to create a document and save it in html format using default options.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize OneNote document
            Document doc = new Document();
            Page page = doc.AppendChildLast(new Page());

            // Default style for all text in the document.
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title()
                             {
                                 TitleText = new RichText() { Text = "Title text.", ParagraphStyle = textStyle },
                                 TitleDate = new RichText() { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), ParagraphStyle = textStyle },
                                 TitleTime = new RichText() { Text = "12:34", ParagraphStyle = textStyle }
                             };

            // Save into HTML format
            dataDir = dataDir + "CreateOneNoteDocAndSaveToHTML_out.html";
            doc.Save(dataDir);

            // ExEnd:CreateAndSaveToHTMLUsingDefaultOptions

            Console.WriteLine("\nOneNote document created successfully.\nFile saved at " + dataDir);
        }

        public static void CreateAndSavePageRange()
        {
            // ExStart:CreateAndSavePageRange
            // ExFor:Document
            // ExFor:Page
            // ExFor:Page.Title
            // ExFor:Title
            // ExFor:Title.TitleText
            // ExFor:Title.TitleDate
            // ExFor:Title.TitleTime
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExFor:HtmlSaveOptions
            // ExFor:SaveOptions.PageCount
            // ExFor:SaveOptions.PageIndex
            // ExSummary:Shows how to create a document and save in html format specified range of pages.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize OneNote document
            Document doc = new Document();

            Page page = doc.AppendChildLast(new Page());
     
            // Default style for all text in the document.
            ParagraphStyle textStyle = new ParagraphStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title()
                         {
                             TitleText = new RichText() { Text = "Title text.", ParagraphStyle = textStyle },
                             TitleDate = new RichText() { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), ParagraphStyle = textStyle },
                             TitleTime = new RichText() { Text = "12:34", ParagraphStyle = textStyle }
                         };

            // Save into HTML format
            dataDir = dataDir + "CreateAndSavePageRange_out.html";
            doc.Save(dataDir, new HtmlSaveOptions
                              {
                                  PageCount = 1,
                                  PageIndex = 0
                              });

            // ExEnd:CreateAndSavePageRange
            Console.WriteLine("\nOneNote document created successfully and saved as page range.\nFile saved at " + dataDir);
        }

        public static void SaveAsHTMLToMemoryStreamWithEmbeddedResources()
        {
            // ExStart: SaveAsHTMLToMemoryStream
            // ExFor:Document
            // ExFor:HtmlSaveOptions
            // ExFor:HtmlSaveOptions.ExportCss
            // ExFor:HtmlSaveOptions.ExportFonts
            // ExFor:HtmlSaveOptions.ExportImages
            // ExFor:HtmlSaveOptions.FontFaceTypes
            // ExSummary:Shows how to save a document to a stream in html format with embedding of all resources(css/fonts/images).
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            var document = new Document(Path.Combine(dataDir, "Aspose.one"));

            var options = new HtmlSaveOptions()
                         {
                             ExportCss = ResourceExportType.ExportEmbedded,
                             ExportFonts = ResourceExportType.ExportEmbedded,
                             ExportImages = ResourceExportType.ExportEmbedded,
                             FontFaceTypes = FontFaceType.Ttf
                         };
            
            var r = new MemoryStream();
            document.Save(r, options);

            // ExEnd: SaveAsHTMLToMemoryStream
        }

        public static void SaveAsHTMLToFileWithResourcesInSeparateFiles()
        {
            // ExStart: SaveAsHTMLWithResourcesInSeparateFiles
            // ExFor:Document
            // ExFor:HtmlSaveOptions
            // ExFor:HtmlSaveOptions.ExportCss
            // ExFor:HtmlSaveOptions.ExportFonts
            // ExFor:HtmlSaveOptions.ExportImages
            // ExFor:HtmlSaveOptions.FontFaceTypes
            // ExSummary:Shows how to save a document in html format with storing all resources(css/fonts/images) to a separate files.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            var document = new Document(Path.Combine(dataDir, "Aspose.one"));

            var options = new HtmlSaveOptions()
                         {
                             ExportCss = ResourceExportType.ExportAsStream,
                             ExportFonts = ResourceExportType.ExportAsStream,
                             ExportImages = ResourceExportType.ExportAsStream,
                             FontFaceTypes = FontFaceType.Ttf
                         };
            document.Save(dataDir + "document_out.html", options);

            // ExEnd: SaveAsHTMLWithResourcesInSeparateFiles
        }

        public static void SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources()
        {
            // ExStart: SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources
            // ExFor:Document
            // ExFor:HtmlSaveOptions
            // ExFor:HtmlSaveOptions.CssSavingCallback
            // ExFor:HtmlSaveOptions.FontSavingCallback
            // ExFor:HtmlSaveOptions.ImageSavingCallback
            // ExFor:HtmlSaveOptions.FontFaceTypes
            // ExSummary:Shows how to save a document in html format with storing all resources(css/fonts/images) by using user-defined callbacks.

            // The code below creates 'documentFolder' folder containing document.html, 'css' folder with 'style.css' file, 'images' folder with images and 'fonts' folder with fonts.
            // 'style.css' file will contain at the end the following string "/* This line is appended to stream manually by user */"
            var savingCallbacks = new UserSavingCallbacks()
                                      {
                                          RootFolder = "documentFolder",
                                          CssFolder = "css",
                                          KeepCssStreamOpened = true,
                                          ImagesFolder = "images",
                                          FontsFolder = "fonts"
                                      };
            var options = new HtmlSaveOptions
                          {
                              FontFaceTypes = FontFaceType.Ttf,
                              CssSavingCallback = savingCallbacks,
                              FontSavingCallback = savingCallbacks,
                              ImageSavingCallback = savingCallbacks
                          };

            if (!Directory.Exists(savingCallbacks.RootFolder))
            {
                Directory.CreateDirectory(savingCallbacks.RootFolder);
            }

            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            var document = new Document(Path.Combine(dataDir, "Aspose.one"));

            using (var stream = File.Create(Path.Combine(savingCallbacks.RootFolder, "document.html")))
            {
                document.Save(stream, options);
            }

            using (var writer = new StreamWriter(savingCallbacks.CssStream))
            {
                writer.WriteLine();
                writer.WriteLine("/* This line is appended to stream manually by user */");
            }

            // ExEnd: SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources
        }
    }
}