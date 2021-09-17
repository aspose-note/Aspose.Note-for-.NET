// -----------------------------------------------------------------------
//  <copyright file="OpenCloseProjectC.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Tags
{
    using System.IO;
    using System.Linq;

    public class OpenCloseProjectC
    {
        private const string ClosedProjectCNotesFileName = "ProjectNoteWithClosedProjectC.one";

        public static void Run()
        {
            CloseProjectCItems();
            OpenProjectCItems();
        }

        public static void CloseProjectCItems()
        {
            // ExStart:CloseProjectCItems
            // ExFor:ITaggable
            // ExFor:ITag
            // ExFor:ITag.Label
            // ExFor:CheckBox
            // ExFor:CheckBox.Checked
            // ExFor:CheckBox.SetCompleted
            // ExSummary:Shows how to make completed all checkbox items related to 'Project C'.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            var oneFile = new Document(Path.Combine(dataDir, "ProjectNotes.one"));

            foreach (var node in oneFile.GetChildNodes<ITaggable>())
            {
                foreach (var checkBox in node.Tags.OfType<CheckBox>())
                {
                    if (checkBox.Label.Contains("Project C") && !checkBox.Checked)
                    {
                        checkBox.SetCompleted();
                    }
                }
            }

            oneFile.Save(Path.Combine(dataDir, ClosedProjectCNotesFileName));

            // ExEnd:CloseProjectCItems
        }

        public static void OpenProjectCItems()
        {
            // ExStart:OpenProjectCItems
            // ExFor:ITaggable
            // ExFor:ITag
            // ExFor:ITag.Label
            // ExFor:CheckBox
            // ExFor:CheckBox.Checked
            // ExFor:CheckBox.SetOpen
            // ExSummary:Shows how to make open all checkbox items related to 'Project C'.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            var oneFile = new Document(Path.Combine(dataDir, ClosedProjectCNotesFileName));

            foreach (var node in oneFile.GetChildNodes<ITaggable>())
            {
                foreach (var checkBox in node.Tags.OfType<CheckBox>())
                {
                    if (checkBox.Label.Contains("Project C") && checkBox.Checked)
                    {
                        checkBox.SetOpen();
                    }
                }
            }

            oneFile.Save(Path.Combine(dataDir, "ProjectNoteWithOpenProjectC.one"));

            // ExEnd:OpenProjectCItems
        }
    }
}
