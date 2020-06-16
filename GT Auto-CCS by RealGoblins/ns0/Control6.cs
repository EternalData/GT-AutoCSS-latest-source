using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200002A RID: 42
	internal class Control6 : Control
	{
		// Token: 0x06000144 RID: 324 RVA: 0x0000BA78 File Offset: 0x00009C78
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

		// Token: 0x06000145 RID: 325 RVA: 0x0000BB60 File Offset: 0x00009D60
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

		// Token: 0x06000146 RID: 326 RVA: 0x00002D72 File Offset: 0x00000F72
		public Image method_1()
		{
			return this.image_0;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002D7A File Offset: 0x00000F7A
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

		// Token: 0x06000148 RID: 328 RVA: 0x00002DA5 File Offset: 0x00000FA5
		public StringAlignment method_3()
		{
			return this.stringAlignment_0;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002DAD File Offset: 0x00000FAD
		public void method_4(StringAlignment stringAlignment_1)
		{
			this.stringAlignment_0 = stringAlignment_1;
			base.Invalidate();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002DBC File Offset: 0x00000FBC
		protected Size method_5()
		{
			return this.size_0;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public ContentAlignment method_6()
		{
			return this.contentAlignment_0;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002DCC File Offset: 0x00000FCC
		public void method_7(ContentAlignment contentAlignment_1)
		{
			this.contentAlignment_0 = contentAlignment_1;
			base.Invalidate();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002DDB File Offset: 0x00000FDB
		protected override void OnMouseUp(MouseEventArgs instance)
		{
			this.int_0 = 0;
			base.Invalidate();
			base.OnMouseUp(instance);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002DF1 File Offset: 0x00000FF1
		protected override void OnMouseDown(MouseEventArgs v)
		{
			this.int_0 = 1;
			base.Invalidate();
			base.OnMouseDown(v);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002E07 File Offset: 0x00001007
		protected override void OnMouseLeave(EventArgs config)
		{
			this.int_0 = 0;
			base.Invalidate();
			base.OnMouseLeave(config);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002D63 File Offset: 0x00000F63
		protected override void OnTextChanged(EventArgs reference)
		{
			base.Invalidate();
			base.OnTextChanged(reference);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000C118 File Offset: 0x0000A318
		public Control6()
		{
			Class21.smethod_0();
			this.stringAlignment_0 = StringAlignment.Center;
			this.contentAlignment_0 = ContentAlignment.MiddleLeft;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 14f);
			this.ForeColor = Color.White;
			base.Size = new Size(166, 40);
			this.stringAlignment_0 = StringAlignment.Center;
			this.pen_0 = new Pen(Color.FromArgb(0, 118, 176));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		protected override void OnResize(EventArgs info)
		{
			base.OnResize(info);
			if (base.Width > 0 && base.Height > 0)
			{
				this.graphicsPath_0 = new GraphicsPath();
				this.rectangle_0 = new Rectangle(0, 0, base.Width, base.Height);
				this.linearGradientBrush_0 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(0, 176, 231), Color.FromArgb(0, 152, 224), 90f);
				this.linearGradientBrush_1 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(0, 118, 176), Color.FromArgb(0, 149, 222), 90f);
				this.linearGradientBrush_2 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(0, 118, 176), Color.FromArgb(0, 118, 176), 90f);
				this.pen_1 = new Pen(this.linearGradientBrush_2);
			}
			GraphicsPath graphicsPath = this.graphicsPath_0;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000C35C File Offset: 0x0000A55C
		protected override void OnPaint(PaintEventArgs spec)
		{
			Graphics graphics = spec.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = Control6.smethod_0(this.method_0(this.method_6()), base.Size, this.method_5());
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
						graphics.DrawImage(this.image_0, pointF.X, pointF.Y, (float)this.method_5().Width, (float)this.method_5().Height);
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
					graphics.DrawImage(this.image_0, pointF.X, pointF.Y, (float)this.method_5().Width, (float)this.method_5().Height);
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.rectangle_0, new StringFormat
					{
						Alignment = this.stringAlignment_0,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			base.OnPaint(spec);
		}

		// Token: 0x040000AA RID: 170
		private int int_0;

		// Token: 0x040000AB RID: 171
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000AC RID: 172
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x040000AD RID: 173
		private LinearGradientBrush linearGradientBrush_1;

		// Token: 0x040000AE RID: 174
		private LinearGradientBrush linearGradientBrush_2;

		// Token: 0x040000AF RID: 175
		private Rectangle rectangle_0;

		// Token: 0x040000B0 RID: 176
		private Pen pen_0;

		// Token: 0x040000B1 RID: 177
		private Pen pen_1;

		// Token: 0x040000B2 RID: 178
		private Image image_0;

		// Token: 0x040000B3 RID: 179
		private Size size_0;

		// Token: 0x040000B4 RID: 180
		private StringAlignment stringAlignment_0;

		// Token: 0x040000B5 RID: 181
		private ContentAlignment contentAlignment_0;
	}
}
