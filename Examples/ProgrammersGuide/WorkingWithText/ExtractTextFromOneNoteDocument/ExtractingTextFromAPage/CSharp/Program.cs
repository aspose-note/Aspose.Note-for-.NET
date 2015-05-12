//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Note. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Note;
using System;
using System.Collections.Generic;

namespace ExtractingTextFromAPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            // Get list of page nodes
            IList<Node> nodes = oneFile.GetChildNodes(NodeType.Page);

            if (nodes.Count > 0 && nodes[0].NodeType == NodeType.Page)
            {
                Page page = (Page)nodes[0];
                // Retrieve text
                string text = page.GetText();
                // Print text on the output screen
                Console.WriteLine(text);
            }

        }
    }
}