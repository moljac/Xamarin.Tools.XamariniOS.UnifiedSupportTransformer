using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;
using CommandLine.Text;

namespace Xamarin.iOS.UnifiedSupportTransformer
{
	public partial class Options
	{
		[Option('l', "library", Required = true, HelpText = "classic library")]
		public string InputFile { get; set; }

		[Option('s', "sample", Required=true, HelpText = "classic sample")]
		public bool Verbose { get; set; }

		[ParserState]
		public IParserState LastParserState { get; set; }

		[HelpOption]
		public string GetUsage()
		{
			return HelpText.AutoBuild(this,
			  (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
		}
	}
}
