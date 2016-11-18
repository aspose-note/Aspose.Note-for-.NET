using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Attachments
{
    public class AttachFileByPath
    {
        public static void Run()
        {
            // ExStart:AttachFileByPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Attachments();

            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);
            // Initialize Outline class object
            Outline outline = new Outline(doc);
            // Initialize OutlineElement class object
            OutlineElement outlineElem = new OutlineElement(doc);
            // Initialize AttachedFile class object
            AttachedFile attachedFile = new AttachedFile(doc,  dataDir + "attachment.txt");
            // Add attached file
            outlineElem.AppendChild(attachedFile);
            // Add outline element node
            outline.AppendChild(outlineElem);
            // Add outline node
            page.AppendChild(outline);
            // Add page node
            doc.AppendChild(page);
            dataDir = dataDir + "AttachFileByPath_out.one";
            doc.Save(dataDir);
            // ExEnd:AttachFileByPath      

            Console.WriteLine("\nFile by path attached successfully.\nFile saved at " + dataDir);
                  
        }        
    }
}