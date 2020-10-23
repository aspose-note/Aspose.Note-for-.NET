using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Attachments
{
    public class RetrieveAttachedFiles
    {
        public static void Run()
        {
            // ExStart:RetrieveAttachedFiles
            // ExFor:Document
            // ExFor:AttachedFile
            // ExFor:AttachedFile.Bytes
            // ExSummary:Shows how to get content of an attached file.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Attachments();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Sample1.one");

            // Get a list of attached file nodes
            IList<AttachedFile> nodes = oneFile.GetChildNodes<AttachedFile>();

            // Iterate through all nodes
            foreach (AttachedFile file in nodes)
            {
                // Load attached file to a stream object
                using (Stream outputStream = new MemoryStream(file.Bytes))
                {
                    // Create a local file
                    using (Stream fileStream = System.IO.File.OpenWrite(String.Format(dataDir + file.FileName)))
                    {
                        // Copy file stream
                        CopyStream(outputStream, fileStream);
                    }
                }
            }

            // ExEnd:RetrieveAttachedFiles            
        }

        private static void CopyStream(Stream input, Stream output)
        {
            try
            {
                byte[] buffer = new byte[8 * 1024];
                int len;
                while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, len);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}