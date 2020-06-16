using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Properties
{
	// Token: 0x02000083 RID: 131
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Resources
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x00002354 File Offset: 0x00000554
		internal Resources()
		{
			Class21.smethod_0();
			base..ctor();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00004DDB File Offset: 0x00002FDB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager MapMap
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					Resources.resourceManager_0 = new ResourceManager("Growtopia_macro.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00004E07 File Offset: 0x00003007
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00004E0E File Offset: 0x0000300E
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo InsertDescriptor
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004E16 File Offset: 0x00003016
		public static Bitmap StopDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("24ZKkLo", Resources.cultureInfo_0);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00004E31 File Offset: 0x00003031
		public static Bitmap ValidateDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("Auto-CCS", Resources.cultureInfo_0);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00004E4C File Offset: 0x0000304C
		public static Bitmap InvokeDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("ezgif.com-video-to-gif (3)", Resources.cultureInfo_0);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00004E67 File Offset: 0x00003067
		public static Bitmap Help
		{
			get
			{
				return (Bitmap)Resources.MapMap.GetObject("Help", Resources.cultureInfo_0);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00004E82 File Offset: 0x00003082
		public static Bitmap CancelDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("Help (1)", Resources.cultureInfo_0);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00004E9D File Offset: 0x0000309D
		public static Bitmap PrintDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("Help (2)", Resources.cultureInfo_0);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00004EB8 File Offset: 0x000030B8
		public static Icon SortDescriptor()
		{
			return (Icon)Resources.MapMap.GetObject("image", Resources.cultureInfo_0);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00004ED3 File Offset: 0x000030D3
		public static Bitmap ConcatDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("imageedit_2_2770522804", Resources.cultureInfo_0);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00004EEE File Offset: 0x000030EE
		public static string ConnectDescriptor()
		{
			return Resources.MapMap.GetString("MouseHelp", Resources.cultureInfo_0);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00004F04 File Offset: 0x00003104
		public static Bitmap CountDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("oie_7191755e9GYUxNx (1)", Resources.cultureInfo_0);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00004F1F File Offset: 0x0000311F
		public static Bitmap EnableDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("output-onlinetexttools", Resources.cultureInfo_0);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00004F3A File Offset: 0x0000313A
		public static string CollectDescriptor()
		{
			return Resources.MapMap.GetString("PremiumInfo", Resources.cultureInfo_0);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00004F50 File Offset: 0x00003150
		public static string MoveDescriptor()
		{
			return Resources.MapMap.GetString("String1", Resources.cultureInfo_0);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00004F66 File Offset: 0x00003166
		public static string QueryDescriptor()
		{
			return Resources.MapMap.GetString("String2", Resources.cultureInfo_0);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00004F7C File Offset: 0x0000317C
		public static string ReadDescriptor()
		{
			return Resources.MapMap.GetString("String3", Resources.cultureInfo_0);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00004F92 File Offset: 0x00003192
		public static string DestroyDescriptor()
		{
			return Resources.MapMap.GetString("UnbannerHelp", Resources.cultureInfo_0);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00004FA8 File Offset: 0x000031A8
		public static Bitmap LoginDescriptor()
		{
			return (Bitmap)Resources.MapMap.GetObject("unnamed", Resources.cultureInfo_0);
		}

		// Token: 0x04000344 RID: 836
		private static ResourceManager resourceManager_0;

		// Token: 0x04000345 RID: 837
		private static CultureInfo cultureInfo_0;
	}
}
