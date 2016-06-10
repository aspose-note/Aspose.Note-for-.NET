Imports System.IO
Imports Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing
Namespace Attachments
    Public Class AttachFileByPath
        Public Shared Sub Run()
            ' ExStart:AttachFileByPath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Attachments()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New Aspose.Note.Page(doc)
            ' Initialize Outline class object
            Dim outline As New Outline(doc)
            ' Initialize OutlineElement class object
            Dim outlineElem As New OutlineElement(doc)
            ' Initialize AttachedFile class object
            Dim attachedFile As New AttachedFile(doc, dataDir & Convert.ToString("attachment.txt"))
            ' Add attached file
            outlineElem.AppendChild(attachedFile)
            ' Add outline element node
            outline.AppendChild(outlineElem)
            ' Add outline node
            page.AppendChild(outline)
            ' Add page node
            doc.AppendChild(page)
            dataDir = dataDir & Convert.ToString("AttachFileByPath_out_.one")
            doc.Save(dataDir)
            ' ExEnd:AttachFileByPath      

            Console.WriteLine(Convert.ToString(vbLf & "File by path attached successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
