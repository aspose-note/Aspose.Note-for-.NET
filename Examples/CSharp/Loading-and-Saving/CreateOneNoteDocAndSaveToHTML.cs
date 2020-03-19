using System.IO;
using Aspose.Note;
using System;
using System.Drawing;
using System.Globalization;
using Aspose.Note.Saving;
using Aspose.Note.Saving.Html;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class CreateOneNoteDocAndSaveToHTML
    {
        public static void Run()
        {
            // ExStart:CreateOneNoteDocAndSaveToHTML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize OneNote document
            Document doc = new Document();
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            
            // Default style for all text in the document.
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc) { Text = "Title text.", DefaultStyle = textStyle },
                TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), DefaultStyle = textStyle },
                TitleTime = new RichText(doc) { Text = "12:34", DefaultStyle = textStyle }
            };
            doc.AppendChildLast(page);
            dataDir = dataDir + "CreateOneNoteDocAndSaveToHTML_out.html";
            // Save as HTML format
            doc.Save(dataDir);
            // ExEnd:CreateOneNoteDocAndSaveToHTML
            Console.WriteLine("\nOneNote document created successfully.\nFile saved at " + dataDir);
        }

        public static void CreateAndSavePageRange()
        {
            // ExStart:CreateAndSavePageRange
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Initialize OneNote document
            Document doc = new Document();

            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Default style for all text in the document.
            TextStyle textStyle = new TextStyle { FontColor = Color.Black, FontName = "Arial", FontSize = 10 };
            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc) { Text = "Title text.", DefaultStyle = textStyle },
                TitleDate = new RichText(doc) { Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), DefaultStyle = textStyle },
                TitleTime = new RichText(doc) { Text = "12:34", DefaultStyle = textStyle }
            };
            doc.AppendChildLast(page);

            dataDir = dataDir + "CreateAndSavePageRange_out.html";
            // Save as HTML format
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
            //ExStart: SaveAsHTMLToMemoryStream
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            var document = new Aspose.Note.Document(dataDir + "Aspose.one");

            var options = new HtmlSaveOptions()
            {
                ExportCss = ResourceExportType.ExportEmbedded,
                ExportFonts = ResourceExportType.ExportEmbedded,
                ExportImages = ResourceExportType.ExportEmbedded,
                FontFaceTypes = FontFaceType.Ttf
            };
            var r = new MemoryStream();
            document.Save(r, options);
            //ExEnd: SaveAsHTMLToMemoryStream
        }

        public static void SaveAsHTMLToFileWithResourcesInSeparateFiles()
        {
            //ExStart: SaveAsHTMLWithResourcesInSeparateFiles
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            var document = new Aspose.Note.Document(dataDir + "Aspose.one");

            var options = new HtmlSaveOptions()
            {
                ExportCss = ResourceExportType.ExportEmbedded,
                ExportFonts = ResourceExportType.ExportEmbedded,
                ExportImages = ResourceExportType.ExportEmbedded,
                FontFaceTypes = FontFaceType.Ttf
            };
            document.Save(dataDir + "document_out.html", options);
            //ExEnd: SaveAsHTMLWithResourcesInSeparateFiles
        }


        public static void SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources()
        {
            //ExStart: SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources
            // This code creates documentFolder containing document.html, css folder with style.css file, images folder with images and fonts folder with fonts.
            // style.css file will contains at the end the following string "/* This line is appended to stream manually by user */"
            var options = new HtmlSaveOptions()
            {
                FontFaceTypes = FontFaceType.Ttf
            };
            var savingCallbacks = new UserSavingCallbacks()
            {
                RootFolder = "documentFolder",
                CssFolder = "css",
                KeepCssStreamOpened = true,
                ImagesFolder = "images",
                FontsFolder = "fonts"
            };
            options.CssSavingCallback = savingCallbacks;
            options.FontSavingCallback = savingCallbacks;
            options.ImageSavingCallback = savingCallbacks;

            if (!Directory.Exists(savingCallbacks.RootFolder))
            {
                Directory.CreateDirectory(savingCallbacks.RootFolder);
            }

            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            var document = new Aspose.Note.Document(dataDir + "Aspose.one");

            using (var stream = File.Create(Path.Combine(savingCallbacks.RootFolder, "document.html")))
            {
                document.Save(stream, options);
            }

            using (var writer = new StreamWriter(savingCallbacks.CssStream))
            {
                writer.WriteLine();
                writer.WriteLine("/* This line is appended to stream manually by user */");
            }
            //ExEnd: SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources
        }
    }
}