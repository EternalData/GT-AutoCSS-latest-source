using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000B RID: 11
	internal abstract class Control2 : Control
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000250B File Offset: 0x0000070B
		public Control2()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, true);
			this.bitmap_0 = new Bitmap(1, 1);
			this.graphics_0 = Graphics.FromImage(this.bitmap_0);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002542 File Offset: 0x00000742
		public void method_0()
		{
			base.SetStyle(ControlStyles.Opaque, false);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002558 File Offset: 0x00000758
		protected override void OnMouseLeave(EventArgs i)
		{
			this.method_1((Control2.UpdatableHelpCommandType)0);
			base.OnMouseLeave(i);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002568 File Offset: 0x00000768
		protected override void OnMouseEnter(EventArgs key)
		{
			this.method_1((Control2.UpdatableHelpCommandType)1);
			base.OnMouseEnter(key);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002578 File Offset: 0x00000778
		protected override void OnMouseUp(MouseEventArgs instance)
		{
			this.method_1((Control2.UpdatableHelpCommandType)1);
			base.OnMouseUp(instance);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002588 File Offset: 0x00000788
		protected override void OnMouseDown(MouseEventArgs first)
		{
			if (first.Button == MouseButtons.Left)
			{
				this.method_1((Control2.UpdatableHelpCommandType)2);
			}
			base.OnMouseDown(first);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000025A5 File Offset: 0x000007A5
		private void method_1(Control2.UpdatableHelpCommandType updatableHelpCommandType_1)
		{
			this.updatableHelpCommandType_0 = updatableHelpCommandType_1;
			base.Invalidate();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000069B0 File Offset: 0x00004BB0
		protected override void OnSizeChanged(EventArgs setup)
		{
			this.graphics_0.Dispose();
			this.bitmap_0.Dispose();
			this.bitmap_0 = new Bitmap(base.Width, base.Height);
			this.graphics_0 = Graphics.FromImage(this.bitmap_0);
			base.Invalidate();
			base.OnSizeChanged(setup);
		}

		// Token: 0x0600003A RID: 58
		protected abstract override void OnPaint(PaintEventArgs first);

		// Token: 0x0600003B RID: 59 RVA: 0x00006A08 File Offset: 0x00004C08
		public void method_2(Color color_0, Rectangle rectangle_0)
		{
			this.bitmap_0.SetPixel(rectangle_0.X, rectangle_0.Y, color_0);
			this.bitmap_0.SetPixel(rectangle_0.X + (rectangle_0.Width - 1), rectangle_0.Y, color_0);
			this.bitmap_0.SetPixel(rectangle_0.X, rectangle_0.Y + (rectangle_0.Height - 1), color_0);
			this.bitmap_0.SetPixel(rectangle_0.X + (rectangle_0.Width - 1), rectangle_0.Y + (rectangle_0.Height - 1), color_0);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006AA8 File Offset: 0x00004CA8
		public void method_3(Pen pen_0, Pen pen_1, Rectangle rectangle_0)
		{
			this.graphics_0.DrawRectangle(pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width - 1, rectangle_0.Height - 1);
			this.graphics_0.DrawRectangle(pen_1, rectangle_0.X + 1, rectangle_0.Y + 1, rectangle_0.Width - 3, rectangle_0.Height - 3);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006B14 File Offset: 0x00004D14
		public void method_4(HorizontalAlignment horizontalAlignment_0, Brush brush_0, int int_0 = 0)
		{
			if (string.IsNullOrEmpty(this.Text))
			{
				return;
			}
			this.size_0 = this.graphics_0.MeasureString(this.Text, this.Font).ToSize();
			switch (horizontalAlignment_0)
			{
			case HorizontalAlignment.Left:
				this.graphics_0.DrawString(this.Text, this.Font, brush_0, (float)(5 + int_0), (float)(base.Height / 2 - this.size_0.Height / 2));
				return;
			case HorizontalAlignment.Right:
				this.graphics_0.DrawString(this.Text, this.Font, brush_0, (float)(base.Width - 5 - this.size_0.Width - int_0), (float)(base.Height / 2 - this.size_0.Height / 2));
				return;
			case HorizontalAlignment.Center:
				this.graphics_0.DrawString(this.Text, this.Font, brush_0, (float)(base.Width / 2 - this.size_0.Width / 2), (float)(base.Height / 2 - this.size_0.Height / 2));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000025B4 File Offset: 0x000007B4
		public int \u3000\u000A()
		{
			if (this.image_0 == null)
			{
				return 0;
			}
			return this.image_0.Width;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000025CB File Offset: 0x000007CB
		public Image method_5()
		{
			return this.image_0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000025D3 File Offset: 0x000007D3
		public void method_6(Image image_1)
		{
			this.image_0 = image_1;
			base.Invalidate();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006C28 File Offset: 0x00004E28
		public void method_7(HorizontalAlignment horizontalAlignment_0, int int_0 = 0)
		{
			if (this.image_0 == null)
			{
				return;
			}
			switch (horizontalAlignment_0)
			{
			case HorizontalAlignment.Left:
				this.graphics_0.DrawImage(this.image_0, base.Width / 10 + int_0, base.Height / 2 - this.image_0.Height / 2);
				return;
			case HorizontalAlignment.Right:
				this.graphics_0.DrawImage(this.image_0, base.Width - base.Width / 10 - this.size_0.Width - int_0, base.Height / 2 - this.size_0.Height / 2);
				return;
			case HorizontalAlignment.Center:
				this.graphics_0.DrawImage(this.image_0, base.Width / 2 - this.size_0.Width / 2, base.Height / 2 - this.size_0.Height / 2);
				return;
			default:
				return;
			}
		}

		// Token: 0x04000021 RID: 33
		protected Bitmap bitmap_0;

		// Token: 0x04000022 RID: 34
		protected Graphics graphics_0;

		// Token: 0x04000023 RID: 35
		protected Control2.UpdatableHelpCommandType updatableHelpCommandType_0;

		// Token: 0x04000024 RID: 36
		private Size size_0;

		// Token: 0x04000025 RID: 37
		private Image image_0;

		// Token: 0x0200000C RID: 12
		public enum UpdatableHelpCommandType : byte
		{

		}
	}
}
