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

namespace Aspose.Note.Examples.CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// Loading and Saving
            //// =====================================================
            //// =====================================================

            //LoadOneNoteDoc.Run();
            //SaveToStream.Run();
            //SpecifySaveOptions.Run();
            //SaveRangeOfPagesAsPDF.Run();
            //SaveWithDefaultSettings.Run();
            //ConvertSpecificPageToImage.Run();
            //CreateOneNoteDocAndSaveToHTML.Run();
            //PasswordProtectedDoc.Run();
            //PageSplittUsingKeepSOlidObjectsAlgoirthm.Run();
            //ConsequentExportOperations.Run();
            //SaveToImageDefaultOptions.Run();            
            //CreateDocWithSimpleRichText.Run();
            //CreateDocWithFormattedRichText.Run();
            //ExtractContent.Run();
            //CreateDocWithPageTitle.Run();

            //// =====================================================
            //// =====================================================
            //// Images
            //// =====================================================
            //// =====================================================

            //ExtractImages.Run(); 
            //GetInformationOfImages.Run();  
            //InsertImage.Run();
            //BuildDocAndInsertImage.Run();
            //BuildDocAndInsertImageUsingImageStream.Run();
            //ImageAlternativeText.Run();

            //// =====================================================
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
            //// =====================================================
            //// Pages
            //// =====================================================
            //// =====================================================

            //GetNumberOfPages.Run();
            //GetPageInformation.Run();
            //CreateDocWithRootAndSubPages.Run();
            //GetPageRevisions.Run();
            //WorkingWithPageRevisions.Run();
            //RollBackRevisions.Run();
            //PushCurrentPageVersion.Run();
            //ModifyPageHistory.Run();

            //// =====================================================
            //// =====================================================
            //// Tables
            //// =====================================================
            //// =====================================================

            //ExtractTableText.Run();
            //ExtractRowText.Run();
            //ExtractCellText.Run();
            //InsertTable.Run();
            //CreateTableWithLockedColumns.Run();
            SettingCellBackGroundColor.Run();

            //// =====================================================
            //// =====================================================
            //// Attachments
            //// =====================================================
            //// =====================================================

            //RetrieveAttachedFiles.Run();
            //AttachFileByPath.Run();
            //AttachFileAndSetIcon.Run();

            //// =====================================================
            //// =====================================================
            //// Tags
            //// =====================================================
            //// =====================================================

            //GetTagDetails.Run();
            //AddTextNodeWithTag.Run();
            //AddImageNodeWithTag.Run();
            //AddTableNodeWithTag.Run();

            //// =====================================================
            //// =====================================================
            //// Tasks
            //// =====================================================
            //// =====================================================

            //GetOutlookTaskDetails.Run();

            //// =====================================================
            //// =====================================================
            //// Hyperlinks
            //// =====================================================
            //// =====================================================

            //AddHyperlink.Run();

            //// =====================================================
            //// =====================================================
            //// NoteBook
            //// =====================================================
            //// =====================================================

            
            //ConvertToImage.Run();
            //ConvertToPDF.Run();
            //CreateNoteBook.Run();
            //RemoveChildNode.Run();
            CreatingPasswordProtectedDoc.Run();
            LoadingPasswordProtectedDoc.Run();
            LoadFromStream.Run();
            SaveNotebookToStream.Run();
            WritingPasswordProtectedDoc.Run();

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
