Imports Aspose.Note
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text

Namespace ApplyLicense
    Public Class ApplyLicenseUsingFileStream
        Public Shared Sub Run()
            ' ExStart:ApplyLicenseUsingFileStream
            Dim license As New Aspose.Note.License()
            Dim myStream As New FileStream("Aspose.Note.lic", FileMode.Open)
            license.SetLicense(myStream)
            ' ExEnd:ApplyLicenseUsingFileStream
        End Sub
    End Class
End Namespace
