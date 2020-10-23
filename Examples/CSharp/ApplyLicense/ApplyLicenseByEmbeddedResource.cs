using Aspose.Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.ApplyLicense
{
    public class ApplyLicenseByEmbeddedResource
    {
        public static void Run() 
        {
            // ExStart:ApplyLicenseByEmbeddedResource
            // ExFor:License
            // ExFor:License.SetLicense(System.String)
            // ExSummary:Shows how to load a license for Aspose.Note from embedded file resource.

            // Instantiate the License class
            Aspose.Note.License license = new Aspose.Note.License();

            // Pass only the name of the license file embedded in the assembly
            license.SetLicense("Aspose.Note.lic");
            
            // ExEnd:ApplyLicenseByEmbeddedResource
        }
    }
}
