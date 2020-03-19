using Aspose.Note.Saving.Html;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Loading_Saving
{
    class UserSavingCallbacks : ICssSavingCallback, IFontSavingCallback, IImageSavingCallback
    {
        public string RootFolder { get; set; }
        public bool KeepCssStreamOpened { get; set; }
        public string CssFolder { get; set; }
        public Stream CssStream { get; private set; }
        public string FontsFolder { get; set; }
        public string ImagesFolder { get; set; }
        public void FontSaving(FontSavingArgs args)
        {
            string uri;
            Stream stream;
            this.CreateResourceInFolder(this.FontsFolder, args.FileName, out uri, out stream);
            args.Stream = stream;
            args.Uri = Path.Combine("..", uri).Replace("\\", "\\\\");
        }
        public void CssSaving(CssSavingArgs args)
        {
            string uri;
            Stream stream;
            this.CreateResourceInFolder(this.CssFolder, args.FileName, out uri, out stream);
            args.Stream = this.CssStream = stream;
            args.KeepStreamOpen = this.KeepCssStreamOpened;
            args.Uri = uri;
        }
        public void ImageSaving(ImageSavingArgs args)
        {
            string uri;
            Stream stream;
            this.CreateResourceInFolder(this.ImagesFolder, args.FileName, out uri, out stream);
            args.Stream = stream;
            args.Uri = uri;
        }
        private void CreateResourceInFolder(string folder, string filename, out string uri, out Stream stream)
        {
            var relativePath = folder;
            var fullPath = Path.Combine(this.RootFolder, relativePath);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
            stream = File.Create(Path.Combine(fullPath, filename));
            uri = Path.Combine(relativePath, filename);
        }
    }
}
