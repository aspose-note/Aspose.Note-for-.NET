using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.PrintingDocument
{
    class PrintDocument
    {
        public static void Run()
        {
            // ExStart:PrintDocument
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            var document = new Aspose.Note.Document(dataDir + "Aspose.one");

            document.Print();
            // ExEnd:PrintDocument
        }
    }
}
