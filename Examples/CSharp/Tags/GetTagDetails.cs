
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tags
{
    public class GetTagDetails
    {
        public static void Run()
        {
            // ExStart:GetTagDetails
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "TagFile.one");

            // Get all RichText nodes
            IList<RichText> nodes = oneFile.GetChildNodes<RichText>();

            // Iterate through each node
            foreach (RichText richText in nodes)
            {
                foreach (var tag in richText.Tags)
                {
                    if (tag is NoteTag)
                    {
                        NoteTag noteTag = (NoteTag)tag;
                        // Retrieve properties
                        Console.WriteLine("Completed Time: " + noteTag.CompletedTime);
                        Console.WriteLine("Create Time: " + noteTag.CreationTime);
                        Console.WriteLine("Font Color: " + noteTag.FontColor);
                        Console.WriteLine("Status: " + noteTag.Status);
                        Console.WriteLine("Label: " + noteTag.Label);
                        Console.WriteLine("Icon: " + noteTag.Icon);
                        Console.WriteLine("High Light: " + noteTag.Highlight);
                    }
                }
            }

            // ExEnd:GetTagDetails
        }
    }
}