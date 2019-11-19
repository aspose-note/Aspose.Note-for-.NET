using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace Aspose.Note.Examples.CSharp.Attachments
{
    public class AttachFileAndSetIcon
    {
        public static void Run()
        {
            // ExStart:AttachFileAndSetIcon
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
            // Initialize AttachedFile class object and also pass its icon path
            AttachedFile attachedFile = new AttachedFile(doc, dataDir + "attachment.txt", File.OpenRead(dataDir  + "icon.jpg"), ImageFormat.Jpeg);
            // Add attached file
            outlineElem.AppendChildLast(attachedFile);
            // Add outline element node
            outline.AppendChildLast(outlineElem);
            // Add outline node
            page.AppendChildLast(outline);
            // Add page node
            doc.AppendChildLast(page);

            dataDir = dataDir + "AttachFileAndSetIcon_out.one";
            doc.Save(dataDir);
            // ExEnd:AttachFileAndSetIcon      

            Console.WriteLine("\nFile attached and it's icon setup successfully.\nFile saved at " + dataDir);
                  
        }        
    }
}