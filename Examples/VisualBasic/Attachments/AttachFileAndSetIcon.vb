Imports System.IO
Imports AsposeNote = Aspose.Note
Imports System.Collections.Generic
Imports System.Drawing.Imaging
Namespace Attachments
    Public Class AttachFileAndSetIcon
        Public Shared Sub Run()
            ' ExStart:AttachFileAndSetIcon
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Attachments()

            ' Create an object of the Document class
            Dim doc As New Document()
            ' Initialize Page class object
            Dim page As New AsposeNote.Page(doc)
            ' Initialize Outline class object
            Dim outline As New Outline(doc)
            ' Initialize OutlineElement class object
            Dim outlineElem As New OutlineElement(doc)
            ' Initialize AttachedFile class object and also pass its icon path
            Dim attachedFile As New AttachedFile(doc, dataDir & Convert.ToString("attachment.txt"), File.OpenRead(dataDir & Convert.ToString("icon.jpg")), ImageFormat.Jpeg)
            ' Add attached file
            outlineElem.AppendChild(attachedFile)
            ' Add outline element node
            outline.AppendChild(outlineElem)
            ' Add outline node
            page.AppendChild(outline)
            ' Add page node
            doc.AppendChild(page)

            dataDir = dataDir & Convert.ToString("AttachFileAndSetIcon_out_.one")
            doc.Save(dataDir)
            ' ExEnd:AttachFileAndSetIcon      

            Console.WriteLine(Convert.ToString(vbLf & "File attached and it's icon setup successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace