using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x0200008B RID: 139
	[DefaultMember("FullName")]
	[CompilerGenerated]
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	public interface IWshShortcut
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000532 RID: 1330
		[IndexerName("FullName")]
		[DispId(0)]
		string FullName { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(0)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000533 RID: 1331
		void _VtblGap1_2();

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000534 RID: 1332
		// (set) Token: 0x06000535 RID: 1333
		[DispId(1001)]
		string Description { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1001)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1001)] [param: In] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000536 RID: 1334
		// (set) Token: 0x06000537 RID: 1335
		[DispId(1002)]
		string Hotkey { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1002)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1002)] [param: In] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000538 RID: 1336
		void _VtblGap2_3();

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000539 RID: 1337
		// (set) Token: 0x0600053A RID: 1338
		[DispId(1005)]
		string TargetPath { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1005)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1005)] [param: In] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600053B RID: 1339
		void _VtblGap3_5();

		// Token: 0x0600053C RID: 1340
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2001)]
		void Save();
	}
}
