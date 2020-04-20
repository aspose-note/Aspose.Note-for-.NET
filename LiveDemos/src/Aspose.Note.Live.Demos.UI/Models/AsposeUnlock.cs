using System.Threading.Tasks;
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System.Diagnostics;

namespace Aspose.Note.Live.Demos.UI.Models
{
	/// <summary>
	/// AsposeUnlock class to convert note file to other format
	/// </summary>
	public class AsposeUnlock : NoteBase
	{
		public Response UnlockNote(string fileName, string folderName, string password)
		{
			Aspose.Note.Live.Demos.UI.Models.License.SetAsposeNoteLicense();
			return  Process(GetType().Name, fileName, folderName, ".one", false, false,
				"UnlockNote",
					(inFilePath, outPath, zipOutFolder) =>
					{
						Aspose.Note.Document doc = new Aspose.Note.Document(inFilePath, new Aspose.Note.LoadOptions() { DocumentPassword = password });
						doc.Save(outPath);
					});
		}
	}
}