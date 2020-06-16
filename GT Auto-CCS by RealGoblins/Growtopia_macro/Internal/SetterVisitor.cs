using System;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200004D RID: 77
	public class SetterVisitor : StatusStrip
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0000399A File Offset: 0x00001B9A
		public SetterVisitor()
		{
			Class21.smethod_0();
			base..ctor();
			this.PrepareMethod(new Reader());
			base.SizingGrip = false;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000396C File Offset: 0x00001B6C
		public Reader ConnectMethod()
		{
			return (Reader)base.Renderer;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003979 File Offset: 0x00001B79
		public void PrepareMethod(Reader task)
		{
			base.Renderer = task;
		}
	}
}
