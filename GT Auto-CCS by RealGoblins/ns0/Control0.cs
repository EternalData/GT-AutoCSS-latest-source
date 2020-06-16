using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000009 RID: 9
	internal abstract class Control0 : ContainerControl
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00006390 File Offset: 0x00004590
		public Control0()
		{
			Class21.smethod_0();
			this.bool_1 = true;
			this.int_0 = 24;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, true);
			this.bitmap_0 = new Bitmap(1, 1);
			this.graphics_0 = Graphics.FromImage(this.bitmap_0);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002425 File Offset: 0x00000625
		protected override void OnHandleCreated(EventArgs task)
		{
			this.Dock = DockStyle.Fill;
			this.bool_0 = (base.Parent is Form);
			if (this.bool_0)
			{
				base.ParentForm.FormBorderStyle = FormBorderStyle.None;
			}
			base.OnHandleCreated(task);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000245D File Offset: 0x0000065D
		public bool method_0()
		{
			return this.bool_1;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002465 File Offset: 0x00000665
		public void method_1(bool bool_6)
		{
			this.bool_1 = bool_6;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000246E File Offset: 0x0000066E
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002476 File Offset: 0x00000676
		public void method_3(int int_1)
		{
			this.int_0 = int_1;
			this.rectangle_0 = new Rectangle(7, 7, base.Width - 14, this.int_0);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000063E4 File Offset: 0x000045E4
		protected override void OnMouseDown(MouseEventArgs ident)
		{
			if (ident.Button != MouseButtons.Left)
			{
				return;
			}
			if (this.bool_0 && base.ParentForm.WindowState == FormWindowState.Maximized)
			{
				return;
			}
			if (this.rectangle_0.Contains(ident.Location))
			{
				this.intptr_0 = new IntPtr(2);
			}
			else
			{
				if (this.struct0_0.byte_0 == 0 | !this.bool_1)
				{
					return;
				}
				this.intptr_0 = new IntPtr((int)this.struct0_0.byte_0);
			}
			base.Capture = false;
			Message message = Message.Create(base.Parent.Handle, 161, this.intptr_0, IntPtr.Zero);
			this.DefWndProc(ref message);
			base.OnMouseDown(ident);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000064A0 File Offset: 0x000046A0
		private Control0.Struct0 method_4()
		{
			this.point_0 = base.PointToClient(Control.MousePosition);
			this.bool_2 = (this.point_0.X < 7);
			this.bool_3 = (this.point_0.X > base.Width - 7);
			this.bool_4 = (this.point_0.Y < 7);
			this.bool_5 = (this.point_0.Y > base.Height - 7);
			if (this.bool_2 & this.bool_4)
			{
				return new Control0.Struct0(Cursors.SizeNWSE, 13);
			}
			if (this.bool_2 & this.bool_5)
			{
				return new Control0.Struct0(Cursors.SizeNESW, 16);
			}
			if (this.bool_3 & this.bool_4)
			{
				return new Control0.Struct0(Cursors.SizeNESW, 14);
			}
			if (this.bool_3 & this.bool_5)
			{
				return new Control0.Struct0(Cursors.SizeNWSE, 17);
			}
			if (this.bool_2)
			{
				return new Control0.Struct0(Cursors.SizeWE, 10);
			}
			if (this.bool_3)
			{
				return new Control0.Struct0(Cursors.SizeWE, 11);
			}
			if (this.bool_4)
			{
				return new Control0.Struct0(Cursors.SizeNS, 12);
			}
			if (this.bool_5)
			{
				return new Control0.Struct0(Cursors.SizeNS, 15);
			}
			return new Control0.Struct0(Cursors.Default, 0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000065EC File Offset: 0x000047EC
		private void method_5()
		{
			this.struct0_1 = this.method_4();
			if (this.struct0_0.byte_0 == this.struct0_1.byte_0)
			{
				return;
			}
			this.struct0_0 = this.method_4();
			this.Cursor = this.struct0_0.cursor_0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000249B File Offset: 0x0000069B
		protected override void OnMouseMove(MouseEventArgs ident)
		{
			if (this.bool_1)
			{
				this.method_5();
			}
			base.OnMouseMove(ident);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000663C File Offset: 0x0000483C
		protected override void OnSizeChanged(EventArgs res)
		{
			this.rectangle_0 = new Rectangle(7, 7, base.Width - 14, this.int_0);
			this.graphics_0.Dispose();
			this.bitmap_0.Dispose();
			this.bitmap_0 = new Bitmap(base.Width, base.Height);
			this.graphics_0 = Graphics.FromImage(this.bitmap_0);
			base.Invalidate();
			base.OnSizeChanged(res);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000024B2 File Offset: 0x000006B2
		public void method_6(Color color_0)
		{
			if (this.bool_0)
			{
				base.ParentForm.TransparencyKey = color_0;
			}
		}

		// Token: 0x06000029 RID: 41
		protected abstract override void OnPaint(PaintEventArgs setup);

		// Token: 0x0600002A RID: 42 RVA: 0x000066B0 File Offset: 0x000048B0
		public void method_7(Color color_0, Rectangle rectangle_1)
		{
			this.bitmap_0.SetPixel(rectangle_1.X, rectangle_1.Y, color_0);
			this.bitmap_0.SetPixel(rectangle_1.X + (rectangle_1.Width - 1), rectangle_1.Y, color_0);
			this.bitmap_0.SetPixel(rectangle_1.X, rectangle_1.Y + (rectangle_1.Height - 1), color_0);
			this.bitmap_0.SetPixel(rectangle_1.X + (rectangle_1.Width - 1), rectangle_1.Y + (rectangle_1.Height - 1), color_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006750 File Offset: 0x00004950
		public void method_8(Pen pen_0, Pen pen_1, Rectangle rectangle_1)
		{
			this.graphics_0.DrawRectangle(pen_0, rectangle_1.X, rectangle_1.Y, rectangle_1.Width - 1, rectangle_1.Height - 1);
			this.graphics_0.DrawRectangle(pen_1, rectangle_1.X + 1, rectangle_1.Y + 1, rectangle_1.Width - 3, rectangle_1.Height - 3);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000067BC File Offset: 0x000049BC
		public void method_9(HorizontalAlignment horizontalAlignment_0, Brush brush_0, int int_1 = 0)
		{
			if (string.IsNullOrEmpty(this.Text))
			{
				return;
			}
			this.size_0 = this.graphics_0.MeasureString(this.Text, this.Font).ToSize();
			switch (horizontalAlignment_0)
			{
			case HorizontalAlignment.Left:
				this.graphics_0.DrawString(this.Text, this.Font, brush_0, (float)(5 + int_1), (float)(this.int_0 / 2 - this.size_0.Height / 2 + 7));
				return;
			case HorizontalAlignment.Right:
				this.graphics_0.DrawString(this.Text, this.Font, brush_0, (float)(base.Width - 5 - this.size_0.Width - int_1), (float)(this.int_0 / 2 - this.size_0.Height / 2 + 7));
				return;
			case HorizontalAlignment.Center:
				this.graphics_0.DrawString(this.Text, this.Font, brush_0, (float)(base.Width / 2 - this.size_0.Width / 2), (float)(this.int_0 / 2 - this.size_0.Height / 2 + 7));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024C8 File Offset: 0x000006C8
		public int method_10()
		{
			if (this.image_0 == null)
			{
				return 0;
			}
			return this.image_0.Width;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024DF File Offset: 0x000006DF
		public Image method_11()
		{
			return this.image_0;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000024E7 File Offset: 0x000006E7
		public void method_12(Image image_1)
		{
			this.image_0 = image_1;
			base.Invalidate();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000068D8 File Offset: 0x00004AD8
		public void method_13(HorizontalAlignment horizontalAlignment_0, int int_1 = 0)
		{
			if (this.image_0 == null)
			{
				return;
			}
			switch (horizontalAlignment_0)
			{
			case HorizontalAlignment.Left:
				this.graphics_0.DrawImage(this.image_0, 5 + int_1, this.int_0 / 2 - this.image_0.Height / 2 + 7);
				return;
			case HorizontalAlignment.Right:
				this.graphics_0.DrawImage(this.image_0, base.Width - 5 - this.size_0.Width - int_1, this.int_0 / 2 - this.size_0.Height / 2 + 7);
				return;
			case HorizontalAlignment.Center:
				this.graphics_0.DrawImage(this.image_0, base.Width / 2 - this.size_0.Width / 2, this.int_0 / 2 - this.size_0.Height / 2 + 7);
				return;
			default:
				return;
			}
		}

		// Token: 0x0400000F RID: 15
		protected Bitmap bitmap_0;

		// Token: 0x04000010 RID: 16
		protected Graphics graphics_0;

		// Token: 0x04000011 RID: 17
		private bool bool_0;

		// Token: 0x04000012 RID: 18
		private bool bool_1;

		// Token: 0x04000013 RID: 19
		private int int_0;

		// Token: 0x04000014 RID: 20
		private IntPtr intptr_0;

		// Token: 0x04000015 RID: 21
		private bool bool_2;

		// Token: 0x04000016 RID: 22
		private bool bool_3;

		// Token: 0x04000017 RID: 23
		private bool bool_4;

		// Token: 0x04000018 RID: 24
		private bool bool_5;

		// Token: 0x04000019 RID: 25
		private Point point_0;

		// Token: 0x0400001A RID: 26
		private Control0.Struct0 struct0_0;

		// Token: 0x0400001B RID: 27
		private Control0.Struct0 struct0_1;

		// Token: 0x0400001C RID: 28
		protected Rectangle rectangle_0;

		// Token: 0x0400001D RID: 29
		private Size size_0;

		// Token: 0x0400001E RID: 30
		private Image image_0;

		// Token: 0x0200000A RID: 10
		private struct Struct0
		{
			// Token: 0x06000031 RID: 49 RVA: 0x000024F6 File Offset: 0x000006F6
			public Struct0(Cursor item, byte position_token)
			{
				Class21.smethod_0();
				this.cursor_0 = item;
				this.byte_0 = position_token;
			}

			// Token: 0x0400001F RID: 31
			public readonly Cursor cursor_0;

			// Token: 0x04000020 RID: 32
			public readonly byte byte_0;
		}
	}
}
