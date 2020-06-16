using System;
using System.Drawing;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000020 RID: 32
	public abstract class Strategy
	{
		// Token: 0x060000D9 RID: 217
		public abstract Interceptor PrepareSpecification();

		// Token: 0x060000DA RID: 218
		public abstract Color CountSpecification();

		// Token: 0x060000DB RID: 219
		public abstract Color RestartSpecification();

		// Token: 0x060000DC RID: 220
		public abstract Color EnableSpecification();

		// Token: 0x060000DD RID: 221
		public abstract Color SetSpecification();

		// Token: 0x060000DE RID: 222
		public abstract Color CollectSpecification();

		// Token: 0x060000DF RID: 223
		public abstract Color VisitSpecification();

		// Token: 0x060000E0 RID: 224
		public abstract Color MoveSpecification();

		// Token: 0x060000E1 RID: 225 RVA: 0x00002354 File Offset: 0x00000554
		protected Strategy()
		{
			Class21.smethod_0();
			base..ctor();
		}
	}
}
