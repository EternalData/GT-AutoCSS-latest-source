using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x0200008A RID: 138
	[CompilerGenerated]
	[ComImport]
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[TypeIdentifier]
	public interface IWshShell3 : IWshShell2
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600052F RID: 1327
		[DispId(100)]
		IWshCollection SpecialFolders { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(100)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000530 RID: 1328
		void _VtblGap1_3();

		// Token: 0x06000531 RID: 1329
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([In] [MarshalAs(UnmanagedType.BStr)] string PathLink);
	}
}
