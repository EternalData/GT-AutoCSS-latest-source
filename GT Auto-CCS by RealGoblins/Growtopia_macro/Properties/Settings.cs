using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Properties
{
	// Token: 0x02000082 RID: 130
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00004D49 File Offset: 0x00002F49
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004D5B File Offset: 0x00002F5B
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public StringCollection SavedMacros
		{
			get
			{
				return (StringCollection)this["SavedMacros"];
			}
			set
			{
				this["SavedMacros"] = value;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00004DB3 File Offset: 0x00002FB3
		public Settings()
		{
			Class21.smethod_0();
			base..ctor();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000023D9 File Offset: 0x000005D9
		private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000023D9 File Offset: 0x000005D9
		private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00004DC0 File Offset: 0x00002FC0
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Class21.smethod_0();
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
