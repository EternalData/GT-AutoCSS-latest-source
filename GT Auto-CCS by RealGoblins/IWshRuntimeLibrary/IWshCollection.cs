using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000087 RID: 135
	[DefaultMember("Item")]
	[CompilerGenerated]
	[ComImport]
	[Guid("F935DC27-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	public interface IWshCollection : IEnumerable
	{
		// Token: 0x0600052E RID: 1326
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object Item([In] [MarshalAs(UnmanagedType.Struct)] ref object Index);
	}
}
