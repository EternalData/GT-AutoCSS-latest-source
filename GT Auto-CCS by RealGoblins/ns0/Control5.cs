using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000029 RID: 41
	internal class Control5 : Control
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000BA78 File Offset: 0x00009C78
		private static PointF smethod_0(StringFormat stringFormat_0, SizeF sizeF_0, SizeF sizeF_1)
		{
			PointF result = default(PointF);
			switch (stringFormat_0.Alignment)
			{
			case StringAlignment.Near:
				result.X = 2f;
				break;
			case StringAlignment.Center:
				result.X = Convert.ToSingle((sizeF_0.Width - sizeF_1.Width) / 2f);
				break;
			case StringAlignment.Far:
				result.X = sizeF_0.Width - sizeF_1.Width - 2f;
				break;
			}
			switch (stringFormat_0.LineAlignment)
			{
			case StringAlignment.Near:
				result.Y = 2f;
				break;
			case StringAlignment.Center:
				result.Y = Convert.ToSingle((sizeF_0.Height - sizeF_1.Height) / 2f);
				break;
			case StringAlignment.Far:
				result.Y = sizeF_0.Height - sizeF_1.Height - 2f;
				break;
			}
			return result;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000BB60 File Offset: 0x00009D60
		private StringFormat method_0(ContentAlignment contentAlignment_1)
		{
			StringFormat stringFormat = new StringFormat();
			if (contentAlignment_1 <= ContentAlignment.MiddleCenter)
			{
				switch (contentAlignment_1)
				{
				case ContentAlignment.TopLeft:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Near;
					break;
				case ContentAlignment.TopCenter:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Center;
					break;
				case (ContentAlignment)3:
					break;
				case ContentAlignment.TopRight:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Far;
					break;
				default:
					if (contentAlignment_1 != ContentAlignment.MiddleLeft)
					{
						if (contentAlignment_1 == ContentAlignment.MiddleCenter)
						{
							stringFormat.LineAlignment = StringAlignment.Center;
							stringFormat.Alignment = StringAlignment.Center;
						}
					}
					else
					{
						stringFormat.LineAlignment = StringAlignment.Center;
						stringFormat.Alignment = StringAlignment.Near;
					}
					break;
				}
			}
			else if (contentAlignment_1 <= ContentAlignment.BottomLeft)
			{
				if (contentAlignment_1 != ContentAlignment.MiddleRight)
				{
					if (contentAlignment_1 == ContentAlignment.BottomLeft)
					{
						stringFormat.LineAlignment = StringAlignment.Far;
						stringFormat.Alignment = StringAlignment.Near;
					}
				}
				else
				{
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else if (contentAlignment_1 != ContentAlignment.BottomCenter)
			{
				if (contentAlignment_1 == ContentAlignment.BottomRight)
				{
					stringFormat.LineAlignment = StringAlignment.Far;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else
			{
				stringFormat.LineAlignment = StringAlignment.Far;
				stringFormat.Alignment = StringAlignment.Center;
			}
			return stringFormat;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002CA1 File Offset: 0x00000EA1
		public Image method_1()
		{
			return this.image_0;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002CA9 File Offset: 0x00000EA9
		public void method_2(Image image_1)
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
			base.Invalidate();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002CD4 File Offset: 0x00000ED4
		protected Size method_3()
		{
			return this.size_0;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002CDC File Offset: 0x00000EDC
		public ContentAlignment method_4()
		{
			return this.contentAlignment_0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public void method_5(ContentAlignment contentAlignment_1)
		{
			this.contentAlignment_0 = contentAlignment_1;
			base.Invalidate();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public StringAlignment method_6()
		{
			return this.stringAlignment_0;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002CFB File Offset: 0x00000EFB
		public void method_7(StringAlignment stringAlignment_1)
		{
			this.stringAlignment_0 = stringAlignment_1;
			base.Invalidate();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002D0A File Offset: 0x00000F0A
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002D12 File Offset: 0x00000F12
		public override Color ForeColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002D21 File Offset: 0x00000F21
		protected override void OnMouseUp(MouseEventArgs spec)
		{
			this.int_0 = 0;
			base.Invalidate();
			base.OnMouseUp(spec);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002D37 File Offset: 0x00000F37
		protected override void OnMouseDown(MouseEventArgs init)
		{
			this.int_0 = 1;
			base.Invalidate();
			base.OnMouseDown(init);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002D4D File Offset: 0x00000F4D
		protected override void OnMouseLeave(EventArgs first)
		{
			this.int_0 = 0;
			base.Invalidate();
			base.OnMouseLeave(first);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002D63 File Offset: 0x00000F63
		protected override void OnTextChanged(EventArgs task)
		{
			base.Invalidate();
			base.OnTextChanged(task);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000BC64 File Offset: 0x00009E64
		public Control5()
		{
			Class21.smethod_0();
			this.stringAlignment_0 = StringAlignment.Center;
			this.color_0 = Color.FromArgb(150, 150, 150);
			this.contentAlignment_0 = ContentAlignment.MiddleLeft;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.FromArgb(36, 36, 36);
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 12f);
			this.ForeColor = Color.FromArgb(255, 255, 255);
			base.Size = new Size(166, 40);
			this.stringAlignment_0 = StringAlignment.Center;
			this.pen_0 = new Pen(Color.FromArgb(36, 36, 36));
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000BD28 File Offset: 0x00009F28
		protected override void OnResize(EventArgs instance)
		{
			if (base.Width > 0 && base.Height > 0)
			{
				this.graphicsPath_0 = new GraphicsPath();
				this.rectangle_0 = new Rectangle(0, 0, base.Width, base.Height);
				this.linearGradientBrush_0 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(251, 251, 251), Color.FromArgb(225, 225, 225), 90f);
				this.linearGradientBrush_1 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(46, 46, 46), Color.FromArgb(46, 46, 46), 90f);
				this.linearGradientBrush_2 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(167, 167, 167), Color.FromArgb(167, 167, 167), 90f);
				this.pen_1 = new Pen(this.linearGradientBrush_2);
			}
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
			base.OnResize(instance);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		protected override void OnPaint(PaintEventArgs config)
		{
			Graphics graphics = config.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = Control5.smethod_0(this.method_0(this.method_4()), base.Size, this.method_3());
			int num = this.int_0;
			if (num != 0)
			{
				if (num == 1)
				{
					graphics.FillPath(this.linearGradientBrush_1, this.graphicsPath_0);
					graphics.DrawPath(this.pen_1, this.graphicsPath_0);
					if (this.method_1() == null)
					{
						graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.rectangle_0, new StringFormat
						{
							Alignment = this.stringAlignment_0,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawImage(this.image_0, pointF.X, pointF.Y, (float)this.method_3().Width, (float)this.method_3().Height);
						graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.rectangle_0, new StringFormat
						{
							Alignment = this.stringAlignment_0,
							LineAlignment = StringAlignment.Center
						});
					}
				}
			}
			else
			{
				graphics.FillPath(this.linearGradientBrush_0, this.graphicsPath_0);
				graphics.DrawPath(this.pen_0, this.graphicsPath_0);
				if (this.method_1() == null)
				{
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.rectangle_0, new StringFormat
					{
						Alignment = this.stringAlignment_0,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawImage(this.image_0, pointF.X, pointF.Y, (float)this.method_3().Width, (float)this.method_3().Height);
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.rectangle_0, new StringFormat
					{
						Alignment = this.stringAlignment_0,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			base.OnPaint(config);
		}

		// Token: 0x0400009D RID: 157
		private int int_0;

		// Token: 0x0400009E RID: 158
		private GraphicsPath graphicsPath_0;

		// Token: 0x0400009F RID: 159
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x040000A0 RID: 160
		private LinearGradientBrush linearGradientBrush_1;

		// Token: 0x040000A1 RID: 161
		private LinearGradientBrush linearGradientBrush_2;

		// Token: 0x040000A2 RID: 162
		private Rectangle rectangle_0;

		// Token: 0x040000A3 RID: 163
		private Pen pen_0;

		// Token: 0x040000A4 RID: 164
		private Pen pen_1;

		// Token: 0x040000A5 RID: 165
		private Image image_0;

		// Token: 0x040000A6 RID: 166
		private Size size_0;

		// Token: 0x040000A7 RID: 167
		private StringAlignment stringAlignment_0;

		// Token: 0x040000A8 RID: 168
		private Color color_0;

		// Token: 0x040000A9 RID: 169
		private ContentAlignment contentAlignment_0;
	}
}
