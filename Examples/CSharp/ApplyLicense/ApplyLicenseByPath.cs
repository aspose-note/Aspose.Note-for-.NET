using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.ApplyLicense
{
    public class ApplyLicenseByPath
    {
        public static void Run() 
        {
            // ExStart:ApplyLicenseByPath        
            Aspose.Note.License license = new Aspose.Note.License();
            license.SetLicense("Aspose.Note.lic");
            // ExEnd:ApplyLicenseByPath
        }
    }
}
