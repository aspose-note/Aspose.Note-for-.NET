//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Note. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Note;
using Aspose.Note.Saving;

namespace SaveRangeOfPagesAsPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Initialize PdfSaveOptions object
            PdfSaveOptions opts = new PdfSaveOptions();

            // Set page index
            opts.PageIndex = 0;

            // Set page count
            opts.PageCount = 1;

            // Save the document as PDF
            oneFile.Save(dataDir + "output.pdf", opts);
        }
    }
}