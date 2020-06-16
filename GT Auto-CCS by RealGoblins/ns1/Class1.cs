using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns0;

namespace ns1
{
	// Token: 0x02000014 RID: 20
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Class1
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00002354 File Offset: 0x00000554
		internal Class1()
		{
			Class21.smethod_0();
			base..ctor();
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000279C File Offset: 0x0000099C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				if (Class1.resourceManager_0 == null)
				{
					Class1.resourceManager_0 = new ResourceManager("Growtopia_macro.Properties.Resources", typeof(Class1).Assembly);
				}
				return Class1.resourceManager_0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000027CB File Offset: 0x000009CB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			set
			{
				Class1.cultureInfo_0 = value;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000027D3 File Offset: 0x000009D3
		internal static byte[] smethod_0()
		{
			return (byte[])Class1.ResourceManager_0.GetObject("bin", Class1.cultureInfo_0);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000027EE File Offset: 0x000009EE
		internal static string smethod_1()
		{
			return Class1.ResourceManager_0.GetString("oui", Class1.cultureInfo_0);
		}

		// Token: 0x04000056 RID: 86
		private static ResourceManager resourceManager_0;

		// Token: 0x04000057 RID: 87
		private static CultureInfo cultureInfo_0;
	}
}
