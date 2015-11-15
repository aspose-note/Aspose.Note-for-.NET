//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Note. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.Globalization;
using Aspose.Note;

namespace Aspose.Note.Examples.Text
{
    class CreateTitleMsStyle
    {
        static void Main()
        {
            string dataDir = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            string outputPath = dataDir + "Output.one";

            var doc = new Document();
            var page = new Page(doc);

            page.Title = new Title(doc)
            {
                TitleText = new RichText(doc)
                {
                    Text = "Title text.",
                    DefaultStyle = TextStyle.DefaultMsOneNoteTitleTextStyle
                },
                TitleDate = new RichText(doc)
                {
                    Text = new DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture),
                    DefaultStyle = TextStyle.DefaultMsOneNoteTitleDateStyle
                },
                TitleTime = new RichText(doc)
                {
                    Text = "12:34",
                    DefaultStyle = TextStyle.DefaultMsOneNoteTitleTimeStyle
                }
            };

            doc.AppendChild(page);

            doc.Save(outputPath);
        }
    }
}
