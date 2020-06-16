using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000034 RID: 52
	[DefaultEvent("TextChanged")]
	internal class Control10 : Control
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000313B File Offset: 0x0000133B
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00003148 File Offset: 0x00001348
		public override string Text
		{
			get
			{
				return this.richTextBox_0.Text;
			}
			set
			{
				this.richTextBox_0.Text = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000315C File Offset: 0x0000135C
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003164 File Offset: 0x00001364
		public void method_1(bool bool_3)
		{
			this.bool_0 = bool_3;
			if (this.richTextBox_0 != null)
			{
				this.richTextBox_0.ReadOnly = bool_3;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003181 File Offset: 0x00001381
		public bool method_2()
		{
			return this.bool_1;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00003189 File Offset: 0x00001389
		public void method_3(bool bool_3)
		{
			this.bool_1 = bool_3;
			if (this.richTextBox_0 != null)
			{
				this.richTextBox_0.WordWrap = bool_3;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000031A6 File Offset: 0x000013A6
		public bool method_4()
		{
			return this.bool_2;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000031AE File Offset: 0x000013AE
		public void method_5(bool bool_3)
		{
			this.bool_2 = bool_3;
			if (this.richTextBox_0 != null)
			{
				this.richTextBox_0.AutoWordSelection = bool_3;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000031CB File Offset: 0x000013CB
		protected override void OnForeColorChanged(EventArgs instance)
		{
			base.OnForeColorChanged(instance);
			this.richTextBox_0.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000031EB File Offset: 0x000013EB
		protected override void OnFontChanged(EventArgs var1)
		{
			base.OnFontChanged(var1);
			this.richTextBox_0.Font = this.Font;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00003007 File Offset: 0x00001207
		protected override void OnPaintBackground(PaintEventArgs var1)
		{
			base.OnPaintBackground(var1);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003205 File Offset: 0x00001405
		protected override void OnSizeChanged(EventArgs i)
		{
			base.OnSizeChanged(i);
			this.richTextBox_0.Size = new Size(base.Width - 13, base.Height - 11);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000D62C File Offset: 0x0000B82C
		protected override void OnResize(EventArgs first)
		{
			base.OnResize(first);
			this.graphicsPath_0 = new GraphicsPath();
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003230 File Offset: 0x00001430
		public void Control10_TextChanged(object sender, EventArgs e)
		{
			this.richTextBox_0.Text = this.Text;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		public void method_6()
		{
			RichTextBox richTextBox = this.richTextBox_0;
			richTextBox.BackColor = Color.Black;
			richTextBox.Size = new Size(base.Width - 10, 100);
			richTextBox.Location = new Point(7, 5);
			richTextBox.Text = string.Empty;
			richTextBox.BorderStyle = BorderStyle.None;
			richTextBox.Font = new Font("Tahoma", 10f);
			richTextBox.Multiline = true;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000D740 File Offset: 0x0000B940
		public Control10()
		{
			Class21.smethod_0();
			this.richTextBox_0 = new RichTextBox();
			base..ctor();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.method_6();
			base.Controls.Add(this.richTextBox_0);
			this.BackColor = Color.Black;
			this.ForeColor = Color.White;
			this.Text = null;
			this.Font = new Font("Tahoma", 10f);
			base.Size = new Size(150, 100);
			this.method_3(true);
			this.method_5(false);
			this.DoubleBuffered = true;
			base.TextChanged += this.Control10_TextChanged;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		protected override void OnPaint(PaintEventArgs init)
		{
			base.OnPaint(init);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.Black);
			graphics.FillPath(Brushes.Black, this.graphicsPath_0);
			graphics.DrawPath(new Pen(Color.FromArgb(255, 255, 255)), this.graphicsPath_0);
			graphics.Dispose();
			init.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x040000D4 RID: 212
		public RichTextBox richTextBox_0;

		// Token: 0x040000D5 RID: 213
		private bool bool_0;

		// Token: 0x040000D6 RID: 214
		private bool bool_1;

		// Token: 0x040000D7 RID: 215
		private bool bool_2;

		// Token: 0x040000D8 RID: 216
		private GraphicsPath graphicsPath_0;
	}
}
