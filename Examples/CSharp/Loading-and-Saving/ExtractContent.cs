using System.Text;
using System.IO;
using Aspose.Note;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class ExtractContent
    {
        // ExStart:ExtractContent
        // ExFor:Document
        // ExFor:Document.Accept
        // ExFor:DocumentVisitor
        // ExSummary:Shows how to access content of a document using visitor.
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Open the document we want to convert.
            Document doc = new Document(dataDir + "Aspose.one");

            // Create an object that inherits from the DocumentVisitor class.
            MyOneNoteToTxtWriter myConverter = new MyOneNoteToTxtWriter();

            // This is the well known Visitor pattern. Get the model to accept a visitor.
            // The model will iterate through itself by calling the corresponding methods
            // on the visitor object (this is called visiting).
            //
            // Note that every node in the object model has the Accept method so the visiting
            // can be executed not only for the whole document, but for any node in the document.
            doc.Accept(myConverter);

            // Once the visiting is complete, we can retrieve the result of the operation,
            // that in this example, has accumulated in the visitor.
            Console.WriteLine(myConverter.GetText());
            Console.WriteLine(myConverter.NodeCount);            
        }

        /// <summary>
        /// Simple implementation of saving a document in the plain text format. Implemented as a Visitor.
        /// </summary>
        public class MyOneNoteToTxtWriter : DocumentVisitor
        {
            public MyOneNoteToTxtWriter()
            {
                nodecount = 0;
                mIsSkipText = false;
                mBuilder = new StringBuilder();
            }

            /// <summary>
            /// Gets the plain text of the document that was accumulated by the visitor.
            /// </summary>
            public string GetText()
            {
                return mBuilder.ToString();
            }

            /// <summary>
            /// Adds text to the current output. Honors the enabled/disabled output flag.
            /// </summary>
            private void AppendText(string text)
            {
                if (!mIsSkipText)
                {
                    mBuilder.AppendLine(text);
                }
            }

            /// <summary>
            /// Called when a RichText node is encountered in the document.
            /// </summary>
            public override void VisitRichTextStart(RichText run)
            {
                ++nodecount;
                AppendText(run.Text);
            }

            /// <summary>
            /// Called when a Document node is encountered in the document.
            /// </summary>
            public override void VisitDocumentStart(Document document)
            {
                ++nodecount;
            }

            /// <summary>
            /// Called when a Page node is encountered in the document.
            /// </summary>
            public override void VisitPageStart(Page page)
            {
                ++nodecount;
                this.AppendText($"*** Page '{page.Title?.TitleText?.Text ?? "(no title)"}' ***");
            }

            /// <summary>
            /// Called when processing of a Page node is finished.
            /// </summary>
            public override void VisitPageEnd(Page page)
            {
                this.AppendText(string.Empty);
            }

            /// <summary>
            /// Called when a Title node is encountered in the document.
            /// </summary>
            public override void VisitTitleStart(Title title)
            {
                ++nodecount;
            }

            /// <summary>
            /// Called when a Image node is encountered in the document.
            /// </summary>
            public override void VisitImageStart(Image image)
            {
                ++nodecount;
            }

            /// <summary>
            /// Called when a OutlineGroup node is encountered in the document.
            /// </summary>
            public override void VisitOutlineGroupStart(OutlineGroup outlineGroup)
            {
                ++nodecount;
            }

            /// <summary>
            /// Called when a Outline node is encountered in the document.
            /// </summary>
            public override void VisitOutlineStart(Outline outline)
            {
                ++nodecount;
            }

            /// <summary>
            /// Called when a OutlineElement node is encountered in the document.
            /// </summary>
            public override void VisitOutlineElementStart(OutlineElement outlineElement)
            {
                ++nodecount;
            }

            /// <summary>
            /// Gets the total count of nodes by the Visitor
            /// </summary>
            public Int32 NodeCount
            {
                get { return this.nodecount; }
            }

            private readonly StringBuilder mBuilder;
            private bool mIsSkipText;
            private Int32 nodecount;
        }

        // ExEnd:ExtractContent          
    }
}