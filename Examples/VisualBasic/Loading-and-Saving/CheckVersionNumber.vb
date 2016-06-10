Imports System.IO
Imports Aspose.Note

Namespace Loading_Saving
    Public Class CheckVersionNumber
        Public Shared Sub Run()
            ' ExStart:CheckVersionNumber
            Console.WriteLine("Family: " + AssemblyConstants.Family)
            Console.WriteLine("Platform: " + AssemblyConstants.Platform)
            Console.WriteLine("Product: " + AssemblyConstants.Product)
            Console.WriteLine("Release date: " + AssemblyConstants.ReleaseDate)
            ' ExEnd:CheckVersionNumber           
        End Sub
    End Class
End Namespace
