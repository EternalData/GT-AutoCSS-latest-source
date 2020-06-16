using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000033 RID: 51
	[DefaultEvent("TextChanged")]
	internal class Control9 : Control
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00003025 File Offset: 0x00001225
		public HorizontalAlignment method_0()
		{
			return this.horizontalAlignment_0;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000302D File Offset: 0x0000122D
		public void method_1(HorizontalAlignment horizontalAlignment_1)
		{
			this.horizontalAlignment_0 = horizontalAlignment_1;
			base.Invalidate();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000303C File Offset: 0x0000123C
		public int method_2()
		{
			return this.int_0;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003044 File Offset: 0x00001244
		public void method_3(int int_1)
		{
			this.int_0 = int_1;
			this.textBox_0.MaxLength = this.method_2();
			base.Invalidate();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003064 File Offset: 0x00001264
		public bool method_4()
		{
			return this.bool_2;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000306C File Offset: 0x0000126C
		public void method_5(bool bool_3)
		{
			this.textBox_0.UseSystemPasswordChar = this.method_4();
			this.bool_2 = bool_3;
			base.Invalidate();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000308C File Offset: 0x0000128C
		public bool method_6()
		{
			return this.bool_0;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003094 File Offset: 0x00001294
		public void method_7(bool bool_3)
		{
			this.bool_0 = bool_3;
			if (this.textBox_0 != null)
			{
				this.textBox_0.ReadOnly = bool_3;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000030B1 File Offset: 0x000012B1
		public bool method_8()
		{
			return this.bool_1;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000D274 File Offset: 0x0000B474
		public void method_9(bool bool_3)
		{
			this.bool_1 = bool_3;
			if (this.textBox_0 != null)
			{
				this.textBox_0.Multiline = bool_3;
				if (bool_3)
				{
					this.textBox_0.Height = base.Height - 10;
					return;
				}
				base.Height = this.textBox_0.Height + 10;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000030B9 File Offset: 0x000012B9
		protected override void OnTextChanged(EventArgs param)
		{
			base.OnTextChanged(param);
			this.textBox_0.Text = this.Text;
			base.Invalidate();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000030D9 File Offset: 0x000012D9
		private void textBox_0_TextChanged(object sender, EventArgs e)
		{
			this.Text = this.textBox_0.Text;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000030EC File Offset: 0x000012EC
		protected override void OnForeColorChanged(EventArgs res)
		{
			base.OnForeColorChanged(res);
			this.textBox_0.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000310C File Offset: 0x0000130C
		protected override void OnFontChanged(EventArgs ident)
		{
			base.OnFontChanged(ident);
			this.textBox_0.Font = this.Font;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003007 File Offset: 0x00001207
		protected override void OnPaintBackground(PaintEventArgs ident)
		{
			base.OnPaintBackground(ident);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000D2C8 File Offset: 0x0000B4C8
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

		// Token: 0x06000192 RID: 402 RVA: 0x0000D320 File Offset: 0x0000B520
		protected override void OnResize(EventArgs ident)
		{
			base.OnResize(ident);
			if (this.bool_1)
			{
				this.textBox_0.Height = base.Height - 10;
			}
			else
			{
				base.Height = this.textBox_0.Height + 10;
			}
			this.graphicsPath_0 = new GraphicsPath();
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003126 File Offset: 0x00001326
		protected override void OnGotFocus(EventArgs v)
		{
			base.OnGotFocus(v);
			this.textBox_0.Focus();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		public void method_10()
		{
			TextBox textBox = this.textBox_0;
			textBox.Size = new Size(base.Width - 10, 33);
			textBox.Location = new Point(7, 5);
			textBox.Text = string.Empty;
			textBox.BorderStyle = BorderStyle.None;
			textBox.TextAlign = HorizontalAlignment.Left;
			textBox.Font = new Font("Tahoma", 11f);
			textBox.UseSystemPasswordChar = this.method_4();
			textBox.Multiline = false;
			this.textBox_0.KeyDown += this.textBox_0_KeyDown;
			this.textBox_0.TextChanged += this.textBox_0_TextChanged;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000D498 File Offset: 0x0000B698
		public Control9()
		{
			Class21.smethod_0();
			this.textBox_0 = new TextBox();
			this.int_0 = 32767;
			base..ctor();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.method_10();
			base.Controls.Add(this.textBox_0);
			this.pen_0 = new Pen(Color.FromArgb(36, 36, 36));
			this.solidBrush_0 = new SolidBrush(Color.FromArgb(36, 36, 36));
			this.BackColor = Color.FromArgb(36, 36, 36);
			this.ForeColor = Color.FromArgb(36, 36, 36);
			this.Text = null;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(135, 33);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000D574 File Offset: 0x0000B774
		protected override void OnPaint(PaintEventArgs instance)
		{
			base.OnPaint(instance);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			TextBox textBox = this.textBox_0;
			textBox.Width = base.Width - 10;
			textBox.TextAlign = this.method_0();
			textBox.UseSystemPasswordChar = this.method_4();
			graphics.Clear(Color.FromArgb(36, 36, 36));
			graphics.FillPath(this.solidBrush_0, this.graphicsPath_0);
			graphics.DrawPath(this.pen_0, this.graphicsPath_0);
			instance.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000CB RID: 203
		public TextBox textBox_0;

		// Token: 0x040000CC RID: 204
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000CD RID: 205
		private int int_0;

		// Token: 0x040000CE RID: 206
		private bool bool_0;

		// Token: 0x040000CF RID: 207
		private bool bool_1;

		// Token: 0x040000D0 RID: 208
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x040000D1 RID: 209
		private bool bool_2;

		// Token: 0x040000D2 RID: 210
		private Pen pen_0;

		// Token: 0x040000D3 RID: 211
		private SolidBrush solidBrush_0;
	}
}
