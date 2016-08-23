Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ApplyLicense
    Public Class ApplyLicenseByEmbeddedResource
        Public Shared Sub Run()
            ' ExStart:ApplyLicenseByEmbeddedResource        
            ' Instantiate the License class
            Dim license As New Aspose.Note.License()

            ' Pass only the name of the license file embedded in the assembly
            license.SetLicense("Aspose.Note.lic")
            ' ExEnd:ApplyLicenseByEmbeddedResource
        End Sub
    End Class
End Namespace
