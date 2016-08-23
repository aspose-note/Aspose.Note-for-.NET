using Aspose.Note;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.ApplyLicense
{
    public class ApplyLicenseUsingFileStream
    {
        public static void Run()
        {
            // ExStart:ApplyLicenseUsingFileStream
            Aspose.Note.License license = new Aspose.Note.License();
            FileStream myStream = new FileStream("Aspose.Note.lic", FileMode.Open);
            license.SetLicense(myStream);
            // ExEnd:ApplyLicenseUsingFileStream
        }

    }
}
