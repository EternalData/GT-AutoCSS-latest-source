using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000041 RID: 65
	internal class Control14 : Control
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000034CA File Offset: 0x000016CA
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000034DC File Offset: 0x000016DC
		public int Int32_0
		{
			get
			{
				if (this.int_0 == 0)
				{
					return 0;
				}
				return this.int_0;
			}
			set
			{
				if (value > this.int_1)
				{
					value = this.int_1;
				}
				this.int_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000034FC File Offset: 0x000016FC
		public int method_0()
		{
			return this.int_1;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00003504 File Offset: 0x00001704
		public void method_1(int int_2)
		{
			if (int_2 < this.int_0)
			{
				this.int_0 = int_2;
			}
			this.int_1 = int_2;
			base.Invalidate();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00003523 File Offset: 0x00001723
		public Control14()
		{
			Class21.smethod_0();
			this.int_1 = 99;
			base..ctor();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.Text = null;
			this.DoubleBuffered = true;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000355A File Offset: 0x0000175A
		protected override void OnResize(EventArgs ident)
		{
			base.OnResize(ident);
			base.Height = 20;
			base.Width = 20;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000EE2C File Offset: 0x0000D02C
		protected override void OnPaint(PaintEventArgs setup)
		{
			base.OnPaint(setup);
			Graphics graphics = setup.Graphics;
			string s = this.int_0.ToString();
			graphics.Clear(this.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(18, 20)), Color.FromArgb(197, 69, 68), Color.FromArgb(176, 52, 52), 90f);
			graphics.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(18, 18)));
			graphics.DrawEllipse(new Pen(Color.FromArgb(205, 70, 66)), new Rectangle(new Point(0, 0), new Size(18, 18)));
			graphics.DrawString(s, new Font("Segoe UI", 8f, FontStyle.Bold), new SolidBrush(Color.FromArgb(255, 255, 253)), new Rectangle(0, 0, base.Width - 2, base.Height), new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			});
			setup.Dispose();
		}

		// Token: 0x040000F6 RID: 246
		private int int_0;

		// Token: 0x040000F7 RID: 247
		private int int_1;
	}
}
