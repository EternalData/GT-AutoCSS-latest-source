using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200007F RID: 127
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class TestsToken
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x00002354 File Offset: 0x00000554
		internal TestsToken()
		{
			Class21.smethod_0();
			base..ctor();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00004814 File Offset: 0x00002A14
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResolveMap
		{
			get
			{
				if (TestsToken.resourceManager_0 == null)
				{
					TestsToken.resourceManager_0 = new ResourceManager("Growtopia_macro.Internal.TestsToken", typeof(TestsToken).Assembly);
				}
				return TestsToken.resourceManager_0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00004840 File Offset: 0x00002A40
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00004847 File Offset: 0x00002A47
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo RunMap
		{
			get
			{
				return TestsToken.cultureInfo_0;
			}
			set
			{
				TestsToken.cultureInfo_0 = value;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000484F File Offset: 0x00002A4F
		public static byte[] ChangeMap()
		{
			return (byte[])TestsToken.ResolveMap.GetObject("rasphone", TestsToken.cultureInfo_0);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000486A File Offset: 0x00002A6A
		public static string IncludeMap()
		{
			return TestsToken.ResolveMap.GetString("rasphone_txt", TestsToken.cultureInfo_0);
		}

		// Token: 0x04000337 RID: 823
		private static ResourceManager resourceManager_0;

		// Token: 0x04000338 RID: 824
		private static CultureInfo cultureInfo_0;
	}
}
