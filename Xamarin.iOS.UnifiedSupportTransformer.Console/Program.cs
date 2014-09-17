using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.iOS.UnifiedSupportTransformer
{
	class Program
	{
		static void Main(string[] args)
		{
			var options = new Options();
			if (CommandLine.Parser.Default.ParseArguments(args, options))
			{
				// Values are available here
				if (options.Verbose)
				{
					Console.WriteLine("Filename: {0}", options.InputFile);
				}
			}


			UnifiedSupportTransformer ust = new UnifiedSupportTransformer();

			string[] projects = ust.ProjectFiles();

			ust.CopyProjects();
			ust.TransformProjectsUnified();
			ust.TransformProjectsClassic();

			return;
		}
	}
}
