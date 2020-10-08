using Aspose.Note.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    class SaveDocToOneNoteFormatUsingOnesaveoptions
    {
        public static void Run()
        {
            // ExStart:SaveDocToOneNoteFormatUsingOneSaveOptions
            // ExFor:Document
            // ExFor:Document.Save(System.String, Aspose.Note.Saving.SaveOptions)
            // ExFor:OneSaveOptions
            // ExSummary:Shows how to save a document using OneSaveOptions.

            string inputFile = "Sample1.one";
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string outputFile = "SaveDocToOneNoteFormatUsingOneSaveOptions_out.one";

            Document document = new Document(dataDir + inputFile);

            document.Save(dataDir + outputFile, new OneSaveOptions());

            // ExEnd:SaveDocToOneNoteFormatUsingOneSaveOptions
        }
    }
}
