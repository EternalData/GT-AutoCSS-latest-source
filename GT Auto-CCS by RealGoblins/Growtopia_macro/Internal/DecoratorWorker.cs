using System;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000039 RID: 57
	public class DecoratorWorker : Control
	{
		// Token: 0x060001CC RID: 460 RVA: 0x000033B8 File Offset: 0x000015B8
		public DecoratorWorker()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.Size = new Size(120, 10);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000033DD File Offset: 0x000015DD
		protected override void OnPaint(PaintEventArgs i)
		{
			base.OnPaint(i);
			i.Graphics.DrawLine(new Pen(Color.FromArgb(184, 183, 188)), 0, 5, base.Width, 5);
		}
	}
}
