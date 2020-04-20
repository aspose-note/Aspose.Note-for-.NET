using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspose.Note.Live.Demos.UI.Models
{
	///<Summary>
	/// License class to set apose products license
	///</Summary>
	public static class License
	{
		private static string _licenseFileName = "Aspose.Total.lic";

		///<Summary>
		/// SetAsposeNoteLicense method to Aspose.ThreeD License
		///</Summary>
		public static void SetAsposeNoteLicense()
		{
			try
			{

				Aspose.Note.License lic = new Aspose.Note.License();
				lic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}	
		
	}
}
