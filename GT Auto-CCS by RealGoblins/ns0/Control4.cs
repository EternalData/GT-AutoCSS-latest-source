using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000F RID: 15
	internal class Control4 : Control2
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00006FE0 File Offset: 0x000051E0
		public Control4()
		{
			Class21.smethod_0();
			this.color_0 = Color.FromArgb(90, Color.Black);
			this.color_1 = Color.FromArgb(14, Color.White);
			base..ctor();
			base.method_0();
			this.BackColor = Color.Transparent;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000025E2 File Offset: 0x000007E2
		public Orientation method_8()
		{
			return this.orientation_0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025EA File Offset: 0x000007EA
		public void method_9(Orientation orientation_1)
		{
			this.orientation_0 = orientation_1;
			base.Invalidate();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000025F9 File Offset: 0x000007F9
		public Color method_10()
		{
			return this.color_0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002601 File Offset: 0x00000801
		public void method_11(Color color_2)
		{
			this.color_0 = color_2;
			base.Invalidate();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002610 File Offset: 0x00000810
		public Color method_12()
		{
			return this.color_1;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002618 File Offset: 0x00000818
		public void method_13(Color color_2)
		{
			this.color_1 = color_2;
			base.Invalidate();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007030 File Offset: 0x00005230
		protected override void OnPaint(PaintEventArgs param)
		{
			this.graphics_0.Clear(this.BackColor);
			if (this.orientation_0 == Orientation.Horizontal)
			{
				this.graphics_0.DrawLine(new Pen(this.color_0), 0, base.Height / 2, base.Width, base.Height / 2);
				this.graphics_0.DrawLine(new Pen(this.color_1), 0, base.Height / 2 + 1, base.Width, base.Height / 2 + 1);
			}
			else
			{
				this.graphics_0.DrawLine(new Pen(this.color_0), base.Width / 2, 0, base.Width / 2, base.Height);
				this.graphics_0.DrawLine(new Pen(this.color_1), base.Width / 2 + 1, 0, base.Width / 2 + 1, base.Height);
			}
			param.Graphics.DrawImage(this.bitmap_0, 0, 0);
		}

		// Token: 0x04000033 RID: 51
		private Orientation orientation_0;

		// Token: 0x04000034 RID: 52
		private Color color_0;

		// Token: 0x04000035 RID: 53
		private Color color_1;

		// Token: 0x04000036 RID: 54
		private Rectangle rectangle_0;

		// Token: 0x04000037 RID: 55
		private object object_0;

		// Token: 0x04000038 RID: 56
		private int int_0;
	}
}
