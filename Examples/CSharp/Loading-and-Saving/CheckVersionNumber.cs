
using System.IO;
using Aspose.Note;
using System;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    public class CheckVersionNumber
    {
        public static void Run()
        {
            // ExStart:CheckVersionNumber
            Console.WriteLine("Family: " + AssemblyConstants.Family);
            Console.WriteLine("Platform: " + AssemblyConstants.Platform);
            Console.WriteLine("Product: " + AssemblyConstants.Product);
            Console.WriteLine("Release date: " + AssemblyConstants.ReleaseDate);
            // ExEnd:CheckVersionNumber           
        }
    }
}