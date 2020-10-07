using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Pages
{
    class ConflictPageManipulation
    {
        public static void Run()
        {
            // ExStart:ConflictPageManipulation
            // ExFor:Document
            // ExFor:Document.GetPageHistory
            // ExFor:CompositeNode`1.FirstChild
            // ExFor:Page
            // ExFor:Page.PageContentRevisionSummary
            // ExFor:Page.IsConflictPage
            // ExFor:RevisionSummary
            // ExFor:RevisionSummary.AuthorMostRecent
            // ExFor:RevisionSummary.LastModifiedTime
            // ExSummary:Shows how to check if a page is a conflict page(i.e. it has changes that OneNote couldn't automatically merge).

            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document
            Document doc = new Document(dataDir + "Aspose.one", new LoadOptions { LoadHistory = true });

            var history = doc.GetPageHistory(doc.FirstChild);
            for (int i = 0; i < history.Count; i++)
            {
                var historyPage = history[i];
                Console.Write("    {0}. Author: {1}, {2:dd.MM.yyyy hh.mm.ss}",
                                i,
                                historyPage.PageContentRevisionSummary.AuthorMostRecent,
                                historyPage.PageContentRevisionSummary.LastModifiedTime);
                Console.WriteLine(historyPage.IsConflictPage ? ", IsConflict: true" : string.Empty);

                // By default conflict pages are just skipped on saving.
                // If mark it as non-conflict then it will be saved as usual one in the history.
                if (historyPage.IsConflictPage)
                    historyPage.IsConflictPage = false;
            }

            doc.Save(dataDir + "ConflictPageManipulation_out.one", SaveFormat.One);

            // ExEnd:ConflictPageManipulation
        }
}
}
