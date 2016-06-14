
using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.Tasks
{
    public class GetOutlookTaskDetails
    {
        public static void Run()
        {
            // ExStart:GetOutlookTaskDetails
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tasks();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get all RichText nodes
            IList<RichText> nodes = oneFile.GetChildNodes<RichText>();

            // Iterate through each node
            foreach (RichText richText in nodes)
            {
                foreach (var tag in richText.Tags)
                {
                    if (tag is NoteTask)
                    {
                        NoteTask noteTask = (NoteTask)tag;
                        // Retrieve properties
                        Console.WriteLine("Completed Time: " + noteTask.CompletedTime);
                        Console.WriteLine("Create Time: " + noteTask.CreationTime);
                        Console.WriteLine("Due Date: " + noteTask.DueDate);
                        Console.WriteLine("Status: " + noteTask.Status);
                        Console.WriteLine("Task Type: " + noteTask.TaskType);
                        Console.WriteLine("Icon: " + noteTask.Icon);
                    }
                }
            }
            // ExEnd:GetOutlookTaskDetails
        }
    }
}