using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000032 RID: 50
	[DefaultEvent("TextChanged")]
	internal class Control8 : Control
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00002EF6 File Offset: 0x000010F6
		public HorizontalAlignment method_0()
		{
			return this.horizontalAlignment_0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002EFE File Offset: 0x000010FE
		public void method_1(HorizontalAlignment horizontalAlignment_1)
		{
			this.horizontalAlignment_0 = horizontalAlignment_1;
			base.Invalidate();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002F0D File Offset: 0x0000110D
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002F15 File Offset: 0x00001115
		public void method_3(int int_1)
		{
			this.int_0 = int_1;
			this.textBox_0.MaxLength = this.method_2();
			base.Invalidate();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002F35 File Offset: 0x00001135
		public bool method_4()
		{
			return this.bool_2;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002F3D File Offset: 0x0000113D
		public void method_5(bool bool_3)
		{
			this.textBox_0.UseSystemPasswordChar = this.method_4();
			this.bool_2 = bool_3;
			base.Invalidate();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002F5D File Offset: 0x0000115D
		public bool method_6()
		{
			return this.bool_0;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002F65 File Offset: 0x00001165
		public void method_7(bool bool_3)
		{
			this.bool_0 = bool_3;
			if (this.textBox_0 != null)
			{
				this.textBox_0.ReadOnly = bool_3;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002F82 File Offset: 0x00001182
		public bool method_8()
		{
			return this.bool_1;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000CE30 File Offset: 0x0000B030
		public void method_9(bool bool_3)
		{
			this.bool_1 = bool_3;
			if (this.textBox_0 != null)
			{
				this.textBox_0.Multiline = bool_3;
				if (bool_3)
				{
					this.textBox_0.Height = base.Height - 23;
					return;
				}
				base.Height = this.textBox_0.Height + 23;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002F8A File Offset: 0x0000118A
		public Image method_10()
		{
			return this.image_0;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000CE84 File Offset: 0x0000B084
		public void method_11(Image image_1)
		{
			if (image_1 == null)
			{
				this.size_0 = Size.Empty;
			}
			else
			{
				this.size_0 = image_1.Size;
			}
			this.image_0 = image_1;
			if (this.method_10() == null)
			{
				this.textBox_0.Location = new Point(8, 10);
			}
			else
			{
				this.textBox_0.Location = new Point(35, 11);
			}
			base.Invalidate();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002F92 File Offset: 0x00001192
		protected Size method_12()
		{
			return this.size_0;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002F9A File Offset: 0x0000119A
		protected override void OnTextChanged(EventArgs key)
		{
			base.OnTextChanged(key);
			this.textBox_0.Text = this.Text;
			base.Invalidate();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002FBA File Offset: 0x000011BA
		private void textBox_0_TextChanged(object sender, EventArgs e)
		{
			this.Text = this.textBox_0.Text;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002FCD File Offset: 0x000011CD
		protected override void OnForeColorChanged(EventArgs last)
		{
			base.OnForeColorChanged(last);
			this.textBox_0.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002FED File Offset: 0x000011ED
		protected override void OnFontChanged(EventArgs init)
		{
			base.OnFontChanged(init);
			this.textBox_0.Font = this.Font;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003007 File Offset: 0x00001207
		protected override void OnPaintBackground(PaintEventArgs var1)
		{
			base.OnPaintBackground(var1);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		private void textBox_0_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				this.textBox_0.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				this.textBox_0.Copy();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000CF44 File Offset: 0x0000B144
		protected override void OnResize(EventArgs config)
		{
			base.OnResize(config);
			if (this.bool_1)
			{
				this.textBox_0.Height = base.Height - 23;
			}
			else
			{
				base.Height = this.textBox_0.Height + 23;
			}
			this.graphicsPath_0 = new GraphicsPath();
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003010 File Offset: 0x00001210
		protected override void OnGotFocus(EventArgs instance)
		{
			base.OnGotFocus(instance);
			this.textBox_0.Focus();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000D018 File Offset: 0x0000B218
		public void method_13()
		{
			TextBox textBox = this.textBox_0;
			textBox.Location = new Point(7, 10);
			textBox.Text = string.Empty;
			textBox.BorderStyle = BorderStyle.None;
			textBox.TextAlign = HorizontalAlignment.Left;
			textBox.Font = new Font("Tahoma", 11f);
			textBox.UseSystemPasswordChar = this.method_4();
			textBox.Multiline = false;
			this.textBox_0.KeyDown += this.textBox_0_KeyDown;
			this.textBox_0.TextChanged += this.textBox_0_TextChanged;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		public Control8()
		{
			Class21.smethod_0();
			this.textBox_0 = new TextBox();
			this.int_0 = 32767;
			base..ctor();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.method_13();
			base.Controls.Add(this.textBox_0);
			this.pen_0 = new Pen(Color.FromArgb(180, 180, 180));
			this.solidBrush_0 = new SolidBrush(Color.White);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.DimGray;
			this.Text = null;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(135, 43);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000D17C File Offset: 0x0000B37C
		protected override void OnPaint(PaintEventArgs i)
		{
			base.OnPaint(i);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (this.method_10() == null)
			{
				this.textBox_0.Width = base.Width - 18;
			}
			else
			{
				this.textBox_0.Width = base.Width - 45;
			}
			this.textBox_0.TextAlign = this.method_0();
			this.textBox_0.UseSystemPasswordChar = this.method_4();
			graphics.Clear(Color.Transparent);
			graphics.FillPath(this.solidBrush_0, this.graphicsPath_0);
			graphics.DrawPath(this.pen_0, this.graphicsPath_0);
			if (this.method_10() != null)
			{
				graphics.DrawImage(this.image_0, 5, 8, 24, 24);
			}
			i.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000C0 RID: 192
		public TextBox textBox_0;

		// Token: 0x040000C1 RID: 193
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000C2 RID: 194
		private int int_0;

		// Token: 0x040000C3 RID: 195
		private bool bool_0;

		// Token: 0x040000C4 RID: 196
		private bool bool_1;

		// Token: 0x040000C5 RID: 197
		private Image image_0;

		// Token: 0x040000C6 RID: 198
		private Size size_0;

		// Token: 0x040000C7 RID: 199
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x040000C8 RID: 200
		private bool bool_2;

		// Token: 0x040000C9 RID: 201
		private Pen pen_0;

		// Token: 0x040000CA RID: 202
		private SolidBrush solidBrush_0;
	}
}
