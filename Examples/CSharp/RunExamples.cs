using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSharp.Loading_Saving;
using CSharp.Images;
using CSharp.Text;
using CSharp.Pages;
using CSharp.Tables;
using CSharp.Attachments;
using CSharp.Tags;
using CSharp.Tasks;
using CSharp.Hyperlinks;

namespace CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run");
            Console.WriteLine("=====================================================");
            // Un-comment the one you want to try out

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
            //CheckVersionNumber.Run();
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
