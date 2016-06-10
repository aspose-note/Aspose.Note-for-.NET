
using System.IO;
using Aspose.Note;
using System;

namespace CSharp.Loading_Saving
{
    public class NodeTypeEnumeration
    {
        public static void Run()
        {
            // ExStart:NodeTypeEnumeration
            // The path to the documents directory.
            Document doc = new Document();

            // Returns NodeType.Document
            NodeType type = doc.NodeType;
            // ExEnd:NodeTypeEnumeration
           
        }
    }
}