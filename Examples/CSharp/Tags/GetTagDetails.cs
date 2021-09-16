
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tags
{
    using System.Linq;

    public class GetTagDetails
    {
        public static void Run()
        {
            // ExStart:GetTagDetails
            // ExFor:ITag
            // ExFor:ITag.CompletedTime
            // ExFor:ITag.CreationTime
            // ExFor:ITag.Icon
            // ExFor:ITag.Label
            // ExFor:ITag.Status
            // ExFor:INoteTag
            // ExFor:INoteTag.FontColor
            // ExFor:INoteTag.Highlight
            // ExFor:NoteTag
            // ExFor:RichText
            // ExFor:RichText.Text
            // ExFor:RichText.ParagraphStyle
            // ExSummary:Shows how to access details of a tag.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "TagFile.one");

            // Get all RichText nodes
            IList<RichText> nodes = oneFile.GetChildNodes<RichText>();

            // Iterate through each node
            foreach (RichText richText in nodes)
            {
                var tags = richText.Tags.OfType<NoteTag>();
                if (tags.Any())
                {
                    Console.WriteLine($"Text: {richText.Text}");
                    foreach (var noteTag in tags)
                    {
                        // Retrieve properties
                        Console.WriteLine($"    Completed Time: {noteTag.CompletedTime}");
                        Console.WriteLine($"    Create Time: {noteTag.CreationTime}");
                        Console.WriteLine($"    Font Color: {noteTag.FontColor}");
                        Console.WriteLine($"    Status: {noteTag.Status}");
                        Console.WriteLine($"    Label: {noteTag.Label}");
                        Console.WriteLine($"    Icon: {noteTag.Icon}");
                        Console.WriteLine($"    High Light: {noteTag.Highlight}");
                    }
                }
            }

            // ExEnd:GetTagDetails
        }
    }
}