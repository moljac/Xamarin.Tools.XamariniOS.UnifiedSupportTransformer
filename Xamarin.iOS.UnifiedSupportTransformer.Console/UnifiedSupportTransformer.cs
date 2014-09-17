using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace Xamarin.iOS.UnifiedSupportTransformer
{
	public partial class UnifiedSupportTransformer
	{
		string sourceDirectory = "original";
		string destinationDirectory = "transformed";

		public string[] ProjectFiles()
		{
			string [] fileEntries = Directory.GetFiles(sourceDirectory, "*.csproj", SearchOption.TopDirectoryOnly);
 
			return fileEntries;
		}

		public string[] CopyProjects()
		{
			List<string> projects_transformed = new List<string>();

			foreach(string file_csproj in this.ProjectFiles())
			{
				string file_csproj_classic = file_csproj
												.Replace(sourceDirectory + @"\", "")
												.Replace(".csproj", "-Classic.csproj")
												;
				string file_csproj_unified = file_csproj
												.Replace(sourceDirectory + @"\", "")
												;

				Console.WriteLine("file_csproj			= {0}", file_csproj);
				Console.WriteLine("file_csproj_classic	= {0}", file_csproj_classic);
				Console.WriteLine("file_csproj_unified	= {0}", file_csproj_unified);

				File.Copy
						(
						  file_csproj
						, Path.Combine(destinationDirectory, file_csproj_classic)
						, true // overwrite
						);

				File.Copy
						(
						  file_csproj
						, Path.Combine(destinationDirectory, file_csproj_unified)
						, true // overwrite
						);

			}

			return projects_transformed.ToArray();
		}


		public string[] TransformProjectsUnified()
		{
			List<string> projects_transformed = new List<string>();

			string [] csprojs_uniified = Directory.GetFiles(destinationDirectory, "*.csproj", SearchOption.TopDirectoryOnly);

			foreach (string csproj_unified in csprojs_uniified)
			{
				// stupid
				if (csproj_unified.Contains("-Classic.csproj"))
				{
					continue;
				};

				string csproj_unified_content = "";
				using (TextReader reader = File.OpenText(csproj_unified))
				{
					csproj_unified_content = reader.ReadToEnd();
				}



				XmlDocument doc = new XmlDocument();
				doc.LoadXml(csproj_unified_content);

				// needed to supress empty xmlns="" when adding nodes
				XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
				ns.AddNamespace("x", "http://schemas.microsoft.com/developer/msbuild/2003");

				XmlNode root = doc.DocumentElement;

				//---------------------------------------------------------------------
				XmlNodeList project_type_guids = doc.GetElementsByTagName("ProjectTypeGuids");
				XmlNode node1 = project_type_guids[0];
				node1.InnerText = "{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
				//---------------------------------------------------------------------

				//---------------------------------------------------------------------
				XmlNodeList references = doc.GetElementsByTagName("Reference");
				for (int i = 0; i < references.Count; i++)
				{
					XmlNode node = references[i];
					XmlAttribute attribute_include = node.Attributes["Include"];
					if (attribute_include.InnerText == "monotouch")
					{
						attribute_include.InnerText = "Xamarin.iOS";
					}
				}
				//---------------------------------------------------------------------

				//---------------------------------------------------------------------
				XmlNodeList target_import = doc.GetElementsByTagName("Import");
				XmlNode node3 = target_import[0];
				node3.Attributes["Project"].InnerText = @"$(MSBuildExtensionsPath)\Xamarin\iOS\Xamarin.iOS.CSharp.targets";
				//---------------------------------------------------------------------

				//---------------------------------------------------------------------
				XmlNodeList project_preprocessor = doc.GetElementsByTagName("DefineConstants");
				XmlNode node4 = project_preprocessor[0];
				node4.InnerText = "DEBUG;__UNIFIED__;";
				//---------------------------------------------------------------------

				//---------------------------------------------------------------------
				//string xpath = @"/Project/PropertyGroup[@Condition]";
				XmlNodeList property_groups = doc.GetElementsByTagName("PropertyGroup");
				for(int i =0; i<property_groups.Count; i++)
				{
					XmlNode n = property_groups[i];
					XmlAttribute xa = n.Attributes["Condition"];
					if (null != xa && xa.InnerText.Contains("Release"))
					{
						//Create a new node.
						XmlElement elem = doc.CreateElement("DefineConstants", "http://schemas.microsoft.com/developer/msbuild/2003");
						elem.InnerText = "__UNIFIED__;";

						//Add the node to the document.
						n.InsertAfter(elem, n.LastChild);
					}

					if (null != xa && (xa.InnerText.Contains("Release") || xa.InnerText.Contains("Debug")))
					{
						//Create a new node.
						XmlElement elem = doc.CreateElement("IntermediateOutputPath", "http://schemas.microsoft.com/developer/msbuild/2003");
						elem.InnerText = @"obj\unified\$(Configuration)\";

						//Add the node to the document.
						n.InsertAfter(elem, n.LastChild);
					}

				}
				//---------------------------------------------------------------------



				using (StringWriter stringWriter = new StringWriter())
				using (XmlWriter xmlTextWriter = XmlWriter.Create(stringWriter))
				{
					doc.WriteTo(xmlTextWriter);
					xmlTextWriter.Flush();
					string content = stringWriter.GetStringBuilder().ToString();
				} 
				
				doc.Save(Console.Out);
				doc.Save(csproj_unified);
			}
			return csprojs_uniified;




		}

		public string[] TransformProjectsClassic()
		{
			List<string> projects_transformed = new List<string>();

			string[] csprojs_uniified = Directory.GetFiles(destinationDirectory, "*.csproj", SearchOption.TopDirectoryOnly);

			foreach (string csproj_unified in csprojs_uniified)
			{
				// stupid
				if ( ! csproj_unified.Contains("-Classic.csproj"))
				{
					continue;
				};

				string csproj_classic_content = "";
				using (TextReader reader = File.OpenText(csproj_unified))
				{
					csproj_classic_content = reader.ReadToEnd();
				}


				XmlDocument doc = new XmlDocument();
				doc.LoadXml(csproj_classic_content);

				// needed to supress empty xmlns="" when adding nodes
				XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
				ns.AddNamespace("x", "http://schemas.microsoft.com/developer/msbuild/2003");

				XmlNode root = doc.DocumentElement;

	
				//---------------------------------------------------------------------
				//string xpath = @"/Project/PropertyGroup[@Condition]";
				XmlNodeList property_groups = doc.GetElementsByTagName("PropertyGroup");
				for (int i = 0; i < property_groups.Count; i++)
				{
					XmlNode n = property_groups[i];
					XmlAttribute xa = n.Attributes["Condition"];
					if (null != xa && (xa.InnerText.Contains("Release") || xa.InnerText.Contains("Debug")))
					{
						//Create a new node.
						XmlElement elem = doc.CreateElement("IntermediateOutputPath", "http://schemas.microsoft.com/developer/msbuild/2003");
						elem.InnerText = @"obj\classic\$(Configuration)\";

						//Add the node to the document.
						n.InsertAfter(elem, n.LastChild);
					}
				}
				//---------------------------------------------------------------------




				using (StringWriter stringWriter = new StringWriter())
				using (XmlWriter xmlTextWriter = XmlWriter.Create(stringWriter))
				{
					doc.WriteTo(xmlTextWriter);
					xmlTextWriter.Flush();
					string content = stringWriter.GetStringBuilder().ToString();
				}

				doc.Save(Console.Out);
				doc.Save(csproj_unified);
			}

			return csprojs_uniified;
		}
	}
}
