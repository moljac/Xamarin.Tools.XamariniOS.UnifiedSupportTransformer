﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.VisualStudio

{
	public partial class ProjectTypes : List<ProjectType>
	{
		public static ProjectTypes GetProjectTypes()
		{
			ProjectTypes pt = new ProjectTypes()
			{
			};

			string[] lines = collected_project_type_guids_as_text
									.Split
										(
										  new string[] { Environment.NewLine}
										, StringSplitOptions.RemoveEmptyEntries
										);

			foreach (string l in lines)
			{
				string l_trimmed = l.Trim();

				if (l_trimmed == String.Empty || l_trimmed.StartsWith(@"//"))
				{
					continue;
				}
				else
				{
					int position_guid_begin = l_trimmed.IndexOf('{');
					int position_guid_end = l_trimmed.IndexOf('}');
					string description = l_trimmed.Substring(0, position_guid_begin).Trim();
					string guid_project_type = l_trimmed.Substring(position_guid_begin + 1, position_guid_end - position_guid_begin - 1);
				}

			}
			return pt;
		}



		public static readonly string collected_project_type_guids_as_text =
			@"
			//http://www.codeproject.com/Reference/720512/List-of-Visual-Studio-Project-Type-GUIDs

			C#	{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}
			F#	{F2A71F9B-5D33-465A-A702-920D77279786}
			C++	{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}
			VB.NET	{F184B08F-C81C-45F6-A57F-5ABD9991F28F}
			J#	{E6FDF86B-F3D1-11D4-8576-0002A516ECE8}

			Solution Folder	{2150E333-8FDC-42A3-9474-1A3956D46DE8}

			Portable Class Library	{786C830F-07A1-408B-BD7F-6EE04809D6DB}

			Windows (C#)	{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}
			Windows (VB.NET)	{F184B08F-C81C-45F6-A57F-5ABD9991F28F}
			Windows (Visual C++)	{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}

			Windows Presentation Foundation (WPF)	{60DC8134-EBA5-43B8-BCC9-BB4BC16C2548}

			Xamarin.Android	{EFBA0AD7-5A72-4C68-AF49-83D382785DCF}
			Xamarin.iOS	{6BC8ED88-2882-458C-8E55-DFD12B67127B}
			Xamarin.iOS Binding (Classic & Unified)  	{F5B4F3BC-B597-4E2B-B552-EF5D8A32436F}
			Xamarin.iOS Unified Library / App 		{FEACFBD2-3405-455C-9665-78FE426C6842}
			Xamarin.iOS Unified App Extension  		{EE2C853D-36AF-4FDB-B1AD-8E90477E2198}
			Mono for Android	{EFBA0AD7-5A72-4C68-AF49-83D382785DCF}
			MonoTouch	{6BC8ED88-2882-458C-8E55-DFD12B67127B}
			MonoTouch Binding	{F5B4F3BC-B597-4E2B-B552-EF5D8A32436F}

			Web Application	{349C5851-65DF-11DA-9384-00065B846F21}
			Web Site	{E24C65DC-7377-472B-9ABA-BC803B73C61A}

			ASP.NET MVC 1.0	{603C0E0B-DB56-11DC-BE95-000D561079B0}
			ASP.NET MVC 2.0	{F85E285D-A4E0-4152-9332-AB1D724D3325}
			ASP.NET MVC 3.0	{E53F8FEA-EAE0-44A6-8774-FFD645390401}
			ASP.NET MVC 4.0	{E3E379DF-F4C6-4180-9B81-6769533ABE47}
			Model-View-Controller v2 (MVC2)	{F85E285D-A4E0-4152-9332-AB1D724D3325}
			Model-View-Controller v3 (MVC3)	{E53F8FEA-EAE0-44A6-8774-FFD645390401}
			Model-View-Controller v4 (MVC4)	{E3E379DF-F4C6-4180-9B81-6769533ABE47}
			Windows Communication Foundation (WCF)	{3D9AD99F-2412-4246-B90B-4EAA41C64699}

			Silverlight	{A1591282-1198-4647-A2B1-27E5FF5F6F3B}
			Test	{3AC096D0-A1C2-E12C-1390-A8335801FDAB}

			Windows Phone 8/8.1 Blank/Hub/Webview App	{76F1466A-8B6D-4E39-A767-685A06062A39}
			Windows Phone 8/8.1 App (C#)	{C089C8C0-30E0-4E22-80C0-CE093F111A43}
			Windows Phone 8/8.1 App (VB.NET)	{DB03555F-0C8B-43BE-9FF9-57896B3C5E56}

			Database	{A9ACE9BB-CECE-4E62-9AA4-C7E7C5BD2124}
			Database (other project types)	{4F174C21-8C12-11D0-8340-0000F80270F8}

			Deployment Cab	{3EA9E505-35AC-4774-B492-AD1749C4943A}
			Deployment Merge Module	{06A35CCD-C46D-44D5-987B-CF40FF872267}
			Deployment Setup	{978C614F-708E-4E1A-B201-565925725DBA}
			Deployment Smart Device Cab	{AB322303-2255-48EF-A496-5904EB18DA55}

			Distributed System	{F135691A-BF7E-435D-8960-F99683D2D49C}

			Smart Device (C#)	{4D628B5B-2FBC-4AA6-8C16-197242AEB884}
			Smart Device (VB.NET)	{68B1623D-7FB9-47D8-8664-7ECEA3297D4F}
			Legacy (2003) Smart Device (C#)	{20D4826A-C6FA-45DB-90F4-C717570B9F32}
			Legacy (2003) Smart Device (VB.NET)	{CB4CE8C6-1BDB-4DC7-A4D3-65A1999772F8}

			//Extensibility	

			SharePoint (C#)	{593B0543-81F6-4436-BA1E-4747859CAAE2}
			SharePoint (VB.NET)	{EC05E597-79D4-47f3-ADA0-324C4F7C7484}
			SharePoint Workflow	{F8810EC1-6754-47FC-A15F-DFABD2E3FA90}

			Visual Database Tools	{C252FEB5-A946-4202-B1D4-9916A0590387}
			Visual Studio Tools for Applications (VSTA)	{A860303F-1F3F-4691-B57E-529FC101A107}
			Visual Studio Tools for Office (VSTO)	{BAA0C2D2-18E2-41B9-852F-F413020CAA33}

			Workflow (C#)	{14822709-B5A1-4724-98CA-57A101D1B079}
			Workflow (VB.NET)	{D59BE175-2ED0-4C54-BE3D-CDAA9F3214C8}
			Workflow Foundation	{32F31D43-81CC-4C15-9DE6-3FC5453562B6}
			Windows Store (Metro) Apps & Components	{BC8A1FFA-BEE3-4634-8014-F334798102B3}

			XNA (Windows)	{6D335F3A-9D43-41b4-9D22-F6F17C4BE596}
			XNA (XBox)	{2DF5C3F4-5A5F-47a9-8E94-23B4456F55E2}
			XNA (Zune)	{D399B71A-8929-442a-A9AC-8BEC78BB2433}

			vs2013 c# wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 pivotapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}

			vs2013 c# wp8.1 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 pivotapp {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 vb wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 pivot app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 vb wp8.1 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 pivot app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 c# wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 pivotapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}

			vs2013 c# wp8.1 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 pivotapp {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 vb wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 pivot app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 vb wp8.1 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 pivot app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 c# wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8 pivotapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}

			vs2013 c# wp8.1 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 c# wp8.1 pivotapp {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 c# wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 vb wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8 pivot app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 vb wp8 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 vb wp8.1 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 pivot app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 vb wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8 pivotapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}

			vs2013 wp8.1 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8.1 databound app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8.1 html5 app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8.1 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8.1 panorama app {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8.1 phoneapp {C089C8C0-30E0-4E22-80C0-CE093F111A43}
			vs2013 wp8.1 pivotapp {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 wp8 blank app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8 hub app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8 pivot app {76F1466A-8B6D-4E39-A767-685A06062A39}
			vs2013 wp8 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			vs2013 wp8.1 databound app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8.1 html5 app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8.1 panorama app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8.1 phone app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8.1 pivot app {DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			vs2013 wp8.1 webview app {76F1466A-8B6D-4E39-A767-685A06062A39}

			// http://www.mztools.com/articles/2008/mz2008017.aspx
			C#	{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}
			VB.NET	{F184B08F-C81C-45F6-A57F-5ABD9991F28F}
			C++	{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}
			F#	{F2A71F9B-5D33-465A-A702-920D77279786}
			J#	{E6FDF86B-F3D1-11D4-8576-0002A516ECE8}
			JScript	{262852C6-CD72-467D-83FE-5EEB1973A190}
			Web Application	{349C5851-65DF-11DA-9384-00065B846F21}
			Web Site	{E24C65DC-7377-472B-9ABA-BC803B73C61A}
			Distributed System	{F135691A-BF7E-435D-8960-F99683D2D49C}
			Windows Communication Foundation (WCF)	{3D9AD99F-2412-4246-B90B-4EAA41C64699}
			Windows Presentation Foundation (WPF)	{60DC8134-EBA5-43B8-BCC9-BB4BC16C2548}
			Visual Database Tools	{C252FEB5-A946-4202-B1D4-9916A0590387}
			Database	{A9ACE9BB-CECE-4E62-9AA4-C7E7C5BD2124}
			Database (other project types)	{4F174C21-8C12-11D0-8340-0000F80270F8}
			Test	{3AC096D0-A1C2-E12C-1390-A8335801FDAB}
			Legacy (2003) Smart Device (C#)	{20D4826A-C6FA-45DB-90F4-C717570B9F32}
			Legacy (2003) Smart Device (VB.NET)	{CB4CE8C6-1BDB-4DC7-A4D3-65A1999772F8}
			Smart Device (C#)	{4D628B5B-2FBC-4AA6-8C16-197242AEB884}
			Smart Device (VB.NET)	{68B1623D-7FB9-47D8-8664-7ECEA3297D4F}
			Workflow (C#)	{14822709-B5A1-4724-98CA-57A101D1B079}
			Workflow (VB.NET)	{D59BE175-2ED0-4C54-BE3D-CDAA9F3214C8}
			Deployment Merge Module	{06A35CCD-C46D-44D5-987B-CF40FF872267}
			Deployment Cab	{3EA9E505-35AC-4774-B492-AD1749C4943A}
			Deployment Setup	{978C614F-708E-4E1A-B201-565925725DBA}
			Deployment Smart Device Cab	{AB322303-2255-48EF-A496-5904EB18DA55}
			Visual Studio Tools for Applications (VSTA)	{A860303F-1F3F-4691-B57E-529FC101A107}
			Visual Studio Tools for Office (VSTO)	{BAA0C2D2-18E2-41B9-852F-F413020CAA33}
			SharePoint Workflow	{F8810EC1-6754-47FC-A15F-DFABD2E3FA90}
			XNA (Windows)	{6D335F3A-9D43-41b4-9D22-F6F17C4BE596}
			XNA (XBox)	{2DF5C3F4-5A5F-47a9-8E94-23B4456F55E2}
			XNA (Zune)	{D399B71A-8929-442a-A9AC-8BEC78BB2433}
			SharePoint (VB.NET)	{EC05E597-79D4-47f3-ADA0-324C4F7C7484}
			SharePoint (C#)	{593B0543-81F6-4436-BA1E-4747859CAAE2}
			Silverlight	{A1591282-1198-4647-A2B1-27E5FF5F6F3B}
			ASP.NET MVC 1.0	{603C0E0B-DB56-11DC-BE95-000D561079B0}
			ASP.NET MVC 2.0	{F85E285D-A4E0-4152-9332-AB1D724D3325}
			ASP.NET MVC 3.0	{E53F8FEA-EAE0-44A6-8774-FFD645390401}
			ASP.NET MVC 4.0	{E3E379DF-F4C6-4180-9B81-6769533ABE47}
			Extensibility	{82B43B9B-A64C-4715-B499-D71E9CA2BD60}
			Store App Windows Phone 8.1	{76F1466A-8B6D-4E39-A767-685A06062A39}
			Store App Windows Phone 8.1 Silverlight (C#)	{C089C8C0-30E0-4E22-80C0-CE093F111A43}
			Store App Windows Phone 8.1 Silverlight (VB.NET)	{DB03555F-0C8B-43BE-9FF9-57896B3C5E56}
			Store App Windows 8.1	{BC8A1FFA-BEE3-4634-8014-F334798102B3}
			Store App Universal	{D954291E-2A0B-460D-934E-DC6B0785DB48}
			Store App Portable Universal	{786C830F-07A1-408B-BD7F-6EE04809D6DB}
			LightSwitch	{8BB0C5E8-0616-4F60-8E55-A43933E57E9C}
			LightSwitch Project	{581633EB-B896-402F-8E60-36F3DA191C85}
			Office/SharePoint App	{C1CDDADD-2546-481F-9697-4EA41081F2FC}
			";
	}
}
