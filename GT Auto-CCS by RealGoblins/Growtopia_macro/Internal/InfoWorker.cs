using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000037 RID: 55
	public class InfoWorker : Control
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000332E File Offset: 0x0000152E
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00003336 File Offset: 0x00001536
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

		// Token: 0x060001BC RID: 444 RVA: 0x00003345 File Offset: 0x00001545
		public Color CloneTests()
		{
			return this.color_1;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000334D File Offset: 0x0000154D
		public void InitTests(Color instance)
		{
			this.color_1 = instance;
			base.Invalidate();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000335C File Offset: 0x0000155C
		public bool SearchTests()
		{
			return this.bool_0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00003364 File Offset: 0x00001564
		public void CreateTests(bool stripvar1)
		{
			this.bool_0 = stripvar1;
			base.Invalidate();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		public InfoWorker()
		{
			Class21.smethod_0();
			this.color_0 = Color.FromArgb(52, 52, 52);
			this.color_1 = Color.FromArgb(217, 217, 217);
			this.bool_0 = true;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(152, 38);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.FromArgb(52, 52, 52);
			this.Font = new Font("Segoe UI", 10f);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000E08C File Offset: 0x0000C28C
		protected override void OnResize(EventArgs item)
		{
			this.graphicsPath_0 = new GraphicsPath();
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(9, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(9, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
			base.OnResize(item);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000E138 File Offset: 0x0000C338
		protected override void OnPaint(PaintEventArgs var1)
		{
			base.OnPaint(var1);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(this.BackColor);
			graphics2.FillPath(new SolidBrush(this.color_1), this.graphicsPath_0);
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Rectangle(15, 4, base.Width - 17, base.Height - 5));
			if (this.bool_0)
			{
				Point[] points = new Point[]
				{
					new Point(9, base.Height - 19),
					new Point(0, base.Height - 25),
					new Point(9, base.Height - 30)
				};
				graphics2.FillPolygon(new SolidBrush(this.color_1), points);
				graphics2.DrawPolygon(new Pen(new SolidBrush(this.color_1)), points);
			}
			graphics.Dispose();
			var1.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			var1.Graphics.DrawImageUnscaled(bitmap, 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x040000E4 RID: 228
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000E5 RID: 229
		private Color color_0;

		// Token: 0x040000E6 RID: 230
		private Color color_1;

		// Token: 0x040000E7 RID: 231
		private bool bool_0;
	}
}
