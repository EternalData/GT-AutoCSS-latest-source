using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200003A RID: 58
	internal class Control11 : ContainerControl
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000E510 File Offset: 0x0000C710
		public Control11()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.Transparent;
			base.Size = new Size(187, 117);
			base.Padding = new Padding(5, 5, 5, 5);
			this.DoubleBuffered = true;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000E570 File Offset: 0x0000C770
		protected override void OnResize(EventArgs res)
		{
			base.OnResize(res);
			this.graphicsPath_0 = new GraphicsPath();
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000E614 File Offset: 0x0000C814
		protected override void OnPaint(PaintEventArgs ident)
		{
			base.OnPaint(ident);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(Brushes.White, this.graphicsPath_0);
			graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), this.graphicsPath_0);
			graphics.Dispose();
			ident.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x040000EC RID: 236
		private GraphicsPath graphicsPath_0;
	}
}
