using Aspose.Note.Live.Demos.UI.Models.Common;
using Aspose.Note.Live.Demos.UI.Models;
using Aspose.Note.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Note.Live.Demos.UI.Controllers
{
	public class UnlockController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Unlock(string outputType, string passw)
		{

			Response response = null;
			var files = Request.Files;
			foreach (string fileName in Request.Files)
			{
				HttpPostedFileBase postedFile = Request.Files[fileName];

				if (postedFile != null)
				{
					var isFileUploaded = FileManager.UploadFile(postedFile);

					if ((isFileUploaded != null) && (isFileUploaded.FileName.Trim() != ""))
					{
						AsposeUnlock asposeNoteUnlock = new AsposeUnlock();
						response = asposeNoteUnlock.UnlockNote(isFileUploaded.FileName,isFileUploaded.FolderId, passw);

						if (response == null)
						{
							Console.WriteLine("Method not found.");
						}

					}
				}

			}

			return response;

					
		}
		public ActionResult Unlock()
		{
			var model = new ViewModel(this, "Unlock")
			{
				ControlsView = "UnlockControls",
				SaveAsComponent = true,
				MaximumUploadFiles = 1
			};
			if (model.RedirectToMainApp)
				return Redirect("/note/" + model.AppName.ToLower());
			return View(model);			
		}	

	}
}
