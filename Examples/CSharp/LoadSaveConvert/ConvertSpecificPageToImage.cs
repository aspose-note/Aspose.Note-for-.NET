//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Note. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Note;
using Aspose.Note.Saving;

namespace Aspose.Note.Examples.LoadSaveConvert
{
    public class ConvertSpecificPageToImage
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Initialize ImageSaveOptions object 
            ImageSaveOptions opts = new ImageSaveOptions(SaveFormat.Png);
            
            // set page index
            opts.PageIndex = 1;

            // Save the document as PNG.
            oneFile.Save(dataDir + "output.png", opts);
        }
    }
}