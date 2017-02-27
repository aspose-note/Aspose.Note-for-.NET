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
            // ExStart:SaveDocToOneNoteFormatUsingOnesaveoptions
            string inputFile = "Sample1.one";
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string outputFile = "SaveDocToOneNoteFormatUsingOnesaveoptions_out.one";

            Document document = new Document(dataDir + inputFile);

            document.Save(dataDir + outputFile, new OneSaveOptions());
            // ExEnd:SaveDocToOneNoteFormatUsingOnesaveoptions
        }
    }
}
