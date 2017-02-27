using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    class SaveDocToOneNoteFormat
    {
        public static void Run()
        {
            // ExStart:SaveDocToOneNoteFormat
            string inputFile = "Sample1.one";
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string outputFile = "SaveDocToOneNoteFormat_out.one";
            
            Document doc = new Document(dataDir + inputFile);
            doc.Save(dataDir + outputFile);
            // ExEnd:SaveDocToOneNoteFormat
        }
    }
}
