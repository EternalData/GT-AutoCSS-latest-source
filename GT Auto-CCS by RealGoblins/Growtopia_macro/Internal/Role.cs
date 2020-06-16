using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000025 RID: 37
	public class Role : ContainerControl
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public bool PrepareVisitor()
		{
			return this.bool_2;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public void CountVisitor(bool issetup)
		{
			this.bool_2 = issetup;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002B01 File Offset: 0x00000D01
		public bool EnableVisitor()
		{
			return this.bool_3;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002B09 File Offset: 0x00000D09
		public void SetVisitor(bool moveparam)
		{
			this.bool_3 = moveparam;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002B12 File Offset: 0x00000D12
		protected bool VisitVisitor()
		{
			return this.bool_4;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002B1A File Offset: 0x00000D1A
		protected bool UpdateVisitor()
		{
			return base.Parent != null && base.Parent.Parent != null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002B34 File Offset: 0x00000D34
		protected bool ReflectVisitor()
		{
			return this.bool_5;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002B3C File Offset: 0x00000D3C
		protected void ReadVisitor(bool isinstance)
		{
			this.bool_5 = isinstance;
			base.Invalidate();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002B4B File Offset: 0x00000D4B
		public FormStartPosition DestroyVisitor()
		{
			if (this.bool_4 && !this.bool_5)
			{
				return base.ParentForm.StartPosition;
			}
			return this.formStartPosition_0;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002B6F File Offset: 0x00000D6F
		public void PublishVisitor(FormStartPosition value)
		{
			this.formStartPosition_0 = value;
			if (this.bool_4 && !this.bool_5)
			{
				base.ParentForm.StartPosition = value;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000AB4C File Offset: 0x00008D4C
		protected sealed override void OnParentChanged(EventArgs res)
		{
			base.OnParentChanged(res);
			if (base.Parent == null)
			{
				return;
			}
			this.bool_4 = (base.Parent is Form);
			if (!this.bool_5)
			{
				this.method_4();
				if (this.bool_4)
				{
					base.ParentForm.FormBorderStyle = FormBorderStyle.None;
					base.ParentForm.TransparencyKey = Color.Fuchsia;
					if (!base.DesignMode)
					{
						base.ParentForm.Shown += this.method_0;
					}
				}
				base.Parent.BackColor = this.BackColor;
				base.Parent.MinimumSize = new Size(126, 39);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002B94 File Offset: 0x00000D94
		protected sealed override void OnSizeChanged(EventArgs first)
		{
			base.OnSizeChanged(first);
			if (!this.bool_5)
			{
				this.rectangle_0 = new Rectangle(0, 0, base.Width - 14, this.int_0 - 7);
			}
			base.Invalidate();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		protected override void OnMouseDown(MouseEventArgs asset)
		{
			base.OnMouseDown(asset);
			if (asset.Button == MouseButtons.Left)
			{
				this.method_1((Role.FlowDirectionValues)2);
			}
			if ((!this.bool_4 || base.ParentForm.WindowState != FormWindowState.Maximized) && !this.bool_5)
			{
				if (this.rectangle_0.Contains(asset.Location))
				{
					base.Capture = false;
					this.bool_10 = true;
					this.DefWndProc(ref this.message_0[0]);
					return;
				}
				if (this.bool_2 && this.int_2 != 0)
				{
					base.Capture = false;
					this.bool_10 = true;
					this.DefWndProc(ref this.message_0[this.int_2]);
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002BC9 File Offset: 0x00000DC9
		protected override void OnMouseUp(MouseEventArgs task)
		{
			base.OnMouseUp(task);
			this.bool_0 = false;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		protected override void OnMouseMove(MouseEventArgs setup)
		{
			base.OnMouseMove(setup);
			if ((!this.bool_4 || base.ParentForm.WindowState != FormWindowState.Maximized) && this.bool_2 && !this.bool_5)
			{
				this.method_3();
			}
			if (this.bool_0)
			{
				base.Parent.Location = (Point)(Convert.ToDouble(Control.MousePosition) - Convert.ToDouble(this.point_0));
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002BD9 File Offset: 0x00000DD9
		protected override void OnInvalidated(InvalidateEventArgs config)
		{
			base.OnInvalidated(config);
			base.ParentForm.Text = this.Text;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002BF3 File Offset: 0x00000DF3
		protected override void OnPaintBackground(PaintEventArgs info)
		{
			base.OnPaintBackground(info);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002BFC File Offset: 0x00000DFC
		protected override void OnTextChanged(EventArgs res)
		{
			base.OnTextChanged(res);
			base.Invalidate();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000AD24 File Offset: 0x00008F24
		private void method_0(object sender, EventArgs e)
		{
			if (!this.bool_5 && !this.bool_1)
			{
				if (this.formStartPosition_0 == FormStartPosition.CenterParent || this.formStartPosition_0 == FormStartPosition.CenterScreen)
				{
					Rectangle bounds = Screen.PrimaryScreen.Bounds;
					Rectangle bounds2 = base.ParentForm.Bounds;
					base.ParentForm.Location = new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2);
				}
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002C0B File Offset: 0x00000E0B
		private void method_1(Role.FlowDirectionValues flowDirectionValues_0)
		{
			this.visitorWorker = flowDirectionValues_0;
			base.Invalidate();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		private int method_2()
		{
			this.point_1 = base.PointToClient(Control.MousePosition);
			this.bool_6 = (this.point_1.X < 7);
			this.bool_7 = (this.point_1.X > base.Width - 7);
			this.bool_8 = (this.point_1.Y < 7);
			this.bool_9 = (this.point_1.Y > base.Height - 7);
			if (this.bool_6 && this.bool_8)
			{
				return 4;
			}
			if (this.bool_6 && this.bool_9)
			{
				return 7;
			}
			if (this.bool_7 && this.bool_8)
			{
				return 5;
			}
			if (this.bool_7 && this.bool_9)
			{
				return 8;
			}
			if (this.bool_6)
			{
				return 1;
			}
			if (this.bool_7)
			{
				return 2;
			}
			if (this.bool_8)
			{
				return 3;
			}
			if (this.bool_9)
			{
				return 6;
			}
			return 0;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000AE98 File Offset: 0x00009098
		private void method_3()
		{
			this.int_1 = this.method_2();
			if (this.int_1 == this.int_2)
			{
				return;
			}
			this.int_2 = this.int_1;
			int num = this.int_2;
			if (num == 0)
			{
				this.Cursor = Cursors.Default;
				return;
			}
			switch (num)
			{
			case 6:
				this.Cursor = Cursors.SizeNS;
				return;
			case 7:
				this.Cursor = Cursors.SizeNESW;
				return;
			case 8:
				this.Cursor = Cursors.SizeNWSE;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000AF1C File Offset: 0x0000911C
		private void method_4()
		{
			this.message_0[0] = Message.Create(base.Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
			for (int i = 1; i <= 8; i++)
			{
				this.message_0[i] = Message.Create(base.Parent.Handle, 161, new IntPtr(i + 9), IntPtr.Zero);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000AF90 File Offset: 0x00009190
		private void method_5(Rectangle rectangle_1)
		{
			if (base.Parent.Width > rectangle_1.Width)
			{
				base.Parent.Width = rectangle_1.Width;
			}
			if (base.Parent.Height > rectangle_1.Height)
			{
				base.Parent.Height = rectangle_1.Height;
			}
			int num = base.Parent.Location.X;
			int num2 = base.Parent.Location.Y;
			if (num < rectangle_1.X)
			{
				num = rectangle_1.X;
			}
			if (num2 < rectangle_1.Y)
			{
				num2 = rectangle_1.Y;
			}
			int num3 = rectangle_1.X + rectangle_1.Width;
			int num4 = rectangle_1.Y + rectangle_1.Height;
			if (num + base.Parent.Width > num3)
			{
				num = num3 - base.Parent.Width;
			}
			if (num2 + base.Parent.Height > num4)
			{
				num2 = num4 - base.Parent.Height;
			}
			base.Parent.Location = new Point(num, num2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000B0A8 File Offset: 0x000092A8
		protected override void WndProc(ref Message key)
		{
			base.WndProc(ref key);
			if (this.bool_10 && key.Msg == 513)
			{
				this.bool_10 = false;
				this.method_1((Role.FlowDirectionValues)1);
				if (!this.bool_3)
				{
					return;
				}
				if (this.UpdateVisitor())
				{
					this.method_5(new Rectangle(Point.Empty, base.Parent.Parent.Size));
					return;
				}
				this.method_5(Screen.FromControl(base.Parent).WorkingArea);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002C1A File Offset: 0x00000E1A
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			base.ParentForm.FormBorderStyle = FormBorderStyle.None;
			base.ParentForm.TransparencyKey = Color.Fuchsia;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002C3E File Offset: 0x00000E3E
		protected override void CreateHandle()
		{
			base.CreateHandle();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B128 File Offset: 0x00009328
		public Role()
		{
			Class21.smethod_0();
			this.point_0 = new Point(0, 0);
			this.bool_2 = true;
			this.message_0 = new Message[9];
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.Dock = DockStyle.Fill;
			this.int_0 = 25;
			base.Padding = new Padding(3, 28, 3, 28);
			this.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
			this.ForeColor = Color.FromArgb(142, 142, 142);
			this.BackColor = Color.FromArgb(246, 246, 246);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000B1E0 File Offset: 0x000093E0
		protected override void OnPaint(PaintEventArgs var1)
		{
			base.OnPaint(var1);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Rectangle rectangle = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			Color transparencyKey = base.ParentForm.TransparencyKey;
			graphics.SmoothingMode = SmoothingMode.Default;
			graphics.Clear(transparencyKey);
			graphics.FillPath(new SolidBrush(Color.FromArgb(52, 52, 52)), Class6.smethod_0(rectangle, 7));
			graphics.FillPath(new SolidBrush(Color.FromArgb(246, 246, 246)), Class6.smethod_0(new Rectangle(2, 20, base.Width - 5, base.Height - 42), 7));
			graphics.FillPath(new SolidBrush(Color.FromArgb(52, 52, 52)), Class6.smethod_0(new Rectangle(2, 2, base.Width / 2 + 2, 16), 7));
			graphics.FillPath(new SolidBrush(Color.FromArgb(52, 52, 52)), Class6.smethod_0(new Rectangle(base.Width / 2 - 3, 2, base.Width / 2, 16), 7));
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 52, 52)), new Rectangle(2, 15, base.Width - 5, 10));
			graphics.DrawPath(new Pen(Color.FromArgb(52, 52, 52)), Class6.smethod_0(new Rectangle(2, 2, base.Width - 5, base.Height - 5), 7));
			graphics.DrawPath(new Pen(Color.FromArgb(52, 52, 52)), Class6.smethod_0(rectangle, 7));
			graphics.DrawString(this.Text, new Font("Trebuchet MS", 10f, FontStyle.Bold), new SolidBrush(Color.FromArgb(221, 221, 221)), new Rectangle(7, 3, base.Width - 1, 22), new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Near
			});
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 52, 52)), 0, base.Height - 25, base.Width - 3, 20);
			graphics.DrawLine(new Pen(Color.FromArgb(52, 52, 52)), 5, base.Height - 5, base.Width - 6, base.Height - 5);
			graphics.DrawLine(new Pen(Color.FromArgb(52, 52, 52)), 7, base.Height - 4, base.Width - 7, base.Height - 4);
			graphics.DrawString(this.string_0, new Font("Trebuchet MS", 10f, FontStyle.Bold), new SolidBrush(Color.FromArgb(221, 221, 221)), 5f, (float)(base.Height - 23));
			var1.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x04000082 RID: 130
		private Point point_0;

		// Token: 0x04000083 RID: 131
		private bool bool_0;

		// Token: 0x04000084 RID: 132
		private int int_0;

		// Token: 0x04000085 RID: 133
		private string string_0;

		// Token: 0x04000086 RID: 134
		protected Role.FlowDirectionValues visitorWorker;

		// Token: 0x04000087 RID: 135
		private bool bool_1;

		// Token: 0x04000088 RID: 136
		private Rectangle rectangle_0;

		// Token: 0x04000089 RID: 137
		private bool bool_2;

		// Token: 0x0400008A RID: 138
		private bool bool_3;

		// Token: 0x0400008B RID: 139
		private bool bool_4;

		// Token: 0x0400008C RID: 140
		private bool bool_5;

		// Token: 0x0400008D RID: 141
		private FormStartPosition formStartPosition_0;

		// Token: 0x0400008E RID: 142
		private Point point_1;

		// Token: 0x0400008F RID: 143
		private bool bool_6;

		// Token: 0x04000090 RID: 144
		private bool bool_7;

		// Token: 0x04000091 RID: 145
		private bool bool_8;

		// Token: 0x04000092 RID: 146
		private bool bool_9;

		// Token: 0x04000093 RID: 147
		private int int_1;

		// Token: 0x04000094 RID: 148
		private int int_2;

		// Token: 0x04000095 RID: 149
		private Message[] message_0;

		// Token: 0x04000096 RID: 150
		private bool bool_10;

		// Token: 0x02000026 RID: 38
		public enum FlowDirectionValues
		{

		}
	}
}
