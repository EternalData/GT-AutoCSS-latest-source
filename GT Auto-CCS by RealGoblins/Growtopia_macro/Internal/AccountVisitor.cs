using System;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200004B RID: 75
	public class AccountVisitor : MenuStrip
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00003954 File Offset: 0x00001B54
		public AccountVisitor()
		{
			Class21.smethod_0();
			base..ctor();
			this.ForgotMethod(new Reader());
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000396C File Offset: 0x00001B6C
		public Reader PrintMethod()
		{
			return (Reader)base.Renderer;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003979 File Offset: 0x00001B79
		public void ForgotMethod(Reader res)
		{
			base.Renderer = res;
		}
	}
}
