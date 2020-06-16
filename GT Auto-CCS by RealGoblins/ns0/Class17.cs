using System;
using System.Reflection;

namespace ns0
{
	// Token: 0x0200008E RID: 142
	internal class Class17
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x0002C644 File Offset: 0x0002A844
		internal static void smethod_0(int int_0)
		{
			Type type = Class17.module_0.ResolveType(33554432 + int_0);
			foreach (FieldInfo fieldInfo in type.GetFields())
			{
				MethodInfo method = (MethodInfo)Class17.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002354 File Offset: 0x00000554
		public Class17()
		{
			Class21.smethod_0();
			base..ctor();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00004FC3 File Offset: 0x000031C3
		// Note: this type is marked as 'beforefieldinit'.
		static Class17()
		{
			Class21.smethod_0();
			Class17.module_0 = typeof(Class17).Assembly.ManifestModule;
		}

		// Token: 0x0400034F RID: 847
		internal static Module module_0;

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000541 RID: 1345
		internal delegate void Delegate2(object o);
	}
}
