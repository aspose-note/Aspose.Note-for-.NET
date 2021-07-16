using System;
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class LoadOneNoteDoc
    {
        public static void Run()
        {
            SimpleLoadNotebook();
            Document_CheckIfEncryptedAndLoad();
            Document_CheckIfEncryptedByPasswordAndLoad();
        }

        public static void SimpleLoadNotebook()
        {
            // ExStart:SimpleLoadNotebook
            // ExFor:Notebook
            // ExFor:Document
            // ExSummary:Shows how to pass through content of a notebook.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string fileName = "Open Notebook.onetoc2";
            try
            {
                var notebook = new Notebook(dataDir + fileName);
                foreach (var notebookChildNode in notebook)
                {
                    Console.WriteLine(notebookChildNode.DisplayName);
                    if (notebookChildNode is Document)
                    {
                        // Do something with child document
                    }
                    else if (notebookChildNode is Notebook)
                    {
                        // Do something with child notebook
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ExEnd:SimpleLoadNotebook
        }

        public static void Document_CheckIfEncryptedAndLoad()
        {
            // ExStart:Document_CheckIfEncryptedAndLoad
            // ExFor:Document
            // ExFor:Document.IsEncrypted(System.IO.Stream,Aspose.Note.LoadOptions,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.IO.Stream,System.String,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.IO.Stream,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.String,Aspose.Note.LoadOptions,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.String,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.String,System.String,Aspose.Note.Document@)
            // ExSummary:Shows how to check if a document is password-protected.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string fileName = Path.Combine(dataDir, "Aspose.one");

            Document document;
            if (!Document.IsEncrypted(fileName, out document))
            {
                Console.WriteLine("The document is loaded and ready to be processed.");
            }
            else
            {
                Console.WriteLine("The document is encrypted. Provide a password.");
            }

            // ExEnd:Document_CheckIfEncryptedAndLoad
        }

        public static void Document_CheckIfEncryptedByPasswordAndLoad()
        {
            // ExStart:Document_CheckIfEncryptedByPasswordAndLoad
            // ExFor:Document
            // ExFor:Document.IsEncrypted(System.IO.Stream,Aspose.Note.LoadOptions,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.IO.Stream,System.String,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.IO.Stream,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.String,Aspose.Note.LoadOptions,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.String,Aspose.Note.Document@)
            // ExFor:Document.IsEncrypted(System.String,System.String,Aspose.Note.Document@)
            // ExSummary:Shows how to check if a document is password-protected by specific password.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();
            string fileName = Path.Combine(dataDir, "Aspose.one");

            Document document;
            if (Document.IsEncrypted(fileName, "VerySecretPassword", out document))
            {
                if (document != null)
                {
                    Console.WriteLine("The document is decrypted. It is loaded and ready to be processed.");
                }
                else
                {
                    Console.WriteLine("The document is encrypted. Invalid password was provided.");
                }
            }
            else
            {
                Console.WriteLine("The document is NOT encrypted. It is loaded and ready to be processed.");
            }

            // ExEnd:Document_CheckIfEncryptedByPasswordAndLoad
        }
    }
}