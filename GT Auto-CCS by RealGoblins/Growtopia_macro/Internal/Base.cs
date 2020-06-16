using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000008 RID: 8
	public class Base : Control
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000023DB File Offset: 0x000005DB
		public int ForgotList()
		{
			return this.int_0;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023E3 File Offset: 0x000005E3
		public void SortList(int initY)
		{
			if (initY > base.Height)
			{
				initY = base.Height;
			}
			if (initY < 2)
			{
				base.Height = 1;
			}
			this.int_0 = initY;
			base.Invalidate();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000240E File Offset: 0x0000060E
		public HorizontalAlignment ConcatList()
		{
			return this.horizontalAlignment_0;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002416 File Offset: 0x00000616
		public void CallList(HorizontalAlignment res)
		{
			this.horizontalAlignment_0 = res;
			base.Invalidate();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023AB File Offset: 0x000005AB
		protected override void OnHandleCreated(EventArgs ident)
		{
			this.Dock = DockStyle.Fill;
			if (base.Parent is Form)
			{
				((Form)base.Parent).FormBorderStyle = FormBorderStyle.None;
			}
			base.OnHandleCreated(ident);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005F6C File Offset: 0x0000416C
		protected override void OnMouseDown(MouseEventArgs v)
		{
			if (new Rectangle(base.Parent.Location.X, base.Parent.Location.Y, base.Width - 1, this.int_0 - 1).IntersectsWith(new Rectangle(Control.MousePosition.X, Control.MousePosition.Y, 1, 1)))
			{
				base.Capture = false;
				Message message = Message.Create(base.Parent.Handle, 161, new IntPtr(2), new IntPtr(0));
				this.DefWndProc(ref message);
			}
			base.OnMouseDown(v);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023D9 File Offset: 0x000005D9
		protected override void OnPaintBackground(PaintEventArgs key)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00006018 File Offset: 0x00004218
		protected override void OnPaint(PaintEventArgs last)
		{
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.Clear(this.color_2);
					Tests.OrderList(graphics, this.color_1, this.color_2, this.color_0, 0.5f, 1, 0, 0, base.Width, this.int_0);
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(15, 255, 255, 255)), 1, 1, base.Width - 2, Convert.ToInt32((double)this.int_0 / 2.0) - 2);
					graphics.DrawRectangle(new Pen(Color.FromArgb(35, 255, 255, 255)), 1, 1, base.Width - 3, this.int_0 - 2);
					SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
					int num = 6;
					if (this.horizontalAlignment_0 == HorizontalAlignment.Center)
					{
						num = base.Width / 2 - (int)sizeF.Width / 2;
					}
					if (this.horizontalAlignment_0 == HorizontalAlignment.Right)
					{
						num = base.Width - (int)sizeF.Width - 14;
					}
					int num2 = Convert.ToInt32((double)this.int_0 / 2.0 - (double)((sizeF.Height + 4f) / 2f));
					Tests.ValidateList(graphics, this.color_2, this.color_1, num, num2, (int)sizeF.Width + 8, (int)sizeF.Height + 4);
					graphics.DrawRectangle(new Pen(this.color_2), (float)num, (float)num2, sizeF.Width + 7f, sizeF.Height + 3f);
					Rectangle rectangle = new Rectangle(num + 4, Convert.ToInt32((float)(this.int_0 / 2) - sizeF.Height / 2f), (int)sizeF.Width, (int)sizeF.Height);
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, this.color_0, this.color_1, LinearGradientMode.Vertical))
					{
						graphics.DrawString(this.Text, this.Font, linearGradientBrush, rectangle);
					}
					graphics.DrawRectangle(new Pen(this.color_0), 1, this.int_0 + 1, base.Width - 3, base.Height - this.int_0 - 3);
					graphics.DrawLine(new Pen(this.color_3), 0, this.int_0, base.Width, this.int_0);
					graphics.DrawRectangle(new Pen(this.color_3), 0, 0, base.Width - 1, base.Height - 1);
					last.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00006328 File Offset: 0x00004528
		public Base()
		{
			Class21.smethod_0();
			this.int_0 = 25;
			this.horizontalAlignment_0 = HorizontalAlignment.Center;
			this.color_0 = Color.FromArgb(0, 70, 114);
			this.color_1 = Color.FromArgb(0, 47, 78);
			this.color_2 = Color.FromArgb(0, 34, 57);
			this.color_3 = Color.FromArgb(0, 30, 50);
			base..ctor();
		}

		// Token: 0x04000009 RID: 9
		private int int_0;

		// Token: 0x0400000A RID: 10
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x0400000B RID: 11
		private Color color_0;

		// Token: 0x0400000C RID: 12
		private Color color_1;

		// Token: 0x0400000D RID: 13
		private Color color_2;

		// Token: 0x0400000E RID: 14
		private Color color_3;
	}
}
