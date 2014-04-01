//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Note. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Note;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace ExtractImages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");
            // Get all Image nodes
            IList<Node> nodes = oneFile.GetChildNodes(NodeType.Image);

            foreach (Aspose.Note.Image image in nodes)
            {
                using (MemoryStream stream = new MemoryStream(image.Bytes))
                {
                    using (Bitmap bitMap = new Bitmap(stream))
                    {
                        // Save image bytes to a file
                        bitMap.Save(String.Format(dataDir + "{0}", Path.GetFileName(image.FileName)));
                    }
                }
            }
 
        }
    }
}