using System.IO;
using Aspose.Note;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class PasswordProtectedDoc
    {
        public static void Run()
        {
            // ExStart:PasswordProtectedDoc
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            LoadOptions loadOptions = new LoadOptions
            {
                DocumentPassword = "password"
            };
            Document doc = new Document(dataDir + "Sample1.one", loadOptions);
            
            // ExEnd:PasswordProtectedDoc
            Console.WriteLine("\nPassword protected document loaded successfully.");
        }
    }
}