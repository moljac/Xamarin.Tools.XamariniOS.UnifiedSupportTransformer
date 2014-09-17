using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.iOS.UnifiedSupportTransformer.ProjectFile
{

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/developer/msbuild/2003", IsNullable = false)]
	public partial class Project
	{

		private ProjectPropertyGroup[] propertyGroupField;

		private ProjectItemGroup[] itemGroupField;

		private ProjectImport importField;

		private string defaultTargetsField;

		private decimal toolsVersionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PropertyGroup")]
		public ProjectPropertyGroup[] PropertyGroup
		{
			get
			{
				return this.propertyGroupField;
			}
			set
			{
				this.propertyGroupField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemGroup")]
		public ProjectItemGroup[] ItemGroup
		{
			get
			{
				return this.itemGroupField;
			}
			set
			{
				this.itemGroupField = value;
			}
		}

		/// <remarks/>
		public ProjectImport Import
		{
			get
			{
				return this.importField;
			}
			set
			{
				this.importField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DefaultTargets
		{
			get
			{
				return this.defaultTargetsField;
			}
			set
			{
				this.defaultTargetsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal ToolsVersion
		{
			get
			{
				return this.toolsVersionField;
			}
			set
			{
				this.toolsVersionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroup
	{

		private bool debugSymbolsField;

		private bool debugSymbolsFieldSpecified;

		private string debugTypeField;

		private bool optimizeField;

		private bool optimizeFieldSpecified;

		private string outputPathField;

		private string defineConstantsField;

		private string errorReportField;

		private byte warningLevelField;

		private bool warningLevelFieldSpecified;

		private bool consolePauseField;

		private bool consolePauseFieldSpecified;

		private bool allowUnsafeBlocksField;

		private bool allowUnsafeBlocksFieldSpecified;

		private ProjectPropertyGroupConfiguration configurationField;

		private ProjectPropertyGroupPlatform platformField;

		private string projectTypeGuidsField;

		private string productVersionField;

		private decimal schemaVersionField;

		private bool schemaVersionFieldSpecified;

		private string projectGuidField;

		private string outputTypeField;

		private string rootNamespaceField;

		private string iPhoneResourcePrefixField;

		private string assemblyNameField;

		private string targetFrameworkIdentifierField;

		private string conditionField;

		/// <remarks/>
		public bool DebugSymbols
		{
			get
			{
				return this.debugSymbolsField;
			}
			set
			{
				this.debugSymbolsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DebugSymbolsSpecified
		{
			get
			{
				return this.debugSymbolsFieldSpecified;
			}
			set
			{
				this.debugSymbolsFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string DebugType
		{
			get
			{
				return this.debugTypeField;
			}
			set
			{
				this.debugTypeField = value;
			}
		}

		/// <remarks/>
		public bool Optimize
		{
			get
			{
				return this.optimizeField;
			}
			set
			{
				this.optimizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool OptimizeSpecified
		{
			get
			{
				return this.optimizeFieldSpecified;
			}
			set
			{
				this.optimizeFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string OutputPath
		{
			get
			{
				return this.outputPathField;
			}
			set
			{
				this.outputPathField = value;
			}
		}

		/// <remarks/>
		public string DefineConstants
		{
			get
			{
				return this.defineConstantsField;
			}
			set
			{
				this.defineConstantsField = value;
			}
		}

		/// <remarks/>
		public string ErrorReport
		{
			get
			{
				return this.errorReportField;
			}
			set
			{
				this.errorReportField = value;
			}
		}

		/// <remarks/>
		public byte WarningLevel
		{
			get
			{
				return this.warningLevelField;
			}
			set
			{
				this.warningLevelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool WarningLevelSpecified
		{
			get
			{
				return this.warningLevelFieldSpecified;
			}
			set
			{
				this.warningLevelFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool ConsolePause
		{
			get
			{
				return this.consolePauseField;
			}
			set
			{
				this.consolePauseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ConsolePauseSpecified
		{
			get
			{
				return this.consolePauseFieldSpecified;
			}
			set
			{
				this.consolePauseFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool AllowUnsafeBlocks
		{
			get
			{
				return this.allowUnsafeBlocksField;
			}
			set
			{
				this.allowUnsafeBlocksField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AllowUnsafeBlocksSpecified
		{
			get
			{
				return this.allowUnsafeBlocksFieldSpecified;
			}
			set
			{
				this.allowUnsafeBlocksFieldSpecified = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupConfiguration Configuration
		{
			get
			{
				return this.configurationField;
			}
			set
			{
				this.configurationField = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupPlatform Platform
		{
			get
			{
				return this.platformField;
			}
			set
			{
				this.platformField = value;
			}
		}

		/// <remarks/>
		public string ProjectTypeGuids
		{
			get
			{
				return this.projectTypeGuidsField;
			}
			set
			{
				this.projectTypeGuidsField = value;
			}
		}

		/// <remarks/>
		public string ProductVersion
		{
			get
			{
				return this.productVersionField;
			}
			set
			{
				this.productVersionField = value;
			}
		}

		/// <remarks/>
		public decimal SchemaVersion
		{
			get
			{
				return this.schemaVersionField;
			}
			set
			{
				this.schemaVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SchemaVersionSpecified
		{
			get
			{
				return this.schemaVersionFieldSpecified;
			}
			set
			{
				this.schemaVersionFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string ProjectGuid
		{
			get
			{
				return this.projectGuidField;
			}
			set
			{
				this.projectGuidField = value;
			}
		}

		/// <remarks/>
		public string OutputType
		{
			get
			{
				return this.outputTypeField;
			}
			set
			{
				this.outputTypeField = value;
			}
		}

		/// <remarks/>
		public string RootNamespace
		{
			get
			{
				return this.rootNamespaceField;
			}
			set
			{
				this.rootNamespaceField = value;
			}
		}

		/// <remarks/>
		public string IPhoneResourcePrefix
		{
			get
			{
				return this.iPhoneResourcePrefixField;
			}
			set
			{
				this.iPhoneResourcePrefixField = value;
			}
		}

		/// <remarks/>
		public string AssemblyName
		{
			get
			{
				return this.assemblyNameField;
			}
			set
			{
				this.assemblyNameField = value;
			}
		}

		/// <remarks/>
		public string TargetFrameworkIdentifier
		{
			get
			{
				return this.targetFrameworkIdentifierField;
			}
			set
			{
				this.targetFrameworkIdentifierField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroupConfiguration
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroupPlatform
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroup
	{

		private ProjectItemGroupObjcBindingCoreSource objcBindingCoreSourceField;

		private ProjectItemGroupObjcBindingApiDefinition objcBindingApiDefinitionField;

		private ProjectItemGroupFolder folderField;

		private ProjectItemGroupReference[] referenceField;

		/// <remarks/>
		public ProjectItemGroupObjcBindingCoreSource ObjcBindingCoreSource
		{
			get
			{
				return this.objcBindingCoreSourceField;
			}
			set
			{
				this.objcBindingCoreSourceField = value;
			}
		}

		/// <remarks/>
		public ProjectItemGroupObjcBindingApiDefinition ObjcBindingApiDefinition
		{
			get
			{
				return this.objcBindingApiDefinitionField;
			}
			set
			{
				this.objcBindingApiDefinitionField = value;
			}
		}

		/// <remarks/>
		public ProjectItemGroupFolder Folder
		{
			get
			{
				return this.folderField;
			}
			set
			{
				this.folderField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Reference")]
		public ProjectItemGroupReference[] Reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				this.referenceField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupObjcBindingCoreSource
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupObjcBindingApiDefinition
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupFolder
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupReference
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectImport
	{

		private string projectField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}
	}

}
