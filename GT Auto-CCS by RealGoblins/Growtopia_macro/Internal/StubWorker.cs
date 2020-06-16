using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200003B RID: 59
	public class StubWorker : ContainerControl
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x0000E6AC File Offset: 0x0000C8AC
		public StubWorker()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			base.Size = new Size(212, 104);
			this.MinimumSize = new Size(136, 50);
			base.Padding = new Padding(5, 28, 5, 5);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000E718 File Offset: 0x0000C918
		protected override void OnPaint(PaintEventArgs key)
		{
			base.OnPaint(key);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Rectangle rectangle = new Rectangle(51, 3, base.Width - 103, 18);
			Rectangle rectangle2 = new Rectangle(0, 0, base.Width - 1, base.Height - 10);
			graphics.Clear(Color.Transparent);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.FillPath(Brushes.White, Class6.smethod_0(new Rectangle(1, 12, base.Width - 3, rectangle2.Height - 1), 8));
			graphics.DrawPath(new Pen(Color.FromArgb(159, 159, 161)), Class6.smethod_0(new Rectangle(1, 12, base.Width - 3, base.Height - 13), 8));
			graphics.FillPath(Brushes.White, Class6.smethod_0(rectangle, 1));
			graphics.DrawPath(new Pen(Color.FromArgb(182, 180, 186)), Class6.smethod_0(rectangle, 4));
			graphics.DrawString(this.Text, new Font("Tahoma", 9f, FontStyle.Regular), new SolidBrush(Color.FromArgb(53, 53, 53)), rectangle, new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			});
			key.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}
	}
}
