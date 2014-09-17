# Xamarin.iOS Unified Support for components


# Unified GUIDs

1.	Library
	1.	iOS
		<ProjectTypeGuids>{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
	2.	Bindings project
	    <ProjectTypeGuids>{F5B4F3BC-B597-4E2B-B552-EF5D8A32436F};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
2.	Applications (exes)	
	Universal, iPhone and iPad
		<ProjectTypeGuids>{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>

## Xamarin.iOS Library Unified assembly

1.	Library
	1. 	Project modifications
		1.	rename existing *.csproj to *-Classic.csproj
		2.	copy to *-Classic.csproj to to *.csproj 
			unified=*.csproj
			classic will become obsolete with time
		3. 	open unified project file *.csproj
			1.	change project type to Xamarin iOS Unified Library project
				from:
				 <ProjectTypeGuids>*</ProjectTypeGuids>
				to:
				 <ProjectTypeGuids>{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
			2.	change references fro unified Support
				from:
					<Reference Include="monotouch" />
				to:
					<Reference Include="Xamarin.iOS" />
			3.	change targets for unified support
				from:
				<Import Project="$(MSBuildExtensionsPath)\Xamarin\iOS\Xamarin.MonoTouch.CSharp.targets" />
				to:
				<Import Project="$(MSBuildExtensionsPath)\Xamarin\iOS\Xamarin.iOS.CSharp.targets" />
			4.	preprocessor directive to support unified
				from:
					<DefineConstants>DEBUG</DefineConstants>
				to:
					<DefineConstants>DEBUG;__UNIFIED__</DefineConstants>
		4. open classic support *-Classic.csproj
			1.	change output folders to:
				<IntermediateOutputPath>obj\classic\$(Configuration)\</IntermediateOutputPath>
				so
				from:
					<ConsolePause>false</ConsolePause>
	    		to:
					<ConsolePause>false</ConsolePause>
	    			<IntermediateOutputPath>obj\unified\$(Configuration)\</IntermediateOutputPath>
	2.	Source code modifications
		1.	add following code in the files to fix usings
				#if __UNIFIED__
				using UIKit;
				using Foundation;
				using CoreAnimation;
				using CoreGraphics;
				#else
				using MonoTouch.UIKit;
				using MonoTouch.Foundation;
				using MonoTouch.CoreAnimation;
				using MonoTouch.CoreGraphics;

				using System.Drawing;
				using CGRect = global::System.Drawing.RectangleF;
				using CGPoint = global::System.Drawing.PointF;
				using CGSize = global::System.Drawing.SizeF;
				#endif
2.	Sample supporting Xamarin.ios unified




