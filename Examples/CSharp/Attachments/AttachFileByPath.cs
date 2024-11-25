using System;

namespace Aspose.Note.Examples.CSharp.Attachments
{
    public class AttachFileByPath
    {
        public static void Run()
        {
            // ExStart:AttachFileByPath
            // ExFor:Document
            // ExFor:AttachedFile
            // ExSummary:Shows how to add a file to a document by using filepath.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Attachments();

            // Create an object of the Document class
            Document doc = new Document();
            
            // Initialize Page class object
            Page page = new Page();
            
            // Initialize Outline class object
            Outline outline = new Outline();
            
            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement();
            
            // Initialize AttachedFile class object
            AttachedFile attachedFile = new AttachedFile(dataDir + "attachment.txt");
            
            // Add attached file
            outlineElem.AppendChildLast(attachedFile);
            
            // Add outline element node
            outline.AppendChildLast(outlineElem);
            
            // Add outline node
            page.AppendChildLast(outline);
            
            // Add page node
            doc.AppendChildLast(page);
            
            dataDir = dataDir + "AttachFileByPath_out.one";
            doc.Save(dataDir);
            
            // ExEnd:AttachFileByPath      

            Console.WriteLine("\nFile by path attached successfully.\nFile saved at " + dataDir);
                  
        }        
    }
}