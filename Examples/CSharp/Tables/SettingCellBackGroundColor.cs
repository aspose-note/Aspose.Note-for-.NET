using System.IO;
using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Aspose.Note.Examples.CSharp.Tables
{
    public class SettingCellBackGroundColor
    {
        public static void Run()
        {
            // ExStart:SettingCellBackGroundColor
            // Create an object of the Document class
            Document doc = new Document();
            // Initialize Page class object
            Aspose.Note.Page page = new Aspose.Note.Page(doc);

            // Initialize TableRow class object
            TableRow row1 = new TableRow(doc);
            // Initialize TableCell class object and set text content
            TableCell cell11 = new TableCell(doc);
            cell11.AppendChildLast(InsertTable.GetOutlineElementWithText(doc, "Small text"));
            cell11.BackgroundColor = Color.Coral;
            row1.AppendChildLast(cell11);  
            // ExEnd:SettingCellBackGroundColor
        }
    }
}