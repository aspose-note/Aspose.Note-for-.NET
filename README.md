# Aspose.Note for .NET

[Aspose.Note for .NET](https://products.aspose.com/note/net) is OneNote API to read, write and modify Microsoft Office OneNote files. It allows developers to work with .one files in C#, VB.NET, ASP.NET web applications, web services and Windows applications. It makes it possible to open files and manipulate the elements of OneNote books, from text, images and properties to more complex elements, and then export to ONE, PNG, GIF, JPEG, BMP, HTML or PDF formats.

<p align="center">
  <a href="https://github.com/aspose-note/Aspose.Note-for-.NET/archive/master.zip">
    <img src="http://i.imgur.com/hwNhrGZ.png" />
  </a>
</p>

This repository contains [Demos](Demos), [Examples](Examples) and Showcase projects for [Aspose.Note for .NET](https://products.aspose.com/note/net) to help you learn and write your own applications.

Directory | Description
--------- | -----------
[Demos](Demos)  | Aspose.Note for .NET Live Demos Source Code
[Examples](Examples)  | A collection of .NET examples that help you learn the product features


# .NET API for OneNote Document Processing

It is a standalone class library that allows to interact with [Microsoft OneNote® documents for processing](https://products.aspose.com/note/net) and conversion.

Aspose.Note for .NET can be used for printing ONE documents as well as manipulation of [pages](https://docs.aspose.com/display/notenet/Working+with+Pages), [images](https://docs.aspose.com/display/notenet/Working+with+Images), [text](https://docs.aspose.com/display/notenet/Working+with+Text), [tables](https://docs.aspose.com/display/notenet/Working+with+Tables), [attachments](https://docs.aspose.com/display/notenet/Working+with+Attachments), [tags](https://docs.aspose.com/display/notenet/Working+with+Tags), [tasks](https://docs.aspose.com/display/notenet/Working+with+Tasks), [text styles](https://docs.aspose.com/display/notenet/Working+with+Text+Styles), and [hyperlinks](https://docs.aspose.com/display/notenet/Working+with+Hyperlinks), without needing Microsoft OneNote.

## Microsoft OneNote File Processing Features

- [Load, edit and save](https://docs.aspose.com/display/notenet/Loading%2C+Saving+and+Converting) Microsoft OneNote documents via API.
- Navigate through the OneNote Document Object Model (DOM).
- Insert an [image into an OneNote file](https://docs.aspose.com/display/notenet/Loading%2C+Saving+and+Converting).
- Parse and export various numbered list formats.
- Extract text from any part of an OneNote document.
- Export OneNote documents as other popular formats.

## Read & Write OneNote Format

**Microsoft OneNote:** ONE

## Save OneNote Files As

**Fixed Layout:** PDF\
**Web:** HTML\
**Images:** GIF, JPEG, PNG, BMP, TIFF

## Read Formats

ONETOC2

## Platform Independence

Aspose.Note for .NET can be used to build both the 32-bit and the 64-bit .NET applications, including ASP.NET, Web Services & WinForms. Its deployment is very easy and consists of a single assembly with no dependencies (except for the .NET framework). Aspose.Note.dll is CLS compliant, written entirely in C# and contains only safe managed code for .NET Framework, .NET Core & Sliverlight 3.

## Getting Started with Aspose.Note for .NET

Are you ready to give Aspose.Note for .NET a try? Simply execute `Install-Package Aspose.Note` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.Note for .NET and want to upgrade the version, please execute `Update-Package Aspose.Note` to get the latest version.

## Convert Microsoft OneNote to PDF Format via C# Code

Execute below code snippet to see how Aspose.Note API performs in your environment or check the [GitHub Repository](https://github.com/aspose-note/Aspose.Note-for-.NET) for other common usage scenarios.

```csharp
// load the document into Aspose.Note.
Document oneFile = new Document(dir + "template.one");
// save the document as PDF
oneFile.Save(dir + "output.pdf", SaveFormat.Pdf);
```

## Extract Images from Microsoft OneNote Document

Aspose.Note for .NET enables your .NET applications to list and manipulate images from an OneNote document as demonstrated with following snippet:

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

[Product Page](https://products.aspose.com/note/net) | [Docs](https://docs.aspose.com/display/notenet/Home) | [Demos](https://products.aspose.app/note/family) | [API Reference](https://apireference.aspose.com/note/net) | [Examples](https://github.com/aspose-note/Aspose.Note-for-.NET) | [Blog](https://blog.aspose.com/category/note/) | [Free Support](https://forum.aspose.com/c/note) |  [Temporary License](https://purchase.aspose.com/temporary-license)
