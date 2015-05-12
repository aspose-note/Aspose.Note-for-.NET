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

namespace ReplaceTextOnParticularPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Dictionary<string, string> replacements = new Dictionary<string, string>();
            replacements.Add("Some task here", "New Text Here");

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            IList<Node> pageNodes = oneFile.GetChildNodes(NodeType.Page);
            CompositeNode compositeNode = (CompositeNode)pageNodes[0];

            // Get all RichText nodes
            IList<Node> textNodes = compositeNode.GetChildNodes(NodeType.RichText);

            foreach (Node node in textNodes)
            {
                foreach (KeyValuePair<string, string> kvp in replacements)
                {
                    RichText richText = (RichText)node;
                    if (richText != null && richText.Text.Contains(kvp.Key))
                    {
                        // Replace text of a shape
                        richText.Text = richText.Text.Replace(kvp.Key, kvp.Value);
                    }
                }
            }

            // Save to any supported file format
            oneFile.Save(dataDir + "Output.pdf", SaveFormat.Pdf);
 
            
        }
    }
}