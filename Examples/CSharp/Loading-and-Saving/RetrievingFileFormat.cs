using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class RetrievingFileFormat
    {
        public static void Run()
        {
            // ExStart:RetrievingFileFormat
            // ExFor:Document
            // ExFor:Document.FileFormat
            // ExSummary:Shows how to get file format of a document.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            var document = new Aspose.Note.Document(dataDir + "Aspose.one");
            switch (document.FileFormat)
            {
                case FileFormat.OneNote2010:
                    // Process OneNote 2010
                    break;
                case FileFormat.OneNoteOnline:
                    // Process OneNote Online
                    break;
            }

            // ExEnd:RetrievingFileFormat           
        }
    }
}