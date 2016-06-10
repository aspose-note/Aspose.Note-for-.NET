Imports System.IO
Imports VisualBasic.Loading_Saving
Imports VisualBasic.Images
Imports VisualBasic.Text
Imports VisualBasic.Pages
Imports VisualBasic.Tables
Imports VisualBasic.Attachments
Imports VisualBasic.Tags
Imports VisualBasic.Tasks
Imports VisualBasic.Hyperlinks

Module RunExamples
    Sub Main()
        Console.WriteLine("Open RunExamples.vb. In Main() method, Un-comment the example that you want to run")
        Console.WriteLine("=====================================================")

        ' Un-comment the one you want to try out

        '' =====================================================
        '' =====================================================
        '' Loading and Saving
        '' =====================================================
        '' =====================================================
        'ConsequentExportOperations.Run()
        'LoadOneNoteDoc.Run()
        'SaveToStream.Run()
        'SpecifySaveOptions.Run()
        'SaveRangeOfPagesAsPDF.Run()
        'SaveWithDefaultSettings.Run()
        'ConvertSpecificPageToImage.Run()
        'CreateOneNoteDocAndSaveToHTML.Run()
        'PasswordProtectedDoc.Run()
        'PageSplittUsingKeepSOlidObjectsAlgoirthm.Run()
        'SaveToImageDefaultOptions.Run()
        'CheckVersionNumber.Run()
        'CreateDocWithSimpleRichText.Run()
        'CreateDocWithFormattedRichText.Run()
        'ExtractContent.Run()
        'CreateDocWithPageTitle.Run()

        '' =====================================================
        '' =====================================================
        '' Images
        '' =====================================================
        '' =====================================================

        'ExtractImages.Run()
        'GetInformationOfImages.Run()
        'InsertImage.Run()
        'BuildDocAndInsertImage.Run()
        'BuildDocAndInsertImageUsingImageStream.Run()
        'ImageAlternativeText.Run()

        '' =====================================================
        '' =====================================================
        '' Text
        '' =====================================================
        '' =====================================================

        'ExtractingAllText.Run()
        'ExtractingTextFromAPage.Run()
        'ReplaceTextOnParticularPage.Run()
        'ReplaceTextOnAllPages.Run()
        'RetrieveBulletOrNumberList.Run()
        'ApplyBulletsOnText.Run()
        'ApplyNumberingOnText.Run()
        'InsertChineseNumberList.Run()
        'CreateTitleMsStyle.Run()
        ChangeStyle.Run()

        '' =====================================================
        '' =====================================================
        '' Pages
        '' =====================================================
        '' =====================================================

        'CreateDocWithRootAndSubPages.Run()
        'GetNumberOfPages.Run()
        'GetPageInformation.Run()
        'GetPageRevisions.Run()

        '' =====================================================
        '' =====================================================
        '' Tables
        '' =====================================================
        '' =====================================================

        'ExtractCellText.Run()
        'ExtractRowText.Run()
        'ExtractTableText.Run()

        '' =====================================================
        '' =====================================================
        '' Attachments
        '' =====================================================
        '' =====================================================

        'AttachFileAndSetIcon.Run()
        'AttachFileByPath.Run()
        'RetrieveAttachedFiles.Run()

        '' =====================================================
        '' =====================================================
        '' Tags
        '' =====================================================
        '' =====================================================

        'GetTagDetails.Run()
        'AddTextNodeWithTag.Run()
        'AddImageNodeWithTag.Run()

        '' =====================================================
        '' =====================================================
        '' Tasks
        '' =====================================================
        '' =====================================================

        'GetOutlookTaskDetails.Run()

        '' =====================================================
        '' =====================================================
        '' Hyperlinks
        '' =====================================================
        '' =====================================================

        'AddHyperlink.Run()
        
        ' Stop before exiting
        Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit....")
        Console.ReadKey()
    End Sub
    Public Function GetDataDir_LoadingAndSaving() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Loading-and-Saving/")
    End Function
    Public Function GetDataDir_Images() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Images/")
    End Function
    Public Function GetDataDir_Pages() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Pages/")
    End Function
    Public Function GetDataDir_Text() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Text/")
    End Function
    Public Function GetDataDir_Tables() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Tables/")
    End Function
    Public Function GetDataDir_Attachments() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Attachments/")
    End Function
    Public Function GetDataDir_Tags() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Tags/")
    End Function
    Public Function GetDataDir_Hyperlinks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Hyperlinks/")
    End Function
    Public Function GetDataDir_Tasks() As [String]
        Return Path.GetFullPath(GetDataDir_Data() + "Tasks/")
    End Function
    Public Function GetDataDir_Data() As String
        Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
        Dim startDirectory As String = Nothing
        If parent IsNot Nothing Then
            Dim directoryInfo = parent.Parent
            If directoryInfo IsNot Nothing Then
                startDirectory = directoryInfo.FullName
            End If
        Else
            startDirectory = parent.FullName
        End If
        Return Path.Combine(startDirectory, "Data\")
    End Function

End Module
