using System;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200004C RID: 76
	public class WrapperVisitor : ContextMenuStrip
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00003982 File Offset: 0x00001B82
		public WrapperVisitor()
		{
			Class21.smethod_0();
			base..ctor();
			this.ConcatMethod(new Reader());
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000396C File Offset: 0x00001B6C
		public Reader PushMethod()
		{
			return (Reader)base.Renderer;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003979 File Offset: 0x00001B79
		public void ConcatMethod(Reader param)
		{
			base.Renderer = param;
		}
	}
}
