// -----------------------------------------------------------------------
//  <copyright file="RunExamples.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2022 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------



namespace Aspose.Note.Examples.CSharp
{
    using System;
    using System.IO;

    using Aspose.Note.Examples.CSharp.Hyperlinks;
    using Aspose.Note.Examples.CSharp.Import;
    using Aspose.Note.Examples.CSharp.Loading_and_Saving;
    using Aspose.Note.Examples.CSharp.Pages;
    using Aspose.Note.Examples.CSharp.Tables;
    using Aspose.Note.Examples.CSharp.Tags;
    using Aspose.Note.Examples.CSharp.Text;

    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            // The API has evaluation limitaions as mentioned in https://docs.aspose.com/display/notenet/Licensing#Licensing-EvaluationVersionLimitations
            // You can get a 30-day temporary license free of cost for evaluating the API without any limitations.
            // Get a temporary license from http://www.aspose.com/corporate/purchase/temporary-license.aspx and apply before executing the code samples.
            License lic = new License();
            // lic.SetLicense(@"Aspose.Total.Product.Family.Lic");     //Comment this line if you would like to try the API with Evaluation limitations

            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the one you want to try out

            // MeteredLicense.Run();

            //// =====================================================
            //// =====================================================
            //// Loading and Saving
            //// =====================================================
            //// =====================================================
            // ConsequentExportOperations.Run();
            // ConvertSpecificPageToImage.Run();
            // CreateDocWithFormattedRichText.Run();
            // CreateDocWithPageTitle.Run();
            // CreateDocWithSimpleRichText.Run();
            // CreateOneNoteDocAndSaveToHTML.Run();
            // CreateOneNoteDocAndSaveToHTML.SaveAsHTMLToMemoryStreamWithEmbeddedResources();
            // CreateOneNoteDocAndSaveToHTML.SaveAsHTMLToFileWithResourcesInSeparateFiles();
            // CreateOneNoteDocAndSaveToHTML.SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources();
            // ExtractContent.Run();
            // LoadOneNoteDoc.Run();
            // NodeTypeEnumeration.Run();
            // PageSplitUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.Run();
            // PageSplittUsingKeepSOlidObjectsAlgoirthm.Run();
            // PasswordProtectedDoc.Run();
            // RetreivingFileFormat.Run();
            // SaveDocToOneNoteFormat.Run();
            // SaveDocToOneNoteFormatUsingOnesaveoptions.Run();
            // SaveDocToOneNoteFormatUsingSaveFormat.Run();
            // SaveRangeOfPagesAsPDF.Run();
            // SaveToImageDefaultOptions.Run();   
            // SaveToGrayscaleImage.Run();
            // SaveToBinaryImageUsingFixedThreshold.Run();
            // SaveToBinaryImageUsingOtsuMethod.Run();
            // SaveToBmpImageUsingImageSaveOptions.Run();
            // SaveToJpegImageUsingSaveFormat.Run();
            // SaveToTiffImageUsingImageSaveOptions.Run();
            // SaveToStream.Run();
            // SaveWithDefaultSettings.Run();
            // SpecifySaveOptions.Run();
            // SaveUsingSpecifiedFontsSubsystem.Run();
            SaveToPdfUsingPageSettings.Run();
            //// =====================================================
            #region Printing Documents

            //// =====================================================
            //// Printing Documents
            //// =====================================================
            //// =====================================================
            // PrintDocument.Run();
            // PrintDocumentWithPrintOptions.Run();
            //// =====================================================
            #endregion

            #region Images

            //// =====================================================
            //// Images
            //// =====================================================
            //// =====================================================

            // BuildDocAndInsertImage.Run();
            // BuildDocAndInsertImageUsingImageStream.Run();
            // ExtractImages.Run();
            // GetInformationOfImages.Run();
            // ImageAlternativeText.Run();
            // ImageWithHyperlink.Run();
            // InsertImage.Run();

            //// =====================================================
            #endregion

            #region Text

            //// =====================================================
            //// Text
            //// =====================================================
            //// =====================================================

