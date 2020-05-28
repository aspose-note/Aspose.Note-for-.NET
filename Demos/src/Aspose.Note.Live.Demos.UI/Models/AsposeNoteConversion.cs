using System.Threading.Tasks;
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System.Diagnostics;

namespace Aspose.Note.Live.Demos.UI.Models
{
	/// <summary>
	/// AsposeNoteConversion class to convert note file to other format
	/// </summary>
	public class AsposeNoteConversion : NoteBase
	{
		private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip, bool checkNumberofPages, ActionDelegate action)
		{
			Aspose.Note.Live.Demos.UI.Models.License.SetAsposeNoteLicense();
			return  Process(this.GetType().Name, fileName, folderName, outFileExtension, createZip, checkNumberofPages,   (new StackTrace()).GetFrame(5).GetMethod().Name, action);

		}
		/// <summary>
		/// ConvertNoteToPdf method to convert note to pdf format
		/// </summary>
		public Response ConvertNoteToPdf(string fileName, string folderName, string outputType)
		{
			return  ProcessTask(fileName, folderName, ".pdf", false, false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				Document document = new Document(inFilePath);
				document.Save(outPath, new PdfSaveOptions());
			});
		}
		/// <summary>
		/// ConvertNoteToHtml method to convert note to html format
		/// </summary>
		public Response ConvertNoteToHtml(string fileName, string folderName)
		{
			return  ProcessTask(fileName, folderName, ".html", true, false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				Document document = new Document(inFilePath);
				document.Save(outPath, SaveFormat.Html);
			});
		}
		/// <summary>
		/// ConvertNoteToTiff method to convert note to tiff format
		/// </summary>
		public Response ConvertNoteToTiff(string fileName, string folderName)
		{
			return  ProcessTask(fileName, folderName, ".tiff", false, false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				Document document = new Document(inFilePath);
				document.Save(outPath, SaveFormat.Tiff);
			});
		}
		/// <summary>
		/// ConvertNoteToImages method to convert note to images format
		/// </summary>
		public Response ConvertNoteToImages(string fileName, string folderName, string outputType)
		{
			if (outputType.Equals("bmp") || outputType.Equals("jpg") || outputType.Equals("png"))
			{
				SaveFormat format = SaveFormat.Bmp;

				if (outputType.Equals("jpg"))
				{
					format = SaveFormat.Jpeg;
				}
				else if (outputType.Equals("png"))
				{
					format = SaveFormat.Png;
				}

				return  ProcessTask(fileName, folderName, "." + outputType, true, true, delegate (string inFilePath, string outPath, string zipOutFolder)
				{
					string outfileName = Path.GetFileNameWithoutExtension(fileName) + "_{0}";
					ImageSaveOptions options = new ImageSaveOptions(format);

					Document document = new Document(inFilePath);
					int count = document.GetChildNodes<Note.Page>().Count;

					for (int i = 0; i < count; i++)
					{
						if (count > 1)
						{
							outPath = zipOutFolder + "/" + outfileName;
							options.PageIndex = i;

							document.Save(string.Format(outPath, (i + 1) + "." + outputType), options);
						}
						else
						{
							outPath = zipOutFolder + "/" + Path.GetFileNameWithoutExtension(fileName);
							options.PageIndex = i;
							document.Save(outPath + "." + outputType, options);
						}
					}

				});
			}

			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};
		}
		/// <summary>
		/// ConvertFile
		/// </summary>
		public Response ConvertFile(string fileName, string folderName, string outputType)
		{
			outputType = outputType.ToLower();

			if (outputType.StartsWith("pdf"))
			{
				return  ConvertNoteToPdf(fileName, folderName, outputType);
			}
			else if (outputType.Equals("html"))
			{
				return  ConvertNoteToHtml(fileName, folderName);
			}
			else if (outputType.Equals("tiff"))
			{
				return  ConvertNoteToTiff(fileName, folderName);
			}
			else if (outputType.Equals("bmp") || outputType.Equals("jpg") || outputType.Equals("png"))
			{
				return  ConvertNoteToImages(fileName, folderName, outputType);
			}

			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};
		}

	}
}
