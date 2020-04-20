using Aspose.Note.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Note.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Free Apps to View or Convert MS OneNote files to PDF, HTML, Image formats";
			ViewBag.MetaDescription = "Our 100% free Apps providing the capabilities to online View Microsoft OneNote files on Desktop or Mobile. Convert to PDF, HTML, JPG, PNG, BMP, TIFF formats.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