            // ExtractingAllText.Run();
            // ExtractingTextFromAPage.Run();
            // ReplaceTextOnParticularPage.Run();
            // ReplaceTextOnAllPages.Run();
            // RetrieveBulletOrNumberList.Run();
            // ApplyBulletsOnText.Run();
            // ApplyNumberingOnText.Run();
            // InsertChineseNumberList.Run();
            // CreateTitleMsStyle.Run();
            // ChangeStyle.Run();
            // ChangePageTitleStyle.Run();
            // SetDefaultParagraphStyle.Run();
            // SetProofingLanguageForText.Run();
            // GenerateDocumentFromTemplate.Run();
            // ApplyDarkTheme.Run();

            //// =====================================================
            #endregion

            #region Pages

            //// =====================================================
            //// Pages
            //// =====================================================
            //// =====================================================
            // ConflictPageManipulation.Run();
            // GetNumberOfPages.Run();
            // GetPageInformation.Run();
            // CreateDocWithRootAndSubPages.Run();
            // GetPageRevisions.Run();
            // WorkingWithPageRevisions.Run();
            // RollBackRevisions.Run();
            // PushCurrentPageVersion.Run();
            // ModifyPageHistory.Run();
            // PageClone.Run();
            SetPageBackgroundColor.Run();

            //// =====================================================
            #endregion

            #region Tables

            //// =====================================================
            //// Tables
            //// =====================================================
            //// =====================================================

            // ExtractTableText.Run();
            // ExtractRowText.Run();
            // ExtractCellText.Run();
            // InsertTable.Run();
            // CreateTableWithLockedColumns.Run();
            // SettingCellBackGroundColor.Run();
            // ChangeTableStyle.Run();
            ComposeTable.Run();

            //// =====================================================
            #endregion

            #region Attachments

            //// =====================================================
            //// Attachments
            //// =====================================================
            //// =====================================================

            // RetrieveAttachedFiles.Run();
            // AttachFileByPath.Run();
            // AttachFileAndSetIcon.Run();

            //// =====================================================
            #endregion

            #region Tags

            //// =====================================================
            //// Tags
            //// =====================================================
            //// =====================================================

            // GetTagDetails.Run();
            // AddTextNodeWithTag.Run();
            // AddImageNodeWithTag.Run();
            // AddTableNodeWithTag.Run();
            Reporting.Run();
            GenerateTemplateForMeetingNotes.Run();
            OpenCloseProjectC.Run();

            //// =====================================================
            #endregion

            #region Tasks

            //// =====================================================
            //// Tasks
            //// =====================================================
            //// =====================================================

            // GetOutlookTaskDetails.Run();

            //// =====================================================
            #endregion

            #region Hyperlinks

            //// =====================================================
            //// Hyperlinks
            //// =====================================================
            //// =====================================================
            AddHyperlink.Run();

            //// =====================================================
            #endregion

            #region Notebook

            //// =====================================================
            //// NoteBook
            //// =====================================================
            //// =====================================================

            // ConvertToImage.Run();
            // ConvertToPDF.Run();
            // CreateNoteBook.Run();
            // RemoveChildNode.Run();
            // CreatingPasswordProtectedDoc.Run();
            // LoadingPasswordProtectedDoc.Run();
            // LoadFromStream.Run();
            // SaveNotebookToStream.Run();
            // WritingPasswordProtectedDoc.Run();
            // LoadingNotebookFilewithLoadOptions.Run();
            // LoadingNotebookInstantly.Run();
            // RetrieveDocumentsfromOneNoteNotebook.Run();
            // ReadRichText.Run();
            // ConvertToImageAsFlattenedNotebook.Run();
            #endregion

            #region Import

            ImportFromPdf.Run();

            #endregion

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

        public static string GetDataDir_LoadingAndSaving()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Loading-and-Saving/");
        }

        public static string GetDataDir_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Images/");
        }

        public static string GetDataDir_Pages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Pages/");
        }

        public static string GetDataDir_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Text/");
        }

        public static string GetDataDir_Tables()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tables/");
        }

        public static string GetDataDir_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Attachments/");
        }

        public static string GetDataDir_Tags()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tags/");
        }

        public static string GetDataDir_Hyperlinks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Hyperlinks/");
        }

        public static string GetDataDir_Tasks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tasks/");
        }

        public static string GetDataDir_NoteBook()
        {
            return Path.GetFullPath(GetDataDir_Data() + "NoteBook/");
        }

        public static string GetDataDir_Import()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Import/");
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }

            return Path.Combine(startDirectory, "Data\\");
        }
    }
}
