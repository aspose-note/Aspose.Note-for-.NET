// -----------------------------------------------------------------------
//  <copyright file="ImportFromPdf.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Import
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Aspose.Note.Importing;

    public class ImportFromPdf
    {
        public static void Run()
        {
            ImportSetOfFiles_SimpleMerge();
            ImportSetOfFiles_StructuredMerge();
            ImportSetOfFiles_SinglePageMerge();
            ImportSetOfFiles_CustomMerge();
        }

        public static void ImportSetOfFiles_SimpleMerge()
        {
            // ExStart:ImportSetOfFiles_SimpleMerge
            // ExFor:Document.Import(System.String,PdfImportOptions,MergeOptions)
            // ExSummary:Shows how to import all pages from a set of PDF documents page by page.
            string dataDir = RunExamples.GetDataDir_Import();

            var d = new Document();

            d.Import(Path.Combine(dataDir, "sampleText.pdf"))
             .Import(Path.Combine(dataDir, "sampleImage.pdf"))
             .Import(Path.Combine(dataDir, "sampleTable.pdf"));

            d.Save(Path.Combine(dataDir, "sample_SimpleMerge.one"));

            // ExEnd:ImportSetOfFiles_SimpleMerge

            Console.WriteLine("\nThe PDF document is imported successfully.");
        }

        public static void ImportSetOfFiles_StructuredMerge()
        {
            // ExStart:ImportSetOfFiles_StructuredMerge
            // ExFor:Document.Import(System.String,PdfImportOptions,MergeOptions)
            // ExFor:MergeOptions
            // ExFor:MergeOptions.InsertAt
            // ExFor:MergeOptions.InsertAsChild
            // ExSummary:Shows how to import all pages from a set of PDF documents while inserting pages from every PDF document as children of a top level OneNote page.
            string dataDir = RunExamples.GetDataDir_Import();

            var d = new Document();

            foreach (var file in new[] { "sampleText.pdf", "sampleImage.pdf", "sampleTable.pdf" })
            {
                d.AppendChildLast(new Page()).Title = new Title() { TitleText = new RichText() { ParagraphStyle = ParagraphStyle.Default }.Append(file) };
                d.Import(Path.Combine(dataDir, file), new PdfImportOptions(), new MergeOptions() { InsertAt = int.MaxValue, InsertAsChild = true });
            }

            d.Save(Path.Combine(dataDir, "sample_StructuredMerge.one"));

            // ExEnd:ImportSetOfFiles_StructuredMerge

            Console.WriteLine("\nThe PDF document is imported successfully.");
        }

        public static void ImportSetOfFiles_SinglePageMerge()
        {
            // ExStart:ImportSetOfFiles_SinglePageMerge
            // ExFor:Document.Import(System.String,PdfImportOptions,MergeOptions)
            // ExFor:MergeOptions
            // ExFor:MergeOptions.ImportAsSinglePage
            // ExFor:MergeOptions.PageSpacing
            // ExSummary:Shows how to import all content from a set of PDF documents while merging pages from every PDF document to a single OneNote page.
            string dataDir = RunExamples.GetDataDir_Import();

            var d = new Document();

            var importOptions = new PdfImportOptions();
            var mergeOptions = new MergeOptions() { ImportAsSinglePage = true, PageSpacing = 100 };

            d.Import(Path.Combine(dataDir, "sampleText.pdf"), importOptions, mergeOptions)
             .Import(Path.Combine(dataDir, "sampleImage.pdf"), importOptions, mergeOptions)
             .Import(Path.Combine(dataDir, "sampleTable.pdf"), importOptions, mergeOptions);

            d.Save(Path.Combine(dataDir, "sample_SinglePageMerge.one"));

            // ExEnd:ImportSetOfFiles_SinglePageMerge

            Console.WriteLine("\nThe PDF document is imported successfully.");
        }


        public static void ImportSetOfFiles_CustomMerge()
        {
            // ExStart:ImportSetOfFiles_CustomMerge
            // ExFor:PdfImporter
            // ExFor:PdfImporter.Import(System.String,PdfImportOptions)
            // ExFor:Document.Merge
            // ExFor:MergeOptions
            // ExFor:MergeOptions.ImportAsSinglePage
            // ExFor:MergeOptions.PageSpacing
            // ExSummary:Shows how to import all pages from PDF document grouping every 5 pages to a single OneNote page.
            string dataDir = RunExamples.GetDataDir_Import();

            var d = new Document();

            var mergeOptions = new MergeOptions() { ImportAsSinglePage = true, PageSpacing = 100 };

            IEnumerable<Page> pages = PdfImporter.Import(Path.Combine(dataDir, "SampleGrouping.pdf"));
            while (pages.Any())
            {
                d.Merge(pages.Take(5), mergeOptions);
                pages = pages.Skip(5);
            }

            d.Save(Path.Combine(dataDir, "sample_CustomMerge.one"));

            // ExEnd:ImportSetOfFiles_CustomMerge

            Console.WriteLine("\nThe PDF document is imported successfully.");
        }
    }
}
