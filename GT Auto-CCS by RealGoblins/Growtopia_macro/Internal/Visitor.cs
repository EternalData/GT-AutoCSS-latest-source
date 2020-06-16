using System;
using System.Windows.Forms;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000004 RID: 4
	public static class Visitor
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public static void WriteList(Control first, Control selection, string third)
		{
			if (selection.InvokeRequired)
			{
				Visitor.Delegate0 method = new Visitor.Delegate0(Visitor.WriteList);
				first.Invoke(method, new object[]
				{
					first,
					selection,
					third
				});
				return;
			}
			selection.Text = third;
		}

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000005 RID: 5
		private delegate void Delegate0(Form f, Control ctrl, string text);
	}
}
