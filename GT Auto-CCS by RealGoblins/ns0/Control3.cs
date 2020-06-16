using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000E RID: 14
	internal class Control3 : Control2
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00006E8C File Offset: 0x0000508C
		public Control3()
		{
			Class21.smethod_0();
			base..ctor();
			base.method_0();
			this.BackColor = Color.FromArgb(41, 41, 41);
			this.ForeColor = Color.FromArgb(100, 100, 100);
			this.pen_0 = new Pen(Color.FromArgb(25, 25, 25));
			this.pen_1 = new Pen(Color.FromArgb(11, Color.White));
			this.color_0 = Color.FromArgb(41, 41, 41);
			this.color_1 = Color.FromArgb(51, 51, 51);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006F1C File Offset: 0x0000511C
		protected override void OnPaint(PaintEventArgs i)
		{
			if (this.updatableHelpCommandType_0 == (Control2.UpdatableHelpCommandType)2)
			{
				this.linearGradientBrush_0 = new LinearGradientBrush(base.ClientRectangle, this.color_0, this.color_1, LinearGradientMode.Vertical);
			}
			else
			{
				this.linearGradientBrush_0 = new LinearGradientBrush(base.ClientRectangle, this.color_1, this.color_0, LinearGradientMode.Vertical);
			}
			this.graphics_0.FillRectangle(this.linearGradientBrush_0, base.ClientRectangle);
			base.method_4(HorizontalAlignment.Center, new SolidBrush(this.ForeColor), 0);
			base.method_7(HorizontalAlignment.Left, 0);
			base.method_3(this.pen_0, this.pen_1, base.ClientRectangle);
			base.method_2(this.BackColor, base.ClientRectangle);
			i.Graphics.DrawImage(this.bitmap_0, 0, 0);
		}

		// Token: 0x0400002D RID: 45
		private Pen pen_0;

		// Token: 0x0400002E RID: 46
		private Pen pen_1;

		// Token: 0x0400002F RID: 47
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x04000030 RID: 48
		private Color color_0;

		// Token: 0x04000031 RID: 49
		private Color color_1;

		// Token: 0x04000032 RID: 50
		private Rectangle rectangle_0;
	}
}
