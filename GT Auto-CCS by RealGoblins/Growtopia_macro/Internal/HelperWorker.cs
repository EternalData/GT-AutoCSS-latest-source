using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000038 RID: 56
	public class HelperWorker : Control
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00003373 File Offset: 0x00001573
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000337B File Offset: 0x0000157B
		public override Color ForeColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000338A File Offset: 0x0000158A
		public Color CheckTests()
		{
			return this.color_1;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00003392 File Offset: 0x00001592
		public void GetTests(Color param)
		{
			this.color_1 = param;
			base.Invalidate();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000033A1 File Offset: 0x000015A1
		public bool RateTests()
		{
			return this.bool_0;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000033A9 File Offset: 0x000015A9
		public void InterruptTests(bool removevalue)
		{
			this.bool_0 = removevalue;
			base.Invalidate();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000E278 File Offset: 0x0000C478
		public HelperWorker()
		{
			Class21.smethod_0();
			this.color_0 = Color.FromArgb(52, 52, 52);
			this.color_1 = Color.FromArgb(192, 206, 215);
			this.bool_0 = true;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(152, 38);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.FromArgb(52, 52, 52);
			this.Font = new Font("Segoe UI", 10f);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000E318 File Offset: 0x0000C518
		protected override void OnResize(EventArgs init)
		{
			base.OnResize(init);
			this.graphicsPath_0 = new GraphicsPath();
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 18, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 18, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		protected override void OnPaint(PaintEventArgs v)
		{
			base.OnPaint(v);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(this.BackColor);
			graphics2.FillPath(new SolidBrush(this.color_1), this.graphicsPath_0);
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Rectangle(6, 4, base.Width - 15, base.Height));
			if (this.bool_0)
			{
				Point[] points = new Point[]
				{
					new Point(base.Width - 8, base.Height - 19),
					new Point(base.Width, base.Height - 25),
					new Point(base.Width - 8, base.Height - 30)
				};
				graphics2.FillPolygon(new SolidBrush(this.color_1), points);
				graphics2.DrawPolygon(new Pen(new SolidBrush(this.color_1)), points);
			}
			graphics.Dispose();
			v.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			v.Graphics.DrawImageUnscaled(bitmap, 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x040000E8 RID: 232
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000E9 RID: 233
		private Color color_0;

		// Token: 0x040000EA RID: 234
		private Color color_1;

		// Token: 0x040000EB RID: 235
		private bool bool_0;
	}
}
