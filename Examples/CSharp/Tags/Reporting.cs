// -----------------------------------------------------------------------
//  <copyright file="Reporting.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2021 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Tags
{
    using System;
    using System.IO;
    using System.Linq;

    public class Reporting
    {
        public static void Run()
        {
            GenerateReport_IncompleteItemsFromLastWeek();
            GenerateReport_IncompleteOutlookTasksForThisWeek();
            GenerateReport_ItemsRelatedToSpecifiedProject();
        }

        public static void GenerateReport_IncompleteItemsFromLastWeek()
        {
            // ExStart:GenerateReport_IncompleteItemsFromLastWeek
            // ExFor:ITaggable
            // ExFor:ITag
            // ExFor:ITag.CreationTime
            // ExFor:CheckBox
            // ExFor:CheckBox.Checked
            // ExSummary:Shows how to generate a pdf containing pages with items marked by incomplete checkboxes and created during last week.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            var oneFile = new Document(Path.Combine(dataDir, "TagFile.one"));

            var report = new Document();
            foreach (var page in oneFile)
            {
                if (page.GetChildNodes<ITaggable>().Any(e => e.Tags.OfType<CheckBox>().Any(x => !x.Checked && DateTime.UtcNow.Subtract(TimeSpan.FromDays(7)) <= x.CreationTime)))
                {
                    report.AppendChildLast(page.Clone());
                }
            }

            report.Save(Path.Combine(dataDir, "IncompleteLastWeekReport.pdf"));

            // ExEnd:GenerateReport_IncompleteItemsFromLastWeek
        }

        public static void GenerateReport_IncompleteOutlookTasksForThisWeek()
        {
            // ExStart:GenerateReport_IncompleteOutlookTasksForThisWeek
            // ExFor:ITaggable
            // ExFor:ITag
            // ExFor:ITag.CreationTime
            // ExFor:CheckBox
            // ExFor:CheckBox.Checked
            // ExSummary:Shows how to generate a pdf containing pages with Outlook incomplete tasks to complete on this week.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            var oneFile = new Document(Path.Combine(dataDir, "TagFile.one"));

            var report = new Document();
            var endOfWeek = DateTime.Today.AddDays(5 - (int)DateTime.Today.DayOfWeek);
            foreach (var page in oneFile)
            {
                if (page.GetChildNodes<ITaggable>().Any(e => e.Tags.OfType<NoteTask>().Any(x => !x.Checked && DateTime.UtcNow.Subtract(TimeSpan.FromDays(7)) <= x.CreationTime && x.DueDate <= endOfWeek)))
                {
                    report.AppendChildLast(page.Clone());
                }
            }

            report.Save(Path.Combine(dataDir, "IncompleteTasksForThisWeekReport.pdf"));

            // ExEnd:GenerateReport_IncompleteOutlookTasksForThisWeek
        }

        public static void GenerateReport_ItemsRelatedToSpecifiedProject()
        {
            // ExStart:GenerateReport_ItemsRelatedToSpecifiedProject
            // ExFor:ITaggable
            // ExFor:ITag
            // ExFor:ITag.CreationTime
            // ExFor:CheckBox
            // ExFor:CheckBox.Checked
            // ExFor:NoteTask
            // ExFor:NoteTask.DueDate
            // ExSummary:Shows how to generate a pdf containing all pages related to 'Project A'.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tags();

            // Load the document into Aspose.Note.
            var oneFile = new Document(Path.Combine(dataDir, "ProjectNotes.one"));

            var report = new Document();
            foreach (var page in oneFile)
            {
                if (page.GetChildNodes<ITaggable>().Any(e => e.Tags.Any(x => x.Label.Contains("Project A"))))
                {
                    report.AppendChildLast(page.Clone());
                }
            }

            report.Save(Path.Combine(dataDir, "ProjectA_Report.pdf"));

            // ExEnd:GenerateReport_ItemsRelatedToSpecifiedProject
        }
    }
}
