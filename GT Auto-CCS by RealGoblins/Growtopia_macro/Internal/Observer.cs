using System;
using System.Drawing;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000022 RID: 34
	public class Observer : Interceptor
	{
		// Token: 0x060000EB RID: 235 RVA: 0x000029DB File Offset: 0x00000BDB
		public override Color SortSpecification()
		{
			return Color.FromArgb(230, 230, 230);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000029DB File Offset: 0x00000BDB
		public override Color PushSpecification()
		{
			return Color.FromArgb(230, 230, 230);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000029F1 File Offset: 0x00000BF1
		public override Color PopSpecification()
		{
			return Color.FromArgb(180, 180, 180);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000029AF File Offset: 0x00000BAF
		public override Color CancelSpecification()
		{
			return Color.FromArgb(240, 240, 240);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002A07 File Offset: 0x00000C07
		public override Color VerifySpecification()
		{
			return Color.FromArgb(235, 235, 235);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000029DB File Offset: 0x00000BDB
		public override Color PrintSpecification()
		{
			return Color.FromArgb(230, 230, 230);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002A1D File Offset: 0x00000C1D
		public override Color ForgotSpecification()
		{
			return Color.FromArgb(232, 232, 232);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002A33 File Offset: 0x00000C33
		public override Color InvokeSpecification()
		{
			return Color.FromArgb(80, 80, 80);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002A40 File Offset: 0x00000C40
		public override Color SelectSpecification()
		{
			return Color.FromArgb(188, 199, 216);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002A56 File Offset: 0x00000C56
		public override Color ConcatSpecification()
		{
			return Color.LightGray;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002A5D File Offset: 0x00000C5D
		public override Color CallSpecification()
		{
			return Color.Black;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002A64 File Offset: 0x00000C64
		public override Color ConnectSpecification()
		{
			return Color.FromArgb(213, 220, 232);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002A7A File Offset: 0x00000C7A
		public Observer()
		{
			Class21.smethod_0();
			base..ctor();
		}
	}
}
