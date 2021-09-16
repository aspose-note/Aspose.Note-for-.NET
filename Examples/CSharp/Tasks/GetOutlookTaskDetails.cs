
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tasks
{
    using System.Linq;

    public class GetOutlookTaskDetails
    {
        public static void Run()
        {
            // ExStart:GetOutlookTaskDetails
            // ExFor:RichText.Tags
            // ExFor:ITag
            // ExFor:ITag.CompletedTime
            // ExFor:ITag.CreationTime
            // ExFor:ITag.Icon
            // ExFor:ITag.Status
            // ExFor:NoteTask
            // ExFor:NoteTask.DueDate
            // ExSummary:Shows how to access details of outlook's tasks.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tasks();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get all RichText nodes
            IList<RichText> nodes = oneFile.GetChildNodes<RichText>();

            // Iterate through each node
            foreach (RichText richText in nodes)
            {
                var tasks = richText.Tags.OfType<NoteTask>();
                if (tasks.Any())
                {
                    Console.WriteLine($"Task: {richText.Text}");
                    foreach (var noteTask in tasks)
                    {
                        // Retrieve properties
                        Console.WriteLine($"    Completed Time: {noteTask.CompletedTime}");
                        Console.WriteLine($"    Create Time: {noteTask.CreationTime}");
                        Console.WriteLine($"    Due Date: {noteTask.DueDate}");
                        Console.WriteLine($"    Status: {noteTask.Status}");
                        Console.WriteLine($"    Icon: {noteTask.Icon}");
                    }
                }
            }

            // ExEnd:GetOutlookTaskDetails
        }
    }
}