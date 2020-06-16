using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000030 RID: 48
	internal class Class8 : LinkLabel
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		public Class8()
		{
			Class21.smethod_0();
			base..ctor();
			this.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
			this.BackColor = Color.Transparent;
			base.LinkColor = Color.FromArgb(51, 153, 225);
			base.ActiveLinkColor = Color.FromArgb(0, 101, 202);
			base.VisitedLinkColor = Color.FromArgb(0, 101, 202);
			base.LinkBehavior = LinkBehavior.NeverUnderline;
		}
	}
}
