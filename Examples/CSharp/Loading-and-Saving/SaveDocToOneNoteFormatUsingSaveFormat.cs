using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    class SaveDocToOneNoteFormatUsingSaveFormat
    {
        public static void Run()
        {
            // ExStart:SaveDocToOneNoteFormatUsingSaveFormat
            // ExFor:Document
            // ExFor:Document.Save(System.String, Aspose.Note.SaveFormat)
            // ExFor:SaveFormat
            // ExSummary:Shows how to save a document using SaveFormat enumeration.

            string inputFile = "Sample1.one";
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string outputFile = "SaveDocToOneNoteFormatUsingSaveFormat_out.one";

            Document document = new Document(dataDir + inputFile);

            document.Save(dataDir + outputFile, SaveFormat.One);

            // ExEnd:SaveDocToOneNoteFormatUsingSaveFormat
        }
    }
}
