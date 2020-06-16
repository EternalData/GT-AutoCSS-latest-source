using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000007 RID: 7
	public class Item : Control
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002361 File Offset: 0x00000561
		public int InvokeList()
		{
			return this.int_0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002369 File Offset: 0x00000569
		public void SelectList(int flagsconfig)
		{
			if (flagsconfig > base.Height)
			{
				flagsconfig = base.Height;
			}
			if (flagsconfig < 2)
			{
				base.Height = 1;
			}
			this.int_0 = flagsconfig;
			base.Invalidate();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002394 File Offset: 0x00000594
		public HorizontalAlignment CancelList()
		{
			return this.horizontalAlignment_0;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000239C File Offset: 0x0000059C
		public void VerifyList(HorizontalAlignment item)
		{
			this.horizontalAlignment_0 = item;
			base.Invalidate();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023AB File Offset: 0x000005AB
		protected override void OnHandleCreated(EventArgs key)
		{
			this.Dock = DockStyle.Fill;
			if (base.Parent is Form)
			{
				((Form)base.Parent).FormBorderStyle = FormBorderStyle.None;
			}
			base.OnHandleCreated(key);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00005C0C File Offset: 0x00003E0C
		protected override void OnMouseDown(MouseEventArgs instance)
		{
			if (new Rectangle(base.Parent.Location.X, base.Parent.Location.Y, base.Width - 1, this.int_0 - 1).IntersectsWith(new Rectangle(Control.MousePosition.X, Control.MousePosition.Y, 1, 1)))
			{
				base.Capture = false;
				Message message = Message.Create(base.Parent.Handle, 161, new IntPtr(2), new IntPtr(0));
				this.DefWndProc(ref message);
			}
			base.OnMouseDown(instance);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023D9 File Offset: 0x000005D9
		protected override void OnPaintBackground(PaintEventArgs i)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00005CB8 File Offset: 0x00003EB8
		protected override void OnPaint(PaintEventArgs spec)
		{
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.Clear(this.color_2);
					Tests.ValidateList(graphics, this.color_3, this.color_2, 0, 0, base.Width, this.int_0);
					SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
					int x = 6;
					if (this.horizontalAlignment_0 == HorizontalAlignment.Center)
					{
						x = base.Width / 2 - (int)sizeF.Width / 2;
					}
					if (this.horizontalAlignment_0 == HorizontalAlignment.Right)
					{
						x = base.Width - (int)sizeF.Width - 6;
					}
					Rectangle rectangle = new Rectangle(x, (this.int_0 + 2) / 2 - (int)sizeF.Height / 2, (int)sizeF.Width, (int)sizeF.Height);
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, this.color_0, this.color_2, LinearGradientMode.Vertical))
					{
						graphics.DrawString(this.Text, this.Font, linearGradientBrush, rectangle);
					}
					graphics.DrawLine(new Pen(this.color_2), 0, 1, base.Width, 1);
					Tests.OrderList(graphics, this.color_4, this.color_5, this.color_4, 0.5f, 0, 0, this.int_0 + 1, base.Width, 1);
					graphics.DrawLine(new Pen(this.color_3), 0, this.int_0, base.Width, this.int_0);
					graphics.DrawRectangle(new Pen(this.color_3), 0, 0, base.Width - 1, base.Height - 1);
					spec.Graphics.DrawImage((Image)bitmap.Clone(), 0f, 0f);
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005ED4 File Offset: 0x000040D4
		public Item()
		{
			Class21.smethod_0();
			this.int_0 = 25;
			this.horizontalAlignment_0 = HorizontalAlignment.Center;
			this.color_0 = Color.FromArgb(74, 74, 74);
			this.color_1 = Color.FromArgb(63, 63, 63);
			this.color_2 = Color.FromArgb(41, 41, 41);
			this.color_3 = Color.FromArgb(27, 27, 27);
			this.color_4 = Color.FromArgb(0, 0, 0, 0);
			this.color_5 = Color.FromArgb(25, 255, 255, 255);
			base..ctor();
		}

		// Token: 0x04000001 RID: 1
		private int int_0;

		// Token: 0x04000002 RID: 2
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x04000003 RID: 3
		private Color color_0;

		// Token: 0x04000004 RID: 4
		private Color color_1;

		// Token: 0x04000005 RID: 5
		private Color color_2;

		// Token: 0x04000006 RID: 6
		private Color color_3;

		// Token: 0x04000007 RID: 7
		private Color color_4;

		// Token: 0x04000008 RID: 8
		private Color color_5;
	}
}
