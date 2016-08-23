Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace ApplyLicense
    Public Class ApplyLicenseByPath
        Public Shared Sub Run()
            ' ExStart:ApplyLicenseByPath        
            Dim license As New Aspose.Note.License()
            license.SetLicense("Aspose.Note.lic")
            ' ExEnd:ApplyLicenseByPath
        End Sub
    End Class
End Namespace
