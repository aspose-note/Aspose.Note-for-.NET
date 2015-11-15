'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Note. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System
Imports System.Globalization
Imports Aspose.Note

Namespace Aspose.Note.Examples.Text
    Public Class CreateTitleMsStyle
        Public Shared Sub Main(ByVal args() As String)
            Dim dataDir As String = Aspose.Note.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim outputPath As String = dataDir & "Output.one"

            Dim doc = New Document()
            Dim page = New Page(doc)
            page.Title = New Title(doc) With { _
                .TitleText = New RichText(doc) With { _
                    .Text = "Title text.", _
                    .DefaultStyle = TextStyle.DefaultMsOneNoteTitleTextStyle _
                }, _
                .TitleDate = New RichText(doc) With { _
                    .Text = New DateTime(2011, 11, 11).ToString("D", CultureInfo.InvariantCulture), _
                    .DefaultStyle = TextStyle.DefaultMsOneNoteTitleDateStyle _
                }, _
                .TitleTime = New RichText(doc) With { _
                    .Text = "12:34", _
                    .DefaultStyle = TextStyle.DefaultMsOneNoteTitleTimeStyle _
                } _
            }

            doc.AppendChild(Page)

            doc.Save(outputPath)
        End Sub
    End Class
End Namespace