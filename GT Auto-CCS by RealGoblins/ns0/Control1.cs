using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000D RID: 13
	internal class Control1 : Control0
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00006D08 File Offset: 0x00004F08
		public Control1()
		{
			Class21.smethod_0();
			base..ctor();
			base.method_3(28);
			this.ForeColor = Color.FromArgb(100, 100, 100);
			base.method_6(Color.Fuchsia);
			this.color_0 = Color.FromArgb(41, 41, 41);
			this.color_1 = Color.FromArgb(25, 25, 25);
			this.pen_0 = new Pen(Color.FromArgb(58, 58, 58));
			this.pen_1 = new Pen(this.color_1);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006D90 File Offset: 0x00004F90
		protected override void OnPaint(PaintEventArgs var1)
		{
			this.graphics_0.Clear(this.color_0);
			this.rectangle_1 = new Rectangle(0, 0, base.Width, 28);
			this.linearGradientBrush_0 = new LinearGradientBrush(this.rectangle_1, this.color_1, this.color_0, LinearGradientMode.Vertical);
			this.graphics_0.FillRectangle(this.linearGradientBrush_0, this.rectangle_1);
			this.graphics_0.DrawLine(this.pen_1, 0, 28, base.Width, 28);
			this.graphics_0.DrawLine(this.pen_0, 0, 29, base.Width, 29);
			base.method_9(HorizontalAlignment.Left, new SolidBrush(this.ForeColor), base.method_10());
			base.method_13(HorizontalAlignment.Left, 0);
			base.method_8(Pens.Black, this.pen_0, base.ClientRectangle);
			base.method_7(Color.Fuchsia, base.ClientRectangle);
			var1.Graphics.DrawImage(this.bitmap_0, 0, 0);
		}

		// Token: 0x04000027 RID: 39
		private Color color_0;

		// Token: 0x04000028 RID: 40
		private Color color_1;

		// Token: 0x04000029 RID: 41
		private Pen pen_0;

		// Token: 0x0400002A RID: 42
		private Pen pen_1;

		// Token: 0x0400002B RID: 43
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x0400002C RID: 44
		private Rectangle rectangle_1;
	}
}
