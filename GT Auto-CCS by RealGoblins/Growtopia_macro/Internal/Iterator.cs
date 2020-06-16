using System;
using System.Drawing;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000021 RID: 33
	public class Iterator : Strategy
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002963 File Offset: 0x00000B63
		public Iterator()
		{
			Class21.smethod_0();
			base..ctor();
			this.observer_0 = new Observer();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000297B File Offset: 0x00000B7B
		public override Interceptor PrepareSpecification()
		{
			return this.observer_0;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002983 File Offset: 0x00000B83
		public override Color CountSpecification()
		{
			return Color.FromArgb(246, 246, 246);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002999 File Offset: 0x00000B99
		public override Color RestartSpecification()
		{
			return Color.FromArgb(226, 226, 226);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002983 File Offset: 0x00000B83
		public override Color SetSpecification()
		{
			return Color.FromArgb(246, 246, 246);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002983 File Offset: 0x00000B83
		public override Color CollectSpecification()
		{
			return Color.FromArgb(246, 246, 246);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000029AF File Offset: 0x00000BAF
		public override Color EnableSpecification()
		{
			return Color.FromArgb(240, 240, 240);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000029C5 File Offset: 0x00000BC5
		public override Color VisitSpecification()
		{
			return Color.FromArgb(190, 195, 203);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000029AF File Offset: 0x00000BAF
		public override Color MoveSpecification()
		{
			return Color.FromArgb(240, 240, 240);
		}

		// Token: 0x04000080 RID: 128
		private Observer observer_0;
	}
}
