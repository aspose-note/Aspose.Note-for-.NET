using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Note.Examples.CSharp.Loading_Saving;
using Aspose.Note.Examples.CSharp.Images;
using Aspose.Note.Examples.CSharp.Text;
using Aspose.Note.Examples.CSharp.Pages;
using Aspose.Note.Examples.CSharp.Tables;
using Aspose.Note.Examples.CSharp.Attachments;
using Aspose.Note.Examples.CSharp.Tags;
using Aspose.Note.Examples.CSharp.Tasks;
using Aspose.Note.Examples.CSharp.Hyperlinks;
using Aspose.Note.Examples.CSharp.WorkingWithNoteBook;
using Aspose.Note.Examples.CSharp.NoteBook;
//using Aspose.Note.Examples.CSharp.PrintingDocument;

namespace Aspose.Note.Examples.CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            //The API has evaluation limitaions as mentioned in https://docs.aspose.com/display/notenet/Licensing#Licensing-EvaluationVersionLimitations
            //You can get a 30-day temporary license free of cost for evaluating the API without any limitations.
            //Get a temporary license from http://www.aspose.com/corporate/purchase/temporary-license.aspx and apply before executing the code samples.
            
            License lic = new License();
            lic.SetLicense(@"Aspose.Total.Product.Family.Lic");     //Comment this line if you would like to try the API with Evaluation limitations

            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out

            #region Loading and Saving Section
            //// =====================================================
            //// =====================================================
            //// Loading and Saving
            //// =====================================================
            //// =====================================================
            //ConsequentExportOperations.Run();
            //ConvertSpecificPageToImage.Run();
            //CreateDocWithFormattedRichText.Run();
            //CreateDocWithPageTitle.Run();
            //CreateDocWithSimpleRichText.Run();
            //CreateOneNoteDocAndSaveToHTML.Run();
            //CreateOneNoteDocAndSaveToHTML.SaveAsHTMLToMemoryStreamWithEmbeddedResources();
            //CreateOneNoteDocAndSaveToHTML.SaveAsHTMLToFileWithResourcesInSeparateFiles();
            //CreateOneNoteDocAndSaveToHTML.SaveAsHTMLToMemoryStreamWithCallBacksToSaveResources();
            //ExtractContent.Run();
            //LoadOneNoteDoc.Run();
            //NodeTypeEnumeration.Run();
            //PageSplitUsingKeepPartAndCloneSolidObjectToNextPageAlgorithm.Run();
            //PageSplittUsingKeepSOlidObjectsAlgoirthm.Run();
            //PasswordProtectedDoc.Run();
            //RetreivingFileFormat.Run();
            //SaveDocToOneNoteFormat.Run();
            //SaveDocToOneNoteFormatUsingOnesaveoptions.Run();
            //SaveDocToOneNoteFormatUsingSaveFormat.Run();
            SaveRangeOfPagesAsPDF.Run();
            //SaveToImageDefaultOptions.Run();   
            //SaveToStream.Run();
            //SaveWithDefaultSettings.Run();
            //SpecifySaveOptions.Run();
            //// =====================================================
            #endregion

            #region Printing Documents
            //// =====================================================
            //// Printing Documents
            //// =====================================================
            //// =====================================================
            //PrintDocument.Run();
            //PrintDocumentWithPrintOptions.Run();
            //// =====================================================
            #endregion

            #region Images
            //// =====================================================
            //// Images
            //// =====================================================
            //// =====================================================

            //BuildDocAndInsertImage.Run();
            //BuildDocAndInsertImageUsingImageStream.Run();
            //ExtractImages.Run();
            //GetInformationOfImages.Run();
            //ImageAlternativeText.Run();
            //ImageWithHyperlink.Run();
            //InsertImage.Run();


            //// =====================================================
            #endregion

            #region Text
            //// =====================================================
            //// Text
            //// =====================================================
            //// =====================================================

            //ExtractingAllText.Run();
            //ExtractingTextFromAPage.Run();
            //ReplaceTextOnParticularPage.Run();
            //ReplaceTextOnAllPages.Run();
            //RetrieveBulletOrNumberList.Run();
            //ApplyBulletsOnText.Run();
            //ApplyNumberingOnText.Run();
            //InsertChineseNumberList.Run();
            //CreateTitleMsStyle.Run();
            //ChangeStyle.Run();

            //// =====================================================
            #endregion

            #region Pages
            //// =====================================================
            //// Pages
            //// =====================================================
            //// =====================================================
            //ConflictPageManipulation.Run();
            //GetNumberOfPages.Run();
            //GetPageInformation.Run();
            //CreateDocWithRootAndSubPages.Run();
            //GetPageRevisions.Run();
            //WorkingWithPageRevisions.Run();
            //RollBackRevisions.Run();
            //PushCurrentPageVersion.Run();
            //ModifyPageHistory.Run();
            //PageClone.Run();

            //// =====================================================
            #endregion

            #region Tables
            //// =====================================================
            //// Tables
            //// =====================================================
            //// =====================================================

            //ExtractTableText.Run();
            //ExtractRowText.Run();
            //ExtractCellText.Run();
            //InsertTable.Run();
            //CreateTableWithLockedColumns.Run();
            //SettingCellBackGroundColor.Run();

            //// =====================================================
            #endregion

            #region Attachments
            //// =====================================================
            //// Attachments
            //// =====================================================
            //// =====================================================

            //RetrieveAttachedFiles.Run();
            //AttachFileByPath.Run();
            //AttachFileAndSetIcon.Run();

            //// =====================================================
            #endregion

            #region Tags
            //// =====================================================
            //// Tags
            //// =====================================================
            //// =====================================================

            //GetTagDetails.Run();
            //AddTextNodeWithTag.Run();
            //AddImageNodeWithTag.Run();
            //AddTableNodeWithTag.Run();

            //// =====================================================
            #endregion

            #region Tasks
            //// =====================================================
            //// Tasks
            //// =====================================================
            //// =====================================================

            //GetOutlookTaskDetails.Run();

            //// =====================================================
            #endregion

            #region Hyperlinks
            //// =====================================================
            //// Hyperlinks
            //// =====================================================
            //// =====================================================

            //AddHyperlink.Run();

            //// =====================================================
            #endregion

            #region Notebook
            //// =====================================================
            //// NoteBook
            //// =====================================================
            //// =====================================================

            //ConvertToImage.Run();
            //ConvertToPDF.Run();
            //CreateNoteBook.Run();
            //RemoveChildNode.Run();
            //CreatingPasswordProtectedDoc.Run();
            //LoadingPasswordProtectedDoc.Run();
            //LoadFromStream.Run();
            //SaveNotebookToStream.Run();
            //WritingPasswordProtectedDoc.Run();
            //LoadingNotebookFilewithLoadOptions.Run();
            //LoadingNotebookInstantly.Run();
            //RetrieveDocumentsfromOneNoteNotebook.Run();
            //ReadRichText.Run();
            //ConvertToImageAsFlattenedNotebook.Run();
            #endregion

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        public static String GetDataDir_LoadingAndSaving()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Loading-and-Saving/");
        }
        public static String GetDataDir_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Images/");
        }
        public static String GetDataDir_Pages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Pages/");
        }
        public static String GetDataDir_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Text/");
        }
        public static String GetDataDir_Tables()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tables/");
        }
        public static String GetDataDir_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Attachments/");
        }
        public static String GetDataDir_Tags()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tags/");
        }
        public static String GetDataDir_Hyperlinks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Hyperlinks/");
        }
        public static String GetDataDir_Tasks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tasks/");
        }
        public static String GetDataDir_NoteBook()
        {
            return Path.GetFullPath(GetDataDir_Data() + "NoteBook/");
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
