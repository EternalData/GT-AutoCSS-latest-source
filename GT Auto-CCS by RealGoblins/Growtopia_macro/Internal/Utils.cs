using System;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000010 RID: 16
	public class Utils : Control
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00007128 File Offset: 0x00005328
		public Utils()
		{
			Class21.smethod_0();
			this.color_0 = Color.FromArgb(31, 31, 31);
			this.color_1 = Color.FromArgb(41, 41, 41);
			this.color_2 = Color.FromArgb(51, 51, 51);
			this.color_3 = Color.FromArgb(0, 0, 0, 0);
			this.color_4 = Color.FromArgb(25, 255, 255, 255);
			base..ctor();
			this.ForeColor = Color.FromArgb(65, 65, 65);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002627 File Offset: 0x00000827
		protected override void OnMouseEnter(EventArgs spec)
		{
			this.int_0 = 1;
			base.Invalidate();
			base.OnMouseEnter(spec);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000263D File Offset: 0x0000083D
		protected override void OnMouseDown(MouseEventArgs info)
		{
			this.int_0 = 2;
			base.Invalidate();
			base.OnMouseDown(info);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002653 File Offset: 0x00000853
		protected override void OnMouseLeave(EventArgs instance)
		{
			this.int_0 = 0;
			base.Invalidate();
			base.OnMouseLeave(instance);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002669 File Offset: 0x00000869
		protected override void OnMouseUp(MouseEventArgs instance)
		{
			this.int_0 = 1;
			base.Invalidate();
			base.OnMouseUp(instance);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000023D9 File Offset: 0x000005D9
		protected override void OnPaintBackground(PaintEventArgs setup)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000071B0 File Offset: 0x000053B0
		protected override void OnPaint(PaintEventArgs key)
		{
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.DrawRectangle(new Pen(this.color_0), 0, 0, base.Width - 1, base.Height - 1);
					if (this.int_0 == 2)
					{
						Tests.ValidateList(graphics, this.color_1, this.color_2, 1, 1, base.Width - 2, base.Height - 2);
					}
					else
					{
						Tests.ValidateList(graphics, this.color_2, this.color_1, 1, 1, base.Width - 2, base.Height - 2);
					}
					SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), (float)(base.Width / 2) - sizeF.Width / 2f, (float)(base.Height / 2) - sizeF.Height / 2f);
					Tests.OrderList(graphics, this.color_3, this.color_4, this.color_3, 0.5f, 0, 1, 1, base.Width - 2, 1);
					key.Graphics.DrawImage((Image)bitmap.Clone(), 0f, 0f);
				}
			}
		}

		// Token: 0x04000039 RID: 57
		private int int_0;

		// Token: 0x0400003A RID: 58
		private Color color_0;

		// Token: 0x0400003B RID: 59
		private Color color_1;

		// Token: 0x0400003C RID: 60
		private Color color_2;

		// Token: 0x0400003D RID: 61
		private Color color_3;

		// Token: 0x0400003E RID: 62
		private Color color_4;
	}
}
