using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.WINFORMS.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("nn")]
		[UserScopedSetting]
		public string FLqW1
		{
			get
			{
				return (string)this["FLqW1"];
			}
			set
			{
				this["FLqW1"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("nn")]
		[UserScopedSetting]
		public string FLqW2
		{
			get
			{
				return (string)this["FLqW2"];
			}
			set
			{
				this["FLqW2"] = value;
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=PORTERIA-PC\\SQLEXPRESS;Initial Catalog=masterDBAC;Persist Security Info=True;User ID=sa;Password=a1")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string masterDBACConnectionString
		{
			get
			{
				return (string)this["masterDBACConnectionString"];
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Sistema de Control de Acceso NOHA")]
		[UserScopedSetting]
		public string Titulo
		{
			get
			{
				return (string)this["Titulo"];
			}
			set
			{
				this["Titulo"] = value;
			}
		}

		static Settings()
		{
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}

		public Settings()
		{
		}
	}
}