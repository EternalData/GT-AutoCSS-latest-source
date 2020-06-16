using System;
using System.Drawing;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200001F RID: 31
	public abstract class Interceptor
	{
		// Token: 0x060000CC RID: 204
		public abstract Color InvokeSpecification();

		// Token: 0x060000CD RID: 205
		public abstract Color SelectSpecification();

		// Token: 0x060000CE RID: 206
		public abstract Color PopSpecification();

		// Token: 0x060000CF RID: 207
		public abstract Color CancelSpecification();

		// Token: 0x060000D0 RID: 208
		public abstract Color VerifySpecification();

		// Token: 0x060000D1 RID: 209
		public abstract Color PrintSpecification();

		// Token: 0x060000D2 RID: 210
		public abstract Color ForgotSpecification();

		// Token: 0x060000D3 RID: 211
		public abstract Color SortSpecification();

		// Token: 0x060000D4 RID: 212
		public abstract Color PushSpecification();

		// Token: 0x060000D5 RID: 213
		public abstract Color ConcatSpecification();

		// Token: 0x060000D6 RID: 214
		public abstract Color CallSpecification();

		// Token: 0x060000D7 RID: 215
		public abstract Color ConnectSpecification();

		// Token: 0x060000D8 RID: 216 RVA: 0x00002354 File Offset: 0x00000554
		protected Interceptor()
		{
			Class21.smethod_0();
			base..ctor();
		}
	}
}
