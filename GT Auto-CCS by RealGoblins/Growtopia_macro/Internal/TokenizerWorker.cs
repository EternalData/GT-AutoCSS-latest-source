using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000027 RID: 39
	public class TokenizerWorker : Control
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0000B4C4 File Offset: 0x000096C4
		protected override void OnMouseClick(MouseEventArgs info)
		{
			base.OnMouseClick(info);
			if (this.int_0 > 0 & this.int_0 < 28)
			{
				base.FindForm().WindowState = FormWindowState.Minimized;
			}
			else if (this.int_0 > 30 & this.int_0 < 75)
			{
				base.FindForm().Close();
			}
			this.attributeToken_0 = (TokenizerWorker.AttributeToken)2;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002C46 File Offset: 0x00000E46
		protected override void OnMouseEnter(EventArgs instance)
		{
			base.OnMouseEnter(instance);
			this.attributeToken_0 = (TokenizerWorker.AttributeToken)1;
			base.Invalidate();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002C5C File Offset: 0x00000E5C
		protected override void OnMouseLeave(EventArgs key)
		{
			base.OnMouseLeave(key);
			this.attributeToken_0 = (TokenizerWorker.AttributeToken)0;
			base.Invalidate();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002C72 File Offset: 0x00000E72
		protected override void OnMouseUp(MouseEventArgs ident)
		{
			base.OnMouseUp(ident);
			this.attributeToken_0 = (TokenizerWorker.AttributeToken)1;
			base.Invalidate();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000B528 File Offset: 0x00009728
		protected override void OnMouseMove(MouseEventArgs item)
		{
			base.OnMouseMove(item);
			this.int_0 = item.Location.X;
			base.Invalidate();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002C88 File Offset: 0x00000E88
		protected override void OnResize(EventArgs last)
		{
			base.OnResize(last);
			base.Width = 77;
			base.Height = 19;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000B558 File Offset: 0x00009758
		public TokenizerWorker()
		{
			Class21.smethod_0();
			this.rectangle_0 = new Rectangle(28, 0, 47, 18);
			this.rectangle_1 = new Rectangle(0, 0, 28, 18);
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000B5BC File Offset: 0x000097BC
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			Point location = new Point(checked(base.FindForm().Width - 81), -1);
			base.Location = location;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000B5EC File Offset: 0x000097EC
		protected override void OnPaint(PaintEventArgs v)
		{
			base.OnPaint(v);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			GraphicsPath graphicsPath = new GraphicsPath();
			GraphicsPath graphicsPath2 = new GraphicsPath();
			graphicsPath.AddRectangle(this.rectangle_1);
			graphicsPath2.AddRectangle(this.rectangle_0);
			graphics.Clear(this.BackColor);
			TokenizerWorker.AttributeToken attributeToken = this.attributeToken_0;
			if (attributeToken != (TokenizerWorker.AttributeToken)0)
			{
				if (attributeToken != (TokenizerWorker.AttributeToken)1)
				{
					goto IL_44E;
				}
				if (this.int_0 > 0 & this.int_0 < 28)
				{
					LinearGradientBrush brush = new LinearGradientBrush(this.rectangle_1, Color.FromArgb(76, 76, 76, 76), Color.FromArgb(48, 48, 48), 90f);
					graphics.FillPath(brush, graphicsPath);
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath);
					graphics.DrawString("0", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.rectangle_1.Width - 22), (float)(this.rectangle_1.Height - 16));
					LinearGradientBrush brush2 = new LinearGradientBrush(this.rectangle_0, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
					graphics.FillPath(brush2, graphicsPath2);
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath2);
					graphics.DrawString("r", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.rectangle_0.Width - 4), (float)(this.rectangle_0.Height - 16));
					goto IL_44E;
				}
				if (this.int_0 > 30 & this.int_0 < 75)
				{
					LinearGradientBrush brush3 = new LinearGradientBrush(this.rectangle_0, Color.FromArgb(76, 76, 76, 76), Color.FromArgb(48, 48, 48), 90f);
					graphics.FillPath(brush3, graphicsPath2);
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath2);
					graphics.DrawString("r", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.rectangle_0.Width - 4), (float)(this.rectangle_0.Height - 16));
					LinearGradientBrush brush4 = new LinearGradientBrush(this.rectangle_1, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
					graphics.FillPath(brush4, Class6.smethod_0(this.rectangle_1, 1));
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath);
					graphics.DrawString("0", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.rectangle_1.Width - 22), (float)(this.rectangle_1.Height - 16));
					goto IL_44E;
				}
			}
			LinearGradientBrush brush5 = new LinearGradientBrush(this.rectangle_1, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
			graphics.FillPath(brush5, graphicsPath);
			graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath);
			graphics.DrawString("0", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.rectangle_1.Width - 22), (float)(this.rectangle_1.Height - 16));
			LinearGradientBrush brush6 = new LinearGradientBrush(this.rectangle_0, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
			graphics.FillPath(brush6, graphicsPath2);
			graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath2);
			graphics.DrawString("r", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.rectangle_0.Width - 4), (float)(this.rectangle_0.Height - 16));
			IL_44E:
			v.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			graphicsPath2.Dispose();
			graphicsPath.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x04000098 RID: 152
		private TokenizerWorker.AttributeToken attributeToken_0;

		// Token: 0x04000099 RID: 153
		private int int_0;

		// Token: 0x0400009A RID: 154
		private Rectangle rectangle_0;

		// Token: 0x0400009B RID: 155
		private Rectangle rectangle_1;

		// Token: 0x02000028 RID: 40
		public enum AttributeToken : byte
		{

		}
	}
}
