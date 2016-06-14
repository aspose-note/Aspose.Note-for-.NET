using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class RetreivingFileFormat
    {
        public static void Run()
        {
            // ExStart:RetreivingFileFormat
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            var document = new Aspose.Note.Document(dataDir + "Aspose.one");
            //switch (document.FileFormat)
            //{
            //    case FileFormat.OneNote2010:
            //        // process OneNote 2010
            //        break;
            //    case FileFormat.OneNoteOnline:
            //        // process OneNote Online
            //        break;
            //}
            // ExEnd:RetreivingFileFormat           
        }
    }
}