using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.NoteBook
{
    class ReadRichText
    {
        public static void Run()
        {
            // ExStart:ReadRichText
            // ExFor:Notebook
            // ExSummary:Shows how to get all text from a notebook.

            string inputFile = "notebook.onetoc2";
            string dataDir = RunExamples.GetDataDir_NoteBook();

            Notebook rootNotebook = new Notebook(dataDir + inputFile);

            IList<RichText> allRichTextNodes = rootNotebook.GetChildNodes<RichText>();
            foreach (RichText richTextNode in allRichTextNodes)
            {
	            Console.WriteLine(richTextNode.Text);
            }

            // ExEnd:ReadRichText
        }
    }
}
