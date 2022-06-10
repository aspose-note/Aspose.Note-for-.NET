![Nuget](https://img.shields.io/nuget/v/Aspose.Note) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Note) ![GitHub](https://img.shields.io/github/license/aspose-note/Aspose.Note-for-.NET)

# .NET API for OneNote Document Processing

[Aspose.Note for .NET](https://products.aspose.com/note/net) is OneNote API to read, write and modify Microsoft Office OneNote files. It allows developers to work with .one files in C#, VB.NET, ASP.NET web applications, web services and Windows applications. It makes it possible to open files and manipulate the elements of OneNote books, from text, images and properties to more complex elements, and then export to ONE, PNG, GIF, JPEG, BMP, HTML or PDF formats.

<p align="center">
  <a
     href="https://github.com/aspose-note/Aspose.Note-for-.NET/archive/master.zip">
    <img src="http://i.imgur.com/hwNhrGZ.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for live demos hosted at https://products.aspose.app/note/family.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features.

## Microsoft OneNote File Processing Features

- Load, edit and save Microsoft OneNote documents via API.
- Navigate through the OneNote Document Object Model (DOM).
- Insert an image into an OneNote file.
- Parse and export various numbered list formats.
- Extract text from any part of an OneNote document.
- Export OneNote documents as other popular formats.
- Import content from popular formats to OneNote documents.

## Read & Write OneNote Format

**Microsoft OneNote:** ONE

## Read Formats

ONETOC2

## Import Formats

PDF

## Save OneNote Files As

**Fixed Layout:** PDF\
**Web:** HTML\
**Images:** GIF, JPEG, PNG, BMP, TIFF


## Platform Independence

Aspose.Note for .NET can be used to build both the 32-bit and the 64-bit .NET applications, including ASP.NET, Web Services & WinForms. Its deployment is very easy and consists of a single assembly with no dependencies (except for the .NET framework). Aspose.Note.dll is CLS compliant, written entirely in C# and contains only safe managed code for .NET Framework, .NET Core & Sliverlight 3.

## Get Started with Aspose.Note for .NET

Are you ready to give Aspose.Note for .NET a try? Simply execute `Install-Package Aspose.Note` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.Note for .NET and want to upgrade the version, please execute `Update-Package Aspose.Note` to get the latest version.

## Convert Microsoft OneNote to PDF Format

```csharp
// load the document into Aspose.Note.
Document oneFile = new Document(dir + "template.one");
// save the document as PDF
oneFile.Save(dir + "output.pdf", SaveFormat.Pdf);
```

## Extract Images from Microsoft OneNote Document

```csharp
// load the document into Aspose.Note.
Document oneFile = new Document(dir + "template.one");
// get all image nodes
IList<Aspose.Note.Image> nodes = oneFile.GetChildNodes<Aspose.Note.Image>();
foreach (Aspose.Note.Image image in nodes)
{
    using (MemoryStream stream = new MemoryStream(image.Bytes))
    {
        using (Bitmap bitMap = new Bitmap(stream))
        {
            // save image bytes to a file
            bitMap.Save(dir + image.FileName);
        }
    }
}
```
##### [Demos](https://products.aspose.app/note/family):
- [Conversion](https://products.aspose.app/note/conversion)
- [Viewer](https://products.aspose.app/note/viewer)
- [Unlock](https://products.aspose.app/note/unlock)
------------
[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/note/net) | [Docs](https://docs.aspose.com/note/net/) | [API Reference](https://apireference.aspose.com/note/net) | [Examples](https://github.com/aspose-note/Aspose.Note-for-.NET) | [Blog](https://blog.aspose.com/category/note/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/note) |  [Temporary License](https://purchase.aspose.com/temporary-license)
